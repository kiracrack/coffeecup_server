<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoucherOtherExpense
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
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.voucherno = New DevExpress.XtraEditors.TextEdit()
        Me.itemcode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTransactionName = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.Gridview_TransactionName = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtCheckAmount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.trnid = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.companyid = New DevExpress.XtraEditors.TextEdit()
        Me.lblReference = New DevExpress.XtraEditors.LabelControl()
        Me.txtInvoiceno = New DevExpress.XtraEditors.TextEdit()
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransactionName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview_TransactionName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.companyid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvoiceno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.BackColor = System.Drawing.Color.Green
        Me.cmdSave.Appearance.BackColor2 = System.Drawing.Color.Green
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.ForeColor = System.Drawing.Color.White
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseBackColor = True
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Appearance.Options.UseForeColor = True
        Me.cmdSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSave.Location = New System.Drawing.Point(322, 169)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(154, 30)
        Me.cmdSave.TabIndex = 4
        Me.cmdSave.Text = "Confirm Save"
        '
        'voucherno
        '
        Me.voucherno.Location = New System.Drawing.Point(75, 232)
        Me.voucherno.Name = "voucherno"
        Me.voucherno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.voucherno.Properties.Appearance.Options.UseFont = True
        Me.voucherno.Properties.ReadOnly = True
        Me.voucherno.Size = New System.Drawing.Size(55, 20)
        Me.voucherno.TabIndex = 590
        Me.voucherno.Visible = False
        '
        'itemcode
        '
        Me.itemcode.EnterMoveNextControl = True
        Me.itemcode.Location = New System.Drawing.Point(136, 232)
        Me.itemcode.Name = "itemcode"
        Me.itemcode.Properties.Appearance.Options.UseFont = True
        Me.itemcode.Size = New System.Drawing.Size(50, 20)
        Me.itemcode.TabIndex = 746
        Me.itemcode.Visible = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(44, 22)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(106, 17)
        Me.LabelControl9.TabIndex = 745
        Me.LabelControl9.Text = "Transaction Name"
        '
        'txtTransactionName
        '
        Me.txtTransactionName.EditValue = "Select Group"
        Me.txtTransactionName.Location = New System.Drawing.Point(157, 18)
        Me.txtTransactionName.Name = "txtTransactionName"
        Me.txtTransactionName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.txtTransactionName.Properties.Appearance.Options.UseFont = True
        Me.txtTransactionName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTransactionName.Properties.DisplayMember = "itemname"
        Me.txtTransactionName.Properties.NullText = ""
        Me.txtTransactionName.Properties.PopupView = Me.Gridview_TransactionName
        Me.txtTransactionName.Properties.ValueMember = "itemcode"
        Me.txtTransactionName.Size = New System.Drawing.Size(232, 26)
        Me.txtTransactionName.TabIndex = 0
        '
        'Gridview_TransactionName
        '
        Me.Gridview_TransactionName.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.Gridview_TransactionName.Name = "Gridview_TransactionName"
        Me.Gridview_TransactionName.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.Gridview_TransactionName.OptionsView.ShowGroupPanel = False
        '
        'txtCheckAmount
        '
        Me.txtCheckAmount.EditValue = "0.00"
        Me.txtCheckAmount.Location = New System.Drawing.Point(157, 74)
        Me.txtCheckAmount.Name = "txtCheckAmount"
        Me.txtCheckAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtCheckAmount.Properties.Appearance.Options.UseFont = True
        Me.txtCheckAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCheckAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCheckAmount.Properties.Mask.EditMask = "n"
        Me.txtCheckAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCheckAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCheckAmount.Size = New System.Drawing.Size(154, 26)
        Me.txtCheckAmount.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(106, 77)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 15)
        Me.LabelControl4.TabIndex = 743
        Me.LabelControl4.Text = "Amount"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(48, 104)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(102, 17)
        Me.LabelControl3.TabIndex = 748
        Me.LabelControl3.Text = "Expense Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(157, 103)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.txtRemarks.Properties.Appearance.Options.UseFont = True
        Me.txtRemarks.Size = New System.Drawing.Size(319, 60)
        Me.txtRemarks.TabIndex = 3
        '
        'trnid
        '
        Me.trnid.Location = New System.Drawing.Point(192, 232)
        Me.trnid.Name = "trnid"
        Me.trnid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trnid.Properties.Appearance.Options.UseFont = True
        Me.trnid.Properties.ReadOnly = True
        Me.trnid.Size = New System.Drawing.Size(55, 20)
        Me.trnid.TabIndex = 749
        Me.trnid.Visible = False
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(253, 232)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(55, 20)
        Me.mode.TabIndex = 750
        Me.mode.Visible = False
        '
        'companyid
        '
        Me.companyid.Location = New System.Drawing.Point(314, 232)
        Me.companyid.Name = "companyid"
        Me.companyid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.companyid.Properties.Appearance.Options.UseFont = True
        Me.companyid.Properties.ReadOnly = True
        Me.companyid.Size = New System.Drawing.Size(55, 20)
        Me.companyid.TabIndex = 751
        Me.companyid.Visible = False
        '
        'lblReference
        '
        Me.lblReference.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblReference.Appearance.Options.UseFont = True
        Me.lblReference.Appearance.Options.UseTextOptions = True
        Me.lblReference.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblReference.Location = New System.Drawing.Point(85, 50)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(65, 17)
        Me.lblReference.TabIndex = 753
        Me.lblReference.Text = "Invoice No."
        '
        'txtInvoiceno
        '
        Me.txtInvoiceno.EnterMoveNextControl = True
        Me.txtInvoiceno.Location = New System.Drawing.Point(157, 47)
        Me.txtInvoiceno.Name = "txtInvoiceno"
        Me.txtInvoiceno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInvoiceno.Properties.Appearance.Options.UseFont = True
        Me.txtInvoiceno.Properties.Appearance.Options.UseTextOptions = True
        Me.txtInvoiceno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtInvoiceno.Size = New System.Drawing.Size(154, 24)
        Me.txtInvoiceno.TabIndex = 1
        '
        'frmVoucherOtherExpense
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 215)
        Me.Controls.Add(Me.lblReference)
        Me.Controls.Add(Me.txtInvoiceno)
        Me.Controls.Add(Me.companyid)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.itemcode)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtTransactionName)
        Me.Controls.Add(Me.txtCheckAmount)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.voucherno)
        Me.Controls.Add(Me.cmdSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVoucherOtherExpense"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Other Expense Item"
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransactionName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview_TransactionName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.companyid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvoiceno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents voucherno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents itemcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTransactionName As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents Gridview_TransactionName As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtCheckAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents trnid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents companyid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblReference As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtInvoiceno As DevExpress.XtraEditors.TextEdit
End Class
