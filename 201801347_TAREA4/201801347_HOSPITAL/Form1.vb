Public Class Form1
    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click

        Select Case (cmbHabitacion.SelectedIndex)
            Case 0 : calculo_servicio_priv()
            Case 1 : calculo_servicio_semi()
            Case 2 : calculo_servicio_no()
        End Select

        If index < 6 Then
            paciente(index) = txtPaciente.Text
            nit(index) = txtNit.Text
            dias(index) = txtDias.Text
            honorarios(index) = txtHonorarios.Text
            habitacion(index) = cmbHabitacion.SelectedItem

            If chbEncamamiento.Checked Then
                servicio(index) = "Encamamiento"
            End If

            If chbOperacion.Checked Then
                servicio(index) = "Operación"
            End If

            If chbMaternidad.Checked Then
                servicio(index) = "Maternidad"
            End If

            pago(index) = pago(index)

            If RadioButton3.Checked = True Then
                    recargo(index) = pago(index) * recargo_credito
                End If

                If RadioButton1.Checked = True Or RadioButton2.Checked = True Or RadioButton4.Checked = True Then
                    calc_desc()
                End If

                total(index) = calc_total()

                DataGridView1.Rows.Add(paciente(index), nit(index), dias(index), honorarios(index), servicio(index), habitacion(index), pago(index), descuento(index), recargo(index), total(index))

                index = index + 1
            End If

    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "salir") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem.Click
        limpiarentradas()
    End Sub

    Private Sub VectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VectoresToolStripMenuItem.Click
        limpiarvectores()
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbHabitacion.Items.Add("Privada")
        cmbHabitacion.Items.Add("Semi Privada")
        cmbHabitacion.Items.Add("No Privada")

    End Sub
End Class
