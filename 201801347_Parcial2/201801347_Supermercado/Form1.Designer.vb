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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DATAGRIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombrePack = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCantPack = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.OrangeRed
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCantPack)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombrePack)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbProducto)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(565, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DE INGRESO"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AToolStripMenuItem, Me.LIMPIARToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1090, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.BackColor = System.Drawing.Color.OrangeRed
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AToolStripMenuItem.Text = "ACEPTAR"
        '
        'LIMPIARToolStripMenuItem
        '
        Me.LIMPIARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATAGRIDToolStripMenuItem, Me.VECTORESToolStripMenuItem, Me.ENTRADASToolStripMenuItem})
        Me.LIMPIARToolStripMenuItem.Name = "LIMPIARToolStripMenuItem"
        Me.LIMPIARToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.LIMPIARToolStripMenuItem.Text = "LIMPIAR "
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'DATAGRIDToolStripMenuItem
        '
        Me.DATAGRIDToolStripMenuItem.Name = "DATAGRIDToolStripMenuItem"
        Me.DATAGRIDToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DATAGRIDToolStripMenuItem.Text = "DATAGRID"
        '
        'VECTORESToolStripMenuItem
        '
        Me.VECTORESToolStripMenuItem.Name = "VECTORESToolStripMenuItem"
        Me.VECTORESToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VECTORESToolStripMenuItem.Text = "VECTORES"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.BackColor = System.Drawing.Color.Red
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Column11, Me.Column3, Me.Column5, Me.Column6, Me.Column7, Me.Column9, Me.Column10, Me.Column8})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 210)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1068, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'cmbProducto
        '
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(184, 52)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(121, 21)
        Me.cmbProducto.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(181, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Producto:"
        '
        'txtNombrePack
        '
        Me.txtNombrePack.Location = New System.Drawing.Point(39, 53)
        Me.txtNombrePack.Name = "txtNombrePack"
        Me.txtNombrePack.Size = New System.Drawing.Size(100, 20)
        Me.txtNombrePack.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre del pack:"
        '
        'txtCantPack
        '
        Me.txtCantPack.Location = New System.Drawing.Point(342, 52)
        Me.txtCantPack.Name = "txtCantPack"
        Me.txtCantPack.Size = New System.Drawing.Size(100, 20)
        Me.txtCantPack.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(339, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cantidad:"
        '
        'Column1
        '
        Me.Column1.HeaderText = "NOMBRE DEL PACK"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "PRODUCTO DESEADO"
        Me.Column2.Name = "Column2"
        '
        'Column4
        '
        Me.Column4.HeaderText = "CANTIDAD EN EL PACK"
        Me.Column4.Name = "Column4"
        '
        'Column11
        '
        Me.Column11.HeaderText = "CANTIDAD EN INVENTARIO"
        Me.Column11.Name = "Column11"
        '
        'Column3
        '
        Me.Column3.HeaderText = "# DE PACKS "
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 50
        '
        'Column5
        '
        Me.Column5.HeaderText = "SOBRANTE"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 80
        '
        'Column6
        '
        Me.Column6.HeaderText = "INGRESOS DEL PACK"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "INGRESOS DEL SOBRANTE"
        Me.Column7.Name = "Column7"
        '
        'Column9
        '
        Me.Column9.HeaderText = "DESCUENTO"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "TOTAL PARCIAL"
        Me.Column10.Name = "Column10"
        '
        'Column8
        '
        Me.Column8.HeaderText = "TOTAL"
        Me.Column8.Name = "Column8"
        '
        'ENTRADASToolStripMenuItem
        '
        Me.ENTRADASToolStripMenuItem.Name = "ENTRADASToolStripMenuItem"
        Me.ENTRADASToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ENTRADASToolStripMenuItem.Text = "ENTRADAS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(1090, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbProducto As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DATAGRIDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombrePack As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCantPack As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents ENTRADASToolStripMenuItem As ToolStripMenuItem
End Class
