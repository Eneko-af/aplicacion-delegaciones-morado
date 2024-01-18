Imports System.Data.SqlClient

Public Class Borrar
    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

    Private Sub Borrar_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        llenar_id()
    End Sub

    Private Sub llenar_id()


        Try
            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=PRUEBA4;User ID=sa;Password=123456aA;"
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
            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=PRUEBA4;User ID=sa;Password=123456aA;"
            Dim query As String = "SELECT Nombre FROM ARTICULOS where id_articulo = " + IDS.Text

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()

                    If result IsNot DBNull.Value Then
                        Dim valor As String = Convert.ToString(result)
                        nombre.Text = valor
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub



    Private Sub Actualizar()
        IDS.Items.Clear()
        nombre.Text = ""
        llenar_id()
    End Sub

    Private Function Delete(id As String) As Boolean
        Try
            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=PRUEBA4;User ID=sa;Password=123456aA;"
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim queryString As String = "DELETE FROM ARTICULOS WHERE ID_ARTICULO = " + id + ""
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

    Private Sub BorrarArticulo_Click_1(sender As Object, e As EventArgs) Handles BorrarArticulo.Click
        Dim cod As String = IDS.Text
        Dim mensaje As String = $"¿Está seguro de borrar el artículo con ID {cod}?"
        Dim resultado As DialogResult = MessageBox.Show(mensaje, "Confirmar Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = DialogResult.Yes Then
            ' Lógica para borrar el artículo de la base de datos
            If Delete(cod) Then
                Actualizar()
                MessageBox.Show("Artículo borrado con éxito.", "Borrado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Ocurrio un error")
            End If


        End If
    End Sub
End Class