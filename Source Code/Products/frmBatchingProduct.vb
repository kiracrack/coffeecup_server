Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmBatchingProduct
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmBatchingProduct_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmBatchingProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        PopulateGridViewControls("Product Name", 50, "", dgv, True, True)
        loadBrand()
        loadColor()
        loadSize()
    End Sub
    Private Sub txtitem_EditValueChanged(sender As Object, e As EventArgs) Handles txtitem.EditValueChanged
        loadPreview()
    End Sub

#Region "BRAND OPTION"
    Public Sub loadBrand()
        list_brand.Items.Clear()
        com.CommandText = "select * from tblproductbatchoption where optiontype='BRAND' and catid='" & catid.Text & "' order by description asc" : rst = com.ExecuteReader
        While rst.Read
            list_brand.Items.Add(rst("id").ToString, False)
            list_brand.Items.Item(rst("id").ToString).Description = rst("description").ToString
            list_brand.Items.Item(rst("id").ToString).Value = rst("id").ToString
        End While
        rst.Close()
    End Sub

    Private Sub txtAddBrand_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtaddBrand.KeyPress
        If txtaddBrand.Text = "" Then Exit Sub
        If e.KeyChar() = Chr(13) Then
            If brand.Text = "" Then
                If countqry("tblproductbatchoption", "optiontype='BRAND' and catid='" & catid.Text & "' and description='" & rchar(txtaddBrand.Text) & "'") > 0 Then
                    XtraMessageBox.Show("Brand name already exists!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtaddBrand.Focus()
                    Exit Sub
                End If
                com.CommandText = "insert into tblproductbatchoption set optiontype='BRAND', catid='" & catid.Text & "', description='" & rchar(txtaddBrand.Text) & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "UPDATE tblproductbatchoption set description='" & rchar(txtaddBrand.Text) & "' where id='" & brand.Text & "'" : com.ExecuteNonQuery()
            End If
            txtaddBrand.Text = "" : brand.Text = "" : txtaddBrand.Focus()
            loadBrand()
        End If
    End Sub

    Private Sub cmdbrandEdit_Click(sender As Object, e As EventArgs) Handles cmdBrandEdit.Click
        brand.Text = list_brand.SelectedValue
        txtaddBrand.Text = list_brand.Items.Item(list_brand.SelectedValue).Description
    End Sub

    Private Sub cmdbrandDelete_Click(sender As Object, e As EventArgs) Handles cmdBrandDelete.Click
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "DELETE FROM tblproductbatchoption where id='" & list_brand.SelectedValue & "'" : com.ExecuteNonQuery()
            loadBrand()
        End If
    End Sub
    Private Sub cmdBrandRefresh_Click(sender As Object, e As EventArgs) Handles cmdBrandRefresh.Click
        loadBrand()
    End Sub

    Private Sub list_brand_ItemCheck(sender As Object, e As Controls.ItemCheckEventArgs) Handles list_brand.ItemCheck
        loadPreview()
    End Sub
    Private Sub ckAllBrand_CheckedChanged(sender As Object, e As EventArgs) Handles ckAllBrand.CheckedChanged
        For n = 0 To list_brand.ItemCount - 1
            If ckAllBrand.Checked = True Then
                list_brand.Items.Item(n).CheckState = CheckState.Checked
            Else
                list_brand.Items.Item(n).CheckState = CheckState.Unchecked
            End If
        Next
        loadPreview()
    End Sub
#End Region

#Region "COLOR OPTION"
    Public Sub loadColor()
        list_color.Items.Clear()
        com.CommandText = "select * from tblproductbatchoption where optiontype='COLOR' and catid='" & catid.Text & "' order by description asc" : rst = com.ExecuteReader
        While rst.Read
            list_color.Items.Add(rst("id").ToString, False)
            list_color.Items.Item(rst("id").ToString).Description = rst("description").ToString
            list_color.Items.Item(rst("id").ToString).Value = rst("id").ToString
        End While
        rst.Close()
    End Sub

    Private Sub txtAddColor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddColor.KeyPress
        If txtAddColor.Text = "" Then Exit Sub
        If e.KeyChar() = Chr(13) Then
            If color.Text = "" Then
                If countqry("tblproductbatchoption", "optiontype='COLOR' and catid='" & catid.Text & "' and description='" & rchar(txtAddColor.Text) & "'") > 0 Then
                    XtraMessageBox.Show("Color name already exists!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtAddColor.Focus()
                    Exit Sub
                End If
                com.CommandText = "insert into tblproductbatchoption set optiontype='COLOR',catid='" & catid.Text & "', description='" & rchar(txtAddColor.Text) & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "UPDATE tblproductbatchoption set description='" & rchar(txtAddColor.Text) & "' where id='" & color.Text & "'" : com.ExecuteNonQuery()
            End If

            txtAddColor.Text = "" : color.Text = "" : txtAddColor.Focus()
            loadColor()
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        color.Text = list_color.SelectedValue
        txtAddColor.Text = list_color.Items.Item(list_color.SelectedValue).Description
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "DELETE FROM tblproductbatchoption where id='" & list_color.SelectedValue & "'" : com.ExecuteNonQuery()
            loadColor()
        End If
    End Sub
    Private Sub cmdColorRefresh_Click(sender As Object, e As EventArgs) Handles cmdColorRefresh.Click
        loadColor()
    End Sub

    Private Sub list_color_ItemCheck(sender As Object, e As Controls.ItemCheckEventArgs) Handles list_color.ItemCheck
        loadPreview()
    End Sub
    Private Sub ckAllColor_CheckedChanged(sender As Object, e As EventArgs) Handles ckAllColor.CheckedChanged
        For n = 0 To list_color.ItemCount - 1
            If ckAllColor.Checked = True Then
                list_color.Items.Item(n).CheckState = CheckState.Checked
            Else
                list_color.Items.Item(n).CheckState = CheckState.Unchecked
            End If
        Next
        loadPreview()
    End Sub
#End Region

#Region "SIZE OPTION"
    Public Sub loadSize()
        list_size.Items.Clear()
        com.CommandText = "select * from tblproductbatchoption where optiontype='SIZE' and catid='" & catid.Text & "' order by description asc" : rst = com.ExecuteReader
        While rst.Read
            list_size.Items.Add(rst("id").ToString, False)
            list_size.Items.Item(rst("id").ToString).Description = rst("description").ToString
            list_size.Items.Item(rst("id").ToString).Value = rst("id").ToString
        End While
        rst.Close()
    End Sub

    Private Sub txtAddSize_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddSize.KeyPress
        If txtAddSize.Text = "" Then Exit Sub
        If e.KeyChar() = Chr(13) Then
            If size.Text = "" Then
                If countqry("tblproductbatchoption", "optiontype='SIZE' and catid='" & catid.Text & "' and description='" & rchar(txtAddSize.Text) & "'") > 0 Then
                    XtraMessageBox.Show("Size name already exists!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtAddSize.Focus()
                    Exit Sub
                End If
                com.CommandText = "insert into tblproductbatchoption set optiontype='SIZE',catid='" & catid.Text & "', description='" & rchar(txtAddSize.Text) & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "UPDATE tblproductbatchoption set description='" & rchar(txtAddSize.Text) & "' where id='" & size.Text & "'" : com.ExecuteNonQuery()
            End If
            txtAddSize.Text = "" : size.Text = "" : txtAddSize.Focus()
            loadSize()
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles cmdEditSize.Click
        size.Text = list_size.SelectedValue
        txtAddSize.Text = list_size.Items.Item(list_size.SelectedValue).Description
    End Sub


    Private Sub cmdRemoveSize_Click(sender As Object, e As EventArgs) Handles cmdRemoveSize.Click
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "DELETE FROM tblproductbatchoption where id='" & list_size.SelectedValue & "'" : com.ExecuteNonQuery()
            loadSize()
        End If
    End Sub
    Private Sub cmdSizeRefresh_Click(sender As Object, e As EventArgs) Handles cmdSizeRefresh.Click
        loadSize()
    End Sub
    Private Sub list_size_ItemCheck(sender As Object, e As Controls.ItemCheckEventArgs) Handles list_size.ItemCheck
        loadPreview()
    End Sub
    Private Sub ckAllSize_CheckedChanged(sender As Object, e As EventArgs) Handles ckAllSize.CheckedChanged
        For n = 0 To list_size.ItemCount - 1
            If ckAllSize.Checked = True Then
                list_size.Items.Item(n).CheckState = CheckState.Checked
            Else
                list_size.Items.Item(n).CheckState = CheckState.Unchecked
            End If
        Next
        loadPreview()
    End Sub
#End Region

    Public Sub loadPreview()
        dgv.Rows.Clear()
        If list_brand.CheckedItemsCount > 0 Then
            For b = 0 To list_brand.CheckedItems.Count - 1
                If list_color.CheckedItemsCount > 0 Then
                    For n = 0 To list_color.CheckedItems.Count - 1
                        If list_size.CheckedItemsCount > 0 Then
                            For s = 0 To list_size.CheckedItems.Count - 1
                                dgv.Rows.Add(txtitem.Text & " " & UCase(list_brand.Items.Item(list_brand.CheckedItems.Item(b)).Description) & " " & UCase(list_color.Items.Item(list_color.CheckedItems.Item(n)).Description) & " - " & UCase(list_size.Items.Item(list_size.CheckedItems.Item(s)).Description))
                            Next
                        Else
                            dgv.Rows.Add(txtitem.Text & " " & UCase(list_brand.Items.Item(list_brand.CheckedItems.Item(b)).Description) & " " & UCase(list_color.Items.Item(list_color.CheckedItems.Item(n)).Description))
                        End If
                    Next
                Else
                    If list_size.CheckedItemsCount > 0 Then
                        For s = 0 To list_size.CheckedItems.Count - 1
                            dgv.Rows.Add(txtitem.Text & " " & UCase(list_brand.Items.Item(list_brand.CheckedItems.Item(b)).Description) & " - " & UCase(list_size.Items.Item(list_size.CheckedItems.Item(s)).Description))
                        Next
                    Else
                         dgv.Rows.Add(txtitem.Text & " " & UCase(list_brand.Items.Item(list_brand.CheckedItems.Item(b)).Description))
                    End If
                End If
            Next
        Else
            If list_color.CheckedItemsCount > 0 Then
                For n = 0 To list_color.CheckedItems.Count - 1
                    If list_size.CheckedItemsCount > 0 Then
                        For s = 0 To list_size.CheckedItems.Count - 1
                            dgv.Rows.Add(txtitem.Text & " " & UCase(list_color.Items.Item(list_color.CheckedItems.Item(n)).Description) & " - " & UCase(list_size.Items.Item(list_size.CheckedItems.Item(s)).Description))
                        Next
                    Else
                        dgv.Rows.Add(txtitem.Text & " " & UCase(list_color.Items.Item(list_color.CheckedItems.Item(n)).Description))
                    End If
                Next
            Else
                If list_size.CheckedItemsCount > 0 Then
                    For s = 0 To list_size.CheckedItems.Count - 1
                        dgv.Rows.Add(txtitem.Text & " - " & UCase(list_size.Items.Item(list_size.CheckedItems.Item(s)).Description))
                    Next
                End If
            End If
        End If
        If dgv.RowCount > 0 Then
            cmdUpload.Enabled = True
        Else
            cmdUpload.Enabled = False
        End If
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdUpload.ItemClick
        Dim duplicate As Boolean = False
        Me.Cursor = Cursors.WaitCursor
        com.CommandText = "drop temporary table if exists tmpproductbatch" : com.ExecuteNonQuery()
        com.CommandText = "CREATE temporary TABLE tmpproductbatch(  `productname` VARCHAR(200) NOT NULL,  PRIMARY KEY (`productname`)) ENGINE = InnoDB;" : com.ExecuteNonQuery()
        For I = 0 To dgv.RowCount - 1
            com.CommandText = "insert into tmpproductbatch set productname='" & rchar(dgv.Item("Product Name", I).Value) & "'" : com.ExecuteNonQuery()
        Next
        If countqry("tblglobalproducts", " itemname in (select productname from tmpproductbatch) and deleted=0") > 0 Then
            MessageBox.Show("Some product item already exists", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Me.Cursor = Cursors.Default
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmProductTemplate2.UploadBatchRegistration(dgv)
            Me.Close()
        End If
    End Sub
End Class

