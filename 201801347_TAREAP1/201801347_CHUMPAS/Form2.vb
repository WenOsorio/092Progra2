Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtpreCosto.Text = precioCosto
        txtpreVenta.Text = precioVenta
        mostrar_resultados()
    End Sub

End Class