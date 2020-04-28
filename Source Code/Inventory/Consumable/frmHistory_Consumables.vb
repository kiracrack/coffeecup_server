Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid
Imports DevExpress.XtraSplashScreen

Public Class frmHistory_Consumables
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then


        ElseIf keyData = (Keys.Control) + Keys.P Then
            PrintReport()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        If (countqry("tblinventoryledger", "officeid='" & officeid.Text & "' and productid='" & itemid.Text & "' order by datetrn desc limit 1")) > 0 Then
            txtfrmdate.EditValue = CDate(qrysingledata("datetrn", "datetrn", "tblinventoryledger where officeid='" & officeid.Text & "' and productid='" & itemid.Text & "' order by datetrn desc limit 1"))
        Else
            txtfrmdate.EditValue = CDate(Now)
        End If
        txttodate.EditValue = CDate(Now)
        filter()
        LoadGridviewAppearance(GridView1)
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs)
        filter()
    End Sub
    Public Sub filter()
        LoadXgrid("select date_format(a.datetrn, '%Y-%m-%d %r') as 'Date Transaction', " _
                        + " a.remarks as 'Remarks', " _
                        + " a.debit as 'Stock In', " _
                        + " a.credit as 'Stock Out', " _
                        + " (SELECT SUM(COALESCE(debit,0) - COALESCE(credit,0)) FROM tblinventoryledger as b " _
                        + " WHERE b.id <= a.id and b.officeid=a.officeid and b.productid=a.productid) AS 'Balance',referenceno as 'Reference No.', trntype as 'Transaction Type', trnby as 'Transaction By', (select officename from tblcompoffice where officeid=a.reqoffice) as 'Requesting Party' " _
                        + " FROM tblinventoryledger as a where a.officeid='" & officeid.Text & "' and a.productid='" & itemid.Text & "' and date_format(a.datetrn, '%Y-%m-%d') between '" & ConvertDate(txtfrmdate.EditValue) & "' and '" & ConvertDate(txttodate.EditValue) & "' order by a.id asc", "tblinventoryledger", Em, GridView1, Me)


        XgridColCurrencyDecimalCount({"Stock In", "Stock Out", "Balance"}, 4, GridView1)
        ' XgridColWidth({"Date Transaction"}, GridView1, 120)
        XgridColWidth({"Stock In", "Stock Out", "Balance"}, GridView1, 90)
        'GridView1.Columns("Remarks").ColumnEdit = MemoEdit
        GridView1.BestFitColumns()

        XgridColAlign({"Date Transaction", "Reference No."}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        ' XgridHideColumn({"dt"}, GridView1)
    End Sub

  
    Private Sub DisplayFormatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2 : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Public Sub PrintReport()
        If LCase(GlobalReportTemplate) = "deped" Then
            GenerateInventoryLedgerDeped(officeid.Text, itemid.Text, ConvertDate(txtfrmdate.EditValue), ConvertDate(txttodate.EditValue), Me)
        Else
            PrintDatagridview(Me.Text, "DATABASE RECORDS", "REPORT FILTER: Form " & txtfrmdate.Text & " to " & txttodate.Text, GridView1, Me)
            'Dim report As New rptInventorySummary()
            'report.officeid.Text = officeid.Text
            'report.txtReportPeriod.Text = "As of " & Format(Now.ToString("MMMM dd, yyyy"))
            'report.txtReportType.Text = Me.Text
            'report.txtReportTitle.Text = UCase(Me.Text & " of " & StrConv(Me.Text, VbStrConv.ProperCase))
            'report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
            'SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            'report.ShowRibbonPreviewDialog()
            'SplashScreenManager.CloseForm()
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub cmdPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint.ItemClick
        PrintReport()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        filter()
    End Sub

    Private Sub itemid_EditValueChanged(sender As Object, e As EventArgs) Handles itemid.EditValueChanged
        filter()
    End Sub
End Class