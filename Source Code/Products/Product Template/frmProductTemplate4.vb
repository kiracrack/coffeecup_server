Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmProductTemplate4
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Enter) Then
            If txtitem.Focus = True Then
                txtSellingPrice.Focus()
            End If
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmParticularInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        'SkinManager.EnableMdiFormSkins()
        If mode.Text <> "edit" Then
            productid.Text = getproid()
        End If
        LoadCategory()
        LoadToComboBox("unit", "tblglobalproducts", txtUnit, True)
        LoadGridviewAppearance(combogrid)

    End Sub

    Public Sub LoadCategory()
        LoadXgridLookupEdit("select CATID,DESCRIPTION 'Select Category' from tblprocategory order by DESCRIPTION asc", "tblprocategory", txtprocat, combogrid, Me)
        combogrid.Columns("CATID").Visible = False
    End Sub

    Private Sub txtprocat_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprocat.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtprocat.Properties.View.FocusedRowHandle.ToString)
        catid.Text = txtprocat.Properties.View.GetFocusedRowCellValue("CATID").ToString()
        txtprocat.Text = txtprocat.Properties.View.GetFocusedRowCellValue("Select Category").ToString()
        txtitem.Focus()
        
        ValidateProductCategory()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveParticular.Click
        If productid.Text = "" Then
            XtraMessageBox.Show("Please enter itemcode!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            productid.Focus()
            Exit Sub
        ElseIf productid.Text.Contains(" ") = True And mode.Text <> "edit" Then
            XtraMessageBox.Show("Please enter itemcode without space!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            productid.Focus()
            Exit Sub
        ElseIf txtprocat.Text = "" Then
            XtraMessageBox.Show("Please select category!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtprocat.Focus()
            Exit Sub
        ElseIf txtitem.Text = "" Then
            XtraMessageBox.Show("Please provide particular name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtitem.Focus()
            Exit Sub
        ElseIf txtUnit.Text = "" Then
            XtraMessageBox.Show("Please select unit!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUnit.Focus()
            Exit Sub
        ElseIf countqry("tblglobalproducts", "barcode='" & txtBarcode.Text & "' and productid<>'" & productid.Text & "'") > 0 And txtBarcode.Text <> "" Then
            XtraMessageBox.Show("Barcode already exists!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBarcode.SelectAll()
            txtBarcode.Focus()
            Exit Sub
        ElseIf countqry("tblglobalproducts", "itemname='" & rchar(txtitem.Text) & "' and unit='" & txtUnit.Text & "'  and productid<>'" & productid.Text & "' and deleted=0") > 0 Then
            XtraMessageBox.Show("Duplicate particular item name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtitem.SelectAll()
            txtitem.Focus()
            Exit Sub
        End If
        UpdateProductTemplate4(mode.Text, productid.Text, txtBarcode.Text, catid.Text, rchar(txtitem.Text), rchar(txtPartNumber.Text), txtUnit.Text, ckEnableSell.CheckState, ckVatEnable.CheckState, ckNonInventory.CheckState, ckMenuMakerInventory.CheckState, ckMenuMakerServices.CheckState, Val(CC(txtPurchasedPrice.Text)), Val(CC(txtSellingRate.Text)), Val(CC(txtSellingPrice.Text)), Val(CC(txtSellingPrice1.Text)), Val(CC(txtSellingPrice2.Text)), Val(CC(txtSellingPrice3.Text)), Val(CC(txtSellingPrice4.Text)), radSaleMode.EditValue, ckInputDiscount.CheckState)
        UpdateInventoryInfo(productid.Text, rchar(txtitem.Text) & If(txtPartNumber.Text <> "", " " + rchar(txtPartNumber.Text), ""), catid.Text, txtUnit.Text, Val(CC(txtSellingPrice.Text)))
        clearfields()
        XtraMessageBox.Show("Product successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub clearfields()
        productid.Text = getproid()
        txtitem.Text = ""
        mode.Text = ""
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        Dim procat As String = "" : Dim Enablesell As Boolean = False : Dim contract As Boolean = False
        com.CommandText = "select *, case when purchasedprice = 0 then (select procost from tblitemvendor where itemid = tblglobalproducts.productid order by lastupdate desc limit 1) else purchasedprice end as 'purchasedcost', " _
                            + " (select description from tblprocategory where catid = tblglobalproducts.catid) as catproduct  from tblglobalproducts where productid='" & productid.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            procat = rst("catproduct").ToString
            catid.Text = rst("catid").ToString
            txtBarcode.Text = rst("barcode").ToString
            txtitem.Text = rst("itemname").ToString
            txtPartNumber.Text = rst("partnumber").ToString
            txtUnit.Text = rst("unit").ToString
            Enablesell = rst("enablesell")
            contract = rst("forcontract")
            ckMenuMakerInventory.Checked = rst("menuitem")
            ckMenuMakerServices.Checked = rst("servicemenuproduct")
            txtPurchasedPrice.Text = rst("purchasedcost").ToString
            txtSellingRate.Text = rst("calcsellrate").ToString
            txtSellingPrice.Text = rst("sellingprice").ToString
            txtSellingPrice1.Text = rst("sellingprice1").ToString
            txtSellingPrice2.Text = rst("sellingprice2").ToString
            txtSellingPrice3.Text = rst("sellingprice3").ToString
            txtSellingPrice4.Text = rst("sellingprice4").ToString
            radSaleMode.EditValue = rst("salemode").ToString
            ckInputDiscount.Checked = rst("allowinputdiscountedamount")
        End While
        rst.Close()
        txtprocat.Text = procat
        ckEnableSell.Checked = Enablesell
        ckNonInventory.Checked = contract
    End Sub
    Public Sub CalculateSellRate()
        txtSellingPrice.Text = ((Val(CC(txtSellingRate.Text)) / 100) * Val(CC(txtPurchasedPrice.Text))) + Val(CC(txtPurchasedPrice.Text))
        If Val(CC(txtSellingRate.Text)) > 0 Then
            txtSellingPrice.Properties.ReadOnly = True
        Else
            txtSellingPrice.Properties.ReadOnly = False
        End If
    End Sub
    Private Sub txtitem_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtitem.GotFocus
        Me.AcceptButton = cmdSaveParticular
    End Sub

    Private Sub id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles productid.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtprocat.Text = "" Then
                txtprocat.Focus()
            Else
                txtitem.Focus()
            End If
        End If
    End Sub

    Private Sub txtitem_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtitem.LostFocus
        Me.AcceptButton = Nothing
    End Sub

    Private Sub ckUnit_CheckedChanged(sender As Object, e As EventArgs) Handles ckUnit.CheckedChanged
        If ckUnit.Checked = True Then
            txtUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Else
            txtUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        End If
    End Sub

    Private Sub txtPurchasedPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtPurchasedPrice.EditValueChanged, txtSellingRate.EditValueChanged
        CalculateSellRate()
    End Sub

    Private Sub ckEnableSell_CheckedChanged(sender As Object, e As EventArgs) Handles ckEnableSell.CheckedChanged
        ValidateProductCategory()
    End Sub
    Public Sub ValidateProductCategory()
        If catid.Text = "" Then Exit Sub
        If ckEnableSell.Checked = True Then
            radSaleMode.SelectedIndex = 0
            If CBool(qrysingledata("noninventory", "noninventory", "tblprocategory where catid='" & catid.Text & "'")) = True Then
                ckNonInventory.Checked = True
                ckMenuMakerInventory.Enabled = True
                ckMenuMakerServices.Enabled = True
                panelSale.Enabled = True

                txtPurchasedPrice.Enabled = False
                txtSellingRate.Enabled = False

            ElseIf CBool(qrysingledata("consumable", "consumable", "tblprocategory where catid='" & catid.Text & "'")) = True Then
                panelSale.Enabled = True
                ckMenuMakerInventory.Enabled = False
                ckMenuMakerInventory.Checked = False

                ckMenuMakerServices.Enabled = False
                ckMenuMakerServices.Checked = False

                txtPurchasedPrice.Enabled = True
                txtSellingRate.Enabled = True
            End If
            radSaleMode.Enabled = True
        Else
            panelSale.Enabled = False
            ckNonInventory.Checked = False
            ckMenuMakerInventory.Enabled = False
            ckMenuMakerInventory.Checked = False
            ckMenuMakerServices.Enabled = False
            ckMenuMakerServices.Checked = False
            radSaleMode.Enabled = False
        End If
    End Sub

    Private Sub cmdBarcode_Click(sender As Object, e As EventArgs)
        frmBarcodeTest.itemcode.Text = productid.Text
        frmBarcodeTest.ShowDialog(Me)
    End Sub

    Private Sub txtSellingPrice_GotFocus(sender As Object, e As EventArgs) Handles txtSellingPrice.GotFocus
        txtSellingPrice.SelectAll()
    End Sub

    Private Sub ckContractandServices_CheckedChanged(sender As Object, e As EventArgs) Handles ckNonInventory.CheckedChanged
        If ckNonInventory.Checked = True Then
            ckMenuMakerInventory.Enabled = True
        Else
            ckMenuMakerInventory.Enabled = False
            ckMenuMakerInventory.Checked = False
        End If
    End Sub
End Class