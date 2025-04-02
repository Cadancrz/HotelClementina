Imports System.Data.SqlClient
Public Class HistorialReservas
    Dim query As String 'variable para las consultas
    Dim con As New ClsConexion 'variable para las conexion
    Dim dv As New DataView 'variable dataview
    Dim dvfechas As New DataView 'variable dataview
    Dim entrar As String = "si" 'variable para entrar a las funciones
    Dim export As SqlDataReader 'variable datareader

    ' Variables globales para la paginación
    Private totalPaginas As Integer = 1 ' Variable para almacenar el total de páginas
    Private paginaActual As Integer = 1
    Private RegistrosPorPagina As Integer = 500 ' Cambia este valor según lo que necesites

    Private Sub HistorialReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Carga() 'llama la funcion para cargar el gridview
            ObtenerTotalRegistros() 'llama la funcion
        Catch ex As Exception 'si captura algun error despliega el mensaje
            MsgBox(ex.Message) 'MENSAJE SI HAY UN ERROR  
        End Try
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        paginaActual = 1 ' Reiniciar la página actual
        Dim result As String
        If Len(TxtBusqueda.Text) > 0 Then
            Dim cadena As String = TxtBusqueda.Text
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

    Private Sub TxtBusqueda_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtBusqueda.MouseClick
        TxtBusqueda.Text = ""
    End Sub

    Private Sub TxtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBusqueda.KeyPress
        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.Handled) <= 122 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Then 'solo letras
            e.Handled = False 'acepte letras
        Else
            e.Handled = True 'si presiona otras teclas que no sean letras
        End If
    End Sub

    Dim dias As Integer 'variables para guardar los dias
    Dim resultado As Integer 'variable para mensajes de confirmacion
    Dim conthuesped As Integer 'variable contador de huespedes

    Private Sub DGVClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClientes.CellClick
        Try
            ' Asegúrate de que el clic no sea en el encabezado
            If e.RowIndex >= 0 Then
                ' Obtiene el valor de la primera celda (columna 0) de la fila clickeada
                Dim identidadCliente As String = DGVClientes.Rows(e.RowIndex).Cells(0).Value.ToString()

                ' Asigna la identidad al LblIdentidad
                LblIdentidad.Text = identidadCliente

                ' Carga las reservas del cliente en DgvReserva
                CargarReservas(identidadCliente)
            End If
        Catch ex As Exception
            MsgBox("Error al seleccionar el cliente: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub CargarReservas(identidadCliente As String)
        Try
            Dim db As New ClsConexion()

            Dim parametros As New List(Of SqlParameter) From {
                New SqlParameter("@Cod_Cli", identidadCliente)
            }

            Dim dt As DataTable = db.EjecutarSP("ProSelecDatosHistorialFact", parametros)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                With DgvHistorial
                    .MultiSelect = False
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .DataSource = dt
                End With
            Else
                DgvHistorial.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox("Error al cargar las reservas: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
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
                End With
            Else
                DGVClientes.DataSource = Nothing
            End If

            ' Obtener el total de productos y calcular la paginación
            totalPaginas = Math.Ceiling(ObtenerTotalRegistros(cadena1, cadena2, cadena3, cadena4) / RegistrosPorPagina)

        Catch ex As Exception
            MsgBox("Error al cargar los huéspedes: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
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
    Private Sub ActualizarEstadoBotones()
        Dim tieneFilas As Boolean = (DGVClientes.Rows.Count > 0)
        ' Deshabilita el botón de "Anterior" si está en la primera página
        BtnAnterior.Enabled = paginaActual > 1

        ' Deshabilita el botón de "Siguiente" si está en la última página
        BtnSiguiente.Enabled = paginaActual < totalPaginas
    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        If paginaActual > 1 Then
            paginaActual -= 1
            Carga(TxtBusqueda.Text)
        End If
    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        If paginaActual < totalPaginas Then
            paginaActual += 1
            Carga(TxtBusqueda.Text)
        End If
    End Sub
End Class