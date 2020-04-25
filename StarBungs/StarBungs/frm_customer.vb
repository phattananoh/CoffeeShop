Imports System.Data.SqlClient


Public Class frm_customer
    Private Sub frm_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_customer()
    End Sub

    Public Sub load_customer()
        connect()
        sql = "select username, name from customer"
        DA = New SqlClient.SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")

        datagrid_search.DataSource = DS.Tables("table")

    End Sub
    Public Sub search_customer()
        connect()
        sql = "select username, name from customer where username like '%" & txt_search.Text & "%' or password like '%" & txt_search.Text & "%' or name like'%" & txt_search.Text & "%' or nickname like '%" & txt_search.Text & "%' or address like '%" & txt_search.Text & "%' or tel like '%" & txt_search.Text & "%'"
        DA = New SqlClient.SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")

        datagrid_search.DataSource = DS.Tables("table")
    End Sub
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        search_customer()

    End Sub

    Private Sub datagrid_search_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_search.CellContentClick


    End Sub

    Private Sub datagrid_search_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_search.CellClick

        On Error Resume Next

        Dim i As Integer = datagrid_search.CurrentRow.Index
        Dim key As String = datagrid_search.Item(0, i).Value
        connect()
        sql = "select * from customer where username = '" & key & "'"
        DA = New SqlClient.SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")

        Dim dts As DataTable = DS.Tables("table")
        txt_show_username.Text = dts.Rows(0)("username")
        txt_show_password.Text = dts.Rows(0)("password")
        txt_show_name.Text = dts.Rows(0)("name")
        txt_show_nickname.Text = dts.Rows(0)("nickname")
        txt_show_address.Text = dts.Rows(0)("address")
        txt_show_tel.Text = dts.Rows(0)("tel")
        date_show_born.Value = dts.Rows(0)("born")
        txt_show_point.Text = dts.Rows(0)("point")

        txt_edit_username.Text = dts.Rows(0)("username")
        txt_edit_password.Text = dts.Rows(0)("password")
        txt_edit_name.Text = dts.Rows(0)("name")
        txt_edit_nickname.Text = dts.Rows(0)("nickname")
        txt_edit_address.Text = dts.Rows(0)("address")
        txt_edit_tel.Text = dts.Rows(0)("tel")
        date_edit_born.Value = dts.Rows(0)("born")
        txt_show_point.Text = dts.Rows(0)("point")




    End Sub
    Friend Sub connect()
        If cn.State = ConnectionState.Closed Then cn.Open()

    End Sub
    Private Sub btn_add_save_Click(sender As Object, e As EventArgs) Handles btn_add_save.Click
        If confirm("ยืนยันการเพิ่มข้อมูล") = vbNo Then Return



        connect()
        Dim name As String = txt_add_name.Text
        Dim nickname As String = txt_add_nickname.Text
        Dim born As Date = date_add_born.Value
        Dim address As String = txt_add_address.Text
        Dim tel As String = txt_add_tel.Text
        Dim username As String = txt_add_username.Text
        Dim password As String = txt_add_password.Text

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
        cmd.Parameters.AddWithValue("point", 0)

        If cmd.ExecuteNonQuery() >= 1 Then
            msg_ok("เพิ่มสำเร็จ")
            load_customer()
            txt_add_address.Text = ""
            txt_add_name.Text = ""
            txt_add_nickname.Text = ""
            txt_add_password.Text = ""
            txt_add_tel.Text = ""
            txt_add_username.Text = ""



        Else
            msg_error("ไม่สำเร็จ")
        End If





    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If confirm("ยืนยันการลบหรือไม่ ?") = vbNo Then
            Return
        End If

        Dim i As Integer = datagrid_search.CurrentRow.Index
        Dim key As String = datagrid_search.Item(0, i).Value

        connect()
        sql = "delete from customer where username = '" & key & "'"
        cmd = New SqlCommand(sql, cn)
        If cmd.ExecuteNonQuery >= 1 Then
            msg_ok("ลบสำเร็จ")
            load_customer()
        Else
            msg_error("ล้มเหลว")


        End If
    End Sub

    Private Sub btn_edit_button_Click(sender As Object, e As EventArgs) Handles btn_edit_button.Click
        If confirm("ยืนยันการแก้ไข") = vbNo Then Return



        connect()
        Dim name As String = txt_edit_name.Text
        Dim nickname As String = txt_edit_nickname.Text
        Dim born As Date = date_edit_born.Value
        Dim address As String = txt_edit_address.Text
        Dim tel As String = txt_edit_tel.Text
        Dim username As String = txt_edit_username.Text
        Dim password As String = txt_edit_password.Text
        Dim point As Integer = txt_edit_point.Text

        sql = "update customer set password=@password, name=@name, nickname=@nickname, born=@born, address=@address, tel=@tel, point=@point where username=@username"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("username", username)
        cmd.Parameters.AddWithValue("password", password)
        cmd.Parameters.AddWithValue("name", name)
        cmd.Parameters.AddWithValue("nickname", nickname)
        cmd.Parameters.AddWithValue("born", born)
        cmd.Parameters.AddWithValue("address", address)
        cmd.Parameters.AddWithValue("tel", tel)
        cmd.Parameters.AddWithValue("point", point)

        If cmd.ExecuteNonQuery() >= 1 Then
            msg_ok("เเก้ไขสำเร็จ")
            load_customer()
            txt_add_address.Text = ""
            txt_add_name.Text = ""
            txt_add_nickname.Text = ""
            txt_add_password.Text = ""
            txt_add_tel.Text = ""
            txt_add_username.Text = ""



        Else
            msg_error("ไม่สำเร็จ")
        End If
    End Sub
End Class