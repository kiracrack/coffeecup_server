Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen

Public Class frmAPClosedPayables
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub BarLargeButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Close()
    End Sub

    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        PopulateGridViewControls("Select", 20, "CHECKBOX", dgv, True, False)
        PopulateGridViewControls("Payable No.", 50, "", dgv, True, True)
        PopulateGridViewControls("Date", 50, "", dgv, True, True)
        PopulateGridViewControls("Office", 50, "", dgv, True, True)
        PopulateGridViewControls("Supplier", 30, "", dgv, True, True)
        PopulateGridViewControls("Amount", 10, "", dgv, True, True)
        PopulateGridViewControls("Note", 50, "", dgv, True, True)
        PopulateGridViewControls("Posted By", 10, "", dgv, True, True)
        PopulateGridViewControls("Date Posted", 10, "", dgv, True, True)
        PopulateGridViewControls("Date Approved", 10, "", dgv, True, True)
        PopulateGridViewControls("Date Cleared", 10, "", dgv, True, True)
        PopulateGridViewControls("vendorid", 0, "", dgv, False, True)
        LoadApprovedPayable()
    End Sub

    Public Sub LoadApprovedPayable()
        dgv.Rows.Clear()
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select vendorid, voucherno, date_format(voucherdate,'%Y-%m-%d') as 'Date', (select officename from tblcompoffice where officeid=tbldisbursementvoucher.officeid) as 'Office', " _
                                    + " (select companyname from tblglobalvendor where vendorid=tbldisbursementvoucher.vendorid) as 'Supplier', Amount, " _
                                    + "  Note, date_format(datetrn,'%Y-%m-%d %r') as 'DatePosted', (select fullname from tblaccounts where accountid=tbldisbursementvoucher.trnby) as 'PostedBy', " _
                                    + " if(Verified=1,date_format(dateverified,'%Y-%m-%d %r') ,'-') as 'DateApproved', date_format(datecleared,'%Y-%m-%d %r') as 'DateCleared' " _
                                    + "   from tbldisbursementvoucher where verified=1 and cleared=0 and cancelled=0  order by datetrn desc", conn)

        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                dgv.Rows.Add(False, .Rows(cnt)("voucherno").ToString(), _
                                                 .Rows(cnt)("Date").ToString(), _
                                                 .Rows(cnt)("office").ToString(), _
                                                 .Rows(cnt)("Supplier").ToString(), _
                                                 Val(.Rows(cnt)("Amount").ToString()), _
                                                 .Rows(cnt)("Note").ToString(), _
                                                 .Rows(cnt)("DatePosted").ToString(), _
                                                 .Rows(cnt)("PostedBy").ToString(), _
                                                 .Rows(cnt)("DateApproved").ToString(), _
                                                 .Rows(cnt)("DateCleared").ToString(), _
                                                 .Rows(cnt)("vendorid").ToString())
            End With
        Next

        GridCurrencyColumn(dgv, {"Amount"})
        GridColumnWidth(dgv, {"Amount", "Payable No."}, 100)
        GridColumnAlignment(dgv, {"Date", "Payable No."}, DataGridViewContentAlignment.MiddleCenter)
        GridColumAutoWidth(dgv, {"Select", "Date", "Office", "Supplier", "Note", "Posted By", "Date Posted", "Date Approved", "Date Cleared"})

    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        Dim Selected As Boolean = False
        For I = 0 To dgv.RowCount - 1
            If DirectCast(dgv.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                Selected = True
            End If
        Next
        If Selected = False Then
            MessageBox.Show("No item selected", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If XtraMessageBox.Show("Are you sure you want to clear selected approved payable? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            For xi = 0 To dgv.RowCount - 1
                If DirectCast(dgv.Rows(xi).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                    Dim VoucherNo As String = dgv.Item("Payable No.", xi).Value
                    GenerateApprovedAP(False, VoucherNo, dgv.Item("Supplier", xi).Value, GridView_Voucher, Em_Voucher, Me)
                    com.CommandText = "insert into tblglaccountledger set journalmode='payable-accounts', accountno='" & dgv.Item("vendorid", xi).Value & "', referenceno='" & VoucherNo & "', itemcode='Payment', " _
                                               + " remarks='" & dgv.Item("Note", xi).Value & "', debit=0, credit=(select sum(amount) from tbldisbursementdetails where voucherno='" & VoucherNo & "'), datetrn=current_timestamp,trnby='" & globaluserid & "',cleared=1,clearedby='" & globaluserid & "', datecleared=current_timestamp " : com.ExecuteNonQuery()
                    If GLobalEnableElectronicVoucher = True Then
                        com.CommandText = "update tbldisbursementvoucher set cleared=1, clearedby='" & globaluserid & "', datecleared=current_timestamp where voucherno='" & VoucherNo & "'" : com.ExecuteNonQuery()
                    Else
                        com.CommandText = "update tbldisbursementvoucher set verified=1,dateverified=current_timestamp,verifiedby='" & globaluserid & "',cleared=1, clearedby='" & globaluserid & "', datecleared=current_timestamp where voucherno='" & VoucherNo & "'" : com.ExecuteNonQuery()
                    End If


                    com.CommandText = "update tblpurchaseorder set paymentupdated=1, closed=1, dateclosed=current_timestamp where paymentrefnumber='" & VoucherNo & "' and ap=1" : com.ExecuteNonQuery()
                    RecordApprovingHistory("payable", VoucherNo, VoucherNo, "cleared", "update status as cleared")
                End If
            Next
            SplashScreenManager.CloseForm()
            LoadApprovedPayable()
            XtraMessageBox.Show("Transaction successfully cleared", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            For x = 0 To dgv.RowCount - 1
                DirectCast(dgv.Rows(x).Cells("Select"), DataGridViewCheckBoxCell).Value = 1
            Next
        Else
            For x = 0 To dgv.RowCount - 1
                DirectCast(dgv.Rows(x).Cells("Select"), DataGridViewCheckBoxCell).Value = 0
            Next
        End If
    End Sub


End Class