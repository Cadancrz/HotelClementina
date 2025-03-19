<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturacion
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblpleca1 = New System.Windows.Forms.Label()
        Me.LblAño = New System.Windows.Forms.Label()
        Me.LblMes = New System.Windows.Forms.Label()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblDia = New System.Windows.Forms.Label()
        Me.lblCodCli = New System.Windows.Forms.Label()
        Me.CheckBoxEmpresa = New System.Windows.Forms.CheckBox()
        Me.TxtEmpresa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBusCli = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtDias = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodFac = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtCodCli = New System.Windows.Forms.TextBox()
        Me.TxtCodRes = New System.Windows.Forms.TextBox()
        Me.CKBConTur = New System.Windows.Forms.CheckBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.CKBsinTur = New System.Windows.Forms.CheckBox()
        Me.DgvDetalle = New System.Windows.Forms.DataGridView()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtTot = New System.Windows.Forms.TextBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtNoches = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.TxtUnit = New System.Windows.Forms.TextBox()
        Me.TxtCnt = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtIsvTur = New System.Windows.Forms.TextBox()
        Me.RBEfectivo = New System.Windows.Forms.RadioButton()
        Me.RBTarjeta = New System.Windows.Forms.RadioButton()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNeto = New System.Windows.Forms.TextBox()
        Me.TxtISV = New System.Windows.Forms.TextBox()
        Me.TxtDet = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TxtCodCli)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtCodRes)
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
        Me.Label1.Location = New System.Drawing.Point(434, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FACTURACIÓN"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.lblpleca1)
        Me.GroupBox1.Controls.Add(Me.LblAño)
        Me.GroupBox1.Controls.Add(Me.LblMes)
        Me.GroupBox1.Controls.Add(Me.LblHora)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lblDia)
        Me.GroupBox1.Controls.Add(Me.lblCodCli)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtDias)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtCodFac)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtUsuario)
        Me.GroupBox1.Font = New System.Drawing.Font("Dubai", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(596, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 211)
        Me.GroupBox1.TabIndex = 124
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encabezado"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(199, 134)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 27)
        Me.Label16.TabIndex = 103
        Me.Label16.Text = "/"
        '
        'lblpleca1
        '
        Me.lblpleca1.AutoSize = True
        Me.lblpleca1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblpleca1.Location = New System.Drawing.Point(154, 134)
        Me.lblpleca1.Name = "lblpleca1"
        Me.lblpleca1.Size = New System.Drawing.Size(20, 27)
        Me.lblpleca1.TabIndex = 102
        Me.lblpleca1.Text = "/"
        '
        'LblAño
        '
        Me.LblAño.AutoSize = True
        Me.LblAño.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblAño.Location = New System.Drawing.Point(220, 134)
        Me.LblAño.Name = "LblAño"
        Me.LblAño.Size = New System.Drawing.Size(0, 27)
        Me.LblAño.TabIndex = 101
        '
        'LblMes
        '
        Me.LblMes.AutoSize = True
        Me.LblMes.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblMes.Location = New System.Drawing.Point(176, 134)
        Me.LblMes.Name = "LblMes"
        Me.LblMes.Size = New System.Drawing.Size(0, 27)
        Me.LblMes.TabIndex = 100
        '
        'LblHora
        '
        Me.LblHora.AutoSize = True
        Me.LblHora.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblHora.Location = New System.Drawing.Point(129, 171)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(0, 27)
        Me.LblHora.TabIndex = 99
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(39, 134)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 27)
        Me.Label14.TabIndex = 98
        Me.Label14.Text = "Fecha"
        '
        'lblDia
        '
        Me.lblDia.AutoSize = True
        Me.lblDia.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDia.Location = New System.Drawing.Point(519, 25)
        Me.lblDia.Name = "lblDia"
        Me.lblDia.Size = New System.Drawing.Size(0, 21)
        Me.lblDia.TabIndex = 96
        '
        'lblCodCli
        '
        Me.lblCodCli.AutoSize = True
        Me.lblCodCli.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCodCli.Location = New System.Drawing.Point(40, 171)
        Me.lblCodCli.Name = "lblCodCli"
        Me.lblCodCli.Size = New System.Drawing.Size(47, 27)
        Me.lblCodCli.TabIndex = 97
        Me.lblCodCli.Text = "Hora"
        '
        'CheckBoxEmpresa
        '
        Me.CheckBoxEmpresa.AutoSize = True
        Me.CheckBoxEmpresa.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CheckBoxEmpresa.Location = New System.Drawing.Point(24, 91)
        Me.CheckBoxEmpresa.Name = "CheckBoxEmpresa"
        Me.CheckBoxEmpresa.Size = New System.Drawing.Size(91, 31)
        Me.CheckBoxEmpresa.TabIndex = 91
        Me.CheckBoxEmpresa.TabStop = False
        Me.CheckBoxEmpresa.Text = "Empresa"
        Me.CheckBoxEmpresa.UseVisualStyleBackColor = True
        '
        'TxtEmpresa
        '
        Me.TxtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmpresa.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtEmpresa.Location = New System.Drawing.Point(113, 78)
        Me.TxtEmpresa.MaxLength = 88
        Me.TxtEmpresa.Multiline = True
        Me.TxtEmpresa.Name = "TxtEmpresa"
        Me.TxtEmpresa.Size = New System.Drawing.Size(372, 57)
        Me.TxtEmpresa.TabIndex = 1
        Me.TxtEmpresa.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(205, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 27)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "días"
        '
        'btnBusCli
        '
        Me.btnBusCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btnBusCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBusCli.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBusCli.ForeColor = System.Drawing.Color.Black
        Me.btnBusCli.Location = New System.Drawing.Point(358, 148)
        Me.btnBusCli.Name = "btnBusCli"
        Me.btnBusCli.Size = New System.Drawing.Size(127, 41)
        Me.btnBusCli.TabIndex = 81
        Me.btnBusCli.Text = "Buscar Cliente"
        Me.btnBusCli.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(34, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 27)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Estadía"
        '
        'TxtDias
        '
        Me.TxtDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDias.Enabled = False
        Me.TxtDias.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtDias.Location = New System.Drawing.Point(134, 95)
        Me.TxtDias.Name = "TxtDias"
        Me.TxtDias.ReadOnly = True
        Me.TxtDias.Size = New System.Drawing.Size(65, 25)
        Me.TxtDias.TabIndex = 78
        Me.TxtDias.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(21, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 27)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "No. Factura"
        '
        'TxtCodFac
        '
        Me.TxtCodFac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodFac.Enabled = False
        Me.TxtCodFac.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtCodFac.Location = New System.Drawing.Point(134, 61)
        Me.TxtCodFac.Name = "TxtCodFac"
        Me.TxtCodFac.ReadOnly = True
        Me.TxtCodFac.Size = New System.Drawing.Size(65, 25)
        Me.TxtCodFac.TabIndex = 53
        Me.TxtCodFac.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(34, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 27)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Usuario"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUsuario.Enabled = False
        Me.TxtUsuario.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtUsuario.Location = New System.Drawing.Point(134, 27)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.ReadOnly = True
        Me.TxtUsuario.Size = New System.Drawing.Size(391, 25)
        Me.TxtUsuario.TabIndex = 57
        Me.TxtUsuario.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(41, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 27)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Cliente"
        '
        'TxtCliente
        '
        Me.TxtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCliente.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtCliente.Location = New System.Drawing.Point(114, 40)
        Me.TxtCliente.MaxLength = 45
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.ReadOnly = True
        Me.TxtCliente.Size = New System.Drawing.Size(371, 25)
        Me.TxtCliente.TabIndex = 0
        Me.TxtCliente.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtEmpresa)
        Me.GroupBox3.Controls.Add(Me.TxtCliente)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.CheckBoxEmpresa)
        Me.GroupBox3.Controls.Add(Me.btnBusCli)
        Me.GroupBox3.Font = New System.Drawing.Font("Dubai", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(536, 211)
        Me.GroupBox3.TabIndex = 125
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Infomación del Cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.TxtDet)
        Me.GroupBox2.Controls.Add(Me.CKBConTur)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.CKBsinTur)
        Me.GroupBox2.Controls.Add(Me.DgvDetalle)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.TxtTot)
        Me.GroupBox2.Controls.Add(Me.BtnEliminar)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.TxtNoches)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.BtnIngresar)
        Me.GroupBox2.Controls.Add(Me.TxtUnit)
        Me.GroupBox2.Controls.Add(Me.TxtCnt)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.TxtIsvTur)
        Me.GroupBox2.Controls.Add(Me.TxtTotal)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.btnFacturar)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtNeto)
        Me.GroupBox2.Controls.Add(Me.TxtISV)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 297)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1136, 439)
        Me.GroupBox2.TabIndex = 126
        Me.GroupBox2.TabStop = False
        '
        'TxtCodCli
        '
        Me.TxtCodCli.Location = New System.Drawing.Point(1031, 32)
        Me.TxtCodCli.Name = "TxtCodCli"
        Me.TxtCodCli.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodCli.TabIndex = 137
        Me.TxtCodCli.TabStop = False
        Me.TxtCodCli.Visible = False
        '
        'TxtCodRes
        '
        Me.TxtCodRes.Location = New System.Drawing.Point(1031, 5)
        Me.TxtCodRes.Name = "TxtCodRes"
        Me.TxtCodRes.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodRes.TabIndex = 136
        Me.TxtCodRes.TabStop = False
        Me.TxtCodRes.Visible = False
        '
        'CKBConTur
        '
        Me.CKBConTur.AutoSize = True
        Me.CKBConTur.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CKBConTur.ForeColor = System.Drawing.Color.White
        Me.CKBConTur.Location = New System.Drawing.Point(170, 19)
        Me.CKBConTur.Name = "CKBConTur"
        Me.CKBConTur.Size = New System.Drawing.Size(148, 31)
        Me.CKBConTur.TabIndex = 185
        Me.CKBConTur.Text = "Con ISV Turismo"
        Me.CKBConTur.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(27, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(123, 27)
        Me.Label24.TabIndex = 184
        Me.Label24.Text = "Tipo de Factura:"
        '
        'CKBsinTur
        '
        Me.CKBsinTur.AutoSize = True
        Me.CKBsinTur.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CKBsinTur.ForeColor = System.Drawing.Color.White
        Me.CKBsinTur.Location = New System.Drawing.Point(342, 19)
        Me.CKBsinTur.Name = "CKBsinTur"
        Me.CKBsinTur.Size = New System.Drawing.Size(143, 31)
        Me.CKBsinTur.TabIndex = 183
        Me.CKBsinTur.Text = "Sin ISV Turismo"
        Me.CKBsinTur.UseVisualStyleBackColor = True
        '
        'DgvDetalle
        '
        Me.DgvDetalle.AllowUserToAddRows = False
        Me.DgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.DgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Papyrus", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalle.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvDetalle.DefaultCellStyle = DataGridViewCellStyle14
        Me.DgvDetalle.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.DgvDetalle.Location = New System.Drawing.Point(18, 193)
        Me.DgvDetalle.Name = "DgvDetalle"
        Me.DgvDetalle.ReadOnly = True
        Me.DgvDetalle.Size = New System.Drawing.Size(899, 225)
        Me.DgvDetalle.TabIndex = 182
        Me.DgvDetalle.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(695, 60)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 27)
        Me.Label23.TabIndex = 181
        Me.Label23.Text = "TOTAL"
        Me.Label23.Visible = False
        '
        'TxtTot
        '
        Me.TxtTot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTot.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtTot.Location = New System.Drawing.Point(697, 90)
        Me.TxtTot.Name = "TxtTot"
        Me.TxtTot.Size = New System.Drawing.Size(59, 25)
        Me.TxtTot.TabIndex = 180
        Me.TxtTot.Visible = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEliminar.Location = New System.Drawing.Point(770, 139)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(147, 40)
        Me.BtnEliminar.TabIndex = 164
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(575, 60)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(110, 27)
        Me.Label22.TabIndex = 179
        Me.Label22.Text = "Precio Unitaio"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(498, 60)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 27)
        Me.Label21.TabIndex = 178
        Me.Label21.Text = "Noches"
        '
        'TxtNoches
        '
        Me.TxtNoches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNoches.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtNoches.Location = New System.Drawing.Point(500, 90)
        Me.TxtNoches.MaxLength = 2
        Me.TxtNoches.Name = "TxtNoches"
        Me.TxtNoches.Size = New System.Drawing.Size(61, 25)
        Me.TxtNoches.TabIndex = 161
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(257, 60)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 27)
        Me.Label20.TabIndex = 177
        Me.Label20.Text = "Detalle"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(12, 60)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 27)
        Me.Label19.TabIndex = 176
        Me.Label19.Text = "Cantidad"
        '
        'BtnIngresar
        '
        Me.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIngresar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnIngresar.Location = New System.Drawing.Point(770, 90)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(147, 40)
        Me.BtnIngresar.TabIndex = 163
        Me.BtnIngresar.Text = "Agregar"
        Me.BtnIngresar.UseVisualStyleBackColor = False
        '
        'TxtUnit
        '
        Me.TxtUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUnit.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtUnit.Location = New System.Drawing.Point(599, 90)
        Me.TxtUnit.MaxLength = 6
        Me.TxtUnit.Name = "TxtUnit"
        Me.TxtUnit.Size = New System.Drawing.Size(59, 25)
        Me.TxtUnit.TabIndex = 162
        '
        'TxtCnt
        '
        Me.TxtCnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCnt.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtCnt.Location = New System.Drawing.Point(18, 90)
        Me.TxtCnt.MaxLength = 3
        Me.TxtCnt.Name = "TxtCnt"
        Me.TxtCnt.Size = New System.Drawing.Size(60, 25)
        Me.TxtCnt.TabIndex = 159
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(939, 157)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 27)
        Me.Label17.TabIndex = 175
        Me.Label17.Text = "4 %"
        '
        'TxtIsvTur
        '
        Me.TxtIsvTur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIsvTur.Enabled = False
        Me.TxtIsvTur.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtIsvTur.Location = New System.Drawing.Point(1013, 157)
        Me.TxtIsvTur.Name = "TxtIsvTur"
        Me.TxtIsvTur.Size = New System.Drawing.Size(96, 25)
        Me.TxtIsvTur.TabIndex = 174
        Me.TxtIsvTur.TabStop = False
        Me.TxtIsvTur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RBEfectivo
        '
        Me.RBEfectivo.AutoSize = True
        Me.RBEfectivo.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RBEfectivo.ForeColor = System.Drawing.Color.White
        Me.RBEfectivo.Location = New System.Drawing.Point(8, 75)
        Me.RBEfectivo.Name = "RBEfectivo"
        Me.RBEfectivo.Size = New System.Drawing.Size(86, 31)
        Me.RBEfectivo.TabIndex = 173
        Me.RBEfectivo.Text = "Efectivo"
        Me.RBEfectivo.UseVisualStyleBackColor = True
        '
        'RBTarjeta
        '
        Me.RBTarjeta.AutoSize = True
        Me.RBTarjeta.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RBTarjeta.ForeColor = System.Drawing.Color.White
        Me.RBTarjeta.Location = New System.Drawing.Point(8, 34)
        Me.RBTarjeta.Name = "RBTarjeta"
        Me.RBTarjeta.Size = New System.Drawing.Size(155, 31)
        Me.RBTarjeta.TabIndex = 172
        Me.RBTarjeta.Text = "Tarjeta de Credito"
        Me.RBTarjeta.UseVisualStyleBackColor = True
        '
        'TxtTotal
        '
        Me.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtTotal.Location = New System.Drawing.Point(1013, 193)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(96, 25)
        Me.TxtTotal.TabIndex = 171
        Me.TxtTotal.TabStop = False
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(931, 191)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 27)
        Me.Label15.TabIndex = 170
        Me.Label15.Text = "TOTAL"
        '
        'btnFacturar
        '
        Me.btnFacturar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacturar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnFacturar.Location = New System.Drawing.Point(935, 372)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(174, 46)
        Me.btnFacturar.TabIndex = 169
        Me.btnFacturar.Text = "FACTURAR"
        Me.btnFacturar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(931, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 27)
        Me.Label11.TabIndex = 168
        Me.Label11.Text = "15 %"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(933, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 27)
        Me.Label8.TabIndex = 167
        Me.Label8.Text = "Neto"
        '
        'TxtNeto
        '
        Me.TxtNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNeto.Enabled = False
        Me.TxtNeto.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtNeto.Location = New System.Drawing.Point(1013, 88)
        Me.TxtNeto.Name = "TxtNeto"
        Me.TxtNeto.Size = New System.Drawing.Size(96, 25)
        Me.TxtNeto.TabIndex = 166
        Me.TxtNeto.TabStop = False
        Me.TxtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtISV
        '
        Me.TxtISV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtISV.Enabled = False
        Me.TxtISV.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtISV.Location = New System.Drawing.Point(1013, 122)
        Me.TxtISV.Name = "TxtISV"
        Me.TxtISV.Size = New System.Drawing.Size(96, 25)
        Me.TxtISV.TabIndex = 165
        Me.TxtISV.TabStop = False
        Me.TxtISV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDet
        '
        Me.TxtDet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDet.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtDet.Location = New System.Drawing.Point(91, 90)
        Me.TxtDet.MaxLength = 88
        Me.TxtDet.Multiline = True
        Me.TxtDet.Name = "TxtDet"
        Me.TxtDet.Size = New System.Drawing.Size(394, 95)
        Me.TxtDet.TabIndex = 92
        Me.TxtDet.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RBTarjeta)
        Me.GroupBox4.Controls.Add(Me.RBEfectivo)
        Me.GroupBox4.Font = New System.Drawing.Font("Dubai", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(936, 233)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(173, 123)
        Me.GroupBox4.TabIndex = 186
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo de Pago"
        '
        'Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1160, 748)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Facturacion"
        Me.Text = "Facturacion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents lblpleca1 As Label
    Friend WithEvents LblAño As Label
    Friend WithEvents LblMes As Label
    Friend WithEvents LblHora As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblDia As Label
    Friend WithEvents lblCodCli As Label
    Friend WithEvents CheckBoxEmpresa As CheckBox
    Friend WithEvents TxtEmpresa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBusCli As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtDias As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCodFac As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtCodCli As TextBox
    Friend WithEvents TxtCodRes As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CKBConTur As CheckBox
    Friend WithEvents Label24 As Label
    Friend WithEvents CKBsinTur As CheckBox
    Friend WithEvents DgvDetalle As DataGridView
    Friend WithEvents Label23 As Label
    Friend WithEvents TxtTot As TextBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtNoches As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents TxtUnit As TextBox
    Friend WithEvents TxtCnt As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtIsvTur As TextBox
    Friend WithEvents RBEfectivo As RadioButton
    Friend WithEvents RBTarjeta As RadioButton
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnFacturar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtNeto As TextBox
    Friend WithEvents TxtISV As TextBox
    Friend WithEvents TxtDet As TextBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
