Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmApprovingProcessBatching
    Private gridsel As String = ""
    Private cpass As Boolean = False
    Private gridid As String
    Private trckdate As Date

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmBiilSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        com.CommandText = "CREATE TABLE IF NOT EXISTS `tblapproveraccounts` (  `id` int(11) NOT NULL AUTO_INCREMENT,  `applevel` varchar(5) NOT NULL,  `authcode` varchar(45) NOT NULL,  `apptitle` text NOT NULL,  `finalapp` tinyint(1) NOT NULL DEFAULT '0',  `customized` tinyint(1) NOT NULL DEFAULT '0',  `requiredattachment` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`id`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery()
        LoadPurchaseType()
        LoadClientProcessList()
        loadUserPosition()

    End Sub


    Private Sub txtClient_processType_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtClient_processType.SelectedValueChanged
        grpRequestType.Enabled = True
        If txtClient_processType.Text = "Requisition Approving Process" Then
            LoadPurchaseType()
            ckCustomizedBranch.Enabled = True
        Else
            grpRequestType.Enabled = False
            grpRequestType.Items.Clear()
        End If
    End Sub

    Private Sub ckCustomizedBranch_CheckedChanged(sender As Object, e As EventArgs) Handles ckCustomizedBranch.CheckedChanged
        If ckCustomizedBranch.Checked = True Then
            LoadCustomizedBranch()
            grpCustomBranch.Enabled = True
        Else
            grpCustomBranch.Items.Clear()
            grpCustomBranch.Enabled = False
        End If
    End Sub

