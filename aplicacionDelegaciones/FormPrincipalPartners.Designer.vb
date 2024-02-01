<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipalPartners
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TA_FiltrarPorNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.btnAniadirPartner = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PARTNERS"
        '
        'TA_FiltrarPorNOMBRE
        '
        Me.TA_FiltrarPorNOMBRE.Location = New System.Drawing.Point(251, 63)
        Me.TA_FiltrarPorNOMBRE.Name = "TA_FiltrarPorNOMBRE"
        Me.TA_FiltrarPorNOMBRE.Size = New System.Drawing.Size(222, 22)
        Me.TA_FiltrarPorNOMBRE.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Filtrar por NOMBRE"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1294, 347)
        Me.DataGridView1.TabIndex = 7
        '
        'refreshButton
        '
        Me.refreshButton.Location = New System.Drawing.Point(970, 63)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(106, 23)
        Me.refreshButton.TabIndex = 11
        Me.refreshButton.Text = "REFRESCAR"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'btnAniadirPartner
        '
        Me.btnAniadirPartner.Location = New System.Drawing.Point(775, 53)
        Me.btnAniadirPartner.Name = "btnAniadirPartner"
        Me.btnAniadirPartner.Size = New System.Drawing.Size(174, 35)
        Me.btnAniadirPartner.TabIndex = 10
        Me.btnAniadirPartner.Text = "AÑADIR PARTNER"
        Me.btnAniadirPartner.UseVisualStyleBackColor = True
        '
        'FormPrincipalPartners
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 450)
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.btnAniadirPartner)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TA_FiltrarPorNOMBRE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPrincipalPartners"
        Me.Text = "PARTNERS EUSKOMITO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TA_FiltrarPorNOMBRE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents refreshButton As Button
    Friend WithEvents btnAniadirPartner As Button
End Class
