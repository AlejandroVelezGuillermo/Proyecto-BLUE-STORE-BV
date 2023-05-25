<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caja
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
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscarCodigo = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtPago = New System.Windows.Forms.TextBox()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCantidad = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnPrecio = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnGenerarCodigo = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPxU = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.aGREGARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.eLIMINARPRODUCTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.eliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.eDITARPRODUCTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gUARDADLISTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aBRIRLALISTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.groupBox3.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.btnBuscar)
        Me.groupBox3.Controls.Add(Me.txtBuscarCodigo)
        Me.groupBox3.Controls.Add(Me.label7)
        Me.groupBox3.Location = New System.Drawing.Point(716, 59)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(357, 165)
        Me.groupBox3.TabIndex = 29
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "SISTEMA DE BUSQUEDA"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(9, 84)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 19
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscarCodigo
        '
        Me.txtBuscarCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscarCodigo.Location = New System.Drawing.Point(9, 56)
        Me.txtBuscarCodigo.Name = "txtBuscarCodigo"
        Me.txtBuscarCodigo.Size = New System.Drawing.Size(246, 22)
        Me.txtBuscarCodigo.TabIndex = 20
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.White
        Me.label7.Location = New System.Drawing.Point(6, 29)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(287, 16)
        Me.label7.TabIndex = 21
        Me.label7.Text = "Ingrese Codigo  o Nombre Del Producto:"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.Controls.Add(Me.txtPago)
        Me.groupBox2.Controls.Add(Me.btnPagar)
        Me.groupBox2.Location = New System.Drawing.Point(510, 59)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(200, 165)
        Me.groupBox2.TabIndex = 30
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "SISTEMA DE PAGO"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(6, 29)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(44, 16)
        Me.label5.TabIndex = 10
        Me.label5.Text = "label5"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.ForeColor = System.Drawing.Color.White
        Me.label6.Location = New System.Drawing.Point(6, 59)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(63, 16)
        Me.label6.TabIndex = 14
        Me.label6.Text = "RECIBIO:"
        '
        'txtPago
        '
        Me.txtPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPago.Location = New System.Drawing.Point(75, 53)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(100, 22)
        Me.txtPago.TabIndex = 13
        '
        'btnPagar
        '
        Me.btnPagar.Location = New System.Drawing.Point(62, 96)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(75, 23)
        Me.btnPagar.TabIndex = 12
        Me.btnPagar.Text = "PAGAR"
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dataGridView1.GridColor = System.Drawing.Color.Yellow
        Me.dataGridView1.Location = New System.Drawing.Point(12, 253)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.RowHeadersWidth = 51
        Me.dataGridView1.RowTemplate.Height = 24
        Me.dataGridView1.Size = New System.Drawing.Size(1061, 179)
        Me.dataGridView1.TabIndex = 27
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Precio x Unidad"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cantidad"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Precio x Cantidad"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.BtnCantidad)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.btnPrecio)
        Me.groupBox1.Controls.Add(Me.txtCodigo)
        Me.groupBox1.Controls.Add(Me.btnGenerarCodigo)
        Me.groupBox1.Controls.Add(Me.txtNombre)
        Me.groupBox1.Controls.Add(Me.txtPxU)
        Me.groupBox1.Controls.Add(Me.txtCantidad)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Location = New System.Drawing.Point(12, 59)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(492, 165)
        Me.groupBox1.TabIndex = 28
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "DATOS PRODUCTOS"
        '
        'BtnCantidad
        '
        Me.BtnCantidad.Location = New System.Drawing.Point(348, 118)
        Me.BtnCantidad.Name = "BtnCantidad"
        Me.BtnCantidad.Size = New System.Drawing.Size(123, 23)
        Me.BtnCantidad.TabIndex = 28
        Me.BtnCantidad.Text = "Generar Cantidad"
        Me.BtnCantidad.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(6, 36)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(61, 16)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Codigo:"
        '
        'btnPrecio
        '
        Me.btnPrecio.Location = New System.Drawing.Point(348, 86)
        Me.btnPrecio.Name = "btnPrecio"
        Me.btnPrecio.Size = New System.Drawing.Size(123, 23)
        Me.btnPrecio.TabIndex = 27
        Me.btnPrecio.Text = "Generar Precio"
        Me.btnPrecio.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodigo.Location = New System.Drawing.Point(144, 30)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(198, 22)
        Me.txtCodigo.TabIndex = 5
        '
        'btnGenerarCodigo
        '
        Me.btnGenerarCodigo.Location = New System.Drawing.Point(348, 26)
        Me.btnGenerarCodigo.Name = "btnGenerarCodigo"
        Me.btnGenerarCodigo.Size = New System.Drawing.Size(123, 23)
        Me.btnGenerarCodigo.TabIndex = 26
        Me.btnGenerarCodigo.Text = "Generar Codigo"
        Me.btnGenerarCodigo.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(144, 59)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(198, 22)
        Me.txtNombre.TabIndex = 6
        '
        'txtPxU
        '
        Me.txtPxU.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPxU.Location = New System.Drawing.Point(144, 90)
        Me.txtPxU.Name = "txtPxU"
        Me.txtPxU.Size = New System.Drawing.Size(198, 22)
        Me.txtPxU.TabIndex = 7
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCantidad.Location = New System.Drawing.Point(144, 121)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(198, 22)
        Me.txtCantidad.TabIndex = 8
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(6, 65)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(66, 16)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Nombre:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(6, 96)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(121, 16)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Precio x Unidad:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(6, 124)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(73, 16)
        Me.label4.TabIndex = 4
        Me.label4.Text = "Cantidad:"
        '
        'menuStrip1
        '
        Me.menuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.menuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aGREGARToolStripMenuItem, Me.eLIMINARPRODUCTOToolStripMenuItem, Me.eDITARPRODUCTOToolStripMenuItem, Me.gUARDADLISTAToolStripMenuItem, Me.aBRIRLALISTAToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(1096, 28)
        Me.menuStrip1.TabIndex = 26
        Me.menuStrip1.Text = "menuStrip1"
        '
        'aGREGARToolStripMenuItem
        '
        Me.aGREGARToolStripMenuItem.Name = "aGREGARToolStripMenuItem"
        Me.aGREGARToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.aGREGARToolStripMenuItem.Text = "AGREGAR"
        '
        'eLIMINARPRODUCTOToolStripMenuItem
        '
        Me.eLIMINARPRODUCTOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.eliminarToolStripMenuItem})
        Me.eLIMINARPRODUCTOToolStripMenuItem.Name = "eLIMINARPRODUCTOToolStripMenuItem"
        Me.eLIMINARPRODUCTOToolStripMenuItem.Size = New System.Drawing.Size(169, 24)
        Me.eLIMINARPRODUCTOToolStripMenuItem.Text = "ELIMINAR PRODUCTO"
        '
        'eliminarToolStripMenuItem
        '
        Me.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem"
        Me.eliminarToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.eliminarToolStripMenuItem.Text = "ELIMINAR TODO"
        '
        'eDITARPRODUCTOToolStripMenuItem
        '
        Me.eDITARPRODUCTOToolStripMenuItem.Name = "eDITARPRODUCTOToolStripMenuItem"
        Me.eDITARPRODUCTOToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.eDITARPRODUCTOToolStripMenuItem.Text = "EDITAR PRODUCTO"
        '
        'gUARDADLISTAToolStripMenuItem
        '
        Me.gUARDADLISTAToolStripMenuItem.Name = "gUARDADLISTAToolStripMenuItem"
        Me.gUARDADLISTAToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.gUARDADLISTAToolStripMenuItem.Text = "GUARDAD LISTA"
        '
        'aBRIRLALISTAToolStripMenuItem
        '
        Me.aBRIRLALISTAToolStripMenuItem.Name = "aBRIRLALISTAToolStripMenuItem"
        Me.aBRIRLALISTAToolStripMenuItem.Size = New System.Drawing.Size(125, 24)
        Me.aBRIRLALISTAToolStripMenuItem.Text = "ABRIR LA LISTA"
        '
        'Caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1096, 450)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Name = "Caja"
        Me.Text = "Caja"
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents groupBox3 As GroupBox
    Private WithEvents btnBuscar As Button
    Private WithEvents txtBuscarCodigo As TextBox
    Private WithEvents label7 As Label
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents label5 As Label
    Private WithEvents label6 As Label
    Private WithEvents txtPago As TextBox
    Private WithEvents btnPagar As Button
    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents Column1 As DataGridViewTextBoxColumn
    Private WithEvents Column2 As DataGridViewTextBoxColumn
    Private WithEvents Column3 As DataGridViewTextBoxColumn
    Private WithEvents Column4 As DataGridViewTextBoxColumn
    Private WithEvents Column5 As DataGridViewTextBoxColumn
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents BtnCantidad As Button
    Private WithEvents label1 As Label
    Private WithEvents btnPrecio As Button
    Private WithEvents txtCodigo As TextBox
    Private WithEvents btnGenerarCodigo As Button
    Private WithEvents txtNombre As TextBox
    Private WithEvents txtPxU As TextBox
    Private WithEvents txtCantidad As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label3 As Label
    Private WithEvents label4 As Label
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents aGREGARToolStripMenuItem As ToolStripMenuItem
    Private WithEvents eLIMINARPRODUCTOToolStripMenuItem As ToolStripMenuItem
    Private WithEvents eliminarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents eDITARPRODUCTOToolStripMenuItem As ToolStripMenuItem
    Private WithEvents gUARDADLISTAToolStripMenuItem As ToolStripMenuItem
    Private WithEvents aBRIRLALISTAToolStripMenuItem As ToolStripMenuItem
End Class
