<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockoutQuantity
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
        Me.txtquantity = New DevExpress.XtraEditors.TextEdit()
        Me.txtproduct = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtunit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.catid = New DevExpress.XtraEditors.TextEdit()
        Me.txtAvailableQuantity = New DevExpress.XtraEditors.TextEdit()
        Me.cmdAction = New DevExpress.XtraEditors.SimpleButton()
        Me.stockid = New DevExpress.XtraEditors.TextEdit()
        Me.productid = New DevExpress.XtraEditors.TextEdit()
        Me.txtUnitCost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotalCost = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtquantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtproduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAvailableQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stockid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnitCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtquantity
        '
        Me.txtquantity.EditValue = "0"
        Me.txtquantity.Location = New System.Drawing.Point(308, 41)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txtquantity.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtquantity.Properties.Appearance.Options.UseBackColor = True
        Me.txtquantity.Properties.Appearance.Options.UseFont = True
        Me.txtquantity.Properties.Appearance.Options.UseTextOptions = True
        Me.txtquantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtquantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtquantity.Size = New System.Drawing.Size(89, 26)
        Me.txtquantity.TabIndex = 0
        '
        'txtproduct
        '
        Me.txtproduct.Location = New System.Drawing.Point(156, 18)
        Me.txtproduct.Name = "txtproduct"
        Me.txtproduct.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproduct.Properties.Appearance.Options.UseFont = True
        Me.txtproduct.Properties.Appearance.Options.UseTextOptions = True
        Me.txtproduct.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtproduct.Properties.ReadOnly = True
        Me.txtproduct.Size = New System.Drawing.Size(329, 20)
        Me.txtproduct.TabIndex = 557
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(225, 46)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(76, 15)
        Me.LabelControl6.TabIndex = 555
        Me.LabelControl6.Text = "Enter Quantity"
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(401, 41)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtunit.Properties.Appearance.Options.UseFont = True
        Me.txtunit.Properties.ReadOnly = True
        Me.txtunit.Size = New System.Drawing.Size(84, 26)
        Me.txtunit.TabIndex = 554
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(78, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl1.TabIndex = 558
        Me.LabelControl1.Text = "Product Name"
        '
        'officeid
        '
        Me.officeid.EditValue = ""
        Me.officeid.EnterMoveNextControl = True
        Me.officeid.Location = New System.Drawing.Point(18, 351)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Properties.Appearance.Options.UseTextOptions = True
        Me.officeid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.officeid.Size = New System.Drawing.Size(81, 20)
        Me.officeid.TabIndex = 563
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(156, 130)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(45, 15)
        Me.LabelControl11.TabIndex = 575
        Me.LabelControl11.Text = "Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.EditValue = ""
        Me.txtRemarks.Location = New System.Drawing.Point(208, 128)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtRemarks.Properties.Appearance.Options.UseFont = True
        Me.txtRemarks.Size = New System.Drawing.Size(277, 45)
        Me.txtRemarks.TabIndex = 2
        '
        'catid
        '
        Me.catid.EditValue = ""
        Me.catid.EnterMoveNextControl = True
        Me.catid.Location = New System.Drawing.Point(105, 348)
        Me.catid.Name = "catid"
        Me.catid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.catid.Properties.Appearance.Options.UseFont = True
        Me.catid.Properties.Appearance.Options.UseTextOptions = True
        Me.catid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.catid.Size = New System.Drawing.Size(81, 20)
        Me.catid.TabIndex = 580
        '
        'txtAvailableQuantity
        '
        Me.txtAvailableQuantity.EditValue = ""
        Me.txtAvailableQuantity.EnterMoveNextControl = True
        Me.txtAvailableQuantity.Location = New System.Drawing.Point(16, 319)
        Me.txtAvailableQuantity.Name = "txtAvailableQuantity"
        Me.txtAvailableQuantity.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableQuantity.Properties.Appearance.Options.UseFont = True
        Me.txtAvailableQuantity.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAvailableQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAvailableQuantity.Size = New System.Drawing.Size(81, 20)
        Me.txtAvailableQuantity.TabIndex = 581
        Me.txtAvailableQuantity.Visible = False
        '
        'cmdAction
        '
        Me.cmdAction.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAction.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdAction.Appearance.Options.UseFont = True
        Me.cmdAction.Location = New System.Drawing.Point(318, 177)
        Me.cmdAction.Name = "cmdAction"
        Me.cmdAction.Size = New System.Drawing.Size(167, 32)
        Me.cmdAction.TabIndex = 3
        Me.cmdAction.Text = "Confirm"
        '
        'stockid
        '
        Me.stockid.EditValue = ""
        Me.stockid.EnterMoveNextControl = True
        Me.stockid.Location = New System.Drawing.Point(195, 379)
        Me.stockid.Name = "stockid"
        Me.stockid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockid.Properties.Appearance.Options.UseFont = True
        Me.stockid.Properties.Appearance.Options.UseTextOptions = True
        Me.stockid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.stockid.Size = New System.Drawing.Size(81, 20)
        Me.stockid.TabIndex = 608
        '
        'productid
        '
        Me.productid.EditValue = ""
        Me.productid.EnterMoveNextControl = True
        Me.productid.Location = New System.Drawing.Point(108, 379)
        Me.productid.Name = "productid"
        Me.productid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productid.Properties.Appearance.Options.UseFont = True
        Me.productid.Properties.Appearance.Options.UseTextOptions = True
        Me.productid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.productid.Size = New System.Drawing.Size(81, 20)
        Me.productid.TabIndex = 609
        '
        'txtUnitCost
        '
        Me.txtUnitCost.EditValue = "0.00"
        Me.txtUnitCost.EnterMoveNextControl = True
        Me.txtUnitCost.Location = New System.Drawing.Point(308, 70)
        Me.txtUnitCost.Name = "txtUnitCost"
        Me.txtUnitCost.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtUnitCost.Properties.Appearance.Options.UseFont = True
        Me.txtUnitCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUnitCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtUnitCost.Properties.ReadOnly = True
        Me.txtUnitCost.Size = New System.Drawing.Size(177, 26)
        Me.txtUnitCost.TabIndex = 610
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(252, 75)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(49, 15)
        Me.LabelControl3.TabIndex = 611
        Me.LabelControl3.Text = "Unit Cost"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(247, 104)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(54, 15)
        Me.LabelControl4.TabIndex = 613
        Me.LabelControl4.Text = "Total Cost"
        '
        'txtTotalCost
        '
        Me.txtTotalCost.EditValue = "0.00"
        Me.txtTotalCost.EnterMoveNextControl = True
        Me.txtTotalCost.Location = New System.Drawing.Point(308, 99)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtTotalCost.Properties.Appearance.Options.UseFont = True
        Me.txtTotalCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalCost.Properties.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(177, 26)
        Me.txtTotalCost.TabIndex = 612
        '
        'frmStockoutQuantity
        '
        Me.AcceptButton = Me.cmdAction
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 225)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtUnitCost)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.stockid)
        Me.Controls.Add(Me.cmdAction)
        Me.Controls.Add(Me.txtAvailableQuantity)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtproduct)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.txtunit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockoutQuantity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Quantity"
        CType(Me.txtquantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtproduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAvailableQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stockid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnitCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtquantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtproduct As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtunit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents catid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAvailableQuantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdAction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents stockid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents productid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUnitCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalCost As DevExpress.XtraEditors.TextEdit
End Class
