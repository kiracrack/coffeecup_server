Imports MySql.Data.MySqlClient
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraSplashScreen

Public Class frmStockoutBatchSummary
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmAccountPayables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)
        FilterStockoutSummary()
    End Sub

    'Public Function FilterStockoutSummaryOLD()
    '    Dim filterasof As String = ""
    '    If ckasof.Checked = True Then
    '        filterasof = "where date_format(datetrn,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
    '    Else
    '        filterasof = "where date_format(datetrn,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
    '    End If
    '    dst.EnforceConstraints = False
    '    dst.Relations.Clear() : Em.LevelTree.Nodes.Clear()
    '    dst.Clear()
    '    LoadXgrid("Select batchcode as 'Stockout No.',  (select officename from tblcompoffice where officeid=tblstockoutbatch.inventory) as 'Inventory', " _
    '                                    + " date_format(datestockout, '%Y-%m-%d') as 'Date Stockout', " _
    '                                    + " allocatedstockout as 'Allocated Stockout', " _
    '                                    + " (select officename from tblcompoffice where officeid=tblstockoutbatch.allocatedoffice) as 'Allocated Office'," _
    '                                    + " (select count(*) from tblstockoutitem where batchcode=tblstockoutbatch.batchcode) as 'Total Item', " _
    '                                    + " ifnull((select sum(purchasedprice) from tblstockoutitem where batchcode=tblstockoutbatch.batchcode),0) as 'Total Amount', " _
    '                                    + " (select fullname from tblaccounts where accountid=tblstockoutbatch.requestby) as 'Requested by', " _
    '                                    + " Remarks, " _
    '                                    + " date_format(datetrn, '%Y-%m-%d') as 'Date Transactions', " _
    '                                    + " (select fullname from tblaccounts where accountid=tblstockoutbatch.trnby) as 'Transaction by', " _
    '                                    + " Verified, " _
    '                                    + " Cancelled, " _
    '                                    + " date_format(datecancelled, '%Y-%m-%d') as 'Date Cancelled', " _
    '                                    + " (select fullname from tblaccounts where accountid=tblstockoutbatch.cancelledby) as 'Cancelled by' " _
    '                                    + " from tblstockoutbatch  " & If(ckPendingRequest.Checked = True, " where verified=0 and cancelled=0 ", filterasof) & " order by datetrn desc", "tblstockoutbatch", Em, GridView1, Me)
    '    msda.SelectCommand.CommandTimeout = 6000000
    '    msda.Fill(dst, "tblstockoutbatch")

    '    XgridColCurrency({"Total Amount"}, GridView1)
    '    XgridColAlign({"Stockout No.", "Date Stockout", "Total Item"}, GridView1, HorzAlignment.Center)
    '    GridView1.BestFitColumns()

    '    XgridGeneralSummaryCurrency({"Total Amount"}, GridView1)

    '    msda = New MySqlDataAdapter("Select batchcode as 'Stockout No.', (select itemname from tblglobalproducts where productid=tblstockoutitem.productid) as 'Product Name', (select description from tblprocategory where catid=tblstockoutitem.catid) as 'Category', Quantity,Unit, purchasedprice as 'Unit Cost', (purchasedprice*Quantity) as 'Total Cost',Remarks from tblstockoutitem", conn)
    '    msda.Fill(dst, "tblstockoutitem")

    '    BandgridView = New GridView(Em)
    '    LoadGridviewAppearance(BandgridView)
    '    Dim keyColumn As DataColumn = dst.Tables("tblstockoutbatch").Columns("Stockout No.")
    '    Dim foreignKeyColumn2 As DataColumn = dst.Tables("tblstockoutitem").Columns("Stockout No.")

    '    dst.Relations.Add("StockoutDetails", keyColumn, foreignKeyColumn2)
    '    Em.LevelTree.Nodes.Add("StockoutDetails", BandgridView)

    '    Em.DataSource = dst.Tables("tblstockoutbatch")

    '    '############## Band Gridview #####################
    '    BandgridView.PopulateColumns(dst.Tables("tblstockoutitem"))
    '    BandgridView.BestFitColumns()
    '    BandgridView.OptionsView.ColumnAutoWidth = False
    '    BandgridView.OptionsView.RowAutoHeight = False
    '    BandgridView.OptionsCustomization.AllowGroup = False
    '    BandgridView.OptionsView.ShowGroupPanel = False
    '    BandgridView.OptionsBehavior.Editable = False
    '    XgridHideColumn({"Stockout No."}, BandgridView)
    '    XgridColCurrency({"Unit Cost", "Total Cost"}, BandgridView)
    '    XgridGeneralSummaryCurrency({"Unit Cost", "Total Cost"}, BandgridView)
    '    XgridColWidth({"Product Name"}, BandgridView, 300)
    '    XgridColAlign({"Quantity", "Unit"}, BandgridView, HorzAlignment.Center)
    '    SaveFilterColumn(GridView1, Me.Text)
    '    Return True
    'End Function

    Public Function FilterStockoutSummary()
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = "and date_format(postingdate,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = "and date_format(postingdate,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If
        LoadXgrid("Select  id,BatchCode, date_format(postingdate,'%Y-%m-%d') as 'Stockout Date', (select officename from tblcompoffice where officeid=tblstockoutitem.officeid) as 'Office', " _
                            + " (select itemname from tblglobalproducts where PRODUCTID=tblstockoutitem.PRODUCTID) as 'Item Name', " _
                            + " (select description from tblprocategory where CATID = tblstockoutitem.CATID) as 'Category', " _
                            + " refcode as 'Stock ID', " _
                            + " Quantity,Unit, purchasedprice as 'Unit Cost', (purchasedprice*Quantity) as 'Total Cost',  Remarks, " _
                            + " (select description from tblstockouttype where stockouttypeid=tblstockoutitem.stockouttypeid) as 'Stockout Type', Remarks, " _
                            + " (select fullname from tblaccounts where accountid=tblstockoutitem.trnby) as 'Transaction By', date_format(datetrn,'%Y-%m-%d %r') as 'Date Transaction' " _
                            + " from tblstockoutitem where confirmed=1 " & filterasof, "tblstockoutitem", Em, GridView1, Me)
        

        XgridColCurrency({"Total Cost"}, GridView1)
        XgridColAlign({"BatchCode", "Stockout Date", "Stock ID", "Stockout Date"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total Amount"}, GridView1)
        Return True
    End Function
     
    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        FilterStockoutSummary()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub


    Private Sub ckasof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        FilterStockoutSummary()
        SplashScreenManager.CloseForm()
    End Sub

     
    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        PrintGeneralReport(Me.Text, Me.Text, GridView1, Me)
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        ReadFilterColumn(GridView1, Me.Text)
    End Sub
 
    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        frmVouchersInformation.Show(Me)
    End Sub
 

    Private Sub cmdCreateBatch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCreateBatch.ItemClick
        If frmStockoutBatchRequest.Visible = True Then
            frmStockoutBatchRequest.Focus()
        Else
            frmStockoutBatchRequest.Show(Me)
        End If

    End Sub

  
End Class