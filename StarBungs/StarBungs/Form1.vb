Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub



    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If txt_ID.Text = "" Or txt_Password.Text = "" Then
            msg_error("Plese Enter ID and Passwoed")
            Return
        End If

        sql = "select count(*) from staffs where staffID='" & txt_ID.Text & "'and staffPassword='" & txt_Password.Text & "'"
        Dim count_staff As Integer = cmd_excuteScalar()

        If count_staff <= 0 Then
            msg_error("Fail to Login")
            txt_ID.Text = ""
            txt_Password.Text = ""
            txt_ID.Select()

        Else
            msg_ok("Login Success")
            starbungs_main.Show()
            Me.Hide()

            sql = "select * from staffs where staffID='" & txt_ID.Text & "'and staffPassword='" & txt_Password.Text & "'"
            Dim dts As DataTable = cmd_excuteDataTable()

            With starbungs_main
                .lbl_Username.Text = dts.Rows(0)("staffID")
                .lbl_Name.Text = dts.Rows(0)("staffName")
                .lbl_Level.Text = dts.Rows(0)("staffLevel")
                .lbl_Email.Text = dts.Rows(0)("staffEmail")

            End With

        End If

    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txt_Password.PasswordChar = ""
        Else
            txt_Password.PasswordChar = "#"
        End If

    End Sub
End Class
