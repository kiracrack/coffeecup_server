Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmAccountsRecevable
    Private Sub Vendors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        filterClient()
    End Sub
    
    Public Sub filterClient()
        LoadXgrid("Select walkinaccount,cifid as 'Client ID',  COMPANYNAME as 'Client Name', TELEPHONE as 'Telephone',  ifnull((select sum(debit)-sum(credit) from tblglaccountledger where accountno=cifid and cleared=1 and cancelled=0),0) as 'Balance Due', (select count(*) from tblsalesclientcharges where tblsalesclientcharges.accountno = tblclientaccounts.cifid and paymentupdated=0 and cancelled=0 and verified=1)  + (select count(*) from tblsalesaccounttransaction where tblsalesaccounttransaction.accountno = tblclientaccounts.cifid and debit > 0 and paymentupdated=0 and cancelled=0 and verified=1) as 'Pending Invoices', creditlimitamount as 'Credit Limit', enabledue as 'Enable Term',duetype as 'Term Type',case when duetype ='DAYS' then concat('Every ',duevalue, ' day(s) after from charge invoice') when duetype='WEEK' then concat('Every ', date_format(DATE_ADD(current_date, INTERVAL ((7+duevalue) - DAYOFWEEK(current_date)) DAY),'%W'),' of the Week') when duetype='MONTH' then concat('Every ',date_format(STR_TO_DATE(duevalue,'%D'),'%D'), ' day of the month') end as 'Term'  from tblclientaccounts where ifnull((select sum(debit)-sum(credit) from tblglaccountledger where accountno=cifid and cleared=1 and cancelled=0),0)<>0 and deleted=0 order by COMPANYNAME asc ", "tblclientaccounts", Em, GridView1, Me)

        XgridHideColumn({"Client ID", "walkinaccount"}, GridView1)
        GridView1.Columns("Client Name").Width = 350
        XgridColAlign({"Client ID", "Birth Date", "Email", "Enable Due", "Term Type", "Pending Invoices", "VIP"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Balance Due", "Credit Limit"}, GridView1)
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
        Dim status As Double = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Balance Due"))
        If status < 0 And e.Column.FieldName = "Balance Due" Then
            e.Appearance.ForeColor = Color.Red
        Else
            e.Appearance.ForeColor = DefaultForeColor
        End If
    End Sub
 
    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filterClient()
    End Sub
     
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        GridView1.ShowFindPanel()
    End Sub
     
    Private Sub ViewInformationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewInformationToolStripMenuItem1.Click
        If countqry("tblclientaccounts", "walkinaccount=1 and cifid='" & GridView1.GetFocusedRowCellValue("Client ID") & "'") > 0 Then
            XtraMessageBox.Show("Walkin account is not allowed to continue this function", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Client ID") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Pending Invoices").ToString = "0" Then
            XtraMessageBox.Show("There's no Pending Invoices to create billing", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
        frmClientTransactionHistory.Show(Me)
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
      
    Private Sub BarButtonItem1_ItemClick_2(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub
     

End Class