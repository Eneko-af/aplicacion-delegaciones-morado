<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipalComerciales
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TA_FiltrarPorNIE = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnAniadirComercial = New System.Windows.Forms.Button()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.CB_FIltrarActivos = New System.Windows.Forms.CheckBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COMERCIALES"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 103)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1900, 374)
        Me.DataGridView1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Filtrar por NIE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(513, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Filtrar por ZONA"
        '
        'TA_FiltrarPorNIE
        '
        Me.TA_FiltrarPorNIE.Location = New System.Drawing.Point(185, 61)
        Me.TA_FiltrarPorNIE.Name = "TA_FiltrarPorNIE"
        Me.TA_FiltrarPorNIE.Size = New System.Drawing.Size(222, 22)
        Me.TA_FiltrarPorNIE.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(709, 62)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(222, 24)
        Me.ComboBox1.TabIndex = 5
        '
        'btnAniadirComercial
        '
        Me.btnAniadirComercial.Location = New System.Drawing.Point(969, 60)
        Me.btnAniadirComercial.Name = "btnAniadirComercial"
        Me.btnAniadirComercial.Size = New System.Drawing.Size(174, 35)
        Me.btnAniadirComercial.TabIndex = 8
        Me.btnAniadirComercial.Text = "AÑADIR COMERCIAL"
        Me.btnAniadirComercial.UseVisualStyleBackColor = True
        '
        'refreshButton
        '
        Me.refreshButton.Location = New System.Drawing.Point(1149, 73)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(106, 23)
        Me.refreshButton.TabIndex = 9
        Me.refreshButton.Text = "REFRESCAR"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'CB_FIltrarActivos
        '
        Me.CB_FIltrarActivos.AutoSize = True
        Me.CB_FIltrarActivos.Location = New System.Drawing.Point(1727, 76)
        Me.CB_FIltrarActivos.Name = "CB_FIltrarActivos"
        Me.CB_FIltrarActivos.Size = New System.Drawing.Size(185, 20)
        Me.CB_FIltrarActivos.TabIndex = 11
        Me.CB_FIltrarActivos.Text = "FILTRAR SOLO ACTIVOS"
        Me.CB_FIltrarActivos.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(544, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(458, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormPrincipalComerciales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 493)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CB_FIltrarActivos)
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.btnAniadirComercial)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TA_FiltrarPorNIE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPrincipalComerciales"
        Me.Text = "COMERCIALES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TA_FiltrarPorNIE As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnAniadirComercial As Button
    Friend WithEvents refreshButton As Button
    Friend WithEvents CB_FIltrarActivos As CheckBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Button1 As Button
End Class
