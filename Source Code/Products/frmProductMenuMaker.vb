﻿Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmProductMenuMaker
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
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

    Private Sub frmProductMenuMaker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(gridMenuProduct)
        LoadGridviewAppearance(gridItemMenu)
        LoadSourceProduct()
        LoadDetailsProduct()
        filter()
        ckEnableInventory.Checked = CBool(qrysingledata("enablemenumakerinventory", "enablemenumakerinventory", "tblgeneralsettings"))
        ckStrictInventory.Checked = CBool(qrysingledata("enablestrictmenumakerinventory", "enablestrictmenumakerinventory", "tblgeneralsettings"))
        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdRemove.Visible = True
        Else
            cmdRemove.Visible = False
        End If
    End Sub

    Public Sub filter()
        LoadXgrid("Select id, (select itemname from tblglobalproducts where productid=tblproductmenuitem.productid) as 'Product Name', Quantity,Unit, Cost,(cost*quantity) as Total from tblproductmenuitem where source_productid = '" & productid_source.Text & "'", "tblproductmenuitem", Em, GridView1, Me)
        GridView1.Columns("id").Visible = False
        XgridColCurrency({"Quantity", "Cost", "Total"}, GridView1)
        XgridColAlign({"Unit"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total"}, GridView1)
    End Sub

    Public Sub LoadSourceProduct()
        LoadXgridLookupSearch("SELECT productid, itemname as 'Menu Product' from tblglobalproducts where deleted=0 and menuitem=1 and catid in (select catid from tblprocategory where (noninventory=1 or consumable=1)) order by itemname asc", "tblglobalproducts", txtSourceProduct, gridMenuProduct, Me)
        gridMenuProduct.Columns("productid").Visible = False
    End Sub

    Private Sub txtSourceProduct_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSourceProduct.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtSourceProduct.Properties.View.FocusedRowHandle.ToString)
        productid_source.Text = txtSourceProduct.Properties.View.GetFocusedRowCellValue("productid").ToString()
        txtSourceProduct.Text = txtSourceProduct.Properties.View.GetFocusedRowCellValue("Menu Product").ToString()
        filter()
    End Sub

    Public Sub LoadDetailsProduct()
        LoadXgridLookupSearch("SELECT productid, itemname as 'Item Menu',Unit from tblglobalproducts where deleted=0 and menuitem=0 order by itemname asc", "tblglobalproducts", txtItemMenu, gridItemMenu, Me)
        gridItemMenu.Columns("productid").Visible = False
    End Sub

    Private Sub txtItemMenu_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemMenu.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtItemMenu.Properties.View.FocusedRowHandle.ToString)
        productid_item.Text = txtItemMenu.Properties.View.GetFocusedRowCellValue("productid").ToString()
        txtItemMenu.Text = txtItemMenu.Properties.View.GetFocusedRowCellValue("Item Menu").ToString()
        txtunit.Text = txtItemMenu.Properties.View.GetFocusedRowCellValue("Unit").ToString()
        txtQuantity.Focus()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtSourceProduct.Text = "" Then
            XtraMessageBox.Show("Please select main menu", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSourceProduct.Focus()
            Exit Sub
        ElseIf txtItemMenu.Text = "" Then
            XtraMessageBox.Show("Please select item menu", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtItemMenu.Focus()
            Exit Sub
        ElseIf txtQuantity.EditValue = 0 Then
            XtraMessageBox.Show("Please enter valid quantity", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtQuantity.Focus()
            Exit Sub
        End If
        com.CommandText = "insert into tblproductmenuitem set source_productid='" & productid_source.Text & "', productid='" & productid_item.Text & "', quantity='" & Val(CC(txtQuantity.Text)) & "',unit='" & txtunit.Text & "', cost=" & Val(CC(txtUnitCost.Text)) & "" : com.ExecuteNonQuery()
        filter()
    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("id", "id", "tblproductmenuitem", GridView1, Me)
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub ckStrictInventory_CheckedChanged(sender As Object, e As EventArgs) Handles ckStrictInventory.CheckedChanged
        com.CommandText = "update tblgeneralsettings set enablestrictmenumakerinventory=" & ckStrictInventory.CheckState & "" : com.ExecuteNonQuery()
    End Sub

    Private Sub txtQuantity_EditValueChanged(sender As Object, e As EventArgs) Handles txtQuantity.EditValueChanged, txtUnitCost.EditValueChanged
        txtTotalCost.Text = Val(CC(txtUnitCost.Text)) * Val(CC(txtQuantity.Text))
    End Sub

    Private Sub ckEnableInventory_CheckedChanged(sender As Object, e As EventArgs) Handles ckEnableInventory.CheckedChanged
        If ckEnableInventory.Checked = True Then
            ckStrictInventory.Enabled = True
        Else
            ckStrictInventory.Enabled = False
            ckStrictInventory.Checked = False
        End If
        com.CommandText = "update tblgeneralsettings set enablemenumakerinventory=" & ckEnableInventory.CheckState & "" : com.ExecuteNonQuery()
    End Sub
End Class