Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI

Public Class frmVoucherUpdateCheckDetails
    Public ConfirmVoucher As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmVoucherOtherExpense_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmConfirmedVoucherProcessing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If MessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tbldisbursementvoucher set checkno='" & txtCheckNumber.Text & "', checkdate='" & ConvertDate(txtCheckDate.EditValue) & "', checkamount='" & Val(CC(txtCheckAmount.Text)) & "'  where voucherno='" & voucherno.Text & "'" : com.ExecuteNonQuery()
            If frmVoucherSummary.Visible = True Then
                frmVoucherSummary.FilterVoucherSummary()
            End If
            If frmAcctVoucherSummary.Visible = True Then
                frmAcctVoucherSummary.FilterVoucherSummary()
            End If
            XtraMessageBox.Show("Check successfully updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub


    Private Sub cmdCheckPrint_Click(sender As Object, e As EventArgs) Handles cmdCheckPrint.Click
        Dim report As New rptCheckPrint()
        report.txtCheckPayee.Text = "*** " & txtClaimant.Text & " ***"
        report.txtCheckDate.Text = "*** " & CDate(txtCheckDate.EditValue).ToString("MMMM dd, yyyy") & " ***"
        report.txtNumberInWords.Text = "*** " & NumToWords(Val(CC(txtCheckAmount.Text))) & " ***"
        report.txtCheckAmount.Text = "*** " & txtCheckAmount.Text & " ***"
        report.ShowRibbonPreviewDialog()
    End Sub
End Class