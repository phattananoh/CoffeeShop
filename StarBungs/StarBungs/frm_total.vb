Public Class frm_total
    Private Sub frm_total_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_cancle_Click(sender As Object, e As EventArgs) Handles btn_cancle.Click
        Me.Close()

    End Sub

    Private Sub txt_receive_TextChanged(sender As Object, e As EventArgs) Handles txt_receive.TextChanged

    End Sub

    Private Sub txt_receive_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_receive.KeyDown
        If e.KeyData = Keys.Enter Then
            If Not IsNumeric(txt_receive.Text) Then
                msg_error("Please only Enter a Number")
                txt_receive.Text = ""
                txt_receive.Select()
                Return
            End If

            If Val(txt_receive.Text) < Val(txt_total2.Text) Then
                msg_error("Can not Purchase")
                txt_receive.Text = ""
                txt_receive.Select()
                Return
            End If


            Dim net As Double = txt_total2.Text
            Dim receive As Double = txt_receive.Text
            Dim change As Double = receive - net
            txt_change.Text = FormatNumber(change)
        End If
    End Sub

    Private Sub txt_change_TextChanged(sender As Object, e As EventArgs) Handles txt_change.TextChanged

    End Sub

    Private Sub txt_change_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_change.KeyDown

    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        sql = "insert into sales(saleFullID,coffeeID,coffeeAmount,coffeeTotal,date) values"
        Dim i As Integer = coffeesale.ListView1.Items.Count - 1
        For j As Integer = 0 To i
            Dim coffeeID As String = coffeesale.ListView1.Items(j).SubItems(1).Text
            Dim coffeeAmount As Integer = coffeesale.ListView1.Items(j).SubItems(4).Text
            Dim coffeeTotal As Integer = coffeesale.ListView1.Items(j).SubItems(6).Text
            Dim dateSale As String = Date.Now.Year & "/" & Date.Now.Month & "/" & Date.Now.Day


            If j = i Then
                sql &= String.Format("('{0}','{1}','{2}','{3}','{4}')", coffeesale.lbl_saleID.Text, coffeeID, coffeeAmount, coffeeTotal, dateSale)


            Else
                sql &= String.Format("('{0}','{1}','{2}','{3}','{4}') ,", coffeesale.lbl_saleID.Text, coffeeID, coffeeAmount, coffeeTotal, dateSale)

            End If
        Next

        cmd = New SqlClient.SqlCommand(sql, cn)
        If cmd.ExecuteNonQuery = 0 Then
            msg_error("Can not save")
        Else
            sql = "insert into sale_Details(saleFullID,saleTotal,discount,discount_condition,sale_net,customer) values(@saleFullID,@saleTotal,@discount,@discount_condition,@sale_net,@customer)"
            cmd = New SqlClient.SqlCommand(sql, cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("saleFullID", coffeesale.lbl_saleID.Text)
            cmd.Parameters.AddWithValue("saleTotal", txt_total.Text)
            cmd.Parameters.AddWithValue("discount", txt_discount.Text)
            cmd.Parameters.AddWithValue("discount_condition", promotion.lbl_condition.Text)
            cmd.Parameters.AddWithValue("sale_net", txt_total.Text)
            cmd.Parameters.AddWithValue("customer", coffeesale.lbl_username.Text)



            If cmd.ExecuteNonQuery = 0 Then
                msg_error("Can not Save")
            Else
                msg_ok("Complete")
                connect_open()
                sql = "update customer set point+=" & lbl_point.Text & " where username = '" & coffeesale.lbl_username.Text & "'"
                cmd = New SqlClient.SqlCommand(sql, cn)
                If cmd.ExecuteNonQuery >= 1 Then
                    msg_ok("เพิ่ม Point สำเร็จ")
                Else
                    msg_error("ไม่สามารถเพิ่ม Point ได้")

                End If






            End If

        End If

        Me.Close()
        coffeesale.txt_total.Text = "0.00"
        coffeesale.generate_saleID()
        coffeesale.ListView1.Items.Clear()
        coffeesale.lbl_discount.Text = "0"



    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Price_Enter(sender As Object, e As EventArgs) Handles Price.Enter

    End Sub
End Class