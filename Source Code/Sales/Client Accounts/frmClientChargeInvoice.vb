Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid

Public Class frmClientChargeInvoice

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then


        ElseIf keyData = (Keys.Control) + Keys.P Then
            ' printreport()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmClientChargeInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
 
    End Sub
    Public Sub LoadInvoiceInfo()
        com.CommandText = "select *,(select companyname from tblclientaccounts where cifid=tblsalesclientcharges.accountno) as clientname from tblsalesclientcharges where batchcode='" & txtBatchcode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtInvoiceNo.Text = rst("invoiceno").ToString
            txtClientName.Text = rst("clientname").ToString
        End While
        rst.Close()
        FilterTransaction()
    End Sub

    Public Sub FilterTransaction()
        Try
            dst = Nothing
            If txtInvoiceNo.Text = "" Then Exit Sub
            LoadXgrid("select tblsalesclientchargesitem.id as trnid_invoice, (select id from tblsalestransaction where batchcode=tblsalesclientchargesitem.batchcode and datetrn=tblsalesclientchargesitem.datetrn and productid=tblsalesclientchargesitem.productid and quantity=tblsalesclientchargesitem.quantity) as 'trnid_batch',date_format(tblsalesclientchargesitem.datetrn, '%Y-%m-%d') as 'Date', tblsalesclientcharges.invoiceno as 'Invoice No.', productname as 'Product',Quantity,originalsellprice as 'Original Selling Price', sellprice as 'Selling Price', chargetotal as 'Charges', distotal as 'Discount', tblsalesclientchargesitem.Total, tblsalesclientcharges.Verified,tblsalesclientcharges.Cancelled,paymentupdated as Paid " _
                                   + " from tblsalesclientchargesitem inner join tblsalesbatch on tblsalesclientchargesitem.batchcode = tblsalesbatch.batchcode  inner join tblsalesclientcharges on tblsalesclientchargesitem.batchcode = tblsalesclientcharges.batchcode where tblsalesclientchargesitem.batchcode='" & txtBatchcode.Text & "' order by tblsalesclientchargesitem.datetrn asc", "tblsalesclientchargesitem", Em, gridview1, Me)
            XgridHideColumn({"trnid_invoice", "trnid_batch"}, gridview1)
            XgridColCurrency({"Selling Price", "Original Selling Price", "Quantity", "Charges", "Discount", "Total"}, gridview1)
            gridview1.BestFitColumns()
            XgridColWidth({"Total"}, gridview1, 120)
            XgridColAlign({"Date", "Invoice No.", "Quantity"}, gridview1, DevExpress.Utils.HorzAlignment.Center)

            XgridGroupSummaryCurrency({"Total"}, gridview1)
            XgridGeneralSummaryCurrency({"Total"}, gridview1)
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


    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub cmdApprove_Click(sender As Object, e As EventArgs)
        FilterTransaction()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        ExportGridToExcel(Me.Text + "(" + txtInvoiceNo.Text + ")", gridview1)
    End Sub

    Private Sub accountno_EditValueChanged(sender As Object, e As EventArgs)
        FilterTransaction()
    End Sub

    Private Sub txtBatchcode_EditValueChanged(sender As Object, e As EventArgs) Handles txtBatchcode.EditValueChanged
        LoadInvoiceInfo()
    End Sub

    Private Sub ShowInvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowInvoiceToolStripMenuItem.Click
        frmInvoinceChangeProduct.trnid_invoice.Text = gridview1.GetFocusedRowCellValue("trnid_invoice").ToString
        frmInvoinceChangeProduct.trnid_batch.Text = gridview1.GetFocusedRowCellValue("trnid_batch").ToString
        frmInvoinceChangeProduct.ShowDialog(Me)
    End Sub

    Private Sub RefreshListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshListToolStripMenuItem.Click
        LoadInvoiceInfo()
    End Sub
End Class