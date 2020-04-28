Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmStockoutQuantity
    Private cost
    Private total
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
   
    Private Sub frmStockoutQuantity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
    End Sub

    Private Sub stockid_EditValueChanged(sender As Object, e As EventArgs) Handles stockid.EditValueChanged
        ShowStockInfo()
    End Sub
    Public Sub ShowStockInfo()
        com.CommandText = "select * from tblinventory where trnid='" & stockid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            Me.Text = rst("productname").ToString
            officeid.Text = rst("officeid").ToString
            txtproduct.Text = rst("productname").ToString
            productid.Text = rst("productid").ToString
            catid.Text = rst("catid").ToString
            txtUnitCost.Text = FormatNumber(rst("purchasedprice").ToString, 3)
            txtAvailableQuantity.Text = rst("quantity").ToString
            txtquantity.Text = rst("quantity").ToString
            txtunit.Text = rst("unit").ToString
        End While
        rst.Close()
    End Sub
  
    Private Sub cmdSetQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAction.Click
        Dim tempQry As String = ""
        If txtquantity.Text = "" Or Val(CC(txtquantity.Text)) < 1 Then
            XtraMessageBox.Show("Please enter valid quantity!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtquantity.Focus()
            Exit Sub
        ElseIf Val(CC(txtquantity.Text)) > Val(CC(txtAvailableQuantity.Text)) Then
            XtraMessageBox.Show("Maximum quantity is " & txtAvailableQuantity.Text & "!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtquantity.Focus()
            Exit Sub
       
        End If
        com.CommandText = "insert into tblstockoutitem set " _
                                  + " batchcode='', " _
                                  + " postingdate='" & ConvertDate(frmStockoutBatchRequest.txtDateStockout.EditValue) & "', " _
                                  + " officeid='" & officeid.Text & "', " _
                                  + " refcode='" & stockid.Text & "', " _
                                  + " productid='" & productid.Text & "', " _
                                  + " catid='" & catid.Text & "', " _
                                  + " quantity='" & Val(CC(txtquantity.Text)) & "', " _
                                  + " purchasedprice='" & Val(CC(txtUnitCost.Text)) & "', " _
                                  + " unit='" & txtunit.Text & "', " _
                                  + " stockouttypeid='" & frmStockoutBatchRequest.Stockouttypeid.Text & "', " _
                                  + " remarks='" & rchar(txtRemarks.Text) & "', " _
                                  + " trnby='" & globaluserid & "', " _
                                  + " confirmed=0, " _
                                  + " datetrn=current_timestamp " : com.ExecuteNonQuery()

        'If ckBatch.Checked = True Then

        '    'StockoutInventory("Inventory Stockout", stockid.Text, officeid.Text, productid.Text, Val(CC(txtquantity.Text)), Val(CC(purchasedprice.Text)), If(txtRemarks.Text = "", "manual stockout", txtRemarks.Text), officeallocated.Text, CDate(txtdatestockout.EditValue).ToString("yyyy-MM") & "-" & batchcode.Text, "")
        '    If frmStockoutBatchRequest.Visible = True Then
        '        frmStockoutBatchRequest.FilterNew()
        '    End If
        'Else
        '    com.CommandText = "insert into tblstockoutitem set " _
        '                          + " officeid='" & officeid.Text & "', " _
        '                          + " refcode='" & stockid.Text & "', " _
        '                          + " allocatedstock=" & ckAllocatedStockout.CheckState & ", " _
        '                          + " allocatedofficeid='" & officeallocated.Text & "', " _
        '                          + " productid='" & productid.Text & "', " _
        '                          + " catid='" & catid.Text & "', " _
        '                          + " quantity='" & Val(CC(txtquantity.Text)) & "', " _
        '                          + " purchasedprice='" & Val(CC(purchasedprice.Text)) & "', " _
        '                          + " unit='" & txtunit.Text & "', " _
        '                          + " stockouttypeid='" & Stockouttypeid.Text & "', " _
        '                          + " remarks='" & rchar(txtRemarks.Text) & "', " _
        '                          + " requestby='" & requestorid.Text & "', " _
        '                          + " trnby='" & globaluserid & "', " _
        '                          + " status=0, " _
        '                          + " datetrn=concat('" & ConvertDate(txtdatestockout.Text) & "',' ',current_time) " : com.ExecuteNonQuery()
        '    StockoutInventory("Inventory Stockout", stockid.Text, officeid.Text, productid.Text, Val(CC(txtquantity.Text)), Val(CC(purchasedprice.Text)), If(txtRemarks.Text = "", "manual stockout", txtRemarks.Text), officeallocated.Text, CDate(txtdatestockout.EditValue).ToString("yyyy-MM") & "-" & batchcode.Text, "")
        '    If frmInventoryConsumables.Visible = True Then
        '        frmInventoryConsumables.FilterInventoryReports()
        '    End If
        '    XtraMessageBox.Show("Inventory successfully stockout!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
        frmStockoutBatchRequest.FilterNew()
        Me.Close()
    End Sub
  
    Private Sub EditValueChanging_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtquantity.EditValueChanged
        If Val(CC(txtquantity.Text)) > Val(CC(txtAvailableQuantity.Text)) Then
            txtquantity.ForeColor = Color.White
            txtquantity.BackColor = Color.Red
        Else
            txtquantity.ForeColor = Color.Black
            txtquantity.BackColor = Color.Yellow
        End If
        txtTotalCost.Text = FormatNumber(Val(CC(txtUnitCost.Text)) * Val(CC(txtquantity.Text)), 3)
    End Sub

    
End Class