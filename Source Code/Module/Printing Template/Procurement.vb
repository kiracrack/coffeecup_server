Module Procurement
    Public Sub PrintDisbursementVoucher(ByVal vouchercode As String, ByVal form As Form, ByVal PrintFile As Boolean)
        Dim TableRow As String = "" : Dim picbox As New PictureBox
        Dim Template As String = Application.StartupPath.ToString & "\Templates\DisbursementVoucherTemplate.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\VOUCHER\" & vouchercode & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If

        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        Dim supplierid As String = "" : Dim direct As Boolean = False : Dim ca As Boolean = False : Dim note As String = "" : Dim approved As Boolean = False
        If System.IO.File.Exists(Application.StartupPath.ToString & "\img\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<div align='center'><img  style='float: left' src='" & Application.StartupPath.ToString & "\img\logo.png'></div>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeaderGeneral()), False)
        com.CommandText = "select *,(select companyname from tblcompany where code=tbldisbursementvoucher.companyid) as 'Company',(select digitalsign from tblaccounts where accountid=tbldisbursementvoucher.trnby) as signature, date_format(voucherdate,'%M %d, %Y') as trndate,(select accountname from tblbankaccounts where bankcode=tbldisbursementvoucher.sourcefund) as fund, (select companyname from tblglobalvendor where vendorid=tbldisbursementvoucher.vendorid) as vendor from tbldisbursementvoucher where voucherno='" & vouchercode & "'" : rst = com.ExecuteReader
        While rst.Read
            supplierid = rst("vendorid").ToString : direct = CBool(rst("directexpense").ToString) : ca = CBool(rst("ca").ToString) : note = rst("note").ToString : approved = CBool(rst("verified"))
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucherno]", rst("voucherno").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[companyname]", rst("Company").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucherdate]", rst("trndate").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[check_payment]", If(CBool(rst("check").ToString) = True, "checked='yes'", "")), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cash_payment]", If(CBool(rst("cash").ToString) = True, "checked='yes'", "")), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cash_advance]", If(CBool(rst("ca").ToString) = True, "checked='yes'", "")), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checkno]", If(CBool(rst("check").ToString) = True, rst("checkno").ToString, "")), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[bankname]", If(CBool(rst("check").ToString) = True, rst("fund").ToString, "")), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checkdate]", If(CBool(rst("check").ToString) = True, rst("checkdate").ToString, "")), False)

            'Prepared Signatories
            picbox.Image = Nothing
            ConvertDatabaseImage("signature", picbox)
            If Not picbox.Image Is Nothing Then
                If System.IO.File.Exists(Application.StartupPath.ToString & "\Templates\" & globaluserid & ".png") = True Then
                    System.IO.File.Delete(Application.StartupPath.ToString & "\Templates\" & globaluserid & ".png")
                End If
                picbox.Image.Save(Application.StartupPath.ToString & "\Templates\" & globaluserid & ".png", System.Drawing.Imaging.ImageFormat.Png)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[preparedsig]", "<img src='" & Application.StartupPath.ToString & "\Templates\" & globaluserid & ".png' style='width: 200px;'>"), False)
            Else
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[preparedsig]", "<br/><br/><br/>"), False)
            End If

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[preparedby]", "[ " & UCase(globalfullname) & " ]"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[preparedposition]", StrConv(globaldesignation, VbStrConv.ProperCase)), False)

        End While
        rst.Close()

        'supplier
        If ca = True Then
            com.CommandText = "select *,(select officename from tblcompoffice where officeid=tblaccounts.officeid) as office from tblaccounts where accountid='" & supplierid & "'" : rst = com.ExecuteReader
            While rst.Read
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[suppliername]", "[ " & rst("fullname").ToString & " ]"), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[supplieraddress]", rst("office").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[suppliertitle]", "Department"), False)
            End While
            rst.Close()
        Else
            com.CommandText = "select * from tblglobalvendor where vendorid='" & supplierid & "'" : rst = com.ExecuteReader
            While rst.Read
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[suppliername]", rst("companyname").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[supplieraddress]", rst("compadd").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[suppliertitle]", "Address"), False)
            End While
            rst.Close()
        End If


        'Voucher Item
        TableRow = "" : Dim total As Double = 0 : Dim cnt As Integer = 0
        If direct = True Then
            TableRow += "<tr> " _
                  + " <td style='padding: 5px' align='center' width='15%'><b>Date</b></td> " _
                  + " <td style='padding: 5px' align='center' ><b>Particular</b></td>" _
                  + " <td style='padding: 5px' align='center' ><b>Note</b></td> " _
                  + "<td style='padding: 5px' align='center' width='15%'><b>Invoice No</b></td>" _
                  + " <td style='padding: 5px' align='right'  width='18%'><b>Amount</b></td> " _
              + " </tr>"

            com.CommandText = "select *,date_format(datetrn,'%Y-%m-%d') as 'Date',(select itemname from tblglitem where itemcode=tbldisbursementexpense.itemcode and companyid=tbldisbursementexpense.companyid) as item from tbldisbursementexpense where voucherno='" & vouchercode & "' order by datetrn asc" : rst = com.ExecuteReader
            While rst.Read
                TableRow += "<tr> " _
                               + " <td align='center' style='padding: 5px' >" & rst("date").ToString & "</td> " _
                               + " <td>" & StrConv(rst("item").ToString, VbStrConv.ProperCase) & "</td> " _
                               + " <td>" & rst("remarks").ToString & "</td> " _
                               + " <td align='center'>" & rst("invoiceno").ToString & "</td> " _
                               + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                         + " </tr> " & Chr(13)
                total += Val(rst("amount").ToString)
                cnt += 1
            End While
            rst.Close()
        Else
            TableRow += "<tr> " _
                + " <td style='padding: 5px' align='center' width='15%'><b>Date</b></td> " _
                + If(ca = True, "<td style='padding: 5px' align='center' ><b>Supplier</b></td>", "") _
                + " <td style='padding: 5px' align='center' width='15%'><b>PO Number</b></td> " _
                + " <td style='padding: 5px' align='center' ><b>Note</b></td> " _
                + If(ca = True, "", "<td style='padding: 5px' align='center' width='15%'><b>Invoice No</b></td>") _
                + " <td style='padding: 5px' align='right'  width='18%'><b>Amount</b></td> " _
            + " </tr>"
            com.CommandText = "select Supplier, ponumber as 'PO Number', if(forpo=1,'Purchase Order','Payment Request') as 'Description', date_format(datetrn,'%Y-%m-%d') as 'Date', invoiceno, amount,Note from tbldisbursementdetails where voucherno='" & vouchercode & "' order by datetrn asc" : rst = com.ExecuteReader
            While rst.Read
                TableRow += "<tr> " _
                               + " <td align='center'>" & rst("date").ToString & "</td> " _
                               + If(ca = True, "<td style='padding: 5px'>" & StrConv(rst("Supplier").ToString, VbStrConv.ProperCase) & "</td>", "") _
                               + " <td align='center'>" & rst("PO Number").ToString & "</td> " _
                               + " <td>" & If(rst("Note").ToString = "", "Purchase Order", rst("Note").ToString) & "</td> " _
                                + If(ca = True, "", "<td align='center'>" & rst("invoiceno").ToString & "</td>") _
                               + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                         + " </tr> " & Chr(13)
                total += Val(rst("amount").ToString)
                cnt += 1
            End While
            rst.Close()

            com.CommandText = "select *,date_format(datetrn,'%Y-%m-%d') as 'Date',(select itemname from tblglitem where itemcode=tbldisbursementexpense.itemcode and companyid=tbldisbursementexpense.companyid) as item from tbldisbursementexpense where voucherno='" & vouchercode & "' order by datetrn asc" : rst = com.ExecuteReader
            While rst.Read
                TableRow += "<tr> " _
                               + " <td align='center' style='padding: 5px' >" & rst("date").ToString & "</td> " _
                               + " <td>&nbsp;</td> " _
                               + " <td>" & StrConv(rst("item").ToString, VbStrConv.ProperCase) & " - " & rst("remarks").ToString & "</td> " _
                               + " <td align='center'>" & rst("invoiceno").ToString & "</td> " _
                               + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                         + " </tr> " & Chr(13)
                total += Val(rst("amount").ToString)
                cnt += 1
            End While
            rst.Close()
        End If
     
     

        For I = 0 To 6 - cnt
            TableRow += "<tr> " _
                         + " <td style='padding: 5px' >&nbsp;</td> " _
                         + " <td>&nbsp;</td> " _
                         + " <td>&nbsp;</td> " _
                         + " <td>&nbsp;</td> " _
                         + " <td>&nbsp;</td> " _
                   + " </tr> " & Chr(13)
        Next
        TableRow += "<tr> " _
                       + " <td colspan='4' style='padding:5px'><span style='vertical-align: top; float:left; font-size: 12px;'>Amount in words:</span><br/><b>" & StrConv(ConvertCurrencyToEnglish(total), VbStrConv.Uppercase) & "</b></td> " _
                       + " <td align='right' style='padding:5px; font-weight:bold;font-size: 14px;'>" & FormatNumber(total, 2) & "</td> " _
                 + " </tr> " & Chr(13)

        If note.Length > 5 Then
            TableRow += "<tr> " _
                      + " <td colspan='5' style='padding:5px'>NOTE: " & note & "</td> " _
                + " </tr> " & Chr(13)
        End If

        If TableRow.Length > 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucher_item]", TableRow), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucher_item]", ""), False)
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[total]", FormatNumber(total, 2)), False)

        'Prepared Signatories
        If GLobalEnableElectronicVoucher = True Then
            'fill the signatory name
            com.CommandText = "SELECT *,left(applevel,1) as level,(select digitalsign from tblaccounts where accountid=a.authorizedid) as signature,(select fullname from tblaccounts where accountid=a.authorizedid) as name,(select designation from tblaccounts where accountid=a.authorizedid) as position FROM `tblapprovermainprocess` as a where authorizedid not in (select confirmid FROM `tblapprovalhistory` where referenceno='" & vouchercode & "' and approvaltype='voucher' and applevel<>'-') and apptype='voucher-signatories' and customized=0 order by left(applevel,1) asc;" : rst = com.ExecuteReader
            While rst.Read
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approversig" & rst("level").ToString & "]", "<br/><br/><br/>"), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvertitle" & rst("level").ToString & "]", rst("apptitle").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvername" & rst("level").ToString & "]", "[ " & UCase(rst("name").ToString) & " ]"), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approverposition" & rst("level").ToString & "]", StrConv(rst("position").ToString, VbStrConv.ProperCase)), False)
            End While
            rst.Close()

            'fill the approved name
            com.CommandText = "SELECT *,left(applevel,1) as level,(select digitalsign from tblaccounts where accountid=a.confirmid) as signature, confirmby as name,position FROM `tblapprovalhistory` as a where referenceno='" & vouchercode & "' and approvaltype='voucher' and applevel<>'-' and status='approved' order by left(applevel,1) asc;" : rst = com.ExecuteReader
            While rst.Read
                picbox.Image = Nothing
                ConvertDatabaseImage("signature", picbox)
                If Not picbox.Image Is Nothing Then
                    If System.IO.File.Exists(Application.StartupPath.ToString & "\Templates\" & rst("confirmid").ToString & ".png") = True Then
                        System.IO.File.Delete(Application.StartupPath.ToString & "\Templates\" & rst("confirmid").ToString & ".png")
                    End If
                    picbox.Image = CropImageHeight(picbox.Image)
                    picbox.Image.Save(Application.StartupPath.ToString & "\Templates\" & rst("confirmid").ToString & ".png", System.Drawing.Imaging.ImageFormat.Png)
                    My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approversig" & rst("level").ToString & "]", "<img src='" & Application.StartupPath.ToString & "\Templates\" & rst("confirmid").ToString & ".png' style='width: 200px;'>"), False)
                Else
                    My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approversig" & rst("level").ToString & "]", "<br/><br/><br/>"), False)
                End If

                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvertitle" & rst("level").ToString & "]", rst("apptitle").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvername" & rst("level").ToString & "]", "[ " & UCase(rst("name").ToString) & " ]"), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approverposition" & rst("level").ToString & "]", StrConv(rst("position").ToString, VbStrConv.ProperCase)), False)
            End While
            rst.Close()
        Else
            com.CommandText = "SELECT *,left(applevel,1) as level,(select digitalsign from tblaccounts where accountid=a.authorizedid) as signature,(select fullname from tblaccounts where accountid=a.authorizedid) as name,(select designation from tblaccounts where accountid=a.authorizedid) as position FROM `tblapprovermainprocess` as a where apptype='voucher-signatories' and customized=0 order by left(applevel,1) asc;" : rst = com.ExecuteReader
            While rst.Read
                picbox.Image = Nothing
                ConvertDatabaseImage("signature", picbox)
                If Not picbox.Image Is Nothing Then
                    If approved = True Then
                        If System.IO.File.Exists(Application.StartupPath.ToString & "\Templates\" & rst("authorizedid").ToString & ".png") = True Then
                            System.IO.File.Delete(Application.StartupPath.ToString & "\Templates\" & rst("authorizedid").ToString & ".png")
                        End If
                        picbox.Image = CropImageHeight(picbox.Image)
                        picbox.Image.Save(Application.StartupPath.ToString & "\Templates\" & rst("authorizedid").ToString & ".png", System.Drawing.Imaging.ImageFormat.Png)
                        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approversig" & rst("level").ToString & "]", "<img src='" & Application.StartupPath.ToString & "\Templates\" & rst("authorizedid").ToString & ".png' style='width: 200px;'>"), False)
                    Else
                        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approversig" & rst("level").ToString & "]", "<br/><br/><br/>"), False)
                    End If
                Else
                    My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approversig" & rst("level").ToString & "]", "<br/><br/><br/>"), False)
                End If

                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvertitle" & rst("level").ToString & "]", rst("apptitle").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvername" & rst("level").ToString & "]", "[ " & UCase(rst("name").ToString) & " ]"), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approverposition" & rst("level").ToString & "]", StrConv(rst("position").ToString, VbStrConv.ProperCase)), False)
            End While
            rst.Close()
        End If
        If PrintFile = True Then
            PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
        Else
            SavePDFCopy(SaveLocation, Application.StartupPath.ToString & "\Transaction\VOUCHER\Voucher " & vouchercode & ".pdf")
        End If
    End Sub


    Public Sub PrintAccountingDisbursementVoucher(ByVal vouchercode As String, ByVal form As Form)
        Dim PayableROw As String = "" : Dim AccountingRow As String = "" : Dim picbox As New PictureBox
        Dim Template As String = Application.StartupPath.ToString & "\Templates\DisbursementVoucherAccounting.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\VOUCHER\" & vouchercode & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If

        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        com.CommandText = "select *,(select companyname from tblcompany where code=a.companyid) as 'Company',  date_format(voucherdate,'%M %d, %Y') as trndate, " _
            + " (select companyname from tblglobalvendor where vendorid=a.vendorid) as vendor, " _
            + " (select compadd from tblglobalvendor where vendorid=a.vendorid) as address, " _
            + " (select fullname from tblaccounts where accountid=a.trnby) as trnname, " _
            + " (select designation from tblaccounts where accountid=a.trnby) as trnposition " _
            + "  from tbldisbursementvoucher as a where voucherno='" & vouchercode & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[companyname]", rst("Company").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucherno]", rst("voucherno").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[suppliername]", rst("vendor").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[supplieraddress]", rst("address").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucherdate]", rst("trndate").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[clasification]", If(CBool(rst("check").ToString) = True, "CHECK DISBURSEMENT VOUCHER", "CASH DISBURSEMENT VOUCHER")), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[totalamount]", FormatNumber(Val(rst("amount").ToString), 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[amountinwords]", NumToWords(Val(rst("amount").ToString))), False)

            'Prepared Signatories
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[preparedby]", UCase(rst("trnname").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[preparedposition]", StrConv(rst("trnposition").ToString, VbStrConv.ProperCase)), False)

        End While
        rst.Close()

        'Voucher Item
        PayableROw = "" : Dim cnt As Integer = 0
        com.CommandText = "select *,date_format(datetrn,'%M %d, %Y') as dt from tbldisbursementdetails where voucherno='" & vouchercode & "' order by id asc" : rst = com.ExecuteReader
        While rst.Read
            PayableROw += "<tr><td align='center'>" & rst("dt").ToString & "</td><td>" & rst("description").ToString & "</td><td>" & rst("Note").ToString & "</td><td align='center'>" & rst("invoiceno").ToString & "</td><td align='right'>" & FormatNumber(rst("amount"), 2) & "</td></tr> " & Chr(13)
            cnt += 1
        End While
        rst.Close()

        For I = 0 To 10 - cnt
            PayableROw += "<tr><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr>" & Chr(13)
        Next
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[payable_item]", PayableROw), False)


        'accounting
        Dim cnt2 As Integer = 0
        com.CommandText = "select * from tblgljournalitems where ticketno='" & vouchercode & "' order by id asc" : rst = com.ExecuteReader
        While rst.Read
            AccountingRow += "<tr><td>" & rst("itemname").ToString & "</td><td align='right'>" & FormatNumber(rst("debitamount"), 2) & "</td><td align='right'>" & FormatNumber(rst("creditamount"), 2) & "</td></tr> " & Chr(13)
            cnt2 += 1
        End While
        rst.Close()

        For I = 0 To 3 - cnt2
            AccountingRow += "<tr><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr>" & Chr(13)
        Next
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[accounting_item]", AccountingRow), False)


        com.CommandText = "SELECT *,left(applevel,1) as level,(select digitalsign from tblaccounts where accountid=a.authorizedid) as signature,(select fullname from tblaccounts where accountid=a.authorizedid) as name, " _
            + " (select designation from tblaccounts where accountid=a.authorizedid) as position FROM `tblapprovermainprocess` as a where apptype='voucher-signatories' and customized=0 order by left(applevel,1) asc;" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvertitle" & rst("level").ToString & "]", rst("apptitle").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvername" & rst("level").ToString & "]", UCase(rst("name").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approverposition" & rst("level").ToString & "]", StrConv(rst("position").ToString, VbStrConv.ProperCase)), False)
        End While
        rst.Close()
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub PrintLiquidationReport(ByVal vouchercode As String, ByVal form As Form, ByVal PrintFile As Boolean)
        Dim TableRow As String = "" : Dim picbox As New PictureBox
        Dim Template As String = Application.StartupPath.ToString & "\Templates\DisbursementLiquidation.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\LIQUIDITION\" & vouchercode & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If

        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        Dim supplierid As String = "" : Dim ca As Boolean = False
        If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<div align='center'><img  style='float: left' src='" & Application.StartupPath.ToString & "\Logo\logo.png'></div>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
        com.CommandText = "select *,(select companyname from tblcompany where code=tbldisbursementvoucher.companyid) as 'Company', date_format(voucherdate,'%M %d, %Y') as trndate,date_format(dateliquidated,'%M %d, %Y') as dateliquidate from tbldisbursementvoucher where voucherno='" & vouchercode & "'" : rst = com.ExecuteReader
        While rst.Read
            supplierid = rst("vendorid").ToString : ca = CBool(rst("ca").ToString)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucherno]", rst("voucherno").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[companyname]", rst("Company").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucherdate]", rst("trndate").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", rst("dateliquidate").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[amount_voucher]", FormatNumber(Val(rst("amount").ToString), 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[amount_spent]", FormatNumber(Val(rst("amountspend").ToString), 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[amount_refund]", FormatNumber(Val(rst("amountrefunded").ToString), 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[amount_reimbursed]", FormatNumber(Val(rst("amountreimbursed").ToString), 2)), False)
        End While
        rst.Close()

        'supplier
        If ca = True Then
            com.CommandText = "select *,(select officename from tblcompoffice where officeid=tblaccounts.officeid) as office from tblaccounts where accountid='" & supplierid & "'" : rst = com.ExecuteReader
            While rst.Read
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[claimant]", rst("fullname").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[position]", rst("designation").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[department]", rst("office").ToString), False)
            End While
            rst.Close()
        End If


        'Voucher Item
        TableRow = "" : Dim total As Double = 0 : Dim cnt As Integer = 0
        TableRow += "<tr> " _
                    + " <td style='padding: 5px' align='center' width='15%'><b>Date</b></td> " _
                    + " <td style='padding: 5px' align='center' ><b>Supplier</b></td>" _
                    + " <td style='padding: 5px' align='center' width='15%'><b>PO Number</b></td> " _
                    + " <td style='padding: 5px' align='center' width='15%'><b>Invoice No</b></td>" _
                    + " <td style='padding: 5px' align='right'  width='18%'><b>Actual Spend</b></td> " _
                + " </tr>"
        com.CommandText = "select *,date_format(datetrn,'%Y-%m-%d') as 'Date',(select companyname from tblglobalvendor where vendorid=tblpurchaseorder.vendorid) as 'Supplier' from tblpurchaseorder where paymentrefnumber='" & vouchercode & "' order by datetrn asc" : rst = com.ExecuteReader
        While rst.Read
            TableRow += "<tr> " _
                           + " <td align='center'>" & rst("date").ToString & "</td> " _
                           + " <td style='padding: 5px'>" & StrConv(rst("Supplier").ToString, VbStrConv.ProperCase) & "</td>" _
                           + " <td align='center'>" & rst("ponumber").ToString & "</td> " _
                           + " <td align='center'>" & rst("invoiceno").ToString & "</td>" _
                           + " <td align='right'>" & FormatNumber(rst("totalamount").ToString, 2) & "</td> " _
                     + " </tr> " & Chr(13)
            total += Val(rst("totalamount").ToString)
            cnt += 1
        End While
        rst.Close()

        com.CommandText = "select *,date_format(datetrn,'%Y-%m-%d') as 'Date',(select itemname from tblglitem where itemcode=tbldisbursementexpense.itemcode) as item from tbldisbursementexpense where voucherno='" & vouchercode & "' order by datetrn asc" : rst = com.ExecuteReader
        While rst.Read
            TableRow += "<tr> " _
                           + " <td align='center'>" & rst("date").ToString & "</td> " _
                           + " <td style='padding: 5px' colspan='2'>" & StrConv(rst("item").ToString, VbStrConv.ProperCase) & " - " & rst("remarks").ToString & "</td>" _
                           + " <td align='center'>" & rst("invoiceno").ToString & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                     + " </tr> " & Chr(13)
            total += Val(rst("amount").ToString)
            cnt += 1
        End While
        rst.Close()

        For I = 0 To 6 - cnt
            TableRow += "<tr> " _
                         + " <td style='padding: 5px'>&nbsp;</td> " _
                         + " <td>&nbsp;</td> " _
                         + " <td>&nbsp;</td> " _
                         + " <td>&nbsp;</td> " _
                         + " <td>&nbsp;</td> " _
                   + " </tr> " & Chr(13)
        Next
        TableRow += "<tr> " _
                       + " <td colspan='4' style='padding:10px 5px'><b>" & StrConv(ConvertCurrencyToEnglish(total), VbStrConv.Uppercase) & "</b></td> " _
                       + " <td align='right' style='padding:5px; font-weight:bold;font-size: 14px;'>" & FormatNumber(total, 2) & "</td> " _
                 + " </tr> " & Chr(13)

        If TableRow.Length > 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucher_item]", TableRow), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucher_item]", ""), False)
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[total]", FormatNumber(total, 2)), False)

        If PrintFile = True Then
            PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
        End If
    End Sub

    Public Function CropImageHeight(ByVal img As Image) As Image
        CropImageHeight = Nothing
        If Not img Is Nothing Then
            Dim hg As Integer = 60
            Dim CropRect As New Rectangle(0, (img.Height / 2) - (hg / 2), 200, hg)
            Dim CropImage = New Bitmap(CropRect.Width, CropRect.Height)
            Using grp = Graphics.FromImage(CropImage)
                grp.DrawImage(img, New Rectangle(0, 0, CropRect.Width, CropRect.Height), CropRect, GraphicsUnit.Pixel)
            End Using
            CropImageHeight = CropImage
        End If
        Return CropImageHeight
    End Function

   
    Public Function SavePDFCopy(ByVal htmlfile As String, ByVal PDFfile As String)
        Dim htmlToPdf = New NReco.PdfGenerator.HtmlToPdfConverter()
        htmlToPdf.Zoom = 2
        htmlToPdf.GeneratePdfFromFile(htmlfile, Nothing, PDFfile)
        Return True
    End Function
End Module
