Public Class Migracion
    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Dim miVistaMigracion As New VistaMigracion() 'Crear una nueva instancia
        miVistaMigracion.LblFecha.Text = CStr(Me.MonthCalendar1.SelectionRange.Start) 'guarda la fecha seleccionada del calendario en el label
        miVistaMigracion.ShowDialog()
    End Sub
End Class