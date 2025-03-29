Imports System.Data.SqlClient

Public Class Reservaciones
    Dim query As String 'variable para las consultas
    Dim con As New ClsConexion 'variable conexion
    Dim dv As New DataView 'variable dataview para la busqueda de clientes
    Dim dvdispon As New DataView 'variable dataview para cargar gridview de habitaciones
    Dim entrar As String 'variable para entrar a los ciclos
    Dim export As SqlDataReader 'variable datareader para las exportaciones
    Dim habi As Integer 'variable para guardar los numeros de las habitaciones
    Dim habidisponibles As String 'variable para guardar las habitaciones disponibles en el ciclo e ir llenando el gridview
    Dim Det, ResultQuery As Integer 'variable para respuesta de mensajes
    Dim dr As IDataReader 'para leer cadenas de datos'
    Dim contador As Integer 'EXPORTA EL NUMERO DE HABITACION EN ORDEN ASCENDENTE
    Dim dias As Integer 'variable para guardar la cantidad de diass de una reserva
    Dim fecha1, fecha2, fechafin As Date 'variables para las fechas
    Dim preciodia, preciototal As Double 'variables para cantidades
End Class