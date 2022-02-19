Imports System.Math
Module Module1
    Public Const moSmall = 65.5
    Public Const moMedium = 85.99
    Public Const moLarge = 99.99

    Public Const precioydAlgodon = 15
    Public Const precioydSeda = 23.99
    Public Const precioydLona = 30.99

    Public Const ydSmall = 2
    Public Const ydMedium = 2.5
    Public Const ydLarge = 3

    Public precioCosto = 0
    Public precioVenta = 0

    Public Function calcular(material As String, tamaño As String, cantidad As Double)
        Select Case tamaño
            Case "Small"
                Select Case material
                    Case "Algodon"
                        precioCosto = cantidad * moSmall + cantidad * precioydAlgodon * ydSmall
                    Case "Seda"
                        precioCosto = cantidad * moSmall + cantidad * precioydSeda * ydSmall
                    Case "Lona"
                        precioCosto = cantidad * moSmall + cantidad * precioydLona * ydSmall
                End Select
            Case "Medium"
                Select Case material
                    Case "Algodon"
                        precioCosto = cantidad * moMedium + cantidad * precioydAlgodon * ydMedium
                    Case "Seda"
                        precioCosto = cantidad * moMedium + cantidad * precioydSeda * ydMedium
                    Case "Lona"
                        precioCosto = cantidad * moMedium + cantidad * precioydLona * ydMedium
                End Select
            Case "Large"
                Select Case material
                    Case "Algodon"
                        precioCosto = cantidad * moLarge + cantidad * precioydAlgodon * ydLarge
                    Case "Seda"
                        precioCosto = cantidad * moLarge + cantidad * precioydSeda * ydLarge
                    Case "Lona"
                        precioCosto = cantidad * moLarge + cantidad * precioydLona * ydLarge
                End Select
        End Select
        precioVenta = precioCosto + 0.65 * precioCosto
    End Function

    Sub limpiardatos()
        Form1.rbSmall.Checked = False
        Form1.rbMedium.Checked = False
        Form1.rbLarge.Checked = False

        Form1.rbAlgodon.Checked = False
        Form1.rbSeda.Checked = False
        Form1.rbLona.Checked = False

        Form1.TextBox1.Clear()
        Form1.txtCliente.Clear()

        Form2.txtpreCosto.Clear()
        Form2.txtpreVenta.Clear()

        Form1.txtCliente.Focus()
    End Sub

    Sub mostrar_resultados()
        Form2.txtpreCosto.Text = Str(Round(precioCosto, 2))
        Form2.txtpreVenta.Text = Str(Round(precioVenta, 2))
    End Sub

End Module
