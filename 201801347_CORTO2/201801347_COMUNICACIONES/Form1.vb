Public Class Form1
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            'limpiar_entradas()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbArticulo.Items.Add("Tablet")
        cmbArticulo.Items.Add("Drone")
        cmbArticulo.Items.Add("Celular")
        cmbArticulo.Items.Add("Televisor")
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (indice <= 6) Then
            nombre(indice) = txtNombre.Text
            salario(indice) = txtSalario.Text

            Select Case (cmbArticulo.SelectedIndex)
                Case 0 : articulo(indice) = "Tablet"
                Case 1 : articulo(indice) = "Drone"
                Case 2 : articulo(indice) = "Celular"
                Case 3 : articulo(indice) = "Televisor"
            End Select

            Select Case (cmbArticulo.SelectedIndex)
                Case 0 : comision(indice) = 0.055 * tablet
                Case 1 : comision(indice) = 0.055 * drone
                Case 2 : comision(indice) = 0.055 * celular
                Case 3 : comision(indice) = 0.055 * tele
                Case Else
                    MsgBox("ERROR, NO SELECCIONÓ ARTÍCULO")
            End Select

            If Val(salario(indice) >= 1) And Val(salario(indice) <= 2000) Then
                bono(indice) = 0.03 * salario(indice)
            ElseIf Val(salario(indice) >= 2001) And Val(salario(indice) <= 5000) Then
                bono(indice) = 0.04 * salario(indice)
            ElseIf Val(salario(indice) >= 5001) Then
                bono(indice) = 0.05 * salario(indice)
            Else
                MsgBox("ERROR, NO INGRESÓ SALARIO")
            End If

            sueldo_final(indice) = salario(indice) + comision(indice) + bono(indice)

            mostrar_vectores()
            indice = indice + 1
        End If

        If (indice = 7) Then
            MsgBox("VECTORES LLENOS")
        End If
    End Sub

    Private Sub LIMPIARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        limpiar_entradas()
    End Sub
End Class
