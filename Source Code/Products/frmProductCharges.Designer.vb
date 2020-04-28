<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductCharges
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
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabCharges = New DevExpress.XtraTab.XtraTabPage()
        Me.chargescode = New DevExpress.XtraEditors.TextEdit()
        Me.Em_charges = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit_charges = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete_charges = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableDisableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gridview2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.txtChargesName = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gvChargesName = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.radChargesType = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtChargesRate = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSaveCharges = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCategory = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridCategory = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.catid = New DevExpress.XtraEditors.TextEdit()
        Me.tabFilter = New DevExpress.XtraTab.XtraTabPage()
        Me.cmdMoveLeft = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdMoveRight = New DevExpress.XtraEditors.SimpleButton()
        Me.Em_unfiltered = New DevExpress.XtraGrid.GridControl()
        Me.gridunfiltered = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Em_filtered = New DevExpress.XtraGrid.GridControl()
        Me.gridfiltered = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabCharges.SuspendLayout()
        CType(Me.chargescode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_charges, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Gridview2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChargesName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvChargesName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radChargesType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChargesRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFilter.SuspendLayout()
        CType(Me.Em_unfiltered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridunfiltered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_filtered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridfiltered, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabCharges
        Me.XtraTabControl1.Size = New System.Drawing.Size(620, 525)
        Me.XtraTabControl1.TabIndex = 608
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabCharges, Me.tabFilter})
        '
        'tabCharges
        '
        Me.tabCharges.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCharges.Appearance.Header.Options.UseFont = True
        Me.tabCharges.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCharges.Appearance.HeaderActive.Options.UseFont = True
        Me.tabCharges.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCharges.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabCharges.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCharges.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabCharges.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCharges.Appearance.PageClient.Options.UseFont = True
        Me.tabCharges.Controls.Add(Me.chargescode)
        Me.tabCharges.Controls.Add(Me.Em_charges)
        Me.tabCharges.Controls.Add(Me.HyperlinkLabelControl1)
        Me.tabCharges.Controls.Add(Me.txtChargesName)
        Me.tabCharges.Controls.Add(Me.id)
        Me.tabCharges.Controls.Add(Me.mode)
        Me.tabCharges.Controls.Add(Me.LabelControl8)
        Me.tabCharges.Controls.Add(Me.radChargesType)
        Me.tabCharges.Controls.Add(Me.LabelControl9)
        Me.tabCharges.Controls.Add(Me.LabelControl11)
        Me.tabCharges.Controls.Add(Me.txtChargesRate)
        Me.tabCharges.Controls.Add(Me.cmdSaveCharges)
        Me.tabCharges.Controls.Add(Me.LabelControl12)
        Me.tabCharges.Controls.Add(Me.txtCategory)
        Me.tabCharges.Controls.Add(Me.catid)
        Me.tabCharges.Name = "tabCharges"
        Me.tabCharges.Size = New System.Drawing.Size(618, 494)
        Me.tabCharges.Text = "Client Product Charges"
        '
        'chargescode
        '
        Me.chargescode.EditValue = ""
        Me.chargescode.Location = New System.Drawing.Point(554, 98)
        Me.chargescode.Name = "chargescode"
        Me.chargescode.Properties.Appearance.Options.UseTextOptions = True
        Me.chargescode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.chargescode.Size = New System.Drawing.Size(53, 20)
        Me.chargescode.TabIndex = 708
        Me.chargescode.Visible = False
        '
        'Em_charges
        '
        Me.Em_charges.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em_charges.ContextMenuStrip = Me.ContextMenuStrip1
        GridLevelNode1.RelationName = "Level1"
        Me.Em_charges.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Em_charges.Location = New System.Drawing.Point(5, 173)
        Me.Em_charges.MainView = Me.Gridview2
        Me.Em_charges.Name = "Em_charges"
        Me.Em_charges.Size = New System.Drawing.Size(610, 319)
        Me.Em_charges.TabIndex = 694
        Me.Em_charges.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview2})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit_charges, Me.cmdDelete_charges, Me.EnableDisableToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshListToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "gridmenustrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(164, 98)
        '
        'cmdEdit_charges
        '
        Me.cmdEdit_charges.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.cmdEdit_charges.Name = "cmdEdit_charges"
        Me.cmdEdit_charges.Size = New System.Drawing.Size(163, 22)
        Me.cmdEdit_charges.Text = "Edit Charges"
        '
        'cmdDelete_charges
        '
        Me.cmdDelete_charges.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus
        Me.cmdDelete_charges.Name = "cmdDelete_charges"
        Me.cmdDelete_charges.Size = New System.Drawing.Size(163, 22)
        Me.cmdDelete_charges.Text = "Remove Charges"
        '
        'EnableDisableToolStripMenuItem
        '
        Me.EnableDisableToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources._151
        Me.EnableDisableToolStripMenuItem.Name = "EnableDisableToolStripMenuItem"
        Me.EnableDisableToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.EnableDisableToolStripMenuItem.Text = "Enable/Disable"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(160, 6)
        '
        'RefreshListToolStripMenuItem
        '
        Me.RefreshListToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshListToolStripMenuItem.Name = "RefreshListToolStripMenuItem"
        Me.RefreshListToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.RefreshListToolStripMenuItem.Text = "Refresh List"
        '
        'Gridview2
        '
        Me.Gridview2.GridControl = Me.Em_charges
        Me.Gridview2.Name = "Gridview2"
        Me.Gridview2.OptionsBehavior.Editable = False
        Me.Gridview2.OptionsSelection.MultiSelect = True
        Me.Gridview2.OptionsView.ShowGroupPanel = False
        '
        'HyperlinkLabelControl1
        '
        Me.HyperlinkLabelControl1.Location = New System.Drawing.Point(151, 22)
        Me.HyperlinkLabelControl1.Name = "HyperlinkLabelControl1"
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(74, 13)
        Me.HyperlinkLabelControl1.TabIndex = 707
        Me.HyperlinkLabelControl1.Text = "Charges Name"
        '
        'txtChargesName
        '
        Me.txtChargesName.EditValue = ""
        Me.txtChargesName.Location = New System.Drawing.Point(232, 19)
        Me.txtChargesName.Name = "txtChargesName"
        Me.txtChargesName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtChargesName.Properties.Appearance.Options.UseFont = True
        Me.txtChargesName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtChargesName.Properties.DisplayMember = "Description"
        Me.txtChargesName.Properties.NullText = ""
        Me.txtChargesName.Properties.PopupView = Me.gvChargesName
        Me.txtChargesName.Properties.ValueMember = "id"
        Me.txtChargesName.Size = New System.Drawing.Size(273, 22)
        Me.txtChargesName.TabIndex = 705
        '
        'gvChargesName
        '
        Me.gvChargesName.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvChargesName.Name = "gvChargesName"
        Me.gvChargesName.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvChargesName.OptionsView.ShowGroupPanel = False
        '
        'id
        '
        Me.id.EditValue = ""
        Me.id.Location = New System.Drawing.Point(554, 69)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Options.UseTextOptions = True
        Me.id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.id.Size = New System.Drawing.Size(53, 20)
        Me.id.TabIndex = 704
        Me.id.Visible = False
        '
        'mode
        '
        Me.mode.EditValue = ""
        Me.mode.Location = New System.Drawing.Point(554, 43)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Size = New System.Drawing.Size(53, 20)
        Me.mode.TabIndex = 703
        Me.mode.Visible = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(153, 73)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(72, 15)
        Me.LabelControl8.TabIndex = 702
        Me.LabelControl8.Text = "Charges Type"
        '
        'radChargesType
        '
        Me.radChargesType.EditValue = "amount"
        Me.radChargesType.Location = New System.Drawing.Point(232, 69)
        Me.radChargesType.Name = "radChargesType"
        Me.radChargesType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.radChargesType.Properties.Appearance.Options.UseFont = True
        Me.radChargesType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("amount", "Amount"), New DevExpress.XtraEditors.Controls.RadioGroupItem("percent", "Percent")})
        Me.radChargesType.Size = New System.Drawing.Size(273, 24)
        Me.radChargesType.TabIndex = 701
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(347, 100)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(54, 15)
        Me.LabelControl9.TabIndex = 700
        Me.LabelControl9.Text = "/ Quantity"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(156, 101)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(69, 15)
        Me.LabelControl11.TabIndex = 698
        Me.LabelControl11.Text = "Charges Rate"
        '
        'txtChargesRate
        '
        Me.txtChargesRate.EditValue = ""
        Me.txtChargesRate.Location = New System.Drawing.Point(232, 96)
        Me.txtChargesRate.Name = "txtChargesRate"
        Me.txtChargesRate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtChargesRate.Properties.Appearance.Options.UseFont = True
        Me.txtChargesRate.Properties.Appearance.Options.UseTextOptions = True
        Me.txtChargesRate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtChargesRate.Properties.Mask.EditMask = "n"
        Me.txtChargesRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtChargesRate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtChargesRate.Size = New System.Drawing.Size(110, 22)
        Me.txtChargesRate.TabIndex = 693
        '
        'cmdSaveCharges
        '
        Me.cmdSaveCharges.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdSaveCharges.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveCharges.Appearance.Options.UseFont = True
        Me.cmdSaveCharges.Location = New System.Drawing.Point(232, 122)
        Me.cmdSaveCharges.Name = "cmdSaveCharges"
        Me.cmdSaveCharges.Size = New System.Drawing.Size(110, 30)
        Me.cmdSaveCharges.TabIndex = 697
        Me.cmdSaveCharges.Text = "Save"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(143, 47)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(82, 15)
        Me.LabelControl12.TabIndex = 695
        Me.LabelControl12.Text = "Select Category"
        '
        'txtCategory
        '
        Me.txtCategory.EditValue = ""
        Me.txtCategory.Location = New System.Drawing.Point(232, 44)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCategory.Properties.Appearance.Options.UseFont = True
        Me.txtCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCategory.Properties.DisplayMember = "Description"
        Me.txtCategory.Properties.NullText = ""
        Me.txtCategory.Properties.PopupView = Me.gridCategory
        Me.txtCategory.Properties.ValueMember = "Description"
        Me.txtCategory.Size = New System.Drawing.Size(273, 22)
        Me.txtCategory.TabIndex = 692
        '
        'gridCategory
        '
        Me.gridCategory.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridCategory.Name = "gridCategory"
        Me.gridCategory.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridCategory.OptionsView.ShowGroupPanel = False
        '
        'catid
        '
        Me.catid.EditValue = ""
        Me.catid.Location = New System.Drawing.Point(554, 15)
        Me.catid.Name = "catid"
        Me.catid.Properties.Appearance.Options.UseTextOptions = True
        Me.catid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.catid.Size = New System.Drawing.Size(53, 20)
        Me.catid.TabIndex = 696
        Me.catid.Visible = False
        '
        'tabFilter
        '
        Me.tabFilter.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabFilter.Appearance.Header.Options.UseFont = True
        Me.tabFilter.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabFilter.Appearance.HeaderActive.Options.UseFont = True
        Me.tabFilter.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabFilter.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabFilter.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabFilter.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabFilter.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabFilter.Appearance.PageClient.Options.UseFont = True
        Me.tabFilter.Controls.Add(Me.cmdMoveLeft)
        Me.tabFilter.Controls.Add(Me.cmdMoveRight)
        Me.tabFilter.Controls.Add(Me.Em_unfiltered)
        Me.tabFilter.Controls.Add(Me.Em_filtered)
        Me.tabFilter.Name = "tabFilter"
        Me.tabFilter.Size = New System.Drawing.Size(618, 494)
        Me.tabFilter.Text = "Charges Filter by Office"
        '
        'cmdMoveLeft
        '
        Me.cmdMoveLeft.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.cmdMoveLeft.Appearance.Options.UseFont = True
        Me.cmdMoveLeft.Location = New System.Drawing.Point(283, 246)
        Me.cmdMoveLeft.Name = "cmdMoveLeft"
        Me.cmdMoveLeft.Size = New System.Drawing.Size(53, 46)
        Me.cmdMoveLeft.TabIndex = 708
        Me.cmdMoveLeft.Text = "<"
        '
        'cmdMoveRight
        '
        Me.cmdMoveRight.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.cmdMoveRight.Appearance.Options.UseFont = True
        Me.cmdMoveRight.Location = New System.Drawing.Point(283, 194)
        Me.cmdMoveRight.Name = "cmdMoveRight"
        Me.cmdMoveRight.Size = New System.Drawing.Size(53, 46)
        Me.cmdMoveRight.TabIndex = 707
        Me.cmdMoveRight.Text = ">"
        '
        'Em_unfiltered
        '
        Me.Em_unfiltered.Location = New System.Drawing.Point(13, 7)
        Me.Em_unfiltered.MainView = Me.gridunfiltered
        Me.Em_unfiltered.Name = "Em_unfiltered"
        Me.Em_unfiltered.Size = New System.Drawing.Size(259, 476)
        Me.Em_unfiltered.TabIndex = 705
        Me.Em_unfiltered.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridunfiltered})
        '
        'gridunfiltered
        '
        Me.gridunfiltered.Appearance.FocusedCell.BackColor = System.Drawing.Color.Yellow
        Me.gridunfiltered.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gridunfiltered.GridControl = Me.Em_unfiltered
        Me.gridunfiltered.Name = "gridunfiltered"
        Me.gridunfiltered.OptionsBehavior.Editable = False
        Me.gridunfiltered.OptionsSelection.MultiSelect = True
        Me.gridunfiltered.OptionsView.ShowGroupPanel = False
        '
        'Em_filtered
        '
        Me.Em_filtered.Location = New System.Drawing.Point(346, 7)
        Me.Em_filtered.MainView = Me.gridfiltered
        Me.Em_filtered.Name = "Em_filtered"
        Me.Em_filtered.Size = New System.Drawing.Size(259, 476)
        Me.Em_filtered.TabIndex = 706
        Me.Em_filtered.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridfiltered})
        '
        'gridfiltered
        '
        Me.gridfiltered.Appearance.FocusedCell.BackColor = System.Drawing.Color.Yellow
        Me.gridfiltered.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gridfiltered.GridControl = Me.Em_filtered
        Me.gridfiltered.Name = "gridfiltered"
        Me.gridfiltered.OptionsBehavior.Editable = False
        Me.gridfiltered.OptionsSelection.MultiSelect = True
        Me.gridfiltered.OptionsView.ShowGroupPanel = False
        '
        'frmProductCharges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 525)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmProductCharges"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Charges"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabCharges.ResumeLayout(False)
        Me.tabCharges.PerformLayout()
        CType(Me.chargescode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_charges, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Gridview2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChargesName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvChargesName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radChargesType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChargesRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFilter.ResumeLayout(False)
        CType(Me.Em_unfiltered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridunfiltered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_filtered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridfiltered, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabCharges As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents radChargesType As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtChargesRate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSaveCharges As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents catid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCategory As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridCategory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Em_charges As DevExpress.XtraGrid.GridControl
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit_charges As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete_charges As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Gridview2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EnableDisableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabFilter As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdMoveLeft As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdMoveRight As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Em_unfiltered As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridunfiltered As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Em_filtered As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridfiltered As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtChargesName As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gvChargesName As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents chargescode As DevExpress.XtraEditors.TextEdit
End Class
