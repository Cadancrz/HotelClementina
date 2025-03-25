Imports System.Data.SqlClient
Public Class Bitacora
    Private Sub Bitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtpFechaFin.MinDate = DateAdd(DateInterval.Day, 1, DtpFechaInicio.Value.Date) 'establece que la fecha minima no sea menor que el dia actual del sistema
    End Sub

    Private Sub DtpFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles DtpFechaInicio.ValueChanged
        DtpFechaFin.MinDate = DateAdd(DateInterval.Day, 1, DtpFechaInicio.Value.Date)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            cmd = New SqlCommand("ProBuscarBitacora '" & DtpFechaInicio.Value.Date.ToString("yyyy/MM/dd") & "','" & DtpFechaFin.Value.Date.ToString("yyyy/MM/dd") & "' ", con.cnn)
            Dim ds As New DataSet 'variable dataset
            Dim da As New SqlDataAdapter(cmd) 'variable dataadapter
            da.Fill(ds) 'llena la variable dataadapter con lo que contenga el dataset
            DgvBitacora.DataSource = ds.Tables(0) 'llena el datagrid con lo que contenga el dataset
        Catch ex As Exception 'si captura algun error despliega el mensaje
            MsgBox(ex.Message) 'MENSAJE SI HAY UN ERROR 
        End Try
    End Sub
End Class