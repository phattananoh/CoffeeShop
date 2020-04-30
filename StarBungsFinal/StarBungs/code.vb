Imports System.Data.Sql
Imports System.Data.SqlClient



Module codeLog


    Friend cn As New SqlConnection("Data Source=PHATTANAN;Initial Catalog=starbungs;Integrated Security=True")

    Friend cmd As New SqlCommand

    Friend DA As New SqlDataAdapter

    Friend sql As String

    Friend DS As DataSet


    Friend Function confirm(text As String, Optional title As String = "Confirm")
        Return MsgBox(text, vbQuestion + vbYesNo, title)
    End Function

    Friend Sub msg_ok(text As String, Optional title As String = "Success")
        MsgBox(text, vbInformation + vbOKOnly, title)
    End Sub

    Friend Sub msg_error(text As String, Optional title As String = "Fail")
        MsgBox(text, vbCritical + vbOKOnly, title)
    End Sub

    Friend Sub connect_open()
        If cn.State = ConnectionState.Closed Then cn.Open()


    End Sub

    Friend Function cmd_excuteNonquery()
        cmd = New SqlCommand(sql, cn)
        Return cmd.ExecuteNonQuery
    End Function

    Friend Function cmd_excuteScalar()
        connect_open()
        cmd = New SqlCommand(sql, cn)
        Return cmd.ExecuteScalar


    End Function

    Friend Function cmd_excuteDataTable()
        connect_open()
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        Return DS.Tables("table")
    End Function

End Module
