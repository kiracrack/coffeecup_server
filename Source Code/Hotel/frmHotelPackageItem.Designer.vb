﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelPackageItem
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
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.code = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.ItemCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtItem = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridItem = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(153, 65)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(124, 26)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "Save"
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        GridLevelNode1.RelationName = "Level1"
        Me.Em.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Em.Location = New System.Drawing.Point(5, 101)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(489, 353)
        Me.Em.TabIndex = 697
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdDelete, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(165, 76)
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(164, 22)
        Me.cmdEdit.Text = "Edit Selected"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(164, 22)
        Me.cmdDelete.Text = "Remove Selected"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(161, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(87, 17)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(59, 15)
        Me.LabelControl3.TabIndex = 730
        Me.LabelControl3.Text = "Item Name"
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDescription.EditValue = ""
        Me.txtDescription.Location = New System.Drawing.Point(153, 14)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Properties.NullText = "Room Description"
        Me.txtDescription.Size = New System.Drawing.Size(223, 22)
        Me.txtDescription.TabIndex = 0
        '
        'code
        '
        Me.code.EnterMoveNextControl = True
        Me.code.Location = New System.Drawing.Point(439, 225)
        Me.code.Name = "code"
        Me.code.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.code.Properties.Appearance.Options.UseFont = True
        Me.code.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.code.Size = New System.Drawing.Size(48, 22)
        Me.code.TabIndex = 732
        Me.code.Visible = False
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(439, 197)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mode.Size = New System.Drawing.Size(48, 22)
        Me.mode.TabIndex = 731
        Me.mode.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(75, 42)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(71, 15)
        Me.LabelControl2.TabIndex = 737
        Me.LabelControl2.Text = "Account Title"
        '
        'ItemCode
        '
        Me.ItemCode.EnterMoveNextControl = True
        Me.ItemCode.Location = New System.Drawing.Point(391, 8)
        Me.ItemCode.Name = "ItemCode"
        Me.ItemCode.Properties.Appearance.Options.UseFont = True
        Me.ItemCode.Size = New System.Drawing.Size(41, 20)
        Me.ItemCode.TabIndex = 736
        Me.ItemCode.Visible = False
        '
        'txtItem
        '
        Me.txtItem.EditValue = ""
        Me.txtItem.Location = New System.Drawing.Point(153, 39)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtItem.Properties.Appearance.Options.UseFont = True
        Me.txtItem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtItem.Properties.DisplayMember = "itemname"
        Me.txtItem.Properties.NullText = ""
        Me.txtItem.Properties.PopupView = Me.gridItem
        Me.txtItem.Properties.ValueMember = "itemcode"
        Me.txtItem.Size = New System.Drawing.Size(223, 22)
        Me.txtItem.TabIndex = 1
        '
        'gridItem
        '
        Me.gridItem.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridItem.Name = "gridItem"
        Me.gridItem.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridItem.OptionsView.ShowGroupPanel = False
        '
        'frmHotelPackageItem
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(499, 459)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.ItemCode)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.code)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Em)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmHotelPackageItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Package Item"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ItemCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtItem As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridItem As DevExpress.XtraGrid.Views.Grid.GridView
End Class
