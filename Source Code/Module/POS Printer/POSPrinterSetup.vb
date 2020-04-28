Imports System.IO
Imports System.Management
Imports System.Text
Imports System.IO.Ports

Module POSPrinterSetup
    Dim detailsFile As StreamWriter = Nothing
    Public globalEnablePoleDisplay As Boolean
    Public globalPolePortNumber As String
    Public globalPoleBaudrate As Integer
    Public globalPoleDataBits As String
    Public sp As New SerialPort()

    Public globalEnablePosPrinter As Boolean
    Public globalPosPrintingType As String

    Public globalPosPrinterDevice As String
    Public globalPosSecondaryPrinterDevice As String
    Public globalposEnableCashDrawer As Boolean = False
    Public globalPosMappingScript As String

    Public globalPosPaperSize As Double = 40
    Public globalPosCornerLength As Double = 2
    Public globalPosMarginBottomLenght As Double = 6

    Public globalPosCustomFont As Boolean = False
    Public globalPosFontName As String
    Public globalPosFontSize As Double = 9
    Public globalPosAutoCutPrinter As String = "EPSON"
    Public globalTempOfflinePrinter As Boolean = False
 
    Public Sub OpenCashDrawer()
        Dim details As String = ""
        Dim salefilelocation As String = System.IO.Path.GetTempPath
        details = Chr(27) & Chr(112) & Chr(0) & Chr(25) & Chr(250)
        If System.IO.File.Exists(salefilelocation & "\" & globaluserid & ".txt") = True Then
            System.IO.File.Delete(salefilelocation & "\" & globaluserid & ".txt")
        End If
        Dim detailsFile As StreamWriter = Nothing
        detailsFile = New StreamWriter(salefilelocation & "\" & globaluserid & ".txt", True)
        detailsFile.WriteLine(details)
        detailsFile.Close()
        PrintTextFile(salefilelocation & "\" & globaluserid & ".txt")
    End Sub

    Public Function RemoveFilenameCharacter(ByVal str As String)
        Dim removechar As Char() = "!@#$%^&*+={}|[]\:;'<>?/".ToCharArray()
        Dim sb As New System.Text.StringBuilder
        For Each ch As Char In str
            If Array.IndexOf(removechar, ch) = -1 Then
                sb.Append(ch)
            End If
        Next
        Return sb.ToString
    End Function

    Public Sub LoadPOSPrinterSetup()
        If System.IO.File.Exists(file_PrinterSettings) = True Then
            Dim PrinterType As String = ""
            Dim sr As StreamReader = File.OpenText(file_PrinterSettings)
            Dim br As String = sr.ReadLine() : sr.Close()
            PrinterType = DecryptTripleDES(br) : Dim cnt As Integer = 0
            For Each word In PrinterType.Split(New Char() {","c})
                If cnt = 0 Then
                    globalPosPrintingType = word
                End If
                cnt = cnt + 1
            Next
            globalEnablePosPrinter = True
        Else
            globalEnablePosPrinter = False
        End If
        If globalEnablePosPrinter = True Then
            If globalPosPrintingType = "script" Then
                LoadScriptPrinterSettings()
            ElseIf globalPosPrintingType = "manual" Then
                LoadManualPrinterSettings()
            End If

        End If
    End Sub

    Public Sub LoadScriptPrinterSettings()
        If System.IO.File.Exists(file_PrinterSettings) = True Then
            globalEnablePosPrinter = True
            Dim sr As StreamReader = File.OpenText(file_PrinterSettings)
            Dim br As String = sr.ReadLine() : sr.Close()
            Dim strSetup = DecryptTripleDES(br) : Dim cnt As Integer = 0
            For Each word In strSetup.Split(New Char() {","c})
                If cnt = 1 Then
                    globalPosPrinterDevice = word

                ElseIf cnt = 2 Then
                    If word <> "" Then
                        globalPosMappingScript = word
                    End If
                ElseIf cnt = 3 Then
                    globalposEnableCashDrawer = CBool(word)

                ElseIf cnt = 4 Then
                    globalPosPaperSize = word

                ElseIf cnt = 5 Then
                    globalPosCornerLength = word

                ElseIf cnt = 6 Then
                    globalPosMarginBottomLenght = word

                ElseIf cnt = 7 Then
                    globalPosAutoCutPrinter = word

                ElseIf cnt = 8 Then
                    globalTempOfflinePrinter = word

                End If
                cnt = cnt + 1
            Next
            MapPOSScriptPrinter()

        End If
    End Sub

    Public Sub LoadManualPrinterSettings()
        If System.IO.File.Exists(file_PrinterSettings) = True Then
            globalEnablePosPrinter = True
            Dim sr As StreamReader = File.OpenText(file_PrinterSettings)
            Dim br As String = sr.ReadLine() : sr.Close()
            Dim strSetup = DecryptTripleDES(br) : Dim cnt As Integer = 0
            For Each word In strSetup.Split(New Char() {","c})
                If cnt = 1 Then
                    globalPosPrinterDevice = word

                ElseIf cnt = 2 Then
                    globalPosSecondaryPrinterDevice = word

                ElseIf cnt = 3 Then
                    globalposEnableCashDrawer = CBool(word)

                ElseIf cnt = 4 Then
                    globalPosPaperSize = word

                ElseIf cnt = 5 Then
                    globalPosCornerLength = word

                ElseIf cnt = 6 Then
                    globalPosMarginBottomLenght = word

                ElseIf cnt = 7 Then
                    globalPosCustomFont = CBool(word)

                ElseIf cnt = 8 Then
                    globalPosFontName = word

                ElseIf cnt = 9 Then
                    globalPosFontSize = word

                ElseIf cnt = 10 Then
                    globalPosAutoCutPrinter = word

                ElseIf cnt = 11 Then
                    globalTempOfflinePrinter = CBool(word)

                End If
                cnt = cnt + 1
            Next
        End If
    End Sub

    Public Function PrintSpaceLine() As String
        PrintSpaceLine = ""
        For i = 0 To globalPosPaperSize - (globalPosCornerLength * 2)
            PrintSpaceLine = PrintSpaceLine + "-"
        Next
        Return PrintGetSpace(globalPosCornerLength) + PrintSpaceLine
    End Function

    Public Function PrintCenterText(ByVal value As String) As String
        PrintCenterText = Nothing
        Dim centerText As String = "" : Dim space As String = "" : Dim remVal As String = ""
        If value.Length > globalPosPaperSize Then
            centerText = value
        Else
            centerText = value
            For i = 0 To ((globalPosPaperSize - value.Length) / 2)
                space = space & " "
            Next
        End If
        PrintCenterText = space + centerText & remVal
        Return PrintCenterText
    End Function

    Public Function PrintLeftText(ByVal value As String)
        Return PrintGetSpace(globalPosCornerLength) + value
    End Function

    Public Function Split(ByVal Expression As String)
        Dim Astr As String = Expression
        'Astr = Astr.Remove(Astr.Length - 10, 10)
        Astr = Astr.Remove(globalPosPaperSize - (globalPosPaperSize / 4.25), Astr.Length - (globalPosPaperSize - (globalPosPaperSize / 4.25)))
        Astr = Astr.Remove(Astr.Length - 3, 3)
        ' Astr = Astr.Remove(Astr.Length - (globalPosPaperSize - (globalPosPaperSize / 2)), (globalPosPaperSize / 4))
        Return Astr
    End Function

    Public Function PrintLeftRigthText(ByVal value_left As String, ByVal value_right As String)
        Dim str As String = ""
        If value_left.Length > (globalPosPaperSize - value_right.Length) Then
            value_left = Split(value_left) & ".."
        End If
        Dim a As Double = (globalPosPaperSize - ((globalPosCornerLength * 2) + value_left.Length)) - value_right.Length
        str = PrintGetSpace(globalPosCornerLength) + value_left + PrintGetSpace(a) + value_right
        Return str
    End Function

    Public Function PrintGetSpace(ByVal value As Integer)
        PrintGetSpace = ""
        For i = 0 To value - 1
            PrintGetSpace = PrintGetSpace + " "
        Next
        Return PrintGetSpace
    End Function
    Public Function PageHeader() As String
        Dim details As String = ""
        details = If(globalposEnableCashDrawer = True, (27) & Chr(112) & Chr(0) & Chr(25) & Chr(250), "")
        details += If(compname.Length > 0, PrintCenterText(compname) & Environment.NewLine, "")
        details += If(compadd.Length > 0, PrintCenterText(compadd) & Environment.NewLine, "")
        details += If(compnumber.Length > 0, PrintCenterText(compnumber) & Environment.NewLine, "")
        Return details
    End Function

    Public Function CutPaperCommand(ByVal PrinterType As String) As String
        CutPaperCommand = ""
        Dim EPS As String = Chr(29) & "V" & Chr(65) & Chr(0)
        Dim ESC As String = Chr(27) + Chr(29)
        Dim CH As String = Chr(13) + Chr(10)

        If PrinterType = "Epson" Then
            CutPaperCommand = EPS
        ElseIf PrinterType = "Standard" Then
            CutPaperCommand = ESC
        Else
            CutPaperCommand = CH
        End If

        Return CutPaperCommand
    End Function

    Public Function LastPagepaper() As String
        Dim bottomMargin As String = ""
        For i = 0 To globalPosMarginBottomLenght - 1
            bottomMargin = bottomMargin + Environment.NewLine
        Next
        LastPagepaper = bottomMargin & CutPaperCommand(globalPosAutoCutPrinter)
        Return LastPagepaper
    End Function

    Public Sub MapPOSScriptPrinter()
        If globalPosMappingScript <> "" Then
            For Each word In globalPosMappingScript.Split(New Char() {vbCrLf})
                Dim command As String = "/C " & word
                Dim application As New ProcessStartInfo("cmd.exe", command)
                Dim process As New Process
                application.WindowStyle = ProcessWindowStyle.Hidden
                process = process.Start(application)
                process.WaitForExit()
                process.Close()
            Next
        End If
    End Sub

    Public Sub PrintTextFile(ByVal location As String)
        If location <> "" Then
            Dim command As String = "/C print /d:" & globalPosPrinterDevice & ": """ & location & """"
            Dim application As New ProcessStartInfo("cmd.exe", command)
            Dim process As New Process
            application.WindowStyle = ProcessWindowStyle.Hidden
            process = process.Start(application)
            process.WaitForExit()
            process.Close()
        End If
    End Sub

    Public Sub OpenDrawerViaCMD()
        Dim command As String = "/C " & Chr(27) & Chr(112) & Chr(0) & Chr(25) & Chr(250)
        Dim application As New ProcessStartInfo("cmd.exe", command)
        Dim process As New Process
        application.WindowStyle = ProcessWindowStyle.Hidden
        process = process.Start(application)
        process.WaitForExit()
        process.Close()
    End Sub

    Public Function POSPrint(ByVal details As String, ByVal ReferenceNo As String, ByVal folder As String)
        If globalPosPrintingType = "script" Then
            Dim salefilelocation As String = ""
            salefilelocation = Application.StartupPath.ToString & "\Transaction\" & folder
             If System.IO.File.Exists(salefilelocation & "\" & RemoveFilenameCharacter(ReferenceNo) & ".txt") = True Then
                System.IO.File.Delete(salefilelocation & "\" & RemoveFilenameCharacter(ReferenceNo) & ".txt")
            End If
            Dim detailsFile As StreamWriter = Nothing
            detailsFile = New StreamWriter(salefilelocation & "\" & RemoveFilenameCharacter(ReferenceNo) & ".txt", True)
            detailsFile.WriteLine(details)
            detailsFile.Close()
            PrintTextFile(salefilelocation & "\" & ReferenceNo & ".txt")
        Else
            If globalPosCustomFont = True Then
                Dim Print As New POSDirectPrint
                Print.prt(details, globalPosPrinterDevice)
            Else
                RawPrinterHelper.SendStringToPrinter(globalPosPrinterDevice, details)
            End If
        End If
        Return True
    End Function

    Public Function POSQueuePrint(ByVal details As String)
        If globalPosPrintingType = "script" Then
            MsgBox("Script printing are not available for pos queue features. please use manual printer setup on pos printer settings!", MsgBoxStyle.Exclamation)
        Else            'MsgBox(details)            If globalPosCustomFont = True Then
                Dim Print As New POSDirectPrint
                Print.prt(details, globalPosSecondaryPrinterDevice)
            Else
                RawPrinterHelper.SendStringToPrinter(globalPosSecondaryPrinterDevice, details)
            End If
        End If

        Return True
    End Function

End Module
