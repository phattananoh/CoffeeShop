Public Class coffeesale
    Private Sub coffeesale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_coffee()
        generate_saleID()
        get_datenow()
    End Sub


    Public Sub generate_saleID()
        Try
            sql = "select max(saleID) from sales"
            Dim i As Integer = cmd_excuteScalar() + 1
            lbl_saleID.Text = "SB-" & Date.Now.Year + 543 & "/" & i.ToString.PadLeft(5, "0")
        Catch ex As Exception
            lbl_saleID.Text = "SB-" & Date.Now.Year + 543 & "/00001"

        End Try

    End Sub

    Public Sub get_datenow()
        lbl_date_sale.Text = Date.Today
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
        arr(3) = "Cup"
        arr(4) = txt_coffee_amount.Text

        Dim price As Integer = 0
        If rad_hot.Checked = True Then price = dts.Rows(0)("coffeeHot")
        If rad_iced.Checked = True Then price = dts.Rows(0)("coffeeIced")
        If rad_frappe.Checked = True Then price = dts.Rows(0)("coffeeFrappe")

        Dim type_coffee As String = ""
        If rad_hot.Checked = True Then type_coffee = "Hot"
        If rad_iced.Checked = True Then type_coffee = "Iced"
        If rad_frappe.Checked = True Then type_coffee = "Frappe"

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
            msg_error("Invalid Coffee ID")
        End If
    End Sub

    Private Sub txt_coffee_id_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_coffee_id.KeyDown
        If e.KeyData = Keys.Enter Then txt_coffee_amount.Select()
    End Sub

    Private Sub btn_del_all_Click(sender As Object, e As EventArgs) Handles btn_del_all.Click
        If confirm("Are you sure you want to cancle ?") = vbNo Then Return
        ListView1.Items.Clear()
        txt_total.Text = "0.00"
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If confirm("You want to remove ?") = vbYes Then
            ListView1.Items.Remove(ListView1.FocusedItem)
            total_price()
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub btn_purchase_Click(sender As Object, e As EventArgs) Handles btn_purchase.Click
        With frm_total
            .txt_total.Text = txt_total.Text
            .txt_discount.Text = lbl_discount.Text
            .txt_total2.Text = .txt_total.Text - .txt_discount.Text

            Dim point As Integer = .txt_total2.Text / 100
            .lbl_point.Text = point
            If lbl_username.Text = "..." Or lbl_name.Text = "..." Then
                .lbl_point.Visible = False
                .lbl_add_point.Visible =False 
            Else
                .lbl_point.Visible = True
                .lbl_add_point.Visible = True

            End If



            .txt_receive.Text = ""
            .txt_receive.Select()
            .Show()
            .Activate()

        End With
    End Sub

    Private Sub lbl_saleID_Click(sender As Object, e As EventArgs) Handles lbl_saleID.Click

    End Sub

    Private Sub btn_promotion_Click(sender As Object, e As EventArgs) Handles btn_promotion.Click
        With promotion
            .Show()
            .Activate()
            .txt_code.Select()

        End With
    End Sub

    Private Sub link_select_customer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_select_customer.LinkClicked
        frm_select_customer.Show()
        frm_select_customer.Activate()

    End Sub

    Private Sub btn_customer_clear_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btn_customer_clear.LinkClicked
        lbl_username.Text = "..."
        lbl_name.Text = "..."
        lbl_point.Text = 0

    End Sub
End Class