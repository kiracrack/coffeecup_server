<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSTransactionHistory
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSTransactionHistory))
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShortcutToProductCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshLedgerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabAccountingEntries = New DevExpress.XtraTab.XtraTabPage()
        Me.tabSalesSummary = New DevExpress.XtraTab.XtraTabPage()
        Me.tabBatch = New DevExpress.XtraTab.XtraTabPage()
        Me.tabDetailed = New DevExpress.XtraTab.XtraTabPage()
        Me.tabVoid = New DevExpress.XtraTab.XtraTabPage()
        Me.tabCheck = New DevExpress.XtraTab.XtraTabPage()
        Me.tabCard = New DevExpress.XtraTab.XtraTabPage()
        Me.tabOnline = New DevExpress.XtraTab.XtraTabPage()
        Me.tabVoucher = New DevExpress.XtraTab.XtraTabPage()
        Me.tabAccountingTicket = New DevExpress.XtraTab.XtraTabPage()
        Me.tabExpenses = New DevExpress.XtraTab.XtraTabPage()
        Me.tabKeyAccounts = New DevExpress.XtraTab.XtraTabPage()
        Me.globalSalesTrnCOde = New DevExpress.XtraEditors.TextEdit()
        Me.tabInterOffice = New DevExpress.XtraTab.XtraTabPage()
        Me.tabCouponCharge = New DevExpress.XtraTab.XtraTabPage()
        Me.tabSoldProduct = New DevExpress.XtraTab.XtraTabPage()
        Me.tabChargetoHotel = New DevExpress.XtraTab.XtraTabPage()
        Me.tabHotelTrn = New DevExpress.XtraTab.XtraTabPage()
        Me.tabHotelPayment = New DevExpress.XtraTab.XtraTabPage()
        Me.NavBarControl2 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup5 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.cmdSystemGeneratedTicket = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdSalesBlotterSummary = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdBatchTransaction = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdDetailedTransaction = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdVoidCancelled = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdCheck = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdCard = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdOnline = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdVoucherPayment = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdAccountingTicket = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdExpenses = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdClientAccounts = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdInterOffice = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdCouponCharge = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdSoldProduct = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdChargeToHotel = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdHotelCharges = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdHotelPayments = New DevExpress.XtraNavBar.NavBarItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdPrintSelectedTab = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarLargeButtonItem1 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdPrintReport = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdExportToExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabAccountingEntries.SuspendLayout()
        Me.tabKeyAccounts.SuspendLayout()
        CType(Me.globalSalesTrnCOde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavBarControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.Em.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(779, 566)
        Me.Em.TabIndex = 650
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShortcutToProductCategoryToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshLedgerToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(230, 54)
        '
        'ShortcutToProductCategoryToolStripMenuItem
        '
        Me.ShortcutToProductCategoryToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.notebook__arrow1
        Me.ShortcutToProductCategoryToolStripMenuItem.Name = "ShortcutToProductCategoryToolStripMenuItem"
        Me.ShortcutToProductCategoryToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.ShortcutToProductCategoryToolStripMenuItem.Text = "Shortcut to Product Category"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(226, 6)
        '
        'RefreshLedgerToolStripMenuItem
        '
        Me.RefreshLedgerToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshLedgerToolStripMenuItem.Name = "RefreshLedgerToolStripMenuItem"
        Me.RefreshLedgerToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.RefreshLedgerToolStripMenuItem.Text = "Refresh Ledger"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.Appearance.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.HeaderActive.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.HeaderDisabled.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.HeaderHotTracked.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.PageClient.Options.UseFont = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(247, 26)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabAccountingEntries
        Me.XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Size = New System.Drawing.Size(781, 595)
        Me.XtraTabControl1.TabIndex = 651
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabAccountingEntries, Me.tabSalesSummary, Me.tabBatch, Me.tabDetailed, Me.tabVoid, Me.tabCheck, Me.tabCard, Me.tabOnline, Me.tabVoucher, Me.tabAccountingTicket, Me.tabExpenses, Me.tabKeyAccounts, Me.tabInterOffice, Me.tabCouponCharge, Me.tabSoldProduct, Me.tabChargetoHotel, Me.tabHotelTrn, Me.tabHotelPayment})
        Me.XtraTabControl1.Transition.AllowTransition = DevExpress.Utils.DefaultBoolean.[True]
        '
        'tabAccountingEntries
        '
        Me.tabAccountingEntries.Controls.Add(Me.Em)
        Me.tabAccountingEntries.Name = "tabAccountingEntries"
        Me.tabAccountingEntries.Size = New System.Drawing.Size(779, 566)
        Me.tabAccountingEntries.Text = "System Generated Accounting Entries"
        '
        'tabSalesSummary
        '
        Me.tabSalesSummary.Name = "tabSalesSummary"
        Me.tabSalesSummary.Size = New System.Drawing.Size(779, 566)
        Me.tabSalesSummary.Text = "Sales Blotter Summary"
        '
        'tabBatch
        '
        Me.tabBatch.Name = "tabBatch"
        Me.tabBatch.Size = New System.Drawing.Size(779, 566)
        Me.tabBatch.Text = "Batch Transaction Summary"
        '
        'tabDetailed
        '
        Me.tabDetailed.Name = "tabDetailed"
        Me.tabDetailed.Size = New System.Drawing.Size(779, 566)
        Me.tabDetailed.Text = "Detailed Transaction History"
        '
        'tabVoid
        '
        Me.tabVoid.Name = "tabVoid"
        Me.tabVoid.Size = New System.Drawing.Size(779, 566)
        Me.tabVoid.Text = "Void and Cancelled History"
        '
        'tabCheck
        '
        Me.tabCheck.Name = "tabCheck"
        Me.tabCheck.Size = New System.Drawing.Size(779, 566)
        Me.tabCheck.Text = "Check Payment Transaction"
        '
        'tabCard
        '
        Me.tabCard.Name = "tabCard"
        Me.tabCard.Size = New System.Drawing.Size(779, 566)
        Me.tabCard.Text = "Credit/Debit Card Transaction"
        '
        'tabOnline
        '
        Me.tabOnline.Name = "tabOnline"
        Me.tabOnline.Size = New System.Drawing.Size(779, 566)
        Me.tabOnline.Text = "Online Payment Transaction"
        '
        'tabVoucher
        '
        Me.tabVoucher.Name = "tabVoucher"
        Me.tabVoucher.Size = New System.Drawing.Size(779, 566)
        Me.tabVoucher.Text = "Voucher"
        '
        'tabAccountingTicket
        '
        Me.tabAccountingTicket.Name = "tabAccountingTicket"
        Me.tabAccountingTicket.Size = New System.Drawing.Size(779, 566)
        Me.tabAccountingTicket.Text = "Accounting Ticket"
        '
        'tabExpenses
        '
        Me.tabExpenses.Name = "tabExpenses"
        Me.tabExpenses.Size = New System.Drawing.Size(779, 566)
        Me.tabExpenses.Text = "Expenses Transaction"
        '
        'tabKeyAccounts
        '
        Me.tabKeyAccounts.Controls.Add(Me.globalSalesTrnCOde)
        Me.tabKeyAccounts.Name = "tabKeyAccounts"
        Me.tabKeyAccounts.Size = New System.Drawing.Size(779, 566)
        Me.tabKeyAccounts.Text = "Client Account Transaction"
        '
        'globalSalesTrnCOde
        '
        Me.globalSalesTrnCOde.Location = New System.Drawing.Point(338, 121)
        Me.globalSalesTrnCOde.Name = "globalSalesTrnCOde"
        Me.globalSalesTrnCOde.Properties.Appearance.Options.UseTextOptions = True
        Me.globalSalesTrnCOde.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.globalSalesTrnCOde.Properties.ReadOnly = True
        Me.globalSalesTrnCOde.Size = New System.Drawing.Size(53, 20)
        Me.globalSalesTrnCOde.TabIndex = 671
        Me.globalSalesTrnCOde.Visible = False
        '
        'tabInterOffice
        '
        Me.tabInterOffice.Name = "tabInterOffice"
        Me.tabInterOffice.Size = New System.Drawing.Size(779, 566)
        Me.tabInterOffice.Text = "Inter Office"
        '
        'tabCouponCharge
        '
        Me.tabCouponCharge.Name = "tabCouponCharge"
        Me.tabCouponCharge.Size = New System.Drawing.Size(779, 566)
        Me.tabCouponCharge.Text = "Coupon Charge Transaction"
        '
        'tabSoldProduct
        '
        Me.tabSoldProduct.Name = "tabSoldProduct"
        Me.tabSoldProduct.Size = New System.Drawing.Size(779, 566)
        Me.tabSoldProduct.Text = "Sold Product Summary"
        '
        'tabChargetoHotel
        '
        Me.tabChargetoHotel.Name = "tabChargetoHotel"
        Me.tabChargetoHotel.Size = New System.Drawing.Size(779, 566)
        Me.tabChargetoHotel.Text = "Charge to Hotel Transaction"
        '
        'tabHotelTrn
        '
        Me.tabHotelTrn.Name = "tabHotelTrn"
        Me.tabHotelTrn.Size = New System.Drawing.Size(779, 566)
        Me.tabHotelTrn.Text = "Hotel Transaction"
        '
        'tabHotelPayment
        '
        Me.tabHotelPayment.Name = "tabHotelPayment"
        Me.tabHotelPayment.Size = New System.Drawing.Size(779, 566)
        Me.tabHotelPayment.Text = "Hotel Payment"
        '
        'NavBarControl2
        '
        Me.NavBarControl2.ActiveGroup = Me.NavBarGroup5
        Me.NavBarControl2.AllowDrop = False
        Me.NavBarControl2.Appearance.GroupHeader.Options.UseFont = True
        Me.NavBarControl2.Appearance.GroupHeaderActive.Options.UseFont = True
        Me.NavBarControl2.Appearance.GroupHeaderHotTracked.Options.UseFont = True
        Me.NavBarControl2.Appearance.GroupHeaderPressed.Options.UseFont = True
        Me.NavBarControl2.Appearance.Item.Options.UseFont = True
        Me.NavBarControl2.Appearance.ItemActive.Options.UseFont = True
        Me.NavBarControl2.Appearance.ItemHotTracked.Options.UseFont = True
        Me.NavBarControl2.Appearance.ItemPressed.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarControl2.Appearance.ItemPressed.Options.UseFont = True
        Me.NavBarControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavBarControl2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarControl2.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup5})
        Me.NavBarControl2.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.cmdSalesBlotterSummary, Me.cmdClientAccounts, Me.cmdBatchTransaction, Me.cmdDetailedTransaction, Me.cmdSoldProduct, Me.cmdVoidCancelled, Me.cmdChargeToHotel, Me.cmdHotelCharges, Me.cmdHotelPayments, Me.cmdInterOffice, Me.cmdCouponCharge, Me.cmdExpenses, Me.cmdCheck, Me.cmdCard, Me.cmdOnline, Me.cmdAccountingTicket, Me.cmdVoucherPayment, Me.cmdSystemGeneratedTicket})
        Me.NavBarControl2.Location = New System.Drawing.Point(0, 26)
        Me.NavBarControl2.Name = "NavBarControl2"
        Me.NavBarControl2.OptionsLayout.StoreAppearance = True
        Me.NavBarControl2.OptionsNavPane.ExpandedWidth = 247
        Me.NavBarControl2.Size = New System.Drawing.Size(247, 595)
        Me.NavBarControl2.TabIndex = 653
        Me.NavBarControl2.Text = "NavBarControl2"
        '
        'NavBarGroup5
        '
        Me.NavBarGroup5.Caption = "Navigation Menu"
        Me.NavBarGroup5.Expanded = True
        Me.NavBarGroup5.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdSystemGeneratedTicket), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdSalesBlotterSummary), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdBatchTransaction), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdDetailedTransaction), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdVoidCancelled), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdCheck), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdCard), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdOnline), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdVoucherPayment), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdAccountingTicket), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdExpenses), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdClientAccounts), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdInterOffice), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdCouponCharge), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdSoldProduct), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdChargeToHotel), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdHotelCharges), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdHotelPayments)})
        Me.NavBarGroup5.Name = "NavBarGroup5"
        '
        'cmdSystemGeneratedTicket
        '
        Me.cmdSystemGeneratedTicket.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSystemGeneratedTicket.Appearance.Options.UseFont = True
        Me.cmdSystemGeneratedTicket.AppearanceHotTracked.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdSystemGeneratedTicket.AppearanceHotTracked.Options.UseFont = True
        Me.cmdSystemGeneratedTicket.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdSystemGeneratedTicket.AppearancePressed.Options.UseFont = True
        Me.cmdSystemGeneratedTicket.Caption = "Accounting Ticket"
        Me.cmdSystemGeneratedTicket.ImageOptions.SmallImage = Global.Coffeecup.My.Resources.Resources.arrow_curve
        Me.cmdSystemGeneratedTicket.Name = "cmdSystemGeneratedTicket"
        '
        'cmdSalesBlotterSummary
        '
        Me.cmdSalesBlotterSummary.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalesBlotterSummary.Appearance.Options.UseFont = True
        Me.cmdSalesBlotterSummary.AppearanceDisabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdSalesBlotterSummary.AppearanceDisabled.Options.UseFont = True
        Me.cmdSalesBlotterSummary.AppearanceHotTracked.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdSalesBlotterSummary.AppearanceHotTracked.Options.UseFont = True
        Me.cmdSalesBlotterSummary.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdSalesBlotterSummary.AppearancePressed.Options.UseFont = True
        Me.cmdSalesBlotterSummary.Caption = "Sales Blotter Summary"
        Me.cmdSalesBlotterSummary.ImageOptions.SmallImage = CType(resources.GetObject("cmdSalesBlotterSummary.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.cmdSalesBlotterSummary.Name = "cmdSalesBlotterSummary"
        '
        'cmdBatchTransaction
        '
        Me.cmdBatchTransaction.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBatchTransaction.Appearance.Options.UseFont = True
        Me.cmdBatchTransaction.AppearanceHotTracked.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdBatchTransaction.AppearanceHotTracked.Options.UseFont = True
        Me.cmdBatchTransaction.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdBatchTransaction.AppearancePressed.Options.UseFont = True
        Me.cmdBatchTransaction.Caption = "Batch Sales Transaction"
        Me.cmdBatchTransaction.ImageOptions.SmallImage = CType(resources.GetObject("cmdBatchTransaction.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.cmdBatchTransaction.Name = "cmdBatchTransaction"
        '
        'cmdDetailedTransaction
        '
        Me.cmdDetailedTransaction.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDetailedTransaction.Appearance.Options.UseFont = True
        Me.cmdDetailedTransaction.AppearanceHotTracked.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdDetailedTransaction.AppearanceHotTracked.Options.UseFont = True
        Me.cmdDetailedTransaction.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdDetailedTransaction.AppearancePressed.Options.UseFont = True
        Me.cmdDetailedTransaction.Caption = "Detailed Sales Transaction"
        Me.cmdDetailedTransaction.ImageOptions.SmallImage = CType(resources.GetObject("cmdDetailedTransaction.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.cmdDetailedTransaction.Name = "cmdDetailedTransaction"
        '
        'cmdVoidCancelled
        '
        Me.cmdVoidCancelled.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVoidCancelled.Appearance.Options.UseFont = True
        Me.cmdVoidCancelled.AppearanceHotTracked.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdVoidCancelled.AppearanceHotTracked.Options.UseFont = True
        Me.cmdVoidCancelled.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdVoidCancelled.AppearancePressed.Options.UseFont = True
        Me.cmdVoidCancelled.Caption = "Void and Cancelled Transaction"
        Me.cmdVoidCancelled.ImageOptions.SmallImage = CType(resources.GetObject("cmdVoidCancelled.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.cmdVoidCancelled.Name = "cmdVoidCancelled"
        '
        'cmdCheck
        '
        Me.cmdCheck.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCheck.Appearance.Options.UseFont = True
        Me.cmdCheck.AppearanceHotTracked.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdCheck.AppearanceHotTracked.Options.UseFont = True
        Me.cmdCheck.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdCheck.AppearancePressed.Options.UseFont = True
        Me.cmdCheck.Caption = "Check Transaction"
        Me.cmdCheck.ImageOptions.SmallImage = CType(resources.GetObject("cmdCheck.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.cmdCheck.Name = "cmdCheck"
        '
        'cmdCard
        '
        Me.cmdCard.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCard.Appearance.Options.UseFont = True
        Me.cmdCard.AppearanceHotTracked.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdCard.AppearanceHotTracked.Options.UseFont = True
        Me.cmdCard.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdCard.AppearancePressed.Options.UseFont = True
        Me.cmdCard.Caption = "Credit/Debit Card Transaction"
        Me.cmdCard.ImageOptions.SmallImage = CType(resources.GetObject("cmdCard.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.cmdCard.Name = "cmdCard"
        '
        'cmdOnline
        '
        Me.cmdOnline.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOnline.Appearance.Options.UseFont = True
        Me.cmdOnline.AppearanceHotTracked.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdOnline.AppearanceHotTracked.Options.UseFont = True
        Me.cmdOnline.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdOnline.AppearancePressed.Options.UseFont = True
        Me.cmdOnline.Caption = "Online Payment Transaction"
        Me.cmdOnline.ImageOptions.SmallImage = CType(resources.GetObject("cmdOnline.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.cmdOnline.Name = "cmdOnline"
        '
        'cmdVoucherPayment
        '
        Me.cmdVoucherPayment.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVoucherPayment.Appearance.Options.UseFont = True
        Me.cmdVoucherPayment.AppearanceHotTracked.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdVoucherPayment.AppearanceHotTracked.Options.UseFont = True
        Me.cmdVoucherPayment.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdVoucherPayment.AppearancePressed.Options.UseFont = True
        Me.cmdVoucherPayment.Caption = "Voucher Payment Transaction"
        Me.cmdVoucherPayment.ImageOptions.SmallImage = Global.Coffeecup.My.Resources.Resources.arrow_curve
        Me.cmdVoucherPayment.Name = "cmdVoucherPayment"
        '
        'cmdAccountingTicket
        '
        Me.cmdAccountingTicket.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAccountingTicket.Appearance.Options.UseFont = True
        Me.cmdAccountingTicket.AppearanceHotTracked.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdAccountingTicket.AppearanceHotTracked.Options.UseFont = True
        Me.cmdAccountingTicket.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdAccountingTicket.AppearancePressed.Options.UseFont = True
        Me.cmdAccountingTicket.Caption = "Ticket Entries Payment"
        Me.cmdAccountingTicket.ImageOptions.SmallImage = Global.Coffeecup.My.Resources.Resources.arrow_curve
        Me.cmdAccountingTicket.Name = "cmdAccountingTicket"
        '
        'cmdExpenses
        '
        Me.cmdExpenses.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExpenses.Appearance.Options.UseFont = True
        Me.cmdExpenses.AppearanceHotTracked.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdExpenses.AppearanceHotTracked.Options.UseFont = True
        Me.cmdExpenses.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdExpenses.AppearancePressed.Options.UseFont = True
        Me.cmdExpenses.Caption = "Expenses Transaction"
        Me.cmdExpenses.ImageOptions.SmallImage = CType(resources.GetObject("cmdExpenses.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.cmdExpenses.Name = "cmdExpenses"
        '
        'cmdClientAccounts
        '
        Me.cmdClientAccounts.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClientAccounts.Appearance.Options.UseFont = True
        Me.cmdClientAccounts.AppearanceDisabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdClientAccounts.AppearanceDisabled.Options.UseFont = True
        Me.cmdClientAccounts.AppearanceHotTracked.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdClientAccounts.AppearanceHotTracked.Options.UseFont = True
        Me.cmdClientAccounts.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdClientAccounts.AppearancePressed.Options.UseFont = True
        Me.cmdClientAccounts.Caption = "Client Accounts Transaction"
        Me.cmdClientAccounts.ImageOptions.SmallImage = CType(resources.GetObject("cmdClientAccounts.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.cmdClientAccounts.Name = "cmdClientAccounts"
        '
        'cmdInterOffice
        '
        Me.cmdInterOffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInterOffice.Appearance.Options.UseFont = True
        Me.cmdInterOffice.AppearanceHotTracked.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdInterOffice.AppearanceHotTracked.Options.UseFont = True
        Me.cmdInterOffice.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdInterOffice.AppearancePressed.Options.UseFont = True
        Me.cmdInterOffice.Caption = "Inter Office Transaction"
        Me.cmdInterOffice.ImageOptions.SmallImage = Global.Coffeecup.My.Resources.Resources.arrow_curve
        Me.cmdInterOffice.Name = "cmdInterOffice"
        '
        'cmdCouponCharge
        '
        Me.cmdCouponCharge.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCouponCharge.Appearance.Options.UseFont = True
        Me.cmdCouponCharge.AppearanceHotTracked.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdCouponCharge.AppearanceHotTracked.Options.UseFont = True
        Me.cmdCouponCharge.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdCouponCharge.AppearancePressed.Options.UseFont = True
        Me.cmdCouponCharge.Caption = "Coupon Charge Transaction"
        Me.cmdCouponCharge.ImageOptions.SmallImage = CType(resources.GetObject("cmdCouponCharge.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.cmdCouponCharge.Name = "cmdCouponCharge"
        '
        'cmdSoldProduct
        '
        Me.cmdSoldProduct.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSoldProduct.Appearance.Options.UseFont = True
        Me.cmdSoldProduct.AppearanceHotTracked.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdSoldProduct.AppearanceHotTracked.Options.UseFont = True
        Me.cmdSoldProduct.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdSoldProduct.AppearancePressed.Options.UseFont = True
        Me.cmdSoldProduct.Caption = "Sold Product Summary"
        Me.cmdSoldProduct.ImageOptions.SmallImage = CType(resources.GetObject("cmdSoldProduct.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.cmdSoldProduct.Name = "cmdSoldProduct"
        '
        'cmdChargeToHotel
        '
        Me.cmdChargeToHotel.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChargeToHotel.Appearance.Options.UseFont = True
        Me.cmdChargeToHotel.AppearanceHotTracked.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdChargeToHotel.AppearanceHotTracked.Options.UseFont = True
        Me.cmdChargeToHotel.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdChargeToHotel.AppearancePressed.Options.UseFont = True
        Me.cmdChargeToHotel.Caption = "Charge to Hotel Transaction"
        Me.cmdChargeToHotel.ImageOptions.SmallImage = CType(resources.GetObject("cmdChargeToHotel.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.cmdChargeToHotel.Name = "cmdChargeToHotel"
        '
        'cmdHotelCharges
        '
        Me.cmdHotelCharges.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHotelCharges.Appearance.Options.UseFont = True
        Me.cmdHotelCharges.AppearanceHotTracked.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdHotelCharges.AppearanceHotTracked.Options.UseFont = True
        Me.cmdHotelCharges.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdHotelCharges.AppearancePressed.Options.UseFont = True
        Me.cmdHotelCharges.Caption = "Hotel Charges Transaction"
        Me.cmdHotelCharges.ImageOptions.SmallImage = CType(resources.GetObject("cmdHotelCharges.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.cmdHotelCharges.Name = "cmdHotelCharges"
        '
        'cmdHotelPayments
        '
        Me.cmdHotelPayments.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHotelPayments.Appearance.Options.UseFont = True
        Me.cmdHotelPayments.AppearanceHotTracked.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdHotelPayments.AppearanceHotTracked.Options.UseFont = True
        Me.cmdHotelPayments.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdHotelPayments.AppearancePressed.Options.UseFont = True
        Me.cmdHotelPayments.Caption = "Hotel Payments Transaction"
        Me.cmdHotelPayments.ImageOptions.SmallImage = CType(resources.GetObject("cmdHotelPayments.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.cmdHotelPayments.Name = "cmdHotelPayments"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarLargeButtonItem1, Me.BarButtonItem2, Me.cmdPrintReport, Me.cmdExportToExcel, Me.BarButtonItem1, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.cmdPrintSelectedTab, Me.BarButtonItem6})
        Me.BarManager1.MainMenu = Me.Bar1
        Me.BarManager1.MaxItemId = 13
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Main Menu"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrintSelectedTab, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True)})
        Me.Bar1.OptionsBar.MultiLine = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Main Menu"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Close Window"
        Me.BarButtonItem1.Id = 7
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'cmdPrintSelectedTab
        '
        Me.cmdPrintSelectedTab.Caption = "Print Selected Tab"
        Me.cmdPrintSelectedTab.Id = 11
        Me.cmdPrintSelectedTab.Name = "cmdPrintSelectedTab"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Print Cash Blotter"
        Me.BarButtonItem3.Id = 8
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Print Remittance Report"
        Me.BarButtonItem5.Id = 10
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Export to Excel"
        Me.BarButtonItem4.Id = 9
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Column Settings"
        Me.BarButtonItem6.Id = 12
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1028, 26)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 621)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1028, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 26)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 595)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1028, 26)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 595)
        '
        'BarLargeButtonItem1
        '
        Me.BarLargeButtonItem1.Caption = "&Close Window"
        Me.BarLargeButtonItem1.Id = 1
        Me.BarLargeButtonItem1.Name = "BarLargeButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "&Close Window"
        Me.BarButtonItem2.Id = 4
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'cmdPrintReport
        '
        Me.cmdPrintReport.Caption = "Print Report"
        Me.cmdPrintReport.Id = 5
        Me.cmdPrintReport.Name = "cmdPrintReport"
        '
        'cmdExportToExcel
        '
        Me.cmdExportToExcel.Caption = "Export to Excel"
        Me.cmdExportToExcel.Id = 6
        Me.cmdExportToExcel.Name = "cmdExportToExcel"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'frmPOSTransactionHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 621)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.NavBarControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmPOSTransactionHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS Transaction History"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabAccountingEntries.ResumeLayout(False)
        Me.tabKeyAccounts.ResumeLayout(False)
        CType(Me.globalSalesTrnCOde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavBarControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabKeyAccounts As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabDetailed As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabVoid As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabBatch As DevExpress.XtraTab.XtraTabPage
    Public WithEvents globalSalesTrnCOde As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tabSalesSummary As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabHotelTrn As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabHotelPayment As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabSoldProduct As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents NavBarControl2 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup5 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents cmdSalesBlotterSummary As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdClientAccounts As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdBatchTransaction As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdDetailedTransaction As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdSoldProduct As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdVoidCancelled As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdChargeToHotel As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdHotelCharges As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdHotelPayments As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents tabChargetoHotel As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarLargeButtonItem1 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrintReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdExportToExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tabInterOffice As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdInterOffice As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdCouponCharge As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdExpenses As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdCheck As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdCard As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdOnline As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents tabCheck As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabCard As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabOnline As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabExpenses As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabCouponCharge As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdAccountingTicket As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents tabAccountingTicket As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdVoucherPayment As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents tabVoucher As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdSystemGeneratedTicket As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents tabAccountingEntries As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdPrintSelectedTab As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShortcutToProductCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshLedgerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
