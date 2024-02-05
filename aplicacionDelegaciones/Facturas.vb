Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Microsoft.VisualBasic.ApplicationServices
Imports stdole
Public Class Facturas
    Private Sub Facturas_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        filtro.Items.Clear()
        ComboBox1.Items.Clear()
        Try
            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;"

            Dim queryString As String = "select *
                                        from FACTURAS"
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(queryString, connection)
                    ' Abrir la conexión
                    connection.Open()

                    ' Crear un adaptador de datos para recuperar los datos
                    Using adapter As New SqlDataAdapter(command)
                        ' Crear un DataTable para almacenar los datos
                        Dim dataTable As New DataTable()

                        ' Llenar el DataTable con los datos del adaptador
                        adapter.Fill(dataTable)

                        ' Enlazar el DataGridView al DataTable para mostrar los datos
                        DataGridView1.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try

        Try
            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;"
            Dim queryString As String = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'PARTNERS'"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(queryString, connection)
                    connection.Open()

                    ' Utilizar un DataReader para obtener los nombres de las columnas
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            ' Agregar cada nombre de columna al ComboBox
                            filtro.Items.Add(reader("COLUMN_NAME").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try


        Try
            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;"
            Dim queryString As String = "SELECT ID_PARTNER FROM PARTNERS"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(queryString, connection)
                    connection.Open()

                    ' Utilizar un DataReader para obtener los nombres de las columnas
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            ' Agregar cada nombre de columna al ComboBox
                            ComboBox1.Items.Add(reader("ID_PARTNER").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fil As String
        Dim con As String

        fil = filtro.Text.Trim.ToUpper
        con = consulta.Text.Trim.ToUpper


        If fil.Length > 0 And con.Length > 0 Then
            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;"

            If fil = "ID_FACTURA" Then
                Consultas("ID_FACTURA", con)
            ElseIf fil = "FECHA_EMISION" Then
                Consultas("FECHA_EMISION", con)
            ElseIf fil = "ALBARAN_ID" Then
                Consultas("ALBARAN_ID", con)
            ElseIf fil = "TOTAL_FACTURA" Then
                Consultas("TOTAL_FACTURA", con)
            ElseIf fil = "ESTADO_PAGO" Then
                Consultas("ESTADO_PAGO", con)
            ElseIf fil = "FECHA_PAGO" Then
                Consultas("FECHA_PAGO", con)
            ElseIf fil = "METODO_PAGO" Then
                Consultas("METODO_PAGO", con)
            End If





            consulta.Text = ""
        Else
            MessageBox.Show("Campos de filtrado vacio")

        End If
    End Sub
    Sub Consultas(ByVal fila As String, ByVal clave As String)

        Try
            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;"

            Dim queryString As String = "select *
                                        from FACTURAS
                                         Where upper(" + fila + ") LIKE '%" + clave + "%' COLLATE Latin1_General_CI_AI"
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(queryString, connection)
                    ' Abrir la conexión
                    connection.Open()

                    ' Crear un adaptador de datos para recuperar los datos
                    Using adapter As New SqlDataAdapter(command)
                        ' Crear un DataTable para almacenar los datos
                        Dim dataTable As New DataTable()

                        ' Llenar el DataTable con los datos del adaptador
                        adapter.Fill(dataTable)

                        ' Enlazar el DataGridView al DataTable para mostrar los datos
                        DataGridView1.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;"
            Dim query As String = "SELECT Nombre FROM PARTNERS where id_PARTNER = " + ComboBox1.Text

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()

                    If result IsNot DBNull.Value Then
                        Dim valor As String = Convert.ToString(result)
                        TextBox1.Text = valor
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text.Length > 0 Then
            Try
                Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;"

                Dim queryString As String = "SELECT * FROM FACTURAS WHERE ALBARAN_ID IN (SELECT ALBARAN_ID FROM ALBARANES WHERE PARTNER_ID = @PARTNER_ID)"

                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(queryString, connection)
                        ' Agregar el parámetro @PARTNER_ID
                        command.Parameters.AddWithValue("@PARTNER_ID", ComboBox1.Text)

                        ' Abrir la conexión
                        connection.Open()

                        ' Crear un adaptador de datos para recuperar los datos
                        Using adapter As New SqlDataAdapter(command)
                            ' Crear un DataTable para almacenar los datos
                            Dim dataTable As New DataTable()

                            ' Llenar el DataTable con los datos del adaptador
                            adapter.Fill(dataTable)

                            ' Enlazar el DataGridView al DataTable para mostrar los datos
                            DataGridView1.DataSource = dataTable
                        End Using
                    End Using
                End Using

                PDF.Visible = True
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}")
            End Try
        Else
            MessageBox.Show("Campos vacios")
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles PDF.Click
        GenerarFacturasPDF(ComboBox1.Text)
        PDF.Visible = False
    End Sub
    Public Sub GenerarFacturasPDF(ByVal idPartner As Integer)
        Try
            ' Obtener los datos del partner desde la base de datos
            Dim datosPartner As String = ObtenerDatosPartner(idPartner)

            ' Crear un nuevo documento PDF
            Dim doc As New Document()
            PdfWriter.GetInstance(doc, New FileStream("Facturas.pdf", FileMode.Create))
            doc.Open()

            ' Configurar la fuente
            Dim fontTitle As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD)
            Dim fontSubtitle As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.NORMAL)
            Dim fontBody As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL)

            ' Agregar título de la factura
            Dim tituloFactura As New Paragraph("FACTURA", fontTitle)
            tituloFactura.Alignment = Element.ALIGN_CENTER
            tituloFactura.SpacingAfter = 20
            doc.Add(tituloFactura)

            ' Obtener las facturas del partner seleccionado desde la base de datos
            Dim dtFacturas As DataTable = ObtenerFacturasPorPartner(idPartner)

            ' Recorrer cada factura
            For Each factura As DataRow In dtFacturas.Rows
                ' Agregar cabecera de la factura
                Dim cabeceraFactura As New Paragraph()
                cabeceraFactura.Alignment = Element.ALIGN_RIGHT
                cabeceraFactura.Font = fontSubtitle
                cabeceraFactura.Add($"ID Factura: {factura("ID_FACTURA")} | Fecha de Emisión: {factura("FECHA_EMISION")} | Total de Factura: {factura("TOTAL_FACTURA")} | Estado de Pago: {factura("ESTADO_PAGO")}")
                cabeceraFactura.SpacingAfter = 10
                doc.Add(cabeceraFactura)

                ' Crear tabla para mostrar los detalles de la factura
                Dim tablaFactura As New PdfPTable(2)
                tablaFactura.WidthPercentage = 100
                tablaFactura.SpacingBefore = 10
                tablaFactura.SetWidths({1, 3})

                ' Agregar detalles de la factura a la tabla
                AgregarCeldaTabla(tablaFactura, "Nombre del Cliente:", ObtenerNombreCliente(idPartner))
                AgregarCeldaTabla(tablaFactura, "Dirección del Cliente:", ObtenerDireccionCliente(idPartner))
                AgregarCeldaTabla(tablaFactura, "ID Factura:", factura("ID_FACTURA").ToString)
                AgregarCeldaTabla(tablaFactura, "Fecha de Emisión:", factura("FECHA_EMISION").ToString)
                AgregarCeldaTabla(tablaFactura, "Total de Factura:", factura("TOTAL_FACTURA").ToString)
                AgregarCeldaTabla(tablaFactura, "Estado de Pago:", factura("ESTADO_PAGO").ToString)

                ' Agregar la tabla de detalles de la factura al documento
                doc.Add(tablaFactura)

                ' Obtener las líneas de pedido asociadas a la factura desde la base de datos
                Dim dtLineasPedidos As DataTable = ObtenerLineasPorAlbaran(factura("ID_FACTURA"))

                ' Crear tabla para mostrar las líneas de los artículos
                Dim tablaLineas As New PdfPTable(4)
                tablaLineas.WidthPercentage = 100
                tablaLineas.SpacingBefore = 10
                tablaLineas.SetWidths({1, 2, 1, 1})

                ' Agregar encabezados de la tabla
                Dim encabezados As String() = {"ID Línea", "Nombre Artículo", "Cantidad", "Precio Unitario"}
                For Each encabezado As String In encabezados
                    Dim celdaEncabezado As New PdfPCell(New Phrase(encabezado, fontSubtitle))
                    celdaEncabezado.BackgroundColor = BaseColor.LIGHT_GRAY
                    tablaLineas.AddCell(celdaEncabezado)
                Next

                ' Agregar detalles de las líneas de los artículos a la tabla
                For Each linea As DataRow In dtLineasPedidos.Rows
                    AgregarCeldaTabla(tablaLineas, linea("ID_LINEA").ToString, linea("NOMBRE_ARTICULO").ToString)
                    AgregarCeldaTabla(tablaLineas, linea("CANTIDAD").ToString, linea("PRECIO_UNITARIO").ToString)
                    AgregarCeldaTabla(tablaLineas, linea("PRECIO_UNITARIO").ToString, (linea("CANTIDAD") * linea("PRECIO_UNITARIO")).ToString)
                Next

                ' Agregar la tabla de líneas de los artículos al documento
                doc.Add(tablaLineas)
            Next

            ' Cerrar el documento
            doc.Close()

            ' Mostrar mensaje de éxito
            MessageBox.Show("Facturas guardadas en Facturas.pdf")
        Catch ex As Exception
            MessageBox.Show($"Error al generar el PDF: {ex.Message}")
        End Try
    End Sub




    Private Function ObtenerDireccionCliente(idPartner As Integer) As String
        Dim direccionCliente As String = String.Empty
        Try
            ' Aquí debes agregar la lógica para acceder a tu base de datos y obtener la dirección del cliente
            ' Debes reemplazar "ObtenerDireccionClienteDesdeBaseDeDatos" con tu lógica real para obtener la dirección del cliente.
            ' Por ejemplo, si estás usando SQL y ADO.NET, esto podría ser un SqlCommand que ejecuta una consulta SQL.
            Using connection As New SqlConnection("Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;")
                connection.Open()
                Dim query As String = "SELECT DIRECCION FROM partners WHERE ID_PARTNER = @ID_PARTNER"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ID_PARTNER", idPartner)
                    direccionCliente = Convert.ToString(command.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            ' Manejo de excepciones, por ejemplo:
            Console.WriteLine("Error al obtener la dirección del cliente: " & ex.Message)
        End Try
        Return direccionCliente
    End Function



    ' Método para obtener la descripción de un producto a partir de su ID
    Private Function ObtenerDescripcionProducto(idProducto As Integer) As String
        Dim descripcionProducto As String = String.Empty
        Try

            Using connection As New SqlConnection("Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;")
                connection.Open()
                Dim query As String = "SELECT DESCRIPCION FROM Articulos WHERE ID_ARTICULO = @ID_ARTICULO"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ID_ARTICULO", idProducto)
                    descripcionProducto = Convert.ToString(command.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            ' Manejo de excepciones, por ejemplo:
            Console.WriteLine("Error al obtener la descripción del producto: " & ex.Message)
        End Try
        Return descripcionProducto
    End Function

    ' Método para obtener los detalles de una factura a partir de su ID
    Private Function ObtenerDetallesFactura(idFactura As Integer) As DataTable
        Dim dtDetalles As New DataTable()
        Try
            Using connection As New SqlConnection("Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;")
                connection.Open()
                Dim query As String = "SELECT LP.*, A.NOMBRE AS NOMBRE_ARTICULO, A.DESCRIPCION AS DESCRIPCION_ARTICULO " &
                                  "FROM LineaPedidos LP " &
                                  "INNER JOIN Articulos A ON LP.ARTICULO_ID = A.ID_ARTICULO " &
                                  "WHERE LP.ALBARAN_ID = @ID_FACTURA"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ID_FACTURA", idFactura)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(dtDetalles)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Manejo de excepciones, por ejemplo:
            Console.WriteLine("Error al obtener los detalles de la factura: " & ex.Message)
        End Try
        Return dtDetalles
    End Function
    Private Sub AgregarCeldaTabla(ByRef tabla As PdfPTable, ByVal dato1 As String, ByVal dato2 As String)
        Dim celda1 As New PdfPCell(New Phrase(dato1))
        Dim celda2 As New PdfPCell(New Phrase(dato2))
        tabla.AddCell(celda1)
        tabla.AddCell(celda2)
    End Sub

    Private Function ObtenerAlbaranesPorFactura(ByVal idFactura As Integer) As DataTable
        Dim dtAlbaranes As New DataTable()

        ' Tu cadena de conexión a la base de datos
        Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;"

        ' Consulta SQL para obtener los albaranes asociados a la factura
        Dim query As String = "SELECT * FROM Albaranes WHERE ID_ALBARAN = (SELECT ALBARAN_ID FROM Facturas WHERE ID_FACTURA = @ID_FACTURA)"

        Try
            ' Crear la conexión a la base de datos
            Using connection As New SqlConnection(connectionString)
                ' Abrir la conexión
                connection.Open()

                ' Crear el comando SQL
                Using command As New SqlCommand(query, connection)
                    ' Establecer el parámetro ID_FACTURA
                    command.Parameters.AddWithValue("@ID_FACTURA", idFactura)

                    ' Crear el adaptador de datos
                    Dim adapter As New SqlDataAdapter(command)

                    ' Llenar el DataTable con los resultados de la consulta
                    adapter.Fill(dtAlbaranes)
                End Using
            End Using
        Catch ex As Exception
            ' Manejar la excepción, si es necesario
            MessageBox.Show($"Error al obtener los albaranes de la factura: {ex.Message}")
        End Try

        ' Devolver el DataTable con los albaranes asociados a la factura
        Return dtAlbaranes
    End Function
    Public Function ObtenerNombreCliente(idPartner As Integer) As String
        Dim nombreCliente As String = String.Empty
        Try
            ' Aquí asumimos que tienes una conexión a tu base de datos llamada "connection" y un comando SQL para obtener el nombre del cliente
            Using connection As New SqlConnection("Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;")
                connection.Open()
                Dim query As String = "SELECT NOMBRE FROM partners WHERE ID_PARTNER = @ID_PARTNER"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ID_PARTNER", idPartner)
                    nombreCliente = Convert.ToString(command.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            ' Manejo de excepciones, por ejemplo:
            Console.WriteLine("Error al obtener el nombre del cliente: " & ex.Message)
        End Try

        Return nombreCliente
    End Function
    Private Function ObtenerLineasPorAlbaran(ByVal idAlbaran As Integer) As DataTable
        Dim dtLineasPedidos As New DataTable()

        ' Tu cadena de conexión a la base de datos
        Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;"

        ' Consulta SQL para obtener las líneas de pedido del albarán seleccionado con la información del artículo asociado
        Dim query As String = "SELECT LP.*, A.NOMBRE AS NOMBRE_ARTICULO, A.DESCRIPCION AS DESCRIPCION_ARTICULO " &
                      "FROM linea_pedido LP " &
                      "INNER JOIN Articulos A ON LP.ARTICULO_ID = A.ID_ARTICULO " &
                      "WHERE LP.ALBARAN_ID = @ID_ALBARAN"

        Try
            ' Crear la conexión a la base de datos
            Using connection As New SqlConnection(connectionString)
                ' Abrir la conexión
                connection.Open()

                ' Crear el comando SQL
                Using command As New SqlCommand(query, connection)
                    ' Establecer el parámetro ID_ALBARAN
                    command.Parameters.AddWithValue("@ID_ALBARAN", idAlbaran)

                    ' Crear el adaptador de datos
                    Dim adapter As New SqlDataAdapter(command)

                    ' Llenar el DataTable con los resultados de la consulta
                    adapter.Fill(dtLineasPedidos)

                    ' Verificar si el DataTable está vacío
                    If dtLineasPedidos.Rows.Count = 0 Then
                        ' Si no se encontraron líneas de pedido, mostrar un mensaje informativo
                        MessageBox.Show("No se encontraron líneas de pedido para el albarán especificado.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Manejar la excepción, si es necesario
            MessageBox.Show($"Error al obtener las líneas de pedido del albarán: {ex.Message}")
        End Try

        ' Devolver el DataTable con las líneas de pedido del albarán
        Return dtLineasPedidos
    End Function
    Private Function ObtenerAlbaranesPorPartner(ByVal idPartner As Integer) As DataTable
        Dim dtAlbaranes As New DataTable()

        ' Tu cadena de conexión a la base de datos
        Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;"

        ' Consulta SQL para obtener los albaranes del partner seleccionado
        Dim query As String = "SELECT * FROM Albaranes WHERE PARTNER_ID = @ID_PARTNER"

        Try
            ' Crear la conexión a la base de datos
            Using connection As New SqlConnection(connectionString)
                ' Abrir la conexión
                connection.Open()

                ' Crear el comando SQL
                Using command As New SqlCommand(query, connection)
                    ' Establecer el parámetro ID_PARTNER
                    command.Parameters.AddWithValue("@ID_PARTNER", idPartner)

                    ' Crear el adaptador de datos
                    Dim adapter As New SqlDataAdapter(command)

                    ' Llenar el DataTable con los resultados de la consulta
                    adapter.Fill(dtAlbaranes)
                End Using
            End Using
        Catch ex As Exception
            ' Manejar la excepción, si es necesario
            MessageBox.Show($"Error al obtener los albaranes del partner: {ex.Message}")
        End Try

        ' Devolver el DataTable con los albaranes del partner
        Return dtAlbaranes
    End Function
    Public Function ObtenerDatosPartner(ByVal idPartner As Integer) As String
        Dim datosPartner As New StringBuilder()

        Try
            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;"
            Dim query As String = "SELECT NOMBRE, DIRECCION, CIUDAD, CODIGO_POSTAL, TELEFONO, EMAIL, TIPO, FECHA_REGISTRO " &
                                  "FROM partners " &
                                  "WHERE ID_PARTNER = @ID_PARTNER"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ID_PARTNER", idPartner)
                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            datosPartner.AppendLine($"Nombre: {reader("NOMBRE")}")
                            datosPartner.AppendLine($"Dirección: {reader("DIRECCION")}")
                            datosPartner.AppendLine($"Ciudad: {reader("CIUDAD")}")
                            datosPartner.AppendLine($"Código Postal: {reader("CODIGO_POSTAL")}")
                            datosPartner.AppendLine($"Teléfono: {reader("TELEFONO")}")
                            datosPartner.AppendLine($"Email: {reader("EMAIL")}")
                            datosPartner.AppendLine($"Tipo: {reader("TIPO")}")
                            datosPartner.AppendLine($"Fecha de Registro: {reader("FECHA_REGISTRO")}")
                        Else
                            MessageBox.Show("No se encontraron datos para el partner.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error al obtener los datos del partner: {ex.Message}")
        End Try

        Return datosPartner.ToString()
    End Function


    Private Function ObtenerFacturasPorPartner(idPartner As Integer) As DataTable
        Dim dtFacturas As New DataTable()
        Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;"
        Dim query As String = "SELECT * FROM facturas WHERE ALBARAN_ID IN (SELECT ID_ALBARAN FROM albaranes WHERE PARTNER_ID = @ID_PARTNER)"

        Try
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ID_PARTNER", idPartner)
                    connection.Open()
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(dtFacturas)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error2 al obtener las facturas: " & ex.Message)
            consulta.Text = ex.Message
        End Try

        Return dtFacturas
    End Function




End Class