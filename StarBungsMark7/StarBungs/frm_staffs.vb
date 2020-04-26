Public Class frm_staffs
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt_show_ID.TextChanged

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connect_open()
        sql = "select * from staffs where staffID = '" & txt_add_user.Text & "'"
        DA = New SqlClient.SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        Dim dts As DataTable = DS.Tables("table")
        If dts.Rows.Count > 0 Then
            msg_error("This username already exists")
            Return
        End If
        If confirm("Are you sure you want to Add Staff?") = vbNo Then Return

        connect_open()
        sql = "insert into staffs values(@staffID,@staffPassword,@satffName,@gender,@staffLevel,@staffEmail)"
        cmd = New SqlClient.SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("staffID", txt_add_user.Text)
        cmd.Parameters.AddWithValue("staffPassword", txt_add_password.Text)
        cmd.Parameters.AddWithValue("satffName", txt_add_name.Text)
        cmd.Parameters.AddWithValue("gender", txt_add_Gender.Text)
        cmd.Parameters.AddWithValue("staffLevel", txt_add_level.Text)
        cmd.Parameters.AddWithValue("staffEmail", txt_add_email.Text)

        If cmd.ExecuteNonQuery >= 1 Then

            sql = "insert into permissions values(@sale,@coffee,@customer,@staff,@promotion,@username)"
            cmd = New SqlClient.SqlCommand(sql, cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("sale", CheckBox_sale.Checked)
            cmd.Parameters.AddWithValue("coffee", CheckBox_Menu.Checked)
            cmd.Parameters.AddWithValue("customer", CheckBox_customer.Checked)
            cmd.Parameters.AddWithValue("staff", CheckBox_staffs.Checked)
            cmd.Parameters.AddWithValue("promotion", CheckBox_promotion.Checked)
            cmd.Parameters.AddWithValue("username", txt_add_user.Text)
            If cmd.ExecuteNonQuery >= 1 Then
                msg_ok("Complete")
                load_staffs()
            Else
                msg_error("Fail")
            End If



        Else
                msg_error("Fail")
        End If
    End Sub

    Private Sub frm_staffs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_staffs()

    End Sub

    Public Sub load_staffs()
        connect_open()
        sql = "select * from staffs"

        DA = New SqlClient.SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        Dim dts As DataTable = DS.Tables("table")
        DataGrid_Search.DataSource = DS.Tables("table")
    End Sub

    Private Sub DataGrid_Search_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_Search.CellContentClick

    End Sub

    Private Sub DataGrid_Search_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_Search.CellClick
        Dim i As Integer = DataGrid_Search.CurrentRow.Index
        Dim key As String = DataGrid_Search.Item(0, i).Value

        txt_show_ID.Text = DataGrid_Search.Item(0, i).Value
        txt_show_Password.Text = DataGrid_Search.Item(1, i).Value
        txt_show_Name.Text = DataGrid_Search.Item(2, i).Value
        txt_show_gender.Text = DataGrid_Search.Item(3, i).Value
        txt_show_level.Text = DataGrid_Search.Item(4, i).Value
        txt_show_email.Text = DataGrid_Search.Item(5, i).Value

        connect_open()
        sql = "select * from permissions where username = '" & key & "'"
        DA = New SqlClient.SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        Dim dts As DataTable = DS.Tables("table")
        ck_show_Sale.Checked = dts.Rows(0)("sale")
        ck_show_Menu.Checked = dts.Rows(0)("coffee")
        ck_show_Customer.Checked = dts.Rows(0)("customer")
        ck_show_Staffs.Checked = dts.Rows(0)("staff")
        ck_show_Coupon.Checked = dts.Rows(0)("promotion")


        txt_edit_ID.Text = DataGrid_Search.Item(0, i).Value
        txt_edit_password.Text = DataGrid_Search.Item(1, i).Value
        txt_edit_name.Text = DataGrid_Search.Item(2, i).Value
        combo_edit_name.Text = DataGrid_Search.Item(3, i).Value
        txt_edit_level.Text = DataGrid_Search.Item(4, i).Value
        txt_edit_email.Text = DataGrid_Search.Item(5, i).Value






    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txt_confirm.Text <> "CONFIRM" Then
            msg_error("Please enter CONFIRM again")
            txt_confirm.Text = ""
            txt_confirm.Select()
            Return




        End If

        Dim select_id As Integer = DataGrid_Search.CurrentRow.Index
        Dim coffeeID As String = DataGrid_Search.Item(0, select_id).Value

        sql = "delete from staffs where staffID = '" & txt_show_ID.Text & "'"
        If cmd_excuteNonquery() = 0 Then
            msg_error("Fail to remove")
        Else
            msg_ok("Remove complete")
            txt_confirm.Text = ""
            load_staffs()
            coffeesale.refresh_coffee()

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If confirm("Are you sure you want to clear textbox?") = vbNo Then Return
        txt_edit_name.Text = ""
        txt_edit_password.Text = ""
        txt_edit_ID.Text = ""
        txt_edit_level.Text = ""
        txt_edit_email.Text = ""
        combo_edit_name.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If confirm("Are you sure you want to clear textbox?") = vbNo Then Return
        txt_add_user.Text = ""
        txt_add_password.Text = ""
        txt_add_level.Text = ""
        txt_add_name.Text = ""
        txt_add_email.Text = ""
        txt_add_Gender.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If confirm("Are you sure you want to EDIT?") = vbNo Then Return
        connect_open()
        sql = "update staffs set staffPassword  = @password , staffName = @name, gender = @gander, staffLevel = @level , staffEmail = @email where staffID ='" & txt_edit_ID.Text & "'"
        cmd = New SqlClient.SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("password", txt_edit_password.Text)
        cmd.Parameters.AddWithValue("name", txt_edit_name.Text)
        cmd.Parameters.AddWithValue("gander", combo_edit_name.Text)
        cmd.Parameters.AddWithValue("level", txt_edit_level.Text)
        cmd.Parameters.AddWithValue("email", txt_edit_email.Text)
        If cmd.ExecuteNonQuery >= 1 Then
            sql = "update permissions set sale = @sale , coffee = @coffee , customer = @customer,staff = @staff,promotion = @promotion where username = '" & txt_edit_ID.Text & "'"
            cmd = New SqlClient.SqlCommand(sql, cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("sale", cbEdit_sale.Checked)
            cmd.Parameters.AddWithValue("coffee", cbEdit_Menu.Checked)
            cmd.Parameters.AddWithValue("customer", cbEdit_Customer.Checked)
            cmd.Parameters.AddWithValue("staff", cbEdit_Staffs.Checked)
            cmd.Parameters.AddWithValue("promotion", cbEdit_Coupon.Checked)
            If cmd.ExecuteNonQuery >= 1 Then
                msg_ok("Complete")
            Else
                msg_error("Fail")
            End If


        Else
            msg_error("Fail")
        End If
    End Sub
End Class