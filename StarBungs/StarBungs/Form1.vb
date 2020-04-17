Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connect_open()
            MsgBox("Success")
        Catch ex As Exception
            MsgBox("Fail")

        End Try

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If txt_ID.Text = "" Or txt_Password.Text = "" Then
            MsgBox("Plese Enter ID and Passwoed")
            Return
        End If

        sql = "select count(*) from users where staffID='" & txt_ID.Text & "'and staffPassword='" & txt_Password.Text & "'"
        Dim count_staff As Integer = cmd_excuteScalar()

        If count_staff <= 0 Then
            MsgBox("Fail to Login")
        Else
            MsgBox("Login Success")


        End If







    End Sub
End Class
