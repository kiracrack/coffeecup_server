Imports MySql.Data.MySqlClient
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraSplashScreen

Public Class frmAPSummaryList
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
        FilterOption()
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        FilterOption()
    End Sub

    Public Sub FilterOption()
        If XtraTabControl1.SelectedTabPage Is tabCorporate Then
            Em.Parent = XtraTabControl1.SelectedTabPage
            FilterCorporatePayable(True)
        Else
            Em.Parent = XtraTabControl1.SelectedTabPage
            FilterCorporatePayable(False)
        End If
    End Sub

    Public Function FilterCorporatePayable(ByVal corporate As Boolean)
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = " and date_format(datetrn,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " and date_format(datetrn,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If
        dst.EnforceConstraints = False
        dst.Relations.Clear() : Em.LevelTree.Nodes.Clear()
        dst.Clear()
        LoadXgrid("select voucherno as 'Payable No.', hold, vendorid, officeid,  if(cancelled=1,'Cancelled',if(hold=1,'Hold',if(cleared=1,'Cleared',if(verified=1,'Approved','For Approval')))) as 'Status', " _
                                    + " date_format(voucherdate,'%Y-%m-%d') as 'Date', (select officename from tblcompoffice where officeid=tbldisbursementvoucher.officeid) as 'Office', " _
                                    + " (select companyname from tblglobalvendor where vendorid=tbldisbursementvoucher.vendorid) as 'Supplier', Amount, " _
                                    + "  Note, date_format(datetrn,'%Y-%m-%d %r') as 'Date Posted', (select fullname from tblaccounts where accountid=tbldisbursementvoucher.trnby) as 'Posted By', Verified as Approved, if(Verified=1,date_format(dateverified,'%Y-%m-%d %r') ,'-') as 'Date Approved', Cleared,date_format(datecleared,'%Y-%m-%d') as 'Date Cleared' " _
                                    + "   from tbldisbursementvoucher where corporatelevel=" & corporate & If(ckPendingRequest.Checked = True, " and (cleared=0 and cancelled=0) ", filterasof) & "  order by datetrn desc", "tbldisbursementvoucher", Em, GridView1, Me)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tbldisbursementvoucher")

        GridView1.BestFitColumns()
        XgridColCurrency({"Amount"}, GridView1)
        XgridHideColumn({"itemcode", "vendorid", "officeid", "hold"}, GridView1)
        XgridColAlign({"Payable No.", "Office", "Date", "Status", "Date Posted", "Date Verified", "Date Approved", "DatePaymentPosted", "Date Cleared", "Date Cancelled"}, GridView1, HorzAlignment.Center)
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
        If GLobalEnableElectronicVoucher = True Then
            If CBool(GridView1.GetFocusedRowCellValue("Approved").ToString) = True Then
                cmdEditVoucher.Visible = False
            Else
                cmdEditVoucher.Visible = True
            End If
        Else
            cmdEditVoucher.Visible = True
        End If
        If CBool(GridView1.GetFocusedRowCellValue("Cleared").ToString) = True Then
            cmdEditVoucher.Visible = False
            cmdCancelled.Visible = False
        Else
            cmdCancelled.Visible = True
        End If
    End Sub


    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        FilterOption()
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
        FilterOption()
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
        FilterOption()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        frmAPPaymentRequest.ShowDialog(Me)
    End Sub

    Private Sub EditVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdEditVoucher.Click
        If CBool(GridView1.GetFocusedRowCellValue("hold")) = False Then
            XtraMessageBox.Show("only hold payable can be revise", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmAPPaymentRequest.mode.Text = "edit"
        frmAPPaymentRequest.txtVoucherNo.Text = GridView1.GetFocusedRowCellValue("Payable No.").ToString()
        If frmAPPaymentRequest.Visible = True Then
            frmAPPaymentRequest.Focus()
        Else
            frmAPPaymentRequest.ShowDialog(Me)
        End If
    End Sub

    Private Sub cmdViewItem_Click(sender As Object, e As EventArgs) Handles cmdViewItem.Click
        frmAPPaymentRequest.mode.Text = "view"
        frmAPPaymentRequest.txtVoucherNo.Text = GridView1.GetFocusedRowCellValue("Payable No.").ToString()
        If frmAPPaymentRequest.Visible = True Then
            frmAPPaymentRequest.Focus()
        Else
            frmAPPaymentRequest.ShowDialog(Me)
        End If
    End Sub

    Private Sub CancelVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdCancelled.Click
        If GridView1.GetFocusedRowCellValue("Payable No.").ToString = "" Then
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
                    com.CommandText = "update tbldisbursementvoucher set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where voucherno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Payable No.").ToString & "'" : com.ExecuteNonQuery()
                    RecordApprovingHistory("voucher", GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Payable No.").ToString, GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Payable No.").ToString, "Cancelled", "")

                    com.CommandText = "UPDATE tblpurchaseorder set paymentrequested=0,paymentrequestedby='', paymentrefnumber='' where paymentrefnumber='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Payable No.").ToString & "'" : com.ExecuteNonQuery()
                    com.CommandText = "DELETE FROM tbldisbursementdetails where voucherno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Payable No.").ToString & "'" : com.ExecuteNonQuery()
                End If
            Next
            FilterOption()
            XtraMessageBox.Show("Transaction successfully cancelled", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
     
 
End Class