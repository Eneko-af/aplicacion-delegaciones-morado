<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_articulo
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
        Me.Agregar = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.id_articulo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.precio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.stock_min = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.stock_max = New System.Windows.Forms.TextBox()
        Me.CATEGORIA = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Agregar
        '
        Me.Agregar.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregar.Location = New System.Drawing.Point(223, 373)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(157, 46)
        Me.Agregar.TabIndex = 11
        Me.Agregar.Text = "Agregar"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar.Location = New System.Drawing.Point(407, 373)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(157, 46)
        Me.Cancelar.TabIndex = 12
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'id_articulo
        '
        Me.id_articulo.Location = New System.Drawing.Point(183, 106)
        Me.id_articulo.Multiline = True
        Me.id_articulo.Name = "id_articulo"
        Me.id_articulo.ReadOnly = True
        Me.id_articulo.Size = New System.Drawing.Size(139, 34)
        Me.id_articulo.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 37)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Agregar Articulo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(179, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "ID_ARTICULO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(352, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "NOMBRE"
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(356, 106)
        Me.nombre.Multiline = True
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(139, 34)
        Me.nombre.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(179, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "DESCRIPCION"
        '
        'descripcion
        '
        Me.descripcion.Location = New System.Drawing.Point(183, 260)
        Me.descripcion.Multiline = True
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(485, 86)
        Me.descripcion.TabIndex = 19
        '
        'precio
        '
        Me.precio.Location = New System.Drawing.Point(529, 106)
        Me.precio.Multiline = True
        Me.precio.Name = "precio"
        Me.precio.Size = New System.Drawing.Size(139, 34)
        Me.precio.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(525, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "PRECIO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(525, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 20)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "CATEGORIA"
        '
        'stock_min
        '
        Me.stock_min.Location = New System.Drawing.Point(356, 182)
        Me.stock_min.Multiline = True
        Me.stock_min.Name = "stock_min"
        Me.stock_min.Size = New System.Drawing.Size(139, 34)
        Me.stock_min.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(352, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 20)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "STOCK_MIN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(179, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 20)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "STOCK_MAX"
        '
        'stock_max
        '
        Me.stock_max.Location = New System.Drawing.Point(183, 182)
        Me.stock_max.Multiline = True
        Me.stock_max.Name = "stock_max"
        Me.stock_max.Size = New System.Drawing.Size(139, 34)
        Me.stock_max.TabIndex = 22
        '
        'CATEGORIA
        '
        Me.CATEGORIA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CATEGORIA.FormattingEnabled = True
        Me.CATEGORIA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CATEGORIA.Location = New System.Drawing.Point(529, 182)
        Me.CATEGORIA.Name = "CATEGORIA"
        Me.CATEGORIA.Size = New System.Drawing.Size(139, 24)
        Me.CATEGORIA.TabIndex = 28
        '
        'Agregar_articulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CATEGORIA)
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
        Me.Controls.Add(Me.id_articulo)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Agregar)
        Me.Name = "Agregar_articulo"
        Me.Text = "Agregar_articulo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Agregar As Button
    Friend WithEvents Cancelar As Button
    Friend WithEvents id_articulo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents descripcion As TextBox
    Friend WithEvents precio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents stock_min As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents stock_max As TextBox
    Friend WithEvents CATEGORIA As ComboBox
End Class
