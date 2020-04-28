Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Skins

Public Class frmDirectPOEditProduct
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        ElseIf keyData = (Keys.Control) + Keys.Enter Then
            cmdaction.PerformClick()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmDirectPOEditProduct_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmQuantitySelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        showProductInformation()
        txtQuantity.Focus()
    End Sub

    Private Sub txtquan_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuantity.GotFocus
        txtQuantity.SelectionStart = 0
        txtQuantity.SelectionLength = Len(txtQuantity.Text)
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        If Val(CC(txtQuantity.Text)) <= 0 Then
            XtraMessageBox.Show("Quantity missing entry!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtQuantity.Focus()
            Exit Sub
 
        ElseIf txtUnitCost.Text = "" Then
            XtraMessageBox.Show("Estimate Cost missing entry!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUnitCost.Focus()
            Exit Sub
        End If

        If XtraMessageBox.Show("Do you want to update the product database record of the current price? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "UPDATE tblpurchaseorderitem set quantity='" & txtQuantity.EditValue & "',cost='" & Val(CC(txtUnitCost.EditValue)) & "', total='" & Val(CC(txtTotalCost.EditValue)) & "'  where trnid='" & trnid.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "UPDATE tblinventory set quantity='" & txtQuantity.EditValue & "',purchasedprice='" & Val(CC(txtUnitCost.EditValue)) & "' where productid='" & productid.Text & "' and stockref='" & ponumber.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "UPDATE tblinventoryledger set debit='" & txtQuantity.EditValue & "',cost='" & Val(CC(txtUnitCost.EditValue)) & "' where productid='" & productid.Text & "' and referenceno='" & ponumber.Text & "' and trntype='Purchase order'" : com.ExecuteNonQuery()
            com.CommandText = "UPDATE tblpurchaseorder set subtotal=ifnull((select sum(total) from tblpurchaseorderitem where ponumber='" & ponumber.Text & "'),0),totalamount=ifnull((select sum(total) from tblpurchaseorderitem where ponumber='" & ponumber.Text & "'),0)  where ponumber='" & ponumber.Text & "'" : com.ExecuteNonQuery()
            frmPurchaseOrderProfile.filterParticularItems()
            XtraMessageBox.Show("Item successfully updated!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Public Sub calctotal()
        Dim quan : Dim stm : Dim ttl
        quan = CC(txtQuantity.Text)
        stm = CC(txtUnitCost.Text)
        ttl = Val(quan) * Val(stm)
        txtTotalCost.Text = Format(ttl, "n")
    End Sub

    Private Sub proid_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        showProductInformation()
    End Sub

    Public Sub showProductInformation()
        com.CommandText = "select * from tblpurchaseorderitem where trnid='" & trnid.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            ponumber.Text = rst("ponumber").ToString
            productid.Text = rst("productid").ToString
            txtProductName.Text = rst("itemname").ToString
            txtQuantity.Text = rst("quantity").ToString
            txtunit.Text = rst("unit").ToString
            txtremarks.Text = rst("remarks").ToString
            txtUnitCost.Text = FormatNumber(Val(rst("cost")), 2)
        End While
        rst.Close()
    End Sub

    Private Sub txtquan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.EditValueChanged
        calctotal()
    End Sub

    Private Sub txtsti_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnitCost.EditValueChanged
        calctotal()
    End Sub

End Class