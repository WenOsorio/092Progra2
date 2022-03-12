Imports System.Math
Module Module1
    Public carnet(8) As Double
    Public estudiante(8) As String
    Public idioma(8) As String
    Public fecha(8) As Double
    Public horas(8) As Byte
    Public dias(8) As Byte
    Public forma_pago(8) As String
    Public pago_parcial(8) As Double
    Public descuento(8) As Double
    Public pago_final(8) As Double

    Public idiomas(8, 10) As String

    Public columna As Byte = 0
    Public columna1 As Byte = 0

    Sub mostrar_datos()
        Form1.DataGridView1.Rows.Add(idiomas(columna1, 0), idiomas(columna1, 1), idiomas(columna1, 2), idiomas(columna1, 3), idiomas(columna1, 4), idiomas(columna1, 5), idiomas(columna1, 6), idiomas(columna1, 7), idiomas(columna1, 8), idiomas(columna1, 9))
    End Sub

    Sub limpiar_entradas()
        Form1.txtCarnet.Clear()
        Form1.txtNombre.Clear()
        Form1.txtFecha.Clear()
        Form1.txtHoras.Clear()
        'Form1.cmbIdioma.SelectedIndex = -1
        Form1.chbViernes.Checked = False
        Form1.chbSabado.Checked = False
        Form1.rbtnEfectivo.Checked = False
        Form1.rbtnCheque.Checked = False
        Form1.txtCarnet.Focus()
        Form1.cmbIdioma.Text = ""
        'columna1 = 0
    End Sub

    Sub limpiar_vectores()
        Form1.DataGridView1.ClearSelection()

        For x = 0 To 7
            idiomas(7, x) = Nothing
        Next x
        columna1 = 0

    End Sub
End Module
