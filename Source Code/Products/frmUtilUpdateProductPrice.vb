Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmUtilUpdateProductPrice
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If Val(CC(txtSellingPrice.Text)) <= 0 Then
            XtraMessageBox.Show("Please enter valid selling price! ", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSellingPrice.Focus()
            Exit Sub
        End If
        frmProductManagement.SetProductPrice(Val(CC(txtSellingPrice.Text)))
    End Sub

    Private Sub frmReportDamage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
    End Sub

End Class