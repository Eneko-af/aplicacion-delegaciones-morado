Imports System.Data.SqlClient

Public Class FormPrincipalTransportistas
    Private Sub FormPrincipalTransportistas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim query As String = "SELECT * FROM TRANSPORTISTAS"

        rellenarDG(query)
    End Sub
    Private Sub btnAniadirTransportista_Click(sender As Object, e As EventArgs) Handles btnAniadirTransportista.Click
        Dim dtCount As New DataTable
        Dim idNueva As Integer
        Dim formANIADIR As New FormAniadirTransportista

        Dim queryCount As String = "SELECT COUNT(*) AS TOTAL FROM TRANSPORTISTAS"

        dtCount = establecerConexion(queryCount)

        idNueva = CInt(dtCount.Rows(0)("TOTAL")) + 1

        formANIADIR.TB_ID.Text = idNueva

        formANIADIR.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick

        If e.RowIndex >= 0 Then
            Try
                Dim formMODIFICAR_TLF As New FormModficarTLFTransportista

                formMODIFICAR_TLF.TB_ID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                formMODIFICAR_TLF.TB_Empresa.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
                formMODIFICAR_TLF.TB_TlfViejo.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value

                formMODIFICAR_TLF.ShowDialog()

            Catch ex As System.InvalidCastException
                MessageBox.Show("Debe seleccionar una fila con datos")
            Catch ex_2 As Exception
                MessageBox.Show(ex_2.StackTrace)
            End Try


        End If
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
    Private Sub rellenarDG(query As String)
        DataGridView1.DataSource = establecerConexion(query)
    End Sub
    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        Dim query As String

        query = "SELECT * FROM TRANSPORTISTAS"

        rellenarDG(query)

    End Sub

End Class