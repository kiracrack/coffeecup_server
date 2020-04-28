Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid
Imports System.IO
Imports DevExpress.XtraSplashScreen

Public Class frmDepedFFESummary
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then


        ElseIf keyData = Keys.F2 Then
            If SplitContainerControl1.Collapsed = True Then
                SplitContainerControl1.Collapsed = False
            Else
                SplitContainerControl1.Collapsed = True
            End If

        ElseIf keyData = (Keys.Control) + Keys.P Then
            PrintReport()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(gv_inventory)

        loadInventoryTo()

        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)
        filterInventory()
    End Sub

    Public Sub loadInventoryTo()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Office' from tblcompoffice order by officename asc", "tblcompoffice", txtInventory, gv_inventory, Me)
        gv_inventory.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInventory.EditValueChanged
        On Error Resume Next
        officeid.Text = txtInventory.Properties.View.GetFocusedRowCellValue("officeid").ToString()
        If ck_inventory.Checked = True Then
            PrintSummaryToolStripMenuItem.Enabled = False
        Else
            If txtInventory.Text = "" Then
                PrintSummaryToolStripMenuItem.Enabled = False
            Else
                PrintSummaryToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub cmdaction_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdaction.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        filterInventory()
        SplashScreenManager.CloseForm()
    End Sub
    Public Sub filterInventory()
        Dim viewalloffices As String = "" : Dim filterasof As String = "" : Dim stockhouse As String = ""
        If ck_inventory.Checked = True Then
            viewalloffices = ""
        Else
            viewalloffices = " and officeid ='" & officeid.Text & "'"
        End If
        If ckasof.Checked = True Then
            filterasof = " and date_format(dateacquired,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " and date_format(dateacquired,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If

        LoadXgrid("Select id as 'Entry Code'," _
                  + " (select officename from tblcompoffice where officeid=tblofficeequipment.officeid) as 'Office' , " _
                  + " productid as 'Product Code', " _
                  + " productname as 'Particular', " _
                  + " (select fullname from tblaccounts where accountid=tblofficeequipment.accountable) as 'Accountable Person'," _
                  + " productdetails as 'Equipment Details', " _
                  + " propertyno as 'Property Number', " _
                  + " Quantity, Unit, unitcost as 'Unit Cost', totalcost as Total, estimatedlife as 'Estimated Used Life', date_format(dateacquired, '%Y-%m-%d') as 'Date Acquired', " _
                  + " (select companyname from tblglobalvendor where vendorid=tblofficeequipment.vendorid) as 'Supplier' " _
                  + " from tblofficeequipment where id<> '' " & filterasof & viewalloffices & " order by productname asc", "tblofficeequipment", Em, GridView1, Me)

        GridView1.Columns("Office").Group()
        GridView1.ExpandAllGroups()
        XgridColCurrency({"Unit Cost", "Total"}, GridView1)
        XgridColAlign({"Entry Code", "Product Code", "Date Acquired", "Property Number", "Estimated Used Life"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()
        GridView1.Columns("Entry Code").Width = 100
        GridView1.Columns("Product Code").Width = 100
        GridView1.Columns("Quantity").Width = 120
        GridView1.Columns("Unit Cost").Width = 150
        GridView1.Columns("Total").Width = 150
        GridView1.Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center

        XgridGroupSummaryCurrency({"Total"}, GridView1)
        XgridGeneralSummaryCurrency({"Total"}, GridView1)

    End Sub
    
    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        cmdaction.PerformClick()
    End Sub

  
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub ck_inventory_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ck_inventory.CheckedChanged
        If ck_inventory.Checked = True Then
            txtInventory.Enabled = False
            txtInventory.Properties.DataSource = False
            txtInventory.Text = ""
            PrintSummaryToolStripMenuItem.Enabled = False
        Else
            loadInventoryTo()
            txtInventory.Enabled = True
            If txtInventory.Text = "" Then
                PrintSummaryToolStripMenuItem.Enabled = False
            Else
                PrintSummaryToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub PrintSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSummaryToolStripMenuItem.Click
        PrintReport()
    End Sub
    Public Sub PrintReport()
        
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        PrintReport()
    End Sub

    Private Sub ckasof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        frmDepEdAddFEE.Show(Me)
    End Sub

    Private Sub EditEquimentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditEquimentToolStripMenuItem.Click
        frmDepEdAddFEE.id.Text = GridView1.GetFocusedRowCellValue("Entry Code").ToString
        frmDepEdAddFEE.mode.Text = "edit"
        frmDepEdAddFEE.Show(Me)
    End Sub
End Class