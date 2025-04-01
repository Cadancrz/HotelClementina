Imports System.Data.SqlClient

Public Class Login
    Dim con As New ClsConexion()
    Public Shared codUsu As String
    Public Shared codCargo As Integer
    Public Shared NombreEmpleado As String

    Private Sub BtnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAceptar.Click
        ingresar()
    End Sub

    Private Sub TxtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            ingresar()
        End If
    End Sub

    Private Sub TxtContraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtContraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            ingresar()
        End If
    End Sub

    Private Sub ingresar()
        ' Verificar si los campos están vacíos
        If String.IsNullOrWhiteSpace(TxtUsuario.Text) Or String.IsNullOrWhiteSpace(TxtContraseña.Text) Then
            MsgBox("Por favor, complete todos los campos.", MsgBoxStyle.Information, "Información")
            Exit Sub
        End If

        Try
            con.conectar()

            ' Llamar al procedimiento almacenado
            Dim cmd As New SqlCommand("Pa_IniciarSesion", con.cnn)
            cmd.CommandType = CommandType.StoredProcedure

            ' Parámetros de entrada
            cmd.Parameters.AddWithValue("@usuario", TxtUsuario.Text)
            cmd.Parameters.AddWithValue("@contra", TxtContraseña.Text)

            ' Parámetros de salida
            Dim paramCodUsu As New SqlParameter("@codUsu", SqlDbType.NVarChar, 20)  ' Cambiado a NVarChar(20)
            paramCodUsu.Direction = ParameterDirection.Output
            cmd.Parameters.Add(paramCodUsu)

            Dim paramCodCargo As New SqlParameter("@codCargo", SqlDbType.Int)
            paramCodCargo.Direction = ParameterDirection.Output
            cmd.Parameters.Add(paramCodCargo)

            Dim paramEstado As New SqlParameter("@estado", SqlDbType.Bit)
            paramEstado.Direction = ParameterDirection.Output
            cmd.Parameters.Add(paramEstado)

            Dim paramNombreEmpleado As New SqlParameter("@nombreEmpleado", SqlDbType.VarChar, 255)
            paramNombreEmpleado.Direction = ParameterDirection.Output
            cmd.Parameters.Add(paramNombreEmpleado)

            Dim paramIdUsu As New SqlParameter("@idUsu", SqlDbType.NVarChar, 30)  ' Nuevo parámetro para Id_Usu
            paramIdUsu.Direction = ParameterDirection.Output
            cmd.Parameters.Add(paramIdUsu)

            cmd.ExecuteNonQuery()

            ' Obtener valores de los parámetros de salida
            codUsu = If(IsDBNull(paramCodUsu.Value), "", Convert.ToString(paramCodUsu.Value))
            codCargo = If(IsDBNull(paramCodCargo.Value), 0, Convert.ToInt32(paramCodCargo.Value))
            Dim estado As Boolean = If(IsDBNull(paramEstado.Value), False, Convert.ToBoolean(paramEstado.Value))
            NombreEmpleado = If(IsDBNull(paramNombreEmpleado.Value), "", Convert.ToString(paramNombreEmpleado.Value))
            Dim idUsu As String = If(IsDBNull(paramIdUsu.Value), "", Convert.ToString(paramIdUsu.Value))  ' Obtener Id_Usu

            ' Verificar si el usuario fue encontrado
            If Not String.IsNullOrEmpty(codUsu) Then
                ' Verificar si el usuario está habilitado
                If Not estado Then
                    MsgBox("Usuario deshabilitado, contacte al administrador.", MsgBoxStyle.Exclamation, "Acceso Denegado")
                Else
                    ' Mostrar el formulario principal
                    PanelPrincipalMenu.Show()

                    ' Si es administrador (Cod_Cargo = 1)
                    If codCargo = 1 Then
                        MsgBox("Bienvenido(a) " & NombreEmpleado, MsgBoxStyle.Information, "Acceso Permitido")
                    Else
                        PanelPrincipalMenu.BtnTipoHab.Visible = False
                        PanelPrincipalMenu.BtnUsuarios.Visible = False
                        PanelPrincipalMenu.BtnSalon.Visible = False
                        PanelPrincipalMenu.BtnBitacora.Visible = False
                        PanelPrincipalMenu.PnHabitaciones.Height = 32 ' Establecer el alto a píxeles
                        MsgBox("Bienvenido(a) " & NombreEmpleado, MsgBoxStyle.Information, "Acceso Permitido")
                    End If

                    ' Asignar Id_Usu al TxtCodEmp
                    PanelPrincipalMenu.TxtCodEmp.Text = codUsu
                    Usuario = NombreEmpleado

                    ' Limpiar campos y ocultar el login
                    TxtUsuario.Clear()
                    TxtContraseña.Clear()
                    Me.Hide()
                End If
            Else
                MsgBox("Usuario no encontrado o contraseña incorrecta.", MsgBoxStyle.Exclamation, "Acceso denegado")
            End If

            con.desconectar()
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos: " & ex.Message, MsgBoxStyle.Critical, "Error")
            con.desconectar()
        End Try
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lblhorafecha.Text = DateTime.Now
        Dim con As New ClsConexion()
        con.conectar()
        TxtUsuario.Focus()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If TxtContraseña.PasswordChar = "*"c Then
            TxtContraseña.PasswordChar = ""
        Else
            TxtContraseña.PasswordChar = "*"c
        End If
    End Sub
End Class