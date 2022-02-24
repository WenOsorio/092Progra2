Public Class Form1
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿DESEA SALIR DE LA APLICACIÓN?", vbQuestion + vbYesNo, "salir") = vbYes Then
            End
        Else
            limpiardatos()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiardatos()
    End Sub

    Private Sub cbSimples_CheckedChanged(sender As Object, e As EventArgs) Handles cbSimples.CheckedChanged
        If cbSimples.Checked = True Then
            txtdato1.Visible() = True
            txtdato2.Visible() = True
        Else
            txtdato1.Visible() = False
            txtdato2.Visible() = False
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If cbSimples.Checked = False And cbVarias.Checked = False Then
            MsgBox("ERROR! NO HA SELECCIONADO NINGUNA OPCIÓN")
            Exit Sub
        End If

        If txtdato1.Text = "" Then
            MsgBox("ERROR! NO INGRESO DATO 1")
            txtdato1.Focus()
            Exit Sub
        End If

        If txtdato2.Text = "" Then
            MsgBox("ERROR! NO INGRESO DATO 2")
            txtdato2.Focus()
            Exit Sub
        End If

        ''If txtdatoVar.Text = "" Then
        'MsgBox("ERROR! NO INGRESO NINGÚN DATO")
        'txtdatoVar.Focus()
        'Exit Sub
        'End If

        If rbSuma.Checked = False And rbResta.Checked = False And rbMultiplicacion.Checked = False And rbDivision.Checked = False And rbpot2.Checked = False And rbraiz2.Checked = False And rbsen.Checked = False And rbcos.Checked = False Then
            MsgBox("ERROR! NO HA SELECCIONADO NINGUNA OPERACIÓN")
            Exit Sub
        End If

        Dim dato1 As Double, dato2 As Double
        Dim totsuma As Double
        Dim totresta As Double
        Dim totmultiplicacion As Double
        Dim totdivision As Double
        dato1 = txtdato1.Text
        dato2 = txtdato2.Text

        If rbSuma.Checked = True Then
            totsuma = dato1 + dato2
            txtResultado.Text = totsuma
        End If
        If rbResta.Checked = True Then
            totresta = dato1 - dato2
            txtResultado.Text = totresta
        End If
        If rbMultiplicacion.Checked = True Then
            totmultiplicacion = dato1 * dato2
            txtResultado.Text = totmultiplicacion
        End If
        If rbDivision.Checked = True Then
            totdivision = dato1 / dato2
            txtResultado.Text = totdivision
        End If

    End Sub

    Private Sub cbVarias_CheckedChanged(sender As Object, e As EventArgs) Handles cbVarias.CheckedChanged
        If cbVarias.Checked = True Then
            txtdatoVar.Visible() = True
        Else
            txtdatoVar.Visible() = False
        End If
    End Sub

    Private Sub txtdato1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdato1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtdato2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdato2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtdatoVar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdatoVar.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
