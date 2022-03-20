Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbProducto.Items.Add("Jugos")
        cmbProducto.Items.Add("Frituras")
        cmbProducto.Items.Add("Galletas")
        cmbProducto.Items.Add("Baterías")
    End Sub

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click
        If (indice <= 5) Then
            nombre_pack(indice) = txtNombrePack.Text
            cant_pack(indice) = txtCantPack.Text
            cant_inventario(indice) = "175"

            Select Case (cmbProducto.SelectedIndex)
                Case 0 : p_deseado(indice) = "Jugos"
                Case 1 : p_deseado(indice) = "Frituras"
                Case 2 : p_deseado(indice) = "Galletas"
                Case 3 : p_deseado(indice) = "Baterías"
                Case Else
                    MsgBox("ERROR, NO SELECCIONÓ NINGÚN PRODUCTO")
            End Select


            Dim tot_inventario As Integer = 175
            Dim tot_packs As Integer = Val(txtCantPack.Text)

            Dim division As Integer = (tot_inventario / tot_packs)
            numero_packs(indice) = division

            Dim residuo As Integer = tot_inventario Mod tot_packs
            sobrante(indice) = residuo

            Select Case (cmbProducto.SelectedIndex)
                Case 0 : ingresos_pack(indice) = numero_packs(indice) * jugos
                Case 1 : ingresos_pack(indice) = numero_packs(indice) * frituras
                Case 2 : ingresos_pack(indice) = numero_packs(indice) * galletas
                Case 3 : ingresos_pack(indice) = numero_packs(indice) * baterias
            End Select

            'If Val(cant_pack(indice) >= 1) And Val(cant_pack(indice) <= 175) Then
            '
            'Else
            'MsgBox("ERROR, CANTIDAD DE PRODUCTO NO PERMITIDO")
            'End If


            DataGridView1.Rows.Add(nombre_pack(indice), p_deseado(indice), cant_pack(indice), cant_inventario(indice), numero_packs(indice), sobrante(indice), ingresos_pack(indice), ingresos_sobrante(indice), descuento(indice), tot_parcial(indice), total(indice))


        End If

        If (indice = 6) Then
            MsgBox("VECTORES LLENOS")
        End If

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            limpiar_entradas()
        End If
    End Sub

    Private Sub DATAGRIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATAGRIDToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub ENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENTRADASToolStripMenuItem.Click
        limpiar_entradas()
    End Sub
End Class
