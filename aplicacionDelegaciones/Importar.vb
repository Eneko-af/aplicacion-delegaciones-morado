Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Xml

Public Class Importar

    Private Sub Importar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        seleccionar()
        Me.Close()
    End Sub

    Private Sub seleccionar()
        Try
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Title = "Seleccionar archivo XML de artículos"
            openFileDialog.Filter = "Archivos XML (*.xml)|*.xml"
            openFileDialog.Multiselect = False ' Permitir seleccionar solo un archivo

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Se ha seleccionado un archivo
                Dim rutaArchivoXml As String = openFileDialog.FileName
                ' Aquí puedes llamar a un método para procesar el archivo XML seleccionado
                ImportarArticulos(rutaArchivoXml)
            Else
                MessageBox.Show("No se seleccionó ningún archivo.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error al importar los artículos: {ex.Message}")
        End Try
    End Sub
    Private Sub ImportarArticulos(ByVal archivo As String)
        Try
            Dim xmlDoc As New XmlDocument()
            xmlDoc.Load(archivo) ' Cambia por la ruta correcta del archivo XML

            Dim articulos As XmlNodeList = xmlDoc.SelectNodes("/Articulos/Articulo")

            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;"

            ' Crear la conexión
            Dim connection As New SqlConnection(connectionString)
            connection.Open()

            For Each articulo As XmlNode In articulos
                Dim idNode As XmlNode = articulo.SelectSingleNode("ID_ARTICULO")
                Dim nombreNode As XmlNode = articulo.SelectSingleNode("NOMBRE")
                Dim descripcionNode As XmlNode = articulo.SelectSingleNode("DESCRIPCION")
                Dim precioNode As XmlNode = articulo.SelectSingleNode("PRECIO")
                Dim stockMaxNode As XmlNode = articulo.SelectSingleNode("STOCK_MAX")
                Dim stockMinNode As XmlNode = articulo.SelectSingleNode("STOCK_MIN")
                Dim categoriaIdNode As XmlNode = articulo.SelectSingleNode("CATEGORIA_ID")

                ' Verificar si alguna etiqueta esperada no se encuentra
                If idNode Is Nothing OrElse nombreNode Is Nothing OrElse descripcionNode Is Nothing OrElse precioNode Is Nothing _
                OrElse stockMaxNode Is Nothing OrElse stockMinNode Is Nothing OrElse categoriaIdNode Is Nothing Then
                    MessageBox.Show("El formato del archivo XML es incorrecto. Alguna de las etiquetas esperadas no se encontró.")
                    Return
                End If

                Dim id As Integer = Convert.ToInt32(idNode.InnerText)
                Dim nombre As String = nombreNode.InnerText
                Dim descripcion As String = descripcionNode.InnerText
                Dim precio As Decimal = Convert.ToDecimal(precioNode.InnerText)
                Dim stockMax As Integer = Convert.ToInt32(stockMaxNode.InnerText)
                Dim stockMin As Integer = Convert.ToInt32(stockMinNode.InnerText)
                Dim categoriaId As Integer = Convert.ToInt32(categoriaIdNode.InnerText)

                ' Consultar si el artículo ya existe en la base de datos
                Dim query As String = "SELECT COUNT(*) FROM ARTICULOS WHERE ID_ARTICULO = @Id"
                Dim cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Id", id)

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If count > 0 Then
                    ' Si el artículo existe, actualizarlo
                    query = "UPDATE ARTICULOS SET NOMBRE = @Nombre, DESCRIPCION = @Descripcion, PRECIO = @Precio, STOCK_MAX = @StockMax, STOCK_MIN = @StockMin, CATEGORIA_ID = @CategoriaId WHERE ID_ARTICULO = @Id"
                Else
                    ' Si el artículo no existe, insertarlo
                    query = "INSERT INTO ARTICULOS (ID_ARTICULO, NOMBRE, DESCRIPCION, PRECIO, STOCK_MAX, STOCK_MIN, CATEGORIA_ID) VALUES (@Id, @Nombre, @Descripcion, @Precio, @StockMax, @StockMin, @CategoriaId)"
                End If

                ' Ejecutar la consulta SQL
                cmd = New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Id", id)
                cmd.Parameters.AddWithValue("@Nombre", nombre)
                cmd.Parameters.AddWithValue("@Descripcion", descripcion)
                cmd.Parameters.AddWithValue("@Precio", precio)
                cmd.Parameters.AddWithValue("@StockMax", stockMax)
                cmd.Parameters.AddWithValue("@StockMin", stockMin)
                cmd.Parameters.AddWithValue("@CategoriaId", categoriaId)

                cmd.ExecuteNonQuery()
            Next
        Catch ex As FormatException
            MessageBox.Show("Datos del xml incompatibles ¡Revisar!")
        Catch ex As Exception
            MessageBox.Show($"Error al importar los artículos: {ex.Message}")
        End Try
    End Sub







End Class