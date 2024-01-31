<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAniadirComercial
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cbZONA2 = New System.Windows.Forms.ComboBox()
        Me.cbZONA1 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TB_Direccion = New System.Windows.Forms.TextBox()
        Me.TB_Tlf = New System.Windows.Forms.TextBox()
        Me.TB_DNI = New System.Windows.Forms.TextBox()
        Me.TB_Apellido2 = New System.Windows.Forms.TextBox()
        Me.TB_Apellido1 = New System.Windows.Forms.TextBox()
        Me.TB_Nombre = New System.Windows.Forms.TextBox()
        Me.TB_FechaContratacion = New System.Windows.Forms.TextBox()
        Me.TB_Mail = New System.Windows.Forms.TextBox()
        Me.TB_ID = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 397)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(635, 397)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 41)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "GUARDAR Y SALIR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cbZONA2
        '
        Me.cbZONA2.FormattingEnabled = True
        Me.cbZONA2.Location = New System.Drawing.Point(182, 299)
        Me.cbZONA2.Name = "cbZONA2"
        Me.cbZONA2.Size = New System.Drawing.Size(157, 24)
        Me.cbZONA2.TabIndex = 57
        '
        'cbZONA1
        '
        Me.cbZONA1.FormattingEnabled = True
        Me.cbZONA1.Location = New System.Drawing.Point(182, 244)
        Me.cbZONA1.Name = "cbZONA1"
        Me.cbZONA1.Size = New System.Drawing.Size(157, 24)
        Me.cbZONA1.TabIndex = 56
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 243)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(170, 22)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "ZONA PRINCIPAL:"
        '
        'TB_Direccion
        '
        Me.TB_Direccion.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_Direccion.Location = New System.Drawing.Point(529, 353)
        Me.TB_Direccion.Name = "TB_Direccion"
        Me.TB_Direccion.Size = New System.Drawing.Size(309, 22)
        Me.TB_Direccion.TabIndex = 54
        '
        'TB_Tlf
        '
        Me.TB_Tlf.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_Tlf.Location = New System.Drawing.Point(453, 302)
        Me.TB_Tlf.Name = "TB_Tlf"
        Me.TB_Tlf.Size = New System.Drawing.Size(385, 22)
        Me.TB_Tlf.TabIndex = 53
        '
        'TB_DNI
        '
        Me.TB_DNI.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_DNI.Location = New System.Drawing.Point(491, 243)
        Me.TB_DNI.Name = "TB_DNI"
        Me.TB_DNI.Size = New System.Drawing.Size(347, 22)
        Me.TB_DNI.TabIndex = 52
        '
        'TB_Apellido2
        '
        Me.TB_Apellido2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_Apellido2.Location = New System.Drawing.Point(620, 186)
        Me.TB_Apellido2.Name = "TB_Apellido2"
        Me.TB_Apellido2.Size = New System.Drawing.Size(218, 22)
        Me.TB_Apellido2.TabIndex = 51
        '
        'TB_Apellido1
        '
        Me.TB_Apellido1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_Apellido1.Location = New System.Drawing.Point(600, 133)
        Me.TB_Apellido1.Name = "TB_Apellido1"
        Me.TB_Apellido1.Size = New System.Drawing.Size(238, 22)
        Me.TB_Apellido1.TabIndex = 50
        '
        'TB_Nombre
        '
        Me.TB_Nombre.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_Nombre.Location = New System.Drawing.Point(504, 80)
        Me.TB_Nombre.Name = "TB_Nombre"
        Me.TB_Nombre.Size = New System.Drawing.Size(334, 22)
        Me.TB_Nombre.TabIndex = 49
        '
        'TB_FechaContratacion
        '
        Me.TB_FechaContratacion.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_FechaContratacion.Location = New System.Drawing.Point(265, 182)
        Me.TB_FechaContratacion.Name = "TB_FechaContratacion"
        Me.TB_FechaContratacion.Size = New System.Drawing.Size(108, 22)
        Me.TB_FechaContratacion.TabIndex = 48
        '
        'TB_Mail
        '
        Me.TB_Mail.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_Mail.Location = New System.Drawing.Point(85, 130)
        Me.TB_Mail.Name = "TB_Mail"
        Me.TB_Mail.Size = New System.Drawing.Size(288, 22)
        Me.TB_Mail.TabIndex = 47
        '
        'TB_ID
        '
        Me.TB_ID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_ID.Location = New System.Drawing.Point(85, 76)
        Me.TB_ID.Name = "TB_ID"
        Me.TB_ID.ReadOnly = True
        Me.TB_ID.Size = New System.Drawing.Size(288, 22)
        Me.TB_ID.TabIndex = 46
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(385, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(239, 26)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "DATOS PERSONALES:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(234, 26)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "DATOS EN EMPRESA:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 301)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(172, 22)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "ZONA ADICIONAL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(386, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 22)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "TLF"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(386, 352)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 22)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "DIRECCION"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 183)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(227, 22)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "FECHA CONTRATACIÓN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(386, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 22)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "SEGUNDO APELLIDO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(386, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 22)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "DNI/NIE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 22)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "MAIL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(386, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 22)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "PRIMER APELLIDO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(386, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 22)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "NOMBRE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 22)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "ID"
        '
        'FormAniadirComercial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 450)
        Me.Controls.Add(Me.cbZONA2)
        Me.Controls.Add(Me.cbZONA1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TB_Direccion)
        Me.Controls.Add(Me.TB_Tlf)
        Me.Controls.Add(Me.TB_DNI)
        Me.Controls.Add(Me.TB_Apellido2)
        Me.Controls.Add(Me.TB_Apellido1)
        Me.Controls.Add(Me.TB_Nombre)
        Me.Controls.Add(Me.TB_FechaContratacion)
        Me.Controls.Add(Me.TB_Mail)
        Me.Controls.Add(Me.TB_ID)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormAniadirComercial"
        Me.Text = "AÑADIR COMERCIAL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Public WithEvents cbZONA2 As ComboBox
    Public WithEvents cbZONA1 As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TB_Direccion As TextBox
    Friend WithEvents TB_Tlf As TextBox
    Friend WithEvents TB_DNI As TextBox
    Friend WithEvents TB_Apellido2 As TextBox
    Friend WithEvents TB_Apellido1 As TextBox
    Friend WithEvents TB_Nombre As TextBox
    Public WithEvents TB_FechaContratacion As TextBox
    Public WithEvents TB_Mail As TextBox
    Public WithEvents TB_ID As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
