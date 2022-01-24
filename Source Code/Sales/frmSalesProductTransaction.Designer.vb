﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesProductTransaction
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
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdPrintReport = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdExportToExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.BarLargeButtonItem1 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.txtProductName = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ckGroupSummary = New DevExpress.XtraEditors.CheckEdit()
        Me.productid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.ckAllProduct = New DevExpress.XtraEditors.CheckEdit()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.ckasof = New DevExpress.XtraEditors.CheckEdit()
        Me.txtInventory = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gv_inventory = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.lblOffice = New DevExpress.XtraEditors.LabelControl()
        Me.txttodate = New DevExpress.XtraEditors.DateEdit()
        Me.ck_inventory = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtfrmdate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewSubProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTransactionHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.txtProductName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckGroupSummary.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckAllProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckasof.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttodate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttodate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck_inventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfrmdate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfrmdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar1
        '
        Me.Bar1.BarName = "Status bar"
        Me.Bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Status bar"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarLargeButtonItem1, Me.BarButtonItem2, Me.cmdPrintReport, Me.cmdExportToExcel})
        Me.BarManager1.MainMenu = Me.Bar3
        Me.BarManager1.MaxItemId = 7
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        '
        'Bar3
        '
        Me.Bar3.BarName = "Custom 3"
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar3.FloatLocation = New System.Drawing.Point(75, 175)
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrintReport, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdExportToExcel, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.MultiLine = True
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Custom 3"
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
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(766, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 564)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(766, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 540)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(766, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 540)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'BarLargeButtonItem1
        '
        Me.BarLargeButtonItem1.Caption = "&Close Window"
        Me.BarLargeButtonItem1.Id = 1
        Me.BarLargeButtonItem1.Name = "BarLargeButtonItem1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtProductName)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckGroupSummary)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.productid)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckAllProduct)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.officeid)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckasof)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtInventory)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.cmdaction)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.lblOffice)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txttodate)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ck_inventory)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtfrmdate)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl3)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(766, 540)
        Me.SplitContainerControl1.SplitterPosition = 140
        Me.SplitContainerControl1.TabIndex = 11
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'txtProductName
        '
        Me.txtProductName.Enabled = False
        Me.txtProductName.Location = New System.Drawing.Point(99, 13)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtProductName.Properties.Appearance.Options.UseFont = True
        Me.txtProductName.Properties.AutoComplete = False
        Me.txtProductName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtProductName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProductName.Properties.ImmediatePopup = True
        Me.txtProductName.Properties.PopupSizeable = True
        Me.txtProductName.Properties.ValidateOnEnterKey = True
        Me.txtProductName.Size = New System.Drawing.Size(310, 22)
        Me.txtProductName.TabIndex = 623
        '
        'ckGroupSummary
        '
        Me.ckGroupSummary.Location = New System.Drawing.Point(98, 107)
        Me.ckGroupSummary.Name = "ckGroupSummary"
        Me.ckGroupSummary.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckGroupSummary.Properties.Appearance.Options.UseFont = True
        Me.ckGroupSummary.Properties.Caption = "Product Summary Report"
        Me.ckGroupSummary.Size = New System.Drawing.Size(148, 20)
        Me.ckGroupSummary.TabIndex = 594
        '
        'productid
        '
        Me.productid.Location = New System.Drawing.Point(500, 15)
        Me.productid.Name = "productid"
        Me.productid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productid.Properties.Appearance.Options.UseFont = True
        Me.productid.Properties.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(73, 20)
        Me.productid.TabIndex = 593
        Me.productid.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(11, 17)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl2.TabIndex = 591
        Me.LabelControl2.Text = "Product Name"
        '
        'ckAllProduct
        '
        Me.ckAllProduct.EditValue = True
        Me.ckAllProduct.Location = New System.Drawing.Point(414, 14)
        Me.ckAllProduct.Name = "ckAllProduct"
        Me.ckAllProduct.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckAllProduct.Properties.Appearance.Options.UseFont = True
        Me.ckAllProduct.Properties.Caption = "View All"
        Me.ckAllProduct.Size = New System.Drawing.Size(80, 20)
        Me.ckAllProduct.TabIndex = 592
        '
        'officeid
        '
        Me.officeid.Location = New System.Drawing.Point(448, 66)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(73, 20)
        Me.officeid.TabIndex = 589
        Me.officeid.Visible = False
        '
        'ckasof
        '
        Me.ckasof.Location = New System.Drawing.Point(98, 87)
        Me.ckasof.Name = "ckasof"
        Me.ckasof.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckasof.Properties.Appearance.Options.UseFont = True
        Me.ckasof.Properties.Caption = "use report as of"
        Me.ckasof.Size = New System.Drawing.Size(118, 20)
        Me.ckasof.TabIndex = 588
        '
        'txtInventory
        '
        Me.txtInventory.EditValue = ""
        Me.txtInventory.Enabled = False
        Me.txtInventory.Location = New System.Drawing.Point(99, 38)
        Me.txtInventory.Name = "txtInventory"
        Me.txtInventory.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtInventory.Properties.Appearance.Options.UseFont = True
        Me.txtInventory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtInventory.Properties.DisplayMember = "Select Inventory"
        Me.txtInventory.Properties.NullText = ""
        Me.txtInventory.Properties.PopupView = Me.gv_inventory
        Me.txtInventory.Properties.ValueMember = "Select Inventory"
        Me.txtInventory.Size = New System.Drawing.Size(310, 22)
        Me.txtInventory.TabIndex = 580
        '
        'gv_inventory
        '
        Me.gv_inventory.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_inventory.Name = "gv_inventory"
        Me.gv_inventory.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_inventory.OptionsView.ShowGroupPanel = False
        '
        'cmdaction
        '
        Me.cmdaction.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdaction.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdaction.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdaction.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdaction.Appearance.Options.UseBackColor = True
        Me.cmdaction.Appearance.Options.UseFont = True
        Me.cmdaction.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdaction.Location = New System.Drawing.Point(268, 88)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(141, 30)
        Me.cmdaction.TabIndex = 583
        Me.cmdaction.Text = "Filter Search"
        '
        'lblOffice
        '
        Me.lblOffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOffice.Appearance.Options.UseFont = True
        Me.lblOffice.Appearance.Options.UseTextOptions = True
        Me.lblOffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblOffice.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblOffice.Location = New System.Drawing.Point(11, 42)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(82, 13)
        Me.lblOffice.TabIndex = 584
        Me.lblOffice.Text = "Select "
        '
        'txttodate
        '
        Me.txttodate.EditValue = New Date(CType(0, Long))
        Me.txttodate.EnterMoveNextControl = True
        Me.txttodate.Location = New System.Drawing.Point(268, 64)
        Me.txttodate.Name = "txttodate"
        Me.txttodate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttodate.Properties.Appearance.Options.UseFont = True
        Me.txttodate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txttodate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txttodate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txttodate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txttodate.Size = New System.Drawing.Size(141, 20)
        Me.txttodate.TabIndex = 582
        '
        'ck_inventory
        '
        Me.ck_inventory.EditValue = True
        Me.ck_inventory.Location = New System.Drawing.Point(414, 39)
        Me.ck_inventory.Name = "ck_inventory"
        Me.ck_inventory.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_inventory.Properties.Appearance.Options.UseFont = True
        Me.ck_inventory.Properties.Caption = "View All"
        Me.ck_inventory.Size = New System.Drawing.Size(80, 20)
        Me.ck_inventory.TabIndex = 585
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(249, 67)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(13, 13)
        Me.LabelControl1.TabIndex = 587
        Me.LabelControl1.Text = "To"
        '
        'txtfrmdate
        '
        Me.txtfrmdate.EditValue = New Date(CType(0, Long))
        Me.txtfrmdate.EnterMoveNextControl = True
        Me.txtfrmdate.Location = New System.Drawing.Point(99, 64)
        Me.txtfrmdate.Name = "txtfrmdate"
        Me.txtfrmdate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfrmdate.Properties.Appearance.Options.UseFont = True
        Me.txtfrmdate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtfrmdate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtfrmdate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtfrmdate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtfrmdate.Size = New System.Drawing.Size(141, 20)
        Me.txtfrmdate.TabIndex = 581
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(67, 67)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl3.TabIndex = 586
        Me.LabelControl3.Text = "From"
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.Em.Size = New System.Drawing.Size(766, 390)
        Me.Em.TabIndex = 5
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewSubProductToolStripMenuItem, Me.ViewTransactionHistoryToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshDataToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(206, 76)
        '
        'ViewSubProductToolStripMenuItem
        '
        Me.ViewSubProductToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.address_book_open
        Me.ViewSubProductToolStripMenuItem.Name = "ViewSubProductToolStripMenuItem"
        Me.ViewSubProductToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ViewSubProductToolStripMenuItem.Text = "View Sub Product Item "
        '
        'ViewTransactionHistoryToolStripMenuItem
        '
        Me.ViewTransactionHistoryToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.book_open_text1
        Me.ViewTransactionHistoryToolStripMenuItem.Name = "ViewTransactionHistoryToolStripMenuItem"
        Me.ViewTransactionHistoryToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ViewTransactionHistoryToolStripMenuItem.Text = "View Product Menu Item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(202, 6)
        '
        'RefreshDataToolStripMenuItem
        '
        Me.RefreshDataToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshDataToolStripMenuItem.Name = "RefreshDataToolStripMenuItem"
        Me.RefreshDataToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.RefreshDataToolStripMenuItem.Text = "Refresh Data"
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseTextOptions = True
        Me.GridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'frmSalesProductTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 564)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MinimumSize = New System.Drawing.Size(764, 481)
        Me.Name = "frmSalesProductTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Sales Transaction"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.txtProductName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckGroupSummary.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckAllProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckasof.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_inventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttodate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttodate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck_inventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfrmdate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfrmdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarLargeButtonItem1 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents cmdPrintReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents ckasof As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtInventory As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gv_inventory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblOffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txttodate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ck_inventory As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtfrmdate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ViewTransactionHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdExportToExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ViewSubProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents productid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckAllProduct As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckGroupSummary As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtProductName As DevExpress.XtraEditors.ComboBoxEdit
End Class
