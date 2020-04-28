Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmCancel_invoices
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmApprovalChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
    End Sub
   
    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If countqry("tblsalesclientcharges", "batchcode='" & rchar(txtBatchcode.Text) & "'") = 0 Then
            XtraMessageBox.Show("Please enter correct batch code!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBatchcode.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue correct transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tblsalesclientcharges set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblsalesclientchargesitem set cancelled=1, cancelledby='" & globaluserid & "' where batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblglaccountledger set cancelled=1,cancelledby='" & globaluserid & "', datecancelled=current_timestamp where batchcode='" & txtBatchcode.Text & "' and journalmode='client-accounts'" : com.ExecuteNonQuery()
            com.CommandText = "update tblsalesbatch set void=1,voidby='" & globaluserid & "', voidreason='" & rchar(txtRemarks.Text) & "' where batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblsalestransaction set cancelled=1,cancelledby='" & globaluserid & "',  cancelremarks='" & rchar(txtRemarks.Text) & "' where batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()

            com.CommandText = "insert into tblsaleserrorcorrect set errortype='Cancelled', errorref='Invoice#: " & txtBatchcode.Text & " - " & txtCurrentClient.Text & Chr(13) & "Total Amount: " & txtAmount.Text & Chr(13) & "', remarks='" & rchar(txtRemarks.Text) & "',cashier='" & txtCashier.Text & "', datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
            XtraMessageBox.Show("Invoice successfully cancelled", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBatchcode.KeyPress
        If e.KeyChar() = Chr(13) Then
            If countqry("tblsalesclientcharges", "batchcode='" & rchar(txtBatchcode.Text) & "'") > 0 Then
                com.CommandText = "select *,(select companyname from tblclientaccounts where cifid = tblsalesclientcharges.accountno) as 'fullname' from tblsalesclientcharges where batchcode='" & rchar(txtBatchcode.Text) & "'" : rst = com.ExecuteReader
                While rst.Read
                    txtDate.Text = rst("datetrn").ToString
                    txtInvoiceNo.Text = rst("invoiceno").ToString
                    txtAmount.Text = FormatNumber(Val(rst("amount").ToString), 2)
                    txtCurrentClient.Text = rst("fullname").ToString
                End While
                rst.Close()

                txtRemarks.Focus()
            Else
                XtraMessageBox.Show("batchcode not found! Please try again", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtBatchcode.SelectAll()
                txtBatchcode.Focus()
            End If
        End If
    End Sub
End Class