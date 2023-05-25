Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Text
Imports System.IO
Imports System.Linq
Imports System.Reflection.Emit
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Net.Mime.MediaTypeNames

Namespace A_proyecto_blue_2
    Partial Public Class Caja
        Inherits Form

        Private total As Integer = 0
        Private rowIndexToEdit As Integer = -1
        Private Codigo As Random = New Random()
        Private timer As Timer

        Public Sub New()
            InitializeComponent()
            Dim valor As Integer = 0
            valor = Convert.ToInt32(Codigo.[Next](0, 999))
            txtCodigo.Text = valor.ToString()
            txtCodigo.KeyDown += AddressOf Caja_KeyDown
            txtNombre.KeyDown += AddressOf Caja_KeyDown
            txtPxU.KeyDown += AddressOf Caja_KeyDown
            txtCantidad.KeyDown += AddressOf Caja_KeyDown
        End Sub

        Private Sub aGREGARToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Agregar_Producto()
        End Sub

        Private Sub eLIMINARPRODUCTOToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            EliminarProducto()
        End Sub

        Private Sub eDITARPRODUCTOToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            EditarProducto()
        End Sub

        Private Sub eliminarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            EliminarTodo()
        End Sub

        Private Sub btnGenerarCodigo_Click(ByVal sender As Object, ByVal e As EventArgs)
            GenerarCodigo()
        End Sub

        Private Sub btnPrecio_Click(ByVal sender As Object, ByVal e As EventArgs)
            GenerarPrecio()
        End Sub

        Private Sub BtnCantidad_Click(ByVal sender As Object, ByVal e As EventArgs)
            GenerarCantidad()
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Buscar()
        End Sub

        Private Sub btnPagar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Pagar()
        End Sub

        Private Sub gUARDADLISTAToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            GuardadLista()
        End Sub

        Public Sub Agregar_Producto()
            Dim producto As Producto = New Producto(Integer.Parse(txtCodigo.Text), txtNombre.Text, Double.Parse(txtPxU.Text), Integer.Parse(txtCantidad.Text))
            Dim n As Integer = dataGridView1.Rows.Add()
            Dim a As Integer = 0, b As Integer = 0
            a = (CInt(producto.Cantidad) * CInt(producto.PxU))
            b = a
            dataGridView1.Rows(n).Cells(0).Value = producto.Codigo
            dataGridView1.Rows(n).Cells(1).Value = producto.Nombre
            dataGridView1.Rows(n).Cells(2).Value = producto.PxU
            dataGridView1.Rows(n).Cells(3).Value = producto.Cantidad
            dataGridView1.Rows(n).Cells(4).Value = b
            Console.Beep()
            txtCodigo.Clear()
            txtNombre.Clear()
            txtPxU.Clear()
            txtCantidad.Clear()
            Dim SumaProducto As Integer = 0

            For i As Integer = 0 To dataGridView1.Rows.Count - 1
                Dim valorCelda As Integer = Convert.ToInt32(dataGridView1.Rows(i).Cells(4).Value)
                SumaProducto += valorCelda
            Next

            label5.Text = SumaProducto.ToString()
            Dim valor As Integer = 0
            valor = Convert.ToInt32(Codigo.[Next](0, 999))
            txtCodigo.Text = valor.ToString()
        End Sub

        Public Sub EliminarProducto()
            If dataGridView1.SelectedRows.Count > 0 Then
                Dim rowIndex As Integer = dataGridView1.SelectedRows(0).Index
                Dim precio As Integer = Convert.ToInt32(dataGridView1.Rows(rowIndex).Cells(4).Value)
                Dim sumaActual As Integer = Integer.Parse(label5.Text)
                Dim nuevaSuma As Integer = sumaActual - precio
                label5.Text = nuevaSuma.ToString()
                dataGridView1.Rows.RemoveAt(rowIndex)
            End If
        End Sub

        Private Sub EditarProducto()
            If dataGridView1.SelectedRows.Count > 0 Then
                Dim rowIndex As Integer = dataGridView1.SelectedRows(0).Index
                rowIndexToEdit = rowIndex
                Dim codigo As Integer = Convert.ToInt32(dataGridView1.Rows(rowIndex).Cells(0).Value)
                Dim nombre As String = dataGridView1.Rows(rowIndex).Cells(1).Value.ToString()
                Dim precio As Double = Convert.ToDouble(dataGridView1.Rows(rowIndex).Cells(2).Value)
                Dim cantidad As Integer = Convert.ToInt32(dataGridView1.Rows(rowIndex).Cells(3).Value)
                txtCodigo.Text = codigo.ToString()
                txtNombre.Text = nombre
                txtPxU.Text = precio.ToString()
                txtCantidad.Text = cantidad.ToString()
                dataGridView1.Rows.RemoveAt(rowIndex)
            End If
        End Sub

        Private Sub EliminarTodo()
            dataGridView1.Rows.Clear()
        End Sub

        Private Sub GenerarCodigo()
            Dim valor As Integer = 0
            valor = Convert.ToInt32(Codigo.[Next](0, 999))
            txtCodigo.Text = valor.ToString()
        End Sub

        Private Sub GenerarPrecio()
            Dim valor As Integer = 0
            valor = Convert.ToInt32(Codigo.[Next](0, 100))
            txtPxU.Text = valor.ToString()
        End Sub

        Private Sub GenerarCantidad()
            Dim valor As Integer = 0
            valor = Convert.ToInt32(Codigo.[Next](1, 10))
            txtCantidad.Text = valor.ToString()
        End Sub

        Private Sub Pagar()
            Dim pago As Integer = 0

            If Integer.TryParse(txtPago.Text, pago) Then
                Dim total As Integer = Integer.Parse(label5.Text)
                Dim cambio As Integer = pago - total
                MessageBox.Show($"Total: {total}\nPago: {pago}\nCambio: {cambio}")
                dataGridView1.Rows.Clear()
                Console.Beep()
                dataGridView1.Rows.Clear()
                label5.Text = "Total : $0.0"
                txtPago.Clear()
            Else
                MessageBox.Show("Ingrese un valor válido para el pago.")
            End If
        End Sub

        Private Sub Buscar()
            Dim codigoBuscado As String = txtBuscarCodigo.Text
            Dim encontrado As Boolean = False

            For Each row As DataGridViewRow In dataGridView1.Rows

                If row.Cells(0).Value IsNot Nothing AndAlso row.Cells(0).Value.ToString() = codigoBuscado Then
                    dataGridView1.CurrentCell = row.Cells(0)
                    encontrado = True
                    txtBuscarCodigo.Clear()
                    Exit For
                End If

                If row.Cells(0).Value IsNot Nothing AndAlso row.Cells(1).Value.ToString() = codigoBuscado Then
                    dataGridView1.CurrentCell = row.Cells(1)
                    encontrado = True
                    txtBuscarCodigo.Clear()
                    Exit For
                End If
            Next

            If Not encontrado Then
                MessageBox.Show("Producto no encontrado, Ingrese (Código o Nombre)", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Sub

        Private Sub GuardadLista()
            Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt"
            saveFileDialog.Title = "Guardar archivo de texto"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then

                Try

                    Using sw As StreamWriter = New StreamWriter(saveFileDialog.FileName)

                        For Each row As DataGridViewRow In dataGridView1.Rows

                            If Not row.IsNewRow Then
                                Dim codigo As String = row.Cells(0).Value.ToString()
                                Dim nombre As String = row.Cells(1).Value.ToString()
                                Dim pxu As String = row.Cells(2).Value.ToString()
                                Dim cantidad As String = row.Cells(3).Value.ToString()
                                Dim total As String = row.Cells(4).Value.ToString()
                                sw.WriteLine($"{codigo},{nombre},{pxu},{cantidad},{total}")
                            End If
                        Next
                    End Using

                    MessageBox.Show("Datos guardados correctamente.")
                Catch ex As Exception
                    MessageBox.Show("Error al guardar el archivo: " & ex.Message)
                End Try
            End If
        End Sub

        Private Sub Caja_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                Dim nextControl As Control = GetNextControl(CType(sender, Control), True)

                If nextControl IsNot Nothing Then
                    nextControl.Focus()
                End If
            End If
        End Sub

        Private Sub aBRIRLALISTAToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt"
            openFileDialog.Title = "Abrir archivo de texto"

            If openFileDialog.ShowDialog() = DialogResult.OK Then

                Try
                    Dim filePath As String = openFileDialog.FileName
                    Dim lines As String() = File.ReadAllLines(filePath)
                    dataGridView1.Rows.Clear()

                    For Each line As String In lines
                        Dim parts As String() = line.Split(","c)
                        Dim rowIndex As Integer = dataGridView1.Rows.Add()
                        dataGridView1.Rows(rowIndex).Cells(0).Value = parts(0)
                        dataGridView1.Rows(rowIndex).Cells(1).Value = parts(1)
                        dataGridView1.Rows(rowIndex).Cells(2).Value = parts(2)
                        dataGridView1.Rows(rowIndex).Cells(3).Value = parts(3)
                        dataGridView1.Rows(rowIndex).Cells(4).Value = parts(4)
                    Next

                Catch ex As Exception
                    MessageBox.Show("Error al abrir el archivo: " & ex.Message)
                End Try
            End If
        End Sub
    End Class
End Namespace
