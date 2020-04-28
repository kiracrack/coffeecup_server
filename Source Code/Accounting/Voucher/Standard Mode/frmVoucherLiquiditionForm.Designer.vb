<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoucherLiquiditionForm
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
        Me.lblReference = New DevExpress.XtraEditors.LabelControl()
        Me.voucherno = New DevExpress.XtraEditors.TextEdit()
        Me.txtVoucherAmount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmountSpend = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmountRefunded = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmountReimbursed = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabActualExpenseSummary = New DevExpress.XtraTab.XtraTabPage()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView_Summary = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.tabExpenseSummary = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_Voucher = New DevExpress.XtraGrid.GridControl()
        Me.GridView_Voucher = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.tabDirectExpense = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_OtherExpense = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gridview_OtherExpense = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdAttachment = New DevExpress.XtraEditors.SimpleButton()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.companyid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVoucherAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmountSpend.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmountRefunded.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmountReimbursed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabActualExpenseSummary.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_Summary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabExpenseSummary.SuspendLayout()
        CType(Me.Em_Voucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_Voucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDirectExpense.SuspendLayout()
        CType(Me.Em_OtherExpense, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Gridview_OtherExpense, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.companyid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblReference
        '
        Me.lblReference.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblReference.Appearance.Options.UseFont = True
        Me.lblReference.Appearance.Options.UseTextOptions = True
        Me.lblReference.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblReference.Location = New System.Drawing.Point(108, 24)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(73, 17)
        Me.lblReference.TabIndex = 757
        Me.lblReference.Text = "Voucher No."
        '
        'voucherno
        '
        Me.voucherno.EnterMoveNextControl = True
        Me.voucherno.Location = New System.Drawing.Point(192, 21)
        Me.voucherno.Name = "voucherno"
        Me.voucherno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.voucherno.Properties.Appearance.Options.UseFont = True
        Me.voucherno.Properties.Appearance.Options.UseTextOptions = True
        Me.voucherno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.voucherno.Size = New System.Drawing.Size(93, 24)
        Me.voucherno.TabIndex = 754
        '
        'txtVoucherAmount
        '
        Me.txtVoucherAmount.EditValue = "0.00"
        Me.txtVoucherAmount.Location = New System.Drawing.Point(192, 48)
        Me.txtVoucherAmount.Name = "txtVoucherAmount"
        Me.txtVoucherAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtVoucherAmount.Properties.Appearance.Options.UseFont = True
        Me.txtVoucherAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVoucherAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtVoucherAmount.Properties.Mask.EditMask = "n"
        Me.txtVoucherAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtVoucherAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVoucherAmount.Size = New System.Drawing.Size(154, 26)
        Me.txtVoucherAmount.TabIndex = 755
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(119, 51)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(62, 15)
        Me.LabelControl4.TabIndex = 756
        Me.LabelControl4.Text = "DV Amount"
        '
        'txtAmountSpend
        '
        Me.txtAmountSpend.EditValue = "0.00"
        Me.txtAmountSpend.Location = New System.Drawing.Point(192, 77)
        Me.txtAmountSpend.Name = "txtAmountSpend"
        Me.txtAmountSpend.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtAmountSpend.Properties.Appearance.Options.UseFont = True
        Me.txtAmountSpend.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmountSpend.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmountSpend.Properties.Mask.EditMask = "n"
        Me.txtAmountSpend.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmountSpend.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmountSpend.Size = New System.Drawing.Size(154, 26)
        Me.txtAmountSpend.TabIndex = 758
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(71, 80)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(110, 15)
        Me.LabelControl1.TabIndex = 759
        Me.LabelControl1.Text = "Total Amount Spend"
        '
        'txtAmountRefunded
        '
        Me.txtAmountRefunded.EditValue = "0.00"
        Me.txtAmountRefunded.Location = New System.Drawing.Point(192, 106)
        Me.txtAmountRefunded.Name = "txtAmountRefunded"
        Me.txtAmountRefunded.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtAmountRefunded.Properties.Appearance.Options.UseFont = True
        Me.txtAmountRefunded.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmountRefunded.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmountRefunded.Properties.Mask.EditMask = "n"
        Me.txtAmountRefunded.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmountRefunded.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmountRefunded.Size = New System.Drawing.Size(154, 26)
        Me.txtAmountRefunded.TabIndex = 760
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(86, 111)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(95, 15)
        Me.LabelControl2.TabIndex = 761
        Me.LabelControl2.Text = "Amount Returned"
        '
        'txtAmountReimbursed
        '
        Me.txtAmountReimbursed.EditValue = "0.00"
        Me.txtAmountReimbursed.Location = New System.Drawing.Point(192, 135)
        Me.txtAmountReimbursed.Name = "txtAmountReimbursed"
        Me.txtAmountReimbursed.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtAmountReimbursed.Properties.Appearance.Options.UseFont = True
        Me.txtAmountReimbursed.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmountReimbursed.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmountReimbursed.Properties.Mask.EditMask = "n"
        Me.txtAmountReimbursed.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmountReimbursed.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmountReimbursed.Size = New System.Drawing.Size(154, 26)
        Me.txtAmountReimbursed.TabIndex = 762
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(41, 138)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(140, 15)
        Me.LabelControl3.TabIndex = 763
        Me.LabelControl3.Text = "Amount to be Reimbursed"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(375, 7)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabExpenseSummary
        Me.XtraTabControl1.Size = New System.Drawing.Size(618, 508)
        Me.XtraTabControl1.TabIndex = 764
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabExpenseSummary, Me.tabDirectExpense, Me.tabActualExpenseSummary})
        Me.XtraTabControl1.Transition.AllowTransition = DevExpress.Utils.DefaultBoolean.[True]
        '
        'tabActualExpenseSummary
        '
        Me.tabActualExpenseSummary.Controls.Add(Me.Em)
        Me.tabActualExpenseSummary.Controls.Add(Me.companyid)
        Me.tabActualExpenseSummary.Name = "tabActualExpenseSummary"
        Me.tabActualExpenseSummary.Size = New System.Drawing.Size(616, 479)
        Me.tabActualExpenseSummary.Text = "Actual Expense Reference"
        '
        'Em
        '
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView_Summary
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.Em.Size = New System.Drawing.Size(616, 479)
        Me.Em.TabIndex = 822
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Summary})
        '
        'GridView_Summary
        '
        Me.GridView_Summary.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Summary.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_Summary.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Summary.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_Summary.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Summary.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_Summary.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_Summary.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_Summary.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Summary.Appearance.Row.Options.UseFont = True
        Me.GridView_Summary.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_Summary.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Summary.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_Summary.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Summary.GridControl = Me.Em
        Me.GridView_Summary.Name = "GridView_Summary"
        Me.GridView_Summary.OptionsBehavior.Editable = False
        Me.GridView_Summary.OptionsSelection.MultiSelect = True
        Me.GridView_Summary.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_Summary.OptionsView.ColumnAutoWidth = False
        Me.GridView_Summary.OptionsView.RowAutoHeight = True
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'tabExpenseSummary
        '
        Me.tabExpenseSummary.Controls.Add(Me.Em_Voucher)
        Me.tabExpenseSummary.Name = "tabExpenseSummary"
        Me.tabExpenseSummary.Size = New System.Drawing.Size(616, 479)
        Me.tabExpenseSummary.Text = "Expense Summary"
        '
        'Em_Voucher
        '
        Me.Em_Voucher.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_Voucher.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_Voucher.Location = New System.Drawing.Point(0, 0)
        Me.Em_Voucher.MainView = Me.GridView_Voucher
        Me.Em_Voucher.Name = "Em_Voucher"
        Me.Em_Voucher.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit2})
        Me.Em_Voucher.Size = New System.Drawing.Size(616, 479)
        Me.Em_Voucher.TabIndex = 823
        Me.Em_Voucher.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Voucher})
        '
        'GridView_Voucher
        '
        Me.GridView_Voucher.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Voucher.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_Voucher.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Voucher.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_Voucher.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Voucher.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_Voucher.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_Voucher.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_Voucher.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Voucher.Appearance.Row.Options.UseFont = True
        Me.GridView_Voucher.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_Voucher.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Voucher.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_Voucher.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Voucher.GridControl = Me.Em_Voucher
        Me.GridView_Voucher.Name = "GridView_Voucher"
        Me.GridView_Voucher.OptionsBehavior.Editable = False
        Me.GridView_Voucher.OptionsSelection.MultiSelect = True
        Me.GridView_Voucher.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_Voucher.OptionsView.ColumnAutoWidth = False
        Me.GridView_Voucher.OptionsView.RowAutoHeight = True
        '
        'RepositoryItemPictureEdit2
        '
        Me.RepositoryItemPictureEdit2.Name = "RepositoryItemPictureEdit2"
        '
        'tabDirectExpense
        '
        Me.tabDirectExpense.Controls.Add(Me.Em_OtherExpense)
        Me.tabDirectExpense.Name = "tabDirectExpense"
        Me.tabDirectExpense.Size = New System.Drawing.Size(616, 479)
        Me.tabDirectExpense.Text = "Additional Direct Expense Item"
        '
        'Em_OtherExpense
        '
        Me.Em_OtherExpense.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em_OtherExpense.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.Em_OtherExpense.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Em_OtherExpense.Location = New System.Drawing.Point(0, 0)
        Me.Em_OtherExpense.MainView = Me.Gridview_OtherExpense
        Me.Em_OtherExpense.Name = "Em_OtherExpense"
        Me.Em_OtherExpense.Size = New System.Drawing.Size(616, 479)
        Me.Em_OtherExpense.TabIndex = 718
        Me.Em_OtherExpense.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview_OtherExpense})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem3, Me.ToolStripMenuItem2, Me.ToolStripSeparator2, Me.ToolStripMenuItem4})
        Me.ContextMenuStrip1.Name = "gridmenustrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(178, 98)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.Coffeecup.My.Resources.Resources.notebook__plus
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 22)
        Me.ToolStripMenuItem1.Text = "Add Other Expense"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(177, 22)
        Me.ToolStripMenuItem3.Text = "Edit Selected Item"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.ShowShortcutKeys = False
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(177, 22)
        Me.ToolStripMenuItem2.Text = "Cancel Selected Item"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(174, 6)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(177, 22)
        Me.ToolStripMenuItem4.Text = "Refresh"
        '
        'Gridview_OtherExpense
        '
        Me.Gridview_OtherExpense.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.Gridview_OtherExpense.Appearance.FooterPanel.Options.UseFont = True
        Me.Gridview_OtherExpense.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.Gridview_OtherExpense.Appearance.Row.Options.UseFont = True
        Me.Gridview_OtherExpense.GridControl = Me.Em_OtherExpense
        Me.Gridview_OtherExpense.Name = "Gridview_OtherExpense"
        Me.Gridview_OtherExpense.OptionsBehavior.Editable = False
        Me.Gridview_OtherExpense.OptionsPrint.UsePrintStyles = False
        Me.Gridview_OtherExpense.OptionsSelection.MultiSelect = True
        Me.Gridview_OtherExpense.OptionsView.ColumnAutoWidth = False
        Me.Gridview_OtherExpense.OptionsView.ShowFooter = True
        '
        'cmdAttachment
        '
        Me.cmdAttachment.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.cmdAttachment.Appearance.Options.UseFont = True
        Me.cmdAttachment.Location = New System.Drawing.Point(41, 167)
        Me.cmdAttachment.Name = "cmdAttachment"
        Me.cmdAttachment.Size = New System.Drawing.Size(145, 36)
        Me.cmdAttachment.TabIndex = 766
        Me.cmdAttachment.Text = "Print Liquidation"
        '
        'Button1
        '
        Me.Button1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.Button1.Appearance.Options.UseFont = True
        Me.Button1.Location = New System.Drawing.Point(192, 167)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 36)
        Me.Button1.TabIndex = 767
        Me.Button1.Text = "Confirm Liquidate"
        '
        'companyid
        '
        Me.companyid.EnterMoveNextControl = True
        Me.companyid.Location = New System.Drawing.Point(170, 141)
        Me.companyid.Name = "companyid"
        Me.companyid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.companyid.Properties.Appearance.Options.UseFont = True
        Me.companyid.Properties.Appearance.Options.UseTextOptions = True
        Me.companyid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.companyid.Size = New System.Drawing.Size(61, 24)
        Me.companyid.TabIndex = 768
        Me.companyid.Visible = False
        '
        'frmVoucherLiquiditionForm
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 522)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdAttachment)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.txtAmountReimbursed)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtAmountRefunded)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtAmountSpend)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.lblReference)
        Me.Controls.Add(Me.voucherno)
        Me.Controls.Add(Me.txtVoucherAmount)
        Me.Controls.Add(Me.LabelControl4)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVoucherLiquiditionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liquidition Form"
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVoucherAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmountSpend.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmountRefunded.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmountReimbursed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabActualExpenseSummary.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_Summary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabExpenseSummary.ResumeLayout(False)
        CType(Me.Em_Voucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_Voucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDirectExpense.ResumeLayout(False)
        CType(Me.Em_OtherExpense, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Gridview_OtherExpense, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.companyid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblReference As DevExpress.XtraEditors.LabelControl
    Public WithEvents voucherno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtVoucherAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmountSpend As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmountRefunded As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmountReimbursed As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabActualExpenseSummary As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabExpenseSummary As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabDirectExpense As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Summary As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents Em_Voucher As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Voucher As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents Em_OtherExpense As DevExpress.XtraGrid.GridControl
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Gridview_OtherExpense As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdAttachment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents companyid As DevExpress.XtraEditors.TextEdit
End Class
