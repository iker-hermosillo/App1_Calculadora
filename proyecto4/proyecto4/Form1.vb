Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SUMAR.Click

        Dim Numero1 As Double = Double.Parse(TXTBXnum1.Text)
        Dim Numero2 As Integer = Integer.Parse(TXTBXnum2.Text)

        Dim resultado As Integer = Numero1 + Numero2

        Label4.Text = resultado.ToString()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles RESTAR.Click

        Dim numero1 As Integer = Integer.Parse(TXTBXnum1.Text)
        Dim numero2 As Integer = Integer.Parse(TXTBXnum2.Text)

        Dim resultado As Integer = numero1 - numero2

        Label4.Text = resultado.ToString()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles MULTIPLICAR.Click

        Dim numero1 As Integer = Integer.Parse(TXTBXnum1.Text)
        Dim numero2 As Integer = Integer.Parse(TXTBXnum2.Text)

        Dim resultado As Integer = numero1 * numero2

        Label4.Text = resultado.ToString()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles DIVIDIR.Click

        Dim numero1 As Integer = Integer.Parse(TXTBXnum1.Text)
        Dim numero2 As Integer = Integer.Parse(TXTBXnum2.Text)

        Dim resultado As Integer = numero1 / numero2

        Label4.Text = resultado.ToString()

    End Sub

    Private Sub boton0_Click(sender As Object, e As EventArgs) Handles boton0.Click
        TXTBXnum1.Text = TXTBXnum1.Text & "0"
    End Sub

    Private Sub boton1_Click(sender As Object, e As EventArgs) Handles boton1.Click
        TXTBXnum1.Text = TXTBXnum1.Text & "1"
    End Sub

    Private Sub boton2_Click(sender As Object, e As EventArgs) Handles boton2.Click
        TXTBXnum1.Text = TXTBXnum1.Text & "2"
    End Sub

    Private Sub boton3_Click(sender As Object, e As EventArgs) Handles boton3.Click
        TXTBXnum1.Text = TXTBXnum1.Text & "3"
    End Sub

    Private Sub boton4_Click(sender As Object, e As EventArgs) Handles boton4.Click
        TXTBXnum1.Text = TXTBXnum1.Text & "4"
    End Sub

    Private Sub boton5_Click(sender As Object, e As EventArgs) Handles boton5.Click
        TXTBXnum1.Text = TXTBXnum1.Text & "5"
    End Sub

    Private Sub boton6_Click(sender As Object, e As EventArgs) Handles boton6.Click
        TXTBXnum1.Text = TXTBXnum1.Text & "6"
    End Sub

    Private Sub boton7_Click(sender As Object, e As EventArgs) Handles boton7.Click
        TXTBXnum1.Text = TXTBXnum1.Text & "7"
    End Sub

    Private Sub boton8_Click(sender As Object, e As EventArgs) Handles boton8.Click
        TXTBXnum1.Text = TXTBXnum1.Text & "8"
    End Sub

    Private Sub boton9_Click(sender As Object, e As EventArgs) Handles boton9.Click
        TXTBXnum1.Text = TXTBXnum1.Text & "9"
    End Sub

    Private Sub botonC_Click(sender As Object, e As EventArgs) Handles botonC.Click
        TXTBXnum1.Text = ""
    End Sub
End Class
