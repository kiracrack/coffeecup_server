<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductCategoryAccountTitleTagging
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
        Me.cmdConfirm = New DevExpress.XtraEditors.SimpleButton()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.assetscode = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.costcode = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtAssets = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridAssets = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.revenuecode = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCost = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridCost = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRevenue = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridRevenue = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ADassetscode = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtADAssets = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridADAssets = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.assetscode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.costcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAssets.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridAssets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.revenuecode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRevenue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridRevenue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADassetscode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtADAssets.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridADAssets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.cmdConfirm.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdConfirm.Appearance.Options.UseFont = True
        Me.cmdConfirm.Location = New System.Drawing.Point(147, 113)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(141, 30)
        Me.cmdConfirm.TabIndex = 3
        Me.cmdConfirm.Text = "&Confirm"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 155)
        Me.BarDockControl1.Manager = Nothing
        Me.BarDockControl1.Size = New System.Drawing.Size(437, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 155)
        Me.BarDockControl2.Manager = Nothing
        Me.BarDockControl2.Size = New System.Drawing.Size(437, 0)
        '
        'assetscode
        '
        Me.assetscode.EditValue = ""
        Me.assetscode.Location = New System.Drawing.Point(35, 288)
        Me.assetscode.Name = "assetscode"
        Me.assetscode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.assetscode.Properties.Appearance.Options.UseFont = True
        Me.assetscode.Properties.Appearance.Options.UseTextOptions = True
        Me.assetscode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.assetscode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.assetscode.Properties.Mask.BeepOnError = True
        Me.assetscode.Properties.ReadOnly = True
        Me.assetscode.Size = New System.Drawing.Size(67, 22)
        Me.assetscode.TabIndex = 729
        Me.assetscode.Visible = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(58, 66)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(81, 15)
        Me.LabelControl4.TabIndex = 735
        Me.LabelControl4.Text = "Assets Account"
        '
        'costcode
        '
        Me.costcode.EditValue = ""
        Me.costcode.Location = New System.Drawing.Point(35, 263)
        Me.costcode.Name = "costcode"
        Me.costcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costcode.Properties.Appearance.Options.UseFont = True
        Me.costcode.Properties.Appearance.Options.UseTextOptions = True
        Me.costcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.costcode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.costcode.Properties.Mask.BeepOnError = True
        Me.costcode.Properties.ReadOnly = True
        Me.costcode.Size = New System.Drawing.Size(67, 22)
        Me.costcode.TabIndex = 728
        Me.costcode.Visible = False
        '
        'txtAssets
        '
        Me.txtAssets.EditValue = ""
        Me.txtAssets.Location = New System.Drawing.Point(147, 62)
        Me.txtAssets.Name = "txtAssets"
        Me.txtAssets.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAssets.Properties.Appearance.Options.UseFont = True
        Me.txtAssets.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAssets.Properties.DisplayMember = "itemname"
        Me.txtAssets.Properties.NullText = ""
        Me.txtAssets.Properties.PopupView = Me.gridAssets
        Me.txtAssets.Properties.ValueMember = "itemcode"
        Me.txtAssets.Size = New System.Drawing.Size(234, 22)
        Me.txtAssets.TabIndex = 2
        '
        'gridAssets
        '
        Me.gridAssets.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridAssets.Name = "gridAssets"
        Me.gridAssets.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridAssets.OptionsView.ShowGroupPanel = False
        '
        'revenuecode
        '
        Me.revenuecode.EditValue = ""
        Me.revenuecode.Location = New System.Drawing.Point(35, 240)
        Me.revenuecode.Name = "revenuecode"
        Me.revenuecode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.revenuecode.Properties.Appearance.Options.UseFont = True
        Me.revenuecode.Properties.Appearance.Options.UseTextOptions = True
        Me.revenuecode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.revenuecode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.revenuecode.Properties.Mask.BeepOnError = True
        Me.revenuecode.Properties.ReadOnly = True
        Me.revenuecode.Size = New System.Drawing.Size(67, 22)
        Me.revenuecode.TabIndex = 727
        Me.revenuecode.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(16, 42)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(123, 15)
        Me.LabelControl2.TabIndex = 733
        Me.LabelControl2.Text = "Cost of Goods Account"
        '
        'txtCost
        '
        Me.txtCost.EditValue = ""
        Me.txtCost.Location = New System.Drawing.Point(147, 37)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCost.Properties.Appearance.Options.UseFont = True
        Me.txtCost.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCost.Properties.DisplayMember = "itemname"
        Me.txtCost.Properties.NullText = ""
        Me.txtCost.Properties.PopupView = Me.gridCost
        Me.txtCost.Properties.ValueMember = "itemcode"
        Me.txtCost.Size = New System.Drawing.Size(234, 22)
        Me.txtCost.TabIndex = 1
        '
        'gridCost
        '
        Me.gridCost.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridCost.Name = "gridCost"
        Me.gridCost.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridCost.OptionsView.ShowGroupPanel = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(46, 16)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(93, 15)
        Me.LabelControl5.TabIndex = 731
        Me.LabelControl5.Text = "Revenue Account"
        '
        'txtRevenue
        '
        Me.txtRevenue.EditValue = ""
        Me.txtRevenue.Location = New System.Drawing.Point(147, 12)
        Me.txtRevenue.Name = "txtRevenue"
        Me.txtRevenue.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRevenue.Properties.Appearance.Options.UseFont = True
        Me.txtRevenue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtRevenue.Properties.DisplayMember = "itemname"
        Me.txtRevenue.Properties.NullText = ""
        Me.txtRevenue.Properties.PopupView = Me.gridRevenue
        Me.txtRevenue.Properties.ValueMember = "itemcode"
        Me.txtRevenue.Size = New System.Drawing.Size(234, 22)
        Me.txtRevenue.TabIndex = 0
        '
        'gridRevenue
        '
        Me.gridRevenue.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridRevenue.Name = "gridRevenue"
        Me.gridRevenue.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridRevenue.OptionsView.ShowGroupPanel = False
        '
        'ADassetscode
        '
        Me.ADassetscode.EditValue = ""
        Me.ADassetscode.Location = New System.Drawing.Point(35, 312)
        Me.ADassetscode.Name = "ADassetscode"
        Me.ADassetscode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADassetscode.Properties.Appearance.Options.UseFont = True
        Me.ADassetscode.Properties.Appearance.Options.UseTextOptions = True
        Me.ADassetscode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ADassetscode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ADassetscode.Properties.Mask.BeepOnError = True
        Me.ADassetscode.Properties.ReadOnly = True
        Me.ADassetscode.Size = New System.Drawing.Size(67, 22)
        Me.ADassetscode.TabIndex = 740
        Me.ADassetscode.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(39, 90)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(100, 15)
        Me.LabelControl3.TabIndex = 739
        Me.LabelControl3.Text = "AD Assets Account"
        '
        'txtADAssets
        '
        Me.txtADAssets.EditValue = ""
        Me.txtADAssets.Location = New System.Drawing.Point(147, 87)
        Me.txtADAssets.Name = "txtADAssets"
        Me.txtADAssets.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtADAssets.Properties.Appearance.Options.UseFont = True
        Me.txtADAssets.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtADAssets.Properties.DisplayMember = "itemname"
        Me.txtADAssets.Properties.NullText = ""
        Me.txtADAssets.Properties.PopupView = Me.gridADAssets
        Me.txtADAssets.Properties.ValueMember = "itemcode"
        Me.txtADAssets.Size = New System.Drawing.Size(234, 22)
        Me.txtADAssets.TabIndex = 738
        '
        'gridADAssets
        '
        Me.gridADAssets.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridADAssets.Name = "gridADAssets"
        Me.gridADAssets.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridADAssets.OptionsView.ShowGroupPanel = False
        '
        'frmProductCategoryAccountTitleTagging
        '
        Me.AcceptButton = Me.cmdConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 155)
        Me.Controls.Add(Me.ADassetscode)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtADAssets)
        Me.Controls.Add(Me.assetscode)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.costcode)
        Me.Controls.Add(Me.txtAssets)
        Me.Controls.Add(Me.revenuecode)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtRevenue)
        Me.Controls.Add(Me.cmdConfirm)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.BarDockControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmProductCategoryAccountTitleTagging"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Account Title"
        Me.TopMost = True
        CType(Me.assetscode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.costcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAssets.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridAssets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.revenuecode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRevenue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridRevenue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADassetscode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtADAssets.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridADAssets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents assetscode As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents costcode As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtAssets As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridAssets As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents revenuecode As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCost As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridCost As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRevenue As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridRevenue As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ADassetscode As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtADAssets As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridADAssets As DevExpress.XtraGrid.Views.Grid.GridView
End Class
