﻿Module Product
    Public Function EditProduct(ByVal productid As String, ByVal frm As Form, ByVal modalview As Boolean)
        If GlobalProductTemplate = 1 Then
            frmProductTemplate1.mode.Text = ""
            frmProductTemplate1.productid.Text = productid
            frmProductTemplate1.mode.Text = "edit"
            If modalview = True Then
                frmProductTemplate1.ShowDialog(frm)
            Else
                frmProductTemplate1.Show(frm)
            End If
        ElseIf GlobalProductTemplate = 2 Then
            frmProductTemplate2.mode.Text = ""
            frmProductTemplate2.productid.Text = productid
            frmProductTemplate2.mode.Text = "edit"
            If modalview = True Then
                frmProductTemplate2.ShowDialog(frm)
            Else
                frmProductTemplate2.Show(frm)
            End If

        ElseIf GlobalProductTemplate = 3 Then
            frmProductTemplate3.mode.Text = ""
            frmProductTemplate3.productid.Text = productid
            frmProductTemplate3.mode.Text = "edit"
            If modalview = True Then
                frmProductTemplate3.ShowDialog(frm)
            Else
                frmProductTemplate3.Show(frm)
            End If

        ElseIf GlobalProductTemplate = 4 Then
            frmProductTemplate4.mode.Text = ""
            frmProductTemplate4.productid.Text = productid
            frmProductTemplate4.mode.Text = "edit"
            If modalview = True Then
                frmProductTemplate4.ShowDialog(frm)
            Else
                frmProductTemplate4.Show(frm)
            End If
        End If
        Return True
    End Function

    Public Function AddProduct(ByVal AddFrom As String, ByVal frm As Form, ByVal modalview As Boolean)
        If GlobalProductTemplate = 1 Then
            frmProductTemplate1.selfrom.Text = AddFrom
            If modalview = True Then
                frmProductTemplate1.ShowDialog(frm)
            Else
                frmProductTemplate1.Show(frm)
            End If
        ElseIf GlobalProductTemplate = 2 Then
            frmProductTemplate2.selfrom.Text = AddFrom
            If modalview = True Then
                frmProductTemplate2.ShowDialog(frm)
            Else
                frmProductTemplate2.Show(frm)
            End If
        ElseIf GlobalProductTemplate = 3 Then
            frmProductTemplate3.selfrom.Text = AddFrom
            If modalview = True Then
                frmProductTemplate3.ShowDialog(frm)
            Else
                frmProductTemplate3.Show(frm)
            End If
        ElseIf GlobalProductTemplate = 4 Then
            frmProductTemplate4.selfrom.Text = AddFrom
            If modalview = True Then
                frmProductTemplate4.ShowDialog(frm)
            Else
                frmProductTemplate4.Show(frm)
            End If
        End If
        Return 0
    End Function

    Public Sub UpdateDefaultProductInformation(ByVal mode As String, ByVal productid As String, ByVal catid As String, ByVal itemname As String, ByVal unit As String)
        Dim SqlQuery As String = "catid='" & catid & "',itemname='" & rchar(itemname) & "', unit='" & unit & "'"
        If mode = "edit" Then
            com.CommandText = "UPDATE tblglobalproducts set " & SqlQuery & " where productid='" & productid & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "INSERT into tblglobalproducts set productid='" & productid & "', " & SqlQuery & ", entryby='" & globaluserid & "', dateentered=current_timestamp " : com.ExecuteNonQuery()
        End If
    End Sub

    Public Sub UpdateProductTemplate2(ByVal mode As String, ByVal productid As String, ByVal barcode As String, ByVal catid As String, ByVal subcatid As String, ByVal itemname As String, ByVal description As String, ByVal unit As String, ByVal reorderPoint As Double, ByVal enablesell As Boolean, ByVal vatableitem As Boolean, ByVal servicechargeitem As Boolean, ByVal forcontract As Boolean, ByVal menumakeritem As Boolean, ByVal servicemakeritem As Boolean, ByVal customproductorder As Boolean, ByVal requiredattendingpersonnel As Boolean, ByVal enableofficecenter As Boolean, ByVal officecenter As String, ByVal ComputeLength As Boolean, ByVal EnableCoupon As Boolean, ByVal purchasedprice As Double, ByVal calcsellrate As Double, ByVal sellingprice As Double, ByVal salemode As String, ByVal allowinputdiscountedamount As Boolean, ByVal updaterequired As Boolean)
        Dim SqlQuery As String = "barcode='" & barcode & "', catid='" & catid & "',subcatid='" & subcatid & "', itemname='" & itemname & "', description='" & description & "', unit='" & unit & "', reorderpoint='" & reorderPoint & "', enablesell=" & enablesell & ", vatableitem=" & vatableitem & ",svchargeitem=" & servicechargeitem & ", forcontract=" & forcontract & ", menuitem=" & menumakeritem & ", servicemenuproduct=" & servicemakeritem & ", customproductorder=" & customproductorder & ", requiredattendingpersonnel=" & requiredattendingpersonnel & ", enablecomputelength=" & ComputeLength & ", enablecenter=" & enableofficecenter & ", officecenter='" & officecenter & "', enablecoupon=" & EnableCoupon & ", purchasedprice='" & Val(CC(purchasedprice)) & "', calcsellrate='" & Val(CC(calcsellrate)) & "', sellingprice='" & Val(CC(sellingprice)) & "',salemode='" & salemode & "', allowinputdiscountedamount=" & allowinputdiscountedamount & ", updaterequired=" & updaterequired & " "
        If mode = "edit" Then
            com.CommandText = "UPDATE tblglobalproducts set " & SqlQuery & " where productid='" & productid & "'" : com.ExecuteNonQuery()
            If enablesell = True And forcontract = True Then
                UpdateProductMenumakerService(productid, sellingprice)
            End If
            com.CommandText = "UPDATE tblinventory set catid='" & catid & "', categoryname='" & qrysingledata("description", "description", "tblprocategory where catid='" & catid & "'") & "', productname='" & itemname & "', reorderpoint='" & reorderPoint & "', sellingprice='" & sellingprice & "' where productid='" & productid & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblglobalproducts set productid='" & productid & "', " & SqlQuery & ", entryby='" & globaluserid & "', dateentered=current_timestamp " : com.ExecuteNonQuery()
        End If
    End Sub

    Public Sub UpdateProductTemplate3(ByVal mode As String, ByVal productid As String, ByVal barcode As String, ByVal catid As String, ByVal itemname As String, ByVal partnumber As String, ByVal unit As String, ByVal enablesell As Boolean, ByVal vatableitem As Boolean, ByVal forcontract As Boolean, ByVal menumakeritem As Boolean, ByVal servicemakeritem As Boolean, ByVal purchasedprice As Double, ByVal calcsellrate As Double, ByVal sellingprice As Double, ByVal salemode As String, ByVal allowinputdiscountedamount As Boolean)
        Dim SqlQuery As String = "barcode='" & barcode & "', catid='" & catid & "',itemname='" & rchar(itemname) & "',partnumber='" & rchar(partnumber) & "', unit='" & unit & "', enablesell=" & enablesell & ", vatableitem=" & vatableitem & ", forcontract=" & forcontract & ", menuitem=" & menumakeritem & ", servicemenuproduct=" & servicemakeritem & ", purchasedprice='" & Val(CC(purchasedprice)) & "', calcsellrate='" & Val(CC(calcsellrate)) & "', sellingprice='" & Val(CC(sellingprice)) & "',salemode='" & salemode & "', allowinputdiscountedamount=" & allowinputdiscountedamount & ""
        If mode = "edit" Then
            com.CommandText = "UPDATE tblglobalproducts set " & SqlQuery & "  where productid='" & productid & "'" : com.ExecuteNonQuery()
            If enablesell = True And forcontract = True Then
                UpdateProductMenumakerService(productid, sellingprice)
            End If
        Else
            com.CommandText = "insert into tblglobalproducts set productid='" & productid & "', " & SqlQuery & ", entryby='" & globaluserid & "', dateentered=current_timestamp" : com.ExecuteNonQuery()
        End If
    End Sub

    Public Sub UpdateProductTemplate4(ByVal mode As String, ByVal productid As String, ByVal barcode As String, ByVal catid As String, ByVal itemname As String, ByVal partnumber As String, ByVal unit As String, ByVal enablesell As Boolean, ByVal vatableitem As Boolean, ByVal forcontract As Boolean, ByVal menumakeritem As Boolean, ByVal servicemakeritem As Boolean, ByVal purchasedprice As Double, ByVal calcsellrate As Double, ByVal sellingprice As Double, ByVal sellingprice1 As Double, ByVal sellingprice2 As Double, ByVal sellingprice3 As Double, ByVal sellingprice4 As Double, ByVal salemode As String, ByVal allowinputdiscountedamount As Boolean)
        Dim SqlQuery As String = "barcode='" & barcode & "', catid='" & catid & "',itemname='" & rchar(itemname) & "',partnumber='" & rchar(partnumber) & "', unit='" & unit & "', enablesell=" & enablesell & ", vatableitem=" & vatableitem & ", forcontract=" & forcontract & ", menuitem=" & menumakeritem & ", servicemenuproduct=" & servicemakeritem & ", purchasedprice='" & Val(CC(purchasedprice)) & "', calcsellrate='" & Val(CC(calcsellrate)) & "', sellingprice='" & Val(CC(sellingprice)) & "', sellingprice1='" & Val(CC(sellingprice1)) & "', sellingprice2='" & Val(CC(sellingprice2)) & "', sellingprice3='" & Val(CC(sellingprice3)) & "', sellingprice4='" & Val(CC(sellingprice4)) & "', salemode='" & salemode & "', allowinputdiscountedamount=" & allowinputdiscountedamount & ""
        If mode = "edit" Then
            com.CommandText = "UPDATE tblglobalproducts set " & SqlQuery & " where productid='" & productid & "'" : com.ExecuteNonQuery()
            If enablesell = True And forcontract = True Then
                UpdateProductMenumakerService(productid, sellingprice)
            End If
        Else
            com.CommandText = "insert into tblglobalproducts set productid='" & productid & "', " & SqlQuery & ", entryby='" & globaluserid & "', dateentered=current_timestamp" : com.ExecuteNonQuery()
        End If
    End Sub

    Public Sub UpdateProductMenumakerService(ByVal productid As String, ByVal amount As Double)
        com.CommandText = "update tblproductserviceitem set amount='" & amount & "' where productid='" & productid & "'" : com.ExecuteNonQuery()
    End Sub

    Public Function SearchProductName(ByVal fieldname As String, ByVal strString As String)
        Dim StrQuery As String = ""
        If strString.Contains(" ") = True Then
            For Each word In strString.Split(New Char() {" "c})
                StrQuery += fieldname & " like '%" & word & "%' and "
            Next
            StrQuery = "(" & StrQuery.Remove(StrQuery.Length - 4, 4) & ")"
        Else
            StrQuery = fieldname & " like '%" & strString & "%'"
        End If
        Return StrQuery
    End Function

End Module
