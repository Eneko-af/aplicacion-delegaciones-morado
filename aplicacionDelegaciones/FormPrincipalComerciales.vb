Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles

Public Class FormPrincipalComerciales
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CB_FIltrarActivos.Checked = True
        TA_FiltrarPorNIE.MaxLength = 10

        Dim dtZonas As New DataTable
        Dim queryZonas As String = "SELECT * FROM ZONAS"
        Dim query As String = "SELECT * FROM COMERCIALES WHERE ACTIVO = 1"

        rellenarDG(query)

        dtZonas = establecerConexion(queryZonas)

        ComboBox1.Items.Add("QUITAR FILTROS ZONA")

        For Each row As DataRow In dtZonas.Rows

            ComboBox1.Items.Add(row("DESCRIPCION_ZONA").ToString())

        Next


    End Sub
    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick

        If e.RowIndex >= 0 Then
            Try
                Dim dtZonas As New DataTable
                Dim queryZonas As String
                Dim valorIDComercial As Object
                Dim valorZonaPrincipal As Object
                Dim valorZonaSecundaria As Object

                queryZonas = "SELECT * FROM ZONAS"
                valorIDComercial = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                valorZonaPrincipal = DataGridView1.Rows(e.RowIndex).Cells(9).Value
                valorZonaSecundaria = DataGridView1.Rows(e.RowIndex).Cells(10).Value

                dtZonas = establecerConexion(queryZonas)

                Dim formCONSULTAS As New CONSULTA_COMERCIALES

                formCONSULTAS.TB_ID.Text = valorIDComercial

                For Each row As DataRow In dtZonas.Rows

                    formCONSULTAS.cbZONA1.Items.Add(row("DESCRIPCION_ZONA").ToString())
                    formCONSULTAS.cbZONA2.Items.Add(row("DESCRIPCION_ZONA").ToString())

                Next

                formCONSULTAS.cbZONA1.SelectedIndex = valorZonaPrincipal - 1
                formCONSULTAS.cbZONA2.SelectedIndex = valorZonaSecundaria - 1

                formCONSULTAS.ShowDialog()
            Catch ex As System.InvalidCastException
                MessageBox.Show("Debe seleccionar una fila con datos")
            Catch ex_2 As Exception
                MessageBox.Show(ex_2.StackTrace)
            End Try


        End If
    End Sub

    Private Sub buscarPorZonas(selectedItem As String)
        CB_FIltrarActivos.Checked = True
        Dim query As String = "SELECT * 
                                        FROM COMERCIALES WHERE ZONA_PRINCIPAL = (      
                                        SELECT ID_ZONA
                                        FROM ZONAS
                                        WHERE DESCRIPCION_ZONA = '" & selectedItem & "') AND ACTIVO = 1"
        rellenarDG(query)
    End Sub

    Private Sub buscarPorDNI(DNI_Empleado As String)
        Dim query As String = "SELECT * FROM COMERCIALES WHERE NIE LIKE '" & DNI_Empleado & "%'"
        rellenarDG(query)
    End Sub

    Private Sub vaciarCampos()
        TA_FiltrarPorNIE.Text = ""
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub rellenarDG(query As String)
        DataGridView1.DataSource = establecerConexion(query)
    End Sub

    Private Sub TA_FiltrarPorNIE_TextChanged(sender As Object, e As EventArgs) Handles TA_FiltrarPorNIE.TextChanged

        If TA_FiltrarPorNIE.Text = "" Then
            If CB_FIltrarActivos.Checked = True Then
                Dim query As String = "SELECT * FROM COMERCIALES WHERE ACTIVO = 1"
                rellenarDG(query)
                ComboBox1.Enabled = True
            Else
                Dim query As String = "SELECT * FROM COMERCIALES"
                rellenarDG(query)
                ComboBox1.Enabled = True
            End If

        Else
                buscarPorDNI(TA_FiltrarPorNIE.Text)
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim query As String
        If ComboBox1.SelectedIndex > 0 Then
            buscarPorZonas(ComboBox1.SelectedItem)
            TA_FiltrarPorNIE.ReadOnly = True
        Else
            If CB_FIltrarActivos.Checked = True Then
                query = "SELECT * FROM COMERCIALES WHERE ACTIVO = 1"
            Else
                query = "SELECT * FROM COMERCIALES"
            End If

            rellenarDG(query)
            TA_FiltrarPorNIE.ReadOnly = False
            vaciarCampos()
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

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        Dim query As String
        Dim dtZonas As New DataTable
        Dim queryZonas As String = "SELECT * FROM ZONAS"

        If CB_FIltrarActivos.Checked = True Then
            query = "SELECT * FROM COMERCIALES WHERE ACTIVO = 1"
        Else
            query = "SELECT * FROM COMERCIALES"
        End If

        ComboBox1.SelectedIndex = 0

        rellenarDG(query)

    End Sub

    Private Sub btnAniadirComercial_Click(sender As Object, e As EventArgs) Handles btnAniadirComercial.Click
        Dim dtCount As New DataTable
        Dim dtZonas As New DataTable
        Dim idNueva As Integer
        Dim formANIADIR As New FormAniadirComercial

        Dim queryZonas As String = "SELECT * FROM ZONAS"
        Dim queryCount As String = "SELECT COUNT(*) AS TOTAL FROM COMERCIALES"

        dtCount = establecerConexion(queryCount)
        dtZonas = establecerConexion(queryZonas)

        For Each row As DataRow In dtZonas.Rows

            formANIADIR.cbZONA1.Items.Add(row("DESCRIPCION_ZONA").ToString())
            formANIADIR.cbZONA2.Items.Add(row("DESCRIPCION_ZONA").ToString())

        Next

        idNueva = CInt(dtCount.Rows(0)("TOTAL")) + 1

        formANIADIR.TB_ID.Text = idNueva

        formANIADIR.ShowDialog()
    End Sub

End Class
