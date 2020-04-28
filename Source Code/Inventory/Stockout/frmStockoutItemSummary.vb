Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraSplashScreen

Public Class frmStockoutItemSummary
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
       
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmTransferedItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)
        LoadOffice()
        filter()
    End Sub

    Public Sub LoadOffice()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Office' from tblcompoffice order by officename asc", "tblcompoffice", txtInventory, gv_Office, Me)
        gv_Office.Columns("officeid").Visible = False
    End Sub

    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInventory.EditValueChanged
        On Error Resume Next
        officeid.Text = txtInventory.Properties.View.GetFocusedRowCellValue("officeid").ToString()
    End Sub

    Public Sub filter()
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = " and date_format(postingdate,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " and date_format(postingdate,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If

        LoadXgrid("Select  ID,BatchCode, date_format(postingdate,'%Y-%m-%d') as 'Stockout Date', (select officename from tblcompoffice where officeid=tblstockoutitem.officeid) as 'Office', " _
                            + " (select itemname from tblglobalproducts where PRODUCTID=tblstockoutitem.PRODUCTID) as 'Item Name', " _
                            + " (select description from tblprocategory where CATID = tblstockoutitem.CATID) as 'Category', " _
                            + " refcode as 'Stock ID', " _
                            + " Quantity,Unit, purchasedprice as 'Unit Cost', (purchasedprice*Quantity) as 'Total Cost',  Remarks, " _
                            + " (select description from tblstockouttype where stockouttypeid=tblstockoutitem.stockouttypeid) as 'Stockout Type',  " _
                            + " (select fullname from tblaccounts where accountid=tblstockoutitem.trnby) as 'Transaction By', date_format(datetrn,'%Y-%m-%d %r') as 'Date Transaction' " _
                            + " from tblstockoutitem where confirmed=1 " & filterasof & If(ck_inventory.Checked = True, "", " and officeid='" & officeid.Text & "'"), "tblstockoutitem", Em, GridView1, Me)

        XgridColAlign({"ID", "Series No.", "Quantity", "Unit", "Stockout Date", "Stockout Time"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
 
        XgridColCurrencyDecimalCount({"Quantity", "Unit Cost", "Total Cost"}, 3, GridView1)
        XgridColAlign({"BatchCode", "Stockout Date", "Stock ID", "Stockout Date"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total Cost"}, GridView1)
    End Sub


    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub
 
    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

#Region "REPORT SETTINGS"
    Private Sub ckasof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        filter()
        SplashScreenManager.CloseForm()
    End Sub
#End Region

     
    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdaction.Click
        filter()
    End Sub

    Private Sub ck_inventory_CheckedChanged(sender As Object, e As EventArgs) Handles ck_inventory.CheckedChanged
        If ck_inventory.Checked = True Then
            txtInventory.Enabled = False
            txtInventory.Properties.DataSource = False
            txtInventory.Text = ""
        Else
            LoadOffice()
            txtInventory.Enabled = True
        End If
    End Sub

    Private Sub ckasof_CheckedChanged_1(sender As Object, e As EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
            txttodate.Enabled = False
        Else
            txtfrmdate.Enabled = True
            txttodate.Enabled = True
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        PrintDatagridview(If(ck_inventory.Checked = True, Me.Text, txtInventory.Text), Me.Text, If(ckasof.Checked = True, "Report Filter: ALL RECORDS", "Report Filter: From " & txtfrmdate.Text & " to " & txttodate.Text), GridView1, Me)
    End Sub
     
    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        ExportGridToExcel("Stock out consumable summary " & If(ck_inventory.Checked = True, "all office", txtInventory.Text) & " as of " & CDate(Now).ToString("yyyy-MM-dd"), GridView1)
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If frmStockoutBatchRequest.Visible = True Then
            frmStockoutBatchRequest.Focus()
        Else
            frmStockoutBatchRequest.Show(Me)
        End If
    End Sub
End Class