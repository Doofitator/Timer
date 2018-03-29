Public Class Timer
    Private Sub Timer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadIni.ReadIni(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "TimerProjects.ini", "Projects", "list")
    End Sub

    Private Sub ProjectTimer_Tick(sender As Object, e As EventArgs) Handles ProjectTimer.Tick
        If ProjectSelector.SelectedItem = "" Or ProjectSelector.SelectedItem = "Please Select" Then
            If HistoryBox.Text = "" Then
                HistoryBox.Text += "Please Selected a project!" & Environment.NewLine
            End If
        End If
    End Sub
End Class
