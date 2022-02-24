Public Class Form1
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("Desea salir", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            End
        Else
            limpiar()
            txtNombre.Focus()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnCalculos_Click(sender As Object, e As EventArgs) Handles btnCalculos.Click
        If RadioButton1.Checked = True And RadioButton5.Checked = True Then
            montoseguro = monviaNorte + (seguroVehiculo * sueldobase)
        ElseIf RadioButton6.Checked = True Then
            montoseguro = monviaNorte + (seguroAccidente * sueldobase)
        End If

        If RadioButton2.Checked = True And RadioButton5.Checked = True Then
            montoseguro = monviaSur + (seguroVehiculo * sueldobase)
        ElseIf RadioButton6.Checked = True Then
            montoseguro = monviaSur + (seguroAccidente * sueldobase)
        End If

        If RadioButton3.Checked = True And RadioButton5.Checked = True Then
            montoseguro = monviaOriente + (seguroVehiculo * sueldobase)
        ElseIf RadioButton6.Checked = True Then
            montoseguro = monviaOriente + (seguroAccidente * sueldobase)
        End If

        If RadioButton4.Checked = True And RadioButton5.Checked = True Then
            montoseguro = monviaOccidente + (seguroVehiculo * sueldobase)
        ElseIf RadioButton6.Checked = True Then
            montoseguro = monviaOccidente + (seguroAccidente * sueldobase)
        Else
            MsgBox("No seleccionó región o seguro")
        End If

        sueldofinal = Val(TextBox1.Text) * (Val(txtMonto.Text)) + sueldobase
        mostrardatos()

    End Sub
End Class
