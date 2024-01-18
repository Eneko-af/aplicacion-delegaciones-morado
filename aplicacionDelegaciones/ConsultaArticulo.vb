Imports System.Data.SqlClient

Public Class ConsultaArticulo

    Private Sub ConsultaArticulo_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        filtro.Items.Clear()
        Try
            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=PRUEBA4;User ID=sa;Password=123456aA;"

            Dim queryString As String = "select ID_ARTICULO,NOMBRE,DESCRIPCION,PRECIO,STOCK_MAX,STOCK_MIN,CATEGORIA_ID
                                        from ARTICULOS"
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
            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=PRUEBA4;User ID=sa;Password=123456aA;"
            Dim queryString As String = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'ARTICULOS'"

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
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fil As String
        Dim con As String

        fil = filtro.Text.Trim.ToUpper
        con = consulta.Text.Trim.ToUpper


        If fil.Length > 0 And con.Length > 0 Then
            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=PRUEBA4;User ID=sa;Password=123456aA;"

            If fil = "ID_ARTICULO" Then
                Consultas("ID_ARTICULO", con)
            ElseIf fil = "NOMBRE" Then
                Consultas("NOMBRE", con)
            ElseIf fil = "DESCRIPCION" Then
                Consultas("DESCRIPCION", con)
            ElseIf fil = "PRECIO" Then
                Consultas("PRECIO", con)
            ElseIf fil = "STOCK_MAX" Then
                Consultas("STOCK_MAX", con)
            ElseIf fil = "STOCK_MIN" Then
                Consultas("STOCK_MIN", con)
            ElseIf fil = "CATEGORIA_ID" Then
                Consultas("CATEGORIA_ID", con)
            End If





            consulta.Text = ""
        Else
            MessageBox.Show("Campos de filtrado vacio")

        End If
    End Sub

    Sub Consultas(ByVal fila As String, ByVal clave As String)
        Try
            Dim connectionString As String = "Data Source=192.168.0.223;Initial Catalog=PRUEBA4;User ID=sa;Password=123456aA;"

            Dim queryString As String = "select ID_ARTICULO,NOMBRE,DESCRIPCION,PRECIO,STOCK_MAX,STOCK_MIN,CATEGORIA_ID
                                        from ARTICULOS 
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

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        Dim formAgregarArticulo As New Agregar_articulo()
        formAgregarArticulo.ShowDialog()
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        Dim formBorrar As New Borrar()
        formBorrar.ShowDialog()
    End Sub
End Class
