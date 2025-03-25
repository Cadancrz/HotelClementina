Imports System.Data.SqlClient 'libreria para conexion con SQL
Public Class RegistroEmpresas
    Dim query As String 'variable para guardar las consultas
    Dim con As New ClsConexion 'variable conexion
    Dim dv As New DataView 'variable dataview
    Dim resultado As Integer 'variable para preguntar si desea eliminar un cliente
    Dim entrar As String = "si" 'variable para controlar la entrada a los gridview
    Dim export As SqlDataReader 'variable datareader
    Dim codemp, nomemp As String 'variables para el codigo y nombre de la empresa

    Private totalPaginas As Integer = 1 ' Variable para almacenar el total de páginas
    Private paginaActual As Integer = 1
    Private RegistrosPorPagina As Integer = 500 ' Cambia este valor según lo que necesites

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
            query = "select Cod_Emp, Nom_Emp from Empresa where Nom_Emp = '" & TxtNombre.Text & "'" 'guarda la consulta en la variable query
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
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        limpiar()
    End Sub

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

        Catch ex As Exception
            MsgBox("Error al cargar los empleados: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

End Class