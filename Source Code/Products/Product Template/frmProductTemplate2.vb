Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient

Public Class frmProductTemplate2
    Dim addnewproduct As Boolean
    Private Sub frmProductTemplate2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmParticularInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadCategory()
        LoadToComboBox("unitname", "tblproductunit", txtUnit, True)
        LoadGridviewAppearance(combogrid)
        LoadOffice()

        If mode.Text <> "edit" Then
            productid.Text = getproid()
        Else
            ShowProductInfo()
        End If
        If Globalenableproductbarcodefocus = True Then
            txtBarcode.Focus()
        Else
            txtProductName.Focus()
        End If
        tabInformation.Focus()
    End Sub

    Public Sub LoadOffice()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Office' from tblcompoffice order by officename asc", "tblcompoffice", txtOfficeCenter, gv_inventory, Me)
        gv_inventory.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOfficeCenter.EditValueChanged
        On Error Resume Next
        officeid.Text = txtOfficeCenter.Properties.View.GetFocusedRowCellValue("officeid").ToString()
    End Sub

    Public Sub LoadCategory()
        LoadXgridLookupSearch("select catid,DESCRIPTION 'Select Category' from tblprocategory order by DESCRIPTION asc", "tblprocategory", txtprocat, combogrid, Me)
        combogrid.Columns("catid").Visible = False
    End Sub

    Private Sub txtprocat_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprocat.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtprocat.Properties.View.FocusedRowHandle.ToString)
        catid.Text = txtprocat.Properties.View.GetFocusedRowCellValue("catid").ToString()
        LoadSubCategory()
        ValidateProductCategory()
        If gridsubcategory.RowCount = 0 Then
            txtUnit.Focus()
        Else
            txtSubCategory.Focus()
            'txtSubCategory.ShowPopup()
        End If
    End Sub

    Public Sub LoadSubCategory()
        If catid.Text = "" Then Exit Sub
        LoadXgridLookupSearch("select subcatid, DESCRIPTION 'Select' from tblprosubcategory where catid='" & catid.Text & "' order by description asc", "tblprosubcategory", txtSubCategory, gridsubcategory, Me)
        gridsubcategory.Columns("subcatid").Visible = False
        If gridsubcategory.RowCount = 0 Then
            txtSubCategory.Enabled = False
        Else
            txtSubCategory.Enabled = True
        End If
        txtSubCategory.Focus()
    End Sub

    Private Sub txtSubCategory_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubCategory.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtprocat.Properties.View.FocusedRowHandle.ToString)
        subcatid.Text = txtprocat.Properties.View.GetFocusedRowCellValue("subcatid").ToString()
        txtUnit.Focus()
    End Sub

    Private Sub cmdSaveAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveAdd.Click
        If SaveProductInfo() = True Then
            clearfields()
            addnewproduct = True
        End If
    End Sub
    Private Sub cmdSaveExit_Click(sender As Object, e As EventArgs) Handles cmdSaveExit.Click
        If SaveProductInfo() = True Then
            If frmManualInventoryProductSearch.Visible = True Then
                frmManualInventoryProductSearch.productnameselected = txtProductName.Text
            End If
            Me.Close()
        End If
    End Sub

    Public Function SaveProductInfo() As Boolean
        If productid.Text = "" Then
            XtraMessageBox.Show("Please enter itemcode!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            productid.Focus()
            Exit Function
        ElseIf productid.Text.Contains(" ") = True And mode.Text <> "edit" Then
            XtraMessageBox.Show("Please enter itemcode without space!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            productid.Focus()
            Exit Function
        ElseIf txtprocat.Text = "" Then
            XtraMessageBox.Show("Please select category!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtprocat.Focus()
            Exit Function
        ElseIf txtProductName.Text = "" Then
            XtraMessageBox.Show("Please provide particular name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtProductName.Focus()
            Exit Function
        ElseIf txtUnit.Text = "" Then
            XtraMessageBox.Show("Please select unit!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUnit.Focus()
            Exit Function
        ElseIf countqry("tblglobalproducts", "barcode='" & txtBarcode.Text & "' and productid<>'" & productid.Text & "'") > 0 And txtBarcode.Text <> "" Then
            XtraMessageBox.Show("Barcode already exists!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBarcode.SelectAll()
            txtBarcode.Focus()
            Exit Function
        ElseIf countqry("tblglobalproducts", "itemname='" & rchar(txtProductName.Text) & "' and unit='" & txtUnit.Text & "' and catid='" & catid.Text & "' and productid<>'" & productid.Text & "' and deleted=0") > 0 Then
            XtraMessageBox.Show("Duplicate particular item name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProductName.SelectAll()
            txtProductName.Focus()
            Exit Function
        ElseIf ckOfficeCenter.Checked = True And officeid.Text = "" Then
            XtraMessageBox.Show("Please select product center office!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOfficeCenter.SelectAll()
            txtOfficeCenter.Focus()
            Exit Function
        End If

        UpdateProductTemplate2(mode.Text, productid.Text, txtBarcode.Text, catid.Text, subcatid.Text, rchar(txtProductName.Text), rchar(txtDescription.Text), rchar(txtUnit.Text), Val(CC(txtReorderPoint.Text)), ckEnableSell.CheckState, ckVatEnable.CheckState, ckServiceCharge.CheckState, ckNonInventory.CheckState, ckStandardCosting.CheckState, ckMenuMakerServices.CheckState, ckCustomizeProductOrder.CheckState, ckRequiredAttendingPerson.CheckState, ckOfficeCenter.CheckState, officeid.Text, ckComputeLength.CheckState, ckEnableCoupon.CheckState, Val(CC(txtPurchasedPrice.Text)), 0, Val(CC(txtSellingPrice.Text)), If(esbq.Checked = True, "esbq", "esba"), ckInputDiscount.CheckState, False)
        UpdateInventoryInfo(productid.Text, txtProductName.Text, catid.Text, txtUnit.Text, Val(CC(txtSellingPrice.Text)))
        UpdateProductImage(productid.Text, PictureEdit1, Me)
        XtraMessageBox.Show("Product successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return True
    End Function
    Public Sub clearfields()
        productid.Text = getproid()
        PictureEdit1.Image = Nothing
        txtBarcode.Text = ""
        txtProductName.Text = ""
        mode.Text = ""
        If Globalenableproductbarcodefocus = True Then
            txtBarcode.Focus()
        Else
            txtProductName.Focus()
        End If
    End Sub

    Private Sub signature_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles PictureEdit1.Validating
        ResizeImage(PictureEdit1, 600)
    End Sub


    Public Sub ShowProductInfo()
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select *, case when purchasedprice = 0 then (select procost from tblitemvendor where itemid = tblglobalproducts.productid order by lastupdate desc limit 1) else purchasedprice end as 'purchasedcost' from tblglobalproducts where productid='" & productid.Text & "' and actived=1", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                txtprocat.Text = .Rows(cnt)("catid").ToString
                catid.Text = .Rows(cnt)("catid").ToString
                subcatid.Text = .Rows(cnt)("subcatid").ToString
                txtSubCategory.Text = .Rows(cnt)("subcatid").ToString
                txtBarcode.Text = .Rows(cnt)("barcode").ToString
                txtProductName.Text = .Rows(cnt)("itemname").ToString
                txtDescription.Text = .Rows(cnt)("description").ToString
                txtUnit.Text = .Rows(cnt)("unit").ToString
                ckEnableSell.Checked = CBool(.Rows(cnt)("enablesell").ToString)
                ckNonInventory.Checked = CBool(.Rows(cnt)("forcontract").ToString)
                ckStandardCosting.Checked = CBool(.Rows(cnt)("menuitem").ToString)
                ckMenuMakerServices.Checked = CBool(.Rows(cnt)("servicemenuproduct").ToString)
                ckCustomizeProductOrder.Checked = CBool(.Rows(cnt)("customproductorder").ToString)
                txtPurchasedPrice.Text = .Rows(cnt)("purchasedcost").ToString
                txtSellingPrice.Text = .Rows(cnt)("sellingprice").ToString
                If .Rows(cnt)("salemode").ToString = "esbq" Then
                    esbq.Checked = True
                Else
                    esba.Checked = True
                End If
                ckInputDiscount.Checked = CBool(.Rows(cnt)("allowinputdiscountedamount").ToString)
                ckVatEnable.Checked = CBool(.Rows(cnt)("vatableitem").ToString)
                ckServiceCharge.Checked = CBool(.Rows(cnt)("svchargeitem").ToString)
                ckOfficeCenter.Checked = CBool(.Rows(cnt)("enablecenter").ToString)
                officeid.Text = .Rows(cnt)("officecenter").ToString
                txtOfficeCenter.Text = .Rows(cnt)("officecenter").ToString
                ckComputeLength.Checked = CBool(.Rows(cnt)("enablecomputelength").ToString)
                ckEnableCoupon.Checked = CBool(.Rows(cnt)("enablecoupon").ToString)
                ckRequiredAttendingPerson.Checked = CBool(.Rows(cnt)("requiredattendingpersonnel").ToString)
                txtReorderPoint.Text = .Rows(cnt)("reorderpoint").ToString

            End With
        Next
        com.CommandText = "select ifnull((select imgdata from " & sqlfiledir & ".tblproductimage where productid=tblglobalproducts.productid),null) as img from tblglobalproducts where productid='" & productid.Text & "'" : rst = com.ExecuteReader()
        While rst.Read
            ShowImage("img", PictureEdit1, Me)
        End While
        rst.Close()
        If ckOfficeCenter.Checked = True Then
            txtOfficeCenter.Enabled = True
            ckEnableCoupon.Enabled = True
        Else
            txtOfficeCenter.Enabled = False
            ckEnableCoupon.Enabled = False
        End If
    End Sub
    'Public Sub CalculateSellRate()
    '    txtSellingPrice.Text = ((Val(CC(txtSellingRate.Text)) / 100) * Val(CC(txtPurchasedPrice.Text))) + Val(CC(txtPurchasedPrice.Text))
    '    If Val(CC(txtSellingRate.Text)) > 0 Then
    '        txtSellingPrice.Properties.ReadOnly = True
    '    Else
    '        txtSellingPrice.Properties.ReadOnly = False
    '    End If
    'End Sub
    Private Sub txtitem_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProductName.GotFocus
        If mode.Text = "edit" Then
            Me.AcceptButton = cmdSaveExit
        End If
    End Sub

    Private Sub id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles productid.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtprocat.Text = "" Then
                txtprocat.Focus()
            Else
                txtProductName.Focus()
            End If
        End If
    End Sub

    Private Sub ckUnit_CheckedChanged(sender As Object, e As EventArgs)
        'If ckUnit.Checked = True Then
        '    txtUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        'Else
        '    txtUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        'End If
    End Sub

    Private Sub ckEnableSell_CheckedChanged(sender As Object, e As EventArgs) Handles ckEnableSell.CheckedChanged
        ValidateProductCategory()
    End Sub

    Public Sub ValidateProductCategory()
        If catid.Text = "" Then Exit Sub
        If ckEnableSell.Checked = True Then
            If CBool(qrysingledata("noninventory", "noninventory", "tblprocategory where catid='" & catid.Text & "'")) = True Then
                ckNonInventory.Checked = True
                ckStandardCosting.Enabled = True
                ckMenuMakerServices.Enabled = True
                ckCustomizeProductOrder.Enabled = True
                panelSale.Enabled = True

                txtPurchasedPrice.Enabled = False

            ElseIf CBool(qrysingledata("consumable", "consumable", "tblprocategory where catid='" & catid.Text & "'")) = True Then
                panelSale.Enabled = True
                ckNonInventory.Checked = False
                ckStandardCosting.Enabled = False
                ckStandardCosting.Checked = False

                ckMenuMakerServices.Enabled = False
                ckMenuMakerServices.Checked = False

                ckCustomizeProductOrder.Enabled = False
                ckCustomizeProductOrder.Checked = False

                txtPurchasedPrice.Enabled = True
            End If
            esbq.Enabled = True
            esba.Enabled = True
            ckRequiredAttendingPerson.Enabled = True
            txtSellingPrice.Focus()
        Else
            panelSale.Enabled = False
            ckNonInventory.Checked = False
            ckStandardCosting.Enabled = False
            ckStandardCosting.Checked = False
            ckMenuMakerServices.Enabled = False
            ckMenuMakerServices.Checked = False
            ckCustomizeProductOrder.Enabled = False
            ckCustomizeProductOrder.Checked = False
            esbq.Enabled = False
            esba.Enabled = False
            ckRequiredAttendingPerson.Enabled = False
        End If
    End Sub


    Private Sub cmdBarcode_Click(sender As Object, e As EventArgs)
        frmBarcodeTest.itemcode.Text = productid.Text
        frmBarcodeTest.ShowDialog(Me)
    End Sub

    Private Sub txtSellingPrice_GotFocus(sender As Object, e As EventArgs) Handles txtSellingPrice.GotFocus
        txtSellingPrice.SelectAll()
        If addnewproduct = True Then
            Me.AcceptButton = cmdSaveAdd
        Else
            Me.AcceptButton = cmdSaveExit
        End If

    End Sub

    Private Sub ckOfficeCenter_CheckedChanged(sender As Object, e As EventArgs) Handles ckOfficeCenter.CheckedChanged
        If ckOfficeCenter.Checked = True Then
            txtOfficeCenter.Enabled = True
            txtOfficeCenter.Properties.DataSource = Nothing
            txtOfficeCenter.Text = ""
            LoadOffice()
            ckEnableCoupon.Enabled = True
        Else
            txtOfficeCenter.Enabled = False
            officeid.Text = ""
            ckEnableCoupon.Enabled = False
            ckEnableCoupon.Checked = False
        End If
    End Sub

    Private Sub HyperlinkLabelControl1_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl1.Click
        If frmProductCategory.Visible = True Then
            frmProductCategory.Focus()
        Else
            frmProductCategory.ShowDialog(Me)
        End If
        LoadCategory()
    End Sub

    Private Sub HyperlinkLabelControl2_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl2.Click
        If txtprocat.Text = "" Then
            XtraMessageBox.Show("Please select category!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtprocat.Focus()
            Exit Sub
        End If
        frmProductSubCategory.catid.Text = catid.Text
        frmProductSubCategory.txtCategory.Text = catid.Text
        If frmProductSubCategory.Visible = True Then
            frmProductSubCategory.Focus()
        Else
            frmProductSubCategory.ShowDialog(Me)
        End If
        LoadSubCategory()
    End Sub

    Private Sub txtprocat_GotFocus(sender As Object, e As EventArgs) Handles txtprocat.GotFocus
        'txtprocat.ShowPopup()
    End Sub
     
    Private Sub txtUnit_GotFocus(sender As Object, e As EventArgs) Handles txtUnit.GotFocus
        'txtUnit.ShowPopup()
    End Sub

    Private Sub txtUnit_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtUnit.SelectedValueChanged
        txtReorderPoint.Focus()
    End Sub

    Private Sub esba_CheckedChanged(sender As Object, e As EventArgs) Handles esba.CheckedChanged
        If esba.Checked = True Then
            ckInputDiscount.Enabled = True
            ckInputDiscount.Checked = True
        End If
    End Sub

    Private Sub esbq_CheckedChanged(sender As Object, e As EventArgs) Handles esbq.CheckedChanged
        If esbq.Checked = True Then
            ckInputDiscount.Enabled = False
            ckInputDiscount.Checked = False
        End If
    End Sub

    Private Sub cmdEditItem_Click(sender As Object, e As EventArgs) Handles cmdEditItem.Click
        If txtProductName.Text = "" Then
            XtraMessageBox.Show("Please provide particular name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtProductName.Focus()
            Exit Sub
        ElseIf txtprocat.Text = "" Then
            XtraMessageBox.Show("Please select product category!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtprocat.Focus()
            Exit Sub
        ElseIf txtUnit.Text = "" Then
            XtraMessageBox.Show("Please select unit!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUnit.Focus()
            Exit Sub
        End If
        frmBatchingProduct.catid.Text = catid.Text
        frmBatchingProduct.txtitem.Text = txtProductName.Text
        frmBatchingProduct.ShowDialog(Me)
    End Sub
    Public Sub UploadBatchRegistration(ByVal gv As DataGridView)
        frmBatchingProduct.ProgressBarControl1.Visible = True
        frmBatchingProduct.ProgressBarControl1.Properties.Step = 1
        frmBatchingProduct.ProgressBarControl1.Properties.PercentView = True
        frmBatchingProduct.ProgressBarControl1.Properties.Maximum = gv.RowCount - 1
        frmBatchingProduct.ProgressBarControl1.Properties.Minimum = 0
        frmBatchingProduct.ProgressBarControl1.Position = 0
        For I = 0 To gv.RowCount - 1
            UpdateProductTemplate2(mode.Text, getproid(), txtBarcode.Text, catid.Text, subcatid.Text, rchar(gv.Item("Product Name", I).Value), rchar(txtDescription.Text), txtUnit.Text, Val(CC(txtReorderPoint.Text)), ckEnableSell.CheckState, ckVatEnable.CheckState, ckServiceCharge.CheckState, ckNonInventory.CheckState, ckStandardCosting.CheckState, ckMenuMakerServices.CheckState, ckCustomizeProductOrder.CheckState, ckRequiredAttendingPerson.CheckState, ckOfficeCenter.CheckState, officeid.Text, ckComputeLength.CheckState, ckEnableCoupon.CheckState, Val(CC(txtPurchasedPrice.Text)), 0, Val(CC(txtSellingPrice.Text)), If(esbq.Checked = True, "esbq", "esba"), ckInputDiscount.CheckState, True)
            frmBatchingProduct.ProgressBarControl1.PerformStep()
            frmBatchingProduct.ProgressBarControl1.Update()
        Next
        frmBatchingProduct.ProgressBarControl1.Update()
        frmBatchingProduct.ProgressBarControl1.Refresh()
        XtraMessageBox.Show("Product batch successfully uploaded!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        frmBatchingProduct.ProgressBarControl1.Visible = False
        Me.Close()
    End Sub

    Private Sub txtBarcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBarcode.KeyPress
        If e.KeyChar = Chr(13) Then
            txtProductName.Focus()
        End If
    End Sub

    Private Sub cmdBaselineUnit_Click(sender As Object, e As EventArgs) Handles cmdBaselineUnit.Click
        frmProductMeasurement.ShowDialog(Me)
        LoadToComboBox("unitname", "tblproductunit", txtUnit, True)
    End Sub
End Class