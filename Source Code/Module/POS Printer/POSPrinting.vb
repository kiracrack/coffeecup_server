Module POSPrinting
    'Public Sub POSPrintPurchaseOrder(ByVal ponumber As String)
    '    Dim details As String = ""
    '    details = PageHeader()
    '    details += Environment.NewLine & PrintCenterText("PURCHASE ORDER") & Environment.NewLine & Environment.NewLine
    '    com.CommandText = "select *,(select officename from tblcompoffice where officeid=tblpurchaseorder.officeid) as office from tblpurchaseorder where ponumber='" & ponumber & "'" : rst = com.ExecuteReader
    '    While rst.Read
    '        details += PrintLeftText("PO Number:" & rst("ponumber").ToString) & Environment.NewLine
    '        details += PrintLeftText("Office:" & rst("office").ToString) & Environment.NewLine
    '        details += PrintLeftText("Office:" & rst("office").ToString) & Environment.NewLine
    '    End While
    '    details += PrintCenterText("END OF PRODUCT LIST")
    '    POSPrint(details, getGlobalTrnid("p", "d"), "Product")
    'End Sub
End Module
