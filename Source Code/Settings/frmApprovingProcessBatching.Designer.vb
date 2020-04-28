<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApprovingProcessBatching
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
        Me.grpCustomBranch = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.grpRequestType = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.ckRequireAttachment = New DevExpress.XtraEditors.CheckEdit()
        Me.ckCustomizedBranch = New DevExpress.XtraEditors.CheckEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtClient_AppTitle = New DevExpress.XtraEditors.TextEdit()
        Me.client_id = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtClient_processType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.client_mode = New DevExpress.XtraEditors.TextEdit()
        Me.cmdClientSave = New DevExpress.XtraEditors.SimpleButton()
        Me.ckClient_FinalApprover = New DevExpress.XtraEditors.CheckEdit()
        Me.authCode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtClient_level = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtUserPosition = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gv_clientUserPosition = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Em_client = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditApproverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.gv_clientProcess = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabSignatories = New DevExpress.XtraTab.XtraTabPage()
        Me.tabConfiguration = New DevExpress.XtraTab.XtraTabPage()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grpCustomBranch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpRequestType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckRequireAttachment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckCustomizedBranch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClient_AppTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.client_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClient_processType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.client_mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckClient_FinalApprover.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.authCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClient_level.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserPosition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_clientUserPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_client, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.gv_clientProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabSignatories.SuspendLayout()
        Me.tabConfiguration.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCustomBranch
        '
        Me.grpCustomBranch.CheckOnClick = True
        Me.grpCustomBranch.Enabled = False
        Me.grpCustomBranch.Location = New System.Drawing.Point(142, 54)
        Me.grpCustomBranch.Name = "grpCustomBranch"
        Me.grpCustomBranch.Size = New System.Drawing.Size(325, 185)
        Me.grpCustomBranch.TabIndex = 707
        '
        'grpRequestType
        '
        Me.grpRequestType.CheckOnClick = True
        Me.grpRequestType.Location = New System.Drawing.Point(142, 245)
        Me.grpRequestType.Name = "grpRequestType"
        Me.grpRequestType.Size = New System.Drawing.Size(325, 129)
        Me.grpRequestType.TabIndex = 706
        '
        'ckRequireAttachment
        '
        Me.ckRequireAttachment.Location = New System.Drawing.Point(150, 107)
        Me.ckRequireAttachment.Name = "ckRequireAttachment"
        Me.ckRequireAttachment.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckRequireAttachment.Properties.Appearance.Options.UseFont = True
        Me.ckRequireAttachment.Properties.Caption = "Required Attachment?"
        Me.ckRequireAttachment.Size = New System.Drawing.Size(144, 20)
        Me.ckRequireAttachment.TabIndex = 705
        '
        'ckCustomizedBranch
        '
        Me.ckCustomizedBranch.Location = New System.Drawing.Point(47, 52)
        Me.ckCustomizedBranch.Name = "ckCustomizedBranch"
        Me.ckCustomizedBranch.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckCustomizedBranch.Properties.Appearance.Options.UseFont = True
        Me.ckCustomizedBranch.Properties.Appearance.Options.UseTextOptions = True
        Me.ckCustomizedBranch.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ckCustomizedBranch.Properties.Caption = "Customized"
        Me.ckCustomizedBranch.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ckCustomizedBranch.Size = New System.Drawing.Size(91, 20)
        Me.ckCustomizedBranch.TabIndex = 702
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Location = New System.Drawing.Point(279, 131)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(73, 26)
        Me.SimpleButton2.TabIndex = 700
        Me.SimpleButton2.Text = "Cancel"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(86, 68)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl10.TabIndex = 698
        Me.LabelControl10.Text = "Report Title"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(68, 245)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl9.TabIndex = 697
        Me.LabelControl9.Text = "Request Type"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = Global.Coffeecup.My.Resources.Resources._129
        Me.SimpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(356, 42)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(18, 20)
        Me.SimpleButton1.TabIndex = 695
        '
        'txtClient_AppTitle
        '
        Me.txtClient_AppTitle.EditValue = ""
        Me.txtClient_AppTitle.Location = New System.Drawing.Point(151, 65)
        Me.txtClient_AppTitle.Name = "txtClient_AppTitle"
        Me.txtClient_AppTitle.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClient_AppTitle.Properties.Appearance.Options.UseFont = True
        Me.txtClient_AppTitle.Properties.Appearance.Options.UseTextOptions = True
        Me.txtClient_AppTitle.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtClient_AppTitle.Size = New System.Drawing.Size(201, 20)
        Me.txtClient_AppTitle.TabIndex = 694
        '
        'client_id
        '
        Me.client_id.Location = New System.Drawing.Point(227, 219)
        Me.client_id.Name = "client_id"
        Me.client_id.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.client_id.Properties.Appearance.Options.UseFont = True
        Me.client_id.Properties.Appearance.Options.UseTextOptions = True
        Me.client_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.client_id.Properties.ReadOnly = True
        Me.client_id.Size = New System.Drawing.Size(38, 20)
        Me.client_id.TabIndex = 693
        Me.client_id.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(142, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(131, 13)
        Me.LabelControl2.TabIndex = 692
        Me.LabelControl2.Text = "Please select process type"
        '
        'txtClient_processType
        '
        Me.txtClient_processType.EditValue = ""
        Me.txtClient_processType.Location = New System.Drawing.Point(142, 28)
        Me.txtClient_processType.Name = "txtClient_processType"
        Me.txtClient_processType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClient_processType.Properties.Appearance.Options.UseFont = True
        Me.txtClient_processType.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtClient_processType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtClient_processType.Properties.ImmediatePopup = True
        Me.txtClient_processType.Properties.Items.AddRange(New Object() {"Requisition Approving Process", "Purchase Order Signatories", "Stock Transfer Signatories", "Voucher Signatories", "FFE for Disposal"})
        Me.txtClient_processType.Properties.PopupSizeable = True
        Me.txtClient_processType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtClient_processType.Size = New System.Drawing.Size(309, 20)
        Me.txtClient_processType.TabIndex = 691
        '
        'client_mode
        '
        Me.client_mode.Location = New System.Drawing.Point(312, 219)
        Me.client_mode.Name = "client_mode"
        Me.client_mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.client_mode.Properties.Appearance.Options.UseFont = True
        Me.client_mode.Properties.Appearance.Options.UseTextOptions = True
        Me.client_mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.client_mode.Properties.ReadOnly = True
        Me.client_mode.Size = New System.Drawing.Size(38, 20)
        Me.client_mode.TabIndex = 526
        Me.client_mode.Visible = False
        '
        'cmdClientSave
        '
        Me.cmdClientSave.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdClientSave.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdClientSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClientSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdClientSave.Appearance.Options.UseBackColor = True
        Me.cmdClientSave.Appearance.Options.UseFont = True
        Me.cmdClientSave.Location = New System.Drawing.Point(151, 131)
        Me.cmdClientSave.Name = "cmdClientSave"
        Me.cmdClientSave.Size = New System.Drawing.Size(122, 26)
        Me.cmdClientSave.TabIndex = 5
        Me.cmdClientSave.Text = "Confirm && Save"
        '
        'ckClient_FinalApprover
        '
        Me.ckClient_FinalApprover.Location = New System.Drawing.Point(150, 88)
        Me.ckClient_FinalApprover.Name = "ckClient_FinalApprover"
        Me.ckClient_FinalApprover.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckClient_FinalApprover.Properties.Appearance.Options.UseFont = True
        Me.ckClient_FinalApprover.Properties.Caption = "Final Approver?"
        Me.ckClient_FinalApprover.Size = New System.Drawing.Size(104, 20)
        Me.ckClient_FinalApprover.TabIndex = 4
        '
        'authCode
        '
        Me.authCode.Location = New System.Drawing.Point(271, 219)
        Me.authCode.Name = "authCode"
        Me.authCode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authCode.Properties.Appearance.Options.UseFont = True
        Me.authCode.Properties.Appearance.Options.UseTextOptions = True
        Me.authCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.authCode.Properties.ReadOnly = True
        Me.authCode.Size = New System.Drawing.Size(38, 20)
        Me.authCode.TabIndex = 525
        Me.authCode.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(75, 22)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl3.TabIndex = 388
        Me.LabelControl3.Text = "Position Level"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(44, 45)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(101, 13)
        Me.LabelControl4.TabIndex = 523
        Me.LabelControl4.Text = "Select User Position"
        '
        'txtClient_level
        '
        Me.txtClient_level.EditValue = ""
        Me.txtClient_level.Location = New System.Drawing.Point(151, 19)
        Me.txtClient_level.Name = "txtClient_level"
        Me.txtClient_level.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClient_level.Properties.Appearance.Options.UseFont = True
        Me.txtClient_level.Properties.Appearance.Options.UseTextOptions = True
        Me.txtClient_level.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtClient_level.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtClient_level.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtClient_level.Properties.Items.AddRange(New Object() {"1st", "2nd", "3rd", "4th", "5th", "6th", "7th", "8th", "9th", "10th"})
        Me.txtClient_level.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtClient_level.Size = New System.Drawing.Size(81, 20)
        Me.txtClient_level.TabIndex = 0
        '
        'txtUserPosition
        '
        Me.txtUserPosition.EditValue = "Select Group"
        Me.txtUserPosition.Location = New System.Drawing.Point(151, 42)
        Me.txtUserPosition.Name = "txtUserPosition"
        Me.txtUserPosition.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserPosition.Properties.Appearance.Options.UseFont = True
        Me.txtUserPosition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtUserPosition.Properties.DisplayMember = "Position"
        Me.txtUserPosition.Properties.ImmediatePopup = True
        Me.txtUserPosition.Properties.NullText = ""
        Me.txtUserPosition.Properties.PopupView = Me.gv_clientUserPosition
        Me.txtUserPosition.Properties.ValueMember = "Position"
        Me.txtUserPosition.Size = New System.Drawing.Size(201, 20)
        Me.txtUserPosition.TabIndex = 1
        '
        'gv_clientUserPosition
        '
        Me.gv_clientUserPosition.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_clientUserPosition.Name = "gv_clientUserPosition"
        Me.gv_clientUserPosition.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_clientUserPosition.OptionsView.ShowGroupPanel = False
        '
        'Em_client
        '
        Me.Em_client.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em_client.Location = New System.Drawing.Point(16, 170)
        Me.Em_client.MainView = Me.gv_clientProcess
        Me.Em_client.Name = "Em_client"
        Me.Em_client.Size = New System.Drawing.Size(531, 256)
        Me.Em_client.TabIndex = 4
        Me.Em_client.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_clientProcess})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditApproverToolStripMenuItem, Me.ToolStripMenuItem4, Me.ToolStripSeparator1, Me.ToolStripMenuItem5})
        Me.ContextMenuStrip1.Name = "gridmenustrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(170, 76)
        '
        'EditApproverToolStripMenuItem
        '
        Me.EditApproverToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.EditApproverToolStripMenuItem.Name = "EditApproverToolStripMenuItem"
        Me.EditApproverToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.EditApproverToolStripMenuItem.Text = "Edit Approver"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = Global.Coffeecup.My.Resources.Resources.window_suppressed
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(169, 22)
        Me.ToolStripMenuItem4.Text = "Remove Approver"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(166, 6)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(169, 22)
        Me.ToolStripMenuItem5.Text = "Refresh Data"
        '
        'gv_clientProcess
        '
        Me.gv_clientProcess.GridControl = Me.Em_client
        Me.gv_clientProcess.Name = "gv_clientProcess"
        Me.gv_clientProcess.OptionsBehavior.Editable = False
        Me.gv_clientProcess.OptionsView.ShowGroupPanel = False
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Nothing
        Me.barDockControlTop.Size = New System.Drawing.Size(0, 0)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(22, 12)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabSignatories
        Me.XtraTabControl1.Size = New System.Drawing.Size(567, 473)
        Me.XtraTabControl1.TabIndex = 533
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabSignatories, Me.tabConfiguration})
        '
        'tabSignatories
        '
        Me.tabSignatories.Controls.Add(Me.client_id)
        Me.tabSignatories.Controls.Add(Me.txtClient_level)
        Me.tabSignatories.Controls.Add(Me.client_mode)
        Me.tabSignatories.Controls.Add(Me.txtUserPosition)
        Me.tabSignatories.Controls.Add(Me.authCode)
        Me.tabSignatories.Controls.Add(Me.ckRequireAttachment)
        Me.tabSignatories.Controls.Add(Me.LabelControl4)
        Me.tabSignatories.Controls.Add(Me.LabelControl3)
        Me.tabSignatories.Controls.Add(Me.ckClient_FinalApprover)
        Me.tabSignatories.Controls.Add(Me.SimpleButton2)
        Me.tabSignatories.Controls.Add(Me.cmdClientSave)
        Me.tabSignatories.Controls.Add(Me.txtClient_AppTitle)
        Me.tabSignatories.Controls.Add(Me.LabelControl10)
        Me.tabSignatories.Controls.Add(Me.SimpleButton1)
        Me.tabSignatories.Controls.Add(Me.Em_client)
        Me.tabSignatories.Name = "tabSignatories"
        Me.tabSignatories.Size = New System.Drawing.Size(565, 444)
        Me.tabSignatories.Text = "Signatories"
        '
        'tabConfiguration
        '
        Me.tabConfiguration.Controls.Add(Me.SimpleButton3)
        Me.tabConfiguration.Controls.Add(Me.grpRequestType)
        Me.tabConfiguration.Controls.Add(Me.grpCustomBranch)
        Me.tabConfiguration.Controls.Add(Me.txtClient_processType)
        Me.tabConfiguration.Controls.Add(Me.LabelControl9)
        Me.tabConfiguration.Controls.Add(Me.LabelControl2)
        Me.tabConfiguration.Controls.Add(Me.ckCustomizedBranch)
        Me.tabConfiguration.Name = "tabConfiguration"
        Me.tabConfiguration.Size = New System.Drawing.Size(565, 444)
        Me.tabConfiguration.Text = "Configuration"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton3.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.SimpleButton3.Appearance.Options.UseBackColor = True
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Location = New System.Drawing.Point(231, 392)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(122, 26)
        Me.SimpleButton3.TabIndex = 708
        Me.SimpleButton3.Text = "Confirm Upload"
        '
        'frmApprovingProcessBatching
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 497)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmApprovingProcessBatching"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coffeecup Approving Process Batching"
        CType(Me.grpCustomBranch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpRequestType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckRequireAttachment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckCustomizedBranch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClient_AppTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.client_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClient_processType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.client_mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckClient_FinalApprover.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.authCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClient_level.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserPosition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_clientUserPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_client, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.gv_clientProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabSignatories.ResumeLayout(False)
        Me.tabSignatories.PerformLayout()
        Me.tabConfiguration.ResumeLayout(False)
        Me.tabConfiguration.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents client_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClient_processType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents client_mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdClientSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ckClient_FinalApprover As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents authCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClient_level As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtUserPosition As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gv_clientUserPosition As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Em_client As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_clientProcess As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtClient_AppTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ckCustomizedBranch As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckRequireAttachment As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents grpCustomBranch As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents grpRequestType As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabSignatories As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabConfiguration As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EditApproverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
