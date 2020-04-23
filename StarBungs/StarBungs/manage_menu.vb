Public Class manage_menu

    Public Sub RefreshCoffee()
        sql = "select coffeeID ID,coffeeName Name,coffeeHot Hot,coffeeIced Iced,coffeeFrappe Frappe,coffeeDetail Detail from coffee"
        DataGridCoffee.DataSource = cmd_excuteDataTable()
    End Sub

    Public Sub Clear_from()
        txt_AddID.Text = ""
        txt_AddName.Text = ""
        txt_AddHot.Text = ""
        txt_AddIced.Text = ""
        txt_AddFrappe.Text = ""
        txt_AddDetail.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If confirm("Are you sure you want to add coffee") = vbNo Then Return
        If txt_AddHot.Text = "" Or txt_AddIced.Text = "" Or txt_AddFrappe.Text = "" Or txt_AddID.Text = "" Or txt_AddName.Text = "" Or txt_AddDetail.Text = "" Then
            msg_error("Please fill all textbox.")
            Return


            If Not IsNumeric(txt_editHot.Text) Or Not IsNumeric(txt_editIced.Text) Or Not IsNumeric(txt_editFrappe.Text) Then
                msg_error("Please fill Price in Number")
                Return
            End If
        End If

        sql = "insert into coffee(coffeeID,coffeeName,coffeeHot,coffeeIced,coffeeFrappe,coffeeDetail) values(@id,@name,@hot,@iced,@frappe,@detail)"
        cmd = New SqlClient.SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("id", txt_AddID.Text)
        cmd.Parameters.AddWithValue("name", txt_AddName.Text)
        cmd.Parameters.AddWithValue("hot", txt_AddHot.Text)
        cmd.Parameters.AddWithValue("iced", txt_AddIced.Text)
        cmd.Parameters.AddWithValue("frappe", txt_AddFrappe.Text)
        cmd.Parameters.AddWithValue("detail", txt_AddDetail.Text)

        If cmd.ExecuteNonQuery = 0 Then
            msg_error("Incomplete")
        Else
            msg_ok("Complete")
            RefreshCoffee()
            Clear_from()
            coffeesale.refresh_coffee()

        End If
    End Sub

    Private Sub manage_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshCoffee()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        sql = "select coffeeID,coffeeName from coffee where coffeeID like '%" & txt_search.Text & "%' or coffeeName like '%" & txt_search.Text & "%'"
        DataGridCoffee.DataSource = cmd_excuteDataTable()

    End Sub

    Private Sub Edit_Button_Click(sender As Object, e As EventArgs) Handles Edit_Button.Click
        If confirm("Are you sure you want to edit menu") = vbNo Then Return
        If txt_editID.Text = "" Or txt_editName.Text = "" Or txt_editHot.Text = "" Or txt_editIced.Text = "" Or txt_editFrappe.Text = "" Or txt_editDetail.Text = "" Then
            msg_error("Please fill all textbox")
            Return

            If Not IsNumeric(txt_AddHot.Text) Or Not IsNumeric(txt_AddIced.Text) Or Not IsNumeric(txt_AddFrappe.Text) Then
                msg_error("Please fill Price in Number")
                Return
                coffeesale.refresh_coffee()
            End If


        End If
        sql = "update coffee set coffeeName = @name , coffeeHot = @hot , coffeeIced = @Iced , coffeeFrappe = @frappe , coffeeDetail = @detail where coffeeID = @id"
        cmd = New SqlClient.SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("id", txt_editID.Text)
        cmd.Parameters.AddWithValue("name", txt_editName.Text)
        cmd.Parameters.AddWithValue("hot", txt_editHot.Text)
        cmd.Parameters.AddWithValue("iced", txt_editIced.Text)
        cmd.Parameters.AddWithValue("frappe", txt_editFrappe.Text)
        cmd.Parameters.AddWithValue("detail", txt_editDetail.Text)

        If cmd.ExecuteNonQuery = 0 Then
            msg_error("Fail")
        Else
            msg_ok("Complete")
            RefreshCoffee()
            Clear_from()

        End If
    End Sub

    Private Sub DataGridCoffee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridCoffee.CellContentClick
        Dim select_row As Integer = DataGridCoffee.CurrentRow.Index
        Dim coffeeID As String = DataGridCoffee.Item(0, select_row).Value
        sql = "select * from coffee where coffeeID ='" & coffeeID & "'"
        Dim data_keep As DataTable = cmd_excuteDataTable()
        txt_editID.Text = data_keep.Rows(0)("coffeeID")
        txt_editName.Text = data_keep.Rows(0)("coffeeName")
        txt_editHot.Text = data_keep.Rows(0)("coffeeHot")
        txt_editIced.Text = data_keep.Rows(0)("coffeeIced")
        txt_editFrappe.Text = data_keep.Rows(0)("coffeeFrappe")
        txt_editDetail.Text = data_keep(0)("coffeeDetail")





    End Sub

    Private Sub DataGridCoffee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridCoffee.CellClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txt_confirm.Text <> "CONFIRM" Then
            msg_error("Please enter CONFIRM again")
            txt_confirm.Text = ""
            txt_confirm.Select()
            Return




        End If

        Dim select_id As Integer = DataGridCoffee.CurrentRow.Index
        Dim coffeeID As String = DataGridCoffee.Item(0, select_id).Value

        sql = "delete from coffee where coffeeID = '" & coffeeID & "'"
        If cmd_excuteNonquery() = 0 Then
            msg_error("Fail to remove")
        Else
            msg_ok("Remove complete")
            txt_confirm.Text = ""
            RefreshCoffee()
            coffeesale.refresh_coffee()

        End If
    End Sub
End Class