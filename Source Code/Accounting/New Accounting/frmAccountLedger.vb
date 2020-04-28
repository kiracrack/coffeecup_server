Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls
Imports System.IO

Public Class frmAccountLedger
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then


        ElseIf keyData = (Keys.Control) + Keys.P Then
            ' printreport()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPumpReading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        txtdateFrom.Properties.MinValue = "01/01/" & txtYear.Text
        txtdateFrom.Properties.MaxValue = "01/31/" & txtYear.Text

        txtDateTo.Properties.MinValue = "01/01/" & txtYear.Text
        txtDateTo.Properties.MaxValue = "01/31/" & txtYear.Text

        txtdateFrom.EditValue = Format(frmGeneralLedger.txtReportDate.EditValue.AddMonths(-1).AddDays(1))
        txtDateTo.EditValue = frmGeneralLedger.txtReportDate.EditValue

    End Sub
    
    Public Sub FilterAccountLedger()
        Try
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            Dim debit As Boolean = CBool(qrysingledata("debit", "debit", "tblglitem where itemcode='" & accountno.Text & "'"))
            com.CommandText = "CALL sp_acct_accountledger('" & companyid.Text & "', '" & accountno.Text & "', '" & txtYear.Text & "')" : com.ExecuteNonQuery()
            If debit = True Then
                LoadXgrid("select a.id, " _
                      + " date_format(a.postingdate, '%Y-%m-%d') as 'Date Transaction', " _
                      + " (select officename from tblcompoffice where officeid=a.officeid) as 'Office', " _
                      + " referenceno as 'Reference No.', " _
                      + " Remarks, " _
                      + " a.debit as 'Debit', " _
                      + " a.credit as 'Credit', " _
                      + " (SELECT SUM(COALESCE(debit,0) - COALESCE(credit,0)) FROM tmpaccountledger2 as b " _
                      + " WHERE b.id <= a.id and b.itemcode='" & accountno.Text & "' and date_format(b.postingdate, '%Y')='" & txtYear.Text & "' ) AS 'Balance', " _
                      + " trnname as 'Transacted By' " _
                      + " FROM `tmpaccountledger` as a where date_format(a.postingdate, '%Y')='" & txtYear.Text & "' and date_format(a.postingdate, '%Y-%m-%d') between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' order by id asc", "tmpaccountledger", Em, GridView1, Me)
            Else
                LoadXgrid("select a.id, " _
                    + " date_format(a.postingdate, '%Y-%m-%d') as 'Date Transaction', " _
                    + " (select officename from tblcompoffice where officeid=a.officeid) as 'Office', " _
                    + " referenceno as 'Reference No.', " _
                    + " Remarks, " _
                    + " a.debit as 'Debit', " _
                    + " a.credit as 'Credit', " _
                    + " (SELECT SUM(COALESCE(credit,0) - COALESCE(debit,0)) FROM tmpaccountledger2 as b " _
                    + " WHERE b.id <= a.id and b.itemcode='" & accountno.Text & "' and date_format(b.postingdate, '%Y')='" & txtYear.Text & "' ) AS 'Balance', " _
                    + " trnname as 'Transacted By' " _
                    + " FROM `tmpaccountledger` as a where date_format(a.postingdate, '%Y')='" & txtYear.Text & "' and date_format(a.postingdate, '%Y-%m-%d') between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' order by id asc", "tmpaccountledger", Em, GridView1, Me)
            End If

            XgridHideColumn({"id"}, GridView1)
            XgridHideColumn({"trnid"}, GridView1)
            GridView1.BestFitColumns()
            XgridColAlign({"Reference No.", "Date Transaction"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
            XgridColCurrency({"Debit", "Credit", "Balance"}, GridView1)
            GridView1.BestFitColumns()
            GridView1.Columns("Remarks").Width = 300
            GridView1.Columns("Remarks").ColumnEdit = MemoEdit
            'XgridColWidth({"Description"}, GridView1, 300)
            XgridColWidth({"Debit", "Credit", "Balance"}, GridView1, 120)
            ShowDetails()
            Em.Refresh() : GridView1.RefreshData()
            SplashScreenManager.CloseForm()
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                            & "Module:" & "form_load" & vbCrLf _
                            & "Message:" & errMYSQL.Message & vbCrLf _
                            & "Details:" & errMYSQL.StackTrace, _
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SplashScreenManager.CloseForm()
        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                            & "Module:" & "form_load" & vbCrLf _
                            & "Message:" & errMS.Message & vbCrLf _
                            & "Details:" & errMS.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SplashScreenManager.CloseForm()
        End Try
    End Sub

    Public Sub ShowDetails()
        com.CommandText = "select sum(debitamount) as ttldebit, sum(creditamount) as ttlcredit, if(debit=1,sum(debitamount)-sum(creditamount),sum(creditamount)-sum(debitamount))  as 'balance' from tblglticket where itemcode='" & accountno.Text & "' and date_format(postingdate, '%Y')='" & txtYear.Text & "' " : rst = com.ExecuteReader
        While rst.Read
            txtTotalDebit.Text = Format(Val(rst("ttldebit").ToString), "n")
            txtTotalCredit.Text = Format(Val(rst("ttlcredit").ToString), "n")
            txtCurrentBalance.Text = Format(Val(rst("balance").ToString), "n")
        End While
        rst.Close()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        gridview1.ShowFindPanel()
    End Sub

    Private Sub txtdatetrn_EditValueChanged(sender As Object, e As EventArgs) Handles txtdateFrom.EditValueChanged
        If accountno.Text <> "" Then
            FilterAccountLedger()
            txtDateTo.Properties.MinValue = txtdateFrom.EditValue
        End If
    End Sub

    Private Sub txtDateTo_EditValueChanged(sender As Object, e As EventArgs) Handles txtDateTo.EditValueChanged
        If accountno.Text <> "" Then
            FilterAccountLedger()

        End If
    End Sub

    Private Sub RefreshLedgerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshLedgerToolStripMenuItem.Click
        FilterAccountLedger()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        If txtAccountTitle.Text = "" And GridView1.RowCount = 0 Then
            XtraMessageBox.Show("Please select account!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Report File (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveFileDialog1.FileName = txtAccountTitle.Text & " (" & ConvertDate(txtdateFrom.Text) & " to " & ConvertDate(txtDateTo.Text) & ").xlsx"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If System.IO.File.Exists(saveFileDialog1.FileName) = True Then
                System.IO.File.Delete(saveFileDialog1.FileName)
            End If
            GridView1.ExportToXlsx(saveFileDialog1.FileName)
            XtraMessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        PrintGeneralReport(txtAccountTitle.Text, "Report Date: " & txtdateFrom.Text & " - " & txtDateTo.Text, GridView1, Me)
    End Sub
End Class