﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferedRequestList
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
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRequestInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DisplayFormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.cmdPrintReport = New DevExpress.XtraEditors.SimpleButton()
        Me.Paneldate = New DevExpress.XtraEditors.PanelControl()
        Me.txttodate = New DevExpress.XtraEditors.DateEdit()
        Me.cmdSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.txtfrmdate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.ckasof = New DevExpress.XtraEditors.CheckEdit()
        Me.TabTransferControl = New DevExpress.XtraTab.XtraTabControl()
        Me.tabpending = New DevExpress.XtraTab.XtraTabPage()
        Me.tabConfirmed = New DevExpress.XtraTab.XtraTabPage()
        Me.tabCancelled = New DevExpress.XtraTab.XtraTabPage()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.Paneldate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Paneldate.SuspendLayout()
        CType(Me.txttodate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttodate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfrmdate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfrmdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckasof.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabTransferControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabTransferControl.SuspendLayout()
        Me.tabpending.SuspendLayout()
        Me.SuspendLayout()
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.ContextMenuStrip2
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(574, 469)
        Me.Em.TabIndex = 334
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdCancel, Me.ViewRequestInfoToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.ToolStripSeparator1, Me.DisplayFormatToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(169, 98)
        '
        'cmdCancel
        '
        Me.cmdCancel.Image = Global.Coffeecup.My.Resources.Resources.news_unsubscribe_2
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(168, 22)
        Me.cmdCancel.Text = "Cancel Request"
        '
        'ViewRequestInfoToolStripMenuItem
        '
        Me.ViewRequestInfoToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.book_open_list
        Me.ViewRequestInfoToolStripMenuItem.Name = "ViewRequestInfoToolStripMenuItem"
        Me.ViewRequestInfoToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ViewRequestInfoToolStripMenuItem.Text = "View Request Info"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(165, 6)
        '
        'DisplayFormatToolStripMenuItem
        '
        Me.DisplayFormatToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.edit
        Me.DisplayFormatToolStripMenuItem.Name = "DisplayFormatToolStripMenuItem"
        Me.DisplayFormatToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.DisplayFormatToolStripMenuItem.Text = "View Appearance"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "", Nothing, "", "1")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem2, Me.BarButtonItem1, Me.BarButtonItem3})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Close Window"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Printing Option"
        Me.BarButtonItem1.Id = 2
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Export to Excel"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.Name = "BarButtonItem3"
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
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(814, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 522)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(814, 18)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 498)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(814, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 498)
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("f8ef9b7b-99db-4553-9a93-819c28568f9f")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 24)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(238, 200)
        Me.DockPanel1.SavedSizeFactor = 0.0R
        Me.DockPanel1.Size = New System.Drawing.Size(238, 498)
        Me.DockPanel1.Text = "Report Settings"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.cmdPrintReport)
        Me.DockPanel1_Container.Controls.Add(Me.Paneldate)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 30)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(231, 465)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'cmdPrintReport
        '
        Me.cmdPrintReport.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdPrintReport.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdPrintReport.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintReport.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdPrintReport.Appearance.Options.UseBackColor = True
        Me.cmdPrintReport.Appearance.Options.UseFont = True
        Me.cmdPrintReport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdPrintReport.Location = New System.Drawing.Point(11, 100)
        Me.cmdPrintReport.Name = "cmdPrintReport"
        Me.cmdPrintReport.Size = New System.Drawing.Size(212, 30)
        Me.cmdPrintReport.TabIndex = 556
        Me.cmdPrintReport.Text = "Print Report"
        '
        'Paneldate
        '
        Me.Paneldate.Controls.Add(Me.txttodate)
        Me.Paneldate.Controls.Add(Me.cmdSearch)
        Me.Paneldate.Controls.Add(Me.txtfrmdate)
        Me.Paneldate.Controls.Add(Me.LabelControl1)
        Me.Paneldate.Controls.Add(Me.LabelControl3)
        Me.Paneldate.Controls.Add(Me.ckasof)
        Me.Paneldate.Location = New System.Drawing.Point(11, 6)
        Me.Paneldate.Name = "Paneldate"
        Me.Paneldate.Size = New System.Drawing.Size(210, 88)
        Me.Paneldate.TabIndex = 557
        '
        'txttodate
        '
        Me.txttodate.EditValue = New Date(CType(0, Long))
        Me.txttodate.EnterMoveNextControl = True
        Me.txttodate.Location = New System.Drawing.Point(38, 41)
        Me.txttodate.Name = "txttodate"
        Me.txttodate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttodate.Properties.Appearance.Options.UseFont = True
        Me.txttodate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txttodate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txttodate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txttodate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txttodate.Size = New System.Drawing.Size(128, 20)
        Me.txttodate.TabIndex = 524
        '
        'cmdSearch
        '
        Me.cmdSearch.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Appearance.Options.UseFont = True
        Me.cmdSearch.ImageOptions.Image = Global.Coffeecup.My.Resources.Resources.Search1
        Me.cmdSearch.Location = New System.Drawing.Point(170, 15)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(31, 46)
        Me.cmdSearch.TabIndex = 532
        '
        'txtfrmdate
        '
        Me.txtfrmdate.EditValue = New Date(CType(0, Long))
        Me.txtfrmdate.EnterMoveNextControl = True
        Me.txtfrmdate.Location = New System.Drawing.Point(38, 15)
        Me.txtfrmdate.Name = "txtfrmdate"
        Me.txtfrmdate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfrmdate.Properties.Appearance.Options.UseFont = True
        Me.txtfrmdate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtfrmdate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtfrmdate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtfrmdate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtfrmdate.Size = New System.Drawing.Size(128, 20)
        Me.txtfrmdate.TabIndex = 523
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(21, 44)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl1.TabIndex = 527
        Me.LabelControl1.Text = "To"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(9, 18)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl3.TabIndex = 525
        Me.LabelControl3.Text = "From"
        '
        'ckasof
        '
        Me.ckasof.Location = New System.Drawing.Point(36, 63)
        Me.ckasof.Name = "ckasof"
        Me.ckasof.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckasof.Properties.Appearance.Options.UseFont = True
        Me.ckasof.Properties.Caption = "use report as of query"
        Me.ckasof.Size = New System.Drawing.Size(135, 20)
        Me.ckasof.TabIndex = 581
        '
        'TabTransferControl
        '
        Me.TabTransferControl.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabTransferControl.AppearancePage.Header.Options.UseFont = True
        Me.TabTransferControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabTransferControl.Location = New System.Drawing.Point(238, 24)
        Me.TabTransferControl.Name = "TabTransferControl"
        Me.TabTransferControl.SelectedTabPage = Me.tabpending
        Me.TabTransferControl.Size = New System.Drawing.Size(576, 498)
        Me.TabTransferControl.TabIndex = 340
        Me.TabTransferControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabpending, Me.tabConfirmed, Me.tabCancelled})
        Me.TabTransferControl.Transition.AllowTransition = DevExpress.Utils.DefaultBoolean.[True]
        '
        'tabpending
        '
        Me.tabpending.Controls.Add(Me.Em)
        Me.tabpending.Name = "tabpending"
        Me.tabpending.Size = New System.Drawing.Size(574, 469)
        Me.tabpending.Text = "Pending Approval List"
        '
        'tabConfirmed
        '
        Me.tabConfirmed.Name = "tabConfirmed"
        Me.tabConfirmed.Size = New System.Drawing.Size(574, 469)
        Me.tabConfirmed.Text = "Confirmed Request"
        '
        'tabCancelled
        '
        Me.tabCancelled.Name = "tabCancelled"
        Me.tabCancelled.Size = New System.Drawing.Size(574, 469)
        Me.tabCancelled.Text = "Cancelled Request"
        '
        'frmTransferedRequestList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 540)
        Me.Controls.Add(Me.TabTransferControl)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmTransferedRequestList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfered Request List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.Paneldate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Paneldate.ResumeLayout(False)
        Me.Paneldate.PerformLayout()
        CType(Me.txttodate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttodate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfrmdate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfrmdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckasof.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabTransferControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabTransferControl.ResumeLayout(False)
        Me.tabpending.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DisplayFormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabTransferControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabpending As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabConfirmed As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabCancelled As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ViewRequestInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrintReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Paneldate As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txttodate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmdSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtfrmdate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckasof As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
End Class
