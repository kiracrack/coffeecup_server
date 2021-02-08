Imports DevExpress.XtraGrid.Views.Grid

Module Payroll
    '####################### PAYROLL VARIABLES #####################
    Public GlobalTaxCode As String = ""
    Public GlobalSSSCode As String = ""
    Public GlobalPagibigCode As String = ""
    Public GlobalPhilhealthCode As String = ""
    Public GlobalSavingsCode As String = ""
    Public GlobalTaxPercent As Double = 0
    Public GlobalTotalWorkingDays As Double = 0
    Public GlobalTotalWorkingHours As Double = 0
    Public GLobalEmployeeSequence As Boolean
    Public GlobalBimetricModel As String = ""
    Public GlobalBimetricTemplate As String = ""

    Public Sub loadGeneralPayrollSettings()
        com.CommandText = "select *,(select description from tblpayrolldedaddtype where code = tblpayrollsettings.defaulttax) as 'tax', " _
                        + " (select description from tblpayrolldedaddtype where code = tblpayrollsettings.defaultsss) as 'sss', " _
                        + " (select description from tblpayrolldedaddtype where code = tblpayrollsettings.defaultpagibig) as 'pagibig', " _
                        + " (select description from tblpayrolldedaddtype where code = tblpayrollsettings.defaultphilhealth) as 'philhealth', " _
                        + " (select description from tblpayrolldedaddtype where code = tblpayrollsettings.defaultsavings) as 'savings' " _
                        + " from tblpayrollsettings" : rst = com.ExecuteReader
        While rst.Read
            GlobalTaxCode = rst("defaulttax").ToString
            GlobalSSSCode = rst("defaultsss").ToString
            GlobalPagibigCode = rst("defaultpagibig").ToString
            GlobalPhilhealthCode = rst("defaultphilhealth").ToString
            GlobalSavingsCode = rst("defaultsavings").ToString
            GlobalTaxPercent = rst("taxpercent").ToString
            GlobalTotalWorkingDays = rst("totalworkingdays").ToString
            GlobalTotalWorkingHours = rst("totalworkinghours").ToString
            If rst("employeeidsequence").ToString = "" Then
                GLobalEmployeeSequence = False
            Else
                GLobalEmployeeSequence = True
            End If
            GlobalBimetricModel = rst("biometricmodel").ToString
            GlobalBimetricTemplate = rst("biometrictemplate").ToString
        End While
        rst.Close()
    End Sub

    Public Function getEmployeeIDSequence()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "select employeeidsequence from tblpayrollsettings" : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("employeeidsequence").ToString.Length
            strng = Val(rst("employeeidsequence").ToString) + 1
        End While
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 10 Then
                newNumber = "0000000000" & strng
            ElseIf a = 9 Then
                newNumber = "000000000" & strng
            ElseIf a = 8 Then
                newNumber = "00000000" & strng
            ElseIf a = 7 Then
                newNumber = "0000000" & strng
            ElseIf a = 6 Then
                newNumber = "000000" & strng
            ElseIf a = 5 Then
                newNumber = "00000" & strng
            ElseIf a = 4 Then
                newNumber = "0000" & strng
            ElseIf a = 3 Then
                newNumber = "000" & strng
            ElseIf a = 2 Then
                newNumber = "00" & strng
            ElseIf a = 1 Then
                newNumber = "0" & strng
            Else
                newNumber = strng
            End If
        Else
            newNumber = strng
        End If
        Return newNumber
    End Function

    Public Sub PrintDailyTimeRecord(ByVal userid As String, ByVal form As Form, ByVal gv As GridView)
        Dim TableRow As String = ""
        Dim Template As String = Application.StartupPath.ToString & "\Templates\DailyTimeRecord.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\REPORTS\" & userid & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        Dim payrollMonth As String = ""
        Dim totalUnderTime As Double = 0
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        For x = 1 To 31
            Dim day_found As Boolean = False
            For I = 0 To gv.RowCount - 1
                If payrollMonth = "" Then
                    payrollMonth = Format(CDate(gv.GetRowCellValue(I, "AttendanceDate").ToString), "MMMM, yyyy")
                End If

                Dim att_day As Integer = Format(CDate(gv.GetRowCellValue(I, "AttendanceDate").ToString), "dd")
                If x = att_day Then
                    day_found = True
                    Dim undertime As Double = Val(gv.GetRowCellValue(I, "Undertime").ToString)
                    TableRow += "<tr class='row_dtr'> " _
                                + " <td align='center'>" & att_day & "</td> " _
                                + " <td align='center' style='white-space: nowrap;'>" & gv.GetRowCellValue(I, "MorningIn").ToString & "</td> " _
                                + " <td align='center' style='white-space: nowrap;'>" & gv.GetRowCellValue(I, "MorningOut").ToString & "</td> " _
                                + " <td align='center' style='white-space: nowrap;'>" & gv.GetRowCellValue(I, "NoonIn").ToString & "</td> " _
                                + " <td align='center' style='white-space: nowrap;'>" & gv.GetRowCellValue(I, "NoonOut").ToString & "</td> " _
                                + " <td align='center'>" & If(undertime >= 60, Math.Floor(undertime / 60), "") & "</td> " _
                                + " <td align='center'>" & If(undertime > 60, Val(undertime - (Math.Floor(undertime / 60) * 60)), If(undertime = 0, "", undertime)) & "</td> " _
                            + " </tr>"
                    totalUnderTime += undertime
                End If
            Next
            If day_found = False Then
                TableRow += "<tr class='row_dtr'> " _
                               + " <td align='center'>" & x & "</td> " _
                               + " <td align='center' style='white-space: nowrap;'></td> " _
                               + " <td align='center' style='white-space: nowrap;'></td> " _
                               + " <td align='center' style='white-space: nowrap;'></td> " _
                               + " <td align='center' style='white-space: nowrap;'></td> " _
                               + " <td align='center'></td> " _
                               + " <td align='center'></td> " _
                           + " </tr>"
            End If
        Next




        TableRow += "<tr class='row_dtr'> " _
                        + " <td align='right' colspan='5' style='white-space: nowrap;'>TOTAL</td> " _
                        + " <td align='center'>" & If(totalUnderTime >= 60, Math.Floor(totalUnderTime / 60), "") & "</td> " _
                        + " <td align='center'>" & If(totalUnderTime > 60, (totalUnderTime - (Math.Floor(totalUnderTime / 60) * 60)), If(totalUnderTime = 0, "", totalUnderTime)) & "</td> " _
                    + " </tr>"
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[month]", payrollMonth), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[fullname]", form.Text), False)
        If TableRow.Length > 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dtr_item]", TableRow), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dtr_item]", ""), False)
        End If
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub ExitPayrollVariables()
        GlobalTaxCode = ""
        GlobalSSSCode = ""
        GlobalPagibigCode = ""
        GlobalPhilhealthCode = ""
        GlobalTaxPercent = 0
        GlobalTotalWorkingDays = 0
        GlobalTotalWorkingHours = 0
        GLobalEmployeeSequence = False
    End Sub
End Module
