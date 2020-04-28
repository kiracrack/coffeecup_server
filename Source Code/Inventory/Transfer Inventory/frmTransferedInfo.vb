Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmTransferedInfo
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmTransferNew_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ClearMaster()
    End Sub
    Private Sub frmTransferNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadBatchInformation()
        filterBatch()
        LoadGridviewAppearance(GridView1)
    End Sub
    Public Sub ClearMaster()
        Batchcode.Text = getGlobalTrnid("BT", globaluserid)
        txtInventoryfrom.Text = ""
        txtInventoryto.Text = ""
        txtRequestby.Text = ""
        txtNote.Text = ""
    End Sub
    Public Sub LoadBatchInformation()
        com.CommandText = "select *,(select officename from tblcompoffice where officeid=tbltransferbatch.inventory_from) as 'From', " _
                      + " (select officename from tblcompoffice where officeid=tbltransferbatch.inventory_to) as 'To', " _
                      + " (select fullname from tblaccounts where accountid = tbltransferbatch.requestby) as 'Request By' , " _
                      + " (select designation from tblaccounts where accountid = tbltransferbatch.requestby) as 'position', " _
                      + " if(cancelled=1,'Cancelled', case when confirmed=0 then 'Not yet Confirm' when confirmed=1 then 'Confirmed' end ) as 'Status' from tbltransferbatch where batchcode='" & Batchcode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtInventoryfrom.Text = rst("From").ToString
            txtInventoryto.Text = rst("To").ToString
            txtRequestby.Text = rst("Request By").ToString
            txtDesignation.Text = rst("position").ToString
            txtNote.Text = rst("note").ToString
            inventoryfrom.Text = rst("inventory_from").ToString
            inventoryto.Text = rst("inventory_to").ToString
            txtStatus.Text = StrConv(rst("Status").ToString, vbProperCase)
            lblTitle.Text = StrConv(rst("Status").ToString, vbProperCase) & " Request Transfer"
            If rst("Status").ToString = "Not yet Confirm" Then
                Em.ContextMenuStrip = ContextMenuStrip2
                cmdConfirm.Visible = True
                cmdPrint.Visible = False
            Else
                Em.ContextMenuStrip = Nothing
                cmdConfirm.Visible = False
                cmdPrint.Visible = True
            End If
        End While
        rst.Close()
    End Sub
    Public Sub filterBatch()
        LoadXgrid("Select  trnid, refcode as 'Stock No.',(select ITEMNAME from tblglobalproducts where PRODUCTID=tbltransferitem.itemid and actived=1 limit 1) as 'Particular', " _
                           + " Quantity, " _
                           + If(cmdConfirm.Visible = True, " (select quantity from tblinventory where trnid=tbltransferitem.refcode) as 'Available Stock', ", "") _
                           + " (select unit from tblglobalproducts where PRODUCTID=tbltransferitem.itemid and actived=1 limit 1) as 'Unit', " _
                           + " unitcost as 'Unit Cost', " _
                           + " unitcost*Quantity as 'Total Cost', " _
                           + " Remarks " _
                           + " from tbltransferitem where batchcode = '" & Batchcode.Text & "'" _
                           + " order by datetrn asc", "tbltransferitem", Em, GridView1, Me)
        GridView1.BestFitColumns()
        GridView1.Columns("trnid").Visible = False
        'GridView1.Columns("refcode").Visible = False
        GridView1.Columns("Remarks").ColumnEdit = MemoEdit
        XgridColCurrencyDecimalCount({"Quantity", "Available Stock", "Unit Cost", "Total Cost"}, 3, GridView1)
        XgridColAlign({"Stock No.", "Quantity", "Unit"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total Cost"}, GridView1)

    End Sub

    'Private Sub GridView_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
    '    Dim View As GridView = sender
    '    If e.Column.Name = "colAvailableStock" Then
    '        Dim quantity As Double = Val(CC(View.GetRowCellDisplayText(e.RowHandle, View.Columns("Quantity"))))
    '        Dim Stock As Double = Val(CC(View.GetRowCellDisplayText(e.RowHandle, View.Columns("Available Stock"))))
    '        If quantity > Stock Then
    '            e.Appearance.BackColor = Color.White
    '            e.Appearance.ForeColor = Color.Red
    '        Else
    '            e.Appearance.BackColor = BackColor
    '            e.Appearance.ForeColor = ForeColor
    '        End If
    '    End If
    'End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim report As New rptPurchaseRequest()
        report.pid.Text = StrConv(Batchcode.Text, vbUpperCase)
        report.txtRequestby.Text = StrConv(txtRequestby.Text, vbUpperCase)
        report.txtdesignation.Text = txtDesignation.Text
        report.txtoffice.Text = txtInventoryto.Text
        report.txtDateRequest.Text = Format(Now.ToString("MMMM dd, yyyy hh:mm:ss tt"))
        report.txtDateNeeded.Text = Format(Now.ToString("MMMM dd, yyyy hh:mm:ss tt"))
        report.txtpurchasetype.Text = UCase(lblTitle.Text)
        report.txtdetails.Text = "Transfer Item From " & StrConv(txtInventoryfrom.Text, vbProperCase) & " to " & StrConv(txtInventoryto.Text, vbProperCase) & " (" & txtNote.Text & ")"
        report.ReportFooter.Visible = False
        'report.TransferRequest()
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        report.ShowRibbonPreviewDialog()
    End Sub
    Private Sub cmdConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click
        'If qrysingledata("inventorymethod", "inventorymethod", " where officeid='" & inventoryto.Text & "'", "tblcompoffice") = "" Then
        '    MessageBox.Show("Your office have not set inventory method, please contact your administrator!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'ElseIf countqry("(select sum(quantity) as quantity,(select quantity from tblinventory where trnid=tbltransferitem.refcode) as available from tbltransferitem where batchcode='" & Batchcode.Text & "' group by refcode) as a", "quantity > available") > 0 Then
        '    MessageBox.Show("There was a descrepancy item count on your stock transfer inventory! please report this error to your IT Department.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        If XtraMessageBox.Show("Continue confirm batch transfer inventory?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If ReceivedTransfer(Batchcode.Text, False) = True Then
                XtraMessageBox.Show("Request successfully confirmed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filterBatch()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If CheckSelectedRow("trnid", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to continue this action?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                For I = 0 To GridView1.SelectedRowsCount - 1
                    com.CommandText = "delete from tbltransferitem where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid") & "'" : com.ExecuteNonQuery()
                Next
                GridView1.DeleteSelectedRows()
            End If
        End If
    End Sub
End Class