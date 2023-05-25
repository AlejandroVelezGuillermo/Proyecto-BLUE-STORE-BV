<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.btnAtrasLogin = New System.Windows.Forms.Button()
        Me.btnINgresarLogin = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtContraseñaRegister = New System.Windows.Forms.TextBox()
        Me.txtUsuarioRegister = New System.Windows.Forms.TextBox()
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
        'btnAtrasLogin
        '
        Me.btnAtrasLogin.Location = New System.Drawing.Point(640, 339)
        Me.btnAtrasLogin.Name = "btnAtrasLogin"
        Me.btnAtrasLogin.Size = New System.Drawing.Size(117, 23)
        Me.btnAtrasLogin.TabIndex = 25
        Me.btnAtrasLogin.Text = "ATRAS"
        Me.btnAtrasLogin.UseVisualStyleBackColor = True
        '
        'btnINgresarLogin
        '
        Me.btnINgresarLogin.Location = New System.Drawing.Point(400, 339)
        Me.btnINgresarLogin.Name = "btnINgresarLogin"
        Me.btnINgresarLogin.Size = New System.Drawing.Size(117, 23)
        Me.btnINgresarLogin.TabIndex = 24
        Me.btnINgresarLogin.Text = "INGRESAR"
        Me.btnINgresarLogin.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(412, 160)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(335, 50)
        Me.label3.TabIndex = 23
        Me.label3.Text = "Por favor ingrese los siguientes datos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para poder ingresar a BLUE STORE."
        '
        'txtContraseñaRegister
        '
        Me.txtContraseñaRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.txtContraseñaRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseñaRegister.ForeColor = System.Drawing.Color.White
        Me.txtContraseñaRegister.Location = New System.Drawing.Point(400, 281)
        Me.txtContraseñaRegister.Name = "txtContraseñaRegister"
        Me.txtContraseñaRegister.Size = New System.Drawing.Size(357, 22)
        Me.txtContraseñaRegister.TabIndex = 22
        Me.txtContraseñaRegister.Text = " Contraseña"
        '
        'txtUsuarioRegister
        '
        Me.txtUsuarioRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.txtUsuarioRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioRegister.ForeColor = System.Drawing.Color.White
        Me.txtUsuarioRegister.Location = New System.Drawing.Point(400, 250)
        Me.txtUsuarioRegister.Name = "txtUsuarioRegister"
        Me.txtUsuarioRegister.Size = New System.Drawing.Size(357, 22)
        Me.txtUsuarioRegister.TabIndex = 21
        Me.txtUsuarioRegister.Text = " Usuario"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(382, 97)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(353, 38)
        Me.label2.TabIndex = 18
        Me.label2.Text = "LOGIN BLUE STORE"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(377, 45)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(365, 51)
        Me.label1.TabIndex = 17
        Me.label1.Text = "BIENVENIDO AL"
        '
        'pictureBox3
        '
        Me.pictureBox3.Image = Global.A_Proyecto_Blue_2_VB.My.Resources.Resources.bloquear
        Me.pictureBox3.Location = New System.Drawing.Point(369, 278)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(25, 25)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox3.TabIndex = 20
        Me.pictureBox3.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = Global.A_Proyecto_Blue_2_VB.My.Resources.Resources.persona
        Me.pictureBox2.Location = New System.Drawing.Point(369, 247)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 19
        Me.pictureBox2.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.A_Proyecto_Blue_2_VB.My.Resources.Resources.astronauta
        Me.pictureBox1.Location = New System.Drawing.Point(-2, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(346, 451)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 3
        Me.pictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAtrasLogin)
        Me.Controls.Add(Me.btnINgresarLogin)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txtContraseñaRegister)
        Me.Controls.Add(Me.txtUsuarioRegister)
        Me.Controls.Add(Me.pictureBox3)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents btnAtrasLogin As Button
    Private WithEvents btnINgresarLogin As Button
    Private WithEvents label3 As Label
    Private WithEvents txtContraseñaRegister As TextBox
    Private WithEvents txtUsuarioRegister As TextBox
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
