Imports System.Data.SqlClient

Public Class frm_customer_main
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If confirm("ยืนยันการแก้ไข") = vbNo Then Return



        connect_open()
        Dim name As String = txt_show_name.Text
        Dim nickname As String = txt_show_nickname.Text
        Dim born As Date = date_show_born.Value
        Dim address As String = txt_show_address.Text
        Dim tel As String = txt_show_tel.Text
        Dim username As String = txt_show_username.Text
        Dim password As String = txt_show_password.Text
        Dim point As Integer = txt_show_point.Text

        sql = "update customer set password=@password, name=@name, nickname=@nickname, born=@born, address=@address, tel=@tel where username=@username"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("username", username)
        cmd.Parameters.AddWithValue("password", password)
        cmd.Parameters.AddWithValue("name", name)
        cmd.Parameters.AddWithValue("nickname", nickname)
        cmd.Parameters.AddWithValue("born", born)
        cmd.Parameters.AddWithValue("address", address)
        cmd.Parameters.AddWithValue("tel", tel)


        If cmd.ExecuteNonQuery() >= 1 Then
            msg_ok("เเก้ไขสำเร็จ")




        Else
            msg_error("ไม่สำเร็จ")
        End If
    End Sub

    Private Sub btn_use_point_Click(sender As Object, e As EventArgs) Handles btn_use_point.Click

        If txt_use_coupon.Text = "" Then
            msg_error("กรุณาระบุแต้มที่ต้องการแลก")
            txt_use_coupon.Select()
            Return
        End If

        Dim all_point As Integer = txt_show_point.Text
        Dim use_point As Integer = txt_use_coupon.Text
        If use_point > all_point Then
            msg_error("Point คุณน้อยเกินไป")
            Return
        End If

        Dim new_point As Integer = all_point - use_point


        If confirm("คุณต้องการแลกแต้มหรือไม่ ?") = vbNo Then Return
        connect_open()
        sql = "update customer set point=point-" & txt_use_coupon.Text & "Where username='" & txt_show_username.Text & "'"
        cmd = New SqlCommand(sql, cn)
        If cmd.ExecuteNonQuery >= 1 Then
            msg_ok("แต้มของคุณถูกใช้")
            Randomize()
            Dim rand_code As String = 999999 * Rnd()
            txt_coupon_code.Text = rand_code

            rand_code = rand_code.PadLeft(6, "0")
            sql = "insert into promotions(promotion_coupon, promotion_condition, promotion_discount, promotion_count, promotion_user) values(@coupon, @condition, @discount, @count, @promotion_user)"


            cmd = New SqlCommand(sql, cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("coupon", rand_code)
            cmd.Parameters.AddWithValue("condition", "รับส่วนลดจากการแลกแต้ม" & txt_use_coupon.Text)
            cmd.Parameters.AddWithValue("discount", txt_use_coupon.Text)
            cmd.Parameters.AddWithValue("count", 1)
            cmd.Parameters.AddWithValue("promotion_user", txt_show_username.Text)



            If cmd.ExecuteNonQuery >= 1 Then
                msg_ok("สร้าง Coupon สำเร็จ")
                txt_show_point.Text = new_point

            Else
                msg_error("สร้าง Coupon ไม่สำเร็จ")
            End If



        Else

            msg_error("ไม่สามารถแลกแต้มได้")
        End If

    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Form1.Show()

        Me.Close()


    End Sub

    Private Sub btn_history_Click(sender As Object, e As EventArgs) Handles btn_history.Click
        connect_open()
        sql = "select * from promotions where promotion_user='" & txt_show_username.Text & "'"
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        frm_history.datagrid_history.DataSource = DS.Tables("table")

        frm_history.Show()

    End Sub
End Class