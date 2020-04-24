Public Class manage_promotion
    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        If txt_count.Text = "" Or txt_code.Text = "" Or txt_discount.Text = "" Then
            msg_error("Please Enter all textbox")
            Return


        End If

        If confirm("Confirm Add?") = vbNo Then Return
        sql = String.Format("insert into promotions(promotion_coupon,promotion_condition,promotion_discount,promotion_count) values('{0}','{1}','{2}','{3}')", txt_code.Text, txt_condition.Text, txt_discount.Text, txt_count.Text)

        If cmd_excuteNonquery() = 0 Then
            msg_error("Fail")
        Else
            msg_ok("complete")
            txt_code.Text = ""
            txt_condition.Text = ""
            txt_discount.Text = ""
            txt_count.Text = ""
            refresh_coupon()

        End If

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub manage_promotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_coupon()
    End Sub

    Public Sub refresh_coupon()
        sql = "select * from promotions"
        DatagridAll.DataSource = cmd_excuteDataTable()
        sql = "select * from promotions where promotion_count = 0"
        DatagridExpried.DataSource = cmd_excuteDataTable()
        head_change()

        lbl_total1.Text = DatagridAll.RowCount
        lbl_total2.Text = DatagridExpried.RowCount
    End Sub

    Public Sub head_change()
        Dim head() As String = {"ID", "Code", "Detail", "Discount", "Reamin"}
        For i As Integer = 0 To head.Length - 1
            DatagridAll.Columns(i).HeaderText = head(i)
            DatagridExpried.Columns(i).HeaderText = head(i)

        Next
    End Sub

    Private Sub lbl_total2_Click(sender As Object, e As EventArgs) Handles lbl_total2.Click

    End Sub

    Private Sub coupon_add_Click(sender As Object, e As EventArgs) Handles coupon_add.Click
        Dim i As Integer = DatagridAll.CurrentRow.Index
        Dim coupon As String = DatagridAll.Item(1, i).Value

        sql = "update promotions set promotion_count = promotion_count + " & txt_coupon_Add.Text & "where promotion_coupon = '" & coupon & "'"
        If cmd_excuteNonquery() = 0 Then
            msg_error("Fail")
        Else
            msg_ok("Complete")
            refresh_coupon()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = DatagridAll.CurrentRow.Index
        Dim coupon As String = DatagridAll.Item(1, i).Value
        sql = "delete from promotions where promotion_coupon = '" & coupon & "'"
        If cmd_excuteNonquery() = 0 Then
            msg_error("Fail")
        Else
            msg_ok("Complete")
            refresh_coupon()

        End If
    End Sub
End Class