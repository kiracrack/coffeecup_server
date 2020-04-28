﻿Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid

Public Class frmProductCategory
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Enter) Then
            SaveData()

        ElseIf keyData = Keys.F2 Then
            If SplitContainerControl1.Collapsed = True Then
                SplitContainerControl1.Collapsed = False
            Else
                SplitContainerControl1.Collapsed = True
            End If

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        clearfields()
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(s_type)
        filter()
        Em.ForceInitialize()

        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdUpdate.Enabled = True
        Else
            cmdUpdate.Enabled = False
        End If
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdEdit.Visible = True
        Else
            cmdEdit.Visible = False
        End If
        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdDelete.Visible = True
        Else
            cmdDelete.Visible = False
        End If
        If globalAllowEdit = True Or globalAllowDelete = True Or LCase(globaluser) = "root" Then
            Em.ContextMenuStrip = gridmenustrip
        Else
            Em.ContextMenuStrip = Nothing
        End If
        loadPurchaseType()
        LoadGLItem()
    End Sub

    Public Sub loadPurchaseType()

        LoadXgridLookupEdit("select POTYPEID,DESCRIPTION as 'Request Type' from tblrequesttype", "tblrequesttype", txtRequestType, s_type, Me)
        s_type.Columns("POTYPEID").Visible = False
    End Sub

    Private Sub txtPurchaseType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRequestType.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtRequestType.Properties.View.FocusedRowHandle.ToString)
        potypeid.Text = txtRequestType.Properties.View.GetFocusedRowCellValue("POTYPEID").ToString()
    End Sub

    Public Sub LoadGLItem()
        Dim ctrl() As GridView = {gridRevenue, gridCost, gridAssets, gridADAssets}
        Dim Em() As SearchLookUpEdit = {txtRevenue, txtCost, txtAssets, txtADAssets}

        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a where groupcode in (select groupcode from tblglgrouptag where revenue=1)", "tblglitem", txtRevenue, gridRevenue, Me)
        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a where groupcode in (select groupcode from tblglgrouptag where expenses=1)", "tblglitem", txtCost, gridCost, Me)
        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a where groupcode in (select groupcode from tblglgrouptag where assets=1)", "tblglitem", txtAssets, gridAssets, Me)
        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a where groupcode in (select groupcode from tblglgrouptag where assets=1)", "tblglitem", txtADAssets, gridADAssets, Me)

        For Each ct In ctrl
            XgridHideColumn({"itemcode", "itemname", "debit", "sl"}, ct)
            RemoveHandler ct.RowCellStyle, New RowCellStyleEventHandler(AddressOf GridRowCellStyle)
            AddHandler ct.RowCellStyle, New RowCellStyleEventHandler(AddressOf GridRowCellStyle)
        Next

        'For Each txt In Em
        '    txt.Properties.PopupFormSize = New Size(800, 400)
        '    txt.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        'Next

    End Sub

    Private Sub GridRowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs)
        Dim View As GridView = sender
        Dim sl As Boolean = CBool(View.GetRowCellDisplayText(e.RowHandle, View.Columns("sl")))
        If sl = False Then
            e.Appearance.BackColor = Color.LightYellow
            e.Appearance.ForeColor = Color.Black
            e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold)
        End If
    End Sub

    Private Sub txtRevenue_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRevenue.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtRevenue.Properties.View.FocusedRowHandle.ToString)
        revenuecode.Text = txtRevenue.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub

    Private Sub txtCost_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCost.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCost.Properties.View.FocusedRowHandle.ToString)
        costcode.Text = txtCost.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub

    Private Sub txtAssets_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAssets.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtAssets.Properties.View.FocusedRowHandle.ToString)
        assetscode.Text = txtAssets.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub

    Private Sub txtadAssets_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtADAssets.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtADAssets.Properties.View.FocusedRowHandle.ToString)
        ADassetscode.Text = txtADAssets.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub

    Private Sub txtRevenue_Popup(sender As Object, e As EventArgs) Handles txtRevenue.Popup
        gridRevenue.BestFitColumns()
    End Sub

    Private Sub txtCost_Popup(sender As Object, e As EventArgs) Handles txtCost.Popup
        gridCost.BestFitColumns()
    End Sub

    Private Sub txtAssets_Popup(sender As Object, e As EventArgs) Handles txtAssets.Popup
        gridAssets.BestFitColumns()
    End Sub

    Private Sub txtADAssets_Popup(sender As Object, e As EventArgs) Handles txtADAssets.Popup
        gridADAssets.BestFitColumns()
    End Sub

    Public Sub filter()
        LoadXgrid("Select catid as 'Code', Description,(select count(productid) from tblglobalproducts where catid=tblprocategory.catid and deleted=0) as 'Total Item', CASE WHEN noninventory = 1 THEN 'NON-INVENTORY' WHEN consumable = 1 then 'CONSUMABLE' when ffe = 1 then 'FFE' END as 'Category Type', Prepaid,enablereqfilter as 'Enable Filter',  if(enablereqfilter=1,ifnull((select description from tblrequesttype where potypeid = tblprocategory.potypeid),'Deleted'),'-') as 'Request Filter',(select itemname from tblglitem where itemcode=tblprocategory.glitemrevenue) as 'Revenue Account',(select itemname from tblglitem where itemcode=tblprocategory.glitemcost) as 'Cost of Goods Account',(select itemname from tblglitem where itemcode=tblprocategory.glitemassets) as 'Asset Account',(select itemname from tblglitem where itemcode=tblprocategory.glitemadassets) as 'AD Asset Account' " _
                  + " from tblprocategory order by description asc", "tblprocategory", Em, GridView1, Me)
        'GridView1.Columns("Code").Visible = False
        XgridColAlign({"Code", "Prepaid", "Total Item", "Category Type"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
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

    Public Sub SaveData()
        If txtdesc.Text = "" Then
            XtraMessageBox.Show("Please provide description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesc.Focus()
            Exit Sub
        ElseIf ckpooption.SelectedIndex = -1 Then
            XtraMessageBox.Show("Please select category type!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ckpooption.Focus()
            Exit Sub
        ElseIf countqry("tblprocategory", "description='" & txtdesc.Text & "' and catid<>'" & id.Text & "'") > 0 Then
            XtraMessageBox.Show("Category already exists!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesc.SelectAll()
            txtdesc.Focus()
            Exit Sub
        End If

        If mode.Text <> "edit" Then
            com.CommandText = "insert into tblprocategory set catid='" & id.Text & "', description='" & txtdesc.Text & "',details='" & rchar(txtDetails.Text) & "', " & If(ckpooption.SelectedIndex = 0, "noninventory=1,", "noninventory=0,") & If(ckpooption.SelectedIndex = 1, "consumable=1,", "consumable=0,") & If(ckpooption.SelectedIndex = 2, "ffe=1,", "ffe=0,") & " prepaid=" & ckPrepaid.CheckState & ",enablereqfilter=" & ckRequestFilter.CheckState & ", potypeid='" & If(ckRequestFilter.Checked = True, potypeid.Text, "-") & "', glitemrevenue='" & revenuecode.Text & "', glitemcost='" & costcode.Text & "',glitemassets='" & assetscode.Text & "', glitemadassets='" & ADassetscode.Text & "' " : com.ExecuteNonQuery()
            UpdateImage2("referenceno='" & id.Text & "' and tablename='tblprocategory'", ",referenceno='" & id.Text & "',tablename='tblprocategory'", "imgdata", sqlfiledir & ".tblimagerepository", PictureEdit1, Me)
        Else
            com.CommandText = "update tblprocategory set description='" & txtdesc.Text & "', details='" & rchar(txtDetails.Text) & "', " & If(ckpooption.SelectedIndex = 0, "noninventory=1,", "noninventory=0,") & If(ckpooption.SelectedIndex = 1, "consumable=1,", "consumable=0,") & If(ckpooption.SelectedIndex = 2, "ffe=1,", "ffe=0,") & " prepaid=" & ckPrepaid.CheckState & ",enablereqfilter=" & ckRequestFilter.CheckState & ", potypeid='" & If(ckRequestFilter.Checked = True, potypeid.Text, "-") & "', glitemrevenue='" & revenuecode.Text & "', glitemcost='" & costcode.Text & "',glitemassets='" & assetscode.Text & "', glitemadassets='" & ADassetscode.Text & "' where catid='" & id.Text & "'" : com.ExecuteNonQuery()
            UpdateImage2("referenceno='" & id.Text & "' and tablename='tblprocategory'", ",referenceno='" & id.Text & "',tablename='tblprocategory'", "imgdata", sqlfiledir & ".tblimagerepository", PictureEdit1, Me)
        End If
        clearfields() : filter()
        XtraMessageBox.Show("Category successfully save!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub clearfields()
        id.Text = getprocatid()
        ckpooption.SelectedIndex = -1
        txtdesc.Text = ""
        mode.Text = ""
        ckPrepaid.Checked = False
        ckRequestFilter.Checked = False
        txtRequestType.Properties.DataSource = Nothing
        txtRequestType.Text = ""
        potypeid.Text = ""
        txtRevenue.Text = ""
        revenuecode.Text = ""
        costcode.Text = ""
        txtCost.Text = ""
        assetscode.Text = ""
        txtAssets.Text = ""
        ADassetscode.Text = ""
        txtADAssets.Text = ""
        loadPurchaseType()
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        Dim potype As String = ""
        com.CommandText = "select *,ifnull((select imgdata from " & sqlfiledir & ".tblimagerepository where referenceno=tblprocategory.catid and tablename='tblprocategory'),null) as img, CASE WHEN noninventory = 1 THEN 0 WHEN consumable = 1 then 1 when ffe = 1 then 2 END as InventoryType, (select description from tblrequesttype where potypeid = tblprocategory.potypeid) as 'potype' from tblprocategory where CATID='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            potype = rst("potype").ToString
            potypeid.Text = rst("potypeid").ToString
            txtdesc.Text = rst("description").ToString
            ckpooption.SelectedIndex = rst("InventoryType").ToString
            ckPrepaid.Checked = rst("prepaid")
            ckRequestFilter.Checked = rst("enablereqfilter")
            txtDetails.Text = rst("details").ToString
            ShowImage("img", PictureEdit1, Me)
            revenuecode.Text = rst("glitemrevenue").ToString
            txtRevenue.Text = rst("glitemrevenue").ToString
            costcode.Text = rst("glitemcost").ToString
            txtCost.Text = rst("glitemcost").ToString
            assetscode.Text = rst("glitemassets").ToString
            txtAssets.Text = rst("glitemassets").ToString
            ADassetscode.Text = rst("glitemadassets").ToString
            txtADAssets.Text = rst("glitemadassets").ToString
        End While
        rst.Close()
        txtRequestType.Text = potype
        If mode.Text = "edit" Then
            cmdUpdate.Enabled = True
        Else
            cmdUpdate.Enabled = False
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Code") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        id.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        mode.Text = "edit"
        SplitContainerControl1.Collapsed = False
    End Sub

    Private Sub frmProductCat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        clearfields()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If GridView1.GetFocusedRowCellValue("Code") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf countqry("tblglobalproducts", "catid='" & GridView1.GetFocusedRowCellValue("Code") & "' and deleted=0") > 0 Then
            XtraMessageBox.Show("Category currently in use! Please transfer all product to new category under this product category", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("Code", "CATID", "tblprocategory", GridView1, Me)
        End If
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        SaveData()
    End Sub


    Private Sub ckRequestFilter_CheckedChanged(sender As Object, e As EventArgs) Handles ckRequestFilter.CheckedChanged
        If ckRequestFilter.Checked = True Then
            txtRequestType.Enabled = True
        Else
            txtRequestType.Enabled = False
        End If
    End Sub

    Private Sub ckpooption_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ckpooption.SelectedIndexChanged
        If ckpooption.SelectedIndex = 1 Then
            ckPrepaid.Enabled = True
        Else
            ckPrepaid.Enabled = False
            ckPrepaid.Checked = False
        End If
        If ckpooption.SelectedIndex = 2 Then
            txtADAssets.Enabled = True
        Else
            txtADAssets.Enabled = False
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        PrintGeneralReport(Me.Text, "", GridView1, Me)
    End Sub

    Private Sub cmdShowItem_Click(sender As Object, e As EventArgs) Handles cmdShowItem.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)

        If frmProductManagement.Visible = True Then
            frmProductManagement.Focus()
        Else
            frmProductManagement.Show(Me)
        End If
        frmProductManagement.CheckEdit1.Checked = False
        frmProductManagement.catid.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        frmProductManagement.txtprocat.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub signature_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles PictureEdit1.Validating
        ResizeImage(PictureEdit1, 600)
    End Sub

    Public Sub SetAccounTitle(ByVal revenue As String, ByVal txtrevenue As String, ByVal cost As String, ByVal txtcost As String, ByVal assets As String, ByVal txtassets As String, ByVal txtadassets As String)
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "update tblprocategory set glitemrevenue='" & revenue & "', glitemcost='" & cost & "',glitemassets='" & assets & "',glitemadassets='" & txtadassets & "' where catid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code").ToString & "'" : com.ExecuteNonQuery()
            GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Revenue Account", txtrevenue)
            GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Cost of Goods Account", txtcost)
            GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Asset Account", txtassets)
            GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "AD Asset Account", txtadassets)
        Next
    End Sub

    Private Sub TagGLItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TagGLItemToolStripMenuItem.Click
        If ckpooption.SelectedIndex = 2 Then
            frmProductCategoryAccountTitleTagging.txtADAssets.Enabled = True
        Else
            frmProductCategoryAccountTitleTagging.txtADAssets.Enabled = False
        End If
        frmProductCategoryAccountTitleTagging.Show(Me)
    End Sub
End Class