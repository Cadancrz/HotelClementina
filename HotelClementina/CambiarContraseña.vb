Imports System.Data.SqlClient 'libreria de SQL
Public Class CambiarContraseña
    Dim query As String 'variable para las consultas
    Dim con As New ClsConexion 'variable conexion
    Dim dv As New DataView 'para los empleados
    Public Event ContraseñaModificada()
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If TxtUsuario.Text = "" Or TxtAntigua.Text = "" Or TxtNueva.Text = "" Or TxtRenueva.Text = "" Then 'si alguno de estos texbox esta vacio despliega el mensaje
                MsgBox("Campo vacio", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje 
            Else
                query = "exec ProUsuarios '" & TxtUsuario.Text & "' , '" & TxtAntigua.Text & "'" 'variable que cuarda la consulta para ejecuatrse en la BD
                If con.val(query) = True Then 'si el retorno de la consulta contiene datos entra al ciclo
                    If TxtNueva.Text = TxtRenueva.Text Then 'verifica si las contraseñas coinciden
                        query = "exec ProModifContraUsu '" & TxtNueva.Text & "' , '" & TxtUsuario.Text & "'" 'variable que cuarda la consulta para ejecuatrse en la BD
                        con.insertar(query) 'funcion para ejecutar la consulta
                        RaiseEvent ContraseñaModificada() ' Activar el evento
                        MsgBox("Contraseña Modificada", MsgBoxStyle.Information, "Informacion")
                        Login.TxtUsuario.Select()
                        Me.Close()
                    Else
                        MsgBox("Contraseñas nuevas no coinciden", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje 
                    End If
                Else
                    MsgBox("usuario o contraseña incorrectos", MsgBoxStyle.Information, "Informacion") 'despliega el mensaje 
                End If
            End If
        Catch ex As Exception 'si captura algun error despliega el mensaje
            MsgBox(ex.Message) 'MENSAJE SI HAY UN ERROR 
        End Try
    End Sub

    Private Sub TxtNueva_TextChanged(sender As Object, e As EventArgs) Handles TxtNueva.TextChanged
        VerificarCoincidenciaContraseñas()
    End Sub

    Private Sub TxtRenueva_TextChanged(sender As Object, e As EventArgs) Handles TxtRenueva.TextChanged
        VerificarCoincidenciaContraseñas()
    End Sub

    Private Sub VerificarCoincidenciaContraseñas()
        If TxtNueva.Text <> TxtRenueva.Text Then
            ErrorProvider1.SetError(TxtRenueva, "No coincide con la nueva contraseña")
        Else
            ErrorProvider1.SetError(TxtRenueva, "") ' Limpiar el error si coinciden
        End If
    End Sub

End Class