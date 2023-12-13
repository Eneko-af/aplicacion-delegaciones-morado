Imports System.Data.SqlClient

Public Class CONSULTA_COMERCIALES
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.DataSource = establecerConexion()

    End Sub

    Public Shared Function establecerConexion()

        Dim stringConexion As SqlConnectionStringBuilder
        Dim conexion As SqlConnection

        Dim query As String = "SELECT * FROM COMERCIALES"

        stringConexion = New SqlConnectionStringBuilder()


        stringConexion.DataSource = "192.168.0.223"
        stringConexion.InitialCatalog = "PRUEBA4"
        stringConexion.UserID = "sa"
        stringConexion.Password = "123456aA"

        conexion = New SqlConnection(stringConexion.ConnectionString)

        Dim adapter As New SqlDataAdapter(query, stringConexion.ConnectionString)
        Dim dt As New DataTable()

        Try
            conexion.Open()
            adapter.Fill(dt)
            Return dt
        Catch ex As Exception
            Console.WriteLine("Error al establecer la conexión: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Function

End Class