Module DepedTemplate
    Public Sub GenerateStockoutDepedTemplate(ByVal office As String, ByVal txtbatchcode As String, ByVal daterequest As Date, ByVal requestby As String, ByVal remarks As String, ByVal form As Form)
        Dim details As String = "" : Dim TableRow As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0 : Dim extraRow As String = ""
        CreateHTMLReportTemplate("StockoutDepedTemplate.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\StockoutDepedTemplate.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\STOCKOUT\" & txtbatchcode & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        Dim totalrow As Integer = 29
        com.CommandText = "Select *, (select ITEMNAME from tblglobalproducts where PRODUCTID=tblstockoutitem.PRODUCTID) as 'productname',(select stockref from tblinventory where trnid  = tblstockoutitem.refcode) as stockref, " _
            + " (select quantity from tblinventory where trnid  = tblstockoutitem.refcode) as 'remainingquantity' from tblstockoutitem where batchcode='" & txtbatchcode & "' " : rst = com.ExecuteReader
        details = "<table border='1' style='width:700px; margin:3px 0' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'>  "
        details += "<tr> " _
                    + " <td colspan='3' align='center'><font size='4'>REQUISITION</font></td> " _
                    + " <td colspan='3' align='center'>Stock Available</td> " _
                    + " <td colspan='2' align='center'>Issue</td>" _
                    + " </tr>"
        details += "<tr> " _
                           + " <th align='center'>Stock #</td> " _
                           + " <th align='center'>Unit</td> " _
                           + " <th align='left'>DESCRIPTION</td> " _
                           + " <th align='center'>Quantity</td> " _
                           + " <th align='center'>YES</td> " _
                           + " <th align='center'>NO</td> " _
                           + " <th align='center'>Quantity</td> " _
                           + " <th align='right'>PRICE</td> " _
                     + " </tr> " & Chr(13)
        While rst.Read
            TableRow += "<tr> " _
                           + " <td align='center'>" & rst("stockref").ToString & "</td> " _
                           + " <td align='left'>" & rst("Unit").ToString & "</td> " _
                           + " <td align='left'>" & StrConv(rst("productname").ToString, vbProperCase) & "</td> " _
                           + " <td align='center'>" & rst("remainingquantity").ToString & "</td> " _
                           + " <td align='center'></td> " _
                           + " <td align='center'></td> " _
                           + " <td align='center'>" & rst("quantity").ToString & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("purchasedprice").ToString, 2) & "</td> " _
                     + " </tr> " & Chr(13)
            totalrow = totalrow - 1
        End While
        rst.Close()
        TableRow += "<tr> " _
                       + " <td align='center'>&nbsp;</td> " _
                       + " <td align='center'>&nbsp;</td> " _
                       + " <td align='center'>*** NOTHING FOLLOWS ***</td> " _
                       + " <td align='center'>&nbsp;</td> " _
                       + " <td align='center'>&nbsp;</td> " _
                       + " <td align='center'>&nbsp;</td> " _
                       + " <td align='center'>&nbsp;</td> " _
                       + " <td align='center'>&nbsp;</td> " _
                 + " </tr> " & Chr(13)
        For I = 0 To totalrow
            extraRow += "<tr> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                     + " </tr> " & Chr(13)
        Next
        Dim Purpose As String = ""
        Purpose += "<tr> " _
                           + " <td align='left' colspan='8'>PURPOSE : " & remarks & " </td> " _
                     + " </tr> " & Chr(13)

        TableTransaction = details + TableRow + extraRow + Purpose
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[office]", office), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[risno]", Now.ToString("yyyy-MM").ToString & "-" & txtbatchcode), False)

        com.CommandText = "select * from tblaccounts where accountid='" & requestby & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[requestby]", UCase(rst("fullname").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[requestbyposition]", UCase(rst("designation").ToString)), False)
        End While
        rst.Close()

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[issuedby]", UCase(AppApprovedName)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[issuedbyposition]", UCase(AppApprovedPosition)), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[daterequest]", CDate(daterequest).ToString("MMMM dd, yyyy")), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dateprint]", CDate(Now).ToString("MMMM dd, yyyy")), False)


        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateInventoryDepedTemplate(ByVal datereport As String, ByVal query As String, ByVal form As Form)
        Dim details As String = "" : Dim TableRow As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0 : Dim extraRow As String = ""
        CreateHTMLReportTemplate("InventoryDepedTemplate.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\InventoryDepedTemplate.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\INVENTORY\" & RemoveSpecialCharacter(datereport) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        Dim totalrow As Integer = 22
        com.CommandText = query : rst = com.ExecuteReader
        details = "<table id='tbl' border='1' style='width:900px; margin:3px 0' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'>  "
        details += "<tr> " _
                           + " <th align='center'>ARTICLE</th> " _
                           + " <th align='center'>STOCK</br>NUMBER</th> " _
                           + " <th align='center'>UNIT OF</br>MEASURE</th> " _
                           + " <th align='center'>UNIT</br>VALUE</td> " _
                           + " <th align='center'>BALANCE</br>PER CARD</br>(Quantity)</th> " _
                           + " <th align='center'>ON HAND</br>PER COUNT</br>(Quantity)</th> " _
                           + " <th align='center' colspan='2'>SHORTAGE/OVERAGES</th> " _
                           + " <th align='center'>REMARKS</th> " _
                     + " </tr> " & Chr(13)

        While rst.Read
            TableRow += "<tr> " _
                          + " <td align='left'  width='300'>" & StrConv(rst("productname").ToString, vbProperCase) & "</td> " _
                           + " <td align='center'>" & rst("stockref").ToString & "</td> " _
                           + " <td align='center'>" & rst("Unit").ToString & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("purchasedprice").ToString, 2) & "</td> " _
                           + " <td align='center'>" & rst("quantity").ToString & "</td> " _
                           + " <td align='center'></td> " _
                           + " <td align='center'></td> " _
                           + " <td align='center'></td> " _
                           + " <td align='center' width='200'>Unused office supplies</td> " _
                     + " </tr> " & Chr(13)
            totalrow = totalrow - 1
        End While
        rst.Close()

        For I = 0 To totalrow
            extraRow += "<tr> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                            + " <td align='center'>&nbsp;</td> " _
                     + " </tr> " & Chr(13)
        Next
        TableTransaction = details + TableRow + extraRow
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date report]", CDate(datereport).ToString("MMMM dd, yyyy")), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvedby]", UCase(AppApprovedName)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvedbyposition]", UCase(AppApprovedPosition)), False)


        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateInventoryLedgerDeped(ByVal officeid As String, ByVal itemid As String, ByVal date_from As String, ByVal date_to As String, ByVal form As Form)
        Dim details As String = "" : Dim TableRow As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0 : Dim extraRow As String = ""
        CreateHTMLReportTemplate("InventoryLedgerDepedTemplate.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\InventoryLedgerDepedTemplate.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\INVENTORY\" & RemoveSpecialCharacter(itemid) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        Dim totalrow As Integer = 50
        com.CommandText = "select a.*, date_format(a.datetrn, '%Y-%m-%d') as 'datetrans', " _
                        + " a.remarks as 'Remarks', " _
                        + " a.debit as 'StockIn', " _
                        + " a.credit as 'StockOut', " _
                        + " (SELECT SUM(COALESCE(debit,0) - COALESCE(credit,0)) FROM tblinventoryledger as b " _
                        + " WHERE b.id <= a.id and b.officeid=a.officeid and b.productid=a.productid) AS 'Balance',trntype as 'Transaction Type', trnby as 'Transaction By', " _
                        + " ifnull((select officename from tblcompoffice where officeid=a.reqoffice),(select companyname from tblglobalvendor where vendorid=a.reqoffice)) as 'RequestingParty' " _
                        + " FROM tblinventoryledger as a where a.officeid='" & officeid & "' and a.productid='" & itemid & "' and date_format(a.datetrn, '%Y-%m-%d') between '" & date_from & "' and '" & date_to & "' order by a.id asc" : rst = com.ExecuteReader
        details = "<table id='tbl' border='1' style='width:700px; margin:3px 0' cellpadding='4' cellspacing='0' style='border-collapse:collapse; font-size:7px'>  "
        details += "<tr> " _
                           + " <th align='center'>DATE<br/>RECEIVED<br/>OR ISSUED</th> " _
                           + " <th align='center'>DELIVERY<br/>RECEIPT NO./<br/>INVOICE NO.</th> " _
                           + " <th align='center'>SICR NO./<br/>P.O. NO.</th> " _
                           + " <th align='center'>FROM WHOM RECEIVED OR<br/>TO WHOM ISSUED</td> " _
                           + " <th align='center'>QUANTITY<br/>RECEIVED</th> " _
                           + " <th align='center'>QUANTITY<br/>ISSUED</th> " _
                           + " <th align='center'>QUANTITY<br/>ON HAND</th> " _
                           + " <th align='center'>PRICE PER<br/>P.O./P.L.</th> " _
                           + " <th align='center'>REMARKS</th> " _
                     + " </tr> " & Chr(13)

        While rst.Read
            TableRow += "<tr> " _
                           + " <td align='center'>" & rst("datetrans").ToString & "</td> " _
                           + " <td align='center'>" & rst("invoiceno").ToString & "</td> " _
                           + " <td align='center'>" & rst("referenceno").ToString & "</td> " _
                           + " <td align='center'>" & rst("RequestingParty").ToString & "</td> " _
                           + " <td align='center'>" & rst("StockIn").ToString & "</td> " _
                           + " <td align='center'>" & rst("StockOut").ToString & "</td> " _
                           + " <td align='center'>" & rst("Balance").ToString & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("cost").ToString, 2) & "</td> " _
                           + " <td>" & rst("remarks").ToString & "</td> " _
                        + " </tr> " & Chr(13)
            totalrow = totalrow - 1
        End While
        rst.Close()

        For I = 0 To totalrow
            extraRow += "<tr> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                            + " <td align='center'>&nbsp;</td> " _
                     + " </tr> " & Chr(13)
        Next
        extraRow += "<tr> " _
                           + " <td align='center' colspan='4'>BALANCE CARRIED FORWARD</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                            + " <td align='center'>&nbsp;</td> " _
                     + " </tr> " & Chr(13)
        TableTransaction = details + TableRow + extraRow
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)
        com.CommandText = "select *, sum(quantity) as quan,(select officename from tblcompoffice where officeid=tblinventory.officeid) as office from tblinventory where officeid='" & officeid & "' and productid='" & itemid & "' and quantity>0 group by productid" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[productname]", UCase(rst("productname").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[quantity]", UCase(rst("quan").ToString)), False)
        End While
        rst.Close()

        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateDepedRSMITemplate(ByVal datereport As String, ByVal filterasof As String, ByVal form As Form)
        Dim details As String = "" : Dim TableRow As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0 : Dim extraRow As String = ""
        CreateHTMLReportTemplate("DepedRSMI.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\DepedRSMI.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\INVENTORY\DepedRSMI " & RemoveSpecialCharacter(datereport) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        Dim totalrow As Integer = 22
        com.CommandText = "select *,  concat(date_format(datestockout,'%Y-%m'),'-',tblstockoutbatch.batchcode) as 'ris', '' as 'CenterCode',(select stockref from tblinventory where trnid=tblstockoutitem.refcode) as 'StockNo', " _
            + " (select itemname from tblglobalproducts where productid=tblstockoutitem.productid) as 'ITEM',Unit,quantity, purchasedprice,purchasedprice*quantity as 'Amount'  from tblstockoutitem inner join tblstockoutbatch on tblstockoutbatch.batchcode = tblstockoutitem.batchcode " & filterasof & " and cancelled=0 order by datestockout asc" : rst = com.ExecuteReader
        details = "<table id='tbl' border='1' style='width:700px; margin:3px 0' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'>  "
        details += "<tr> " _
                           + " <th align='center' width='75'>RIS No.</th> " _
                           + " <th align='center'>Center Code</th> " _
                           + " <th align='center'>Stock</br>No.</th> " _
                           + " <th align='center'>ITEM</td> " _
                           + " <th align='center'>Unit</th> " _
                           + " <th align='center'>Qty</br>Issued</th> " _
                           + " <th align='center'>Unit Cost</th> " _
                           + " <th align='center'>Amount</th> " _
                     + " </tr> " & Chr(13)

        While rst.Read
            TableRow += "<tr> " _
                          + " <td align='center'>" & StrConv(rst("ris").ToString, vbProperCase) & "</td> " _
                           + " <td align='center'>" & rst("CenterCode").ToString & "</td> " _
                           + " <td align='center'>" & rst("StockNo").ToString & "</td> " _
                           + " <td align='left'>" & rst("ITEM").ToString & "</td> " _
                           + " <td align='center'>" & rst("Unit").ToString & "</td> " _
                           + " <td align='center'>" & rst("quantity").ToString & "</td> " _
                           + " <td align='center'>" & FormatNumber(rst("purchasedprice").ToString, 2) & "</td> " _
                           + " <td align='center'>" & FormatNumber(rst("Amount").ToString, 2) & "</td> " _
                     + " </tr> " & Chr(13)
            totalrow = totalrow - 1
        End While
        rst.Close()

        'For I = 0 To totalrow
        '    extraRow += "<tr> " _
        '                   + " <td align='center'>&nbsp;</td> " _
        '                   + " <td align='center'>&nbsp;</td> " _
        '                   + " <td align='center'>&nbsp;</td> " _
        '                   + " <td align='center'>&nbsp;</td> " _
        '                   + " <td align='center'>&nbsp;</td> " _
        '                   + " <td align='center'>&nbsp;</td> " _
        '                   + " <td align='center'>&nbsp;</td> " _
        '                   + " <td align='center'>&nbsp;</td> " _
        '             + " </tr> " & Chr(13)
        'Next



        Dim details2 As String = ""
        Dim details3 As String = ""
        Dim TableRow2 As String = ""
        details2 += "<tr style='font-size:15px; padding: 10px;'> " _
                           + " <td align='center'></td> " _
                           + " <td align='center' colspan='2' style=' padding: 10px;'><strong>RECAPITULATION</strong></td> " _
                           + " <td align='center'></td> " _
                           + " <td align='center'></td> " _
                           + " <td align='center'></td> " _
                           + " <td align='center' colspan='2'><strong>RECAPITULATION</strong></td> " _
                     + " </tr> " & Chr(13)
        details2 += "<tr> " _
                   + " <td align='center'></td> " _
                   + " <td align='center'><strong>STOCK NO.</strong></td> " _
                   + " <td align='center'><strong>QUANTITY</strong></td> " _
                   + " <td align='center'></td> " _
                   + " <td align='center'></td> " _
                   + " <td align='center'><strong>UNIT</br>COST</strong></td> " _
                   + " <td align='center'><strong>TOTAL COST</strong></td> " _
                   + " <td align='center'><strong>ACCOUNT COST</strong></td> " _
             + " </tr> " & Chr(13)
        com.CommandText = "select refcode as 'StockNo',(select itemname from tblglobalproducts where productid=tblstockoutitem.productid) as 'ITEM',Unit, sum(quantity) as qty, purchasedprice,purchasedprice*sum(quantity) as 'Amount'  from tblstockoutitem inner join tblstockoutbatch on tblstockoutbatch.batchcode = tblstockoutitem.batchcode " & filterasof & " group by productid order by (select itemname from tblglobalproducts where productid=tblstockoutitem.productid) asc" : rst = com.ExecuteReader
        While rst.Read
            TableRow2 += "<tr> " _
                          + " <td align='center'></td> " _
                           + " <td align='center'>" & rst("StockNo").ToString & "</td> " _
                           + " <td align='center'>" & rst("qty").ToString & "</td> " _
                           + " <td align='left'>" & rst("ITEM").ToString & "</td> " _
                           + " <td align='center'>" & rst("Unit").ToString & "</td> " _
                           + " <td align='center'>" & FormatNumber(rst("purchasedprice").ToString, 2) & "</td> " _
                           + " <td align='center'>" & FormatNumber(rst("Amount").ToString, 2) & "</td> " _
                           + " <td align='center'></td> " _
                     + " </tr> " & Chr(13)
        End While
        rst.Close()

        details3 += "<tr> " _
                 + " <td align='center'></td> " _
                 + " <td align='center'></td> " _
                 + " <td align='center'></td> " _
                 + " <td align='left'><strong>BALANCE FORWARDED</strong></td> " _
                 + " <td align='center'></td> " _
                 + " <td align='center'></td> " _
                 + " <td align='center'></td> " _
                 + " <td align='center'></td> " _
           + " </tr> " & Chr(13)
        details3 += "<tr style='font-size:15px; padding: 10px;'> " _
                + " <td align='center' colspan='4'>I HEREBY CERTIFY TO THE CORRECTION OF THE ABOVE INFORMATION.</td> " _
                + " <td align='center'></td> " _
                + " <td align='center'></td> " _
                + " <td align='center'></td> " _
                + " <td align='center'></td> " _
          + " </tr> " & Chr(13)

        details3 += "<tr style='font-size:15px; padding: 10px;'> " _
               + " <td align='center' colspan='5'></br></br><u><b>NARLYN Z. MENDOZA</b></u> </br> Administrative Officer IV</td> " _
               + " <td align='center' colspan='3'>POSTED BY DATE: </br></br>________________________</br>ACCOUNTING CLERK</td> " _
         + " </tr> " & Chr(13)

        TableTransaction = details + TableRow + details2 + TableRow2 + details3 + "</table>"
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", CDate(datereport).ToString("MMMM, yyyy")), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvedby]", UCase(AppApprovedName)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvedbyposition]", UCase(AppApprovedPosition)), False)


        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

End Module
