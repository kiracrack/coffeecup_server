﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBankAccounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBankAccounts))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.companyid = New DevExpress.XtraEditors.TextEdit()
        Me.txtCompany = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gvCompany = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.ItemCode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtItem = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridItem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ckBankAccounts = New DevExpress.XtraEditors.CheckEdit()
        Me.ckOnlineTransaction = New DevExpress.XtraEditors.CheckEdit()
        Me.ckposmerchant = New DevExpress.XtraEditors.CheckEdit()
        Me.ckEnableEmailNotification = New DevExpress.XtraEditors.CheckEdit()
        Me.ckCash = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAccountName = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAccountNumber = New DevExpress.XtraEditors.TextEdit()
        Me.code = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtBank = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.cmdClose = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.companyid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckBankAccounts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckOnlineTransaction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckposmerchant.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckEnableEmailNotification.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckCash.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAccountName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAccountNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.companyid)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtCompany)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl4)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ItemCode)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl5)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtItem)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckBankAccounts)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckOnlineTransaction)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckposmerchant)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckEnableEmailNotification)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckCash)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl3)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtAccountName)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.cmdSave)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtAccountNumber)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.code)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl6)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtBank)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.mode)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1019, 436)
        Me.SplitContainerControl1.SplitterPosition = 386
        Me.SplitContainerControl1.TabIndex = 11
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'companyid
        '
        Me.companyid.Location = New System.Drawing.Point(269, 348)
        Me.companyid.Name = "companyid"
        Me.companyid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.companyid.Properties.Appearance.Options.UseFont = True
        Me.companyid.Properties.ReadOnly = True
        Me.companyid.Size = New System.Drawing.Size(73, 20)
        Me.companyid.TabIndex = 736
        Me.companyid.Visible = False
        '
        'txtCompany
        '
        Me.txtCompany.EditValue = ""
        Me.txtCompany.Location = New System.Drawing.Point(155, 61)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCompany.Properties.DisplayMember = "Select Company"
        Me.txtCompany.Properties.NullText = ""
        Me.txtCompany.Properties.PopupView = Me.gvCompany
        Me.txtCompany.Properties.ValueMember = "code"
        Me.txtCompany.Size = New System.Drawing.Size(217, 20)
        Me.txtCompany.TabIndex = 1
        '
        'gvCompany
        '
        Me.gvCompany.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvCompany.Name = "gvCompany"
        Me.gvCompany.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvCompany.OptionsView.ShowGroupPanel = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Location = New System.Drawing.Point(67, 64)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl4.TabIndex = 735
        Me.LabelControl4.Text = "Account Owner"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(89, 110)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl2.TabIndex = 733
        Me.LabelControl2.Text = "Bank Name"
        '
        'ItemCode
        '
        Me.ItemCode.EnterMoveNextControl = True
        Me.ItemCode.Location = New System.Drawing.Point(221, 348)
        Me.ItemCode.Name = "ItemCode"
        Me.ItemCode.Properties.Appearance.Options.UseFont = True
        Me.ItemCode.Size = New System.Drawing.Size(41, 20)
        Me.ItemCode.TabIndex = 731
        Me.ItemCode.Visible = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(81, 132)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl5.TabIndex = 720
        Me.LabelControl5.Text = "Account Title"
        '
        'txtItem
        '
        Me.txtItem.EditValue = ""
        Me.txtItem.Location = New System.Drawing.Point(155, 129)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Properties.Appearance.Options.UseFont = True
        Me.txtItem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtItem.Properties.DisplayMember = "itemname"
        Me.txtItem.Properties.NullText = ""
        Me.txtItem.Properties.PopupView = Me.gridItem
        Me.txtItem.Properties.ValueMember = "itemcode"
        Me.txtItem.Size = New System.Drawing.Size(217, 20)
        Me.txtItem.TabIndex = 4
        '
        'gridItem
        '
        Me.gridItem.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridItem.Name = "gridItem"
        Me.gridItem.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridItem.OptionsView.ShowGroupPanel = False
        '
        'ckBankAccounts
        '
        Me.ckBankAccounts.Location = New System.Drawing.Point(155, 155)
        Me.ckBankAccounts.Name = "ckBankAccounts"
        Me.ckBankAccounts.Properties.Appearance.Options.UseFont = True
        Me.ckBankAccounts.Properties.Caption = "Bank Accounts"
        Me.ckBankAccounts.Size = New System.Drawing.Size(166, 20)
        Me.ckBankAccounts.TabIndex = 636
        '
        'ckOnlineTransaction
        '
        Me.ckOnlineTransaction.Location = New System.Drawing.Point(155, 233)
        Me.ckOnlineTransaction.Name = "ckOnlineTransaction"
        Me.ckOnlineTransaction.Properties.Appearance.Options.UseFont = True
        Me.ckOnlineTransaction.Properties.Caption = "Online Payment Transaction"
        Me.ckOnlineTransaction.Size = New System.Drawing.Size(166, 20)
        Me.ckOnlineTransaction.TabIndex = 635
        '
        'ckposmerchant
        '
        Me.ckposmerchant.Location = New System.Drawing.Point(155, 194)
        Me.ckposmerchant.Name = "ckposmerchant"
        Me.ckposmerchant.Properties.Appearance.Options.UseFont = True
        Me.ckposmerchant.Properties.Caption = "POS Merchant"
        Me.ckposmerchant.Size = New System.Drawing.Size(153, 20)
        Me.ckposmerchant.TabIndex = 634
        '
        'ckEnableEmailNotification
        '
        Me.ckEnableEmailNotification.Location = New System.Drawing.Point(155, 213)
        Me.ckEnableEmailNotification.Name = "ckEnableEmailNotification"
        Me.ckEnableEmailNotification.Properties.Appearance.Options.UseFont = True
        Me.ckEnableEmailNotification.Properties.Caption = "Enable email notifification"
        Me.ckEnableEmailNotification.Size = New System.Drawing.Size(166, 20)
        Me.ckEnableEmailNotification.TabIndex = 633
        '
        'ckCash
        '
        Me.ckCash.Location = New System.Drawing.Point(155, 175)
        Me.ckCash.Name = "ckCash"
        Me.ckCash.Properties.Appearance.Options.UseFont = True
        Me.ckCash.Properties.Caption = "Cash Account"
        Me.ckCash.Size = New System.Drawing.Size(153, 20)
        Me.ckCash.TabIndex = 632
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(73, 87)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl3.TabIndex = 629
        Me.LabelControl3.Text = "Account Name"
        '
        'txtAccountName
        '
        Me.txtAccountName.EditValue = ""
        Me.txtAccountName.Location = New System.Drawing.Point(155, 84)
        Me.txtAccountName.Name = "txtAccountName"
        Me.txtAccountName.Properties.Appearance.Options.UseFont = True
        Me.txtAccountName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAccountName.Size = New System.Drawing.Size(217, 20)
        Me.txtAccountName.TabIndex = 2
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Location = New System.Drawing.Point(155, 258)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(166, 30)
        Me.cmdSave.TabIndex = 5
        Me.cmdSave.Text = "Save"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(61, 41)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl1.TabIndex = 390
        Me.LabelControl1.Text = "Account Number"
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.EditValue = ""
        Me.txtAccountNumber.Location = New System.Drawing.Point(155, 38)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Properties.Appearance.Options.UseFont = True
        Me.txtAccountNumber.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAccountNumber.Size = New System.Drawing.Size(142, 20)
        Me.txtAccountNumber.TabIndex = 0
        '
        'code
        '
        Me.code.EditValue = ""
        Me.code.Location = New System.Drawing.Point(155, 15)
        Me.code.Name = "code"
        Me.code.Properties.Appearance.Options.UseFont = True
        Me.code.Properties.Appearance.Options.UseTextOptions = True
        Me.code.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.code.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.code.Properties.Mask.BeepOnError = True
        Me.code.Properties.ReadOnly = True
        Me.code.Size = New System.Drawing.Size(107, 20)
        Me.code.TabIndex = 0
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(120, 18)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl6.TabIndex = 389
        Me.LabelControl6.Text = "Code"
        '
        'txtBank
        '
        Me.txtBank.EditValue = ""
        Me.txtBank.Location = New System.Drawing.Point(155, 107)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.Properties.Appearance.Options.UseFont = True
        Me.txtBank.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtBank.Properties.PopupSizeable = True
        Me.txtBank.Size = New System.Drawing.Size(217, 20)
        Me.txtBank.TabIndex = 3
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(623, 436)
        Me.Em.TabIndex = 3
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdDelete, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(172, 76)
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(171, 22)
        Me.cmdEdit.Text = "Edit Bank Account"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(171, 22)
        Me.cmdDelete.Text = "Delete Account"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(168, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(246, 8)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(38, 20)
        Me.mode.TabIndex = 388
        Me.mode.Visible = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdClose, Me.BarButtonItem1, Me.BarButtonItem2})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 3
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdClose), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True)})
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
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Print Accounts"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Clear Fields"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.Name = "BarButtonItem1"
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
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1019, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 460)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1019, 18)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 436)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1019, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 436)
        '
        'frmBankAccounts
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 478)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmBankAccounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounts Setup"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.companyid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckBankAccounts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckOnlineTransaction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckposmerchant.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckEnableEmailNotification.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckCash.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAccountName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAccountNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAccountNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents code As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAccountName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ckCash As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ckEnableEmailNotification As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckposmerchant As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckOnlineTransaction As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckBankAccounts As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtItem As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridItem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBank As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents companyid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCompany As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gvCompany As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
