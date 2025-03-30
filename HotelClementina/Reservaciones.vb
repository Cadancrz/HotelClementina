Imports System.Data.SqlClient

Public Class Reservaciones
    Dim query As String 'variable para las consultas
    Dim con As New ClsConexion 'variable conexion
    Dim dv As New DataView 'variable dataview para la busqueda de clientes
    Dim dvdispon As New DataView 'variable dataview para cargar gridview de habitaciones
    Dim entrar As String 'variable para entrar a los ciclos
    Dim export As SqlDataReader 'variable datareader para las exportaciones
    Dim habi As Integer 'variable para guardar los numeros de las habitaciones
    Dim habidisponibles As String 'variable para guardar las habitaciones disponibles en el ciclo e ir llenando el gridview
    Dim Det, ResultQuery As Integer 'variable para respuesta de mensajes
    Dim dr As IDataReader 'para leer cadenas de datos'
    Dim contador As Integer 'EXPORTA EL NUMERO DE HABITACION EN ORDEN ASCENDENTE
    Dim dias As Integer 'variable para guardar la cantidad de diass de una reserva
    Dim fecha1, fecha2, fechafin As Date 'variables para las fechas
    Dim preciodia, preciototal As Double 'variables para cantidades
    ' Variables globales para la paginación
    Private totalPaginas As Integer = 1 ' Variable para almacenar el total de páginas
    Private paginaActual As Integer = 1
    Private RegistrosPorPagina As Integer = 500 ' Cambia este valor según lo que necesites
    Dim conthuesped As Integer 'variable contador de huespedes



    Private Sub BtnReservar_Click(sender As Object, e As EventArgs) Handles BtnReservar.Click
        frmReservasAbierto = 1
        estadohabitacion = 0

        ' Llamar al formulario de reservaciones dentro del panel
        Dim frmHabitaciones As New ControlHabitaciones()
        frmHabitaciones.TopLevel = False
        frmHabitaciones.FormBorderStyle = FormBorderStyle.None
        frmHabitaciones.Dock = DockStyle.Fill

        ' Limpiar el panel y agregar el nuevo formulario
        PanelPrincipalMenu.PnPantallas.Controls.Clear()
        PanelPrincipalMenu.PnPantallas.Controls.Add(frmHabitaciones)
        frmHabitaciones.Show()
    End Sub

    Private Sub DGVClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClientes.CellContentClick

    End Sub

    Public Sub Carga(Optional ByVal cadena1 As String = Nothing,
                 Optional ByVal cadena2 As String = Nothing,
                 Optional ByVal cadena3 As String = Nothing,
                 Optional ByVal cadena4 As String = Nothing)
        Try
            Dim db As New ClsConexion()
            Dim parametros As New List(Of SqlParameter)()

            parametros.Add(New SqlParameter("@cadena1", cadena1))
            parametros.Add(New SqlParameter("@cadena2", cadena2))
            parametros.Add(New SqlParameter("@cadena3", cadena3))
            parametros.Add(New SqlParameter("@cadena4", cadena4))
            parametros.Add(New SqlParameter("@Pagina", paginaActual))
            parametros.Add(New SqlParameter("@RegistrosPorPagina", RegistrosPorPagina))

            Dim dt As DataTable = db.EjecutarSP("ProCargaHuespedes", parametros)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                With DGVClientes
                    .MultiSelect = False
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .DataSource = dt
                    .AllowUserToAddRows = False
                    .DefaultCellStyle.ForeColor = Color.Black  ' Texto en negro
                    .DefaultCellStyle.BackColor = Color.White  ' Fondo blanco
                    .DefaultCellStyle.SelectionForeColor = Color.White ' Texto seleccionado en blanco
                    .DefaultCellStyle.SelectionBackColor = Color.Blue   ' Fondo seleccionado en azul
                End With
            Else
                DGVClientes.DataSource = Nothing
            End If


            Dim columnasOcultar As Integer() = {2, 3, 5, 6, 7, 8}

            For Each col As Integer In columnasOcultar
                DGVClientes.Columns(col).Visible = False
            Next

            DGVClientes.Columns(0).Width = 200 ' Primera columna
            DGVClientes.Columns(1).Width = 500 ' Segunda columna
            DGVClientes.Columns(4).Width = 166 ' Tercera columna
            ' Obtener el total de productos y calcular la paginación
            totalPaginas = Math.Ceiling(ObtenerTotalRegistros(cadena1, cadena2, cadena3, cadena4) / RegistrosPorPagina)

            ' Actualizar los botones de paginación

        Catch ex As Exception
            MsgBox("Error al cargar los huéspedes: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNombre.Enabled = True
        TxtNombre.Text = ""
        TxtIdentidad.Text = ""
    End Sub

    Private Sub MCEntrada_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MCEntrada.DateChanged
        ' Validar que la fecha de entrada no sea menor a la fecha actual
        If MCEntrada.SelectionStart < DateTime.Today Then
            MsgBox("La fecha de entrada no puede ser menor a hoy.", MsgBoxStyle.Critical, "Error")
            MCEntrada.SetDate(DateTime.Today) ' Restablecer a la fecha actual
            TxtEntrada.Text = DateTime.Today.ToString("dd/MM/yyyy")
        Else
            ' Asignar la fecha seleccionada al TextBox en formato dd/MM/yyyy
            TxtEntrada.Text = MCEntrada.SelectionStart.ToString("dd/MM/yyyy")
        End If
    End Sub

    Private Sub MCSalida_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MCSalida.DateChanged
        ' Validar que la fecha de salida no sea menor a hoy
        If MCSalida.SelectionStart < DateTime.Today Then
            ' Validar que la fecha de salida solo sea igual a hoy si es antes de las 12 del mediodía
            If MCSalida.SelectionStart.Date = DateTime.Today And DateTime.Now.Hour < 12 Then
                TxtSalida.Text = MCSalida.SelectionStart.ToString("dd/MM/yyyy")
            Else
                MsgBox("La fecha de salida no puede ser menor a hoy.", MsgBoxStyle.Critical, "Error")
                MCSalida.SetDate(DateTime.Today.AddDays(1)) ' Restablecer a un día futuro
                TxtSalida.Text = MCSalida.SelectionStart.ToString("dd/MM/yyyy")
                Exit Sub
            End If
        End If

        ' Validar que la fecha de salida no sea menor que la fecha de entrada
        If MCSalida.SelectionStart < MCEntrada.SelectionStart Then
            MsgBox("La fecha de salida no puede ser menor a la fecha de entrada.", MsgBoxStyle.Critical, "Error")
            MCSalida.SetDate(MCEntrada.SelectionStart.AddDays(1)) ' Restablecer a un día después de la fecha de entrada
            TxtSalida.Text = MCSalida.SelectionStart.ToString("dd/MM/yyyy")
        Else
            ' Asignar la fecha seleccionada en MCSalida al TextBox en formato dd/MM/yyyy
            TxtSalida.Text = MCSalida.SelectionStart.ToString("dd/MM/yyyy")
        End If
    End Sub




    Private Function ObtenerTotalRegistros(Optional ByVal cadena1 As String = Nothing,
                                       Optional ByVal cadena2 As String = Nothing,
                                       Optional ByVal cadena3 As String = Nothing,
                                       Optional ByVal cadena4 As String = Nothing) As Integer
        Try
            Dim db As New ClsConexion()
            Dim query As String = "SELECT COUNT(*) FROM Clientes"
            Dim parametros As New List(Of SqlParameter)()

            If con.val(query) = True Then 'si retorna un valor entra al ciclo
                export = con.reader(query) 'exporta lo que contenga la consulta
                While export.Read 'mientras exporta llena la variable
                    conthuesped = export.GetValue(0) 'llena la variable
                End While
                export.Close() 'cierra la exportacion

            End If

            If Not String.IsNullOrEmpty(cadena1) Or Not String.IsNullOrEmpty(cadena2) Or Not String.IsNullOrEmpty(cadena3) Or Not String.IsNullOrEmpty(cadena4) Then
                query &= " WHERE Nom_Cli LIKE @FiltroNombre"
                parametros.Add(New SqlParameter("@FiltroNombre", "%" & cadena1 & cadena2 & cadena3 & cadena4 & "%"))
            End If

            Dim resultado As Object = db.EjecutarEscalar(query, parametros)

            If resultado IsNot Nothing Then
                Return Convert.ToInt32(resultado)
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox("Error al obtener el total de registros o el contador de huéspedes: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return 0
        End Try
    End Function

    Private Sub Reservaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lblhorafecha.Text = DateTime.Now.Hour
        TxtHabitacion.Text = numhab
        Carga()

        ' Limpiar el ComboBox antes de agregar opciones
        CmbHabitacion.Items.Clear()

        ' Convertir numhab en un número entero
        Dim numHabitacion As Integer
        If Integer.TryParse(numhab, numHabitacion) Then
            Select Case numHabitacion
                Case 2, 3, 4, 10, 11, 12, 13, 18 To 35
                    CmbHabitacion.Items.AddRange(New String() {"Sencillo", "Pareja"})

                Case 1, 7, 9, 15
                    CmbHabitacion.Items.AddRange(New String() {"Sencillo", "Doble"})

                Case 5, 14
                    CmbHabitacion.Items.AddRange(New String() {"Jr Sencilla", "Jr Pareja"})

                Case 6, 16
                    CmbHabitacion.Items.AddRange(New String() {"Triple", "Doble", "Sencilla"})

                Case 17
                    CmbHabitacion.Items.AddRange(New String() {"Suit", "Suit Pareja"})
            End Select
        End If

        ' Seleccionar automáticamente el primer elemento si hay opciones
        If CmbHabitacion.Items.Count > 0 Then
            CmbHabitacion.SelectedIndex = 0
        End If
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        paginaActual = 1 ' Reiniciar la página actual
        Dim result As String
        If Len(TxtNombre.Text) > 0 Then
            Dim cadena As String = TxtNombre.Text
            ':::Creamos el array tambien de tipo string para guardar cada palabra
            Dim Palabra() As String
            ':::Asignamos al array nuestra Cadena con la funcion Split y como separador un espacio vacio
            Palabra = cadena.Split(" ")
            ':::Iniciamos nuestro capturador de errores

            ':::Ahora pasamos a nuestro Label cada parte o seccion del array y le sustraemos las dos (2) primera letras
            Dim cadenas As Integer = UBound(Palabra)

            If cadenas = 0 Then
                result = Palabra(0)
                con.cargarDgv("exec ProCargaHuespedes '" & Palabra(0) & "',2,3,4", DGVClientes, dv) 'llama la funcion para cargar el gridview
            ElseIf cadenas = 1 Then
                result = Palabra(0) & "%" & Palabra(1)
                con.cargarDgv("exec ProCargaHuespedes '" & Palabra(0) & "','" & Palabra(1) & "',3,4", DGVClientes, dv) 'llama la funcion para cargar el gridview
            ElseIf cadenas = 2 Then
                result = Palabra(0) & "%" & Palabra(1)
                con.cargarDgv("exec ProCargaHuespedes '" & Palabra(0) & "','" & Palabra(1) & "','" & Palabra(2) & "',4", DGVClientes, dv) 'llama la funcion para cargar el gridview
            ElseIf cadenas = 3 Then
                result = Palabra(0) & "%" & Palabra(1)
                con.cargarDgv("exec ProCargaHuespedes '" & Palabra(0) & "','" & Palabra(1) & "','" & Palabra(2) & "','" & Palabra(3) & "'", DGVClientes, dv) 'llama la funcion para cargar el gridview
            End If
        Else
            con.cargarDgv("exec ProCargaHuespedes" & " 1,2,3,4", DGVClientes, dv) 'llama la funcion para cargar el gridview
        End If
    End Sub

    Private Sub DGVClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClientes.CellDoubleClick
        TxtIdentidad.Text = DGVClientes.Rows(e.RowIndex).Cells(0).Value.ToString()
        TxtNombre.Text = DGVClientes.Rows(e.RowIndex).Cells(1).Value.ToString()

        ' Deshabilita el TxtNombre
        TxtNombre.Enabled = False
    End Sub
End Class