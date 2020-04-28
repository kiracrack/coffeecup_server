Imports MySql.Data.MySqlClient
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraSplashScreen

Public Class frmUnliquidatedCashAdvance
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
        FilterVoucherSummary()
    End Sub

    Public Function FilterVoucherSummary()
        dst.EnforceConstraints = False
        dst.Relations.Clear() : Em.LevelTree.Nodes.Clear()
        dst.Clear()
        LoadXgrid("Select voucherno as 'Voucher No.', SourceFund,itemcode,officeid, if(liquidated=1,'For Confirmation','Unliquidated') as 'Status', date_format(voucherdate,'%Y-%m-%d') as 'Date', if(directexpense=1,'Direct Exppense','Accounts Payable') as 'Disbursement Type', (select companyname from tblcompany where code=tbldisbursementvoucher.companyid) as 'Company', (select officename from tblcompoffice where officeid=tbldisbursementvoucher.officeid) as 'Office', (select fullname from tblaccounts where accountid=tbldisbursementvoucher.vendorid) as 'Claimant', " _
                                    + "  Amount as 'Voucher Amount',amountspend as 'Amount Spend',amountrefunded as 'Amount Returned',amountreimbursed as 'Amount Reimbursed',if(liquidated=1,date_format(dateliquidated,'%Y-%m-%d'),'-')  as 'Date Liquidated', " _
                                    + " (select accountname from tblbankaccounts where bankcode=tbldisbursementvoucher.sourcefund) as 'Source Fund', Note, date_format(datetrn,'%Y-%m-%d %r') as 'Date Posted', " _
                                    + " (select fullname from tblaccounts where accountid=tbldisbursementvoucher.trnby) as 'Posted By', Verified as Approved, if(Verified=1,date_format(dateverified,'%Y-%m-%d %r') ,'-') as 'Date Approved'  " _
                                    + "   from tbldisbursementvoucher where cleared=1 and ca=1 and clearedliquidation=0 and cancelled=0 order by datetrn desc", "tbldisbursementvoucher", Em, GridView1, Me)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tbldisbursementvoucher")

        GridView1.BestFitColumns()
        XgridHideColumn({"SourceFund", "itemcode", "officeid"}, GridView1)
        XgridColCurrency({"Voucher Amount", "Amount Spend", "Amount Returned", "Amount Reimbursed"}, GridView1)
        XgridColAlign({"Voucher No.", "Disbursement Type", "Office", "Date", "Status", "VoucherType", "Date Posted", "Date Verified", "Check No", "Date Liquidated", "Date Approved", "DatePaymentPosted", "Date Cleared", "Date Cancelled"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Voucher Amount", "Amount Spend", "Amount Returned", "Amount Reimbursed"}, GridView1)
        XgridColWidth({"Voucher Amount", "Amount Spend", "Amount Returned", "Amount Reimbursed"}, GridView1, 120)
        SaveFilterColumn(GridView1, Me.Text)
        Return True
    End Function

    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If e.Column.Name = "colStatus" Then
            Dim priority As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))
            If priority = "For Confirmation" Then
                e.Appearance.BackColor = Color.LightGreen
                e.Appearance.ForeColor = Color.Black
            ElseIf priority = "Unliquidated" Then
                e.Appearance.BackColor = Color.Orange
                e.Appearance.ForeColor = Color.Black
            Else
                e.Appearance.BackColor = BackColor
                e.Appearance.ForeColor = ForeColor
            End If
        End If
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If GridView1.RowCount = 0 Then Exit Sub
        If GridView1.GetFocusedRowCellValue("Status").ToString = "For Confirmation" Then
            cmdLiquidate.Visible = False
            cmdCleared.Visible = True
            cmdReopen.Visible = True
        ElseIf GridView1.GetFocusedRowCellValue("Status").ToString = "Unliquidated" Then
            cmdLiquidate.Visible = True
            cmdCleared.Visible = False
            cmdReopen.Visible = False
        Else
            cmdLiquidate.Visible = False
            cmdCleared.Visible = False
            cmdReopen.Visible = False
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        FilterVoucherSummary()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        PrintDatagridview(Me.Text, "DATABASE RECORDS", "", GridView1, Me)
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        ReadFilterColumn(GridView1, Me.Text)
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        frmVouchersInformation.ShowDialog(Me)
    End Sub

    Private Sub cmdCleared_Click(sender As Object, e As EventArgs) Handles cmdCleared.Click
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            For x = 0 To GridView1.SelectedRowsCount - 1
                Dim VoucherNo As String = GridView1.GetRowCellValue(GridView1.GetSelectedRows(x), "Voucher No.").ToString
                If Val(CC(GridView1.GetRowCellValue(GridView1.GetSelectedRows(x), "Amount Returned").ToString)) > 0 Then
                    com.CommandText = "insert into tblglaccountledger set journalmode='bank-accounts',accountno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(x), "SourceFund").ToString & "', " _
                                          + " referenceno='" & VoucherNo & "', " _
                                          + " itemcode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(x), "itemcode").ToString & "', " _
                                          + " remarks='CA#" & VoucherNo & " Returned', " _
                                          + " debit=0, " _
                                          + " credit='" & Val(CC(GridView1.GetRowCellValue(GridView1.GetSelectedRows(x), "Amount Returned").ToString)) & "',datetrn=current_timestamp,trnby='" & globaluserid & "',cleared=1,clearedby='" & globaluserid & "',datecleared=current_timestamp " : com.ExecuteNonQuery()
                ElseIf Val(CC(GridView1.GetRowCellValue(GridView1.GetSelectedRows(x), "Amount Reimbursed").ToString)) > 0 Then
                    com.CommandText = "insert into tblglaccountledger set journalmode='bank-accounts',accountno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(x), "SourceFund").ToString & "', " _
                                          + " referenceno='" & VoucherNo & "', " _
                                          + " itemcode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(x), "itemcode").ToString & "', " _
                                          + " remarks='CA#" & VoucherNo & " Reimbursed', " _
                                          + " debit='" & Val(CC(GridView1.GetRowCellValue(GridView1.GetSelectedRows(x), "Amount Reimbursed").ToString)) & "', " _
                                          + " credit=0,datetrn=current_timestamp,trnby='" & globaluserid & "',cleared=1,clearedby='" & globaluserid & "',datecleared=current_timestamp " : com.ExecuteNonQuery()
                End If

                com.CommandText = "insert into tblglaccountledger (journalmode,accountno, referenceno, itemcode,remarks, debit, credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                    + " select 'payable-accounts', vendorid,'" & VoucherNo & "','Voucher','Cash advance',0,totalamount,current_timestamp,'" & globaluserid & "',1,'" & globaluserid & "',current_timestamp from tblpurchaseorder where paymentrefnumber='" & VoucherNo & "' and ap=0 " : com.ExecuteNonQuery()


                com.CommandText = "update tblpurchaseorder set paymentupdated=1, closed=1, dateclosed=current_timestamp where paymentrefnumber='" & VoucherNo & "' and ap=0" : com.ExecuteNonQuery()
                com.CommandText = "update tbldisbursementvoucher set clearedliquidation=1 where voucherno='" & VoucherNo & "'" : com.ExecuteNonQuery()
                If EnableModuleAccounting = True Then
                    com.CommandText = "CALL sp_acct_entries('" & VoucherNo & "', '" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(x), "officeid").ToString & "','VOUCHER_LIQUIDITION','')" : com.ExecuteNonQuery()
                End If
                RecordApprovingHistory("voucher", VoucherNo, VoucherNo, "liquidation", "liquidation cleared")
            Next
            FilterVoucherSummary()
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show("Transaction successfully cleared", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ReOpenLiquidationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdReopen.Click
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            For x = 0 To GridView1.SelectedRowsCount - 1
                Dim VoucherNo As String = GridView1.GetRowCellValue(GridView1.GetSelectedRows(x), "Voucher No.").ToString
                com.CommandText = "update tbldisbursementvoucher set liquidated=0, dateliquidated=current_timestamp where voucherno='" & VoucherNo & "'" : com.ExecuteNonQuery()
                RecordApprovingHistory("voucher", VoucherNo, VoucherNo, "liquidation", "liquidation re-opened")
            Next
            FilterVoucherSummary()
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show("Transaction successfully cleared", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdLiquidate_Click(sender As Object, e As EventArgs) Handles cmdLiquidate.Click
        frmVoucherLiquiditionForm.voucherno.Text = GridView1.GetFocusedRowCellValue("Voucher No.").ToString()
        frmVoucherLiquiditionForm.ShowDialog(Me)
    End Sub

    Private Sub PrintLiquiditionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintLiquiditionToolStripMenuItem.Click
        PrintLiquidationReport(GridView1.GetFocusedRowCellValue("Voucher No.").ToString(), Me, True)
    End Sub
End Class