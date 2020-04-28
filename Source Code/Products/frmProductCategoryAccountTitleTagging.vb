Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmProductCategoryAccountTitleTagging
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmProductCategoryAccountTitleTagging_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadGLItem()
    End Sub
    Public Sub LoadGLItem()
        Dim ctrl() As GridView = {gridRevenue, gridCost, gridAssets, gridADAssets}
        Dim Em() As SearchLookUpEdit = {txtRevenue, txtCost, txtAssets, txtADAssets}

        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a", "tblglitem", txtRevenue, gridRevenue, Me)
        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a", "tblglitem", txtCost, gridCost, Me)
        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a", "tblglitem", txtAssets, gridAssets, Me)
        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a", "tblglitem", txtADAssets, gridADAssets, Me)

        For Each ct In ctrl
            XgridHideColumn({"itemcode", "itemname", "debit", "sl"}, ct)
            RemoveHandler ct.RowCellStyle, New RowCellStyleEventHandler(AddressOf GridRowCellStyle)
            AddHandler ct.RowCellStyle, New RowCellStyleEventHandler(AddressOf GridRowCellStyle)
        Next
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


    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click
        frmProductCategory.SetAccounTitle(revenuecode.Text, txtRevenue.Text, costcode.Text, txtCost.Text, assetscode.Text, txtAssets.Text, txtADAssets.Text)
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Close()
    End Sub


End Class
