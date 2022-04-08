Module Module1
    Public indice As Byte = 0

    Public cliente(10)
    Public tipo(10)
    Public valor(10)
    Public peso(10)
    Public envio(10)
    Public parcial(10)
    Public impuesto(10)
    Public total(10)

    Public calc_envio(10)
    public calc_impuesto(10)

    Public Const documentos = 0.015
    Public Const ropa = 0.06
    Public Const arti_noperecedero = 0.055
    Public Const arti_plastico = 0.045
    Public Const lociones = 0.02

    Sub inicializar_datos()
        Form1.txtCliente.Clear()
        Form1.cmbPaquetes.Text = ""
        Form1.txtValor.Clear()
        Form1.txtPeso.Clear()
        Form1.cmbEnvio.Text = ""
        Form1.txtCliente.Focus()
        Form1.ListBox6.Items.Clear()
    End Sub

    Sub limpiar_entradas()
        Form1.txtCliente.Clear()
        Form1.txtValor.Clear()
        Form1.txtPeso.Clear()
        Form1.cmbPaquetes.Text = ""
        Form1.cmbEnvio.Text = ""
    End Sub
End Module
