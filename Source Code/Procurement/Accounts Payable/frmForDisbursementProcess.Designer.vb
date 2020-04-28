<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForDisbursementProcess
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
        Me.cmdMove = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSupplier = New DevExpress.XtraEditors.TextEdit()
        Me.lbldisbursingoffice = New DevExpress.XtraEditors.LabelControl()
        Me.txtBranch = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.ponumber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.voucherno = New DevExpress.XtraEditors.TextEdit()
        Me.pid = New DevExpress.XtraEditors.TextEdit()
        Me.txtInvoice = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBranch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ponumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvoice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdMove
        '
        Me.cmdMove.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMove.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdMove.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdMove.Appearance.Options.UseFont = True
        Me.cmdMove.Appearance.Options.UseForeColor = True
        Me.cmdMove.Location = New System.Drawing.Point(191, 163)
        Me.cmdMove.Name = "cmdMove"
        Me.cmdMove.Size = New System.Drawing.Size(141, 30)
        Me.cmdMove.TabIndex = 2
        Me.cmdMove.Text = "Proceed"
        '
        'txtSupplier
        '
        Me.txtSupplier.EditValue = ""
        Me.txtSupplier.Location = New System.Drawing.Point(191, 75)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtSupplier.Properties.Appearance.Options.UseFont = True
        Me.txtSupplier.Properties.ReadOnly = True
        Me.txtSupplier.Properties.ValidateOnEnterKey = True
        Me.txtSupplier.Size = New System.Drawing.Size(236, 26)
        Me.txtSupplier.TabIndex = 638
        '
        'lbldisbursingoffice
        '
        Me.lbldisbursingoffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldisbursingoffice.Appearance.Options.UseFont = True
        Me.lbldisbursingoffice.Appearance.Options.UseTextOptions = True
        Me.lbldisbursingoffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbldisbursingoffice.Location = New System.Drawing.Point(116, 136)
        Me.lbldisbursingoffice.Name = "lbldisbursingoffice"
        Me.lbldisbursingoffice.Size = New System.Drawing.Size(65, 17)
        Me.lbldisbursingoffice.TabIndex = 728
        Me.lbldisbursingoffice.Text = "Invoice No."
        '
        'txtBranch
        '
        Me.txtBranch.EditValue = ""
        Me.txtBranch.Location = New System.Drawing.Point(191, 46)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtBranch.Properties.Appearance.Options.UseFont = True
        Me.txtBranch.Properties.ReadOnly = True
        Me.txtBranch.Properties.ValidateOnEnterKey = True
        Me.txtBranch.Size = New System.Drawing.Size(236, 26)
        Me.txtBranch.TabIndex = 636
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(142, 49)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(39, 17)
        Me.LabelControl6.TabIndex = 637
        Me.LabelControl6.Text = "Branch"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(133, 78)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(48, 17)
        Me.LabelControl1.TabIndex = 729
        Me.LabelControl1.Text = "Supplier"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(103, 107)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(78, 17)
        Me.LabelControl2.TabIndex = 731
        Me.LabelControl2.Text = "Total Amount"
        '
        'txtAmount
        '
        Me.txtAmount.EditValue = ""
        Me.txtAmount.Location = New System.Drawing.Point(191, 104)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtAmount.Properties.Appearance.Options.UseFont = True
        Me.txtAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmount.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(45)
        Me.txtAmount.Properties.ReadOnly = True
        Me.txtAmount.Properties.ValidateOnEnterKey = True
        Me.txtAmount.Size = New System.Drawing.Size(141, 26)
        Me.txtAmount.TabIndex = 730
        '
        'ponumber
        '
        Me.ponumber.EditValue = ""
        Me.ponumber.Location = New System.Drawing.Point(507, 149)
        Me.ponumber.Name = "ponumber"
        Me.ponumber.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.ponumber.Properties.Appearance.Options.UseFont = True
        Me.ponumber.Properties.ReadOnly = True
        Me.ponumber.Properties.ValidateOnEnterKey = True
        Me.ponumber.Size = New System.Drawing.Size(55, 26)
        Me.ponumber.TabIndex = 732
        Me.ponumber.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(80, 19)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(101, 17)
        Me.LabelControl3.TabIndex = 733
        Me.LabelControl3.Text = "Payment Number"
        '
        'voucherno
        '
        Me.voucherno.EditValue = ""
        Me.voucherno.Location = New System.Drawing.Point(191, 16)
        Me.voucherno.Name = "voucherno"
        Me.voucherno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.voucherno.Properties.Appearance.Options.UseFont = True
        Me.voucherno.Properties.Appearance.Options.UseTextOptions = True
        Me.voucherno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.voucherno.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(45)
        Me.voucherno.Properties.ReadOnly = True
        Me.voucherno.Properties.ValidateOnEnterKey = True
        Me.voucherno.Size = New System.Drawing.Size(141, 26)
        Me.voucherno.TabIndex = 734
        '
        'pid
        '
        Me.pid.EditValue = ""
        Me.pid.Location = New System.Drawing.Point(507, 123)
        Me.pid.Name = "pid"
        Me.pid.Properties.Appearance.Options.UseTextOptions = True
        Me.pid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.pid.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(45)
        Me.pid.Properties.ReadOnly = True
        Me.pid.Properties.ValidateOnEnterKey = True
        Me.pid.Size = New System.Drawing.Size(38, 20)
        Me.pid.TabIndex = 735
        Me.pid.Visible = False
        '
        'txtInvoice
        '
        Me.txtInvoice.EditValue = ""
        Me.txtInvoice.Location = New System.Drawing.Point(191, 133)
        Me.txtInvoice.Name = "txtInvoice"
        Me.txtInvoice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtInvoice.Properties.Appearance.Options.UseFont = True
        Me.txtInvoice.Properties.Appearance.Options.UseTextOptions = True
        Me.txtInvoice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtInvoice.Properties.ValidateOnEnterKey = True
        Me.txtInvoice.Size = New System.Drawing.Size(141, 26)
        Me.txtInvoice.TabIndex = 0
        '
        'frmForDisbursementProcess
        '
        Me.AcceptButton = Me.cmdMove
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 213)
        Me.Controls.Add(Me.txtInvoice)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.voucherno)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.ponumber)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.lbldisbursingoffice)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtBranch)
        Me.Controls.Add(Me.cmdMove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmForDisbursementProcess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Approving Level"
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBranch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ponumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvoice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdMove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSupplier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbldisbursingoffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBranch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ponumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents voucherno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInvoice As DevExpress.XtraEditors.TextEdit
End Class
