<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAniadirTransportista
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
        Me.TB_ID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TB_Nombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_Tlf = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TB_ID
        '
        Me.TB_ID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_ID.Location = New System.Drawing.Point(48, 81)
        Me.TB_ID.Name = "TB_ID"
        Me.TB_ID.ReadOnly = True
        Me.TB_ID.Size = New System.Drawing.Size(285, 22)
        Me.TB_ID.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 22)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "ID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(278, 26)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "DATOS TRANSPORTISTA:"
        '
        'TB_Nombre
        '
        Me.TB_Nombre.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_Nombre.Location = New System.Drawing.Point(112, 130)
        Me.TB_Nombre.Name = "TB_Nombre"
        Me.TB_Nombre.Size = New System.Drawing.Size(221, 22)
        Me.TB_Nombre.TabIndex = 70
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 22)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "NOMBRE"
        '
        'TB_Tlf
        '
        Me.TB_Tlf.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_Tlf.Location = New System.Drawing.Point(129, 184)
        Me.TB_Tlf.Name = "TB_Tlf"
        Me.TB_Tlf.Size = New System.Drawing.Size(204, 22)
        Me.TB_Tlf.TabIndex = 74
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 22)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "TELEFONO"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 230)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(153, 41)
        Me.btnSalir.TabIndex = 75
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(180, 230)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(153, 41)
        Me.btnGuardar.TabIndex = 76
        Me.btnGuardar.Text = "GUARDAR Y SALIR"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'FormAniadirTransportista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 283)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.TB_Tlf)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TB_Nombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_ID)
        Me.Name = "FormAniadirTransportista"
        Me.Text = "AÑADIR TRANSPORTISTA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents TB_ID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Public WithEvents TB_Nombre As TextBox
    Friend WithEvents Label7 As Label
    Public WithEvents TB_Tlf As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnGuardar As Button
End Class
