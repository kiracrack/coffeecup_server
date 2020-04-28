Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmVerifiedPurchaseOrder
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmApprovalChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txttodate.EditValue = CDate(Now)
    End Sub
     
    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If txtInvoiceNumber.Text = "" Then
            MsgBox("Please enter Invoice Number!", MsgBoxStyle.Exclamation, "Error Message")
            txtInvoiceNumber.Focus()
            Exit Sub
        ElseIf countqry("tblpurchaseorder", "invoiceno='" & txtInvoiceNumber.Text & "' and cancelled=0") > 0 Then
            MsgBox("Invoice number already exists!", MsgBoxStyle.Exclamation, "Error Message")
            txtInvoiceNumber.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to clear selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmPurchaseOrder.ValidatingDirectPurchaseOrder(txtInvoiceNumber.Text, txttodate.EditValue)
            Me.Close()
        End If
    End Sub
End Class