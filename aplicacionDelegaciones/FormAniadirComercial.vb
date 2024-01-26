Imports System.Data.SqlClient

Public Class FormAniadirComercial
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ActiveForm.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim activo As Boolean = True

        If TB_Nombre.Text = "" Or TB_Apellido1.Text = "" Or TB_Apellido2.Text = "" Or TB_DNI.Text = "" Or TB_Mail.Text = "" Or TB_Tlf.Text = "" Or TB_Direccion.Text = "" Or TB_FechaContratacion.Text = "" Then
            MessageBox.Show("Uno o varios campos está vacío.")
        ElseIf Not validarFecha(TB_FechaContratacion.Text) Then
            MessageBox.Show("La fecha de contratación no está en el formato correcto (dd/MM/yyyy).")
        Else
            Dim nuevaInsercionQuery As String = "INSERT INTO COMERCIALES (ID_COMERCIAL, NOMBRE, APELLIDO_UNO, APELLIDO_DOS, NIE, EMAIL, TELEFONO, DIRECCION, FECHA_CONTRATACION, ZONA_PRINCIPAL, ZONA_ADICIONAL, ACTIVO) " &
                                    "VALUES ('" & TB_ID.Text & "', '" & TB_Nombre.Text.ToUpper & "', '" & TB_Apellido1.Text.ToUpper & "', '" & TB_Apellido2.Text.ToUpper & "', '" & TB_DNI.Text.ToUpper & "', '" & TB_Mail.Text.ToUpper & "', '" & TB_Tlf.Text.ToUpper & "', '" & TB_Direccion.Text.ToUpper & "', '" & TB_FechaContratacion.Text & "', '" & obtenerIDZona(cbZONA1.SelectedItem.ToString) & "', '" & obtenerIDZona(cbZONA2.SelectedItem.ToString) & "', '" & activo & "')"

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
        stringConexion.InitialCatalog = "PRUEBA4"
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

    Private Function validarFecha(dateString As String) As Boolean
        Dim parsedDate As DateTime
        Return DateTime.TryParseExact(dateString, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, parsedDate)
    End Function

    Private Function obtenerIDZona(descripcionZona As String) As String
        Dim dt As New DataTable
        Dim idZona As Integer
        Dim query As String = "Select ID_ZONA FROM ZONAS
                                WHERE DESCRIPCION_ZONA = '" & descripcionZona & "'"

        dt = establecerConexion(query)

        idZona = dt.Rows(0)("ID_ZONA")

        Return idZona

    End Function

    Public Shared Function establecerConexion(query As String)

        Dim stringConexion As SqlConnectionStringBuilder
        Dim conexion As SqlConnection

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