Public Class Migracion
    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        VistaMigracion.Close()
        VistaMigracion.LblFecha.Text = CStr(Me.MonthCalendar1.SelectionRange.Start) 'guarda la fecha seleccionada del calendario en el texbox
        VistaMigracion.ShowDialog()
    End Sub
End Class