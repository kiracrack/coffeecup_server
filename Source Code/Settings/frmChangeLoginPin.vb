﻿Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmChangeLoginPin
    Private Sub frmChangeUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        SetIcon(Me)
        txtNewPassword.Text = "Pass"
        txtVerifyPassword.Text = "Pass"
    End Sub
    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVerifyPassword.KeyPress
        If e.KeyChar() = Chr(13) Then
            cmdSaveButton.PerformClick()
        End If
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        If txtNewPassword.Text = "" Or txtNewPassword.Text = "Pass" Then
            XtraMessageBox.Show("Please enter PIN!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNewPassword.Focus()
            Exit Sub
        ElseIf txtVerifyPassword.Text = "" Then
            XtraMessageBox.Show("Please enter verify PIN!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVerifyPassword.Focus()
            Exit Sub
        ElseIf txtNewPassword.Text <> txtVerifyPassword.Text Then
            XtraMessageBox.Show("PIN did not match! ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNewPassword.Text = ""
            txtVerifyPassword.Text = ""
            txtNewPassword.Focus()
            Exit Sub
        End If
        com.CommandText = "update tblaccounts set pinkey='" & EncryptTripleDES(UCase(txtFullname.Text) + txtVerifyPassword.Text) & "'  where accountid='" & userid.Text & "'" : com.ExecuteNonQuery()
        XtraMessageBox.Show("PIN successfully changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class