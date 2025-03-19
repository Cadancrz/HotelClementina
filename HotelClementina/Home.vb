Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblUsuario.Text = Login.NombreEmpleado
    End Sub
End Class