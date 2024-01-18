Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class CONSULTA_COMERCIALES

    Private Sub CONSULTA_COMERCIALES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim valorID As String

        valorID = TB_ID.Text

        buscarPorID(valorID)
    End Sub

    Private Sub buscarPorID(idEmpleado As String)
        Dim query As String = "SELECT * FROM COMERCIALES WHERE ID_COMERCIAL = " & idEmpleado
        rellenarCampos(query, idEmpleado)
    End Sub
    Private Sub rellenarCampos(query As String, dato As String)

        Dim queryZonas As String = "SELECT * FROM ZONAS"
        Dim dtComercial As New DataTable
        Dim dtZonas As New DataTable
        Dim dr As DataRow()

        dtComercial = establecerConexion(query)

        dr = dtComercial.Select("ID_COMERCIAL = " & dato)

        For Each linea As DataRow In dr
            'DATOS EMPRESA
            TB_Mail.Text = linea("EMAIL")
            TB_FechaContratacion.Text = linea("FECHA_CONTRATACION")

            For Each row As DataRow In dtZonas.Rows

                cbZONA1.Items.Add(row("DESCRIPCION_ZONA").ToString())
                cbZONA2.Items.Add(row("DESCRIPCION_ZONA").ToString())

            Next

            'DAROS PERSONALES
            TB_Nombre.Text = linea("NOMBRE")
            TB_Apellido1.Text = linea("APELLIDO_UNO")
            TB_Apellido2.Text = linea("APELLIDO_DOS")
            TB_DNI.Text = linea("NIE")
            TB_Tlf.Text = linea("TELEFONO")
            TB_Direccion.Text = linea("DIRECCION")
        Next
    End Sub

    Private Sub btnSALIR_Click(sender As Object, e As EventArgs) Handles btnSALIR.Click
        ActiveForm.Close()
    End Sub

    Private Sub btnMODIFICAR_Click(sender As Object, e As EventArgs) Handles btnMODIFICAR.Click
        MessageBox.Show("VA A HABLITAR LA EDICIÓN DE DATOS DEL COMERCIAL")
        btnGUARDAR.Enabled = True

        habilitarTextBoxes(False)

    End Sub
    Private Sub btnGUARDAR_Click(sender As Object, e As EventArgs) Handles btnGUARDAR.Click
        Dim insertQuery As String
        If TB_Nombre.Text = "" Or TB_Apellido1.Text = "" Or TB_Apellido2.Text = "" Or TB_DNI.Text = "" Or TB_Mail.Text = "" Or TB_Tlf.Text = "" Or TB_Direccion.Text = "" Or TB_FechaContratacion.Text = "" Then
            MessageBox.Show("Uno o varios campos está vacío.")
        ElseIf Not validarFecha(TB_FechaContratacion.Text) Then
            MessageBox.Show("La fecha de contratación no está en el formato correcto (dd/MM/yyyy).")
        Else

            insertQuery = "
                UPDATE COMERCIALES
                SET
                    NOMBRE = '" & TB_Nombre.Text.ToUpper & "',
                    APELLIDO_UNO = '" & TB_Apellido1.Text.ToUpper & "',
                    APELLIDO_DOS = '" & TB_Apellido2.Text.ToUpper & "',
                    NIE = '" & TB_DNI.Text.ToUpper & "',
                    EMAIL = '" & TB_Mail.Text.ToUpper & "',
                    TELEFONO = '" & TB_Tlf.Text.ToUpper & "',
                    DIRECCION = '" & TB_Direccion.Text.ToUpper & "',
                    FECHA_CONTRATACION = '" & TB_FechaContratacion.Text & "',
                    ZONA_PRINCIPAL = '" & obtenerIDZona(cbZONA1.SelectedItem.ToString) & "',
                    ZONA_ADICIONAL = '" & obtenerIDZona(cbZONA2.SelectedItem.ToString) & "'
                WHERE
                    ID_COMERCIAL = '" & TB_ID.Text & "'"

            conexionInstert(insertQuery)
            btnGUARDAR.Enabled = False
            habilitarTextBoxes(True)
            MessageBox.Show("SE HA GUARDADO LA INFORMACIÓN")
        End If

    End Sub

    Private Function obtenerIDZona(descripcionZona As String) As String
        Dim dt As New DataTable
        Dim idZona As Integer
        Dim query As String = "SELECT ID_ZONA FROM ZONAS
                                WHERE DESCRIPCION_ZONA = '" & descripcionZona & "'"

        dt = establecerConexion(query)

        idZona = dt.Rows(0)("ID_ZONA")

        Return idZona

    End Function

    Private Function validarFecha(dateString As String) As Boolean
        Dim parsedDate As DateTime
        Return DateTime.TryParseExact(dateString, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, parsedDate)
    End Function


    Private Sub habilitarTextBoxes(habilitar As Boolean)
        'DATOS EMPRESA
        TB_Mail.ReadOnly = habilitar
        TB_FechaContratacion.ReadOnly = habilitar
        cbZONA1.Enabled = Not habilitar
        cbZONA2.Enabled = Not habilitar

        'DAROS PERSONALES
        TB_Nombre.ReadOnly = habilitar
        TB_Apellido1.ReadOnly = habilitar
        TB_Apellido2.ReadOnly = habilitar
        TB_DNI.ReadOnly = habilitar
        TB_Tlf.ReadOnly = habilitar
        TB_Direccion.ReadOnly = habilitar
    End Sub
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

End Class
