Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid

Public Class frmBillingStatement
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then


        ElseIf keyData = (Keys.Control) + Keys.P Then
            GridView1.ShowRibbonPrintPreview()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPumpReading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        If mode.Text = "view" Then
            If countqry("tblsalesclientcharges", " accountno='" & accountno.Text & "' and cancelled=0 and verified=1 and paymentupdated=0") > 0 Then
                txtdateFrom.EditValue = CDate(qrysingledata("dt", "date_format(datetrn,'%Y,%m,%d') as dt", "where accountno='" & accountno.Text & "' and cancelled=0 and verified=1 and paymentupdated=0 order by datetrn desc", "tblsalesclientcharges"))
            Else
                txtdateFrom.EditValue = Now
            End If
        Else
            txtdateFrom.EditValue = Now
        End If
        txtDateTo.EditValue = Now
        FilterInvoices()
        If LCase(globaluser) = "root" Then
            tabRootCorrectTransaction.PageVisible = True
        Else
            tabRootCorrectTransaction.PageVisible = False
        End If
        '  LoadGridviewAppearance(GridView1)
    End Sub

    Public Sub FilterInvoices()
        If ckFilter.Checked = True Then
            FilterInvoiceTransaction()
        Else
            FilterDetailTransaction()
        End If
        If LCase(globaluser) = "root" Then
            LoadToComboBox("batchcode", " tblsalesclientcharges where accountno='" & accountno.Text & "' and  paymentupdated=0 and cancelled=0 and date_format(datetrn,'%Y-%m-%d') between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "'", txtBatchcode, True)
        End If
    End Sub
    
    Public Sub FilterDetailTransaction()
        Try
            dst = Nothing
            If accountno.Text = "" Then Exit Sub
            LoadXgrid("select  date_format(tblsalesclientchargesitem.datetrn, '%M %d, %Y') as 'Date', invoiceno as 'Invoice No.', productname as 'Product',Quantity,sellprice as 'Unit Cost', chargetotal as 'Charges', distotal as 'Discount', Total from tblsalesclientchargesitem inner join tblsalesclientcharges on tblsalesclientchargesitem.batchcode = tblsalesclientcharges.batchcode and tblsalesclientcharges.cancelled=0 where tblsalesclientchargesitem.cifid='" & accountno.Text & "' and date_format(tblsalesclientchargesitem.datetrn, '%Y-%m-%d') between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' and tblsalesclientchargesitem.cancelled=0 and  tblsalesclientcharges.verified=1 and tblsalesclientcharges.paymentupdated=0 order by tblsalesclientchargesitem.datetrn asc", "tblsalesclientchargesitem", Em, GridView1, Me)
            XgridColCurrency({"Unit Cost", "Quantity", "Charges", "Discount", "Total"}, GridView1)
            GridView1.BestFitColumns()
            XgridColWidth({"Total"}, GridView1, 120)
            XgridColAlign({"Date", "Invoice No.", "Quantity"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
            GridView1.Columns("Product").ColumnEdit = MemoEdit
            XgridGroupSummaryCurrency({"Total"}, GridView1)
            XgridGeneralSummaryCurrency({"Total"}, GridView1)

            com.CommandText = "select * from tblcolumnindex where form='" & Me.Name & "-details' and gridview='" & GridView1.Name & "' order by colindex asc" : rst = com.ExecuteReader
            While rst.Read
                GridView1.Columns(rst("columnname").ToString).VisibleIndex = rst("colindex")
                If Val(rst("columnwidth").ToString) > 0 Then
                    GridView1.Columns(rst("columnname").ToString).Width = Val(rst("columnwidth").ToString)
                End If
            End While
            rst.Close()

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                            & "Module:" & "form_load" & vbCrLf _
                            & "Message:" & errMYSQL.Message & vbCrLf _
                            & "Details:" & errMYSQL.StackTrace, _
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                            & "Module:" & "form_load" & vbCrLf _
                            & "Message:" & errMS.Message & vbCrLf _
                            & "Details:" & errMS.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub FilterInvoiceTransaction()
        Try
            dst = Nothing
            If accountno.Text = "" Then Exit Sub
            LoadXgrid("select date_format(datetrn, '%M %d, %Y') as 'Date', batchcode as 'Order Number', invoiceno as 'Invoice No.' ,if(paymentrefnumber<>'',(amount-(select paymentamount from tblpaymenttransactions where tblpaymenttransactions.trnid=tblsalesclientcharges.paymentrefnumber and cancelled=0)),amount) as 'Amount'  from tblsalesclientcharges where accountno='" & accountno.Text & "' and  paymentupdated=0 and cancelled=0 and date_format(datetrn,'%Y-%m-%d') between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' ", "tblsalesclientcharges", Em, GridView1, Me)
            XgridColCurrency({"Amount"}, GridView1)
            GridView1.BestFitColumns()
            XgridColWidth({"Amount"}, GridView1, 120)
            XgridColAlign({"Date", "Invoice No.", "Order Number"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

            XgridGroupSummaryCurrency({"Amount"}, GridView1)
            XgridGeneralSummaryCurrency({"Amount"}, GridView1)

            com.CommandText = "select * from tblcolumnindex where form='" & Me.Name & "-group' and gridview='" & GridView1.Name & "' order by colindex asc" : rst = com.ExecuteReader
            While rst.Read
                GridView1.Columns(rst("columnname").ToString).VisibleIndex = rst("colindex")
                If Val(rst("columnwidth").ToString) > 0 Then
                    GridView1.Columns(rst("columnname").ToString).Width = Val(rst("columnwidth").ToString)
                End If
            End While
            rst.Close()


        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                            & "Module:" & "form_load" & vbCrLf _
                            & "Message:" & errMYSQL.Message & vbCrLf _
                            & "Details:" & errMYSQL.StackTrace, _
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                            & "Module:" & "form_load" & vbCrLf _
                            & "Message:" & errMS.Message & vbCrLf _
                            & "Details:" & errMS.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "ROOT ACCESS"
    Private Sub txtBatchcode_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtBatchcode.SelectedValueChanged
        FilterRootTransaction()
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        FilterRootTransaction()
    End Sub

    Public Sub FilterRootTransaction()
        dst = Nothing
        If accountno.Text = "" And txtBatchcode.Text = "" Then Exit Sub
        If RadioGroup1.EditValue = 0 Then
            LoadXgrid("select trnid, Cancelled, date_format(datetrn, '%M %d, %Y') as 'Date', batchcode as 'Order Number', invoiceno as 'Invoice No.' , Amount  from tblsalesclientcharges where batchcode='" & txtBatchcode.Text & "'", "tblsalesclientcharges", EmRoot, gridRoot, Me)
            XgridColCurrency({"Amount"}, gridRoot)
            gridRoot.BestFitColumns()
            XgridHideColumn({"trnid"}, gridRoot)
            XgridColWidth({"Amount"}, gridRoot, 120)
            XgridColAlign({"Date", "Invoice No.", "Order Number"}, gridRoot, DevExpress.Utils.HorzAlignment.Center)
        ElseIf RadioGroup1.EditValue = 1 Then
            LoadXgrid("select  id, Cancelled, date_format(datetrn, '%M %d, %Y') as 'Date', productname as 'Product',Quantity,sellprice as 'Unit Cost', chargetotal as 'Charges', distotal as 'Discount', Total from tblsalesclientchargesitem  where batchcode='" & txtBatchcode.Text & "' order by datetrn asc", "tblsalesclientchargesitem", EmRoot, gridRoot, Me)
            XgridColCurrency({"Unit Cost", "Quantity", "Charges", "Discount", "Total"}, gridRoot)
            gridRoot.BestFitColumns()
            XgridHideColumn({"id"}, gridRoot)
            XgridColWidth({"Total"}, gridRoot, 120)
            XgridColAlign({"Date", "Batchcode", "Invoice No.", "Quantity"}, gridRoot, DevExpress.Utils.HorzAlignment.Center)
            gridRoot.Columns("Product").ColumnEdit = MemoEdit
            XgridGroupSummaryCurrency({"Total"}, gridRoot)
            XgridGeneralSummaryCurrency({"Total"}, gridRoot)
        ElseIf RadioGroup1.EditValue = 2 Then
            LoadXgrid("select  trnid, Cancelled, date_format(datetrn, '%M %d, %Y') as 'Date',referenceno as 'Invoice No.', itemcode as 'Description',Debit,Credit, Remarks from tblglaccountledger where accountno='" & accountno.Text & "' and batchcode='" & txtBatchcode.Text & "' and journalmode='client-accounts' order by datetrn asc", "tblglaccountledger", EmRoot, gridRoot, Me)
            XgridColCurrency({"Debit", "Credit"}, gridRoot)
            gridRoot.BestFitColumns()
            XgridHideColumn({"trnid"}, gridRoot)
            XgridColWidth({"Debit", "Credit"}, gridRoot, 120)
            XgridColAlign({"Date", "Invoice No.", "Description"}, gridRoot, DevExpress.Utils.HorzAlignment.Center)
        End If
 
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If RadioGroup1.EditValue = 0 Then
            com.CommandText = "update tblsalesclientcharges set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where trnid='" & gridRoot.GetFocusedRowCellValue("trnid").ToString & "'" : com.ExecuteNonQuery()
        ElseIf RadioGroup1.EditValue = 1 Then
            com.CommandText = "update tblsalesclientchargesitem set cancelled=1, cancelledby='" & globaluserid & "' where id='" & gridRoot.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
        ElseIf RadioGroup1.EditValue = 2 Then
            com.CommandText = "update tblglaccountledger set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where trnid='" & gridRoot.GetFocusedRowCellValue("trnid").ToString & "'" : com.ExecuteNonQuery()
        End If
        FilterRootTransaction()
    End Sub

    Private Sub RevertSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RevertSelectedToolStripMenuItem.Click
        If RadioGroup1.EditValue = 0 Then
            com.CommandText = "update tblsalesclientcharges set cancelled=0, cancelledby='', datecancelled=null where trnid='" & gridRoot.GetFocusedRowCellValue("trnid").ToString & "'" : com.ExecuteNonQuery()
        ElseIf RadioGroup1.EditValue = 1 Then
            com.CommandText = "update tblsalesclientchargesitem set cancelled=0, cancelledby='' where id='" & gridRoot.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
        ElseIf RadioGroup1.EditValue = 2 Then
            com.CommandText = "update tblglaccountledger set cancelled=0, cancelledby='', datecancelled=null where trnid='" & gridRoot.GetFocusedRowCellValue("trnid").ToString & "'" : com.ExecuteNonQuery()
        End If
        FilterRootTransaction()
    End Sub

#End Region
    Private Sub GridView1_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles GridView1.ColumnWidthChanged
        UpdateGridColumnSetting(Me.Name & If(ckFilter.Checked = True, "-group", "-details"), GridView1)
    End Sub

    Private Sub GridView1_DragObjectDrop(sender As Object, e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles GridView1.DragObjectDrop
        UpdateGridColumnSetting(Me.Name & If(ckFilter.Checked = True, "-group", "-details"), GridView1)
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub


    Private Sub txtdatetrn_EditValueChanged(sender As Object, e As EventArgs) Handles txtdateFrom.EditValueChanged
        FilterInvoices()
    End Sub

    Private Sub txtDateTo_EditValueChanged(sender As Object, e As EventArgs) Handles txtDateTo.EditValueChanged
        FilterInvoices()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint.ItemClick
        Dim report As New rptBillingStatement()
        com.CommandText = "select * from tblclientaccounts where cifid='" & accountno.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            report.txtClientName.Text = rst("companyname").ToString
            report.txtAddress.Text = rst("compadd").ToString
            report.txtContactNumber.Text = rst("telephone").ToString
        End While
        rst.Close()
        report.txtDate.Text = UCase(Format(Now.ToString("MMMM dd, yyyy")))
        report.txtStatementDatePeriod.Text = UCase("Period covered from " & txtdateFrom.Text & " To " & txtDateTo.Text)
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        report.txtStatementHeader.Text = ReadFile(Application.StartupPath.ToString & "\Report\rptBillingHeader.txt").ToString.Replace(vbCrLf, Environment.NewLine)
        report.txtStatementFooter.Text = ReadFile(Application.StartupPath.ToString & "\Report\rptBillingFooter.txt").ToString.Replace(vbCrLf, Environment.NewLine)
        report.txtStatementFooter1.Text = ReadFile(Application.StartupPath.ToString & "\Report\rptBillingFooter1.txt").ToString.Replace(vbCrLf, Chr(13))

        Me.WindowState = FormWindowState.Minimized
        report.ShowRibbonPreviewDialog()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub RefreshListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshListToolStripMenuItem.Click
        FilterInvoices()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim I As Integer = 0
        For I = 0 To gridview1.SelectedRowsCount - 1
            gridview1.DeleteRow(gridview1.GetSelectedRows(I))
        Next
    End Sub

    Private Sub txtTimeFrom_EditValueChanged(sender As Object, e As EventArgs)
        FilterInvoices()
    End Sub

    
    Private Sub ckFilter_CheckedChanged(sender As Object, e As EventArgs) Handles ckFilter.CheckedChanged
        If ckFilter.Checked = True Then
            ShowInvoiceToolStripMenuItem.Visible = True
        Else
            ShowInvoiceToolStripMenuItem.Visible = False
        End If
        FilterInvoices()
    End Sub

    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim colname As String = ""
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView1, Me.Text & If(ckFilter.Checked = True, "-all", ""))
        frmColumnFilter.ShowDialog(Me)
    End Sub

    Private Sub ShowInvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowInvoiceToolStripMenuItem.Click
        frmClientChargeInvoice.txtBatchcode.Text = GridView1.GetFocusedRowCellValue("Order Number").ToString
        If frmClientChargeInvoice.Visible = True Then
            frmClientChargeInvoice.Focus()
        Else
            frmClientChargeInvoice.Show(Me)
        End If

    End Sub
End Class