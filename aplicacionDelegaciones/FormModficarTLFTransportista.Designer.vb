<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModficarTLFTransportista
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_TlfViejo = New System.Windows.Forms.TextBox()
        Me.TB_TlfNuevo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_Empresa = New System.Windows.Forms.TextBox()
        Me.btnSALIR = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.TB_ID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 26)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "TELEFONO VIEJO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 26)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "TELEFONO NUEVO:"
        '
        'TB_TlfViejo
        '
        Me.TB_TlfViejo.Enabled = False
        Me.TB_TlfViejo.Location = New System.Drawing.Point(293, 73)
        Me.TB_TlfViejo.Name = "TB_TlfViejo"
        Me.TB_TlfViejo.Size = New System.Drawing.Size(248, 22)
        Me.TB_TlfViejo.TabIndex = 16
        '
        'TB_TlfNuevo
        '
        Me.TB_TlfNuevo.Location = New System.Drawing.Point(293, 140)
        Me.TB_TlfNuevo.Name = "TB_TlfNuevo"
        Me.TB_TlfNuevo.Size = New System.Drawing.Size(248, 22)
        Me.TB_TlfNuevo.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 26)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "EMPRESA:"
        '
        'TB_Empresa
        '
        Me.TB_Empresa.Enabled = False
        Me.TB_Empresa.Location = New System.Drawing.Point(138, 9)
        Me.TB_Empresa.Name = "TB_Empresa"
        Me.TB_Empresa.Size = New System.Drawing.Size(403, 22)
        Me.TB_Empresa.TabIndex = 19
        '
        'btnSALIR
        '
        Me.btnSALIR.Location = New System.Drawing.Point(12, 220)
        Me.btnSALIR.Name = "btnSALIR"
        Me.btnSALIR.Size = New System.Drawing.Size(188, 48)
        Me.btnSALIR.TabIndex = 28
        Me.btnSALIR.Text = "SALIR"
        Me.btnSALIR.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(353, 220)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(188, 48)
        Me.btnGuardar.TabIndex = 29
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'TB_ID
        '
        Me.TB_ID.Enabled = False
        Me.TB_ID.Location = New System.Drawing.Point(474, 37)
        Me.TB_ID.Name = "TB_ID"
        Me.TB_ID.Size = New System.Drawing.Size(67, 22)
        Me.TB_ID.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(426, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 26)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "ID:"
        '
        'FormModficarTLFTransportista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 283)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_ID)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSALIR)
        Me.Controls.Add(Me.TB_Empresa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_TlfNuevo)
        Me.Controls.Add(Me.TB_TlfViejo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormModficarTLFTransportista"
        Me.Text = "MODIFICAR TELEFONO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_TlfViejo As TextBox
    Friend WithEvents TB_TlfNuevo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_Empresa As TextBox
    Friend WithEvents btnSALIR As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents TB_ID As TextBox
    Friend WithEvents Label4 As Label
End Class
