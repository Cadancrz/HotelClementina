Imports System.Data.SqlClient

Public Class Reservaciones
    Dim query As String 'variable para las consultas
    Dim con As New ClsConexion 'variable conexion
    Dim dv As New DataView 'variable dataview para la busqueda de clientes
    Dim export As SqlDataReader 'variable datareader para las exportaciones
    Dim dr As IDataReader 'para leer cadenas de datos'
    ' Variables globales para la paginación
    Private totalPaginas As Integer = 1 ' Variable para almacenar el total de páginas
    Private paginaActual As Integer = 1
    Private RegistrosPorPagina As Integer = 500 ' Cambia este valor según lo que necesites
    Dim conthuesped As Integer 'variable contador de huespedes
    Dim entradacompleto As DateTime
    Dim salidacompleto As DateTime
    Dim numreserva As Integer
    Dim preciohab As Integer

    Public Sub autonum()
        query = "select Cod_Res from Reserva"
        If con.val(query) = True Then
            query = "select Max(Cod_Res) from Reserva"
            dr = con.reader(query)
            While dr.Read
                numreserva = dr.GetValue(0) + 1
            End While
            dr.Close()
        Else
            numreserva = 1
        End If
    End Sub

    Private Sub BtnReservar_Click(sender As Object, e As EventArgs) Handles BtnReservar.Click

        If CmbHabitacion.Text = "Sencilla" Then
            preciohab = 1300
        ElseIf CmbHabitacion.Text = "Pareja" Then
            preciohab = 1700
        ElseIf CmbHabitacion.Text = "Jr Sencilla" Then
            preciohab = 1450
        ElseIf CmbHabitacion.Text = "Jr Pareja" Then
            preciohab = 1800
        ElseIf CmbHabitacion.Text = "Doble" Then
            preciohab = 1850
        ElseIf CmbHabitacion.Text = "Triple" Then
            preciohab = 2650
        ElseIf CmbHabitacion.Text = "Suit" Or CmbHabitacion.Text = "Suit Pareja" Then
            preciohab = 2100
        End If

        If TxtNombre.Text = "" Or TxtIdentidad.Text = "" Or TxtEntrada.Text = "" Or TxtSalida.Text = "" Then
            MsgBox("Faltan datos por ingresar.", MsgBoxStyle.Critical, "Error")
        Else
            query = " INSERT INTO Reserva (Cod_Res, Fec_Ini_Res, Fec_Fin_Res, Cod_Hab, Cod_Cli, Nom_Usu, Precio_Unitario, Descuento, Recargo, Pagado_NoPagado, Cod_Est, TipoPago)  VALUES(" & numreserva & ",'" & entradacompleto.ToString("yyyy/dd/MM HH:mm:ss") & "','" & salidacompleto.ToString("yyyy/dd/MM HH:mm:ss") & "','" & TxtHabitacion.Text & "','" & TxtIdentidad.Text & "','" & Usuario & "'," & preciohab & "," & 0 & "," & 0 & "," & 0 & "," & 0 & ", NULL)"
            con.insertar(query)

            ' Registrar en la Bitácora
            Dim fecha As String = DateTime.Now.ToString("yyyy-MM-dd")
            Dim hora As String = DateTime.Now.ToString("HH:mm:ss")
            Dim descripcion As String = Login.NombreEmpleado & " hizo una reserva de la habitación: " & TxtHabitacion.Text & " del huésped: " & TxtNombre.Text

            query = "INSERT INTO Bitacora (Cod_Usu, Fch_Bita, Hrs_Bita, Obs_Bita) VALUES (" & Login.codUsu & ", '" & fecha & "', '" & hora & "', '" & descripcion & "')"
            con.insertar(query)

            MsgBox("Reserva elaborada exitosamente.", MsgBoxStyle.Information, "Aviso")
            ' Llamar al formulario de reservaciones dentro del panel
            Dim frmHabitaciones As New ControlHabitaciones()
            frmHabitaciones.TopLevel = False
            frmHabitaciones.FormBorderStyle = FormBorderStyle.None
            frmHabitaciones.Dock = DockStyle.Fill

            ' Limpiar el panel y agregar el nuevo formulario
            PanelPrincipalMenu.PnPantallas.Controls.Clear()
            PanelPrincipalMenu.PnPantallas.Controls.Add(frmHabitaciones)
            frmHabitaciones.Show()

        End If

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
            TxtEntrada.Text = DateTime.Today.ToString("dd/MM/yyyy HH:mm:ss")
        Else
            ' Asignar la fecha seleccionada al TextBox en formato dd/MM/yyyy
            entradacompleto = MCEntrada.SelectionStart.Date + DateTime.Now.TimeOfDay
            TxtEntrada.Text = entradacompleto.ToString("dd/MM/yyyy HH:mm:ss")

            ' Actualizar la fecha mínima de MCSalida
            MCSalida.MinDate = MCEntrada.SelectionStart.AddDays(1)
            ' Actualizar TxtSalida con el día siguiente de la entrada
            salidacompleto = MCEntrada.SelectionStart.Date.AddDays(1) + New TimeSpan(12, 0, 0)
            TxtSalida.Text = salidacompleto.ToString("dd/MM/yyyy HH:mm:ss")
        End If
    End Sub

    Private Sub MCSalida_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MCSalida.DateChanged
        ' Validar que la fecha de salida no sea menor a la fecha de entrada + 1 día
        If MCSalida.SelectionStart < MCEntrada.SelectionStart.AddDays(1) Then
            MsgBox("La fecha de salida debe ser al menos un día después de la fecha de entrada.", MsgBoxStyle.Critical, "Error")
            MCSalida.SetDate(MCEntrada.SelectionStart.AddDays(1)) ' Restablecer a la fecha de entrada + 1 día
            salidacompleto = MCEntrada.SelectionStart.Date.AddDays(1) + New TimeSpan(12, 0, 0)
            TxtSalida.Text = salidacompleto.ToString("dd/MM/yyyy HH:mm:ss")
        Else
            ' Asignar la fecha en TxtSalida si es válida.
            salidacompleto = MCSalida.SelectionStart.Date + New TimeSpan(12, 0, 0)
            TxtSalida.Text = salidacompleto.ToString("dd/MM/yyyy HH:mm:ss")
        End If
    End Sub

    Private Sub BtnConsultarDispon_Click(sender As Object, e As EventArgs) Handles BtnConsultarDispon.Click
        query = "EXEC VerificarReserva " & TxtHabitacion.Text & ", '" & entradacompleto.ToString("yyyy/MM/dd") & "', '" & salidacompleto.ToString("yyyy/MM/dd") & "'"
        If con.val(query) = False Then 'si retorna un valor entra al ciclo
            MsgBox("Habitacion disponible", MsgBoxStyle.Information, "Aviso")
            BtnReservar.Visible = True
        Else
            MsgBox("Habitacion no disponible para la fecha", MsgBoxStyle.Critical, "Aviso")
            BtnReservar.Visible = False
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
        ' Configurar el primer MonthCalendar para que no permita seleccionar fechas pasadas
        MCEntrada.MinDate = DateTime.Today
        ' Configurar el segundo MonthCalendar con una fecha mínima inicial
        MCSalida.MinDate = DateTime.Today.AddDays(1)
        TxtEntrada.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        Lblhorafecha.Text = DateTime.Now.Hour
        TxtHabitacion.Text = numhab
        Carga()
        autonum()
        ' Limpiar el ComboBox antes de agregar opciones
        CmbHabitacion.Items.Clear()

        ' Convertir numhab en un número entero
        Dim numHabitacion As Integer
        If Integer.TryParse(numhab, numHabitacion) Then
            Select Case numHabitacion
                Case 2, 3, 4, 10, 11, 12, 13, 18 To 35
                    CmbHabitacion.Items.AddRange(New String() {"Sencilla", "Pareja"})

                Case 1, 7, 9, 15
                    CmbHabitacion.Items.AddRange(New String() {"Sencilla", "Doble"})

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

        ' Inicializar TxtSalida con el día siguiente de la entrada
        salidacompleto = DateTime.Today.AddDays(1) + New TimeSpan(12, 0, 0)
        TxtSalida.Text = salidacompleto.ToString("dd/MM/yyyy HH:mm:ss")
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