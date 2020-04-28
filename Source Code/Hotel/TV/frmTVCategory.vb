Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmTVCategory
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmClientGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadData()
        LoadItemOrder()
    End Sub

    Public Sub LoadItemOrder()
        txtItemOrder.Text = CInt(qrysingledata("itemorder", "itemorder", "tbltvcategory order by itemorder desc limit 1")) + 1
    End Sub
    Public Sub LoadData()
        LoadXgrid("select Code,ItemOrder, Description, Link, LinkFile,DefaultPage from tbltvcategory", "tbltvcategory", Em, GridView1, Me)
        GridView1.Columns("Code").Width = 80
        GridView1.Columns("ItemOrder").Width = 80
        XgridColAlign({"Code", "ItemOrder"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        ' GridView1.SelectRow(1)
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If txtDescription.Text = "" Then
            XtraMessageBox.Show("Please Enter category name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub
        ElseIf countqry("tbltvcategory", "description='" & rchar(txtDescription.Text) & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("category name already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            code.Focus()
            Exit Sub
        ElseIf countqry("tbltvcategory", "defaultpage=1 and code<>'" & code.Text & "'") > 0 And ckDefault.Checked = True Then
            XtraMessageBox.Show("Default page already set!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            code.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tbltvcategory set itemorder='" & txtItemOrder.Text & "',description='" & rchar(txtDescription.Text) & "', link=" & ckExternalLinks.CheckState & ",linkfile='" & txtlinkFile.Text & "',defaultpage=" & ckDefault.CheckState & ",opacity='" & txtOpacity.Text & "' where code='" & code.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tbltvcategory set itemorder='" & txtItemOrder.Text & "',description='" & rchar(txtDescription.Text) & "', link=" & ckExternalLinks.CheckState & ",linkfile='" & txtlinkFile.Text & "',defaultpage=" & ckDefault.CheckState & ",opacity='" & txtOpacity.Text & "' " : com.ExecuteNonQuery()
            End If

            LoadData()
            mode.Text = ""
            code.Text = ""
            txtDescription.Text = "" : txtlinkFile.Text = "" : ckExternalLinks.Checked = False : txtDescription.Focus() : LoadItemOrder()
            XtraMessageBox.Show("category successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Code").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        code.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        com.CommandText = "select * from tbltvcategory where code='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtItemOrder.Text = rst("itemorder").ToString
            txtDescription.Text = rst("description").ToString
            ckExternalLinks.Checked = rst("link")
            txtlinkFile.Text = rst("linkfile").ToString
            ckDefault.Checked = rst("defaultpage")
            txtOpacity.Text = rst("opacity").ToString
        End While
        rst.Close()
        mode.Text = "edit"
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If CheckSelectedRow("Code", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to delete selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                For I = 0 To GridView1.SelectedRowsCount - 1
                    com.CommandText = "delete from tbltvcategory where code='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code").ToString & "'" : com.ExecuteNonQuery()
                Next
                LoadData()
                XtraMessageBox.Show("category successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub
     
    Private Sub ckExternalLinks_CheckedChanged(sender As Object, e As EventArgs) Handles ckExternalLinks.CheckedChanged
        If ckExternalLinks.Checked = True Then
            txtlinkFile.Enabled = True
        Else
            txtlinkFile.Enabled = False
            txtlinkFile.Text = ""
        End If
    End Sub
End Class