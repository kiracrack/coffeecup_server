Imports System.Security.Cryptography
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars
Imports System.Management
Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation

Module Security
    Public EnableModuleProcurement As Boolean
    Public EnableModuleInventory As Boolean
    Public EnableModuleSales As Boolean
    Public EnableModuleFuel As Boolean
    Public EnableModuleAccounting As Boolean
    Public EnableModuleHR As Boolean
    Public EnableModulePayroll As Boolean
    Public EnableModuleReportGen As Boolean
    Public EnableModuleHotel As Boolean

    Public GlobalNumberOfPOS As Integer = 0
    Public GlobalNumberOfDevision As Integer = 0
    Public EnableRetainersMode As Boolean

    Public SystemEngineCode As String
    Public SystemModule As String
    Public SystemDate As String
    Public SystemExpiryDate As String

    Public GlobalDisableSystem As Boolean
    Public GlobalDisableTrigger As String = ""
    Public GlobalDisableValue As String = ""

    Public Function keyloger(ByVal str As String)
        com.CommandText = "insert into tblsystemlogs set DESCRIPTION='" & str & "', UPDATEBY='" & globalfullname & "', DATELOGS=CURRENT_TIMESTAMP"
        com.ExecuteNonQuery()
        Return 0
    End Function

    Public Function LoadGlobalModule() As Boolean
        Dim InfoFile As String = ""
        Try
            'If countqry(" `mysql`.`help_topic`", "`help_topic_id`='467' and help_category_id=1") = 0 Then
            '    If countqry(" `mysql`.`help_topic`", "`help_topic_id`='467'") = 0 Then
            '        com.CommandText = "update `mysql`.`help_topic` set help_category_id=1 where `help_topic_id`='467';" : com.ExecuteNonQuery()
            '        GlobalDisableSystem = True
            '    Else
            '        com.CommandText = "select * from `mysql`.`help_topic` where help_topic_id='467'" : rst = com.ExecuteReader
            '        While rst.Read
            '            GlobalDisableTrigger = rst("example").ToString
            '        End While
            '        rst.Close()

            '        If GlobalDisableTrigger = "" Then
            '            com.CommandText = "update `mysql`.`help_topic` set help_category_id=1 where `help_topic_id`='467';" : com.ExecuteNonQuery()
            '            GlobalDisableSystem = True
            '        Else
            '            GlobalDisableValue = Decryptoffeecup(GlobalDisableTrigger, "a_zur_e")
            '        End If

            '        If GlobalDisableValue <> "FREE" Then
            '            If CDate(Now) > CDate(GlobalDisableValue) Then
            '                com.CommandText = "update `mysql`.`help_topic` set help_category_id=1 where `help_topic_id`='467';" : com.ExecuteNonQuery()
            '                GlobalDisableSystem = True
            '            End If
            '        End If
            '    End If
            'Else
            '    GlobalDisableSystem = True
            'End If

            com.CommandText = "select * from tblsystemlicense" : rst = com.ExecuteReader
            While rst.Read
                SystemEngineCode = rst("enginecode").ToString
                SystemModule = rst("systemmodule").ToString
                SystemDate = rst("systemdate").ToString
                SystemExpiryDate = rst("expirydate").ToString
            End While
            rst.Close()

            If SystemModule <> "" Then
                InfoFile = DecryptTripleDES(SystemModule)
                If InfoFile.Length > 0 Then
                    For Each strLine As String In InfoFile.Split(vbCrLf)
                        Dim word As String() = strLine.Split("=")
                        If word(0) = "procurement" Then
                            If word(1) = "ACTIVATED" Then
                                EnableModuleProcurement = True
                            Else
                                EnableModuleProcurement = False
                            End If
                        End If
                        If word(0) = "inventory" Then
                            If word(1) = "ACTIVATED" Then
                                EnableModuleInventory = True
                            Else
                                EnableModuleInventory = False
                            End If
                        End If
                        If word(0) = "sales" Then
                            If word(1) = "ACTIVATED" Then
                                EnableModuleSales = True
                            Else
                                EnableModuleSales = False
                            End If
                        End If
                        If word(0) = "fuel" Then
                            If word(1) = "ACTIVATED" Then
                                EnableModuleFuel = True
                            Else
                                EnableModuleFuel = False
                            End If
                        End If
                        If word(0) = "accounting" Then
                            If word(1) = "ACTIVATED" Then
                                EnableModuleAccounting = True
                            Else
                                EnableModuleAccounting = False
                            End If
                        End If
                        If word(0) = "hr" Then
                            If word(1) = "ACTIVATED" Then
                                EnableModuleHR = True
                            Else
                                EnableModuleHR = False
                            End If
                        End If
                        If word(0) = "payroll" Then
                            If word(1) = "ACTIVATED" Then
                                EnableModulePayroll = True
                            Else
                                EnableModulePayroll = False
                            End If
                        End If
                        If word(0) = "reportgen" Then
                            If word(1) = "ACTIVATED" Then
                                EnableModuleReportGen = True
                            Else
                                EnableModuleReportGen = False
                            End If
                        End If
                        If word(0) = "hotel" Then
                            If word(1) = "ACTIVATED" Then
                                EnableModuleHotel = True
                            Else
                                EnableModuleHotel = False
                            End If
                        End If
                        If word(0) = "pos" Then
                            GlobalNumberOfPOS = word(1)
                        End If
                        If word(0) = "division" Then
                            GlobalNumberOfDevision = word(1)
                        End If

                        If word(0) = "retainersmode" Then
                            If word(1) = "1" Then
                                EnableRetainersMode = True
                            Else
                                EnableRetainersMode = False
                            End If
                        End If
                    Next
                End If
                Return True
            Else
                Return False
            End If

        Catch errMYSQL As MySqlException
            Return False
        Catch errMS As Exception
            Return False
        End Try
        Return LoadGlobalModule
    End Function


    Public Sub FilterAccessPermission(ByVal currentRibbon As DevExpress.XtraBars.Ribbon.RibbonControl)
        ActivateModuleAndSettings()
        Dim msg As String = ""
        Dim mCurrentItem As BarItem
        If LCase(globaluser) = "root" Then
            MdiCoffeeCup.cmdAdminTool.Visibility = BarItemVisibility.Always
            For Each currentPage As RibbonPage In currentRibbon.Pages
                msg += currentPage.Text & Environment.NewLine
                For Each currentGroup As RibbonPageGroup In currentPage.Groups
                    For Each currenLink As BarItemLink In currentGroup.ItemLinks
                        msg += "-" & currenLink.Item.Caption & Environment.NewLine
                        mCurrentItem = currenLink.Item
                        currenLink.Item.Visibility = BarItemVisibility.Always
                    Next currenLink
                Next currentGroup
            Next
            ' MsgBox(msg)
        Else
            MdiCoffeeCup.cmdAdminTool.Visibility = BarItemVisibility.Never
            For Each currentPage As RibbonPage In currentRibbon.Pages
                For Each currentGroup As RibbonPageGroup In currentPage.Groups
                    For Each currenLink As BarItemLink In currentGroup.ItemLinks
                        mCurrentItem = currenLink.Item
                        currenLink.Item.Visibility = BarItemVisibility.Never
                    Next currenLink
                Next currentGroup
            Next

            For Each currentPage As RibbonPage In currentRibbon.Pages
                Dim p As Integer = 0
                For Each currentGroup As RibbonPageGroup In currentPage.Groups
                    Dim c As Integer = 0
                    com.CommandText = "select * from tblpermissionstemplate where percode='" & globalPermissionAccess & "' and grouppermission='" & currentPage.Name & "'" : rst = com.ExecuteReader
                    While rst.Read
                        For Each currenLink As BarItemLink In currentGroup.ItemLinks
                            mCurrentItem = currenLink.Item
                            If currenLink.Item.Name = rst("menus").ToString Then
                                If rst("menus").ToString = "cmdNewRequest" Then
                                    MdiCoffeeCup.cmdMenuNewRequest.Visibility = BarItemVisibility.Always
                                End If
                                currenLink.Item.Visibility = BarItemVisibility.Always
                                c = c + 1
                            End If
                        Next currenLink
                    End While
                    rst.Close()
                    If c = 0 Then
                        currentGroup.Visible = False
                    Else
                        currentGroup.Visible = True
                        p = p + 1
                    End If
                Next currentGroup
                If p = 0 Then
                    currentPage.Visible = False
                Else
                    currentPage.Visible = True
                End If
            Next
        End If
        If GlobalEnableClinicsServices = True Then
            MdiCoffeeCup.cmdClinicServices.Visibility = BarItemVisibility.Always
        Else
            MdiCoffeeCup.cmdClinicServices.Visibility = BarItemVisibility.Never
        End If
        If GlobalEnableAccountingVoucher = True Then
            MdiCoffeeCup.cmdUnliquidatedCashAdvance.Visibility = BarItemVisibility.Never
        End If
    End Sub

    Public Sub ActivateModuleAndSettings()
        'MAIN MODULE ACTIVATOR
        If EnableModuleProcurement = True Then
            MdiCoffeeCup.rbnProcurement.Visible = True
        Else
            MdiCoffeeCup.rbnProcurement.Visible = False
        End If

        If EnableModuleInventory = True Then
            MdiCoffeeCup.rbnInventory.Visible = True
        Else
            MdiCoffeeCup.rbnInventory.Visible = False
        End If

        If EnableModuleSales = True Then
            MdiCoffeeCup.rbnSales.Visible = True
        Else
            MdiCoffeeCup.rbnSales.Visible = False
        End If

        If EnableModuleAccounting = True Then
            MdiCoffeeCup.rbnAccounting.Visible = True
        Else
            MdiCoffeeCup.rbnAccounting.Visible = False
        End If

        If EnableModuleFuel = True Then
            MdiCoffeeCup.rbnFuel.Visible = True
        Else
            MdiCoffeeCup.rbnFuel.Visible = False
        End If

        If EnableModuleHotel = True Then
            MdiCoffeeCup.rbnHotel.Visible = True
        Else
            MdiCoffeeCup.rbnHotel.Visible = False
        End If

        If EnableModuleHR = True Then
            MdiCoffeeCup.rbnHumanResource.Visible = True
        Else
            MdiCoffeeCup.rbnHumanResource.Visible = False
        End If

        If EnableModulePayroll = True Then
            MdiCoffeeCup.rbnPayrollManagement.Visible = True
        Else
            MdiCoffeeCup.rbnPayrollManagement.Visible = False
        End If

        If EnableModuleReportGen = True Then
            MdiCoffeeCup.cmdReportGenerator.Visibility = BarItemVisibility.Always
            MdiCoffeeCup.cmdReportDeveloper.Visibility = BarItemVisibility.Always
        Else
            MdiCoffeeCup.cmdReportGenerator.Visibility = BarItemVisibility.Never
            MdiCoffeeCup.cmdReportDeveloper.Visibility = BarItemVisibility.Never
        End If

    End Sub

    Public Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
        Return nics(0).GetPhysicalAddress.ToString
    End Function

End Module
