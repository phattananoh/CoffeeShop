
Imports System.Data.SqlClient
Public Class frm_select_customer


    Public Sub load_customer()
        connect_open()
        sql = "select * from customer"
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        datagrid_search.DataSource = DS.Tables("table")


    End Sub

    Public Sub search_customer()
        connect_open()
        sql = "select * from customer where username like '%" & txt_search.Text & "%' or password like '%" & txt_search.Text & "%' or name like'%" & txt_search.Text & "%' or nickname like '%" & txt_search.Text & "%' or address like '%" & txt_search.Text & "%' or tel like '%" & txt_search.Text & "%'"
        DA = New SqlClient.SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")

        datagrid_search.DataSource = DS.Tables("table")


    End Sub
    Private Sub frm_select_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_customer()

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        search_customer()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        customer_select()

    End Sub

    Public Sub customer_select()
        Dim i As Integer = datagrid_search.CurrentRow.Index
        Dim username As String = datagrid_search.Item(0, i).Value
        Dim name As String = datagrid_search.Item(2, i).Value
        Dim point As Integer = datagrid_search.Item(7, i).Value

        With coffeesale
            .lbl_username.Text = username
            .lbl_name.Text = name
            .lbl_point.Text = point
        End With

        Me.Close()


    End Sub

    Private Sub datagrid_search_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub datagrid_search_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        customer_select()

    End Sub
End Class