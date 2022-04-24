Module Module1
    Public cine(7, 5) As String
    Public fila As Byte = 0
    Public I As Byte

    Public Const P_Sala1 = 44
    Public Const P_Sala2 = 62
    Public Const P_Sala3 = 104


    Sub limpiar_entradas()
        Form1.txtNit.Clear()
        Form1.txtPeli.Clear()
        Form1.txtBoletos.Clear()
        Form1.cbNormal.Checked = False
        Form1.cb3D.Checked = False
        Form1.cb4DX.Checked = False
        Form1.txtNit.Focus()
    End Sub

    Sub limpiar_matriz()
        Dim J As Byte
        Form1.DataGridView1.Rows.Clear()
        fila = 0
        I = 0
        While (I <= 4)
            cine(I, 0) = Nothing
            cine(I, 1) = Nothing
            cine(I, 2) = Nothing
            cine(I, 3) = Nothing
            cine(I, 4) = Nothing
            I = I + 1
        End While
    End Sub

    Sub mostrar_matriz()
        Form1.DataGridView1.Rows.Clear()
        I = 0
        While (I <= 6)
            If (cine(I, 0) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(cine(I, 0), cine(I, 1), cine(I, 2), cine(I, 3), cine(I, 4))
            Else
                Exit While
            End If
            I = I + 1
        End While
    End Sub
End Module
