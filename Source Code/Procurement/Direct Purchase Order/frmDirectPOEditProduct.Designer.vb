<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDirectPOEditProduct
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
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtQuantity = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalCost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUnitCost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtremarks = New DevExpress.XtraEditors.MemoEdit()
        Me.productid = New DevExpress.XtraEditors.TextEdit()
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.txtunit = New DevExpress.XtraEditors.TextEdit()
        Me.txtProductName = New DevExpress.XtraEditors.TextEdit()
        Me.trnid = New DevExpress.XtraEditors.TextEdit()
        Me.ponumber = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnitCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtremarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ponumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(266, 53)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(53, 17)
        Me.LabelControl6.TabIndex = 382
        Me.LabelControl6.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.EditValue = "1"
        Me.txtQuantity.EnterMoveNextControl = True
        Me.txtQuantity.Location = New System.Drawing.Point(326, 50)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtQuantity.Properties.Appearance.Options.UseFont = True
        Me.txtQuantity.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtQuantity.Properties.Mask.EditMask = "n3"
        Me.txtQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtQuantity.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtQuantity.Size = New System.Drawing.Size(100, 24)
        Me.txtQuantity.TabIndex = 0
        '
        'txtTotalCost
        '
        Me.txtTotalCost.EditValue = "0.00"
        Me.txtTotalCost.Location = New System.Drawing.Point(326, 102)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txtTotalCost.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtTotalCost.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalCost.Properties.Appearance.Options.UseFont = True
        Me.txtTotalCost.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotalCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalCost.Properties.Mask.EditMask = "n"
        Me.txtTotalCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalCost.Size = New System.Drawing.Size(182, 24)
        Me.txtTotalCost.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(249, 105)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(70, 18)
        Me.LabelControl2.TabIndex = 387
        Me.LabelControl2.Text = "Sub Total"
        '
        'txtUnitCost
        '
        Me.txtUnitCost.EditValue = "0.00"
        Me.txtUnitCost.Location = New System.Drawing.Point(326, 76)
        Me.txtUnitCost.Name = "txtUnitCost"
        Me.txtUnitCost.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtUnitCost.Properties.Appearance.Options.UseFont = True
        Me.txtUnitCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUnitCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtUnitCost.Properties.Mask.EditMask = "n3"
        Me.txtUnitCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtUnitCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtUnitCost.Size = New System.Drawing.Size(182, 24)
        Me.txtUnitCost.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(262, 79)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(57, 17)
        Me.LabelControl1.TabIndex = 386
        Me.LabelControl1.Text = "Unit Price"
        '
        'txtremarks
        '
        Me.txtremarks.EditValue = ""
        Me.txtremarks.Location = New System.Drawing.Point(128, 130)
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Properties.Appearance.Options.UseFont = True
        Me.txtremarks.Properties.NullText = "Remarks (Optional)"
        Me.txtremarks.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtremarks.Properties.ShowNullValuePromptWhenFocused = True
        Me.txtremarks.Size = New System.Drawing.Size(380, 51)
        Me.txtremarks.TabIndex = 4
        '
        'productid
        '
        Me.productid.Location = New System.Drawing.Point(97, 347)
        Me.productid.Name = "productid"
        Me.productid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.productid.Properties.Appearance.Options.UseFont = True
        Me.productid.Properties.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(62, 24)
        Me.productid.TabIndex = 562
        Me.productid.Visible = False
        '
        'cmdaction
        '
        Me.cmdaction.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdaction.Appearance.Options.UseFont = True
        Me.cmdaction.Location = New System.Drawing.Point(326, 185)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(182, 30)
        Me.cmdaction.TabIndex = 558
        Me.cmdaction.Text = "Confirm Update Product"
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(428, 50)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtunit.Properties.Appearance.Options.UseFont = True
        Me.txtunit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtunit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtunit.Properties.ReadOnly = True
        Me.txtunit.Size = New System.Drawing.Size(80, 24)
        Me.txtunit.TabIndex = 100
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(42, 21)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtProductName.Properties.Appearance.Options.UseFont = True
        Me.txtProductName.Properties.Appearance.Options.UseTextOptions = True
        Me.txtProductName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtProductName.Properties.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(466, 26)
        Me.txtProductName.TabIndex = 563
        '
        'trnid
        '
        Me.trnid.Location = New System.Drawing.Point(165, 347)
        Me.trnid.Name = "trnid"
        Me.trnid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.trnid.Properties.Appearance.Options.UseFont = True
        Me.trnid.Properties.ReadOnly = True
        Me.trnid.Size = New System.Drawing.Size(62, 24)
        Me.trnid.TabIndex = 564
        Me.trnid.Visible = False
        '
        'ponumber
        '
        Me.ponumber.Location = New System.Drawing.Point(233, 347)
        Me.ponumber.Name = "ponumber"
        Me.ponumber.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.ponumber.Properties.Appearance.Options.UseFont = True
        Me.ponumber.Properties.ReadOnly = True
        Me.ponumber.Size = New System.Drawing.Size(62, 24)
        Me.ponumber.TabIndex = 565
        Me.ponumber.Visible = False
        '
        'frmDirectPOEditProduct
        '
        Me.AcceptButton = Me.cmdaction
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 242)
        Me.Controls.Add(Me.ponumber)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.cmdaction)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.txtremarks)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtUnitCost)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtTotalCost)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDirectPOEditProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Product Confirmation"
        Me.TopMost = True
        CType(Me.txtQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnitCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtremarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ponumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQuantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUnitCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtremarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtunit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents productid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProductName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents trnid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ponumber As DevExpress.XtraEditors.TextEdit
End Class
