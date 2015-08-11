Public Class OptForm


    Function saveSetting() As Boolean
        My.Settings.Format1 = Format1Text.Text
        My.Settings.Format2 = Format2Text.Text
        My.Settings.Font = FontDialog1.Font
        My.Settings.FontColor = ColorDialog1.Color
        My.Settings.Save()

        For i As Integer = 0 To Screen.AllScreens.Count() - 1
            If (Not Screen.PrimaryScreen.Equals(Screen.AllScreens(i))) Then
                clockForms(i).updateForm()
            End If
        Next
        Return True
    End Function

    Private Sub OKBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        Me.Close()
    End Sub

    Private Sub OptForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = My.Resources.strOptions
        ExitBtn.Text = My.Resources.strExit
        FontBtn.Text = My.Resources.strFont
        ColorBtn.Text = My.Resources.strFontColor
        OkBtn.Text = My.Resources.strOk
        Format1Label.Text = My.Resources.strFormat1
        Format2Label.Text = My.Resources.strFormat2

        Format1Text.Text = My.Settings.Format1
        Format2Text.Text = My.Settings.Format2
        FontDialog1.Font = My.Settings.Font
        ColorDialog1.Color = My.Settings.FontColor
    End Sub


    Private Sub OptForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If (justStart) Then

            For i As Integer = 0 To Screen.AllScreens.Count() - 1
                If (Not Screen.PrimaryScreen.Equals(Screen.AllScreens(i))) Then
                    clockForms(i) = New ClockForm()
                    clockForms(i).Tag = i
                    clockForms(i).Show()
                End If
            Next


            justStart = False
            Me.Close()
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        End
    End Sub

    Private Sub OptForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        noOptForm = True
    End Sub


    Private Sub FormatTexts_LostFocus(sender As Object, e As EventArgs) Handles Format1Text.LostFocus, Format2Text.LostFocus
        saveSetting()
    End Sub



    Private Sub FontBtn_Click(sender As Object, e As EventArgs) Handles FontBtn.Click
        If (FontDialog1.ShowDialog() = DialogResult.OK) Then
            saveSetting()
        End If
    End Sub

    Private Sub ColorBtn_Click(sender As Object, e As EventArgs) Handles ColorBtn.Click
        If (ColorDialog1.ShowDialog() = DialogResult.OK) Then
            saveSetting()
        End If
    End Sub


    Private Sub FormatTexts_KeyDown(sender As Object, e As KeyEventArgs) Handles Format1Text.KeyDown, Format2Text.KeyDown
        If (e.KeyCode = Keys.Return) Then
            saveSetting()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class