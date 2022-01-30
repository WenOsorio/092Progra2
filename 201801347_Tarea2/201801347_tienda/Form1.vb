Imports System.Math
Public Class Form1

    'acá se declaran las constantes de los diferentes precios 
    Const precioarroz As Double = 2.0
    Const preciofrijol As Double = 1.75
    Const precioazucar As Double = 2.5
    Const iva As Double = 0.12

    'acá se declaran las variables con su respectivo tipo
    Dim pagosiniva As Double = 0
    Dim valoriva As Double = 0
    Dim pagoconIVA As Double = 0
    Dim descuento As Double = 0
    Dim pagofinal As Double = 0


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'acá se encuentra el código en relación a los cálculos de cada pago
        pagosiniva = Round((Val(txtarroz.Text) * precioarroz) + (Val(txtfrijol.Text) * preciofrijol) + (Val(txtazucar.Text) * precioazucar), 2)
        valoriva = Round(pagosiniva * iva, 2)
        pagoconIVA = Round(pagosiniva + valoriva, 2)
        descuento = Round(pagoconIVA * 0.025, 2)
        pagofinal = Round(pagoconIVA - descuento, 2)

        txtcalc1.Text = pagosiniva
        txtcalc2.Text = valoriva
        txtcalc3.Text = pagoconIVA
        txtcalc4.Text = descuento
        txtcalc5.Text = pagofinal


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        'acá se encuentra el código en relación a limpiar cada variable
        txtarroz.Clear()
        txtfrijol.Clear()
        txtazucar.Clear()

        txtcalc1.Clear()
        txtcalc2.Clear()
        txtcalc3.Clear()
        txtcalc4.Clear()
        txtcalc5.Clear()

        'lo siguiente indica que el cursor se encontrará en el primer TextBox colocado
        txtarroz.Focus()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'acá se encuentra el código para salir de la aplicación
        If MsgBox("¿Desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If

    End Sub

    Private Sub txtarroz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtarroz.KeyPress
        'acá se encuentra el código el cual permite el ingreso unicamente de números
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtfrijol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfrijol.KeyPress
        'acá se encuentra el código el cual permite el ingreso unicamente de números
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtazucar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtazucar.KeyPress
        'acá se encuentra el código el cual permite el ingreso unicamente de números
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class
