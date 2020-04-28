﻿Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmHotelRoomDiscount
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmClientGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadData()
        LoadGridviewAppearance(GridView1)
        If mode.Text <> "edit" Then
            code.Text = getcodeid("discode", "tblhotelroomsdiscount", "100")
        End If
    End Sub

    Public Sub LoadData()
        LoadXgrid("select discode as 'Code', Description, discountrate as 'Discount rate' from tblhotelroomsdiscount", "tblhotelroomsdiscount", Em, GridView1, Me)

        GridView1.Columns("Code").Width = 80
        XgridColAlign({"Code", "Discount rate"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        ' GridView1.SelectRow(1)
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If code.Text = "" Then
            XtraMessageBox.Show("Please Enter Discount Code!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            code.Focus()
            Exit Sub
        ElseIf txtDescription.Text = "" Then
            XtraMessageBox.Show("Please Enter Description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub
        ElseIf Val(CC(txtdiscountrate.Text)) <= 0 Then
            XtraMessageBox.Show("Please Enter Discount Rate!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtdiscountrate.Focus()
            Exit Sub
        ElseIf countqry("tblhotelroomsdiscount", "discode='" & code.Text & "' ") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Discount Code already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            code.Focus()
            Exit Sub
        ElseIf countqry("tblhotelroomsdiscount", "Description='" & rchar(txtDescription.Text) & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Description already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tblhotelroomsdiscount set Description='" & rchar(UCase(txtDescription.Text)) & "',  discountrate='" & Val(CC(txtdiscountrate.Text)) & "' where discode='" & code.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblhotelroomsdiscount set discode='" & code.Text & "', Description='" & rchar(UCase(txtDescription.Text)) & "',   discountrate='" & Val(CC(txtdiscountrate.Text)) & "'" : com.ExecuteNonQuery()
            End If

            LoadData()
            mode.Text = ""
            code.Text = getcodeid("discode", "tblhotelroomsdiscount", "100")
            XtraMessageBox.Show("Discount successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Code").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        code.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        com.CommandText = "select * from tblhotelroomsdiscount where discode='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("Description").ToString
            txtdiscountrate.Text = rst("discountrate").ToString
        End While
        rst.Close()
        mode.Text = "edit"

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If CheckSelectedRow("Code", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to delete selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                For I = 0 To GridView1.SelectedRowsCount - 1
                    com.CommandText = "delete from tblhotelroomsdiscount where discode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code").ToString & "'" : com.ExecuteNonQuery()
                Next
                LoadData() : code.Text = getcodeid("discode", "tblhotelroomsdiscount", "100")
                XtraMessageBox.Show("Vip successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub


    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub
 
End Class