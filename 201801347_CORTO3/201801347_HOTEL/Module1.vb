Module Module1
    Public huesped(7)
    Public nit(7)
    Public dias(7)
    Public tipo_habitacion(7)
    Public tipo_pago(7)
    Public impuesto(7)
    Public descuento(7)
    Public recargo(7)
    Public parcial(7)
    Public total(7)

    Public fila As Byte = 0

    Public I As Byte

    Sub limpiar_entradas()
        Form1.txtHuesped.Clear()
        Form1.txtNit.Clear()
        Form1.txtDias.Clear()
        Form1.txtImpuesto.Clear()
        Form1.cmbHabitacion.Text = ""
        Form1.cmbPago.Text = ""
    End Sub

    Sub mostrar_vectores()
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 6
            If (nit(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(huesped(I), Str(nit(I)), Str(dias(I)), tipo_habitacion(I), tipo_pago(I), Str(impuesto(I)), Str(parcial(I)), Str(total(I))) 'Str(descuento(I)), Str(recargo(I))
            Else
                Exit For
            End If
        Next I
    End Sub

    Sub limpiar_vectores()
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 6
            If (nit(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(huesped(I), Str(nit(I)), Str(dias(I)), tipo_habitacion(I), tipo_pago(I), Str(impuesto(I)), Str(parcial(I)), Str(total(I)))
            Else
                Exit For
            End If
        Next I
    End Sub

End Module
