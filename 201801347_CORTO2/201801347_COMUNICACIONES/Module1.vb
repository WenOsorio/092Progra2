Module Module1
    Public indice As Byte = 0

    Public nombre(7)
    Public salario(7)
    Public articulo(7)
    Public comision(7)
    Public bono(7)
    Public sueldo_final(7)

    Public Const tablet = 375
    Public Const drone = 560
    Public Const celular = 1450
    Public Const tele = 3250

    Sub mostrar_vectores()
        Form1.ListBox1.Items.Add(nombre(indice))
        Form1.ListBox2.Items.Add(salario(indice))
        Form1.ListBox3.Items.Add(articulo(indice))
        Form1.ListBox4.Items.Add(comision(indice))
        Form1.ListBox5.Items.Add(bono(indice))
        Form1.ListBox6.Items.Add(sueldo_final(indice))
    End Sub

    Sub limpiar_vectores()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
    End Sub

    Sub limpiar_entradas()
        Form1.txtNombre.Clear()
        Form1.txtSalario.Clear()
        Form1.cmbArticulo.SelectedIndex = -1
    End Sub
End Module
