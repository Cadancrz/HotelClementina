Imports System.Data.SqlClient
Public Class Salon
    Dim query As String 'variable para las consultas
    Dim con As New ClsConexion 'variable conexion
    Public dv As New DataView 'variable dataview
    Dim Det As Integer 'variable para guardar datos enteros
    Dim dr As IDataReader 'para leer cadenas de datos'
    Dim export As SqlDataReader 'variable para exportaciones
    Dim horas, dias, codcli As Integer 'variables para guardar datos enteros
    Dim sonido, aire, data, neto, total, ISV, IsvTur As Double 'variables para usarse con cantidades

    Public Sub Carga(Optional ByVal filtroNombre As String = "")
        Try
            Dim db As New ClsConexion()

            Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@FiltroNombre", If(String.IsNullOrEmpty(filtroNombre), DBNull.Value, filtroNombre))
        }

            Dim dt As DataTable = db.EjecutarSP("ProCargaSalon", parametros)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                With DgvSalon
                    .MultiSelect = False
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .DataSource = dt
                End With
            Else
                DgvSalon.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los registros: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CbDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles CbDescuento.CheckedChanged
        If CbDescuento.Checked Then 'si el descuento esta chek entra al ciclo
            TxtDescuento.Visible = True 'muestra el texbox
        Else
            TxtDescuento.Visible = False 'oculta el texbox
        End If
    End Sub

    Private Sub CbCancelar_CheckedChanged(sender As Object, e As EventArgs) Handles CbCancelar.CheckedChanged
        If CbCancelar.Checked Then
            GbCancelaciones.Visible = True
        Else
            GbCancelaciones.Visible = False
        End If
    End Sub

    Private Sub BtnReservar_Click(sender As Object, e As EventArgs) Handles BtnReservar.Click
        Try
            If TxtNombre.Text = "" Then 'si el campo esta vacio entra al ciclo
                MsgBox("Escriba un cliente", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
            Else
                If Val(TxtHoras.Text) <= 0 Then 'si las horas son menores o iguales a 0
                    MsgBox("Escoja Horas", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
                Else
                    If TxtFecha.Text = "" Then 'si el campo esta vacio entra al ciclo
                        MsgBox("Seleccione una Fecha", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
                    Else
                        If TxtSubTotal.Text = "" Or TxtTotal.Text = "" Then 'si el campo esta vacio entra al ciclo
                            MsgBox("Presione el Boton Actualizar", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
                        Else
                            query = "exec ProValResSalon '" & TxtFecha.Text & "' , '" & DtpInicio.Value.Hour & ":" & DtpInicio.Value.Minute & ":" & DtpInicio.Value.Second & "' , '" & DtpFin.Value.Hour & ":" & DtpFin.Value.Minute & ":" & DtpFin.Value.Second & "' , '" & DtpInicio.Value.Hour & ":" & DtpInicio.Value.Minute & ":" & DtpInicio.Value.Second & "' , '" & DtpFin.Value.Hour & ":" & DtpFin.Value.Minute & ":" & DtpFin.Value.Second & "' , '" & DtpInicio.Value.Hour & ":" & DtpInicio.Value.Minute & ":" & DtpInicio.Value.Second & "' , '" & DtpFin.Value.Hour & ":" & DtpFin.Value.Minute & ":" & DtpFin.Value.Second & "'" 'variable que cuarda la consulta para ejecuatrse en la BD
                            If con.val(query) = True Then 'si retorna un valor entra al ciclo
                                MsgBox("Ya hay una reserva para esta fecha", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
                            Else
                                StrInsert = "exec ProInsertResSalon '" & LblCodigoRes.Text & "', '" & TxtNombre.Text & "', '" & TxtFecha.Text & "', '" & DtpInicio.Value.Hour & ":" & DtpInicio.Value.Minute & ":" & DtpInicio.Value.Second & "', '" & DtpFin.Value.Hour & ":" & DtpFin.Value.Minute & ":" & DtpFin.Value.Second & "', '" & CbSonido.Checked & "', '" & CbData.Checked & "', '" & CbAire.Checked & "', '" & TxtObservaciones.Text & "', '" & TxtDescuento.Text & "' , '" & codusuario & "'" 'variable que cuarda la consulta para ejecuatrse en la BD
                                con.insertar(StrInsert) 'funcion para ejecutar la consulta en la BD
                                LblCodigoRes.Text = con.autonum("exec ProSelecCodSal", "exec ProSelecMaxCodSalon") 'llama la funcion del autonumerado

                                ' Registrar en la Bitácora
                                Dim fecha As String = DateTime.Now.ToString("yyyy-MM-dd")
                                Dim hora As String = DateTime.Now.ToString("HH:mm:ss")
                                Dim descripcion As String = Login.NombreEmpleado & " hizo una reserva del salón del cliente: " & TxtNombre.Text & " en la fecha: " & TxtFecha.Text

                                query = "INSERT INTO Bitacora (Cod_Usu, Fch_Bita, Hrs_Bita, Obs_Bita) VALUES (" & Login.codUsu & ", '" & fecha & "', '" & hora & "', '" & descripcion & "')"
                                con.insertar(query)

                                MsgBox("RESERVA HECHA", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
                                Limpiar()
                                Carga() 'llama la funcion para cargar el gridview
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception 'si captura algun error despliega el mensaje
            MsgBox(ex.Message) 'MENSAJE SI HAY UN ERROR 
        End Try
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Try
            If TxtNombre.Text = "" Then 'si el campo esta vacio entra al ciclo
                MsgBox("Escriba un nombre", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
            Else
                If TxtHoras.Text = "" Then 'si el campo esta vacio entra al ciclo
                    MsgBox("Ingrese cantidad de Horas", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
                Else
                    If TxtFecha.Text = "" Then 'si el campo esta vacio entra al ciclo
                        MsgBox("Seleccione una Fecha", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
                    Else
                        If DtpInicio.Text = "" And DtpFin.Text = "" Then 'si el campo esta vacio entra al ciclo
                            MsgBox("Seleccione una Hora", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
                        Else
                            If Val(TxtHoras.Text) <= 0 Then 'si las horas son menores o iguales a 0 entra el ciclo
                                MsgBox("La hora de inicio no puede ser mayor o igual a la de salida", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
                            Else
                                Calculos() 'llama la funcion para los calculos
                                Carga() 'llama la funcion para llenar el gridview
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception 'si captura algun error despliega el mensaje
            MsgBox(ex.Message) 'MENSAJE SI HAY UN ERROR 
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try
            If TxtNomCancel.Text = "" Then 'si el campo esta vacio entra al ciclo
                MsgBox("Seleccione una reserva a cancelar", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
            Else
                query = "exec ProValPagadoNoPagadoResSalon '" & LblCodigoRes.Text & "'" 'variable que cuarda la consulta para ejecuatrse en la BD
                If con.val(query) = True Then 'si retorna un valor entra al ciclo
                    MsgBox("Esta reservacion no se puede cancelar porque ya esta pagada", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
                Else
                    StrInsert = "exec ProCancelResSalon '" & LblCodigoRes.Text & "' , '" & codusuario & "'" 'variable que cuarda la consulta para ejecuatrse en la BD
                    con.insertar(StrInsert) 'funcion para ejecutar la consulta en la BD

                    ' Registrar en la Bitácora
                    Dim fecha As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim hora As String = DateTime.Now.ToString("HH:mm:ss")
                    Dim descripcion As String = Login.NombreEmpleado & " canceló una reserva del salón del cliente: " & TxtNombre.Text

                    query = "INSERT INTO Bitacora (Cod_Usu, Fch_Bita, Hrs_Bita, Obs_Bita) VALUES (" & Login.codUsu & ", '" & fecha & "', '" & hora & "', '" & descripcion & "')"
                    con.insertar(query)

                    Carga() 'llama la funcion para cargar el gridview
                    MsgBox("Reservacion Cancelada", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
                End If
            End If
        Catch ex As Exception 'si captura algun error despliega el mensaje
            MsgBox(ex.Message) 'MENSAJE SI HAY UN ERROR 
        End Try
        Limpiar()
    End Sub

    Private Sub Salon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga()
        CbCancelar.Checked = False
        GbCancelaciones.Visible = False
        TxtDescuento.Text = "0" 'establece este texto en el texbox
        MtFecha.MinDate = Today 'coloca la fecha del calendario a la del dia actual
        DtpInicio.Value = DateTimePicker.MinimumDateTime 'establece la fecha minima del datetime
        DtpFin.Value = DateTimePicker.MinimumDateTime 'establece la fecha minima del datetime
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        LblCodigoRes.Text = con.autonum("exec ProSelecCodSal", "exec ProSelecMaxCodSalon") 'llama la funcion del autonumerado
        Limpiar()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Try
            If TxtNombre.Text = "" Or TxtFecha.Text = "" Or TxtHoras.Text = "0" Then 'si alguno de los campos esta vacio entra al ciclo
                MsgBox("Seleccione una reserva a modificar", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
            Else
                StrInsert = "exec ProModifResSalon '" & TxtNombre.Text & "' , '" & TxtFecha.Text & "' , '" & DtpInicio.Value.Hour & ":" & DtpInicio.Value.Minute & ":" & DtpInicio.Value.Second & "' , '" & DtpFin.Value.Hour & ":" & DtpFin.Value.Minute & ":" & DtpFin.Value.Second & "' , '" & CbSonido.Checked & "' , '" & CbData.Checked & "' , '" & CbAire.Checked & "' , '" & TxtObservaciones.Text & "' , '" & TxtDescuento.Text & "' , '" & LblCodigoRes.Text & "' , '" & codusuario & "'" 'variable que cuarda la consulta para ejecuatrse en la BD
                con.insertar(StrInsert) 'funcion para ejecutar la consulta en la BD

                ' Registrar en la Bitácora
                Dim fecha As String = DateTime.Now.ToString("yyyy-MM-dd")
                Dim hora As String = DateTime.Now.ToString("HH:mm:ss")
                Dim descripcion As String = Login.NombreEmpleado & " modificó la eserva del salón del cliente: " & TxtNombre.Text

                query = "INSERT INTO Bitacora (Cod_Usu, Fch_Bita, Hrs_Bita, Obs_Bita) VALUES (" & Login.codUsu & ", '" & fecha & "', '" & hora & "', '" & descripcion & "')"
                con.insertar(query)

                Carga() 'llama la funcion para llenar el gridview
                MsgBox("Reservacion Modificada", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
            End If
        Catch ex As Exception 'si captura algun error despliega el mensaje
            MsgBox(ex.Message) 'MENSAJE SI HAY UN ERROR 
        End Try
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        Carga(TxtBusqueda.Text)
    End Sub

    Private Sub MtFecha_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MtFecha.DateSelected
        Me.TxtFecha.Text = CStr(Me.MtFecha.SelectionRange.Start)
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        reservacion = "cliente"
        Dim registroHuespedesForm As New RegistroHuespedes()
        registroHuespedesForm.ShowDialog()

        If Not String.IsNullOrEmpty(registroHuespedesForm.NombreHuespedSeleccionado) Then
            TxtNombre.Text = registroHuespedesForm.NombreHuespedSeleccionado
        End If
        registroHuespedesForm.Close()
    End Sub

    Private Sub DtpFin_ValueChanged(sender As Object, e As EventArgs) Handles DtpFin.ValueChanged
        lblHora.Text = DateDiff(DateInterval.Minute, DtpInicio.Value, DtpFin.Value) 'calcula las horas
        TxtHoras.Text = Math.Round(((Convert.ToInt32(lblHora.Text) + 1) / 60), 1) 'ingresa las horas en el texbox
    End Sub

    Private Sub DtpInicio_ValueChanged(sender As Object, e As EventArgs) Handles DtpInicio.ValueChanged
        lblHora.Text = DateDiff(DateInterval.Minute, DtpInicio.Value, DtpFin.Value) 'calcula las horas
        TxtHoras.Text = Math.Round(((Convert.ToInt32(lblHora.Text) + 1) / 60), 1) 'ingresa las horas en el texbox
    End Sub

    Private Sub DgvSalon_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvSalon.CellMouseClick
        Dim horaIni As TimeSpan
        Dim horaFin As TimeSpan

        ' Carga para cancelaciones
        TxtNomCancel.Text = DgvSalon.CurrentRow.Cells(1).Value
        TxtFechaCancel.Text = DgvSalon.CurrentRow.Cells(2).Value

        LblCodigoRes.Text = DgvSalon.CurrentRow.Cells(0).Value
        TxtNombre.Text = DgvSalon.CurrentRow.Cells(1).Value
        TxtFecha.Text = DgvSalon.CurrentRow.Cells(2).Value
        horaIni = DgvSalon.CurrentRow.Cells(3).Value
        horaFin = DgvSalon.CurrentRow.Cells(4).Value

        CbSonido.Checked = CBool(DgvSalon.CurrentRow.Cells(5).Value)
        CbData.Checked = CBool(DgvSalon.CurrentRow.Cells(6).Value)
        CbAire.Checked = CBool(DgvSalon.CurrentRow.Cells(7).Value)

        TxtObservaciones.Text = DgvSalon.CurrentRow.Cells(8).Value
        TxtDescuento.Text = DgvSalon.CurrentRow.Cells(9).Value
        DtpInicio.Value = CDate(DgvSalon.CurrentRow.Cells(2).Value & " " & horaIni.ToString())
        DtpFin.Value = CDate(DgvSalon.CurrentRow.Cells(2).Value & " " & horaFin.ToString())

        lblHora.Text = DateDiff(DateInterval.Minute, DtpInicio.Value, DtpFin.Value).ToString()
        TxtHoras.Text = Math.Round((Convert.ToInt32(lblHora.Text) + 1) / 60.0, 1).ToString()

        Calculos()
    End Sub

    Private Sub Calculos() 'funcion que realiza los calculos
        horas = Val(TxtHoras.Text) * 350 'calcula las horas
        If CbSonido.Checked Then 'si esta en chek entra al ciclo
            sonido = 150 * Val(TxtHoras.Text) 'calcula el precio del sonido
        End If
        If CbData.Checked Then 'si esta en chek entra al ciclo
            Data = 200 * Val(TxtHoras.Text) 'calcula el precio del data
        End If
        If CbAire.Checked Then 'si esta en chek entra al ciclo
            aire = 200 * Val(TxtHoras.Text) 'calcula el precio del aire
        End If
        neto = horas + sonido + Data + aire 'calcula el neto
        total = neto - Val(TxtDescuento.Text) 'calcula el total
        TxtSubTotal.Text = Math.Round(neto, 2) 'redondea a 2 cifras el texbox
        TxtTotal.Text = Math.Round(total, 2) 'redondea a 2 cifras el texbox
        sonido = 0 'vacia la variable
        Data = 0 'vacia la variable
        aire = 0 'vacia la variable
        total = 0 'vacia la variable
    End Sub

    Private Sub Limpiar()
        TxtNombre.Text = "" 'limpia el campo
        TxtHoras.Text = "" 'limpia el campo
        CbSonido.Checked = False 'quita el chek
        CbData.Checked = False 'quita el chek
        CbAire.Checked = False 'quita el chek
        CbCancelar.Checked = False 'quita el chek
        CbDescuento.Checked = False 'quita el chek
        TxtObservaciones.Text = "" 'limpia el campo
        lblHora.Text = "" 'limpia el campo
        TxtNomCancel.Text = "" 'limpia el campo
        TxtFechaCancel.Text = "" 'limpia el campo
        TxtSubTotal.Text = "" 'limpia el campo
        TxtDescuento.Text = "" 'limpia el campo
        TxtTotal.Text = "" 'limpia el campo
        TxtFecha.Text = "" 'limpia el campo
        DtpInicio.Value = DateTimePicker.MinimumDateTime 'establece la hora minima del datetime
        DtpFin.Value = DateTimePicker.MinimumDateTime 'establece la hora minima del datetime
    End Sub
End Class