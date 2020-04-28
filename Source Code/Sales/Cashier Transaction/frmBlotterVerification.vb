Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports System.IO
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmBlotterVerification
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmApprovalChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)

        loadCashTo()
        LoadGridviewAppearance(gridCashTo)
        LoadSystemCashEnd()
        LoadBlottersTransaction()
        If EnableModuleAccounting = True Then
            Me.Width = 1164
            Em.Visible = True
            LoadSAccountingEntriesSummary()
        Else
            Em.Visible = False
            Me.Width = 485
        End If
    End Sub
    Public Sub LoadSAccountingEntriesSummary()
        com.CommandText = "CALL sp_acct_cashier('" & trncode.Text & "',FALSE)" : com.ExecuteNonQuery()
        LoadXgrid("select ifnull((select officename from tblcompoffice where officeid=a.officeid),'Reconciling office not configured') as 'Office',ItemCode,ifnull((select itemname from tblglitem where itemcode=a.itemcode),if(itemcode='','Account title not configured','Invalid account configuration')) as 'Item Name',ReferenceNo, Explaination, Debit, Credit from tmpcashiersblotterview as a;", "tmpcashiersblotterview", Em, GridView1, Me)
        ' GridView1.Columns("Transaction Type").Group()
        XgridColCurrency({"Debit", "Credit"}, GridView1)
        XgridColWidth({"Details"}, GridView1, 350)
        XgridColWidth({"Debit", "Credit"}, GridView1, 120)
        XgridColAlign({"ReferenceNo", "ItemCode"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Debit", "Credit"}, GridView1)

        com.CommandText = "select * from tblcolumnindex where form='" & Me.Name & "' and gridview='" & GridView1.Name & "' order by colindex asc" : rst = com.ExecuteReader
        While rst.Read
            GridView1.Columns(rst("columnname").ToString).VisibleIndex = rst("colindex")
            If Val(rst("columnwidth").ToString) > 0 Then
                GridView1.Columns(rst("columnname").ToString).Width = Val(rst("columnwidth").ToString)
            End If
        End While
        rst.Close()
    End Sub

    Private Sub GridView1_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles GridView1.ColumnWidthChanged
        UpdateGridColumnSetting(Me.Name, GridView1)
    End Sub

    Private Sub GridView1_DragObjectDrop(sender As Object, e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles GridView1.DragObjectDrop
        UpdateGridColumnSetting(Me.Name, GridView1)
    End Sub


    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If View.GetRowCellDisplayText(e.RowHandle, View.Columns("Item Name")).ToString = "Account title not configured" Or View.GetRowCellDisplayText(e.RowHandle, View.Columns("Item Name")).ToString = "Invalid account configuration" Or View.GetRowCellDisplayText(e.RowHandle, View.Columns("Office")).ToString = "Reconciling office not configured" Then
            e.Appearance.ForeColor = Color.Red
        End If
    End Sub

    Public Sub LoadSystemCashEnd()
        com.CommandText = "CALL sp_salesremittance('CONSOLIDATED','" & trncode.Text & "','')" : com.ExecuteNonQuery()
        com.CommandText = "select * from tmpconsolidateddetails where trntype='cash'" : rst = com.ExecuteReader
        While rst.Read
            txtCashEnd.Text = FormatNumber(rst("amount").ToString, 2)
        End While
        rst.Close()
    End Sub

    Public Sub LoadBlottersTransaction()
        com.CommandText = "select *, if(backdatetrn=1, date_format(backdate,'%Y-%m-%d') , date_format(dateopen,'%Y-%m-%d')) as datetrn, (select fullname from tblaccounts where accountid=tblsalessummary.userid) as 'Cashier' from tblsalessummary where trncode='" & trncode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtCashier.Text = rst("Cashier").ToString
            cashfrom.Text = rst("cashfrom").ToString
            officeid.Text = rst("officeid").ToString
            txtdateTransaction.Text = rst("dateclose").ToString
            txtCashOnHand.Text = FormatNumber(rst("cashonhand").ToString, 2)
            txtNextBeginningCash.Text = FormatNumber(rst("nextbeginningcash").ToString, 2)

            txtAmountDeposit.Text = FormatNumber(Val(rst("cashonhand").ToString) - Val(rst("nextbeginningcash").ToString), 2)
            txtRemarks.Text = ConvertDate(rst("datetrn").ToString) & " - " & rst("Cashier").ToString
        End While
        rst.Close()
        ComputeVariance()
    End Sub

    Public Sub ComputeVariance()
        Dim Variance As Double = 0
        Variance = Val(CC(txtCashOnHand.Text)) - Val(CC(txtCashEnd.Text))
        If Variance > 0 Then
            txtOverages.Text = FormatNumber(Variance, 2)
        ElseIf Variance < 0 Then
            txtShortages.Text = FormatNumber(-Variance, 2)
        Else
            txtShortages.Text = "0.00"
            txtOverages.Text = "0.00"
        End If
    End Sub

    Public Sub loadCashTo()
        LoadXgridLookupEdit("select bankcode, accountname as 'Account Name' from tblbankaccounts where (bankaccounts=1 or cashaccount=1)", "tblbankaccounts", txtCashTo, gridCashTo, Me)

        gridCashTo.Columns("bankcode").Visible = False
        gridCashTo.SelectRow(1)
    End Sub

    Private Sub txtCashTo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCashTo.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCashTo.Properties.View.FocusedRowHandle.ToString)
        cashTo.Text = txtCashTo.Properties.View.GetFocusedRowCellValue("bankcode").ToString()
        txtCashTo.Text = txtCashTo.Properties.View.GetFocusedRowCellValue("Account Name").ToString()
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If EnableModuleAccounting = True Then
            Dim DisableVerification As Boolean = False
            For I = 0 To GridView1.RowCount - 1
                If GridView1.GetRowCellValue(I, "Item Name").ToString = "Account title not configured" Or GridView1.GetRowCellValue(I, "Item Name").ToString = "Invalid account configuration" Or GridView1.GetRowCellValue(I, "Office").ToString = "Reconciling office not configured" Then
                    DisableVerification = True
                End If
            Next
            If DisableVerification = True Then
                XtraMessageBox.Show("Some account title in accounting entries are currently not configured! Please make sure all " & Environment.NewLine & "account title are properly tagged and configured! ", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Val(CC(txtOverages.Text)) > 0 And qrysingledata("glcodeaccountsoverages", "glcodeaccountsoverages", "tblgldefaultitem") = "" And EnableModuleAccounting = True Then
                XtraMessageBox.Show("Overages account title currently not configured! Please contact your system administrator", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf Val(CC(txtShortages.Text)) > 0 And qrysingledata("glcodeaccountsshortages", "glcodeaccountsshortages", "tblgldefaultitem") = "" And EnableModuleAccounting = True Then
                XtraMessageBox.Show("Shortages account title currently not configured! Please contact your system administrator", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf Val(CC(GridView1.Columns("Debit").SummaryText)) <> Val(CC(GridView1.Columns("Credit").SummaryText)) And EnableModuleAccounting = True Then
                XtraMessageBox.Show("There's a descripancy on cashier's accounting entries! Please contact your system administrator", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        If txtCashTo.Text = "" And Val(CC(txtAmountDeposit.Text)) > 0 Then
            XtraMessageBox.Show("Please select depository account!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCashTo.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim gltoken As String = CreateGLTicketToken(trncode.Text, globaluserid)
            com.CommandText = "update tblsalessummary set gltoken='" & gltoken & "', " _
                             + " verified=1,dateverified=current_timestamp, " _
                             + " verifiedby='" & globaluserid & "', " _
                             + " cashend='" & Val(CC(txtCashEnd.Text)) & "', " _
                             + " cashonhand='" & Val(CC(txtCashOnHand.Text)) & "', " _
                             + " amountdeposited='" & Val(CC(txtAmountDeposit.Text)) & "', " _
                             + " overages='" & Val(CC(txtOverages.Text)) & "', " _
                             + " shortages='" & Val(CC(txtShortages.Text)) & "', " _
                             + " bankdeposited='" & cashTo.Text & "', " _
                             + " depositrefnumber='" & txtdepositref.Text & "' " _
                             + " where trncode='" & trncode.Text & "'" : com.ExecuteNonQuery()
            If EnableModuleAccounting = True Then
                If Val(CC(txtOverages.Text)) > 0 Then
                    com.CommandText = "CALL sp_acct_entries('" & officeid.Text & "','" & trncode.Text & "', 'OVERAGES','')" : com.ExecuteNonQuery()
                End If
                If Val(CC(txtShortages.Text)) > 0 Then
                    com.CommandText = "CALL sp_acct_entries('" & officeid.Text & "','" & trncode.Text & "', 'SHORTAGES','')" : com.ExecuteNonQuery()
                End If
                com.CommandText = "CALL sp_acct_cashier('" & trncode.Text & "',TRUE)" : com.ExecuteNonQuery()
            End If
            frmCashiersBlotter.LoadCurrentBlotter()
            XtraMessageBox.Show("Cashier's blotter successfuly verified!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub txtAmountDeposit_EditValueChanged(sender As Object, e As EventArgs) Handles txtAmountDeposit.EditValueChanged
        If Val(CC(txtAmountDeposit.Text)) > 0 Then
            PanelControl1.Enabled = True
        Else
            PanelControl1.Enabled = False
        End If
    End Sub

    Private Sub RefreshLedgerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshLedgerToolStripMenuItem.Click
        LoadSAccountingEntriesSummary()
    End Sub

    Private Sub ShortcutToProductCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShortcutToProductCategoryToolStripMenuItem.Click
        If frmProductCategory.Visible = True Then
            frmProductCategory.Focus()
        Else
            frmProductCategory.Show(Me)
        End If
    End Sub
End Class