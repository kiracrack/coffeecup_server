﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilUpdateProductPrice
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
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSellingPrice = New DevExpress.XtraEditors.TextEdit()
        Me.trnid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtSellingPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdUpdate.Appearance.Options.UseFont = True
        Me.cmdUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdUpdate.Location = New System.Drawing.Point(147, 56)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(171, 32)
        Me.cmdUpdate.TabIndex = 2
        Me.cmdUpdate.Text = "Confirm Update"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(88, 32)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 15)
        Me.LabelControl2.TabIndex = 625
        Me.LabelControl2.Text = "New Price"
        '
        'txtSellingPrice
        '
        Me.txtSellingPrice.EditValue = "0"
        Me.txtSellingPrice.EnterMoveNextControl = True
        Me.txtSellingPrice.Location = New System.Drawing.Point(147, 25)
        Me.txtSellingPrice.Name = "txtSellingPrice"
        Me.txtSellingPrice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtSellingPrice.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSellingPrice.Properties.Appearance.Options.UseFont = True
        Me.txtSellingPrice.Properties.Appearance.Options.UseForeColor = True
        Me.txtSellingPrice.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSellingPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSellingPrice.Properties.Mask.EditMask = "n"
        Me.txtSellingPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSellingPrice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSellingPrice.Size = New System.Drawing.Size(171, 26)
        Me.txtSellingPrice.TabIndex = 0
        '
        'trnid
        '
        Me.trnid.EditValue = ""
        Me.trnid.EnterMoveNextControl = True
        Me.trnid.Location = New System.Drawing.Point(93, 315)
        Me.trnid.Name = "trnid"
        Me.trnid.Properties.ReadOnly = True
        Me.trnid.Properties.ValidateOnEnterKey = True
        Me.trnid.Size = New System.Drawing.Size(77, 20)
        Me.trnid.TabIndex = 627
        Me.trnid.Visible = False
        '
        'frmUtilUpdateProductPrice
        '
        Me.AcceptButton = Me.cmdUpdate
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 114)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.txtSellingPrice)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cmdUpdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUtilUpdateProductPrice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Product Price Batching"
        CType(Me.txtSellingPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSellingPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents trnid As DevExpress.XtraEditors.TextEdit
End Class
