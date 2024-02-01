Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormPrincipalPartners
    Private Sub FormPrincipalPartners_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TA_FiltrarPorNOMBRE.MaxLength = 10

        Dim query As String = "SELECT * FROM PARTNERS"

        rellenarDG(query)

    End Sub

    Private Sub btnAniadirPartner_Click(sender As Object, e As EventArgs) Handles btnAniadirPartner.Click
        Dim dtCount As New DataTable
        Dim idNueva As Integer
        Dim formANIADIR As New FormAniadirPartner

        Dim queryCount As String = "SELECT COUNT(*) AS TOTAL FROM PARTNERS"

        dtCount = establecerConexion(queryCount)

        idNueva = CInt(dtCount.Rows(0)("TOTAL")) + 1

        formANIADIR.TB_ID.Text = idNueva
        formANIADIR.TB_FechaRegistro.Text = DateTime.Now.ToString("yyyy-MM-dd")

        formANIADIR.ShowDialog()
    End Sub

    Private Sub TA_FiltrarPorNOMBRE_TextChanged(sender As Object, e As EventArgs) Handles TA_FiltrarPorNOMBRE.TextChanged
        Dim query As String
        Dim nombrePartner As String = TA_FiltrarPorNOMBRE.Text

        If nombrePartner = "" Then
            query = "SELECT * FROM PARTNERS"
            rellenarDG(query)
        Else
            query = "SELECT * FROM PARTNERS WHERE NOMBRE LIKE '" & nombrePartner & "%'"
            rellenarDG(query)
        End If

    End Sub

    Private Sub rellenarDG(query As String)
        DataGridView1.DataSource = establecerConexion(query)
    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        Dim query As String

        query = "SELECT * FROM PARTNERS"

        TA_FiltrarPorNOMBRE.Text = ""

        rellenarDG(query)

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

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick

        If e.RowIndex >= 0 Then
            Try
                Dim queryZonas As String
                Dim valorIDPartner As Object

                valorIDPartner = DataGridView1.Rows(e.RowIndex).Cells(0).Value

                Dim formCONSULTAS_PARTNER As New CONSULTA_PARTNERS

                formCONSULTAS_PARTNER.TB_ID.Text = valorIDPartner

                formCONSULTAS_PARTNER.ShowDialog()
            Catch ex As System.InvalidCastException
                MessageBox.Show("Debe seleccionar una fila con datos")
            Catch ex_2 As Exception
                MessageBox.Show(ex_2.StackTrace)
            End Try


        End If
    End Sub
End Class