#Region "Client Process"
    Public Sub LoadCustomizedBranch()
        grpCustomBranch.Items.Clear()
        com.CommandText = "select officeid, officename from tblcompoffice where custombranchapproval = 1 and deleted=0 order by officename asc" : rst = com.ExecuteReader
        While rst.Read
            grpCustomBranch.Items.Add(rst("officeid").ToString)
            grpCustomBranch.Items.Item(rst("officeid").ToString).Description = rst("officename").ToString
            grpCustomBranch.Items.Item(rst("officeid").ToString).Value = rst("officeid").ToString
        End While
        rst.Close()
    End Sub

    Public Sub LoadPurchaseType()
        grpRequestType.Items.Clear()
        com.CommandText = "select potypeid,description from tblrequesttype order by description asc" : rst = com.ExecuteReader
        While rst.Read
            grpRequestType.Items.Add(rst("potypeid").ToString)
            grpRequestType.Items.Item(rst("potypeid").ToString).Description = rst("description").ToString
            grpRequestType.Items.Item(rst("potypeid").ToString).Value = rst("potypeid").ToString
        End While
        rst.Close()
    End Sub

    Public Sub LoadClientProcessList()
        LoadXgrid("select id,authcode, applevel as 'Level', apptitle as 'Title', (select authDescription from tbluserauthority where authCode = a.authcode) as 'Authorize Approver' ,finalapp as 'Final Approver',requiredattachment as 'Required Attachment' from tblapproveraccounts as a order by applevel asc", "tblapproveraccounts", Em_client, gv_clientProcess, Me)
        gv_clientProcess.Columns("id").Visible = False
        gv_clientProcess.Columns("authcode").Visible = False
        XgridColAlign({"Level"}, gv_clientProcess, DevExpress.Utils.HorzAlignment.Center)
        gv_clientProcess.BestFitColumns()
    End Sub
    Public Sub loadUserPosition()
        LoadXgridLookupEdit("select authcode, authDescription as 'Position' from tbluserauthority order by authDescription asc", "tbluserauthority", txtUserPosition, gv_clientUserPosition, Me)
        gv_clientUserPosition.Columns("authcode").Visible = False
    End Sub

    Private Sub txtUserPosition_EditValueChanged(sender As Object, e As EventArgs) Handles txtUserPosition.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtUserPosition.Properties.View.FocusedRowHandle.ToString)
        authCode.Text = txtUserPosition.Properties.View.GetFocusedRowCellValue("authcode").ToString()
        txtUserPosition.Text = txtUserPosition.Properties.View.GetFocusedRowCellValue("Position").ToString()
    End Sub
    Private Sub cmdClientSave_Click(sender As Object, e As EventArgs) Handles cmdClientSave.Click

        If txtClient_level.Text = "" Then
            XtraMessageBox.Show("Please select account level!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtClient_level.Focus()
            Exit Sub
        ElseIf txtUserPosition.Text = "" Then
            XtraMessageBox.Show("Please select user position!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUserPosition.Focus()
            Exit Sub
        ElseIf txtClient_AppTitle.Text = "" Then
            XtraMessageBox.Show("Please select approver title!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtClient_AppTitle.Focus()
            Exit Sub
        ElseIf ckCustomizedBranch.Checked = True And grpCustomBranch.Text = "" Then
            XtraMessageBox.Show("Please select custom office approving!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If client_mode.Text = "edit" Then
            com.CommandText = "update tblapproveraccounts set authcode='" & authCode.Text & "',apptitle='" & rchar(txtClient_AppTitle.Text) & "', APPLEVEL='" & txtClient_level.Text & "', FINALAPP=" & ckClient_FinalApprover.CheckState & ", requiredattachment=" & ckRequireAttachment.CheckState & " where id='" & client_id.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblapproveraccounts set authcode='" & authCode.Text & "',apptitle='" & rchar(txtClient_AppTitle.Text) & "', APPLEVEL='" & txtClient_level.Text & "', FINALAPP=" & ckClient_FinalApprover.CheckState & ", requiredattachment=" & ckRequireAttachment.CheckState & "" : com.ExecuteNonQuery()
        End If
        ClearClientField() : LoadClientProcessList()
        XtraMessageBox.Show("Account for approver successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Dim Rows() As DataRow : Dim I As Integer : Dim todelete As String = ""
        If XtraMessageBox.Show("Are you sure you want to remove selected item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            ReDim Rows(gv_clientProcess.SelectedRowsCount - 1)
            For I = 0 To gv_clientProcess.SelectedRowsCount - 1
                Rows(I) = gv_clientProcess.GetDataRow(gv_clientProcess.GetSelectedRows(I))
                todelete = gv_clientProcess.GetRowCellValue(gv_clientProcess.GetSelectedRows(I), "id").ToString
                com.CommandText = "delete from tblapproveraccounts where id='" & todelete & "'" : com.ExecuteNonQuery()
            Next
            LoadClientProcessList()
        End If
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmCoffeecupClientPermission.Visible = True Then
            frmCoffeecupClientPermission.Focus()
        Else
            frmCoffeecupClientPermission.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        ClearClientField()
    End Sub
    Public Sub ClearClientField()
        txtClient_level.SelectedIndex = -1
        txtUserPosition.Properties.DataSource = Nothing
        txtUserPosition.Text = ""
        loadUserPosition()

        txtClient_AppTitle.Text = ""
        client_mode.Text = ""
        authCode.Text = ""
        ckClient_FinalApprover.Checked = False
        LoadClientProcessList()
    End Sub

#End Region

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If XtraMessageBox.Show("Are you sure you want to Continue? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If ckCustomizedBranch.Checked = True Then
                If grpCustomBranch.CheckedItemsCount > 0 Then
                    For br = 0 To grpCustomBranch.CheckedItems.Count - 1
                        If grpRequestType.CheckedItemsCount > 0 Then
                            For r = 0 To grpRequestType.CheckedItems.Count - 1
                                'com.CommandText = "DELETE FROM tblapproverclientprocess where apptype='" & LCase(txtClient_processType.Text.Replace(" ", "-")) & "' and requestcode='" & grpRequestType.Items.Item(grpRequestType.CheckedItems.Item(r)).Value & "' and customized=" & ckCustomizedBranch.CheckState & "" : com.ExecuteNonQuery()
                                For I = 0 To gv_clientProcess.RowCount - 1
                                    com.CommandText = "insert into tblapproverclientprocess set apptype='" & LCase(txtClient_processType.Text.Replace(" ", "-")) & "',requestcode='" & grpRequestType.Items.Item(grpRequestType.CheckedItems.Item(r)).Value & "', authcode='" & gv_clientProcess.GetRowCellValue(I, "authcode").ToString & "',apptitle='" & gv_clientProcess.GetRowCellValue(I, "Title").ToString & "', APPLEVEL='" & gv_clientProcess.GetRowCellValue(I, "Level").ToString & "', FINALAPP=" & CBool(gv_clientProcess.GetRowCellValue(I, "Final Approver").ToString) & ",customized=" & ckCustomizedBranch.CheckState & ",officeid='" & grpCustomBranch.Items.Item(grpCustomBranch.CheckedItems.Item(br)).Value & "',requiredattachment=" & CBool(gv_clientProcess.GetRowCellValue(I, "Required Attachment").ToString) & "" : com.ExecuteNonQuery()
                                Next
                            Next
                        Else
                            'com.CommandText = "DELETE FROM tblapproverclientprocess where apptype='" & LCase(txtClient_processType.Text.Replace(" ", "-")) & "' and customized=" & ckCustomizedBranch.CheckState & "" : com.ExecuteNonQuery()
                            For I = 0 To gv_clientProcess.RowCount - 1
                                com.CommandText = "insert into tblapproverclientprocess set apptype='" & LCase(txtClient_processType.Text.Replace(" ", "-")) & "',requestcode='', authcode='" & gv_clientProcess.GetRowCellValue(I, "authcode").ToString & "',apptitle='" & gv_clientProcess.GetRowCellValue(I, "Title").ToString & "', APPLEVEL='" & gv_clientProcess.GetRowCellValue(I, "Level").ToString & "', FINALAPP=" & CBool(gv_clientProcess.GetRowCellValue(I, "Final Approver").ToString) & ",customized=" & ckCustomizedBranch.CheckState & ",officeid='" & grpCustomBranch.Items.Item(grpCustomBranch.CheckedItems.Item(br)).Value & "',requiredattachment=" & CBool(gv_clientProcess.GetRowCellValue(I, "Required Attachment").ToString) & "" : com.ExecuteNonQuery()
                            Next
                        End If
                    Next
                End If
            Else
                If grpRequestType.CheckedItemsCount > 0 Then
                    For r = 0 To grpRequestType.CheckedItems.Count - 1
                        'com.CommandText = "DELETE FROM tblapproverclientprocess where apptype='" & LCase(txtClient_processType.Text.Replace(" ", "-")) & "' and requestcode='" & grpRequestType.Items.Item(grpRequestType.CheckedItems.Item(r)).Value & "' and customized=" & ckCustomizedBranch.CheckState & "" : com.ExecuteNonQuery()
                        For I = 0 To gv_clientProcess.RowCount - 1
                            com.CommandText = "insert into tblapproverclientprocess set apptype='" & LCase(txtClient_processType.Text.Replace(" ", "-")) & "',requestcode='" & grpRequestType.Items.Item(grpRequestType.CheckedItems.Item(r)).Value & "', authcode='" & gv_clientProcess.GetRowCellValue(I, "authcode").ToString & "',apptitle='" & gv_clientProcess.GetRowCellValue(I, "Title").ToString & "', APPLEVEL='" & gv_clientProcess.GetRowCellValue(I, "Level").ToString & "', FINALAPP=" & CBool(gv_clientProcess.GetRowCellValue(I, "Final Approver").ToString) & ",customized=" & ckCustomizedBranch.CheckState & ",officeid='',requiredattachment=" & CBool(gv_clientProcess.GetRowCellValue(I, "Required Attachment").ToString) & "" : com.ExecuteNonQuery()
                        Next
                    Next
                Else
                    'com.CommandText = "DELETE FROM tblapproverclientprocess where apptype='" & LCase(txtClient_processType.Text.Replace(" ", "-")) & "' and customized=" & ckCustomizedBranch.CheckState & "" : com.ExecuteNonQuery()
                    For I = 0 To gv_clientProcess.RowCount - 1
                        com.CommandText = "insert into tblapproverclientprocess set apptype='" & LCase(txtClient_processType.Text.Replace(" ", "-")) & "',requestcode='', authcode='" & gv_clientProcess.GetRowCellValue(I, "authcode").ToString & "',apptitle='" & gv_clientProcess.GetRowCellValue(I, "Title").ToString & "', APPLEVEL='" & gv_clientProcess.GetRowCellValue(I, "Level").ToString & "', FINALAPP=" & CBool(gv_clientProcess.GetRowCellValue(I, "Final Approver").ToString) & ",customized=" & ckCustomizedBranch.CheckState & ",officeid='',requiredattachment=" & CBool(gv_clientProcess.GetRowCellValue(I, "Required Attachment").ToString) & "" : com.ExecuteNonQuery()
                    Next
                End If
            End If

            XtraMessageBox.Show("Account for approver successfully uploaded!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub EditApproverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditApproverToolStripMenuItem.Click
        com.CommandText = "select *,(select authDescription from tbluserauthority where authCode = tblapproveraccounts.authcode) as 'userposition' " _
               + " from tblapproveraccounts where id='" & gv_clientProcess.GetFocusedRowCellValue("id").ToString() & "'" : rst = com.ExecuteReader
        While rst.Read
            client_id.Text = rst("id").ToString
            txtClient_level.Text = rst("applevel").ToString
            txtUserPosition.Text = rst("userposition").ToString
            txtClient_AppTitle.Text = rst("apptitle").ToString
            authCode.Text = rst("authcode").ToString
            ckClient_FinalApprover.Checked = rst("FINALAPP")
            ckRequireAttachment.Checked = rst("requiredattachment")
        End While
        rst.Close()
        client_mode.Text = "" : client_mode.Text = "edit"
    End Sub
End Class