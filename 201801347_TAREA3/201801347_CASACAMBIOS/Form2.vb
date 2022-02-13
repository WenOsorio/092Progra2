Public Class Form2
    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'nos regresa al formulario 1 luego de ver los resultados y cerrar el segundo formulario
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'se procede a presentar los cálculos en relación a la compra
        If Form1.CCDolar.Checked Then
            Label1.Text = "Cantidad de compra en Dolares: " + Str(calcularCompra(Form1.txcompra.Text, cambioDolar))
        ElseIf Form1.CCPesos.Checked Then
            Label1.Text = "Cantidad de compra en Pesos Mexicanos: " + Str(calcularCompra(Form1.txcompra.Text, cambioPesos))
        ElseIf Form1.CCEuro.Checked Then
            Label1.Text = "Cantidad de compra en Euros: " + Str(calcularCompra(Form1.txcompra.Text, cambioEuro))
        ElseIf Form1.CCColones.Checked Then
            Label1.Text = "Cantidad de compra en Colones Costarricense: " + Str(calcularCompra(Form1.txcompra.Text, cambioColones))
        Else
            Label1.Text = 0

        End If

        'se procede a presentar los cálculos en relación a la venta
        If Form1.CVDolar.Checked Then
            Label3.Text = "Cantidad de venta en Dolares: " + Str(calcularVenta(Form1.txventa.Text, cambioDolar))
        ElseIf Form1.CVPesos.Checked Then
            Label3.Text = "Cantidad de venta en Pesos Mexicanos: " + Str(calcularVenta(Form1.txventa.Text, cambioPesos))
        ElseIf Form1.CVEuro.Checked Then
            Label3.Text = "Cantidad de venta en Euros: " + Str(calcularVenta(Form1.txventa.Text, cambioEuro))
        ElseIf Form1.CVColones.Checked Then
            Label3.Text = "Cantidad de venta en Colones Costarricense: " + Str(calcularVenta(Form1.txventa.Text, cambioColones))
        Else
            Label3.Text = 0

        End If



    End Sub
End Class