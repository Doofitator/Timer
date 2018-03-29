<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Timer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Timer))
        Me.Author = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.StartStop = New System.Windows.Forms.Button()
        Me.Minutes = New System.Windows.Forms.Label()
        Me.Hours = New System.Windows.Forms.Label()
        Me.Days = New System.Windows.Forms.Label()
        Me.ProjectSelector = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HistoryBox = New System.Windows.Forms.TextBox()
        Me.DayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.HourTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MinuteTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ProjectTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Author
        '
        Me.Author.AutoSize = True
        Me.Author.Location = New System.Drawing.Point(421, 356)
        Me.Author.Name = "Author"
        Me.Author.Size = New System.Drawing.Size(151, 13)
        Me.Author.TabIndex = 0
        Me.Author.Text = "Created by Ash Sharkey, 2018"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(584, 378)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 11
        Me.LineShape2.X2 = 571
        Me.LineShape2.Y1 = 350
        Me.LineShape2.Y2 = 350
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 290
        Me.LineShape1.X2 = 290
        Me.LineShape1.Y1 = 10
        Me.LineShape1.Y2 = 350
        '
        'StartStop
        '
        Me.StartStop.Location = New System.Drawing.Point(103, 142)
        Me.StartStop.Name = "StartStop"
        Me.StartStop.Size = New System.Drawing.Size(75, 23)
        Me.StartStop.TabIndex = 2
        Me.StartStop.Text = "Start timer"
        Me.StartStop.UseVisualStyleBackColor = True
        '
        'Minutes
        '
        Me.Minutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minutes.Location = New System.Drawing.Point(195, 57)
        Me.Minutes.Name = "Minutes"
        Me.Minutes.Size = New System.Drawing.Size(88, 56)
        Me.Minutes.TabIndex = 3
        Me.Minutes.Text = "00"
        Me.Minutes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Hours
        '
        Me.Hours.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hours.Location = New System.Drawing.Point(101, 57)
        Me.Hours.Name = "Hours"
        Me.Hours.Size = New System.Drawing.Size(88, 56)
        Me.Hours.TabIndex = 4
        Me.Hours.Text = "00"
        Me.Hours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Days
        '
        Me.Days.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Days.Location = New System.Drawing.Point(7, 57)
        Me.Days.Name = "Days"
        Me.Days.Size = New System.Drawing.Size(88, 56)
        Me.Days.TabIndex = 5
        Me.Days.Text = "00"
        Me.Days.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProjectSelector
        '
        Me.ProjectSelector.FormattingEnabled = True
        Me.ProjectSelector.Location = New System.Drawing.Point(108, 21)
        Me.ProjectSelector.Name = "ProjectSelector"
        Me.ProjectSelector.Size = New System.Drawing.Size(121, 21)
        Me.ProjectSelector.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Project:"
        '
        'HistoryBox
        '
        Me.HistoryBox.Location = New System.Drawing.Point(304, 13)
        Me.HistoryBox.Multiline = True
        Me.HistoryBox.Name = "HistoryBox"
        Me.HistoryBox.Size = New System.Drawing.Size(268, 322)
        Me.HistoryBox.TabIndex = 8
        '
        'ProjectTimer
        '
        Me.ProjectTimer.Enabled = True
        '
        'Timer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 378)
        Me.Controls.Add(Me.HistoryBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProjectSelector)
        Me.Controls.Add(Me.Days)
        Me.Controls.Add(Me.Hours)
        Me.Controls.Add(Me.Minutes)
        Me.Controls.Add(Me.StartStop)
        Me.Controls.Add(Me.Author)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Timer"
        Me.Text = "Timer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Author As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents StartStop As Button
    Friend WithEvents Minutes As Label
    Friend WithEvents Hours As Label
    Friend WithEvents Days As Label
    Friend WithEvents ProjectSelector As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents HistoryBox As TextBox
    Friend WithEvents DayTimer As Windows.Forms.Timer
    Friend WithEvents HourTimer As Windows.Forms.Timer
    Friend WithEvents MinuteTimer As Windows.Forms.Timer
    Friend WithEvents ProjectTimer As Windows.Forms.Timer
End Class
