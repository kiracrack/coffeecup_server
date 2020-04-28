Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmProductPriceList
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmAddVendorItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        filterPriceList()
    End Sub

    Public Sub filterPriceList()
        'LoadXgrid("Select id, (select ucase(COMPANYNAME) from tblglobalvendor where vendorid = tblitemvendor.vendorid) as Vendor, procost as 'Selling Price',Unit, lastupdate as 'Last Update' from tblitemvendor where itemid='" & productid.Text & "' order by procost asc", "tblitemvendor", Em, GridView1, Me)
        LoadXgrid("select Supplier, Unit, cost as 'Unit Cost',date_format(datedelivered,'%M %d, %Y %r') as 'Last Update'  from (select (select ucase(COMPANYNAME) from tblglobalvendor where vendorid = tblpurchaseorderitem.vendorid) as supplier, cost, unit, datedelivered  from tblpurchaseorderitem where delivered=1 and productid='" & productid.Text & "'  union all " _
                        + " select (select ucase(COMPANYNAME) from tblglobalvendor where vendorid = tblinventorylogs.vendorid),unitcost,unit,datetrn from tblinventorylogs where productid='" & productid.Text & "'  order by datedelivered desc) as a where supplier<>'' group by supplier order by datedelivered desc;", "tblpurchaseorderitem", Em, GridView1, Me)
        XgridColAlign({"Unit"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Unit Cost"}, GridView1)
    End Sub
 
    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filterPriceList()
    End Sub
    Private Sub FormatGridToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormatGridToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        PrintGeneralReport(Me.Text, productname.Text & " Price List", gridview1, Me)
    End Sub

    Private Sub productid_EditValueChanged(sender As Object, e As EventArgs) Handles productid.EditValueChanged
        filterPriceList()
    End Sub
End Class