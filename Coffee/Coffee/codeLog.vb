Imports System.Data.Sql
Imports System.Data.SqlClient


Module codeLog
    Friend cn As New SqlConnection("Data Source=.\SQLEXPRESS; Initial Catalog=CoffeeLogin; Integrated Security=SSPI;")

    Friend cmd As New SqlCommand

    Friend DA As New SqlDataAdapter

    Friend sql As String


    Friend Sub connect_open()
        If cn.State = ConnectionState.Closed Then cn.Open()
    End Sub



    Friend Function cmd_excuteScalar()
        connect_open()
        cmd = New SqlCommand(sql, cn)
        Return cmd.ExecuteScalar


    End Function

    Friend Sub msg_error(text As String, Optional title As String = "ผิดพลาด")
        MsgBox(text, vbCritical + vbOKOnly, title)
    End Sub
    Friend Sub msg_ok(text As String, Optional title As String = "สำเร็จ")
        MsgBox(text, vbInformation + vbOKOnly, title)
    End Sub

    Friend Function confirm(text As String, Optional title As String = "ยืนยัน")
        Return MsgBox(text, vbQuestion + vbYesNo, title)
    End Function


End Module
