Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Skins

Public Class frmUpdateRRReport
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        ElseIf keyData = (Keys.Control) + Keys.Enter Then
            cmdaction.PerformClick()
        End If
        Return ProcessCmdKey
    End Function
  
    Private Sub frmQuantitySelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)

    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdaction.Click
        If radPayOption.SelectedIndex = -1 Then
            MessageBox.Show("Please select pay type transaction!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            radPayOption.Focus()
            Exit Sub
        End If
        frmReceivingReport.UpdateRR(radPayOption.EditValue, CheckEdit1.Checked)
        Me.Close()
    End Sub

End Class