Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Xml
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.Office.Interop

Public Class Exportar

    Private Sub Exportar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Archivo()
        CopiarArchivoXML()
        EnviarCorreo()
        Me.Close()

    End Sub


    Private Sub EscribirElementoXml(writer As XmlWriter, nombreElemento As String, valor As String)
        ' Método auxiliar para escribir un elemento XML con un nombre y valor específicos
        writer.WriteStartElement(nombreElemento)
        writer.WriteString(valor)
        writer.WriteEndElement()
    End Sub


    Private Function RutaArchivoXml() As String
        ' Define la ruta del archivo XML
        Return "articulos.xml"
    End Function
    Private Sub ComprobarYCrearArchivoXml()
        Dim rutaArchivo As String = RutaArchivoXml()

        If Not File.Exists(rutaArchivo) Then
            ' Si el archivo no existe, crea uno nuevo
            CrearArchivoXml()
        End If
    End Sub

    Private Sub CrearArchivoXml()
        Try
            Dim rutaArchivo As String = RutaArchivoXml()

            ' Crear un objeto XmlWriterSettings para controlar el formato del archivo XML
            Dim settings As New XmlWriterSettings()
            settings.Indent = True
            settings.NewLineChars = Environment.NewLine

            ' Crear un objeto XmlWriter y escribir el encabezado del documento
            Using writer As XmlWriter = XmlWriter.Create(rutaArchivo, settings)
                writer.WriteStartDocument()

                ' Escribir el elemento raíz
                writer.WriteStartElement("Articulos")

                ' Finalizar el elemento raíz y el documento
                writer.WriteEndElement()
                writer.WriteEndDocument()
            End Using

            MessageBox.Show("Archivo XML creado correctamente.")
        Catch ex As Exception
            MessageBox.Show($"Error al crear el archivo XML: {ex.Message}")
        End Try
    End Sub


    Private Sub Archivo()
        Try
            ComprobarYCrearArchivoXml()

            Dim rutaArchivo As String = RutaArchivoXml()

            ' Crear un objeto XmlWriterSettings para controlar el formato del archivo XML
            Dim settings As New XmlWriterSettings()
            settings.Indent = True
            settings.NewLineChars = Environment.NewLine

            ' Crear un objeto XmlWriter y escribir el encabezado del documento
            Using writer As XmlWriter = XmlWriter.Create(rutaArchivo, settings)
                writer.WriteStartDocument()

                ' Escribir el elemento raíz
                writer.WriteStartElement("Articulos")

                ' Consultar la base de datos y obtener los datos de los artículos
                Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=EUSKOMITO;User ID=sa;Password=123456aA;"
                Dim query As String = "SELECT * FROM ARTICULOS"

                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    Using command As New SqlCommand(query, connection)
                        Using reader As SqlDataReader = command.ExecuteReader()
                            While reader.Read()
                                ' Para cada artículo, escribir un elemento "Articulo" con sus datos
                                writer.WriteStartElement("Articulo")

                                ' Añadir elementos con los datos del artículo
                                EscribirElementoXml(writer, "ID_ARTICULO", reader("ID_ARTICULO").ToString())
                                EscribirElementoXml(writer, "NOMBRE", reader("NOMBRE").ToString())
                                EscribirElementoXml(writer, "DESCRIPCION", reader("DESCRIPCION").ToString())
                                EscribirElementoXml(writer, "PRECIO", reader("PRECIO").ToString())
                                EscribirElementoXml(writer, "STOCK_MAX", reader("STOCK_MAX").ToString())
                                EscribirElementoXml(writer, "STOCK_MIN", reader("STOCK_MIN").ToString())
                                EscribirElementoXml(writer, "CATEGORIA_ID", reader("CATEGORIA_ID").ToString())

                                writer.WriteEndElement()
                            End While
                        End Using
                    End Using
                End Using

                ' Finalizar el elemento raíz y el documento
                writer.WriteEndElement()
                writer.WriteEndDocument()
            End Using


        Catch ex As Exception
            MessageBox.Show($"Error al exportar los datos a XML: {ex.Message}")
        End Try
    End Sub


    Private Sub EnviarCorreo()
        Try
            ' Dirección de correo electrónico del destinatario
            Dim correoDestinatario As String = "moradocebanc@gmail.com"

            ' Asunto del correo electrónico
            Dim asunto As String = "Archivo xml de articulos"

            ' Cuerpo del correo electrónico
            Dim cuerpo As String = "Actualizacion"

            ' Ruta del archivo adjunto (reemplaza esto con la ruta correcta de tu archivo Articulos.xml)
            Dim rutaArchivoAdjunto As String = "articulos.xml"

            ' Verificar si el archivo existe antes de adjuntarlo
            If File.Exists(rutaArchivoAdjunto) Then
                ' Construir el enlace para el correo electrónico con el archivo adjunto
                Dim mailtoLink As String = $"mailto:{correoDestinatario}?subject={Uri.EscapeDataString(asunto)}&body={Uri.EscapeDataString(cuerpo)}&attach={Uri.EscapeDataString(rutaArchivoAdjunto)}"

                ' Abrir el cliente de correo electrónico predeterminado con el enlace mailto
                Process.Start(mailtoLink)
            Else
                MessageBox.Show("El archivo Articulos.xml no existe en la ubicación especificada.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error al enviar el correo electrónico: {ex.Message}")
        End Try
    End Sub

    Private Sub CopiarArchivoXML()
        Try
            ' Ruta del archivo XML original
            Dim rutaArchivoOriginal As String = "articulos.xml"

            ' Ruta de destino (carpeta de descargas del usuario)
            Dim carpetaDescargas As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

            ' Nombre del archivo de destino
            Dim nombreArchivoDestino As String = "articulos_copia.xml"

            ' Ruta completa del archivo de destino
            Dim rutaArchivoDestino As String = Path.Combine(carpetaDescargas, nombreArchivoDestino)

            ' Copiar el archivo XML a la carpeta de descargas
            File.Copy(rutaArchivoOriginal, rutaArchivoDestino, True)
            MessageBox.Show("El catalogo ha sido copiado en el escritorio")
        Catch ex As Exception
            MessageBox.Show($"Error al copiar el archivo XML: {ex.Message}")
        End Try
    End Sub




End Class