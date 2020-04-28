Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls
Imports System.IO
Imports DevExpress.Utils

Public Class frmGLAccountReportsGenerator
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        ElseIf keyData = (Keys.Control) + Keys.P Then
            ' printreport()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPumpReading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtReportDate.EditValue = CDate(Now)
        LoadCompany()
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

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdaction.Click
        LoadTickets()
    End Sub

    Public Sub LoadTickets()
        If companyid.Text = "" And CheckEdit1.Checked = False Then Exit Sub
        If CheckEdit1.Checked = True Then
            com.CommandText = "CALL sp_acct_capture_all(FALSE)" : com.ExecuteNonQuery()
        Else
            com.CommandText = "CALL sp_acct_capture_current('" & companyid.Text & "','" & globaluserid & "','" & ConvertDate(txtReportDate.EditValue) & "',FALSE)" : com.ExecuteNonQuery()
        End If

        LoadXgrid("select date_format(postingdate,'%Y-%m-%d') as 'Posting Date',(select officename from tblcompoffice where officeid=a.officeid) as 'Office',ItemCode,ifnull((select itemname from tblglitem where itemcode=a.itemcode),if(itemcode='','Account title not configured','Invalid account configuration')) as 'Item Name',ReferenceNo, Explaination, Debit, Credit,(select fullname from tblaccounts where accountid=a.userid) as 'Transaction By', date_format(datetrn,'%Y-%m-%d %r') as 'Date Transaction' from tmpcapturedtransactionview as a ;", "tmpcapturedtransactionview", Em, GridView1, Me)
        ' GridView1.Columns("Transaction Type").Group()
        XgridColCurrency({"Debit", "Credit"}, GridView1)
        XgridColWidth({"Details"}, GridView1, 350)
        XgridColWidth({"Debit", "Credit"}, GridView1, 120)
        XgridColAlign({"ReferenceNo", "Posting Date", "Date Transaction", "ItemCode"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Debit", "Credit"}, GridView1)
    End Sub
    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If View.GetRowCellDisplayText(e.RowHandle, View.Columns("Item Name")).ToString = "Account title not configured" Or View.GetRowCellDisplayText(e.RowHandle, View.Columns("Item Name")).ToString = "Invalid account configuration" Then
            e.Appearance.ForeColor = Color.Red
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

    End Sub

    Private Sub txtReportDate_EditValueChanged(sender As Object, e As EventArgs) Handles txtReportDate.EditValueChanged
        cmdaction.PerformClick()
    End Sub

    Private Sub RefreshLedgerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshLedgerToolStripMenuItem.Click
        LoadTickets()
    End Sub

    Private Sub TransferAllEntriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferAllEntriesToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If CheckEdit1.Checked = True Then
                com.CommandText = "CALL sp_acct_capture_all(TRUE)" : com.ExecuteNonQuery()
            Else
                com.CommandText = "CALL sp_acct_capture_current('" & companyid.Text & "','" & globaluserid & "','" & ConvertDate(txtReportDate.EditValue) & "',TRUE)" : com.ExecuteNonQuery()
            End If
            XtraMessageBox.Show("Entries successfully transfered", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            txtCompany.Enabled = False
            txtReportDate.Enabled = False
        Else
            txtCompany.Enabled = True
            txtReportDate.Enabled = True
        End If
    End Sub
End Class