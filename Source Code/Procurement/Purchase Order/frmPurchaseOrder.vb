Imports MySql.Data.MySqlClient
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraCharts

Public Class frmPurchaseOrder
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        End If
        Return ProcessCmdKey
    End Function

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        FilterOption()
    End Sub

    Private Sub frmAccountPayables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(gv_purchaseorder)
        LoadOffice()
        FilterOption()
        If Globalenablecreatedirectpo = True Then
            cmdCleared.Visible = True
            lineCleared.Visible = True
            cmdDirectPurchaseOrder.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            cmdEditPurchaseOrder.Visible = True
            ChangeApprovalToolStripMenuItem.Visible = False
        Else
            cmdCleared.Visible = False
            lineCleared.Visible = False
            cmdDirectPurchaseOrder.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            cmdEditPurchaseOrder.Visible = False
            ChangeApprovalToolStripMenuItem.Visible = True
        End If
    End Sub
    Public Sub FilterOption()
        If XtraTabControl1.SelectedTabPage Is tabOffice Then
            Em.Parent = XtraTabControl1.SelectedTabPage
        Else
            Em.Parent = XtraTabControl1.SelectedTabPage
        End If
        filterPurchaseOrder()
    End Sub
    Public Sub LoadOffice()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Office' from tblcompoffice order by officename asc", "tblcompoffice", txtInventory, gv_purchaseorder, Me)
        gv_purchaseorder.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInventory.EditValueChanged
        On Error Resume Next
        officeid.Text = txtInventory.Properties.View.GetFocusedRowCellValue("officeid").ToString()
    End Sub
    Public Function filterPurchaseOrder()
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = " and date_format(datetrn,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " and date_format(datetrn,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If

        '#update expired purchase order
        If countqry("tblpurchaseorder", "(dateexpiry<current_date and dateexpiry is not null ) and verified=0 and cancelled=0;") > 0 Then
            com.CommandText = "update tblpurchaseorder set expired=true where (dateexpiry<current_date and dateexpiry is not null ) and verified=0 and cancelled=0;" : com.ExecuteNonQuery()
        End If

        dst.Clear()
        LoadXgrid("Select cast(concat(requestref,vendorid) as char(100)) as relcode, " & If(GlobalEnableponumbersequence = True, "", " requestref as 'Request No.',") & " officeid,vendorid, ponumber as 'PO Number', " _
                   + " (select officename from tblcompoffice where officeid = tblpurchaseorder.officeid) as 'Office', " _
                   + " ifnull((select ucase(companyname) from tblglobalvendor where vendorid = tblpurchaseorder.vendorid),'DELETED SUPPLIER') as 'Supplier', " _
                   + " invoiceno as 'Invoice No.', totalamount as 'Total', " _
                   + " totalamount - ifnull((select ifnull(sum(tax+a.amount),0) from tbldisbursementdetails as a inner join tbldisbursementvoucher as b on a.voucherno=b.voucherno where b.ca=0 and ponumber = tblpurchaseorder.ponumber),0) as 'Balance', " _
                   + " case when corporatelevel=1 then 'CORPORATE OFFICE' else '" & UCase(GlobalOfficeCaption) & "' end as 'Request Level', " _
                   + " (select fullname from tblaccounts where accountid = tblpurchaseorder.createby) as 'Created By', " _
                   + " date_format(datetrn,'%Y-%m-%d') as 'Date Created',date_format(datetrn,'%r') as 'Time Created', " _
                   + " verified as Approved, " _
                   + " Forwarded, " _
                   + " Delivered, " _
                   + " date_format(datedelivered,'%Y-%m-%d') as 'Date Delivered', " _
                   + " paymentrequested as 'Payment Requested', " _
                   + " paymentupdated as Paid, " _
                   + " Closed, Cancelled, " _
                   + PurchaseOrderStatus.Remove(PurchaseOrderStatus.Length - 2, 2) _
                   + " from tblpurchaseorder where " & If(XtraTabControl1.SelectedTabPage Is tabOffice, " corporatelevel=0 ", " corporatelevel=1 ") _
                   + If(txtSearch.Text = "", "" _
                   + " and forpo=1 " & If(ck_inventory.Checked = True, "", " and officeid ='" & officeid.Text & "' ") _
                   + If(ckPendingRequest.Checked = True, " and (verified=0 or paymentupdated=0 or delivered=0 or paymentrequested=0  or closed=0) ", filterasof) & " and cancelled=0 ", "" _
                   + " and (ponumber like '%" & rchar(txtSearch.Text) & "%' or requestref like '%" & rchar(txtSearch.Text) & "%' or (select officename from tblcompoffice where officeid = tblpurchaseorder.officeid) like '%" & rchar(txtSearch.Text) & "%' or ifnull((select ucase(companyname) from tblglobalvendor where vendorid = tblpurchaseorder.vendorid),'DELETED SUPPLIER') like '%" & rchar(txtSearch.Text) & "%' ) ") _
                   + " order by datetrn desc", "tblpurchaseorder", Em, GridView1, Me)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblpurchaseorder")
        Em.DataSource = dst.Tables("tblpurchaseorder")

        '############## MAIN Gridview #####################

        XgridHideColumn({"relcode", "officeid", "vendorid"}, GridView1)
        GridView1.BestFitColumns()
        XgridColCurrency({"Total"}, GridView1)
        XgridColWidth({"Total", "Balance"}, GridView1, 120)
        XgridColCurrency({"Balance", "Total"}, GridView1)
        XgridColAlign({"Request No.", "PO Number", "Invoice No.", "Date Created", "Time Created", "Date Delivered", "Status", "Request Level"}, GridView1, HorzAlignment.Center)

        Dim item1 As New GridGroupSummaryItem()
        item1.FieldName = "Total"
        item1.SummaryType = DevExpress.Data.SummaryItemType.Sum
        item1.DisplayFormat = "{0:n} Php"
        item1.ShowInGroupColumnFooter = GridView1.Columns("Total")

        GridView1.GroupSummary.Add(item1)
        GridView1.Columns("Total").SummaryItem.SummaryType = SummaryItemType.Sum
        GridView1.Columns("Total").SummaryItem.DisplayFormat = "{0:n}"
        GridView1.Columns("Total").SummaryItem.Tag = 1
        CType(GridView1.Columns("Total").View, GridView).OptionsView.ShowFooter = True
        SaveFilterColumn(GridView1, Me.Text)

        DxChartPreviewReport("select (select officename from tblcompoffice where officeid = tblpurchaseorder.officeid) as Office, sum(totalamount) as Total from tblpurchaseorder where " & If(XtraTabControl1.SelectedTabPage Is tabOffice, " corporatelevel=0 ", " corporatelevel=1 ") & " and forpo=1 " & If(ck_inventory.Checked = True, "", " and officeid ='" & officeid.Text & "' ") _
                   + If(ckPendingRequest.Checked = True, " and (verified=0 or paymentupdated=0 or delivered=0 or paymentrequested=0  or closed=0) ", filterasof) & " and cancelled=0 group by officeid", "tblpurchaseorder", "Office", "Total", "Chart Report View", ChartControl1, ViewType.Pie3D, False)
        DirectPORowCheck()
    End Function

   

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        FilterOption()
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
        FilterOption()
        SplashScreenManager.CloseForm()
    End Sub


    Private Sub cmdViewItem_Click(sender As Object, e As EventArgs) Handles cmdViewItem.Click
        frmPurchaseOrderProfile.mode.Text = "po"
        frmPurchaseOrderProfile.ponumber.Text = GridView1.GetFocusedRowCellValue("PO Number").ToString
        If frmPurchaseOrderProfile.Visible = True Then
            frmPurchaseOrderProfile.Focus()
        Else
            frmPurchaseOrderProfile.Show(Me)
        End If

    End Sub

    Private Sub Em_DoubleClick(sender As Object, e As EventArgs) Handles Em.DoubleClick
        cmdViewItem.PerformClick()
    End Sub

    Private Sub ChangeApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeApprovalToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Status").ToString() = "CLOSED" Then
            XtraMessageBox.Show("Closed account not allowed!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmChangeApproving.mode.Text = "po"
        frmChangeApproving.ponumber.Text = GridView1.GetFocusedRowCellValue("PO Number").ToString
        frmChangeApproving.Show(Me)
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

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        PrintGeneralReport(Me.Text, XtraTabControl1.SelectedTabPage.Text, GridView1, Me)
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim colname As String = ""
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView1, Me.Text)
        frmColumnFilter.ShowDialog(Me)
    End Sub

    Private Sub ckPending_CheckedChanged(sender As Object, e As EventArgs) Handles ckPendingRequest.CheckedChanged
        If ckPendingRequest.Checked = True Then
            txtfrmdate.Enabled = False
            txttodate.Enabled = False
            ckasof.Enabled = False
            ckasof.Checked = False
        Else
            txtfrmdate.Enabled = True
            txttodate.Enabled = True
            ckasof.Enabled = True
        End If
        FilterOption()
    End Sub

    Private Sub ChangeSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeSupplierToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmChangeProductSupplier.mode.Text = "po"
            frmChangeProductSupplier.Show(Me)
        End If
    End Sub
    Public Function ChangeSupplier(ByVal vendorid As String)
        Dim newSupplier As String = qrysingledata("companyname", "companyname", "tblglobalvendor where vendorid='" & vendorid & "'")
        com.CommandText = "UPDATE tblpurchaseorder set vendorid='" & vendorid & "' where ponumber='" & GridView1.GetFocusedRowCellValue("PO Number").ToString & "'" : com.ExecuteNonQuery()
        com.CommandText = "UPDATE tblpurchaseorderitem set vendorid='" & vendorid & "' where ponumber='" & GridView1.GetFocusedRowCellValue("PO Number").ToString & "'" : com.ExecuteNonQuery()
        RecordApprovingHistory("purchase order", If(GlobalEnableponumbersequence = True, GridView1.GetFocusedRowCellValue("PO Number").ToString, GridView1.GetFocusedRowCellValue("Request No.").ToString), GridView1.GetFocusedRowCellValue("PO Number").ToString, "processed", "change supplier from " & GridView1.GetFocusedRowCellValue("Supplier").ToString & " to " & newSupplier)
        XtraMessageBox.Show("Supplier successfully changed", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        filterPurchaseOrder()
    End Function


    Private Sub cmdDirectPurchaseOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdDirectPurchaseOrder.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmDirectCreatePurchaseOrder.Visible = True Then
            frmDirectCreatePurchaseOrder.Focus()
        Else
            frmDirectCreatePurchaseOrder.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdCleared_Click(sender As Object, e As EventArgs) Handles cmdCleared.Click
        If qrysingledata("glcodeaccountspayable", "glcodeaccountspayable", "tblgldefaultitem") = "" Then
            XtraMessageBox.Show("Default accounts payable account title currently not configured! Please contact your system administrator", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmVerifiedPurchaseOrder.txtSupplier.Text = GridView1.GetFocusedRowCellValue("Supplier").ToString
        If frmVerifiedPurchaseOrder.Visible = True Then
            frmVerifiedPurchaseOrder.Focus()
        Else
            frmVerifiedPurchaseOrder.Show(Me)
        End If
    End Sub

    Public Sub ValidatingDirectPurchaseOrder(ByVal invoicenumber As String, ByVal datedelivered As Date)
        dst = New DataSet
        msda = New MySqlDataAdapter("Select * from tblpurchaseorderitem where ponumber='" & GridView1.GetFocusedRowCellValue("PO Number").ToString & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                UpdateInventory("Purchase order", GridView1.GetFocusedRowCellValue("PO Number").ToString, .Rows(cnt)("officeid").ToString(), .Rows(cnt)("vendorid").ToString(), "", .Rows(cnt)("productid").ToString(), Val(CC(.Rows(cnt)("quantity").ToString())), Val(CC(.Rows(cnt)("cost").ToString())), "Purchase Order #" + GridView1.GetFocusedRowCellValue("PO Number").ToString, "", invoicenumber)
                com.CommandText = "update tblpurchaseorderitem set delivered=1, datedelivered='" & ConvertDateTime(datedelivered) & "' where trnid='" & .Rows(cnt)("trnid").ToString() & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblglobalproducts set purchasedprice='" & Val(CC(.Rows(cnt)("cost").ToString())) & "' where productid='" & .Rows(cnt)("productid").ToString() & "'" : com.ExecuteNonQuery()
            End With
        Next
        com.CommandText = "UPDATE tblpurchaseorder set invoiceno='" & invoicenumber & "', verified='1', dateverified='" & ConvertDateTime(datedelivered) & "',verifiedby='" & globaluserid & "',forwarded=1, delivered=1, datedelivered='" & ConvertDateTime(datedelivered) & "',receivedby='" & globaluserid & "' where ponumber='" & GridView1.GetFocusedRowCellValue("PO Number").ToString & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblglaccountledger (journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                                       + "select 'payable-accounts',vendorid,ponumber,'Purchase Order', note, totalamount, 0,'" & ConvertDateTime(datedelivered) & "',createby,1,'" & globaluserid & "','" & ConvertDateTime(datedelivered) & "' from tblpurchaseorder where ponumber='" & GridView1.GetFocusedRowCellValue("PO Number").ToString & "'" : com.ExecuteNonQuery()
        If EnableModuleAccounting = True Then
            com.CommandText = "CALL sp_acct_entries('" & GridView1.GetFocusedRowCellValue("PO Number").ToString & "','" & GridView1.GetFocusedRowCellValue("officeid").ToString & "', 'RECEIVED_PO_AP','')" : com.ExecuteNonQuery()
        End If
        filterPurchaseOrder()
        XtraMessageBox.Show("Supplier successfully changed", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cmdEditPurchaseOrder_Click(sender As Object, e As EventArgs) Handles cmdEditPurchaseOrder.Click
        frmDirectCreatePurchaseOrder.mode.Text = "edit"
        frmDirectCreatePurchaseOrder.ponumber.Text = GridView1.GetFocusedRowCellValue("PO Number").ToString
        If frmDirectCreatePurchaseOrder.Visible = True Then
            frmDirectCreatePurchaseOrder.Focus()
        Else
            frmDirectCreatePurchaseOrder.Show(Me)
        End If
    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        DirectPORowCheck()
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        DirectPORowCheck()
    End Sub

    Public Sub DirectPORowCheck()
        If GridView1.RowCount = 0 Then Exit Sub
        If Globalenablecreatedirectpo = True Then
            If CBool(GridView1.GetFocusedRowCellValue("Approved").ToString) = True Then
                cmdCleared.Visible = False
                lineCleared.Visible = False
                cmdEditPurchaseOrder.Visible = False
            Else
                cmdCleared.Visible = True
                lineCleared.Visible = True
                cmdEditPurchaseOrder.Visible = True
            End If
        End If
    End Sub
 
    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Chr(13) Then
            FilterOption()
        End If
    End Sub

    Private Sub UpdateForceCloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateForceCloseToolStripMenuItem.Click
        frmPOForclosedAccount.ponumber.Text = GridView1.GetFocusedRowCellValue("PO Number").ToString
        frmPOForclosedAccount.ShowDialog(Me)
    End Sub

    Private Sub FullCancelPOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullCancelPOToolStripMenuItem.Click
        frmCancelRequestOption.mode.Text = "purchaseorder"
        frmCancelRequestOption.ShowDialog(Me)
    End Sub

    Public Sub CancelRequest(ByVal reason As String)
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "update tblpurchaseorder set cancelled=1,cancelledby='" & globalfullname & "',datecancelled=current_timestamp where ponumber='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "PO Number").ToString & "'" : com.ExecuteNonQuery()
            RecordApprovingHistory("Purchase Order", GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "PO Number").ToString, GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "PO Number").ToString, "cancelled", reason)
        Next
        FilterOption()
        XtraMessageBox.Show("Request successfully cancelled!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class