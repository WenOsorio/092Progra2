Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbEquipo.Items.Add("Sky")
        cmbEquipo.Items.Add("Movistar")
        cmbEquipo.Items.Add("Pro Cycling")
        cmbEquipo.Items.Add("Pro Team")
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If (MsgBox("¿Desea salir?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            limpiar_entradas()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (fila <= 11) Then
            etapa(fila) = Val(txtEtapa.Text)
            equipo(fila) = cmbEquipo.Text
            kilometros(fila) = Val(txtKm.Text)
            tiempo(fila) = Val(txtTiempo.Text)

            If (rb1.Checked) Then
                nacionalidad(fila) = rb1.Text
            ElseIf rb2.Checked Then
                nacionalidad(fila) = rb2.Text
            Else
                MsgBox("Error, no seleccionó nacionalidad")
                Exit Sub
            End If

            If (Val(kilometros(fila)) >= 0) And ((kilometros(fila)) <= 139) Then
                penalizacion(fila) = "+30"
                t_total(fila) = tiempo(fila) + 30
            ElseIf (Val(kilometros(fila)) >= 140) And ((kilometros(fila)) <= 159) Then
                t_total(fila) = tiempo(fila) + 40
                penalizacion(fila) = "+40"
            ElseIf (Val(kilometros(fila)) >= 160) Then
                t_total(fila) = tiempo(fila) + 50
                penalizacion(fila) = "+50"
            Else
                MsgBox("Error, no ingresó cantidad de kilómetros")
                Exit Sub
            End If

            If (Val(tiempo(fila)) >= 0) And ((tiempo(fila)) <= 85) Then
                Select Case cmbEquipo.SelectedIndex
                    Case 1 : t_total(fila) = tiempo(fila) - 15
                        penalizacion(fila) = "-15"
                    Case 3 : t_total(fila) = tiempo(fila) - 10
                        penalizacion(fila) = "-10"
                End Select
            End If
            fila = fila + 1
        End If

        If (fila = 12) Then
            MsgBox("Vectores llenos")
        End If
        limpiar_entradas()
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim i As Byte
        DataGridView1.Rows.Clear()
        For i = 0 To 11
            If etapa(i) <> Nothing Then
                DataGridView1.Rows.Add(Str(etapa(i)), equipo(i), Str(kilometros(i)), Str(tiempo(i)), nacionalidad(i), Str(penalizacion(i)), Str(t_total(i)))
            Else
                Exit For
            End If
        Next i
        limpiar_entradas()
    End Sub

    Private Sub btnOrdenar_Click(sender As Object, e As EventArgs) Handles btnOrdenar.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1 As Integer
        Dim temp2 As String
        Dim temp3 As Integer
        Dim temp4 As Integer
        Dim temp5 As String
        Dim temp6 As Integer
        Dim temp7 As Double

        For i = 0 To 10
            For j = i + 1 To 11
                If (etapa(j) <> Nothing) Then
                    If (etapa(i) > etapa(j)) Then
                        temp1 = etapa(i)
                        etapa(i) = etapa(j)
                        etapa(j) = temp1

                        temp2 = equipo(i)
                        equipo(i) = equipo(j)
                        equipo(j) = temp2

                        temp3 = kilometros(i)
                        kilometros(i) = kilometros(j)
                        kilometros(j) = temp3

                        temp4 = tiempo(i)
                        tiempo(i) = tiempo(j)
                        tiempo(j) = temp4

                        temp5 = nacionalidad(i)
                        nacionalidad(i) = nacionalidad(j)
                        nacionalidad(j) = temp5

                        temp6 = penalizacion(i)
                        penalizacion(i) = penalizacion(j)
                        penalizacion(j) = temp6

                        temp7 = t_total(i)
                        t_total(i) = t_total(j)
                        t_total(j) = temp7

                    End If
                Else
                    Exit For
                End If
            Next j

        Next i

    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim I As Byte = 0
        Dim EXISTE As Boolean = True

        While (I <= 11) And (EXISTE)
            If (etapa(I) <> Nothing) Then
                If (etapa(I) = Val(txtConsulta.Text)) Then
                    EXISTE = False
                Else
                    I = I + 1
                End If
            Else
                Exit While
            End If
        End While
        If (EXISTE) Then
            MsgBox("Error, número de etapa no encontrado")
        Else
            MsgBox("Número de etapa encontrado exitosamente")
            txtEtapa.Text = Str(etapa(I))
            cmbEquipo.Text = equipo(I)
            txtKm.Text = Str(kilometros(I))
            txtTiempo.Text = Str(tiempo(I))
            If (nacionalidad(I) = "Guatemalteco") Then
                rb1.Checked = True
            Else
                rb2.Checked = True
            End If
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(etapa(I)), equipo(I), Str(kilometros(I)), Str(tiempo(I)), nacionalidad(I), Str(penalizacion(I)), Str(t_total(I)))

            fila = I
            txtConsulta.Clear()
        End If
    End Sub

    Private Sub btnEntradas_Click(sender As Object, e As EventArgs) Handles btnEntradas.Click
        limpiar_entradas()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        etapa(fila) = Val(txtEtapa.Text)
        equipo(fila) = cmbEquipo.Text
        kilometros(fila) = Val(txtKm.Text)
        tiempo(fila) = Val(txtTiempo.Text)

        If (rb1.Checked) Then
            nacionalidad(fila) = rb1.Text
        ElseIf rb2.Checked Then
            nacionalidad(fila) = rb2.Text
        End If

        If (Val(kilometros(fila)) >= 0) And ((kilometros(fila)) <= 139) Then
            penalizacion(fila) = "+30"
            t_total(fila) = tiempo(fila) + 30
        ElseIf (Val(kilometros(fila)) >= 140) And ((kilometros(fila)) <= 159) Then
            t_total(fila) = tiempo(fila) + 40
            penalizacion(fila) = "+40"
        ElseIf (Val(kilometros(fila)) >= 160) Then
            t_total(fila) = tiempo(fila) + 50
            penalizacion(fila) = "+50"
        End If

        If (Val(kilometros(fila)) >= 0) And ((kilometros(fila)) <= 85) Then
            Select Case cmbEquipo.SelectedIndex
                Case 1 : t_total(fila) = tiempo(fila) - 15
                    penalizacion(fila) = "-15"
                Case 3 : t_total(fila) = tiempo(fila) - 10
                    penalizacion(fila) = "-10"
            End Select
        End If
        MsgBox("Registro actualizado con éxito")
        fila = 0

        While (etapa(fila) <> Nothing)
            fila = fila + 1
        End While
        limpiar_entradas()
    End Sub

    Private Sub btnVectores_Click(sender As Object, e As EventArgs) Handles btnVectores.Click
        For J = 0 To 11
            etapa(J) = Nothing
            equipo(J) = Nothing
            kilometros(J) = Nothing
            tiempo(J) = Nothing
            nacionalidad(J) = Nothing
            penalizacion(J) = Nothing
            t_total(J) = Nothing
        Next J
        DataGridView1.Rows.Clear()
        txtR1.Clear()
        txtR2_1.Clear()
        txtR2_2.Clear()
        txtR2_3.Clear()
        txtR2_4.Clear()
        txtR3_1.Clear()
        txtR3_2.Clear()
        fila = 0
    End Sub

    Private Sub btnEstadisticas_Click(sender As Object, e As EventArgs) Handles btnEstadisticas.Click
        Dim K As Byte
        Dim R1 As Byte = 0
        Dim R2_1 As Integer = 0, R2_2 As Integer = 0, R2_3 As Integer = 0, R2_4 As Integer = 0
        Dim R3_1 As Integer = 0, R3_2 As Integer

        For K = 0 To 11
            If (kilometros(K) > 45) And (nacionalidad(K) = "Guatemalteco") Then
                R1 = R1 + 1
            End If
            If (equipo(K) = "Sky") Then
                R2_1 = R2_1 + kilometros(K)
            End If
            If (equipo(K) = "Movistar") Then
                R2_2 = R2_2 + kilometros(K)
            End If
            If (equipo(K) = "Pro Cycling") Then
                R2_3 = R2_3 + kilometros(K)
            End If
            If (equipo(K) = "Pro Team") Then
                R2_4 = R2_4 + kilometros(K)
            End If
            If (nacionalidad(K) = "Guatemalteco") Then
                R3_1 = R3_1 + t_total(K)
            End If
            If (nacionalidad(K) = "Extranjero") Then
                R3_2 = R3_2 + t_total(K)
            End If
        Next K
        txtR1.Text = Str(R1)
        txtR2_1.Text = Str(R2_1)
        txtR2_2.Text = Str(R2_2)
        txtR2_3.Text = Str(R2_3)
        txtR2_4.Text = Str(R2_4)
        txtR3_1.Text = Str(R3_1)
        txtR3_2.Text = Str(R3_2)
    End Sub
End Class
