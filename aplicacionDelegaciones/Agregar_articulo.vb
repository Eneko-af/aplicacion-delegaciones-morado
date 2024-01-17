Imports System.Data.SqlClient

Public Class Agregar_articulo


    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

    Private Sub Agregar_articulo_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Try
            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=PRUEBA4;User ID=sa;Password=123456aA;"
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


End Class