Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmStockoutBatchRequest
    Private tempID As String
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Insert Then
            menuInventory.PerformClick()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmStockoutBatchRequest_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmStockoutBatchRequest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtDateStockout.Text = CDate(Now.ToShortDateString)
        FilterNew()
        loadCompOffice()
        LoadStockoutType()
        DockPanel2.Focus()
    End Sub

    Public Sub LoadStockoutType()
        LoadXgridLookupSearch("SELECT Stockouttypeid, Description as 'Select' from tblStockouttype", "tblStockouttype", txtStockoutType, g_inventory, Me)
        g_inventory.Columns("Stockouttypeid").Visible = False
    End Sub
    Private Sub txtStockoutType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStockoutType.EditValueChanged
        On Error Resume Next
        Stockouttypeid.Text = txtStockoutType.Properties.View.GetFocusedRowCellValue("Stockouttypeid").ToString()
    End Sub

    Public Sub FilterNew()
        LoadXgrid("Select  id,  date_format(postingdate,'%Y-%m-%d') as 'Stockout Date', (select officename from tblcompoffice where officeid=tblstockoutitem.officeid) as 'Office', " _
                            + " (select itemname from tblglobalproducts where PRODUCTID=tblstockoutitem.PRODUCTID) as 'Item Name', " _
                            + " Quantity,Unit, purchasedprice as 'Unit Cost', (purchasedprice*Quantity) as 'Total Cost',  Remarks, " _
                            + " (select description from tblstockouttype where stockouttypeid=tblstockoutitem.stockouttypeid) as 'Stockout Type' " _
                            + " from tblstockoutitem where confirmed=0 and trnby='" & globaluserid & "'", "tblstockoutitem", Cm, Gridview1, Me)

        XgridHideColumn({"id"}, Gridview1)
        XgridColCurrencyDecimalCount({"Quantity", "Unit Cost", "Total Cost"}, 3, Gridview1)
        XgridColAlign({"Quantity", "Stockout Date"}, Gridview1, DevExpress.Utils.HorzAlignment.Center)

        com.CommandText = "select * from tblcolumnindex where form='" & Me.Name & "' and gridview='" & Gridview1.Name & "' order by colindex asc" : rst = com.ExecuteReader
        While rst.Read
            Gridview1.Columns(rst("columnname").ToString).VisibleIndex = rst("colindex")
            If Val(rst("columnwidth").ToString) > 0 Then
                Gridview1.Columns(rst("columnname").ToString).Width = Val(rst("columnwidth").ToString)
            End If
        End While
        rst.Close()
    End Sub

    Private Sub GridView1_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles Gridview1.ColumnWidthChanged
        UpdateGridColumnSetting(Me.Name, GridView1)
    End Sub

    Private Sub GridView1_DragObjectDrop(sender As Object, e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles Gridview1.DragObjectDrop
        UpdateGridColumnSetting(Me.Name, GridView1)
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolRemove.Click
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To Gridview1.SelectedRowsCount - 1
                com.CommandText = "DELETE FROM tblstockoutitem where id='" & Gridview1.GetRowCellValue(Gridview1.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
            Next
            FilterNew()
        End If
    End Sub

    Public Sub loadCompOffice()
        LoadXgridLookupSearch("select officeid, officename as 'Select Office' from tblcompoffice order by officename asc", "tblcompoffice", txtoffice, gridcompoffice, Me)
        gridcompoffice.Columns("officeid").Visible = False

    End Sub
    Private Sub txtoffice_EditValueChanged(sender As Object, e As EventArgs) Handles txtoffice.EditValueChanged
        On Error Resume Next
        officeid.Text = txtoffice.Properties.View.GetFocusedRowCellValue("officeid").ToString
    End Sub

    
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Me.Close()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        FilterNew()
    End Sub

    Private Sub ViewAppearanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAppearanceToolStripMenuItem.Click
        frmUserProfile.formatGrid(Gridview1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    Private Sub menuInventory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuInventory.ItemClick
        If txtoffice.Text = "" Then
            XtraMessageBox.Show("Please office inventory!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtoffice.Focus()
            Exit Sub
        ElseIf txtStockoutType.Text = "" Then
            XtraMessageBox.Show("Please select stockout type!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStockoutType.Focus()
            Exit Sub
        End If
        frmStockoutInventory.mode.Text = "stockout"
        frmStockoutInventory.officeid.Text = officeid.Text
        frmStockoutInventory.ShowDialog(Me)
    End Sub

    Private Sub txtStockoutType_GotFocus(sender As Object, e As EventArgs) Handles txtStockoutType.GotFocus
        'txtStockoutType.ShowPopup()
    End Sub

    Private Sub cmdSaveAndFinish_Click(sender As Object, e As EventArgs) Handles cmdSaveAndFinish.Click
        If Gridview1.RowCount = 0 Then
            XtraMessageBox.Show("Theres no item to save!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtoffice.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Continue confirm batch stockout inventory?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim batchcode As String = getStockoutBatchSequence()
            dst = New DataSet
            msda = New MySqlDataAdapter("Select *,(select description from tblstockouttype where stockouttypeid=tblstockoutitem.stockouttypeid) as stockouttype from tblstockoutitem where confirmed=0 and trnby='" & globaluserid & "'", conn)
            msda.Fill(dst, 0)
            ProgressBarControl1.Visible = True
            ProgressBarControl1.Properties.Step = 1
            ProgressBarControl1.Properties.PercentView = True
            ProgressBarControl1.Properties.Maximum = Gridview1.RowCount - 1
            ProgressBarControl1.Properties.Minimum = 0
            ProgressBarControl1.Position = 0
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    StockoutInventory("Inventory Stockout", .Rows(cnt)("refcode").ToString(), .Rows(cnt)("officeid").ToString(), .Rows(cnt)("productid").ToString(), Val(CC(.Rows(cnt)("quantity").ToString())), Val(CC(.Rows(cnt)("purchasedprice").ToString())), If(.Rows(cnt)("remarks").ToString() = "", .Rows(cnt)("stockouttype").ToString(), .Rows(cnt)("stockouttype").ToString() & " - " & .Rows(cnt)("remarks").ToString()), "", "")
                    com.CommandText = "update tblstockoutitem set batchcode='" & batchcode & "', confirmed=1 where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                    If EnableModuleAccounting = True Then
                        com.CommandText = "CALL sp_acct_entries('" & .Rows(cnt)("id").ToString() & "','" & .Rows(cnt)("officeid").ToString() & "', 'STOCK_OUT','')" : com.ExecuteNonQuery()
                    End If
                End With
                ProgressBarControl1.PerformStep()
                ProgressBarControl1.Update()
            Next
            ProgressBarControl1.Update()
            ProgressBarControl1.Refresh()
            ProgressBarControl1.Visible = False
            FilterNew()

            frmManualInventoryHistory.filter()
            XtraMessageBox.Show("Inventory successfully deducted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class