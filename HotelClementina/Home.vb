Public Class Home
    Dim query As String 'variable para las consultas
    Dim con As New ClsConexion 'variable conexion
    Dim ISV, ISVtur As Decimal 'variables para trabajar con cantidades
    Dim Neto As Decimal 'variables para trabajar con cantidades
    Dim Total As Decimal 'variables para trabajar con cantidades
    Dim nombre_respaldo As String

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblUsuario.Text = Login.NombreEmpleado
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtBase.Text = "" 'limpia el campo
        TxtImpuesto.Text = "" 'limpia el campo
        TxtNeto.Text = "" 'limpia el campo
        TxtTotal.Text = "" 'limpia el campo
        TxtImpTur.Text = "" 'limpia el campo
    End Sub

    Private Sub BtnMostrarISV_Click(sender As Object, e As EventArgs) Handles BtnMostrarISV.Click
        GbxImpuesto4.Visible = True
        GbxImpuesto15.Visible = True
    End Sub

    Private Sub BtnOcultarISV_Click(sender As Object, e As EventArgs) Handles BtnOcultarISV.Click
        GbxImpuesto4.Visible = False
        GbxImpuesto15.Visible = False
    End Sub

    Private Sub BtnLimpiar2_Click(sender As Object, e As EventArgs) Handles BtnLimpiar2.Click
        TxtBase2.Text = "" 'limpia el campo
        TxtNeto2.Text = "" 'limpia el campo
        TxtImpuesto2.Text = "" 'limpia el campo
        TxtTotal2.Text = "" 'limpia el campo
    End Sub

    Private Sub BtnCalcular2_Click(sender As Object, e As EventArgs) Handles BtnCalcular2.Click
        Neto = Val(TxtBase2.Text) / 1.15 'calcula el neto
        ISV = Val(TxtBase2.Text) - Neto 'calcula el impuesto
        Total = Neto + ISV 'calcula el total con los impuestos
        TxtImpuesto2.Text = Math.Round(ISV, 2) 'redondea el texbox a 2 decimales
        TxtNeto2.Text = Math.Round(Neto, 2) 'redondea el texbox a 2 decimales
        TxtTotal2.Text = Math.Round(Total, 2) 'redondea el texbox a 2 decimales
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Neto = Val(TxtBase.Text) / 1.19 'calcula el neto
        ISV = Neto * 0.15 'calcula el impuesto
        ISVtur = Neto * 0.04 'calcula el impuesto de turismo
        Total = Neto + ISV + ISVtur 'calcula el total con los impuestos
        TxtImpuesto.Text = Math.Round(ISV, 2) 'redondea el texbox a 2 decimales
        TxtImpTur.Text = Math.Round(ISVtur, 2) 'redondea el texbox a 2 decimales
        TxtNeto.Text = Math.Round(Neto, 2) 'redondea el texbox a 2 decimales
        TxtTotal.Text = Math.Round(Total, 2) 'redondea el texbox a 2 decimales
    End Sub

    Private Sub TxtBase_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBase.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then 'solo admite este codigo de tecla presionada
            e.Handled = False 'acepte numeros
        Else
            e.Handled = True ' si presiona otras teclas que no sean numeros
        End If
    End Sub

    Private Sub TxtBase2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBase2.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then 'solo admite este codigo de tecla presionada
            e.Handled = False 'acepte numeros
        Else
            e.Handled = True ' si presiona otras teclas que no sean numeros
        End If
    End Sub
End Class