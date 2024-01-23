<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.stock_min = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.stock_max = New System.Windows.Forms.TextBox()
        Me.precio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.guardar = New System.Windows.Forms.Button()
        Me.IDS = New System.Windows.Forms.ComboBox()
        Me.CATEGORIA = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(445, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 20)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "CATEGORIA*"
        '
        'stock_min
        '
        Me.stock_min.Location = New System.Drawing.Point(103, 182)
        Me.stock_min.Multiline = True
        Me.stock_min.Name = "stock_min"
        Me.stock_min.Size = New System.Drawing.Size(139, 34)
        Me.stock_min.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(99, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 20)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "STOCK_MIN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(272, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 20)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "STOCK_MAX"
        '
        'stock_max
        '
        Me.stock_max.Location = New System.Drawing.Point(276, 182)
        Me.stock_max.Multiline = True
        Me.stock_max.Name = "stock_max"
        Me.stock_max.Size = New System.Drawing.Size(139, 34)
        Me.stock_max.TabIndex = 39
        '
        'precio
        '
        Me.precio.Location = New System.Drawing.Point(449, 106)
        Me.precio.Multiline = True
        Me.precio.Name = "precio"
        Me.precio.Size = New System.Drawing.Size(139, 34)
        Me.precio.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(445, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "PRECIO"
        '
        'descripcion
        '
        Me.descripcion.Location = New System.Drawing.Point(103, 260)
        Me.descripcion.Multiline = True
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(485, 86)
        Me.descripcion.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(99, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 20)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "DESCRIPCION"
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(276, 106)
        Me.nombre.Multiline = True
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(139, 34)
        Me.nombre.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(272, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "NOMBRE*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(99, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "ID_ARTICULO*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(205, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 37)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Modificar articulo"
        '
        'Cancelar
        '
        Me.Cancelar.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar.Location = New System.Drawing.Point(353, 379)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(175, 46)
        Me.Cancelar.TabIndex = 30
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'guardar
        '
        Me.guardar.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardar.Location = New System.Drawing.Point(172, 379)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(175, 46)
        Me.guardar.TabIndex = 29
        Me.guardar.Text = "Guardar Cambios"
        Me.guardar.UseVisualStyleBackColor = True
        '
        'IDS
        '
        Me.IDS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IDS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IDS.FormattingEnabled = True
        Me.IDS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.IDS.Location = New System.Drawing.Point(103, 116)
        Me.IDS.Name = "IDS"
        Me.IDS.Size = New System.Drawing.Size(139, 24)
        Me.IDS.TabIndex = 46
        '
        'CATEGORIA
        '
        Me.CATEGORIA.Location = New System.Drawing.Point(449, 182)
        Me.CATEGORIA.Multiline = True
        Me.CATEGORIA.Name = "CATEGORIA"
        Me.CATEGORIA.Size = New System.Drawing.Size(139, 34)
        Me.CATEGORIA.TabIndex = 47
        '
        'Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 450)
        Me.Controls.Add(Me.CATEGORIA)
        Me.Controls.Add(Me.IDS)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.stock_min)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.stock_max)
        Me.Controls.Add(Me.precio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.guardar)
        Me.Name = "Modificar"
        Me.Text = "Modificar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents stock_min As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents stock_max As TextBox
    Friend WithEvents precio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents descripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Cancelar As Button
    Friend WithEvents guardar As Button
    Friend WithEvents IDS As ComboBox
    Friend WithEvents CATEGORIA As TextBox
End Class
