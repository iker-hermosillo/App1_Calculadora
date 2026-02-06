Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Numero1 As Integer = Integer.Parse(TextBox1.Text)
        Dim Numero2 As Integer = Integer.Parse(TextBox2.Text)

        Dim resultado As Integer = Numero1 + Numero2

        Label4.Text = resultado.ToString()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim numero1 As Integer = Integer.Parse(TextBox1.Text)
        Dim numero2 As Integer = Integer.Parse(TextBox2.Text)

        Dim resultado As Integer = numero1 - numero2

        Label4.Text = resultado.ToString()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim numero1 As Integer = Integer.Parse(TextBox1.Text)
        Dim numero2 As Integer = Integer.Parse(TextBox2.Text)

        Dim resultado As Integer = numero1 * numero2

        Label4.Text = resultado.ToString()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim numero1 As Integer = Integer.Parse(TextBox1.Text)
        Dim numero2 As Integer = Integer.Parse(TextBox2.Text)

        Dim resultado As Integer = numero1 / numero2

        Label4.Text = resultado.ToString()

    End Sub
End Class
