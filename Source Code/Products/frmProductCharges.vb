Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins

Public Class frmProductCharges
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmClientProductFilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(Gridview2)
        LoadChargesName()
        LoadProduct()
        LoadChargesProduct()
        If globalAllowAdd = True Then
            cmdSaveCharges.Visible = True
        Else
            cmdSaveCharges.Visible = False
        End If

        If globalAllowEdit = True Then
            cmdEdit_charges.Enabled = True
        Else
            cmdEdit_charges.Enabled = False
        End If

        If globalAllowDelete = True Then
            cmdDelete_charges.Enabled = True
        Else
            cmdDelete_charges.Enabled = False
        End If

    End Sub

#Region "Charges Settings"
    Public Sub LoadChargesName()
        LoadXgridLookupSearch("select id, Description  from tblclientchargesname order by Description asc", "tblclientchargesname", txtChargesName, gvChargesName, Me)
        gvChargesName.Columns("id").Visible = False
    End Sub

    Private Sub txtChargesName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChargesName.EditValueChanged
        On Error Resume Next
        chargescode.Text = txtChargesName.Properties.View.GetFocusedRowCellValue("id").ToString()
        LoadChargesProduct()
        ShowUnfilteredOffice()
        ShowfilteredOffice()
    End Sub

    Public Sub LoadProduct()
        LoadXgridLookupSearch("select catid, Description  from tblprocategory where (consumable=1 or noninventory=1) order by Description asc", "tblprocategory", txtCategory, gridCategory, Me)
        gridCategory.Columns("catid").Visible = False
    End Sub

    Private Sub txtCategory_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCategory.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCategory.Properties.View.FocusedRowHandle.ToString)
        catid.Text = txtCategory.Properties.View.GetFocusedRowCellValue("catid").ToString()
    End Sub

    Public Sub LoadChargesProduct()
        If chargescode.Text = "" Then Exit Sub
        LoadXgrid("select id, (select description from tblprocategory where catid=tblclientcharges.catid)  as 'Category',ucase(chargestype) as 'Charges Type', chargesrate as 'Charges Rate', Enable from tblclientcharges where chargesid='" & chargescode.Text & "' order by (select description from tblprocategory where catid=tblclientcharges.catid) asc", "tblclientcharges", Em_charges, Gridview2, Me)
        Gridview2.Columns("id").Visible = False
        Gridview2.Columns("Charges Rate").Width = 80
        XgridColAlign({"Charges Rate", "Charges Type", "Enable"}, Gridview2, DevExpress.Utils.HorzAlignment.Center)
    End Sub


    Private Sub cmdSaveCharges_Click(sender As Object, e As EventArgs) Handles cmdSaveCharges.Click
        If txtCategory.Text = "" Then
            XtraMessageBox.Show("Please Select Category!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCategory.Focus()
            Exit Sub
        ElseIf txtChargesRate.Text = "0.00" Then
            XtraMessageBox.Show("Please Enter charges Rate!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtChargesRate.Focus()
            Exit Sub
        ElseIf countqry("tblclientcharges", "catid='" & catid.Text & "' and chargesid='" & chargescode.Text & "' and id<>'" & id.Text & "'") > 0 Then
            XtraMessageBox.Show("Product charges is already added!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCategory.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to save charges rate?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tblclientcharges set chargesid='" & chargescode.Text & "', catid='" & catid.Text & "',  chargestype='" & radChargesType.EditValue & "', chargesrate='" & Val(CC(txtChargesRate.Text)) & "' where id='" & id.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblclientcharges set chargesid='" & chargescode.Text & "', catid='" & catid.Text & "', chargestype='" & radChargesType.EditValue & "', chargesrate='" & Val(CC(txtChargesRate.Text)) & "', enable=0 " : com.ExecuteNonQuery()
            End If
            txtCategory.Properties.DataSource = Nothing
            txtCategory.Text = "" : catid.Text = "" : txtChargesRate.Text = "0"
            LoadProduct() : LoadChargesProduct()
            XtraMessageBox.Show("Charge rate successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    Private Sub cmdEdit_charges_Click(sender As Object, e As EventArgs) Handles cmdEdit_charges.Click
        If XtraMessageBox.Show("Are you sure you want to edit selected item?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            id.Text = Gridview2.GetFocusedRowCellValue("id").ToString
            Dim strproduct As String = ""
            com.CommandText = "select *, (select description from tblprocategory where catid=tblclientcharges.catid) as 'category' from tblclientcharges where id='" & id.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                strproduct = rst("category").ToString
                radChargesType.EditValue = rst("chargestype").ToString
                catid.Text = rst("catid").ToString
                txtChargesRate.Text = rst("chargesrate").ToString
            End While
            rst.Close()
            txtCategory.Text = strproduct
            mode.Text = "edit"
        End If
    End Sub

    Private Sub cmdDelete_charges_Click(sender As Object, e As EventArgs) Handles cmdDelete_charges.Click
        If XtraMessageBox.Show("Are you sure you want to delete selected item?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblclientcharges where id='" & Gridview2.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
            LoadChargesProduct()
        End If
    End Sub

    Private Sub EnableDisableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableDisableToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to tag as hired selected employee? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To Gridview2.SelectedRowsCount - 1
                If CBool(Gridview2.GetFocusedRowCellValue("Enable").ToString) = True Then
                    com.CommandText = "update tblclientcharges set enable=0 where id='" & Gridview2.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
                Else
                    com.CommandText = "update tblclientcharges set enable=1 where id='" & Gridview2.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
                End If

            Next
            LoadChargesProduct()
        End If
    End Sub
#End Region

#Region "Charges Filter"
    Public Sub ShowUnfilteredOffice()
        If chargescode.Text = "" Then Exit Sub
        LoadXgrid("select officeid, officename as 'Not Allowed' from tblcompoffice where officeid not in (select officeid from tblproductchargesfilter where chargesid='" & chargescode.Text & "') order by officename asc", "tblcompoffice", Em_unfiltered, gridunfiltered, Me)
        gridunfiltered.Columns("officeid").Visible = False
    End Sub

    Public Sub ShowfilteredOffice()
        If chargescode.Text = "" Then Exit Sub
        LoadXgrid("select officeid, officename as 'Allowed' from tblcompoffice where officeid in (select officeid from tblproductchargesfilter  where chargesid='" & chargescode.Text & "') order by officename asc", "tblcompoffice", Em_filtered, gridfiltered, Me)
        gridfiltered.Columns("officeid").Visible = False
    End Sub
#End Region

    Private Sub cmdMoveRight_Click(sender As Object, e As EventArgs) Handles cmdMoveRight.Click
        For I = 0 To gridunfiltered.SelectedRowsCount - 1
            com.CommandText = "insert into tblproductchargesfilter set officeid='" & gridunfiltered.GetRowCellValue(gridunfiltered.GetSelectedRows(I), "officeid").ToString & "', chargesid='" & chargescode.Text & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredOffice()
        ShowfilteredOffice()
    End Sub

    Private Sub cmdMoveLeft_Click(sender As Object, e As EventArgs) Handles cmdMoveLeft.Click
        For I = 0 To gridfiltered.SelectedRowsCount - 1
            com.CommandText = "delete from tblproductchargesfilter where officeid='" & gridfiltered.GetRowCellValue(gridfiltered.GetSelectedRows(I), "officeid").ToString & "' and chargesid='" & chargescode.Text & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredOffice()
        ShowfilteredOffice()
    End Sub

    Private Sub HyperlinkLabelControl1_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl1.Click
        frmProductChargesName.ShowDialog(Me)
        LoadChargesName()
    End Sub

    Private Sub XtraTabControl1_TabIndexChanged(sender As Object, e As EventArgs) Handles XtraTabControl1.TabIndexChanged
        ShowUnfilteredOffice()
        ShowfilteredOffice()
    End Sub
End Class