Module Module1

    Public precio As Double
    Public Const precio1 = 350
    Public Const precio2 = 550
    Public Const precio3 = 450
    Public Const precio4 = 250
    Public Const precio5 = 400
    Public Const precio6 = 350
    Public Const precio7 = 150
    Public Const precio8 = 300
    Public Const precio9 = 250
    Public Const desc_efectivo = 0.15
    Public Const desc_cheque = 0.15
    Public Const desc_debito = 0.08
    Public Const recargo_credito = 0.05

    Public index = 0

    Public pago(5)
    Public descuento(5)
    Public recargo(5)
    Public total(5)

    Public paciente(5)
    Public nit(5)
    Public dias(5)
    Public honorarios(5)
    Public habitacion(5)
    Public servicio(5)

    Sub limpiarvectores2()
        ReDim pago(5)
        ReDim descuento(5)
        ReDim recargo(5)

        index = 0
    End Sub

    Sub limpiarentradas()

        Form1.DataGridView1.Rows.Clear()
        Form1.cmbHabitacion.SelectedIndex = -1
        Form1.txtPaciente.Clear()
        Form1.txtDias.Clear()
        Form1.txtNit.Clear()
        Form1.txtHonorarios.Clear()
        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False
        Form1.RadioButton3.Checked = False
        Form1.RadioButton4.Checked = False
        Form1.chbEncamamiento.Checked = False
        Form1.chbMaternidad.Checked = False
        Form1.chbOperacion.Checked = False

        index = 0
    End Sub

    Sub limpiarvectores()

        For contador = 0 To index - 1
            pago(contador) = Nothing
            descuento(contador) = Nothing
            recargo(contador) = Nothing
        Next

        index = 0
    End Sub
    Sub calculo_servicio_priv()
        If (Form1.chbEncamamiento.Checked) Or (Form1.chbOperacion.Checked) Or (Form1.chbMaternidad.Checked) Then
            If Form1.chbEncamamiento.Checked Then
                pago(index) = precio1
            End If

            If Form1.chbOperacion.Checked Then
                pago(index) = precio2
            End If

            If Form1.chbMaternidad.Checked Then
                pago(index) = precio3
            End If

        Else
            MsgBox("ERROR, NO SELECCIONÓ TIPO DE SERVICIO")
            Exit Sub
        End If
    End Sub

    Sub calculo_servicio_semi()
        If (Form1.chbEncamamiento.Checked) Or (Form1.chbOperacion.Checked) Or (Form1.chbMaternidad.Checked) Then
            If Form1.chbEncamamiento.Checked Then
                pago(index) = precio4
            End If

            If Form1.chbOperacion.Checked Then
                pago(index) = precio5
            End If

            If Form1.chbMaternidad.Checked Then
                pago(index) = precio6
            End If

        Else
            MsgBox("ERROR, NO SELECCIONÓ TIPO DE SERVICIO")
            Exit Sub
        End If
    End Sub

    Sub calculo_servicio_no()
        If (Form1.chbEncamamiento.Checked) Or (Form1.chbOperacion.Checked) Or (Form1.chbMaternidad.Checked) Then
            If Form1.chbEncamamiento.Checked Then
                pago(index) = precio7
            End If

            If Form1.chbOperacion.Checked Then
                pago(index) = precio8
            End If

            If Form1.chbMaternidad.Checked Then
                pago(index) = precio9
            End If

        Else
            MsgBox("ERROR, NO SELECCIONÓ TIPO DE SERVICIO")
            Exit Sub
        End If
    End Sub

    Sub calc_desc()
        If Form1.RadioButton1.Checked = True Then
            descuento(index) = pago(index) * desc_efectivo
        End If

        If Form1.RadioButton2.Checked = True Then
            descuento(index) = pago(index) * desc_cheque
        End If

        If Form1.RadioButton4.Checked = True Then
            descuento(index) = pago(index) * desc_debito
        Else
            MsgBox("ERROR, NO SELECCIÓ FORMA DE PAGO")
        End If

    End Sub

    Function calc_total() As Double
        total(index) = pago(index) - descuento(index) + recargo(index)
        Return total(index)
    End Function
End Module
