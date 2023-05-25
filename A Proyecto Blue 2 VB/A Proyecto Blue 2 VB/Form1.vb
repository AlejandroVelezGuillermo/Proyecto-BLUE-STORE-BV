Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace A_proyecto_blue_2
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnCrearCuenta_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Hide()
            Dim Uno As Form = New Form2()
            Uno.Show()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Hide()
            Dim Tres As Form = New Form3()
            Tres.Show()
        End Sub
    End Class
End Namespace

