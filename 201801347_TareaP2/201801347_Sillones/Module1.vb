Module Module1
    Public indice As Byte = 0

    Public no_venta(8)
    Public tamaño(8)
    Public cantidad(8)
    Public material(8)
    Public p_parcial(8)
    Public mano_obra(8)
    Public p_costo(8)
    Public p_venta(8)

    Public Const mo_Sofa = 250.99
    Public Const mo_Individual = 150.99
    Public Const mo_Doble = 200.99
    Public Const yd_Sofa = 8
    Public Const yd_Individual = 3.5
    Public Const yd_Doble = 6
    Public Const cuero = 75
    Public Const cuerina = 45.99

    Sub limpiar_entradas()
        Form1.txtNoV.Clear()
        Form1.txtCantidad.Clear()
        Form1.cmbTamaño.SelectedIndex = -1
        Form1.rbtnCuero.Checked = False
        Form1.rbtnCuerina.Checked = False
        Form1.DataGridView1.ClearSelection()
    End Sub

    Sub limpiar_vectores()
        indice = 0
        Form1.DataGridView1.ClearSelection()
    End Sub

End Module
