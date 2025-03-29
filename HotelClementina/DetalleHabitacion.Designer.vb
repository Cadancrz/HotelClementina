<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalleHabitacion
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
        Me.LblCodigoRec = New System.Windows.Forms.Label()
        Me.LblCodRes = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtTipoHabi = New System.Windows.Forms.TextBox()
        Me.DtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnRecargo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtRecargoAplicado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtRecargo = New System.Windows.Forms.TextBox()
        Me.TxtInicio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtFin = New System.Windows.Forms.TextBox()
        Me.TxtPrecioTotal = New System.Windows.Forms.TextBox()
        Me.TxtPrecioHabi = New System.Windows.Forms.TextBox()
        Me.BtnDescuento = New System.Windows.Forms.Button()
        Me.TxtDescuento = New System.Windows.Forms.TextBox()
        Me.TxtDescuentoAplicado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnBorrarRecargo = New System.Windows.Forms.Button()
        Me.DgvRecargos = New System.Windows.Forms.DataGridView()
        Me.BtnAplicarRecargo = New System.Windows.Forms.Button()
        Me.CmbRecargo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtPrecioRecargo = New System.Windows.Forms.TextBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvRecargos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LblCodigoRec)
        Me.Panel1.Controls.Add(Me.LblCodRes)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1136, 58)
        Me.Panel1.TabIndex = 33
        '
        'LblCodigoRec
        '
        Me.LblCodigoRec.AutoSize = True
        Me.LblCodigoRec.Location = New System.Drawing.Point(124, 9)
        Me.LblCodigoRec.Name = "LblCodigoRec"
        Me.LblCodigoRec.Size = New System.Drawing.Size(0, 13)
        Me.LblCodigoRec.TabIndex = 115
        Me.LblCodigoRec.Visible = False
        '
        'LblCodRes
        '
        Me.LblCodRes.AutoSize = True
        Me.LblCodRes.Location = New System.Drawing.Point(23, 9)
        Me.LblCodRes.Name = "LblCodRes"
        Me.LblCodRes.Size = New System.Drawing.Size(0, 13)
        Me.LblCodRes.TabIndex = 114
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(268, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(608, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DETALLE DE LA HABITACIÓN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TxtTipoHabi)
        Me.GroupBox1.Controls.Add(Me.DtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BtnRecargo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtRecargoAplicado)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.TxtRecargo)
        Me.GroupBox1.Controls.Add(Me.TxtInicio)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TxtFin)
        Me.GroupBox1.Controls.Add(Me.TxtPrecioTotal)
        Me.GroupBox1.Controls.Add(Me.TxtPrecioHabi)
        Me.GroupBox1.Controls.Add(Me.BtnDescuento)
        Me.GroupBox1.Controls.Add(Me.TxtDescuento)
        Me.GroupBox1.Controls.Add(Me.TxtDescuentoAplicado)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Dubai", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(13, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 551)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Dubai", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(191, 432)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 22)
        Me.Label14.TabIndex = 146
        Me.Label14.Text = "Label14"
        '
        'TxtTipoHabi
        '
        Me.TxtTipoHabi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTipoHabi.Enabled = False
        Me.TxtTipoHabi.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtTipoHabi.Location = New System.Drawing.Point(195, 100)
        Me.TxtTipoHabi.Name = "TxtTipoHabi"
        Me.TxtTipoHabi.ReadOnly = True
        Me.TxtTipoHabi.Size = New System.Drawing.Size(134, 25)
        Me.TxtTipoHabi.TabIndex = 131
        '
        'DtpFechaFin
        '
        Me.DtpFechaFin.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFin.Location = New System.Drawing.Point(195, 200)
        Me.DtpFechaFin.Name = "DtpFechaFin"
        Me.DtpFechaFin.Size = New System.Drawing.Size(134, 25)
        Me.DtpFechaFin.TabIndex = 145
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(13, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 27)
        Me.Label8.TabIndex = 123
        Me.Label8.Text = "Precio de la habitación"
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnModificar.ForeColor = System.Drawing.Color.Black
        Me.BtnModificar.Location = New System.Drawing.Point(25, 499)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(304, 36)
        Me.BtnModificar.TabIndex = 144
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(36, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 27)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Tipo de Habitacion"
        '
        'BtnRecargo
        '
        Me.BtnRecargo.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnRecargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRecargo.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnRecargo.ForeColor = System.Drawing.Color.Black
        Me.BtnRecargo.Location = New System.Drawing.Point(183, 457)
        Me.BtnRecargo.Name = "BtnRecargo"
        Me.BtnRecargo.Size = New System.Drawing.Size(146, 36)
        Me.BtnRecargo.TabIndex = 143
        Me.BtnRecargo.Text = "Aplicar Recargo"
        Me.BtnRecargo.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(13, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 27)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "Nombre del Huesped"
        '
        'TxtRecargoAplicado
        '
        Me.TxtRecargoAplicado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRecargoAplicado.Enabled = False
        Me.TxtRecargoAplicado.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtRecargoAplicado.Location = New System.Drawing.Point(195, 365)
        Me.TxtRecargoAplicado.Name = "TxtRecargoAplicado"
        Me.TxtRecargoAplicado.ReadOnly = True
        Me.TxtRecargoAplicado.Size = New System.Drawing.Size(134, 25)
        Me.TxtRecargoAplicado.TabIndex = 142
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(48, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 27)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Fecha de Entrada"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(48, 364)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 27)
        Me.Label12.TabIndex = 141
        Me.Label12.Text = "Recargo Aplicado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(59, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 27)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "Fecha de Salida"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(112, 332)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 27)
        Me.Label13.TabIndex = 139
        Me.Label13.Text = "Recargo"
        '
        'TxtNombre
        '
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtNombre.Location = New System.Drawing.Point(18, 66)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(311, 25)
        Me.TxtNombre.TabIndex = 127
        '
        'TxtRecargo
        '
        Me.TxtRecargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRecargo.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtRecargo.Location = New System.Drawing.Point(195, 332)
        Me.TxtRecargo.Name = "TxtRecargo"
        Me.TxtRecargo.ShortcutsEnabled = False
        Me.TxtRecargo.Size = New System.Drawing.Size(134, 25)
        Me.TxtRecargo.TabIndex = 140
        '
        'TxtInicio
        '
        Me.TxtInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtInicio.Enabled = False
        Me.TxtInicio.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtInicio.Location = New System.Drawing.Point(195, 133)
        Me.TxtInicio.Name = "TxtInicio"
        Me.TxtInicio.ReadOnly = True
        Me.TxtInicio.Size = New System.Drawing.Size(134, 25)
        Me.TxtInicio.TabIndex = 128
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(75, 397)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 27)
        Me.Label11.TabIndex = 138
        Me.Label11.Text = "Total Estadia"
        '
        'TxtFin
        '
        Me.TxtFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFin.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtFin.Location = New System.Drawing.Point(195, 166)
        Me.TxtFin.Name = "TxtFin"
        Me.TxtFin.ReadOnly = True
        Me.TxtFin.Size = New System.Drawing.Size(134, 25)
        Me.TxtFin.TabIndex = 129
        '
        'TxtPrecioTotal
        '
        Me.TxtPrecioTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrecioTotal.Enabled = False
        Me.TxtPrecioTotal.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtPrecioTotal.Location = New System.Drawing.Point(195, 398)
        Me.TxtPrecioTotal.Name = "TxtPrecioTotal"
        Me.TxtPrecioTotal.ReadOnly = True
        Me.TxtPrecioTotal.Size = New System.Drawing.Size(134, 25)
        Me.TxtPrecioTotal.TabIndex = 137
        '
        'TxtPrecioHabi
        '
        Me.TxtPrecioHabi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrecioHabi.Enabled = False
        Me.TxtPrecioHabi.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtPrecioHabi.Location = New System.Drawing.Point(195, 233)
        Me.TxtPrecioHabi.Name = "TxtPrecioHabi"
        Me.TxtPrecioHabi.ReadOnly = True
        Me.TxtPrecioHabi.Size = New System.Drawing.Size(134, 25)
        Me.TxtPrecioHabi.TabIndex = 130
        '
        'BtnDescuento
        '
        Me.BtnDescuento.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDescuento.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnDescuento.ForeColor = System.Drawing.Color.Black
        Me.BtnDescuento.Location = New System.Drawing.Point(25, 457)
        Me.BtnDescuento.Name = "BtnDescuento"
        Me.BtnDescuento.Size = New System.Drawing.Size(155, 36)
        Me.BtnDescuento.TabIndex = 136
        Me.BtnDescuento.Text = "Aplicar Descuento"
        Me.BtnDescuento.UseVisualStyleBackColor = False
        '
        'TxtDescuento
        '
        Me.TxtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescuento.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtDescuento.Location = New System.Drawing.Point(195, 266)
        Me.TxtDescuento.Name = "TxtDescuento"
        Me.TxtDescuento.ShortcutsEnabled = False
        Me.TxtDescuento.Size = New System.Drawing.Size(134, 25)
        Me.TxtDescuento.TabIndex = 132
        '
        'TxtDescuentoAplicado
        '
        Me.TxtDescuentoAplicado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescuentoAplicado.Enabled = False
        Me.TxtDescuentoAplicado.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtDescuentoAplicado.Location = New System.Drawing.Point(195, 299)
        Me.TxtDescuentoAplicado.Name = "TxtDescuentoAplicado"
        Me.TxtDescuentoAplicado.ReadOnly = True
        Me.TxtDescuentoAplicado.Size = New System.Drawing.Size(134, 25)
        Me.TxtDescuentoAplicado.TabIndex = 135
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(96, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 27)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "Descuento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(29, 299)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 27)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "Descuento Aplicado"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnBorrarRecargo)
        Me.GroupBox2.Controls.Add(Me.DgvRecargos)
        Me.GroupBox2.Controls.Add(Me.BtnAplicarRecargo)
        Me.GroupBox2.Controls.Add(Me.CmbRecargo)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioRecargo)
        Me.GroupBox2.Controls.Add(Me.TxtCantidad)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Dubai", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(386, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(315, 391)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recargos"
        '
        'BtnBorrarRecargo
        '
        Me.BtnBorrarRecargo.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnBorrarRecargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBorrarRecargo.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBorrarRecargo.ForeColor = System.Drawing.Color.Black
        Me.BtnBorrarRecargo.Location = New System.Drawing.Point(158, 332)
        Me.BtnBorrarRecargo.Name = "BtnBorrarRecargo"
        Me.BtnBorrarRecargo.Size = New System.Drawing.Size(133, 41)
        Me.BtnBorrarRecargo.TabIndex = 120
        Me.BtnBorrarRecargo.Text = "Borrar Recargo"
        Me.BtnBorrarRecargo.UseVisualStyleBackColor = False
        '
        'DgvRecargos
        '
        Me.DgvRecargos.AllowUserToAddRows = False
        Me.DgvRecargos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvRecargos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.DgvRecargos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvRecargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRecargos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DgvRecargos.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.DgvRecargos.Location = New System.Drawing.Point(20, 176)
        Me.DgvRecargos.Name = "DgvRecargos"
        Me.DgvRecargos.ReadOnly = True
        Me.DgvRecargos.Size = New System.Drawing.Size(271, 150)
        Me.DgvRecargos.TabIndex = 110
        '
        'BtnAplicarRecargo
        '
        Me.BtnAplicarRecargo.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAplicarRecargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAplicarRecargo.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAplicarRecargo.ForeColor = System.Drawing.Color.Black
        Me.BtnAplicarRecargo.Location = New System.Drawing.Point(20, 332)
        Me.BtnAplicarRecargo.Name = "BtnAplicarRecargo"
        Me.BtnAplicarRecargo.Size = New System.Drawing.Size(132, 41)
        Me.BtnAplicarRecargo.TabIndex = 119
        Me.BtnAplicarRecargo.Text = "Aplicar Recargo"
        Me.BtnAplicarRecargo.UseVisualStyleBackColor = False
        '
        'CmbRecargo
        '
        Me.CmbRecargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRecargo.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.CmbRecargo.FormattingEnabled = True
        Me.CmbRecargo.Items.AddRange(New Object() {"Refresco/Agua", "Cerveza Nacional", "Cerveza Extrangera", "Persona Adicional", "Desayuno", "Lavanderia", "Otros"})
        Me.CmbRecargo.Location = New System.Drawing.Point(20, 66)
        Me.CmbRecargo.Name = "CmbRecargo"
        Me.CmbRecargo.Size = New System.Drawing.Size(271, 27)
        Me.CmbRecargo.TabIndex = 115
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(15, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 27)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "Recargo"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(34, 135)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 27)
        Me.Label15.TabIndex = 112
        Me.Label15.Text = "Precio"
        '
        'TxtPrecioRecargo
        '
        Me.TxtPrecioRecargo.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtPrecioRecargo.Location = New System.Drawing.Point(95, 135)
        Me.TxtPrecioRecargo.Name = "TxtPrecioRecargo"
        Me.TxtPrecioRecargo.ShortcutsEnabled = False
        Me.TxtPrecioRecargo.Size = New System.Drawing.Size(196, 25)
        Me.TxtPrecioRecargo.TabIndex = 114
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtCantidad.Location = New System.Drawing.Point(95, 102)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.ShortcutsEnabled = False
        Me.TxtCantidad.Size = New System.Drawing.Size(196, 25)
        Me.TxtCantidad.TabIndex = 113
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(15, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 27)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "Cantidad"
        '
        'DetalleHabitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1160, 748)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DetalleHabitacion"
        Me.Text = "DetalleHabitacion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvRecargos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblCodRes As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtTipoHabi As TextBox
    Friend WithEvents DtpFechaFin As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnModificar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnRecargo As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtRecargoAplicado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtRecargo As TextBox
    Friend WithEvents TxtInicio As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtFin As TextBox
    Friend WithEvents TxtPrecioTotal As TextBox
    Friend WithEvents TxtPrecioHabi As TextBox
    Friend WithEvents BtnDescuento As Button
    Friend WithEvents TxtDescuento As TextBox
    Friend WithEvents TxtDescuentoAplicado As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvRecargos As DataGridView
    Friend WithEvents CmbRecargo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtPrecioRecargo As TextBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LblCodigoRec As Label
    Friend WithEvents BtnBorrarRecargo As Button
    Friend WithEvents BtnAplicarRecargo As Button
End Class
