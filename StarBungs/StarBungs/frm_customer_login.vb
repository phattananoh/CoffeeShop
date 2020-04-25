Imports System.Data.SqlClient

Public Class frm_customer_login
    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        If confirm("ยืนยันการสมัคร") = vbNo Then Return



        connect_open()
        Dim name As String = txt_show_name.Text
        Dim nickname As String = txt_show_nickname.Text
        Dim born As Date = date_show_born.Value
        Dim address As String = txt_show_address.Text
        Dim tel As String = txt_show_tel.Text
        Dim username As String = txt_show_username.Text
        Dim password As String = txt_show_password.Text

        sql = "insert into customer (username, password, name, nickname, born, address, tel, poin) values(@username, @password, @name, @nickname, @born, @address, @tel, @point)"
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
            msg_ok("สมัครสำเร็จ")

            txt_show_address.Text = ""
            txt_show_name.Text = ""
            txt_show_nickname.Text = ""
            txt_show_password.Text = ""
            txt_show_tel.Text = ""
            txt_show_username.Text = ""



        Else
            msg_error("ไม่สำเร็จ")
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        connect_open()
        sql = "select * from customer where username'" & txt_username1.Text & "' and password'" & txt_password1.Text & "'"

        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        Dim DT As DataTable = DS.Tables("table")


        If DT.Rows.Count = 0 Then
            msg_error("ไม่พบ username / password ในระบบ")
        Else

            Me.Hide()
            frm_customer_main.Show()




        End If
    End Sub
End Class