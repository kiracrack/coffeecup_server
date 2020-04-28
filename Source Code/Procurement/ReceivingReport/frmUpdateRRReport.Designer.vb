<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateRRReport
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
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.radPayOption = New DevExpress.XtraEditors.RadioGroup()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.radPayOption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdaction
        '
        Me.cmdaction.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdaction.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdaction.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdaction.Appearance.Options.UseBackColor = True
        Me.cmdaction.Appearance.Options.UseFont = True
        Me.cmdaction.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdaction.Location = New System.Drawing.Point(59, 127)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(226, 33)
        Me.cmdaction.TabIndex = 2
        Me.cmdaction.Text = "Confirm Update"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(56, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(326, 15)
        Me.Label10.TabIndex = 877
        Me.Label10.Text = "Select option to update selected item on the receiving report"
        '
        'radPayOption
        '
        Me.radPayOption.Location = New System.Drawing.Point(59, 36)
        Me.radPayOption.Name = "radPayOption"
        Me.radPayOption.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.radPayOption.Properties.Appearance.Options.UseFont = True
        Me.radPayOption.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Cash Transaction"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Credit Transaction")})
        Me.radPayOption.Size = New System.Drawing.Size(323, 59)
        Me.radPayOption.TabIndex = 876
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(59, 101)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Update Vat Sales Amount"
        Me.CheckEdit1.Size = New System.Drawing.Size(175, 20)
        Me.CheckEdit1.TabIndex = 878
        '
        'frmUpdateRRReport
        '
        Me.AcceptButton = Me.cmdaction
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 183)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.radPayOption)
        Me.Controls.Add(Me.cmdaction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdateRRReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Item"
        Me.TopMost = True
        CType(Me.radPayOption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents radPayOption As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
End Class
