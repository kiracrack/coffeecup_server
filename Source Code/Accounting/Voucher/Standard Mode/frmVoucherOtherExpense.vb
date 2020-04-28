Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmVoucherOtherExpense
    Public ConfirmVoucher As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmVoucherOtherExpense_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmConfirmedVoucherProcessing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadTransactionName()
        If mode.Text = "edit" Then
            showInfo()
        End If
    End Sub
    Public Sub LoadTransactionName()
        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a where groupcode in (select groupcode from tblglgrouptag where expenses=1)", "tblglitem", txtTransactionName, Gridview_TransactionName, Me)
        XgridHideColumn({"itemcode", "itemname", "debit", "sl"}, Gridview_TransactionName)
    End Sub
    Private Sub gridItem_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles Gridview_TransactionName.RowCellStyle
        Dim View As GridView = sender
        Dim sl As Boolean = CBool(View.GetRowCellDisplayText(e.RowHandle, View.Columns("sl")))
        If sl = False Then
            e.Appearance.BackColor = Color.LightYellow
            e.Appearance.ForeColor = Color.Black
            e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold)
        End If
    End Sub
    Private Sub txtTransactionName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTransactionName.EditValueChanged
        On Error Resume Next
        itemcode.Text = txtTransactionName.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub
    Public Sub showInfo()
        com.CommandText = "select * from tbldisbursementexpense where id='" & trnid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            voucherno.Text = rst("voucherno").ToString
            itemcode.Text = rst("itemcode").ToString
            txtTransactionName.EditValue = rst("itemcode").ToString
            txtRemarks.Text = rst("remarks").ToString
            txtCheckAmount.Text = FormatNumber(rst("amount").ToString, 2)
        End While
        rst.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtTransactionName.Text = "" Then
            XtraMessageBox.Show("Please select transaction name", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTransactionName.Focus()
            Exit Sub
        ElseIf Val(CC(txtCheckAmount.Text)) <= 0 Then
            XtraMessageBox.Show("Please enter amount", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCheckAmount.Focus()
            Exit Sub
        ElseIf txtRemarks.Text = "" Then
            XtraMessageBox.Show("Please enter message", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRemarks.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tbldisbursementexpense set voucherno='" & voucherno.Text & "', companyid='" & companyid.Text & "', itemcode='" & itemcode.Text & "', remarks='" & rchar(txtRemarks.Text) & "',invoiceno='" & txtInvoiceno.Text & "', amount='" & Val(CC(txtCheckAmount.Text)) & "' where id='" & trnid.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tbldisbursementexpense set voucherno='" & voucherno.Text & "',companyid='" & companyid.Text & "', itemcode='" & itemcode.Text & "', remarks='" & rchar(txtRemarks.Text) & "',invoiceno='" & txtInvoiceno.Text & "', amount='" & Val(CC(txtCheckAmount.Text)) & "', datetrn=current_date" : com.ExecuteNonQuery()
            End If


            If frmVouchersInformation.Visible = True Then
                frmVouchersInformation.filterOtherExpense()
            End If

            If frmVoucherLiquiditionForm.Visible = True Then
                frmVoucherLiquiditionForm.filterOtherExpense()
            End If
            XtraMessageBox.Show("Expense successfully saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub


End Class