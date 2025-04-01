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

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

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

    Private Sub VerificarEstadoHabitacion(codHab As Integer)
        ' Formatear el ID de la habitación a dos dígitos (ejemplo: 01, 02, ..., 10)
        Dim habId As String = codHab.ToString("D2")

        ' Buscar las TabPages dentro de TabControl1
        For Each tabPage As TabPage In TabControl1.TabPages
            ' Verificar si el GroupBox existe dentro de la TabPage
            Dim groupBox As GroupBox = TryCast(tabPage.Controls("GbHab" & habId), GroupBox)
            If groupBox IsNot Nothing Then

                ' Obtener los controles dentro del GroupBox
                Dim btnCancelar As Button = TryCast(groupBox.Controls("BtnCancelar" & habId), Button)
                Dim btnReservar As Button = TryCast(groupBox.Controls("BtnReservar" & habId), Button)
                Dim btnDetalle As Button = TryCast(groupBox.Controls("BtnDetalle" & habId), Button)
                Dim btnFactura As Button = TryCast(groupBox.Controls("BtnFactura" & habId), Button)
                Dim pbHab As PictureBox = TryCast(groupBox.Controls("PbHab" & habId), PictureBox)
                Dim pbHabP1 As PictureBox = TryCast(groupBox.Controls("PbHab" & habId & "P1"), PictureBox)
                Dim pbHabP2 As PictureBox = TryCast(groupBox.Controls("PbHab" & habId & "P2"), PictureBox)

                query = "SELECT Precio_Unitario FROM Reserva WHERE Cod_Hab = " & codHab & "  AND '" & DateTime.Now & "' BETWEEN Fec_Ini_Res AND Fec_Fin_Res"

                If con.val(query) = True Then
                    export = con.reader(query)
                    ' Si hay reserva activa
                    If btnCancelar IsNot Nothing Then btnCancelar.Visible = True
                    If btnReservar IsNot Nothing Then btnReservar.Visible = False
                    If btnDetalle IsNot Nothing Then btnDetalle.Enabled = True
                    If btnFactura IsNot Nothing Then btnFactura.Enabled = True
                    If pbHab IsNot Nothing Then pbHab.Visible = False
                    If pbHabP1 IsNot Nothing Then pbHabP1.Visible = True

                    ' Verificar si el precio unitario es 1850.00
                    While export.Read
                        Dim precio As Decimal = export.GetDecimal(0)
                        pbHabP2.Visible = (precio = 1850.0)
                    End While
                    export.Close()
                Else
                    ' No hay reserva activa
                    If btnCancelar IsNot Nothing Then btnCancelar.Visible = False
                    If btnReservar IsNot Nothing Then btnReservar.Visible = True
                    If btnDetalle IsNot Nothing Then btnDetalle.Enabled = False
                    If btnFactura IsNot Nothing Then btnFactura.Enabled = False
                    If pbHab IsNot Nothing Then pbHab.Visible = True
                    If pbHabP1 IsNot Nothing Then pbHabP1.Visible = False
                    If pbHabP2 IsNot Nothing Then pbHabP2.Visible = False
                End If

            End If
        Next
    End Sub

    Private Sub ControlHabitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Verificamos todas las habitaciones del 1 al 10 (ajústalo según la cantidad total de habitaciones)
        For i As Integer = 1 To 35
            VerificarEstadoHabitacion(i)
        Next

        ' Ocultar botones si CodUsu es 0
        If Login.codCargo = 0 Then ' Asumiendo que CodUsu es una cadena
            For i As Integer = 0 To 35 ' Ajusta el rango según tus botones
                Dim btnHab As Button = Me.Controls.Find("BtnHab" & i.ToString("00"), True).FirstOrDefault()
                If btnHab IsNot Nothing Then
                    btnHab.Visible = False
                End If
            Next
        End If

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

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar01.Click, BtnCancelar02.Click, BtnCancelar03.Click, BtnCancelar04.Click, BtnCancelar05.Click, BtnCancelar06.Click, BtnCancelar07.Click, BtnCancelar09.Click, BtnCancelar10.Click, BtnCancelar11.Click, BtnCancelar12.Click, BtnCancelar13.Click, BtnCancelar14.Click, BtnCancelar15.Click, BtnCancelar16.Click, BtnCancelar17.Click, BtnCancelar18.Click, BtnCancelar19.Click, BtnCancelar20.Click, BtnCancelar21.Click, BtnCancelar22.Click, BtnCancelar23.Click, BtnCancelar24.Click, BtnCancelar25.Click, BtnCancelar26.Click, BtnCancelar27.Click, BtnCancelar28.Click, BtnCancelar29.Click, BtnCancelar30.Click, BtnCancelar31.Click, BtnCancelar32.Click, BtnCancelar33.Click, BtnCancelar34.Click, BtnCancelar35.Click
        ' Obtener el botón que disparó el evento
        Dim btn As Button = DirectCast(sender, Button)

        ' Obtener el número del botón
        Dim num As String = btn.Name.Replace("BtnCancelar", "")

        ' Buscar el GroupBox correspondiente
        Dim gb As GroupBox = Me.Controls.Find("GbHab" & num, True).FirstOrDefault()

        ' Si el GroupBox fue encontrado
        If gb IsNot Nothing Then
            ' Obtener el Cod_Hab de la habitación (puedes cambiar esta parte si tu Cod_Hab tiene otro formato o fuente)
            Dim codHab As Integer = Integer.Parse(num)

            Dim btnCancelar As Button = TryCast(gb.Controls("BtnCancelar" & num), Button)
            Dim btnReservar As Button = TryCast(gb.Controls("BtnReservar" & num), Button)
            Dim btnDetalle As Button = TryCast(gb.Controls("BtnDetalle" & num), Button)
            Dim btnFactura As Button = TryCast(gb.Controls("BtnFactura" & num), Button)
            Dim pbHab As PictureBox = TryCast(gb.Controls("PbHab" & num), PictureBox)
            Dim pbHabP1 As PictureBox = TryCast(gb.Controls("PbHab" & num & "P1"), PictureBox)
            Dim pbHabP2 As PictureBox = TryCast(gb.Controls("PbHab" & num & "P2"), PictureBox)

            ' Verificar si hay una reserva activa para esa habitación
            Dim query As String = "SELECT * FROM Reserva WHERE Cod_Hab = " & codHab & "  AND '" & DateTime.Now & "' BETWEEN Fec_Ini_Res AND Fec_Fin_Res"

            If con.val(query) = True Then
                Dim deleteQuery As String = "DELETE FROM Reserva WHERE Cod_Hab = " & codHab & " AND '" & DateTime.Now & "' BETWEEN Fec_Ini_Res AND Fec_Fin_Res"
                con.insertar(deleteQuery)
                ' Informar al usuario
                MessageBox.Show("La reserva ha sido cancelada correctamente.", "Cancelación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If btnCancelar IsNot Nothing Then btnCancelar.Visible = False
                If btnReservar IsNot Nothing Then btnReservar.Visible = True
                If btnDetalle IsNot Nothing Then btnDetalle.Enabled = False
                If btnFactura IsNot Nothing Then btnFactura.Enabled = False
                If pbHab IsNot Nothing Then pbHab.Visible = True
                If pbHabP1 IsNot Nothing Then pbHabP1.Visible = False
                If pbHabP2 IsNot Nothing Then pbHabP2.Visible = False
            Else
                ' Si no hay reserva activa para esa habitación
                MessageBox.Show("No hay reserva activa para esta habitación en este momento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
End Class