Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class rptAccountingTicket
    Private Sub rptAccountsPayable_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        If ReportHeaderImg Is Nothing Then
            imgReportHeader.Visible = False
            txtCompanyName.Text = compname
            txtCompanyAddress.Text = compadd
            txtCompanyNumber.Text = compnumber
        Else
            imgReportHeader.Visible = True
            imgReportHeader.Image = ReportHeaderImg
        End If

        If ReportFooterImg Is Nothing Then
            imgReportFooter.Visible = False
        Else
            imgReportFooter.Visible = True
            imgReportFooter.Image = ReportFooterImg
        End If

        If Me.Landscape = True Then
            txtCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            txtCompanyAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            txtCompanyNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Else
            txtCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            txtCompanyAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            txtCompanyNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        End If


        'PROCUREMENT OFFICER
        Dim proccessby As String = qrysingledata("trnby", "trnby", "tblgljournalentries where ticketno='" & ticketno.Text & "'")
        com.CommandText = "select * from tblaccounts where accountid='" & proccessby & "'" : rst = com.ExecuteReader
        While rst.Read
            txtSignatory1.Text = rst("fullname").ToString
            txtPosition1.Text = rst("designation").ToString
        End While
        rst.Close()
        ShowReportSignature(proccessby, XrPictureBox1)

   
        Dim Approvedby As String = qrysingledata("clearedby", "clearedby", "tblgljournalentries where ticketno='" & ticketno.Text & "'")
        com.CommandText = "select * from tblaccounts where accountid='" & Approvedby & "'" : rst = com.ExecuteReader
        While rst.Read
            txtSignatory2.Text = rst("fullname").ToString
            txtPosition2.Text = rst("designation").ToString
        End While
        rst.Close()
        ShowReportSignature(Approvedby, XrPictureBox2)

        txtNote.Text = "NOTE: This report and the signatures contained herein are generated electronically. All signatures are official and carry the full authority of the person(s) indicated"
        If GlobalEnableCopyright = True Then
            txtCopyright.Visible = True
        Else
            txtCopyright.Visible = False
        End If
        txtCopyright.Text = GlobalCopyrightName
    End Sub
 
End Class