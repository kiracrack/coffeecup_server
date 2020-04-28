Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports System.IO
Imports DevExpress.Skins

Public Class frmNewManualInventory
    Public productidselected As String
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Insert) Then
            ProductSearch()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmNewManualInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        loadCompOffice()
        loadVendor()
        loadTransactionName()
        batchcode.Text = getGlobalTrnid("BAT", globaluserid)
        trncode.Text = getGlobalTrnid("mtr", globaluserid)
        txtdatepurchased.EditValue = CDate(Now).ToString("MMMM dd, yyyy")
        filterBatch()
        If AppEnableBeginvendor = True Then
            txtVendor.Text = AppBeginvendorName
            vendorid.Text = AppBeginvendorId
        End If
    End Sub

    Public Sub loadTransactionName()
        If LCase(globaluser) = "root" Then
            LoadXgridLookupSearch("select itemcode, itemname as 'Item Name' from tbltransactioncode order by itemname asc", "tbltransactioncode", txtItemCode, gridTransactionName, Me)
        Else
            LoadXgridLookupSearch("select itemcode, itemname as 'Item Name' from tbltransactioncode where itemcode in (select itemcode from tbltransactioncodefilter where permissioncode='" & globalClientPermissionAccess & "') order by itemname asc", "tbltransactioncode", txtItemCode, gridTransactionName, Me)
        End If
        XgridHideColumn({"itemcode"}, gridTransactionName)
    End Sub
    Private Sub txtItemCode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemCode.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtItemCode.Properties.View.FocusedRowHandle.ToString)
        itemcode.Text = txtItemCode.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub
    Private Sub productid_EditValueChanged(sender As Object, e As EventArgs) Handles productid.EditValueChanged
        If productid.Text <> "" Then
            LoadProductInfo()
        Else
            txtProductName.Text = ""
            catid.Text = ""
            txtUnit.Text = ""
            txtUnitCost.EditValue = 0
        End If
    End Sub
    Public Sub LoadProductInfo()
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select * from tblglobalproducts where productid='" & productid.Text & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                txtProductName.Text = .Rows(cnt)("itemname").ToString
                catid.Text = .Rows(cnt)("catid").ToString
                txtUnit.Text = .Rows(cnt)("unit").ToString
                txtUnitCost.Text = .Rows(cnt)("purchasedprice").ToString
            End With
        Next
        txtQuantity.Focus()
    End Sub

    Public Sub loadCompOffice()
        LoadXgridLookupSearch("select officeid, officename as '" & GlobalOfficeCaption & "' from tblcompoffice order by officename asc", "tblcompoffice", txtoffice, gridcompoffice, Me)
        gridcompoffice.Columns("officeid").Visible = False
        Me.txtoffice.Properties.DisplayMember = GlobalOfficeCaption
        Me.txtoffice.Properties.ValueMember = GlobalOfficeCaption
    End Sub
    Private Sub txtcompoffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtoffice.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtoffice.Properties.View.FocusedRowHandle.ToString)
        officeid.Text = txtoffice.Properties.View.GetFocusedRowCellValue("officeid").ToString
        txtoffice.Text = txtoffice.Properties.View.GetFocusedRowCellValue(GlobalOfficeCaption).ToString
    End Sub

    Public Sub loadVendor()
        LoadXgridLookupSearch("select vendorid, companyname as 'Supplier' from tblglobalvendor order by companyname asc", "tblglobalvendor", txtVendor, gridvendor, Me)
        gridvendor.Columns("vendorid").Visible = False
    End Sub

    Private Sub txtVendor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVendor.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtoffice.Properties.View.FocusedRowHandle.ToString)
        vendorid.Text = txtVendor.Properties.View.GetFocusedRowCellValue("vendorid").ToString
        txtVendor.Text = txtVendor.Properties.View.GetFocusedRowCellValue("Supplier").ToString
    End Sub
    Public Sub filterBatch()
        LoadXgrid("Select id,(select if(partnumber='' or partnumber is null,ITEMNAME,concat(ITEMNAME,'-',partnumber)) from tblglobalproducts where productid=tblinventorylogs.productid and actived=1) as 'Particular', " _
                           + " Quantity, Unit,unitcost as 'Unit Cost',Total,(select itemname from tbltransactioncode where itemcode=tblinventorylogs.itemcode) as 'Transaction Name', (select companyname from tblglobalvendor where vendorid = tblinventorylogs.vendorid ) as 'Vendor',Remarks, (select officename from tblcompoffice where officeid = tblinventorylogs.officeid) as 'Office' " _
                           + " from tblinventorylogs where confirmed=0 and trnby='" & globaluserid & "' " _
                           + " order by datetrn asc", "tblinventorylogs", Em, GridView1, Me)

        GridView1.BestFitColumns()
        GridView1.Columns("id").Visible = False
        ' gridview1.Columns("officeid").Visible = False
        GridView1.Columns("Remarks").ColumnEdit = MemoEdit
        XgridColCurrencyDecimalCount({"Quantity", "Unit Cost", "Total"}, 3, GridView1)
        XgridGeneralSummaryCurrency({"Total"}, GridView1)
        'XgridColAlign("Particular ID", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign({"Quantity"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

        com.CommandText = "select * from tblcolumnindex where form='" & Me.Name & "' and gridview='" & GridView1.Name & "' order by colindex asc" : rst = com.ExecuteReader
        While rst.Read
            GridView1.Columns(rst("columnname").ToString).VisibleIndex = rst("colindex")
            If Val(rst("columnwidth").ToString) > 0 Then
                GridView1.Columns(rst("columnname").ToString).Width = Val(rst("columnwidth").ToString)
            End If
        End While
        rst.Close()
    End Sub

    Private Sub GridView1_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles GridView1.ColumnWidthChanged
        UpdateGridColumnSetting(Me.Name, GridView1)
    End Sub

    Private Sub GridView1_DragObjectDrop(sender As Object, e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles GridView1.DragObjectDrop
        UpdateGridColumnSetting(Me.Name, GridView1)
    End Sub


    Private Sub cmdconfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim tempquan = 0
        If txtoffice.Text = "" Then
            XtraMessageBox.Show("Please select office!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtoffice.Focus()
            Exit Sub
        ElseIf Val(CC(txtQuantity.Text)) <= 0 Then
            XtraMessageBox.Show("Please proper quantity!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtQuantity.Focus()
            Exit Sub
        ElseIf Val(txtUnitCost.Text) < 0 Then
            XtraMessageBox.Show("Please enter proper cost!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUnitCost.Focus()
            Exit Sub
        ElseIf txtItemCode.Text = "" Then
            XtraMessageBox.Show("Please select transaction name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtItemCode.Focus()
            Exit Sub
        End If
        com.CommandText = "update tblglobalproducts set purchasedprice='" & Val(CC(txtUnitCost.Text)) & "' where productid='" & productid.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "Insert into tblinventorylogs set officeid='" & officeid.Text & "', stockref='" & txtStockNo.Text & "', invoiceno='" & txtInvoiceNo.Text & "', " _
                                                                      + " stockhouseid='default', " _
                                                                      + " batchcode='" & batchcode.Text & "', " _
                                                                      + " itemcode='" & itemcode.Text & "', " _
                                                                      + " trncode='" & trncode.Text & "', " _
                                                                      + " catid='" & catid.Text & "', " _
                                                                      + " productid='" & productid.Text & "', " _
                                                                      + " quantity=" & Val(CC(txtQuantity.Text)) & ", " _
                                                                      + " unit='" & txtUnit.Text & "', " _
                                                                      + " unitcost='" & Val(CC(txtUnitCost.Text)) & "', " _
                                                                      + " total='" & Val(CC(txtTotalAmount.Text)) & "', " _
                                                                      + " datepurchased='" & ConvertDate(txtdatepurchased.Text) & "', " _
                                                                      + " vendorid='" & If(vendorid.Text = "", AppBeginvendorId, vendorid.Text) & "', " _
                                                                      + " remarks='" & rchar(txtitemremarks.Text) & "', " _
                                                                      + " datetrn=current_timestamp, " _
                                                                      + " trnby='" & globaluserid & "', " _
                                                                      + " confirmed=0" : com.ExecuteNonQuery()
        filterBatch()
        Clearfields()
        If XtraMessageBox.Show("Do you want to add more product?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            ProductSearch()
        Else
            cmdConfirm.Focus()
        End If
    End Sub
    Public Sub Clearfields()
        productid.Text = ""
        trncode.Text = getGlobalTrnid("mtr", globaluserid)
        txtQuantity.Text = "0"
        txtUnit.Text = ""
        txtUnitCost.Text = "0.00"
        txtitemremarks.Text = ""
    End Sub
 
    Private Sub txtcost_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtQuantity.EditValueChanged, txtUnitCost.EditValueChanged
        calctotal()
    End Sub
    Public Sub calctotal()
        Dim ttl
        ttl = Val(CC(txtQuantity.Text)) * Val(CC(txtUnitCost.Text))
        txtTotalAmount.Text = Format(Val(ttl), "n")
        If Val(CC(txtUnitCost.Text)) > 0 Then
            Me.AcceptButton = cmdAdd
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filterBatch()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdConfirm.Click
        If GridView1.RowCount = 0 Then
            XtraMessageBox.Show("Theres no item to save!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtoffice.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Continue confirm batch inventory?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            dst = New DataSet
            msda = New MySqlDataAdapter("Select * from tblinventorylogs where confirmed=0 and trnby='" & globaluserid & "'", conn)
            msda.Fill(dst, 0)
            ProgressBarControl1.Visible = True
            ProgressBarControl1.Properties.Step = 1
            ProgressBarControl1.Properties.PercentView = True
            ProgressBarControl1.Properties.Maximum = GridView1.RowCount - 1
            ProgressBarControl1.Properties.Minimum = 0
            ProgressBarControl1.Position = 0
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    UpdateInventory("Manual Inventory", .Rows(cnt)("stockref").ToString(), .Rows(cnt)("officeid").ToString(), .Rows(cnt)("vendorid").ToString(), .Rows(cnt)("stockhouseid").ToString(), .Rows(cnt)("productid").ToString(), Val(CC(.Rows(cnt)("quantity").ToString())), Val(CC(.Rows(cnt)("unitcost").ToString())), "manual stockin", "", .Rows(cnt)("invoiceno").ToString())
                    com.CommandText = "update tblinventorylogs set confirmed=1 where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                    If EnableModuleAccounting = True Then
                        com.CommandText = "CALL sp_acct_entries('" & .Rows(cnt)("id").ToString() & "','" & .Rows(cnt)("officeid").ToString() & "', 'STOCK_IN_MANUAL','')" : com.ExecuteNonQuery()
                    End If
                End With
                ProgressBarControl1.PerformStep()
                ProgressBarControl1.Update()
            Next
            ProgressBarControl1.Update()
            ProgressBarControl1.Refresh()
            ProgressBarControl1.Visible = False
            filterBatch()
            batchcode.Text = getGlobalTrnid("BAT", globaluserid)
            frmManualInventoryHistory.filter()
            XtraMessageBox.Show("Inventory successfully updated", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub RemoveParticularToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RemoveParticularToolStripMenuItem.Click
        If CheckSelectedRow("id", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to continue this action?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                For I = 0 To GridView1.SelectedRowsCount - 1
                    com.CommandText = "delete from tblinventorylogs where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id") & "'" : com.ExecuteNonQuery()
                Next
                GridView1.DeleteSelectedRows()
            End If
        End If
    End Sub

    Public Sub ProductSearch()
        If txtoffice.Text = "" Then
            XtraMessageBox.Show("Please select office!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtoffice.Focus()
            Exit Sub
        End If
        frmManualInventoryProductSearch.officeid.Text = officeid.Text
        frmManualInventoryProductSearch.ShowDialog(Me)
        If productid.Text <> "" Then
            txtQuantity.Focus()
        End If
    End Sub
 
   
    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        ProductSearch()
    End Sub
End Class