Public Class Form1
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'Permite unicamente el ingreso de números dentro del TextBox
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If (txtCliente.Text = "") Then
            MsgBox("ERROR! NO INGRESO NOMBRE DEL CLIENTE")
            txtCliente.Focus()
            Exit Sub
        End If

        If rbSmall.Checked = False And rbMedium.Checked = False And rbLarge.Checked = False Then
            MsgBox("ERROR! NO HA SELECCIONADO NINGÚN TAMAÑO")
            Exit Sub
        End If

        If rbAlgodon.Checked = False And rbSeda.Checked = False And rbLona.Checked = False Then
            MsgBox("ERROR! NO HA SELECCIONADO NINGÚN MATERIAL")
            Exit Sub
        End If

        If TextBox1.Text = "" Then
            MsgBox("ERROR! DEBE INGRESAR LA CANTIDAD DE CHUMPAS QUE DESEA")
            TextBox1.Focus()
            Exit Sub
        End If

        Dim tamaño As String
        Dim material As String

        If rbSmall.Checked Then
            tamaño = "Small"
        ElseIf rbMedium.Checked Then
            tamaño = "Medium"
        Else
            tamaño = "Large"
        End If

        If rbAlgodon.Checked Then
            material = "Algodon"
        ElseIf rbSeda.Checked Then
            material = "Seda"
        Else
            material = "Lona"
        End If
        calcular(material, tamaño, Val(TextBox1.Text))
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiardatos()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿DESEA SALIR DE LA APLICACIÓN?", vbQuestion + vbYesNo, "salir") = vbYes Then
            End
        Else
            limpiardatos()
        End If
    End Sub
End Class
