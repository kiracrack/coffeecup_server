Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraSplashScreen

Public Class frmTransferedItems
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + Keys.W Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then


        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmTransferedItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)

        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)

        filter()
        LoadGridviewAppearance(GridView1)
    End Sub

    Private Sub txtProductName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProductName.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtProductName.Text = "" Or txtProductName.Text = "%" Then Exit Sub
            If countqry("tblglobalproducts", "itemname='" & rchar(txtProductName.Text) & "' and productid in (select itemid from tbltransferitem) ") = 0 Then
                LoadToComboBox("itemname", "tblglobalproducts where " & SearchProductName("itemname", rchar(txtProductName.Text)) & " and productid in (select itemid from tbltransferitem)", txtProductName, True)
                txtProductName.ShowPopup()
                Exit Sub
            Else
                filter()
            End If
        End If
    End Sub

    Public Sub filter()
        Dim viewallproducts As String = "" : Dim filterasof As String = ""
        If ckShowAllProducts.Checked = True Then
            viewallproducts = ""
        Else
            viewallproducts = " and (select ITEMNAME from tblglobalproducts where PRODUCTID=tbltransferitem.itemid) ='" & rchar(txtProductName.Text) & "'"
        End If
        If ckasof.Checked = True Then
            filterasof = " date_format(dateconfirmed,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " date_format(dateconfirmed,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If
        LoadXgrid("select tbltransferbatch.batchcode as 'Batchcode',source_rr as 'RR', " _
                + " (select fullname from tblaccounts where accountid=tbltransferbatch.requestby) as 'Request By', " _
                + " date_format(datetransfer, '%Y-%m-%d %r') as 'Date Request', " _
                  + " (select officename from tblcompoffice where officeid=tbltransferbatch.inventory_from) as 'Transfer From', " _
                  + " (select officename from tblcompoffice where officeid=tbltransferbatch.inventory_to) as 'Transfer To', " _
                   + " (select (select description from tblprocategory where catid=a.catid) from tblglobalproducts as a where a.PRODUCTID=tbltransferitem.itemid) as 'Category',  " _
                  + " (select ITEMNAME from tblglobalproducts where PRODUCTID=tbltransferitem.itemid) as 'Product',  " _
                  + " (select unit from tblglobalproducts where PRODUCTID=tbltransferitem.itemid) as 'Unit', " _
                           + " Quantity,unitcost as 'Unit Cost', (Quantity*unitcost) as 'Total Cost', " _
                           + " (select fullname from tblaccounts where accountid=tbltransferbatch.trnby) as 'Processed By', " _
                           + " Note, Remarks,if(Confirmed=1,'Yes','-') as 'Confirmed', date_format(dateconfirmed, '%Y-%m-%d %r') as 'Date Confirmed',  " _
                           + " (select fullname from tblaccounts where accountid=tbltransferbatch.confirmedby) as 'Confirmed By', " _
                           + " Cancelled,(select fullname from tblaccounts where accountid=tbltransferbatch.cancelledby) as 'Cancelled By' from tbltransferitem inner join tbltransferbatch on tbltransferitem.batchcode = tbltransferbatch.batchcode where " & filterasof & viewallproducts & " order by dateconfirmed desc", "tbltransferitem", Em, GridView1, Me)
        '  GridView1.Columns("inventory_from").Visible = False
        GridView1.Columns("Note").ColumnEdit = MemoEdit
        GridView1.Columns("Remarks").ColumnEdit = MemoEdit
        XgridColCurrency({"Quantity", "Unit Cost", "Total Cost"}, GridView1)
        XgridColAlign({"Batchcode", "Quantity", "Date Request", "Date Received", "Confirmed", "Date Confirmed"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total Cost"}, GridView1)
        XgridColMemo({"Product", "Remarks"}, GridView1)
        XgridColWidth({"Product", "Remarks"}, GridView1, 300)


    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

#Region "REPORT SETTINGS"
    Private Sub ckasof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintReport.Click
       
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        filter()
        SplashScreenManager.CloseForm()
    End Sub
#End Region

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub ckShowAllProducts_CheckedChanged(sender As Object, e As EventArgs) Handles ckShowAllProducts.CheckedChanged
        If ckShowAllProducts.Checked = True Then
            txtProductName.Enabled = False
        Else
            'loadProductList()
            txtProductName.Enabled = True
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        filter()
    End Sub
End Class