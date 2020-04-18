Public Class frm_main
    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If confirm("คุณต้องการออกจากระบบหรือไม่ ?") = vbNo Then Return
        Me.Close()
        frm_login.Show()
        With frm_login

            .txt_password.Text = ""
            .txt_password.Select()

        End With

    End Sub
End Class