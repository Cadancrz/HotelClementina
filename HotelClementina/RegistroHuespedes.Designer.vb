<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroHuespedes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroHuespedes))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbTipoCliente = New System.Windows.Forms.ComboBox()
        Me.TxtTel2 = New System.Windows.Forms.TextBox()
        Me.TxtTel1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnEmpresa = New System.Windows.Forms.Button()
        Me.TxtEmpresa = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtProcedencia = New System.Windows.Forms.TextBox()
        Me.CmbNacion = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DgvHuespedes = New System.Windows.Forms.DataGridView()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblContador = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvHuespedes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1136, 58)
        Me.Panel1.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(441, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HUÉSPEDES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 27)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Tipo de Cliente"
        Me.Label2.Visible = False
        '
        'CmbTipoCliente
        '
        Me.CmbTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipoCliente.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.CmbTipoCliente.FormattingEnabled = True
        Me.CmbTipoCliente.Items.AddRange(New Object() {"Credito", "Contado"})
        Me.CmbTipoCliente.Location = New System.Drawing.Point(129, 275)
        Me.CmbTipoCliente.Name = "CmbTipoCliente"
        Me.CmbTipoCliente.Size = New System.Drawing.Size(295, 27)
        Me.CmbTipoCliente.TabIndex = 129
        Me.CmbTipoCliente.Visible = False
        '
        'TxtTel2
        '
        Me.TxtTel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTel2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtTel2.Location = New System.Drawing.Point(129, 228)
        Me.TxtTel2.MaxLength = 20
        Me.TxtTel2.Name = "TxtTel2"
        Me.TxtTel2.ShortcutsEnabled = False
        Me.TxtTel2.Size = New System.Drawing.Size(295, 25)
        Me.TxtTel2.TabIndex = 122
        '
        'TxtTel1
        '
        Me.TxtTel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTel1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtTel1.Location = New System.Drawing.Point(129, 186)
        Me.TxtTel1.MaxLength = 20
        Me.TxtTel1.Name = "TxtTel1"
        Me.TxtTel1.ShortcutsEnabled = False
        Me.TxtTel1.Size = New System.Drawing.Size(295, 25)
        Me.TxtTel1.TabIndex = 121
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 27)
        Me.Label6.TabIndex = 127
        Me.Label6.Text = "Teléfono 1"
        '
        'TxtNombres
        '
        Me.TxtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombres.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtNombres.Location = New System.Drawing.Point(129, 142)
        Me.TxtNombres.MaxLength = 50
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.ShortcutsEnabled = False
        Me.TxtNombres.Size = New System.Drawing.Size(295, 25)
        Me.TxtNombres.TabIndex = 120
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 27)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Nombre"
        '
        'TxtIdentidad
        '
        Me.TxtIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdentidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtIdentidad.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtIdentidad.Location = New System.Drawing.Point(129, 96)
        Me.TxtIdentidad.MaxLength = 25
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.ShortcutsEnabled = False
        Me.TxtIdentidad.Size = New System.Drawing.Size(295, 25)
        Me.TxtIdentidad.TabIndex = 119
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 27)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "Identidad"
        '
        'BtnEmpresa
        '
        Me.BtnEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmpresa.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEmpresa.Location = New System.Drawing.Point(512, 17)
        Me.BtnEmpresa.Name = "BtnEmpresa"
        Me.BtnEmpresa.Size = New System.Drawing.Size(141, 41)
        Me.BtnEmpresa.TabIndex = 133
        Me.BtnEmpresa.Text = "Agregar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnEmpresa.UseVisualStyleBackColor = False
        '
        'TxtEmpresa
        '
        Me.TxtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEmpresa.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtEmpresa.Location = New System.Drawing.Point(115, 15)
        Me.TxtEmpresa.MaxLength = 100
        Me.TxtEmpresa.Multiline = True
        Me.TxtEmpresa.Name = "TxtEmpresa"
        Me.TxtEmpresa.Size = New System.Drawing.Size(328, 46)
        Me.TxtEmpresa.TabIndex = 131
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(25, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 27)
        Me.Label8.TabIndex = 132
        Me.Label8.Text = "Empresa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(470, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 27)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "Procedencia"
        '
        'TxtProcedencia
        '
        Me.TxtProcedencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProcedencia.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtProcedencia.Location = New System.Drawing.Point(590, 140)
        Me.TxtProcedencia.MaxLength = 40
        Me.TxtProcedencia.Name = "TxtProcedencia"
        Me.TxtProcedencia.Size = New System.Drawing.Size(328, 25)
        Me.TxtProcedencia.TabIndex = 138
        '
        'CmbNacion
        '
        Me.CmbNacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbNacion.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.CmbNacion.FormattingEnabled = True
        Me.CmbNacion.Items.AddRange(New Object() {"Afganistán", "Akrotiri", "Albania", "Alemania", "Andorra", "Angola", "Anguila", "Antártida", "Antigua y Barbuda", "Antillas Neerlandesas", "Arabia Saudí", "Arctic Ocean", "Argelia", "Argentina", "Armenia", "Aruba", "Ashmore andCartier Islands", "Atlantic Ocean", "Australia", "Austria", "Azerbaiyán", "Bahamas", "Bahráin", "Bangladesh", "Barbados", "Bélgica", "Belice", "Benín", "Bermudas", "Bielorrusia", "Birmania Myanmar", "Bolivia", "Bosnia y Hercegovina", "Botsuana", "Brasil", "Brunéi", "Bulgaria", "Burkina Faso", "Burundi", "Bután", "Cabo Verde", "Camboya", "Camerún", "Canadá", "Chad", "Chile", "China", "Chipre", "Clipperton Island", "Colombia", "Comoras", "Congo", "Coral Sea Islands", "Corea del Norte", "Corea del Sur", "Costa de Marfil", "Costa Rica", "Croacia", "Cuba", "Dhekelia", "Dinamarca", "Dominica", "Ecuador", "Egipto", "El Salvador", "El Vaticano", "Emiratos Árabes Unidos", "Eritrea", "Eslovaquia", "Eslovenia", "España", "Estados Unidos", "Estonia", "Etiopía", "Filipinas", "Finlandia", "Fiyi", "Francia", "Gabón", "Gambia", "Gaza Strip", "Georgia", "Ghana", "Gibraltar", "Granada", "Grecia", "Groenlandia", "Guam", "Guatemala", "Guernsey", "Guinea", "Guinea Ecuatorial", "Guinea-Bissau", "Guyana", "Haití", "Honduras", "Hong Kong", "Hungría", "India", "Indian Ocean", "Indonesia", "Irán", "Iraq", "Irlanda", "Isla Bouvet", "Isla Christmas", "Isla Norfolk", "Islandia", "Islas Caimán", "Islas Cocos", "Islas Cook", "Islas Feroe", "Islas Georgia del Sur y Sandwich del Sur", "Islas Heard y McDonald", "Islas Malvinas", "Islas Marianas del Norte", "IslasMarshall", "Islas Pitcairn", "Islas Salomón", "Islas Turcas y Caicos", "Islas Vírgenes Americanas", "Islas Vírgenes Británicas", "Israel", "Italia", "Jamaica", "Jan Mayen", "Japón", "Jersey", "Jordania", "Kazajistán", "Kenia", "Kirguizistán", "Kiribati", "Kuwait", "Laos", "Lesoto", "Letonia", "Líbano", "Liberia", "Libia", "Liechtenstein", "Lituania", "Luxemburgo", "Macao", "Macedonia", "Madagascar", "Malasia", "Malaui", "Maldivas", "Malí", "Malta", "Man, Isle of", "Marruecos", "Mauricio", "Mauritania", "Mayotte", "México", "Micronesia", "Moldavia", "Mónaco", "Mongolia", "Montserrat", "Mozambique", "Namibia", "Nauru", "Navassa Island", "Nepal", "Nicaragua", "Níger", "Nigeria", "Niue", "Noruega", "Nueva Caledonia", "Nueva Zelanda", "Omán", "Pacific Ocean", "Países Bajos", "Pakistán", "Palaos", "Panamá", "Papúa-Nueva Guinea", "Paracel Islands", "Paraguay", "Perú", "Polinesia Francesa", "Polonia", "Portugal", "Puerto Rico", "Qatar", "Reino Unido", "República Centroafricana", "República Checa", "República Democrática del Congo", "República Dominicana", "Ruanda", "Rumania", "Rusia", "Sáhara Occidental", "Samoa", "Samoa Americana", "San Cristóbal y Nieves", "San Marino", "San Pedro y Miquelón", "San Vicente y las Granadinas", "Santa Helena", "Santa Lucía", "Santo Tomé y Príncipe", "Senegal", "Seychelles", "Sierra Leona", "Singapur", "Siria", "Somalia", "Southern Ocean", "Spratly Islands", "Sri Lanka", "Suazilandia", "Sudáfrica", "Sudán", "Suecia", "Suiza", "Surinam", "Svalbard y Jan Mayen", "Tailandia", "Taiwán", "Tanzania", "Tayikistán", "TerritorioBritánicodel Océano Indico", "Territorios Australes Franceses", "Timor Oriental", "Togo", "Tokelau", "Tonga", "Trinidad y Tobago", "Túnez", "Turkmenistán", "Turquía", "Tuvalu", "Ucrania", "Uganda", "Unión Europea", "Uruguay", "Uzbekistán", "Vanuatu", "Venezuela", "Vietnam", "Wake Island", "Wallis y Futuna", "West Bank", "World", "Yemen", "Yibuti", "Zambia", "Zimbabue"})
        Me.CmbNacion.Location = New System.Drawing.Point(590, 94)
        Me.CmbNacion.Name = "CmbNacion"
        Me.CmbNacion.Size = New System.Drawing.Size(328, 27)
        Me.CmbNacion.TabIndex = 137
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(470, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 27)
        Me.Label13.TabIndex = 136
        Me.Label13.Text = "Nacionalidad"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtObservaciones.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtObservaciones.Location = New System.Drawing.Point(590, 185)
        Me.TxtObservaciones.MaxLength = 200
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtObservaciones.Size = New System.Drawing.Size(328, 67)
        Me.TxtObservaciones.TabIndex = 134
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(470, 185)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 27)
        Me.Label12.TabIndex = 135
        Me.Label12.Text = "Observaciones"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtEmpresa)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.BtnEmpresa)
        Me.GroupBox1.Location = New System.Drawing.Point(475, 258)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(673, 72)
        Me.GroupBox1.TabIndex = 140
        Me.GroupBox1.TabStop = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLimpiar.Location = New System.Drawing.Point(960, 180)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(188, 35)
        Me.BtnLimpiar.TabIndex = 144
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEliminar.Location = New System.Drawing.Point(960, 222)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(188, 35)
        Me.BtnEliminar.TabIndex = 143
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnModificar.Location = New System.Drawing.Point(960, 138)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(188, 35)
        Me.BtnModificar.TabIndex = 142
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAgregar.Location = New System.Drawing.Point(960, 97)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(188, 35)
        Me.BtnAgregar.TabIndex = 141
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtBusqueda)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Font = New System.Drawing.Font("Dubai", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(15, 352)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1133, 57)
        Me.GroupBox2.TabIndex = 147
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Control de Huéspedes"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusqueda.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtBusqueda.Location = New System.Drawing.Point(279, 22)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.ShortcutsEnabled = False
        Me.TxtBusqueda.Size = New System.Drawing.Size(608, 25)
        Me.TxtBusqueda.TabIndex = 148
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(162, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 27)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Por Nombre"
        '
        'DgvHuespedes
        '
        Me.DgvHuespedes.AllowUserToAddRows = False
        Me.DgvHuespedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvHuespedes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.DgvHuespedes.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvHuespedes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvHuespedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvHuespedes.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Dubai", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvHuespedes.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvHuespedes.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.DgvHuespedes.Location = New System.Drawing.Point(15, 419)
        Me.DgvHuespedes.Name = "DgvHuespedes"
        Me.DgvHuespedes.Size = New System.Drawing.Size(1133, 274)
        Me.DgvHuespedes.TabIndex = 148
        '
        'BtnAnterior
        '
        Me.BtnAnterior.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAnterior.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAnterior.ForeColor = System.Drawing.Color.Black
        Me.BtnAnterior.Location = New System.Drawing.Point(918, 699)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(110, 40)
        Me.BtnAnterior.TabIndex = 150
        Me.BtnAnterior.Text = "Anterior"
        Me.BtnAnterior.UseVisualStyleBackColor = False
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSiguiente.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSiguiente.ForeColor = System.Drawing.Color.Black
        Me.BtnSiguiente.Location = New System.Drawing.Point(1034, 699)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(114, 40)
        Me.BtnSiguiente.TabIndex = 149
        Me.BtnSiguiente.Text = "Siguiente"
        Me.BtnSiguiente.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(16, 704)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 27)
        Me.Label14.TabIndex = 152
        Me.Label14.Text = "Huéspedes:"
        '
        'LblContador
        '
        Me.LblContador.AutoSize = True
        Me.LblContador.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblContador.ForeColor = System.Drawing.Color.White
        Me.LblContador.Location = New System.Drawing.Point(113, 704)
        Me.LblContador.Name = "LblContador"
        Me.LblContador.Size = New System.Drawing.Size(0, 27)
        Me.LblContador.TabIndex = 151
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(8, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 27)
        Me.Label9.TabIndex = 153
        Me.Label9.Text = "Teléfono 2"
        '
        'RegistroHuespedes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1160, 748)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LblContador)
        Me.Controls.Add(Me.BtnAnterior)
        Me.Controls.Add(Me.BtnSiguiente)
        Me.Controls.Add(Me.DgvHuespedes)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtProcedencia)
        Me.Controls.Add(Me.CmbNacion)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtObservaciones)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbTipoCliente)
        Me.Controls.Add(Me.TxtTel2)
        Me.Controls.Add(Me.TxtTel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtNombres)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtIdentidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegistroHuespedes"
        Me.Text = "RegistroHuespedes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvHuespedes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbTipoCliente As ComboBox
    Friend WithEvents TxtTel2 As TextBox
    Friend WithEvents TxtTel1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtIdentidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnEmpresa As Button
    Friend WithEvents TxtEmpresa As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtProcedencia As TextBox
    Friend WithEvents CmbNacion As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtObservaciones As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DgvHuespedes As DataGridView
    Friend WithEvents BtnAnterior As Button
    Friend WithEvents BtnSiguiente As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents LblContador As Label
    Friend WithEvents Label9 As Label
End Class
