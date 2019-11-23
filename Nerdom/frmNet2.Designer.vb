<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNet2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtQuesN1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPauseTimer = New System.Windows.Forms.Label()
        Me.lblHideTimer = New System.Windows.Forms.Label()
        Me.btnNotes = New System.Windows.Forms.Button()
        Me.btnScoreTest = New System.Windows.Forms.Button()
        Me.btnShowAnswer = New System.Windows.Forms.Button()
        Me.btnShowExplanation = New System.Windows.Forms.Button()
        Me.btnReview = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtInputAnswer = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtRouterOutput = New System.Windows.Forms.TextBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTimeDiff = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.lblPercentCorrect = New System.Windows.Forms.Label()
        Me.chkMarkForReview = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtQuesN1
        '
        Me.txtQuesN1.BackColor = System.Drawing.SystemColors.Window
        Me.txtQuesN1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuesN1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQuesN1.Location = New System.Drawing.Point(7, 62)
        Me.txtQuesN1.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.txtQuesN1.Multiline = True
        Me.txtQuesN1.Name = "txtQuesN1"
        Me.txtQuesN1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtQuesN1.Size = New System.Drawing.Size(1372, 167)
        Me.txtQuesN1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblPauseTimer)
        Me.Panel1.Controls.Add(Me.lblHideTimer)
        Me.Panel1.Controls.Add(Me.btnNotes)
        Me.Panel1.Controls.Add(Me.btnScoreTest)
        Me.Panel1.Controls.Add(Me.btnShowAnswer)
        Me.Panel1.Controls.Add(Me.btnShowExplanation)
        Me.Panel1.Controls.Add(Me.btnReview)
        Me.Panel1.Controls.Add(Me.btnShow)
        Me.Panel1.Controls.Add(Me.btnForward)
        Me.Panel1.Controls.Add(Me.btnSubmit)
        Me.Panel1.Controls.Add(Me.btnPrevious)
        Me.Panel1.Location = New System.Drawing.Point(7, 651)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1372, 131)
        Me.Panel1.TabIndex = 2
        '
        'lblPauseTimer
        '
        Me.lblPauseTimer.AutoSize = True
        Me.lblPauseTimer.ForeColor = System.Drawing.Color.Blue
        Me.lblPauseTimer.Location = New System.Drawing.Point(676, 88)
        Me.lblPauseTimer.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblPauseTimer.Name = "lblPauseTimer"
        Me.lblPauseTimer.Size = New System.Drawing.Size(151, 29)
        Me.lblPauseTimer.TabIndex = 10
        Me.lblPauseTimer.Text = "Pause Timer"
        '
        'lblHideTimer
        '
        Me.lblHideTimer.AutoSize = True
        Me.lblHideTimer.ForeColor = System.Drawing.Color.Blue
        Me.lblHideTimer.Location = New System.Drawing.Point(526, 88)
        Me.lblHideTimer.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblHideTimer.Name = "lblHideTimer"
        Me.lblHideTimer.Size = New System.Drawing.Size(134, 29)
        Me.lblHideTimer.TabIndex = 9
        Me.lblHideTimer.Text = "Hide Timer"
        '
        'btnNotes
        '
        Me.btnNotes.Location = New System.Drawing.Point(1156, 72)
        Me.btnNotes.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.btnNotes.Name = "btnNotes"
        Me.btnNotes.Size = New System.Drawing.Size(200, 45)
        Me.btnNotes.TabIndex = 8
        Me.btnNotes.Text = "Add Notes"
        Me.btnNotes.UseVisualStyleBackColor = True
        '
        'btnScoreTest
        '
        Me.btnScoreTest.Location = New System.Drawing.Point(942, 72)
        Me.btnScoreTest.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.btnScoreTest.Name = "btnScoreTest"
        Me.btnScoreTest.Size = New System.Drawing.Size(200, 45)
        Me.btnScoreTest.TabIndex = 7
        Me.btnScoreTest.Text = "Score Test"
        Me.btnScoreTest.UseVisualStyleBackColor = True
        '
        'btnShowAnswer
        '
        Me.btnShowAnswer.Location = New System.Drawing.Point(226, 72)
        Me.btnShowAnswer.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.btnShowAnswer.Name = "btnShowAnswer"
        Me.btnShowAnswer.Size = New System.Drawing.Size(200, 45)
        Me.btnShowAnswer.TabIndex = 6
        Me.btnShowAnswer.Text = "Show Answer"
        Me.btnShowAnswer.UseVisualStyleBackColor = True
        '
        'btnShowExplanation
        '
        Me.btnShowExplanation.Location = New System.Drawing.Point(12, 72)
        Me.btnShowExplanation.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.btnShowExplanation.Name = "btnShowExplanation"
        Me.btnShowExplanation.Size = New System.Drawing.Size(200, 45)
        Me.btnShowExplanation.TabIndex = 5
        Me.btnShowExplanation.Text = "Explanation"
        Me.btnShowExplanation.UseVisualStyleBackColor = True
        '
        'btnReview
        '
        Me.btnReview.Enabled = False
        Me.btnReview.Location = New System.Drawing.Point(942, 13)
        Me.btnReview.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.btnReview.Name = "btnReview"
        Me.btnReview.Size = New System.Drawing.Size(200, 45)
        Me.btnReview.TabIndex = 4
        Me.btnReview.Text = "Preview Items"
        Me.btnReview.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(1156, 13)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(200, 45)
        Me.btnShow.TabIndex = 3
        Me.btnShow.Text = "Exhibit"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnForward
        '
        Me.btnForward.Location = New System.Drawing.Point(440, 13)
        Me.btnForward.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(200, 45)
        Me.btnForward.TabIndex = 2
        Me.btnForward.Text = "Next >>"
        Me.btnForward.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(226, 13)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(200, 45)
        Me.btnSubmit.TabIndex = 1
        Me.btnSubmit.Text = "Save Answer"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(12, 13)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(200, 45)
        Me.btnPrevious.TabIndex = 0
        Me.btnPrevious.Text = "<< Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtInputAnswer)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(9, 316)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.GroupBox1.Size = New System.Drawing.Size(1327, 85)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Answer"
        Me.GroupBox1.Visible = False
        '
        'txtInputAnswer
        '
        Me.txtInputAnswer.BackColor = System.Drawing.SystemColors.Control
        Me.txtInputAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInputAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputAnswer.Location = New System.Drawing.Point(28, 32)
        Me.txtInputAnswer.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.txtInputAnswer.Multiline = True
        Me.txtInputAnswer.Name = "txtInputAnswer"
        Me.txtInputAnswer.Size = New System.Drawing.Size(1272, 35)
        Me.txtInputAnswer.TabIndex = 3
        Me.txtInputAnswer.Text = " "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.InfoText
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.txtRouterOutput)
        Me.Panel2.Controls.Add(Me.txtInput)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(7, 236)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1372, 409)
        Me.Panel2.TabIndex = 0
        '
        'txtRouterOutput
        '
        Me.txtRouterOutput.BackColor = System.Drawing.SystemColors.InfoText
        Me.txtRouterOutput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRouterOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRouterOutput.ForeColor = System.Drawing.SystemColors.Info
        Me.txtRouterOutput.Location = New System.Drawing.Point(0, 109)
        Me.txtRouterOutput.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.txtRouterOutput.Multiline = True
        Me.txtRouterOutput.Name = "txtRouterOutput"
        Me.txtRouterOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRouterOutput.Size = New System.Drawing.Size(1372, 292)
        Me.txtRouterOutput.TabIndex = 2
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.SystemColors.InfoText
        Me.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.ForeColor = System.Drawing.SystemColors.Info
        Me.txtInput.Location = New System.Drawing.Point(0, 58)
        Me.txtInput.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(1372, 28)
        Me.txtInput.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Nerdom.My.Resources.Resources.bar
        Me.PictureBox1.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1372, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Time Left :"
        '
        'lblTimeDiff
        '
        Me.lblTimeDiff.AutoSize = True
        Me.lblTimeDiff.Location = New System.Drawing.Point(123, 20)
        Me.lblTimeDiff.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblTimeDiff.Name = "lblTimeDiff"
        Me.lblTimeDiff.Size = New System.Drawing.Size(86, 29)
        Me.lblTimeDiff.TabIndex = 4
        Me.lblTimeDiff.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(289, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Question :"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(418, 22)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(329, 26)
        Me.ProgressBar1.TabIndex = 6
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Location = New System.Drawing.Point(752, 20)
        Me.lblPercent.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(123, 29)
        Me.lblPercent.TabIndex = 7
        Me.lblPercent.Text = "400 of 400"
        '
        'lblPercentCorrect
        '
        Me.lblPercentCorrect.AutoSize = True
        Me.lblPercentCorrect.Location = New System.Drawing.Point(944, 20)
        Me.lblPercentCorrect.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblPercentCorrect.Name = "lblPercentCorrect"
        Me.lblPercentCorrect.Size = New System.Drawing.Size(145, 29)
        Me.lblPercentCorrect.TabIndex = 8
        Me.lblPercentCorrect.Text = "Correct : 0%"
        '
        'chkMarkForReview
        '
        Me.chkMarkForReview.AutoSize = True
        Me.chkMarkForReview.Location = New System.Drawing.Point(1166, 19)
        Me.chkMarkForReview.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.chkMarkForReview.Name = "chkMarkForReview"
        Me.chkMarkForReview.Size = New System.Drawing.Size(202, 33)
        Me.chkMarkForReview.TabIndex = 9
        Me.chkMarkForReview.Text = "Make for review"
        Me.chkMarkForReview.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'frmNet2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1384, 789)
        Me.Controls.Add(Me.chkMarkForReview)
        Me.Controls.Add(Me.lblPercentCorrect)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTimeDiff)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtQuesN1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.MaximizeBox = False
        Me.Name = "frmNet2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtQuesN1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnForward As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnReview As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents btnNotes As Button
    Friend WithEvents btnScoreTest As Button
    Friend WithEvents btnShowAnswer As Button
    Friend WithEvents btnShowExplanation As Button
    Friend WithEvents lblPauseTimer As Label
    Friend WithEvents lblHideTimer As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtInputAnswer As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtRouterOutput As TextBox
    Friend WithEvents txtInput As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTimeDiff As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblPercent As Label
    Friend WithEvents lblPercentCorrect As Label
    Friend WithEvents chkMarkForReview As CheckBox
    Friend WithEvents Timer1 As Timer
End Class
