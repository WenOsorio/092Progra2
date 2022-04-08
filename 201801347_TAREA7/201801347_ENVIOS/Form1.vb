Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPaquetes.Items.Add("Documentos")
        cmbPaquetes.Items.Add("Ropa")
        cmbPaquetes.Items.Add("Artículo no perecederos")
        cmbPaquetes.Items.Add("Artículos de plástico")
        cmbPaquetes.Items.Add("Lociones")

        cmbEnvio.Items.Add("Camión")
        cmbEnvio.Items.Add("Motocicleta")
    End Sub

    Private Sub ACEPTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACEPTARToolStripMenuItem.Click
        If (indice <= 9) Then
            cliente(indice) = txtCliente.Text
            tipo(indice) = cmbPaquetes.Text
            valor(indice) = Val(txtValor.Text)
            'peso(indice) = Val(txtPeso.Text)
            peso(indice) = Val(InputBox("Ingrese el peso del paquete (lb)"))
            envio(indice) = cmbEnvio.Text

            Select Case cmbEnvio.SelectedIndex
                Case 0 : calc_envio(indice) = 50
                Case 1 : calc_envio(indice) = 15
                Case Else
                    MsgBox("ERROR NO SELECCIONÓ FORMA DE ENVÍO")
            End Select

            parcial(indice) = Math.Round((valor(indice) * peso(indice)) + calc_envio(indice), 2)

            Select Case cmbPaquetes.SelectedIndex
                Case 0 : calc_impuesto(indice) = documentos
                Case 1 : calc_impuesto(indice) = ropa
                Case 2 : calc_impuesto(indice) = arti_noperecedero
                Case 3 : calc_impuesto(indice) = arti_plastico
                Case 4 : calc_impuesto(indice) = lociones
                Case Else
                    MsgBox("ERROR NO SELECCÍONÓ TIPO DE PAQUETE")
            End Select

            impuesto(indice) = Math.Round(calc_impuesto(indice) * peso(indice), 2)
            total(indice) = Math.Round(parcial(indice) + impuesto(indice), 2)
            indice = indice + 1
        End If
        inicializar_datos()
        If (indice = 10) Then
            MsgBox("VECTORES LLENOS")
        End If

    End Sub

    Private Sub RESULTADOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESULTADOSToolStripMenuItem.Click
        Dim X As Byte
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
        ListBox7.Items.Clear()
        ListBox8.Items.Clear()

        For X = 0 To 9
            If valor(X) <> Nothing Then
                ListBox1.Items.Add(cliente(X))
                ListBox2.Items.Add(tipo(X))
                ListBox3.Items.Add(Str(valor(X)))
                ListBox4.Items.Add(Str(peso(X)))
                ListBox5.Items.Add(envio(X))
                ListBox6.Items.Add(parcial(X))
                ListBox7.Items.Add(impuesto(X))
                ListBox8.Items.Add(total(X))
            Else
                Exit For
            End If
        Next X
    End Sub

    Private Sub RESTADÍSTICAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESTADÍSTICAToolStripMenuItem.Click
        Dim K As Byte
        Dim R1 As Integer = 0
        Dim R2 As Byte = 0
        Dim R3 As Integer = 0
        Dim R4 As Integer = 0

        For K = 0 To 9
            If (tipo(K) = "Lociones") Then
                R1 = R1 + total(K)
            End If
            If (tipo(K) = "Artículos de plástico") Then
                R2 = R2 + 1
            End If
            If (tipo(K) = "Documentos") Then
                R3 = R3 + total(K)
            End If
            If (tipo(K) = "Ropa") Then
                R4 = R4 + 1
            End If
        Next K
        txtR1.Text = Str(R1)
        txtR2.Text = Str(R2)
        txtR3.Text = Str(R3)
        txtR4.Text = Str(R4)
    End Sub

    Private Sub ENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENTRADASToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub VECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VECTORESToolStripMenuItem.Click
        Dim J As Byte

        For J = 0 To 9
            cliente(J) = Nothing
            tipo(J) = Nothing
            valor(J) = Nothing
            peso(J) = Nothing
            envio(J) = Nothing
            parcial(J) = Nothing
            impuesto(J) = Nothing
            total(J) = Nothing
        Next J
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
        ListBox7.Items.Clear()
        ListBox8.Items.Clear()
        txtR1.Clear()
        txtR2.Clear()
        txtR3.Clear()
        txtR4.Clear()
        indice = 0
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            limpiar_entradas()
        End If
    End Sub
End Class
