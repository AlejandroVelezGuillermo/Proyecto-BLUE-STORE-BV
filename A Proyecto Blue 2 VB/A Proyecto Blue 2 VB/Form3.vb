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
    Partial Public Class Form3
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnINgresarLogin_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim mundo As TextReader = New StreamReader(txtUsuarioRegister.Text & ".txt")

            If mundo.ReadLine() = txtContraseñaRegister.Text Then
                MessageBox.Show("Se Encontro Su Cuneta.")
                Me.Hide()
                Dim xdd As Form = New Caja()
                xdd.Show()
            Else
                MessageBox.Show("no encontro")
            End If
        End Sub

        Private Sub txtUsuarioRegister_Enter(ByVal sender As Object, ByVal e As EventArgs)
            If txtUsuarioRegister.Text = " Usuario" Then
                txtUsuarioRegister.Text = ""
            End If
        End Sub

        Private Sub txtUsuarioRegister_Leave(ByVal sender As Object, ByVal e As EventArgs)
            If txtUsuarioRegister.Text = "" Then
                txtUsuarioRegister.Text = " Usuario"
            End If
        End Sub

        Private Sub txtContraseñaRegister_Enter(ByVal sender As Object, ByVal e As EventArgs)
            If txtContraseñaRegister.Text = " Contraseña" Then
                txtContraseñaRegister.Text = ""
            End If

            txtContraseñaRegister.UseSystemPasswordChar = True
        End Sub

        Private Sub txtContraseñaRegister_Leave(ByVal sender As Object, ByVal e As EventArgs)
            If txtContraseñaRegister.Text = "" Then
                txtContraseñaRegister.Text = " Contraseña"
            End If

            txtContraseñaRegister.UseSystemPasswordChar = False
        End Sub

        Private Sub btnAtrasLogin_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Hide()
            Dim Dos As Form = New Form1()
            Dos.Show()
        End Sub
    End Class
End Namespace