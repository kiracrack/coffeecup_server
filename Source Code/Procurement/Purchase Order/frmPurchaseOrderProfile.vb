Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.IO
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.GridColumnSummaryItem
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmPurchaseOrderProfile

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
    Private Function formatcurrency(ByVal i As Integer)
        GridView1.Columns(i).DisplayFormat.FormatType = FormatType.Numeric
        GridView1.Columns(i).DisplayFormat.FormatString = "n"
        Return 0
    End Function

    Private Sub frmPurchaseItems_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        pid.Text = "" : ponumber.Text = ""
    End Sub
    Private Sub frmPurchaseItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        'filter(pid.Text)
        filterApprovalLogs()
        'LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(GridView2)
        lblOffice.Text = GlobalOfficeCaption
        If Globalenablecreatedirectpo = True Then
            CorrectItemNameToolStripMenuItem.Visible = True
            EditSelectedItemToolStripMenuItem.Visible = True
        Else
            CorrectItemNameToolStripMenuItem.Visible = False
            EditSelectedItemToolStripMenuItem.Visible = False
        End If
        If mode.Text = "po" Then
            Me.Text = "Purchase Order"
            cmdPrint.Caption = "Print Purchase Order"
            lblProfile.Text = "PURCHASE ORDER"
        Else
            Me.Text = "Accounts Payable"
            cmdPrint.Caption = "Print Accounts Payable"
            lblProfile.Text = "ACCOUNTS PAYABLE"
        End If
    End Sub

    Private Sub ponumber_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ponumber.EditValueChanged
        If ponumber.Text = "" Then Exit Sub
        loaddetails(ponumber.Text)
    End Sub
    Public Function loaddetails(ByVal id As String)
        com.CommandText = "select *, ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where refnumber = tblpurchaseorder.ponumber or refnumber=tblpurchaseorder.requestref),'-') as 'Attachment',  " _
            + " (select companyname from tblglobalvendor where vendorid=tblpurchaseorder.vendorid) as Supplier, " _
            + " (select dateneeded from tblrequisitions where pid=tblpurchaseorder.requestref) as dateneeded, " _
            + " (select officename from tblcompoffice where officeid=tblpurchaseorder.officeid) as 'office', " & PurchaseOrderStatus.Remove(PurchaseOrderStatus.Length - 2, 2) & " from tblpurchaseorder where ponumber='" & id & "'"
        rst = com.ExecuteReader
        While rst.Read
            pid.Text = rst("requestref").ToString
            txtoffice.Text = rst("office").ToString
            officeid.Text = rst("officeid").ToString
            txtPayee.Text = rst("Supplier").ToString
            vendorid.Text = rst("vendorid").ToString
            txtTransactionDate.Text = rst("DateTrn").ToString
            paymentref.Text = rst("paymentrefnumber").ToString
            txtDateNeeded.Text = If(rst("dateneeded").ToString = "", "", CDate(rst("dateneeded").ToString).ToString("MMMM dd, yyyy"))
            txtStatus.Text = rst("Status").ToString
            txtNote.Text = rst("note").ToString
            txtTotalAmount.Text = FormatNumber(rst("Totalamount").ToString, 2)
            If rst("Attachment").ToString <> "-" Then
                cmdAttachment.Enabled = True
                cmdAttachment.Text = rst("Attachment").ToString
            Else
                cmdAttachment.Enabled = False
                cmdAttachment.Text = "Not Availaible"
            End If
        End While
        rst.Close()
        TextBoxColorCode(txtStatus)
        filterParticularItems()
        filterPaymentLogs()
        Return 0
    End Function
    Public Function filterParticularItems()
        LoadXgrid("Select trnid, productid, Quantity," _
                              + " UNIT as 'Unit', " _
                              + " ITEMNAME as 'Particular', " _
                              + " COST as 'Cost', " _
                              + " TOTAL as 'Total', " _
                              + " Remarks " _
                              + " from tblpurchaseorderitem " _
                              + " where ponumber='" & ponumber.Text & "' order by ITEMNAME asc", "tblpurchaseorderitem", Em, GridView1, Me)

        XgridHideColumn({"trnid", "productid"}, GridView1)
        XgridColCurrency({"Cost", "Total"}, GridView1)
        XgridColAlign({"Quantity", "Unit"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()

        GridView1.Columns("Particular").ColumnEdit = MemoEdit
        GridView1.Columns("Remarks").ColumnEdit = MemoEdit
        RemovedNoValueColumn("Remarks", GridView1, Me)
        GridView1.Columns("Total").Summary.Clear()
        GridView1.Columns("Total").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n}")
        CType(GridView1.Columns("Total").View, GridView).OptionsView.ShowFooter = True

        com.CommandText = "select * from tblcolumnindex where form='" & Me.Name & "' and gridview='" & GridView1.Name & "' order by colindex asc" : rst = com.ExecuteReader
        While rst.Read
            GridView1.Columns(rst("columnname").ToString).VisibleIndex = rst("colindex")
            If Val(rst("columnwidth").ToString) > 0 Then
                GridView1.Columns(rst("columnname").ToString).Width = Val(rst("columnwidth").ToString)
            End If

        End While
        rst.Close()

        Return 0
    End Function
     

    Private Sub GridView1_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles GridView1.ColumnWidthChanged
        UpdateGridColumnSetting(Me.Name, GridView1)
    End Sub

    Private Sub GridView1_DragObjectDrop(sender As Object, e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles GridView1.DragObjectDrop
        UpdateGridColumnSetting(Me.Name, GridView1)
    End Sub

    Public Sub filterPaymentLogs()
        LoadXgrid("select a.voucherno as 'Voucher No.', " _
                      + " date_format(b.voucherdate,'%Y-%m-%d') as 'Date', " _
                      + " a.Tax, " _
                      + " a.Amount, " _
                      + " (a.tax+a.Amount) as Total, b.Note, " _
                      + " date_format(b.datetrn,'%Y-%m-%d %r') as 'Date Posted', " _
                      + " (select fullname from tblaccounts where accountid=b.trnby) as 'Posted By' " _
                      + " from tbldisbursementdetails as a inner join tbldisbursementvoucher as b on a.voucherno=b.voucherno " _
                      + " WHERE a.ponumber = '" & ponumber.Text & "' order by b.datetrn asc", "tbldisbursementdetails", Em_Payment, gridpayment, Me)
        XgridColAlign({"Voucher No.", "Date", "Date Posted"}, gridpayment, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Tax", "Amount", "Total"}, gridpayment)
        XgridGeneralSummaryCurrency({"Total"}, gridpayment)
        gridpayment.BestFitColumns()
        XgridColWidth({"Tax", "Amount", "Total"}, gridpayment, 80)
    End Sub

    Public Sub filterApprovalLogs()
        LoadXgrid("select CONFIRMBY as 'Confirmed by', " _
                      + " Position as 'Position', " _
                      + " Remarks, " _
                      + " CONCAT(UCASE(SUBSTRING(tblapprovalhistory.`status`, 1, 1)),LOWER(SUBSTRING(tblapprovalhistory.`status`, 2)))  as 'Status', " _
                      + " appdescription as 'Transaction Type'," _
                      + " DATECONFIRM as 'Date Confirmed' " _
                      + " from tblapprovalhistory  " _
                      + " WHERE referenceno = '" & ponumber.Text & "' or referenceno = '" & pid.Text & "' or (referenceno='" & paymentref.Text & "' and approvaltype='payable' ) order by DATECONFIRM asc", "tblapprovalhistory", Bm, GridView2, Me)

        GridView2.Columns("Remarks").ColumnEdit = MemoEdit
        GridView2.Columns("Remarks").Width = 200
    End Sub
    Private Sub BarLargeButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filterParticularItems()
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        filterApprovalLogs()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        frmUserProfile.formatGrid(GridView2)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint.ItemClick
        If mode.Text = "po" Then
            PrintPurchaseOrder(ponumber.Text, Em)
        End If
        
    End Sub
    Private Function FillDatasetFromGrid() As DataSet
        Dim ds As New DataSet()
        Dim rowHandle As Integer
        Dim gridRow As DataRow
        For i As Integer = 0 To gridView1.RowCount - 1
            rowHandle = gridView1.GetVisibleRowHandle(i)
            If (Not gridView1.IsGroupRow(rowHandle)) Then
                gridRow = gridView1.GetDataRow(rowHandle)
                ds.Tables(0).Rows.Add(gridRow.ItemArray)
            End If
        Next i
        Return ds
    End Function
    Private Sub cmdAttachment_Click(sender As Object, e As EventArgs) Handles cmdAttachment.Click
        ViewAttachmentPackage_Database({ponumber.Text, pid.Text}, "")
    End Sub

    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If mode.Text = "po" Then
            PrintGeneralReport("Approval History", "PO Number " & ponumber.Text & " - " & txtoffice.Text, GridView2, Me)
        Else
            PrintGeneralReport("Approval History", "Accounts Payable Reference #" & ponumber.Text & " - " & txtoffice.Text, GridView2, Me)
        End If
    End Sub

    Private Sub CorrectItemNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorrectItemNameToolStripMenuItem.Click
        frmPOChangeProduct.ponumber.Text = ponumber.Text
        frmPOChangeProduct.trnid.Text = GridView1.GetFocusedRowCellValue("trnid").ToString
        frmPOChangeProduct.productid.Text = GridView1.GetFocusedRowCellValue("productid").ToString
        frmPOChangeProduct.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        filterPaymentLogs()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        GenerateApprovedAP(True, gridpayment.GetFocusedRowCellValue("Voucher No.").ToString, txtPayee.Text, frmAPSummaryList.GridView_Voucher, frmAPSummaryList.Em_Voucher, Me)
    End Sub

    Private Sub EditSelectedItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditSelectedItemToolStripMenuItem.Click
        frmDirectPOEditProduct.trnid.Text = GridView1.GetFocusedRowCellValue("trnid").ToString
        frmDirectPOEditProduct.ShowDialog()
    End Sub
End Class