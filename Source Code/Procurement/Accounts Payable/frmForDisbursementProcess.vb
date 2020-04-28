Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraReports.UI

Public Class frmForDisbursementProcess
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmApproverFinal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        com.CommandText = "select *,(select sum(total) from tblpurchaseorderitem where ponumber=tblpurchaseorder.ponumber ) as total, (select officename from tblcompoffice where officeid=tblpurchaseorder.officeid) as office,(select companyname from tblglobalvendor where vendorid=tblpurchaseorder.vendorid) as vendor from tblpurchaseorder where ponumber ='" & ponumber.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            pid.Text = rst("requestref").ToString
            txtBranch.Text = rst("office").ToString
            txtSupplier.Text = rst("vendor").ToString
            txtAmount.Text = FormatNumber(Val(rst("total").ToString), 2)
            txtInvoice.Text = rst("invoiceno").ToString
        End While
        rst.Close()
        GenerateVoucherReference()
    End Sub
    Public Sub GenerateVoucherReference()
        'txtVoucherNo.ReadOnly = True
        voucherno.Text = getVourcherNumberSequence()
        com.CommandText = "UPDATE tblgeneralsettings set vouchernosequence='" & voucherno.Text & "'" : com.ExecuteNonQuery()
    End Sub

    Private Sub cmdMove_Click(sender As Object, e As EventArgs) Handles cmdMove.Click
        frmForDisbursmentRequest.ProceedPaymentRequest(txtInvoice.Text, voucherno.Text)
        Me.Hide()
    End Sub

 
End Class