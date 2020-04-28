Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraSplashScreen

Public Class frmPayrollCaptureAttendance
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPayrollPeriod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadPayrollCode()
        txtDescription.Text = GlobalBimetricModel
    End Sub

    Public Sub LoadPayrollCode()
        LoadXgridLookupEdit("select payrollcode as 'Payroll Code', date_format(datefrom,'%Y-%m-%d') as 'Period From', date_format(dateto,'%Y-%m-%d') as 'Period To' from tblpayrollperiod where computeattendance=1 and approved=0 order by datefrom asc", "tblpayrollperiod", txtPayrollCode, gv_scheduletype, Me)
        gv_scheduletype.BestFitColumns()
        gv_scheduletype.Columns("Payroll Code").Width = 120
    End Sub
    Private Sub txtPayrollCode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPayrollCode.EditValueChanged
        On Error Resume Next
        payrollcode.Text = txtPayrollCode.Properties.View.GetFocusedRowCellValue("Payroll Code").ToString
        com.CommandText = "select *,(select description from tblpayrollschedule where code=tblpayrollperiod.schedulecode) as 'schedule' from tblpayrollperiod where payrollcode='" & payrollcode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            payrollcode.Text = rst("payrollcode")
            txtPeriodFrom.EditValue = CDate(rst("datefrom").ToString)
            txtPeriodTo.EditValue = CDate(rst("dateto").ToString)
        End While
        rst.Close()
    End Sub

    Private Sub cmdCapture_Click(sender As Object, e As EventArgs) Handles cmdCapture.Click
        If radSelectAttendance.SelectedIndex = 0 Then
            ProgressBarControl1.Visible = True
            Me.Height = Me.Height + 10
            If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                'SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
                com.CommandText = "DROP temporary table if exists tmpAttendanceLog;" : com.ExecuteNonQuery()
                com.CommandText = "CREATE temporary table tmpAttendanceLog select * from tblpayrollattendancelog where logindate between '" & ConvertDate(txtPeriodFrom.EditValue) & "' and '" & ConvertDate(txtPeriodTo.EditValue) & "' order by logindate asc" : com.ExecuteNonQuery()
                com.CommandText = "ALTER TABLE `tmpAttendanceLog` ADD INDEX `employeeid`(`employeeid`), ADD INDEX `logindate`(`logindate`);" : com.ExecuteNonQuery()

                com.CommandText = "DROP temporary table if exists tmpAttendanceLogApproved " : com.ExecuteNonQuery()
                com.CommandText = "CREATE temporary table tmpAttendanceLogApproved  select employeeid from tblpayrollattendance where payrollcode='" & payrollcode.Text & "' and approved=1" : com.ExecuteNonQuery()
                com.CommandText = "ALTER TABLE `tmpAttendanceLogApproved`  ADD INDEX `employeeid`(`employeeid`);" : com.ExecuteNonQuery()

                ProgressBarControl1.Properties.Step = 1
                ProgressBarControl1.Properties.PercentView = True
                ProgressBarControl1.Properties.Minimum = 0
                ProgressBarControl1.Position = 0
                dst = New DataSet
                msda = New MySqlDataAdapter("select * from tmpAttendanceLog where employeeid not in (select employeeid from tmpAttendanceLogApproved) order by logindate asc", conn)
                msda.Fill(dst, 0)
                ProgressBarControl1.Properties.Maximum = dst.Tables(0).Rows.Count - 1
                For cnt = 0 To dst.Tables(0).Rows.Count - 1
                    With (dst.Tables(0))
                        'com.CommandText = "update tblpayrollattendance set " & If(.Rows(cnt)("shiftcode").ToString() = "", "", " shiftcode='" & .Rows(cnt)("shiftcode").ToString() & "', ") & " halfday=" & If((.Rows(cnt)("1st_timein").ToString() = "" And .Rows(cnt)("1st_timeout").ToString() = "") Or (.Rows(cnt)("2nd_timein").ToString() = "" And .Rows(cnt)("2nd_timeout").ToString() = ""), "1", "0") & ", " _
                        com.CommandText = "update tblpayrollattendance set " & If(.Rows(cnt)("shiftcode").ToString() = "", "", " shiftcode='" & .Rows(cnt)("shiftcode").ToString() & "', ") & " halfday=" & If((.Rows(cnt)("1st_timein").ToString() = "" And .Rows(cnt)("1st_timeout").ToString() = "") Or (.Rows(cnt)("2nd_timein").ToString() = "" And .Rows(cnt)("2nd_timeout").ToString() = ""), "0", "0") & ", " _
                                        + " 1st_timein=" & If(.Rows(cnt)("1st_timein").ToString() = "", "null", "'" & ConvertServerTime(.Rows(cnt)("1st_timein").ToString()) & "'") & ", " _
                                        + " 1st_timeout=" & If(.Rows(cnt)("1st_timeout").ToString() = "", "null", "'" & ConvertServerTime(.Rows(cnt)("1st_timeout").ToString()) & "'") & ", " _
                                        + " 2nd_timein=" & If(.Rows(cnt)("2nd_timein").ToString() = "", "null", "'" & ConvertServerTime(.Rows(cnt)("2nd_timein").ToString()) & "'") & ", " _
                                        + " 2nd_timeout=" & If(.Rows(cnt)("2nd_timeout").ToString() = "", "null", "'" & ConvertServerTime(.Rows(cnt)("2nd_timeout").ToString()) & "'") & ", " _
                                        + " 3rd_timein=" & If(.Rows(cnt)("3rd_timein").ToString() = "", "null", "'" & ConvertServerTime(.Rows(cnt)("3rd_timein").ToString()) & "'") & ", " _
                                        + " 3rd_timeout=" & If(.Rows(cnt)("3rd_timeout").ToString() = "", "null", "'" & ConvertServerTime(.Rows(cnt)("3rd_timeout").ToString()) & "'") & "  " _
                                        + " where payrollcode='" & payrollcode.Text & "' and employeeid='" & .Rows(cnt)("employeeid").ToString() & "' and attendancedate='" & ConvertDate(.Rows(cnt)("logindate").ToString()) & "'" : com.ExecuteNonQuery()
                        com.CommandText = "CALL sp_payrollcomputeattendance(TRUE,'" & payrollcode.Text & "','" & .Rows(cnt)("employeeid").ToString() & "')" : com.ExecuteNonQuery()
                        ProgressBarControl1.PerformStep()
                        ProgressBarControl1.Update()
                    End With
                Next
                'SplashScreenManager.CloseForm()
                ProgressBarControl1.Update()
                ProgressBarControl1.Refresh()

                ProgressBarControl1.Properties.Step = 1
                ProgressBarControl1.Properties.PercentView = True
                ProgressBarControl1.Properties.Minimum = 0
                ProgressBarControl1.Position = 0
                st = New DataSet
                da = New MySqlDataAdapter("select distinct employeeid from tblpayrollattendance where payrollcode='" & payrollcode.Text & "' and approved=0", conn)
                da.Fill(st, 0)
                ProgressBarControl1.Properties.Maximum = st.Tables(0).Rows.Count - 1
                For cnt = 0 To st.Tables(0).Rows.Count - 1
                    With (st.Tables(0))
                        com.CommandText = "UPDATE tblpayrollattendance set absent=1,1st_timein=null,1st_timeout=null,2nd_timein=null,2nd_timeout=null,3rd_timein=null,3rd_timeout=null where attendancedate not in (select logindate from tmpAttendanceLog where employeeid='" & .Rows(cnt)("employeeid").ToString() & "') and employeeid='" & .Rows(cnt)("employeeid").ToString() & "' and payrollcode='" & payrollcode.Text & "' and regularday=1" : com.ExecuteNonQuery()
                        ProgressBarControl1.PerformStep()
                        ProgressBarControl1.Update()
                    End With
                Next
                'SplashScreenManager.CloseForm()
                ProgressBarControl1.Update()
                ProgressBarControl1.Refresh()

                ProgressBarControl1.Visible = False
                XtraMessageBox.Show("Attendance successfuly captured!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.Height = Me.Height - 10
            ProgressBarControl1.Visible = False
        Else
            XtraMessageBox.Show("Invalid biometric file format!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub txtFilePath_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtFilePath.ButtonClick
        Dim objOpenFileDialog As New OpenFileDialog
        'Set the Open dialog properties
        With objOpenFileDialog
            .Filter = GlobalFiletypeSupport
            .FilterIndex = 1
            .Title = "Open File Dialog"
        End With

        'Show the Open dialog and if the user clicks the Open button,
        'load the file
        If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                'Read the contents of the file
                txtFilePath.Text = objOpenFileDialog.FileName
                'Display the file contents in the TextBox
            Catch fileException As Exception
                Throw fileException
            End Try
            objOpenFileDialog.Dispose()
            objOpenFileDialog = Nothing
        End If
    End Sub

    Private Sub radSelectAttendance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radSelectAttendance.SelectedIndexChanged
        If radSelectAttendance.SelectedIndex = 0 Then
            txtDescription.Enabled = False
            txtFilePath.Enabled = False
        Else
            txtDescription.Enabled = True
            txtFilePath.Enabled = True
        End If
    End Sub
End Class