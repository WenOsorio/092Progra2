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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.chbCompra = New System.Windows.Forms.CheckBox()
        Me.chbVenta = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txcompra = New System.Windows.Forms.TextBox()
        Me.txventa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CCDolar = New System.Windows.Forms.RadioButton()
        Me.CCPesos = New System.Windows.Forms.RadioButton()
        Me.CCEuro = New System.Windows.Forms.RadioButton()
        Me.CCColones = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CVColones = New System.Windows.Forms.RadioButton()
        Me.CVEuro = New System.Windows.Forms.RadioButton()
        Me.CVPesos = New System.Windows.Forms.RadioButton()
        Me.CVDolar = New System.Windows.Forms.RadioButton()
        Me.btCalcular = New System.Windows.Forms.Button()
        Me.btLimpiar = New System.Windows.Forms.Button()
        Me.BtSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chbVenta)
        Me.GroupBox1.Controls.Add(Me.chbCompra)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TRANSACCIONES"
        '
        'chbCompra
        '
        Me.chbCompra.AutoSize = True
        Me.chbCompra.Location = New System.Drawing.Point(26, 44)
        Me.chbCompra.Name = "chbCompra"
        Me.chbCompra.Size = New System.Drawing.Size(62, 17)
        Me.chbCompra.TabIndex = 0
        Me.chbCompra.Text = "Compra"
        Me.chbCompra.UseVisualStyleBackColor = True
        '
        'chbVenta
        '
        Me.chbVenta.AutoSize = True
        Me.chbVenta.Location = New System.Drawing.Point(149, 44)
        Me.chbVenta.Name = "chbVenta"
        Me.chbVenta.Size = New System.Drawing.Size(54, 17)
        Me.chbVenta.TabIndex = 1
        Me.chbVenta.Text = "Venta"
        Me.chbVenta.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txventa)
        Me.GroupBox2.Controls.Add(Me.txcompra)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(247, 112)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "INGRESE LA CANTIDAD DESEADA"
        '
        'txcompra
        '
        Me.txcompra.Enabled = False
        Me.txcompra.Location = New System.Drawing.Point(26, 55)
        Me.txcompra.Name = "txcompra"
        Me.txcompra.Size = New System.Drawing.Size(83, 20)
        Me.txcompra.TabIndex = 0
        '
        'txventa
        '
        Me.txventa.Enabled = False
        Me.txventa.Location = New System.Drawing.Point(149, 55)
        Me.txventa.Name = "txventa"
        Me.txventa.Size = New System.Drawing.Size(88, 20)
        Me.txventa.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Compra:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Venta:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightGreen
        Me.GroupBox3.Controls.Add(Me.CCColones)
        Me.GroupBox3.Controls.Add(Me.CCEuro)
        Me.GroupBox3.Controls.Add(Me.CCPesos)
        Me.GroupBox3.Controls.Add(Me.CCDolar)
        Me.GroupBox3.Location = New System.Drawing.Point(278, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(144, 171)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SELECCIONE CAMBIO PARA COMPRA"
        '
        'CCDolar
        '
        Me.CCDolar.AutoSize = True
        Me.CCDolar.Location = New System.Drawing.Point(11, 36)
        Me.CCDolar.Name = "CCDolar"
        Me.CCDolar.Size = New System.Drawing.Size(50, 17)
        Me.CCDolar.TabIndex = 0
        Me.CCDolar.TabStop = True
        Me.CCDolar.Text = "Dolar"
        Me.CCDolar.UseVisualStyleBackColor = True
        '
        'CCPesos
        '
        Me.CCPesos.AutoSize = True
        Me.CCPesos.Location = New System.Drawing.Point(11, 71)
        Me.CCPesos.Name = "CCPesos"
        Me.CCPesos.Size = New System.Drawing.Size(108, 17)
        Me.CCPesos.TabIndex = 1
        Me.CCPesos.TabStop = True
        Me.CCPesos.Text = "Pesos Mexicanos"
        Me.CCPesos.UseVisualStyleBackColor = True
        '
        'CCEuro
        '
        Me.CCEuro.AutoSize = True
        Me.CCEuro.Location = New System.Drawing.Point(11, 105)
        Me.CCEuro.Name = "CCEuro"
        Me.CCEuro.Size = New System.Drawing.Size(52, 17)
        Me.CCEuro.TabIndex = 2
        Me.CCEuro.TabStop = True
        Me.CCEuro.Text = "Euros"
        Me.CCEuro.UseVisualStyleBackColor = True
        '
        'CCColones
        '
        Me.CCColones.AutoSize = True
        Me.CCColones.Location = New System.Drawing.Point(11, 137)
        Me.CCColones.Name = "CCColones"
        Me.CCColones.Size = New System.Drawing.Size(130, 17)
        Me.CCColones.TabIndex = 3
        Me.CCColones.TabStop = True
        Me.CCColones.Text = "Colones Costarricense"
        Me.CCColones.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LightGreen
        Me.GroupBox4.Controls.Add(Me.CVColones)
        Me.GroupBox4.Controls.Add(Me.CVEuro)
        Me.GroupBox4.Controls.Add(Me.CVPesos)
        Me.GroupBox4.Controls.Add(Me.CVDolar)
        Me.GroupBox4.Location = New System.Drawing.Point(428, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(144, 171)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "SELECCIONE CAMBIO PARA VENTA"
        '
        'CVColones
        '
        Me.CVColones.AutoSize = True
        Me.CVColones.Location = New System.Drawing.Point(11, 137)
        Me.CVColones.Name = "CVColones"
        Me.CVColones.Size = New System.Drawing.Size(130, 17)
        Me.CVColones.TabIndex = 3
        Me.CVColones.TabStop = True
        Me.CVColones.Text = "Colones Costarricense"
        Me.CVColones.UseVisualStyleBackColor = True
        '
        'CVEuro
        '
        Me.CVEuro.AutoSize = True
        Me.CVEuro.Location = New System.Drawing.Point(11, 105)
        Me.CVEuro.Name = "CVEuro"
        Me.CVEuro.Size = New System.Drawing.Size(52, 17)
        Me.CVEuro.TabIndex = 2
        Me.CVEuro.TabStop = True
        Me.CVEuro.Text = "Euros"
        Me.CVEuro.UseVisualStyleBackColor = True
        '
        'CVPesos
        '
        Me.CVPesos.AutoSize = True
        Me.CVPesos.Location = New System.Drawing.Point(11, 71)
        Me.CVPesos.Name = "CVPesos"
        Me.CVPesos.Size = New System.Drawing.Size(108, 17)
        Me.CVPesos.TabIndex = 1
        Me.CVPesos.TabStop = True
        Me.CVPesos.Text = "Pesos Mexicanos"
        Me.CVPesos.UseVisualStyleBackColor = True
        '
        'CVDolar
        '
        Me.CVDolar.AutoSize = True
        Me.CVDolar.Location = New System.Drawing.Point(11, 36)
        Me.CVDolar.Name = "CVDolar"
        Me.CVDolar.Size = New System.Drawing.Size(50, 17)
        Me.CVDolar.TabIndex = 0
        Me.CVDolar.TabStop = True
        Me.CVDolar.Text = "Dolar"
        Me.CVDolar.UseVisualStyleBackColor = True
        '
        'btCalcular
        '
        Me.btCalcular.BackColor = System.Drawing.Color.LimeGreen
        Me.btCalcular.Location = New System.Drawing.Point(289, 206)
        Me.btCalcular.Name = "btCalcular"
        Me.btCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btCalcular.TabIndex = 5
        Me.btCalcular.Text = "CALCULAR"
        Me.btCalcular.UseVisualStyleBackColor = False
        '
        'btLimpiar
        '
        Me.btLimpiar.BackColor = System.Drawing.Color.ForestGreen
        Me.btLimpiar.Location = New System.Drawing.Point(395, 206)
        Me.btLimpiar.Name = "btLimpiar"
        Me.btLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btLimpiar.TabIndex = 6
        Me.btLimpiar.Text = "LIMPIAR"
        Me.btLimpiar.UseVisualStyleBackColor = False
        '
        'BtSalir
        '
        Me.BtSalir.BackColor = System.Drawing.Color.CadetBlue
        Me.BtSalir.Location = New System.Drawing.Point(497, 206)
        Me.BtSalir.Name = "BtSalir"
        Me.BtSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtSalir.TabIndex = 7
        Me.BtSalir.Text = "SALIR"
        Me.BtSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(630, 280)
        Me.Controls.Add(Me.BtSalir)
        Me.Controls.Add(Me.btLimpiar)
        Me.Controls.Add(Me.btCalcular)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chbVenta As CheckBox
    Friend WithEvents chbCompra As CheckBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txventa As TextBox
    Friend WithEvents txcompra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CCColones As RadioButton
    Friend WithEvents CCEuro As RadioButton
    Friend WithEvents CCPesos As RadioButton
    Friend WithEvents CCDolar As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CVColones As RadioButton
    Friend WithEvents CVEuro As RadioButton
    Friend WithEvents CVPesos As RadioButton
    Friend WithEvents CVDolar As RadioButton
    Friend WithEvents btCalcular As Button
    Friend WithEvents btLimpiar As Button
    Friend WithEvents BtSalir As Button
End Class
