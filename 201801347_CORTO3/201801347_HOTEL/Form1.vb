Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbHabitacion.Items.Add("Sencilla")
        cmbHabitacion.Items.Add("Doble")
        cmbHabitacion.Items.Add("Cabaña")

        cmbPago.Items.Add("Efectivo")
        cmbPago.Items.Add("Tarjeta")
        cmbPago.Items.Add("Transferencia")
        cmbPago.Items.Add("Depósito")
    End Sub

    Private Sub CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CToolStripMenuItem.Click
        If (fila <= 6) Then
            huesped(fila) = txtHuesped.Text
            nit(fila) = Val(txtNit.Text)
            dias(fila) = Val(txtDias.Text)
            tipo_habitacion(fila) = cmbHabitacion.Text
            tipo_pago(fila) = cmbPago.Text
            impuesto(fila) = Val(txtImpuesto.Text)

            Select Case (cmbHabitacion.SelectedIndex)
                Case 0 : parcial(fila) = 250 * dias(fila) + impuesto(fila)
                Case 1 : parcial(fila) = 400 * dias(fila) + impuesto(fila)
                Case 2 : parcial(fila) = 650 * dias(fila) + impuesto(fila)
                Case Else
                    MsgBox("NO SELECCIONÓ TIPO DE HABITACIÓN")
            End Select

            Select Case (cmbPago.SelectedIndex)
                Case 0 : total(fila) = parcial(fila) - (parcial(fila) * 0.15)
                Case 1 : total(fila) = parcial(fila) - (parcial(fila) * 0.03)
                Case 2 : total(fila) = parcial(fila)
                Case 3 : total(fila) = parcial(fila)
                Case Else
                    MsgBox("NO SELECCIONÓ TIPO DE PAGO")
            End Select

            'total(fila) = parcial(fila) + descuento(fila) + recargo(fila)

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

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Dim existe As Boolean = False
        I = 0
        While (I <= 6) And Not (existe)
            If (nit(I) = Val(txtConsulta.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While

        If (existe) Then
            MsgBox("REGISTRO ENCONTRADO EXITOSAMENTE")
            txtHuesped.Text = huesped(I)
            txtNit.Text = Str(nit(I))
            txtDias.Text = Str(dias(I))
            txtImpuesto.Text = Str(impuesto(I))
            cmbHabitacion.Text = tipo_habitacion(I)
            cmbPago.Text = tipo_pago(I)
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(huesped(I), Str(nit(I)), Str(dias(I)), tipo_habitacion(I), tipo_pago(I), Str(impuesto(I)), Str(parcial(I)), Str(total(I)))
            fila = I
        Else
            MsgBox("NIT NO ENCONTRADO")
            txtNit.Focus()
        End If
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        huesped(fila) = Nothing
        nit(fila) = Nothing
        dias(fila) = Nothing
        tipo_habitacion(fila) = Nothing
        tipo_pago(fila) = Nothing
        impuesto(fila) = Nothing
        parcial(fila) = Nothing
        total(fila) = Nothing

        For I = fila To 5
            huesped(I) = huesped(I + 1)
            nit(I) = nit(I + 1)
            dias(I) = dias(I + 1)
            tipo_habitacion(I) = tipo_habitacion(I + 1)
            tipo_pago(I) = tipo_pago(I + 1)
            impuesto(I) = impuesto(I + 1)
            parcial(I) = parcial(I + 1)
            total(I) = total(I + 1)
        Next I

        MsgBox("REGISTRO ELIMINADO EXITOSAMENTE")

        huesped(fila) = Nothing
        nit(fila) = Nothing
        dias(fila) = Nothing
        tipo_habitacion(fila) = Nothing
        tipo_pago(fila) = Nothing
        impuesto(fila) = Nothing
        parcial(fila) = Nothing
        total(fila) = Nothing

        fila = I
        limpiar_entradas()
        DataGridView1.Rows.Clear()
    End Sub
End Class
