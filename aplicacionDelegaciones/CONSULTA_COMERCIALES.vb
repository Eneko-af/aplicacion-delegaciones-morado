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

            'TB_Zona1.Text = linea("ZONA_PRINCIPAL")
            'TB_Zona2.Text = linea("ZONA_ADICIONAL")

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
        'INSERT EN LA BDD
        btnGUARDAR.Enabled = False
        habilitarTextBoxes(True)
        MessageBox.Show("SE HA GUARDADO LA INFORMACIÓN")
    End Sub

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

End Class
