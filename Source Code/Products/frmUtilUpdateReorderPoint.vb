Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmUtilUpdateReorderPoint
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
  
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If Val(CC(txtReorderPoint.Text)) <= 0 Then
            XtraMessageBox.Show("Please enter valid re-order point quantity! ", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtReorderPoint.Focus()
            Exit Sub
        End If
        frmProductManagement.SetReorderPoint(Val(CC(txtReorderPoint.Text)))
    End Sub

    Private Sub frmReportDamage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
    End Sub

End Class