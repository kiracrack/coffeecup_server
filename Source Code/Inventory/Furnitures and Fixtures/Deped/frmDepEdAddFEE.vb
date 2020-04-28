﻿Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmDepEdAddFEE
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmDepEdUpdateRequestStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtDateAcquired.EditValue = CDate(Now)
        loadCompOffice()
        LoadAccountable()
        loadProducts()
        LoadEstimatedLife()
        LoadVendor()
        If mode.Text = "edit" Then
            ShowEquipmentInfo()
        End If
    End Sub
    Public Sub loadCompOffice()
        LoadXgridLookupSearch("select officeid, officename as 'Office' from tblcompoffice order by officename", "tblcompoffice", txtoffice, gridcompoffice, Me)
        gridcompoffice.Columns("officeid").Visible = False
        Me.txtoffice.Properties.DisplayMember = "Office"
        Me.txtoffice.Properties.ValueMember = "Office"
    End Sub

    Private Sub txtcompoffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtoffice.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtoffice.Properties.View.FocusedRowHandle.ToString)
        officeid.Text = txtoffice.Properties.View.GetFocusedRowCellValue("officeid").ToString
    End Sub

    Public Sub LoadAccountable()
        LoadXgridLookupSearch("select accountid, Fullname from tblaccounts where username<>'ROOT' and deleted=0 order by fullname asc", "tblaccounts", txtAccountablePerson, s_grid, Me)
        s_grid.Columns("accountid").Visible = False
    End Sub

    Private Sub txtrequestby_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccountablePerson.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtAccountablePerson.Properties.View.FocusedRowHandle.ToString)
        accountable.Text = txtAccountablePerson.Properties.View.GetFocusedRowCellValue("accountid").ToString()
    End Sub

    Public Sub loadProducts()
        LoadXgridLookupSearch("SELECT distinct(productid),tblglobalproducts.catid, if(partnumber='' or partnumber is null,itemname,concat(itemname,'-',partnumber)) as 'Select Product' , Unit, purchasedprice from tblglobalproducts inner join tblprocategory on  tblprocategory.catid = tblglobalproducts.catid where deleted=0 and ffe=1 order by itemname asc ", "tblglobalproducts", txtProductItemName, g_product, Me)
        g_product.BestFitColumns()
        g_product.Columns("productid").Visible = False
        g_product.Columns("catid").Visible = False
        g_product.Columns("purchasedprice").Visible = False
        g_product.Columns("Select Product").Width = 350
    End Sub

    Private Sub txtProduct_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProductItemName.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtProductItemName.Properties.View.FocusedRowHandle.ToString)
        productid.Text = txtProductItemName.Properties.View.GetFocusedRowCellValue("productid").ToString()
        txtUnit.Text = txtProductItemName.Properties.View.GetFocusedRowCellValue("Unit").ToString()
        txtUnitCost.Text = txtProductItemName.Properties.View.GetFocusedRowCellValue("purchasedprice").ToString()
        txtQuantity.Focus()
    End Sub

    Public Sub LoadEstimatedLife()
        LoadToComboBox("estimatedlife", "tblofficeequipment", txtEstimatedLife, True)
    End Sub

    Public Sub LoadVendor()
        LoadXgridLookupSearch("select vendorid, CompanyName as 'Select Company' from tblglobalvendor order by CompanyName asc", "tblglobalvendor", txtVendor, g_vendor, Me)
        g_vendor.Columns("vendorid").Visible = False
    End Sub

    Private Sub txtVendor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVendor.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtVendor.Properties.View.FocusedRowHandle.ToString)
        vendorid.Text = txtVendor.Properties.View.GetFocusedRowCellValue("vendorid").ToString()
    End Sub


    Private Sub txtcost_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtQuantity.EditValueChanged, txtUnitCost.EditValueChanged
        calctotal()
    End Sub
    Public Sub calctotal()
        Dim ttl
        ttl = Val(CC(txtQuantity.Text)) * Val(CC(txtUnitCost.Text))
        txtTotalCost.Text = Format(Val(ttl), "n")
        If Val(CC(txtUnitCost.Text)) > 0 Then
            Me.AcceptButton = cmdOk
        End If
    End Sub

    Public Sub ShowEquipmentInfo()
        com.CommandText = "select *,(select officename from tblcompoffice where officeid =tblofficeequipment.officeid) as office, " _
                        + " (select fullname from tblaccounts where accountid=tblofficeequipment.accountable) as accountableperson, " _
                        + " (select productname from tblglobalproducts where productid=tblofficeequipment.productid) as product, " _
                        + " (select companyname from tblglobalvendor where vendorid=tblofficeequipment.vendorid) as vendor from tblofficeequipment where id='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            officeid.Text = rst("officeid").ToString
            txtoffice.Text = rst("office").ToString
            accountable.Text = rst("accountable").ToString
            txtAccountablePerson.Text = rst("accountableperson").ToString
            productid.Text = rst("productid").ToString
            txtProductItemName.Text = rst("product").ToString
            txtItemDetails.Text = rst("productdetails").ToString
            txtPropertyNo.Text = rst("propertyno").ToString
            txtQuantity.Text = rst("quantity").ToString
            txtUnit.Text = rst("unit").ToString
            txtUnitCost.EditValue = rst("unitcost").ToString
            txtTotalCost.EditValue = rst("totalcost").ToString
            txtEstimatedLife.Text = rst("estimatedlife").ToString
            txtDateAcquired.EditValue = rst("dateacquired").ToString
            vendorid.Text = rst("vendorid").ToString
            txtVendor.Text = rst("vendor").ToString
        End While
        rst.Close()
    End Sub


    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If MessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "UPDATE tblofficeequipment set officeid='" & officeid.Text & "', accountable='" & accountable.Text & "', productid='" & productid.Text & "',productname='" & rchar(txtProductItemName.Text) & "', productdetails='" & rchar(txtItemDetails.Text) & "', propertyno='" & txtPropertyNo.Text & "', quantity='" & Val(CC(txtQuantity.EditValue)) & "', unit='" & txtUnit.Text & "', unitcost='" & Val(CC(txtUnitCost.EditValue)) & "', totalcost='" & Val(CC(txtTotalCost.EditValue)) & "', estimatedlife='" & txtEstimatedLife.Text & "', dateacquired='" & ConvertDate(txtDateAcquired.EditValue) & "',vendorid='" & vendorid.Text & "', entryby='" & globalfullname & "', dateentry=current_timestamp where id='" & id.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblofficeequipment set officeid='" & officeid.Text & "', accountable='" & accountable.Text & "', productid='" & productid.Text & "',productname='" & rchar(txtProductItemName.Text) & "', productdetails='" & rchar(txtItemDetails.Text) & "', propertyno='" & txtPropertyNo.Text & "', quantity='" & Val(CC(txtQuantity.EditValue)) & "', unit='" & txtUnit.Text & "', unitcost='" & Val(CC(txtUnitCost.EditValue)) & "', totalcost='" & Val(CC(txtTotalCost.EditValue)) & "', estimatedlife='" & txtEstimatedLife.Text & "', dateacquired='" & ConvertDate(txtDateAcquired.EditValue) & "',vendorid='" & vendorid.Text & "', entryby='" & globalfullname & "', dateentry=current_timestamp" : com.ExecuteNonQuery()
            End If
            frmDepedFFESummary.filterInventory()
            XtraMessageBox.Show("Office equipment successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
 
 
    Private Sub cmdAddItem_Click(sender As Object, e As EventArgs) Handles cmdAddItem.Click
        AddProduct("", Me, True)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If frmVendorInformation.Visible = True Then
            frmVendorInformation.Focus()
        Else
            frmVendorInformation.ShowDialog(Me)
            LoadVendor()
        End If
    End Sub
End Class