Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid
Imports System.IO
Imports DevExpress.XtraSplashScreen

Public Class frmInventoryFFESummary
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then


        ElseIf keyData = Keys.F2 Then
            If SplitContainerControl1.Collapsed = True Then
                SplitContainerControl1.Collapsed = False
            Else
                SplitContainerControl1.Collapsed = True
            End If
 
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(gv_inventory)


        loadInventoryTo()

        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)
        If GlobalEnableStockHouse = True Then
            cmdStockHouseInfor.Visible = True
        Else
            cmdStockHouseInfor.Visible = False
        End If
        lblOffice.Text = "Select " & GlobalOfficeCaption
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdStockHouseInfor.Visible = True
            ToolStripSeparator2.Visible = True
        Else
            cmdStockHouseInfor.Visible = False
            ToolStripSeparator2.Visible = False
        End If
    End Sub

    Public Sub loadInventoryTo()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Inventory' from tblcompoffice order by officename asc", "tblcompoffice", txtInventory, gv_inventory, Me)
        gv_inventory.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInventory.EditValueChanged
        On Error Resume Next
        officeid.Text = txtInventory.Properties.View.GetFocusedRowCellValue("officeid").ToString()
        If ck_inventory.Checked = True Then
            PrintSummaryToolStripMenuItem.Enabled = False
        Else
            If txtInventory.Text = "" Then
                PrintSummaryToolStripMenuItem.Enabled = False
            Else
                PrintSummaryToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub cmdaction_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdaction.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        filterInventory()
        SplashScreenManager.CloseForm()
    End Sub
    Public Sub filterInventory()
        Dim viewalloffices As String = "" : Dim filterasof As String = "" : Dim stockhouse As String = ""
        If ck_inventory.Checked = True Then
            viewalloffices = ""
        Else
            viewalloffices = " and officeid ='" & officeid.Text & "'"
        End If
        If ckasof.Checked = True Then
            filterasof = " and date_format(datetrn,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " and date_format(datetrn,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If
        UpdateDepreciationInventory("")
        LoadXgrid("Select ffecode as 'Asset Code'," _
                  + " (select officename from tblcompoffice where officeid=tblinventoryffe.officeid) as '" & GlobalOfficeCaption & "' , " _
                  + " productid as 'Product Code', " _
                  + " productname as 'Particular', " _
                  + " (select description from tblinventoryffetype where code=tblinventoryffe.ffetype) as 'Asset Type', " _
                  + " ifnull((select stockhousename from tblstockhouse where stockhouseid=tblinventoryffe.stockhouseid),'MAIN STOCK HOUSE') as 'Stock House', " _
                  + " categoryname as 'Category', " _
                  + " Quantity, Unit, unitcost as 'Unit Cost', totalamount as Total, date_format(datepurchased, '%Y-%m-%d') as 'Date Purchased', " _
                  + " (select companyname from tblglobalvendor where vendorid=tblinventoryffe.vendorid) as 'Supplier', " _
                  + " if(warranty=1,date_format(warrantydate,'%Y-%m-%d'),'-') as 'Date Warranty', " _
                  + " Age," _
                  + " bookvalue as 'Book Value', " _
                  + " totalamount-bookvalue as 'Depreciated Value', " _
                  + " monthlydepreciation as 'Monthly Depreciation', date_format(lastdepreciationdate, '%Y-%m-%d') as 'Last Depreciation Date', " _
                  + " acctableperson as 'Accountable Person', date_format(acctdateissued, '%Y-%m-%d') as 'Date Issued', " _
                  + " case when disposed=1 then 'Disposed' else 'Actived' end as 'Status', " _
                  + " Flaged, " _
                  + " flagedreason as 'Flaged Reason', lockedediting " _
                  + " from tblinventoryffe where disposed=0 " & filterasof & viewalloffices, "tblinventoryffe", Em, GridView1, Me)

        GridView1.Columns(GlobalOfficeCaption).Group()
        GridView1.ExpandAllGroups()
        XgridHideColumn({"lockedediting"}, GridView1)
        XgridColCurrency({"Unit Cost", "Total"}, GridView1)
        XgridColAlign({"Asset Code", "Product Code", "Date Purchased", "Status", "Age", "Date Warranty", "Last Depreciation Date", "Date Issued"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()
        GridView1.Columns("Product Code").Width = 100
        GridView1.Columns("Quantity").Width = 120
        GridView1.Columns("Unit Cost").Width = 150
        GridView1.Columns("Total").Width = 150
        GridView1.Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
        SaveFilterColumn(GridView1, Me.Text)
        XgridColCurrencyDecimalCount({"Book Value", "Monthly Depreciation", "Depreciated Value"}, 3, GridView1)
        XgridGroupSummaryCurrency({"Total", "Book Value", "Monthly Depreciation", "Depreciated Value"}, GridView1)
        XgridGeneralSummaryCurrency({"Total", "Book Value", "Monthly Depreciation", "Depreciated Value"}, GridView1)

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

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        cmdaction.PerformClick()
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2 : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub ck_inventory_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ck_inventory.CheckedChanged
        If ck_inventory.Checked = True Then
            txtInventory.Enabled = False
            txtInventory.Properties.DataSource = False
            txtInventory.Text = ""
            PrintSummaryToolStripMenuItem.Enabled = False
        Else
            loadInventoryTo()
            txtInventory.Enabled = True
            If txtInventory.Text = "" Then
                PrintSummaryToolStripMenuItem.Enabled = False
            Else
                PrintSummaryToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub
 
    Private Sub ckasof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub


    Private Sub cmdUnitInformation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnitInformation.Click
        If CheckSelectedRow("Asset Code", GridView1) = True Then
            frmFFEAccountabilityLog.ffecode.Text = GridView1.GetFocusedRowCellValue("Asset Code").ToString
            If frmFFEAccountabilityLog.Visible = True Then
                frmFFEAccountabilityLog.Focus()
            Else
                frmFFEAccountabilityLog.Show(Me)
            End If
        End If
    End Sub
    Private Sub ColumnChooserToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdColumnFilter.Click
        If CheckSelectedRow("Asset Code", GridView1) = True Then
            Dim colname As String = ""
            For I = 0 To GridView1.Columns.Count - 1
                colname += GridView1.Columns(I).FieldName & ","
            Next
            frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
            frmColumnFilter.GetFilterInfo(GridView1, Me.Text)
            frmColumnFilter.ShowDialog(Me)
        End If
    End Sub


    Private Sub cmdViewAttachment_Click(sender As Object, e As EventArgs) Handles cmdViewAttachment.Click
        If CheckSelectedRow("Asset Code", GridView1) = True Then
            ViewAttachmentPackage_Database({GridView1.GetFocusedRowCellValue("Asset Code").ToString}, "")
        End If
    End Sub

    Private Sub SetAttachmentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SetAttachmentToolStripMenuItem1.Click
        If CheckSelectedRow("Asset Code", GridView1) = True Then
            frmSetAttachment.refno.Text = GridView1.GetFocusedRowCellValue("Asset Code").ToString()
            frmSetAttachment.Show(Me)
        End If
    End Sub

    'Private Sub AllocatedExpensesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAllocated.Click
    '    If CheckSelectedRow("FFE Code", GridView1) = True Then
    '        frmHistory_AllocatedExpenses.officeid.Text = GridView1.GetFocusedRowCellValue("officeid").ToString
    '        frmHistory_AllocatedExpenses.refcode.Text = GridView1.GetFocusedRowCellValue("FFE Code").ToString
    '        frmHistory_AllocatedExpenses.XtraTabControl1.SelectedTabPage.Text = "ALLOCATED EXPENSES REPORT OF " & GridView1.GetFocusedRowCellValue("Particular").ToString
    '        frmHistory_AllocatedExpenses.Show(Me)
    '    End If
    'End Sub

    Private Sub SetStockHouseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStockHouseInfor.Click
        If CheckSelectedRow("Asset Code", GridView1) = True Then
            frmSetStockHouse.trnid.Text = GridView1.GetFocusedRowCellValue("id").ToString
            frmSetStockHouse.refcode.Text = GridView1.GetFocusedRowCellValue("Asset Code").ToString
            frmSetStockHouse.officeid.Text = GridView1.GetFocusedRowCellValue("officeid").ToString
            frmSetStockHouse.inventorytype.Text = "cffe"
            frmSetStockHouse.Show(Me)
        End If
    End Sub
 

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        frmFFETypeManagement.ShowDialog(Me)
    End Sub

    Private Sub PrintMemorandumOfReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintMemorandumOfReceiptToolStripMenuItem.Click
        PrintFFeMR(GridView1.GetFocusedRowCellValue("Asset Code").ToString, Me)
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Dim colname As String = ""
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView1, Me.Text)
        frmColumnFilter.ShowDialog(Me)
    End Sub
End Class