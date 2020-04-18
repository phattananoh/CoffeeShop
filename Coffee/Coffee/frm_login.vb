Public Class frm_login
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_username.Text = My.Settings.username
        If My.Settings.username = "" Then
            chk_remember.Checked = False

        Else
            chk_remember.Checked = True
        End If

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_username.Text = "" Or txt_password.Text = "" Then
            msg_error("กรุณากรอกข้อมูลให้ครบ")
            Return
        End If

        sql = "select count(*) from usersLog where users_username='" & txt_username.Text & "'and users_password='" & txt_password.Text & "'"
        Dim count_user As Integer = cmd_excuteScalar()

        If count_user <= 0 Then
            msg_error("คุณ Login ผิดพลาด")
            txt_username.Text = ""
            txt_password.Text = ""
            txt_username.Select()

        Else
            msg_ok("Login สำเร็จ")
            frm_main.Show()
            Me.Hide()

            sql = "select * from usersLog where users_username='" & txt_username.Text & "'and users_password='" & txt_password.Text & "'"
            Dim dts As DataTable = cmd_excuteDataTable()

            With frm_main
                .lbr_username.Text = dts.Rows(0)("users_username")
                .lbr_fullname.Text = dts.Rows(0)("users_name") & " " & dts.Rows(0)("users_lastname")
                .lbr_tel.Text = dts.Rows(0)("users_tel")
                .lbr_email.Text = dts.Rows(0)("users_email")
                .lbr_timelogin.Text = Date.Now



            End With





        End If



    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        If confirm("คุณต้องการออกจากโปรแกรมหรือไม่ ?") = vbYes Then End


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txt_password.PasswordChar = ""
        Else
            txt_password.PasswordChar = "•"
        End If

    End Sub

    Private Sub chk_remember_CheckedChanged(sender As Object, e As EventArgs) Handles chk_remember.CheckedChanged
        If chk_remember.Checked = True Then
            My.Settings.username = txt_username.Text
        Else
            My.Settings.username = ""
        End If
        My.Settings.Save()

    End Sub
End Class
