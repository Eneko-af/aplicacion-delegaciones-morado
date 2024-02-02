Imports System.Data.SqlClient

Public Class FormAniadirTransportista
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        ActiveForm.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If TB_Nombre.Text = "" Or TB_Tlf.Text = "" Then
            MessageBox.Show("Uno o varios campos está vacío.")
        Else
            Dim nuevaInsercionQuery As String = "INSERT INTO TRANSPORTISTAS (ID_TRANSPORTISTA, EMPRESA, TELEFONO_CONTACTO_TRANSPORTISTA) " &
                                        "VALUES ('" & TB_ID.Text & "', '" & TB_Nombre.Text.ToUpper & "', '" & TB_Tlf.Text & "')"

            conexionInstert(nuevaInsercionQuery)
            MessageBox.Show("SE HA GUARDADO LA INFORMACIÓN")
            ActiveForm.Close()
        End If
    End Sub


    Public Shared Function conexionInstert(query As String)

        Dim stringConexion As SqlConnectionStringBuilder
        Dim conexion As SqlConnection

        stringConexion = New SqlConnectionStringBuilder()

        stringConexion.DataSource = "192.168.0.223"
        stringConexion.InitialCatalog = "EUSKOMITO"
        stringConexion.UserID = "sa"
        stringConexion.Password = "123456aA"

        conexion = New SqlConnection(stringConexion.ConnectionString)

        Try
            conexion.Open()
            Dim comando As New SqlCommand(query, conexion)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            conexion.Close()
        End Try

    End Function

End Class