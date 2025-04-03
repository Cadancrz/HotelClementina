Imports System.Data.SqlClient 'libreria para conexion con SQL
Public Class RegistroEmpresas
    Dim query As String 'variable para guardar las consultas
    Dim con As New ClsConexion 'variable conexion
    Dim dv As New DataView 'variable dataview
    Dim resultado As Integer 'variable para preguntar si desea eliminar un cliente
    Dim entrar As String = "si" 'variable para controlar la entrada a los gridview
    Dim export As SqlDataReader 'variable datareader
    Dim codemp, nomemp As String 'variables para el codigo y nombre de la empresa
    Public Property TextBoxDestino As TextBox

    Private totalPaginas As Integer = 1 ' Variable para almacenar el total de páginas
    Private paginaActual As Integer = 1
    Private RegistrosPorPagina As Integer = 500 ' Cambia este valor según lo que necesites

    Public Sub Carga(Optional ByVal filtroNombre As String = "", Optional ByVal pagina As Integer = 1, Optional ByVal registrosPorPagina As Integer = 100)
        Try
            Dim db As New ClsConexion()

            Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@FiltroNombre", If(String.IsNullOrEmpty(filtroNombre), DBNull.Value, filtroNombre)),
            New SqlParameter("@Pagina", pagina),
            New SqlParameter("@RegistrosPorPagina", registrosPorPagina)
        }

            Dim dt As DataTable = db.EjecutarSP("ProCargaEmpresa", parametros)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                With DGVEmpresa
                    .MultiSelect = False
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .DataSource = dt
                End With
            Else
                DGVEmpresa.DataSource = Nothing
            End If

            ' Calcular el total de páginas
            totalPaginas = Math.Ceiling(ObtenerTotalRegistros(filtroNombre) / registrosPorPagina)

            ' Actualizar el estado de los botones de paginación
            ActualizarEstadoBotones()

        Catch ex As Exception
            MsgBox("Error al cargar los empleados: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function ObtenerTotalRegistros(Optional ByVal filtroNombre As String = "") As Integer
        Try
            Dim db As New ClsConexion()
            Dim query As String = "SELECT COUNT(*) FROM Empresa"
            Dim parametros As New List(Of SqlParameter)()

            If Not String.IsNullOrEmpty(filtroNombre) Then
                query &= " WHERE Nom_Empresa LIKE @FiltroNombre"
                parametros.Add(New SqlParameter("@FiltroNombre", "%" & filtroNombre & "%"))
            End If

            Dim resultado As Object = db.EjecutarEscalar(query, parametros)

            If resultado IsNot Nothing Then
                Return Convert.ToInt32(resultado)
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox("Error al obtener el total de registros: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return 0
        End Try
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub RegistroEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga()
        Me.TxtNombre.Select() 'coloca el cursor en el texbox
    End Sub

    Private Sub DGVEmpresa_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVEmpresa.CellMouseClick
        If entrar = "si" Then 'si la variable es igual a si entra al ciclo
            TxtCodigo.Text = DGVEmpresa.CurrentRow.Cells(0).Value 'llena la columna del gridview
            TxtNombre.Text = DGVEmpresa.CurrentRow.Cells(1).Value 'llena la columna del gridview
        End If

        'PARA EXPORTAR A HUESPEDES
        If reservacion = "empresa" Then 'para tomar el nombre del cliente en la factura
            query = "select Cod_Empresa, Nom_Empresa from Empresa where Nom_Empresa = '" & TxtNombre.Text & "'" 'guarda la consulta en la variable query
            If con.val(query) = True Then 'si la consulta retorna un valor entra al ciclo
                export = con.reader(query) 'exporta lo que contiene la consulta
                While export.Read 'mientras exporta sigue leyendo
                    codemp = export.GetString(0) 'exporta a la variable
                    nomemp = export.GetString(1) 'exporta a la variable
                End While
                export.Close() 'cierra la exportacion
                TxtCodigo.Text = codemp 'iguala lo que contiene la variable al texbox
                TxtNombre.Text = nomemp 'iguala lo que contiene la variable al texbox
            End If
            RegistroHuespedes.TxtEmpresa.Text = TxtNombre.Text & vbCrLf & TxtCodigo.Text 'iguala los texbox
            reservacion = "" 'vacia la variable
            limpiar() 'ejecuta la funcion limpiar
            Me.Close() 'cierra el formulario
        End If
    End Sub

    Private Sub limpiar() 'funcion para limpiar los campos
        TxtCodigo.Text = "" 'vacia el texbox
        TxtNombre.Text = "" 'vacia el texbox
        TxtCodigo.Enabled = True 'habilita el texbox
        Carga()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If TxtCodigo.Text = "" Or TxtNombre.Text = "" Then 'si los texbox estan vacios despliega el mensaje
            MsgBox("Campos vacíos", MsgBoxStyle.Information, "Información") 'despliega el mensaje
        Else
            query = "SELECT Cod_Empresa FROM Empresa WHERE Cod_Empresa = '" & TxtCodigo.Text & "'" 'guarda la consulta en la variable query
            If con.val(query) = True Then 'si la consulta retorna un valor entra al ciclo
                MsgBox("Esta empresa ya esta ingresada", MsgBoxStyle.Information, "Información") 'despliega el mensaje de confirmacion
            Else
                StrInsert = "INSERT INTO Empresa(Cod_Empresa, Nom_Empresa) values('" & TxtCodigo.Text & "','" & TxtNombre.Text & "')" 'ejecuta el procedimiento para incertar la consulta
                con.insertar(StrInsert) 'hace la conexion con el procedimiento
                MsgBox("Empresa ingresada exitosamente", MsgBoxStyle.Information, "Información") 'despliega el mensaje de confirmacion

                ' Registrar en la Bitácora
                Dim fecha As String = DateTime.Now.ToString("yyyy-MM-dd")
                Dim hora As String = DateTime.Now.ToString("HH:mm:ss")
                Dim descripcion As String = Login.NombreEmpleado & " registró una nueva empresa con RTN: " & TxtCodigo.Text & " con nombre: " & TxtNombre.Text

                query = "INSERT INTO Bitacora (Cod_Usu, Fch_Bita, Hrs_Bita, Obs_Bita) VALUES (" & Login.codUsu & ", '" & fecha & "', '" & hora & "', '" & descripcion & "')"
                con.insertar(query)

                limpiar() 'funcion para limpiar los texbox
                Carga() 'ejecuta la funcion para cargar los huespedes
            End If
        End If
    End Sub

    Private Sub ActualizarEstadoBotones()
        Dim tieneFilas As Boolean = (DGVEmpresa.Rows.Count > 0)
        ' Deshabilita el botón de "Anterior" si está en la primera página
        BtnAnterior.Enabled = paginaActual > 1

        ' Deshabilita el botón de "Siguiente" si está en la última página
        BtnSiguiente.Enabled = paginaActual < totalPaginas
    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        If paginaActual > 1 Then
            paginaActual -= 1
            Carga(TxtNombre.Text)
        End If
    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        If paginaActual < totalPaginas Then
            paginaActual += 1
            Carga(TxtNombre.Text)
        End If
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        paginaActual = 1 ' Reiniciar la página actual al cambiar el filtro
        Carga(TxtNombre.Text)
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If TxtCodigo.Text = "" Then 'verifica si el texbox esta vacio

            MsgBox("Cargue datos de la empresa", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje

        Else

            query = "UPDATE Empresa SET Nom_Empresa = '" & TxtNombre.Text & "' where Cod_Empresa = '" & TxtCodigo.Text & "'" 'guarda la consulta en la variable query

            con.insertar(query) 'hace la conexion con lo que tiene la variable query

            MsgBox("Datos Modificados", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje

            ' Registrar en la Bitácora
            Dim fecha As String = DateTime.Now.ToString("yyyy-MM-dd")
            Dim hora As String = DateTime.Now.ToString("HH:mm:ss")
            Dim descripcion As String = Login.NombreEmpleado & " modificó una empresa con RTN: " & TxtCodigo.Text & " con nombre: " & TxtNombre.Text

            query = "INSERT INTO Bitacora (Cod_Usu, Fch_Bita, Hrs_Bita, Obs_Bita) VALUES (" & Login.codUsu & ", '" & fecha & "', '" & hora & "', '" & descripcion & "')"
            con.insertar(query)

            Carga() 'ejecuta la funcion
            limpiar()
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If TxtCodigo.Text = "" Then 'valida si el texbox esta vacio
            MsgBox("Cargue datos de la Empresa", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
        Else
            resultado = MsgBox("Seguro que desea borrar esta Empresa?", vbOKCancel, "Informacion") 'despliega el mensaje de confirmacion
            If resultado = vbOK Then ' si presiono OK entra al ciclo
                query = "DELETE from Empresa where Cod_Empresa = '" & TxtCodigo.Text & "'" 'guarda la consulta en la variable query
                con.insertar(query) 'hace la conexion con lo que tiene la variable query

                ' Registrar en la Bitácora
                Dim fecha As String = DateTime.Now.ToString("yyyy-MM-dd")
                Dim hora As String = DateTime.Now.ToString("HH:mm:ss")
                Dim descripcion As String = Login.NombreEmpleado & " eliminó una empresa con RTN: " & TxtCodigo.Text & " con nombre: " & TxtNombre.Text

                query = "INSERT INTO Bitacora (Cod_Usu, Fch_Bita, Hrs_Bita, Obs_Bita) VALUES (" & Login.codUsu & ", '" & fecha & "', '" & hora & "', '" & descripcion & "')"
                con.insertar(query)

                limpiar() 'funcion para limpiar los texbox
                Carga() 'ejecuta la funcion para cargar los huespedes
                MsgBox("Empresa Eliminada", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje de confirmacion
            End If
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        limpiar()
    End Sub
End Class