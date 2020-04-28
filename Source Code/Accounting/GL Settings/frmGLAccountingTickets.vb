Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls
Imports System.IO

Public Class frmGLAccountingTickets
    Private BandgridView As GridView
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
        txtdateFrom.EditValue = CDate(Now)
        txtDateTo.EditValue = CDate(Now)
        LoadCompany()

    End Sub

    Public Sub LoadCompany()
        LoadXgridLookupSearch("select code, Companyname as 'Select Company' from tblcompany", "tblcompany", txtCompany, gvCompany, Me)
        gvCompany.Columns("code").Visible = False
    End Sub

    Private Sub txtCompany_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompany.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCompany.Properties.View.FocusedRowHandle.ToString)
        companyid.Text = txtCompany.Properties.View.GetFocusedRowCellValue("code").ToString()
        LoadOffice()
    End Sub

    Public Sub LoadOffice()
        If companyid.Text = "" Then Exit Sub
        LoadXgridLookupSearch("select officeid, officename as 'Select Office' from tblcompoffice where companyid='" & companyid.Text & "' order by officename", "tblcompoffice", txtOffice, gridOffice, Me)
        gridOffice.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOffice.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtOffice.Properties.View.FocusedRowHandle.ToString)
        officeid.Text = txtOffice.Properties.View.GetFocusedRowCellValue("officeid").ToString()
        FilterAccountLedger()
      
    End Sub

    Public Sub FilterAccountLedger()
        Try
            If companyid.Text = "" Then Exit Sub
            LoadXgrid("select id, date_format(postingdate, '%Y-%m-%d') as 'Posting Date',(select officename from tblcompoffice where officeid=tblglticket.officeid) as 'Office',ItemCode,ItemName, DebitAmount as 'Debit',CreditAmount as 'Credit', ReferenceNo, Remarks, date_format(datetrn, '%Y-%m-%d %r') as 'Transaction Date',trnreference as 'Transaction Code', trnname as 'Transacted by', Exported, Imported from tblglticket where companyid='" & companyid.Text & "' " & If(CheckEdit1.Checked = True, "", " and officeid='" & officeid.Text & "' ") & " and date_format(postingdate, '%Y-%m-%d')  between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' order by datetrn asc", "tblglticket", Em, GridView1, Me)
            GridView1.Columns("Remarks").AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            ' GridView1.Columns("Description").ColumnEdit = MemoEdit
            GridView1.Columns("Remarks").ColumnEdit = MemoEdit

            XgridHideColumn({"id"}, GridView1)
            GridView1.BestFitColumns()
            XgridColAlign({"Posting Date", "ItemCode", "ReferenceNo", "Transaction Code", "Date Transaction"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
            XgridGroupSummaryCurrency({"Debit", "Credit"}, GridView1)
            XgridGeneralSummaryCurrency({"Debit", "Credit"}, GridView1)
            XgridColCurrency({"Debit", "Credit"}, GridView1)
            GridView1.BestFitColumns()
            'GridView1.Columns("Remarks").Width = 500
            'XgridColWidth({"Description"}, GridView1, 300)
            XgridColWidth({"Debit", "Credit"}, GridView1, 120)
            Em.Refresh() : GridView1.RefreshData()
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                            & "Module:" & "form_load" & vbCrLf _
                            & "Message:" & errMYSQL.Message & vbCrLf _
                            & "Details:" & errMYSQL.StackTrace, _
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                            & "Module:" & "form_load" & vbCrLf _
                            & "Message:" & errMS.Message & vbCrLf _
                            & "Details:" & errMS.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If GridView1.RowCount = 0 Then Exit Sub
        If GridView1.GetFocusedRowCellValue("ItemName").ToString = "" Then
            cmdChangeAccounttitle.Visible = True
            lineCorrectAccount.Visible = True
        Else
            cmdChangeAccounttitle.Visible = False
            lineCorrectAccount.Visible = False
        End If
    End Sub


    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

 
    Private Sub txtdatetrn_EditValueChanged(sender As Object, e As EventArgs) Handles txtdateFrom.EditValueChanged
        If companyid.Text <> "" Then
            FilterAccountLedger()
            txtDateTo.Properties.MinValue = txtdateFrom.EditValue
        End If
    End Sub

    Private Sub txtDateTo_EditValueChanged(sender As Object, e As EventArgs) Handles txtDateTo.EditValueChanged
        If companyid.Text <> "" Then
            FilterAccountLedger()
        End If
    End Sub

    Public Function ReadFile(ByVal path As String)
        Me.Cursor = Cursors.WaitCursor
        Dim oReader As StreamReader
        oReader = New StreamReader(path, True)
        Me.Cursor = Cursors.Default
        Return oReader.ReadToEnd
    End Function

    Private Sub RefreshLedgerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshLedgerToolStripMenuItem.Click
        FilterAccountLedger()
    End Sub

   
    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        If txtOffice.Text = "" And GridView1.RowCount = 0 Then
            XtraMessageBox.Show("Please select account!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Report File (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveFileDialog1.FileName = txtOffice.Text & " (" & ConvertDate(txtdateFrom.Text) & " to " & ConvertDate(txtDateTo.Text) & ").xlsx"
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

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            txtOffice.Enabled = False
        Else
            txtOffice.Enabled = True
        End If
        FilterAccountLedger()
    End Sub

    Private Sub CorrectAccountingTicketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdChangeAccounttitle.Click
        frmGLChangeAccountingItem.trnid.Text = GridView1.GetFocusedRowCellValue("id").ToString
        frmGLChangeAccountingItem.ShowDialog(Me)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        FilterAccountLedger()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        If txtCompany.Text = "" Then
            XtraMessageBox.Show("Please Select company!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCompany.Focus()
            Exit Sub
        End If
        Try
            Dim fbd As New System.Windows.Forms.FolderBrowserDialog
            Dim ExportDetails As String = ""
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "Ticket Report file (*.trf)|*.trf|All files (*.*)|*.*"
            saveFileDialog1.FileName = "Ticket Report file " & If(CheckEdit1.Checked = True, "", "(" & StrConv(txtOffice.Text, vbProperCase) & ") ") & ConvertDate(txtdateFrom.EditValue).ToString.Replace("-", "") & "-" & ConvertDate(txtDateTo.EditValue).ToString.Replace("-", "") & ".trf"
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                SplitContainerControl2.PanelVisibility = SplitPanelVisibility.Both
                Dim detailsFile As StreamWriter = Nothing
                ProgressBarControl1.Properties.Step = 1
                ProgressBarControl1.Properties.PercentView = True
                ProgressBarControl1.Properties.Maximum = GridView1.RowCount
                ProgressBarControl1.Properties.Minimum = 0
                ProgressBarControl1.Position = 0

                If System.IO.File.Exists(saveFileDialog1.FileName) = True Then
                    System.IO.File.Delete(saveFileDialog1.FileName)
                End If

                Dim objWriter As New System.IO.StreamWriter(saveFileDialog1.FileName)
                ExportDetails = "DELETE FROM tblglticket where companyid='" & companyid.Text & "' " & If(CheckEdit1.Checked = True, "", " and officeid='" & officeid.Text & "' ") & " and date_format(postingdate, '%Y-%m-%d')  between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' and imported=1;"
                objWriter.WriteLine(ExportDetails)
                com.CommandText = "select * from tblglticket where companyid='" & companyid.Text & "' " & If(CheckEdit1.Checked = True, "", " and officeid='" & officeid.Text & "' ") & " and date_format(postingdate, '%Y-%m-%d')  between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' order by datetrn asc" : rst = com.ExecuteReader
                While rst.Read
                    ExportDetails = "insert into tblglticket set companyid='" & rst("companyid").ToString & "', officeid='" & rst("officeid").ToString & "', postingdate='" & ConvertDate(rst("postingdate").ToString) & "', itemcode='" & rst("itemcode").ToString & "', itemname='" & rchar(rst("itemname").ToString) & "', referenceno='" & rst("referenceno").ToString & "', remarks='" & rchar(rst("remarks").ToString.Replace(vbLf, "|")) & "', debitamount='" & rst("debitamount") & "', creditamount='" & rst("creditamount") & "', debit=" & rst("debit") & ", datetrn='" & ConvertDateTime(rst("datetrn").ToString) & "', trnby='" & rst("trnby").ToString & "', trnname='" & rst("trnname").ToString & "', trnreference='" & rst("trnreference").ToString & "',imported=1;"
                    objWriter.WriteLine(ExportDetails)
                    ProgressBarControl1.PerformStep()
                    ProgressBarControl1.Update()
                End While
                rst.Close()
                objWriter.Close()
                com.CommandText = "UPDATE tblglticket set exported=true where companyid='" & companyid.Text & "' " & If(CheckEdit1.Checked = True, "", " and officeid='" & officeid.Text & "' ") & " and date_format(postingdate, '%Y-%m-%d')  between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' " : com.ExecuteNonQuery()
                FilterAccountLedger()
                XtraMessageBox.Show("Data successfully exported", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                SplitContainerControl2.PanelVisibility = SplitPanelVisibility.Panel1
            End If

        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message, vbCrLf _
                         & "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Dim sqlpath As String = ""
        Dim objOpenFileDialog As New OpenFileDialog
        'Set the Open dialog properties
        With objOpenFileDialog
            .Filter = "Ticket Report file (*.trf)|*.trf|All files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Open File Dialog"
        End With

        'Show the Open dialog and if the user clicks the Open button,
        'load the file
        If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim allText As String
            Try
                'Read the contents of the file
                allText = My.Computer.FileSystem.GetParentPath(objOpenFileDialog.FileName)
                'Display the file contents in the TextBox
                sqlpath = objOpenFileDialog.FileName
            Catch fileException As Exception
                Throw fileException
            End Try
            objOpenFileDialog.Dispose()
            objOpenFileDialog = Nothing
            If XtraMessageBox.Show("Are you sure you want to import accounting ticket report file? " & StrConv(globaluser, vbProperCase) & "@" & StrConv(globalfullname, vbProperCase) & " on " & globaldate & " - " & GlobalTime() & ") ?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If sqlpath <> "" Then
                    ReadFileGL(sqlpath)
                    frmGLImportRecords.ShowDialog(Me)
                End If
            End If
        End If
    End Sub
    Public Function ReadFileGL(ByVal path As String)
        Me.Cursor = Cursors.WaitCursor
        Dim oReader As StreamReader
        oReader = New StreamReader(path, True)
        frmGLImportRecords.txtsqlQuery.Text = oReader.ReadToEnd
        ProgressBarControl1.Visible = False
        Me.Cursor = Cursors.Default
        Return 0
    End Function
End Class