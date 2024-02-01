<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CONSULTA_PARTNERS
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_TipoPartner = New System.Windows.Forms.TextBox()
        Me.TB_Tlf = New System.Windows.Forms.TextBox()
        Me.TB_MaIl = New System.Windows.Forms.TextBox()
        Me.TB_CodPostal = New System.Windows.Forms.TextBox()
        Me.TB_Ciudad = New System.Windows.Forms.TextBox()
        Me.TB_Direccion = New System.Windows.Forms.TextBox()
        Me.TB_FechaRegistro = New System.Windows.Forms.TextBox()
        Me.TB_Nombre = New System.Windows.Forms.TextBox()
        Me.TB_ID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dltButton = New System.Windows.Forms.Button()
        Me.btnGUARDAR = New System.Windows.Forms.Button()
        Me.btnMODIFICAR = New System.Windows.Forms.Button()
        Me.btnSALIR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 25.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(72, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PARTNERS"
        '
        'TB_TipoPartner
        '
        Me.TB_TipoPartner.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_TipoPartner.Location = New System.Drawing.Point(545, 187)
        Me.TB_TipoPartner.Name = "TB_TipoPartner"
        Me.TB_TipoPartner.ReadOnly = True
        Me.TB_TipoPartner.Size = New System.Drawing.Size(290, 22)
        Me.TB_TipoPartner.TabIndex = 92
        '
        'TB_Tlf
        '
        Me.TB_Tlf.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_Tlf.Location = New System.Drawing.Point(511, 133)
        Me.TB_Tlf.Name = "TB_Tlf"
        Me.TB_Tlf.ReadOnly = True
        Me.TB_Tlf.Size = New System.Drawing.Size(324, 22)
        Me.TB_Tlf.TabIndex = 91
        '
        'TB_MaIl
        '
        Me.TB_MaIl.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_MaIl.Location = New System.Drawing.Point(132, 342)
        Me.TB_MaIl.Name = "TB_MaIl"
        Me.TB_MaIl.ReadOnly = True
        Me.TB_MaIl.Size = New System.Drawing.Size(217, 22)
        Me.TB_MaIl.TabIndex = 90
        '
        'TB_CodPostal
        '
        Me.TB_CodPostal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_CodPostal.Location = New System.Drawing.Point(167, 290)
        Me.TB_CodPostal.Name = "TB_CodPostal"
        Me.TB_CodPostal.ReadOnly = True
        Me.TB_CodPostal.Size = New System.Drawing.Size(182, 22)
        Me.TB_CodPostal.TabIndex = 89
        '
        'TB_Ciudad
        '
        Me.TB_Ciudad.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_Ciudad.Location = New System.Drawing.Point(485, 292)
        Me.TB_Ciudad.Name = "TB_Ciudad"
        Me.TB_Ciudad.ReadOnly = True
        Me.TB_Ciudad.Size = New System.Drawing.Size(350, 22)
        Me.TB_Ciudad.TabIndex = 88
        '
        'TB_Direccion
        '
        Me.TB_Direccion.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_Direccion.Location = New System.Drawing.Point(516, 239)
        Me.TB_Direccion.Name = "TB_Direccion"
        Me.TB_Direccion.ReadOnly = True
        Me.TB_Direccion.Size = New System.Drawing.Size(319, 22)
        Me.TB_Direccion.TabIndex = 87
        '
        'TB_FechaRegistro
        '
        Me.TB_FechaRegistro.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_FechaRegistro.Location = New System.Drawing.Point(247, 239)
        Me.TB_FechaRegistro.Name = "TB_FechaRegistro"
        Me.TB_FechaRegistro.ReadOnly = True
        Me.TB_FechaRegistro.Size = New System.Drawing.Size(102, 22)
        Me.TB_FechaRegistro.TabIndex = 86
        '
        'TB_Nombre
        '
        Me.TB_Nombre.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_Nombre.Location = New System.Drawing.Point(167, 186)
        Me.TB_Nombre.Name = "TB_Nombre"
        Me.TB_Nombre.ReadOnly = True
        Me.TB_Nombre.Size = New System.Drawing.Size(182, 22)
        Me.TB_Nombre.TabIndex = 85
        '
        'TB_ID
        '
        Me.TB_ID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_ID.Location = New System.Drawing.Point(104, 133)
        Me.TB_ID.Name = "TB_ID"
        Me.TB_ID.ReadOnly = True
        Me.TB_ID.Size = New System.Drawing.Size(245, 22)
        Me.TB_ID.TabIndex = 84
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(395, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 22)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "TIPO PARTNER"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(395, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 22)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "TELEFONO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 342)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 22)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "MAIL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 290)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 22)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "C.POSTAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(395, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 22)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "CIUDAD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(395, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 22)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "DIRECCION"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(68, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(173, 22)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "FECHA REGISTRO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(68, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 22)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "NOMBRE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(68, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 22)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "ID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(67, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(196, 26)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "DATOS PARTNER:"
        '
        'dltButton
        '
        Me.dltButton.Location = New System.Drawing.Point(12, 392)
        Me.dltButton.Name = "dltButton"
        Me.dltButton.Size = New System.Drawing.Size(188, 48)
        Me.dltButton.TabIndex = 96
        Me.dltButton.Text = "DESABILITAR"
        Me.dltButton.UseVisualStyleBackColor = True
        '
        'btnGUARDAR
        '
        Me.btnGUARDAR.Enabled = False
        Me.btnGUARDAR.Location = New System.Drawing.Point(558, 392)
        Me.btnGUARDAR.Name = "btnGUARDAR"
        Me.btnGUARDAR.Size = New System.Drawing.Size(188, 48)
        Me.btnGUARDAR.TabIndex = 95
        Me.btnGUARDAR.Text = "GUARDAR"
        Me.btnGUARDAR.UseVisualStyleBackColor = True
        '
        'btnMODIFICAR
        '
        Me.btnMODIFICAR.Location = New System.Drawing.Point(351, 392)
        Me.btnMODIFICAR.Name = "btnMODIFICAR"
        Me.btnMODIFICAR.Size = New System.Drawing.Size(188, 48)
        Me.btnMODIFICAR.TabIndex = 94
        Me.btnMODIFICAR.Text = "MODIFICAR"
        Me.btnMODIFICAR.UseVisualStyleBackColor = True
        '
        'btnSALIR
        '
        Me.btnSALIR.Location = New System.Drawing.Point(765, 392)
        Me.btnSALIR.Name = "btnSALIR"
        Me.btnSALIR.Size = New System.Drawing.Size(188, 48)
        Me.btnSALIR.TabIndex = 93
        Me.btnSALIR.Text = "SALIR"
        Me.btnSALIR.UseVisualStyleBackColor = True
        '
        'CONSULTA_PARTNERS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 457)
        Me.Controls.Add(Me.dltButton)
        Me.Controls.Add(Me.btnGUARDAR)
        Me.Controls.Add(Me.btnMODIFICAR)
        Me.Controls.Add(Me.btnSALIR)
        Me.Controls.Add(Me.TB_TipoPartner)
        Me.Controls.Add(Me.TB_Tlf)
        Me.Controls.Add(Me.TB_MaIl)
        Me.Controls.Add(Me.TB_CodPostal)
        Me.Controls.Add(Me.TB_Ciudad)
        Me.Controls.Add(Me.TB_Direccion)
        Me.Controls.Add(Me.TB_FechaRegistro)
        Me.Controls.Add(Me.TB_Nombre)
        Me.Controls.Add(Me.TB_ID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CONSULTA_PARTNERS"
        Me.Text = "PARTNER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Public WithEvents TB_TipoPartner As TextBox
    Public WithEvents TB_Tlf As TextBox
    Public WithEvents TB_MaIl As TextBox
    Public WithEvents TB_CodPostal As TextBox
    Public WithEvents TB_Ciudad As TextBox
    Public WithEvents TB_Direccion As TextBox
    Public WithEvents TB_FechaRegistro As TextBox
    Public WithEvents TB_Nombre As TextBox
    Public WithEvents TB_ID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dltButton As Button
    Friend WithEvents btnGUARDAR As Button
    Friend WithEvents btnMODIFICAR As Button
    Friend WithEvents btnSALIR As Button
End Class
