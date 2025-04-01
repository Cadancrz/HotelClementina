Imports System.Data.SqlClient 'libreria de SQL
Public Class DetalleHabitacion
    Dim query As String 'variable para las consultas
    Dim con As New ClsConexion 'variable conexion
    Dim export As SqlDataReader 'variable para exportaciones
    Dim dv As New DataView 'variable dataview
    Dim precio, recargos As Double 'variables para guardar cantidades
    Dim fecha1, fecha2 As Date 'variables para guardar fechas
    Dim dias, descuentoaplicado, totalestadia, recargoaplicado, cantidad As Integer ''variables para guardar datos entero
    Dim Det, pagadoNOpagado As Integer 'variable para guardar datos enteros
    Dim dr As IDataReader 'para leer cadenas de datos'
    Dim entrar As String 'variable para entrar a las funciones
    Dim ide As String
    Dim cantdias As Integer

    Private Sub DetalleHabitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CmbRecargo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbRecargo.SelectedIndexChanged
        If CmbRecargo.SelectedItem = "Refresco/Agua" = True Then 'si el texto del combobox es igual a "Refresco/Agua"
            TxtPrecioRecargo.Text = "20" 'establece el precio en el texbox
        ElseIf CmbRecargo.SelectedItem = "Cerveza Nacional" = True Then 'si el texto del combobox es igual a "Cerveza Nacional"
            TxtPrecioRecargo.Text = "35" 'establece el precio en el texbox
        ElseIf CmbRecargo.SelectedItem = "Cerveza Extrangera" = True Then 'si el texto del combobox es igual a "Cerveza Extrangera"
            TxtPrecioRecargo.Text = "50" 'establece el precio en el texbox
        End If
    End Sub
End Class