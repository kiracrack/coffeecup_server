﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGLJournalDetails
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
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.cmdOk = New DevExpress.XtraEditors.SimpleButton()
        Me.ItemCode = New DevExpress.XtraEditors.TextEdit()
        Me.lblDebit = New DevExpress.XtraEditors.LabelControl()
        Me.txtDebit = New DevExpress.XtraEditors.TextEdit()
        Me.txtNote = New DevExpress.XtraEditors.MemoEdit()
        Me.txtTicketNo = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.lblCredit = New DevExpress.XtraEditors.LabelControl()
        Me.txtCredit = New DevExpress.XtraEditors.TextEdit()
        Me.companyid = New DevExpress.XtraEditors.TextEdit()
        Me.gridItem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtItem = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.ckDebit = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.ItemCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTicketNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.companyid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckDebit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'cmdOk
        '
        Me.cmdOk.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdOk.Appearance.Options.UseFont = True
        Me.cmdOk.Location = New System.Drawing.Point(228, 185)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(173, 30)
        Me.cmdOk.TabIndex = 4
        Me.cmdOk.Text = "Add to Journal"
        '
        'ItemCode
        '
        Me.ItemCode.EnterMoveNextControl = True
        Me.ItemCode.Location = New System.Drawing.Point(479, 467)
        Me.ItemCode.Name = "ItemCode"
        Me.ItemCode.Properties.Appearance.Options.UseFont = True
        Me.ItemCode.Size = New System.Drawing.Size(82, 20)
        Me.ItemCode.TabIndex = 719
        Me.ItemCode.Visible = False
        '
        'lblDebit
        '
        Me.lblDebit.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblDebit.Appearance.Options.UseFont = True
        Me.lblDebit.Appearance.Options.UseTextOptions = True
        Me.lblDebit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblDebit.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblDebit.Location = New System.Drawing.Point(58, 131)
        Me.lblDebit.Name = "lblDebit"
        Me.lblDebit.Size = New System.Drawing.Size(163, 15)
        Me.lblDebit.TabIndex = 723
        Me.lblDebit.Text = "Debit"
        '
        'txtDebit
        '
        Me.txtDebit.EditValue = ""
        Me.txtDebit.Location = New System.Drawing.Point(228, 126)
        Me.txtDebit.Name = "txtDebit"
        Me.txtDebit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtDebit.Properties.Appearance.Options.UseFont = True
        Me.txtDebit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDebit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDebit.Properties.Mask.EditMask = "n"
        Me.txtDebit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDebit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDebit.Size = New System.Drawing.Size(173, 26)
        Me.txtDebit.TabIndex = 2
        '
        'txtNote
        '
        Me.txtNote.EditValue = ""
        Me.txtNote.Location = New System.Drawing.Point(58, 71)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Properties.Appearance.Options.UseFont = True
        Me.txtNote.Properties.NullValuePrompt = "Specific item remarks.."
        Me.txtNote.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtNote.Size = New System.Drawing.Size(343, 49)
        Me.txtNote.TabIndex = 1
        '
        'txtTicketNo
        '
        Me.txtTicketNo.EnterMoveNextControl = True
        Me.txtTicketNo.Location = New System.Drawing.Point(207, 467)
        Me.txtTicketNo.Name = "txtTicketNo"
        Me.txtTicketNo.Properties.Appearance.Options.UseFont = True
        Me.txtTicketNo.Size = New System.Drawing.Size(82, 20)
        Me.txtTicketNo.TabIndex = 724
        Me.txtTicketNo.Visible = False
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(391, 467)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Size = New System.Drawing.Size(82, 20)
        Me.mode.TabIndex = 725
        Me.mode.Visible = False
        '
        'id
        '
        Me.id.EnterMoveNextControl = True
        Me.id.Location = New System.Drawing.Point(302, 467)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Options.UseFont = True
        Me.id.Size = New System.Drawing.Size(82, 20)
        Me.id.TabIndex = 726
        Me.id.Visible = False
        '
        'lblCredit
        '
        Me.lblCredit.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCredit.Appearance.Options.UseFont = True
        Me.lblCredit.Appearance.Options.UseTextOptions = True
        Me.lblCredit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblCredit.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCredit.Location = New System.Drawing.Point(58, 161)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(163, 15)
        Me.lblCredit.TabIndex = 729
        Me.lblCredit.Text = "Credit"
        '
        'txtCredit
        '
        Me.txtCredit.EditValue = ""
        Me.txtCredit.Location = New System.Drawing.Point(228, 155)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtCredit.Properties.Appearance.Options.UseFont = True
        Me.txtCredit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCredit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCredit.Properties.Mask.EditMask = "n"
        Me.txtCredit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCredit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCredit.Size = New System.Drawing.Size(173, 26)
        Me.txtCredit.TabIndex = 3
        '
        'companyid
        '
        Me.companyid.EnterMoveNextControl = True
        Me.companyid.Location = New System.Drawing.Point(567, 467)
        Me.companyid.Name = "companyid"
        Me.companyid.Properties.Appearance.Options.UseFont = True
        Me.companyid.Size = New System.Drawing.Size(82, 20)
        Me.companyid.TabIndex = 730
        Me.companyid.Visible = False
        '
        'gridItem
        '
        Me.gridItem.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridItem.Name = "gridItem"
        Me.gridItem.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridItem.OptionsView.ShowGroupPanel = False
        '
        'txtItem
        '
        Me.txtItem.EditValue = ""
        Me.txtItem.Location = New System.Drawing.Point(58, 41)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtItem.Properties.Appearance.Options.UseFont = True
        Me.txtItem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtItem.Properties.DisplayMember = "itemname"
        Me.txtItem.Properties.NullText = ""
        Me.txtItem.Properties.PopupView = Me.gridItem
        Me.txtItem.Properties.ValueMember = "itemcode"
        Me.txtItem.Size = New System.Drawing.Size(343, 26)
        Me.txtItem.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(58, 22)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(223, 15)
        Me.LabelControl3.TabIndex = 718
        Me.LabelControl3.Text = "Select account title for specific transaction"
        '
        'ckDebit
        '
        Me.ckDebit.Location = New System.Drawing.Point(446, 20)
        Me.ckDebit.Name = "ckDebit"
        Me.ckDebit.Properties.Caption = "debit"
        Me.ckDebit.Size = New System.Drawing.Size(63, 20)
        Me.ckDebit.TabIndex = 731
        Me.ckDebit.Visible = False
        '
        'frmGLJournalDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 235)
        Me.Controls.Add(Me.ckDebit)
        Me.Controls.Add(Me.companyid)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.txtCredit)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtTicketNo)
        Me.Controls.Add(Me.lblDebit)
        Me.Controls.Add(Me.txtDebit)
        Me.Controls.Add(Me.ItemCode)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.txtNote)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmGLJournalDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Journal Entry Item"
        CType(Me.ItemCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTicketNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.companyid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckDebit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ItemCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDebit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDebit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtTicketNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCredit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCredit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents companyid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gridItem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtItem As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckDebit As DevExpress.XtraEditors.CheckEdit
End Class
