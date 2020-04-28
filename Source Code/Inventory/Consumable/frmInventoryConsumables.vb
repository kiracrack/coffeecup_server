Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid
Imports DevExpress.XtraSplashScreen

Public Class frmInventoryConsumables
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
        ElseIf keyData = Keys.F3 Then
            txtFilterName.SelectAll()
            txtFilterName.Focus()

        ElseIf keyData = (Keys.Control) + Keys.P Then
            PrintReport()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        loadInventoryTo()
        loadCategory()

        CheckUserAccess()
        If globalApproverPermission = True Or LCase(globaluser) = "root" Then
            cmdBalanceForward.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            cmdBalanceForward.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
    End Sub

    Public Sub loadCategory()
        com.CommandText = "select * from tblprocategory where consumable=1 order by description asc;" : rst = com.ExecuteReader
        While rst.Read
            txtCategory.Properties.Items.Add(rst("catid").ToString, False, True)
            txtCategory.Properties.Items.Item(rst("catid").ToString).Description = rst("description").ToString
            txtCategory.Properties.Items.Item(rst("catid").ToString).Value = rst("catid").ToString
        End While
        rst.Close()
    End Sub

    Private Sub txtCategory_EditValueChanged(sender As Object, e As EventArgs) Handles txtCategory.EditValueChanged
        FilterInventoryReports()
    End Sub

    Public Sub CheckUserAccess()
        If ckStockSequence.Checked = True Then
            If globalAllowDelete = True Or LCase(globaluser) = "root" Then
                cmdRemove.Visible = True
            Else
                cmdRemove.Visible = False
            End If
            cmdAdjustment.Visible = False
        Else

            cmdRemove.Visible = False
            cmdUpdateInfo.Visible = False
        End If
    End Sub
    Private Sub ck_category_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            txtCategory.Enabled = False
        Else
            txtCategory.Enabled = True
        End If
        FilterInventoryReports()
    End Sub
    Public Sub loadInventoryTo()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Inventory' from tblcompoffice order by officename asc", "tblcompoffice", txtInventory, gv_inventory, Me)
        gv_inventory.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInventory.EditValueChanged
        On Error Resume Next
        officeid.Text = txtInventory.Properties.View.GetFocusedRowCellValue("officeid").ToString()
    End Sub

    Private Sub cmdaction_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdaction.Click
        FilterInventoryReports()
    End Sub

    Public Sub FilterInventoryReports()
        If ckStockSequence.Checked = True Then
            filterInventoryDetails()
        Else
            filterInventorySummary()
        End If
    End Sub
    Public Sub filterInventorySummary()
        Dim SelectedCategory As String = ""
        For Each item As CheckedListBoxItem In txtCategory.Properties.Items
            If item.CheckState = CheckState.Checked Then
                SelectedCategory += "catid='" & item.Value.ToString() & "' or "
            End If
        Next
        If SelectedCategory.Length > 0 Then
            SelectedCategory = SelectedCategory.Remove(SelectedCategory.Length - 3, 3)
        End If

        LoadXgrid("Select OfficeID, stockref as 'Stock No.',(select officename from tblcompoffice where officeid=tblinventory.officeid) as 'Office' , " _
                        + " productid as 'Product No.', " _
                        + " productname as 'Particular', " _
                        + " categoryname as 'Category', " _
                        + " Case when prepaid=1 then 'Prepaid' else 'On hand' end as 'Inventory Type', " _
                        + " reorderpoint as 'Re-order Point', " _
                        + " sum(quantity) as 'Available Quantity', " _
                        + " ifnull((select sum(debit)-sum(credit) from tblinventoryledger where officeid=tblinventory.officeid and productid=tblinventory.productid),0) as 'Ledger Balance',Unit, " _
                        + " date_format(lastupdate, '%Y-%m-%d %r') as 'Last Update' " _
                        + " from tblinventory where officeid<>'' " & If(ckZeroQuantity.Checked = True, "", " and quantity > 0 ") & If(CheckBox2.Checked = True Or SelectedCategory = "", "", " and (" & SelectedCategory & ") ") & " and " _
                        + If(ck_inventory.Checked = True, "", " officeid ='" & officeid.Text & "' and ") _
                        + " (" & SearchProductName("productname", rchar(txtFilterName.Text)) & " or productid like '%" & rchar(txtFilterName.Text) & "%' or stockref like '%" & txtFilterName.Text & "%') group by officeid,productid order by productname,quantity asc" _
                        + " ", "tblinventory", Em, GridView1, Me)

        If ck_inventory.Checked = True Then
            GridView1.Columns("Office").Group()
            GridView1.ExpandAllGroups()
        Else
            GridView1.Columns("Office").Visible = False
        End If

        GridView1.Columns("OfficeID").Visible = False
        XgridColCurrencyDecimalCount({"Re-order Point", "Available Quantity", "Ledger Balance"}, 3, GridView1)
        XgridColAlign({"Product No.", "Re-order Point", "Stock No.", "Inventory Type", "Available Quantity", "Ledger Balance", "Unit", "Last Update"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.Columns("Particular").ColumnEdit = MemoEdit



        com.CommandText = "select * from tblcolumnindex where form='" & Me.Name & "-sum' and gridview='" & GridView1.Name & "' order by colindex asc" : rst = com.ExecuteReader
        While rst.Read
            GridView1.Columns(rst("columnname").ToString).VisibleIndex = rst("colindex")
            If Val(rst("columnwidth").ToString) > 0 Then
                GridView1.Columns(rst("columnname").ToString).Width = Val(rst("columnwidth").ToString)
            End If
        End While
        rst.Close()
        SaveFilterColumn(GridView1, Me.Name & "-sum")
        CheckUserAccess()
    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        Dim AvailableQuanity As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Available Quantity"))
        Dim ReorderPoint As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Re-order Point"))
        If Val(CC(AvailableQuanity)) <= ReorderPoint Then
            e.Appearance.ForeColor = Color.Red
            ' e.Appearance.ForeColor = Color.White
        ElseIf Val(CC(AvailableQuanity)) > ReorderPoint And Val(CC(AvailableQuanity)) <= (ReorderPoint + 5) Then
            e.Appearance.ForeColor = Color.Orange
            ' e.Appearance.ForeColor = Color.Black
        End If
        If ckStockSequence.Checked = False Then
            If e.Column.Name = "colLedgerBalance" Then
                Dim Ledger As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Ledger Balance"))
                If AvailableQuanity <> Ledger Then
                    If e.Column.Name = "colLedgerBalance" Then
                        e.Appearance.BackColor = Color.Red
                        e.Appearance.BackColor2 = Color.Red
                        e.Appearance.ForeColor = Color.White
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        DirectPORowCheck()
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        DirectPORowCheck()
    End Sub

    Public Sub DirectPORowCheck()
        Try
            If GridView1.RowCount = 0 Then Exit Sub
            If GlobalEnableConsumableAdjustment = True And ckStockSequence.Checked = False Then
                If Val(CC(GridView1.GetFocusedRowCellValue("Available Quantity").ToString)) <> Val(CC(GridView1.GetFocusedRowCellValue("Ledger Balance").ToString)) Then
                    If globalApproverPermission = True Or LCase(globaluser) = "root" Then
                        cmdAdjustment.Visible = True
                    Else
                        cmdAdjustment.Visible = False
                    End If
                Else
                    cmdAdjustment.Visible = False
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub



    Public Sub filterInventoryDetails()
        Try
            Dim SelectedCategory As String = ""
            For Each item As CheckedListBoxItem In txtCategory.Properties.Items
                If item.CheckState = CheckState.Checked Then
                    SelectedCategory += "catid='" & item.Value.ToString() & "' or "
                End If
            Next
            If SelectedCategory.Length > 0 Then
                SelectedCategory = SelectedCategory.Remove(SelectedCategory.Length - 3, 3)
            End If

            LoadXgrid("Select trnid as 'Stock No.', stockref as 'Stock Ref', OfficeID, " _
                            + " (select officename from tblcompoffice where officeid=tblinventory.officeid) as 'Office' , " _
                            + " productid as 'Product No.', " _
                            + " productname as 'Particular', " _
                            + " categoryname as 'Category', " _
                            + " Case when prepaid=1 then 'Prepaid' else 'On hand' end as 'Inventory Type', " _
                            + " reorderpoint as 'Re-order Point', " _
                            + " quantity as 'Available Quantity',Unit, " _
                            + " purchasedprice as 'Purchased Price',(purchasedprice*QUANTITY) as 'Total', " _
                            + " date_format(lastupdate, '%Y-%m-%d %r') as 'Last Update', " _
                            + " date_format(dateinventory, '%Y-%m-%d %r') as 'Date Inventory' " _
                            + " from tblinventory where officeid<>'' " & If(ckZeroQuantity.Checked = True, "", " and quantity > 0 ") & If(CheckBox2.Checked = True Or SelectedCategory = "", "", " and (" & SelectedCategory & ") ") & " and " _
                            + If(ck_inventory.Checked = True, "", " officeid ='" & officeid.Text & "' and ") _
                            + " (productname like '%" & rchar(txtFilterName.Text) & "%' or productid like '%" & rchar(txtFilterName.Text) & "%') order by productname,dateinventory asc" _
                            + " ", "tblinventory", Em, GridView1, Me)

            If ck_inventory.Checked = True Then
                GridView1.Columns("Office").Group()
                GridView1.ExpandAllGroups()
            Else
                GridView1.Columns("Office").Visible = False
            End If


            XgridColCurrencyDecimalCount({"Available Quantity", "Re-order Point"}, 3, GridView1)
            XgridColAlign({"Product No.", "OfficeID", "Last Update", "Re-order Point", "Available Quantity", "Inventory Type", "Date Inventory", "Stock No.", "Stock Ref"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
            GridView1.BestFitColumns()
            GridView1.Columns("Total").Width = 120
            GridView1.Columns("Particular").ColumnEdit = MemoEdit

            XgridColCurrency({"Purchased Price"}, GridView1)
            XgridColCurrencyDecimalCount({"Purchased Price", "Total"}, 3, GridView1)

            XgridColCurrency({"Selling Price"}, GridView1)
            XgridGroupSummaryCurrency({"Total", "Selling Price"}, GridView1)
            XgridGeneralSummaryCurrency({"Total", "Selling Price"}, GridView1)

            com.CommandText = "select * from tblcolumnindex where form='" & Me.Name & "-detail' and gridview='" & GridView1.Name & "' order by colindex asc" : rst = com.ExecuteReader
            While rst.Read
                GridView1.Columns(rst("columnname").ToString).VisibleIndex = rst("colindex")
                If Val(rst("columnwidth").ToString) > 0 Then
                    GridView1.Columns(rst("columnname").ToString).Width = Val(rst("columnwidth").ToString)
                End If
            End While
            rst.Close()

            SaveFilterColumn(GridView1, Me.Name & "-detail")
            CheckUserAccess()
        Catch ex As Exception
            rst.Close()
            UpdateGridColumnSetting(Me.Name & If(ckStockSequence.Checked = True, "-detail", "-sum"), GridView1)
        End Try
    End Sub

    Private Sub GridView1_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles GridView1.ColumnWidthChanged
        UpdateGridColumnSetting(Me.Name & If(ckStockSequence.Checked = True, "-detail", "-sum"), GridView1)
    End Sub

    Private Sub GridView1_DragObjectDrop(sender As Object, e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles GridView1.DragObjectDrop
        UpdateGridColumnSetting(Me.Name & If(ckStockSequence.Checked = True, "-detail", "-sum"), GridView1)
    End Sub


    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        cmdHistory.PerformClick()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        cmdaction.PerformClick()
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2 : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub ViewInventoryDetailsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdHistory.Click
        frmHistory_Consumables.officeid.Text = GridView1.GetFocusedRowCellValue("OfficeID").ToString
        frmHistory_Consumables.itemid.Text = GridView1.GetFocusedRowCellValue("Product No.").ToString
        frmHistory_Consumables.Text = GridView1.GetFocusedRowCellValue("Particular").ToString
        If frmHistory_Consumables.Visible = False Then
            frmHistory_Consumables.Show(Me)
        End If
    End Sub


    Private Sub ck_inventory_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ck_inventory.CheckedChanged
        If ck_inventory.Checked = True Then
            txtInventory.Enabled = False
            txtInventory.Properties.DataSource = False
            txtInventory.Text = ""
        Else
            loadInventoryTo()
            txtInventory.Enabled = True
        End If
    End Sub


    Public Sub PrintReport()
        If LCase(GlobalReportTemplate) = "deped" Then
            GenerateInventoryDepedTemplate(Now, "select * from tblinventory where quantity <> 0 " _
                        + If(CheckBox2.Checked = True, "", " and catid='" & catid.Text & "'  ") _
                         + If(ck_inventory.Checked = True, "", " and officeid ='" & officeid.Text & "' "), Me)
        Else
            PrintDatagridview(If(ckStockSequence.Checked = True, "INVENTORY REPORT LOGS", "INVENTORY SUMMARY REPORT"), Me.Text, If(ck_inventory.Checked = True, "ALL BRANCHES/OFFICES", txtInventory.Text), GridView1, Me)

        End If

    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        PrintReport()
    End Sub


    Private Sub rc_rdamage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdjustment.Click
        If CheckSelectedRow("Product No.", GridView1) = True Then
            frmUtilAdjustment.productid.Text = GridView1.GetFocusedRowCellValue("Product No.").ToString
            frmUtilAdjustment.officeid.Text = GridView1.GetFocusedRowCellValue("OfficeID").ToString
            If frmUtilAdjustment.Visible = True Then
                frmUtilAdjustment.Focus()
            Else
                frmUtilAdjustment.Show(Me)
            End If

        End If
    End Sub
    Public Sub ItemAdjustmentValue(ByVal quantity As Double)
        For I = 0 To GridView1.SelectedRowsCount - 1
            If GridView1.Columns("Available Quantity").Visible = True Then
                GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Available Quantity", quantity)
                GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Ledger Balance", quantity)
            End If
        Next
    End Sub

    Private Sub BarCheckItem1_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem1.CheckedChanged
        Dim colname As String = ""
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView1, Me.Name & If(ckStockSequence.Checked = True, "-detail", "-sum"))
        frmColumnFilter.ShowDialog(Me)
    End Sub

    Private Sub RemoveInventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item?" & Environment.NewLine & Environment.NewLine & "NOTE: There's no UNDO function to retrived deleted inventory!", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then
            com.CommandText = "delete from tblinventory where trnid='" & GridView1.GetFocusedRowCellValue("Stock No.").ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "delete from tblinventoryledger where productid='" & GridView1.GetFocusedRowCellValue("Product No.").ToString & "' and officeid='" & GridView1.GetFocusedRowCellValue("OfficeID").ToString & "'" : com.ExecuteNonQuery()
            FilterInventoryReports()
            XtraMessageBox.Show("Inventory successfully removed!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cmdExportToExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdExportToExcel.ItemClick
        ExportGridToExcel("Inventory consumable summary " & If(ck_inventory.Checked = True, "all office", txtInventory.Text) & " as of " & CDate(Now).ToString("yyyy-MM-dd"), GridView1)
    End Sub

    Private Sub BarButtonItem3_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        frmLockInventoryCutoff.ShowDialog(Me)
    End Sub

    Private Sub txtFilterName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFilterName.KeyPress
        If e.KeyChar() = Chr(13) Then
            If ck_inventory.Checked = False And txtInventory.Text = "" Then
                XtraMessageBox.Show("Please select office!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtInventory.Focus()
                Exit Sub
            ElseIf CheckBox2.Checked = False And txtcategory.Text = "" Then
                XtraMessageBox.Show("Please select category!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtcategory.Focus()
                Exit Sub
            End If
            FilterInventoryReports()
            txtFilterName.SelectAll()
            txtFilterName.Focus()
        End If
    End Sub

    Private Sub UnitConverterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnitConverterToolStripMenuItem.Click
        If CheckSelectedRow("Product No.", GridView1) = True Then
            If ckStockSequence.Checked = False Then
                'XtraMessageBox.Show("Current Product currently not configure, Please add product convertion to this item!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                frmUtilUnitConverterInfo.productid_source.Text = GridView1.GetFocusedRowCellValue("Product No.").ToString
                frmUtilUnitConverterInfo.txtSourceProduct.Text = GridView1.GetFocusedRowCellValue("Particular").ToString
                frmUtilUnitConverterInfo.txtSourceUnitType.Text = GridView1.GetFocusedRowCellValue("Unit").ToString
                frmUtilUnitConverterInfo.txtSourceQuantity.Text = "1"
                frmUtilUnitConverterInfo.txtTargetQuantity.Focus()
                frmUtilUnitConverterInfo.Show(Me)
            Else
                If countqry("tblunitconverter", "productid_source='" & GridView1.GetFocusedRowCellValue("Product No.").ToString & "'") = 0 Then
                    XtraMessageBox.Show("Current Product currently not configure, Please add product convertion to this item!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    frmUtilUnitConverterInfo.productid_source.Text = GridView1.GetFocusedRowCellValue("Product No.").ToString
                    frmUtilUnitConverterInfo.txtSourceProduct.Text = GridView1.GetFocusedRowCellValue("Particular").ToString
                    frmUtilUnitConverterInfo.txtSourceUnitType.Text = GridView1.GetFocusedRowCellValue("Unit").ToString
                    frmUtilUnitConverterInfo.txtSourceQuantity.Text = "1"
                    frmUtilUnitConverterInfo.txtTargetQuantity.Focus()
                    frmUtilUnitConverterInfo.Show(Me)
                Else
                    frmUtilUnitConvertion.trnid.Text = GridView1.GetFocusedRowCellValue("Stock No.").ToString
                    frmUtilUnitConvertion.Show(Me)
                End If
            End If
        End If
    End Sub

    Private Sub ckStockSequence_CheckedChanged(sender As Object, e As EventArgs) Handles ckStockSequence.CheckedChanged
        FilterInventoryReports()
    End Sub

    Private Sub cmdUpdateInfo_Click(sender As Object, e As EventArgs) Handles cmdUpdateInfo.Click
        If CheckSelectedRow("Product No.", GridView1) = True Then
            frmUtilUpdateInventoryInfo.trnid.Text = GridView1.GetFocusedRowCellValue("Stock No.").ToString
            frmUtilUpdateInventoryInfo.Show(Me)
        End If
    End Sub
 
    Private Sub cmdBalanceForward_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdBalanceForward.ItemClick
        frmInventoryBalanceForward.Show(Me)
    End Sub

    Private Sub ckZeroQuantity_CheckedChanged(sender As Object, e As EventArgs) Handles ckZeroQuantity.CheckedChanged
        FilterInventoryReports()
    End Sub
End Class