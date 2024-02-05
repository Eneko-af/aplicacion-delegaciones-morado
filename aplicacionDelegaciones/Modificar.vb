Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView

Public Class Modificar
    Private y As String = 0
    Private Sub Modificar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        llenar_id()
    End Sub


    Private Sub llenar_id()
        IDS.Items.Clear()

        Try
            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;"
            Dim queryString As String = "SELECT ID_ARTICULO FROM ARTICULOS"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(queryString, connection)
                    connection.Open()

                    ' Utilizar un DataReader para obtener los nombres de las columnas
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            ' Agregar cada nombre de columna al ComboBox
                            IDS.Items.Add(reader("ID_ARTICULO").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub IDS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IDS.SelectedIndexChanged

        Try
            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;"
            Dim query As String = "SELECT  Nombre, Precio, Descripcion, Stock_Max, Stock_Min, Categoria_ID FROM ARTICULOS where id_articulo = " + IDS.Text

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    connection.Open()

                    ' Utilizar un DataReader para obtener los nombres de las columnas
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Obtener datos del artículo
                            Dim nombreArticulo As String = reader.GetString(0)
                            Dim precioArticulo As Decimal = reader.GetDecimal(1)
                            Dim descripcionArticulo As String = reader.GetString(2)
                            Dim stockMax As Integer = reader.GetInt32(3)
                            Dim stockMin As Integer = reader.GetInt32(4)
                            Dim categoriaArticulo As String = reader.GetInt32(5)

                            ' Mostrar datos en los ComboBoxes
                            nombre.Text = nombreArticulo
                            precio.Text = precioArticulo.ToString()
                            descripcion.Text = descripcionArticulo
                            stock_max.Text = stockMax.ToString()
                            stock_min.Text = stockMin.ToString()
                            CATEGORIA.Text = categoriaArticulo
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception

            MessageBox.Show($"Error: {ex}")
        End Try
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        Dim idArticulo As String = IDS.Text
        Dim nombreArticulo As String = nombre.Text
        Dim precioArticulo As String = precio.Text
        Dim descripcionArticulo As String = descripcion.Text
        Dim stockMax As String = stock_max.Text
        Dim stockMin As String = stock_min.Text
        Dim categoriaArticulo As String = CATEGORIA.Text

        y = idArticulo
        If idArticulo.Length > 0 Then

            If nombreArticulo.Length > 0 And categoriaArticulo.Length > 0 Then
                If update(idArticulo, nombreArticulo, precioArticulo, descripcionArticulo, stockMax, stockMin, categoriaArticulo) Then
                    MessageBox.Show("Se modifico el articulo con codigo " + idArticulo)
                    limpiar()
                End If
            Else

                MessageBox.Show("El nombre del articulo y la categoria son campos obligatorios")
            End If
        Else
            MessageBox.Show("Ningun articulo seleccionado")

        End If

    End Sub

    Private Sub limpiar()
        IDS.Text = ""
        nombre.Text = ""
        precio.Text = ""
        descripcion.Text = ""
        stock_max.Text = ""
        stock_min.Text = ""
        CATEGORIA.Text = ""
    End Sub

    Private Function update(id As String, nom As String, pre As String, de As String, max As String, min As String, ca As String) As Boolean
        Try
            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim queryString As String = "UPDATE ARTICULOS
                                          SET Nombre = @Nombre,
                                              Precio = @Precio,
                                              Descripcion = @Descripcion, 
                                              Stock_Max = @Stock_Max,
                                              Stock_Min = @Stock_Min,
                                              CATEGORIA_ID = @Categoria
                                          WHERE id_articulo = @Id;"

                Using command As New SqlCommand(queryString, connection)
                    ' Configurar parámetros
                    command.Parameters.AddWithValue("@Nombre", nom)
                    Try
                        command.Parameters.AddWithValue("@Precio", Convert.ToDecimal(pre))
                    Catch ex As Exception
                        command.Parameters.AddWithValue("@Precio", Convert.ToDecimal(0.0))
                    End Try
                    command.Parameters.AddWithValue("@Descripcion", de)
                    Try
                        command.Parameters.AddWithValue("@Stock_Max", Convert.ToInt32(max))
                    Catch ex As Exception
                        command.Parameters.AddWithValue("@Stock_Max", Convert.ToInt32(0))
                    End Try

                    Try
                        command.Parameters.AddWithValue("@Stock_Min", Convert.ToInt32(min))
                    Catch ex As Exception
                        command.Parameters.AddWithValue("@Stock_Min", Convert.ToInt32(0))
                    End Try

                    command.Parameters.AddWithValue("@Categoria", Convert.ToInt32(ca))
                    command.Parameters.AddWithValue("@Id", Convert.ToInt32(id))

                    ' Ejecutar la consulta
                    Dim filasAfectadas As Integer = command.ExecuteNonQuery()
                    Return filasAfectadas > 0
                End Using
            End Using
        Catch ex As SqlException
            If ex.Number = 547 Then
                ' Manejar el error de clave foránea no encontrada
                MessageBox.Show("La categoria no existe.")
            Else
                ' Manejar otros errores de SqlException
                MessageBox.Show($"Error de SQL: {ex.Message}")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error al actualizar el artículo: {ex.Message}")

            Return False
        End Try
    End Function

    Private Function comprobar(nom As String, de As String, pre As String, max As String, min As String, ca As String) As Boolean
        Dim x As Boolean = True

        If Not ValidarNombre(nom) Then
            x = False
        End If
        If Not ValidarDescripcion(de) Then
            x = False
        End If
        If Not ValidarPrecio(pre) Then
            x = False
        End If
        If Not ValidarStock(max) Then
            x = False
        End If
        If Not ValidarStock(min) Then
            x = False
        End If
        If Not ValidarCategoria(ca) Then
            x = False
        End If
        Return x
    End Function

    Private Function ValidarNombre(nombre As String) As Boolean
        Dim regex As New Regex("^.{1,100}$")
        Return regex.IsMatch(nombre)
    End Function
    Private Function ValidarDescripcion(descripcion As String) As Boolean
        Dim regex As New Regex("^.{0,100}$")
        Return regex.IsMatch(descripcion)
    End Function

    Private Function ValidarPrecio(precio As String) As Boolean
        Dim regex As New Regex("^\d{0,10}(\.\d{1,2})?$")
        Return regex.IsMatch(precio)
    End Function
    Private Function ValidarStock(stock As String) As Boolean
        Dim regex As New Regex("^\d{0,6}$")
        Return regex.IsMatch(stock)
    End Function
    Private Function ValidarCategoria(categoria As String) As Boolean
        Dim regex As New Regex("^\d{0,3}$")
        Return regex.IsMatch(categoria)
    End Function
End Class