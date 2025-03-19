<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salon
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.CbAire = New System.Windows.Forms.CheckBox()
        Me.CbData = New System.Windows.Forms.CheckBox()
        Me.CbSonido = New System.Windows.Forms.CheckBox()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtHoras = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TxtFechaCancel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CbCancelar = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNomCancel = New System.Windows.Forms.TextBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.DtpFin = New System.Windows.Forms.DateTimePicker()
        Me.DtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DgvSalon = New System.Windows.Forms.DataGridView()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnFacturar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtDescuento = New System.Windows.Forms.TextBox()
        Me.CbDescuento = New System.Windows.Forms.CheckBox()
        Me.BtnReservar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvSalon, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(377, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(433, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SALÓN DE EVENTOS"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAgregar.Location = New System.Drawing.Point(528, 145)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(121, 38)
        Me.BtnAgregar.TabIndex = 149
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'CbAire
        '
        Me.CbAire.AutoSize = True
        Me.CbAire.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CbAire.ForeColor = System.Drawing.Color.White
        Me.CbAire.Location = New System.Drawing.Point(455, 150)
        Me.CbAire.Name = "CbAire"
        Me.CbAire.Size = New System.Drawing.Size(67, 31)
        Me.CbAire.TabIndex = 148
        Me.CbAire.Text = "A / C"
        Me.CbAire.UseVisualStyleBackColor = True
        '
        'CbData
        '
        Me.CbData.AutoSize = True
        Me.CbData.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CbData.ForeColor = System.Drawing.Color.White
        Me.CbData.Location = New System.Drawing.Point(325, 150)
        Me.CbData.Name = "CbData"
        Me.CbData.Size = New System.Drawing.Size(106, 31)
        Me.CbData.TabIndex = 147
        Me.CbData.Text = "Data Show"
        Me.CbData.UseVisualStyleBackColor = True
        '
        'CbSonido
        '
        Me.CbSonido.AutoSize = True
        Me.CbSonido.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CbSonido.ForeColor = System.Drawing.Color.White
        Me.CbSonido.Location = New System.Drawing.Point(227, 150)
        Me.CbSonido.Name = "CbSonido"
        Me.CbSonido.Size = New System.Drawing.Size(80, 31)
        Me.CbSonido.TabIndex = 146
        Me.CbSonido.Text = "Sonido"
        Me.CbSonido.UseVisualStyleBackColor = True
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtObservaciones.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtObservaciones.Location = New System.Drawing.Point(154, 195)
        Me.TxtObservaciones.MaxLength = 500
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(495, 128)
        Me.TxtObservaciones.TabIndex = 145
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 27)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "Observaciones"
        '
        'TxtHoras
        '
        Me.TxtHoras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHoras.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtHoras.Location = New System.Drawing.Point(154, 150)
        Me.TxtHoras.MaxLength = 3
        Me.TxtHoras.Multiline = True
        Me.TxtHoras.Name = "TxtHoras"
        Me.TxtHoras.ReadOnly = True
        Me.TxtHoras.Size = New System.Drawing.Size(53, 27)
        Me.TxtHoras.TabIndex = 143
        '
        'TxtNombre
        '
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtNombre.Location = New System.Drawing.Point(154, 109)
        Me.TxtNombre.MaxLength = 100
        Me.TxtNombre.Multiline = True
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(495, 27)
        Me.TxtNombre.TabIndex = 142
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 27)
        Me.Label3.TabIndex = 141
        Me.Label3.Text = "Cantidad Horas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 27)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "Nombre"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.TxtFechaCancel)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.CbCancelar)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtNomCancel)
        Me.GroupBox1.Location = New System.Drawing.Point(668, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 222)
        Me.GroupBox1.TabIndex = 150
        Me.GroupBox1.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancelar.Location = New System.Drawing.Point(357, 152)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(110, 38)
        Me.BtnCancelar.TabIndex = 154
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        Me.BtnCancelar.Visible = False
        '
        'TxtFechaCancel
        '
        Me.TxtFechaCancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFechaCancel.Enabled = False
        Me.TxtFechaCancel.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtFechaCancel.Location = New System.Drawing.Point(17, 163)
        Me.TxtFechaCancel.Multiline = True
        Me.TxtFechaCancel.Name = "TxtFechaCancel"
        Me.TxtFechaCancel.ShortcutsEnabled = False
        Me.TxtFechaCancel.Size = New System.Drawing.Size(330, 27)
        Me.TxtFechaCancel.TabIndex = 156
        Me.TxtFechaCancel.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 27)
        Me.Label9.TabIndex = 155
        Me.Label9.Text = "De la fecha:"
        Me.Label9.Visible = False
        '
        'CbCancelar
        '
        Me.CbCancelar.AutoSize = True
        Me.CbCancelar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CbCancelar.ForeColor = System.Drawing.Color.White
        Me.CbCancelar.Location = New System.Drawing.Point(17, 19)
        Me.CbCancelar.Name = "CbCancelar"
        Me.CbCancelar.Size = New System.Drawing.Size(128, 31)
        Me.CbCancelar.TabIndex = 151
        Me.CbCancelar.Text = "Cancelaciones"
        Me.CbCancelar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 27)
        Me.Label8.TabIndex = 153
        Me.Label8.Text = "Cancelar Reserva de:"
        Me.Label8.Visible = False
        '
        'TxtNomCancel
        '
        Me.TxtNomCancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNomCancel.Enabled = False
        Me.TxtNomCancel.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtNomCancel.Location = New System.Drawing.Point(17, 88)
        Me.TxtNomCancel.Multiline = True
        Me.TxtNomCancel.Name = "TxtNomCancel"
        Me.TxtNomCancel.ShortcutsEnabled = False
        Me.TxtNomCancel.Size = New System.Drawing.Size(330, 27)
        Me.TxtNomCancel.TabIndex = 152
        Me.TxtNomCancel.Visible = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(8, 528)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 151
        '
        'DtpFin
        '
        Me.DtpFin.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.DtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtpFin.Location = New System.Drawing.Point(73, 79)
        Me.DtpFin.Name = "DtpFin"
        Me.DtpFin.ShowUpDown = True
        Me.DtpFin.Size = New System.Drawing.Size(157, 25)
        Me.DtpFin.TabIndex = 157
        '
        'DtpInicio
        '
        Me.DtpInicio.CustomFormat = ""
        Me.DtpInicio.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.DtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtpInicio.Location = New System.Drawing.Point(73, 32)
        Me.DtpInicio.Name = "DtpInicio"
        Me.DtpInicio.ShowUpDown = True
        Me.DtpInicio.Size = New System.Drawing.Size(157, 25)
        Me.DtpInicio.TabIndex = 156
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(23, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 27)
        Me.Label11.TabIndex = 155
        Me.Label11.Text = "Fin"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(17, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 27)
        Me.Label10.TabIndex = 154
        Me.Label10.Text = "Inicio"
        '
        'TxtFecha
        '
        Me.TxtFecha.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtFecha.Location = New System.Drawing.Point(81, 482)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.ReadOnly = True
        Me.TxtFecha.Size = New System.Drawing.Size(157, 25)
        Me.TxtFecha.TabIndex = 153
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(23, 482)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 27)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Fecha"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DtpFin)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.DtpInicio)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Font = New System.Drawing.Font("Dubai", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(8, 339)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(248, 126)
        Me.GroupBox2.TabIndex = 158
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hora"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Dubai", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(268, 339)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(605, 67)
        Me.GroupBox3.TabIndex = 159
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Búsqueda"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(80, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 27)
        Me.Label6.TabIndex = 160
        Me.Label6.Text = "Por Nombre"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TextBox1.Location = New System.Drawing.Point(182, 26)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ShortcutsEnabled = False
        Me.TextBox1.Size = New System.Drawing.Size(403, 28)
        Me.TextBox1.TabIndex = 160
        '
        'DgvSalon
        '
        Me.DgvSalon.AllowUserToAddRows = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkKhaki
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DgvSalon.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvSalon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvSalon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvSalon.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkKhaki
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkKhaki
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvSalon.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvSalon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSalon.Location = New System.Drawing.Point(266, 418)
        Me.DgvSalon.Name = "DgvSalon"
        Me.DgvSalon.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkKhaki
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkKhaki
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvSalon.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvSalon.Size = New System.Drawing.Size(607, 272)
        Me.DgvSalon.TabIndex = 160
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLimpiar.Location = New System.Drawing.Point(1015, 589)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(127, 45)
        Me.BtnLimpiar.TabIndex = 171
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnModificar.Location = New System.Drawing.Point(881, 589)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(130, 45)
        Me.BtnModificar.TabIndex = 170
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnFacturar
        '
        Me.BtnFacturar.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFacturar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnFacturar.Location = New System.Drawing.Point(881, 639)
        Me.BtnFacturar.Name = "BtnFacturar"
        Me.BtnFacturar.Size = New System.Drawing.Size(261, 51)
        Me.BtnFacturar.TabIndex = 169
        Me.BtnFacturar.Text = "FACTURAR"
        Me.BtnFacturar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnActualizar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnActualizar.Location = New System.Drawing.Point(881, 539)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(130, 45)
        Me.BtnActualizar.TabIndex = 168
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'TxtTotal
        '
        Me.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtTotal.Location = New System.Drawing.Point(1015, 498)
        Me.TxtTotal.Multiline = True
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ShortcutsEnabled = False
        Me.TxtTotal.Size = New System.Drawing.Size(127, 29)
        Me.TxtTotal.TabIndex = 167
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSubTotal.Enabled = False
        Me.TxtSubTotal.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtSubTotal.Location = New System.Drawing.Point(1015, 415)
        Me.TxtSubTotal.Multiline = True
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.ShortcutsEnabled = False
        Me.TxtSubTotal.Size = New System.Drawing.Size(127, 28)
        Me.TxtSubTotal.TabIndex = 166
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(936, 500)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 27)
        Me.Label7.TabIndex = 165
        Me.Label7.Text = "TOTAL"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(918, 415)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 27)
        Me.Label12.TabIndex = 164
        Me.Label12.Text = "Sub Total"
        '
        'TxtDescuento
        '
        Me.TxtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescuento.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtDescuento.Location = New System.Drawing.Point(1015, 454)
        Me.TxtDescuento.Multiline = True
        Me.TxtDescuento.Name = "TxtDescuento"
        Me.TxtDescuento.ShortcutsEnabled = False
        Me.TxtDescuento.Size = New System.Drawing.Size(127, 29)
        Me.TxtDescuento.TabIndex = 163
        Me.TxtDescuento.Visible = False
        '
        'CbDescuento
        '
        Me.CbDescuento.AutoSize = True
        Me.CbDescuento.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CbDescuento.ForeColor = System.Drawing.Color.White
        Me.CbDescuento.Location = New System.Drawing.Point(900, 454)
        Me.CbDescuento.Name = "CbDescuento"
        Me.CbDescuento.Size = New System.Drawing.Size(105, 31)
        Me.CbDescuento.TabIndex = 162
        Me.CbDescuento.Text = "Descuento"
        Me.CbDescuento.UseVisualStyleBackColor = True
        '
        'BtnReservar
        '
        Me.BtnReservar.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReservar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnReservar.Location = New System.Drawing.Point(1015, 539)
        Me.BtnReservar.Name = "BtnReservar"
        Me.BtnReservar.Size = New System.Drawing.Size(127, 45)
        Me.BtnReservar.TabIndex = 161
        Me.BtnReservar.Text = "Reservar"
        Me.BtnReservar.UseVisualStyleBackColor = False
        '
        'Salon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1160, 748)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnFacturar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.TxtSubTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtDescuento)
        Me.Controls.Add(Me.CbDescuento)
        Me.Controls.Add(Me.BtnReservar)
        Me.Controls.Add(Me.DgvSalon)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.CbAire)
        Me.Controls.Add(Me.CbData)
        Me.Controls.Add(Me.CbSonido)
        Me.Controls.Add(Me.TxtObservaciones)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtHoras)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Salon"
        Me.Text = "Salon"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DgvSalon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents CbAire As CheckBox
    Friend WithEvents CbData As CheckBox
    Friend WithEvents CbSonido As CheckBox
    Friend WithEvents TxtObservaciones As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtHoras As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents TxtFechaCancel As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CbCancelar As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtNomCancel As TextBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents DtpFin As DateTimePicker
    Friend WithEvents DtpInicio As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtFecha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Public WithEvents DgvSalon As DataGridView
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnFacturar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtSubTotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtDescuento As TextBox
    Friend WithEvents CbDescuento As CheckBox
    Friend WithEvents BtnReservar As Button
End Class
