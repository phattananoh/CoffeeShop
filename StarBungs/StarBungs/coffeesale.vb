Public Class coffeesale
    Private Sub coffeesale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_coffee()
    End Sub

    Public Sub total_price()
        txt_total.Text = Sum_Column_Currency(ListView1, 6)
    End Sub
    Public Sub refresh_coffee()
        sql = "select coffeeID,coffeeName,coffeeDetail from coffee"
        Dim data_table As DataTable = cmd_excuteDataTable()

        Load_Sale_item(ImageList1, ListView2, data_table, My.Resources.default_coffee, "coffeeDetail", "coffeeID", "coffeeName")
    End Sub
    Public Sub search_coffee()
        sql = String.Format("select coffeeID,coffeeName,coffeeDetail from coffee where coffeeID like '%{0}%' OR coffeeName like '%{0}%'", txt_search.Text)
        Dim data_table As DataTable = cmd_excuteDataTable()

        Load_Sale_item(ImageList1, ListView2, data_table, My.Resources.default_coffee, "coffeeDetail", "coffeeID", "coffeeName")
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyData = Keys.Enter Then
            search_coffee()
        End If
    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged
        Dim select_coffee As String = ListView2.FocusedItem.Text
        Dim coffee_split() As String = select_coffee.Split("|")
        coffee_split(0) = coffee_split(0).ToString.Trim

        sql = "select * from coffee where coffeeID='" & coffee_split(0) & "'"
        Dim data_table As DataTable = cmd_excuteDataTable()
        Dim Hot, Iced, Frappe As Integer
        Hot = data_table.Rows(0)("coffeeHot")
        Iced = data_table.Rows(0)("coffeeIced")
        Frappe = data_table.Rows(0)("coffeeFrappe")
        Dim coffeeID, coffeeName As String
        coffeeID = data_table.Rows(0)("coffeeID")
        coffeeName = data_table.Rows(0)("coffeeName")


        With frm_selectprice
            .lbl_hot.Text = Hot
            .lbl_iced.Text = Iced
            .lbl_frappe.Text = Frappe

            .lbl_coffeeID.Text = coffeeID
            .lbl_coffeeName.Text = coffeeName

        End With

        frm_selectprice.Show()
        frm_selectprice.TopMost = True
        frm_selectprice.txt_amount.Text = ""



    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_coffee_id.Text = "" Or txt_coffee_amount.Text = "" Then
            msg_error("ไม่สามารถเว้นว่าง id หรือ จำนวนได้")
            Return
        End If
        sql = "select * from coffee where coffeeID='" & txt_coffee_id.Text & "'"
        Dim dts As DataTable = cmd_excuteDataTable()


        Dim arr(7) As String

        arr(0) = ListView1.Items.Count + 1
        arr(1) = dts.Rows(0)("coffeeID")
        arr(2) = dts.Rows(0)("coffeeName")
        arr(3) = "แก้ว"
        arr(4) = txt_coffee_amount.Text

        Dim price As Integer = 0
        If rad_hot.Checked = True Then price = dts.Rows(0)("coffeeHot")
        If rad_iced.Checked = True Then price = dts.Rows(0)("coffeeIced")
        If rad_frappe.Checked = True Then price = dts.Rows(0)("coffeeFrappe")

        Dim type_coffee As String = ""
        If rad_hot.Checked = True Then type_coffee = "ร้อน"
        If rad_iced.Checked = True Then type_coffee = "เย็น"
        If rad_frappe.Checked = True Then type_coffee = "ปั่น"

        arr(3) &= "/" & type_coffee


        arr(5) = price
        arr(6) = arr(4) * arr(5)
        Dim itm As New ListViewItem(arr)
        ListView1.Items.Add(itm)
        total_price()
    End Sub

    Private Sub txt_coffee_id_Leave(sender As Object, e As EventArgs) Handles txt_coffee_id.Leave
        sql = "select * from coffee where coffeeID='" & txt_coffee_id.Text & "'"
        Dim i As Integer = cmd_excuteScalar()
        If i <= 0 And txt_coffee_id.Text <> "" Then
            msg_error("ไม่พบรหัสกาแฟนี้ กรุณาแก้ไขหรือว่างไว้")
        End If
    End Sub

    Private Sub txt_coffee_id_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_coffee_id.KeyDown
        If e.KeyData = Keys.Enter Then txt_coffee_amount.Select()
    End Sub

    Private Sub btn_del_all_Click(sender As Object, e As EventArgs) Handles btn_del_all.Click
        If confirm("ต้องการยกเลิกหรือไม่ ?") = vbNo Then Return
        ListView1.Items.Clear()
        txt_total.Text = "0.00"
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If confirm("คุณต้องการจะลบรายการนี้หรือไม่ ?") = vbYes Then
            ListView1.Items.Remove(ListView1.FocusedItem)
            total_price()
        End If
    End Sub
End Class