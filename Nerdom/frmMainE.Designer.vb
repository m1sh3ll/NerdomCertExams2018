<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainE
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
        Me.Lbl_Def = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbMinutes = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkTimedExam = New System.Windows.Forms.CheckBox()
        Me.cbSelectAll = New System.Windows.Forms.ComboBox()
        Me.cbSelectNum = New System.Windows.Forms.ComboBox()
        Me.rdoSelectAll = New System.Windows.Forms.RadioButton()
        Me.rdoSelectNum = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSaveOptions = New System.Windows.Forms.Button()
        Me.BtnMoreOptions = New System.Windows.Forms.Button()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkRandAnswers = New System.Windows.Forms.CheckBox()
        Me.chkRandQuestions = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLaunchExam = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnResetOptions = New System.Windows.Forms.Button()
        Me.BtnStudyMode = New System.Windows.Forms.Button()
        Me.BtnExamMode = New System.Windows.Forms.Button()
        Me.chkEndExam = New System.Windows.Forms.CheckBox()
        Me.chkShowExplanationIncorrect = New System.Windows.Forms.CheckBox()
        Me.chkShowExplanationCorrect = New System.Windows.Forms.CheckBox()
        Me.chkCorrectReview = New System.Windows.Forms.CheckBox()
        Me.chkReviewIncorrect = New System.Windows.Forms.CheckBox()
        Me.chkReviewCorrect = New System.Windows.Forms.CheckBox()
        Me.chkPauseTimer = New System.Windows.Forms.CheckBox()
        Me.chkHideTimer = New System.Windows.Forms.CheckBox()
        Me.chkScoreTest = New System.Windows.Forms.CheckBox()
        Me.chkMultChoice = New System.Windows.Forms.CheckBox()
        Me.chkAddNotes = New System.Windows.Forms.CheckBox()
        Me.chkPreviousButton = New System.Windows.Forms.CheckBox()
        Me.chkShowExplanationButton = New System.Windows.Forms.CheckBox()
        Me.chkReviewUnanswered = New System.Windows.Forms.CheckBox()
        Me.chkReviewAnswered = New System.Windows.Forms.CheckBox()
        Me.chkReviewUnMarked = New System.Windows.Forms.CheckBox()
        Me.chkReviewMarked = New System.Windows.Forms.CheckBox()
        Me.chkMarkForReview = New System.Windows.Forms.CheckBox()
        Me.chkItemReview = New System.Windows.Forms.CheckBox()
        Me.chkProgressBar = New System.Windows.Forms.CheckBox()
        Me.chkShowPercentCorrect = New System.Windows.Forms.CheckBox()
        Me.chkShowAnswer = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnExam6 = New System.Windows.Forms.Button()
        Me.BtnExam5 = New System.Windows.Forms.Button()
        Me.BtnExam4 = New System.Windows.Forms.Button()
        Me.BtnExam3 = New System.Windows.Forms.Button()
        Me.BtnExam2 = New System.Windows.Forms.Button()
        Me.BtnExam1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Lbl_Topic = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Def
        '
        Me.Lbl_Def.BackColor = System.Drawing.Color.LightGray
        Me.Lbl_Def.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Def.ForeColor = System.Drawing.Color.Green
        Me.Lbl_Def.Location = New System.Drawing.Point(13, 106)
        Me.Lbl_Def.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Lbl_Def.Name = "Lbl_Def"
        Me.Lbl_Def.Size = New System.Drawing.Size(1370, 64)
        Me.Lbl_Def.TabIndex = 1
        Me.Lbl_Def.Text = "Practice Exams - Select an Exam Below"
        Me.Lbl_Def.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btnSaveOptions)
        Me.Panel2.Controls.Add(Me.BtnMoreOptions)
        Me.Panel2.Controls.Add(Me.txtUserName)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.chkRandAnswers)
        Me.Panel2.Controls.Add(Me.chkRandQuestions)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.BtnLaunchExam)
        Me.Panel2.Location = New System.Drawing.Point(777, 170)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(590, 604)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cbMinutes)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.chkTimedExam)
        Me.Panel3.Controls.Add(Me.cbSelectAll)
        Me.Panel3.Controls.Add(Me.cbSelectNum)
        Me.Panel3.Controls.Add(Me.rdoSelectAll)
        Me.Panel3.Controls.Add(Me.rdoSelectNum)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(8, 148)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(571, 290)
        Me.Panel3.TabIndex = 17
        '
        'cbMinutes
        '
        Me.cbMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMinutes.FormattingEnabled = True
        Me.cbMinutes.Location = New System.Drawing.Point(249, 218)
        Me.cbMinutes.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cbMinutes.Name = "cbMinutes"
        Me.cbMinutes.Size = New System.Drawing.Size(177, 37)
        Me.cbMinutes.TabIndex = 19
        Me.cbMinutes.Text = "sdfsdf"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 215)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 47)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "minutes : "
        '
        'chkTimedExam
        '
        Me.chkTimedExam.AccessibleDescription = ""
        Me.chkTimedExam.AutoSize = True
        Me.chkTimedExam.Checked = True
        Me.chkTimedExam.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTimedExam.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkTimedExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTimedExam.Location = New System.Drawing.Point(41, 167)
        Me.chkTimedExam.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkTimedExam.Name = "chkTimedExam"
        Me.chkTimedExam.Size = New System.Drawing.Size(298, 52)
        Me.chkTimedExam.TabIndex = 17
        Me.chkTimedExam.Text = "Timed Exam :"
        Me.chkTimedExam.UseVisualStyleBackColor = True
        '
        'cbSelectAll
        '
        Me.cbSelectAll.Enabled = False
        Me.cbSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSelectAll.FormattingEnabled = True
        Me.cbSelectAll.Location = New System.Drawing.Point(249, 124)
        Me.cbSelectAll.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cbSelectAll.Name = "cbSelectAll"
        Me.cbSelectAll.Size = New System.Drawing.Size(177, 37)
        Me.cbSelectAll.TabIndex = 16
        '
        'cbSelectNum
        '
        Me.cbSelectNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSelectNum.FormattingEnabled = True
        Me.cbSelectNum.Location = New System.Drawing.Point(249, 73)
        Me.cbSelectNum.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cbSelectNum.Name = "cbSelectNum"
        Me.cbSelectNum.Size = New System.Drawing.Size(177, 37)
        Me.cbSelectNum.TabIndex = 15
        '
        'rdoSelectAll
        '
        Me.rdoSelectAll.AutoSize = True
        Me.rdoSelectAll.Checked = True
        Me.rdoSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdoSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSelectAll.Location = New System.Drawing.Point(41, 118)
        Me.rdoSelectAll.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.rdoSelectAll.Name = "rdoSelectAll"
        Me.rdoSelectAll.Size = New System.Drawing.Size(250, 52)
        Me.rdoSelectAll.TabIndex = 14
        Me.rdoSelectAll.TabStop = True
        Me.rdoSelectAll.Text = "Select All : "
        Me.rdoSelectAll.UseVisualStyleBackColor = True
        '
        'rdoSelectNum
        '
        Me.rdoSelectNum.AutoSize = True
        Me.rdoSelectNum.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdoSelectNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSelectNum.Location = New System.Drawing.Point(41, 68)
        Me.rdoSelectNum.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.rdoSelectNum.Name = "rdoSelectNum"
        Me.rdoSelectNum.Size = New System.Drawing.Size(215, 52)
        Me.rdoSelectNum.TabIndex = 13
        Me.rdoSelectNum.Text = "Select # :"
        Me.rdoSelectNum.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(37, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(471, 52)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Number of Questions : "
        '
        'btnSaveOptions
        '
        Me.btnSaveOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveOptions.Location = New System.Drawing.Point(307, 525)
        Me.btnSaveOptions.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnSaveOptions.Name = "btnSaveOptions"
        Me.btnSaveOptions.Size = New System.Drawing.Size(240, 50)
        Me.btnSaveOptions.TabIndex = 15
        Me.btnSaveOptions.Text = "Save Settings"
        Me.btnSaveOptions.UseVisualStyleBackColor = True
        '
        'BtnMoreOptions
        '
        Me.BtnMoreOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMoreOptions.Location = New System.Drawing.Point(37, 525)
        Me.BtnMoreOptions.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.BtnMoreOptions.Name = "BtnMoreOptions"
        Me.BtnMoreOptions.Size = New System.Drawing.Size(240, 50)
        Me.BtnMoreOptions.TabIndex = 14
        Me.BtnMoreOptions.Text = "<< More Options"
        Me.BtnMoreOptions.UseVisualStyleBackColor = True
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(222, 460)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(325, 53)
        Me.txtUserName.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(43, 463)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(262, 47)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "User Name : "
        '
        'chkRandAnswers
        '
        Me.chkRandAnswers.AutoSize = True
        Me.chkRandAnswers.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkRandAnswers.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRandAnswers.Location = New System.Drawing.Point(49, 100)
        Me.chkRandAnswers.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkRandAnswers.Name = "chkRandAnswers"
        Me.chkRandAnswers.Size = New System.Drawing.Size(371, 52)
        Me.chkRandAnswers.TabIndex = 3
        Me.chkRandAnswers.Text = "Random Answers"
        Me.chkRandAnswers.UseVisualStyleBackColor = True
        '
        'chkRandQuestions
        '
        Me.chkRandQuestions.AutoSize = True
        Me.chkRandQuestions.Checked = True
        Me.chkRandQuestions.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRandQuestions.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkRandQuestions.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.chkRandQuestions.Location = New System.Drawing.Point(49, 53)
        Me.chkRandQuestions.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkRandQuestions.Name = "chkRandQuestions"
        Me.chkRandQuestions.Size = New System.Drawing.Size(387, 51)
        Me.chkRandQuestions.TabIndex = 2
        Me.chkRandQuestions.Text = "Random Questions"
        Me.chkRandQuestions.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(43, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 52)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Exam Option : "
        '
        'BtnLaunchExam
        '
        Me.BtnLaunchExam.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLaunchExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLaunchExam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnLaunchExam.Location = New System.Drawing.Point(394, 1)
        Me.BtnLaunchExam.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.BtnLaunchExam.Name = "BtnLaunchExam"
        Me.BtnLaunchExam.Size = New System.Drawing.Size(185, 104)
        Me.BtnLaunchExam.TabIndex = 0
        Me.BtnLaunchExam.Text = "Launch  Exam"
        Me.BtnLaunchExam.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGray
        Me.Panel4.Controls.Add(Me.BtnResetOptions)
        Me.Panel4.Controls.Add(Me.BtnStudyMode)
        Me.Panel4.Controls.Add(Me.BtnExamMode)
        Me.Panel4.Controls.Add(Me.chkEndExam)
        Me.Panel4.Controls.Add(Me.chkShowExplanationIncorrect)
        Me.Panel4.Controls.Add(Me.chkShowExplanationCorrect)
        Me.Panel4.Controls.Add(Me.chkCorrectReview)
        Me.Panel4.Controls.Add(Me.chkReviewIncorrect)
        Me.Panel4.Controls.Add(Me.chkReviewCorrect)
        Me.Panel4.Controls.Add(Me.chkPauseTimer)
        Me.Panel4.Controls.Add(Me.chkHideTimer)
        Me.Panel4.Controls.Add(Me.chkScoreTest)
        Me.Panel4.Controls.Add(Me.chkMultChoice)
        Me.Panel4.Controls.Add(Me.chkAddNotes)
        Me.Panel4.Controls.Add(Me.chkPreviousButton)
        Me.Panel4.Controls.Add(Me.chkShowExplanationButton)
        Me.Panel4.Controls.Add(Me.chkReviewUnanswered)
        Me.Panel4.Controls.Add(Me.chkReviewAnswered)
        Me.Panel4.Controls.Add(Me.chkReviewUnMarked)
        Me.Panel4.Controls.Add(Me.chkReviewMarked)
        Me.Panel4.Controls.Add(Me.chkMarkForReview)
        Me.Panel4.Controls.Add(Me.chkItemReview)
        Me.Panel4.Controls.Add(Me.chkProgressBar)
        Me.Panel4.Controls.Add(Me.chkShowPercentCorrect)
        Me.Panel4.Controls.Add(Me.chkShowAnswer)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(13, 170)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(757, 604)
        Me.Panel4.TabIndex = 4
        Me.Panel4.Visible = False
        '
        'BtnResetOptions
        '
        Me.BtnResetOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResetOptions.Location = New System.Drawing.Point(541, 530)
        Me.BtnResetOptions.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.BtnResetOptions.Name = "BtnResetOptions"
        Me.BtnResetOptions.Size = New System.Drawing.Size(180, 40)
        Me.BtnResetOptions.TabIndex = 25
        Me.BtnResetOptions.Text = "Reset Options"
        Me.BtnResetOptions.UseVisualStyleBackColor = True
        '
        'BtnStudyMode
        '
        Me.BtnStudyMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStudyMode.Location = New System.Drawing.Point(541, 481)
        Me.BtnStudyMode.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.BtnStudyMode.Name = "BtnStudyMode"
        Me.BtnStudyMode.Size = New System.Drawing.Size(180, 40)
        Me.BtnStudyMode.TabIndex = 24
        Me.BtnStudyMode.Text = "Study Mode"
        Me.BtnStudyMode.UseVisualStyleBackColor = True
        '
        'BtnExamMode
        '
        Me.BtnExamMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExamMode.Location = New System.Drawing.Point(541, 433)
        Me.BtnExamMode.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.BtnExamMode.Name = "BtnExamMode"
        Me.BtnExamMode.Size = New System.Drawing.Size(180, 40)
        Me.BtnExamMode.TabIndex = 23
        Me.BtnExamMode.Text = "Exam Mode"
        Me.BtnExamMode.UseVisualStyleBackColor = True
        '
        'chkEndExam
        '
        Me.chkEndExam.AutoSize = True
        Me.chkEndExam.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkEndExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEndExam.Location = New System.Drawing.Point(41, 552)
        Me.chkEndExam.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkEndExam.Name = "chkEndExam"
        Me.chkEndExam.Size = New System.Drawing.Size(478, 45)
        Me.chkEndExam.TabIndex = 22
        Me.chkEndExam.Text = "End Exam After Score Test"
        Me.ToolTip1.SetToolTip(Me.chkEndExam, "Mark this option to be able to End the Exam After Scoring.")
        Me.chkEndExam.UseVisualStyleBackColor = True
        '
        'chkShowExplanationIncorrect
        '
        Me.chkShowExplanationIncorrect.AutoSize = True
        Me.chkShowExplanationIncorrect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkShowExplanationIncorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowExplanationIncorrect.Location = New System.Drawing.Point(41, 513)
        Me.chkShowExplanationIncorrect.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkShowExplanationIncorrect.Name = "chkShowExplanationIncorrect"
        Me.chkShowExplanationIncorrect.Size = New System.Drawing.Size(483, 45)
        Me.chkShowExplanationIncorrect.TabIndex = 21
        Me.chkShowExplanationIncorrect.Text = "Explanation When Incorrect"
        Me.ToolTip1.SetToolTip(Me.chkShowExplanationIncorrect, "Show popup explanation, correct/incorrect status and correct answer for each ques" &
        "tion you answer incorrect.")
        Me.chkShowExplanationIncorrect.UseVisualStyleBackColor = True
        '
        'chkShowExplanationCorrect
        '
        Me.chkShowExplanationCorrect.AutoSize = True
        Me.chkShowExplanationCorrect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkShowExplanationCorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowExplanationCorrect.Location = New System.Drawing.Point(41, 474)
        Me.chkShowExplanationCorrect.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkShowExplanationCorrect.Name = "chkShowExplanationCorrect"
        Me.chkShowExplanationCorrect.Size = New System.Drawing.Size(462, 45)
        Me.chkShowExplanationCorrect.TabIndex = 20
        Me.chkShowExplanationCorrect.Text = "Explanation When Correct"
        Me.ToolTip1.SetToolTip(Me.chkShowExplanationCorrect, "Show popup explanation, correct/incorrect status and correct answer for each ques" &
        "tion you answer correct.")
        Me.chkShowExplanationCorrect.UseVisualStyleBackColor = True
        '
        'chkCorrectReview
        '
        Me.chkCorrectReview.AutoSize = True
        Me.chkCorrectReview.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkCorrectReview.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCorrectReview.Location = New System.Drawing.Point(41, 435)
        Me.chkCorrectReview.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkCorrectReview.Name = "chkCorrectReview"
        Me.chkCorrectReview.Size = New System.Drawing.Size(609, 45)
        Me.chkCorrectReview.TabIndex = 19
        Me.chkCorrectReview.Text = "Correct/Incorrect Column in Review"
        Me.ToolTip1.SetToolTip(Me.chkCorrectReview, "Mark this option to Show Correct Column in Item Review. E.g. Correct: Yes beside " &
        "each question.")
        Me.chkCorrectReview.UseVisualStyleBackColor = True
        '
        'chkReviewIncorrect
        '
        Me.chkReviewIncorrect.AutoSize = True
        Me.chkReviewIncorrect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkReviewIncorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReviewIncorrect.Location = New System.Drawing.Point(428, 384)
        Me.chkReviewIncorrect.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkReviewIncorrect.Name = "chkReviewIncorrect"
        Me.chkReviewIncorrect.Size = New System.Drawing.Size(309, 45)
        Me.chkReviewIncorrect.TabIndex = 18
        Me.chkReviewIncorrect.Text = "Review Incorrect"
        Me.ToolTip1.SetToolTip(Me.chkReviewIncorrect, "Mark this option to enable Reviewing of Incorrect Items in Item Review.")
        Me.chkReviewIncorrect.UseCompatibleTextRendering = True
        Me.chkReviewIncorrect.UseVisualStyleBackColor = True
        '
        'chkReviewCorrect
        '
        Me.chkReviewCorrect.AutoSize = True
        Me.chkReviewCorrect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkReviewCorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReviewCorrect.Location = New System.Drawing.Point(428, 343)
        Me.chkReviewCorrect.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkReviewCorrect.Name = "chkReviewCorrect"
        Me.chkReviewCorrect.Size = New System.Drawing.Size(288, 45)
        Me.chkReviewCorrect.TabIndex = 17
        Me.chkReviewCorrect.Text = "Review Correct"
        Me.ToolTip1.SetToolTip(Me.chkReviewCorrect, "Mark this option to enable Reviewing of Correct Items in Item Review.")
        Me.chkReviewCorrect.UseCompatibleTextRendering = True
        Me.chkReviewCorrect.UseVisualStyleBackColor = True
        '
        'chkPauseTimer
        '
        Me.chkPauseTimer.AutoSize = True
        Me.chkPauseTimer.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkPauseTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPauseTimer.Location = New System.Drawing.Point(428, 302)
        Me.chkPauseTimer.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkPauseTimer.Name = "chkPauseTimer"
        Me.chkPauseTimer.Size = New System.Drawing.Size(380, 45)
        Me.chkPauseTimer.TabIndex = 16
        Me.chkPauseTimer.Text = "Pause Timer Feature"
        Me.ToolTip1.SetToolTip(Me.chkPauseTimer, "Mark this option to be able to Pause the Time Remaining")
        Me.chkPauseTimer.UseCompatibleTextRendering = True
        Me.chkPauseTimer.UseVisualStyleBackColor = True
        '
        'chkHideTimer
        '
        Me.chkHideTimer.AutoSize = True
        Me.chkHideTimer.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkHideTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHideTimer.Location = New System.Drawing.Point(427, 261)
        Me.chkHideTimer.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkHideTimer.Name = "chkHideTimer"
        Me.chkHideTimer.Size = New System.Drawing.Size(352, 45)
        Me.chkHideTimer.TabIndex = 15
        Me.chkHideTimer.Text = "Hide Timer Feature"
        Me.ToolTip1.SetToolTip(Me.chkHideTimer, "Mark this option to be able to Hide the Time Remaining")
        Me.chkHideTimer.UseCompatibleTextRendering = True
        Me.chkHideTimer.UseVisualStyleBackColor = True
        '
        'chkScoreTest
        '
        Me.chkScoreTest.AutoSize = True
        Me.chkScoreTest.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkScoreTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScoreTest.Location = New System.Drawing.Point(427, 220)
        Me.chkScoreTest.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkScoreTest.Name = "chkScoreTest"
        Me.chkScoreTest.Size = New System.Drawing.Size(330, 45)
        Me.chkScoreTest.TabIndex = 14
        Me.chkScoreTest.Text = "Score Test Button"
        Me.ToolTip1.SetToolTip(Me.chkScoreTest, "Mark this option to be able to Score the Test immediately.")
        Me.chkScoreTest.UseCompatibleTextRendering = True
        Me.chkScoreTest.UseVisualStyleBackColor = True
        '
        'chkMultChoice
        '
        Me.chkMultChoice.AutoSize = True
        Me.chkMultChoice.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkMultChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMultChoice.Location = New System.Drawing.Point(428, 179)
        Me.chkMultChoice.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkMultChoice.Name = "chkMultChoice"
        Me.chkMultChoice.Size = New System.Drawing.Size(372, 45)
        Me.chkMultChoice.TabIndex = 13
        Me.chkMultChoice.Text = "Multiple Choice Only"
        Me.ToolTip1.SetToolTip(Me.chkMultChoice, "Only select Multiple Choice Type Questions. This includes True/False, Multiple An" &
        "swer but will not show Input type Questions.")
        Me.chkMultChoice.UseCompatibleTextRendering = True
        Me.chkMultChoice.UseVisualStyleBackColor = True
        '
        'chkAddNotes
        '
        Me.chkAddNotes.AutoSize = True
        Me.chkAddNotes.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkAddNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAddNotes.Location = New System.Drawing.Point(428, 138)
        Me.chkAddNotes.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkAddNotes.Name = "chkAddNotes"
        Me.chkAddNotes.Size = New System.Drawing.Size(344, 45)
        Me.chkAddNotes.TabIndex = 12
        Me.chkAddNotes.Text = "Add Notes Feature"
        Me.ToolTip1.SetToolTip(Me.chkAddNotes, "Enable Note taking during exam.")
        Me.chkAddNotes.UseCompatibleTextRendering = True
        Me.chkAddNotes.UseVisualStyleBackColor = True
        '
        'chkPreviousButton
        '
        Me.chkPreviousButton.AutoSize = True
        Me.chkPreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkPreviousButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPreviousButton.Location = New System.Drawing.Point(428, 97)
        Me.chkPreviousButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkPreviousButton.Name = "chkPreviousButton"
        Me.chkPreviousButton.Size = New System.Drawing.Size(296, 45)
        Me.chkPreviousButton.TabIndex = 11
        Me.chkPreviousButton.Text = "Previous Button"
        Me.ToolTip1.SetToolTip(Me.chkPreviousButton, "Mark this option to Show a Previous button to go back to the previous question as" &
        "ked.")
        Me.chkPreviousButton.UseCompatibleTextRendering = True
        Me.chkPreviousButton.UseVisualStyleBackColor = True
        '
        'chkShowExplanationButton
        '
        Me.chkShowExplanationButton.AutoSize = True
        Me.chkShowExplanationButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkShowExplanationButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowExplanationButton.Location = New System.Drawing.Point(428, 56)
        Me.chkShowExplanationButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkShowExplanationButton.Name = "chkShowExplanationButton"
        Me.chkShowExplanationButton.Size = New System.Drawing.Size(344, 45)
        Me.chkShowExplanationButton.TabIndex = 10
        Me.chkShowExplanationButton.Text = "Explanation Button"
        Me.ToolTip1.SetToolTip(Me.chkShowExplanationButton, "Check this box to show the explanation button which shows the explanation, correc" &
        "t answer and Correct/Incorrect status during the exam.")
        Me.chkShowExplanationButton.UseCompatibleTextRendering = True
        Me.chkShowExplanationButton.UseVisualStyleBackColor = True
        '
        'chkReviewUnanswered
        '
        Me.chkReviewUnanswered.AutoSize = True
        Me.chkReviewUnanswered.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkReviewUnanswered.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReviewUnanswered.Location = New System.Drawing.Point(41, 384)
        Me.chkReviewUnanswered.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkReviewUnanswered.Name = "chkReviewUnanswered"
        Me.chkReviewUnanswered.Size = New System.Drawing.Size(494, 45)
        Me.chkReviewUnanswered.TabIndex = 9
        Me.chkReviewUnanswered.Text = "Enable Review Unanswered"
        Me.ToolTip1.SetToolTip(Me.chkReviewUnanswered, "Mark this option to enable Reviewing of Unanswered Items in Item Review.")
        Me.chkReviewUnanswered.UseCompatibleTextRendering = True
        Me.chkReviewUnanswered.UseVisualStyleBackColor = True
        '
        'chkReviewAnswered
        '
        Me.chkReviewAnswered.AutoSize = True
        Me.chkReviewAnswered.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkReviewAnswered.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReviewAnswered.Location = New System.Drawing.Point(41, 343)
        Me.chkReviewAnswered.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkReviewAnswered.Name = "chkReviewAnswered"
        Me.chkReviewAnswered.Size = New System.Drawing.Size(452, 45)
        Me.chkReviewAnswered.TabIndex = 8
        Me.chkReviewAnswered.Text = "Enable Review Answered"
        Me.ToolTip1.SetToolTip(Me.chkReviewAnswered, "Mark this option to enable Reviewing of Answered Items in Item Review.")
        Me.chkReviewAnswered.UseCompatibleTextRendering = True
        Me.chkReviewAnswered.UseVisualStyleBackColor = True
        '
        'chkReviewUnMarked
        '
        Me.chkReviewUnMarked.AutoSize = True
        Me.chkReviewUnMarked.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkReviewUnMarked.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReviewUnMarked.Location = New System.Drawing.Point(41, 302)
        Me.chkReviewUnMarked.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkReviewUnMarked.Name = "chkReviewUnMarked"
        Me.chkReviewUnMarked.Size = New System.Drawing.Size(458, 45)
        Me.chkReviewUnMarked.TabIndex = 7
        Me.chkReviewUnMarked.Text = "Enable Review Unmarked"
        Me.ToolTip1.SetToolTip(Me.chkReviewUnMarked, "Mark this option to enable Reviewing of UnMarked Items in Item Review.")
        Me.chkReviewUnMarked.UseCompatibleTextRendering = True
        Me.chkReviewUnMarked.UseVisualStyleBackColor = True
        '
        'chkReviewMarked
        '
        Me.chkReviewMarked.AutoSize = True
        Me.chkReviewMarked.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkReviewMarked.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReviewMarked.Location = New System.Drawing.Point(41, 261)
        Me.chkReviewMarked.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkReviewMarked.Name = "chkReviewMarked"
        Me.chkReviewMarked.Size = New System.Drawing.Size(412, 45)
        Me.chkReviewMarked.TabIndex = 6
        Me.chkReviewMarked.Text = "Enable Review Marked"
        Me.ToolTip1.SetToolTip(Me.chkReviewMarked, "Mark this option to enable Reviewing of Marked Items in Item Review.")
        Me.chkReviewMarked.UseCompatibleTextRendering = True
        Me.chkReviewMarked.UseVisualStyleBackColor = True
        '
        'chkMarkForReview
        '
        Me.chkMarkForReview.AutoSize = True
        Me.chkMarkForReview.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkMarkForReview.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMarkForReview.Location = New System.Drawing.Point(41, 220)
        Me.chkMarkForReview.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkMarkForReview.Name = "chkMarkForReview"
        Me.chkMarkForReview.Size = New System.Drawing.Size(436, 45)
        Me.chkMarkForReview.TabIndex = 5
        Me.chkMarkForReview.Text = "Enable Mark For Review"
        Me.ToolTip1.SetToolTip(Me.chkMarkForReview, "Mark this option to be able to Bookmark Items to go back to during Exam.")
        Me.chkMarkForReview.UseCompatibleTextRendering = True
        Me.chkMarkForReview.UseVisualStyleBackColor = True
        '
        'chkItemReview
        '
        Me.chkItemReview.AutoSize = True
        Me.chkItemReview.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkItemReview.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkItemReview.Location = New System.Drawing.Point(41, 179)
        Me.chkItemReview.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkItemReview.Name = "chkItemReview"
        Me.chkItemReview.Size = New System.Drawing.Size(475, 45)
        Me.chkItemReview.TabIndex = 4
        Me.chkItemReview.Text = "Enable Item Review Button"
        Me.ToolTip1.SetToolTip(Me.chkItemReview, "Enable Item Review Button")
        Me.chkItemReview.UseCompatibleTextRendering = True
        Me.chkItemReview.UseVisualStyleBackColor = True
        '
        'chkProgressBar
        '
        Me.chkProgressBar.AutoSize = True
        Me.chkProgressBar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkProgressBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProgressBar.Location = New System.Drawing.Point(41, 138)
        Me.chkProgressBar.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkProgressBar.Name = "chkProgressBar"
        Me.chkProgressBar.Size = New System.Drawing.Size(298, 45)
        Me.chkProgressBar.TabIndex = 3
        Me.chkProgressBar.Text = "chkProgressBar"
        Me.ToolTip1.SetToolTip(Me.chkProgressBar, "Mark this option to Show a Graphical Progress Bar. Otherwise the status will read" &
        " Question: 1 of #")
        Me.chkProgressBar.UseCompatibleTextRendering = True
        Me.chkProgressBar.UseVisualStyleBackColor = True
        '
        'chkShowPercentCorrect
        '
        Me.chkShowPercentCorrect.AutoSize = True
        Me.chkShowPercentCorrect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkShowPercentCorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPercentCorrect.Location = New System.Drawing.Point(41, 97)
        Me.chkShowPercentCorrect.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkShowPercentCorrect.Name = "chkShowPercentCorrect"
        Me.chkShowPercentCorrect.Size = New System.Drawing.Size(430, 45)
        Me.chkShowPercentCorrect.TabIndex = 2
        Me.chkShowPercentCorrect.Text = "chkShowPercentCorrect"
        Me.ToolTip1.SetToolTip(Me.chkShowPercentCorrect, "Show the Percentage of Questions answered correctly.")
        Me.chkShowPercentCorrect.UseCompatibleTextRendering = True
        Me.chkShowPercentCorrect.UseVisualStyleBackColor = True
        '
        'chkShowAnswer
        '
        Me.chkShowAnswer.AccessibleDescription = ""
        Me.chkShowAnswer.AutoSize = True
        Me.chkShowAnswer.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkShowAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowAnswer.Location = New System.Drawing.Point(41, 56)
        Me.chkShowAnswer.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkShowAnswer.Name = "chkShowAnswer"
        Me.chkShowAnswer.Size = New System.Drawing.Size(390, 45)
        Me.chkShowAnswer.TabIndex = 1
        Me.chkShowAnswer.Text = "'Show Answer' Button"
        Me.chkShowAnswer.UseCompatibleTextRendering = True
        Me.chkShowAnswer.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(800, 48)
        Me.Label5.TabIndex = 0
        Me.Label5.Tag = ""
        Me.Label5.Text = "More Exam Options :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label5, "Listed below are the exam options. These options are not available for flashcards" &
        " exams.")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Nerdom.My.Resources.Resources.mark
        Me.PictureBox1.Location = New System.Drawing.Point(13, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1370, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnExam6)
        Me.Panel1.Controls.Add(Me.BtnExam5)
        Me.Panel1.Controls.Add(Me.BtnExam4)
        Me.Panel1.Controls.Add(Me.BtnExam3)
        Me.Panel1.Controls.Add(Me.BtnExam2)
        Me.Panel1.Controls.Add(Me.BtnExam1)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.Lbl_Topic)
        Me.Panel1.Location = New System.Drawing.Point(5, 169)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(757, 604)
        Me.Panel1.TabIndex = 5
        '
        'BtnExam6
        '
        Me.BtnExam6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnExam6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExam6.Location = New System.Drawing.Point(500, 364)
        Me.BtnExam6.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.BtnExam6.Name = "BtnExam6"
        Me.BtnExam6.Size = New System.Drawing.Size(214, 56)
        Me.BtnExam6.TabIndex = 8
        Me.BtnExam6.Text = "Exam 6 - All"
        Me.BtnExam6.UseVisualStyleBackColor = True
        '
        'BtnExam5
        '
        Me.BtnExam5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnExam5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExam5.Location = New System.Drawing.Point(500, 286)
        Me.BtnExam5.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.BtnExam5.Name = "BtnExam5"
        Me.BtnExam5.Size = New System.Drawing.Size(214, 56)
        Me.BtnExam5.TabIndex = 7
        Me.BtnExam5.Text = "Exam 5"
        Me.BtnExam5.UseVisualStyleBackColor = True
        '
        'BtnExam4
        '
        Me.BtnExam4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnExam4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExam4.Location = New System.Drawing.Point(500, 218)
        Me.BtnExam4.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.BtnExam4.Name = "BtnExam4"
        Me.BtnExam4.Size = New System.Drawing.Size(214, 56)
        Me.BtnExam4.TabIndex = 6
        Me.BtnExam4.Text = "Exam 4"
        Me.BtnExam4.UseVisualStyleBackColor = True
        '
        'BtnExam3
        '
        Me.BtnExam3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnExam3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExam3.Location = New System.Drawing.Point(500, 152)
        Me.BtnExam3.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.BtnExam3.Name = "BtnExam3"
        Me.BtnExam3.Size = New System.Drawing.Size(214, 56)
        Me.BtnExam3.TabIndex = 5
        Me.BtnExam3.Text = "Exam 3"
        Me.BtnExam3.UseVisualStyleBackColor = True
        '
        'BtnExam2
        '
        Me.BtnExam2.BackColor = System.Drawing.Color.DarkGray
        Me.BtnExam2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnExam2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExam2.Location = New System.Drawing.Point(500, 82)
        Me.BtnExam2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.BtnExam2.Name = "BtnExam2"
        Me.BtnExam2.Size = New System.Drawing.Size(214, 56)
        Me.BtnExam2.TabIndex = 4
        Me.BtnExam2.Text = "Exam 2"
        Me.BtnExam2.UseVisualStyleBackColor = False
        '
        'BtnExam1
        '
        Me.BtnExam1.BackColor = System.Drawing.Color.DarkGray
        Me.BtnExam1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnExam1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExam1.Location = New System.Drawing.Point(500, 13)
        Me.BtnExam1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.BtnExam1.Name = "BtnExam1"
        Me.BtnExam1.Size = New System.Drawing.Size(214, 56)
        Me.BtnExam1.TabIndex = 3
        Me.BtnExam1.Text = "Exam 1"
        Me.BtnExam1.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 47
        Me.ListBox1.Location = New System.Drawing.Point(13, 13)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(450, 380)
        Me.ListBox1.TabIndex = 2
        '
        'Lbl_Topic
        '
        Me.Lbl_Topic.BackColor = System.Drawing.SystemColors.Window
        Me.Lbl_Topic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Topic.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Topic.Location = New System.Drawing.Point(13, 429)
        Me.Lbl_Topic.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Lbl_Topic.Name = "Lbl_Topic"
        Me.Lbl_Topic.Size = New System.Drawing.Size(726, 159)
        Me.Lbl_Topic.TabIndex = 1
        Me.Lbl_Topic.Text = "Topic 1"
        '
        'frmMainE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(24.0!, 47.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1384, 789)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Lbl_Def)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "frmMainE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lbl_Def As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnLaunchExam As Button
    Friend WithEvents chkRandAnswers As CheckBox
    Friend WithEvents chkRandQuestions As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSaveOptions As Button
    Friend WithEvents BtnMoreOptions As Button
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cbMinutes As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkTimedExam As CheckBox
    Friend WithEvents cbSelectAll As ComboBox
    Friend WithEvents cbSelectNum As ComboBox
    Friend WithEvents rdoSelectAll As RadioButton
    Friend WithEvents rdoSelectNum As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents chkEndExam As CheckBox
    Friend WithEvents chkShowExplanationIncorrect As CheckBox
    Friend WithEvents chkShowExplanationCorrect As CheckBox
    Friend WithEvents chkCorrectReview As CheckBox
    Friend WithEvents chkReviewIncorrect As CheckBox
    Friend WithEvents chkReviewCorrect As CheckBox
    Friend WithEvents chkPauseTimer As CheckBox
    Friend WithEvents chkHideTimer As CheckBox
    Friend WithEvents chkScoreTest As CheckBox
    Friend WithEvents chkMultChoice As CheckBox
    Friend WithEvents chkAddNotes As CheckBox
    Friend WithEvents chkPreviousButton As CheckBox
    Friend WithEvents chkShowExplanationButton As CheckBox
    Friend WithEvents chkReviewUnanswered As CheckBox
    Friend WithEvents chkReviewAnswered As CheckBox
    Friend WithEvents chkReviewUnMarked As CheckBox
    Friend WithEvents chkReviewMarked As CheckBox
    Friend WithEvents chkMarkForReview As CheckBox
    Friend WithEvents chkItemReview As CheckBox
    Friend WithEvents chkProgressBar As CheckBox
    Friend WithEvents chkShowPercentCorrect As CheckBox
    Friend WithEvents chkShowAnswer As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnResetOptions As Button
    Friend WithEvents BtnStudyMode As Button
    Friend WithEvents BtnExamMode As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnExam6 As Button
    Friend WithEvents BtnExam5 As Button
    Friend WithEvents BtnExam4 As Button
    Friend WithEvents BtnExam3 As Button
    Friend WithEvents BtnExam2 As Button
    Friend WithEvents BtnExam1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Lbl_Topic As Label
End Class
