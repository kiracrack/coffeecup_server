﻿Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports DevExpress.XtraSplashScreen

Public Class frmManualInventoryHistory
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then
           

        ElseIf keyData = (Keys.Control) + Keys.P Then

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmStockHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)
        filter()
    End Sub

    Public Sub loadInventoryTo()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Office' from tblcompoffice order by officename asc", "tblcompoffice", txtInventory, gv_Office, Me)
        gv_Office.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInventory.EditValueChanged
        On Error Resume Next
        officeid.Text = txtInventory.Properties.View.GetFocusedRowCellValue("officeid").ToString()
    End Sub


    Public Sub filter()
        On Error Resume Next
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = "  "
        Else
            filterasof = " and date_format(datetrn,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If
        LoadXgrid("select ID as 'Entry No.', StockRef as 'Stock Ref#',invoiceno as 'Invoice No.', (select officename from tblcompoffice where officeid = tblinventorylogs.officeid) as 'Office' , productid as 'Particular ID', (select itemname from tblglobalproducts where productid= tblinventorylogs.productid) as 'Particular', (select description from tblprocategory where catid=tblinventorylogs.catid) as 'Category'," _
                            + " Quantity, Unit, unitcost as 'Unit Cost', Total,(select itemname from tbltransactioncode where itemcode=tblinventorylogs.itemcode) as 'Transaction Name', date_format(datepurchased, '%Y-%m-%d') as 'Date Purchased', (select companyname from tblglobalvendor where vendorid = tblinventorylogs.vendorid) as 'Vendor',Remarks, date_format(datetrn, '%Y-%m-%d %r') as 'Date Entries', (select fullname from tblaccounts where accountid = tblinventorylogs.trnby) as 'Entry By' from tblinventorylogs where confirmed=1  " & filterasof _
                            + If(ck_inventory.Checked = True, "", " and officeid='" & officeid.Text & "' ") & " order by datetrn desc", "tblinventorylogs", Em, GridView1, Me)

        GridView1.Columns("Remarks").ColumnEdit = MemoEdit

        XgridColCurrencyDecimalCount({"Quantity", "Unit Cost", "Total"}, 3, GridView1)
        XgridColAlign({"Entry No.", "Particular ID", "Stock Ref#", "Invoice No.", "Unit", "Quantity", "Date Purchased"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

        com.CommandText = "select * from tblcolumnindex where form='" & Me.Name & "' and gridview='" & GridView1.Name & "' order by colindex asc" : rst = com.ExecuteReader
        While rst.Read
            GridView1.Columns(rst("columnname").ToString).VisibleIndex = rst("colindex")
            If Val(rst("columnwidth").ToString) > 0 Then
                GridView1.Columns(rst("columnname").ToString).Width = Val(rst("columnwidth").ToString)
            End If
        End While
        rst.Close()
        SaveFilterColumn(GridView1, Me.Text)
    End Sub

    Private Sub GridView1_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles GridView1.ColumnWidthChanged
        UpdateGridColumnSetting(Me.Name, GridView1)
    End Sub

    Private Sub GridView1_DragObjectDrop(sender As Object, e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles GridView1.DragObjectDrop
        UpdateGridColumnSetting(Me.Name, GridView1)
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub


    Private Sub RefreshToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2 : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

#Region "REPORT SETTINGS"
    Private Sub ckasof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub
   
    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        filter()
        SplashScreenManager.CloseForm()
    End Sub
#End Region

    Private Sub ck_inventory_CheckedChanged(sender As Object, e As EventArgs) Handles ck_inventory.CheckedChanged
        If ck_inventory.Checked = True Then
            txtInventory.Enabled = False
            txtInventory.Properties.DataSource = False
            txtInventory.Text = ""
        Else
            loadInventoryTo()
            txtInventory.Enabled = True
        End If
    End Sub

    Private Sub ckasof_CheckedChanged_1(sender As Object, e As EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
            txttodate.Enabled = False
        Else
            txtfrmdate.Enabled = True
            txttodate.Enabled = True
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        frmNewManualInventory.Show(Me)
    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdaction.Click
        filter()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub BarButtonItem2_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim colname As String = ""
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView1, Me.Text)
        frmColumnFilter.ShowDialog(Me)
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        PrintDatagridview(If(ck_inventory.Checked = True, "STOCK-IN REPORT LOGS", " STOCK-IN REPORT LOGS <br/>" & txtInventory.Text), "DATABASE RECORDS", If(ckasof.Checked = True, "Report Filter: ALL RECORDS", "Report Filter: From " & txtfrmdate.Text & " to " & txttodate.Text), GridView1, Me)
        'Dim report As New rptInventorySummary()
        'If ck_inventory.Checked = True Then
        '    report.txtoffice.Text = "All Departments/Office"
        'Else
        '    report.txtoffice.Text = txtInventory.Text
        'End If
        'report.txtReportTitle.Text = UCase(Me.Text)
        'report.Landscape = True
        'If ckasof.Checked = True Then
        '    report.txtReportPeriod.Text = "As of " & Format(Now.ToString("MMMM dd, yyyy"))
        'Else
        '    report.txtReportPeriod.Text = "Period from " & txtfrmdate.Text & " to " & txttodate.Text
        'End If
        'report.txtReportType.Text = "Stockin Inventory"
        'report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        'SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        'report.ShowRibbonPreviewDialog()
        'SplashScreenManager.CloseForm()
    End Sub
End Class