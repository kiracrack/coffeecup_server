<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAPPaymentRequest
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
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.claimantid = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.cmdAddPayableItem = New DevExpress.XtraEditors.SimpleButton()
        Me.lblReference = New DevExpress.XtraEditors.LabelControl()
        Me.txtVoucherNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNote = New DevExpress.XtraEditors.MemoEdit()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabDetails = New DevExpress.XtraTab.XtraTabPage()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddPayableItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPurchaseOrderProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tabApprovalLog = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_ApprovalLog = New DevExpress.XtraGrid.GridControl()
        Me.GridView_ApprovalLog = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSupplier = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridVendorAccount = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdSubmit = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtOffice = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridoffice = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.oficeid = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.claimantid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVoucherNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.tabDetails.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabApprovalLog.SuspendLayout()
        CType(Me.Em_ApprovalLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_ApprovalLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridVendorAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridoffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oficeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'claimantid
        '
        Me.claimantid.EnterMoveNextControl = True
        Me.claimantid.Location = New System.Drawing.Point(844, 55)
        Me.claimantid.Name = "claimantid"
        Me.claimantid.Properties.Appearance.Options.UseFont = True
        Me.claimantid.Size = New System.Drawing.Size(50, 20)
        Me.claimantid.TabIndex = 774
        Me.claimantid.Visible = False
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(844, 29)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Size = New System.Drawing.Size(50, 20)
        Me.mode.TabIndex = 776
        Me.mode.Visible = False
        '
        'cmdAddPayableItem
        '
        Me.cmdAddPayableItem.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddPayableItem.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdAddPayableItem.Appearance.Options.UseFont = True
        Me.cmdAddPayableItem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdAddPayableItem.Location = New System.Drawing.Point(238, 499)
        Me.cmdAddPayableItem.Name = "cmdAddPayableItem"
        Me.cmdAddPayableItem.Size = New System.Drawing.Size(154, 30)
        Me.cmdAddPayableItem.TabIndex = 775
        Me.cmdAddPayableItem.Text = "Add Payable Item"
        '
        'lblReference
        '
        Me.lblReference.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblReference.Appearance.Options.UseFont = True
        Me.lblReference.Appearance.Options.UseTextOptions = True
        Me.lblReference.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblReference.Location = New System.Drawing.Point(61, 13)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(70, 17)
        Me.lblReference.TabIndex = 773
        Me.lblReference.Text = "Payable No."
        '
        'txtVoucherNo
        '
        Me.txtVoucherNo.EnterMoveNextControl = True
        Me.txtVoucherNo.Location = New System.Drawing.Point(142, 10)
        Me.txtVoucherNo.Name = "txtVoucherNo"
        Me.txtVoucherNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtVoucherNo.Properties.Appearance.Options.UseFont = True
        Me.txtVoucherNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVoucherNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtVoucherNo.Properties.ReadOnly = True
        Me.txtVoucherNo.Size = New System.Drawing.Size(140, 24)
        Me.txtVoucherNo.TabIndex = 772
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(18, 96)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(113, 17)
        Me.LabelControl3.TabIndex = 771
        Me.LabelControl3.Text = "Disbursement Note"
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(142, 95)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtNote.Properties.Appearance.Options.UseFont = True
        Me.txtNote.Size = New System.Drawing.Size(387, 62)
        Me.txtNote.TabIndex = 770
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.XtraTabControl2.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl2.Location = New System.Drawing.Point(29, 165)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.tabDetails
        Me.XtraTabControl2.Size = New System.Drawing.Size(888, 326)
        Me.XtraTabControl2.TabIndex = 769
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabDetails, Me.tabApprovalLog})
        Me.XtraTabControl2.Transition.AllowTransition = DevExpress.Utils.DefaultBoolean.[True]
        '
        'tabDetails
        '
        Me.tabDetails.Controls.Add(Me.Em)
        Me.tabDetails.Name = "tabDetails"
        Me.tabDetails.Size = New System.Drawing.Size(886, 293)
        Me.tabDetails.Text = "Payable Item Details"
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
        Me.Em.Size = New System.Drawing.Size(886, 293)
        Me.Em.TabIndex = 715
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPayableItemToolStripMenuItem, Me.cmdDelete, Me.ViewPurchaseOrderProfileToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(221, 98)
        '
        'AddPayableItemToolStripMenuItem
        '
        Me.AddPayableItemToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.notebook__plus
        Me.AddPayableItemToolStripMenuItem.Name = "AddPayableItemToolStripMenuItem"
        Me.AddPayableItemToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.AddPayableItemToolStripMenuItem.Text = "Add Payable Item"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(220, 22)
        Me.cmdDelete.Text = "Cancel Selected Item"
        '
        'ViewPurchaseOrderProfileToolStripMenuItem
        '
        Me.ViewPurchaseOrderProfileToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.notebook__arrow
        Me.ViewPurchaseOrderProfileToolStripMenuItem.Name = "ViewPurchaseOrderProfileToolStripMenuItem"
        Me.ViewPurchaseOrderProfileToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ViewPurchaseOrderProfileToolStripMenuItem.Text = "View Purchase Order Profile"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(217, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'GridView1
        '
        Me.GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.GridView1.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsPrint.UsePrintStyles = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.PaintStyleName = "Web"
        '
        'tabApprovalLog
        '
        Me.tabApprovalLog.Controls.Add(Me.Em_ApprovalLog)
        Me.tabApprovalLog.Name = "tabApprovalLog"
        Me.tabApprovalLog.Size = New System.Drawing.Size(886, 293)
        Me.tabApprovalLog.Text = "Approval Log History"
        '
        'Em_ApprovalLog
        '
        Me.Em_ApprovalLog.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode2.RelationName = "Level1"
        Me.Em_ApprovalLog.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.Em_ApprovalLog.Location = New System.Drawing.Point(0, 0)
        Me.Em_ApprovalLog.MainView = Me.GridView_ApprovalLog
        Me.Em_ApprovalLog.Name = "Em_ApprovalLog"
        Me.Em_ApprovalLog.Size = New System.Drawing.Size(886, 293)
        Me.Em_ApprovalLog.TabIndex = 716
        Me.Em_ApprovalLog.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_ApprovalLog})
        '
        'GridView_ApprovalLog
        '
        Me.GridView_ApprovalLog.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.GridView_ApprovalLog.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView_ApprovalLog.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GridView_ApprovalLog.Appearance.Row.Options.UseFont = True
        Me.GridView_ApprovalLog.GridControl = Me.Em_ApprovalLog
        Me.GridView_ApprovalLog.Name = "GridView_ApprovalLog"
        Me.GridView_ApprovalLog.OptionsBehavior.Editable = False
        Me.GridView_ApprovalLog.OptionsPrint.UsePrintStyles = False
        Me.GridView_ApprovalLog.OptionsSelection.MultiSelect = True
        Me.GridView_ApprovalLog.OptionsView.ColumnAutoWidth = False
        Me.GridView_ApprovalLog.OptionsView.ShowFooter = True
        Me.GridView_ApprovalLog.OptionsView.ShowGroupPanel = False
        Me.GridView_ApprovalLog.PaintStyleName = "Web"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(45, 69)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(86, 17)
        Me.LabelControl9.TabIndex = 768
        Me.LabelControl9.Text = "Select Supplier"
        '
        'txtSupplier
        '
        Me.txtSupplier.EditValue = "Select Group"
        Me.txtSupplier.Location = New System.Drawing.Point(142, 66)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.txtSupplier.Properties.Appearance.Options.UseFont = True
        Me.txtSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSupplier.Properties.DisplayMember = "Supplier"
        Me.txtSupplier.Properties.NullText = ""
        Me.txtSupplier.Properties.PopupView = Me.gridVendorAccount
        Me.txtSupplier.Properties.ValueMember = "vendorid"
        Me.txtSupplier.Size = New System.Drawing.Size(319, 26)
        Me.txtSupplier.TabIndex = 766
        '
        'gridVendorAccount
        '
        Me.gridVendorAccount.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridVendorAccount.Name = "gridVendorAccount"
        Me.gridVendorAccount.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridVendorAccount.OptionsView.ShowGroupPanel = False
        '
        'cmdSubmit
        '
        Me.cmdSubmit.Appearance.BackColor = System.Drawing.Color.Green
        Me.cmdSubmit.Appearance.BackColor2 = System.Drawing.Color.Green
        Me.cmdSubmit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSubmit.Appearance.ForeColor = System.Drawing.Color.White
        Me.cmdSubmit.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSubmit.Appearance.Options.UseBackColor = True
        Me.cmdSubmit.Appearance.Options.UseFont = True
        Me.cmdSubmit.Appearance.Options.UseForeColor = True
        Me.cmdSubmit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSubmit.Location = New System.Drawing.Point(558, 499)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(154, 30)
        Me.cmdSubmit.TabIndex = 767
        Me.cmdSubmit.Text = "Submit for Approval"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(61, 41)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(72, 17)
        Me.LabelControl1.TabIndex = 778
        Me.LabelControl1.Text = "Select Office"
        '
        'txtOffice
        '
        Me.txtOffice.EditValue = "Select Group"
        Me.txtOffice.Location = New System.Drawing.Point(142, 37)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.txtOffice.Properties.Appearance.Options.UseFont = True
        Me.txtOffice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOffice.Properties.DisplayMember = "Office"
        Me.txtOffice.Properties.NullText = ""
        Me.txtOffice.Properties.PopupView = Me.gridoffice
        Me.txtOffice.Properties.ValueMember = "officeid"
        Me.txtOffice.Size = New System.Drawing.Size(319, 26)
        Me.txtOffice.TabIndex = 777
        '
        'gridoffice
        '
        Me.gridoffice.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridoffice.Name = "gridoffice"
        Me.gridoffice.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridoffice.OptionsView.ShowGroupPanel = False
        '
        'officeid
        '
        Me.officeid.EnterMoveNextControl = True
        Me.officeid.Location = New System.Drawing.Point(844, 81)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Size = New System.Drawing.Size(50, 20)
        Me.officeid.TabIndex = 779
        Me.officeid.Visible = False
        '
        'oficeid
        '
        Me.oficeid.EnterMoveNextControl = True
        Me.oficeid.Location = New System.Drawing.Point(844, 107)
        Me.oficeid.Name = "oficeid"
        Me.oficeid.Properties.Appearance.Options.UseFont = True
        Me.oficeid.Size = New System.Drawing.Size(50, 20)
        Me.oficeid.TabIndex = 780
        Me.oficeid.Visible = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton2.Location = New System.Drawing.Point(398, 499)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(154, 30)
        Me.SimpleButton2.TabIndex = 781
        Me.SimpleButton2.Text = "Print Report"
        '
        'frmAPPaymentRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 541)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.oficeid)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtOffice)
        Me.Controls.Add(Me.claimantid)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.cmdAddPayableItem)
        Me.Controls.Add(Me.lblReference)
        Me.Controls.Add(Me.txtVoucherNo)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.XtraTabControl2)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.cmdSubmit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAPPaymentRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirm Request Processing"
        CType(Me.claimantid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVoucherNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.tabDetails.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabApprovalLog.ResumeLayout(False)
        CType(Me.Em_ApprovalLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_ApprovalLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridVendorAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridoffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oficeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents claimantid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdAddPayableItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblReference As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVoucherNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabDetails As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tabApprovalLog As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em_ApprovalLog As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_ApprovalLog As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSupplier As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridVendorAccount As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdSubmit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddPayableItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewPurchaseOrderProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOffice As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridoffice As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents oficeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
