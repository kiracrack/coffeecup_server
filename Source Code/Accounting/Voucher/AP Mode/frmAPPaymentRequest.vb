﻿Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient

Public Class frmAPPaymentRequest
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmAPPaymentRequest_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmAPPaymentRequest_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If countqry("tbldisbursementvoucher", "voucherno='" & txtVoucherNo.Text & "'") = 0 Then
            If countqry("tblpurchaseorder", "paymentrefnumber='" & txtVoucherNo.Text & "'") > 0 Or countqry("tbldisbursementexpense", "voucherno='" & txtVoucherNo.Text & "'") > 0 Then
                If XtraMessageBox.Show("System found an voucher transaction not validated save yet! Are you sure you want to cancel voucher?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    com.CommandText = "UPDATE tblpurchaseorder set  paymentrequested=0,paymentrequestedby='', paymentrefnumber='' where paymentrefnumber='" & txtVoucherNo.Text & "'" : com.ExecuteNonQuery()
                    com.CommandText = "DELETE FROM tbldisbursementexpense where voucherno='" & txtVoucherNo.Text & "'" : com.ExecuteNonQuery()
                    com.CommandText = "DELETE FROM tbldisbursementdetails where voucherno='" & txtVoucherNo.Text & "'" : com.ExecuteNonQuery()
                Else
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
    Private Sub frmVoucherPaymentRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadOffice()
        LoadSupplier()
        If mode.Text = "edit" Then
            ShowPayableInfo()
            EnableControls(False)
        ElseIf mode.Text = "view" Then
            ShowPayableInfo()
            EnableControls(True)
        ElseIf mode.Text = "direct" Then

            EnableControls(False)
        Else
            GenerateVoucherReference()
            EnableControls(False)
        End If
        LoadVoucherExpenses()
        filterApprovalLogs()
    End Sub

    Public Sub EnableControls(ByVal readonlyForm As Boolean)
        txtOffice.ReadOnly = readonlyForm
        txtSupplier.ReadOnly = readonlyForm
        txtNote.ReadOnly = readonlyForm
        If readonlyForm = True Then
            cmdSubmit.Visible = False
            cmdAddPayableItem.Visible = False
            Em.ContextMenuStrip = Nothing
        Else
            cmdSubmit.Visible = True
            cmdAddPayableItem.Visible = True
            Em.ContextMenuStrip = gridmenustrip
        End If
    End Sub

    Public Sub ShowPayableInfo()
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select * from tbldisbursementvoucher where voucherno='" & txtVoucherNo.Text & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                officeid.Text = .Rows(cnt)("officeid").ToString
                txtOffice.Text = .Rows(cnt)("officeid").ToString
                txtSupplier.Text = .Rows(cnt)("vendorid").ToString()
                claimantid.Text = .Rows(cnt)("vendorid").ToString()
                txtNote.Text = .Rows(cnt)("note").ToString()
            End With
        Next
    End Sub

    Public Sub GenerateVoucherReference()
        'txtVoucherNo.ReadOnly = True
        txtVoucherNo.Text = getVourcherNumberSequence()
        com.CommandText = "UPDATE tblgeneralsettings set vouchernosequence='" & txtVoucherNo.Text & "'" : com.ExecuteNonQuery()
    End Sub

    Public Sub LoadOffice()
        If mode.Text = "edit" Then
            LoadXgridLookupSearch("select officeid, (select officename from tblcompoffice where officeid=tbldisbursementvoucher.officeid) as 'Office' from tbldisbursementvoucher where voucherno='" & txtVoucherNo.Text & "'", "tbldisbursementvoucher", txtOffice, gridoffice, Me)
        ElseIf mode.Text = "direct" Then
            LoadXgridLookupSearch("select distinct officeid, (select officename from tblcompoffice where officeid=tblpurchaseorder.officeid) as 'Office' from tblpurchaseorder where corporatelevel=1 and verified=1 and cancelled=0 order by (select officename from tblcompoffice where officeid=tblpurchaseorder.officeid) asc", "tblpurchaseorder", txtOffice, gridoffice, Me)
        Else
            LoadXgridLookupSearch("select distinct officeid, (select officename from tblcompoffice where officeid=tblpurchaseorder.officeid) as 'Office' from tblpurchaseorder where corporatelevel=1 and verified=1 and forwarded=1 and paymentrequested=0 and cancelled=0 order by (select officename from tblcompoffice where officeid=tblpurchaseorder.officeid) asc", "tblpurchaseorder", txtOffice, gridoffice, Me)
        End If
        gridoffice.Columns("officeid").Visible = False
    End Sub

    Private Sub txtOffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOffice.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtOffice.Properties.View.FocusedRowHandle.ToString)
        officeid.Text = txtOffice.Properties.View.GetFocusedRowCellValue("officeid").ToString()
        LoadSupplier()
    End Sub

    Public Sub LoadSupplier()
        If mode.Text = "edit" Or mode.Text = "view" Then
            LoadXgridLookupSearch("select vendorid, (select companyname from tblglobalvendor where vendorid=tbldisbursementvoucher.vendorid) as 'Supplier' from tbldisbursementvoucher where voucherno='" & txtVoucherNo.Text & "'", "tbldisbursementvoucher", txtSupplier, gridVendorAccount, Me)
        ElseIf mode.Text = "direct" Then
            LoadXgridLookupSearch("select distinct vendorid, (select companyname from tblglobalvendor where vendorid=tblpurchaseorder.vendorid) as 'Supplier' from tblpurchaseorder where officeid='" & officeid.Text & "' and corporatelevel=1 and verified=1 and cancelled=0 order by (select companyname from tblglobalvendor where vendorid=tblpurchaseorder.vendorid) asc", "tblpurchaseorder", txtSupplier, gridVendorAccount, Me)
        Else
            If officeid.Text = "" Then Exit Sub
            LoadXgridLookupSearch("select distinct vendorid, (select companyname from tblglobalvendor where vendorid=tblpurchaseorder.vendorid) as 'Supplier' from tblpurchaseorder where officeid='" & officeid.Text & "' and corporatelevel=1 and verified=1 and forwarded=1 and paymentrequested=0 and cancelled=0 order by (select companyname from tblglobalvendor where vendorid=tblpurchaseorder.vendorid) asc", "tblpurchaseorder", txtSupplier, gridVendorAccount, Me)
        End If
        gridVendorAccount.Columns("vendorid").Visible = False
    End Sub

    Private Sub txtClientAccount_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSupplier.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtSupplier.Properties.View.FocusedRowHandle.ToString)
        claimantid.Text = txtSupplier.Properties.View.GetFocusedRowCellValue("vendorid").ToString()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadVoucherExpenses()
    End Sub

    Public Sub LoadVoucherExpenses()
        LoadXgrid("select id,date_format(datetrn,'%Y-%m-%d') as 'Date', ponumber as 'PO Number', if(forpo=1,'Purchase Order','Payment Request') as 'Description', invoiceno as 'Invoice No.', Amount,Note from tbldisbursementdetails where voucherno='" & txtVoucherNo.Text & "' order by datetrn asc", "tbldisbursementdetails", Em, GridView1, Me)

        XgridHideColumn({"id"}, GridView1)
        XgridColAlign({"PO Number", "Payable Type", "Date", "Invoice No."}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Amount"}, GridView1)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
        'XgridColWidth({"Description"}, GridView1, 200)
        XgridColWidth({"Amount"}, GridView1, 100)

        If GridView1.RowCount > 0 Then
            txtOffice.ReadOnly = True
            txtSupplier.ReadOnly = True
        Else
            txtOffice.ReadOnly = False
            txtSupplier.ReadOnly = False
        End If

        filterApprovalLogs()
    End Sub


    Public Sub filterApprovalLogs()
        LoadXgrid("select CONFIRMBY as 'Confirmed by', " _
                      + " Position as 'Position', " _
                      + " Remarks, " _
                      + " CONCAT(UCASE(SUBSTRING(tblapprovalhistory.`status`, 1, 1)),LOWER(SUBSTRING(tblapprovalhistory.`status`, 2)))  as 'Status', " _
                      + " DATECONFIRM as 'Date Confirmed' " _
                      + " from tblapprovalhistory  " _
                      + " WHERE referenceno = '" & txtVoucherNo.Text & "' and appdescription='payable' order by DATECONFIRM asc", "tblapprovalhistory", Em_ApprovalLog, GridView_ApprovalLog, Me)

        GridView_ApprovalLog.Columns("Remarks").ColumnEdit = MemoEdit
        GridView_ApprovalLog.Columns("Remarks").Width = 200
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdAddPayableItem.Click
        If txtSupplier.Text = "" Then
            MessageBox.Show("Please select supplier!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSupplier.Focus()
            Exit Sub
        End If
        frmAPPOSelect.lblSupplier.Text = txtSupplier.Text
        frmAPPOSelect.voucherno.Text = txtVoucherNo.Text
        frmAPPOSelect.officeid.Text = officeid.Text
        frmAPPOSelect.vendorid.Text = claimantid.Text
        frmAPPOSelect.ShowDialog(Me)
    End Sub


    Private Sub ViewPurchaseOrderProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPurchaseOrderProfileToolStripMenuItem.Click
        frmPurchaseOrderProfile.ponumber.Text = GridView1.GetFocusedRowCellValue("PO Number").ToString
        If frmPurchaseOrderProfile.Visible = True Then
            frmPurchaseOrderProfile.Focus()
        Else
            frmPurchaseOrderProfile.Show(Me)
        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "UPDATE tblpurchaseorder set paymentrequested=0,paymentrequestedby='', paymentrefnumber='' where ponumber='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "PO Number").ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "DELETE FROM tbldisbursementdetails where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
            Next
            LoadVoucherExpenses()
        End If
    End Sub

    Private Sub AddPayableItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPayableItemToolStripMenuItem.Click
        cmdAddPayableItem.PerformClick()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        frmAPConfirmedVoucherProcessing.ShowDialog(Me)
    End Sub
    Public Sub SubmitVoucher(ByVal message As String)
        If mode.Text = "edit" Then
            RecordApprovingHistory("payable", txtVoucherNo.Text, txtVoucherNo.Text, "revised", rchar(message))
            com.CommandText = "UPDATE tbldisbursementvoucher set voucherdate=current_date,directexpense=0, companyid='" & GlobalCompanyID & "', officeid='" & officeid.Text & "',itemcode='Payable', vendorid='" & claimantid.Text & "', amount='" & Val(CC(GridView1.Columns("Amount").SummaryText)) & "',sourcefund='', note='" & rchar(txtNote.Text) & "', hold=0, corporatelevel=1, datetrn=current_timestamp, trnby='" & globaluserid & "' where voucherno='" & txtVoucherNo.Text & "'" : com.ExecuteNonQuery()
            NextEmailAccountPayableApprover(txtVoucherNo.Text, officeid.Text, "Accounts Payable", True, "")
            MessageBox.Show("Voucher successfully posted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            RecordApprovingHistory("payable", txtVoucherNo.Text, txtVoucherNo.Text, "processed", rchar(message))
            com.CommandText = "insert into tbldisbursementvoucher set voucherno='" & txtVoucherNo.Text & "',voucherdate=current_date,directexpense=0, companyid='" & GlobalCompanyID & "', officeid='" & officeid.Text & "',itemcode='Voucher', vendorid='" & claimantid.Text & "', amount='" & Val(CC(GridView1.Columns("Amount").SummaryText)) & "',sourcefund='', note='" & rchar(txtNote.Text) & "', corporatelevel=1, datetrn=current_timestamp, trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
            NextEmailAccountPayableApprover(txtVoucherNo.Text, officeid.Text, "Accounts Payable", True, "")
            MessageBox.Show("Voucher successfully posted and subject for approval!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GenerateApprovedAP(True, txtVoucherNo.Text, txtSupplier.Text, frmAPSummaryList.GridView_Voucher, frmAPSummaryList.Em_Voucher, Me)
       
    End Sub
End Class