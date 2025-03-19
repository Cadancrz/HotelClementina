Public Class PanelPrincipalMenu
    Public codCargo As Integer
    Private formularioActivo As Form = Nothing
    Private botonAnterior As Button = Nothing ' Almacena el botón previamente seleccionado

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirPantallas(New Home())
        ocultarSubMenu()
        botonAnterior = BtnHome
        BtnHome.ForeColor = Color.Black
        BtnHome.BackColor = Color.FromArgb(228, 187, 19)
    End Sub

    Private Sub ocultarSubMenu()
        PnHuespedes.Visible = False
        PnHabitaciones.Visible = False
    End Sub

    Private Sub mostrarSubMenu(ByVal subMenu As Panel)
        If subMenu.Visible = False Then
            ocultarSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If
    End Sub

    Public Sub abrirPantallas(ByVal formularioHijo As Form)
        If formularioActivo IsNot Nothing Then
            formularioActivo.Close()
        End If

        formularioActivo = formularioHijo
        formularioHijo.TopLevel = False
        formularioHijo.FormBorderStyle = FormBorderStyle.None
        formularioHijo.Dock = DockStyle.Fill
        PnPantallas.Controls.Add(formularioHijo)
        PnPantallas.Tag = formularioHijo
        formularioHijo.BringToFront()
        formularioHijo.Show()
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        RestablecerColorBotonAnterior()
        abrirPantallas(New Home()) ' Muestra el formulario Home
        ocultarSubMenu()
        BtnHome.BackColor = Color.FromArgb(228, 187, 19)
        BtnHome.ForeColor = Color.Black
        botonAnterior = BtnHome
    End Sub

    Private Sub BtnHuespedes_Click(sender As Object, e As EventArgs) Handles BtnHuespedes.Click
        RestablecerColorBotonAnterior()
        mostrarSubMenu(PnHuespedes)
        BtnHuespedes.BackColor = Color.FromArgb(228, 187, 19)
        BtnHuespedes.ForeColor = Color.Black
        botonAnterior = BtnHuespedes
    End Sub

    Private Sub BtnRegHuespedes_Click(sender As Object, e As EventArgs) Handles BtnRegHuespedes.Click
        RestablecerColorBotonAnterior()
        abrirPantallas(New RegistroHuespedes())
        BtnRegHuespedes.BackColor = Color.FromArgb(228, 187, 19)
        BtnRegHuespedes.ForeColor = Color.Black
        botonAnterior = BtnRegHuespedes
    End Sub

    Private Sub BtnEmpresas_Click(sender As Object, e As EventArgs) Handles BtnEmpresas.Click
        RestablecerColorBotonAnterior()
        abrirPantallas(New RegistroEmpresas())
        BtnEmpresas.BackColor = Color.FromArgb(228, 187, 19)
        BtnEmpresas.ForeColor = Color.Black
        botonAnterior = BtnEmpresas
    End Sub
    Private Sub BtnHistorial_Click(sender As Object, e As EventArgs) Handles BtnHistorial.Click
        RestablecerColorBotonAnterior()
        abrirPantallas(New HistorialReservas())
        BtnHistorial.BackColor = Color.FromArgb(228, 187, 19)
        BtnHistorial.ForeColor = Color.Black
        botonAnterior = BtnHistorial
    End Sub

    Private Sub BtnReservaciones_Click(sender As Object, e As EventArgs) Handles BtnReservaciones.Click
        RestablecerColorBotonAnterior()
        abrirPantallas(New Reservaciones()) ' Muestra el formulario Reservaciones
        BtnReservaciones.BackColor = Color.FromArgb(228, 187, 19)
        BtnReservaciones.ForeColor = Color.Black
        botonAnterior = BtnReservaciones
    End Sub

    Private Sub BtnControlHab_Click(sender As Object, e As EventArgs) Handles BtnControlHab.Click
        RestablecerColorBotonAnterior()
        abrirPantallas(New ControlHabitaciones())
        BtnControlHab.BackColor = Color.FromArgb(228, 187, 19)
        BtnControlHab.ForeColor = Color.Black
        botonAnterior = BtnControlHab
    End Sub

    Private Sub BtnTipoHab_Click(sender As Object, e As EventArgs) Handles BtnTipoHab.Click
        RestablecerColorBotonAnterior()
        abrirPantallas(New TipoHabitaciones())
        BtnTipoHab.BackColor = Color.FromArgb(228, 187, 19)
        BtnTipoHab.ForeColor = Color.Black
        botonAnterior = BtnTipoHab
    End Sub

    Private Sub BtnHabitaciones_Click(sender As Object, e As EventArgs) Handles BtnHabitaciones.Click
        RestablecerColorBotonAnterior()
        mostrarSubMenu(PnHabitaciones)
        BtnHabitaciones.BackColor = Color.FromArgb(228, 187, 19)
        BtnHabitaciones.ForeColor = Color.Black
        botonAnterior = BtnHabitaciones
    End Sub

    Private Sub BtnFacturacion_Click(sender As Object, e As EventArgs) Handles BtnFacturacion.Click
        RestablecerColorBotonAnterior()
        abrirPantallas(New Facturacion())
        BtnFacturacion.BackColor = Color.FromArgb(228, 187, 19)
        BtnFacturacion.ForeColor = Color.Black
        botonAnterior = BtnFacturacion
    End Sub

    Private Sub BtnEmpleados_Click(sender As Object, e As EventArgs) Handles BtnEmpleados.Click
        RestablecerColorBotonAnterior()
        abrirPantallas(New Empleados())
        BtnEmpleados.BackColor = Color.FromArgb(228, 187, 19)
        BtnEmpleados.ForeColor = Color.Black
        botonAnterior = BtnEmpleados
    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        RestablecerColorBotonAnterior()
        abrirPantallas(New Usuarios())
        BtnUsuarios.BackColor = Color.FromArgb(228, 187, 19)
        BtnUsuarios.ForeColor = Color.Black
        botonAnterior = BtnUsuarios
    End Sub

    Private Sub BtnSalon_Click(sender As Object, e As EventArgs) Handles BtnSalon.Click
        RestablecerColorBotonAnterior()
        abrirPantallas(New Salon())
        BtnSalon.BackColor = Color.FromArgb(228, 187, 19)
        BtnSalon.ForeColor = Color.Black
        botonAnterior = BtnSalon
    End Sub

    Private Sub BtnMigracion_Click(sender As Object, e As EventArgs) Handles BtnMigracion.Click
        RestablecerColorBotonAnterior()
        abrirPantallas(New Migracion())
        BtnMigracion.BackColor = Color.FromArgb(228, 187, 19)
        BtnMigracion.ForeColor = Color.Black
        botonAnterior = BtnMigracion
    End Sub

    Private Sub BtnBitacora_Click(sender As Object, e As EventArgs) Handles BtnBitacora.Click
        RestablecerColorBotonAnterior()
        abrirPantallas(New Bitacora())
        BtnBitacora.BackColor = Color.FromArgb(228, 187, 19)
        BtnBitacora.ForeColor = Color.Black
        botonAnterior = BtnBitacora
    End Sub
    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs) Handles BtnCerrarSesion.Click
        Me.Close()
        Login.Show()
        Login.TxtUsuario.Focus()
    End Sub

    Private Sub RestablecerColorBotonAnterior()
        If botonAnterior IsNot Nothing Then
            botonAnterior.BackColor = Color.Black ' Color de fondo original
            botonAnterior.ForeColor = Color.FromArgb(228, 187, 19) ' Color de texto original
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    ' Eventos Click para los botones del submenú PnHuespedes
    Private Sub BtnRegHuespedes_Click_1(sender As Object, e As EventArgs) Handles BtnRegHuespedes.Click
        RestablecerColorBotonAnterior()
        abrirPantallas(New RegistroHuespedes())
        BtnRegHuespedes.BackColor = Color.FromArgb(228, 187, 19)
        BtnRegHuespedes.ForeColor = Color.Black
        botonAnterior = BtnHuespedes ' Importante: El botón principal sigue siendo el "padre" del submenú
        ocultarSubMenu() ' Oculta el submenú después de seleccionar una opción
    End Sub

    Private Sub BtnEmpresas_Click_1(sender As Object, e As EventArgs) Handles BtnEmpresas.Click
        RestablecerColorBotonAnterior()
        abrirPantallas(New RegistroEmpresas())
        BtnEmpresas.BackColor = Color.FromArgb(228, 187, 19)
        BtnEmpresas.ForeColor = Color.Black
        botonAnterior = BtnHuespedes ' Importante: El botón principal sigue siendo el "padre" del submenú
        ocultarSubMenu() ' Oculta el submenú después de seleccionar una opción
    End Sub

    Private Sub BtnHistorial_Click_1(sender As Object, e As EventArgs) Handles BtnHistorial.Click
        RestablecerColorBotonAnterior()
        abrirPantallas(New HistorialReservas())
        BtnHistorial.BackColor = Color.FromArgb(228, 187, 19)
        BtnHistorial.ForeColor = Color.Black
        botonAnterior = BtnHuespedes ' Importante: El botón principal sigue siendo el "padre" del submenú
        ocultarSubMenu() ' Oculta el submenú después de seleccionar una opción
    End Sub
End Class