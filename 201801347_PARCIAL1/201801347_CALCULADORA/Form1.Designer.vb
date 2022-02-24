<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbVarias = New System.Windows.Forms.CheckBox()
        Me.cbSimples = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbsen = New System.Windows.Forms.RadioButton()
        Me.rbcos = New System.Windows.Forms.RadioButton()
        Me.rbraiz2 = New System.Windows.Forms.RadioButton()
        Me.rbpot2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdatoVar = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdato1 = New System.Windows.Forms.TextBox()
        Me.txtdato2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbDivision = New System.Windows.Forms.RadioButton()
        Me.rbMultiplicacion = New System.Windows.Forms.RadioButton()
        Me.rbResta = New System.Windows.Forms.RadioButton()
        Me.rbSuma = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gray
        Me.GroupBox1.Controls.Add(Me.cbVarias)
        Me.GroupBox1.Controls.Add(Me.cbSimples)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 328)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OPCINONES PRINCIPALES"
        '
        'cbVarias
        '
        Me.cbVarias.AutoSize = True
        Me.cbVarias.Location = New System.Drawing.Point(234, 34)
        Me.cbVarias.Name = "cbVarias"
        Me.cbVarias.Size = New System.Drawing.Size(118, 17)
        Me.cbVarias.TabIndex = 9
        Me.cbVarias.Text = "Operaciones Varias"
        Me.cbVarias.UseVisualStyleBackColor = True
        '
        'cbSimples
        '
        Me.cbSimples.AutoSize = True
        Me.cbSimples.Location = New System.Drawing.Point(43, 34)
        Me.cbSimples.Name = "cbSimples"
        Me.cbSimples.Size = New System.Drawing.Size(125, 17)
        Me.cbSimples.TabIndex = 8
        Me.cbSimples.Text = "Operaciones Simples"
        Me.cbSimples.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Silver
        Me.GroupBox6.Controls.Add(Me.rbsen)
        Me.GroupBox6.Controls.Add(Me.rbcos)
        Me.GroupBox6.Controls.Add(Me.rbraiz2)
        Me.GroupBox6.Controls.Add(Me.rbpot2)
        Me.GroupBox6.Location = New System.Drawing.Point(234, 179)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(144, 114)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "OPERACIONES"
        '
        'rbsen
        '
        Me.rbsen.AutoSize = True
        Me.rbsen.Location = New System.Drawing.Point(16, 92)
        Me.rbsen.Name = "rbsen"
        Me.rbsen.Size = New System.Drawing.Size(50, 17)
        Me.rbsen.TabIndex = 3
        Me.rbsen.TabStop = True
        Me.rbsen.Text = "Seno"
        Me.rbsen.UseVisualStyleBackColor = True
        '
        'rbcos
        '
        Me.rbcos.AutoSize = True
        Me.rbcos.Location = New System.Drawing.Point(16, 69)
        Me.rbcos.Name = "rbcos"
        Me.rbcos.Size = New System.Drawing.Size(61, 17)
        Me.rbcos.TabIndex = 2
        Me.rbcos.TabStop = True
        Me.rbcos.Text = "Coseno"
        Me.rbcos.UseVisualStyleBackColor = True
        '
        'rbraiz2
        '
        Me.rbraiz2.AutoSize = True
        Me.rbraiz2.Location = New System.Drawing.Point(16, 46)
        Me.rbraiz2.Name = "rbraiz2"
        Me.rbraiz2.Size = New System.Drawing.Size(95, 17)
        Me.rbraiz2.TabIndex = 1
        Me.rbraiz2.TabStop = True
        Me.rbraiz2.Text = "Raiz Cuadrada"
        Me.rbraiz2.UseVisualStyleBackColor = True
        '
        'rbpot2
        '
        Me.rbpot2.AutoSize = True
        Me.rbpot2.Location = New System.Drawing.Point(16, 23)
        Me.rbpot2.Name = "rbpot2"
        Me.rbpot2.Size = New System.Drawing.Size(127, 17)
        Me.rbpot2.TabIndex = 0
        Me.rbpot2.TabStop = True
        Me.rbpot2.Text = "Potencia al Cuadrado"
        Me.rbpot2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.MediumAquamarine
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.txtdatoVar)
        Me.GroupBox5.Location = New System.Drawing.Point(234, 73)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(161, 100)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Ingreso de Cantidades"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Dato:"
        '
        'txtdatoVar
        '
        Me.txtdatoVar.Location = New System.Drawing.Point(66, 45)
        Me.txtdatoVar.Name = "txtdatoVar"
        Me.txtdatoVar.Size = New System.Drawing.Size(69, 20)
        Me.txtdatoVar.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.MediumAquamarine
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtdato1)
        Me.GroupBox4.Controls.Add(Me.txtdato2)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(22, 73)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(161, 100)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ingreso de Cantidades"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Dato 1:"
        '
        'txtdato1
        '
        Me.txtdato1.Location = New System.Drawing.Point(66, 33)
        Me.txtdato1.Name = "txtdato1"
        Me.txtdato1.Size = New System.Drawing.Size(69, 20)
        Me.txtdato1.TabIndex = 1
        '
        'txtdato2
        '
        Me.txtdato2.Location = New System.Drawing.Point(66, 70)
        Me.txtdato2.Name = "txtdato2"
        Me.txtdato2.Size = New System.Drawing.Size(69, 20)
        Me.txtdato2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Dato 2:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.rbDivision)
        Me.GroupBox3.Controls.Add(Me.rbMultiplicacion)
        Me.GroupBox3.Controls.Add(Me.rbResta)
        Me.GroupBox3.Controls.Add(Me.rbSuma)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 179)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(124, 114)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "OPERACIONES"
        '
        'rbDivision
        '
        Me.rbDivision.AutoSize = True
        Me.rbDivision.Location = New System.Drawing.Point(16, 92)
        Me.rbDivision.Name = "rbDivision"
        Me.rbDivision.Size = New System.Drawing.Size(70, 17)
        Me.rbDivision.TabIndex = 3
        Me.rbDivision.TabStop = True
        Me.rbDivision.Text = "/ División"
        Me.rbDivision.UseVisualStyleBackColor = True
        '
        'rbMultiplicacion
        '
        Me.rbMultiplicacion.AutoSize = True
        Me.rbMultiplicacion.Location = New System.Drawing.Point(16, 69)
        Me.rbMultiplicacion.Name = "rbMultiplicacion"
        Me.rbMultiplicacion.Size = New System.Drawing.Size(96, 17)
        Me.rbMultiplicacion.TabIndex = 2
        Me.rbMultiplicacion.TabStop = True
        Me.rbMultiplicacion.Text = "* Multiplicación"
        Me.rbMultiplicacion.UseVisualStyleBackColor = True
        '
        'rbResta
        '
        Me.rbResta.AutoSize = True
        Me.rbResta.Location = New System.Drawing.Point(16, 46)
        Me.rbResta.Name = "rbResta"
        Me.rbResta.Size = New System.Drawing.Size(59, 17)
        Me.rbResta.TabIndex = 1
        Me.rbResta.TabStop = True
        Me.rbResta.Text = "- Resta"
        Me.rbResta.UseVisualStyleBackColor = True
        '
        'rbSuma
        '
        Me.rbSuma.AutoSize = True
        Me.rbSuma.Location = New System.Drawing.Point(16, 23)
        Me.rbSuma.Name = "rbSuma"
        Me.rbSuma.Size = New System.Drawing.Size(61, 17)
        Me.rbSuma.TabIndex = 0
        Me.rbSuma.TabStop = True
        Me.rbSuma.Text = "+ Suma"
        Me.rbSuma.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gray
        Me.GroupBox2.Controls.Add(Me.btnSalir)
        Me.GroupBox2.Controls.Add(Me.btnLimpiar)
        Me.GroupBox2.Controls.Add(Me.btnCalcular)
        Me.GroupBox2.Location = New System.Drawing.Point(464, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(122, 166)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ACCIONES"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Red
        Me.btnSalir.Location = New System.Drawing.Point(22, 112)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(22, 72)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(22, 32)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.MediumAquamarine
        Me.GroupBox7.Controls.Add(Me.txtResultado)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Location = New System.Drawing.Point(464, 210)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(189, 140)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "RESULTADOS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "El calculo de su operación es:"
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(43, 80)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(709, 380)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtdato1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents rbsen As RadioButton
    Friend WithEvents rbcos As RadioButton
    Friend WithEvents rbraiz2 As RadioButton
    Friend WithEvents rbpot2 As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdatoVar As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdato2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbDivision As RadioButton
    Friend WithEvents rbMultiplicacion As RadioButton
    Friend WithEvents rbResta As RadioButton
    Friend WithEvents rbSuma As RadioButton
    Friend WithEvents cbVarias As CheckBox
    Friend WithEvents cbSimples As CheckBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label4 As Label
End Class
