Public Class Form1
    Dim activo

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SUMAR.Click

        Dim Numero1 As Double = Double.Parse(TXTBXnum1.Text)
        Dim Numero2 As Double = Double.Parse(TXTBXnum2.Text)

        Dim resultado As Double = Numero1 + Numero2

        Label4.Text = resultado.ToString()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles RESTAR.Click

        Dim numero1 As Double = Double.Parse(TXTBXnum1.Text)
        Dim numero2 As Double = Double.Parse(TXTBXnum2.Text)

        Dim resultado As Double = numero1 - numero2

        Label4.Text = resultado.ToString()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles MULTIPLICAR.Click

        Dim numero1 As Double = Double.Parse(TXTBXnum1.Text)
        Dim numero2 As Double = Double.Parse(TXTBXnum2.Text)

        Dim resultado As Double = numero1 * numero2

        Label4.Text = resultado.ToString()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles DIVIDIR.Click

        Dim resultado

        Dim numero1 As Double = Double.Parse(TXTBXnum1.Text)
        Dim numero2 As Double = Double.Parse(TXTBXnum2.Text)

        If numero2 > 0 Then
            resultado = numero1 / numero2
        Else
            resultado = "No se puede"
        End If

        Label4.Text = resultado.ToString()

    End Sub

    Private Sub boton0_Click(sender As Object, e As EventArgs) Handles boton0.Click
        activo.Text = activo.Text & "0"
    End Sub

    Private Sub boton1_Click(sender As Object, e As EventArgs) Handles boton1.Click
        activo.Text = activo.Text & "1"
    End Sub

    Private Sub boton2_Click(sender As Object, e As EventArgs) Handles boton2.Click
        activo.Text = activo.Text & "2"
    End Sub

    Private Sub boton3_Click(sender As Object, e As EventArgs) Handles boton3.Click
        activo.Text = activo.Text & "3"
    End Sub

    Private Sub boton4_Click(sender As Object, e As EventArgs) Handles boton4.Click
        activo.Text = activo.Text & "4"
    End Sub

    Private Sub boton5_Click(sender As Object, e As EventArgs) Handles boton5.Click
        activo.Text = activo.Text & "5"
    End Sub

    Private Sub boton6_Click(sender As Object, e As EventArgs) Handles boton6.Click
        activo.Text = activo.Text & "6"
    End Sub

    Private Sub boton7_Click(sender As Object, e As EventArgs) Handles boton7.Click
        activo.Text = activo.Text & "7"
    End Sub

    Private Sub boton8_Click(sender As Object, e As EventArgs) Handles boton8.Click
        activo.Text = activo.Text & "8"
    End Sub

    Private Sub boton9_Click(sender As Object, e As EventArgs) Handles boton9.Click
        activo.Text = activo.Text & "9"
    End Sub

    Private Sub botonC_Click(sender As Object, e As EventArgs) Handles botonC.Click
        activo.Text = ""
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        activo.Text = activo.Text & "."
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        activo = TXTBXnum1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        activo = TXTBXnum2
    End Sub
End Class
