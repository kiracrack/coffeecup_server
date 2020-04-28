Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmHotelGuestRatings
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmHotelRoomType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadData()
        LoadGridviewAppearance(GridView1)
    End Sub

    Public Sub LoadData()
        LoadXgrid("select Code, ratingsname as 'Ratings', Description, yearlyvalidity as 'Yearly', monthvalidity as 'Validity', colorback as 'Back Color', colorfont as 'Font Color' from tblhotelguestratings", "tblhotelguestratings", Em, GridView1, Me)

        GridView1.Columns("Code").Width = 80
        XgridColWidth({"Back Color", "Font Color"}, GridView1, 70)
        XgridColAlign({"Code", "Back Color", "Font Color", "Validity"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Sub
    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If e.Column.Name = "colBackColor" Then
            Dim colorRgb As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Back Color"))
            e.Appearance.BackColor = RGBColorConverter(colorRgb)
            e.Appearance.BackColor2 = RGBColorConverter(colorRgb)
            e.Appearance.ForeColor = RGBColorConverter(colorRgb)
        ElseIf e.Column.Name = "colFontColor" Then
            Dim colorRgb As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Font Color"))
            e.Appearance.BackColor = RGBColorConverter(colorRgb)
            e.Appearance.BackColor2 = RGBColorConverter(colorRgb)
            e.Appearance.ForeColor = RGBColorConverter(colorRgb)
        End If
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If txtRatingsName.Text = "" Then
            XtraMessageBox.Show("Please Enter ratings name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRatingsName.Focus()
            Exit Sub
        ElseIf txtDescription.Text = "" Then
            XtraMessageBox.Show("Please Enter Description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub
      
        ElseIf countqry("tblhotelguestratings", "ratingsname='" & rchar(txtDescription.Text) & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Ratings name already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub

        ElseIf txtValidity.Text = "" And ckYearly.Checked = False Then
            XtraMessageBox.Show("Please Enter validity!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtValidity.Focus()
            Exit Sub

        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tblhotelguestratings set ratingsname='" & rchar(UCase(txtRatingsName.Text)) & "', description='" & rchar(txtDescription.Text) & "',yearlyvalidity=" & ckYearly.CheckState & ", monthvalidity='" & txtValidity.Text & "', colorback='" & txtBgColor.Text & "',colorfont='" & txtFontColor.Text & "' where code='" & id.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblhotelguestratings set ratingsname='" & rchar(UCase(txtRatingsName.Text)) & "', description='" & rchar(txtDescription.Text) & "',yearlyvalidity=" & ckYearly.CheckState & ",monthvalidity='" & txtValidity.Text & "', colorback='" & txtBgColor.Text & "',colorfont='" & txtFontColor.Text & "'" : com.ExecuteNonQuery()
            End If
            LoadData()
            mode.Text = "" : id.Text = "" : txtRatingsName.Text = "" : txtDescription.Text = "" : txtBgColor.Text = "" : txtFontColor.Text = "" : txtBgColor.BackColor = DefaultBackColor : txtBgColor.ForeColor = DefaultForeColor : txtFontColor.BackColor = DefaultBackColor : txtFontColor.ForeColor = DefaultForeColor
            XtraMessageBox.Show("Ratingssuccessfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Code").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        id.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        com.CommandText = "select * from tblhotelguestratings where code='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtRatingsName.Text = rst("ratingsname").ToString
            txtDescription.Text = rst("Description").ToString
            txtValidity.Text = rst("monthvalidity").ToString
            ckYearly.Checked = rst("yearlyvalidity")

            txtBgColor.Text = rst("colorback").ToString
            ChangeColor(txtBgColor, rst("colorback").ToString)

            txtFontColor.Text = rst("colorfont").ToString
            ChangeColor(txtFontColor, rst("colorfont").ToString)

        End While
        rst.Close()
        mode.Text = "edit"

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If CheckSelectedRow("Code", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to delete selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                For I = 0 To GridView1.SelectedRowsCount - 1
                    com.CommandText = "delete from tblhotelguestratings where code='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code").ToString & "'" : com.ExecuteNonQuery()
                Next
                LoadData()
                XtraMessageBox.Show("Item successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub


    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub
 

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            txtBgColor.Text = ColorDialog1.Color.R.ToString & "," & ColorDialog1.Color.G.ToString & "," & ColorDialog1.Color.B.ToString
            ChangeColor(txtBgColor, txtBgColor.Text)
        End If
    End Sub


    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            txtFontColor.Text = ColorDialog1.Color.R.ToString & "," & ColorDialog1.Color.G.ToString & "," & ColorDialog1.Color.B.ToString
            ChangeColor(txtFontColor, txtFontColor.Text)
        End If
    End Sub

    Public Sub ChangeColor(ByVal txt As TextEdit, ByVal RGBString As String)
        Dim RGB As String() = RGBString.Split(",")
        If RGBString.Length > 0 Then
            txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(Val(RGB(0)), Byte), Integer), CType(CType(Val(RGB(1)), Byte), Integer), CType(CType(Val(RGB(2)), Byte), Integer))
            txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(Val(RGB(0)), Byte), Integer), CType(CType(Val(RGB(1)), Byte), Integer), CType(CType(Val(RGB(2)), Byte), Integer))
        Else
            txt.BackColor = DefaultBackColor : txt.ForeColor = DefaultForeColor
        End If

    End Sub

    Public Function RGBColorConverter(ByVal RGBString As String) As Color
        Dim RGB As String() = RGBString.Split(",")
        If RGBString.Length > 0 Then
            RGBColorConverter = System.Drawing.Color.FromArgb(CType(CType(Val(RGB(0)), Byte), Integer), CType(CType(Val(RGB(1)), Byte), Integer), CType(CType(Val(RGB(2)), Byte), Integer))
        Else
            RGBColorConverter = Color.Black
        End If

    End Function

    Private Sub ckYearly_CheckedChanged(sender As Object, e As EventArgs) Handles ckYearly.CheckedChanged
        If ckYearly.Checked = True Then
            txtValidity.Enabled = False
            txtValidity.Text = "0"
        Else
            txtValidity.Enabled = True
            txtValidity.Text = "0"
        End If
    End Sub
End Class