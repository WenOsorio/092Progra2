Module Module1

    Public Const monviaNorte = 150
    Public Const monviaSur = 200
    Public Const monviaOriente = 175
    Public Const monviaOccidente = 225
    Public Const seguroVehiculo = 3 / 100
    Public Const seguroAccidente = 5 / 100
    Public Const sueldobase = 3800

    Public montoseguro As Double
    Public sueldofinal As Double


    Sub limpiar()
        Form1.txtNombre.Clear()
        Form1.txtMonto.Clear()
        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False
        Form1.RadioButton3.Checked = False
        Form1.RadioButton4.Checked = False
        Form1.RadioButton5.Checked = False
        Form1.RadioButton6.Checked = False
        Form1.txtNombre.Focus()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()


    End Sub

    Sub mostrardatos()
        Form1.TextBox1.Text = montoseguro
        Form1.TextBox2.Text = sueldofinal

    End Sub
End Module
