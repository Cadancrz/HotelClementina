﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
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
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
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
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.DgvEmp)
        Me.GroupBox2.Font = New System.Drawing.Font("Dubai", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(105, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(515, 244)
        Me.GroupBox2.TabIndex = 90
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Búsqueda de Empleado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 27)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Nombre"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TextBox1.Location = New System.Drawing.Point(90, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ShortcutsEnabled = False
        Me.TextBox1.Size = New System.Drawing.Size(402, 25)
        Me.TextBox1.TabIndex = 104
        '
        'DgvEmp
        '
        Me.DgvEmp.AllowUserToAddRows = False
        Me.DgvEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEmp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvEmp.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.DgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmp.Location = New System.Drawing.Point(21, 82)
        Me.DgvEmp.Name = "DgvEmp"
        Me.DgvEmp.ReadOnly = True
        Me.DgvEmp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DgvEmp.Size = New System.Drawing.Size(471, 137)
        Me.DgvEmp.TabIndex = 103
        '
        'TxtNombre
        '
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtNombre.Location = New System.Drawing.Point(639, 251)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(416, 25)
        Me.TxtNombre.TabIndex = 98
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(634, 221)
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
        Me.Label2.Location = New System.Drawing.Point(634, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 27)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Identidad"
        '
        'TxtIdentidad
        '
        Me.TxtIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdentidad.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtIdentidad.Location = New System.Drawing.Point(639, 173)
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.ReadOnly = True
        Me.TxtIdentidad.Size = New System.Drawing.Size(416, 25)
        Me.TxtIdentidad.TabIndex = 99
        '
        'DgvUsuarios
        '
        Me.DgvUsuarios.AllowUserToAddRows = False
        Me.DgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUsuarios.Location = New System.Drawing.Point(21, 43)
        Me.DgvUsuarios.Name = "DgvUsuarios"
        Me.DgvUsuarios.ReadOnly = True
        Me.DgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DgvUsuarios.Size = New System.Drawing.Size(610, 286)
        Me.DgvUsuarios.TabIndex = 116
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvUsuarios)
        Me.GroupBox1.Font = New System.Drawing.Font("Dubai", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(105, 352)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(651, 359)
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
        Me.BtnModificar.Location = New System.Drawing.Point(926, 606)
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
        Me.BtnGuardar.Location = New System.Drawing.Point(780, 606)
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
        Me.RbAdmin.Location = New System.Drawing.Point(781, 560)
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
        Me.RbInvitado.Location = New System.Drawing.Point(935, 560)
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
        Me.Label4.Location = New System.Drawing.Point(776, 434)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 27)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Contraseña"
        '
        'TxtContraseña
        '
        Me.TxtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtContraseña.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtContraseña.Location = New System.Drawing.Point(781, 464)
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
        Me.BtnLimpiar.Location = New System.Drawing.Point(781, 664)
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
        Me.BtnCambiarContra.Location = New System.Drawing.Point(781, 505)
        Me.BtnCambiarContra.Name = "BtnCambiarContra"
        Me.BtnCambiarContra.Size = New System.Drawing.Size(274, 43)
        Me.BtnCambiarContra.TabIndex = 130
        Me.BtnCambiarContra.Text = "Cambiar Contraseña"
        Me.BtnCambiarContra.UseVisualStyleBackColor = False
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
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtIdentidad)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
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
End Class
