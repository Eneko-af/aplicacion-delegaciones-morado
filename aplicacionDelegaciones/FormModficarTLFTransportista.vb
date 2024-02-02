Imports System.Data.SqlClient

Public Class FormModficarTLFTransportista
    Private Sub btnSALIR_Click(sender As Object, e As EventArgs) Handles btnSALIR.Click
        ActiveForm.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim queryInstert As String
        Try
            If TB_TlfNuevo.Text = "" Then
                MessageBox.Show("DEBE RELLENAR DEL TELEFONO NUEVO SI DESEA GUARDAR")
            Else
                queryInstert = "
                UPDATE TRANSPORTISTAS SET
                    TELEFONO_CONTACTO_TRANSPORTISTA = '" & TB_TlfNuevo.Text & "'
                WHERE 
                    ID_TRANSPORTISTA = '" & TB_ID.Text & "'"

                MessageBox.Show("TELEFONO ACTUALIZADO EXITOSAMENTE")
                ActiveForm.Close()
            End If
            conexionInstert(queryInstert)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try



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