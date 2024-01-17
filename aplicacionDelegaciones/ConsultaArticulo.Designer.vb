<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaArticulo
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Form2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip4 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip5 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.filtro = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.consulta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Importar = New System.Windows.Forms.Button()
        Me.Exportar = New System.Windows.Forms.Button()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.ContextMenuStrip4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Form2ToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(119, 28)
        '
        'Form2ToolStripMenuItem
        '
        Me.Form2ToolStripMenuItem.Name = "Form2ToolStripMenuItem"
        Me.Form2ToolStripMenuItem.Size = New System.Drawing.Size(118, 24)
        Me.Form2ToolStripMenuItem.Text = "form2"
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip4
        '
        Me.ContextMenuStrip4.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AToolStripMenuItem})
        Me.ContextMenuStrip4.Name = "ContextMenuStrip4"
        Me.ContextMenuStrip4.Size = New System.Drawing.Size(87, 28)
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.AToolStripMenuItem.Text = "a"
        '
        'ContextMenuStrip5
        '
        Me.ContextMenuStrip5.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip5.Name = "ContextMenuStrip5"
        Me.ContextMenuStrip5.Size = New System.Drawing.Size(61, 4)
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(36, 163)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(887, 386)
        Me.DataGridView1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(409, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 37)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Articulos"
        '
        'filtro
        '
        Me.filtro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filtro.FormattingEnabled = True
        Me.filtro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.filtro.Location = New System.Drawing.Point(17, 34)
        Me.filtro.Name = "filtro"
        Me.filtro.Size = New System.Drawing.Size(96, 24)
        Me.filtro.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.consulta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.filtro)
        Me.GroupBox1.Location = New System.Drawing.Point(533, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 98)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar por campo"
        '
        'consulta
        '
        Me.consulta.Location = New System.Drawing.Point(128, 36)
        Me.consulta.Name = "consulta"
        Me.consulta.Size = New System.Drawing.Size(128, 22)
        Me.consulta.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Filtro"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(262, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 36)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Filtrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Agregar
        '
        Me.Agregar.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregar.Location = New System.Drawing.Point(36, 59)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(157, 46)
        Me.Agregar.TabIndex = 10
        Me.Agregar.Text = "Agregar"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'Borrar
        '
        Me.Borrar.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrar.Location = New System.Drawing.Point(199, 59)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(157, 46)
        Me.Borrar.TabIndex = 11
        Me.Borrar.Text = "Borrar"
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modificar.Location = New System.Drawing.Point(364, 59)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(157, 46)
        Me.Modificar.TabIndex = 12
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Importar
        '
        Me.Importar.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Importar.Location = New System.Drawing.Point(36, 111)
        Me.Importar.Name = "Importar"
        Me.Importar.Size = New System.Drawing.Size(157, 46)
        Me.Importar.TabIndex = 13
        Me.Importar.Text = "Importar"
        Me.Importar.UseVisualStyleBackColor = True
        '
        'Exportar
        '
        Me.Exportar.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exportar.Location = New System.Drawing.Point(199, 111)
        Me.Exportar.Name = "Exportar"
        Me.Exportar.Size = New System.Drawing.Size(157, 46)
        Me.Exportar.TabIndex = 14
        Me.Exportar.Text = "Exportar"
        Me.Exportar.UseVisualStyleBackColor = True
        '
        'ConsultaArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 575)
        Me.Controls.Add(Me.Exportar)
        Me.Controls.Add(Me.Importar)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.Borrar)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ConsultaArticulo"
        Me.Text = "Form1"
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ContextMenuStrip4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents Form2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip4 As ContextMenuStrip
    Friend WithEvents AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip5 As ContextMenuStrip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents filtro As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents consulta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Agregar As Button
    Friend WithEvents Borrar As Button
    Friend WithEvents Modificar As Button
    Friend WithEvents Importar As Button
    Friend WithEvents Exportar As Button
End Class
