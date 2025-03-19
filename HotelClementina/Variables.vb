Imports System.Data.SqlClient

Public Class Variables
    'Clase
    Public ClaseConeccion As New ClsConexion 'variable para llamar a la clase conexion

    'Data
    Public cmd As New SqlClient.SqlCommand 'variable SQL para ejecutar comandos

    Public numAtext As String 'variable que guarda la cantidad en letras del total
    Public varfactura As Integer 'variable para dirigir a factura o facturacion
    Public Usuario As String 'variable para guardar el nombre de usuario
    Public StrInsert As String 'variable para insertar
    Public reservacion As String 'variable para cuardar el codigo de la reservacion
    Public codusuario As String 'variable para guardar el codigo de usuario
    Public FacturaSalon As String 'variable para llamar las facturas del gridview en el formulario salon de eventos
    Public codhabi As String 'variable para guradar el codigo de la habitacion
    Public recargos As Double 'variable para guardar recargos
    Public RPTcodfact As Integer 'variable para mandar al reporte
    Public lector As SqlDataReader 'variable datareader
    Public adaptador As New SqlDataAdapter 'variable dataadapter
    Public DS As DataSet 'variable dataset
    Public RPTPlanilla As String 'variable para guardar los codigos de los reportes
    Public pagoatrasado As String 'variable para pagar facturas atrasadas


End Class
