Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmStockoutType
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then


        ElseIf keyData = Keys.F2 Then
            If SplitContainerControl1.Collapsed = True Then
                SplitContainerControl1.Collapsed = False
            Else
                SplitContainerControl1.Collapsed = True
            End If

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmProductCat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmStockoutType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadAccountTitle()
        filter()
        clearfields()
    End Sub

    Public Sub LoadAccountTitle()
        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a where groupcode in (select groupcode from tblglgrouptag where expenses=1 or liabilities=1)", "tblglitem", txtCost, gridCost, Me)
        XgridHideColumn({"itemcode", "itemname", "debit", "sl"}, gridCost)
    End Sub

    Private Sub GridRowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles gridCost.RowCellStyle
        Dim View As GridView = sender
        Dim sl As Boolean = CBool(View.GetRowCellDisplayText(e.RowHandle, View.Columns("sl")))
        If sl = False Then
            e.Appearance.BackColor = Color.LightYellow
            e.Appearance.ForeColor = Color.Black
            e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold)
        End If
    End Sub

    Private Sub txtCost_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCost.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCost.Properties.View.FocusedRowHandle.ToString)
        costcode.Text = txtCost.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub

    Private Sub txtCost_Popup(sender As Object, e As EventArgs) Handles txtCost.Popup
        gridCost.BestFitColumns()
    End Sub

    Public Sub filter()
        LoadXgrid("Select Stockouttypeid, Description,(select itemname from tblglitem where itemcode=tblStockouttype.glaccountcode) 'Expense Title' from tblStockouttype", "tblStockouttype", Em, GridView1, Me)
        GridView1.Columns("Stockouttypeid").Visible = False
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If txtdesc.Text = "" Then
            XtraMessageBox.Show("Please provide description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesc.Focus()
            Exit Sub
        End If
        If mode.Text <> "edit" Then
            If countqry("tblStockouttype", "Stockouttypeid='" & id.Text & "'") <> 0 Then
                XtraMessageBox.Show("Duplicate category ID Please use unique one!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                id.Focus()
                Exit Sub
            End If
            com.CommandText = "insert into tblStockouttype set Stockouttypeid='" & id.Text & "', DESCRIPTION='" & txtdesc.Text & "', glaccountcode='" & costcode.Text & "' "
            com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblStockouttype set DESCRIPTION='" & txtdesc.Text & "', glaccountcode='" & costcode.Text & "'  where Stockouttypeid='" & id.Text & "' "
            com.ExecuteNonQuery()
        End If
        clearfields()
        filter()
        XtraMessageBox.Show("Stock-out type successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub clearfields()
        id.Text = getInventoryid()
        txtdesc.Text = ""
        mode.Text = ""
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select * from tblStockouttype where Stockouttypeid='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtdesc.Text = rst("DESCRIPTION").ToString
            costcode.Text = rst("glaccountcode").ToString
            txtCost.Text = rst("glaccountcode").ToString
        End While
        rst.Close()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Stockouttypeid") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        id.Text = GridView1.GetFocusedRowCellValue("Stockouttypeid").ToString
        mode.Text = "edit"
        SplitContainerControl1.Collapsed = False
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveItemToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Stockouttypeid") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("Stockouttypeid", "Stockouttypeid", "tblStockouttype", GridView1, Me)
        End If
    End Sub


End Class