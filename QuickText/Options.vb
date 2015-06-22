Public Class Options

    Private Sub 日文_CheckedChanged(sender As Object, e As EventArgs) Handles 日文.CheckedChanged
        中文.Checked = False
        英文.Checked = False
    End Sub

    Private Sub 英文_CheckedChanged(sender As Object, e As EventArgs) Handles 英文.CheckedChanged
        中文.Checked = False
        日文.Checked = False
    End Sub

    Private Sub 中文_CheckedChanged(sender As Object, e As EventArgs) Handles 中文.CheckedChanged
        英文.Checked = False
        日文.Checked = False
    End Sub

    Private Sub 快捷功能开关_Click(sender As Object, e As EventArgs) Handles 快捷功能开关.Click
        If Main.从剪切板复制.Visible = True Then
            Main.从剪切板复制.Visible = False
            Main.从剪切板复制.Visible = False
            快捷功能开关.Text = "快捷功能 关"
        Else
            Main.从剪切板复制.Visible = True
            Main.复制到剪切板.Visible = True
            快捷功能开关.Text = "快捷功能 开"
        End If

    End Sub

End Class
