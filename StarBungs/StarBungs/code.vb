Imports System.Data.Sql
Imports System.Data.SqlClient

Module code
    'Database
    Friend cn As New SqlConnection("Data Source=.\SQLEXPRESS; Initial Catalog=starbungs; Integrated Security=True;")
    'Sql Command
    Friend cmd As New SqlCommand

    Friend DA As New SqlDataAdapter

    Friend sql As String

    'Function Open Database
    Friend Sub connect_open()
        If cn.State = ConnectionState.Closed Then cn.Open()

    End Sub

    Friend Function cmd_excuteScalar()
        connect_open()
        cmd = New SqlCommand(sql, cn)
        Return cmd.ExecuteScalar


    End Function

End Module
