<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockoutBatchRequest
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
        Me.Mainmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewAppearanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.Cm = New DevExpress.XtraGrid.GridControl()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.menuInventory = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.menuClear = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdSaveDraft = New DevExpress.XtraBars.BarButtonItem()
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.txtbatch = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.Stockouttypeid = New DevExpress.XtraEditors.TextEdit()
        Me.txtStockoutType = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.g_inventory = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtDateStockout = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSaveAndFinish = New DevExpress.XtraEditors.SimpleButton()
        Me.txtoffice = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridcompoffice = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblOffice = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.Mainmenu.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        CType(Me.txtbatch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stockouttypeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockoutType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g_inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateStockout.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateStockout.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtoffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridcompoffice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mainmenu
        '
        Me.Mainmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolRemove, Me.RefreshToolStripMenuItem, Me.ToolStripSeparator1, Me.ViewAppearanceToolStripMenuItem})
        Me.Mainmenu.Name = "ContextMenuStrip1"
        Me.Mainmenu.Size = New System.Drawing.Size(166, 76)
        '
        'toolRemove
        '
        Me.toolRemove.Image = Global.Coffeecup.My.Resources.Resources.blog__minus
        Me.toolRemove.Name = "toolRemove"
        Me.toolRemove.Size = New System.Drawing.Size(165, 22)
        Me.toolRemove.Text = "Removed Item"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(162, 6)
        '
        'ViewAppearanceToolStripMenuItem
        '
        Me.ViewAppearanceToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.edit
        Me.ViewAppearanceToolStripMenuItem.Name = "ViewAppearanceToolStripMenuItem"
        Me.ViewAppearanceToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ViewAppearanceToolStripMenuItem.Text = "View Appearance"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.ProgressBarControl1)
        Me.GroupControl2.Controls.Add(Me.Cm)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(341, 24)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(747, 467)
        Me.GroupControl2.TabIndex = 517
        Me.GroupControl2.Text = "Selected Particular for Stockout"
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarControl1.Location = New System.Drawing.Point(2, 446)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Properties.ShowTitle = True
        Me.ProgressBarControl1.Size = New System.Drawing.Size(743, 19)
        Me.ProgressBarControl1.TabIndex = 589
        Me.ProgressBarControl1.Visible = False
        '
        'Cm
        '
        Me.Cm.ContextMenuStrip = Me.Mainmenu
        Me.Cm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cm.Location = New System.Drawing.Point(2, 27)
        Me.Cm.MainView = Me.Gridview1
        Me.Cm.Name = "Cm"
        Me.Cm.Size = New System.Drawing.Size(743, 438)
        Me.Cm.TabIndex = 0
        Me.Cm.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview1, Me.GridView2})
        '
        'Gridview1
        '
        Me.Gridview1.GridControl = Me.Cm
        Me.Gridview1.Name = "Gridview1"
        Me.Gridview1.OptionsBehavior.Editable = False
        Me.Gridview1.OptionsSelection.MultiSelect = True
        Me.Gridview1.OptionsView.ColumnAutoWidth = False
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.Cm
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsSelection.UseIndicatorForSelection = False
        '
        'officeid
        '
        Me.officeid.EditValue = ""
        Me.officeid.EnterMoveNextControl = True
        Me.officeid.Location = New System.Drawing.Point(171, 247)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Properties.ValidateOnEnterKey = True
        Me.officeid.Size = New System.Drawing.Size(77, 20)
        Me.officeid.TabIndex = 565
        Me.officeid.Visible = False
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel2})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.menuInventory, Me.menuClear, Me.cmdSaveDraft})
        Me.BarManager1.MainMenu = Me.Bar1
        Me.BarManager1.MaxItemId = 12
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 2"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(351, 168)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.menuInventory, True)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.MultiLine = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Custom 2"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "&Close Window"
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'menuInventory
        '
        Me.menuInventory.Caption = "&Browse Inventory (Shortcut Key - Insert)"
        Me.menuInventory.Id = 6
        Me.menuInventory.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuInventory.ItemAppearance.Normal.Options.UseFont = True
        Me.menuInventory.Name = "menuInventory"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1088, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 491)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1088, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 467)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1088, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 467)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Close Window"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Inventory Category"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "BarButtonItem3"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'menuClear
        '
        Me.menuClear.Caption = "Clea&r Fields"
        Me.menuClear.Id = 9
        Me.menuClear.Name = "menuClear"
        '
        'cmdSaveDraft
        '
        Me.cmdSaveDraft.Caption = "&Save as Draft"
        Me.cmdSaveDraft.Id = 10
        Me.cmdSaveDraft.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdSaveDraft.ItemAppearance.Normal.Options.UseFont = True
        Me.cmdSaveDraft.ItemInMenuAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveDraft.ItemInMenuAppearance.Normal.Options.UseFont = True
        Me.cmdSaveDraft.Name = "cmdSaveDraft"
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel2.FloatVertical = True
        Me.DockPanel2.ID = New System.Guid("6d157c96-e269-47a6-afd0-dcfba310a845")
        Me.DockPanel2.Location = New System.Drawing.Point(0, 24)
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.Options.ShowCloseButton = False
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(341, 122)
        Me.DockPanel2.SavedSizeFactor = 0.0R
        Me.DockPanel2.Size = New System.Drawing.Size(341, 467)
        Me.DockPanel2.Text = "Stockout Details"
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.txtbatch)
        Me.DockPanel2_Container.Controls.Add(Me.LabelControl2)
        Me.DockPanel2_Container.Controls.Add(Me.Stockouttypeid)
        Me.DockPanel2_Container.Controls.Add(Me.officeid)
        Me.DockPanel2_Container.Controls.Add(Me.txtStockoutType)
        Me.DockPanel2_Container.Controls.Add(Me.txtDateStockout)
        Me.DockPanel2_Container.Controls.Add(Me.LabelControl3)
        Me.DockPanel2_Container.Controls.Add(Me.cmdSaveAndFinish)
        Me.DockPanel2_Container.Controls.Add(Me.txtoffice)
        Me.DockPanel2_Container.Controls.Add(Me.lblOffice)
        Me.DockPanel2_Container.Controls.Add(Me.LabelControl4)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(3, 30)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(334, 434)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'txtbatch
        '
        Me.txtbatch.EditValue = "SYSTEM GENERATED"
        Me.txtbatch.Location = New System.Drawing.Point(102, 9)
        Me.txtbatch.Name = "txtbatch"
        Me.txtbatch.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtbatch.Properties.Appearance.Options.UseFont = True
        Me.txtbatch.Properties.Appearance.Options.UseForeColor = True
        Me.txtbatch.Properties.Appearance.Options.UseTextOptions = True
        Me.txtbatch.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtbatch.Properties.ReadOnly = True
        Me.txtbatch.Properties.ValidateOnEnterKey = True
        Me.txtbatch.Size = New System.Drawing.Size(149, 20)
        Me.txtbatch.TabIndex = 531
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Location = New System.Drawing.Point(19, 60)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(76, 15)
        Me.LabelControl2.TabIndex = 597
        Me.LabelControl2.Text = "Stockout Type"
        '
        'Stockouttypeid
        '
        Me.Stockouttypeid.EditValue = ""
        Me.Stockouttypeid.EnterMoveNextControl = True
        Me.Stockouttypeid.Location = New System.Drawing.Point(171, 273)
        Me.Stockouttypeid.Name = "Stockouttypeid"
        Me.Stockouttypeid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stockouttypeid.Properties.Appearance.Options.UseFont = True
        Me.Stockouttypeid.Properties.Appearance.Options.UseTextOptions = True
        Me.Stockouttypeid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Stockouttypeid.Properties.ReadOnly = True
        Me.Stockouttypeid.Size = New System.Drawing.Size(81, 20)
        Me.Stockouttypeid.TabIndex = 596
        Me.Stockouttypeid.Visible = False
        '
        'txtStockoutType
        '
        Me.txtStockoutType.EditValue = ""
        Me.txtStockoutType.Location = New System.Drawing.Point(102, 57)
        Me.txtStockoutType.Name = "txtStockoutType"
        Me.txtStockoutType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtStockoutType.Properties.Appearance.Options.UseFont = True
        Me.txtStockoutType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtStockoutType.Properties.DisplayMember = "Select"
        Me.txtStockoutType.Properties.NullText = ""
        Me.txtStockoutType.Properties.PopupView = Me.g_inventory
        Me.txtStockoutType.Properties.ValueMember = "Stockouttypeid"
        Me.txtStockoutType.Size = New System.Drawing.Size(218, 22)
        Me.txtStockoutType.TabIndex = 1
        Me.txtStockoutType.ToolTip = "Shortcut Key (F12)"
        '
        'g_inventory
        '
        Me.g_inventory.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.g_inventory.Name = "g_inventory"
        Me.g_inventory.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.g_inventory.OptionsView.ShowGroupPanel = False
        '
        'txtDateStockout
        '
        Me.txtDateStockout.EditValue = New Date(CType(0, Long))
        Me.txtDateStockout.EnterMoveNextControl = True
        Me.txtDateStockout.Location = New System.Drawing.Point(102, 82)
        Me.txtDateStockout.Name = "txtDateStockout"
        Me.txtDateStockout.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtDateStockout.Properties.Appearance.Options.UseFont = True
        Me.txtDateStockout.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateStockout.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDateStockout.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtDateStockout.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDateStockout.Size = New System.Drawing.Size(149, 22)
        Me.txtDateStockout.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(21, 85)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(74, 15)
        Me.LabelControl3.TabIndex = 527
        Me.LabelControl3.Text = "Stockout Date"
        '
        'cmdSaveAndFinish
        '
        Me.cmdSaveAndFinish.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.cmdSaveAndFinish.Appearance.Options.UseFont = True
        Me.cmdSaveAndFinish.Location = New System.Drawing.Point(72, 119)
        Me.cmdSaveAndFinish.Name = "cmdSaveAndFinish"
        Me.cmdSaveAndFinish.Size = New System.Drawing.Size(207, 29)
        Me.cmdSaveAndFinish.TabIndex = 6
        Me.cmdSaveAndFinish.Text = "Confirm Deduct Inventory"
        '
        'txtoffice
        '
        Me.txtoffice.EditValue = ""
        Me.txtoffice.Location = New System.Drawing.Point(102, 32)
        Me.txtoffice.Name = "txtoffice"
        Me.txtoffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtoffice.Properties.Appearance.Options.UseFont = True
        Me.txtoffice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtoffice.Properties.DisplayMember = "Select Office"
        Me.txtoffice.Properties.NullText = ""
        Me.txtoffice.Properties.PopupView = Me.gridcompoffice
        Me.txtoffice.Properties.ValueMember = "Select Office"
        Me.txtoffice.Size = New System.Drawing.Size(218, 22)
        Me.txtoffice.TabIndex = 0
        '
        'gridcompoffice
        '
        Me.gridcompoffice.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridcompoffice.Name = "gridcompoffice"
        Me.gridcompoffice.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridcompoffice.OptionsView.ShowGroupPanel = False
        '
        'lblOffice
        '
        Me.lblOffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.lblOffice.Appearance.Options.UseFont = True
        Me.lblOffice.Appearance.Options.UseTextOptions = True
        Me.lblOffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblOffice.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblOffice.Location = New System.Drawing.Point(3, 35)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(91, 14)
        Me.lblOffice.TabIndex = 531
        Me.lblOffice.Text = "Inventory From"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(31, 12)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl4.TabIndex = 573
        Me.LabelControl4.Text = "Batch Code"
        '
        'frmStockoutBatchRequest
        '
        Me.AcceptButton = Me.cmdSaveAndFinish
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 491)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.DockPanel2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmStockoutBatchRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Batching Stockout"
        Me.Mainmenu.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        Me.DockPanel2_Container.PerformLayout()
        CType(Me.txtbatch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stockouttypeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockoutType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g_inventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateStockout.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateStockout.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtoffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridcompoffice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Cm As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents Mainmenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents toolRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuInventory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuClear As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSaveDraft As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ViewAppearanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtoffice As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridcompoffice As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblOffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSaveAndFinish As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDateStockout As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Stockouttypeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStockoutType As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents g_inventory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents txtbatch As DevExpress.XtraEditors.TextEdit
End Class
