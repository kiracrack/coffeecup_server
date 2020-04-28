Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.Utils

Public Class frmPOSTransactionHistory
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(GridView1)
        If EnableModuleAccounting = True Then
            tabAccountingEntries.PageVisible = True
        Else
            tabAccountingEntries.PageVisible = False
        End If
        FilterOption()
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        FilterOption()
    End Sub

    Public Sub FilterOption()
        If XtraTabControl1.SelectedTabPage Is tabAccountingEntries And EnableModuleAccounting = True Then
            Em.Parent = tabAccountingEntries
            LoadSAccountingEntriesSummary()

        ElseIf XtraTabControl1.SelectedTabPage Is tabSalesSummary Then
            Em.Parent = tabSalesSummary
            LoadSalesBlotterSummary()

        ElseIf XtraTabControl1.SelectedTabPage Is tabKeyAccounts Then
            Em.Parent = tabKeyAccounts
            LoadKeyAccounts()

        ElseIf XtraTabControl1.SelectedTabPage Is tabKeyAccounts Then
            Em.Parent = tabKeyAccounts
            LoadKeyAccounts()

        ElseIf XtraTabControl1.SelectedTabPage Is tabInterOffice Then
            Em.Parent = tabInterOffice
            LoadInterOffice()

        ElseIf XtraTabControl1.SelectedTabPage Is tabCouponCharge Then
            Em.Parent = tabCouponCharge
            LoadCoupon()

        ElseIf XtraTabControl1.SelectedTabPage Is tabBatch Then
            Em.Parent = tabBatch
            LoadBatchTransaction()

        ElseIf XtraTabControl1.SelectedTabPage Is tabDetailed Then
            Em.Parent = tabDetailed
            ShowDetailTransactions()

        ElseIf XtraTabControl1.SelectedTabPage Is tabSoldProduct Then
            Em.Parent = tabSoldProduct
            ShowTotalTransactions()

        ElseIf XtraTabControl1.SelectedTabPage Is tabVoid Then
            Em.Parent = tabVoid
            ShowVoidandCancelledTransactions()

        ElseIf XtraTabControl1.SelectedTabPage Is tabExpenses Then
            Em.Parent = tabExpenses
            ShowExpenses()

        ElseIf XtraTabControl1.SelectedTabPage Is tabChargetoHotel Then
            Em.Parent = tabChargetoHotel
            ShowChargeToHotelTransaction()

        ElseIf XtraTabControl1.SelectedTabPage Is tabHotelTrn Then
            Em.Parent = tabHotelTrn
            ShowHotelTransaction()

        ElseIf XtraTabControl1.SelectedTabPage Is tabHotelPayment Then
            Em.Parent = tabHotelPayment
            ShowHotelPaymentTransaction()

        ElseIf XtraTabControl1.SelectedTabPage Is tabCheck Then
            Em.Parent = tabCheck
            ShowCheck()

        ElseIf XtraTabControl1.SelectedTabPage Is tabCard Then
            Em.Parent = tabCard
            ShowCard()

        ElseIf XtraTabControl1.SelectedTabPage Is tabOnline Then
            Em.Parent = tabOnline
            ShowOnline()

        ElseIf XtraTabControl1.SelectedTabPage Is tabVoucher Then
            Em.Parent = tabVoucher
            ShowVoucher()

        ElseIf XtraTabControl1.SelectedTabPage Is tabAccountingTicket Then
            Em.Parent = tabAccountingTicket
            ShowAccountingTicket()
        End If

        com.CommandText = "select * from tblcolumnindex where form='" & Me.Name & XtraTabControl1.SelectedTabPage.Name & "' and gridview='" & GridView1.Name & "' order by colindex asc" : rst = com.ExecuteReader
        While rst.Read
            GridView1.Columns(rst("columnname").ToString).VisibleIndex = rst("colindex")
            If Val(rst("columnwidth").ToString) > 0 Then
                GridView1.Columns(rst("columnname").ToString).Width = Val(rst("columnwidth").ToString)
            End If

        End While
        rst.Close()
        If XtraTabControl1.SelectedTabPage Is tabAccountingEntries Then
            Em.ContextMenuStrip = gridmenustrip
        Else
            Em.ContextMenuStrip = Nothing
        End If
        XgridColWrapText({"Particular", "Remarks"}, GridView1)
        SaveFilterColumn(GridView1, Me.Text & XtraTabControl1.SelectedTabPage.Name)
    End Sub


    Public Sub LoadSAccountingEntriesSummary()
        com.CommandText = "CALL sp_acct_cashier('" & globalSalesTrnCOde.Text & "',FALSE)" : com.ExecuteNonQuery()
        LoadXgrid("select ifnull((select officename from tblcompoffice where officeid=a.officeid),'Reconciling office not configured') as 'Office',ItemCode,ifnull((select itemname from tblglitem where itemcode=a.itemcode),if(itemcode='','Account title not configured','Invalid account configuration')) as 'Item Name',ReferenceNo, Explaination, Debit, Credit from tmpcashiersblotterview as a;", "tmpcashiersblotterview", Em, GridView1, Me)
        ' GridView1.Columns("Transaction Type").Group()
        XgridColCurrency({"Debit", "Credit"}, GridView1)
        XgridColWidth({"Details"}, GridView1, 350)
        XgridColWidth({"Debit", "Credit"}, GridView1, 120)
        XgridColAlign({"ReferenceNo", "ItemCode"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Debit", "Credit"}, GridView1)

    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If XtraTabControl1.SelectedTabPage Is tabAccountingEntries Then
            If View.GetRowCellDisplayText(e.RowHandle, View.Columns("Item Name")).ToString = "Account title not configured" Or View.GetRowCellDisplayText(e.RowHandle, View.Columns("Item Name")).ToString = "Invalid account configuration" Or View.GetRowCellDisplayText(e.RowHandle, View.Columns("Office")).ToString = "Reconciling office not configured" Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If
    End Sub

    Public Sub LoadSalesBlotterSummary()
        com.CommandText = "CALL sp_salesremittance('CONSOLIDATED','" & globalSalesTrnCOde.Text & "','')" : com.ExecuteNonQuery()
        LoadXgrid("select title as 'Transaction Type', details as 'Details',amount as Total from tmpconsolidateddetails where amount>0", "tmpconsolidateddetails", Em, GridView1, Me)
        GridView1.Columns("Transaction Type").Group()
        XgridColCurrency({"Total"}, GridView1)
        XgridColWidth({"Details"}, GridView1, 350)
        XgridColWidth({"Total"}, GridView1, 120)
        XgridGroupSummaryCurrency({"Total"}, GridView1)
        GridView1.ExpandAllGroups()
    End Sub

    Public Sub LoadKeyAccounts()
        LoadXgrid("CALL sp_salestransaction('INVOICE','" & globalSalesTrnCOde.Text & "',0)", "CALL sp_salestransaction('INVOICE','" & globalSalesTrnCOde.Text & "',0)", Em, GridView1, Me)
        XgridColCurrency({"Total Amount"}, GridView1)
        XgridColAlign({"Batch Code", "Invoice No."}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total Amount"}, GridView1)
    End Sub

    Public Sub LoadInterOffice()
        LoadXgrid("CALL sp_salestransaction('INTEROFFICE','" & globalSalesTrnCOde.Text & "',0)", "CALL sp_salestransaction('INTEROFFICE','" & globalSalesTrnCOde.Text & "',0)", Em, GridView1, Me)
        XgridColCurrency({"Amount Due", "Covered Amount", "Excess Amount"}, GridView1)
        XgridColAlign({"Batch Code", "Transaction No.", "Excess Cash Payment"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount Due", "Covered Amount", "Excess Amount"}, GridView1)
    End Sub

    Public Sub LoadCoupon()
        LoadXgrid("CALL sp_salestransaction('COUPON','" & globalSalesTrnCOde.Text & "',0)", "CALL sp_salestransaction('COUPON','" & globalSalesTrnCOde.Text & "',0)", Em, GridView1, Me)
        XgridColCurrency({"Unit Price", "Total"}, GridView1)
        XgridColAlign({"Reference", "Quantity", "Unit", "Coupon Date", "Date Verified"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total"}, GridView1)
    End Sub

    Public Sub LoadBatchTransaction()
        LoadXgrid("CALL sp_salestransaction('BATCH','" & globalSalesTrnCOde.Text & "'," & Globalenablechittransaction & ")", "CALL sp_salestransaction('BATCH','" & globalSalesTrnCOde.Text & "'," & Globalenablechittransaction & ")", Em, GridView1, Me)
        XgridColCurrency({"Sub Total", "Total Amount", "Total Discount", "Total Charges", "Total Tax", "Amount Tendered", "Change", If(Globalenablechittransaction = True, "Total SOP", Nothing)}, GridView1)
        XgridColAlign({"Batch Code", "Folio No.", "Room No.", "Total Item", "Item Cancelled", "Payment Type", "Invoice No", If(Globalenablechittransaction = True, "SOP Transaction", Nothing)}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Sub Total", "Total Amount", "Total Discount", "Total Charges", "Total Tax", If(Globalenablechittransaction = True, "Total SOP", Nothing)}, GridView1)
    End Sub

    Public Sub ShowDetailTransactions()
        LoadXgrid("CALL sp_salestransaction('DETAILED','" & globalSalesTrnCOde.Text & "'," & Globalenablechittransaction & ")", "CALL sp_salestransaction('DETAILED','" & globalSalesTrnCOde.Text & "'," & Globalenablechittransaction & ")", Em, GridView1, Me)
        XgridColCurrency({"Quantity", "Unit Price", "Discount", "Tax", "Sub Total", "Total Amount", If(Globalenablechittransaction = True, "SOP", Nothing), If(Globalenablechittransaction = True, "Total SOP", Nothing)}, GridView1)
        XgridColAlign({"Batch Code", "Folio No.", "Room No.", "Quantity", "Unit", "Unit Price"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Discount", "Tax", "Sub Total", "Total Amount", If(Globalenablechittransaction = True, "SOP", Nothing), If(Globalenablechittransaction = True, "Total SOP", Nothing)}, GridView1)
    End Sub

    Public Sub ShowTotalTransactions()
        LoadXgrid("CALL sp_salestransaction('TOTAL','" & globalSalesTrnCOde.Text & "'," & Globalenablechittransaction & ")", "CALL sp_salestransaction('TOTAL','" & globalSalesTrnCOde.Text & "'," & Globalenablechittransaction & ")", Em, GridView1, Me)
        XgridColCurrency({"Quantity", "Unit Price", "Discount", "Tax", "Sub Total", "Total Amount", If(Globalenablechittransaction = True, "SOP", Nothing), If(Globalenablechittransaction = True, "Total SOP", Nothing)}, GridView1)
        XgridColAlign({"Batch Code", "Quantity", "Unit", "Unit Price"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Discount", "Tax", "Sub Total", "Total Amount", If(Globalenablechittransaction = True, "SOP", Nothing), If(Globalenablechittransaction = True, "Total SOP", Nothing)}, GridView1)
    End Sub


    Public Sub ShowVoidandCancelledTransactions()
        LoadXgrid("CALL sp_salestransaction('VOID','" & globalSalesTrnCOde.Text & "'," & Globalenablechittransaction & ")", "CALL sp_salestransaction('VOID','" & globalSalesTrnCOde.Text & "'," & Globalenablechittransaction & ")", Em, GridView1, Me)

        XgridColCurrency({"Quantity", "Unit Price", "Discount", "Tax", "Sub Total", "Total Amount", If(Globalenablechittransaction = True, "SOP", Nothing), If(Globalenablechittransaction = True, "Total SOP", Nothing)}, GridView1)
        XgridColAlign({"Batch Code", "Quantity", "Unit", "Unit Price"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Discount", "Tax", "Sub Total", "Total Amount", If(Globalenablechittransaction = True, "SOP", Nothing), If(Globalenablechittransaction = True, "Total SOP", Nothing)}, GridView1)
    End Sub

    Public Sub ShowExpenses()
        LoadXgrid("CALL sp_salestransaction('EXPENSES','" & globalSalesTrnCOde.Text & "',0)", "CALL sp_salestransaction('EXPENSES','" & globalSalesTrnCOde.Text & "',0)", Em, GridView1, Me)
        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Date Post"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub ShowChargeToHotelTransaction()
        LoadXgrid("CALL sp_salestransaction('CHRGETOHOTEL','" & globalSalesTrnCOde.Text & "',0)", "CALL sp_salestransaction('CHRGETOHOTEL','" & globalSalesTrnCOde.Text & "',0)", Em, GridView1, Me)

        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Room Number", "Folio No.", "Room No.", "Folio Number"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub ShowHotelTransaction()
        LoadXgrid("CALL sp_salestransaction('HOTELTRN','" & globalSalesTrnCOde.Text & "',0)", "CALL sp_salestransaction('HOTELTRN','" & globalSalesTrnCOde.Text & "',0)", Em, GridView1, Me)

        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Room Number", "Folio Number"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub ShowHotelPaymentTransaction()
        LoadXgrid("CALL sp_salestransaction('HOTELPMT','" & globalSalesTrnCOde.Text & "',0)", "CALL sp_salestransaction('HOTELPMT','" & globalSalesTrnCOde.Text & "',0)", Em, GridView1, Me)

        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Room Number", "Folio Number", "Reference No."}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub ShowCheck()
        LoadXgrid("CALL sp_salestransaction('CHECK','" & globalSalesTrnCOde.Text & "'," & Globalenablechittransaction & ")", "CALL sp_salestransaction('CHECK','" & globalSalesTrnCOde.Text & "'," & Globalenablechittransaction & ")", Em, GridView1, Me)
        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Reference", "Check No.", "Issuer Bank", "Date Transaction"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub ShowCard()
        LoadXgrid("CALL sp_salestransaction('CARD','" & globalSalesTrnCOde.Text & "',0)", "CALL sp_salestransaction('CARD','" & globalSalesTrnCOde.Text & "',0)", Em, GridView1, Me)
        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Reference", "Card No.", "Trace Number", "Date Transaction"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub ShowOnline()
        LoadXgrid("CALL sp_salestransaction('ONLINE','" & globalSalesTrnCOde.Text & "',0)", "CALL sp_salestransaction('ONLINE','" & globalSalesTrnCOde.Text & "',0)", Em, GridView1, Me)
        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Reference", "Date Transaction"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub ShowVoucher()
        LoadXgrid("CALL sp_salestransaction('VOUCHER','" & globalSalesTrnCOde.Text & "',0)", "CALL sp_salestransaction('VOUCHER','" & globalSalesTrnCOde.Text & "',0)", Em, GridView1, Me)
        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Reference", "Voucher No.", "Date Transaction"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub ShowAccountingTicket()
        LoadXgrid("CALL sp_salestransaction('ACCOUNTING','" & globalSalesTrnCOde.Text & "',0)", "CALL sp_salestransaction('ACCOUNTING','" & globalSalesTrnCOde.Text & "',0)", Em, GridView1, Me)
        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Reference", "Date Transaction"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub

    Private Sub GridView1_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles GridView1.ColumnWidthChanged
        UpdateGridColumnSetting(Me.Name & XtraTabControl1.SelectedTabPage.Name, GridView1)
    End Sub

    Private Sub GridView1_DragObjectDrop(sender As Object, e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles GridView1.DragObjectDrop
        UpdateGridColumnSetting(Me.Name & XtraTabControl1.SelectedTabPage.Name, GridView1)
    End Sub

    Private Sub globalSalesTrnCOde_EditValueChanged(sender As Object, e As EventArgs) Handles globalSalesTrnCOde.EditValueChanged
        FilterOption()
    End Sub

    Private Sub cmdSalesBlotterSummary_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdSalesBlotterSummary.LinkClicked
        XtraTabControl1.SelectedTabPage = tabSalesSummary
    End Sub

    Private Sub cmdClientAccounts_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdClientAccounts.LinkClicked
        XtraTabControl1.SelectedTabPage = tabKeyAccounts
    End Sub

    Private Sub cmdInterOffice_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdInterOffice.LinkClicked
        XtraTabControl1.SelectedTabPage = tabInterOffice
    End Sub

    Private Sub cmdCouponCharge_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdCouponCharge.LinkClicked
        XtraTabControl1.SelectedTabPage = tabCouponCharge
    End Sub

    Private Sub cmdBatchTransaction_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdBatchTransaction.LinkClicked
        XtraTabControl1.SelectedTabPage = tabBatch
    End Sub

    Private Sub cmdDetailedTransaction_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdDetailedTransaction.LinkClicked
        XtraTabControl1.SelectedTabPage = tabDetailed
    End Sub

    Private Sub cmdSoldProduct_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdSoldProduct.LinkClicked
        XtraTabControl1.SelectedTabPage = tabSoldProduct
    End Sub

    Private Sub cmdVoidCancelled_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdVoidCancelled.LinkClicked
        XtraTabControl1.SelectedTabPage = tabVoid
    End Sub

    Private Sub cmdExpenses_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdExpenses.LinkClicked
        XtraTabControl1.SelectedTabPage = tabExpenses
    End Sub

    Private Sub cmdChargeToHotel_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdChargeToHotel.LinkClicked
        XtraTabControl1.SelectedTabPage = tabChargetoHotel
    End Sub

    Private Sub cmdHotelCharges_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdHotelCharges.LinkClicked
        XtraTabControl1.SelectedTabPage = tabHotelTrn
    End Sub

    Private Sub cmdHotelPayments_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdHotelPayments.LinkClicked
        XtraTabControl1.SelectedTabPage = tabHotelPayment
    End Sub

    Private Sub cmdCheck_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdCheck.LinkClicked
        XtraTabControl1.SelectedTabPage = tabCheck
    End Sub

    Private Sub cmdCard_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdCard.LinkClicked
        XtraTabControl1.SelectedTabPage = tabCard
    End Sub

    Private Sub cmdOnline_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdOnline.LinkClicked
        XtraTabControl1.SelectedTabPage = tabOnline
    End Sub

    Private Sub cmdVoucherPayment_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdVoucherPayment.LinkClicked
        XtraTabControl1.SelectedTabPage = tabVoucher
    End Sub

    Private Sub cmdAccountingTicket_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdAccountingTicket.LinkClicked
        XtraTabControl1.SelectedTabPage = tabAccountingTicket
    End Sub

    Private Sub cmdSystemGeneratedTicket_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdSystemGeneratedTicket.LinkClicked
        XtraTabControl1.SelectedTabPage = tabAccountingEntries
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        ExportGridToExcel(XtraTabControl1.SelectedTabPage.Text + "-" + Me.Text, GridView1)
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        GenerateLXCashiersBlotter(globalSalesTrnCOde.Text, Me)

    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        GenerateLXCashiersRemittance(globalSalesTrnCOde.Text, Me)
    End Sub

    Private Sub cmdPrintSelectedTab_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrintSelectedTab.ItemClick
        PrintGeneralReport(XtraTabControl1.SelectedTabPage.Text, "Cashier: " & Me.Text, GridView1, Me)
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Dim colname As String = ""
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView1, Me.Text & XtraTabControl1.SelectedTabPage.Name)
        frmColumnFilter.ShowDialog(Me)
    End Sub

    Private Sub ShortcutToProductCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShortcutToProductCategoryToolStripMenuItem.Click
        If frmProductCategory.Visible = True Then
            frmProductCategory.Focus()
        Else
            frmProductCategory.Show(Me)
        End If
    End Sub

    Private Sub RefreshLedgerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshLedgerToolStripMenuItem.Click
        FilterOption()
    End Sub
End Class