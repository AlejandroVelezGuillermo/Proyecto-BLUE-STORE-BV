Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace A_proyecto_blue_2
    Friend Class Producto
        Public Property Codigo As Integer
        Public Property Nombre As String
        Public Property PxU As Double
        Public Property Cantidad As Integer

        Public Sub New(ByVal codigo As Integer, ByVal nombre As String, ByVal pxu As Double, ByVal cantidad As Integer)
            codigo = codigo
            nombre = nombre
            pxu = pxu
            cantidad = cantidad
        End Sub
    End Class
End Namespace