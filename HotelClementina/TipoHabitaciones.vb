Imports System.Data.SqlClient
Public Class TipoHabitaciones
    Dim query As String 'variable para las consultas
    Dim con As New ClsConexion 'variable conexion
    Dim export As SqlDataReader 'variable para exportaciones
    Dim precio As Double 'variable para calcular cantidades

    Private Sub CmbHabitacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbHabitacion.SelectedIndexChanged
        Try
            query = "exec ProCargaPrecioTipoHab '" & CmbHabitacion.SelectedValue & "'" 'variable que cuarda la consulta para ejecuatrse en la BD
            If con.val(query) = True Then 'si retorna un valor entra al ciclo
                export = con.reader(query) 'exporta lo que contenga la consulta
                While export.Read 'mientras exporta llena la variable
                    precio = export.GetValue(0) 'guara en la variable lo exportado
                End While
                export.Close() 'cierra la conexion
                TxtPrecio.Text = precio 'iguala la variable al texbox
            End If
        Catch ex As Exception 'si captura algun error despliega el mensaje
            MsgBox(ex.Message) 'MENSAJE SI HAY UN ERROR 
        End Try
    End Sub

    Private Sub TipoHabitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbHabitacion.SelectedValue = 0 'coloca el valor en 0
        LlenarComboBoxHabitaciones()
    End Sub

    Private Sub TxtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrecio.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then 'numeros y borrador
            e.Handled = False 'acepte numeros
        Else
            e.Handled = True ' si presiona otras teclas que no sean numeros
        End If
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            If CmbHabitacion.Text = "" Then 'si el campo esta vacio entra al ciclo
                MsgBox("Seleccione un tipo de habitacion", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
            Else
                If TxtPrecio.Text = "" Then 'si el campo esta vacio entra al ciclo
                    MsgBox("modifique el precio", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
                End If
                query = "exec ProModifPreTipoHab  '" & TxtPrecio.Text & "' , '" & CmbHabitacion.SelectedValue & "' , '" & codusuario & "'" 'variable que cuarda la consulta para ejecuatrse en la BD
                con.insertar(query) 'funcion para ejecutar la consulta en la BD

                ' Registrar en la Bitácora
                Dim fecha As String = DateTime.Now.ToString("yyyy-MM-dd")
                Dim hora As String = DateTime.Now.ToString("HH:mm:ss")
                Dim descripcion As String = Login.NombreEmpleado & " modificó la habitación: " & CmbHabitacion.Text & " con precio: " & TxtPrecio.Text

                query = "INSERT INTO Bitacora (Cod_Usu, Fch_Bita, Hrs_Bita, Obs_Bita) VALUES (" & Login.codUsu & ", '" & fecha & "', '" & hora & "', '" & descripcion & "')"
                con.insertar(query)

                MsgBox("Datos Modificados", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje
            End If
        Catch ex As Exception 'si captura algun error despliega el mensaje
            MsgBox(ex.Message) 'MENSAJE SI HAY UN ERROR 
        End Try
    End Sub

    Public Sub LlenarComboBoxHabitaciones()
        Try
            Dim db As New ClsConexion()
            Dim dt As DataTable = db.EjecutarSP("[ProCargaTiposHab]", Nothing)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                CmbHabitacion.DataSource = dt
                CmbHabitacion.DisplayMember = "Tipo_Hab" ' Muestra el nombre del usuario
                CmbHabitacion.ValueMember = "Cod_Tipo_Hab" ' Guarda el código del usuario internamente
                CmbHabitacion.SelectedIndex = 0 ' Deja sin selección inicial
            Else
                CmbHabitacion.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las habitaciones: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

End Class