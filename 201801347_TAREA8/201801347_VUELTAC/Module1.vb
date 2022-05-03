Module Module1
    Public etapa(12) As Integer
    Public equipo(12) As String
    Public kilometros(12) As Integer
    Public tiempo(12) As Integer
    Public nacionalidad(12) As String
    Public penalizacion(12) As Integer
    Public t_total(12) As Double

    Public fila As Byte = 0

    Sub limpiar_entradas()
        Form1.txtEtapa.Clear()
        Form1.txtKm.Clear()
        Form1.txtTiempo.Clear()
        Form1.rb1.Checked = False
        Form1.rb2.Checked = False
        Form1.cmbEquipo.Text = ""
        Form1.txtEtapa.Focus()
    End Sub

End Module
