Imports System.Drawing.Printing
Imports System.IO

Module Company
    Public compinitialcode As String
    Public compname As String
    Public compadd As String
    Public compnumber As String
    Public compemail As String
    Public compwebsite As String
    Public complogo As Image = Nothing
    Public CompAproveName As String
    Public compApproveDesig As String
    Public compkb As String
    Public comInventoryName As String
    Public complogimg As Image = Nothing
    Public compapproversign As Image = Nothing
    Public complogwidth
    Public complogheight
    Public GlobalOrganizationLogoURL As String

    Public Sub loadcompsettings()
        complogo = Nothing
        compapproversign = Nothing
        Dim imgBytes As Byte() = Nothing
        Dim stream As MemoryStream = Nothing
        Dim img As Image = Nothing

        Dim imgBytes2 As Byte() = Nothing
        Dim stream2 As MemoryStream = Nothing
        Dim img2 As Image = Nothing

        com.CommandText = "select * from tblcompanysettings where defaultcompany=1 "
        rst = com.ExecuteReader
        While rst.Read
            GlobalCompanyID = rst("companycode").ToString
            compinitialcode = rst("initialcode").ToString
            compname = rst("companyname").ToString
            compadd = rst("compadd").ToString
            compnumber = rst("telephone").ToString
            compemail = rst("email").ToString
            compwebsite = rst("website").ToString
            CompAproveName = rst("chiefoff").ToString
            compApproveDesig = rst("designation").ToString
            GlobalOrganizationLogoURL = rst("logourl").ToString
            compkb = rst("kb").ToString
            If rst("logo").ToString <> "" Then
                imgBytes = CType(rst("logo"), Byte())
                stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                img = Image.FromStream(stream)
                complogo = img
            End If

            If rst("digitalsign").ToString <> "" Then
                imgBytes2 = CType(rst("digitalsign"), Byte())
                stream2 = New MemoryStream(imgBytes2, 0, imgBytes2.Length)
                compapproversign = Image.FromStream(stream2)
            End If
        End While
        rst.Close()
        GlobalCopyrightName = GlobalSystemName & " © Winter Bugahod of " & StrConv(compname, VbStrConv.ProperCase)
    End Sub
    
End Module
