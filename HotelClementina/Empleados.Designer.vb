﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSeguro = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtSueldo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmbSexo = New System.Windows.Forms.ComboBox()
        Me.CmbCargo = New System.Windows.Forms.ComboBox()
        Me.CmbFchNacim = New System.Windows.Forms.DateTimePicker()
        Me.CkHabDes = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CmbFchIniEmp = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtCorEmp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTelEmp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodEmp = New System.Windows.Forms.TextBox()
        Me.txtDirEmp = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNomEmp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBusEmp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtApeEmp = New System.Windows.Forms.TextBox()
        Me.ErrorProviderCorreo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderCorreo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1136, 58)
        Me.Panel1.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(433, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMPLEADOS"
        '
        'TxtSeguro
        '
        Me.TxtSeguro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSeguro.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtSeguro.Location = New System.Drawing.Point(600, 284)
        Me.TxtSeguro.MaxLength = 15
        Me.TxtSeguro.Name = "TxtSeguro"
        Me.TxtSeguro.ShortcutsEnabled = False
        Me.TxtSeguro.Size = New System.Drawing.Size(298, 25)
        Me.TxtSeguro.TabIndex = 126
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(485, 285)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 27)
        Me.Label11.TabIndex = 125
        Me.Label11.Text = "Seguro"
        '
        'TxtSueldo
        '
        Me.TxtSueldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSueldo.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtSueldo.Location = New System.Drawing.Point(600, 246)
        Me.TxtSueldo.MaxLength = 15
        Me.TxtSueldo.Name = "TxtSueldo"
        Me.TxtSueldo.ShortcutsEnabled = False
        Me.TxtSueldo.Size = New System.Drawing.Size(298, 25)
        Me.TxtSueldo.TabIndex = 124
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(486, 246)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 27)
        Me.Label10.TabIndex = 123
        Me.Label10.Text = "Sueldo"
        '
        'CmbSexo
        '
        Me.CmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSexo.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.CmbSexo.FormattingEnabled = True
        Me.CmbSexo.Items.AddRange(New Object() {"M", "F"})
        Me.CmbSexo.Location = New System.Drawing.Point(105, 203)
        Me.CmbSexo.Name = "CmbSexo"
        Me.CmbSexo.Size = New System.Drawing.Size(298, 27)
        Me.CmbSexo.TabIndex = 122
        '
        'CmbCargo
        '
        Me.CmbCargo.DisplayMember = "Tipo_Cargo"
        Me.CmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCargo.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.CmbCargo.FormattingEnabled = True
        Me.CmbCargo.Location = New System.Drawing.Point(105, 321)
        Me.CmbCargo.Name = "CmbCargo"
        Me.CmbCargo.Size = New System.Drawing.Size(298, 27)
        Me.CmbCargo.TabIndex = 121
        Me.CmbCargo.ValueMember = "Cod_Cargo"
        '
        'CmbFchNacim
        '
        Me.CmbFchNacim.CustomFormat = "yyyy-MM-dd"
        Me.CmbFchNacim.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.CmbFchNacim.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CmbFchNacim.Location = New System.Drawing.Point(600, 88)
        Me.CmbFchNacim.Name = "CmbFchNacim"
        Me.CmbFchNacim.Size = New System.Drawing.Size(141, 25)
        Me.CmbFchNacim.TabIndex = 120
        '
        'CkHabDes
        '
        Me.CkHabDes.AutoSize = True
        Me.CkHabDes.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CkHabDes.ForeColor = System.Drawing.Color.White
        Me.CkHabDes.Location = New System.Drawing.Point(600, 321)
        Me.CkHabDes.Name = "CkHabDes"
        Me.CkHabDes.Size = New System.Drawing.Size(187, 31)
        Me.CkHabDes.TabIndex = 119
        Me.CkHabDes.Text = "Habilitado/Desabilitar"
        Me.CkHabDes.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(12, 321)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 27)
        Me.Label14.TabIndex = 118
        Me.Label14.Text = "Cargo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 27)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "Sexo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(462, 203)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 27)
        Me.Label13.TabIndex = 116
        Me.Label13.Text = "Feha de Inicio"
        '
        'CmbFchIniEmp
        '
        Me.CmbFchIniEmp.CustomFormat = "yyyy-MM-dd"
        Me.CmbFchIniEmp.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.CmbFchIniEmp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CmbFchIniEmp.Location = New System.Drawing.Point(600, 203)
        Me.CmbFchIniEmp.Name = "CmbFchIniEmp"
        Me.CmbFchIniEmp.Size = New System.Drawing.Size(298, 25)
        Me.CmbFchIniEmp.TabIndex = 115
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(12, 282)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 27)
        Me.Label12.TabIndex = 113
        Me.Label12.Text = "Correo"
        '
        'TxtCorEmp
        '
        Me.TxtCorEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCorEmp.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtCorEmp.Location = New System.Drawing.Point(105, 282)
        Me.TxtCorEmp.MaxLength = 50
        Me.TxtCorEmp.Name = "TxtCorEmp"
        Me.TxtCorEmp.ShortcutsEnabled = False
        Me.TxtCorEmp.Size = New System.Drawing.Size(298, 25)
        Me.TxtCorEmp.TabIndex = 114
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(451, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 27)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "Fecha Nacimiento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 27)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Identidad"
        '
        'txtTelEmp
        '
        Me.txtTelEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelEmp.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.txtTelEmp.Location = New System.Drawing.Point(105, 244)
        Me.txtTelEmp.MaxLength = 15
        Me.txtTelEmp.Name = "txtTelEmp"
        Me.txtTelEmp.ShortcutsEnabled = False
        Me.txtTelEmp.Size = New System.Drawing.Size(298, 25)
        Me.txtTelEmp.TabIndex = 111
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 27)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Teléfono"
        '
        'txtCodEmp
        '
        Me.txtCodEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodEmp.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.txtCodEmp.Location = New System.Drawing.Point(105, 86)
        Me.txtCodEmp.MaxLength = 20
        Me.txtCodEmp.Name = "txtCodEmp"
        Me.txtCodEmp.ShortcutsEnabled = False
        Me.txtCodEmp.Size = New System.Drawing.Size(298, 25)
        Me.txtCodEmp.TabIndex = 107
        '
        'txtDirEmp
        '
        Me.txtDirEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDirEmp.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.txtDirEmp.Location = New System.Drawing.Point(600, 124)
        Me.txtDirEmp.MaxLength = 200
        Me.txtDirEmp.Multiline = True
        Me.txtDirEmp.Name = "txtDirEmp"
        Me.txtDirEmp.Size = New System.Drawing.Size(298, 64)
        Me.txtDirEmp.TabIndex = 110
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(477, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 27)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Dirección"
        '
        'txtNomEmp
        '
        Me.txtNomEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomEmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomEmp.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.txtNomEmp.Location = New System.Drawing.Point(105, 125)
        Me.txtNomEmp.MaxLength = 30
        Me.txtNomEmp.Name = "txtNomEmp"
        Me.txtNomEmp.ShortcutsEnabled = False
        Me.txtNomEmp.Size = New System.Drawing.Size(298, 25)
        Me.txtNomEmp.TabIndex = 108
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 27)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBusEmp)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Dubai", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(17, 370)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1131, 62)
        Me.GroupBox2.TabIndex = 127
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Búsquedas"
        '
        'txtBusEmp
        '
        Me.txtBusEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBusEmp.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.txtBusEmp.Location = New System.Drawing.Point(180, 24)
        Me.txtBusEmp.Multiline = True
        Me.txtBusEmp.Name = "txtBusEmp"
        Me.txtBusEmp.ShortcutsEnabled = False
        Me.txtBusEmp.Size = New System.Drawing.Size(622, 27)
        Me.txtBusEmp.TabIndex = 128
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(106, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 27)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Nombre"
        '
        'DgvEmpleados
        '
        Me.DgvEmpleados.AllowUserToAddRows = False
        Me.DgvEmpleados.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Dubai", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DgvEmpleados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.DgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Dubai", 11.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvEmpleados.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvEmpleados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvEmpleados.GridColor = System.Drawing.Color.Black
        Me.DgvEmpleados.Location = New System.Drawing.Point(17, 441)
        Me.DgvEmpleados.Name = "DgvEmpleados"
        Me.DgvEmpleados.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Dubai", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEmpleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Dubai", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.DgvEmpleados.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEmpleados.Size = New System.Drawing.Size(1131, 295)
        Me.DgvEmpleados.TabIndex = 128
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Location = New System.Drawing.Point(966, 90)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(182, 49)
        Me.btnGuardar.TabIndex = 133
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.Location = New System.Drawing.Point(966, 146)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(182, 49)
        Me.btnModificar.TabIndex = 132
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimpiar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpiar.Location = New System.Drawing.Point(966, 259)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(182, 49)
        Me.btnLimpiar.TabIndex = 131
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEliminar.ForeColor = System.Drawing.Color.Black
        Me.BtnEliminar.Location = New System.Drawing.Point(966, 202)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(182, 49)
        Me.BtnEliminar.TabIndex = 134
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 27)
        Me.Label9.TabIndex = 135
        Me.Label9.Text = "Apellido"
        '
        'txtApeEmp
        '
        Me.txtApeEmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApeEmp.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.txtApeEmp.Location = New System.Drawing.Point(105, 164)
        Me.txtApeEmp.MaxLength = 30
        Me.txtApeEmp.Name = "txtApeEmp"
        Me.txtApeEmp.ShortcutsEnabled = False
        Me.txtApeEmp.Size = New System.Drawing.Size(298, 25)
        Me.txtApeEmp.TabIndex = 136
        '
        'ErrorProviderCorreo
        '
        Me.ErrorProviderCorreo.ContainerControl = Me
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(783, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 27)
        Me.Label15.TabIndex = 137
        Me.Label15.Text = "Edad"
        '
        'TxtEdad
        '
        Me.TxtEdad.Enabled = False
        Me.TxtEdad.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtEdad.Location = New System.Drawing.Point(836, 89)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(62, 25)
        Me.TxtEdad.TabIndex = 138
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1160, 748)
        Me.Controls.Add(Me.TxtEdad)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtApeEmp)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.DgvEmpleados)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TxtSeguro)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtSueldo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CmbSexo)
        Me.Controls.Add(Me.CmbCargo)
        Me.Controls.Add(Me.CmbFchNacim)
        Me.Controls.Add(Me.CkHabDes)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.CmbFchIniEmp)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtCorEmp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTelEmp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCodEmp)
        Me.Controls.Add(Me.txtDirEmp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNomEmp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Empleados"
        Me.Text = "Empleados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderCorreo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSeguro As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtSueldo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CmbSexo As ComboBox
    Friend WithEvents CmbCargo As ComboBox
    Friend WithEvents CmbFchNacim As DateTimePicker
    Friend WithEvents CkHabDes As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents CmbFchIniEmp As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtCorEmp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTelEmp As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCodEmp As TextBox
    Friend WithEvents txtDirEmp As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNomEmp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBusEmp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DgvEmpleados As DataGridView
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtApeEmp As TextBox
    Friend WithEvents ErrorProviderCorreo As ErrorProvider
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents Label15 As Label
End Class
