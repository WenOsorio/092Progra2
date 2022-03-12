Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbIdioma.Items.Add("Inglés")
        cmbIdioma.Items.Add("Portugués")
        cmbIdioma.Items.Add("Francés")
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (columna1 <= 8) Then

            idiomas(columna1, 0) = txtCarnet.Text
            idiomas(columna1, 1) = txtNombre.Text
            idiomas(columna1, 2) = txtFecha.Text
            idiomas(columna1, 3) = cmbIdioma.Text
            idiomas(columna1, 4) = txtHoras.Text

            Select Case cmbIdioma.SelectedIndex
                Case 0 : idiomas(columna1, 7) = Str(Val(idiomas(columna1, 4) * 150))
                Case 1 : idiomas(columna1, 7) = Str(Val(idiomas(columna1, 4) * 80))
                Case 2 : idiomas(columna1, 7) = Str(Val(idiomas(columna1, 4) * 125))
                Case Else
                    MsgBox("ERROR, NO SELECCIONÓ IDIOMA")
                    Exit Sub
            End Select

            If rbtnEfectivo.Checked Then
                idiomas(columna1, 6) = rbtnEfectivo.Text
                idiomas(columna1, 8) = Str(Val(idiomas(columna1, 7) * 0.02))
            ElseIf rbtnCheque.Checked Then
                idiomas(columna1, 6) = rbtnCheque.Text
                idiomas(columna1, 8) = Str(Val(idiomas(columna1, 7) * 0.015))
            Else
                MsgBox("ERROR, NO SELECCIONÓ FORMA DE PAGO")
                Exit Sub
            End If

            If chbViernes.Checked And chbSabado.Checked Then
                idiomas(columna1, 5) = "Viernes y Sábado"
                idiomas(columna1, 8) = Str(Val(idiomas(columna1, 7) * 0.05))
            ElseIf chbViernes.Checked Then
                idiomas(columna1, 5) = chbViernes.Text '"Viernes"
            ElseIf chbSabado.Checked Then
                idiomas(columna1, 5) = chbSabado.Text '"Sábado"
            Else
                MsgBox("ERROR, NO SELECCIONÓ DÍA")
                Exit Sub
            End If

            If txtCarnet.Text = "" Then
                MsgBox("ERROR, NO INGRESÓ CARNET")
                Exit Sub
                txtCarnet.Focus()
            ElseIf txtNombre.Text = "" Then
                MsgBox("ERROR, NO INGRESÓ NOMBRE")
                Exit Sub
                txtNombre.Focus()
            ElseIf txtFecha.Text = "" Then
                MsgBox("ERROR, NO INGRESÓ FECHA DE INSCRIPCIÓN")
                Exit Sub
                txtFecha.Focus()
            ElseIf txtHoras.Text = "" Then
                MsgBox("ERROR, NO INGRESÓ CANTIDAD DE HORAS")
                Exit Sub
                txtHoras.Focus()
            End If

            'pago_final = pago_parcial - descuento
            idiomas(columna1, 9) = Str(Val(idiomas(columna1, 7)) - Val(idiomas(columna1, 8)))
            mostrar_datos()
            columna1 = columna1 + 1

        End If

        If (columna1 = 8) Then
            MsgBox("MATRIZ LLENA")
        End If

    End Sub

    Private Sub MATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MATRIZToolStripMenuItem.Click
        columna1 = 0
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub ENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENTRADASToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "salir") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub VECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VECTORESToolStripMenuItem.Click
        limpiar_vectores()
    End Sub
End Class
