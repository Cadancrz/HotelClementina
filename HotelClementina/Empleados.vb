Imports System.Data.SqlClient
Public Class Empleados
    Dim query As String 'variable para las consultas
    Dim con As New ClsConexion 'variable conexion
    'Dim func As New Funciones 'variable para conectarse con la clase Funciones
    Dim dv As New DataView 'variable dataview
    Dim codcargo, sexo As Integer 'variables para guardar datos de los cargos y el sexo
    Dim export As SqlDataReader
    Dim StrInsert As String ' Declaración global de StrInsert

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodEmp.Focus()
        Carga()
        LlenarComboBoxCargos()
    End Sub

    Private Sub txtbusemp_keypress(sender As Object, e As KeyPressEventArgs) Handles txtBusEmp.KeyPress
        If Asc(e.KeyChar) = 32 And (txtBusEmp.SelectionStart <> 0) Then 'acepta solo un espacio
            If txtBusEmp.Text.Substring(txtBusEmp.SelectionStart - 1, 1) <> " " Then 'si hay un espacio entra al ciclo
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

    Private Sub txtBusEmp_TextChanged(sender As Object, e As EventArgs) Handles txtBusEmp.TextChanged
        Carga(txtBusEmp.Text)
    End Sub

    Private Sub txtCodEmp_TextChanged(sender As Object, e As EventArgs) Handles txtCodEmp.TextChanged

    End Sub

    Private Sub txtCodEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodEmp.KeyPress
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or e.KeyChar = "-" Then ' Números, borrador y guion
            e.Handled = False ' Acepta su ingreso
        Else
            e.Handled = True ' Niega su ingreso
        End If
    End Sub

    Private Sub txtNomEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomEmp.KeyPress
        If Asc(e.KeyChar) = 32 And (txtNomEmp.SelectionStart <> 0) Then 'acepta solo un espacio
            If txtNomEmp.Text.Substring(txtNomEmp.SelectionStart - 1, 1) <> " " Then 'si hay un espacio entra al ciclo
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

    Private Sub txtApeEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApeEmp.KeyPress
        If Asc(e.KeyChar) = 32 And (txtNomEmp.SelectionStart <> 0) Then 'acepta solo un espacio
            If txtNomEmp.Text.Substring(txtNomEmp.SelectionStart - 1, 1) <> " " Then 'si hay un espacio entra al ciclo
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

    Private Sub txtTelEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelEmp.KeyPress
        If IsNumeric(e.KeyChar) And (txtTelEmp.SelectionStart <> 4) Then 'si el dato es numerico y la seleccion es diferente de 4 entra al al ciclo
            e.Handled = False 'acepta su ingreso
        ElseIf IsNumeric(e.KeyChar) And (txtTelEmp.SelectionStart) Then 'si el dato es numerico y no hay seleccion entra al al ciclo
            txtTelEmp.Text &= "-" 'si el texbox contiene el guion
            txtTelEmp.SelectionStart = txtTelEmp.TextLength 'cuenta el string en el texbox
            e.Handled = False 'acepta su ingreso
        ElseIf Asc(e.KeyChar) = 8 Then 'retroceso
            e.Handled = False 'acepta su ingreso
        Else
            e.Handled = True 'niega su ingreso
        End If
    End Sub

    Private Sub TxtCorEmp_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtCorEmp.Validating
        If Not TxtCorEmp.Text.Contains("@") Then
            ErrorProviderCorreo.SetError(TxtCorEmp, "El correo electrónico debe contener '@'")
        Else
            ErrorProviderCorreo.SetError(TxtCorEmp, "") ' Limpia el error si es válido
            e.Cancel = False ' Permite que el control pierda el foco
        End If
    End Sub

    Public Sub Carga(Optional ByVal filtroNombre As String = "")
        Try
            Dim db As New ClsConexion()

            Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@FiltroNombre", If(String.IsNullOrEmpty(filtroNombre), DBNull.Value, filtroNombre))
        }

            Dim dt As DataTable = db.EjecutarSP("ProCargaEmp", parametros)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                With DgvEmpleados
                    .MultiSelect = False
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .DataSource = dt
                End With
            Else
                DgvEmpleados.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los empleados: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub LlenarComboBoxCargos()
        Try
            Dim db As New ClsConexion()
            Dim dt As DataTable = db.EjecutarSP("ObtenerCargos", Nothing)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                CmbCargo.DataSource = dt
                CmbCargo.DisplayMember = "Tipo_Cargo" ' Muestra el nombre del usuario
                CmbCargo.ValueMember = "Cod_Cargo" ' Guarda el código del usuario internamente
                CmbCargo.SelectedIndex = -1 ' Deja sin selección inicial
            Else
                CmbCargo.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los cargos: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub TxtSueldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSueldo.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then 'si las teclas presionadas estan fuera de estos rangos las bloquea
            e.Handled = False 'acepte su ingreso
        Else
            e.Handled = True 'niega su ingreso
        End If
    End Sub

    Private Sub TxtSeguro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSeguro.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then 'si las teclas presionadas estan fuera de estos rangos las bloquea
            e.Handled = False 'acepte su ingreso
        Else
            e.Handled = True 'niega su ingreso
        End If
    End Sub

    Private Sub limpiar() 'funcion para limpiar los campos
        txtCodEmp.Text = "" 'limpia el campo
        txtNomEmp.Text = "" 'limpia el campo
        txtApeEmp.Text = "" 'limpia el campo
        CmbSexo.SelectedIndex = -1 'limpia el campo
        CmbFchIniEmp.Text = "" 'limpia el campo
        CmbFchNacim.Text = "" 'limpia el campo
        TxtCorEmp.Text = "" 'limpia el campo
        txtTelEmp.Text = "" 'limpia el campo
        CmbCargo.SelectedIndex = -1 'limpia el campo
        txtDirEmp.Text = "" 'limpia el campo
        'TxtSueldo.Text = "0" 'establece en 0 el campo
        'TxtSeguro.Text = "0" 'establece en 0 el campo
        CmbFchIniEmp.Text = "" 'limpia el campo
        CmbFchNacim.Text = "" 'limpia el campo
        CmbSexo.Enabled = True 'habilita el combobox
        CmbFchNacim.Value = Date.Today 'establece el combobox a la fecha actual
        CmbFchIniEmp.Value = Date.Today 'establece el combobox a la fecha actual
        txtCodEmp.Enabled = True 'habilita el texbox
    End Sub

    Private Sub CmbFchNacim_ValueChanged(sender As Object, e As EventArgs) Handles CmbFchNacim.ValueChanged
        CalcularEdad()
    End Sub

    Private Sub CmbSexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSexo.SelectedIndexChanged
        If CmbSexo.Text = "M" Then
            sexo = 0
        Else
            sexo = 1
        End If
    End Sub

    Private Sub DgvEmpleados_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvEmpleados.CellMouseClick
        If e.RowIndex >= 0 Then ' Asegura que se hizo clic en una fila válida
            Dim filaSeleccionada As DataGridViewRow = DgvEmpleados.Rows(e.RowIndex)

            txtCodEmp.Text = filaSeleccionada.Cells(0).Value.ToString() ' Identidad
            txtNomEmp.Text = filaSeleccionada.Cells(1).Value.ToString() ' Nombres
            txtApeEmp.Text = filaSeleccionada.Cells(2).Value.ToString() ' Apellidos
            CmbFchNacim.Value = CDate(filaSeleccionada.Cells(3).Value) ' Fecha de Nacimiento

            Dim sexoTexto As String = filaSeleccionada.Cells(4).Value.ToString()
            If sexoTexto = "M" Then
                CmbSexo.SelectedIndex = 0
                sexo = 0 ' Actualizar la variable 
            Else
                CmbSexo.SelectedIndex = 1
                sexo = 1 ' Actualizar la variable 
            End If

            txtTelEmp.Text = filaSeleccionada.Cells(5).Value.ToString() ' Telefono
            CmbFchIniEmp.Value = CDate(filaSeleccionada.Cells(6).Value) ' Fecha de Inicio
            TxtCorEmp.Text = filaSeleccionada.Cells(7).Value.ToString() ' Email
            txtDirEmp.Text = filaSeleccionada.Cells(8).Value.ToString() ' Dirección

            Dim cargoTexto As String = filaSeleccionada.Cells(9).Value.ToString() ' Cargo
            CmbCargo.Text = cargoTexto

            TxtSueldo.Text = filaSeleccionada.Cells(10).Value.ToString() ' Sueldo
            TxtSeguro.Text = filaSeleccionada.Cells(11).Value.ToString() ' Seguro
            CkHabDes.Checked = CBool(filaSeleccionada.Cells(12).Value) ' Estado

            txtCodEmp.Enabled = False
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtCodEmp.Text = "" Or txtNomEmp.Text = "" Or TxtSueldo.Text = "" Then
            MsgBox("No se puede ingresar, Campo vacio!", MsgBoxStyle.Information, "Información")
        Else
            query = "select * from Empleados where Cod_Emp='" & txtCodEmp.Text & "'"
            If con.val(query) = False Then
                ' Obtener el código del cargo seleccionado
                Dim codCargo As Integer = CInt(CmbCargo.SelectedValue)

                ' Obtener la fecha de inicio
                Dim fechaInicio As Date = CmbFchIniEmp.Value.Date

                ' Escapar comillas simples en los nombres para evitar errores
                Dim nomEmpEscapado As String = txtNomEmp.Text.Replace("'", "''")

                StrInsert = "INSERT INTO Empleados (Cod_Emp, Nom_Emp, Ape_Emp, Fch_Nacim, Sex_Emp, Tel_Emp, Fec_Ini_Emp, Cor_Emp, Dir_Emp, Cod_Cargo, Sueldo_Emp, Seguro, HabDesEmp) 
                            VALUES ('" & txtCodEmp.Text & "', '" & txtNomEmp.Text & "', '" & txtApeEmp.Text & "', '" & CmbFchNacim.Value.ToString("yyyy-MM-dd") & "', '" & sexo & "', '" & txtTelEmp.Text & "', '" & fechaInicio.ToString("yyyy-MM-dd") & "', '" & TxtCorEmp.Text & "', '" & txtDirEmp.Text & "', '" & codCargo & "', '" & TxtSueldo.Text & "', '" & TxtSeguro.Text & "', '" & CInt(CkHabDes.Checked) & "')"
                con.insertar(StrInsert)

                ' Registrar en la Bitácora
                Dim fecha As String = DateTime.Now.ToString("yyyy-MM-dd")
                Dim hora As String = DateTime.Now.ToString("HH:mm:ss")
                Dim descripcion As String = Login.NombreEmpleado & " registró un nuevo empleado con Identidad: " & txtCodEmp.Text & " con nombre: " & txtNomEmp.Text

                query = "INSERT INTO Bitacora (Cod_Usu, Fch_Bita, Hrs_Bita, Obs_Bita) VALUES (" & Login.codUsu & ", '" & fecha & "', '" & hora & "', '" & descripcion & "')"
                con.insertar(query)

                limpiar()
                Carga()
                MsgBox("Registro Guardado", MsgBoxStyle.Information, "Información")
                txtCodEmp.Focus()
            Else
                MsgBox("Este codigo de empleado ya esta registrado", MsgBoxStyle.Information, "Información")
            End If
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtCodEmp.Text = "" Or txtNomEmp.Text = "" Or TxtSueldo.Text = "" Then
            MsgBox("Cargue datos de la lista", MsgBoxStyle.Information, "Información")
        Else
            ' Obtener el código del cargo seleccionado
            Dim codCargo As Integer = CInt(CmbCargo.SelectedValue)

            ' Obtener la fecha de inicio
            Dim fechaInicio As Date = CmbFchIniEmp.Value.Date

            ' Obtener el estado del CheckBox
            Dim estado As Integer = CInt(CkHabDes.Checked)

            query = "UPDATE Empleados SET Nom_Emp = '" & txtNomEmp.Text & "', Ape_Emp = '" & txtApeEmp.Text & "', Fch_Nacim = '" & CmbFchNacim.Value.ToString("yyyy-MM-dd") & "', Sex_Emp = '" & sexo & "', Tel_Emp = '" & txtTelEmp.Text & "', Fec_Ini_Emp = '" & fechaInicio.ToString("yyyy-MM-dd") & "', Cor_Emp = '" & TxtCorEmp.Text & "', Dir_Emp = '" & txtDirEmp.Text & "', Cod_Cargo = '" & codCargo & "', Sueldo_Emp = '" & TxtSueldo.Text & "', Seguro = '" & TxtSeguro.Text & "', HabDesEmp = '" & estado & "' WHERE Cod_Emp = '" & txtCodEmp.Text & "'"

            con.insertar(query)

            ' Registrar en la Bitácora
            Dim fecha As String = DateTime.Now.ToString("yyyy-MM-dd")
            Dim hora As String = DateTime.Now.ToString("HH:mm:ss")
            Dim descripcion As String = Login.NombreEmpleado & " modificó un empleado con Identidad: " & txtCodEmp.Text & " y nombre: " & txtNomEmp.Text

            query = "INSERT INTO Bitacora (Cod_Usu, Fch_Bitacora, Hora_Bitacora, Desc_Bitacora) VALUES (" & Login.codUsu & ", '" & fecha & "', '" & hora & "', '" & descripcion & "')"
            con.insertar(query)

            limpiar()
            Carga()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ' Si el CheckBox no está marcado, preguntar si desea eliminar permanentemente
        Dim resultado As DialogResult = MsgBox("¿Está seguro de que desea eliminar permanentemente a este empleado?", MsgBoxStyle.YesNo, "Confirmar Eliminación")

        If resultado = DialogResult.Yes Then
            ' Eliminar permanentemente al empleado
            query = "DELETE FROM Empleados WHERE Cod_Emp = '" & txtCodEmp.Text & "'"
            con.insertar(query)

            MsgBox("Empleado eliminado permanentemente.", MsgBoxStyle.Information, "Información")

            ' Registrar en la Bitácora
            Dim fecha As String = DateTime.Now.ToString("yyyy-MM-dd")
            Dim hora As String = DateTime.Now.ToString("HH:mm:ss")
            Dim descripcion As String = Login.NombreEmpleado & " Eliminó un empleado con Identidad: " & txtCodEmp.Text & " con nombre: " & txtNomEmp.Text

            query = "INSERT INTO Bitacora (Cod_Usu, Fch_Bita, Hrs_Bita, Obs_Bita) VALUES (" & Login.codUsu & ", '" & fecha & "', '" & hora & "', '" & descripcion & "')"
            con.insertar(query)

            limpiar()
            Carga()
        End If
    End Sub

    Private Sub CalcularEdad()
        Try
            If CmbFchNacim.Value <> Date.MinValue Then ' Verifica si se ha seleccionado una fecha
                Dim fechaNacimiento As Date = CmbFchNacim.Value
                Dim fechaActual As Date = Date.Today

                Dim edad As Integer = fechaActual.Year - fechaNacimiento.Year

                ' Ajusta la edad si aún no ha cumplido años este año
                If fechaActual.Month < fechaNacimiento.Month OrElse (fechaActual.Month = fechaNacimiento.Month And fechaActual.Day < fechaNacimiento.Day) Then
                    edad -= 1
                End If
                TxtEdad.Text = edad.ToString()
            Else
                TxtEdad.Text = "" ' Limpia el campo si no hay fecha seleccionada
            End If
        Catch ex As Exception
            MsgBox("Error al calcular la edad: " & ex.Message, MsgBoxStyle.Critical, "Error")
            TxtEdad.Text = "" ' Limpia el campo en caso de error
        End Try
    End Sub
End Class