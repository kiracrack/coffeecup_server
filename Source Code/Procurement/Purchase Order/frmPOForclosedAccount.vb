Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraReports.UI

Public Class frmPOForclosedAccount
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
            ckDelivered.Checked = rst("delivered")
            ckPaymentRequested.Checked = rst("paymentrequested")
            ckPaidAccount.Checked = rst("paymentupdated")
            ckCloseAccount.Checked = rst("closed")
        End While
        rst.Close()
    End Sub

    Private Sub cmdMove_Click(sender As Object, e As EventArgs) Handles cmdMove.Click
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "Update tblpurchaseorder set delivered=" & ckDelivered.CheckState & ",paymentrequested=" & ckPaymentRequested.CheckState & ",paymentupdated=" & ckPaidAccount.CheckState & ",closed=" & ckCloseAccount.CheckState & " where ponumber='" & ponumber.Text & "'" : com.ExecuteNonQuery()
            If mode.Text = "po" Then
                RecordApprovingHistory("purchase order", pid.Text, ponumber.Text, "processed", "Force Status Update ")
                frmPurchaseOrder.FilterOption()
            Else
                RecordApprovingHistory("Payment Request", pid.Text, ponumber.Text, "processed", "Force Status Update")
                frmPaymentOrder.FilterOption()
            End If
            XtraMessageBox.Show("Approving level successfully changed!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
     
End Class