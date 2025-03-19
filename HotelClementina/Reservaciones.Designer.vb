<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reservaciones
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgbHabDisponibles = New System.Windows.Forms.DataGridView()
        Me.TxtHabitacion = New System.Windows.Forms.TextBox()
        Me.CmbHabitacion = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GBDisp = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.LblRestaFechaFin = New System.Windows.Forms.Label()
        Me.LblPrecioTotal = New System.Windows.Forms.Label()
        Me.LblPrecioDia = New System.Windows.Forms.Label()
        Me.LblDias = New System.Windows.Forms.Label()
        Me.TxtFin = New System.Windows.Forms.TextBox()
        Me.TxtInicio = New System.Windows.Forms.TextBox()
        Me.BtnConsultarDispon = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.BtnReservar = New System.Windows.Forms.Button()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.DGVClientes = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgbHabDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBDisp.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1136, 58)
        Me.Panel1.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(397, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RESERVACIONES"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgbHabDisponibles)
        Me.GroupBox1.Controls.Add(Me.TxtHabitacion)
        Me.GroupBox1.Controls.Add(Me.CmbHabitacion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Font = New System.Drawing.Font("Dubai", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(601, 121)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Disponibilidad"
        '
        'DgbHabDisponibles
        '
        Me.DgbHabDisponibles.AllowUserToAddRows = False
        Me.DgbHabDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgbHabDisponibles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgbHabDisponibles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.DgbHabDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgbHabDisponibles.Location = New System.Drawing.Point(330, 24)
        Me.DgbHabDisponibles.Name = "DgbHabDisponibles"
        Me.DgbHabDisponibles.ReadOnly = True
        Me.DgbHabDisponibles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgbHabDisponibles.Size = New System.Drawing.Size(248, 85)
        Me.DgbHabDisponibles.TabIndex = 108
        '
        'TxtHabitacion
        '
        Me.TxtHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHabitacion.Enabled = False
        Me.TxtHabitacion.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHabitacion.Location = New System.Drawing.Point(187, 78)
        Me.TxtHabitacion.Name = "TxtHabitacion"
        Me.TxtHabitacion.ReadOnly = True
        Me.TxtHabitacion.Size = New System.Drawing.Size(124, 25)
        Me.TxtHabitacion.TabIndex = 105
        '
        'CmbHabitacion
        '
        Me.CmbHabitacion.DisplayMember = "Tipo_Hab"
        Me.CmbHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbHabitacion.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbHabitacion.FormattingEnabled = True
        Me.CmbHabitacion.Location = New System.Drawing.Point(187, 33)
        Me.CmbHabitacion.Name = "CmbHabitacion"
        Me.CmbHabitacion.Size = New System.Drawing.Size(124, 27)
        Me.CmbHabitacion.TabIndex = 104
        Me.CmbHabitacion.ValueMember = "Cod_Tipo_Hab"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 27)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Tipo de Habitacion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(25, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 27)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Habitacion Asignada"
        '
        'GBDisp
        '
        Me.GBDisp.BackColor = System.Drawing.Color.Transparent
        Me.GBDisp.Controls.Add(Me.MonthCalendar2)
        Me.GBDisp.Controls.Add(Me.LblRestaFechaFin)
        Me.GBDisp.Controls.Add(Me.LblPrecioTotal)
        Me.GBDisp.Controls.Add(Me.LblPrecioDia)
        Me.GBDisp.Controls.Add(Me.LblDias)
        Me.GBDisp.Controls.Add(Me.TxtFin)
        Me.GBDisp.Controls.Add(Me.TxtInicio)
        Me.GBDisp.Controls.Add(Me.BtnConsultarDispon)
        Me.GBDisp.Controls.Add(Me.Label3)
        Me.GBDisp.Controls.Add(Me.Label2)
        Me.GBDisp.Controls.Add(Me.MonthCalendar1)
        Me.GBDisp.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBDisp.ForeColor = System.Drawing.Color.White
        Me.GBDisp.Location = New System.Drawing.Point(12, 237)
        Me.GBDisp.Name = "GBDisp"
        Me.GBDisp.Size = New System.Drawing.Size(601, 311)
        Me.GBDisp.TabIndex = 80
        Me.GBDisp.TabStop = False
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar2.Location = New System.Drawing.Point(330, 72)
        Me.MonthCalendar2.MinDate = New Date(2015, 6, 21, 0, 0, 0, 0)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 12
        '
        'LblRestaFechaFin
        '
        Me.LblRestaFechaFin.AutoSize = True
        Me.LblRestaFechaFin.Location = New System.Drawing.Point(661, 236)
        Me.LblRestaFechaFin.Name = "LblRestaFechaFin"
        Me.LblRestaFechaFin.Size = New System.Drawing.Size(0, 30)
        Me.LblRestaFechaFin.TabIndex = 96
        Me.LblRestaFechaFin.Visible = False
        '
        'LblPrecioTotal
        '
        Me.LblPrecioTotal.AutoSize = True
        Me.LblPrecioTotal.Location = New System.Drawing.Point(694, 188)
        Me.LblPrecioTotal.Name = "LblPrecioTotal"
        Me.LblPrecioTotal.Size = New System.Drawing.Size(0, 30)
        Me.LblPrecioTotal.TabIndex = 95
        Me.LblPrecioTotal.Visible = False
        '
        'LblPrecioDia
        '
        Me.LblPrecioDia.AutoSize = True
        Me.LblPrecioDia.Location = New System.Drawing.Point(694, 135)
        Me.LblPrecioDia.Name = "LblPrecioDia"
        Me.LblPrecioDia.Size = New System.Drawing.Size(0, 30)
        Me.LblPrecioDia.TabIndex = 94
        Me.LblPrecioDia.Visible = False
        '
        'LblDias
        '
        Me.LblDias.AutoSize = True
        Me.LblDias.Location = New System.Drawing.Point(689, 26)
        Me.LblDias.Name = "LblDias"
        Me.LblDias.Size = New System.Drawing.Size(0, 30)
        Me.LblDias.TabIndex = 93
        Me.LblDias.Visible = False
        '
        'TxtFin
        '
        Me.TxtFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFin.Enabled = False
        Me.TxtFin.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFin.Location = New System.Drawing.Point(329, 245)
        Me.TxtFin.Multiline = True
        Me.TxtFin.Name = "TxtFin"
        Me.TxtFin.ReadOnly = True
        Me.TxtFin.Size = New System.Drawing.Size(121, 25)
        Me.TxtFin.TabIndex = 89
        '
        'TxtInicio
        '
        Me.TxtInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtInicio.Enabled = False
        Me.TxtInicio.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInicio.Location = New System.Drawing.Point(30, 244)
        Me.TxtInicio.Multiline = True
        Me.TxtInicio.Name = "TxtInicio"
        Me.TxtInicio.ReadOnly = True
        Me.TxtInicio.Size = New System.Drawing.Size(121, 25)
        Me.TxtInicio.TabIndex = 88
        '
        'BtnConsultarDispon
        '
        Me.BtnConsultarDispon.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnConsultarDispon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultarDispon.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultarDispon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnConsultarDispon.Location = New System.Drawing.Point(457, 239)
        Me.BtnConsultarDispon.Name = "BtnConsultarDispon"
        Me.BtnConsultarDispon.Size = New System.Drawing.Size(121, 37)
        Me.BtnConsultarDispon.TabIndex = 87
        Me.BtnConsultarDispon.Text = "Consultar"
        Me.BtnConsultarDispon.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(324, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 32)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Fecha de Salida"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 32)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Fecha de Entrada"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(30, 72)
        Me.MonthCalendar1.MinDate = New Date(2015, 6, 25, 0, 0, 0, 0)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 9
        '
        'BtnReservar
        '
        Me.BtnReservar.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReservar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReservar.Location = New System.Drawing.Point(495, 554)
        Me.BtnReservar.Name = "BtnReservar"
        Me.BtnReservar.Size = New System.Drawing.Size(118, 37)
        Me.BtnReservar.TabIndex = 88
        Me.BtnReservar.Text = "Reservar"
        Me.BtnReservar.UseVisualStyleBackColor = False
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRestaurar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRestaurar.Location = New System.Drawing.Point(377, 554)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(112, 37)
        Me.BtnRestaurar.TabIndex = 87
        Me.BtnRestaurar.Text = "Restaurar"
        Me.BtnRestaurar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Dubai", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(633, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(515, 80)
        Me.GroupBox2.TabIndex = 89
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Búsquedas de Clientes"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(33, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 27)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "Nombre"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TextBox1.Location = New System.Drawing.Point(107, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ShortcutsEnabled = False
        Me.TextBox1.Size = New System.Drawing.Size(389, 25)
        Me.TextBox1.TabIndex = 99
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox3.Controls.Add(Me.TxtNombre)
        Me.GroupBox3.Controls.Add(Me.DGVClientes)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtIdentidad)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Dubai", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(633, 239)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(515, 309)
        Me.GroupBox3.TabIndex = 101
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Infomación del Cliente"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.Black
        Me.BtnLimpiar.Location = New System.Drawing.Point(378, 257)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(118, 37)
        Me.BtnLimpiar.TabIndex = 107
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'TxtNombre
        '
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtNombre.Location = New System.Drawing.Point(119, 34)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(377, 25)
        Me.TxtNombre.TabIndex = 105
        '
        'DGVClientes
        '
        Me.DGVClientes.AllowUserToAddRows = False
        Me.DGVClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVClientes.Location = New System.Drawing.Point(17, 110)
        Me.DGVClientes.Name = "DGVClientes"
        Me.DGVClientes.ReadOnly = True
        Me.DGVClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGVClientes.Size = New System.Drawing.Size(479, 141)
        Me.DGVClientes.TabIndex = 102
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(30, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 27)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Nombre"
        '
        'TxtIdentidad
        '
        Me.TxtIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdentidad.Enabled = False
        Me.TxtIdentidad.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtIdentidad.Location = New System.Drawing.Point(119, 70)
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.ReadOnly = True
        Me.TxtIdentidad.Size = New System.Drawing.Size(377, 25)
        Me.TxtIdentidad.TabIndex = 106
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(30, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 27)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "Identidad"
        '
        'Reservaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1160, 748)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnReservar)
        Me.Controls.Add(Me.BtnRestaurar)
        Me.Controls.Add(Me.GBDisp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reservaciones"
        Me.Text = "Reservaciones"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgbHabDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBDisp.ResumeLayout(False)
        Me.GBDisp.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgbHabDisponibles As DataGridView
    Friend WithEvents TxtHabitacion As TextBox
    Friend WithEvents CmbHabitacion As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GBDisp As GroupBox
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents LblRestaFechaFin As Label
    Friend WithEvents LblPrecioTotal As Label
    Friend WithEvents LblPrecioDia As Label
    Friend WithEvents LblDias As Label
    Friend WithEvents TxtFin As TextBox
    Friend WithEvents TxtInicio As TextBox
    Friend WithEvents BtnConsultarDispon As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents BtnReservar As Button
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents DGVClientes As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtIdentidad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnLimpiar As Button
End Class
