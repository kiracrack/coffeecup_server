Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmGLDefaultSettings
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)

        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdSave.Enabled = True
        Else
            cmdSave.Enabled = False
        End If
        
        LoadGLItem()
        loadCurrentSetup()
    End Sub
    Public Sub loadCurrentSetup()
        com.CommandText = "select * from tblgldefaultitem" : rst = com.ExecuteReader
        While rst.Read
            glcodecashiercash.Text = rst("glcodecashiercash").ToString
            txtglcodecashiercash.Text = rst("glcodecashiercash").ToString

            glcodecashiercheck.Text = rst("glcodecashiercheck").ToString
            txtglcodecashiercheck.Text = rst("glcodecashiercheck").ToString

            glcodecashiercomplimentary.Text = rst("glcodecashiercomplimentary").ToString
            txtglcodecashiercomplimentary.Text = rst("glcodecashiercomplimentary").ToString

            glcodecashiervoucher.Text = rst("glcodecashiervoucher").ToString
            txtglcodecashiervoucher.Text = rst("glcodecashiervoucher").ToString

            glcodecashiercustomerdeposit.Text = rst("glcodecashiercustomerdeposit").ToString
            txtglcodecashiercustomerdeposit.Text = rst("glcodecashiercustomerdeposit").ToString

            glcodeguestledger.Text = rst("glcodeguestledger").ToString
            txtglcodeguestledger.Text = rst("glcodeguestledger").ToString

            glcodeaccountspayable.Text = rst("glcodeaccountspayable").ToString
            txtglcodeaccountspayable.Text = rst("glcodeaccountspayable").ToString

            glcodeaccountsshortages.Text = rst("glcodeaccountsshortages").ToString
            txtglcodeaccountsshortages.Text = rst("glcodeaccountsshortages").ToString

            glcodeaccountsoverages.Text = rst("glcodeaccountsoverages").ToString
            txtglcodeaccountsoverages.Text = rst("glcodeaccountsoverages").ToString

            glcodeownersequity.Text = rst("glcodeownersequity").ToString
            txtglcodeownersequity.Text = rst("glcodeownersequity").ToString

            glcodesop.Text = rst("glcodesop").ToString
            txtglcodesop.Text = rst("glcodesop").ToString

            glcodevouchercashadvance.Text = rst("glcodevouchercashadvance").ToString
            txtglcodevouchercashadvance.Text = rst("glcodevouchercashadvance").ToString
        End While
        rst.Close()
    End Sub
    Public Sub LoadGLItem()
        Dim ctrl() As GridView = {gridglcodecashiercash, gridglcodecashiercheck, gridglcodecashiercomplimentary, gridglcodecashiervoucher, gridglcodecashiercustomerdeposit, gridglcodeguestledger, gridglcodeaccountspayable, gridglcodeaccountsshortages, gridglcodeaccountsoverages, gridglcodeownersequity, gridglcodesop, gridglcodevouchercashadvance}
        Dim Em() As SearchLookUpEdit = {txtglcodecashiercash, txtglcodecashiercheck, txtglcodecashiercomplimentary, txtglcodecashiervoucher, txtglcodecashiercustomerdeposit, txtglcodeguestledger, txtglcodeaccountspayable, txtglcodeaccountsshortages, txtglcodeaccountsoverages, txtglcodeownersequity, txtglcodesop, txtglcodevouchercashadvance}

        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a", "tblglitem", txtglcodecashiercash, gridglcodecashiercash, Me)
        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a", "tblglitem", txtglcodecashiercheck, gridglcodecashiercheck, Me)
        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a", "tblglitem", txtglcodecashiercomplimentary, gridglcodecashiercomplimentary, Me)
        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a", "tblglitem", txtglcodecashiervoucher, gridglcodecashiervoucher, Me)
        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a", "tblglitem", txtglcodecashiercustomerdeposit, gridglcodecashiercustomerdeposit, Me)
        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a", "tblglitem", txtglcodeguestledger, gridglcodeguestledger, Me)
        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a", "tblglitem", txtglcodeaccountspayable, gridglcodeaccountspayable, Me)
        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a", "tblglitem", txtglcodeaccountsshortages, gridglcodeaccountsshortages, Me)
        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a", "tblglitem", txtglcodeaccountsoverages, gridglcodeaccountsoverages, Me)
        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a", "tblglitem", txtglcodeownersequity, gridglcodeownersequity, Me)
        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a", "tblglitem", txtglcodesop, gridglcodesop, Me)
        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a", "tblglitem", txtglcodevouchercashadvance, gridglcodevouchercashadvance, Me)

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

    Private Sub GridRowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        Dim View As GridView = sender
        Dim sl As Boolean = CBool(View.GetRowCellDisplayText(e.RowHandle, View.Columns("sl")))
        If sl = False Then
            e.Appearance.BackColor = Color.LightYellow
            e.Appearance.ForeColor = Color.Black
            e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold)
        End If
    End Sub

    Private Sub txtglcodecashiercash_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtglcodecashiercash.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtglcodecashiercash.Properties.View.FocusedRowHandle.ToString)
        glcodecashiercash.Text = txtglcodecashiercash.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub

    Private Sub txtglcodecashiercheck_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtglcodecashiercheck.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtglcodecashiercheck.Properties.View.FocusedRowHandle.ToString)
        glcodecashiercheck.Text = txtglcodecashiercheck.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub

    Private Sub txtglcodecashiercomplimentary_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtglcodecashiercomplimentary.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtglcodecashiercomplimentary.Properties.View.FocusedRowHandle.ToString)
        glcodecashiercomplimentary.Text = txtglcodecashiercomplimentary.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub

    Private Sub txtglcodecashiervoucher_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtglcodecashiervoucher.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtglcodecashiervoucher.Properties.View.FocusedRowHandle.ToString)
        glcodecashiervoucher.Text = txtglcodecashiervoucher.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub

    Private Sub txtglcodecashiercustomerdeposit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtglcodecashiercustomerdeposit.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtglcodecashiercustomerdeposit.Properties.View.FocusedRowHandle.ToString)
        glcodecashiercustomerdeposit.Text = txtglcodecashiercustomerdeposit.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub

    Private Sub txtglcodeguestledger_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtglcodeguestledger.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtglcodeguestledger.Properties.View.FocusedRowHandle.ToString)
        glcodeguestledger.Text = txtglcodeguestledger.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub
    Private Sub txtglcodeaccountspayable_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtglcodeaccountspayable.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtglcodeaccountspayable.Properties.View.FocusedRowHandle.ToString)
        glcodeaccountspayable.Text = txtglcodeaccountspayable.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub
    Private Sub txtglcodeaccountsshortages_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtglcodeaccountsshortages.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtglcodeaccountsshortages.Properties.View.FocusedRowHandle.ToString)
        glcodeaccountsshortages.Text = txtglcodeaccountsshortages.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub
    Private Sub txtglcodeaccountsoverages_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtglcodeaccountsoverages.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtglcodeaccountsoverages.Properties.View.FocusedRowHandle.ToString)
        glcodeaccountsoverages.Text = txtglcodeaccountsoverages.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub
    Private Sub txtglcodeownersequity_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtglcodeownersequity.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtglcodeownersequity.Properties.View.FocusedRowHandle.ToString)
        glcodeownersequity.Text = txtglcodeownersequity.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub

    Private Sub txtglcodesop_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtglcodesop.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtglcodesop.Properties.View.FocusedRowHandle.ToString)
        glcodesop.Text = txtglcodesop.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub

    Private Sub txtglcodevouchercashadvance_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtglcodevouchercashadvance.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtglcodevouchercashadvance.Properties.View.FocusedRowHandle.ToString)
        glcodevouchercashadvance.Text = txtglcodevouchercashadvance.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If countrecord("tblgldefaultitem") = 0 Then
            com.CommandText = "insert into tblgldefaultitem set glcodecashiercash='" & glcodecashiercash.Text & "', glcodecashiercheck='" & glcodecashiercheck.Text & "', glcodecashiercomplimentary='" & glcodecashiercomplimentary.Text & "', glcodecashiervoucher='" & glcodecashiervoucher.Text & "',glcodecashiercustomerdeposit='" & glcodecashiercustomerdeposit.Text & "', glcodeguestledger='" & glcodeguestledger.Text & "', glcodeaccountspayable='" & glcodeaccountspayable.Text & "', glcodeaccountsshortages='" & glcodeaccountsshortages.Text & "', glcodeaccountsoverages='" & glcodeaccountsoverages.Text & "',glcodeownersequity='" & glcodeownersequity.Text & "',glcodesop='" & glcodesop.Text & "',glcodevouchercashadvance='" & glcodevouchercashadvance.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "UPDATE tblgldefaultitem set glcodecashiercash='" & glcodecashiercash.Text & "', glcodecashiercheck='" & glcodecashiercheck.Text & "', glcodecashiercomplimentary='" & glcodecashiercomplimentary.Text & "', glcodecashiervoucher='" & glcodecashiervoucher.Text & "',glcodecashiercustomerdeposit='" & glcodecashiercustomerdeposit.Text & "', glcodeguestledger='" & glcodeguestledger.Text & "', glcodeaccountspayable='" & glcodeaccountspayable.Text & "', glcodeaccountsshortages='" & glcodeaccountsshortages.Text & "', glcodeaccountsoverages='" & glcodeaccountsoverages.Text & "',glcodeownersequity='" & glcodeownersequity.Text & "', glcodesop='" & glcodesop.Text & "',glcodevouchercashadvance='" & glcodevouchercashadvance.Text & "'" : com.ExecuteNonQuery()
        End If
        XtraMessageBox.Show("Default settings successfully updated!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class