Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmProductTemplate1
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmParticularInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)

        If mode.Text <> "edit" Then
            productid.Text = getproid()
        End If
        LoadCategory()
        LoadToComboBox("unit", "tblglobalproducts", txtUnit, True)
        LoadGridviewAppearance(combogrid)

    End Sub

    Public Sub LoadCategory()
        LoadXgridLookupEdit("select CATID,DESCRIPTION 'Select Category' from tblprocategory order by DESCRIPTION asc", "tblprocategory", txtprocat, combogrid, Me)
        combogrid.Columns("CATID").Visible = False
    End Sub

    Private Sub txtprocat_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprocat.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtprocat.Properties.View.FocusedRowHandle.ToString)
        catid.Text = txtprocat.Properties.View.GetFocusedRowCellValue("CATID").ToString()
        txtprocat.Text = txtprocat.Properties.View.GetFocusedRowCellValue("Select Category").ToString()
        txtitem.Focus()

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveParticular.Click
        If productid.Text = "" Then
            XtraMessageBox.Show("Please enter itemcode!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            productid.Focus()
            Exit Sub
        ElseIf productid.Text.Contains(" ") = True And mode.Text <> "edit" Then
            XtraMessageBox.Show("Please enter itemcode without space!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            productid.Focus()
            Exit Sub
        ElseIf txtprocat.Text = "" Then
            XtraMessageBox.Show("Please select category!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtprocat.Focus()
            Exit Sub
        ElseIf txtitem.Text = "" Then
            XtraMessageBox.Show("Please provide particular name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtitem.Focus()
            Exit Sub
        ElseIf txtUnit.Text = "" Then
            XtraMessageBox.Show("Please select unit!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUnit.Focus()
            Exit Sub
        ElseIf countqry("tblglobalproducts", "itemname='" & rchar(txtitem.Text) & "' and unit='" & txtUnit.Text & "'  and productid<>'" & productid.Text & "' and deleted=0") > 0 Then
            XtraMessageBox.Show("Duplicate particular item name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtitem.SelectAll()
            txtitem.Focus()
            Exit Sub
        End If

        UpdateDefaultProductInformation(mode.Text, productid.Text, catid.Text, rchar(txtitem.Text), txtUnit.Text)
        UpdateInventoryInfo(productid.Text, txtitem.Text, catid.Text, txtUnit.Text, 0)

        clearfields()
        XtraMessageBox.Show("Product successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub clearfields()
        productid.Text = getproid()
        txtitem.Text = ""
        mode.Text = ""
        ' LoadCategory()
    End Sub


    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        Dim procat As String = ""
        com.CommandText = "select *, case when purchasedprice = 0 then (select procost from tblitemvendor where itemid = tblglobalproducts.productid order by lastupdate desc limit 1) else purchasedprice end as 'purchasedcost', " _
                            + " (select description from tblprocategory where catid = tblglobalproducts.catid) as catproduct  from tblglobalproducts where productid='" & productid.Text & "' and actived=1"
        rst = com.ExecuteReader
        While rst.Read
            procat = rst("catproduct").ToString
            catid.Text = rst("catid").ToString
            txtitem.Text = rst("itemname").ToString
            txtUnit.Text = rst("unit").ToString
        End While
        rst.Close()
        txtprocat.Text = procat
    End Sub

    Private Sub txtitem_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtitem.GotFocus
        Me.AcceptButton = cmdSaveParticular
    End Sub

    Private Sub id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles productid.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtprocat.Text = "" Then
                txtprocat.Focus()
            Else
                txtitem.Focus()
            End If
        End If
    End Sub

    Private Sub txtitem_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtitem.LostFocus
        Me.AcceptButton = Nothing
    End Sub

    Private Sub ckUnit_CheckedChanged(sender As Object, e As EventArgs) Handles ckUnit.CheckedChanged
        If ckUnit.Checked = True Then
            txtUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Else
            txtUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        End If
    End Sub
  
End Class