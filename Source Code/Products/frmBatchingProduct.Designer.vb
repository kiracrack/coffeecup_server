<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBatchingProduct
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarLargeButtonItem2 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.cmdUpload = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ContextColor = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdColorRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarLargeButtonItem1 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.list_color = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.list_size = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.ContextSize = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEditSize = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemoveSize = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSizeRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtAddColor = New DevExpress.XtraEditors.TextEdit()
        Me.txtAddSize = New DevExpress.XtraEditors.TextEdit()
        Me.txtitem = New DevExpress.XtraEditors.TextEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabOption = New DevExpress.XtraTab.XtraTabPage()
        Me.ckAllSize = New DevExpress.XtraEditors.CheckEdit()
        Me.ckAllColor = New DevExpress.XtraEditors.CheckEdit()
        Me.ckAllBrand = New DevExpress.XtraEditors.CheckEdit()
        Me.brand = New DevExpress.XtraEditors.TextEdit()
        Me.txtaddBrand = New DevExpress.XtraEditors.TextEdit()
        Me.list_brand = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.ContextBrand = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdBrandEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdBrandDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdBrandRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.size = New DevExpress.XtraEditors.TextEdit()
        Me.color = New DevExpress.XtraEditors.TextEdit()
        Me.tabPreview = New DevExpress.XtraTab.XtraTabPage()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.catid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextColor.SuspendLayout()
        CType(Me.list_color, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_size, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextSize.SuspendLayout()
        CType(Me.txtAddColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtitem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabOption.SuspendLayout()
        CType(Me.ckAllSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckAllColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckAllBrand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.brand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtaddBrand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_brand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextBrand.SuspendLayout()
        CType(Me.size.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.color.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPreview.SuspendLayout()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.BarDockControl1)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarLargeButtonItem2, Me.cmdUpload})
        Me.BarManager1.MainMenu = Me.Bar1
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 3"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarLargeButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdUpload, True)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.MultiLine = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Custom 3"
        '
        'BarLargeButtonItem2
        '
        Me.BarLargeButtonItem2.Caption = "&Close Window"
        Me.BarLargeButtonItem2.Id = 1
        Me.BarLargeButtonItem2.Name = "BarLargeButtonItem2"
        '
        'cmdUpload
        '
        Me.cmdUpload.Caption = "Confirm Upload Product Registration"
        Me.cmdUpload.Id = 4
        Me.cmdUpload.ItemAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpload.ItemAppearance.Normal.Options.UseFont = True
        Me.cmdUpload.Name = "cmdUpload"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(869, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 478)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(869, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 454)
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl1.Location = New System.Drawing.Point(869, 24)
        Me.BarDockControl1.Manager = Me.BarManager1
        Me.BarDockControl1.Size = New System.Drawing.Size(0, 454)
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'ContextColor
        '
        Me.ContextColor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdDelete, Me.ToolStripSeparator1, Me.cmdColorRefresh})
        Me.ContextColor.Name = "gridmenustrip"
        Me.ContextColor.Size = New System.Drawing.Size(145, 76)
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(144, 22)
        Me.cmdEdit.Text = "Edit Item"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(144, 22)
        Me.cmdDelete.Text = "Remove Item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(141, 6)
        '
        'cmdColorRefresh
        '
        Me.cmdColorRefresh.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.cmdColorRefresh.Name = "cmdColorRefresh"
        Me.cmdColorRefresh.Size = New System.Drawing.Size(144, 22)
        Me.cmdColorRefresh.Text = "Refresh Data"
        '
        'BarLargeButtonItem1
        '
        Me.BarLargeButtonItem1.Caption = "&Close Window"
        Me.BarLargeButtonItem1.Id = 1
        Me.BarLargeButtonItem1.Name = "BarLargeButtonItem1"
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(869, 24)
        Me.barDockControlRight.Manager = Nothing
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 454)
        '
        'list_color
        '
        Me.list_color.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.list_color.Appearance.Options.UseFont = True
        Me.list_color.Appearance.Options.UseTextOptions = True
        Me.list_color.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.list_color.CheckOnClick = True
        Me.list_color.ColumnWidth = 280
        Me.list_color.ContextMenuStrip = Me.ContextColor
        Me.list_color.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.list_color.HorizontalScrollbar = True
        Me.list_color.HotTrackItems = True
        Me.list_color.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick
        Me.list_color.IncrementalSearch = True
        Me.list_color.Location = New System.Drawing.Point(285, 35)
        Me.list_color.Name = "list_color"
        Me.list_color.Size = New System.Drawing.Size(272, 314)
        Me.list_color.TabIndex = 715
        '
        'list_size
        '
        Me.list_size.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.list_size.Appearance.Options.UseFont = True
        Me.list_size.Appearance.Options.UseTextOptions = True
        Me.list_size.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.list_size.CheckOnClick = True
        Me.list_size.ColumnWidth = 280
        Me.list_size.ContextMenuStrip = Me.ContextSize
        Me.list_size.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.list_size.HorizontalScrollbar = True
        Me.list_size.HotTrackItems = True
        Me.list_size.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick
        Me.list_size.IncrementalSearch = True
        Me.list_size.Location = New System.Drawing.Point(563, 35)
        Me.list_size.Name = "list_size"
        Me.list_size.Size = New System.Drawing.Size(272, 314)
        Me.list_size.TabIndex = 716
        '
        'ContextSize
        '
        Me.ContextSize.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEditSize, Me.cmdRemoveSize, Me.ToolStripSeparator2, Me.cmdSizeRefresh})
        Me.ContextSize.Name = "gridmenustrip"
        Me.ContextSize.Size = New System.Drawing.Size(145, 76)
        '
        'cmdEditSize
        '
        Me.cmdEditSize.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.cmdEditSize.Name = "cmdEditSize"
        Me.cmdEditSize.Size = New System.Drawing.Size(144, 22)
        Me.cmdEditSize.Text = "Edit Item"
        '
        'cmdRemoveSize
        '
        Me.cmdRemoveSize.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus
        Me.cmdRemoveSize.Name = "cmdRemoveSize"
        Me.cmdRemoveSize.Size = New System.Drawing.Size(144, 22)
        Me.cmdRemoveSize.Text = "Remove Item"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(141, 6)
        '
        'cmdSizeRefresh
        '
        Me.cmdSizeRefresh.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.cmdSizeRefresh.Name = "cmdSizeRefresh"
        Me.cmdSizeRefresh.Size = New System.Drawing.Size(144, 22)
        Me.cmdSizeRefresh.Text = "Refresh Data"
        '
        'txtAddColor
        '
        Me.txtAddColor.Location = New System.Drawing.Point(285, 7)
        Me.txtAddColor.MenuManager = Me.BarManager1
        Me.txtAddColor.Name = "txtAddColor"
        Me.txtAddColor.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddColor.Properties.Appearance.Options.UseFont = True
        Me.txtAddColor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddColor.Properties.NullValuePrompt = "Add Color"
        Me.txtAddColor.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtAddColor.Size = New System.Drawing.Size(272, 24)
        Me.txtAddColor.TabIndex = 717
        '
        'txtAddSize
        '
        Me.txtAddSize.Location = New System.Drawing.Point(563, 7)
        Me.txtAddSize.MenuManager = Me.BarManager1
        Me.txtAddSize.Name = "txtAddSize"
        Me.txtAddSize.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddSize.Properties.Appearance.Options.UseFont = True
        Me.txtAddSize.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddSize.Properties.NullValuePrompt = "Add Size"
        Me.txtAddSize.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtAddSize.Size = New System.Drawing.Size(272, 24)
        Me.txtAddSize.TabIndex = 718
        '
        'txtitem
        '
        Me.txtitem.Location = New System.Drawing.Point(12, 34)
        Me.txtitem.Name = "txtitem"
        Me.txtitem.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.25!, System.Drawing.FontStyle.Bold)
        Me.txtitem.Properties.Appearance.Options.UseFont = True
        Me.txtitem.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtitem.Size = New System.Drawing.Size(558, 22)
        Me.txtitem.TabIndex = 724
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 60)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabOption
        Me.XtraTabControl1.Size = New System.Drawing.Size(847, 410)
        Me.XtraTabControl1.TabIndex = 725
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabOption, Me.tabPreview})
        Me.XtraTabControl1.Transition.AllowTransition = DevExpress.Utils.DefaultBoolean.[True]
        '
        'tabOption
        '
        Me.tabOption.Controls.Add(Me.ckAllSize)
        Me.tabOption.Controls.Add(Me.ckAllColor)
        Me.tabOption.Controls.Add(Me.ckAllBrand)
        Me.tabOption.Controls.Add(Me.brand)
        Me.tabOption.Controls.Add(Me.txtaddBrand)
        Me.tabOption.Controls.Add(Me.list_brand)
        Me.tabOption.Controls.Add(Me.size)
        Me.tabOption.Controls.Add(Me.color)
        Me.tabOption.Controls.Add(Me.txtAddColor)
        Me.tabOption.Controls.Add(Me.list_color)
        Me.tabOption.Controls.Add(Me.list_size)
        Me.tabOption.Controls.Add(Me.txtAddSize)
        Me.tabOption.Name = "tabOption"
        Me.tabOption.Size = New System.Drawing.Size(845, 381)
        Me.tabOption.Text = "Advance Option Settings"
        '
        'ckAllSize
        '
        Me.ckAllSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckAllSize.Location = New System.Drawing.Point(563, 352)
        Me.ckAllSize.Name = "ckAllSize"
        Me.ckAllSize.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckAllSize.Properties.Appearance.Options.UseFont = True
        Me.ckAllSize.Properties.Caption = "Select All Item"
        Me.ckAllSize.Size = New System.Drawing.Size(93, 20)
        Me.ckAllSize.TabIndex = 726
        '
        'ckAllColor
        '
        Me.ckAllColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckAllColor.Location = New System.Drawing.Point(285, 352)
        Me.ckAllColor.Name = "ckAllColor"
        Me.ckAllColor.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckAllColor.Properties.Appearance.Options.UseFont = True
        Me.ckAllColor.Properties.Caption = "Select All Item"
        Me.ckAllColor.Size = New System.Drawing.Size(93, 20)
        Me.ckAllColor.TabIndex = 725
        '
        'ckAllBrand
        '
        Me.ckAllBrand.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckAllBrand.Location = New System.Drawing.Point(7, 352)
        Me.ckAllBrand.Name = "ckAllBrand"
        Me.ckAllBrand.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckAllBrand.Properties.Appearance.Options.UseFont = True
        Me.ckAllBrand.Properties.Caption = "Select All Item"
        Me.ckAllBrand.Size = New System.Drawing.Size(93, 20)
        Me.ckAllBrand.TabIndex = 724
        '
        'brand
        '
        Me.brand.EditValue = ""
        Me.brand.EnterMoveNextControl = True
        Me.brand.Location = New System.Drawing.Point(132, 141)
        Me.brand.Name = "brand"
        Me.brand.Properties.ReadOnly = True
        Me.brand.Properties.ValidateOnEnterKey = True
        Me.brand.Size = New System.Drawing.Size(51, 20)
        Me.brand.TabIndex = 723
        Me.brand.Visible = False
        '
        'txtaddBrand
        '
        Me.txtaddBrand.Location = New System.Drawing.Point(7, 7)
        Me.txtaddBrand.MenuManager = Me.BarManager1
        Me.txtaddBrand.Name = "txtaddBrand"
        Me.txtaddBrand.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddBrand.Properties.Appearance.Options.UseFont = True
        Me.txtaddBrand.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtaddBrand.Properties.NullValuePrompt = "Add Brand"
        Me.txtaddBrand.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtaddBrand.Size = New System.Drawing.Size(272, 24)
        Me.txtaddBrand.TabIndex = 722
        '
        'list_brand
        '
        Me.list_brand.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.list_brand.Appearance.Options.UseFont = True
        Me.list_brand.Appearance.Options.UseTextOptions = True
        Me.list_brand.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.list_brand.CheckOnClick = True
        Me.list_brand.ColumnWidth = 280
        Me.list_brand.ContextMenuStrip = Me.ContextBrand
        Me.list_brand.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.list_brand.HorizontalScrollbar = True
        Me.list_brand.HotTrackItems = True
        Me.list_brand.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick
        Me.list_brand.IncrementalSearch = True
        Me.list_brand.Location = New System.Drawing.Point(7, 35)
        Me.list_brand.Name = "list_brand"
        Me.list_brand.Size = New System.Drawing.Size(272, 314)
        Me.list_brand.TabIndex = 721
        '
        'ContextBrand
        '
        Me.ContextBrand.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdBrandEdit, Me.cmdBrandDelete, Me.ToolStripSeparator3, Me.cmdBrandRefresh})
        Me.ContextBrand.Name = "gridmenustrip"
        Me.ContextBrand.Size = New System.Drawing.Size(145, 76)
        '
        'cmdBrandEdit
        '
        Me.cmdBrandEdit.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.cmdBrandEdit.Name = "cmdBrandEdit"
        Me.cmdBrandEdit.Size = New System.Drawing.Size(144, 22)
        Me.cmdBrandEdit.Text = "Edit Item"
        '
        'cmdBrandDelete
        '
        Me.cmdBrandDelete.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus
        Me.cmdBrandDelete.Name = "cmdBrandDelete"
        Me.cmdBrandDelete.Size = New System.Drawing.Size(144, 22)
        Me.cmdBrandDelete.Text = "Remove Item"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(141, 6)
        '
        'cmdBrandRefresh
        '
        Me.cmdBrandRefresh.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.cmdBrandRefresh.Name = "cmdBrandRefresh"
        Me.cmdBrandRefresh.Size = New System.Drawing.Size(144, 22)
        Me.cmdBrandRefresh.Text = "Refresh Data"
        '
        'size
        '
        Me.size.EditValue = ""
        Me.size.EnterMoveNextControl = True
        Me.size.Location = New System.Drawing.Point(676, 141)
        Me.size.Name = "size"
        Me.size.Properties.ReadOnly = True
        Me.size.Properties.ValidateOnEnterKey = True
        Me.size.Size = New System.Drawing.Size(51, 20)
        Me.size.TabIndex = 720
        Me.size.Visible = False
        '
        'color
        '
        Me.color.EditValue = ""
        Me.color.EnterMoveNextControl = True
        Me.color.Location = New System.Drawing.Point(373, 141)
        Me.color.Name = "color"
        Me.color.Properties.ReadOnly = True
        Me.color.Properties.ValidateOnEnterKey = True
        Me.color.Size = New System.Drawing.Size(51, 20)
        Me.color.TabIndex = 719
        Me.color.Visible = False
        '
        'tabPreview
        '
        Me.tabPreview.Controls.Add(Me.ProgressBarControl1)
        Me.tabPreview.Controls.Add(Me.dgv)
        Me.tabPreview.Name = "tabPreview"
        Me.tabPreview.Size = New System.Drawing.Size(845, 381)
        Me.tabPreview.Text = "Product Preview List"
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarControl1.Location = New System.Drawing.Point(2, 360)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Properties.ShowTitle = True
        Me.ProgressBarControl1.Size = New System.Drawing.Size(841, 19)
        Me.ProgressBarControl1.TabIndex = 737
        Me.ProgressBarControl1.Visible = False
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv.Size = New System.Drawing.Size(845, 381)
        Me.dgv.TabIndex = 762
        '
        'catid
        '
        Me.catid.EditValue = ""
        Me.catid.EnterMoveNextControl = True
        Me.catid.Location = New System.Drawing.Point(576, 34)
        Me.catid.Name = "catid"
        Me.catid.Properties.ReadOnly = True
        Me.catid.Properties.ValidateOnEnterKey = True
        Me.catid.Size = New System.Drawing.Size(51, 20)
        Me.catid.TabIndex = 731
        Me.catid.Visible = False
        '
        'frmBatchingProduct
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 478)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.txtitem)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(368, 374)
        Me.Name = "frmBatchingProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Batching Registration"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextColor.ResumeLayout(False)
        CType(Me.list_color, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_size, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextSize.ResumeLayout(False)
        CType(Me.txtAddColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtitem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabOption.ResumeLayout(False)
        CType(Me.ckAllSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckAllColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckAllBrand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.brand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtaddBrand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_brand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextBrand.ResumeLayout(False)
        CType(Me.size.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.color.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPreview.ResumeLayout(False)
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextColor As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdColorRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarLargeButtonItem1 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarLargeButtonItem2 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents list_size As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents list_color As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents txtAddSize As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAddColor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabOption As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabPreview As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtitem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdUpload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ContextSize As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEditSize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRemoveSize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdSizeRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents size As DevExpress.XtraEditors.TextEdit
    Friend WithEvents color As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents brand As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtaddBrand As DevExpress.XtraEditors.TextEdit
    Friend WithEvents list_brand As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents ContextBrand As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdBrandEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdBrandDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdBrandRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents catid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckAllSize As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckAllColor As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckAllBrand As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
End Class
