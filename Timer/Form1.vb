Public Class Timer
    Public Class GlobalVariables
        Public Shared projects As String
        Public Shared iniFile As String
        Public Shared CurrentTime As String
        Public Shared CurrentProject As String
    End Class
    Private Sub Timer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalVariables.iniFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Timer.ini"
        GlobalVariables.projects = ReadIni.ReadIni(GlobalVariables.iniFile, "Projects", "list")

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

    Private Sub StartStop_Click(sender As Object, e As EventArgs) Handles StartStop.Click
        Dim moment As DateTime = DateTime.Now
        If StartStop.Text = "Start timer" Then
            DayTimer.Enabled = True
            HourTimer.Enabled = True
            MinuteTimer.Enabled = True
            HistoryBox.Text += "START: " + moment.ToString + Environment.NewLine
        Else
            DayTimer.Enabled = False
            HourTimer.Enabled = False
            MinuteTimer.Enabled = False
            HistoryBox.Text += "STOP: " + moment.ToString + Environment.NewLine
            WriteIni.writeIni(GlobalVariables.iniFile, "Times", GlobalVariables.CurrentProject, Days.Text + "," + Hours.Text + "," + Minutes.Text)

            Dim History As String
            History = Replace(HistoryBox.Text, Environment.NewLine, ",").ToString
            WriteIni.writeIni(GlobalVariables.iniFile, "History", GlobalVariables.CurrentProject, Replace(History, "Selected Project: " + GlobalVariables.CurrentProject + ",,", ""))
        End If

        If StartStop.Text = "Start timer" Then
            StartStop.Text = "Stop timer"
        Else
            StartStop.Text = "Start timer"
        End If
    End Sub

    Private Sub ProjectSelector_SelectedValueChanged(sender As Object, e As EventArgs) Handles ProjectSelector.SelectedValueChanged
        GlobalVariables.CurrentProject = ProjectSelector.SelectedItem.ToString

        If ProjectSelector.SelectedItem = "Please Select" Then

        Else
            GlobalVariables.CurrentTime = ReadIni.ReadIni(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Timer.ini", "Times", GlobalVariables.CurrentProject)
            Dim times As String() = GlobalVariables.CurrentTime.Split(New Char() {","c})
            Days.Text = times(0)
            Hours.Text = times(1)
            Minutes.Text = times(2)
            HistoryBox.Text = "Selected Project: " + GlobalVariables.CurrentProject + Environment.NewLine + Environment.NewLine

            GetHistory()
        End If

    End Sub

    Private Sub GetHistory()
        Dim amountOfHistoryEntries As Integer
        amountOfHistoryEntries = FindWords(ReadIni.ReadIni(GlobalVariables.iniFile, "History", GlobalVariables.CurrentProject), ",") - 1
        Dim Entries As String()

        For i = amountOfHistoryEntries To 0 Step -1
            Entries = ReadIni.ReadIni(GlobalVariables.iniFile, "History", GlobalVariables.CurrentProject).Split(New Char() {","c})

        Next

        For i = 0 To Entries.Length - 2
            HistoryBox.Text += Entries(i) + Environment.NewLine
        Next
    End Sub

    Private Sub MinuteTimer_Tick(sender As Object, e As EventArgs) Handles MinuteTimer.Tick
        Minutes.Text += 1
    End Sub

    Private Sub HourTimer_Tick(sender As Object, e As EventArgs) Handles HourTimer.Tick
        If Minutes.Text = 60 Then
            Minutes.Text = 0
            Hours.Text += 1
        End If
    End Sub

    Private Sub DayTimer_Tick(sender As Object, e As EventArgs) Handles DayTimer.Tick
        If Hours.Text = 60 Then
            Hours.Text = 0
            Days.Text += 1
        End If
    End Sub
End Class
