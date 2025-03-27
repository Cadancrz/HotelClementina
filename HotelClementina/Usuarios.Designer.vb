<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.DgvEmp = New System.Windows.Forms.DataGridView()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIdentidad = New System.Windows.Forms.TextBox()
        Me.DgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.RbAdmin = New System.Windows.Forms.RadioButton()
        Me.RbInvitado = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnCambiarContra = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LblCodigo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1136, 58)
        Me.Panel1.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(441, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USUARIOS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtBusqueda)
        Me.GroupBox2.Controls.Add(Me.DgvEmp)
        Me.GroupBox2.Font = New System.Drawing.Font("Dubai", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(82, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(538, 244)
        Me.GroupBox2.TabIndex = 90
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Búsqueda de Empleado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 27)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Nombre"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusqueda.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtBusqueda.Location = New System.Drawing.Point(90, 36)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.ShortcutsEnabled = False
        Me.TxtBusqueda.Size = New System.Drawing.Size(425, 25)
        Me.TxtBusqueda.TabIndex = 104
        '
        'DgvEmp
        '
        Me.DgvEmp.AllowUserToAddRows = False
        Me.DgvEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEmp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvEmp.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEmp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.DgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Dubai", 11.25!)
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvEmp.DefaultCellStyle = DataGridViewCellStyle26
        Me.DgvEmp.Location = New System.Drawing.Point(21, 73)
        Me.DgvEmp.Name = "DgvEmp"
        Me.DgvEmp.ReadOnly = True
        Me.DgvEmp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DgvEmp.Size = New System.Drawing.Size(494, 153)
        Me.DgvEmp.TabIndex = 103
        '
        'TxtNombre
        '
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtNombre.Location = New System.Drawing.Point(27, 176)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(358, 25)
        Me.TxtNombre.TabIndex = 98
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(21, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 27)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Nombre del Empleado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 27)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Identidad"
        '
        'TxtIdentidad
        '
        Me.TxtIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdentidad.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtIdentidad.Location = New System.Drawing.Point(27, 92)
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.ReadOnly = True
        Me.TxtIdentidad.Size = New System.Drawing.Size(358, 25)
        Me.TxtIdentidad.TabIndex = 99
        '
        'DgvUsuarios
        '
        Me.DgvUsuarios.AllowUserToAddRows = False
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Dubai", 11.25!)
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black
        Me.DgvUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle27
        Me.DgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.DgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle28
        Me.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Dubai", 11.25!)
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvUsuarios.DefaultCellStyle = DataGridViewCellStyle29
        Me.DgvUsuarios.Location = New System.Drawing.Point(21, 42)
        Me.DgvUsuarios.Name = "DgvUsuarios"
        Me.DgvUsuarios.ReadOnly = True
        Me.DgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Dubai", 11.25!)
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black
        Me.DgvUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle30
        Me.DgvUsuarios.Size = New System.Drawing.Size(635, 286)
        Me.DgvUsuarios.TabIndex = 116
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvUsuarios)
        Me.GroupBox1.Font = New System.Drawing.Font("Dubai", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(82, 352)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 351)
        Me.GroupBox1.TabIndex = 106
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuarios"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(775, 364)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 27)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "ID / Usuario"
        '
        'TxtId
        '
        Me.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtId.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtId.Location = New System.Drawing.Point(780, 394)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ShortcutsEnabled = False
        Me.TxtId.Size = New System.Drawing.Size(275, 25)
        Me.TxtId.TabIndex = 128
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Dubai", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Location = New System.Drawing.Point(926, 597)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(129, 47)
        Me.BtnModificar.TabIndex = 127
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Dubai", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(780, 597)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(129, 47)
        Me.BtnGuardar.TabIndex = 126
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'RbAdmin
        '
        Me.RbAdmin.AutoSize = True
        Me.RbAdmin.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RbAdmin.ForeColor = System.Drawing.Color.White
        Me.RbAdmin.Location = New System.Drawing.Point(781, 556)
        Me.RbAdmin.Name = "RbAdmin"
        Me.RbAdmin.Size = New System.Drawing.Size(131, 31)
        Me.RbAdmin.TabIndex = 125
        Me.RbAdmin.TabStop = True
        Me.RbAdmin.Text = "Administrador"
        Me.RbAdmin.UseVisualStyleBackColor = True
        '
        'RbInvitado
        '
        Me.RbInvitado.AutoSize = True
        Me.RbInvitado.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RbInvitado.ForeColor = System.Drawing.Color.White
        Me.RbInvitado.Location = New System.Drawing.Point(935, 556)
        Me.RbInvitado.Name = "RbInvitado"
        Me.RbInvitado.Size = New System.Drawing.Size(88, 31)
        Me.RbInvitado.TabIndex = 124
        Me.RbInvitado.TabStop = True
        Me.RbInvitado.Text = "Invitado"
        Me.RbInvitado.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(775, 433)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 27)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Contraseña"
        '
        'TxtContraseña
        '
        Me.TxtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtContraseña.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtContraseña.Location = New System.Drawing.Point(780, 463)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.ShortcutsEnabled = False
        Me.TxtContraseña.Size = New System.Drawing.Size(275, 25)
        Me.TxtContraseña.TabIndex = 122
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Dubai", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(780, 656)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(274, 47)
        Me.BtnLimpiar.TabIndex = 121
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnCambiarContra
        '
        Me.BtnCambiarContra.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnCambiarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCambiarContra.Font = New System.Drawing.Font("Dubai", 12.75!, System.Drawing.FontStyle.Bold)
        Me.BtnCambiarContra.Location = New System.Drawing.Point(780, 504)
        Me.BtnCambiarContra.Name = "BtnCambiarContra"
        Me.BtnCambiarContra.Size = New System.Drawing.Size(274, 43)
        Me.BtnCambiarContra.TabIndex = 130
        Me.BtnCambiarContra.Text = "Cambiar Contraseña"
        Me.BtnCambiarContra.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtIdentidad)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TxtNombre)
        Me.GroupBox3.Font = New System.Drawing.Font("Dubai", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(638, 91)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(417, 244)
        Me.GroupBox3.TabIndex = 106
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información del Empleado"
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.Location = New System.Drawing.Point(18, 17)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(0, 13)
        Me.LblCodigo.TabIndex = 131
        Me.LblCodigo.Visible = False
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1160, 748)
        Me.Controls.Add(Me.BtnCambiarContra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.RbAdmin)
        Me.Controls.Add(Me.RbInvitado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents DgvEmp As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIdentidad As TextBox
    Friend WithEvents DgvUsuarios As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents RbAdmin As RadioButton
    Friend WithEvents RbInvitado As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnCambiarContra As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LblCodigo As Label
End Class
