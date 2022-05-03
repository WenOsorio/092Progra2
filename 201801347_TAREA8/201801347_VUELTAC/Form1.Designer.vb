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
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnOrdenar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEntradas = New System.Windows.Forms.Button()
        Me.btnVectores = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.txtConsulta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTiempo = New System.Windows.Forms.TextBox()
        Me.txtKm = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEtapa = New System.Windows.Forms.TextBox()
        Me.cmbEquipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtR1 = New System.Windows.Forms.TextBox()
        Me.txtR2_1 = New System.Windows.Forms.TextBox()
        Me.txtR2_2 = New System.Windows.Forms.TextBox()
        Me.txtR2_3 = New System.Windows.Forms.TextBox()
        Me.txtR2_4 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnEstadisticas = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtR3_1 = New System.Windows.Forms.TextBox()
        Me.txtR3_2 = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.GreenYellow
        Me.GroupBox1.Controls.Add(Me.rb2)
        Me.GroupBox1.Controls.Add(Me.rb1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtTiempo)
        Me.GroupBox1.Controls.Add(Me.txtKm)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtEtapa)
        Me.GroupBox1.Controls.Add(Me.cmbEquipo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(562, 247)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS"
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Location = New System.Drawing.Point(229, 67)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(72, 17)
        Me.rb2.TabIndex = 12
        Me.rb2.TabStop = True
        Me.rb2.Text = "Extranjero"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Location = New System.Drawing.Point(229, 47)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(91, 17)
        Me.rb1.TabIndex = 11
        Me.rb1.TabStop = True
        Me.rb1.Text = "Guatemalteco"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnActualizar)
        Me.GroupBox3.Controls.Add(Me.btnSalir)
        Me.GroupBox3.Controls.Add(Me.btnMostrar)
        Me.GroupBox3.Controls.Add(Me.btnOrdenar)
        Me.GroupBox3.Controls.Add(Me.btnGuardar)
        Me.GroupBox3.Controls.Add(Me.btnEntradas)
        Me.GroupBox3.Controls.Add(Me.btnVectores)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 178)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(554, 63)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "OPCIONES"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Red
        Me.btnSalir.Location = New System.Drawing.Point(161, 22)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 32)
        Me.btnSalir.TabIndex = 17
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnMostrar
        '
        Me.btnMostrar.BackColor = System.Drawing.Color.LightGreen
        Me.btnMostrar.Location = New System.Drawing.Point(83, 21)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 32)
        Me.btnMostrar.TabIndex = 12
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = False
        '
        'btnOrdenar
        '
        Me.btnOrdenar.BackColor = System.Drawing.Color.LightGreen
        Me.btnOrdenar.Location = New System.Drawing.Point(318, 18)
        Me.btnOrdenar.Name = "btnOrdenar"
        Me.btnOrdenar.Size = New System.Drawing.Size(75, 38)
        Me.btnOrdenar.TabIndex = 14
        Me.btnOrdenar.Text = "Ordenar ascendente"
        Me.btnOrdenar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnGuardar.Location = New System.Drawing.Point(5, 20)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 32)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnEntradas
        '
        Me.btnEntradas.BackColor = System.Drawing.Color.LimeGreen
        Me.btnEntradas.Location = New System.Drawing.Point(396, 20)
        Me.btnEntradas.Name = "btnEntradas"
        Me.btnEntradas.Size = New System.Drawing.Size(75, 35)
        Me.btnEntradas.TabIndex = 16
        Me.btnEntradas.Text = "Limpiar Entradas"
        Me.btnEntradas.UseVisualStyleBackColor = False
        '
        'btnVectores
        '
        Me.btnVectores.BackColor = System.Drawing.Color.LimeGreen
        Me.btnVectores.Location = New System.Drawing.Point(474, 20)
        Me.btnVectores.Name = "btnVectores"
        Me.btnVectores.Size = New System.Drawing.Size(75, 35)
        Me.btnVectores.TabIndex = 15
        Me.btnVectores.Text = "Limpiar vectores"
        Me.btnVectores.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnConsultar)
        Me.GroupBox2.Controls.Add(Me.txtConsulta)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(326, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 109)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CONSULTA"
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.Chartreuse
        Me.btnConsultar.Location = New System.Drawing.Point(115, 55)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 31)
        Me.btnConsultar.TabIndex = 13
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'txtConsulta
        '
        Me.txtConsulta.Location = New System.Drawing.Point(9, 61)
        Me.txtConsulta.Name = "txtConsulta"
        Me.txtConsulta.Size = New System.Drawing.Size(100, 20)
        Me.txtConsulta.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "No. Etapa:"
        '
        'txtTiempo
        '
        Me.txtTiempo.Location = New System.Drawing.Point(76, 124)
        Me.txtTiempo.Name = "txtTiempo"
        Me.txtTiempo.Size = New System.Drawing.Size(100, 20)
        Me.txtTiempo.TabIndex = 9
        '
        'txtKm
        '
        Me.txtKm.Location = New System.Drawing.Point(76, 89)
        Me.txtKm.Name = "txtKm"
        Me.txtKm.Size = New System.Drawing.Size(100, 20)
        Me.txtKm.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(226, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nacionalidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tiempo (min):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Kilometros:"
        '
        'txtEtapa
        '
        Me.txtEtapa.Location = New System.Drawing.Point(76, 27)
        Me.txtEtapa.Name = "txtEtapa"
        Me.txtEtapa.Size = New System.Drawing.Size(100, 20)
        Me.txtEtapa.TabIndex = 3
        '
        'cmbEquipo
        '
        Me.cmbEquipo.FormattingEnabled = True
        Me.cmbEquipo.Location = New System.Drawing.Point(76, 57)
        Me.cmbEquipo.Name = "cmbEquipo"
        Me.cmbEquipo.Size = New System.Drawing.Size(121, 21)
        Me.cmbEquipo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Equipo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Etapa:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(87, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(783, 154)
        Me.DataGridView1.TabIndex = 8
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.LightGreen
        Me.btnActualizar.Location = New System.Drawing.Point(240, 23)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 30)
        Me.btnActualizar.TabIndex = 18
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtR3_2)
        Me.GroupBox4.Controls.Add(Me.txtR3_1)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.btnEstadisticas)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtR2_4)
        Me.GroupBox4.Controls.Add(Me.txtR2_3)
        Me.GroupBox4.Controls.Add(Me.txtR2_2)
        Me.GroupBox4.Controls.Add(Me.txtR2_1)
        Me.GroupBox4.Controls.Add(Me.txtR1)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(575, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(379, 245)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ESTADÍSTICAS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(265, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cuántos corredores nacionales hicieron más de 45 km:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(187, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Kilómetros recorridos por cada equipo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Tiempo total por nacionalidad:"
        '
        'txtR1
        '
        Me.txtR1.Location = New System.Drawing.Point(286, 62)
        Me.txtR1.Name = "txtR1"
        Me.txtR1.Size = New System.Drawing.Size(79, 20)
        Me.txtR1.TabIndex = 3
        '
        'txtR2_1
        '
        Me.txtR2_1.Location = New System.Drawing.Point(18, 125)
        Me.txtR2_1.Name = "txtR2_1"
        Me.txtR2_1.Size = New System.Drawing.Size(73, 20)
        Me.txtR2_1.TabIndex = 4
        '
        'txtR2_2
        '
        Me.txtR2_2.Location = New System.Drawing.Point(107, 125)
        Me.txtR2_2.Name = "txtR2_2"
        Me.txtR2_2.Size = New System.Drawing.Size(73, 20)
        Me.txtR2_2.TabIndex = 5
        '
        'txtR2_3
        '
        Me.txtR2_3.Location = New System.Drawing.Point(198, 125)
        Me.txtR2_3.Name = "txtR2_3"
        Me.txtR2_3.Size = New System.Drawing.Size(73, 20)
        Me.txtR2_3.TabIndex = 6
        '
        'txtR2_4
        '
        Me.txtR2_4.Location = New System.Drawing.Point(292, 125)
        Me.txtR2_4.Name = "txtR2_4"
        Me.txtR2_4.Size = New System.Drawing.Size(73, 20)
        Me.txtR2_4.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Sky:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(104, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Movistar:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(195, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Pro Cycling:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(289, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Pro Team:"
        '
        'btnEstadisticas
        '
        Me.btnEstadisticas.BackColor = System.Drawing.Color.Chartreuse
        Me.btnEstadisticas.Location = New System.Drawing.Point(204, 204)
        Me.btnEstadisticas.Name = "btnEstadisticas"
        Me.btnEstadisticas.Size = New System.Drawing.Size(161, 30)
        Me.btnEstadisticas.TabIndex = 17
        Me.btnEstadisticas.Text = "Mostrar Estadísticas"
        Me.btnEstadisticas.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(195, 162)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Guatemalteco:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(289, 162)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Extranjero:"
        '
        'txtR3_1
        '
        Me.txtR3_1.Location = New System.Drawing.Point(198, 178)
        Me.txtR3_1.Name = "txtR3_1"
        Me.txtR3_1.Size = New System.Drawing.Size(73, 20)
        Me.txtR3_1.TabIndex = 20
        '
        'txtR3_2
        '
        Me.txtR3_2.Location = New System.Drawing.Point(292, 178)
        Me.txtR3_2.Name = "txtR3_2"
        Me.txtR3_2.Size = New System.Drawing.Size(73, 20)
        Me.txtR3_2.TabIndex = 21
        '
        'Column1
        '
        Me.Column1.HeaderText = "No. Etapa"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 70
        '
        'Column2
        '
        Me.Column2.HeaderText = "Equipo"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Kilometros"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tiempo"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Nacionalidad"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 130
        '
        'Column6
        '
        Me.Column6.HeaderText = "Penalización (min)"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 120
        '
        'Column7
        '
        Me.Column7.HeaderText = "Tiempo total (min)"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 120
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.ForestGreen
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 263)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(947, 185)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "RESULTADOS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(964, 450)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtEtapa As TextBox
    Friend WithEvents cmbEquipo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnOrdenar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEntradas As Button
    Friend WithEvents btnVectores As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnConsultar As Button
    Friend WithEvents txtConsulta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTiempo As TextBox
    Friend WithEvents txtKm As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnActualizar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents txtR3_2 As TextBox
    Friend WithEvents txtR3_1 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnEstadisticas As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtR2_4 As TextBox
    Friend WithEvents txtR2_3 As TextBox
    Friend WithEvents txtR2_2 As TextBox
    Friend WithEvents txtR2_1 As TextBox
    Friend WithEvents txtR1 As TextBox
    Friend WithEvents GroupBox5 As GroupBox
End Class
