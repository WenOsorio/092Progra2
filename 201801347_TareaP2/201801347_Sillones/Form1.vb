Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTamaño.Items.Add("Sofá")
        cmbTamaño.Items.Add("Individual")
        cmbTamaño.Items.Add("Doble")
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            limpiar_entradas()
        End If
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (indice <= 7) Then
            no_venta(indice) = txtNoV.Text
            tamaño(indice) = cmbTamaño.Text
            cantidad(indice) = txtCantidad.Text

            If rbtnCuero.Checked Then
                material(indice) = "Cuero"
            ElseIf rbtnCuerina.Checked Then
                material(indice) = "Cuerina"
            Else
                MsgBox("ERROR, NO SELECCIONÓ MATERIAL")
            End If

            Select Case (cmbTamaño.SelectedIndex)
                Case 0 : mano_obra(indice) = mo_Sofa
                Case 1 : mano_obra(indice) = mo_Individual
                Case 2 : mano_obra(indice) = mo_Doble
                Case Else
                    MsgBox("ERROR, NO SELECCIONÓ TAMAÑO")
            End Select

            If rbtnCuero.Checked Then
                p_parcial(indice) = cantidad(indice) * cuero
            ElseIf rbtnCuerina.Checked Then
                p_parcial(indice) = cantidad(indice) * cuerina
            Else
                MsgBox("ERROR, NO INGRESÓ CANTIDAD DE SILLONES")
            End If

            Select Case cmbTamaño.SelectedIndex
                Case 0 : p_costo(indice) = yd_Sofa * p_parcial(indice) + mo_Sofa
                Case 1 : p_costo(indice) = yd_Individual * p_parcial(indice) + mo_Individual
                Case 2 : p_costo(indice) = yd_Doble * p_parcial(indice) + mo_Doble

            End Select

            p_venta(indice) = Math.Round(p_costo(indice) + p_costo(indice) * 0.65, 2)

            DataGridView1.Rows.Add(no_venta(indice), tamaño(indice), cantidad(indice), material(indice), p_parcial(indice), mano_obra(indice), p_costo(indice), p_venta(indice))
            indice = indice + 1

        End If

        If (indice = 8) Then
            MsgBox("VECTORES LLENOSNO SE PERMITEN MAS INGRESOS")
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        limpiar_vectores()
    End Sub
End Class
