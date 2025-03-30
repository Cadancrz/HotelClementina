<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PanelPrincipalMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelPrincipalMenu))
        Me.PnPrincipal = New System.Windows.Forms.Panel()
        Me.PnPantallas = New System.Windows.Forms.Panel()
        Me.PnLineaVertical = New System.Windows.Forms.Panel()
        Me.PnMenu = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnBitacora = New System.Windows.Forms.Button()
        Me.BtnMigracion = New System.Windows.Forms.Button()
        Me.BtnSalon = New System.Windows.Forms.Button()
        Me.BtnUsuarios = New System.Windows.Forms.Button()
        Me.BtnEmpleados = New System.Windows.Forms.Button()
        Me.BtnFacturacion = New System.Windows.Forms.Button()
        Me.PnHabitaciones = New System.Windows.Forms.Panel()
        Me.BtnTipoHab = New System.Windows.Forms.Button()
        Me.BtnControlHab = New System.Windows.Forms.Button()
        Me.BtnHabitaciones = New System.Windows.Forms.Button()
        Me.PnHuespedes = New System.Windows.Forms.Panel()
        Me.BtnHistorial = New System.Windows.Forms.Button()
        Me.BtnEmpresas = New System.Windows.Forms.Button()
        Me.BtnRegHuespedes = New System.Windows.Forms.Button()
        Me.BtnHuespedes = New System.Windows.Forms.Button()
        Me.BtnReservaciones = New System.Windows.Forms.Button()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.BtnCerrarSesion = New System.Windows.Forms.Button()
        Me.PnLogo = New System.Windows.Forms.Panel()
        Me.BtnImpuesto = New System.Windows.Forms.Button()
        Me.TxtCodEmp = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PnPrincipal.SuspendLayout()
        Me.PnMenu.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnHabitaciones.SuspendLayout()
        Me.PnHuespedes.SuspendLayout()
        Me.PnLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnPrincipal
        '
        Me.PnPrincipal.BackColor = System.Drawing.Color.Black
        Me.PnPrincipal.Controls.Add(Me.PnPantallas)
        Me.PnPrincipal.Controls.Add(Me.PnLineaVertical)
        Me.PnPrincipal.Controls.Add(Me.PnMenu)
        Me.PnPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.PnPrincipal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnPrincipal.Name = "PnPrincipal"
        Me.PnPrincipal.Size = New System.Drawing.Size(1809, 926)
        Me.PnPrincipal.TabIndex = 0
        '
        'PnPantallas
        '
        Me.PnPantallas.Location = New System.Drawing.Point(259, 4)
        Me.PnPantallas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnPantallas.Name = "PnPantallas"
        Me.PnPantallas.Size = New System.Drawing.Size(1547, 921)
        Me.PnPantallas.TabIndex = 3
        '
        'PnLineaVertical
        '
        Me.PnLineaVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.PnLineaVertical.Location = New System.Drawing.Point(247, 0)
        Me.PnLineaVertical.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnLineaVertical.Name = "PnLineaVertical"
        Me.PnLineaVertical.Size = New System.Drawing.Size(7, 926)
        Me.PnLineaVertical.TabIndex = 2
        '
        'PnMenu
        '
        Me.PnMenu.Controls.Add(Me.PictureBox2)
        Me.PnMenu.Controls.Add(Me.BtnBitacora)
        Me.PnMenu.Controls.Add(Me.BtnMigracion)
        Me.PnMenu.Controls.Add(Me.BtnSalon)
        Me.PnMenu.Controls.Add(Me.BtnUsuarios)
        Me.PnMenu.Controls.Add(Me.BtnEmpleados)
        Me.PnMenu.Controls.Add(Me.BtnFacturacion)
        Me.PnMenu.Controls.Add(Me.PnHabitaciones)
        Me.PnMenu.Controls.Add(Me.BtnHabitaciones)
        Me.PnMenu.Controls.Add(Me.PnHuespedes)
        Me.PnMenu.Controls.Add(Me.BtnHuespedes)
        Me.PnMenu.Controls.Add(Me.BtnReservaciones)
        Me.PnMenu.Controls.Add(Me.BtnHome)
        Me.PnMenu.Controls.Add(Me.BtnCerrarSesion)
        Me.PnMenu.Controls.Add(Me.PnLogo)
        Me.PnMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnMenu.Location = New System.Drawing.Point(0, 0)
        Me.PnMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnMenu.Name = "PnMenu"
        Me.PnMenu.Size = New System.Drawing.Size(239, 926)
        Me.PnMenu.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 889)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'BtnBitacora
        '
        Me.BtnBitacora.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBitacora.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBitacora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBitacora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnBitacora.Location = New System.Drawing.Point(0, 802)
        Me.BtnBitacora.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnBitacora.Name = "BtnBitacora"
        Me.BtnBitacora.Size = New System.Drawing.Size(239, 50)
        Me.BtnBitacora.TabIndex = 30
        Me.BtnBitacora.Text = "Bitácora"
        Me.BtnBitacora.UseVisualStyleBackColor = True
        '
        'BtnMigracion
        '
        Me.BtnMigracion.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMigracion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnMigracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMigracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMigracion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnMigracion.Location = New System.Drawing.Point(0, 752)
        Me.BtnMigracion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnMigracion.Name = "BtnMigracion"
        Me.BtnMigracion.Size = New System.Drawing.Size(239, 50)
        Me.BtnMigracion.TabIndex = 29
        Me.BtnMigracion.Text = "Migración"
        Me.BtnMigracion.UseVisualStyleBackColor = True
        '
        'BtnSalon
        '
        Me.BtnSalon.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSalon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnSalon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnSalon.Location = New System.Drawing.Point(0, 702)
        Me.BtnSalon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnSalon.Name = "BtnSalon"
        Me.BtnSalon.Size = New System.Drawing.Size(239, 50)
        Me.BtnSalon.TabIndex = 28
        Me.BtnSalon.Text = "Salón"
        Me.BtnSalon.UseVisualStyleBackColor = True
        '
        'BtnUsuarios
        '
        Me.BtnUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnUsuarios.Location = New System.Drawing.Point(0, 652)
        Me.BtnUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnUsuarios.Name = "BtnUsuarios"
        Me.BtnUsuarios.Size = New System.Drawing.Size(239, 50)
        Me.BtnUsuarios.TabIndex = 27
        Me.BtnUsuarios.Text = "Usuarios"
        Me.BtnUsuarios.UseVisualStyleBackColor = True
        '
        'BtnEmpleados
        '
        Me.BtnEmpleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEmpleados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpleados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnEmpleados.Location = New System.Drawing.Point(0, 602)
        Me.BtnEmpleados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEmpleados.Name = "BtnEmpleados"
        Me.BtnEmpleados.Size = New System.Drawing.Size(239, 50)
        Me.BtnEmpleados.TabIndex = 26
        Me.BtnEmpleados.Text = "Empleados"
        Me.BtnEmpleados.UseVisualStyleBackColor = True
        '
        'BtnFacturacion
        '
        Me.BtnFacturacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnFacturacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFacturacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFacturacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnFacturacion.Location = New System.Drawing.Point(0, 552)
        Me.BtnFacturacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnFacturacion.Name = "BtnFacturacion"
        Me.BtnFacturacion.Size = New System.Drawing.Size(239, 50)
        Me.BtnFacturacion.TabIndex = 25
        Me.BtnFacturacion.Text = "Facturación"
        Me.BtnFacturacion.UseVisualStyleBackColor = True
        '
        'PnHabitaciones
        '
        Me.PnHabitaciones.Controls.Add(Me.BtnTipoHab)
        Me.PnHabitaciones.Controls.Add(Me.BtnControlHab)
        Me.PnHabitaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnHabitaciones.Location = New System.Drawing.Point(0, 473)
        Me.PnHabitaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnHabitaciones.Name = "PnHabitaciones"
        Me.PnHabitaciones.Size = New System.Drawing.Size(239, 79)
        Me.PnHabitaciones.TabIndex = 21
        '
        'BtnTipoHab
        '
        Me.BtnTipoHab.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTipoHab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnTipoHab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTipoHab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTipoHab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnTipoHab.Location = New System.Drawing.Point(0, 39)
        Me.BtnTipoHab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnTipoHab.Name = "BtnTipoHab"
        Me.BtnTipoHab.Size = New System.Drawing.Size(239, 39)
        Me.BtnTipoHab.TabIndex = 16
        Me.BtnTipoHab.Text = "Tipo de Habitaciones"
        Me.BtnTipoHab.UseVisualStyleBackColor = True
        '
        'BtnControlHab
        '
        Me.BtnControlHab.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnControlHab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnControlHab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnControlHab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnControlHab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnControlHab.Location = New System.Drawing.Point(0, 0)
        Me.BtnControlHab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnControlHab.Name = "BtnControlHab"
        Me.BtnControlHab.Size = New System.Drawing.Size(239, 39)
        Me.BtnControlHab.TabIndex = 15
        Me.BtnControlHab.Text = "Control de Habitaciones"
        Me.BtnControlHab.UseVisualStyleBackColor = True
        '
        'BtnHabitaciones
        '
        Me.BtnHabitaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnHabitaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHabitaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHabitaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnHabitaciones.Location = New System.Drawing.Point(0, 423)
        Me.BtnHabitaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnHabitaciones.Name = "BtnHabitaciones"
        Me.BtnHabitaciones.Size = New System.Drawing.Size(239, 50)
        Me.BtnHabitaciones.TabIndex = 20
        Me.BtnHabitaciones.Text = "Habitaciones"
        Me.BtnHabitaciones.UseVisualStyleBackColor = True
        '
        'PnHuespedes
        '
        Me.PnHuespedes.Controls.Add(Me.BtnHistorial)
        Me.PnHuespedes.Controls.Add(Me.BtnEmpresas)
        Me.PnHuespedes.Controls.Add(Me.BtnRegHuespedes)
        Me.PnHuespedes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnHuespedes.Location = New System.Drawing.Point(0, 305)
        Me.PnHuespedes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnHuespedes.Name = "PnHuespedes"
        Me.PnHuespedes.Size = New System.Drawing.Size(239, 118)
        Me.PnHuespedes.TabIndex = 19
        '
        'BtnHistorial
        '
        Me.BtnHistorial.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnHistorial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHistorial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnHistorial.Location = New System.Drawing.Point(0, 78)
        Me.BtnHistorial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnHistorial.Name = "BtnHistorial"
        Me.BtnHistorial.Size = New System.Drawing.Size(239, 39)
        Me.BtnHistorial.TabIndex = 20
        Me.BtnHistorial.Text = "Historial de Reservas"
        Me.BtnHistorial.UseVisualStyleBackColor = True
        '
        'BtnEmpresas
        '
        Me.BtnEmpresas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEmpresas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmpresas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpresas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnEmpresas.Location = New System.Drawing.Point(0, 39)
        Me.BtnEmpresas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEmpresas.Name = "BtnEmpresas"
        Me.BtnEmpresas.Size = New System.Drawing.Size(239, 39)
        Me.BtnEmpresas.TabIndex = 19
        Me.BtnEmpresas.Text = "Registro de Empresas"
        Me.BtnEmpresas.UseVisualStyleBackColor = True
        '
        'BtnRegHuespedes
        '
        Me.BtnRegHuespedes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRegHuespedes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnRegHuespedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegHuespedes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegHuespedes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnRegHuespedes.Location = New System.Drawing.Point(0, 0)
        Me.BtnRegHuespedes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnRegHuespedes.Name = "BtnRegHuespedes"
        Me.BtnRegHuespedes.Size = New System.Drawing.Size(239, 39)
        Me.BtnRegHuespedes.TabIndex = 18
        Me.BtnRegHuespedes.Text = "Registro de Huéspedes"
        Me.BtnRegHuespedes.UseVisualStyleBackColor = True
        '
        'BtnHuespedes
        '
        Me.BtnHuespedes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnHuespedes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnHuespedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHuespedes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHuespedes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnHuespedes.Location = New System.Drawing.Point(0, 255)
        Me.BtnHuespedes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnHuespedes.Name = "BtnHuespedes"
        Me.BtnHuespedes.Size = New System.Drawing.Size(239, 50)
        Me.BtnHuespedes.TabIndex = 18
        Me.BtnHuespedes.Text = "Huéspedes"
        Me.BtnHuespedes.UseVisualStyleBackColor = True
        '
        'BtnReservaciones
        '
        Me.BtnReservaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReservaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnReservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReservaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnReservaciones.Location = New System.Drawing.Point(0, 205)
        Me.BtnReservaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnReservaciones.Name = "BtnReservaciones"
        Me.BtnReservaciones.Size = New System.Drawing.Size(239, 50)
        Me.BtnReservaciones.TabIndex = 17
        Me.BtnReservaciones.Text = "Reservaciones"
        Me.BtnReservaciones.UseVisualStyleBackColor = True
        '
        'BtnHome
        '
        Me.BtnHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnHome.Location = New System.Drawing.Point(0, 155)
        Me.BtnHome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(239, 50)
        Me.BtnHome.TabIndex = 12
        Me.BtnHome.Text = "Home"
        Me.BtnHome.UseVisualStyleBackColor = True
        '
        'BtnCerrarSesion
        '
        Me.BtnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrarSesion.Location = New System.Drawing.Point(0, 882)
        Me.BtnCerrarSesion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCerrarSesion.Name = "BtnCerrarSesion"
        Me.BtnCerrarSesion.Size = New System.Drawing.Size(239, 44)
        Me.BtnCerrarSesion.TabIndex = 11
        Me.BtnCerrarSesion.Text = "Cerrar Sesión"
        Me.BtnCerrarSesion.UseVisualStyleBackColor = True
        '
        'PnLogo
        '
        Me.PnLogo.Controls.Add(Me.BtnImpuesto)
        Me.PnLogo.Controls.Add(Me.TxtCodEmp)
        Me.PnLogo.Controls.Add(Me.PictureBox1)
        Me.PnLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnLogo.Location = New System.Drawing.Point(0, 0)
        Me.PnLogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnLogo.Name = "PnLogo"
        Me.PnLogo.Size = New System.Drawing.Size(239, 155)
        Me.PnLogo.TabIndex = 0
        '
        'BtnImpuesto
        '
        Me.BtnImpuesto.Location = New System.Drawing.Point(0, 127)
        Me.BtnImpuesto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnImpuesto.Name = "BtnImpuesto"
        Me.BtnImpuesto.Size = New System.Drawing.Size(100, 28)
        Me.BtnImpuesto.TabIndex = 0
        Me.BtnImpuesto.Text = "Impuesto"
        Me.BtnImpuesto.UseVisualStyleBackColor = True
        '
        'TxtCodEmp
        '
        Me.TxtCodEmp.Location = New System.Drawing.Point(0, 0)
        Me.TxtCodEmp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCodEmp.Name = "TxtCodEmp"
        Me.TxtCodEmp.Size = New System.Drawing.Size(45, 22)
        Me.TxtCodEmp.TabIndex = 0
        Me.TxtCodEmp.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 26)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelPrincipalMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1809, 926)
        Me.Controls.Add(Me.PnPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "PanelPrincipalMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PanelPrincipalMenu"
        Me.PnPrincipal.ResumeLayout(False)
        Me.PnMenu.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnHabitaciones.ResumeLayout(False)
        Me.PnHuespedes.ResumeLayout(False)
        Me.PnLogo.ResumeLayout(False)
        Me.PnLogo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnPrincipal As Panel
    Friend WithEvents PnMenu As Panel
    Friend WithEvents PnLineaVertical As Panel
    Friend WithEvents PnPantallas As Panel
    Friend WithEvents PnLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnCerrarSesion As Button
    Friend WithEvents PnHabitaciones As Panel
    Friend WithEvents BtnTipoHab As Button
    Friend WithEvents BtnControlHab As Button
    Friend WithEvents BtnHabitaciones As Button
    Friend WithEvents PnHuespedes As Panel
    Friend WithEvents BtnHistorial As Button
    Friend WithEvents BtnEmpresas As Button
    Friend WithEvents BtnRegHuespedes As Button
    Friend WithEvents BtnHuespedes As Button
    Friend WithEvents BtnReservaciones As Button
    Friend WithEvents BtnHome As Button
    Friend WithEvents BtnBitacora As Button
    Friend WithEvents BtnMigracion As Button
    Friend WithEvents BtnSalon As Button
    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents BtnEmpleados As Button
    Friend WithEvents BtnFacturacion As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TxtCodEmp As TextBox
    Friend WithEvents BtnImpuesto As Button
End Class
