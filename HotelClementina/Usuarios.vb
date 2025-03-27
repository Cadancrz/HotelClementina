Imports System.Data.SqlClient 'libreria de SQL
Public Class Usuarios
    Dim query As String 'variable para las consultas
    Dim con As New ClsConexion 'variable conexion
    Dim dv As New DataView 'para los empleados
    Dim dvusu As New DataView 'para los usuarios
    Dim entrar As String 'variable para entrar a las funciones
    Dim tipo As Integer

    Public Sub Carga(Optional ByVal filtroNombre As String = "")
        Try
            Dim db As New ClsConexion()

            Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@FiltroNombre", If(String.IsNullOrEmpty(filtroNombre), DBNull.Value, filtroNombre))
        }

            Dim dt As DataTable = db.EjecutarSP("ProSelecEmpUsu", parametros)
            LblCodigo.Text = con.autonum("exec ProSelecCodUsu", "exec ProSelectMaxCodUsu") 'manda a llamar la funcion del autonumerado
            con.cargarDgv("exec ProSelecDatosUsus", DgvUsuarios, dvusu) 'funcion para llenar el gridview
            RbInvitado.Checked = True 'coloca en chek

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                With DgvEmp
                    .MultiSelect = False
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .DataSource = dt
                End With
            Else
                DgvEmp.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los empleados: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        Carga(TxtBusqueda.Text)
    End Sub

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga()
    End Sub

    Private Sub TxtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBusqueda.KeyPress
        If Asc(e.KeyChar) = 32 And (TxtBusqueda.SelectionStart <> 0) Then 'acepta solo un espacio
            If TxtBusqueda.Text.Substring(TxtBusqueda.SelectionStart - 1, 1) <> " " Then 'si hay un espacio entra al ciclo
                e.Handled = False 'acepta su ingreso
            Else
                e.Handled = True 'niega su ingreso
            End If
        ElseIf Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Then 'minusculas
            e.Handled = False 'acepta su ingreso
        ElseIf Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Then 'mayusculas
            e.Handled = False 'acepta su ingreso
        ElseIf Asc(e.KeyChar) = 8 Then 'borrador
            e.Handled = False 'acepta su ingreso
        ElseIf Asc(e.KeyChar) = 96 Then 'acento
            e.Handled = False 'acepta su ingreso
        Else
            e.Handled = True 'niega su ingreso
        End If
    End Sub

    Private Sub DgvEmp_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvEmp.CellMouseClick
        If entrar = "si" Then
            TxtNombre.Text = DgvEmp.CurrentRow.Cells(0).Value 'iguala el texbox a la columna de la fila seleccionada
            TxtIdentidad.Text = DgvEmp.CurrentRow.Cells(1).Value 'iguala el texbox a la columna de la fila seleccionada
        Else
            TxtNombre.Text = DgvEmp.CurrentRow.Cells(0).Value 'iguala el texbox a la columna de la fila seleccionada
            TxtIdentidad.Text = DgvEmp.CurrentRow.Cells(1).Value 'iguala el texbox a la columna de la fila seleccionada
        End If
    End Sub

    Private Sub DgvUsuarios_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvUsuarios.CellMouseClick
        LblCodigo.Text = DgvUsuarios.CurrentRow.Cells(0).Value 'iguala el label a la columna de la fila seleccionada
        TxtIdentidad.Text = DgvUsuarios.CurrentRow.Cells(1).Value 'iguala el combobox a la columna de la fila seleccionada
        TxtNombre.Text = DgvUsuarios.CurrentRow.Cells(2).Value 'iguala el combobox a la columna de la fila seleccionada
        TxtId.Text = DgvUsuarios.CurrentRow.Cells(3).Value 'iguala el combobox a la columna de la fila seleccionada
        TxtContraseña.Text = DgvUsuarios.CurrentRow.Cells(4).Value 'iguala el combobox a la columna de la fila seleccionada
        If DgvUsuarios.CurrentRow.Cells(5).Value = "Administrador" Then 'si el usuario es administrador entra al ciclo
            RbAdmin.Checked = True 'quita el chek
        Else
            RbInvitado.Checked = True 'coloca el chek
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If TxtNombre.Text = "" Then 'si el campo esta vacio entra el ciclo
                MsgBox("Elija un empleado", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
            Else
                If TxtId.Text = "" Then
                    MsgBox("Escriba Id del usuario", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
                Else
                    If TxtContraseña.Text = "" Then 'si el campo esta vacio entra el ciclo
                        MsgBox("Escriba contraseña", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
                    Else
                        query = "exec ProValUsuExist '" & TxtIdentidad.Text & "'" 'variable que cuarda la consulta para ejecuatrse en la BD
                        If con.val(query) = True Then 'si retorna un valor entra al ciclo
                            MsgBox("Este empleado ya cuenta con un usuario registrado", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
                        Else
                            If RbAdmin.Checked = True Then 'si esta en chek entra al ciclo
                                tipo = 1 'establece el valor 1 la variable
                            ElseIf RbInvitado.Checked = True Then 'si esta en chek entra al ciclo
                                tipo = 0 'establece el valor 0 la variable
                            End If
                            StrInsert = "exec ProInsertUsuarios '" & LblCodigo.Text & "', '" & TxtIdentidad.Text & "', '" & TxtNombre.Text & "', '" & TxtId.Text & "', '" & TxtContraseña.Text & "', '" & tipo & "' , '" & codusuario & "'" 'variable que cuarda la consulta para ejecuatrse en la BD
                            con.insertar(StrInsert) 'funcion para ejecutar la consulta en la BD
                            MsgBox("Usuario Ingresado", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
                            limpiar() 'llama la funcion para limpiar los campos
                            LblCodigo.Text = con.autonum("exec ProSelecCodUsu", "exec ProSelectMaxCodUsu") 'llama la fucnion del autonumerado
                            con.cargarDgv("exec ProSelecDatosUsus", DgvUsuarios, dvusu) 'llama la funcion para llenar el gridview
                        End If
                    End If
                End If
            End If
        Catch ex As Exception 'si captura algun error despliega el mensaje
            MsgBox(ex.Message) 'MENSAJE SI HAY UN ERROR 
        End Try
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Try
            If TxtIdentidad.Text = "" Or TxtNombre.Text = "" Or TxtContraseña.Text = "" Then 'si el campo esta vacio entra el ciclo
                MsgBox("Campos vacios", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
            Else
                query = "exec ProValUsuExist '" & TxtIdentidad.Text & "'" 'variable que cuarda la consulta para ejecuatrse en la BD
                If con.val(query) = False Then 'si retorna un valor entra al ciclo
                    MsgBox("Este usuario no existe", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
                Else
                    If RbAdmin.Checked = True Then 'si esta en chek entra al ciclo
                        tipo = 1 'establece el valor 1 la variable
                    ElseIf RbInvitado.Checked = True Then 'si esta en chek entra al ciclo
                        tipo = 0 'establece el valor 0 la variable
                    End If
                    query = "exec ProModifUsus '" & TxtId.Text & "' , '" & TxtContraseña.Text & "' , '" & tipo & "' , '" & TxtIdentidad.Text & "' , '" & codusuario & "'" 'variable que cuarda la consulta para ejecuatrse en la BD
                    con.insertar(query) 'funcion para ejecutar la consulta en la BD
                    con.cargarDgv("exec ProSelecDatosUsus", DgvUsuarios, dvusu) 'llama la funcion para llenar el gridview
                    MsgBox("Datos Modificados", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
                End If
            End If
        Catch ex As Exception 'si captura algun error despliega el mensaje
            MsgBox(ex.Message) 'MENSAJE SI HAY UN ERROR 
        End Try
    End Sub

    Private Sub limpiar() 'funcion para lompiar los campos
        TxtBusqueda.Text = "" 'limpia el campo
        TxtIdentidad.Text = "" 'limpia el campo
        TxtNombre.Text = "" 'limpia el campo
        TxtContraseña.Text = "" 'limpia el campo
        TxtId.Text = "" 'limpia el campo
        LblCodigo.Text = con.autonum("exec ProSelecCodUsu", "exec ProSelectMaxCodUsu") 'llama la fucnion del autonumerado
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        limpiar() 'llama la funcion para limpiar los campos
    End Sub

    Private Sub BtnCambiarContra_Click(sender As Object, e As EventArgs) Handles BtnCambiarContra.Click
        If String.IsNullOrEmpty(TxtId.Text) OrElse String.IsNullOrEmpty(TxtContraseña.Text) Then
            MsgBox("Seleccione un usuario", MsgBoxStyle.Information, "Información")
        Else
            Dim cambiarContraForm As New CambiarContraseña()
            cambiarContraForm.TxtUsuario.Text = TxtId.Text
            AddHandler cambiarContraForm.ContraseñaModificada, AddressOf CambiarContraForm_ContraseñaModificada ' Agregar el controlador de eventos
            cambiarContraForm.ShowDialog()
        End If
    End Sub

    Private Sub CambiarContraForm_ContraseñaModificada()
        Carga() ' Recargar los datos en el DataGridView
    End Sub

End Class