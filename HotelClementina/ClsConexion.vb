﻿Imports System.Data.SqlClient 'libreria de SQL
Public Class ClsConexion
    Public servidor As String = "Data Source=Localhost;Initial Catalog=Hotel_Casa_Encantada;Integrated Security=True" 'variable para guardar la conexion con el servidor en SQL
    Public cnn As New SqlConnection(servidor) 'variable conexion con el parametro del servidor
    Dim query As String 'variable para las consultas

    Public ClsConect As New SqlConnection("Data Source=Localhost;Initial Catalog=Hotel_Casa_Encantada;Integrated Security=True") 'conexion con la BD

    Public Sub conectar()
        Try
            If cnn.State = Data.ConnectionState.Closed Then 'si la conexion esta cerrada entra al ciclo
                cnn.Open() 'abre la conexion
            End If
        Catch ex As Exception 'si captura algun error despliega el mensaje
            MsgBox("Error al conectar a BD" & vbCrLf & ex.Message) 'muestra el mensaje
        End Try
    End Sub

    Public Sub desconectar()
        Try
            If cnn.State = Data.ConnectionState.Open Then 'si la conexion esta abierta entra al ciclo
                cnn.Close() 'cierra la conexion
            End If
        Catch ex As Exception 'si captura algun error despliega el mensaje
            MsgBox(ex.Message) 'despliega el mensaje
        End Try
    End Sub
    Public Function reader(ByVal cons As String) As SqlDataReader
        Dim dr As SqlDataReader 'variable datareader
        Try
            conectar() 'conecta con la BD
            Dim cmdImstrucciom As New SqlCommand(cons, cnn) 'variable sql comando
            dr = cmdImstrucciom.ExecuteReader 'ejecuta el comando del datareader
        Catch ex As Exception 'si captura algun error despliega el mensaje
            dr = Nothing 'vacia el datareader
            MsgBox(ex.Message) 'despliega el mensaje
        Finally 'finaliza la funcion
        End Try
        Return dr 'retorna el valor de la variable
    End Function

    Public Sub insertar(ByVal query As String)
        Dim comando As New SqlCommand(query, cnn) 'variable para ejecutar comandos SQL
        Try
            conectar() 'conecta con la BD
            comando.ExecuteNonQuery() 'ejecuta le comando
        Catch ex As Exception 'si captura algun error despliega el mensaje
            ex.Message.ToString() 'despliega el mensaje
        Finally
            desconectar() 'cierra la conexion
        End Try
    End Sub

    Public Function val(ByVal query As String) As Boolean
        Dim cmd As New SqlCommand 'variable sql comando
        Try
            conectar() 'conecta a la BD
            cmd = New SqlCommand(query, cnn) 'variable conexion
            Dim dr As SqlDataReader 'variable datareader
            dr = cmd.ExecuteReader 'iguala el datareader a la ejecucion del comando
            If dr.HasRows = True Then 'si el datareader retorna un valor entra al ciclo
                Return True 'retorna verdadero
            Else
                Return False 'retorna falso
            End If
            dr.Close() 'cierra el datareader
        Catch ex As Exception 'si captura algun error despliega el mensaje
            MsgBox(ex.Message) 'despliega el mensaje
            Return False 'retorna falso
        Finally
            desconectar() 'cierra la conexion
        End Try
    End Function

    Sub Enlace() 'enlace para la conexion
        Try
            If ClsConect.State = ConnectionState.Closed Then 'si la conexion esta cerrada entra al ciclo
                ClsConect.Open() 'abre la conexion
            End If
        Catch mirror As SqlException 'si captura algun error despliega el mensaje
            MsgBox("Conexion Fallida") 'muestra el mensaje
        End Try
    End Sub

    Public Function EjecutarSP(ByVal nombreSP As String, ByVal parametros As List(Of SqlParameter)) As DataTable
        Dim dt As New DataTable()
        Try
            conectar()
            Using cmd As New SqlCommand(nombreSP, cnn)
                cmd.CommandType = CommandType.StoredProcedure
                If parametros IsNot Nothing Then
                    cmd.Parameters.AddRange(parametros.ToArray())
                End If
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al ejecutar el procedimiento almacenado: " & ex.Message)
        Finally
            desconectar()
        End Try
        Return dt
    End Function

    ' **************************************
    ' FUNCIÓN PARA CONVERTIR NÚMEROS A TEXTO
    ' ******************************
    Public Function Num2Text(ByVal value As Double) As String
        Select Case value
            Case 0 : Return "Cero"
            Case 1 : Return "Uno"
            Case 2 : Return "Dos"
            Case 3 : Return "Tres"
            Case 4 : Return "Cuatro"
            Case 5 : Return "Cinco"
            Case 6 : Return "Seis"
            Case 7 : Return "Siete"
            Case 8 : Return "Ocho"
            Case 9 : Return "Nueve"
            Case 10 : Return "Diez"
            Case 11 : Return "Once"
            Case 12 : Return "Doce"
            Case 13 : Return "Trece"
            Case 14 : Return "Catorce"
            Case 15 : Return "Quince"
            Case Is < 20 : Return "Dieci" & Num2Text(value - 10)
            Case 20 : Return "Veinte"
            Case Is < 30 : Return "Veinti" & Num2Text(value - 20)
            Case 30 : Return "Treinta"
            Case 40 : Return "Cuarenta"
            Case 50 : Return "Cincuenta"
            Case 60 : Return "Sesenta"
            Case 70 : Return "Setenta"
            Case 80 : Return "Ochenta"
            Case 90 : Return "Noventa"
            Case Is < 100 : Return Num2Text(Int(value \ 10) * 10) & " y " & Num2Text(value Mod 10)
            Case 100 : Return "Cien"
            Case Is < 200 : Return "Ciento " & Num2Text(value - 100)
            Case 200, 300, 400, 600, 800 : Return Num2Text(Int(value \ 100)) & "cientos"
            Case 500 : Return "Quinientos"
            Case 700 : Return "Setecientos"
            Case 900 : Return "Novecientos"
            Case Is < 1000 : Return Num2Text(Int(value \ 100) * 100) & " " & Num2Text(value Mod 100)
            Case 1000 : Return "Mil"
            Case Is < 2000 : Return "Mil " & Num2Text(value Mod 1000)
            Case Is < 1000000 : Return Num2Text(Int(value \ 1000)) & " Mil " & IIf(value Mod 1000 > 0, Num2Text(value Mod 1000), "")
            Case 1000000 : Return "Un millón"
            Case Is < 2000000 : Return "Un millón " & Num2Text(value Mod 1000000)
            Case Else : Return Num2Text(Int(value / 1000000)) & " Millones " & IIf(value Mod 1000000 > 0, Num2Text(value Mod 1000000), "")
        End Select
    End Function

    Public Function EjecutarEscalar(ByVal query As String, ByVal parametros As List(Of SqlParameter)) As Object
        Dim resultado As Object = Nothing
        Try
            conectar()
            Using cmd As New SqlCommand(query, cnn)
                cmd.CommandType = CommandType.Text
                If parametros IsNot Nothing Then
                    cmd.Parameters.AddRange(parametros.ToArray())
                End If
                resultado = cmd.ExecuteScalar()
            End Using
        Catch ex As Exception
            Throw New Exception("Error al ejecutar consulta escalar: " & ex.Message)
        Finally
            desconectar()
        End Try
        Return resultado
    End Function

    ' Método para ejecutar consultas que NO devuelven datos (INSERT, UPDATE, DELETE)
    Public Sub EjecutarConsulta(ByVal query As String, ByVal parametros As List(Of SqlParameter))
        Try
            conectar()
            Using comando As New SqlCommand(query, cnn)
                If parametros IsNot Nothing Then
                    comando.Parameters.AddRange(parametros.ToArray())
                End If
                comando.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Error al ejecutar la consulta: " & ex.Message, MsgBoxStyle.Critical, "Error de SQL")
        Finally
            desconectar()
        End Try
    End Sub
End Class
