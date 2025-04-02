Imports System.Data.SqlClient
Public Class VistaMigracion
    Dim query As String 'variable para las consultas
    Dim con As New ClsConexion 'variable conexion
    Dim dv As New DataView 'variable dataview
    Dim export As SqlDataReader

    Public Sub Carga()
        Try
            Dim db As New ClsConexion()

            ' Crear una lista de parámetros
            Dim parametros As New List(Of SqlParameter) From {
                New SqlParameter("@Fecha", LblFecha.Text)
            }

            ' Ejecutar el procedimiento almacenado con los parámetros
            Dim dt As DataTable = db.EjecutarSP("ProCargarMiagracion", parametros)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                With DgvHuespedes
                    .MultiSelect = False
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .DataSource = dt
                End With

                ' Formatear la columna "Hora de Entrada"
                For Each row As DataGridViewRow In DgvHuespedes.Rows
                    If Not row.IsNewRow Then
                        Dim horaEntrada As DateTime = Convert.ToDateTime(row.Cells("Hora de Entrada").Value)
                        row.Cells("Hora de Entrada").Value = horaEntrada.ToString("HH:mm:ss")
                    End If
                Next

            Else
                DgvHuespedes.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los huéspedes: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub VistaMigracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga()
    End Sub

    Private Sub DgvHuespedes_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvHuespedes.CellMouseClick
        TxtIdentidad.Text = DgvHuespedes.CurrentRow.Cells(2).Value 'iguala el texbox a la columna de la fila seleccionada
        TxtNombre.Text = DgvHuespedes.CurrentRow.Cells(1).Value 'iguala el texbox a la columna de la fila seleccionada
        LblNumFila.Text = DgvHuespedes.CurrentRow.Index
    End Sub

    Private Sub BtnQuitar_Click(sender As Object, e As EventArgs) Handles BtnQuitar.Click
        Try
            If TxtIdentidad.Text = "" Then
                MsgBox("Seleccione un huesped de la lista", MsgBoxStyle.Information, "Informacion") 'muestra el mensaje
            Else
                DgvHuespedes.Rows.RemoveAt(LblNumFila.Text)
                LblNumFila.Text = ""
                TxtIdentidad.Text = ""
                TxtNombre.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message) 'MENSAJE SI HAY UN ERROR
        End Try
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            'PARA GUARDAR LOS DATOS DEL GRIDVIEW EN A BASE DE DATOS
            If DgvHuespedes.RowCount > 0 Then 'VRIFICA QUE SI EL DATA GRIDVIEW TIENE LAS COLUMNAS LLENAS SI ES MAYOR Q CERO ESTA LLENA SINO ESTA VACIA
                For Each row As DataGridViewRow In DgvHuespedes.Rows 'POR CADA COLUMNA DEL DATAGRIDVIEW EN EL DATAGRIDVIER2
                    query = "insert into Migracion_Temp(hora, Nombre, Id, Nacionalidad, Habitacion, Procedencia) values('" & row.Cells(0).Value & "', '" & row.Cells(1).Value & "', '" & row.Cells(2).Value & "', '" & row.Cells(3).Value & "', '" & row.Cells(4).Value & "', '" & row.Cells(5).Value & "')" 'variable que cuarda la consulta para ejecuatrse en la BD
                    con.insertar(query) 'DICE Q SE EJECUTE EL COMANDO
                    'RPTMigra.TextBox1.Text = LblFecha.Text 'guarda lo que contenga el texbox en la variable
                Next
                Me.Close() 'cierra este formulario
                'RPTMigra.Show() 'muestra el formulario
            End If
            con.desconectar() 'SE DESCONECTA 
        Catch ex As Exception 'si captura algun error despliega el mensaje
            MsgBox(ex.Message) 'MENSAJE SI HAY UN ERROR 
        End Try
    End Sub

    Private Sub DgvHuespedes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvHuespedes.CellContentClick
        For Each row As DataGridViewRow In DgvHuespedes.Rows
            If Not row.IsNewRow Then ' Evita errores con filas nuevas vacías
                Dim horaEntrada As DateTime = Convert.ToDateTime(row.Cells("Hora de Entrada").Value) ' Corregido el nombre de la columna
                row.Cells("Hora de Entrada").Value = horaEntrada.ToString("HH:mm:ss") ' Corregido el nombre de la columna
            End If
        Next
    End Sub
End Class