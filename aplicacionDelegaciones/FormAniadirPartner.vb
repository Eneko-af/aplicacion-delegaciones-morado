Imports System.Data.SqlClient

Public Class FormAniadirPartner
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        ActiveForm.Close()
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

    Public Shared Function establecerConexion(query As String)

        Dim stringConexion As SqlConnectionStringBuilder
        Dim conexion As SqlConnection

        stringConexion = New SqlConnectionStringBuilder()


        stringConexion.DataSource = "192.168.0.223"
        stringConexion.InitialCatalog = "EUSKOMITO"
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If TB_Nombre.Text = "" Or TB_CodPostal.Text = "" Or TB_MaIl.Text = "" Or TB_Tlf.Text = "" Or TB_TipoPartner.Text = "" Or TB_Direccion.Text = "" Or TB_Ciudad.Text = "" Then
            MessageBox.Show("Uno o varios campos está vacío.")
        Else
            Dim nuevaInsercionQuery As String = "INSERT INTO PARTNERS (ID_PARTNER, NOMBRE, DIRECCION, CIUDAD, CODIGO_POSTAL, TELEFONO, EMAIL, TIPO, FECHA_REGISTRO) " &
                                        "VALUES ('" & TB_ID.Text & "', '" & TB_Nombre.Text.ToUpper & "', '" & TB_Direccion.Text.ToUpper & "', '" & TB_Ciudad.Text.ToUpper & "', '" & TB_CodPostal.Text.ToUpper & "', '" & TB_Tlf.Text.ToUpper & "', '" & TB_MaIl.Text.ToUpper & "', '" & TB_TipoPartner.Text.ToUpper & "', '" & TB_FechaRegistro.Text & "')"

            conexionInstert(nuevaInsercionQuery)
            MessageBox.Show("SE HA GUARDADO LA INFORMACIÓN")
            ActiveForm.Close()
        End If
    End Sub

End Class