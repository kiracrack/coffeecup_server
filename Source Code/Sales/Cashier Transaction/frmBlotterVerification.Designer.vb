﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBlotterVerification
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
        Me.cmdOk = New DevExpress.XtraEditors.SimpleButton()
        Me.itemcode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCashTo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridCashTo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cashTo = New DevExpress.XtraEditors.TextEdit()
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtOverages = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtShortages = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmountDeposit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.trncode = New DevExpress.XtraEditors.TextEdit()
        Me.cashfrom = New DevExpress.XtraEditors.TextEdit()
        Me.txtCashEnd = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCashOnHand = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCashier = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtdepositref = New DevExpress.XtraEditors.TextEdit()
        Me.txtdateTransaction = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.txtNextBeginningCash = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShortcutToProductCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshLedgerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.itemcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCashTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCashTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cashTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOverages.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtShortages.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmountDeposit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trncode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cashfrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCashEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCashOnHand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCashier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtdepositref.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdateTransaction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNextBeginningCash.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdOk.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdOk.Appearance.Options.UseFont = True
        Me.cmdOk.Location = New System.Drawing.Point(126, 390)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(205, 30)
        Me.cmdOk.TabIndex = 5
        Me.cmdOk.Text = "Verify Transaction"
        '
        'itemcode
        '
        Me.itemcode.Location = New System.Drawing.Point(357, 90)
        Me.itemcode.Name = "itemcode"
        Me.itemcode.Properties.Appearance.Options.UseTextOptions = True
        Me.itemcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.itemcode.Properties.ReadOnly = True
        Me.itemcode.Size = New System.Drawing.Size(53, 20)
        Me.itemcode.TabIndex = 651
        Me.itemcode.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(93, 96)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 15)
        Me.LabelControl2.TabIndex = 653
        Me.LabelControl2.Text = "Deposit to"
        '
        'txtCashTo
        '
        Me.txtCashTo.EditValue = "Select Group"
        Me.txtCashTo.Location = New System.Drawing.Point(156, 92)
        Me.txtCashTo.Name = "txtCashTo"
        Me.txtCashTo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCashTo.Properties.Appearance.Options.UseFont = True
        Me.txtCashTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCashTo.Properties.DisplayMember = "Account Name"
        Me.txtCashTo.Properties.ImmediatePopup = True
        Me.txtCashTo.Properties.NullText = ""
        Me.txtCashTo.Properties.PopupView = Me.gridCashTo
        Me.txtCashTo.Properties.ValueMember = "Account Name"
        Me.txtCashTo.Size = New System.Drawing.Size(253, 22)
        Me.txtCashTo.TabIndex = 2
        '
        'gridCashTo
        '
        Me.gridCashTo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridCashTo.Name = "gridCashTo"
        Me.gridCashTo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridCashTo.OptionsView.ShowGroupPanel = False
        '
        'cashTo
        '
        Me.cashTo.Location = New System.Drawing.Point(357, 141)
        Me.cashTo.Name = "cashTo"
        Me.cashTo.Properties.Appearance.Options.UseTextOptions = True
        Me.cashTo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cashTo.Properties.ReadOnly = True
        Me.cashTo.Size = New System.Drawing.Size(53, 20)
        Me.cashTo.TabIndex = 654
        Me.cashTo.Visible = False
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(156, 140)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRemarks.Properties.Appearance.Options.UseFont = True
        Me.txtRemarks.Size = New System.Drawing.Size(253, 40)
        Me.txtRemarks.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(102, 143)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(45, 15)
        Me.LabelControl5.TabIndex = 656
        Me.LabelControl5.Text = "Remarks"
        '
        'txtOverages
        '
        Me.txtOverages.EditValue = "0.00"
        Me.txtOverages.Location = New System.Drawing.Point(156, 42)
        Me.txtOverages.Name = "txtOverages"
        Me.txtOverages.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOverages.Properties.Appearance.Options.UseFont = True
        Me.txtOverages.Properties.Appearance.Options.UseTextOptions = True
        Me.txtOverages.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtOverages.Properties.Mask.EditMask = "n"
        Me.txtOverages.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtOverages.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtOverages.Properties.ReadOnly = True
        Me.txtOverages.Size = New System.Drawing.Size(166, 22)
        Me.txtOverages.TabIndex = 659
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(98, 46)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(49, 15)
        Me.LabelControl7.TabIndex = 660
        Me.LabelControl7.Text = "Overages"
        '
        'txtShortages
        '
        Me.txtShortages.EditValue = "0.00"
        Me.txtShortages.Location = New System.Drawing.Point(156, 67)
        Me.txtShortages.Name = "txtShortages"
        Me.txtShortages.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShortages.Properties.Appearance.Options.UseFont = True
        Me.txtShortages.Properties.Appearance.Options.UseTextOptions = True
        Me.txtShortages.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtShortages.Properties.Mask.EditMask = "n"
        Me.txtShortages.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtShortages.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtShortages.Properties.ReadOnly = True
        Me.txtShortages.Size = New System.Drawing.Size(166, 22)
        Me.txtShortages.TabIndex = 661
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(95, 70)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(52, 15)
        Me.LabelControl8.TabIndex = 662
        Me.LabelControl8.Text = "Shortages"
        '
        'txtAmountDeposit
        '
        Me.txtAmountDeposit.EditValue = "0.00"
        Me.txtAmountDeposit.Location = New System.Drawing.Point(156, 12)
        Me.txtAmountDeposit.Name = "txtAmountDeposit"
        Me.txtAmountDeposit.Properties.Appearance.BackColor = System.Drawing.Color.Gold
        Me.txtAmountDeposit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtAmountDeposit.Properties.Appearance.Options.UseBackColor = True
        Me.txtAmountDeposit.Properties.Appearance.Options.UseFont = True
        Me.txtAmountDeposit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmountDeposit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmountDeposit.Properties.Mask.EditMask = "n"
        Me.txtAmountDeposit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmountDeposit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmountDeposit.Properties.ReadOnly = True
        Me.txtAmountDeposit.Size = New System.Drawing.Size(166, 26)
        Me.txtAmountDeposit.TabIndex = 663
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(38, 15)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(109, 20)
        Me.LabelControl9.TabIndex = 664
        Me.LabelControl9.Text = "Deposit Amount"
        '
        'trncode
        '
        Me.trncode.Location = New System.Drawing.Point(175, 20)
        Me.trncode.Name = "trncode"
        Me.trncode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trncode.Properties.Appearance.Options.UseFont = True
        Me.trncode.Properties.Appearance.Options.UseTextOptions = True
        Me.trncode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.trncode.Properties.ReadOnly = True
        Me.trncode.Size = New System.Drawing.Size(105, 20)
        Me.trncode.TabIndex = 668
        '
        'cashfrom
        '
        Me.cashfrom.Location = New System.Drawing.Point(357, 67)
        Me.cashfrom.Name = "cashfrom"
        Me.cashfrom.Properties.Appearance.Options.UseTextOptions = True
        Me.cashfrom.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cashfrom.Properties.ReadOnly = True
        Me.cashfrom.Size = New System.Drawing.Size(53, 20)
        Me.cashfrom.TabIndex = 670
        Me.cashfrom.Visible = False
        '
        'txtCashEnd
        '
        Me.txtCashEnd.EditValue = "0.00"
        Me.txtCashEnd.Location = New System.Drawing.Point(175, 91)
        Me.txtCashEnd.Name = "txtCashEnd"
        Me.txtCashEnd.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashEnd.Properties.Appearance.Options.UseFont = True
        Me.txtCashEnd.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCashEnd.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCashEnd.Properties.Mask.EditMask = "n"
        Me.txtCashEnd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCashEnd.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCashEnd.Properties.ReadOnly = True
        Me.txtCashEnd.Size = New System.Drawing.Size(166, 22)
        Me.txtCashEnd.TabIndex = 675
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(76, 94)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(90, 15)
        Me.LabelControl12.TabIndex = 676
        Me.LabelControl12.Text = "System Cash End"
        '
        'txtCashOnHand
        '
        Me.txtCashOnHand.EditValue = "0.00"
        Me.txtCashOnHand.Location = New System.Drawing.Point(175, 116)
        Me.txtCashOnHand.Name = "txtCashOnHand"
        Me.txtCashOnHand.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashOnHand.Properties.Appearance.Options.UseFont = True
        Me.txtCashOnHand.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCashOnHand.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCashOnHand.Properties.Mask.EditMask = "n"
        Me.txtCashOnHand.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCashOnHand.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCashOnHand.Properties.ReadOnly = True
        Me.txtCashOnHand.Size = New System.Drawing.Size(166, 22)
        Me.txtCashOnHand.TabIndex = 689
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Location = New System.Drawing.Point(74, 120)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(92, 15)
        Me.LabelControl14.TabIndex = 690
        Me.LabelControl14.Text = "Actual Cash Sales"
        '
        'txtCashier
        '
        Me.txtCashier.Location = New System.Drawing.Point(175, 43)
        Me.txtCashier.Name = "txtCashier"
        Me.txtCashier.Properties.ReadOnly = True
        Me.txtCashier.Size = New System.Drawing.Size(166, 20)
        Me.txtCashier.TabIndex = 694
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.txtdepositref)
        Me.PanelControl1.Controls.Add(Me.txtCashTo)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txtRemarks)
        Me.PanelControl1.Controls.Add(Me.LabelControl9)
        Me.PanelControl1.Controls.Add(Me.txtAmountDeposit)
        Me.PanelControl1.Controls.Add(Me.txtOverages)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.txtShortages)
        Me.PanelControl1.Location = New System.Drawing.Point(19, 175)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(432, 195)
        Me.PanelControl1.TabIndex = 696
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(40, 120)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(107, 15)
        Me.LabelControl6.TabIndex = 701
        Me.LabelControl6.Text = "Deposit Slip Ref. No."
        '
        'txtdepositref
        '
        Me.txtdepositref.Location = New System.Drawing.Point(156, 117)
        Me.txtdepositref.Name = "txtdepositref"
        Me.txtdepositref.Size = New System.Drawing.Size(166, 20)
        Me.txtdepositref.TabIndex = 700
        '
        'txtdateTransaction
        '
        Me.txtdateTransaction.Location = New System.Drawing.Point(175, 66)
        Me.txtdateTransaction.Name = "txtdateTransaction"
        Me.txtdateTransaction.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdateTransaction.Properties.Appearance.Options.UseFont = True
        Me.txtdateTransaction.Properties.ReadOnly = True
        Me.txtdateTransaction.Size = New System.Drawing.Size(166, 22)
        Me.txtdateTransaction.TabIndex = 697
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(99, 69)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(67, 15)
        Me.LabelControl1.TabIndex = 698
        Me.LabelControl1.Text = "Closing Date"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(127, 45)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(39, 15)
        Me.LabelControl3.TabIndex = 699
        Me.LabelControl3.Text = "Cashier"
        '
        'officeid
        '
        Me.officeid.Location = New System.Drawing.Point(357, 116)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Options.UseTextOptions = True
        Me.officeid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(53, 20)
        Me.officeid.TabIndex = 700
        Me.officeid.Visible = False
        '
        'txtNextBeginningCash
        '
        Me.txtNextBeginningCash.EditValue = "0.00"
        Me.txtNextBeginningCash.Location = New System.Drawing.Point(175, 141)
        Me.txtNextBeginningCash.Name = "txtNextBeginningCash"
        Me.txtNextBeginningCash.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNextBeginningCash.Properties.Appearance.Options.UseFont = True
        Me.txtNextBeginningCash.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNextBeginningCash.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNextBeginningCash.Properties.Mask.EditMask = "n"
        Me.txtNextBeginningCash.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNextBeginningCash.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNextBeginningCash.Properties.ReadOnly = True
        Me.txtNextBeginningCash.Size = New System.Drawing.Size(166, 22)
        Me.txtNextBeginningCash.TabIndex = 701
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(56, 145)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(110, 15)
        Me.LabelControl4.TabIndex = 702
        Me.LabelControl4.Text = "Next Beginning Cash"
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        GridLevelNode1.RelationName = "Level1"
        Me.Em.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Em.Location = New System.Drawing.Point(474, 12)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(0, 432)
        Me.Em.TabIndex = 703
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShortcutToProductCategoryToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshLedgerToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(230, 54)
        '
        'ShortcutToProductCategoryToolStripMenuItem
        '
        Me.ShortcutToProductCategoryToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.notebook__arrow1
        Me.ShortcutToProductCategoryToolStripMenuItem.Name = "ShortcutToProductCategoryToolStripMenuItem"
        Me.ShortcutToProductCategoryToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.ShortcutToProductCategoryToolStripMenuItem.Text = "Shortcut to Product Category"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(226, 6)
        '
        'RefreshLedgerToolStripMenuItem
        '
        Me.RefreshLedgerToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshLedgerToolStripMenuItem.Name = "RefreshLedgerToolStripMenuItem"
        Me.RefreshLedgerToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.RefreshLedgerToolStripMenuItem.Text = "Refresh Ledger"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(82, 23)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(84, 15)
        Me.LabelControl10.TabIndex = 704
        Me.LabelControl10.Text = "Transaction No."
        '
        'frmBlotterVerification
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 456)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.txtNextBeginningCash)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.txtCashier)
        Me.Controls.Add(Me.txtCashOnHand)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.txtCashEnd)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.cashfrom)
        Me.Controls.Add(Me.trncode)
        Me.Controls.Add(Me.cashTo)
        Me.Controls.Add(Me.itemcode)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.txtdateTransaction)
        Me.Name = "frmBlotterVerification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cashier's Blotter Verification"
        CType(Me.itemcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCashTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCashTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cashTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOverages.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtShortages.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmountDeposit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trncode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cashfrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCashEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCashOnHand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCashier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtdepositref.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdateTransaction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNextBeginningCash.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents itemcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCashTo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gridCashTo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cashTo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOverages As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtShortages As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmountDeposit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents trncode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cashfrom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCashEnd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCashOnHand As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCashier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtdateTransaction As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNextBeginningCash As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdepositref As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshLedgerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShortcutToProductCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
End Class
