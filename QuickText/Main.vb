Public Class Main

    Private Sub 设置_Click(sender As Object, e As EventArgs) Handles 设置.Click
        If Options.Visible = False Then
            Options.Visible = True
        Else
            Options.Visible = False
        End If
    End Sub

    Private Sub 从剪切板复制_Click(sender As Object, e As EventArgs) Handles 从剪切板复制.Click
        主编辑区.Text = Clipboard.GetText
    End Sub

    Private Sub 复制到剪切板_Click(sender As Object, e As EventArgs) Handles 复制到剪切板.Click
        Clipboard.SetText(主编辑区.Text)
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Options.字号.Text = 24


        '这里!!!!
        '很多问题!!!!!!!
        '类型无法转换!
        '从文件夹读取!



        Options.字号.Text = "当前字号" & Options.字号.Text
        主编辑区.Font = New Font("MSYaHei", Options.字号.Text)

End Class
