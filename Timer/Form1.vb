Public Class Timer
    Public Class GlobalVariables
        Public Shared projects As String
    End Class
    Private Sub Timer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalVariables.projects = ReadIni.ReadIni(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Timer.ini", "Default", "list")

        HistoryBox.Text += "Please Selected a project." & Environment.NewLine
        HistoryBox.Text += "Available projects: " + GlobalVariables.projects + Environment.NewLine
        PopulateComboBox()
    End Sub

    Sub PopulateComboBox()
        ProjectSelector.Items.Add("Please Select")
        ProjectSelector.SelectedItem = "Please Select"

        Dim amountOfProjects As Integer
        amountOfProjects = FindWords(GlobalVariables.projects, ",") - 1
        For i = amountOfProjects To 0 Step -1
            Dim availableProjects As String() = GlobalVariables.projects.Split(New Char() {","c})
            ProjectSelector.Items.Add(availableProjects(i))
        Next

    End Sub

    Private Function FindWords(ByVal TextSearched As String, ByVal Paragraph As String) As Integer
        Dim location As Integer = 0
        Dim occurances As Integer = 0
        Do
            location = TextSearched.IndexOf(Paragraph, location)
            If location <> -1 Then
                occurances += 1
                location += Paragraph.Length
            End If
        Loop Until location = -1
        Return occurances
    End Function

    Private Sub ProjectTimer_Tick(sender As Object, e As EventArgs) Handles ProjectTimer.Tick
        If ProjectSelector.SelectedItem = "Please Select" Then
            StartStop.Enabled = False
        Else
            StartStop.Enabled = True
        End If
    End Sub
End Class
