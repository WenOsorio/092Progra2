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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbSmall = New System.Windows.Forms.RadioButton()
        Me.rbMedium = New System.Windows.Forms.RadioButton()
        Me.rbLarge = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbAlgodon = New System.Windows.Forms.RadioButton()
        Me.rbSeda = New System.Windows.Forms.RadioButton()
        Me.rbLona = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnCalcular)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 261)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ACCIONES"
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnCalcular.Location = New System.Drawing.Point(9, 28)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Silver
        Me.btnLimpiar.Location = New System.Drawing.Point(125, 28)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Red
        Me.btnSalir.Location = New System.Drawing.Point(239, 28)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox2.Controls.Add(Me.rbLarge)
        Me.GroupBox2.Controls.Add(Me.rbSmall)
        Me.GroupBox2.Controls.Add(Me.rbMedium)
        Me.GroupBox2.Location = New System.Drawing.Point(69, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(100, 121)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TAMAÑOS"
        '
        'rbSmall
        '
        Me.rbSmall.AutoSize = True
        Me.rbSmall.Location = New System.Drawing.Point(19, 37)
        Me.rbSmall.Name = "rbSmall"
        Me.rbSmall.Size = New System.Drawing.Size(50, 17)
        Me.rbSmall.TabIndex = 2
        Me.rbSmall.TabStop = True
        Me.rbSmall.Text = "Small"
        Me.rbSmall.UseVisualStyleBackColor = True
        '
        'rbMedium
        '
        Me.rbMedium.AutoSize = True
        Me.rbMedium.Location = New System.Drawing.Point(19, 60)
        Me.rbMedium.Name = "rbMedium"
        Me.rbMedium.Size = New System.Drawing.Size(62, 17)
        Me.rbMedium.TabIndex = 3
        Me.rbMedium.TabStop = True
        Me.rbMedium.Text = "Medium"
        Me.rbMedium.UseVisualStyleBackColor = True
        '
        'rbLarge
        '
        Me.rbLarge.AutoSize = True
        Me.rbLarge.Location = New System.Drawing.Point(19, 83)
        Me.rbLarge.Name = "rbLarge"
        Me.rbLarge.Size = New System.Drawing.Size(52, 17)
        Me.rbLarge.TabIndex = 4
        Me.rbLarge.TabStop = True
        Me.rbLarge.Text = "Large"
        Me.rbLarge.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox3.Controls.Add(Me.rbLona)
        Me.GroupBox3.Controls.Add(Me.rbSeda)
        Me.GroupBox3.Controls.Add(Me.rbAlgodon)
        Me.GroupBox3.Location = New System.Drawing.Point(188, 134)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(99, 121)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "MATERIAL"
        '
        'rbAlgodon
        '
        Me.rbAlgodon.AutoSize = True
        Me.rbAlgodon.Location = New System.Drawing.Point(20, 32)
        Me.rbAlgodon.Name = "rbAlgodon"
        Me.rbAlgodon.Size = New System.Drawing.Size(64, 17)
        Me.rbAlgodon.TabIndex = 0
        Me.rbAlgodon.TabStop = True
        Me.rbAlgodon.Text = "Algodón"
        Me.rbAlgodon.UseVisualStyleBackColor = True
        '
        'rbSeda
        '
        Me.rbSeda.AutoSize = True
        Me.rbSeda.Location = New System.Drawing.Point(20, 61)
        Me.rbSeda.Name = "rbSeda"
        Me.rbSeda.Size = New System.Drawing.Size(50, 17)
        Me.rbSeda.TabIndex = 1
        Me.rbSeda.TabStop = True
        Me.rbSeda.Text = "Seda"
        Me.rbSeda.UseVisualStyleBackColor = True
        '
        'rbLona
        '
        Me.rbLona.AutoSize = True
        Me.rbLona.Location = New System.Drawing.Point(20, 92)
        Me.rbLona.Name = "rbLona"
        Me.rbLona.Size = New System.Drawing.Size(49, 17)
        Me.rbLona.TabIndex = 2
        Me.rbLona.TabStop = True
        Me.rbLona.Text = "Lona"
        Me.rbLona.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(301, 191)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label1.Location = New System.Drawing.Point(298, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cantidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "FABRICA DE CHUMPAS"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox4.Controls.Add(Me.txtCliente)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(69, 60)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(332, 68)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DATOS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Cliente:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(103, 23)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(165, 20)
        Me.txtCliente.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(495, 343)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbLarge As RadioButton
    Friend WithEvents rbSmall As RadioButton
    Friend WithEvents rbMedium As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbLona As RadioButton
    Friend WithEvents rbSeda As RadioButton
    Friend WithEvents rbAlgodon As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label4 As Label
End Class
