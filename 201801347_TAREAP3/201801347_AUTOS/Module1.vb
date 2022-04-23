Module Module1
    Public placa(7)
    Public tipo(7)
    Public cobro_base(7)
    Public k_inicial(7)
    Public k_final(7)
    Public k_total(7)
    Public p_final(7)

    Public fila As Byte = 0

    Public I As Byte

    Sub limpiar_entradas()
        Form1.txtPlaca.Clear()
        Form1.cmbTipo.Text = ""
        Form1.txtKinicial.Clear()
        Form1.txtKfinal.Clear()
    End Sub

    Sub mostrar_vectores()
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 6
            If (placa(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(placa(I)), tipo(I), Str(cobro_base(I)), Str(k_inicial(I)), Str(k_final(I)), Str(k_total(I)), Str(p_final(I)))
            Else
                Exit For
            End If
        Next I
    End Sub

    Sub limpiar_vectores()
        Form1.DataGridView1.Rows.Clear()
        fila = 0
        For I = 0 To 6
            placa(I) = Nothing
            tipo(I) = Nothing
            cobro_base(I) = Nothing
            k_inicial(I) = Nothing
            k_final(I) = Nothing
            k_total(I) = Nothing
            p_final(I) = Nothing
        Next I
    End Sub
End Module
