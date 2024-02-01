Imports System.Data.SqlClient

Public Class CONSULTA_PARTNERS
    Private Sub CONSULTA_PARTNERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscarPorID(TB_ID.Text)
    End Sub
    Private Sub buscarPorID(idPartner As String)
        Dim query As String = "SELECT * FROM PARTNERS WHERE ID_PARTNER = " & idPartner
        rellenarCampos(query, idPartner)
    End Sub

    Private Sub rellenarCampos(query As String, dato As String)

        Dim dtPartner As New DataTable
        Dim dr As DataRow()

        dtPartner = establecerConexion(query)

        dr = dtPartner.Select("ID_PARTNER = " & dato)

        For Each linea As DataRow In dr
            'DATOS PARTNER
            TB_Nombre.Text = linea("NOMBRE")
            TB_FechaRegistro.Text = linea("FECHA_REGISTRO")
            TB_CodPostal.Text = linea("CODIGO_POSTAL")
            TB_MaIl.Text = linea("EMAIL")

            TB_Tlf.Text = linea("TELEFONO")
            TB_TipoPartner.Text = linea("TIPO")
            TB_Direccion.Text = linea("DIRECCION")
            TB_Ciudad.Text = linea("CIUDAD")
        Next
    End Sub
    Private Sub btnMODIFICAR_Click(sender As Object, e As EventArgs) Handles btnMODIFICAR.Click
        MessageBox.Show("VA A HABLITAR LA EDICIÓN DE DATOS DEL PARTNER")
        btnGUARDAR.Enabled = True

        habilitarTextBoxes(False)

    End Sub

    Private Sub habilitarTextBoxes(habilitar As Boolean)

        TB_Nombre.ReadOnly = habilitar
        TB_CodPostal.ReadOnly = habilitar
        TB_MaIl.ReadOnly = habilitar
        TB_Tlf.ReadOnly = habilitar
        TB_TipoPartner.ReadOnly = habilitar
        TB_Direccion.ReadOnly = habilitar
        TB_Ciudad.ReadOnly = habilitar

    End Sub
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

    Private Sub btnSALIR_Click(sender As Object, e As EventArgs) Handles btnSALIR.Click
        ActiveForm.Close()
    End Sub

    Private Sub btnGUARDAR_Click(sender As Object, e As EventArgs) Handles btnGUARDAR.Click
        Dim insertQuery As String
        Dim sinZona As String = "1"
        Dim activo As Boolean

        If TB_Nombre.Text = "" Or TB_CodPostal.Text = "" Or TB_MaIl.Text = "" Or TB_Tlf.Text = "" Or TB_TipoPartner.Text = "" Or TB_Direccion.Text = "" Or TB_Ciudad.Text = "" Then
            MessageBox.Show("Uno o varios campos están vacíos.")
        Else
            insertQuery = "
            UPDATE PARTNERS SET " &
                "NOMBRE = '" & TB_Nombre.Text.ToUpper & "', " &
                "DIRECCION = '" & TB_Direccion.Text.ToUpper & "', " &
                "CIUDAD = '" & TB_Ciudad.Text.ToUpper & "', " &
                "CODIGO_POSTAL = '" & TB_CodPostal.Text.ToUpper & "', " &
                "TELEFONO = '" & TB_Tlf.Text.ToUpper & "', " &
                "EMAIL = '" & TB_MaIl.Text.ToUpper & "', " &
                "TIPO = '" & TB_TipoPartner.Text.ToUpper & "' " &
            "WHERE 
                ID_PARTNER = '" & TB_ID.Text & "'"

            conexionInstert(insertQuery)
            btnGUARDAR.Enabled = False
            habilitarTextBoxes(True)
            MessageBox.Show("SE HA GUARDADO LA INFORMACIÓN")
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

    Private Sub dltButton_Click(sender As Object, e As EventArgs) Handles dltButton.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Está seguro de que quieres eliminar al partner?", "Confirmar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If resultado = DialogResult.Yes Then
            Dim query As String
            Dim idPartner As Integer = TB_ID.Text
            query = "DELETE FROM PARTNERS WHERE ID_PARTNER = " & idPartner

            conexionInstert(query)
            ActiveForm.Close()
        End If


    End Sub
End Class