Public Class Form1
    Private Sub ACEPTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACEPTARToolStripMenuItem.Click
        If (fila <= 6) Then
            cine(fila, 0) = Val(txtNit.Text)
            cine(fila, 1) = txtPeli.Text
            cine(fila, 2) = Val(txtBoletos.Text)

            If (cbNormal.Checked) Then
                cine(fila, 3) = cbNormal.Text
            ElseIf (cb3D.Checked) Then
                cine(fila, 3) = cb3D.Text
            ElseIf (cb4DX.Checked) Then
                cine(fila, 3) = cb4DX.Text
            Else
                MsgBox("Error, no seleccionó sala")
                Exit Sub
            End If

            If (cbNormal.Checked) Then
                cine(fila, 4) = P_Sala1 * cine(fila, 2)
            ElseIf (cb3D.Checked) Then
                cine(fila, 4) = P_Sala2 * cine(fila, 2)
            ElseIf (cb4DX.Checked) Then
                cine(fila, 4) = P_Sala3 * cine(fila, 2)
            Else
                MsgBox("Error, no ingró cantidad de boletos")
            Exit Sub
        End If

        'If (cbNormal.Checked) Or (cb3D.Checked) Or (cb4DX.Checked) Then
        ' cine(fila, 4) = P_Sala1 * cine(fila, 2) + P_Sala2 * cine(fila, 2) + P_Sala3 * cine(fila, 2)
        'Else
        'MsgBox("Error, no ingró cantidad de boletos")
        'Exit Sub
        'End If

        fila = fila + 1
            limpiar_entradas()
        End If

        If (fila = 7) Then
            MsgBox("Matriz llena")
        End If
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        mostrar_matriz()
    End Sub

    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        limpiar_matriz()
    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTUALIZARToolStripMenuItem.Click
        cine(fila, 0) = txtNit.Text
        cine(fila, 1) = txtPeli.Text
        cine(fila, 2) = txtBoletos.Text

        If (cbNormal.Checked) Then
            cine(fila, 3) = cbNormal.Text
        ElseIf (cb3D.Checked) Then
            cine(fila, 3) = cb3D.Text
        ElseIf (cb4DX.Checked) Then
            cine(fila, 3) = cb4DX.Text
        End If

        If (cbNormal.Checked) Then
            cine(fila, 4) = P_Sala1 * cine(fila, 2)
        ElseIf (cb3D.Checked) Then
            cine(fila, 4) = P_Sala2 * cine(fila, 2)
        ElseIf (cb4DX.Checked) Then
            cine(fila, 4) = P_Sala3 * cine(fila, 2)
        End If

        'If (cbNormal.Checked) Or (cb3D.Checked) Or (cb4DX.Checked) Then
        'cine(fila, 4) = P_Sala1 * cine(fila, 2) + P_Sala2 * cine(fila, 2) + P_Sala3 * cine(fila, 2)
        'End If

        MsgBox("Registro actualizado correctamente en la matriz")
        fila = 7
        limpiar_entradas()

    End Sub

    Private Sub BUSCARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BUSCARToolStripMenuItem.Click
        Dim existe As Boolean = True
        I = 0
        While (I <= 6) And (existe)
            If (cine(I, 0) <> Nothing) Then
                If (Val(cine(I, 0)) = Val(txtConsulta.Text)) Then
                    existe = False
                Else
                    I = I + 1
                End If
            Else
                Exit While
            End If
        End While

        If (existe) Then
            MsgBox("Nit no encontrado")
            txtConsulta.Focus()
        Else
            MsgBox("Registro Encontrado exitosamente")
            txtNit.Text = cine(I, 0)
            txtPeli.Text = cine(I, 1)
            txtBoletos.Text = cine(I, 2)

            If (cine(I, 3) = "Normal") Then
                cbNormal.Checked = True
            ElseIf (cine(I, 3) = "3D") Then
                cb3D.Checked = True
            ElseIf (cine(I, 3) = "4DX") Then
                cb3D.Checked = True
            End If

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(cine(I, 0), cine(I, 1), cine(I, 2), cine(I, 3), cine(I, 4))

            fila = I
        End If

    End Sub
End Class
