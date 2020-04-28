<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollEmployeeManagement
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.cmdClose = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.lblstatus = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Print201FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdUpdateEmployee = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSetCompany = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSetEmployeeType = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetEmployeeLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSetPosition = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdChangeShift = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdActiveInactive = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdResigned = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdResetAttendance = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmployeeType = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gv_EmployeeType = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.typecode = New DevExpress.XtraEditors.TextEdit()
        Me.ckViewAllType = New DevExpress.XtraEditors.CheckEdit()
        Me.ckViewAllOffice = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtOffice = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.grid_office = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.ckResigned = New DevExpress.XtraEditors.CheckEdit()
        Me.ckActived = New DevExpress.XtraEditors.CheckEdit()
        Me.txtSearch = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabEmployeeList = New DevExpress.XtraTab.XtraTabPage()
        Me.tabBirthDay = New DevExpress.XtraTab.XtraTabPage()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Em_birthday = New DevExpress.XtraGrid.GridControl()
        Me.gridBirthDay = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtBirthMonth = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmployeeType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_EmployeeType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.typecode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckViewAllType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckViewAllOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_office, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckResigned.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckActived.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabEmployeeList.SuspendLayout()
        Me.tabBirthDay.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_birthday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridBirthDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBirthMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdClose, Me.lblstatus, Me.BarButtonItem1, Me.BarEditItem1, Me.BarButtonItem2, Me.BarButtonItem3})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 10
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdClose), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'cmdClose
        '
        Me.cmdClose.Caption = "Close Window"
        Me.cmdClose.Id = 0
        Me.cmdClose.Name = "cmdClose"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Print Report"
        Me.BarButtonItem1.Id = 6
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Export to Excel"
        Me.BarButtonItem2.Id = 8
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Column Settings"
        Me.BarButtonItem3.Id = 9
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1018, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 593)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1018, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 569)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1018, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 569)
        '
        'lblstatus
        '
        Me.lblstatus.Caption = "Ready"
        Me.lblstatus.Id = 5
        Me.lblstatus.Name = "lblstatus"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemTextEdit1
        Me.BarEditItem1.Id = 7
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.gridview1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(1016, 447)
        Me.Em.TabIndex = 3
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridview1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.Print201FileToolStripMenuItem, Me.cmdUpdateEmployee, Me.cmdResetAttendance, Me.ToolStripSeparator2, Me.ToolStripMenuItem3})
        Me.ContextMenuStrip1.Name = "gridmenustrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(220, 120)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(219, 22)
        Me.ToolStripMenuItem1.Text = "Edit Employee"
        '
        'Print201FileToolStripMenuItem
        '
        Me.Print201FileToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.Printer__2_
        Me.Print201FileToolStripMenuItem.Name = "Print201FileToolStripMenuItem"
        Me.Print201FileToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.Print201FileToolStripMenuItem.Text = "Print 201 Employee File"
        '
        'cmdUpdateEmployee
        '
        Me.cmdUpdateEmployee.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSetCompany, Me.cmdSetEmployeeType, Me.SetEmployeeLevelToolStripMenuItem, Me.cmdSetPosition, Me.cmdChangeShift, Me.cmdActiveInactive, Me.ToolStripSeparator1, Me.cmdResigned})
        Me.cmdUpdateEmployee.Image = Global.Coffeecup.My.Resources.Resources.User__3_
        Me.cmdUpdateEmployee.Name = "cmdUpdateEmployee"
        Me.cmdUpdateEmployee.Size = New System.Drawing.Size(219, 22)
        Me.cmdUpdateEmployee.Text = "Update Employee Status"
        '
        'cmdSetCompany
        '
        Me.cmdSetCompany.Image = Global.Coffeecup.My.Resources.Resources.building__arrow
        Me.cmdSetCompany.Name = "cmdSetCompany"
        Me.cmdSetCompany.Size = New System.Drawing.Size(193, 22)
        Me.cmdSetCompany.Text = "Change Office"
        '
        'cmdSetEmployeeType
        '
        Me.cmdSetEmployeeType.Image = Global.Coffeecup.My.Resources.Resources.user_business_gray
        Me.cmdSetEmployeeType.Name = "cmdSetEmployeeType"
        Me.cmdSetEmployeeType.Size = New System.Drawing.Size(193, 22)
        Me.cmdSetEmployeeType.Text = "Employee Status"
        '
        'SetEmployeeLevelToolStripMenuItem
        '
        Me.SetEmployeeLevelToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources._032
        Me.SetEmployeeLevelToolStripMenuItem.Name = "SetEmployeeLevelToolStripMenuItem"
        Me.SetEmployeeLevelToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.SetEmployeeLevelToolStripMenuItem.Text = "Set Employee Level"
        '
        'cmdSetPosition
        '
        Me.cmdSetPosition.Image = Global.Coffeecup.My.Resources.Resources.card_address1
        Me.cmdSetPosition.Name = "cmdSetPosition"
        Me.cmdSetPosition.Size = New System.Drawing.Size(193, 22)
        Me.cmdSetPosition.Text = "Update Employee Rate"
        '
        'cmdChangeShift
        '
        Me.cmdChangeShift.Image = Global.Coffeecup.My.Resources.Resources.Time_Normal
        Me.cmdChangeShift.Name = "cmdChangeShift"
        Me.cmdChangeShift.Size = New System.Drawing.Size(193, 22)
        Me.cmdChangeShift.Text = "Change Shift"
        '
        'cmdActiveInactive
        '
        Me.cmdActiveInactive.Image = Global.Coffeecup.My.Resources.Resources.layers_arrange
        Me.cmdActiveInactive.Name = "cmdActiveInactive"
        Me.cmdActiveInactive.Size = New System.Drawing.Size(193, 22)
        Me.cmdActiveInactive.Text = "Active/Inactive"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(190, 6)
        '
        'cmdResigned
        '
        Me.cmdResigned.Image = Global.Coffeecup.My.Resources.Resources.user__minus
        Me.cmdResigned.Name = "cmdResigned"
        Me.cmdResigned.Size = New System.Drawing.Size(193, 22)
        Me.cmdResigned.Text = "Resigned/Unresigned"
        '
        'cmdResetAttendance
        '
        Me.cmdResetAttendance.Image = Global.Coffeecup.My.Resources.Resources.lock1
        Me.cmdResetAttendance.Name = "cmdResetAttendance"
        Me.cmdResetAttendance.Size = New System.Drawing.Size(219, 22)
        Me.cmdResetAttendance.Text = "Reset Attendance Password"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(216, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(219, 22)
        Me.ToolStripMenuItem3.Text = "Refresh Data"
        '
        'gridview1
        '
        Me.gridview1.GridControl = Me.Em
        Me.gridview1.Name = "gridview1"
        Me.gridview1.OptionsBehavior.Editable = False
        Me.gridview1.OptionsSelection.MultiSelect = True
        Me.gridview1.OptionsView.ColumnAutoWidth = False
        Me.gridview1.OptionsView.RowAutoHeight = True
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(25, 61)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(87, 15)
        Me.LabelControl13.TabIndex = 709
        Me.LabelControl13.Text = "Employee Status"
        '
        'txtEmployeeType
        '
        Me.txtEmployeeType.Location = New System.Drawing.Point(118, 58)
        Me.txtEmployeeType.MenuManager = Me.BarManager1
        Me.txtEmployeeType.Name = "txtEmployeeType"
        Me.txtEmployeeType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtEmployeeType.Properties.Appearance.Options.UseFont = True
        Me.txtEmployeeType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtEmployeeType.Properties.DisplayMember = "Select"
        Me.txtEmployeeType.Properties.NullText = ""
        Me.txtEmployeeType.Properties.PopupView = Me.gv_EmployeeType
        Me.txtEmployeeType.Properties.ValueMember = "Select"
        Me.txtEmployeeType.Size = New System.Drawing.Size(258, 22)
        Me.txtEmployeeType.TabIndex = 710
        '
        'gv_EmployeeType
        '
        Me.gv_EmployeeType.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_EmployeeType.Name = "gv_EmployeeType"
        Me.gv_EmployeeType.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_EmployeeType.OptionsView.ShowGroupPanel = False
        '
        'typecode
        '
        Me.typecode.EnterMoveNextControl = True
        Me.typecode.Location = New System.Drawing.Point(487, 65)
        Me.typecode.Name = "typecode"
        Me.typecode.Size = New System.Drawing.Size(57, 20)
        Me.typecode.TabIndex = 717
        Me.typecode.Visible = False
        '
        'ckViewAllType
        '
        Me.ckViewAllType.EditValue = True
        Me.ckViewAllType.Location = New System.Drawing.Point(382, 60)
        Me.ckViewAllType.MenuManager = Me.BarManager1
        Me.ckViewAllType.Name = "ckViewAllType"
        Me.ckViewAllType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckViewAllType.Properties.Appearance.Options.UseFont = True
        Me.ckViewAllType.Properties.Caption = "View All"
        Me.ckViewAllType.Size = New System.Drawing.Size(83, 20)
        Me.ckViewAllType.TabIndex = 718
        '
        'ckViewAllOffice
        '
        Me.ckViewAllOffice.Location = New System.Drawing.Point(382, 35)
        Me.ckViewAllOffice.MenuManager = Me.BarManager1
        Me.ckViewAllOffice.Name = "ckViewAllOffice"
        Me.ckViewAllOffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckViewAllOffice.Properties.Appearance.Options.UseFont = True
        Me.ckViewAllOffice.Properties.Caption = "View All"
        Me.ckViewAllOffice.Size = New System.Drawing.Size(83, 20)
        Me.ckViewAllOffice.TabIndex = 726
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(46, 36)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(66, 15)
        Me.LabelControl3.TabIndex = 724
        Me.LabelControl3.Text = "Select Office"
        '
        'txtOffice
        '
        Me.txtOffice.Location = New System.Drawing.Point(118, 33)
        Me.txtOffice.MenuManager = Me.BarManager1
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtOffice.Properties.Appearance.Options.UseFont = True
        Me.txtOffice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOffice.Properties.DisplayMember = "Select"
        Me.txtOffice.Properties.NullText = ""
        Me.txtOffice.Properties.PopupView = Me.grid_office
        Me.txtOffice.Properties.ValueMember = "Select"
        Me.txtOffice.Size = New System.Drawing.Size(258, 22)
        Me.txtOffice.TabIndex = 725
        '
        'grid_office
        '
        Me.grid_office.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.grid_office.Name = "grid_office"
        Me.grid_office.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_office.OptionsView.ShowGroupPanel = False
        '
        'officeid
        '
        Me.officeid.EnterMoveNextControl = True
        Me.officeid.Location = New System.Drawing.Point(487, 39)
        Me.officeid.Name = "officeid"
        Me.officeid.Size = New System.Drawing.Size(57, 20)
        Me.officeid.TabIndex = 732
        Me.officeid.Visible = False
        '
        'ckResigned
        '
        Me.ckResigned.Location = New System.Drawing.Point(118, 86)
        Me.ckResigned.MenuManager = Me.BarManager1
        Me.ckResigned.Name = "ckResigned"
        Me.ckResigned.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckResigned.Properties.Appearance.Options.UseFont = True
        Me.ckResigned.Properties.Caption = "Resigned"
        Me.ckResigned.Size = New System.Drawing.Size(73, 20)
        Me.ckResigned.TabIndex = 738
        '
        'ckActived
        '
        Me.ckActived.EditValue = True
        Me.ckActived.Location = New System.Drawing.Point(197, 86)
        Me.ckActived.MenuManager = Me.BarManager1
        Me.ckActived.Name = "ckActived"
        Me.ckActived.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckActived.Properties.Appearance.Options.UseFont = True
        Me.ckActived.Properties.Caption = "Actived"
        Me.ckActived.Size = New System.Drawing.Size(83, 20)
        Me.ckActived.TabIndex = 739
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(808, 83)
        Me.txtSearch.MenuManager = Me.BarManager1
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtSearch.Properties.Appearance.Options.UseFont = True
        Me.txtSearch.Properties.NullValuePrompt = "Advance Search.."
        Me.txtSearch.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtSearch.Size = New System.Drawing.Size(205, 22)
        Me.txtSearch.TabIndex = 745
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(713, 86)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(89, 15)
        Me.LabelControl4.TabIndex = 746
        Me.LabelControl4.Text = "Search Keywords"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 112)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabEmployeeList
        Me.XtraTabControl1.Size = New System.Drawing.Size(1018, 480)
        Me.XtraTabControl1.TabIndex = 752
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabEmployeeList, Me.tabBirthDay})
        '
        'tabEmployeeList
        '
        Me.tabEmployeeList.Controls.Add(Me.Em)
        Me.tabEmployeeList.Name = "tabEmployeeList"
        Me.tabEmployeeList.Size = New System.Drawing.Size(1016, 447)
        Me.tabEmployeeList.Text = "Employee List"
        '
        'tabBirthDay
        '
        Me.tabBirthDay.Controls.Add(Me.CheckEdit1)
        Me.tabBirthDay.Controls.Add(Me.LabelControl1)
        Me.tabBirthDay.Controls.Add(Me.Em_birthday)
        Me.tabBirthDay.Controls.Add(Me.txtBirthMonth)
        Me.tabBirthDay.Name = "tabBirthDay"
        Me.tabBirthDay.Size = New System.Drawing.Size(1016, 447)
        Me.tabBirthDay.Text = "Birthday List"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(381, 16)
        Me.CheckEdit1.MenuManager = Me.BarManager1
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "View All"
        Me.CheckEdit1.Size = New System.Drawing.Size(83, 20)
        Me.CheckEdit1.TabIndex = 740
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(11, 20)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(98, 15)
        Me.LabelControl1.TabIndex = 725
        Me.LabelControl1.Text = "Select Birth Month"
        '
        'Em_birthday
        '
        Me.Em_birthday.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em_birthday.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em_birthday.Location = New System.Drawing.Point(0, 53)
        Me.Em_birthday.MainView = Me.gridBirthDay
        Me.Em_birthday.Name = "Em_birthday"
        Me.Em_birthday.Size = New System.Drawing.Size(1016, 394)
        Me.Em_birthday.TabIndex = 4
        Me.Em_birthday.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridBirthDay})
        '
        'gridBirthDay
        '
        Me.gridBirthDay.GridControl = Me.Em_birthday
        Me.gridBirthDay.Name = "gridBirthDay"
        Me.gridBirthDay.OptionsBehavior.Editable = False
        Me.gridBirthDay.OptionsSelection.MultiSelect = True
        Me.gridBirthDay.OptionsView.ColumnAutoWidth = False
        Me.gridBirthDay.OptionsView.RowAutoHeight = True
        '
        'txtBirthMonth
        '
        Me.txtBirthMonth.Location = New System.Drawing.Point(117, 15)
        Me.txtBirthMonth.MenuManager = Me.BarManager1
        Me.txtBirthMonth.Name = "txtBirthMonth"
        Me.txtBirthMonth.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtBirthMonth.Properties.Appearance.Options.UseFont = True
        Me.txtBirthMonth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtBirthMonth.Properties.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.txtBirthMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtBirthMonth.Size = New System.Drawing.Size(258, 24)
        Me.txtBirthMonth.TabIndex = 4
        '
        'frmPayrollEmployeeManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 593)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.ckActived)
        Me.Controls.Add(Me.ckResigned)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.ckViewAllOffice)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.ckViewAllType)
        Me.Controls.Add(Me.typecode)
        Me.Controls.Add(Me.txtEmployeeType)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.txtOffice)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPayrollEmployeeManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Management"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmployeeType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_EmployeeType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.typecode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckViewAllType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckViewAllOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_office, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckResigned.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckActived.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabEmployeeList.ResumeLayout(False)
        Me.tabBirthDay.ResumeLayout(False)
        Me.tabBirthDay.PerformLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_birthday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridBirthDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBirthMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents lblstatus As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmployeeType As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gv_EmployeeType As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents typecode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckViewAllType As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckViewAllOffice As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOffice As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents grid_office As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdUpdateEmployee As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSetPosition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSetCompany As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSetEmployeeType As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdChangeShift As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdResigned As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdResetAttendance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdActiveInactive As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ckActived As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckResigned As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SetEmployeeLevelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabEmployeeList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabBirthDay As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em_birthday As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridBirthDay As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBirthMonth As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Print201FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
