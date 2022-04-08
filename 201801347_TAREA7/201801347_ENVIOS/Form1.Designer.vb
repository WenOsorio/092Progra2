<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbPaquetes = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbEnvio = New System.Windows.Forms.ComboBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ListBox8 = New System.Windows.Forms.ListBox()
        Me.ListBox7 = New System.Windows.Forms.ListBox()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtR2 = New System.Windows.Forms.TextBox()
        Me.txtR4 = New System.Windows.Forms.TextBox()
        Me.txtR3 = New System.Windows.Forms.TextBox()
        Me.txtR1 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ACEPTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOSTRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RESULTADOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RESTADÍSTICAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipos de Paquete:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente:"
        '
        'cmbPaquetes
        '
        Me.cmbPaquetes.FormattingEnabled = True
        Me.cmbPaquetes.Location = New System.Drawing.Point(134, 27)
        Me.cmbPaquetes.Name = "cmbPaquetes"
        Me.cmbPaquetes.Size = New System.Drawing.Size(121, 24)
        Me.cmbPaquetes.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.cmbEnvio)
        Me.GroupBox2.Controls.Add(Me.cmbPaquetes)
        Me.GroupBox2.Controls.Add(Me.txtPeso)
        Me.GroupBox2.Controls.Add(Me.txtValor)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(9, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(427, 113)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingresos del paquete"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(17, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 16)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Forma de envío:"
        '
        'cmbEnvio
        '
        Me.cmbEnvio.FormattingEnabled = True
        Me.cmbEnvio.Location = New System.Drawing.Point(127, 77)
        Me.cmbEnvio.Name = "cmbEnvio"
        Me.cmbEnvio.Size = New System.Drawing.Size(121, 24)
        Me.cmbEnvio.TabIndex = 0
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(323, 27)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(74, 22)
        Me.txtValor.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Valor Q:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(9, 43)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(180, 22)
        Me.txtCliente.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.txtCliente)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(442, 194)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingreso de datos"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.ListBox8)
        Me.GroupBox4.Controls.Add(Me.ListBox7)
        Me.GroupBox4.Controls.Add(Me.ListBox6)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.ListBox5)
        Me.GroupBox4.Controls.Add(Me.ListBox4)
        Me.GroupBox4.Controls.Add(Me.ListBox3)
        Me.GroupBox4.Controls.Add(Me.ListBox2)
        Me.GroupBox4.Controls.Add(Me.ListBox1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 242)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(913, 211)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resultados"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(715, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Impuesto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(811, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 16)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Pago total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(619, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 16)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Pago parcial"
        '
        'ListBox8
        '
        Me.ListBox8.FormattingEnabled = True
        Me.ListBox8.ItemHeight = 16
        Me.ListBox8.Location = New System.Drawing.Point(812, 49)
        Me.ListBox8.Name = "ListBox8"
        Me.ListBox8.Size = New System.Drawing.Size(90, 148)
        Me.ListBox8.TabIndex = 11
        '
        'ListBox7
        '
        Me.ListBox7.FormattingEnabled = True
        Me.ListBox7.ItemHeight = 16
        Me.ListBox7.Location = New System.Drawing.Point(716, 49)
        Me.ListBox7.Name = "ListBox7"
        Me.ListBox7.Size = New System.Drawing.Size(90, 148)
        Me.ListBox7.TabIndex = 10
        '
        'ListBox6
        '
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.ItemHeight = 16
        Me.ListBox6.Location = New System.Drawing.Point(620, 49)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(90, 148)
        Me.ListBox6.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(525, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Envío"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(429, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Peso "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(321, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Valor "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(154, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Tipo de paquete"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cliente:"
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 16
        Me.ListBox5.Location = New System.Drawing.Point(524, 49)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(90, 148)
        Me.ListBox5.TabIndex = 4
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 16
        Me.ListBox4.Location = New System.Drawing.Point(428, 49)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(90, 148)
        Me.ListBox4.TabIndex = 3
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 16
        Me.ListBox3.Location = New System.Drawing.Point(321, 49)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(101, 148)
        Me.ListBox3.TabIndex = 2
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(157, 49)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(158, 148)
        Me.ListBox2.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(6, 49)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(145, 148)
        Me.ListBox1.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox6.Controls.Add(Me.txtR2)
        Me.GroupBox6.Controls.Add(Me.txtR4)
        Me.GroupBox6.Controls.Add(Me.txtR3)
        Me.GroupBox6.Controls.Add(Me.txtR1)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(471, 42)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(454, 194)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Estadísticas"
        '
        'txtR2
        '
        Me.txtR2.Location = New System.Drawing.Point(325, 75)
        Me.txtR2.Name = "txtR2"
        Me.txtR2.Size = New System.Drawing.Size(88, 22)
        Me.txtR2.TabIndex = 13
        '
        'txtR4
        '
        Me.txtR4.Location = New System.Drawing.Point(325, 137)
        Me.txtR4.Name = "txtR4"
        Me.txtR4.Size = New System.Drawing.Size(88, 22)
        Me.txtR4.TabIndex = 12
        '
        'txtR3
        '
        Me.txtR3.Location = New System.Drawing.Point(325, 103)
        Me.txtR3.Name = "txtR3"
        Me.txtR3.Size = New System.Drawing.Size(88, 22)
        Me.txtR3.TabIndex = 11
        '
        'txtR1
        '
        Me.txtR1.Location = New System.Drawing.Point(325, 43)
        Me.txtR1.Name = "txtR1"
        Me.txtR1.Size = New System.Drawing.Size(88, 22)
        Me.txtR1.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(35, 143)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(229, 16)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Total de paquetes de ropa enviados:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(35, 110)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(250, 16)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Total de los paquetes de documentos Q:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(35, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(261, 16)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Paquetes de artículo de plástico enviados:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(36, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(227, 16)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Total de los paquetes de lociones Q:"
        '
        'ACEPTARToolStripMenuItem
        '
        Me.ACEPTARToolStripMenuItem.BackColor = System.Drawing.Color.LimeGreen
        Me.ACEPTARToolStripMenuItem.Name = "ACEPTARToolStripMenuItem"
        Me.ACEPTARToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ACEPTARToolStripMenuItem.Text = "ACEPTAR"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CALCULARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ENTRADASToolStripMenuItem, Me.VECTORESToolStripMenuItem})
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.CALCULARToolStripMenuItem.Text = "LIMPIAR"
        '
        'ENTRADASToolStripMenuItem
        '
        Me.ENTRADASToolStripMenuItem.Name = "ENTRADASToolStripMenuItem"
        Me.ENTRADASToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ENTRADASToolStripMenuItem.Text = "ENTRADAS"
        '
        'VECTORESToolStripMenuItem
        '
        Me.VECTORESToolStripMenuItem.Name = "VECTORESToolStripMenuItem"
        Me.VECTORESToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.VECTORESToolStripMenuItem.Text = "VECTORES"
        '
        'MOSTRARToolStripMenuItem
        '
        Me.MOSTRARToolStripMenuItem.BackColor = System.Drawing.Color.LimeGreen
        Me.MOSTRARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RESULTADOSToolStripMenuItem, Me.RESTADÍSTICAToolStripMenuItem})
        Me.MOSTRARToolStripMenuItem.Name = "MOSTRARToolStripMenuItem"
        Me.MOSTRARToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.MOSTRARToolStripMenuItem.Text = "MOSTRAR"
        '
        'RESULTADOSToolStripMenuItem
        '
        Me.RESULTADOSToolStripMenuItem.Name = "RESULTADOSToolStripMenuItem"
        Me.RESULTADOSToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.RESULTADOSToolStripMenuItem.Text = "RESULTADOS"
        '
        'RESTADÍSTICAToolStripMenuItem
        '
        Me.RESTADÍSTICAToolStripMenuItem.Name = "RESTADÍSTICAToolStripMenuItem"
        Me.RESTADÍSTICAToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.RESTADÍSTICAToolStripMenuItem.Text = "RESTADÍSTICAS"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.BackColor = System.Drawing.Color.Red
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACEPTARToolStripMenuItem, Me.CALCULARToolStripMenuItem, Me.MOSTRARToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(941, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(261, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Peso lb:"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(323, 59)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(74, 22)
        Me.txtPeso.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(941, 465)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbPaquetes As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ListBox8 As ListBox
    Friend WithEvents ListBox7 As ListBox
    Friend WithEvents ListBox6 As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtR2 As TextBox
    Friend WithEvents txtR4 As TextBox
    Friend WithEvents txtR3 As TextBox
    Friend WithEvents txtR1 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ACEPTARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOSTRARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents cmbEnvio As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents RESULTADOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RESTADÍSTICAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents Label4 As Label
End Class
