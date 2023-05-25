<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtContraseñaRegister = New System.Windows.Forms.TextBox()
        Me.txtUsuarioRegister = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(643, 323)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(117, 23)
        Me.btnAtras.TabIndex = 20
        Me.btnAtras.Text = "ATRAS"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(403, 323)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(117, 23)
        Me.btnRegistrar.TabIndex = 19
        Me.btnRegistrar.Text = "REGISTRAR"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'txtContraseñaRegister
        '
        Me.txtContraseñaRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.txtContraseñaRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseñaRegister.ForeColor = System.Drawing.Color.White
        Me.txtContraseñaRegister.Location = New System.Drawing.Point(403, 275)
        Me.txtContraseñaRegister.Name = "txtContraseñaRegister"
        Me.txtContraseñaRegister.Size = New System.Drawing.Size(357, 22)
        Me.txtContraseñaRegister.TabIndex = 18
        Me.txtContraseñaRegister.Text = " Contraseña Nueva"
        '
        'txtUsuarioRegister
        '
        Me.txtUsuarioRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.txtUsuarioRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioRegister.ForeColor = System.Drawing.Color.White
        Me.txtUsuarioRegister.Location = New System.Drawing.Point(403, 244)
        Me.txtUsuarioRegister.Name = "txtUsuarioRegister"
        Me.txtUsuarioRegister.Size = New System.Drawing.Size(357, 22)
        Me.txtUsuarioRegister.TabIndex = 17
        Me.txtUsuarioRegister.Text = " Usuario Nuevo"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(367, 167)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(407, 50)
        Me.label3.TabIndex = 16
        Me.label3.Text = "Por favor ingrese los siguientes datos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para poder crear su cuenta de BLUE STORE." &
    ""
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(352, 84)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(426, 38)
        Me.label2.TabIndex = 13
        Me.label2.Text = "REGISTRO BLUE STORE"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(390, 32)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(365, 51)
        Me.label1.TabIndex = 12
        Me.label1.Text = "BIENVENIDO AL"
        '
        'pictureBox3
        '
        Me.pictureBox3.Image = Global.A_Proyecto_Blue_2_VB.My.Resources.Resources.bloquear
        Me.pictureBox3.Location = New System.Drawing.Point(372, 272)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(25, 25)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox3.TabIndex = 15
        Me.pictureBox3.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = Global.A_Proyecto_Blue_2_VB.My.Resources.Resources.persona
        Me.pictureBox2.Location = New System.Drawing.Point(372, 241)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 14
        Me.pictureBox2.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.A_Proyecto_Blue_2_VB.My.Resources.Resources.astronauta
        Me.pictureBox1.Location = New System.Drawing.Point(-4, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(346, 451)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 2
        Me.pictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtContraseñaRegister)
        Me.Controls.Add(Me.txtUsuarioRegister)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.pictureBox3)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents btnAtras As Button
    Private WithEvents btnRegistrar As Button
    Private WithEvents txtContraseñaRegister As TextBox
    Private WithEvents txtUsuarioRegister As TextBox
    Private WithEvents label3 As Label
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
