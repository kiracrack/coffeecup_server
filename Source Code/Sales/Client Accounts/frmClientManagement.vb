Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmClientManagement
    Private Sub Vendors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)

        LoadClientGroup()
        filterClient()
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdBarAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            cmdClientAcctFilter.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            cmdClientFilter.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            cmdClientGroup.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            cmdSetClientGroup.Visible = True
        Else
            cmdClientAcctFilter.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            cmdBarAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            cmdClientFilter.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            cmdClientGroup.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            cmdSetClientGroup.Visible = False
        End If
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdClientFilter.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            cmdEdit.Visible = True
            cmdSetClientGroup.Visible = True
        Else
            cmdClientFilter.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            cmdEdit.Visible = False
            cmdSetClientGroup.Visible = False
        End If
        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdDelete.Visible = True
        Else
            cmdDelete.Visible = False
        End If
    End Sub
    Public Sub LoadClientGroup()
        LoadToComboBox("groupname", "tblclientgroup", txtClientGroup, True)
        If countqry("tblclientaccounts", "groupcode not in (select groupcode from tblclientgroup) and deleted=0") > 0 Then
            txtClientGroup.Properties.Items.Add("(Uncategorized)")
        End If
        'groupcode.Text = qrysingledata("groupcode", "groupcode", "where `default`", "tblclientgroup")
        'txtClientGroup.Text = qrysingledata("groupname", "groupname", "where `default`", "tblclientgroup")
    End Sub
    Public Sub filterClient()

        LoadXgrid("Select walkinaccount,cifid as 'Client ID',  COMPANYNAME as 'Client Name', codename as 'Code Name', COMPADD as 'Address',  TELEPHONE as 'Telephone', birthdate as 'Birth Date',emailadd as 'Email', " _
                  + "ifnull((select sum(debit)-sum(credit) from tblglaccountledger where accountno=tblclientaccounts.cifid and cancelled=0),0) as 'Balance Due', creditlimitamount as 'Credit Limit', enabledue as 'Enable Term',duetype as 'Term Type',case when duetype ='DAYS' then concat('Every ',duevalue, ' day(s) after from charge invoice') when duetype='WEEK' then concat('Every ', date_format(DATE_ADD(current_date, INTERVAL ((7+duevalue) - DAYOFWEEK(current_date)) DAY),'%W'),' of the Week') when duetype='MONTH' then concat('Every ',date_format(STR_TO_DATE(duevalue,'%D'),'%D'), ' day of the month') end as 'Term', skipdiscount as 'Skip Discount', Blocked,BlockedReason from tblclientaccounts where  " & If(ckViewAll.Checked = True, "", If(txtClientGroup.Text = "(Uncategorized)", " groupcode not in (select groupcode from tblclientgroup) ", "groupcode='" & groupcode.Text & "'") & "  and ") & " deleted=0 order by COMPANYNAME asc ", "tblclientaccounts", Em, GridView1, Me)

        XgridHideColumn({"Client ID", "walkinaccount"}, GridView1)
        GridView1.Columns("Client Name").Width = 350
        XgridColAlign({"Client ID", "Birth Date", "Email", "Enable Due", "Due Type", "Pending Invoices", "VIP"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Balance Due", "Credit Limit"}, GridView1)
        GridView1.Columns("Address").ColumnEdit = MemoEdit
        XgridGeneralSummaryCurrency({"Balance Due"}, GridView1)

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
        If View.GetRowCellDisplayText(e.RowHandle, View.Columns("Blocked")).ToString = "Checked" Then
            e.Appearance.ForeColor = Color.Red
        Else
            e.Appearance.ForeColor = DefaultForeColor
        End If

    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If CBool(GridView1.GetFocusedRowCellValue("walkinaccount").ToString) = True Then
            XtraMessageBox.Show("Walkin account not allowed", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Client ID") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmClientModification.mode.Text = ""
        frmClientModification.id.Text = GridView1.GetFocusedRowCellValue("Client ID").ToString
        frmClientModification.mode.Text = "edit"
        If frmClientModification.Visible = True Then
            frmClientModification.Focus()
        Else
            frmClientModification.Show(Me)
        End If
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If CBool(GridView1.GetFocusedRowCellValue("walkinaccount").ToString) = True Then
            XtraMessageBox.Show("Walkin account not allowed", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Client ID") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "UPDATE tblclientaccounts set deleted=1 where cifid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Client ID").ToString & "'" : com.ExecuteNonQuery()
            Next
            filterClient()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filterClient()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdBarAdd.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmClientModification.Visible = True Then
            frmClientModification.Focus()
        Else
            frmClientModification.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        GridView1.ShowFindPanel()
    End Sub

    Private Sub FormatGridToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    Private Sub ViewInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdProductFilter.Click
        If GridView1.GetFocusedRowCellValue("Client ID") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        frmClientProductFilter.cifid.Text = GridView1.GetFocusedRowCellValue("Client ID").ToString
        If frmClientProductFilter.Visible = True Then
            frmClientProductFilter.Focus()
        Else
            frmClientProductFilter.Show(Me)
        End If
    End Sub

    Private Sub ViewInformationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewInformationToolStripMenuItem1.Click
        If countqry("tblclientaccounts", "walkinaccount=1 and cifid='" & GridView1.GetFocusedRowCellValue("Client ID") & "'") > 0 Then
            XtraMessageBox.Show("Walkin account is not allowed to continue this function", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Client ID") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmBillingStatement.mode.Text = "view"
        frmBillingStatement.accountno.Text = GridView1.GetFocusedRowCellValue("Client ID").ToString
        frmBillingStatement.txtClient.Text = GridView1.GetFocusedRowCellValue("Client Name").ToString
        frmBillingStatement.txtClient.Properties.ReadOnly = True
        frmBillingStatement.Show(Me)
    End Sub

    Private Sub StatementOfAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatementOfAccountToolStripMenuItem.Click
        If countqry("tblclientaccounts", "walkinaccount=1 and cifid='" & GridView1.GetFocusedRowCellValue("Client ID") & "'") > 0 Then
            XtraMessageBox.Show("Walkin account is not allowed to continue this function", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Client ID") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        frmStatementOfAccount.mode.Text = "view"
        frmStatementOfAccount.accountno.Text = GridView1.GetFocusedRowCellValue("Client ID").ToString
        frmStatementOfAccount.txtClient.Text = GridView1.GetFocusedRowCellValue("Client Name").ToString
        frmStatementOfAccount.txtClient.Properties.ReadOnly = True
        frmStatementOfAccount.Show(Me)
    End Sub

    Private Sub PaymentTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentTransactionToolStripMenuItem.Click
        frmClientPaymentHistory.accountno.Text = GridView1.GetFocusedRowCellValue("Client ID").ToString
        frmClientPaymentHistory.Text = "Payment History of " & StrConv(GridView1.GetFocusedRowCellValue("Client Name").ToString, VbStrConv.ProperCase)
        frmClientPaymentHistory.Show(Me)
    End Sub

    Private Sub TransactionHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionHistoryToolStripMenuItem.Click
        frmClientTransactionHistory.accountno.Text = GridView1.GetFocusedRowCellValue("Client ID").ToString
        frmClientTransactionHistory.Text = "Transaction History of " & StrConv(GridView1.GetFocusedRowCellValue("Client Name").ToString, VbStrConv.ProperCase)
        If frmClientTransactionHistory.Visible = True Then
            frmClientTransactionHistory.Focus()
        Else
            frmClientTransactionHistory.Show(Me)
        End If

    End Sub

    Private Sub cmdColumnFilter_Click(sender As Object, e As EventArgs)
        Dim colname As String = ""
        Dim I As Integer = 0
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView1, Me.Text)
        frmColumnFilter.ShowDialog(Me)
    End Sub

    Private Sub UpdateInvoicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateInvoicesToolStripMenuItem.Click
        If countqry("tblclientaccounts", "walkinaccount=1 and cifid='" & GridView1.GetFocusedRowCellValue("Client ID") & "'") > 0 Then
            XtraMessageBox.Show("Walkin account is not allowed to continue this function", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        frmUpdateAdvancePaymentInvoices.cifid.Text = GridView1.GetFocusedRowCellValue("Client ID").ToString
        frmUpdateAdvancePaymentInvoices.txtClientAccount.Text = GridView1.GetFocusedRowCellValue("Client Name").ToString
        frmUpdateAdvancePaymentInvoices.txtClientAccount.Properties.ReadOnly = True
        frmUpdateAdvancePaymentInvoices.Show(Me)
    End Sub

    Private Sub cmdClientFilter_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClientFilter.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmClientUserFilter.Visible = True Then
            frmClientUserFilter.Focus()
        Else
            frmClientUserFilter.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

   
    Private Sub txtClientGroup_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtClientGroup.SelectedValueChanged
        groupcode.Text = qrysingledata("groupcode", "groupcode", "where groupname='" & txtClientGroup.Text & "'", "tblclientgroup")
        filterClient()
    End Sub

    Private Sub cmdClientGroup_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClientGroup.ItemClick
        frmClientGroup.ShowDialog()
    End Sub
    Private Sub SetClientCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdSetClientGroup.Click
        frmSetClientGroup.Show(Me)
    End Sub
    Public Function SetClientGroup(ByVal groupcode As String)
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "update tblclientaccounts set groupcode='" & groupcode & "' where cifid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Client ID").ToString & "'" : com.ExecuteNonQuery()
        Next
        filterClient()
        Return 0
    End Function

     
    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClientAcctFilter.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmClientFilters.Visible = True Then
            frmClientFilters.Focus()
        Else
            frmClientFilters.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

   
    Private Sub ckViewAll_CheckedChanged(sender As Object, e As EventArgs) Handles ckViewAll.CheckedChanged
        If ckViewAll.Checked = True Then
            txtClientGroup.Enabled = False
            filterClient()
        Else
            txtClientGroup.Enabled = True
            filterClient()
        End If

    End Sub

    Private Sub ck_showzero_CheckedChanged(sender As Object, e As EventArgs)
        filterClient()
    End Sub

    Private Sub BarButtonItem1_ItemClick_2(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        ExportGridToExcel(Me.Text + "(" + If(ckViewAll.Checked = True, "all client", txtClientGroup.Text) + ")", GridView1)
    End Sub

    Public Function BlockClient(ByVal reason As String)
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "update tblclientaccounts set blocked=1,blockedreason='" & reason & "' where cifid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Client ID").ToString & "'" : com.ExecuteNonQuery()
        Next
        filterClient()
        XtraMessageBox.Show("Client successfully Blocked!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return 0
    End Function

  
    Private Sub BlockClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdBlock.Click
        If CBool(GridView1.GetFocusedRowCellValue("walkinaccount").ToString) = True Then
            XtraMessageBox.Show("Walkin account not allowed", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmBlockClientAccount.Show(Me)
    End Sub

    Private Sub cmdUnblock_Click(sender As Object, e As EventArgs) Handles cmdUnblock.Click
        If CBool(GridView1.GetFocusedRowCellValue("walkinaccount").ToString) = True Then
            XtraMessageBox.Show("Walkin account not allowed", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to Continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "update tblclientaccounts set blocked=0,blockedreason='' where cifid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Client ID").ToString & "'" : com.ExecuteNonQuery()
            Next
            filterClient()
            XtraMessageBox.Show("Client successfully Unblocked!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
 
  

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If frmClientTransactionHistory.Visible = True Then
            frmClientTransactionHistory.accountno.Text = GridView1.GetFocusedRowCellValue("Client ID").ToString
            frmClientTransactionHistory.Text = "Transaction History of " & StrConv(GridView1.GetFocusedRowCellValue("Client Name").ToString, VbStrConv.ProperCase)
        End If
    End Sub
End Class