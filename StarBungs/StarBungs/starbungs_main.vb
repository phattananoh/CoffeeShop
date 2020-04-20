Public Class starbungs_main
    Private Sub starbungs_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        If confirm("Are you sure you want yo Logout") = vbNo Then Return
        Me.Close()
        Form1.Show()
        With Form1
            .txt_Password.Text = ""
            .txt_Password.Select()


        End With
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        manage_menu.Show()
        manage_menu.MdiParent = Me
    End Sub
End Class