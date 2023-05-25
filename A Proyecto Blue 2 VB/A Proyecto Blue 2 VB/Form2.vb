Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace A_proyecto_blue_2
    Partial Public Class Form2
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnRegistrar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim RegistrarUsario As TextWriter = New StreamWriter("C:\Users\soned\Videos\programas VS\A proyecto blue 2\A proyecto blue 2\bin\Debug\" & txtUsuarioRegister.Text & ".txt", True)
            RegistrarUsario.WriteLine(txtContraseñaRegister.Text)
            RegistrarUsario.Close()
            MessageBox.Show("Cuenta Creada.")
            txtUsuarioRegister.Clear()
            txtContraseñaRegister.Clear()
            Me.Hide()
            Dim Tres As Form = New Form3()
            Tres.Show()
        End Sub

        Private Sub btnAtras_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Hide()
            Dim Dos As Form = New Form1()
            Dos.Show()
        End Sub

        Private Sub txtUsuarioRegister_Enter(ByVal sender As Object, ByVal e As EventArgs)
            If 
                txtUsuarioRegister.Text = " Usuario Nuevo" Then
                txtUsuarioRegister.Text = ""
            End If
        End Sub

        Private Sub txtUsuarioRegister_Leave(ByVal sender As Object, ByVal e As EventArgs)
            If txtUsuarioRegister.Text = "" Then
                txtUsuarioRegister.Text = " Usuario Nuevo"
            End If
        End Sub

        Private Sub txtContraseñaRegister_Enter(ByVal sender As Object, ByVal e As EventArgs)
            If txtContraseñaRegister.Text = " Contraseña Nueva" Then
                txtContraseñaRegister.Text = ""
            End If

            txtContraseñaRegister.UseSystemPasswordChar = True
        End Sub

        Private Sub txtContraseñaRegister_Leave(ByVal sender As Object, ByVal e As EventArgs)
            If txtContraseñaRegister.Text = "" Then
                txtContraseñaRegister.Text = " Contraseña Nueva"
            End If

            txtContraseñaRegister.UseSystemPasswordChar = False
        End Sub
    End Class
End Namespace