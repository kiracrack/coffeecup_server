Imports DevExpress.Utils
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors

Public Class frmManualInventoryProductSearch
    Public productnameselected As String
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        ElseIf keyData = Keys.Space Then
            txtfilter.Focus()

        ElseIf keyData = (Keys.Insert) Then
            cmdAddnew.PerformClick()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmManualInventoryProductSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)

    End Sub
    Public Sub filter()
        LoadXgrid("SELECT productid,if(partnumber='' or partnumber is null,itemname,concat(itemname,'-',tblglobalproducts.description)) as 'Select Product' , Unit, (select sum(quantity) from tblinventory where productid=tblglobalproducts.productid and officeid='" & officeid.Text & "') as 'Current Inventory', purchasedprice as 'Latest Cost' from tblglobalproducts inner join tblprocategory on  tblprocategory.catid = tblglobalproducts.catid where (productid like '%" & txtfilter.Text & "%' or itemname like '%" & txtfilter.Text & "%' or tblglobalproducts.description like '%" & txtfilter.Text & "%') and deleted=0 and consumable=1 order by itemname asc", "tblglobalproducts", Em, inventoryGrid, Me)
        XgridHideColumn({"productid"}, inventoryGrid)
        XgridColCurrencyDecimalCount({"Current Inventory", "Latest Cost"}, 3, inventoryGrid)
        XgridColAlign({"Current Inventory", "Unit"}, inventoryGrid, DevExpress.Utils.HorzAlignment.Center)

        com.CommandText = "select * from tblcolumnindex where form='" & Me.Name & "' and gridview='" & inventoryGrid.Name & "' order by colindex asc" : rst = com.ExecuteReader
        While rst.Read
            inventoryGrid.Columns(rst("columnname").ToString).VisibleIndex = rst("colindex")
            If Val(rst("columnwidth").ToString) > 0 Then
                inventoryGrid.Columns(rst("columnname").ToString).Width = Val(rst("columnwidth").ToString)
            End If
        End While
        rst.Close()

        inventoryGrid.Focus()
        Em.Focus()
    End Sub

    Private Sub GridView1_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles inventoryGrid.ColumnWidthChanged
        UpdateGridColumnSetting(Me.Name, inventoryGrid)
    End Sub

    Private Sub GridView1_DragObjectDrop(sender As Object, e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles inventoryGrid.DragObjectDrop
        UpdateGridColumnSetting(Me.Name, inventoryGrid)
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
    Private Sub Em_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Em.KeyPress
        If e.KeyChar() = Chr(13) Then
            ShowStockoutQuan()
        End If
    End Sub
    Private Sub Em_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Em.DoubleClick
        ShowStockoutQuan()
    End Sub

    Private Sub menuView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuView.Click
        ShowStockoutQuan()
    End Sub
    Public Sub ShowStockoutQuan()
        If CheckSelectedRow("productid", inventoryGrid) = True Then
            frmNewManualInventory.productid.Text = inventoryGrid.GetFocusedRowCellValue("productid").ToString
            frmNewManualInventory.txtQuantity.Focus()
            Me.Close()
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        ShowStockoutQuan()
    End Sub

    Private Sub RefreshDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshDataToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub txtfilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfilter.KeyPress
        If e.KeyChar() = Chr(13) Then
            filter()
        End If
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdAddnew.Click
        AddProduct("", Me, True)
        If productnameselected <> "" Then
            txtfilter.Text = productnameselected
            filter()
        End If
    End Sub

    Private Sub EditProductInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProductInformationToolStripMenuItem.Click
        If inventoryGrid.GetFocusedRowCellValue("productid") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        EditProduct(inventoryGrid.GetFocusedRowCellValue("productid").ToString, Me, True)
        filter()
    End Sub
End Class