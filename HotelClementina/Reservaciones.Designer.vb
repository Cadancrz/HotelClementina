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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtHabitacion = New System.Windows.Forms.TextBox()
        Me.CmbHabitacion = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GBDisp = New System.Windows.Forms.GroupBox()
        Me.Lblhorafecha = New System.Windows.Forms.Label()
        Me.MCSalida = New System.Windows.Forms.MonthCalendar()
        Me.LblRestaFechaFin = New System.Windows.Forms.Label()
        Me.LblPrecioTotal = New System.Windows.Forms.Label()
        Me.LblPrecioDia = New System.Windows.Forms.Label()
        Me.LblDias = New System.Windows.Forms.Label()
        Me.TxtSalida = New System.Windows.Forms.TextBox()
        Me.TxtEntrada = New System.Windows.Forms.TextBox()
        Me.BtnConsultarDispon = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MCEntrada = New System.Windows.Forms.MonthCalendar()
        Me.BtnReservar = New System.Windows.Forms.Button()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.DGVClientes = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBDisp.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.TxtHabitacion)
        Me.GroupBox1.Controls.Add(Me.CmbHabitacion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(513, 121)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Disponibilidad"
        '
        'TxtHabitacion
        '
        Me.TxtHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHabitacion.Enabled = False
        Me.TxtHabitacion.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHabitacion.Location = New System.Drawing.Point(202, 73)
        Me.TxtHabitacion.Name = "TxtHabitacion"
        Me.TxtHabitacion.ReadOnly = True
        Me.TxtHabitacion.Size = New System.Drawing.Size(52, 25)
        Me.TxtHabitacion.TabIndex = 105
        '
        'CmbHabitacion
        '
        Me.CmbHabitacion.DisplayMember = "Tipo_Hab"
        Me.CmbHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbHabitacion.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbHabitacion.FormattingEnabled = True
        Me.CmbHabitacion.Location = New System.Drawing.Point(202, 30)
        Me.CmbHabitacion.Name = "CmbHabitacion"
        Me.CmbHabitacion.Size = New System.Drawing.Size(185, 27)
        Me.CmbHabitacion.TabIndex = 104
        Me.CmbHabitacion.ValueMember = "Cod_Tipo_Hab"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 20)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Tipo de Habitacion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(25, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(175, 20)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Habitacion Asignada"
        '
        'GBDisp
        '
        Me.GBDisp.BackColor = System.Drawing.Color.Transparent
        Me.GBDisp.Controls.Add(Me.Lblhorafecha)
        Me.GBDisp.Controls.Add(Me.MCSalida)
        Me.GBDisp.Controls.Add(Me.LblRestaFechaFin)
        Me.GBDisp.Controls.Add(Me.LblPrecioTotal)
        Me.GBDisp.Controls.Add(Me.LblPrecioDia)
        Me.GBDisp.Controls.Add(Me.LblDias)
        Me.GBDisp.Controls.Add(Me.TxtSalida)
        Me.GBDisp.Controls.Add(Me.TxtEntrada)
        Me.GBDisp.Controls.Add(Me.BtnConsultarDispon)
        Me.GBDisp.Controls.Add(Me.Label3)
        Me.GBDisp.Controls.Add(Me.Label2)
        Me.GBDisp.Controls.Add(Me.MCEntrada)
        Me.GBDisp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBDisp.ForeColor = System.Drawing.Color.White
        Me.GBDisp.Location = New System.Drawing.Point(12, 227)
        Me.GBDisp.Name = "GBDisp"
        Me.GBDisp.Size = New System.Drawing.Size(513, 427)
        Me.GBDisp.TabIndex = 80
        Me.GBDisp.TabStop = False
        '
        'Lblhorafecha
        '
        Me.Lblhorafecha.AutoSize = True
        Me.Lblhorafecha.Font = New System.Drawing.Font("Segoe Print", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblhorafecha.ForeColor = System.Drawing.Color.White
        Me.Lblhorafecha.Location = New System.Drawing.Point(7, 367)
        Me.Lblhorafecha.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Lblhorafecha.Name = "Lblhorafecha"
        Me.Lblhorafecha.Size = New System.Drawing.Size(190, 44)
        Me.Lblhorafecha.TabIndex = 97
        Me.Lblhorafecha.Text = "Bienvenido(a)"
        '
        'MCSalida
        '
        Me.MCSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MCSalida.Location = New System.Drawing.Point(259, 98)
        Me.MCSalida.MinDate = New Date(2015, 6, 21, 0, 0, 0, 0)
        Me.MCSalida.Name = "MCSalida"
        Me.MCSalida.TabIndex = 12
        '
        'LblRestaFechaFin
        '
        Me.LblRestaFechaFin.AutoSize = True
        Me.LblRestaFechaFin.Location = New System.Drawing.Point(661, 236)
        Me.LblRestaFechaFin.Name = "LblRestaFechaFin"
        Me.LblRestaFechaFin.Size = New System.Drawing.Size(0, 24)
        Me.LblRestaFechaFin.TabIndex = 96
        Me.LblRestaFechaFin.Visible = False
        '
        'LblPrecioTotal
        '
        Me.LblPrecioTotal.AutoSize = True
        Me.LblPrecioTotal.Location = New System.Drawing.Point(694, 188)
        Me.LblPrecioTotal.Name = "LblPrecioTotal"
        Me.LblPrecioTotal.Size = New System.Drawing.Size(0, 24)
        Me.LblPrecioTotal.TabIndex = 95
        Me.LblPrecioTotal.Visible = False
        '
        'LblPrecioDia
        '
        Me.LblPrecioDia.AutoSize = True
        Me.LblPrecioDia.Location = New System.Drawing.Point(694, 135)
        Me.LblPrecioDia.Name = "LblPrecioDia"
        Me.LblPrecioDia.Size = New System.Drawing.Size(0, 24)
        Me.LblPrecioDia.TabIndex = 94
        Me.LblPrecioDia.Visible = False
        '
        'LblDias
        '
        Me.LblDias.AutoSize = True
        Me.LblDias.Location = New System.Drawing.Point(689, 26)
        Me.LblDias.Name = "LblDias"
        Me.LblDias.Size = New System.Drawing.Size(0, 24)
        Me.LblDias.TabIndex = 93
        Me.LblDias.Visible = False
        '
        'TxtSalida
        '
        Me.TxtSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSalida.Enabled = False
        Me.TxtSalida.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSalida.Location = New System.Drawing.Point(259, 270)
        Me.TxtSalida.Multiline = True
        Me.TxtSalida.Name = "TxtSalida"
        Me.TxtSalida.ReadOnly = True
        Me.TxtSalida.Size = New System.Drawing.Size(192, 25)
        Me.TxtSalida.TabIndex = 89
        '
        'TxtEntrada
        '
        Me.TxtEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEntrada.Enabled = False
        Me.TxtEntrada.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEntrada.Location = New System.Drawing.Point(7, 270)
        Me.TxtEntrada.Multiline = True
        Me.TxtEntrada.Name = "TxtEntrada"
        Me.TxtEntrada.ReadOnly = True
        Me.TxtEntrada.Size = New System.Drawing.Size(190, 25)
        Me.TxtEntrada.TabIndex = 88
        '
        'BtnConsultarDispon
        '
        Me.BtnConsultarDispon.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnConsultarDispon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultarDispon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultarDispon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnConsultarDispon.Location = New System.Drawing.Point(375, 374)
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
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(257, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 24)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Fecha de Salida"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Fecha de Entrada"
        '
        'MCEntrada
        '
        Me.MCEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MCEntrada.Location = New System.Drawing.Point(7, 98)
        Me.MCEntrada.MinDate = New Date(2015, 6, 25, 0, 0, 0, 0)
        Me.MCEntrada.Name = "MCEntrada"
        Me.MCEntrada.TabIndex = 9
        '
        'BtnReservar
        '
        Me.BtnReservar.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReservar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReservar.Location = New System.Drawing.Point(130, 660)
        Me.BtnReservar.Name = "BtnReservar"
        Me.BtnReservar.Size = New System.Drawing.Size(118, 37)
        Me.BtnReservar.TabIndex = 88
        Me.BtnReservar.Text = "Reservar"
        Me.BtnReservar.UseVisualStyleBackColor = False
        Me.BtnReservar.Visible = False
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRestaurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRestaurar.Location = New System.Drawing.Point(12, 660)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(112, 37)
        Me.BtnRestaurar.TabIndex = 87
        Me.BtnRestaurar.Text = "Restaurar"
        Me.BtnRestaurar.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox3.Controls.Add(Me.TxtNombre)
        Me.GroupBox3.Controls.Add(Me.DGVClientes)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtIdentidad)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(531, 97)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(618, 557)
        Me.GroupBox3.TabIndex = 101
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Infomación del Cliente"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.Black
        Me.BtnLimpiar.Location = New System.Drawing.Point(489, 504)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(118, 37)
        Me.BtnLimpiar.TabIndex = 107
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'TxtNombre
        '
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtNombre.Location = New System.Drawing.Point(119, 34)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(450, 25)
        Me.TxtNombre.TabIndex = 105
        '
        'DGVClientes
        '
        Me.DGVClientes.AllowUserToAddRows = False
        Me.DGVClientes.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DGVClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Dubai", 11.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVClientes.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVClientes.Location = New System.Drawing.Point(10, 114)
        Me.DGVClientes.Name = "DGVClientes"
        Me.DGVClientes.ReadOnly = True
        Me.DGVClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGVClientes.Size = New System.Drawing.Size(597, 384)
        Me.DGVClientes.TabIndex = 102
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(44, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 20)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Nombre"
        '
        'TxtIdentidad
        '
        Me.TxtIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdentidad.Enabled = False
        Me.TxtIdentidad.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtIdentidad.Location = New System.Drawing.Point(119, 78)
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.ReadOnly = True
        Me.TxtIdentidad.Size = New System.Drawing.Size(450, 25)
        Me.TxtIdentidad.TabIndex = 106
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(30, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 20)
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
        Me.GBDisp.ResumeLayout(False)
        Me.GBDisp.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtHabitacion As TextBox
    Friend WithEvents CmbHabitacion As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GBDisp As GroupBox
    Friend WithEvents MCSalida As MonthCalendar
    Friend WithEvents LblRestaFechaFin As Label
    Friend WithEvents LblPrecioTotal As Label
    Friend WithEvents LblPrecioDia As Label
    Friend WithEvents LblDias As Label
    Friend WithEvents TxtSalida As TextBox
    Friend WithEvents TxtEntrada As TextBox
    Friend WithEvents BtnConsultarDispon As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MCEntrada As MonthCalendar
    Friend WithEvents BtnReservar As Button
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents DGVClientes As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtIdentidad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents Lblhorafecha As Label
End Class
