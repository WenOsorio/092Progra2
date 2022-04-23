Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTipo.Items.Add("Tipo 1")
        cmbTipo.Items.Add("Tipo 2")
        cmbTipo.Items.Add("Tipo 3")
        cmbTipo.Items.Add("Tipo 4")
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (fila <= 6) Then
            placa(fila) = Val(txtPlaca.Text)
            tipo(fila) = cmbTipo.Text
            k_inicial(fila) = Val(txtKinicial.Text)
            k_final(fila) = Val(txtKfinal.Text)
            k_total(fila) = Val(txtKfinal.Text) - Val(txtKinicial.Text)

            Select Case (cmbTipo.SelectedIndex)
                Case 0 : cobro_base(fila) = "Q500"
                Case 1 : cobro_base(fila) = "Q400"
                Case 2 : cobro_base(fila) = "Q300"
                Case 3 : cobro_base(fila) = "Q200"
                Case Else
                    MsgBox("NO SELECCIONÓ TIPO DE CARRO")
            End Select

            If Val(k_total(fila) >= 0) And Val(k_total(fila) <= 50) Then
                p_final(fila) = 3 * k_total(fila) + cobro_base(fila)
            ElseIf Val(k_total(fila) >= 51) And Val(k_total(fila) <= 70) Then
                p_final(fila) = 4 * k_total(fila) + cobro_base(fila)
            ElseIf Val(k_total(fila) >= 70) Then
                p_final(fila) = 5 * k_total(fila) + cobro_base(fila)
            Else
                MsgBox("ERROR, NO INGRESÓ KILOMETRAJE")
            End If

            fila = fila + 1
                limpiar_entradas()
            End If
            If (fila = 7) Then
            MsgBox("VECTORES LLENOS")

        End If
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        mostrar_vectores()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Dim existe As Boolean = False
        I = 0
        While (I <= 6) And Not (existe)
            If (placa(I) = Val(txtConsulPlaca.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While

        If (existe) Then
            MsgBox("REGISTRO ENCONTRADO EXITOSAMENTE")
            txtPlaca.Text = Str(placa(I))
            cmbTipo.Text = (tipo(I))
            txtKinicial.Text = Str(k_inicial(I))
            txtKfinal.Text = Str(k_final(I))
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(placa(I)), tipo(I), Str(cobro_base(I)), Str(k_inicial(I)), Str(k_final(I)), Str(k_total(I)), Str(p_final(I)))
            fila = I
        Else
            MsgBox("PLACA NO ENCONTRADA")
            txtPlaca.Focus()
        End If

    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTUALIZARToolStripMenuItem.Click
        placa(fila) = Val(txtPlaca.Text)
        tipo(fila) = cmbTipo.Text
        k_inicial(fila) = Val(txtKinicial.Text)
        k_final(fila) = Val(txtKfinal.Text)
        k_total(fila) = Val(txtKfinal.Text) - Val(txtKinicial.Text)

        If Val(k_total(fila) >= 0) And Val(k_total(fila) <= 50) Then
            p_final(fila) = 3 * k_total(fila) + cobro_base(fila)
        ElseIf Val(k_total(fila) >= 51) And Val(k_total(fila) <= 70) Then
            p_final(fila) = 4 * k_total(fila) + cobro_base(fila)
        ElseIf Val(k_total(fila) >= 70) Then
            p_final(fila) = 5 * k_total(fila) + cobro_base(fila)
        End If

        MsgBox("REGISTRO ACTUALIZADO CORRECTAMENTE EN LOS VECTORES")
        fila = 7
    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        placa(fila) = Nothing
        tipo(fila) = Nothing
        cobro_base(fila) = Nothing
        k_inicial(fila) = Nothing
        k_final(fila) = Nothing
        k_total(fila) = Nothing
        p_final(fila) = Nothing

        For I = fila To 5
            placa(I) = placa(I + 1)
            tipo(I) = tipo(I + 1)
            cobro_base(I) = cobro_base(I + 1)
            k_inicial(I) = k_inicial(I + 1)
            k_final(I) = k_final(I + 1)
            k_total(I) = k_total(I + 1)
            p_final(I) = p_final(I + 1)
        Next I
        MsgBox("REGISTRO ELIMINADO EXITOSAMENTE")

        placa(fila) = Nothing
        tipo(fila) = Nothing
        cobro_base(fila) = Nothing
        k_inicial(fila) = Nothing
        k_final(fila) = Nothing
        k_total(fila) = Nothing
        p_final(fila) = Nothing

        fila = I
        limpiar_entradas()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            'limpiar_entradas()
        End If
    End Sub
End Class
