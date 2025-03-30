Imports System.Data.SqlClient
Public Class ControlHabitaciones
    Dim query As String 'variable para las consultas
    Dim con As New ClsConexion 'variable para las conexion
    Dim dv As New DataView 'variable dataview
    Dim dvfechas As New DataView 'variable dataview
    Dim entrar As String = "si" 'variable para entrar a las funciones
    Dim export As SqlDataReader 'variable datareader
    Dim Id, tel1, tel2, emp, dir, correo, obs, nacion, proced As String 'variables para los datos del huesped
    Dim fecha1, fecha2 As Date 'variables para guardar fechas
    Dim dias As Integer 'variables para guardar los dias
    Dim resultado As Integer 'variable para mensajes de confirmacion
    Dim conthuesped As Integer 'variable contador de huespedes
    Dim tipocliente As Integer 'variable que guarda el tipo del cliente, contado/credito

    Private Sub BtnReservar_Click(sender As Object, e As EventArgs)
        ' Capturar el número de la habitación desde el botón presionado
        Dim btn As Button = DirectCast(sender, Button)
        numhab = btn.Name.Replace("BtnReservar", "")

        ' Llamar al formulario de reservaciones dentro del panel
        Dim frmReservaciones As New Reservaciones()
        frmReservaciones.TopLevel = False
        frmReservaciones.FormBorderStyle = FormBorderStyle.None
        frmReservaciones.Dock = DockStyle.Fill

        ' Limpiar el panel y agregar el nuevo formulario
        PanelPrincipalMenu.PnPantallas.Controls.Clear()
        PanelPrincipalMenu.PnPantallas.Controls.Add(frmReservaciones)
        frmReservaciones.Show()
    End Sub

    Private Sub ControlHabitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 35
            ' Formateamos el número de habitación en un formato de dos dígitos (01, 02, ..., 35)
            Dim numHab As String = i.ToString("D2") ' Esto asegura que el número tenga siempre dos dígitos (01, 02, ..., 35)

            ' Verificamos el estado de la habitación (0 = Ocupada, 1 = Disponible)
            If numHab = i And estadohabitacion = 0 And frmReservasAbierto = 1 Then ' Restamos 1 porque el índice de estadohabitacion es de 0 a 34
                ' Desactivamos el botón de reservar y activamos el botón de cancelar y demás botones relacionados
                CType(Me.Controls("BtnReservar" & numHab), Button).Visible = False
                CType(Me.Controls("BtnCancelar" & numHab), Button).Visible = True
                CType(Me.Controls("BtnFactura" & numHab), Button).Enabled = True
                CType(Me.Controls("BtnDetalle" & numHab), Button).Enabled = True
            End If
        Next

        ' Iterar sobre todos los botones desde BtnReservar01 hasta BtnReservar35
        For i As Integer = 1 To 35
            Dim btn As Button = Me.Controls.Find("BtnReservar" & i.ToString("00"), True).FirstOrDefault()
            If btn IsNot Nothing Then
                AddHandler btn.Click, AddressOf BtnReservar_Click
            End If
        Next
    End Sub




    Private Sub BtnHabitacion_Click(sender As Object, e As EventArgs) Handles BtnHab00.Click, BtnHab01.Click, BtnHab02.Click, BtnHab03.Click, BtnHab04.Click, BtnHab05.Click, BtnHab06.Click, BtnHab07.Click, BtnHab08.Click, BtnHab09.Click, BtnHab10.Click, BtnHab11.Click, BtnHab12.Click, BtnHab13.Click, BtnHab14.Click, BtnHab15.Click, BtnHab16.Click, BtnHab17.Click, BtnHab18.Click, BtnHab19.Click, BtnHab20.Click, BtnHab21.Click, BtnHab22.Click, BtnHab23.Click, BtnHab24.Click, BtnHab25.Click, BtnHab26.Click, BtnHab27.Click, BtnHab28.Click, BtnHab29.Click, BtnHab30.Click, BtnHab31.Click, BtnHab32.Click, BtnHab33.Click, BtnHab34.Click, BtnHab35.Click
        ' Obtener el botón que disparó el evento
        Dim btn As Button = DirectCast(sender, Button)

        ' Obtener el número del botón
        Dim num As String = btn.Name.Replace("BtnHab", "")

        ' Buscar el GroupBox correspondiente
        Dim gb As GroupBox = Me.Controls.Find("GbHab" & num, True).FirstOrDefault()

        ' Si el GroupBox fue encontrado, cambiar su estado de habilitado
        If gb IsNot Nothing Then
            gb.Enabled = Not gb.Enabled
        End If
    End Sub


End Class