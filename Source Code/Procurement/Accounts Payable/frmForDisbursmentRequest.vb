Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraReports.UI

Public Class frmForDisbursmentRequest
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmApproverFinal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadApprovedRequest()
    End Sub

    Public Sub LoadApprovedRequest()
        LoadXgrid("Select  requestref as 'PR Number',officeid,vendorid, ponumber as 'PO Number', " _
                   + " if(forpo=1,'PURCHASE ORDER','PAYMENT ORDER') as 'Transaction Type', " _
                   + " (select officename from tblcompoffice where officeid = tblpurchaseorder.officeid) as 'Office', " _
                   + " (select ucase(companyname) from tblglobalvendor where vendorid = tblpurchaseorder.vendorid) as 'Supplier', " _
                   + " totalamount as 'Total', " _
                   + " date_format(datetrn,'%Y-%m-%d %r') as 'Date Processed', " _
                   + " if(delivered=1,'Delivered','Not Yet Delivered') as 'Status', " _
                   + " date_format(datedelivered,'%Y-%m-%d %r') as 'Date Delivered', " _
                   + " Note,forpo " _
                   + " from tblpurchaseorder " _
                   + " where verified=1 and corporatelevel=1 and delivered=" & ckasof.CheckState & " and cancelled=0 and paymentrequested=0 and " _
                   + " (requestref like '%" & txtSearch.Text & "%' or ponumber like '%" & txtSearch.Text & "%' or  (select officename from tblcompoffice where officeid = tblpurchaseorder.officeid) like '%" & txtSearch.Text & "%' or (select ucase(companyname) from tblglobalvendor where vendorid = tblpurchaseorder.vendorid) like '%" & txtSearch.Text & "%') order by datetrn desc", "tblpurchaseorder", Em, GridView1, Me)
        XgridHideColumn({"requestref", "forpo", "officeid", "vendorid"}, GridView1)
        XgridColCurrency({"Total"}, GridView1)
        XgridColAlign({"PO Number", "PR Number", "Transaction Type", "Status", "Date Processed", "Date Delivered"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryStatus({"PR Number"}, DevExpress.Data.SummaryItemType.Count, "Total Payable", GridView1)
        GridView1.BestFitColumns()
    End Sub

    Private Sub cmdViewItem_Click(sender As Object, e As EventArgs) Handles cmdViewItem.Click
        frmRequestProfile.pid.Text = GridView1.GetFocusedRowCellValue("PR Number").ToString
        frmRequestProfile.Show(Me)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadApprovedRequest()
    End Sub

    Private Sub cmdPaymentRequest_Click(sender As Object, e As EventArgs) Handles cmdPaymentRequest.Click
        If XtraMessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmForDisbursementProcess.ponumber.Text = GridView1.GetFocusedRowCellValue("PO Number").ToString
            frmForDisbursementProcess.ShowDialog(Me)
        End If
    End Sub

    Public Sub ProceedPaymentRequest(ByVal invoice As String, ByVal voucherno As String)
        frmAPPaymentRequest.mode.Text = "direct"
        frmAPPaymentRequest.txtVoucherNo.Text = voucherno
        frmAPPaymentRequest.officeid.Text = GridView1.GetFocusedRowCellValue("officeid").ToString
        frmAPPaymentRequest.txtOffice.Text = GridView1.GetFocusedRowCellValue("officeid").ToString

        frmAPPaymentRequest.claimantid.Text = GridView1.GetFocusedRowCellValue("vendorid").ToString
        frmAPPaymentRequest.txtSupplier.Text = GridView1.GetFocusedRowCellValue("vendorid").ToString

        com.CommandText = "UPDATE tblpurchaseorder set invoiceno='" & invoice & "', paymentrequested=1,paymentrequestedby='" & globaluserid & "', paymentrefnumber='" & voucherno & "',ap=1 where ponumber='" & GridView1.GetFocusedRowCellValue("PO Number").ToString & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into tbldisbursementdetails set voucherno='" & voucherno & "', vendorid='" & GridView1.GetFocusedRowCellValue("vendorid").ToString & "', supplier='" & GridView1.GetFocusedRowCellValue("Supplier").ToString & "', datetrn='" & ConvertDate(GridView1.GetFocusedRowCellValue("Date Processed").ToString) & "', ponumber='" & GridView1.GetFocusedRowCellValue("PO Number").ToString & "', note='" & rchar(GridView1.GetFocusedRowCellValue("Note").ToString) & "', invoiceno='" & invoice & "',taxcode='',tax='0', amount='" & Val(CC(GridView1.GetFocusedRowCellValue("Total").ToString)) & "',forpo=" & CBool(GridView1.GetFocusedRowCellValue("forpo").ToString) & "" : com.ExecuteNonQuery()
       
        frmAPPaymentRequest.ShowDialog(Me)
        LoadApprovedRequest()
    End Sub

    Private Sub ckasof_CheckedChanged(sender As Object, e As EventArgs) Handles ckasof.CheckedChanged
        LoadApprovedRequest()
    End Sub

    Private Sub txtSearch_EditValueChanged(sender As Object, e As EventArgs) Handles txtSearch.EditValueChanged

    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar() = Chr(13) Then
            LoadApprovedRequest()
        End If
    End Sub

    
End Class