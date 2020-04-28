Imports DevExpress.Utils
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen

Public Class frmStockoutInventory
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        
        ElseIf keyData = Keys.Space Then
            txtfilter.Focus()

        End If
        Return ProcessCmdKey
    End Function
   
    Private Sub frmWidrawalInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        filter()
    End Sub
    Public Sub filter()
        LoadXgrid("Select trnid as 'Stock No.', productname as 'Product Name', " _
                        + " quantity as 'Available Quantity', Unit, purchasedprice as 'Unit Cost', date_format(dateinventory,'%Y-%m-%d %r') as 'Date Inventory' " _
                        + " from tblinventory where officeid='" & officeid.Text & "' and (productname like '%" & txtfilter.Text & "%' or productid like '%" & txtfilter.Text & "%')  and quantity > 0  order by productname asc", "tblinventory", Em, inventoryGrid, Me)
        XgridColCurrencyDecimalCount({"Available Quantity", "Unit Cost"}, 3, inventoryGrid)
        XgridColAlign({"Stock No.", "Unit", "Available Quantity"}, inventoryGrid, DevExpress.Utils.HorzAlignment.Center)
        inventoryGrid.BestFitColumns()
        inventoryGrid.Focus()
        Em.Focus()

        com.CommandText = "select * from tblcolumnindex where form='" & Me.Name & "' and gridview='" & inventoryGrid.Name & "' order by colindex asc" : rst = com.ExecuteReader
        While rst.Read
            inventoryGrid.Columns(rst("columnname").ToString).VisibleIndex = rst("colindex")
            If Val(rst("columnwidth").ToString) > 0 Then
                inventoryGrid.Columns(rst("columnname").ToString).Width = Val(rst("columnwidth").ToString)
            End If
        End While
        rst.Close()
    End Sub

    Private Sub inventoryGrid_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles inventoryGrid.ColumnWidthChanged
        UpdateGridColumnSetting(Me.Name, inventoryGrid)
    End Sub

    Private Sub inventoryGrid_DragObjectDrop(sender As Object, e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles inventoryGrid.DragObjectDrop
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
        If CheckSelectedRow("Product Name", inventoryGrid) = True Then
            If mode.Text = "transfer" Then
                If frmTransferNew.Visible = True Then
                    frmTransferNew.refcode.Text = inventoryGrid.GetFocusedRowCellValue("Stock No.").ToString
                    frmTransferNew.Focus()
                    Me.Close()
                End If
            Else
                If frmStockoutQuantity.Visible = True Then
                    frmStockoutQuantity.stockid.Text = inventoryGrid.GetFocusedRowCellValue("Stock No.").ToString
                    frmStockoutQuantity.Focus()
                Else
                    frmStockoutQuantity.stockid.Text = inventoryGrid.GetFocusedRowCellValue("Stock No.").ToString
                    frmStockoutQuantity.Show(Me)
                End If
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