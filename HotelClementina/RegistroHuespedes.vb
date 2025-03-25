Imports System.Data.SqlClient
Imports HotelClementina.Variables
Public Class RegistroHuespedes
    Dim query As String 'variable para las consultas
    Dim con As New ClsConexion 'variable para las conexion
    Dim dv As New DataView 'variable dataview
    Dim dvfechas As New DataView 'variable dataview
    Dim entrar As String = "si" 'variable para entrar a las funciones
    Dim export As SqlDataReader 'variable datareader
    Dim Id, tel1, tel2, tel3, emp, dir, correo, obs, nacion, proced As String 'variables para los datos del huesped
    Dim fecha1, fecha2 As Date 'variables para guardar fechas
    Dim dias As Integer 'variables para guardar los dias
    Dim resultado As Integer 'variable para mensajes de confirmacion
    Dim conthuesped As Integer 'variable contador de huespedes
    Dim tipocliente As Integer 'variable que guarda el tipo del cliente, contado/credito
    ' Variables globales para la paginación
    Private totalPaginas As Integer = 1 ' Variable para almacenar el total de páginas
    Private paginaActual As Integer = 1
    Private RegistrosPorPagina As Integer = 500 ' Cambia este valor según lo que necesites

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
                With DgvHuespedes
                    .MultiSelect = False
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .DataSource = dt
                End With
            Else
                DgvHuespedes.DataSource = Nothing
            End If

            ' Obtener el total de productos y calcular la paginación
            totalPaginas = Math.Ceiling(ObtenerTotalRegistros(cadena1, cadena2, cadena3, cadena4) / RegistrosPorPagina)

            ' Actualizar los botones de paginación
            ActualizarEstadoBotones()

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
                LblContador.Text = conthuesped 'iguala el label al contador
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

    Private Sub RegistroHuespedes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbNacion.DropDownStyle = ComboBoxStyle.DropDownList 'Evita el ingreso de letras en el combobox
        CmbTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList
        If codusuario = 1 Then 'si la variable es usuario administrador entra al cliclo
            BtnEliminar.Visible = True 'habilita el boton
        Else
            BtnEliminar.Visible = False 'desabilita el boton
        End If
        Try
            limpiar() 'llama la funcion
            Carga() 'llama la funcion para cargar el gridview
            ObtenerTotalRegistros() 'llama la funcion
            CmbTipoCliente.SelectedItem = "Contado" 'selecciona el item "Contado"
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
                con.cargarDgv("exec ProCargaHuespedes '" & Palabra(0) & "',2,3,4", DgvHuespedes, dv) 'llama la funcion para cargar el gridview
            ElseIf cadenas = 1 Then
                result = Palabra(0) & "%" & Palabra(1)
                con.cargarDgv("exec ProCargaHuespedes '" & Palabra(0) & "','" & Palabra(1) & "',3,4", DgvHuespedes, dv) 'llama la funcion para cargar el gridview
            ElseIf cadenas = 2 Then
                result = Palabra(0) & "%" & Palabra(1)
                con.cargarDgv("exec ProCargaHuespedes '" & Palabra(0) & "','" & Palabra(1) & "','" & Palabra(2) & "',4", DgvHuespedes, dv) 'llama la funcion para cargar el gridview
            ElseIf cadenas = 3 Then
                result = Palabra(0) & "%" & Palabra(1)
                con.cargarDgv("exec ProCargaHuespedes '" & Palabra(0) & "','" & Palabra(1) & "','" & Palabra(2) & "','" & Palabra(3) & "'", DgvHuespedes, dv) 'llama la funcion para cargar el gridview
            End If
        Else
            con.cargarDgv("exec ProCargaHuespedes" & " 1,2,3,4", DgvHuespedes, dv) 'llama la funcion para cargar el gridview
        End If
    End Sub

    Private Sub TxtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBusqueda.KeyPress
        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.Handled) <= 122 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Then 'solo letras
            e.Handled = False 'acepte letras
        Else
            e.Handled = True 'si presiona otras teclas que no sean letras
        End If
    End Sub

    Private Sub TxtBusqueda_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtBusqueda.MouseClick
        TxtBusqueda.Text = "" 'limpia el campo
    End Sub

    Private Sub TxtIdentidad_TextChanged(sender As Object, e As EventArgs) Handles TxtIdentidad.TextChanged
        Dim area As String
        Dim textoValidado As String = ""

        ' Validar la entrada del TextBox
        For Each c As Char In TxtIdentidad.Text
            If Char.IsLetter(c) AndAlso Char.IsUpper(c) OrElse Char.IsDigit(c) OrElse c = " " OrElse c = "-" Then
                textoValidado &= c
            End If
        Next

        ' Actualizar el TextBox con el texto validado
        TxtIdentidad.Text = textoValidado
        TxtIdentidad.SelectionStart = TxtIdentidad.Text.Length

        If Len(TxtIdentidad.Text) > 4 Then
            area = Mid(TxtIdentidad.Text, 1, 4)
            query = "select Nom_Muni from Municipios where Cod_Muni = '" & area & "'"

            If con.val(query) = True Then
                export = con.reader(query)
                While export.Read
                    TxtProcedencia.Text = export.GetString(0)
                End While
                export.Close()
            End If
        Else
            TxtProcedencia.Text = "" ' Limpiar TxtProcedencia si la longitud es menor o igual a 4
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        limpiar()
    End Sub

    Private Sub TxtNombres_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombres.KeyPress
        ' Verifica si la tecla presionada es una letra.
        If Char.IsLetter(e.KeyChar) Then
            ' Convierte la letra a mayúscula.
            e.KeyChar = Char.ToUpper(e.KeyChar)
        ElseIf e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            ' Si no es una letra, retroceso o espacio, ignora la tecla.
            e.Handled = True
        End If
    End Sub

    Private Sub TxtTel1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTel1.KeyPress
        ' Verifica si la tecla presionada es un número, espacio, "+", "-" o una tecla de control (como retroceso).
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> " " AndAlso e.KeyChar <> "+" AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> ControlChars.Back Then
            ' Si no es un carácter permitido, ignora la tecla presionada.
            e.Handled = True
        End If
    End Sub

    Private Sub TxtTel2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTel2.KeyPress
        ' Verifica si la tecla presionada es un número, espacio, "+", "-" o una tecla de control (como retroceso).
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> " " AndAlso e.KeyChar <> "+" AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> ControlChars.Back Then
            ' Si no es un carácter permitido, ignora la tecla presionada.
            e.Handled = True
        End If
    End Sub

    Private Sub TxtProcedencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtProcedencia.KeyPress
        If TxtProcedencia.Text = "" Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        Else
            e.KeyChar = Char.ToLower(e.KeyChar)
        End If
    End Sub

    Private Sub BtnEmpresa_Click(sender As Object, e As EventArgs) Handles BtnEmpresa.Click
        reservacion = "empresa" 'iguala la variable al texto
        RegistroEmpresas.TxtCodigo.Text = "" 'vacia el texbox
        RegistroEmpresas.TxtNombre.Text = "" 'vacia el texbox
        RegistroEmpresas.TxtNombre.Enabled = True 'habilita el texbox
        RegistroEmpresas.ShowDialog() 'muestra el formulario
    End Sub

    Private Sub DgvHuespedes_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvHuespedes.CellMouseClick
        Try
            If entrar = "si" Then
                TxtNombres.Text = DgvHuespedes.CurrentRow.Cells(1).Value
                TxtIdentidad.Enabled = False
            Else
                TxtNombres.Text = DgvHuespedes.CurrentRow.Cells(1).Value
                TxtIdentidad.Enabled = False
            End If

            ' Llamar al procedimiento almacenado ProCargaHuespedes con el nombre del cliente
            Dim db As New ClsConexion()
            Dim parametros As New List(Of SqlParameter)()
            parametros.Add(New SqlParameter("@cadena1", TxtNombres.Text))
            Dim dt As DataTable = db.EjecutarSP("ProCargaHuespedes", parametros)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)

                TxtIdentidad.Text = row("Identidad").ToString()
                TxtTel1.Text = If(IsDBNull(row("Teléfono 1")), "", row("Teléfono 1").ToString())
                TxtTel2.Text = If(IsDBNull(row("Teléfono 2")), "", row("Teléfono 2").ToString())
                TxtEmpresa.Text = If(IsDBNull(row("Empresa")), "", row("Empresa").ToString())
                CmbNacion.Text = If(IsDBNull(row("Nacionalidad")), "", row("Nacionalidad").ToString())
                TxtProcedencia.Text = If(IsDBNull(row("Procedencia")), "", row("Procedencia").ToString())
                TxtObservaciones.Text = If(IsDBNull(row("Observaciones")), "", row("Observaciones").ToString())

                If row("Tipo Cliente").ToString() = "0" Then
                    CmbTipoCliente.SelectedItem = "Credito"
                Else
                    CmbTipoCliente.SelectedItem = "Contado"
                End If
            End If

            ' PARA EXPORTAR AL SALON DE EVENTOS
            If reservacion = "cliente" Then
                Salon.TxtNombre.Text = DgvHuespedes.CurrentRow.Cells(0).Value
                Salon.Show()
                Me.Close()
            End If

            ' PARA EXPORTAR A FACTURACION(QUE RELLENA FACTURA INDIVIDUAL)
            If reservacion = "factura" Then
                Dim db2 As New ClsConexion()
                Dim parametros2 As New List(Of SqlParameter)()
                parametros2.Add(New SqlParameter("@Nom_Cli", TxtNombres.Text))
                Dim dt2 As DataTable = db2.EjecutarSP("ProCargaCli", parametros2)

                If dt2 IsNot Nothing AndAlso dt2.Rows.Count > 0 Then
                    TxtIdentidad.Text = dt2.Rows(0)("Cod_Cli").ToString()
                End If

                TxtBusqueda.Text = ""
                Facturacion.TxtCliente.Text = TxtNombres.Text
                Facturacion.TxtCodCli.Text = TxtIdentidad.Text
                Facturacion.Show()
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ActualizarEstadoBotones()
        Dim tieneFilas As Boolean = (DgvHuespedes.Rows.Count > 0)
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

    Private Sub limpiar() 'funcion para limpiar los campos
        TxtIdentidad.Text = "" 'limpia el campo
        TxtNombres.Text = "" 'limpia el campo
        TxtTel1.Text = "" 'limpia el campo
        TxtTel2.Text = "" 'limpia el campo
        TxtEmpresa.Text = "" 'limpia el campo
        CmbNacion.SelectedIndex = -1 'limpia el campo
        TxtProcedencia.Text = ""
        TxtBusqueda.Text = "" 'limpia el campo
        TxtObservaciones.Text = "" 'limpia el campo
        CmbTipoCliente.SelectedValue = 1 'establece el combobox en el primer valor
        TxtIdentidad.Enabled = True 'muestra el texbox
    End Sub

End Class