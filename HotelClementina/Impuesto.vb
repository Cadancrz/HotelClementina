Public Class Impuesto
    Dim neto, isv As Double 'variables para trabajar con cantidades
    Private Sub Impuesto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False 'para que no se pueda maximizar el formulario
        neto = Val(TxtTotal.Text) / 1.15 'calcula el neto
        isv = Val(TxtTotal.Text) - neto 'calcula el impuesto
        TxtNeto.Text = Math.Round(neto, 2) 'redondea el neto a 2 decimales
        TxtISV.Text = Math.Round(isv, 2) 'redondea el impuesto a 2 decimales
    End Sub
End Class