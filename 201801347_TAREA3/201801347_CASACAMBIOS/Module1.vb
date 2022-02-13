Module Module1
    'Se procede a declarar constates
    Public Const cambioDolar = 7.69
    Public Const cambioPesos = 0.38
    Public Const cambioEuro = 7.89
    Public Const cambioColones = 0.012
    Const comiCompra = 2.5 / 100
    Const comiVenta = 3 / 100
    'Se procede a declarar variables
    Dim total_parcial = 0
    Dim total

    Sub limpiar()
        'se procede a limpiar las variables
        Form1.txcompra.Clear()
        Form1.txventa.Clear()
        Form1.chbCompra.Checked = False
        Form1.chbVenta.Checked = False
        Form1.CCDolar.Checked = False
        Form1.CCPesos.Checked = False
        Form1.CCEuro.Checked = False
        Form1.CCColones.Checked = False
        Form1.CVDolar.Checked = False
        Form1.CVPesos.Checked = False
        Form1.CVEuro.Checked = False
        Form1.CVColones.Checked = False

        Form2.Label1.Text = "Limpio"
        Form2.Label3.Text = "Limpio"

    End Sub

    Function calcularCompra(cantCompra As Double, tipoCompra As Double) As Double
        'calculo en relación a la compra
        If cantCompra > 0 Then
            total_parcial = cantCompra / tipoCompra
            total = total_parcial * comiCompra + total_parcial
        End If


        Return Math.Round(total, 2)
    End Function

    Function calcularVenta(cantVenta As Double, tipoVenta As Double) As Double
        'calculo en relación a la venta
        If cantVenta > 0 Then
            total_parcial = cantVenta * tipoVenta
            total = total_parcial * comiVenta + total_parcial
        End If


        Return Math.Round(total, 2)
    End Function

End Module
