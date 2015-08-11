Public Class CalendarForm
    Private Sub CalendarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = MonthCalendar1.Size
    End Sub

    Private Sub MonthCalendar1_LostFocus(sender As Object, e As EventArgs) Handles MonthCalendar1.LostFocus
        noOptForm = True
        Me.Close()
    End Sub

End Class