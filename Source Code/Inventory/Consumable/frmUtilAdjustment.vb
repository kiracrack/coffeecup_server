Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmUtilAdjustment
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmUtilAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowInventoryInfo()
    End Sub
    Private Sub productid_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles productid.EditValueChanged
        ShowInventoryInfo()
    End Sub

    Public Sub ShowInventoryInfo()
        If productid.Text = "" Or officeid.Text = "" Then Exit Sub
        com.CommandText = "select *, (select ITEMNAME from tblglobalproducts where productid = tblinventory.productid and actived=1) as 'PRODUCTS', " _
                              + " (select officename from tblcompoffice where officeid = tblinventory.officeid) as office " _
                              + " from tblinventory where productid = '" & productid.Text & "' and officeid='" & officeid.Text & "' limit 1"
        rst = com.ExecuteReader
        While rst.Read
            txtproduct.Text = rst("PRODUCTS").ToString
            txtStock.Text = rst("office").ToString
        End While
        rst.Close()
        loadCurrentInventory()
    End Sub

    Public Sub loadCurrentInventory()
        'Gridview1.PaintStyleName = "web"
        LoadXgrid("Select trnid as 'Stock No.', quantity as 'Current Quantity',quantity as 'Actual Quantity',purchasedprice as 'Unit Cost', date_format(dateinventory, '%Y-%m-%d %r') as 'Date Inventory' from tblinventory where productid = '" & productid.Text & "' and officeid='" & officeid.Text & "' and quantity<>0 order by dateinventory asc", "tblinventory", Em, Gridview1, Me)
        XgridColCurrencyDecimalCount({"Current Quantity", "Actual Quantity", "Unit Cost"}, 3, Gridview1)
        XgridColAlign({"Product No.", "Current Quantity", "Actual Quantity", "Date Inventory", "Stock No."}, Gridview1, DevExpress.Utils.HorzAlignment.Center)
        For Each col In Gridview1.Columns
            col.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            col.OptionsColumn.AllowEdit = False
        Next
        XgridGeneralSummaryCurrency({"Current Quantity", "Actual Quantity"}, Gridview1)
        Gridview1.Columns("Actual Quantity").OptionsColumn.AllowEdit = True

        Gridview1.Appearance.Row.Font = New Font("Segoe UI", 12.0!)
        Gridview1.Appearance.FooterPanel.Font = New Font("Segoe UI", 12.0!)
        Gridview1.Appearance.GroupFooter.Font = New Font("Segoe UI", 12.0!)
    End Sub


    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles Gridview1.RowCellStyle
        Dim View As GridView = sender
        If e.Column.Name = "colActualQuantity" Then
            e.Appearance.BackColor = Color.Yellow
            e.Appearance.ForeColor = Color.Black
           
        End If
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            'com.CommandText = "DELETE from tblinventoryledger where productid = '" & productid.Text & "' and officeid='" & officeid.Text & "'" : com.ExecuteNonQuery()
            For I = 0 To Gridview1.RowCount - 1
                com.CommandText = "update tblinventory set quantity='" & Val(CC(Gridview1.GetRowCellValue(I, "Actual Quantity").ToString)) & "' where trnid='" & Gridview1.GetRowCellValue(I, "Stock No.").ToString & "'" : com.ExecuteNonQuery()
            Next
            Dim AdjustmentDifference As Double = Val(CC(Gridview1.Columns("Actual Quantity").SummaryText)) - Val(CC(Gridview1.Columns("Current Quantity").SummaryText))
            If AdjustmentDifference > 0 Then
                LogInventoryLedger("Correction", officeid.Text, productid.Text, AdjustmentDifference, 0, 0, "Inventory Correction", "", "", "")
            ElseIf AdjustmentDifference < 0 Then
                LogInventoryLedger("Correction", officeid.Text, productid.Text, 0, -AdjustmentDifference, 0, "Inventory Correction", "", "", "")
            End If
            frmInventoryConsumables.ItemAdjustmentValue(Val(CC(Gridview1.Columns("Actual Quantity").SummaryText)))
            XtraMessageBox.Show("Inventory successfully corrected!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class