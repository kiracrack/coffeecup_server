Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmHotelPackageItem
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmHotelRoomRateBreakDown_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadItem()
        LoadData()
        LoadCode()

    End Sub

    Public Sub LoadItem()
        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a", "tblglitem", txtItem, gridItem, Me)
        XgridHideColumn({"itemcode", "itemname", "debit", "sl"}, gridItem)
    End Sub
    Private Sub gridItem_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles gridItem.RowCellStyle
        Dim View As GridView = sender
        Dim sl As Boolean = CBool(View.GetRowCellDisplayText(e.RowHandle, View.Columns("sl")))
        If sl = False Then
            e.Appearance.BackColor = Color.LightYellow
            e.Appearance.ForeColor = Color.Black
            e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold)
        End If
    End Sub
    Private Sub txtItem_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItem.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtItem.Properties.View.FocusedRowHandle.ToString)
        ItemCode.Text = txtItem.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub

    Public Sub LoadCode()
        If mode.Text <> "edit" Then
            code.Text = getcodeid("itemcode", "tblhotelpackageitem", "100")
        End If
    End Sub


    Public Sub ShowBreakdownInfo()
        com.CommandText = "select * from tblhotelpackageitem where itemcode='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("description").ToString
            ItemCode.Text = rst("glitemtag").ToString
            txtItem.Text = rst("glitemtag").ToString
        End While
        rst.Close()
    End Sub

    Public Sub LoadData()
        LoadXgrid("select itemcode as Code, Description, (select itemname from tblglitem where itemcode=tblhotelpackageitem.glitemtag) as 'Account Title'  from tblhotelpackageitem", "tblhotelpackageitem", Em, GridView1, Me)
        XgridColAlign({"Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Private Sub cmdcomsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If txtDescription.Text = "" Then
                MessageBox.Show("Please item name", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtDescription.Focus()
                Exit Sub
                'ElseIf txtItem.Text = "" Then
                '    MessageBox.Show("Please select account title", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    txtItem.Focus()
                '    Exit Sub
            End If
            If XtraMessageBox.Show("Are you sure you want to Continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If mode.Text = "edit" Then
                    com.CommandText = "UPDATE tblhotelpackageitem set Description='" & rchar(txtDescription.Text) & "', glitemtag='" & ItemCode.Text & "' where itemcode='" & code.Text & "'" : com.ExecuteNonQuery()
                Else
                    com.CommandText = "INSERT INTO tblhotelpackageitem set itemcode='" & code.Text & "', Description='" & rchar(txtDescription.Text) & "', glitemtag='" & ItemCode.Text & "' " : com.ExecuteNonQuery()
                End If
                mode.Text = "" : txtDescription.Text = "" : code.Text = "" : LoadCode() : LoadData() : txtDescription.Focus()
            End If
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to removed selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "delete from tblhotelpackageitem where itemcode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code").ToString & "'" : com.ExecuteNonQuery()
            Next
            LoadData()
            XtraMessageBox.Show("Item successfully removed", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        code.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        mode.Text = "edit"
        ShowBreakdownInfo()
    End Sub
 
    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub
End Class