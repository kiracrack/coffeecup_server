<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferNew
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtremarks = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.fromInventoryId = New DevExpress.XtraEditors.TextEdit()
        Me.transferto = New DevExpress.XtraEditors.TextEdit()
        Me.requestorid = New DevExpress.XtraEditors.TextEdit()
        Me.productid = New DevExpress.XtraEditors.TextEdit()
        Me.refcode = New DevExpress.XtraEditors.TextEdit()
        Me.txtAvailableQuantity = New DevExpress.XtraEditors.TextEdit()
        Me.catid = New DevExpress.XtraEditors.TextEdit()
        Me.txtTransferTo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gv_transferTo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdAddtoBatch = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRequestby = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gv_requestby = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveParticularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdConfirm = New DevExpress.XtraEditors.SimpleButton()
        Me.txtquantity = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lblinvetory = New DevExpress.XtraEditors.LabelControl()
        Me.txtofficeinventory = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gv_officeinventory = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtUnit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNote = New DevExpress.XtraEditors.MemoEdit()
        Me.txtDesignation = New DevExpress.XtraEditors.TextEdit()
        Me.txtUnitCost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotalCost = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtProductName = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSearch = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtremarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fromInventoryId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.transferto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.requestorid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.refcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAvailableQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransferTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_transferTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRequestby.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_requestby, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtquantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtofficeinventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_officeinventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesignation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnitCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtProductName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Location = New System.Drawing.Point(31, 65)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl1.TabIndex = 538
        Me.LabelControl1.Text = "Transfer to"
        '
        'txtremarks
        '
        Me.txtremarks.EditValue = ""
        Me.txtremarks.Location = New System.Drawing.Point(27, 172)
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremarks.Properties.Appearance.Options.UseFont = True
        Me.txtremarks.Properties.NullValuePrompt = "Remarks"
        Me.txtremarks.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtremarks.Size = New System.Drawing.Size(301, 50)
        Me.txtremarks.TabIndex = 8
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(29, 88)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl9.TabIndex = 543
        Me.LabelControl9.Text = "Request By"
        '
        'fromInventoryId
        '
        Me.fromInventoryId.EditValue = ""
        Me.fromInventoryId.EnterMoveNextControl = True
        Me.fromInventoryId.Location = New System.Drawing.Point(402, 107)
        Me.fromInventoryId.Name = "fromInventoryId"
        Me.fromInventoryId.Properties.ReadOnly = True
        Me.fromInventoryId.Properties.ValidateOnEnterKey = True
        Me.fromInventoryId.Size = New System.Drawing.Size(34, 20)
        Me.fromInventoryId.TabIndex = 545
        Me.fromInventoryId.Visible = False
        '
        'transferto
        '
        Me.transferto.EditValue = ""
        Me.transferto.EnterMoveNextControl = True
        Me.transferto.Location = New System.Drawing.Point(402, 130)
        Me.transferto.Name = "transferto"
        Me.transferto.Properties.ReadOnly = True
        Me.transferto.Properties.ValidateOnEnterKey = True
        Me.transferto.Size = New System.Drawing.Size(34, 20)
        Me.transferto.TabIndex = 546
        Me.transferto.Visible = False
        '
        'requestorid
        '
        Me.requestorid.EditValue = ""
        Me.requestorid.EnterMoveNextControl = True
        Me.requestorid.Location = New System.Drawing.Point(402, 153)
        Me.requestorid.Name = "requestorid"
        Me.requestorid.Properties.ReadOnly = True
        Me.requestorid.Properties.ValidateOnEnterKey = True
        Me.requestorid.Size = New System.Drawing.Size(34, 20)
        Me.requestorid.TabIndex = 547
        Me.requestorid.Visible = False
        '
        'productid
        '
        Me.productid.EditValue = ""
        Me.productid.EnterMoveNextControl = True
        Me.productid.Location = New System.Drawing.Point(413, 343)
        Me.productid.Name = "productid"
        Me.productid.Properties.ReadOnly = True
        Me.productid.Properties.ValidateOnEnterKey = True
        Me.productid.Size = New System.Drawing.Size(35, 20)
        Me.productid.TabIndex = 548
        Me.productid.Visible = False
        '
        'refcode
        '
        Me.refcode.EditValue = ""
        Me.refcode.EnterMoveNextControl = True
        Me.refcode.Location = New System.Drawing.Point(413, 297)
        Me.refcode.Name = "refcode"
        Me.refcode.Properties.ReadOnly = True
        Me.refcode.Properties.ValidateOnEnterKey = True
        Me.refcode.Size = New System.Drawing.Size(35, 20)
        Me.refcode.TabIndex = 549
        Me.refcode.Visible = False
        '
        'txtAvailableQuantity
        '
        Me.txtAvailableQuantity.EditValue = ""
        Me.txtAvailableQuantity.EnterMoveNextControl = True
        Me.txtAvailableQuantity.Location = New System.Drawing.Point(413, 366)
        Me.txtAvailableQuantity.Name = "txtAvailableQuantity"
        Me.txtAvailableQuantity.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAvailableQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAvailableQuantity.Properties.ReadOnly = True
        Me.txtAvailableQuantity.Size = New System.Drawing.Size(35, 20)
        Me.txtAvailableQuantity.TabIndex = 551
        Me.txtAvailableQuantity.Visible = False
        '
        'catid
        '
        Me.catid.EditValue = ""
        Me.catid.EnterMoveNextControl = True
        Me.catid.Location = New System.Drawing.Point(413, 321)
        Me.catid.Name = "catid"
        Me.catid.Properties.ReadOnly = True
        Me.catid.Properties.ValidateOnEnterKey = True
        Me.catid.Size = New System.Drawing.Size(35, 20)
        Me.catid.TabIndex = 558
        Me.catid.Visible = False
        '
        'txtTransferTo
        '
        Me.txtTransferTo.EditValue = ""
        Me.txtTransferTo.Location = New System.Drawing.Point(95, 61)
        Me.txtTransferTo.Name = "txtTransferTo"
        Me.txtTransferTo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransferTo.Properties.Appearance.Options.UseFont = True
        Me.txtTransferTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTransferTo.Properties.DisplayMember = "Select Inventory"
        Me.txtTransferTo.Properties.NullText = ""
        Me.txtTransferTo.Properties.PopupView = Me.gv_transferTo
        Me.txtTransferTo.Properties.ValueMember = "Select Inventory"
        Me.txtTransferTo.Size = New System.Drawing.Size(233, 20)
        Me.txtTransferTo.TabIndex = 1
        '
        'gv_transferTo
        '
        Me.gv_transferTo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_transferTo.Name = "gv_transferTo"
        Me.gv_transferTo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_transferTo.OptionsView.ShowGroupPanel = False
        '
        'cmdAddtoBatch
        '
        Me.cmdAddtoBatch.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddtoBatch.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdAddtoBatch.Appearance.Options.UseFont = True
        Me.cmdAddtoBatch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdAddtoBatch.Location = New System.Drawing.Point(159, 226)
        Me.cmdAddtoBatch.Name = "cmdAddtoBatch"
        Me.cmdAddtoBatch.Size = New System.Drawing.Size(169, 30)
        Me.cmdAddtoBatch.TabIndex = 2
        Me.cmdAddtoBatch.Text = "Add to Batch"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(94, 43)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(265, 13)
        Me.LabelControl8.TabIndex = 563
        Me.LabelControl8.Text = "This form is allow to create request for item transfer"
        '
        'lblTitle
        '
        Me.lblTitle.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Appearance.Options.UseFont = True
        Me.lblTitle.Location = New System.Drawing.Point(94, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(158, 19)
        Me.lblTitle.TabIndex = 562
        Me.lblTitle.Text = "Transfer Item Request"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.Silver
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(94, 49)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(250, 13)
        Me.LabelControl10.TabIndex = 561
        Me.LabelControl10.Text = "_________________________________________________________________________________" & _
    "_____"
        '
        'txtRequestby
        '
        Me.txtRequestby.EditValue = ""
        Me.txtRequestby.Location = New System.Drawing.Point(95, 84)
        Me.txtRequestby.Name = "txtRequestby"
        Me.txtRequestby.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequestby.Properties.Appearance.Options.UseFont = True
        Me.txtRequestby.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtRequestby.Properties.DisplayMember = "Fullname"
        Me.txtRequestby.Properties.NullText = ""
        Me.txtRequestby.Properties.PopupView = Me.gv_requestby
        Me.txtRequestby.Properties.ValueMember = "Fullname"
        Me.txtRequestby.Size = New System.Drawing.Size(233, 20)
        Me.txtRequestby.TabIndex = 2
        '
        'gv_requestby
        '
        Me.gv_requestby.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_requestby.Name = "gv_requestby"
        Me.gv_requestby.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_requestby.OptionsView.ShowGroupPanel = False
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.ContentImage = Global.Coffeecup.My.Resources.Resources.preferences_system_network_2
        Me.PanelControl1.Location = New System.Drawing.Point(22, 2)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(66, 61)
        Me.PanelControl1.TabIndex = 560
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em.Location = New System.Drawing.Point(390, 2)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(703, 531)
        Me.Em.TabIndex = 589
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveParticularToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(171, 54)
        '
        'RemoveParticularToolStripMenuItem
        '
        Me.RemoveParticularToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.blog__minus
        Me.RemoveParticularToolStripMenuItem.Name = "RemoveParticularToolStripMenuItem"
        Me.RemoveParticularToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.RemoveParticularToolStripMenuItem.Text = "Remove Particular"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(167, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "Total", Nothing, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConfirm.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfirm.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdConfirm.Appearance.Options.UseFont = True
        Me.cmdConfirm.Location = New System.Drawing.Point(830, 542)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(254, 30)
        Me.cmdConfirm.TabIndex = 4
        Me.cmdConfirm.Text = "Create Request Transfer"
        '
        'txtquantity
        '
        Me.txtquantity.EditValue = "1"
        Me.txtquantity.EnterMoveNextControl = True
        Me.txtquantity.Location = New System.Drawing.Point(188, 91)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txtquantity.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtquantity.Properties.Appearance.Options.UseBackColor = True
        Me.txtquantity.Properties.Appearance.Options.UseFont = True
        Me.txtquantity.Properties.Appearance.Options.UseForeColor = True
        Me.txtquantity.Properties.Appearance.Options.UseTextOptions = True
        Me.txtquantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtquantity.Properties.Mask.EditMask = "n3"
        Me.txtquantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtquantity.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtquantity.Size = New System.Drawing.Size(76, 24)
        Me.txtquantity.TabIndex = 0
        Me.txtquantity.ToolTip = "Shortcut Key (F9)"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(137, 96)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl3.TabIndex = 601
        Me.LabelControl3.Text = "Quantity"
        '
        'lblinvetory
        '
        Me.lblinvetory.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvetory.Appearance.Options.UseFont = True
        Me.lblinvetory.Appearance.Options.UseTextOptions = True
        Me.lblinvetory.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblinvetory.Location = New System.Drawing.Point(9, 41)
        Me.lblinvetory.Name = "lblinvetory"
        Me.lblinvetory.Size = New System.Drawing.Size(77, 13)
        Me.lblinvetory.TabIndex = 600
        Me.lblinvetory.Text = "From Inventory"
        '
        'txtofficeinventory
        '
        Me.txtofficeinventory.EditValue = ""
        Me.txtofficeinventory.Location = New System.Drawing.Point(95, 38)
        Me.txtofficeinventory.Name = "txtofficeinventory"
        Me.txtofficeinventory.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtofficeinventory.Properties.Appearance.Options.UseFont = True
        Me.txtofficeinventory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtofficeinventory.Properties.NullText = ""
        Me.txtofficeinventory.Properties.PopupView = Me.gv_officeinventory
        Me.txtofficeinventory.Size = New System.Drawing.Size(233, 20)
        Me.txtofficeinventory.TabIndex = 0
        Me.txtofficeinventory.ToolTip = "Shortcut Key (F12)"
        '
        'gv_officeinventory
        '
        Me.gv_officeinventory.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_officeinventory.Name = "gv_officeinventory"
        Me.gv_officeinventory.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_officeinventory.OptionsView.ShowGroupPanel = False
        '
        'txtUnit
        '
        Me.txtUnit.EditValue = ""
        Me.txtUnit.EnterMoveNextControl = True
        Me.txtUnit.Location = New System.Drawing.Point(267, 91)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Properties.Appearance.Options.UseFont = True
        Me.txtUnit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUnit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtUnit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnit.Properties.ReadOnly = True
        Me.txtUnit.Size = New System.Drawing.Size(61, 24)
        Me.txtUnit.TabIndex = 602
        Me.txtUnit.ToolTip = "Shortcut Key (F11)"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(61, 109)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl4.TabIndex = 605
        Me.LabelControl4.Text = "Note"
        '
        'txtNote
        '
        Me.txtNote.EditValue = ""
        Me.txtNote.Location = New System.Drawing.Point(95, 107)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Properties.Appearance.Options.UseFont = True
        Me.txtNote.Size = New System.Drawing.Size(233, 49)
        Me.txtNote.TabIndex = 3
        '
        'txtDesignation
        '
        Me.txtDesignation.EditValue = ""
        Me.txtDesignation.EnterMoveNextControl = True
        Me.txtDesignation.Location = New System.Drawing.Point(402, 175)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Properties.ReadOnly = True
        Me.txtDesignation.Properties.ValidateOnEnterKey = True
        Me.txtDesignation.Size = New System.Drawing.Size(34, 20)
        Me.txtDesignation.TabIndex = 609
        Me.txtDesignation.Visible = False
        '
        'txtUnitCost
        '
        Me.txtUnitCost.EditValue = "0.00"
        Me.txtUnitCost.Location = New System.Drawing.Point(188, 118)
        Me.txtUnitCost.Name = "txtUnitCost"
        Me.txtUnitCost.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitCost.Properties.Appearance.Options.UseFont = True
        Me.txtUnitCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUnitCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtUnitCost.Properties.Mask.EditMask = "n3"
        Me.txtUnitCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtUnitCost.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(45)
        Me.txtUnitCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtUnitCost.Size = New System.Drawing.Size(140, 24)
        Me.txtUnitCost.TabIndex = 1
        Me.txtUnitCost.ToolTip = "Shortcut Key (F11)"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(133, 123)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl5.TabIndex = 611
        Me.LabelControl5.Text = "Unit Cost"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(132, 150)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl11.TabIndex = 613
        Me.LabelControl11.Text = "Total Cost"
        '
        'txtTotalCost
        '
        Me.txtTotalCost.EditValue = "0.00"
        Me.txtTotalCost.EnterMoveNextControl = True
        Me.txtTotalCost.Location = New System.Drawing.Point(188, 145)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCost.Properties.Appearance.Options.UseFont = True
        Me.txtTotalCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalCost.Properties.Mask.EditMask = "n3"
        Me.txtTotalCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalCost.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(110)
        Me.txtTotalCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalCost.Properties.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(140, 24)
        Me.txtTotalCost.TabIndex = 612
        Me.txtTotalCost.ToolTip = "Shortcut Key (F11)"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtofficeinventory)
        Me.GroupControl1.Controls.Add(Me.txtRequestby)
        Me.GroupControl1.Controls.Add(Me.txtTransferTo)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.lblinvetory)
        Me.GroupControl1.Controls.Add(Me.txtNote)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Title
        Me.GroupControl1.Location = New System.Drawing.Point(22, 69)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(351, 171)
        Me.GroupControl1.TabIndex = 614
        Me.GroupControl1.Text = "General information"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txtProductName)
        Me.GroupControl2.Controls.Add(Me.cmdSearch)
        Me.GroupControl2.Controls.Add(Me.txtremarks)
        Me.GroupControl2.Controls.Add(Me.LabelControl11)
        Me.GroupControl2.Controls.Add(Me.cmdAddtoBatch)
        Me.GroupControl2.Controls.Add(Me.txtTotalCost)
        Me.GroupControl2.Controls.Add(Me.txtUnit)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.txtUnitCost)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.txtquantity)
        Me.GroupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Title
        Me.GroupControl2.Location = New System.Drawing.Point(22, 248)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(351, 282)
        Me.GroupControl2.TabIndex = 615
        Me.GroupControl2.Text = "Product Transfer Details"
        '
        'txtProductName
        '
        Me.txtProductName.EditValue = ""
        Me.txtProductName.EnterMoveNextControl = True
        Me.txtProductName.Location = New System.Drawing.Point(27, 34)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Properties.Appearance.Options.UseFont = True
        Me.txtProductName.Properties.Appearance.Options.UseTextOptions = True
        Me.txtProductName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtProductName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProductName.Properties.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(301, 22)
        Me.txtProductName.TabIndex = 654
        '
        'cmdSearch
        '
        Me.cmdSearch.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Appearance.Options.UseFont = True
        Me.cmdSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSearch.ImageOptions.Image = Global.Coffeecup.My.Resources.Resources.SearchNew
        Me.cmdSearch.Location = New System.Drawing.Point(114, 61)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(214, 24)
        Me.cmdSearch.TabIndex = 653
        Me.cmdSearch.Text = "Search Product (Press Insert)"
        Me.cmdSearch.ToolTip = "Press Insert on your keyboard"
        '
        'frmTransferNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 581)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtDesignation)
        Me.Controls.Add(Me.cmdConfirm)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.txtAvailableQuantity)
        Me.Controls.Add(Me.refcode)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.requestorid)
        Me.Controls.Add(Me.transferto)
        Me.Controls.Add(Me.fromInventoryId)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.GroupControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(920, 476)
        Me.Name = "frmTransferNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Transfer Items"
        CType(Me.txtremarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fromInventoryId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.transferto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.requestorid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.refcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAvailableQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransferTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_transferTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRequestby.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_requestby, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtquantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtofficeinventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_officeinventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesignation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnitCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtProductName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtremarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents fromInventoryId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents transferto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents requestorid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents productid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents refcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAvailableQuantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents catid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTransferTo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gv_transferTo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdAddtoBatch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRequestby As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gv_requestby As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdConfirm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtquantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblinvetory As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtofficeinventory As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gv_officeinventory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtUnit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtDesignation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveParticularToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtUnitCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtProductName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSearch As DevExpress.XtraEditors.SimpleButton
End Class
