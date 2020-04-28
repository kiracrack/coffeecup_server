Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCompanies
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        filter()
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdSave.Enabled = True
        Else
            cmdSave.Enabled = False
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
        LoadItem()
        LoadOffice()
    End Sub

    Public Sub LoadOffice()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Office' from tblcompoffice where companyid='" & code.Text & "'  and deleted=0  order by officename asc", "tblcompoffice", txtOffice, gv_Office, Me)
        gv_Office.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOffice.EditValueChanged
        On Error Resume Next
        officeid.Text = txtOffice.Properties.View.GetFocusedRowCellValue("officeid").ToString()
    End Sub

    Public Sub LoadItem()
        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a", "tblglitem", txtDueTo, gridDueto, Me)
        XgridHideColumn({"itemcode", "itemname", "debit", "sl"}, gridDueto)

        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a", "tblglitem", txtDueFrom, gridDueFrom, Me)
        XgridHideColumn({"itemcode", "itemname", "debit", "sl"}, gridDueFrom)
    End Sub
    Private Sub gridDueto_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles gridDueto.RowCellStyle
        Dim View As GridView = sender
        Dim sl As Boolean = CBool(View.GetRowCellDisplayText(e.RowHandle, View.Columns("sl")))
        If sl = False Then
            e.Appearance.BackColor = Color.LightYellow
            e.Appearance.ForeColor = Color.Black
            e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold)
        End If
    End Sub
    Private Sub gridDueFrom_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles gridDueFrom.RowCellStyle
        Dim View As GridView = sender
        Dim sl As Boolean = CBool(View.GetRowCellDisplayText(e.RowHandle, View.Columns("sl")))
        If sl = False Then
            e.Appearance.BackColor = Color.LightYellow
            e.Appearance.ForeColor = Color.Black
            e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold)
        End If
    End Sub
    Private Sub txtDueTo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDueTo.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtDueTo.Properties.View.FocusedRowHandle.ToString)
        duetocode.Text = txtDueTo.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub
    Private Sub txtDueFrom_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDueFrom.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtDueFrom.Properties.View.FocusedRowHandle.ToString)
        duefromcode.Text = txtDueFrom.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        LoadOffice()
        com.CommandText = "select * from tblcompany where code='" & code.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtCompanyname.Text = rst("companyname").ToString
            duetocode.Text = rst("glduetocode").ToString
            txtDueTo.Text = rst("glduetocode").ToString
            duefromcode.Text = rst("glduefromcode").ToString
            txtDueFrom.Text = rst("glduefromcode").ToString
            officeid.Text = rst("reconcilingoffice").ToString
            txtOffice.Text = rst("reconcilingoffice").ToString
        End While
        rst.Close()
        If mode.Text = "edit" Then
            cmdSave.Enabled = True
        Else
            cmdSave.Enabled = False
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Public Sub filter()
        LoadXgrid("Select code as 'Code' ,CompanyName as 'Company Name',(select itemname from tblglitem where itemcode=tblcompany.glduetocode) as 'Due To Account Title',(select itemname from tblglitem where itemcode=tblcompany.glduefromcode) as 'Due From Account Title',(select officename from tblcompoffice where officeid=tblcompany.reconcilingoffice) as 'Reconciling Office' from tblcompany order by code asc", "tblcompany", Em, GridView1, Me)
        GridView1.BestFitColumns()
        XgridColAlign({"Code"}, GridView1, HorzAlignment.Center)
        XgridColWidth({"Code"}, GridView1, 70)
    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If code.Text = "" Then
            XtraMessageBox.Show("Please provide company code!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            code.Focus()
            Exit Sub
        ElseIf txtCompanyname.Text = "" Then
            XtraMessageBox.Show("Please provide company name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCompanyname.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "UPDATE tblcompany set companyname='" & rchar(txtCompanyname.Text) & "',glduetocode='" & duetocode.Text & "',glduefromcode='" & duefromcode.Text & "',reconcilingoffice='" & officeid.Text & "'  where code='" & code.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblcompany set code='" & code.Text & "', companyname='" & rchar(txtCompanyname.Text) & "', glduetocode='" & duetocode.Text & "',glduefromcode='" & duefromcode.Text & "' ,reconcilingoffice='" & officeid.Text & "' " : com.ExecuteNonQuery()
        End If
        txtCompanyname.Text = "" : mode.Text = "" : filter()
        XtraMessageBox.Show("company successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Code").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        code.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        mode.Text = "edit"
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to Continue? there's is no undo function once the code is deleted? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "delete from tblcompany where code='" & GridView1.GetFocusedRowCellValue("Code").ToString & "'" : com.ExecuteNonQuery()
            filter()
            XtraMessageBox.Show("company successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


End Class