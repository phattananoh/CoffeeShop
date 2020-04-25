Public Class promotion
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_code.TextChanged

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub

    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click
        sql = "select * from promotions where promotion_coupon = '" & txt_code.Text & "' AND promotion_count  >= 1"
        Dim dts As DataTable = cmd_excuteDataTable()
        If dts.Rows.Count = 0 Then
            msg_error("Invalid Code Or Expired Code")
            Return
        End If

        lbl_condition.Text = dts.Rows(0)("promotion_condition")
        lbl_discount.Text = dts.Rows(0)("promotion_discount")
        txt_code.Enabled = False
        btn_apply.Enabled = False

    End Sub

    Private Sub promotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bnt_confirm_Click(sender As Object, e As EventArgs) Handles bnt_confirm.Click
        sql = "update promotions set promotion_count = promotion_count - 1 where promotion_coupon = '" & txt_code.Text & "'"
        If cmd_excuteNonquery() = 0 Then
            msg_error("Invalid Coupon")
        Else
            msg_ok("Success")
            coffeesale.lbl_discount.Text = lbl_discount.Text
            Me.Close()

        End If


    End Sub

    Private Sub lbl_discount_Click(sender As Object, e As EventArgs) Handles lbl_discount.Click

    End Sub
End Class