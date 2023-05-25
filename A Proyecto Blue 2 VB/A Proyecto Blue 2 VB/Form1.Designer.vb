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
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnCrearCuenta = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.A_Proyecto_Blue_2_VB.My.Resources.Resources.astronauta
        Me.pictureBox1.Location = New System.Drawing.Point(-7, -1)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(346, 451)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 1
        Me.pictureBox1.TabStop = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(369, 129)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(434, 100)
        Me.label3.TabIndex = 6
        Me.label3.Text = "BLUE es un sistema de tienda donde podemos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "agregar productos para vender, calcul" &
    "ar el precio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ademas le da al usario una mejor expreciencia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "con BLUE STORE."
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(461, 79)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(236, 38)
        Me.label2.TabIndex = 5
        Me.label2.Text = "BLUE STORE"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(414, 27)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(340, 51)
        Me.label1.TabIndex = 4
        Me.label1.Text = "BIENVENIDO A"
        '
        'btnCrearCuenta
        '
        Me.btnCrearCuenta.Location = New System.Drawing.Point(468, 356)
        Me.btnCrearCuenta.Name = "btnCrearCuenta"
        Me.btnCrearCuenta.Size = New System.Drawing.Size(224, 23)
        Me.btnCrearCuenta.TabIndex = 9
        Me.btnCrearCuenta.Text = "CREAR UNA CUENTA DE BLUE STORE"
        Me.btnCrearCuenta.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(468, 327)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(224, 23)
        Me.button1.TabIndex = 8
        Me.button1.Text = "INGRESAR A BLUE STORE"
        Me.button1.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(453, 298)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(255, 16)
        Me.label4.TabIndex = 7
        Me.label4.Text = "PORFAVOR SELECCIONE UNA OBCION"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(841, 450)
        Me.Controls.Add(Me.btnCrearCuenta)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox1)
        Me.ForeColor = System.Drawing.Color.SlateGray
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents btnCrearCuenta As Button
    Private WithEvents button1 As Button
    Private WithEvents label4 As Label
End Class
