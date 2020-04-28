<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancel_invoices
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
        Me.cmdOk = New DevExpress.XtraEditors.SimpleButton()
        Me.cifid = New DevExpress.XtraEditors.TextEdit()
        Me.txtBatchcode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCurrentClient = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.batchcode = New DevExpress.XtraEditors.TextEdit()
        Me.txtCashier = New DevExpress.XtraEditors.TextEdit()
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDate = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtInvoiceNo = New DevExpress.XtraEditors.TextEdit()
        CType(Me.cifid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBatchcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrentClient.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.batchcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCashier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvoiceNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdOk.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdOk.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.cmdOk.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdOk.Appearance.Options.UseBackColor = True
        Me.cmdOk.Appearance.Options.UseFont = True
        Me.cmdOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdOk.Location = New System.Drawing.Point(169, 267)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(155, 30)
        Me.cmdOk.TabIndex = 3
        Me.cmdOk.Text = "Confirm Cancel"
        '
        'cifid
        '
        Me.cifid.Location = New System.Drawing.Point(459, 84)
        Me.cifid.Name = "cifid"
        Me.cifid.Properties.Appearance.Options.UseTextOptions = True
        Me.cifid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cifid.Properties.ReadOnly = True
        Me.cifid.Size = New System.Drawing.Size(53, 20)
        Me.cifid.TabIndex = 581
        Me.cifid.Visible = False
        '
        'txtBatchcode
        '
        Me.txtBatchcode.EnterMoveNextControl = True
        Me.txtBatchcode.Location = New System.Drawing.Point(169, 43)
        Me.txtBatchcode.Name = "txtBatchcode"
        Me.txtBatchcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtBatchcode.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtBatchcode.Properties.Appearance.Options.UseFont = True
        Me.txtBatchcode.Properties.Appearance.Options.UseForeColor = True
        Me.txtBatchcode.Properties.Appearance.Options.UseTextOptions = True
        Me.txtBatchcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtBatchcode.Size = New System.Drawing.Size(163, 26)
        Me.txtBatchcode.TabIndex = 0
        '
        'LabelControl26
        '
        Me.LabelControl26.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl26.Appearance.Options.UseFont = True
        Me.LabelControl26.Location = New System.Drawing.Point(55, 46)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(99, 19)
        Me.LabelControl26.TabIndex = 588
        Me.LabelControl26.Text = "Enter Batchcode"
        '
        'txtCurrentClient
        '
        Me.txtCurrentClient.EnterMoveNextControl = True
        Me.txtCurrentClient.Location = New System.Drawing.Point(169, 159)
        Me.txtCurrentClient.Name = "txtCurrentClient"
        Me.txtCurrentClient.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtCurrentClient.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtCurrentClient.Properties.Appearance.Options.UseFont = True
        Me.txtCurrentClient.Properties.Appearance.Options.UseForeColor = True
        Me.txtCurrentClient.Properties.ReadOnly = True
        Me.txtCurrentClient.Size = New System.Drawing.Size(270, 26)
        Me.txtCurrentClient.TabIndex = 589
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(68, 162)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(86, 19)
        Me.LabelControl1.TabIndex = 590
        Me.LabelControl1.Text = "Current Client"
        '
        'batchcode
        '
        Me.batchcode.EnterMoveNextControl = True
        Me.batchcode.Location = New System.Drawing.Point(459, 7)
        Me.batchcode.Name = "batchcode"
        Me.batchcode.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.batchcode.Properties.Appearance.Options.UseForeColor = True
        Me.batchcode.Properties.Appearance.Options.UseTextOptions = True
        Me.batchcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.batchcode.Size = New System.Drawing.Size(43, 20)
        Me.batchcode.TabIndex = 591
        Me.batchcode.Visible = False
        '
        'txtCashier
        '
        Me.txtCashier.Location = New System.Drawing.Point(459, 58)
        Me.txtCashier.Name = "txtCashier"
        Me.txtCashier.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCashier.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCashier.Properties.ReadOnly = True
        Me.txtCashier.Size = New System.Drawing.Size(53, 20)
        Me.txtCashier.TabIndex = 594
        Me.txtCashier.Visible = False
        '
        'txtAmount
        '
        Me.txtAmount.EnterMoveNextControl = True
        Me.txtAmount.Location = New System.Drawing.Point(169, 130)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtAmount.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtAmount.Properties.Appearance.Options.UseFont = True
        Me.txtAmount.Properties.Appearance.Options.UseForeColor = True
        Me.txtAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmount.Properties.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(163, 26)
        Me.txtAmount.TabIndex = 595
        '
        'txtRemarks
        '
        Me.txtRemarks.EditValue = ""
        Me.txtRemarks.Location = New System.Drawing.Point(169, 189)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtRemarks.Properties.Appearance.Options.UseFont = True
        Me.txtRemarks.Size = New System.Drawing.Size(270, 72)
        Me.txtRemarks.TabIndex = 596
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(102, 191)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(52, 19)
        Me.LabelControl4.TabIndex = 597
        Me.LabelControl4.Text = "Remarks"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(104, 133)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(50, 19)
        Me.LabelControl2.TabIndex = 598
        Me.LabelControl2.Text = "Amount"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(178, 18)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(86, 19)
        Me.LabelControl3.TabIndex = 588
        Me.LabelControl3.Text = "10XXXXX-XXX"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(125, 75)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(29, 19)
        Me.LabelControl5.TabIndex = 600
        Me.LabelControl5.Text = "Date"
        '
        'txtDate
        '
        Me.txtDate.EnterMoveNextControl = True
        Me.txtDate.Location = New System.Drawing.Point(169, 72)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtDate.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtDate.Properties.Appearance.Options.UseFont = True
        Me.txtDate.Properties.Appearance.Options.UseForeColor = True
        Me.txtDate.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDate.Properties.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(163, 26)
        Me.txtDate.TabIndex = 599
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(89, 104)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(65, 19)
        Me.LabelControl6.TabIndex = 602
        Me.LabelControl6.Text = "Invoice No"
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.EnterMoveNextControl = True
        Me.txtInvoiceNo.Location = New System.Drawing.Point(169, 101)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtInvoiceNo.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtInvoiceNo.Properties.Appearance.Options.UseFont = True
        Me.txtInvoiceNo.Properties.Appearance.Options.UseForeColor = True
        Me.txtInvoiceNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtInvoiceNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtInvoiceNo.Properties.ReadOnly = True
        Me.txtInvoiceNo.Size = New System.Drawing.Size(163, 26)
        Me.txtInvoiceNo.TabIndex = 601
        '
        'frmCancel_invoices
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 325)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtCashier)
        Me.Controls.Add(Me.batchcode)
        Me.Controls.Add(Me.txtCurrentClient)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtBatchcode)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl26)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cifid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCancel_invoices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancel Invoice"
        CType(Me.cifid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBatchcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrentClient.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.batchcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCashier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvoiceNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cifid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBatchcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCurrentClient As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents batchcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCashier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInvoiceNo As DevExpress.XtraEditors.TextEdit
End Class
