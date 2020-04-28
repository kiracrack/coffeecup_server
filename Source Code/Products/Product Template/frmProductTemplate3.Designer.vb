<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductTemplate3
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
        Me.productid = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtprocat = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.combogrid = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.catid = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtitem = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUnit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ckUnit = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.panelSale = New DevExpress.XtraEditors.PanelControl()
        Me.ckVatEnable = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSellingRate = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSellingPrice = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPurchasedPrice = New DevExpress.XtraEditors.TextEdit()
        Me.lblSale = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSaveParticular = New DevExpress.XtraEditors.SimpleButton()
        Me.selfrom = New DevExpress.XtraEditors.TextEdit()
        Me.ckNonInventory = New DevExpress.XtraEditors.CheckEdit()
        Me.radSaleMode = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.ckEnableSell = New DevExpress.XtraEditors.CheckEdit()
        Me.ckInputDiscount = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtBarcode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPartNumber = New DevExpress.XtraEditors.TextEdit()
        Me.ckMenuMakerInventory = New DevExpress.XtraEditors.CheckEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.ckMenuMakerServices = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtprocat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combogrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtitem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSale.SuspendLayout()
        CType(Me.ckVatEnable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSellingRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSellingPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPurchasedPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.selfrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckNonInventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radSaleMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckEnableSell.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckInputDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckMenuMakerInventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckMenuMakerServices.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'productid
        '
        Me.productid.EditValue = ""
        Me.productid.Location = New System.Drawing.Point(144, 63)
        Me.productid.Name = "productid"
        Me.productid.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.productid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productid.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.productid.Properties.Appearance.Options.UseBackColor = True
        Me.productid.Properties.Appearance.Options.UseFont = True
        Me.productid.Properties.Appearance.Options.UseForeColor = True
        Me.productid.Properties.Appearance.Options.UseTextOptions = True
        Me.productid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.productid.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.productid.Properties.Mask.BeepOnError = True
        Me.productid.Properties.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(184, 20)
        Me.productid.TabIndex = 100
        '
        'txtprocat
        '
        Me.txtprocat.EditValue = ""
        Me.txtprocat.EnterMoveNextControl = True
        Me.txtprocat.Location = New System.Drawing.Point(144, 109)
        Me.txtprocat.Name = "txtprocat"
        Me.txtprocat.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprocat.Properties.Appearance.Options.UseFont = True
        Me.txtprocat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtprocat.Properties.DisplayMember = "Select Category"
        Me.txtprocat.Properties.ImmediatePopup = True
        Me.txtprocat.Properties.NullText = ""
        Me.txtprocat.Properties.PopupView = Me.combogrid
        Me.txtprocat.Properties.ValueMember = "Select Category"
        Me.txtprocat.Size = New System.Drawing.Size(289, 20)
        Me.txtprocat.TabIndex = 1
        '
        'combogrid
        '
        Me.combogrid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.combogrid.Name = "combogrid"
        Me.combogrid.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.combogrid.OptionsView.ShowGroupPanel = False
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Location = New System.Drawing.Point(52, 135)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl17.TabIndex = 524
        Me.LabelControl17.Text = "Particular Name*"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(61, 112)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl1.TabIndex = 526
        Me.LabelControl1.Text = "Item Category*"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(80, 67)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl2.TabIndex = 527
        Me.LabelControl2.Text = "Item Code*"
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(13, 671)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Size = New System.Drawing.Size(38, 20)
        Me.mode.TabIndex = 528
        Me.mode.Visible = False
        '
        'catid
        '
        Me.catid.EditValue = ""
        Me.catid.Location = New System.Drawing.Point(52, 667)
        Me.catid.Name = "catid"
        Me.catid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.catid.Properties.Appearance.Options.UseFont = True
        Me.catid.Properties.Appearance.Options.UseTextOptions = True
        Me.catid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.catid.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.catid.Properties.Mask.BeepOnError = True
        Me.catid.Properties.ReadOnly = True
        Me.catid.Size = New System.Drawing.Size(33, 20)
        Me.catid.TabIndex = 529
        Me.catid.Visible = False
        '
        'txtitem
        '
        Me.txtitem.EnterMoveNextControl = True
        Me.txtitem.Location = New System.Drawing.Point(144, 132)
        Me.txtitem.Name = "txtitem"
        Me.txtitem.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitem.Properties.Appearance.Options.UseFont = True
        Me.txtitem.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtitem.Size = New System.Drawing.Size(289, 20)
        Me.txtitem.TabIndex = 2
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(148, 36)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(260, 13)
        Me.LabelControl7.TabIndex = 556
        Me.LabelControl7.Text = "This form is allow user add and edit particular item"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(148, 14)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(181, 19)
        Me.LabelControl5.TabIndex = 555
        Me.LabelControl5.Text = "Product Item Information"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.Silver
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Location = New System.Drawing.Point(146, 39)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(287, 16)
        Me.LabelControl8.TabIndex = 554
        Me.LabelControl8.Text = "_________________________________________________________________________________" & _
    "_____"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(85, 211)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl3.TabIndex = 558
        Me.LabelControl3.Text = "Item Unit*"
        '
        'txtUnit
        '
        Me.txtUnit.EditValue = ""
        Me.txtUnit.Location = New System.Drawing.Point(145, 208)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Properties.Appearance.Options.UseFont = True
        Me.txtUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtUnit.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtUnit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtUnit.Size = New System.Drawing.Size(102, 20)
        Me.txtUnit.TabIndex = 3
        Me.txtUnit.ToolTip = "Shortcut Key (F11)"
        '
        'ckUnit
        '
        Me.ckUnit.EditValue = True
        Me.ckUnit.Location = New System.Drawing.Point(143, 186)
        Me.ckUnit.Name = "ckUnit"
        Me.ckUnit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckUnit.Properties.Appearance.Options.UseFont = True
        Me.ckUnit.Properties.Caption = "Use existing unit"
        Me.ckUnit.Size = New System.Drawing.Size(106, 20)
        Me.ckUnit.TabIndex = 560
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(255, 185)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(179, 43)
        Me.LabelControl4.TabIndex = 561
        Me.LabelControl4.Text = "Note: Please use proper Particular name and unit to get proper inventory summary"
        '
        'panelSale
        '
        Me.panelSale.Controls.Add(Me.ckVatEnable)
        Me.panelSale.Controls.Add(Me.LabelControl14)
        Me.panelSale.Controls.Add(Me.txtSellingRate)
        Me.panelSale.Controls.Add(Me.LabelControl6)
        Me.panelSale.Controls.Add(Me.LabelControl11)
        Me.panelSale.Controls.Add(Me.txtSellingPrice)
        Me.panelSale.Controls.Add(Me.LabelControl9)
        Me.panelSale.Controls.Add(Me.LabelControl10)
        Me.panelSale.Controls.Add(Me.txtPurchasedPrice)
        Me.panelSale.Enabled = False
        Me.panelSale.Location = New System.Drawing.Point(144, 325)
        Me.panelSale.Name = "panelSale"
        Me.panelSale.Size = New System.Drawing.Size(289, 106)
        Me.panelSale.TabIndex = 4
        '
        'ckVatEnable
        '
        Me.ckVatEnable.EditValue = True
        Me.ckVatEnable.Location = New System.Drawing.Point(141, 79)
        Me.ckVatEnable.Name = "ckVatEnable"
        Me.ckVatEnable.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckVatEnable.Properties.Appearance.Options.UseFont = True
        Me.ckVatEnable.Properties.Caption = "Vatable Item"
        Me.ckVatEnable.Size = New System.Drawing.Size(142, 20)
        Me.ckVatEnable.TabIndex = 693
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Location = New System.Drawing.Point(222, 35)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(9, 13)
        Me.LabelControl14.TabIndex = 631
        Me.LabelControl14.Text = "%"
        Me.LabelControl14.Visible = False
        '
        'txtSellingRate
        '
        Me.txtSellingRate.EditValue = "0"
        Me.txtSellingRate.EnterMoveNextControl = True
        Me.txtSellingRate.Location = New System.Drawing.Point(144, 32)
        Me.txtSellingRate.Name = "txtSellingRate"
        Me.txtSellingRate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSellingRate.Properties.Appearance.Options.UseFont = True
        Me.txtSellingRate.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSellingRate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSellingRate.Properties.Mask.EditMask = "n"
        Me.txtSellingRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSellingRate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSellingRate.Size = New System.Drawing.Size(72, 20)
        Me.txtSellingRate.TabIndex = 630
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(9, 35)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl6.TabIndex = 629
        Me.LabelControl6.Text = "Selling Rate"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(9, 58)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl11.TabIndex = 413
        Me.LabelControl11.Text = "Selling Price"
        '
        'txtSellingPrice
        '
        Me.txtSellingPrice.EditValue = "0"
        Me.txtSellingPrice.Location = New System.Drawing.Point(144, 55)
        Me.txtSellingPrice.Name = "txtSellingPrice"
        Me.txtSellingPrice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSellingPrice.Properties.Appearance.Options.UseFont = True
        Me.txtSellingPrice.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSellingPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSellingPrice.Properties.Mask.EditMask = "n"
        Me.txtSellingPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSellingPrice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSellingPrice.Size = New System.Drawing.Size(140, 20)
        Me.txtSellingPrice.TabIndex = 5
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(349, 11)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl9.TabIndex = 411
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(9, 12)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl10.TabIndex = 410
        Me.LabelControl10.Text = "Purchased Price"
        '
        'txtPurchasedPrice
        '
        Me.txtPurchasedPrice.EditValue = "0"
        Me.txtPurchasedPrice.EnterMoveNextControl = True
        Me.txtPurchasedPrice.Location = New System.Drawing.Point(144, 9)
        Me.txtPurchasedPrice.Name = "txtPurchasedPrice"
        Me.txtPurchasedPrice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchasedPrice.Properties.Appearance.Options.UseFont = True
        Me.txtPurchasedPrice.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPurchasedPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPurchasedPrice.Properties.Mask.EditMask = "n"
        Me.txtPurchasedPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPurchasedPrice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPurchasedPrice.Size = New System.Drawing.Size(140, 20)
        Me.txtPurchasedPrice.TabIndex = 8
        '
        'lblSale
        '
        Me.lblSale.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSale.Appearance.Options.UseFont = True
        Me.lblSale.Location = New System.Drawing.Point(146, 308)
        Me.lblSale.Name = "lblSale"
        Me.lblSale.Size = New System.Drawing.Size(280, 13)
        Me.lblSale.TabIndex = 626
        Me.lblSale.Text = "Applicable Settings for Sales consumable product only"
        '
        'cmdSaveParticular
        '
        Me.cmdSaveParticular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSaveParticular.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSaveParticular.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSaveParticular.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveParticular.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdSaveParticular.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveParticular.Appearance.Options.UseBackColor = True
        Me.cmdSaveParticular.Appearance.Options.UseFont = True
        Me.cmdSaveParticular.Appearance.Options.UseForeColor = True
        Me.cmdSaveParticular.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSaveParticular.Location = New System.Drawing.Point(164, 558)
        Me.cmdSaveParticular.Name = "cmdSaveParticular"
        Me.cmdSaveParticular.Size = New System.Drawing.Size(185, 29)
        Me.cmdSaveParticular.TabIndex = 627
        Me.cmdSaveParticular.Text = "Save Product Information"
        '
        'selfrom
        '
        Me.selfrom.Location = New System.Drawing.Point(13, 668)
        Me.selfrom.Name = "selfrom"
        Me.selfrom.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selfrom.Properties.Appearance.Options.UseFont = True
        Me.selfrom.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.selfrom.Size = New System.Drawing.Size(37, 20)
        Me.selfrom.TabIndex = 628
        Me.selfrom.Visible = False
        '
        'ckNonInventory
        '
        Me.ckNonInventory.Location = New System.Drawing.Point(12, 697)
        Me.ckNonInventory.Name = "ckNonInventory"
        Me.ckNonInventory.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckNonInventory.Properties.Appearance.Options.UseFont = True
        Me.ckNonInventory.Properties.Caption = "Non Inventory Product"
        Me.ckNonInventory.Size = New System.Drawing.Size(216, 20)
        Me.ckNonInventory.TabIndex = 691
        Me.ckNonInventory.Visible = False
        '
        'radSaleMode
        '
        Me.radSaleMode.EditValue = "esbq"
        Me.radSaleMode.Enabled = False
        Me.radSaleMode.Location = New System.Drawing.Point(145, 438)
        Me.radSaleMode.Name = "radSaleMode"
        Me.radSaleMode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSaleMode.Properties.Appearance.Options.UseFont = True
        Me.radSaleMode.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("esbq", "Enter Sale by Quantity"), New DevExpress.XtraEditors.Controls.RadioGroupItem("esba", "Enter Sale by Amount"), New DevExpress.XtraEditors.Controls.RadioGroupItem("aea", "Allow Enter All")})
        Me.radSaleMode.Size = New System.Drawing.Size(289, 67)
        Me.radSaleMode.TabIndex = 690
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Location = New System.Drawing.Point(40, 440)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(97, 13)
        Me.LabelControl15.TabIndex = 691
        Me.LabelControl15.Text = "Entered Sale Mode"
        '
        'ckEnableSell
        '
        Me.ckEnableSell.EditValue = True
        Me.ckEnableSell.Location = New System.Drawing.Point(142, 235)
        Me.ckEnableSell.Name = "ckEnableSell"
        Me.ckEnableSell.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckEnableSell.Properties.Appearance.Options.UseFont = True
        Me.ckEnableSell.Properties.Caption = "Enable Selling this product"
        Me.ckEnableSell.Size = New System.Drawing.Size(216, 20)
        Me.ckEnableSell.TabIndex = 692
        '
        'ckInputDiscount
        '
        Me.ckInputDiscount.EditValue = True
        Me.ckInputDiscount.Location = New System.Drawing.Point(142, 510)
        Me.ckInputDiscount.Name = "ckInputDiscount"
        Me.ckInputDiscount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckInputDiscount.Properties.Appearance.Options.UseFont = True
        Me.ckInputDiscount.Properties.Caption = "Alow input Discounted Amount"
        Me.ckInputDiscount.Size = New System.Drawing.Size(216, 20)
        Me.ckInputDiscount.TabIndex = 695
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(52, 91)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl12.TabIndex = 697
        Me.LabelControl12.Text = "Product Barcode"
        '
        'txtBarcode
        '
        Me.txtBarcode.EnterMoveNextControl = True
        Me.txtBarcode.Location = New System.Drawing.Point(144, 86)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Properties.Appearance.Options.UseFont = True
        Me.txtBarcode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBarcode.Size = New System.Drawing.Size(289, 20)
        Me.txtBarcode.TabIndex = 0
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(73, 158)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl13.TabIndex = 699
        Me.LabelControl13.Text = "Part Number"
        '
        'txtPartNumber
        '
        Me.txtPartNumber.EnterMoveNextControl = True
        Me.txtPartNumber.Location = New System.Drawing.Point(144, 155)
        Me.txtPartNumber.Name = "txtPartNumber"
        Me.txtPartNumber.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartNumber.Properties.Appearance.Options.UseFont = True
        Me.txtPartNumber.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPartNumber.Size = New System.Drawing.Size(289, 20)
        Me.txtPartNumber.TabIndex = 3
        '
        'ckMenuMakerInventory
        '
        Me.ckMenuMakerInventory.Enabled = False
        Me.ckMenuMakerInventory.Location = New System.Drawing.Point(142, 257)
        Me.ckMenuMakerInventory.Name = "ckMenuMakerInventory"
        Me.ckMenuMakerInventory.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckMenuMakerInventory.Properties.Appearance.Options.UseFont = True
        Me.ckMenuMakerInventory.Properties.Caption = "Menu maker for product inventory"
        Me.ckMenuMakerInventory.Size = New System.Drawing.Size(216, 20)
        Me.ckMenuMakerInventory.TabIndex = 700
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.ContentImage = Global.Coffeecup.My.Resources.Resources.product_icon1
        Me.PanelControl1.Location = New System.Drawing.Point(76, 5)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(66, 61)
        Me.PanelControl1.TabIndex = 553
        '
        'ckMenuMakerServices
        '
        Me.ckMenuMakerServices.Enabled = False
        Me.ckMenuMakerServices.Location = New System.Drawing.Point(142, 278)
        Me.ckMenuMakerServices.Name = "ckMenuMakerServices"
        Me.ckMenuMakerServices.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckMenuMakerServices.Properties.Appearance.Options.UseFont = True
        Me.ckMenuMakerServices.Properties.Caption = "Menu maker for product services"
        Me.ckMenuMakerServices.Size = New System.Drawing.Size(216, 20)
        Me.ckMenuMakerServices.TabIndex = 701
        '
        'frmProductTemplate3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 619)
        Me.Controls.Add(Me.ckMenuMakerServices)
        Me.Controls.Add(Me.cmdSaveParticular)
        Me.Controls.Add(Me.ckMenuMakerInventory)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.txtPartNumber)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.ckInputDiscount)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.radSaleMode)
        Me.Controls.Add(Me.selfrom)
        Me.Controls.Add(Me.lblSale)
        Me.Controls.Add(Me.panelSale)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.ckUnit)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.txtprocat)
        Me.Controls.Add(Me.LabelControl17)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtitem)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.ckEnableSell)
        Me.Controls.Add(Me.ckNonInventory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductTemplate3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Item Information"
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtprocat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combogrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtitem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSale.ResumeLayout(False)
        Me.panelSale.PerformLayout()
        CType(Me.ckVatEnable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSellingRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSellingPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPurchasedPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.selfrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckNonInventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radSaleMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckEnableSell.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckInputDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBarcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckMenuMakerInventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckMenuMakerServices.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents productid As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtprocat As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents combogrid As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents catid As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtitem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUnit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ckUnit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents panelSale As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSellingPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPurchasedPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSale As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSaveParticular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents selfrom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSellingRate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckNonInventory As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents radSaleMode As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents ckEnableSell As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckVatEnable As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckInputDiscount As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBarcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPartNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckMenuMakerInventory As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckMenuMakerServices As DevExpress.XtraEditors.CheckEdit
End Class
