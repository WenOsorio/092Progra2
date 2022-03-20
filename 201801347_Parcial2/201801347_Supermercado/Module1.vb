Module Module1
    Public indice As Byte = 0

    Public nombre_pack(6)
    Public p_deseado(6)
    Public cant_inventario(6)
    Public cant_pack(6)
    Public sobrante(6)
    Public numero_packs(6)
    Public ingresos_pack(6)
    Public ingresos_sobrante(6)
    Public tot_parcial(6)
    Public descuento(6)
    Public total(6)

    Public Const jugos = 8.5
    Public Const frituras = 11.2
    Public Const galletas = 4.25
    Public Const baterias = 15

    Sub limpiar_entradas()
        Form1.txtCantPack.Clear()
        Form1.txtNombrePack.Clear()
        Form1.cmbProducto.SelectedIndex = -1
    End Sub

    'Sub calc_ingresos_pack()

    'End Sub
    'pack 6 latas de pepsi, dependiendo de la cantidad en cada pack se aplica un descuento, del inventario se 
    'hace cierta cantidad de packs
End Module
