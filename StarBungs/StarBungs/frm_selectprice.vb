Public Class frm_selectprice


    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click

        If txt_amount.Text = "" Or Not IsNumeric(txt_amount.Text) Then
            msg_error("กรุณากรอกจำนวน")
            Return
        End If

        Dim array_item(7) As String
        With coffeesale
            array_item(0) = .ListView1.Items.Count + 1
            array_item(1) = lbl_coffeeID.Text
            array_item(2) = lbl_coffeeName.Text
            array_item(3) = "แก้ว"
            array_item(4) = txt_amount.Text
            Dim price As Integer = 0
            If rad_hot.Checked = True Then
                price = lbl_hot.Text
            ElseIf rad_iced.Checked = True Then
                price = lbl_iced.Text
            Else
                price = lbl_frappe.Text

            End If
            array_item(5) = price
            array_item(6) = array_item(4) * array_item(5)


        End With
        Dim itm As New ListViewItem(array_item)
        coffeesale.ListView1.Items.Add(itm)
        Me.Hide()
        coffeesale.total_price()

    End Sub

    Private Sub rad_hot_CheckedChanged(sender As Object, e As EventArgs) Handles rad_hot.CheckedChanged
        txt_amount.Select()
    End Sub

    Private Sub rad_iced_CheckedChanged(sender As Object, e As EventArgs) Handles rad_iced.CheckedChanged
        txt_amount.Select()
    End Sub

    Private Sub rad_frappe_CheckedChanged(sender As Object, e As EventArgs) Handles rad_frappe.CheckedChanged
        txt_amount.Select()
    End Sub
End Class