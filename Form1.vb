Public Class Form1
    Public Const g As Integer = 10 'объявление константы

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t, h, g 'ввод переменных 

        h = Val(InputBox("Введите значение высоты в метрах", "Рассчет"))
        g = 10
        t = Val(2 * h * g)
        TextBox3.Text = t

        Form2.Show()

        Form2.TextBox1.Text = TextBox3.Text
    End Sub
End Class
