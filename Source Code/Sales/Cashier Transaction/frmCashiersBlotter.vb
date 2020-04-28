Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCashiersBlotter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtTrndate.EditValue = CDate(Now)
        LoadCurrentBlotter()
        If globalApproverPermission = True Or LCase(globaluser) = "root" Then
            ReopenTransactionToolStripMenuItem.Visible = True
        Else
            ReopenTransactionToolStripMenuItem.Visible = False
        End If
        LoadOffice()
    End Sub

    Public Sub LoadOffice()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Office' from tblcompoffice where officeid in (select officeid from tblsalessummary where verified=0 and cancelled=0) order by officename asc", "tblcompoffice", txtOffice, gv_Office, Me)
        gv_Office.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOffice.EditValueChanged
        On Error Resume Next
        officeid.Text = txtOffice.Properties.View.GetFocusedRowCellValue("officeid").ToString()
        LoadCurrentBlotter()
    End Sub

    Public Sub LoadCurrentBlotter()
        If officeid.Text = "" Then Exit Sub
        LoadXgrid("select officeid,userid, trncode as 'Transaction Code', if(backdatetrn=1, date_format(backdate,'%Y-%m-%d') , date_format(dateopen,'%Y-%m-%d')) as 'Transaction Date',(select officename from tblcompoffice where officeid=tblsalessummary.officeid) as 'Office', (select fullname from tblaccounts where accountid=tblsalessummary.userid) as 'Cashier', cashend as 'System Cash End',cashonhand as 'Actual Cash',if(overages=0,shortages,overages) as 'Variance', if(openfortrn=0,'CLOSED','OPEN') as 'Status'  from tblsalessummary where verified=0 and officeid='" & officeid.Text & "' and cancelled=0 " & If(CheckEdit1.Checked = True, "", " and if(backdatetrn=1, date_format(backdate,'%Y-%m-%d') , date_format(dateopen,'%Y-%m-%d')) ='" & ConvertDate(txtTrndate.EditValue) & "'"), "tblsalessummary", Em, GridView1, Me)
        GridView1.Columns("Office").Group()
        GridView1.ExpandAllGroups()
        XgridHideColumn({"officeid", "userid"}, GridView1)
        XgridColWidth({"Cashier"}, GridView1, 220)
        XgridColWidth({"System Cash End", "Actual Cash", "Variance"}, GridView1, 120)
        XgridColAlign({"Transaction Date", "Clearing Status", "Transaction Code", "Status"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"System Cash End", "Actual Cash", "Variance"}, GridView1)
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Status").ToString = "OPEN" Then
            XtraMessageBox.Show("Current cashier status currently open!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CheckSelectedRow("Transaction Code", GridView1) = True Then
           frmBlotterVerification.trncode.Text = GridView1.GetFocusedRowCellValue("Transaction Code").ToString
            frmBlotterVerification.Show(Me)
        End If
    End Sub
    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If gen_filterappearance = True Then
            If globalApproverPermission = True Or LCase(globaluser) = "root" Then
                Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Variance"))
                If e.Column.FieldName = "Variance" Then
                    If Val(CC(status)) < 0 Then
                        e.Appearance.ForeColor = Color.Red
                    End If
                End If
            End If
            
            Dim cashierstatus As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))
            If e.Column.FieldName = "Status" Then
                If cashierstatus = "OPEN" Then
                    e.Appearance.BackColor = Color.Lime
                    e.Appearance.ForeColor = Color.Black
               
                End If
            End If
        End If
    End Sub

    Private Sub ReopenTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReopenTransactionToolStripMenuItem.Click
        'If GridView1.GetFocusedRowCellValue("Status").ToString = "OPEN" Then
        '    XtraMessageBox.Show("Current cashier status currently open!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        'If countqry("tblsalessummary", "openfortrn=1 and userid='" & GridView1.GetFocusedRowCellValue("userid").ToString & "'") > 0 Then
        '    XtraMessageBox.Show("Selected cashier currently active and cannot be proceed! Please close previous transaction first", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        If CheckSelectedRow("Transaction Code", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to re-open selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "update tblsalessummary set openfortrn=1 where trncode='" & GridView1.GetFocusedRowCellValue("Transaction Code").ToString & "'" : com.ExecuteNonQuery()
                LoadCurrentBlotter()
                XtraMessageBox.Show("Transaction successfully opened", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub RefreshDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshDataToolStripMenuItem.Click
        LoadCurrentBlotter()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
 
    Private Sub ViewTransactionHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTransactionHistoryToolStripMenuItem.Click
        If CheckSelectedRow("Transaction Code", GridView1) = True Then
            frmPOSTransactionHistory.globalSalesTrnCOde.Text = GridView1.GetFocusedRowCellValue("Transaction Code").ToString
            frmPOSTransactionHistory.Text = "TRN# (" & GridView1.GetFocusedRowCellValue("Transaction Code").ToString & ") " & StrConv(GridView1.GetFocusedRowCellValue("Cashier").ToString, vbProperCase)
            If frmPOSTransactionHistory.Visible = False Then
                frmPOSTransactionHistory.Show(Me)
            End If
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            txtTrndate.Enabled = False
        Else
            txtTrndate.Enabled = True
        End If
        LoadCurrentBlotter()
    End Sub

    Private Sub txtTrndate_EditValueChanged(sender As Object, e As EventArgs) Handles txtTrndate.EditValueChanged
        LoadCurrentBlotter()
    End Sub
End Class