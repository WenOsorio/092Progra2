Public Class Form1
    Private Sub cbCompra_CheckedChanged(sender As Object, e As EventArgs) Handles chbCompra.CheckedChanged
        'código para activar el textbox para ingresar la cantidad deseada despúes de seleccionar compra
        If chbCompra.Checked = True Then
            txcompra.Enabled = True
        Else
            txcompra.Enabled = False
        End If
    End Sub

    Private Sub cbVenta_CheckedChanged(sender As Object, e As EventArgs) Handles chbVenta.CheckedChanged
        'código para activar el textobx para ingresar la cantidad deseada despúes de seleccionar venta
        If chbVenta.Checked = True Then
            txventa.Enabled = True
        Else
            txventa.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btCalcular.Click
        'muestra el resultado del calculo en un nuevo formulario
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btLimpiar.Click
        limpiar()
    End Sub

    Private Sub BtSalir_Click(sender As Object, e As EventArgs) Handles BtSalir.Click
        'código para finalizar el programa
        If MsgBox("¿Está seguro que desea salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then

        End If
        End
    End Sub

    Private Sub txcompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txcompra.KeyPress
        'código que permite únicamente el ingreso de números
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txventa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txventa.KeyPress
        'código que permite únicamente el ingreso de números
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
