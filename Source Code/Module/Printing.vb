Imports System.IO

Module Printing
    Dim PicBox As PictureBox = New PictureBox
    Public Sub CreateHTMLReportTemplate(ByVal filename As String)
        Dim saveLocation As String = Application.StartupPath.ToString & "\Templates\" & filename
        com.CommandText = "select * from tblreporthtmltemplate where filename='" & filename & "'" : rst = com.ExecuteReader
        While rst.Read
            If System.IO.File.Exists(saveLocation) = True Then
                System.IO.File.Delete(saveLocation)
            End If
            Dim detailsFile As StreamWriter = Nothing
            detailsFile = New StreamWriter(saveLocation, True)
            detailsFile.WriteLine(rst("htmltemplate").ToString)
            detailsFile.Close()
        End While
        rst.Close()
    End Sub
    Public Function PrintSetupHeader() As String
        PrintSetupHeader += "<p align='right' ><strong>" & UCase(compname) & "</strong></br>" _
                            + compadd & "<br/> " _
                            + compnumber & "<br/> "
        PrintSetupHeader += "<p align='right'><strong>" & UCase(globaloffice) & "</strong></br>"

        Return PrintSetupHeader
    End Function



    Public Function PrintSetupHeaderGeneral()
        PrintSetupHeaderGeneral = ""
        PrintSetupHeaderGeneral += "<p align='right' ><strong>" & UCase(compname) & "</strong></br>" _
                            + compadd & "<br/> " _
                            + compnumber & "<br/> "

        Return PrintSetupHeaderGeneral
    End Function

    Public Function PrintSetupHeaderGL(ByVal companyid As String, ByVal center As Boolean)
        PrintSetupHeaderGL = ""
        com.CommandText = "select * from tblcompanysettings where companycode='" & companyid & "'" : rst = com.ExecuteReader
        While rst.Read
            PrintSetupHeaderGL += "<p align='" & If(center = True, "center", "right") & "' ><strong>" & UCase(rst("companyname").ToString) & "</strong></br>" _
                    + rst("compadd").ToString & "<br/> " _
                    + rst("telephone").ToString & "<br/> "
        End While
        rst.Close()


        Return PrintSetupHeaderGL
    End Function

    Public Sub PrintViaInternetExplorer(ByVal location As String, ByVal form As Form)
        Try
            System.Diagnostics.Process.Start(location)
            'form.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MessageBox.Show("File not found!",
                          "Error Reprint Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub GenerateLXGuestStatement(ByVal folioid As String, ByVal form As Form)
        Dim TableRow As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0
        CreateHTMLReportTemplate("HotelStatementOfAccount.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\HotelStatementOfAccount.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\FOLIO\" & folioid & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        com.CommandText = "SELECT a.trnid, " _
                        + " date_format(a.datetrn, '%Y-%m-%d') as 'datetrn', " _
                        + " (select officename from tblcompoffice where officeid = a.officeid) as 'chargefrom', " _
                        + " if(appliedcoupon=1,concat(remarks,' (Covered by Coupon)'),a.remarks) as 'remarks'," _
                        + " a.referenceno  as 'refno', " _
                        + " if(appliedcoupon=1,0,a.debit) as 'debit', " _
                        + " a.credit as 'credit', " _
                        + " (SELECT SUM(COALESCE(if(appliedcoupon=1,0,debit),0) - COALESCE(credit,0)) FROM tblhoteltransaction as b WHERE b.trnid <= a.trnid and b.folioid='" & folioid & "' and b.cancelled=0) AS 'balance' " _
                        + " FROM `tblhoteltransaction` as a where folioid='" & folioid & "' and a.cancelled=0 order by a.trnid asc" : rst = com.ExecuteReader
        While rst.Read
            TableRow += "<tr> " _
                           + " <td align='center'>" & rst("datetrn").ToString & "</td> " _
                           + " <td align='left'>" & rst("chargefrom").ToString & "</td> " _
                           + " <td align='left'>" & StrConv(rst("remarks").ToString, vbProperCase) & "</td> " _
                           + " <td align='center'>" & rst("refno").ToString & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("debit").ToString, 2) & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("credit").ToString, 2) & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("balance").ToString, 2) & "</td> " _
                     + " </tr> " & Chr(13)
            Total = rst("balance")
        End While
        rst.Close()


        TableRow += "<tr> " _
                        + " <td align='right' colspan='6'>BALANCE</td> " _
                        + " <td align='right'>" & FormatNumber(Total, 2) & "</td> " _
                 + " </tr> " & Chr(13)

        TableTransaction = TableRow
        If System.IO.File.Exists(Application.StartupPath.ToString & "\img\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<img style='float:left;  position: absolute;' src='" & Application.StartupPath.ToString & "\img\logo.png'>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", "STATEMENT OF ACCOUNT"), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", Now.ToShortDateString), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)
        com.CommandText = "select *,(select roomnumber from tblhotelrooms where roomid  = tblhotelroomtransaction.roomid) as 'roomno', " _
                                + " (select description from tblhotelrooms where roomid  = tblhotelroomtransaction.roomid) as 'roomdescription', " _
                                + " (select fullname from tblhotelguest where guestid=tblhotelroomtransaction.guestid) as 'Guest', " _
                                + " (select address from tblhotelguest where guestid=tblhotelroomtransaction.guestid) as 'address', " _
                                + " (select description from tblhotelrooms where roomid  = tblhotelroomtransaction.roomid) as 'roomno' from tblhotelroomtransaction where folioid='" & folioid & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[folio]", rst("foliono").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[client name]", rst("Guest").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[client address]", rst("address").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[room no]", rst("roomno").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[room type]", UCase(rst("roomdescription").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[details]", "Adult " & rst("noadults").ToString & " Child " & rst("nochild").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date checkin]", rst("datecheckin").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date checkout]", rst("datecheckout").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[balance]", FormatNumber(Total)), False)
        End While
        rst.Close()
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globaldesignation)), False)

        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub PrintDatagridview(ByVal ReportTitle As String, ByVal TableTitle As String, ByVal ReportDescription As String, ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView, ByVal form As Form)
        If gv.RowCount = 0 Then
            MessageBox.Show("No data report to print!", _
                       "Error Print", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'CreateHTMLReportTemplate("StandardReportsServer.html")

        Dim Template As String = Application.StartupPath.ToString & "\Templates\StandardReportsServer.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\REPORTS\" & RemoveSpecialCharacter(form.Text) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        If System.IO.File.Exists(Application.StartupPath.ToString & "\img\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<img style='float:left;  position: absolute;' src='" & Application.StartupPath.ToString.Replace("\", "/") & "/img/logo.png'>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", UCase(ReportTitle)), False)

        Dim ReportDetails As String = "<p align='left'> " & If(ReportDescription = "", "&nbsp;", ReportDescription) & " <span style='float:right'>Date Report: " & CDate(Now).ToString("MMMM dd, yyyy") & "</span></p>"
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report details]", ReportDetails), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report table]", SetupTheGridviewPrinter(TableTitle, gv)), False)


        If AppSinglePrepared = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(AppPreparedName)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(ApppreparedPosition)), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globaldesignation)), False)
        End If
        If AppEnableCheckedby = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checked by]", UCase(AppCheckedName)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checked position]", UCase(AppCheckedPosition)), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checked by]", "_________________________"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checked position]", "Signature Over Printed Name"), False)
        End If
        If AppEnableapprovedby = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved by]", UCase(AppApprovedName)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved position]", UCase(AppApprovedPosition)), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved by]", "_________________________"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved position]", "Signature Over Printed Name"), False)
        End If

        ' Me.WindowState = FormWindowState.Minimized
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Function SetupTheGridviewPrinter(ByVal TableTitle As String, ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView) As String
        On Error Resume Next
        Dim TableHeaderStart As String = "" : Dim TableHeaderEnd As String = "" : Dim ColumnName As String = "" : Dim rows As String = "" : Dim rowRowTableData As String = "" : Dim RowFooter As String = ""
        Dim width As Double = 0
        For I = 0 To gv.Columns.Count - 1
            If gv.Columns(I).VisibleIndex >= 0 Then
                width += gv.Columns(I).Width
            End If
        Next


        TableHeaderStart = "<table border='1' width='100%' style='margin:3px 0' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " _
                                       + " <tr> " _
                                           + " <td colspan='" & gv.Columns.Count & "' height='20' align='center'><b>" & UCase(TableTitle) & "</b></td> " _
                                       + " </tr> " & Chr(13) _
                                       + " <tr> "
        com.CommandText = "DROP temporary table if exists temptableprinting" : com.ExecuteNonQuery()
        com.CommandText = "CREATE temporary TABLE  temptableprinting (  `columnname` varchar(100) NOT NULL, `colindex` double NOT NULL, `colwidth` double NOT NULL default 0) ENGINE=memory;" : com.ExecuteNonQuery()
        For I = 0 To gv.Columns.Count - 1
            If gv.Columns(I).VisibleIndex >= 0 Then
                com.CommandText = "insert into temptableprinting set columnname='" & gv.Columns(I).FieldName & "',colindex='" & gv.Columns(I).VisibleIndex & "', colwidth='" & gv.Columns(I).Width & "'" : com.ExecuteNonQuery()
            End If
        Next

        com.CommandText = "select * from temptableprinting order by colindex asc" : rst = com.ExecuteReader
        While rst.Read
            ColumnName += "<th>" & rst("columnname").ToString & "</th>"
        End While
        rst.Close()

        TableHeaderEnd = " </tr> "
        For I = 0 To gv.RowCount - 1
            rowRowTableData = "" : Dim rowColor As String = "000000"
            com.CommandText = "select * from temptableprinting order by colindex asc" : rst = com.ExecuteReader
            While rst.Read
                Dim colalignment As String = "" : Dim strvalue As String = "" : Dim columnSize As String = ""
                If gv.Columns(rst("columnname").ToString).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center Then
                    colalignment = "align='center'"

                    If gv.GetRowCellValue(I, rst("columnname").ToString).ToString Is Nothing Then
                        strvalue = "&nbsp;"
                    Else
                        strvalue = gv.GetRowCellValue(I, rst("columnname").ToString).ToString
                    End If

                ElseIf gv.Columns(rst("columnname").ToString).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far Then
                    colalignment = "align='right'"
                    If gv.GetRowCellValue(I, rst("columnname").ToString).ToString = "" Then
                        strvalue = "&nbsp;"
                    Else
                        strvalue = FormatNumber(gv.GetRowCellValue(I, rst("columnname").ToString).ToString, 2)
                    End If
                Else
                    If gv.GetRowCellValue(I, rst("columnname").ToString).ToString Is Nothing Then
                        strvalue = "&nbsp;"
                    Else
                        strvalue = gv.GetRowCellValue(I, rst("columnname").ToString).ToString
                    End If
                End If

                If Val(rst("colwidth").ToString) >= 350 Then
                    columnSize = " width='350' "

                End If

                Dim CellData As String = strvalue.Replace("True", "YES").Replace("False", "-").Replace(Chr(13), "<br/>").Replace(vbCrLf, "<br/>").Replace(vbCr, "<br/>").Replace(vbLf, "<br/>")

                rowRowTableData += "<td " & colalignment & columnSize & ">" & CellData & "</td> "
            End While
            rst.Close()

            Dim EnableBoldFormat As Boolean = False
            For Each col In gv.Columns

                If col.Name = "colbold" Then

                    EnableBoldFormat = True
                End If
            Next
            If EnableBoldFormat = True Then
                If CBool(gv.GetRowCellValue(I, "bold").ToString) = True Then
                    rows += "<tr style='color:#" & rowColor & "; font-weight:bold'>" + rowRowTableData + "</tr>"
                Else
                    rows += "<tr style='color:#" & rowColor & "'>" + rowRowTableData + "</tr>"
                End If
            Else
                rows += "<tr style='color:#" & rowColor & "'>" + rowRowTableData + "</tr>"
            End If
        Next
        Dim SummaryRow As String = "" : Dim SummaryColumn As String = ""
        If gv.OptionsView.ShowFooter = True Then
            For Each col In gv.Columns
                If col.Visible = True Then
                    SummaryColumn += "<td align='center'>" & col.SummaryText & "</td>"
                End If

            Next

            'For Each col As String In gv.Columns
            '    If col <> "" Then
            '        For I = 0 To gv.Columns.Count - 1

            '        Next
            '    End If
            'Next
        End If
        SummaryRow = "<tr style='font-weight:bold'>" & SummaryColumn & "</tr>"

        SetupTheGridviewPrinter = TableHeaderStart + ColumnName + TableHeaderEnd + rows + SummaryRow + "</table>"
        Return SetupTheGridviewPrinter
    End Function

    Public Sub PrintDatagridviewGL(ByVal companyid As String, ByVal ReportTitle As String, ByVal TableTitle As String, ByVal ReportDescription As String, ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView, ByVal form As Form)
        If gv.RowCount = 0 Then
            MessageBox.Show("No data report to print!", _
                       "Error Print", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'CreateHTMLReportTemplate("StandardReportsServer.html")

        Dim Template As String = Application.StartupPath.ToString & "\Templates\StandardReportsServer.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\REPORTS\" & RemoveSpecialCharacter(form.Text) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        If System.IO.File.Exists(Application.StartupPath.ToString & "\img\" & companyid & ".png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<img style='float:left;  position: absolute;' src='" & Application.StartupPath.ToString.Replace("\", "/") & "/img/" & companyid & ".png'>"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeaderGL(companyid, False)), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeaderGL(companyid, True)), False)
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", ReportTitle), False)

        Dim ReportDetails As String = "<p align='left'> " & If(ReportDescription = "", "&nbsp;", ReportDescription) & " <span style='float:right'>Date Report: " & CDate(Now).ToString("MMMM dd, yyyy") & "</span></p>"
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report details]", ""), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report table]", SetupTheGridviewPrinterGL(TableTitle, True, gv)), False)


        If AppSinglePrepared = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(AppPreparedName)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(ApppreparedPosition)), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globaldesignation)), False)
        End If
        If AppEnableCheckedby = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checked by]", UCase(AppCheckedName)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checked position]", UCase(AppCheckedPosition)), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checked by]", "_________________________"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checked position]", "Signature Over Printed Name"), False)
        End If
        If AppEnableapprovedby = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved by]", UCase(AppApprovedName)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved position]", UCase(AppApprovedPosition)), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved by]", "_________________________"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved position]", "Signature Over Printed Name"), False)
        End If

        ' Me.WindowState = FormWindowState.Minimized
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Function SetupTheGridviewPrinterGL(ByVal TableTitle As String, ByVal replaceSpaceCharacter As Boolean, ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView) As String
        On Error Resume Next
        Dim TableHeaderStart As String = "" : Dim TableHeaderEnd As String = "" : Dim ColumnName As String = "" : Dim rows As String = "" : Dim rowRowTableData As String = "" : Dim RowFooter As String = ""
        Dim width As Double = 0
        For I = 0 To gv.Columns.Count - 1
            If gv.Columns(I).VisibleIndex >= 0 Then
                width += gv.Columns(I).Width
            End If
        Next


        TableHeaderStart = "<table border='1' width='100%' style='margin:3px 0' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " _
                                       + " <tr> " _
                                           + " <td colspan='" & gv.Columns.Count & "' height='20' align='center'><b>" & UCase(TableTitle) & "</b></td> " _
                                       + " </tr> " & Chr(13) _
                                       + " <tr> "
        com.CommandText = "DROP temporary table if exists temptableprinting" : com.ExecuteNonQuery()
        com.CommandText = "CREATE temporary TABLE  temptableprinting (  `columnname` varchar(100) NOT NULL, `colindex` double NOT NULL, `colwidth` double NOT NULL default 0) ENGINE=memory;" : com.ExecuteNonQuery()
        For I = 0 To gv.Columns.Count - 1
            If gv.Columns(I).VisibleIndex >= 0 Then
                com.CommandText = "insert into temptableprinting set columnname='" & gv.Columns(I).FieldName & "',colindex='" & gv.Columns(I).VisibleIndex & "', colwidth='" & gv.Columns(I).Width & "'" : com.ExecuteNonQuery()
            End If
        Next

        com.CommandText = "select * from temptableprinting order by colindex asc" : rst = com.ExecuteReader
        While rst.Read
            ColumnName += "<th>" & rst("columnname").ToString & "</th>"
        End While
        rst.Close()

        TableHeaderEnd = " </tr> "
        For I = 0 To gv.RowCount - 1
            rowRowTableData = "" : Dim rowColor As String = "000000"
            com.CommandText = "select * from temptableprinting order by colindex asc" : rst = com.ExecuteReader
            While rst.Read
                Dim colalignment As String = "" : Dim strvalue As String = "" : Dim columnSize As String = ""
                If gv.Columns(rst("columnname").ToString).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center Then
                    colalignment = "align='center'"

                    If gv.GetRowCellValue(I, rst("columnname").ToString).ToString Is Nothing Then
                        strvalue = "&nbsp;"
                    Else
                        strvalue = gv.GetRowCellValue(I, rst("columnname").ToString).ToString
                    End If

                ElseIf gv.Columns(rst("columnname").ToString).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far Then
                    colalignment = "align='right'"
                    If gv.GetRowCellValue(I, rst("columnname").ToString).ToString = "" Then
                        strvalue = "&nbsp;"
                    Else
                        strvalue = FormatNumber(gv.GetRowCellValue(I, rst("columnname").ToString).ToString, 2)
                    End If
                Else
                    If gv.GetRowCellValue(I, rst("columnname").ToString).ToString Is Nothing Then
                        strvalue = "&nbsp;"
                    Else
                        strvalue = gv.GetRowCellValue(I, rst("columnname").ToString).ToString
                    End If
                End If

                If Val(rst("colwidth").ToString) >= 350 And replaceSpaceCharacter = False Then
                    columnSize = " width='350' "

                End If

                Dim CellData As String = strvalue.Replace("True", "YES").Replace("False", "-").Replace(Chr(13), "<br/>")
                Dim spaces As String = getWhiteSpaces(CellData)

                If replaceSpaceCharacter = True Then
                    Dim newCellData As String = SplitLongString(CellData, spaces)
                    rowRowTableData += "<td " & colalignment & columnSize & ">" & If(newCellData = "0.00", "", newCellData.Replace(" ", "&nbsp;")) & "</td> "
                Else
                    rowRowTableData += "<td " & colalignment & columnSize & ">" & If(CellData = "0.00", "", CellData) & "</td> "
                End If
            End While
            rst.Close()

            Dim EnableBoldFormat As Boolean = False
            For Each col In gv.Columns
                If col.Name = "colsl" Then
                    EnableBoldFormat = True
                End If
            Next
            If EnableBoldFormat = True Then
                If CBool(gv.GetRowCellValue(I, "sl").ToString) = False Then
                    rows += "<tr style='color:#" & rowColor & "; font-weight:bold'>" + rowRowTableData + "</tr>"
                Else
                    rows += "<tr style='color:#" & rowColor & "'>" + rowRowTableData + "</tr>"
                End If
            Else
                rows += "<tr style='color:#" & rowColor & "'>" + rowRowTableData + "</tr>"
            End If
        Next
        Dim SummaryRow As String = "" : Dim SummaryColumn As String = ""
        If gv.OptionsView.ShowFooter = True Then
            For Each col In gv.Columns
                If col.Visible = True Then
                    SummaryColumn += "<td align='center'>" & col.SummaryText & "</td>"
                End If

            Next
        End If
        SummaryRow = "<tr style='font-weight:bold'>" & SummaryColumn & "</tr>"
        SetupTheGridviewPrinterGL = TableHeaderStart + ColumnName + TableHeaderEnd + rows + SummaryRow + "</table>"
        Return SetupTheGridviewPrinterGL
    End Function

    Public Function getWhiteSpaces(ByVal CellData As String) As String
        Dim cnt As Integer = 0 : Dim spaces As String = ""
        For Each q In CellData
            If q = " " Then
                cnt += 1
            ElseIf q <> " " And cnt > 5 Then
                For x = 0 To cnt - 1
                    spaces += " "
                Next
                Exit For
            End If
        Next
        Return spaces
    End Function

    Public Function SplitLongString(ByVal CellData As String, ByVal spaces As String)
        Dim newCellData As String = ""
        If CellData.Length > 120 Then
            Dim cn As Integer = 0 : Dim word As String = ""
            For Each q In CellData
                word += q
                If cn > 120 Then
                    If q = " " Then
                        Exit For
                    End If
                End If
                cn += 1
            Next
            newCellData = word
            If CellData.Replace(word, "").Length > 0 Then
                newCellData += "<br/>" & spaces & CellData.Replace(word, "")
            End If
        Else
            newCellData = CellData
        End If
        Return newCellData
    End Function

    Public Sub PrintLXReceipt(ByVal location As String, ByVal form As Form)
        Dim printProcess As New Diagnostics.ProcessStartInfo()
        printProcess.FileName = location
        Try
            Process.Start(printProcess)
            'form.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MessageBox.Show("File not found!",
                          "Error Reprint Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub PrintEmployee201(ByVal employeeid As String, ByVal fullname As String, ByVal form As Form)
        'CreateHTMLReportTemplate("ResidentProfile.html")
        Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = "" : Dim TableTransaction As String = ""
        Dim Template As String = Application.StartupPath.ToString & "\Templates\Employee201File.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\HR\201-" & fullname & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        If Not IO.Directory.Exists(Application.StartupPath.ToString & "\Transaction\HR\image") Then
            IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Transaction\HR\image")
        End If

        Dim companyid As String = ""
        com.CommandText = "select * from tblcompoffice as c inner join tblemployees as e on e.officeid=c.officeid where employeeid='" & employeeid & "'" : rst = com.ExecuteReader
        While rst.Read
            companyid = rst("companyid").ToString
        End While
        rst.Close()

        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        If System.IO.File.Exists(Application.StartupPath.ToString & "\img\" & companyid & ".png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<img style='float:left;  position: absolute;' src='" & Application.StartupPath.ToString.Replace("\", "/") & "/img/" & companyid & ".png'>"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeaderGL(companyid, False)), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeaderGL(companyid, True)), False)
        End If

        PicBox.Image = Nothing
        com.CommandText = "select *,date_format(datehired,'%M %d, %Y') as 'hired',date_format(dateregular,'%M %d, %Y') as 'regular',(select officename from tblcompoffice where officeid = tblemployees.officeid) as 'officename', " _
                              + " (select departmentname from tblcompdepartments where depid = tblemployees.depid) as 'department', " _
                              + " (select description from tblemployeetype where code = tblemployees.employeetypecode) as 'employeetype', " _
                              + " (select description from tblpayrollbasicrate where code = tblemployees.positioncode) as 'rate', " _
                              + " (select fullname from tblemployees as a where a.employeeid = tblemployees.approvedby) as 'statusapprovedbyname'," _
                              + " (select fullname from tblaccounts where accountid=tblemployees.linkuserid) as 'useraccount', " _
                              + " (select description from tblpayrollshiftsettings where shiftcode=tblemployees.shiftcode) as 'shift'," _
                              + " (select companyname from tblclientaccounts where cifid=tblemployees.linkclientid) as 'clientaccount', " _
                              + " (select img from " & sqlfiledir & ".tblemployeepic where employeeid=tblemployees.employeeid) as img from tblemployees where employeeid='" & employeeid & "'" : rst = com.ExecuteReader
        While rst.Read
            ConvertDatabaseImage("img", PicBox)
            If System.IO.File.Exists(Application.StartupPath.ToString & "\Transaction\HR\image\" & employeeid & ".jpg") = True Then
                System.IO.File.Delete(Application.StartupPath.ToString & "\Transaction\HR\image\" & employeeid & ".jpg")
            End If
            If Not PicBox.Image Is Nothing Then
                PicBox.Image.Save(Application.StartupPath.ToString & "\Transaction\HR\image\" & employeeid & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            Else
                If LCase(rst("gender").ToString) = "male" Then
                    IO.File.Copy(Application.StartupPath.ToString & "\img\no-picture-male.jpg", Application.StartupPath.ToString & "\Transaction\HR\image\" & employeeid & ".jpg")
                Else
                    IO.File.Copy(Application.StartupPath.ToString & "\img\no-picture-female.jpg", Application.StartupPath.ToString & "\Transaction\HR\image\" & employeeid & ".jpg")
                End If
            End If



            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[fullname]", rst("fullname").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[nickname]", If(rst("nickname").ToString = "", "", "<br/>""" & LCase(rst("nickname").ToString) & """")), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[employeeid]", rst("employeeid").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[birthdate]", If(rst("birthdate").ToString = "", "", CDate(rst("birthdate").ToString).ToString("MMMM dd, yyyy"))), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[birthplace]", rst("birthplace").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[gender]", rst("gender").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[civilstatus]", rst("civilstatus").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[spouse]", rst("spousename").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[height]", rst("height").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[weight]", rst("weight").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[nationality]", rst("nationality").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[religion]", rst("religion").ToString), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[employementstatus]", rst("employeetype").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[datehired]", rst("hired").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dateregular]", rst("regular").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[office]", rst("officename").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[department]", rst("department").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[position]", rst("position").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[basicrate]", rst("rate").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[shifttime]", rst("shift").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[actived]", If(CBool(rst("resigned").ToString) = True, "RESIGNED", "ACTIVED")), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cur_purok]", rst("per_add_purok").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cur_barangay]", rst("per_add_brgy").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cur_province]", rst("per_add_prov").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cur_municipality]", rst("per_add_city").ToString), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[per_purok]", rst("cur_add_purok").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[per_barangay]", rst("cur_add_brgy").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[per_province]", rst("cur_add_prov").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[per_municipality]", rst("cur_add_city").ToString), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[incasecontactperson]", rst("inc_cont_person").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[incasecontactnumber]", rst("inc_cont_number").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[incaseaddress]", rst("inc_cont_address").ToString), False)
            
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[contactnumber]", rst("contactnumber").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[homenumber]", rst("homenumber").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[emailaddress]", rst("emailaddress").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[facebook]", rst("profilelink").ToString.Replace("https://www.facebook.com/", "")), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[facebooklink]", rst("profilelink").ToString), False)

         

            If rst("nationalid").ToString = "" And rst("driverlicenseid").ToString = "" And rst("tinid").ToString = "" And rst("sssid").ToString = "" And rst("pagibigid").ToString = "" And rst("philhealthid").ToString = "" Then
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[governmentid]", ""), False)
            Else
                Dim govermentid As String = ""
                If rst("nationalid").ToString <> "" Then
                    govermentid += "<tr><td Class='title1'>National ID</td><td Class='details1'>" & rst("nationalid").ToString & "</td></tr>"
                End If
                If rst("driverlicenseid").ToString <> "" Then
                    govermentid += "<tr><td Class='title1'>Driver's License</td><td Class='details1'>" & rst("driverlicenseid").ToString & "</td></tr>"
                End If
                If rst("tinid").ToString <> "" Then
                    govermentid += "<tr><td Class='title1'>TIN</td><td Class='details1'>" & rst("tinid").ToString & "</td></tr>"
                End If
                If rst("sssid").ToString <> "" Then
                    govermentid += "<tr><td Class='title1'>SSS</td><td Class='details1'>" & rst("sssid").ToString & "</td></tr>"
                End If
                If rst("pagibigid").ToString <> "" Then
                    govermentid += "<tr><td Class='title1'>Pagibig</td><td Class='details1'>" & rst("pagibigid").ToString & "</td></tr>"
                End If
                If rst("philhealthid").ToString <> "" Then
                    govermentid += "<tr><td Class='title1'>Philhealth</td><td Class='details1'>" & rst("philhealthid").ToString & "</td></tr>"
                End If
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[governmentid]", "<tr><td Colspan='2' Align='Left' class='details1'><Strong>Government ID</Strong></td></tr>" & govermentid), False)
            End If
        End While
        rst.Close()

        '#EDUCATION
        If countqry("tblemployeeeducation", "employeeid='" & employeeid & "'") = 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[education]", ""), False)
        Else
            Dim education As String = ""
            com.CommandText = "select id, educationtype as 'Degree', " _
                  + " (select description from tbldatapicked where fieldname='schoolname' and id=tblemployeeeducation.schoolid) as 'school', " _
                  + " (select description from tbldatapicked where fieldname='course' and id=tblemployeeeducation.courseid) as 'course', " _
                  + " date_format(datefrom,'%Y') as 'PeriodFrom', date_format(dateto,'%Y') as 'PeriodTo' " _
                  + " from tblemployeeeducation where employeeid='" & employeeid & "' order by schoollevel desc" : rst = com.ExecuteReader
            While rst.Read
                education += "<tr align='center'><td Class='details1'>" & rst("Degree").ToString & "</td><td Class='details1'>" & rst("school").ToString & "</td><td Class='details1'>" & rst("course").ToString & "</td><td Class='details1' align='center'>" & If(rst("PeriodFrom").ToString = rst("PeriodTo").ToString, rst("PeriodFrom").ToString, rst("PeriodFrom").ToString & "-" & rst("PeriodTo").ToString) & "</td></tr>	"
            End While
            rst.Close()
            education = "<hr class='break'/><table Border='0' width='100%' Cellpadding='4' Cellspacing='0' style='Border-Collapse:Collapse;'><tr><td Colspan='4' Align='center' class='details1'><Strong>Educational Background</Strong></td></tr><tr align='center'><td Class='title1'>Degree</td><td Class='title1'>School</td><td Class='title1'>Course</td><td Class='title1'>Period</td></tr>" _
                        + education + "</table>"
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[education]", education), False)
        End If

        '#WORK HISTORY
        If countqry("tblemployeework", "employeeid='" & employeeid & "'") = 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[workhistory]", ""), False)
        Else
            Dim workhistory As String = ""
            com.CommandText = "select id,(select description from tbldatapicked where id=tblemployeework.companyid) as 'Company', " _
                  + " (select description from tbldatapicked where id=tblemployeework.positionid) as Position, monthlyrate as 'MonthlyRate', " _
                  + " date_format(datefrom,'%Y') as 'DateFrom',if(iscurrent=1,'Current', date_format(dateto,'%Y')) as 'DateTo'," _
                  + " round(datediff(if(iscurrent=1,current_date,dateto),datefrom)/365,0) as 'inservice', " _
                  + " (select description from tbldatapicked where id=tblemployeework.workstatusid) as 'Status' " _
                  + " from tblemployeework where employeeid='" & employeeid & "' order by datefrom desc" : rst = com.ExecuteReader
            While rst.Read
                workhistory += "<tr align='center'><td Class='details1'>" & rst("Company").ToString & "</td>" _
                              + " <td Class='details1'>" & rst("Position").ToString & "</td> " _
                              + " <td Class='details1'>" & FormatNumber(Val(rst("MonthlyRate").ToString), 2) & "</td> " _
                              + " <td Class='details1'>" & rst("inservice").ToString & "</td> " _
                              + " <td Class='details1'>" & If(rst("DateFrom").ToString = rst("DateTo").ToString, rst("DateFrom").ToString, rst("DateFrom").ToString & "-" & rst("DateTo").ToString) & "</td> " _
                              + " <td Class='details1'>" & rst("Status").ToString & "</td></tr> "
            End While
            rst.Close()
            workhistory = "<hr class='break'/><table Border='0' width='100%' Cellpadding='4' Cellspacing='0' style='Border-Collapse:Collapse;'><tr><td Colspan='6' Align='center' class='details1'><Strong>Work History</Strong></td></tr>" _
                + " <tr align='center'><td Class='title1'>Company</td><td Class='title1'>Position</td><td Class='title1'>Monthly Rate</td><td Class='title1'>Years In Service</td><td Class='title1'>Period</td><td Class='title1'>Status</td></tr>" _
                        + workhistory + "</table>"
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[workhistory]", workhistory), False)
        End If

        '#CERTIFICATION
        If countqry("tblemployeecertification", "employeeid='" & employeeid & "'") = 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[certification]", ""), False)
        Else
            Dim certification As String = ""
            com.CommandText = "select id,(select description from tbldatapicked where id=tblemployeecertification.certissuedfrom) as 'IssuedFrom', " _
                  + " (select description from tbldatapicked where id=tblemployeecertification.certid) as 'TypeCertificate', certno as 'CertificateNo', " _
                  + " date_format(certdate,'%Y-%m-%d') as 'CertificateDate' " _
                  + " from tblemployeecertification where employeeid='" & employeeid & "' order by certdate desc" : rst = com.ExecuteReader
            While rst.Read
                certification += "<tr align='center'><td Class='details1'>" & rst("IssuedFrom").ToString & "</td>" _
                              + " <td Class='details1'>" & rst("TypeCertificate").ToString & "</td> " _
                              + " <td Class='details1'>" & rst("CertificateNo").ToString & "</td> " _
                              + " <td Class='details1'>" & rst("CertificateDate").ToString & "</td></tr> "
            End While
            rst.Close()
            certification = "<hr class='break'/><table Border='0' width='100%' Cellpadding='4' Cellspacing='0' style='Border-Collapse:Collapse;'><tr><td Colspan='4' Align='center' class='details1'><Strong>Certification</Strong></td></tr>" _
                + " <tr align='center'><td Class='title1'>Issued From</td><td Class='title1'>Type of Certification</td><td Class='title1'>Certificate No.</td><td Class='title1'>Date</td></tr>" _
                        + certification + "</table>"
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[certification]", certification), False)
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", StrConv(globaldesignation, vbProperCase)), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[watermark]", "This report and the information contained herein are true and generated electronically.<br/> " _
                                                                                                                   + "© " & My.Application.Info.AssemblyName & " " & CDate(Now).ToString("yyyy") & " - Employee 201 file (Printed on " & CDate(Now).ToString("MMMM dd, yyyy") & " by " & StrConv(globalfullname, VbStrConv.ProperCase) & ")"), False)

        ' Me.WindowState = FormWindowState.Minimized
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub

End Module