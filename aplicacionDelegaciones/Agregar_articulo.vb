Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Agregar_articulo


    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

    Private Sub Agregar_articulo_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        ObtenerMaximo_Click()
        llenar_categoria()
    End Sub


    Private Sub llenar_categoria()
        Try
            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;"
            Dim queryString As String = "SELECT * FROM CATEGORIAS"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(queryString, connection)
                    connection.Open()

                    ' Utilizar un DataReader para obtener los nombres de las columnas
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            ' Agregar cada nombre de columna al ComboBox
                            CATEGORIA.Items.Add(reader("NOMBRE").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub ObtenerMaximo_Click()
        Try
            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;"
            Dim query As String = "SELECT MAX(ID_ARTICULO) FROM ARTICULOS"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()

                    If result IsNot DBNull.Value Then
                        Dim valorMaximo As Integer = Convert.ToInt32(result)
                        valorMaximo = valorMaximo + 1
                        id_articulo.Text = valorMaximo.ToString()
                    Else
                        id_articulo.Text = "No hay valores en la tabla"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        Dim nom As String = nombre.Text
        Dim id As String = id_articulo.Text
        Dim pre As String = precio.Text
        Dim max As String = stock_max.Text
        Dim min As String = stock_min.Text
        Dim cat As String = CATEGORIA.Text
        Dim des As String = descripcion.Text
        Dim cocat As String

        Dim x As Boolean = True

        If nom.Length > 0 And des.Length > 0 And pre.Length > 0 And max.Length > 0 And min.Length > 0 And cat.Length > 0 And des.Length > 0 Then
            x = True
            If Not ValidarNombre(nom) Then
                MessageBox.Show("El nombre excede la longitud máxima permitida (100 caracteres).")
                x = False
            End If
            If Not ValidarDescripcion(des) Then
                MessageBox.Show("La descripcion excede la longitud máxima permitida (100 caracteres).")
                x = False
            End If
            If Not ValidarPrecio(pre) Then
                MessageBox.Show("El precio excede la logitud máxima.")
                x = False
            End If

            If ValidarStock(max) And ValidarStock(min) Then
                If Integer.Parse(max) < Integer.Parse(min) Then
                    MessageBox.Show("El stock minimo no puede ser mayor al stock maximo")
                    x = False
                End If
            Else
                MessageBox.Show("Los stock excede la logitud máxima.")
                x = False
            End If

            If x Then
                cocat = obtenerIDCategoria(cat)
                If InsertarNuevoArticulo(id, nom, des, pre, max, min, cocat) Then
                    MessageBox.Show("Nuevo articulo insertado")
                    limpiarCampos()
                End If
            End If

        Else
            MessageBox.Show("Campos vacios!!")
        End If
    End Sub

    Private Sub limpiarCampos()
        nombre.Text = ""
        id_articulo.Text = ""
        descripcion.Text = ""
        precio.Text = ""
        stock_max.Text = ""
        stock_min.Text = ""
        CATEGORIA.Items.Clear()
        ObtenerMaximo_Click()
        llenar_categoria()
    End Sub

    Private Function InsertarNuevoArticulo(id As String, nom As String, des As String, pre As String, max As String, min As String, cat As String) As Boolean
        Try
            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;"
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim queryString As String = "INSERT INTO ARTICULOS (ID_ARTICULO, NOMBRE, DESCRIPCION, PRECIO, STOCK_MAX, STOCK_MIN, CATEGORIA_ID) VALUES (" + id + ",'" + nom + "', '" + des + "', " + pre + ", " + max + "," + min + ", " + cat + ")"
                Using command As New SqlCommand(queryString, connection)
                    ' Ejecutar la consulta
                    Dim filasAfectadas As Integer = command.ExecuteNonQuery()
                    Return filasAfectadas > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error al insertar el nuevo artículo: {ex.Message}")
            Return False
        End Try
    End Function
    Private Function obtenerIDCategoria(categoria As String)
        Try
            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;"
            Dim query As String = "SELECT ID_CATEGORIA FROM CATEGORIAs WHERE NOMBRE LIKE '" + categoria + "'"


            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()

                    If result IsNot DBNull.Value Then
                        Dim codigo As String = Convert.ToString(result)
                        Return codigo
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Function
    Private Function ValidarNombre(nombre As String) As Boolean
        Dim regex As New Regex("^.{1,100}$")
        Return regex.IsMatch(nombre)
    End Function
    Private Function ValidarDescripcion(descripcion As String) As Boolean
        Dim regex As New Regex("^.{1,100}$")
        Return regex.IsMatch(descripcion)
    End Function

    Private Function ValidarPrecio(precio As String) As Boolean
        Dim regex As New Regex("^\d{1,10}(\.\d{1,2})?$")
        Return regex.IsMatch(precio)
    End Function
    Private Function ValidarStock(stock As String) As Boolean
        Dim regex As New Regex("^\d{1,6}$")
        Return regex.IsMatch(stock)
    End Function
End Class