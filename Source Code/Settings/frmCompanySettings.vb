Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.Office.Crypto


Public Class frmCompanySettings
#Region "COMPANY SETTINGS"

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmCompanySettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadCompany()
        companyid.Text = GlobalCompanyID
        txtCompany.Text = GlobalCompanyID
        If LCase(globaluser) = "root" Then
            cmdResetDatabase.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            cmdResetDatabase.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            cmdSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If EnableModuleSales = True Then
            tabIdentity.PageVisible = True
        Else
            tabIdentity.PageVisible = False
        End If
    End Sub

    Public Sub LoadCompany()
        LoadXgridLookupSearch("select Code, Companyname as Company from tblcompany", "tblcompany", txtCompany, gvCompany, Me)
        XgridColAlign({"Code"}, gvCompany, DevExpress.Utils.HorzAlignment.Center)
        gvCompany.Columns("Code").Width = 70
    End Sub

    Private Sub txtCompany_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompany.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCompany.Properties.View.FocusedRowHandle.ToString)
        companyid.Text = txtCompany.Properties.View.GetFocusedRowCellValue("Code").ToString()
        ShowCompanyInfo()
    End Sub

    Public Sub ShowCompanyInfo()
        Try
            'ClearFields()
            Dim imgBytes As Byte() = Nothing
            Dim stream As MemoryStream = Nothing
            Dim img As Image = Nothing

            Dim imgBytes2 As Byte() = Nothing
            Dim stream2 As MemoryStream = Nothing
            Dim img2 As Image = Nothing

            dst = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("select * from tblcompanysettings where companycode='" & companyid.Text & "'", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    companyid.Text = .Rows(cnt)("companycode").ToString()
                    txtinitialcode.Text = .Rows(cnt)("initialcode").ToString()
                    txtcomp.Text = .Rows(cnt)("companyname").ToString()
                    txtadd.Text = .Rows(cnt)("compadd").ToString()
                    txttell.Text = .Rows(cnt)("telephone").ToString()
                    txtemail.Text = .Rows(cnt)("email").ToString()
                    txtweb.Text = .Rows(cnt)("website").ToString()
                    txtofficer.Text = .Rows(cnt)("chiefoff").ToString()
                    txtOfficerDesignation.Text = .Rows(cnt)("designation").ToString()

                    txtLogoWidth.Text = .Rows(cnt)("logowidth")
                    If .Rows(cnt)("logo").ToString() <> "" Then
                        imgBytes = CType(.Rows(cnt)("logo"), Byte())
                        stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                        img = Image.FromStream(stream)
                        piclogo.Image = img
                    End If

                    If .Rows(cnt)("digitalsign").ToString() <> "" Then
                        imgBytes2 = CType(.Rows(cnt)("digitalsign"), Byte())
                        stream2 = New MemoryStream(imgBytes2, 0, imgBytes2.Length)
                        offsignature.Image = Image.FromStream(stream2)
                    End If

                    txtTinNumber.Text = .Rows(cnt)("tinnumber").ToString()
                    txtPermitNumber.Text = .Rows(cnt)("permitnumber").ToString
                    txtMiNumber.Text = .Rows(cnt)("minumber").ToString
                    txtSerialNumber.Text = .Rows(cnt)("snumber").ToString

                    txtVat.Text = .Rows(cnt)("vatpercentage").ToString
                    ckVatAddtoTotal.Checked = CBool(.Rows(cnt)("addvattotal").ToString())

                    txtServiceCharge.Text = .Rows(cnt)("svchargepercentage").ToString
                    ckSVAddtoTotal.Checked = .Rows(cnt)("addsvtotal")

                    txtReceiptType.Text = .Rows(cnt)("posreceipttype").ToString
                    txtLogoUrl.Text = .Rows(cnt)("logourl").ToString

                End With
            Next
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ClearFields()
        piclogo.Image = Nothing
        offsignature.Image = Nothing
        txtinitialcode.Text = ""
        txtcomp.Text = ""
        txtadd.Text = ""
        txttell.Text = ""
        txtemail.Text = ""
        txtweb.Text = ""
        txtofficer.Text = ""
        txtOfficerDesignation.Text = ""
        txtTinNumber.Text = ""
        txtPermitNumber.Text = ""
        txtMiNumber.Text = ""
        txtSerialNumber.Text = ""
        txtVat.Text = ""
        ckVatAddtoTotal.Checked = False
        txtServiceCharge.Text = ""
        ckSVAddtoTotal.Checked = False
        txtReceiptType.Text = ""
        txtLogoUrl.Text = ""
        txtLogoWidth.Text = "200"
    End Sub

    Private Sub offsignature_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles offsignature.Validating
        If offsignature.Image Is Nothing Then Exit Sub
        Dim Original As New Bitmap(offsignature.Image)
        offsignature.Image = Original

        Dim m As Int32 = 200
        Dim n As Int32 = m * Original.Height / Original.Width

        Dim Thumb As New Bitmap(m, n, Original.PixelFormat)
        Thumb.SetResolution(Original.HorizontalResolution, Original.VerticalResolution)

        Dim g As Graphics = Graphics.FromImage(Thumb)
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High

        g.DrawImage(Original, New Rectangle(0, 0, m, n))
        offsignature.Image = Thumb
    End Sub
    Private Sub piclogo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles piclogo.Validating
        ResizeImage(piclogo, Val(txtLogoWidth.Text), Me)
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

#End Region

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        If txtLogoWidth.Text = "" Then
            XtraMessageBox.Show("Please enter logo width!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLogoWidth.Focus()
            Exit Sub
        End If

        ResizeImage(piclogo, Val(txtLogoWidth.Text), Me)
        Try
            If countqry("tblcompanysettings", "companycode='" & companyid.Text & "'") = 0 Then
                com.CommandText = "insert into tblcompanysettings set companycode='" & companyid.Text & "', initialcode='" & txtinitialcode.Text & "', companyname='" & txtcomp.Text & "', compadd='" & txtadd.Text & "', telephone='" & txttell.Text & "', email='" & txtemail.Text & "', website='" & txtweb.Text & "',logowidth='" & Val(txtLogoWidth.Text) & "',logourl='" & txtLogoUrl.Text & "', chiefoff='" & StrConv(txtofficer.Text, vbProperCase) & "', designation='" & StrConv(txtOfficerDesignation.Text, vbProperCase) & "',tinnumber='" & txtTinNumber.Text & "', permitnumber='" & txtPermitNumber.Text & "', minumber='" & txtMiNumber.Text & "', snumber='" & txtSerialNumber.Text & "',vatpercentage='" & txtVat.Text & "', addvattotal=" & ckVatAddtoTotal.CheckState & ", svchargepercentage='" & txtServiceCharge.Text & "',addsvtotal=" & ckSVAddtoTotal.CheckState & ", posreceipttype='" & rchar(txtReceiptType.Text) & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "update tblcompanysettings set initialcode='" & txtinitialcode.Text & "', companyname='" & txtcomp.Text & "', compadd='" & txtadd.Text & "', telephone='" & txttell.Text & "', email='" & txtemail.Text & "', website='" & txtweb.Text & "',logowidth='" & Val(txtLogoWidth.Text) & "',logourl='" & txtLogoUrl.Text & "', chiefoff='" & StrConv(txtofficer.Text, vbProperCase) & "', designation='" & StrConv(txtOfficerDesignation.Text, vbProperCase) & "',tinnumber='" & txtTinNumber.Text & "', permitnumber='" & txtPermitNumber.Text & "', minumber='" & txtMiNumber.Text & "', snumber='" & txtSerialNumber.Text & "',vatpercentage='" & txtVat.Text & "', addvattotal=" & ckVatAddtoTotal.CheckState & ", svchargepercentage='" & txtServiceCharge.Text & "',addsvtotal=" & ckSVAddtoTotal.CheckState & ", posreceipttype='" & rchar(txtReceiptType.Text) & "' where companycode='" & companyid.Text & "'" : com.ExecuteNonQuery()
            End If

            UpdateImage("companycode='" & companyid.Text & "' and companycode='" & companyid.Text & "'", "logo", "tblcompanysettings", piclogo, Me)
            UpdateImage("companycode='" & companyid.Text & "' and companycode='" & companyid.Text & "'", "digitalsign", "tblcompanysettings", offsignature, Me)


            If System.IO.File.Exists(Application.StartupPath.ToString & "\img\" & companyid.Text & ".png") = True Then
                System.IO.File.Delete(Application.StartupPath.ToString & "\img\" & companyid.Text & ".png")
            End If
            If Not piclogo.Image Is Nothing Then
                piclogo.Image.Save(Application.StartupPath.ToString & "\img\" & companyid.Text & ".png", System.Drawing.Imaging.ImageFormat.Png)
            End If

            XtraMessageBox.Show("Setting Successfully Updated", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            loadcompsettings()

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        cmdSave.PerformClick()
    End Sub

    Private Sub BarButtonItem2_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdResetDatabase.ItemClick
        frmResetDatabase.ShowDialog(Me)
    End Sub


    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        frmCompanies.ShowDialog(Me)
        LoadCompany()
    End Sub
End Class