﻿Public Class ClockForm

    Function updateTime() As Boolean

        Label1.Text = DateTime.Now.ToString(My.Settings.Item("format1")) & vbNewLine & DateTime.Now.ToString(My.Settings.Item("format2"))

        'Label1.Text = DateTime.Now.ToString("T") & vbNewLine & DateTime.Now.ToString("yyyy/MM/dd(ddd)")
        Return True
    End Function

    Public Function updateForm() As Boolean
        updateTime()
        Label1.Font = My.Settings.Font
        Label1.ForeColor = My.Settings.FontColor
        Me.Size = Label1.Size
        Me.Location = Screen.AllScreens(Me.Tag).Bounds.Location + Screen.AllScreens(0).Bounds.Size - Label1.Size

        Return True
    End Function
    Private Sub ClockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateForm()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (noOptForm) Then Me.Focus()
        'Me.TopMost = True
        updateTime()
    End Sub

    Private Sub ExitItem_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub OptionsItem_Click(sender As Object, e As EventArgs)
        OptForm.Show()
        OptForm.Location = Me.Location - New Point(300 - Label1.Size.Width, 200)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        noOptForm = False
        OptForm.Show()
        OptForm.Location = Me.Location - New Point(300 - Label1.Size.Width, 200)
    End Sub
End Class
