Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports System.IO

Public Class frmTVCategoryItems
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmClientGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadCategory()
    End Sub

    Public Sub LoadCategory()
        LoadXgridLookupSearch("select Code, description as Category from tbltvcategory where link=0 order by itemorder asc", "tbltvcategory", txtCompany, gvCompany, Me)
        XgridColAlign({"Code", "FileName"}, gvCompany, DevExpress.Utils.HorzAlignment.Center)
        gvCompany.Columns("Code").Width = 70
    End Sub

    Private Sub txtCompany_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompany.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCompany.Properties.View.FocusedRowHandle.ToString)
        catcode.Text = txtCompany.Properties.View.GetFocusedRowCellValue("Code").ToString()
        LoadData()
        LoadItemOrder()
    End Sub

    Public Sub LoadItemOrder()
        txtItemOrder.Text = CInt(qrysingledata("itemorder", "itemorder", "tbltvcategoryitem where catcode='" & catcode.Text & "' order by itemorder desc limit 1")) + 1
    End Sub
    Public Sub LoadData()
        LoadXgrid("select id,ItemOrder, Description,FileName,AllowInquiry from tbltvcategoryitem where catcode='" & catcode.Text & "' order by itemorder asc", "tbltvcategoryitem", Em, GridView1, Me)
        XgridHideColumn({"id"}, GridView1)
        GridView1.Columns("ItemOrder").Width = 80
        XgridColAlign({"id", "ItemOrder", "FileName"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        ' GridView1.SelectRow(1)
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If txtDescription.Text = "" Then
            XtraMessageBox.Show("Please Enter image name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub
        ElseIf countqry("tbltvcategoryitem", "description='" & rchar(txtDescription.Text) & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("image name already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            id.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tbltvcategoryitem set catcode='" & catcode.Text & "', itemorder='" & txtItemOrder.Text & "', description='" & rchar(txtDescription.Text) & "', filename='" & txtFileName.Text & "',allowinquiry=" & ckAllowInquiry.CheckState & " where id='" & id.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tbltvcategoryitem set catcode='" & catcode.Text & "', itemorder='" & txtItemOrder.Text & "', description='" & rchar(txtDescription.Text) & "', filename='" & txtFileName.Text & "',allowinquiry=" & ckAllowInquiry.CheckState & "" : com.ExecuteNonQuery()
            End If
            mode.Text = ""
            id.Text = ""
            txtDescription.Text = "" : txtFileName.Text = "" : txtDescription.Focus() : LoadItemOrder() : LoadData()
            XtraMessageBox.Show("image successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("id").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        id.Text = GridView1.GetFocusedRowCellValue("id").ToString
        com.CommandText = "select * from tbltvcategoryitem where id='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtItemOrder.Text = rst("itemorder").ToString
            txtDescription.Text = rst("description").ToString
            txtFileName.Text = rst("filename").ToString
            ckAllowInquiry.Checked = rst("allowinquiry")
        End While
        rst.Close()
        mode.Text = "edit"
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If CheckSelectedRow("id", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to delete selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                For I = 0 To GridView1.SelectedRowsCount - 1
                    com.CommandText = "delete from tbltvcategoryitem where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
                Next
                LoadData()
                XtraMessageBox.Show("image successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub

    Private Sub HyperlinkLabelControl1_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl1.Click
        frmTVCategory.ShowDialog(Me)
        LoadData()
    End Sub
End Class