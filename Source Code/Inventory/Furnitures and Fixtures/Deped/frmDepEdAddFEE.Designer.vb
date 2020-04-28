<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepEdAddFEE
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
        Me.lblcaption = New DevExpress.XtraEditors.LabelControl()
        Me.cmdOk = New DevExpress.XtraEditors.SimpleButton()
        Me.txtItemDetails = New DevExpress.XtraEditors.MemoEdit()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.txtoffice = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridcompoffice = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblOffice = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtProductItemName = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.g_product = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPropertyNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUnitCost = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalCost = New DevExpress.XtraEditors.TextEdit()
        Me.txtQuantity = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEstimatedLife = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtUnit = New DevExpress.XtraEditors.TextEdit()
        Me.txtDateAcquired = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.txtAccountablePerson = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.s_grid = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.accountable = New DevExpress.XtraEditors.TextEdit()
        Me.productid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtVendor = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.g_vendor = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.vendorid = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAddItem = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtItemDetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtoffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridcompoffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductItemName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPropertyNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnitCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstimatedLife.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateAcquired.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateAcquired.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAccountablePerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.s_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.accountable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g_vendor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vendorid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcaption
        '
        Me.lblcaption.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcaption.Appearance.Options.UseFont = True
        Me.lblcaption.Appearance.Options.UseTextOptions = True
        Me.lblcaption.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lblcaption.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lblcaption.Location = New System.Drawing.Point(34, 94)
        Me.lblcaption.Name = "lblcaption"
        Me.lblcaption.Size = New System.Drawing.Size(94, 13)
        Me.lblcaption.TabIndex = 584
        Me.lblcaption.Text = "Equipment Details"
        '
        'cmdOk
        '
        Me.cmdOk.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdOk.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdOk.Appearance.Options.UseFont = True
        Me.cmdOk.Appearance.Options.UseForeColor = True
        Me.cmdOk.Location = New System.Drawing.Point(135, 394)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(154, 30)
        Me.cmdOk.TabIndex = 10
        Me.cmdOk.Text = "Confirm"
        '
        'txtItemDetails
        '
        Me.txtItemDetails.EditValue = ""
        Me.txtItemDetails.Location = New System.Drawing.Point(135, 92)
        Me.txtItemDetails.Name = "txtItemDetails"
        Me.txtItemDetails.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDetails.Properties.Appearance.Options.UseFont = True
        Me.txtItemDetails.Size = New System.Drawing.Size(284, 124)
        Me.txtItemDetails.TabIndex = 3
        '
        'officeid
        '
        Me.officeid.Location = New System.Drawing.Point(479, 21)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(44, 20)
        Me.officeid.TabIndex = 590
        Me.officeid.Visible = False
        '
        'txtoffice
        '
        Me.txtoffice.EditValue = ""
        Me.txtoffice.Location = New System.Drawing.Point(135, 21)
        Me.txtoffice.Name = "txtoffice"
        Me.txtoffice.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtoffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtoffice.Properties.Appearance.Options.UseFont = True
        Me.txtoffice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtoffice.Properties.NullText = ""
        Me.txtoffice.Properties.PopupView = Me.gridcompoffice
        Me.txtoffice.Size = New System.Drawing.Size(222, 20)
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
        Me.lblOffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblOffice.Appearance.Options.UseFont = True
        Me.lblOffice.Location = New System.Drawing.Point(64, 24)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(64, 13)
        Me.lblOffice.TabIndex = 592
        Me.lblOffice.Text = "Select Office"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(26, 44)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl5.TabIndex = 594
        Me.LabelControl5.Text = "Accountable Person"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(35, 70)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(93, 15)
        Me.LabelControl9.TabIndex = 596
        Me.LabelControl9.Text = "Select Item Name"
        '
        'txtProductItemName
        '
        Me.txtProductItemName.EditValue = ""
        Me.txtProductItemName.EnterMoveNextControl = True
        Me.txtProductItemName.Location = New System.Drawing.Point(135, 67)
        Me.txtProductItemName.Name = "txtProductItemName"
        Me.txtProductItemName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductItemName.Properties.Appearance.Options.UseFont = True
        Me.txtProductItemName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtProductItemName.Properties.DisplayMember = "Select Product"
        Me.txtProductItemName.Properties.NullText = ""
        Me.txtProductItemName.Properties.PopupFormMinSize = New System.Drawing.Size(500, 500)
        Me.txtProductItemName.Properties.PopupFormSize = New System.Drawing.Size(500, 500)
        Me.txtProductItemName.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.txtProductItemName.Properties.PopupView = Me.g_product
        Me.txtProductItemName.Properties.ValueMember = "Select Product"
        Me.txtProductItemName.Size = New System.Drawing.Size(222, 22)
        Me.txtProductItemName.TabIndex = 2
        '
        'g_product
        '
        Me.g_product.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.g_product.Name = "g_product"
        Me.g_product.OptionsBehavior.AllowIncrementalSearch = True
        Me.g_product.OptionsFilter.AllowFilterIncrementalSearch = False
        Me.g_product.OptionsFind.ClearFindOnClose = False
        Me.g_product.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.g_product.OptionsFind.SearchInPreview = True
        Me.g_product.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.g_product.OptionsView.ColumnAutoWidth = False
        Me.g_product.OptionsView.ShowGroupPanel = False
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(36, 222)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(92, 15)
        Me.LabelControl11.TabIndex = 648
        Me.LabelControl11.Text = "Property Number"
        '
        'txtPropertyNo
        '
        Me.txtPropertyNo.EditValue = ""
        Me.txtPropertyNo.EnterMoveNextControl = True
        Me.txtPropertyNo.Location = New System.Drawing.Point(135, 219)
        Me.txtPropertyNo.Name = "txtPropertyNo"
        Me.txtPropertyNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropertyNo.Properties.Appearance.Options.UseFont = True
        Me.txtPropertyNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPropertyNo.Size = New System.Drawing.Size(204, 22)
        Me.txtPropertyNo.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(79, 272)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(49, 15)
        Me.LabelControl2.TabIndex = 653
        Me.LabelControl2.Text = "Unit Cost"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(74, 297)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 15)
        Me.LabelControl1.TabIndex = 654
        Me.LabelControl1.Text = "Total Cost"
        '
        'txtUnitCost
        '
        Me.txtUnitCost.EditValue = "0.00"
        Me.txtUnitCost.Location = New System.Drawing.Point(135, 269)
        Me.txtUnitCost.Name = "txtUnitCost"
        Me.txtUnitCost.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitCost.Properties.Appearance.Options.UseFont = True
        Me.txtUnitCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUnitCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtUnitCost.Properties.Mask.EditMask = "n"
        Me.txtUnitCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtUnitCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtUnitCost.Size = New System.Drawing.Size(132, 22)
        Me.txtUnitCost.TabIndex = 6
        '
        'txtTotalCost
        '
        Me.txtTotalCost.EditValue = "0.00"
        Me.txtTotalCost.Location = New System.Drawing.Point(135, 294)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCost.Properties.Appearance.Options.UseFont = True
        Me.txtTotalCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalCost.Properties.Mask.EditMask = "n"
        Me.txtTotalCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalCost.Properties.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(132, 22)
        Me.txtTotalCost.TabIndex = 651
        Me.txtTotalCost.ToolTipTitle = "When got focus press enter to add this item to batch"
        '
        'txtQuantity
        '
        Me.txtQuantity.EditValue = "0"
        Me.txtQuantity.EnterMoveNextControl = True
        Me.txtQuantity.Location = New System.Drawing.Point(135, 244)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txtQuantity.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtQuantity.Properties.Appearance.Options.UseBackColor = True
        Me.txtQuantity.Properties.Appearance.Options.UseFont = True
        Me.txtQuantity.Properties.Appearance.Options.UseForeColor = True
        Me.txtQuantity.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtQuantity.Properties.Mask.EditMask = "n"
        Me.txtQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtQuantity.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtQuantity.Size = New System.Drawing.Size(132, 22)
        Me.txtQuantity.TabIndex = 5
        Me.txtQuantity.ToolTip = "Shortcut Key (F9)"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(82, 248)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 15)
        Me.LabelControl3.TabIndex = 652
        Me.LabelControl3.Text = "Quantity"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(54, 322)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(74, 15)
        Me.LabelControl4.TabIndex = 656
        Me.LabelControl4.Text = "Estimated Life"
        '
        'txtEstimatedLife
        '
        Me.txtEstimatedLife.EditValue = ""
        Me.txtEstimatedLife.Location = New System.Drawing.Point(135, 319)
        Me.txtEstimatedLife.Name = "txtEstimatedLife"
        Me.txtEstimatedLife.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstimatedLife.Properties.Appearance.Options.UseFont = True
        Me.txtEstimatedLife.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtEstimatedLife.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstimatedLife.Size = New System.Drawing.Size(132, 22)
        Me.txtEstimatedLife.TabIndex = 7
        Me.txtEstimatedLife.ToolTip = "Shortcut Key (F11)"
        '
        'txtUnit
        '
        Me.txtUnit.EditValue = ""
        Me.txtUnit.EnterMoveNextControl = True
        Me.txtUnit.Location = New System.Drawing.Point(270, 244)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Properties.Appearance.Options.UseFont = True
        Me.txtUnit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUnit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtUnit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnit.Properties.ReadOnly = True
        Me.txtUnit.Size = New System.Drawing.Size(69, 22)
        Me.txtUnit.TabIndex = 657
        Me.txtUnit.ToolTip = "Shortcut Key (F11)"
        '
        'txtDateAcquired
        '
        Me.txtDateAcquired.EditValue = New Date(CType(0, Long))
        Me.txtDateAcquired.Location = New System.Drawing.Point(135, 344)
        Me.txtDateAcquired.Name = "txtDateAcquired"
        Me.txtDateAcquired.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateAcquired.Properties.Appearance.Options.UseFont = True
        Me.txtDateAcquired.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateAcquired.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDateAcquired.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtDateAcquired.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDateAcquired.Size = New System.Drawing.Size(132, 22)
        Me.txtDateAcquired.TabIndex = 8
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(53, 347)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(75, 15)
        Me.LabelControl12.TabIndex = 659
        Me.LabelControl12.Text = "Date Acquired"
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(529, 21)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Properties.Appearance.Options.UseFont = True
        Me.id.Properties.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(44, 20)
        Me.id.TabIndex = 660
        Me.id.Visible = False
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(529, 48)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(44, 20)
        Me.mode.TabIndex = 661
        Me.mode.Visible = False
        '
        'txtAccountablePerson
        '
        Me.txtAccountablePerson.EditValue = ""
        Me.txtAccountablePerson.Location = New System.Drawing.Point(135, 44)
        Me.txtAccountablePerson.Name = "txtAccountablePerson"
        Me.txtAccountablePerson.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtAccountablePerson.Properties.Appearance.Options.UseFont = True
        Me.txtAccountablePerson.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAccountablePerson.Properties.DisplayMember = "Fullname"
        Me.txtAccountablePerson.Properties.NullText = ""
        Me.txtAccountablePerson.Properties.PopupView = Me.s_grid
        Me.txtAccountablePerson.Properties.ValueMember = "Fullname"
        Me.txtAccountablePerson.Size = New System.Drawing.Size(222, 20)
        Me.txtAccountablePerson.TabIndex = 1
        '
        's_grid
        '
        Me.s_grid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.s_grid.Name = "s_grid"
        Me.s_grid.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.s_grid.OptionsView.ShowGroupPanel = False
        '
        'accountable
        '
        Me.accountable.Location = New System.Drawing.Point(479, 48)
        Me.accountable.Name = "accountable"
        Me.accountable.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountable.Properties.Appearance.Options.UseFont = True
        Me.accountable.Properties.ReadOnly = True
        Me.accountable.Size = New System.Drawing.Size(44, 20)
        Me.accountable.TabIndex = 663
        Me.accountable.Visible = False
        '
        'productid
        '
        Me.productid.Location = New System.Drawing.Point(479, 71)
        Me.productid.Name = "productid"
        Me.productid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productid.Properties.Appearance.Options.UseFont = True
        Me.productid.Properties.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(44, 20)
        Me.productid.TabIndex = 664
        Me.productid.Visible = False
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(85, 372)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(43, 15)
        Me.LabelControl6.TabIndex = 666
        Me.LabelControl6.Text = "Supplier"
        '
        'txtVendor
        '
        Me.txtVendor.EditValue = ""
        Me.txtVendor.EnterMoveNextControl = True
        Me.txtVendor.Location = New System.Drawing.Point(135, 369)
        Me.txtVendor.Name = "txtVendor"
        Me.txtVendor.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendor.Properties.Appearance.Options.UseFont = True
        Me.txtVendor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtVendor.Properties.DisplayMember = "Select Company"
        Me.txtVendor.Properties.NullText = ""
        Me.txtVendor.Properties.PopupFormMinSize = New System.Drawing.Size(500, 500)
        Me.txtVendor.Properties.PopupFormSize = New System.Drawing.Size(500, 500)
        Me.txtVendor.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.txtVendor.Properties.PopupView = Me.g_vendor
        Me.txtVendor.Properties.ValueMember = "Select Company"
        Me.txtVendor.Size = New System.Drawing.Size(204, 22)
        Me.txtVendor.TabIndex = 9
        '
        'g_vendor
        '
        Me.g_vendor.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.g_vendor.Name = "g_vendor"
        Me.g_vendor.OptionsBehavior.AllowIncrementalSearch = True
        Me.g_vendor.OptionsFilter.AllowFilterIncrementalSearch = False
        Me.g_vendor.OptionsFind.ClearFindOnClose = False
        Me.g_vendor.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.g_vendor.OptionsFind.SearchInPreview = True
        Me.g_vendor.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.g_vendor.OptionsView.ShowGroupPanel = False
        '
        'vendorid
        '
        Me.vendorid.Location = New System.Drawing.Point(479, 294)
        Me.vendorid.Name = "vendorid"
        Me.vendorid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vendorid.Properties.Appearance.Options.UseFont = True
        Me.vendorid.Properties.ReadOnly = True
        Me.vendorid.Size = New System.Drawing.Size(44, 20)
        Me.vendorid.TabIndex = 667
        Me.vendorid.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton1.ImageOptions.Image = Global.Coffeecup.My.Resources.Resources.truck__plus
        Me.SimpleButton1.Location = New System.Drawing.Point(342, 370)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(24, 20)
        Me.SimpleButton1.TabIndex = 670
        Me.SimpleButton1.ToolTip = "Add New Particular"
        '
        'cmdAddItem
        '
        Me.cmdAddItem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdAddItem.ImageOptions.Image = Global.Coffeecup.My.Resources.Resources.newspaper__plus
        Me.cmdAddItem.Location = New System.Drawing.Point(360, 68)
        Me.cmdAddItem.Name = "cmdAddItem"
        Me.cmdAddItem.Size = New System.Drawing.Size(24, 20)
        Me.cmdAddItem.TabIndex = 668
        Me.cmdAddItem.ToolTip = "Add New Particular"
        '
        'frmDepEdAddFEE
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 441)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.cmdAddItem)
        Me.Controls.Add(Me.vendorid)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtVendor)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.accountable)
        Me.Controls.Add(Me.txtAccountablePerson)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.txtDateAcquired)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtUnitCost)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.txtPropertyNo)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtProductItemName)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtoffice)
        Me.Controls.Add(Me.lblOffice)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.txtItemDetails)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.lblcaption)
        Me.Controls.Add(Me.txtEstimatedLife)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDepEdAddFEE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Office Equipment Information"
        CType(Me.txtItemDetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtoffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridcompoffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductItemName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPropertyNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnitCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstimatedLife.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateAcquired.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateAcquired.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAccountablePerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.s_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.accountable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g_vendor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vendorid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblcaption As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtItemDetails As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtoffice As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridcompoffice As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblOffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProductItemName As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents g_product As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPropertyNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUnitCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtQuantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEstimatedLife As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtUnit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDateAcquired As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAccountablePerson As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents s_grid As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents accountable As DevExpress.XtraEditors.TextEdit
    Friend WithEvents productid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVendor As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents g_vendor As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents vendorid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdAddItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
