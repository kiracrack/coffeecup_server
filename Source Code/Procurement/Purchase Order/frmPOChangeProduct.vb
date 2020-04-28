Imports DevExpress.Utils
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors

Public Class frmPOChangeProduct
    Public productnameselected As String
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        ElseIf keyData = Keys.Space Then
            txtfilter.Focus()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPOChangeProduct_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmManualInventoryProductSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)

    End Sub
    Public Sub filter()
        LoadXgrid("SELECT productid,tblprocategory.catid,if(partnumber='' or partnumber is null,itemname,concat(itemname,'-',tblglobalproducts.description)) as 'Select Product' , " _
                  + " Unit, (select sum(quantity) from tblinventory where productid=tblglobalproducts.productid and officeid='" & officeid.Text & "') as 'Current Inventory' from tblglobalproducts inner join tblprocategory on  tblprocategory.catid = tblglobalproducts.catid where " & SearchProductName("itemname", txtfilter.Text) & " and deleted=0 and consumable=1 order by itemname asc", "tblglobalproducts", Em, inventoryGrid, Me)
        XgridHideColumn({"productid", "catid"}, inventoryGrid)
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
            If inventoryGrid.GetFocusedRowCellValue("productid") = "" Then
                XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "UPDATE tblpurchaseorderitem set productid='" & inventoryGrid.GetFocusedRowCellValue("productid").ToString() & "', itemname='" & rchar(inventoryGrid.GetFocusedRowCellValue("Select Product").ToString()) & "',catid='" & inventoryGrid.GetFocusedRowCellValue("catid").ToString() & "' where trnid='" & trnid.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblinventory set productid='" & inventoryGrid.GetFocusedRowCellValue("productid").ToString() & "', productname='" & rchar(inventoryGrid.GetFocusedRowCellValue("Select Product").ToString()) & "',catid='" & inventoryGrid.GetFocusedRowCellValue("catid").ToString() & "' where productid='" & productid.Text & "' and stockref='" & ponumber.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblinventoryledger set productid='" & inventoryGrid.GetFocusedRowCellValue("productid").ToString() & "', productname='" & rchar(inventoryGrid.GetFocusedRowCellValue("Select Product").ToString()) & "' where productid='" & productid.Text & "' and referenceno='" & ponumber.Text & "' and trntype='Purchase order'" : com.ExecuteNonQuery()
                frmPurchaseOrderProfile.filterParticularItems()
                Me.Close()
                XtraMessageBox.Show("Product successfully changed", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
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

 
 
End Class