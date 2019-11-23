<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNet1
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblPercentCorrect = New System.Windows.Forms.Label()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTimeDiff = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkMarkForReview = New System.Windows.Forms.CheckBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnShowExplanation = New System.Windows.Forms.Button()
        Me.btnReview = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.lblPauseTimer = New System.Windows.Forms.Label()
        Me.lblHideTimer = New System.Windows.Forms.Label()
        Me.btnNotes = New System.Windows.Forms.Button()
        Me.btnScoreTest = New System.Windows.Forms.Button()
        Me.btnShowAnswer = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtQuesN1 = New System.Windows.Forms.TextBox()
        Me.PanelInputBox = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtInputAnswer = New System.Windows.Forms.TextBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelCheckBox = New System.Windows.Forms.Panel()
        Me.lblFraC7 = New System.Windows.Forms.Label()
        Me.lblFraC6 = New System.Windows.Forms.Label()
        Me.lblFraC5 = New System.Windows.Forms.Label()
        Me.lblFraC4 = New System.Windows.Forms.Label()
        Me.lblFraC3 = New System.Windows.Forms.Label()
        Me.lblFraC2 = New System.Windows.Forms.Label()
        Me.lblFraC1 = New System.Windows.Forms.Label()
        Me.ChkFra7 = New System.Windows.Forms.CheckBox()
        Me.ChkFra6 = New System.Windows.Forms.CheckBox()
        Me.ChkFra5 = New System.Windows.Forms.CheckBox()
        Me.ChkFra4 = New System.Windows.Forms.CheckBox()
        Me.ChkFra3 = New System.Windows.Forms.CheckBox()
        Me.ChkFra2 = New System.Windows.Forms.CheckBox()
        Me.ChkFra1 = New System.Windows.Forms.CheckBox()
        Me.PanelRadioBox = New System.Windows.Forms.Panel()
        Me.lblFraR7 = New System.Windows.Forms.Label()
        Me.lblFraR6 = New System.Windows.Forms.Label()
        Me.lblFraR5 = New System.Windows.Forms.Label()
        Me.lblFraR4 = New System.Windows.Forms.Label()
        Me.lblFraR3 = New System.Windows.Forms.Label()
        Me.lblFraR2 = New System.Windows.Forms.Label()
        Me.lblFraR1 = New System.Windows.Forms.Label()
        Me.rdoFra7 = New System.Windows.Forms.RadioButton()
        Me.rdoFra6 = New System.Windows.Forms.RadioButton()
        Me.rdoFra5 = New System.Windows.Forms.RadioButton()
        Me.rdoFra4 = New System.Windows.Forms.RadioButton()
        Me.rdoFra3 = New System.Windows.Forms.RadioButton()
        Me.rdoFra2 = New System.Windows.Forms.RadioButton()
        Me.rdoFra1 = New System.Windows.Forms.RadioButton()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.PanelInputBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelCheckBox.SuspendLayout()
        Me.PanelRadioBox.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'lblPercentCorrect
        '
        Me.lblPercentCorrect.AutoSize = True
        Me.lblPercentCorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentCorrect.Location = New System.Drawing.Point(1416, 12)
        Me.lblPercentCorrect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPercentCorrect.Name = "lblPercentCorrect"
        Me.lblPercentCorrect.Size = New System.Drawing.Size(217, 40)
        Me.lblPercentCorrect.TabIndex = 18
        Me.lblPercentCorrect.Text = "Correct : 0%"
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.Location = New System.Drawing.Point(1128, 12)
        Me.lblPercent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(187, 40)
        Me.lblPercent.TabIndex = 17
        Me.lblPercent.Text = "400 of 400"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(627, 18)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(494, 40)
        Me.ProgressBar1.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(434, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 40)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Question :"
        '
        'lblTimeDiff
        '
        Me.lblTimeDiff.AutoSize = True
        Me.lblTimeDiff.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeDiff.Location = New System.Drawing.Point(184, 17)
        Me.lblTimeDiff.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimeDiff.Name = "lblTimeDiff"
        Me.lblTimeDiff.Size = New System.Drawing.Size(125, 40)
        Me.lblTimeDiff.TabIndex = 14
        Me.lblTimeDiff.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 40)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Time Left :"
        '
        'chkMarkForReview
        '
        Me.chkMarkForReview.AutoSize = True
        Me.chkMarkForReview.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMarkForReview.Location = New System.Drawing.Point(1766, 11)
        Me.chkMarkForReview.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkMarkForReview.Name = "chkMarkForReview"
        Me.chkMarkForReview.Size = New System.Drawing.Size(297, 44)
        Me.chkMarkForReview.TabIndex = 19
        Me.chkMarkForReview.Text = "Make for review"
        Me.chkMarkForReview.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(18, 20)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(300, 69)
        Me.btnPrevious.TabIndex = 0
        Me.btnPrevious.Text = "<< Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnShowExplanation
        '
        Me.btnShowExplanation.Location = New System.Drawing.Point(18, 111)
        Me.btnShowExplanation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnShowExplanation.Name = "btnShowExplanation"
        Me.btnShowExplanation.Size = New System.Drawing.Size(300, 69)
        Me.btnShowExplanation.TabIndex = 5
        Me.btnShowExplanation.Text = "Explanation"
        Me.btnShowExplanation.UseVisualStyleBackColor = True
        '
        'btnReview
        '
        Me.btnReview.Enabled = False
        Me.btnReview.Location = New System.Drawing.Point(1412, 20)
        Me.btnReview.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReview.Name = "btnReview"
        Me.btnReview.Size = New System.Drawing.Size(300, 69)
        Me.btnReview.TabIndex = 4
        Me.btnReview.Text = "Preview Items"
        Me.btnReview.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(1734, 20)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(300, 69)
        Me.btnShow.TabIndex = 3
        Me.btnShow.Text = "Exhibit"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnForward
        '
        Me.btnForward.Location = New System.Drawing.Point(662, 20)
        Me.btnForward.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(300, 69)
        Me.btnForward.TabIndex = 2
        Me.btnForward.Text = "Next >>"
        Me.btnForward.UseVisualStyleBackColor = True
        '
        'lblPauseTimer
        '
        Me.lblPauseTimer.AutoSize = True
        Me.lblPauseTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPauseTimer.ForeColor = System.Drawing.Color.Blue
        Me.lblPauseTimer.Location = New System.Drawing.Point(1036, 112)
        Me.lblPauseTimer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPauseTimer.Name = "lblPauseTimer"
        Me.lblPauseTimer.Size = New System.Drawing.Size(221, 40)
        Me.lblPauseTimer.TabIndex = 10
        Me.lblPauseTimer.Text = "Pause Timer"
        '
        'lblHideTimer
        '
        Me.lblHideTimer.AutoSize = True
        Me.lblHideTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHideTimer.ForeColor = System.Drawing.Color.Blue
        Me.lblHideTimer.Location = New System.Drawing.Point(808, 112)
        Me.lblHideTimer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHideTimer.Name = "lblHideTimer"
        Me.lblHideTimer.Size = New System.Drawing.Size(193, 40)
        Me.lblHideTimer.TabIndex = 9
        Me.lblHideTimer.Text = "Hide Timer"
        '
        'btnNotes
        '
        Me.btnNotes.Location = New System.Drawing.Point(1734, 111)
        Me.btnNotes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNotes.Name = "btnNotes"
        Me.btnNotes.Size = New System.Drawing.Size(300, 69)
        Me.btnNotes.TabIndex = 8
        Me.btnNotes.Text = "Add Notes"
        Me.btnNotes.UseVisualStyleBackColor = True
        '
        'btnScoreTest
        '
        Me.btnScoreTest.Location = New System.Drawing.Point(1412, 111)
        Me.btnScoreTest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnScoreTest.Name = "btnScoreTest"
        Me.btnScoreTest.Size = New System.Drawing.Size(300, 69)
        Me.btnScoreTest.TabIndex = 7
        Me.btnScoreTest.Text = "Score Test"
        Me.btnScoreTest.UseVisualStyleBackColor = True
        '
        'btnShowAnswer
        '
        Me.btnShowAnswer.Location = New System.Drawing.Point(339, 111)
        Me.btnShowAnswer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnShowAnswer.Name = "btnShowAnswer"
        Me.btnShowAnswer.Size = New System.Drawing.Size(300, 69)
        Me.btnShowAnswer.TabIndex = 6
        Me.btnShowAnswer.Text = "Show Answer"
        Me.btnShowAnswer.UseVisualStyleBackColor = True
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
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(10, 1002)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2057, 200)
        Me.Panel1.TabIndex = 12
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(339, 20)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(300, 69)
        Me.btnSubmit.TabIndex = 1
        Me.btnSubmit.Text = "Save Answer"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtQuesN1
        '
        Me.txtQuesN1.BackColor = System.Drawing.SystemColors.Window
        Me.txtQuesN1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuesN1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQuesN1.Location = New System.Drawing.Point(10, 75)
        Me.txtQuesN1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtQuesN1.Multiline = True
        Me.txtQuesN1.Name = "txtQuesN1"
        Me.txtQuesN1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtQuesN1.Size = New System.Drawing.Size(2056, 290)
        Me.txtQuesN1.TabIndex = 11
        '
        'PanelInputBox
        '
        Me.PanelInputBox.BackColor = System.Drawing.SystemColors.Window
        Me.PanelInputBox.Controls.Add(Me.GroupBox1)
        Me.PanelInputBox.Controls.Add(Me.txtInput)
        Me.PanelInputBox.Controls.Add(Me.Label2)
        Me.PanelInputBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelInputBox.Location = New System.Drawing.Point(10, 377)
        Me.PanelInputBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelInputBox.Name = "PanelInputBox"
        Me.PanelInputBox.Size = New System.Drawing.Size(2058, 615)
        Me.PanelInputBox.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtInputAnswer)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.GroupBox1.Location = New System.Drawing.Point(381, 391)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1245, 122)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Answer"
        Me.GroupBox1.Visible = False
        '
        'txtInputAnswer
        '
        Me.txtInputAnswer.BackColor = System.Drawing.SystemColors.Window
        Me.txtInputAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInputAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputAnswer.Location = New System.Drawing.Point(12, 52)
        Me.txtInputAnswer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtInputAnswer.Name = "txtInputAnswer"
        Me.txtInputAnswer.Size = New System.Drawing.Size(1224, 41)
        Me.txtInputAnswer.TabIndex = 3
        '
        'txtInput
        '
        Me.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(381, 265)
        Me.txtInput.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(1244, 48)
        Me.txtInput.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(374, 197)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(502, 40)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Input answer in the box below."
        '
        'PanelCheckBox
        '
        Me.PanelCheckBox.BackColor = System.Drawing.SystemColors.Window
        Me.PanelCheckBox.Controls.Add(Me.lblFraC7)
        Me.PanelCheckBox.Controls.Add(Me.lblFraC6)
        Me.PanelCheckBox.Controls.Add(Me.lblFraC5)
        Me.PanelCheckBox.Controls.Add(Me.lblFraC4)
        Me.PanelCheckBox.Controls.Add(Me.lblFraC3)
        Me.PanelCheckBox.Controls.Add(Me.lblFraC2)
        Me.PanelCheckBox.Controls.Add(Me.lblFraC1)
        Me.PanelCheckBox.Controls.Add(Me.ChkFra7)
        Me.PanelCheckBox.Controls.Add(Me.ChkFra6)
        Me.PanelCheckBox.Controls.Add(Me.ChkFra5)
        Me.PanelCheckBox.Controls.Add(Me.ChkFra4)
        Me.PanelCheckBox.Controls.Add(Me.ChkFra3)
        Me.PanelCheckBox.Controls.Add(Me.ChkFra2)
        Me.PanelCheckBox.Controls.Add(Me.ChkFra1)
        Me.PanelCheckBox.Location = New System.Drawing.Point(10, 377)
        Me.PanelCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelCheckBox.Name = "PanelCheckBox"
        Me.PanelCheckBox.Size = New System.Drawing.Size(2056, 615)
        Me.PanelCheckBox.TabIndex = 36
        '
        'lblFraC7
        '
        Me.lblFraC7.AutoSize = True
        Me.lblFraC7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFraC7.Location = New System.Drawing.Point(200, 522)
        Me.lblFraC7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFraC7.Name = "lblFraC7"
        Me.lblFraC7.Size = New System.Drawing.Size(125, 40)
        Me.lblFraC7.TabIndex = 13
        Me.lblFraC7.Text = "Label9"
        '
        'lblFraC6
        '
        Me.lblFraC6.AutoSize = True
        Me.lblFraC6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFraC6.Location = New System.Drawing.Point(200, 446)
        Me.lblFraC6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFraC6.Name = "lblFraC6"
        Me.lblFraC6.Size = New System.Drawing.Size(125, 40)
        Me.lblFraC6.TabIndex = 12
        Me.lblFraC6.Text = "Label8"
        '
        'lblFraC5
        '
        Me.lblFraC5.AutoSize = True
        Me.lblFraC5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFraC5.Location = New System.Drawing.Point(200, 369)
        Me.lblFraC5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFraC5.Name = "lblFraC5"
        Me.lblFraC5.Size = New System.Drawing.Size(125, 40)
        Me.lblFraC5.TabIndex = 11
        Me.lblFraC5.Text = "Label7"
        '
        'lblFraC4
        '
        Me.lblFraC4.AutoSize = True
        Me.lblFraC4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFraC4.Location = New System.Drawing.Point(200, 294)
        Me.lblFraC4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFraC4.Name = "lblFraC4"
        Me.lblFraC4.Size = New System.Drawing.Size(125, 40)
        Me.lblFraC4.TabIndex = 10
        Me.lblFraC4.Text = "Label6"
        '
        'lblFraC3
        '
        Me.lblFraC3.AutoSize = True
        Me.lblFraC3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFraC3.Location = New System.Drawing.Point(200, 212)
        Me.lblFraC3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFraC3.Name = "lblFraC3"
        Me.lblFraC3.Size = New System.Drawing.Size(125, 40)
        Me.lblFraC3.TabIndex = 9
        Me.lblFraC3.Text = "Label5"
        '
        'lblFraC2
        '
        Me.lblFraC2.AutoSize = True
        Me.lblFraC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFraC2.Location = New System.Drawing.Point(200, 135)
        Me.lblFraC2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFraC2.Name = "lblFraC2"
        Me.lblFraC2.Size = New System.Drawing.Size(125, 40)
        Me.lblFraC2.TabIndex = 8
        Me.lblFraC2.Text = "Label4"
        '
        'lblFraC1
        '
        Me.lblFraC1.AutoSize = True
        Me.lblFraC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFraC1.Location = New System.Drawing.Point(200, 55)
        Me.lblFraC1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFraC1.Name = "lblFraC1"
        Me.lblFraC1.Size = New System.Drawing.Size(125, 40)
        Me.lblFraC1.TabIndex = 7
        Me.lblFraC1.Text = "Label2"
        '
        'ChkFra7
        '
        Me.ChkFra7.AutoSize = True
        Me.ChkFra7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkFra7.Location = New System.Drawing.Point(120, 522)
        Me.ChkFra7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkFra7.Name = "ChkFra7"
        Me.ChkFra7.Size = New System.Drawing.Size(71, 44)
        Me.ChkFra7.TabIndex = 6
        Me.ChkFra7.Text = "G"
        Me.ChkFra7.UseVisualStyleBackColor = True
        '
        'ChkFra6
        '
        Me.ChkFra6.AutoSize = True
        Me.ChkFra6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkFra6.Location = New System.Drawing.Point(120, 446)
        Me.ChkFra6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkFra6.Name = "ChkFra6"
        Me.ChkFra6.Size = New System.Drawing.Size(65, 44)
        Me.ChkFra6.TabIndex = 5
        Me.ChkFra6.Text = "F"
        Me.ChkFra6.UseVisualStyleBackColor = True
        '
        'ChkFra5
        '
        Me.ChkFra5.AutoSize = True
        Me.ChkFra5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkFra5.Location = New System.Drawing.Point(120, 369)
        Me.ChkFra5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkFra5.Name = "ChkFra5"
        Me.ChkFra5.Size = New System.Drawing.Size(67, 44)
        Me.ChkFra5.TabIndex = 4
        Me.ChkFra5.Text = "E"
        Me.ChkFra5.UseVisualStyleBackColor = True
        '
        'ChkFra4
        '
        Me.ChkFra4.AutoSize = True
        Me.ChkFra4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkFra4.Location = New System.Drawing.Point(120, 292)
        Me.ChkFra4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkFra4.Name = "ChkFra4"
        Me.ChkFra4.Size = New System.Drawing.Size(69, 44)
        Me.ChkFra4.TabIndex = 3
        Me.ChkFra4.Text = "D"
        Me.ChkFra4.UseVisualStyleBackColor = True
        '
        'ChkFra3
        '
        Me.ChkFra3.AutoSize = True
        Me.ChkFra3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkFra3.Location = New System.Drawing.Point(120, 212)
        Me.ChkFra3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkFra3.Name = "ChkFra3"
        Me.ChkFra3.Size = New System.Drawing.Size(69, 44)
        Me.ChkFra3.TabIndex = 2
        Me.ChkFra3.Text = "C"
        Me.ChkFra3.UseVisualStyleBackColor = True
        '
        'ChkFra2
        '
        Me.ChkFra2.AutoSize = True
        Me.ChkFra2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkFra2.Location = New System.Drawing.Point(120, 134)
        Me.ChkFra2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkFra2.Name = "ChkFra2"
        Me.ChkFra2.Size = New System.Drawing.Size(67, 44)
        Me.ChkFra2.TabIndex = 1
        Me.ChkFra2.Text = "B"
        Me.ChkFra2.UseVisualStyleBackColor = True
        '
        'ChkFra1
        '
        Me.ChkFra1.AutoSize = True
        Me.ChkFra1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkFra1.Location = New System.Drawing.Point(120, 54)
        Me.ChkFra1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkFra1.Name = "ChkFra1"
        Me.ChkFra1.Size = New System.Drawing.Size(67, 44)
        Me.ChkFra1.TabIndex = 0
        Me.ChkFra1.Text = "A"
        Me.ChkFra1.UseVisualStyleBackColor = True
        '
        'PanelRadioBox
        '
        Me.PanelRadioBox.BackColor = System.Drawing.SystemColors.Window
        Me.PanelRadioBox.Controls.Add(Me.lblFraR7)
        Me.PanelRadioBox.Controls.Add(Me.lblFraR6)
        Me.PanelRadioBox.Controls.Add(Me.lblFraR5)
        Me.PanelRadioBox.Controls.Add(Me.lblFraR4)
        Me.PanelRadioBox.Controls.Add(Me.lblFraR3)
        Me.PanelRadioBox.Controls.Add(Me.lblFraR2)
        Me.PanelRadioBox.Controls.Add(Me.lblFraR1)
        Me.PanelRadioBox.Controls.Add(Me.rdoFra7)
        Me.PanelRadioBox.Controls.Add(Me.rdoFra6)
        Me.PanelRadioBox.Controls.Add(Me.rdoFra5)
        Me.PanelRadioBox.Controls.Add(Me.rdoFra4)
        Me.PanelRadioBox.Controls.Add(Me.rdoFra3)
        Me.PanelRadioBox.Controls.Add(Me.rdoFra2)
        Me.PanelRadioBox.Controls.Add(Me.rdoFra1)
        Me.PanelRadioBox.Location = New System.Drawing.Point(10, 377)
        Me.PanelRadioBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelRadioBox.Name = "PanelRadioBox"
        Me.PanelRadioBox.Size = New System.Drawing.Size(2058, 615)
        Me.PanelRadioBox.TabIndex = 37
        '
        'lblFraR7
        '
        Me.lblFraR7.AutoSize = True
        Me.lblFraR7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFraR7.Location = New System.Drawing.Point(202, 522)
        Me.lblFraR7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFraR7.Name = "lblFraR7"
        Me.lblFraR7.Size = New System.Drawing.Size(125, 40)
        Me.lblFraR7.TabIndex = 13
        Me.lblFraR7.Text = "Label2"
        '
        'lblFraR6
        '
        Me.lblFraR6.AutoSize = True
        Me.lblFraR6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFraR6.Location = New System.Drawing.Point(200, 448)
        Me.lblFraR6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFraR6.Name = "lblFraR6"
        Me.lblFraR6.Size = New System.Drawing.Size(125, 40)
        Me.lblFraR6.TabIndex = 12
        Me.lblFraR6.Text = "Label2"
        '
        'lblFraR5
        '
        Me.lblFraR5.AutoSize = True
        Me.lblFraR5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFraR5.Location = New System.Drawing.Point(202, 369)
        Me.lblFraR5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFraR5.Name = "lblFraR5"
        Me.lblFraR5.Size = New System.Drawing.Size(125, 40)
        Me.lblFraR5.TabIndex = 11
        Me.lblFraR5.Text = "Label2"
        '
        'lblFraR4
        '
        Me.lblFraR4.AutoSize = True
        Me.lblFraR4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFraR4.Location = New System.Drawing.Point(202, 292)
        Me.lblFraR4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFraR4.Name = "lblFraR4"
        Me.lblFraR4.Size = New System.Drawing.Size(125, 40)
        Me.lblFraR4.TabIndex = 10
        Me.lblFraR4.Text = "Label2"
        '
        'lblFraR3
        '
        Me.lblFraR3.AutoSize = True
        Me.lblFraR3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFraR3.Location = New System.Drawing.Point(202, 212)
        Me.lblFraR3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFraR3.Name = "lblFraR3"
        Me.lblFraR3.Size = New System.Drawing.Size(125, 40)
        Me.lblFraR3.TabIndex = 9
        Me.lblFraR3.Text = "Label2"
        '
        'lblFraR2
        '
        Me.lblFraR2.AutoSize = True
        Me.lblFraR2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFraR2.Location = New System.Drawing.Point(202, 135)
        Me.lblFraR2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFraR2.Name = "lblFraR2"
        Me.lblFraR2.Size = New System.Drawing.Size(125, 40)
        Me.lblFraR2.TabIndex = 8
        Me.lblFraR2.Text = "Label2"
        '
        'lblFraR1
        '
        Me.lblFraR1.AutoSize = True
        Me.lblFraR1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFraR1.Location = New System.Drawing.Point(200, 55)
        Me.lblFraR1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFraR1.Name = "lblFraR1"
        Me.lblFraR1.Size = New System.Drawing.Size(125, 40)
        Me.lblFraR1.TabIndex = 7
        Me.lblFraR1.Text = "Label2"
        '
        'rdoFra7
        '
        Me.rdoFra7.AutoSize = True
        Me.rdoFra7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFra7.Location = New System.Drawing.Point(120, 522)
        Me.rdoFra7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoFra7.Name = "rdoFra7"
        Me.rdoFra7.Size = New System.Drawing.Size(70, 44)
        Me.rdoFra7.TabIndex = 6
        Me.rdoFra7.TabStop = True
        Me.rdoFra7.Text = "G"
        Me.rdoFra7.UseVisualStyleBackColor = True
        '
        'rdoFra6
        '
        Me.rdoFra6.AutoSize = True
        Me.rdoFra6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFra6.Location = New System.Drawing.Point(120, 446)
        Me.rdoFra6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoFra6.Name = "rdoFra6"
        Me.rdoFra6.Size = New System.Drawing.Size(64, 44)
        Me.rdoFra6.TabIndex = 5
        Me.rdoFra6.TabStop = True
        Me.rdoFra6.Text = "F"
        Me.rdoFra6.UseVisualStyleBackColor = True
        '
        'rdoFra5
        '
        Me.rdoFra5.AutoSize = True
        Me.rdoFra5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFra5.Location = New System.Drawing.Point(120, 369)
        Me.rdoFra5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoFra5.Name = "rdoFra5"
        Me.rdoFra5.Size = New System.Drawing.Size(66, 44)
        Me.rdoFra5.TabIndex = 4
        Me.rdoFra5.TabStop = True
        Me.rdoFra5.Text = "E"
        Me.rdoFra5.UseVisualStyleBackColor = True
        '
        'rdoFra4
        '
        Me.rdoFra4.AutoSize = True
        Me.rdoFra4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFra4.Location = New System.Drawing.Point(120, 292)
        Me.rdoFra4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoFra4.Name = "rdoFra4"
        Me.rdoFra4.Size = New System.Drawing.Size(68, 44)
        Me.rdoFra4.TabIndex = 3
        Me.rdoFra4.TabStop = True
        Me.rdoFra4.Text = "D"
        Me.rdoFra4.UseVisualStyleBackColor = True
        '
        'rdoFra3
        '
        Me.rdoFra3.AutoSize = True
        Me.rdoFra3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFra3.Location = New System.Drawing.Point(120, 212)
        Me.rdoFra3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoFra3.Name = "rdoFra3"
        Me.rdoFra3.Size = New System.Drawing.Size(68, 44)
        Me.rdoFra3.TabIndex = 2
        Me.rdoFra3.TabStop = True
        Me.rdoFra3.Text = "C"
        Me.rdoFra3.UseVisualStyleBackColor = True
        '
        'rdoFra2
        '
        Me.rdoFra2.AutoSize = True
        Me.rdoFra2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFra2.Location = New System.Drawing.Point(120, 134)
        Me.rdoFra2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoFra2.Name = "rdoFra2"
        Me.rdoFra2.Size = New System.Drawing.Size(66, 44)
        Me.rdoFra2.TabIndex = 1
        Me.rdoFra2.TabStop = True
        Me.rdoFra2.Text = "B"
        Me.rdoFra2.UseVisualStyleBackColor = True
        '
        'rdoFra1
        '
        Me.rdoFra1.AutoSize = True
        Me.rdoFra1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFra1.Location = New System.Drawing.Point(120, 54)
        Me.rdoFra1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoFra1.Name = "rdoFra1"
        Me.rdoFra1.Size = New System.Drawing.Size(66, 44)
        Me.rdoFra1.TabIndex = 0
        Me.rdoFra1.TabStop = True
        Me.rdoFra1.Text = "A"
        Me.rdoFra1.UseVisualStyleBackColor = True
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Nerdom.My.Resources.Resources._select
        Me.PictureBox7.Location = New System.Drawing.Point(50, 906)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(75, 38)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 70
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Nerdom.My.Resources.Resources._select
        Me.PictureBox6.Location = New System.Drawing.Point(50, 832)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(75, 38)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 69
        Me.PictureBox6.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Nerdom.My.Resources.Resources._select
        Me.PictureBox1.Location = New System.Drawing.Point(50, 437)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Nerdom.My.Resources.Resources._select
        Me.PictureBox2.Location = New System.Drawing.Point(50, 517)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 65
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Nerdom.My.Resources.Resources._select
        Me.PictureBox3.Location = New System.Drawing.Point(50, 595)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(75, 38)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 66
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Nerdom.My.Resources.Resources._select
        Me.PictureBox4.Location = New System.Drawing.Point(50, 675)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(75, 38)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 67
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Nerdom.My.Resources.Resources._select
        Me.PictureBox5.Location = New System.Drawing.Point(50, 754)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(75, 38)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 68
        Me.PictureBox5.TabStop = False
        '
        'frmNet1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2076, 1214)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PanelCheckBox)
        Me.Controls.Add(Me.PanelRadioBox)
        Me.Controls.Add(Me.PanelInputBox)
        Me.Controls.Add(Me.lblPercentCorrect)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTimeDiff)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkMarkForReview)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtQuesN1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frmNet1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNet1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelInputBox.ResumeLayout(False)
        Me.PanelInputBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelCheckBox.ResumeLayout(False)
        Me.PanelCheckBox.PerformLayout()
        Me.PanelRadioBox.ResumeLayout(False)
        Me.PanelRadioBox.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblPercentCorrect As Label
    Friend WithEvents lblPercent As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTimeDiff As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkMarkForReview As CheckBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnShowExplanation As Button
    Friend WithEvents btnReview As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents btnForward As Button
    Friend WithEvents lblPauseTimer As Label
    Friend WithEvents lblHideTimer As Label
    Friend WithEvents btnNotes As Button
    Friend WithEvents btnScoreTest As Button
    Friend WithEvents btnShowAnswer As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtQuesN1 As TextBox
    Friend WithEvents PanelInputBox As Panel
    Friend WithEvents txtInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtInputAnswer As TextBox
    Friend WithEvents PanelCheckBox As Panel
    Friend WithEvents lblFraC7 As Label
    Friend WithEvents lblFraC6 As Label
    Friend WithEvents lblFraC5 As Label
    Friend WithEvents lblFraC4 As Label
    Friend WithEvents lblFraC3 As Label
    Friend WithEvents lblFraC2 As Label
    Friend WithEvents lblFraC1 As Label
    Friend WithEvents ChkFra7 As CheckBox
    Friend WithEvents ChkFra6 As CheckBox
    Friend WithEvents ChkFra5 As CheckBox
    Friend WithEvents ChkFra4 As CheckBox
    Friend WithEvents ChkFra3 As CheckBox
    Friend WithEvents ChkFra2 As CheckBox
    Friend WithEvents ChkFra1 As CheckBox
    Friend WithEvents PanelRadioBox As Panel
    Friend WithEvents lblFraR7 As Label
    Friend WithEvents lblFraR6 As Label
    Friend WithEvents lblFraR5 As Label
    Friend WithEvents lblFraR4 As Label
    Friend WithEvents lblFraR3 As Label
    Friend WithEvents lblFraR2 As Label
    Friend WithEvents lblFraR1 As Label
    Friend WithEvents rdoFra7 As RadioButton
    Friend WithEvents rdoFra6 As RadioButton
    Friend WithEvents rdoFra5 As RadioButton
    Friend WithEvents rdoFra4 As RadioButton
    Friend WithEvents rdoFra3 As RadioButton
    Friend WithEvents rdoFra2 As RadioButton
    Friend WithEvents rdoFra1 As RadioButton
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
