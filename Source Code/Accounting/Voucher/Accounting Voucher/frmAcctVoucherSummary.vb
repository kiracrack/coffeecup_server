﻿Imports MySql.Data.MySqlClient
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraSplashScreen

Public Class frmAcctVoucherSummary
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmAccountPayables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)
        LoadCompany()
        FilterVoucherSummary()
       
    End Sub

    Public Sub LoadCompany()
        LoadXgridLookupSearch("select code, Companyname as 'Select Company' from tblcompany", "tblcompany", txtCompany, gvCompany, Me)
        gvCompany.Columns("code").Visible = False
    End Sub

    Private Sub txtCompany_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompany.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCompany.Properties.View.FocusedRowHandle.ToString)
        companyid.Text = txtCompany.Properties.View.GetFocusedRowCellValue("code").ToString()
    End Sub

    Public Function FilterVoucherSummary()
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = "where date_format(datetrn,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = "where date_format(datetrn,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If
        dst.EnforceConstraints = False
        dst.Relations.Clear() : Em.LevelTree.Nodes.Clear()
        dst.Clear()
        LoadXgrid("Select voucherno as 'Voucher No.',vendorid,officeid, if(cancelled=1,'Cancelled',if(hold=1,'Hold',if(cleared=1,'Cleared',if(verified=1,'Approved','For Approval')))) as 'Status', " _
                                    + " date_format(voucherdate,'%Y-%m-%d') as 'Date', case when `check`=1 then 'Check Voucher' when cash=1 then 'Cash Voucher' when ca=1 then 'Cash Advance'  end as 'Clasification', " _
                                    + "(select companyname from tblcompany where code=a.companyid) as 'Company', " _
                                    + " (select officename from tblcompoffice where officeid=a.officeid) as 'Office', " _
                                    + " (select companyname from tblglobalvendor where vendorid=a.vendorid) as 'Claimant', " _
                                    + "  Amount,Note, " _
                                    + " Cash, `Check`, CheckNo as 'Check No.',date_format(CheckDate,'%Y-%m-%d') as 'Check Date',  date_format(datetrn,'%Y-%m-%d %r') as 'Date Posted', " _
                                    + " (select fullname from tblaccounts where accountid=a.trnby) as 'Posted By', " _
                                    + " Verified as Approved, if(Verified=1,date_format(dateverified,'%Y-%m-%d %r') ,'-') as 'Date Approved', " _
                                    + " Cleared,date_format(datecleared,'%Y-%m-%d') as 'Date Cleared',(select fullname from tblaccounts where accountid=a.clearedby) as 'Cleared By', " _
                                    + " Cancelled,date_format(datecancelled,'%Y-%m-%d') as 'Date Cancelled',(select fullname from tblaccounts where accountid=a.cancelledby) as 'Cancelled By' " _
                                    + "   from tbldisbursementvoucher as a " & If(ckPendingRequest.Checked = True, " where (cleared=0 and cancelled=0) ", filterasof) & If(CheckEdit1.Checked = True, "", " and companyid='" & companyid.Text & "'") & "  order by datetrn desc", "tbldisbursementvoucher", Em, GridView1, Me)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tbldisbursementvoucher")

        GridView1.BestFitColumns()
        XgridColCurrency({"Amount"}, GridView1)
        XgridHideColumn({"Cash", "CA", "SourceFund", "itemcode", "checkno", "vendorid", "officeid", "directexpense"}, GridView1)
        XgridColAlign({"Voucher No.", "Disbursement Type", "Office", "Date", "Status", "VoucherType", "Date Posted", "Date Verified", "Check No.", "Check Date", "Date Approved", "DatePaymentPosted", "Date Cleared", "Date Cancelled"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
        XgridColWidth({"Amount"}, GridView1, 120)
        SaveFilterColumn(GridView1, Me.Text)
        Return True
    End Function

    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If e.Column.Name = "colStatus" Then
            Dim priority As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))
            If priority = "Approved" Then
                e.Appearance.BackColor = Color.LightGreen
                e.Appearance.ForeColor = Color.Black
            ElseIf priority = "Hold" Then
                e.Appearance.BackColor = Color.Orange
                e.Appearance.ForeColor = Color.Black
            ElseIf priority = "Cancelled" Then
                e.Appearance.BackColor = Color.White
                e.Appearance.ForeColor = Color.Red
            ElseIf priority = "For Approval" Then
                e.Appearance.BackColor = Color.Gold
                e.Appearance.ForeColor = Color.Black
            ElseIf priority = "Cleared" Then
                e.Appearance.BackColor = Color.White
                e.Appearance.ForeColor = Color.DarkBlue
            Else
                e.Appearance.BackColor = BackColor
                e.Appearance.ForeColor = ForeColor
            End If
        End If
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If GridView1.RowCount = 0 Then Exit Sub
        If CBool(GridView1.GetFocusedRowCellValue("Cleared").ToString) = True Or CBool(GridView1.GetFocusedRowCellValue("Cancelled").ToString) = True Then
            cmdCleared.Visible = False
            cmdEditVoucher.Visible = False
            cmdUpdateCheckDetails.Visible = False
            cmdCancelled.Visible = False
        Else
            If CBool(GridView1.GetFocusedRowCellValue("Check").ToString) = True Then
                cmdUpdateCheckDetails.Visible = True
            Else
                cmdUpdateCheckDetails.Visible = False
            End If
            cmdCancelled.Visible = True
        End If
      
    End Sub


    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        FilterVoucherSummary()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub


    Private Sub ckasof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        FilterVoucherSummary()
        SplashScreenManager.CloseForm()
    End Sub


    Private Sub Em_DoubleClick(sender As Object, e As EventArgs) Handles Em.DoubleClick
        cmdViewItem.PerformClick()
    End Sub


    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        PrintDatagridview(Me.Text, "DATABASE RECORDS", "REPORT FILTER: Form " & txtfrmdate.Text & " to " & txttodate.Text, GridView1, Me)
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        ReadFilterColumn(GridView1, Me.Text)
    End Sub

    Private Sub ckPending_CheckedChanged(sender As Object, e As EventArgs) Handles ckPendingRequest.CheckedChanged
        If ckPendingRequest.Checked = True Then
            txtfrmdate.Enabled = False
            txttodate.Enabled = False
            ckasof.Enabled = False
            ckasof.Checked = False
        Else
            txtfrmdate.Enabled = True
            txttodate.Enabled = True
            ckasof.Enabled = True
        End If
        FilterVoucherSummary()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdNewVoucher.ItemClick
        frmAcctVoucherInfo.ShowDialog(Me)
    End Sub

    Private Sub EditVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdEditVoucher.Click
        If GridView1.GetFocusedRowCellValue("Voucher No.").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Verified") = True Then
            XtraMessageBox.Show("Editing verified Voucher not allowed", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Cancelled") = True Then
            XtraMessageBox.Show("Editing cancelled Voucher not allowed", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmAcctVoucherInfo.mode.Text = "edit"
        frmAcctVoucherInfo.txtVoucherNo.Text = GridView1.GetFocusedRowCellValue("Voucher No.").ToString()
        If frmAcctVoucherInfo.Visible = True Then
            frmAcctVoucherInfo.Focus()
        Else
            frmAcctVoucherInfo.ShowDialog(Me)
        End If
    End Sub

    Private Sub cmdViewItem_Click(sender As Object, e As EventArgs) Handles cmdViewItem.Click
        If GridView1.GetFocusedRowCellValue("Cancelled") = True Then
            XtraMessageBox.Show("viewing cancelled Voucher not allowed", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmAcctVoucherInfo.mode.Text = "view"
        frmAcctVoucherInfo.txtVoucherNo.Text = GridView1.GetFocusedRowCellValue("Voucher No.").ToString()
        If frmAcctVoucherInfo.Visible = True Then
            frmAcctVoucherInfo.Focus()
        Else
            frmAcctVoucherInfo.ShowDialog(Me)
        End If
    End Sub

    Private Sub CancelVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdCancelled.Click
        If GridView1.GetFocusedRowCellValue("Voucher No.").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Verified") = True Then
            XtraMessageBox.Show("Cancelling verified Voucher is not allowed", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Cancelled") = True Then
            XtraMessageBox.Show("Voucher already cancelled", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                If CBool(GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Cleared").ToString) = False Then
                    com.CommandText = "update tbldisbursementvoucher set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where voucherno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voucher No.").ToString & "'" : com.ExecuteNonQuery()
                    com.CommandText = "DELETE FROM tbldisbursementdetails where voucherno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voucher No.").ToString & "'" : com.ExecuteNonQuery()
                    com.CommandText = "DELETE FROM tblgljournalitems where ticketno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voucher No.").ToString & "'" : com.ExecuteNonQuery()
                End If
            Next
            FilterVoucherSummary()
            XtraMessageBox.Show("Transaction successfully cancelled", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

   
    Private Sub cmdCleared_Click(sender As Object, e As EventArgs) Handles cmdCleared.Click
        Dim EnterCheck As Boolean = True
        For x = 0 To GridView1.SelectedRowsCount - 1
            If GridView1.GetRowCellValue(GridView1.GetSelectedRows(x), "Check No.").ToString = "" And CBool(GridView1.GetRowCellValue(GridView1.GetSelectedRows(x), "Check").ToString) = True Then
                EnterCheck = False
            End If
        Next
        If EnterCheck = False Then
            XtraMessageBox.Show("invalid disbursement voucher for check payment! No check number added", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to clear voucher? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            For x = 0 To GridView1.SelectedRowsCount - 1
                Dim VoucherNo As String = GridView1.GetRowCellValue(GridView1.GetSelectedRows(x), "Voucher No.").ToString
                Dim Note As String = GridView1.GetRowCellValue(GridView1.GetSelectedRows(x), "Note").ToString

                com.CommandText = "update tbldisbursementvoucher set verified=1,dateverified=current_timestamp,verifiedby='" & globaluserid & "',cleared=1, clearedby='" & globaluserid & "', datecleared=current_timestamp where voucherno='" & VoucherNo & "'" : com.ExecuteNonQuery()
                com.CommandText = "insert into tblglticket (companyid,officeid,postingdate,itemcode,itemname,referenceno,remarks,debitamount,creditamount,debit,datetrn,trnby,trnname,journal,trnreference) " _
                    + " select a.companyid,a.officeid,a.voucherdate,b.itemcode,b.itemname,a.voucherno,b.remarks,b.debitamount,b.creditamount,b.debit,a.datetrn,a.trnby,(select fullname from tblaccounts where accountid=a.trnby),1,'VOUCHER' FROM `tbldisbursementvoucher` as a inner join tblgljournalitems as b on a.voucherno=b.ticketno where a.voucherno='" & VoucherNo & "'" : com.ExecuteNonQuery()

            Next
            FilterVoucherSummary()
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show("Transaction successfully cleared", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            txtCompany.ReadOnly = True
        Else
            txtCompany.ReadOnly = False
        End If
    End Sub

    Private Sub cmdUpdateCheckDetails_Click(sender As Object, e As EventArgs) Handles cmdUpdateCheckDetails.Click
        frmVoucherUpdateCheckDetails.voucherno.Text = GridView1.GetFocusedRowCellValue("Voucher No.").ToString()
        frmVoucherUpdateCheckDetails.txtClaimant.Text = GridView1.GetFocusedRowCellValue("Claimant").ToString()
        frmVoucherUpdateCheckDetails.txtCheckAmount.Text = FormatNumber(GridView1.GetFocusedRowCellValue("Amount").ToString(), 2)
        frmVoucherUpdateCheckDetails.txtCheckNumber.Text = GridView1.GetFocusedRowCellValue("Check No.").ToString()
        frmVoucherUpdateCheckDetails.txtCheckDate.EditValue = GridView1.GetFocusedRowCellValue("Check Date").ToString()
        If frmVoucherUpdateCheckDetails.Visible = True Then
            frmVoucherUpdateCheckDetails.Focus()
        Else
            frmVoucherUpdateCheckDetails.ShowDialog(Me)
        End If
    End Sub
End Class