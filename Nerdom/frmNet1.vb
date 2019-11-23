Imports Nerdom.frmMainE
Imports System.Data.OleDb
Public Class frmNet1
    Dim fme As frmMainE
    Dim provider As String
    Dim connString As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader

    Public Shared currQueNo = 0  'Current  Question No
    Dim timeLeft As Integer

    Public isClicked_ItemNotesBnt = False 'is clicked "Item w/Notes" button in frmReview form?
    Public isClicked_NoItemNotesBnt = False 'is clicked "Item w/Notes" button in frmReview form?
    Public isClicked_UnAnsweredBtn = False 'is clicked "Review UnAnswered" button in frmReview form?
    Public isClicked_AnsweredBtn = False 'is clicked "Review Answered" button in frmReview form?
    Public isClicked_IncorrectBtn = False 'is clicked "Review Incorrect" button in frmReview form?
    Public isClicked_CorrectBtn = False 'is clicked "Review Correct" button in frmReview form?
    Public isClicked_MarkedBtn = False 'is clicked "Review Marked" button in frmReview form?
    Public isClicked_UnMarkedBtn = False 'is clicked "Review UnMarked" button in frmReview form?

    Public Sub New(_form As frmMainE)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        fme = _form
    End Sub
    Private Sub frmNet1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Preferences()

        ' Read all data from database and insert in list "dbData". We use dbData in program
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="

        Dim file As String = ""
        If frmMainE.selectedExamNo = 1 Then file = "db" & Int32.Parse(frmMainE.selected_ID).ToString("D3")
        If frmMainE.selectedExamNo > 1 Then file = "db" & Int32.Parse(frmMainE.selected_ID).ToString("D3") & frmMainE.selectedExamNo
        file = Application.StartupPath & "\" & selectedSubFolder & file & ".mdb"

        connString = provider & file
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String

        If fme.chkMultChoice.Checked Then
            str = "SELECT * From Q1 WHERE chkoropt<>'i'"
        Else
            str = "SELECT * FROM Q1"
        End If

        'chkMultChoice

        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        dbData.Clear()
        Dim num = 0  'number of records
        While dr.Read()
            Dim rInfo As New frmMainE.RecordInfo()
            With rInfo
                .no = num
                .QID = dr("QID").ToString.Trim()
                .Ques = dr("Ques").ToString()
                .chkoropt = dr("chkoropt").ToString.Trim()
                .Explanation = dr("Explanation").ToString()
                .InputAnswer = dr("InputAnswer").ToString.Trim()
                .InputAnswer2 = dr("InputAnswer2").ToString.Trim()
                .Exhibit = dr("Exhibit").ToString.Trim()
                .ExhibitName = dr("ExhibitName").ToString.Trim()
                .Answer = dr("Answer").ToString.Trim()
                .AnsA = dr("AnsA").ToString.Trim()
                .AnsB = dr("AnsB").ToString.Trim()
                .AnsC = dr("AnsC").ToString.Trim()
                .AnsD = dr("AnsD").ToString.Trim()
                .AnsE = dr("AnsE").ToString.Trim()
                .AnsF = dr("AnsF").ToString.Trim()
                .AnsG = dr("AnsG").ToString.Trim()
                .Ans1 = dr("Ans1").ToString.Trim()
                .Ans2 = dr("Ans2").ToString.Trim()
                .Ans3 = dr("Ans3").ToString.Trim()
                .Ans4 = dr("Ans4").ToString.Trim()
                .Ans5 = dr("Ans5").ToString.Trim()
                .Ans6 = dr("Ans6").ToString.Trim()
                .Ans7 = dr("Ans7").ToString.Trim()

                .correct = "incomplete"
                .answered = ""
                .myAnswer = ""
                ReDim .mySelectedAnswers(7)
                .note = ""
                .marked = False
            End With
            dbData.Add(rInfo)
            num += 1
        End While
        myConnection.Close()

        '''''''''''''''''''''''''''''''''''
        ' make random array
        ReDim randomArray(num - 1)
        For i = 0 To num - 1
            randomArray(i) = i
        Next
        If fme.chkRandQuestions.Checked = True Then
            Dim i_random As New Random
            Randomize()
            For i = 0 To num - 1
                Dim dest = i_random.Next(0, num - 1)
                Dim temp = randomArray(i)
                randomArray(i) = randomArray(dest)
                randomArray(dest) = temp
            Next
        End If

        currQueNo = 0

        'Progress Bar
        ProgressBar1.Maximum = frmMainE.selectedQuestionNum

        DisplayData(0)

        'display head part
        If fme.chkTimedExam.Checked = True Then
            Timer1.Enabled = True
            lblTimeDiff.Text = fme.cbMinutes.Text & " minutes"
            timeLeft = fme.cbMinutes.Text
        Else
            lblTimeDiff.Visible = False
            Label1.Visible = False
            lblHideTimer.Visible = False
            lblPauseTimer.Visible = False
        End If

        'form caption
        If selectedExamNo = 1 Then Me.Text = dbIcnse(fme.ListBox1.SelectedIndex).TopicBut1
        If selectedExamNo = 2 Then Me.Text = dbIcnse(fme.ListBox1.SelectedIndex).TopicBut2
        If selectedExamNo = 3 Then Me.Text = dbIcnse(fme.ListBox1.SelectedIndex).TopicBut3
        If selectedExamNo = 4 Then Me.Text = dbIcnse(fme.ListBox1.SelectedIndex).TopicBut4
        If selectedExamNo = 5 Then Me.Text = dbIcnse(fme.ListBox1.SelectedIndex).TopicBut5
        If selectedExamNo = 6 Then Me.Text = dbIcnse(fme.ListBox1.SelectedIndex).TopicButAll

    End Sub
    Private Sub Preferences()
        'show answer' button
        If fme.chkShowAnswer.Checked Then btnShowAnswer.Visible = True Else btnShowAnswer.Visible = False
        If fme.chkShowPercentCorrect.Checked Then lblPercentCorrect.Visible = True Else lblPercentCorrect.Visible = False
        If fme.chkProgressBar.Checked Then
            ProgressBar1.Visible = True
        Else
            ProgressBar1.Visible = False
            lblPercent.Location = New Point(418, 8)
        End If
        If fme.chkItemReview.Checked Then
            btnReview.Visible = True
        Else
            btnReview.Visible = False
            chkMarkForReview.Visible = False
        End If
        If fme.chkShowExplanationButton.Checked Then btnShowExplanation.Visible = True Else btnShowExplanation.Visible = False
        If fme.chkPreviousButton.Checked Then btnPrevious.Visible = True Else btnPrevious.Visible = False
        If fme.chkAddNotes.Checked Then btnNotes.Visible = True Else btnNotes.Visible = False
        If fme.chkScoreTest.Checked Then btnScoreTest.Visible = True Else btnScoreTest.Visible = False
        If fme.chkHideTimer.Enabled And fme.chkHideTimer.Checked Then lblHideTimer.Visible = True Else lblHideTimer.Visible = False
        If fme.chkPauseTimer.Enabled And fme.chkPauseTimer.Checked Then lblPauseTimer.Visible = True Else lblPauseTimer.Visible = False

    End Sub
    Public Sub DisplayData(quesNo As Integer)
        'Display answer window
        Dim co = dbData(randomArray(quesNo)).chkoropt
        If co = "o" Or co = "ab" Or co = "tf" Then
            PanelRadioBox.Visible = True
            PanelCheckBox.Visible = False
            PanelInputBox.Visible = False

            AllShowRadioOption()
            If dbData(randomArray(quesNo)).AnsA <> "" Then
                lblFraR1.Text = dbData(randomArray(quesNo)).AnsA
            Else
                lblFraR1.Visible = False : rdoFra1.Visible = False
            End If
            If dbData(randomArray(quesNo)).AnsB <> "" Then
                lblFraR2.Text = dbData(randomArray(quesNo)).AnsB
            Else
                lblFraR2.Visible = False : rdoFra2.Visible = False
            End If
            If dbData(randomArray(quesNo)).AnsC <> "" Then
                lblFraR3.Text = dbData(randomArray(quesNo)).AnsC
            Else
                lblFraR3.Visible = False : rdoFra3.Visible = False
            End If
            If dbData(randomArray(quesNo)).AnsD <> "" Then
                lblFraR4.Text = dbData(randomArray(quesNo)).AnsD
            Else
                lblFraR4.Visible = False : rdoFra4.Visible = False
            End If
            If dbData(randomArray(quesNo)).AnsE <> "" Then
                lblFraR5.Text = dbData(randomArray(quesNo)).AnsE
            Else
                lblFraR5.Visible = False : rdoFra5.Visible = False
            End If
            If dbData(randomArray(quesNo)).AnsF <> "" Then
                lblFraR6.Text = dbData(randomArray(quesNo)).AnsF
            Else
                lblFraR6.Visible = False : rdoFra6.Visible = False
            End If
            If dbData(randomArray(quesNo)).AnsG <> "" Then
                lblFraR7.Text = dbData(randomArray(quesNo)).AnsG
            Else
                lblFraR7.Visible = False : rdoFra7.Visible = False
            End If

            'show selected radio options
            If dbData(randomArray(quesNo)).mySelectedAnswers(0) = "1" Then rdoFra1 .Checked = True
            If dbData(randomArray(quesNo)).mySelectedAnswers(1) = "1" Then rdoFra2.Checked = True
            If dbData(randomArray(quesNo)).mySelectedAnswers(2) = "1" Then rdoFra3.Checked = True
            If dbData(randomArray(quesNo)).mySelectedAnswers(3) = "1" Then rdoFra4.Checked = True
            If dbData(randomArray(quesNo)).mySelectedAnswers(4) = "1" Then rdoFra5.Checked = True
            If dbData(randomArray(quesNo)).mySelectedAnswers(5) = "1" Then rdoFra6.Checked = True
            If dbData(randomArray(quesNo)).mySelectedAnswers(6) = "1" Then rdoFra7.Checked = True
        End If
            If co = "c" Then
            PanelRadioBox.Visible = False
            PanelCheckBox.Visible = True
            PanelInputBox.Visible = False

            AllShowCheckOption()
            If dbData(randomArray(quesNo)).AnsA <> "" Then
                lblFraC1.Text = dbData(randomArray(quesNo)).AnsA
            Else
                lblFraC1.Visible = False : ChkFra1.Visible = False
            End If
            If dbData(randomArray(quesNo)).AnsB <> "" Then
                lblFraC2.Text = dbData(randomArray(quesNo)).AnsB
            Else
                lblFraC2.Visible = False : ChkFra2.Visible = False
            End If
            If dbData(randomArray(quesNo)).AnsC <> "" Then
                lblFraC3.Text = dbData(randomArray(quesNo)).AnsC
            Else
                lblFraC3.Visible = False : ChkFra3.Visible = False
            End If
            If dbData(randomArray(quesNo)).AnsD <> "" Then
                lblFraC4.Text = dbData(randomArray(quesNo)).AnsD
            Else
                lblFraC4.Visible = False : ChkFra4.Visible = False
            End If
            If dbData(randomArray(quesNo)).AnsE <> "" Then
                lblFraC5.Text = dbData(randomArray(quesNo)).AnsE
            Else
                lblFraC5.Visible = False : ChkFra5.Visible = False
            End If
            If dbData(randomArray(quesNo)).AnsF <> "" Then
                lblFraC6.Text = dbData(randomArray(quesNo)).AnsF
            Else
                lblFraC6.Visible = False : ChkFra6.Visible = False
            End If
            If dbData(randomArray(quesNo)).AnsG <> "" Then
                lblFraC7.Text = dbData(randomArray(quesNo)).AnsG
            Else
                lblFraC7.Visible = False : ChkFra7.Visible = False
            End If

            'show selected checkbox options
            If dbData(randomArray(quesNo)).mySelectedAnswers(0) = "1" Then ChkFra1.Checked = True
            If dbData(randomArray(quesNo)).mySelectedAnswers(1) = "1" Then ChkFra2.Checked = True
            If dbData(randomArray(quesNo)).mySelectedAnswers(2) = "1" Then ChkFra3.Checked = True
            If dbData(randomArray(quesNo)).mySelectedAnswers(3) = "1" Then ChkFra4.Checked = True
            If dbData(randomArray(quesNo)).mySelectedAnswers(4) = "1" Then ChkFra5.Checked = True
            If dbData(randomArray(quesNo)).mySelectedAnswers(5) = "1" Then ChkFra6.Checked = True
            If dbData(randomArray(quesNo)).mySelectedAnswers(6) = "1" Then ChkFra7.Checked = True
        End If
        If co = "i" Then
            PanelRadioBox.Visible = False
            PanelCheckBox.Visible = False
            PanelInputBox.Visible = True

            'show answer
            txtInput.Text = dbData(randomArray(quesNo)).myAnswer
        End If

        'visible all picturebox
        btnShowAnswer.Text = "Show Answer" : PictureBox1.Visible = False : PictureBox2.Visible = False : PictureBox3.Visible = False
        PictureBox4.Visible = False : PictureBox5.Visible = False : PictureBox6.Visible = False : PictureBox7.Visible = False
        GroupBox1.Visible = False

        ' question display
        txtQuesN1.Text = dbData(randomArray(quesNo)).Ques
        txtQuesN1.Select(txtQuesN1.TextLength, txtQuesN1.TextLength)

        'display "x of y"
        lblPercent.Text = quesNo + 1 & " of " & selectedQuestionNum

        If quesNo = 0 Then
            btnPrevious.Enabled = False
            btnForward.Enabled = True
        End If

        'Exhibit enable or disable
        If dbData(randomArray(quesNo)).Exhibit = "0" Then
            btnShow.Enabled = False
        ElseIf dbData(randomArray(quesNo)).Exhibit = "1" Then
            btnShow.Enabled = True
        ElseIf dbData(randomArray(quesNo)).Exhibit = "" Then
            btnShow.Enabled = False
        End If

        'display "mark for review"
        chkMarkForReview.Checked = dbData(randomArray(quesNo)).marked

        lblPercentCorrect.Text = "Correct : " & Math.Round(GetCorrectNum() / selectedQuestionNum * 100) & "%"

        ProgressBar1.Value = quesNo + 1

        'forward, previous button enable/disable
        If quesNo > 0 And quesNo < frmMainE.selectedQuestionNum - 1 Then
            btnPrevious.Enabled = True
            btnForward.Enabled = True
        End If
        If quesNo = frmMainE.selectedQuestionNum - 1 Then
            btnForward.Enabled = False
            btnPrevious.Enabled = True
            btnReview.Enabled = True
        End If
        If quesNo = 0 And frmMainE.selectedQuestionNum > 1 Then
            btnForward.Enabled = True
            btnPrevious.Enabled = False
        End If
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click


        If isClicked_ItemNotesBnt = True Then
            Dim i As Integer
            For i = currQueNo + 1 To frmMainE.selectedQuestionNum - 1
                If dbData(randomArray(i)).note <> "" Then
                    currQueNo = i
                    Exit For
                End If
            Next
            If i = frmMainE.selectedQuestionNum Then
                isClicked_ItemNotesBnt = False
                Dim fr As New frmReview1(Me, fme)
                fr.ShowDialog()
            End If
        ElseIf isClicked_NoItemNotesBnt = True Then
            Dim i As Integer
            For i = currQueNo + 1 To frmMainE.selectedQuestionNum - 1
                If dbData(randomArray(i)).note = "" Then
                    currQueNo = i
                    Exit For
                End If
            Next
            If i = frmMainE.selectedQuestionNum Then
                isClicked_NoItemNotesBnt = False
                Dim fr As New frmReview1(Me, fme)
                fr.ShowDialog()
            End If
        ElseIf isClicked_UnAnsweredBtn = True Then
            Dim i As Integer
            For i = currQueNo + 1 To frmMainE.selectedQuestionNum - 1
                If dbData(randomArray(i)).answered = "No" Then
                    currQueNo = i
                    Exit For
                End If
            Next
            If i = frmMainE.selectedQuestionNum Then
                isClicked_UnAnsweredBtn = False
                Dim fr As New frmReview1(Me, fme)
                fr.ShowDialog()
            End If
        ElseIf isClicked_AnsweredBtn = True Then
            Dim i As Integer
            For i = currQueNo + 1 To frmMainE.selectedQuestionNum - 1
                If dbData(randomArray(i)).answered = "Yes" Then
                    currQueNo = i
                    Exit For
                End If
            Next
            If i = frmMainE.selectedQuestionNum Then
                isClicked_AnsweredBtn = False
                Dim fr As New frmReview1(Me, fme)
                fr.ShowDialog()
            End If
        ElseIf isClicked_IncorrectBtn = True Then
            Dim i As Integer
            For i = currQueNo + 1 To frmMainE.selectedQuestionNum - 1
                If dbData(randomArray(i)).correct = "incorrect" Then
                    currQueNo = i
                    Exit For
                End If
            Next
            If i = frmMainE.selectedQuestionNum Then
                isClicked_IncorrectBtn = False
                Dim fr As New frmReview1(Me, fme)
                fr.ShowDialog()
            End If
        ElseIf isClicked_CorrectBtn = True Then
            Dim i As Integer
            For i = currQueNo + 1 To frmMainE.selectedQuestionNum - 1
                If dbData(randomArray(i)).correct = "correct" Then
                    currQueNo = i
                    Exit For
                End If
            Next
            If i = frmMainE.selectedQuestionNum Then
                isClicked_CorrectBtn = False
                Dim fr As New frmReview1(Me, fme)
                fr.ShowDialog()
            End If
        ElseIf isClicked_MarkedBtn = True Then
            Dim i As Integer
            For i = currQueNo + 1 To frmMainE.selectedQuestionNum - 1
                If dbData(randomArray(i)).marked = True Then
                    currQueNo = i
                    Exit For
                End If
            Next
            If i = frmMainE.selectedQuestionNum Then
                isClicked_MarkedBtn = False
                Dim fr As New frmReview1(Me, fme)
                fr.ShowDialog()
            End If
        ElseIf isClicked_UnMarkedBtn = True Then
            Dim i As Integer
            For i = currQueNo + 1 To frmMainE.selectedQuestionNum - 1
                If dbData(randomArray(i)).marked = False Then
                    currQueNo = i
                    Exit For
                End If
            Next
            If i = frmMainE.selectedQuestionNum Then
                isClicked_UnMarkedBtn = False
                Dim fr As New frmReview1(Me, fme)
                fr.ShowDialog()
            End If
        Else
            ''''''''''''''''''''''''''''''
            'Save All Satatus
            SaveAllStatus()
            ''''''''''''''''''
            If fme.chkShowExplanationCorrect.Checked Then
                If IsCorrectAnswer() Then
                    Dim fe As New frmExplanation("frmNet1")
                    fe.ShowDialog()
                End If
            End If
            If fme.chkShowExplanationIncorrect.Checked Then
                If IsCorrectAnswer() = False Then
                    Dim fe As New frmExplanation("frmNet1")
                    fe.ShowDialog()
                End If
            End If

            '''''''''''''''''''''''
            currQueNo += 1
            '''''''''''''''''''''''''''''''
        End If

        DisplayData(currQueNo)
    End Sub
    Private Sub SaveAllStatus()
        'is Correct?
        Dim str1 = ""
        If IsCorrectAnswer() Then str1 = "correct" Else str1 = "incorrect"
        Dim ri = dbData(randomArray(currQueNo))
        ri.correct = str1
        dbData(randomArray(currQueNo)) = ri

        'Did you answer?
        If IsAnswered() Then
            ri = dbData(randomArray(currQueNo))
            ri.answered = "Yes"
            If dbData(randomArray(currQueNo)).chkoropt = "i" Then ri.myAnswer = txtInput.Text
            dbData(randomArray(currQueNo)) = ri
        Else
            ri = dbData(randomArray(currQueNo))
            ri.answered = "No"
            dbData(randomArray(currQueNo)) = ri
        End If

        'save selected answers
        SaveSelectedAnswers()
    End Sub


    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click

        If isClicked_ItemNotesBnt = True Then
            Dim i As Integer
            For i = currQueNo - 1 To 0 Step -1
                If dbData(randomArray(i)).note <> "" Then
                    currQueNo = i
                    Exit For
                End If
            Next
            If i = -1 Then
                isClicked_ItemNotesBnt = False
                Dim fr As New frmReview1(Me, fme)
                fr.ShowDialog()
            End If
        ElseIf isClicked_NoItemNotesBnt = True Then
            Dim i As Integer
            For i = currQueNo - 1 To 0 Step -1
                If dbData(randomArray(i)).note = "" Then
                    currQueNo = i
                    Exit For
                End If
            Next
            If i = -1 Then
                isClicked_NoItemNotesBnt = False
                Dim fr As New frmReview1(Me, fme)
                fr.ShowDialog()
            End If
        ElseIf isClicked_UnAnsweredBtn = True Then
            Dim i As Integer
            For i = currQueNo - 1 To 0 Step -1
                If dbData(randomArray(i)).answered = "No" Then
                    currQueNo = i
                    Exit For
                End If
            Next
            If i = -1 Then
                isClicked_UnAnsweredBtn = False
                Dim fr As New frmReview1(Me, fme)
                fr.ShowDialog()
            End If
        ElseIf isClicked_AnsweredBtn = True Then
            Dim i As Integer
            For i = currQueNo - 1 To 0 Step -1
                If dbData(randomArray(i)).answered = "Yes" Then
                    currQueNo = i
                    Exit For
                End If
            Next
            If i = -1 Then
                isClicked_AnsweredBtn = False
                Dim fr As New frmReview1(Me, fme)
                fr.ShowDialog()
            End If
        ElseIf isClicked_IncorrectBtn = True Then
            Dim i As Integer
            For i = currQueNo - 1 To 0 Step -1
                If dbData(randomArray(i)).correct = "incorrect" Then
                    currQueNo = i
                    Exit For
                End If
            Next
            If i = -1 Then
                isClicked_IncorrectBtn = False
                Dim fr As New frmReview1(Me, fme)
                fr.ShowDialog()
            End If
        ElseIf isClicked_CorrectBtn = True Then
            Dim i As Integer
            For i = currQueNo - 1 To 0 Step -1
                If dbData(randomArray(i)).correct = "correct" Then
                    currQueNo = i
                    Exit For
                End If
            Next
            If i = -1 Then
                isClicked_CorrectBtn = False
                Dim fr As New frmReview1(Me, fme)
                fr.ShowDialog()
            End If
        ElseIf isClicked_MarkedBtn = True Then
            Dim i As Integer
            For i = currQueNo - 1 To 0 Step -1
                If dbData(randomArray(i)).marked = True Then
                    currQueNo = i
                    Exit For
                End If
            Next
            If i = -1 Then
                isClicked_MarkedBtn = False
                Dim fr As New frmReview1(Me, fme)
                fr.ShowDialog()
            End If
        ElseIf isClicked_UnMarkedBtn = True Then
            Dim i As Integer
            For i = currQueNo - 1 To 0 Step -1
                If dbData(randomArray(i)).marked = False Then
                    currQueNo = i
                    Exit For
                End If
            Next
            If i = -1 Then
                isClicked_UnMarkedBtn = False
                Dim fr As New frmReview1(Me, fme)
                fr.ShowDialog()
            End If
        Else
            '''''''''''''''''''''''''''''''''''''''''''''''''
            'Save All Satatus
            SaveAllStatus()
            currQueNo -= 1
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        End If

        DisplayData(currQueNo)
    End Sub

    Private Sub AllShowRadioOption()
        lblFraR1.Visible = True : rdoFra1.Visible = True : rdoFra1.Checked = False
        lblFraR2.Visible = True : rdoFra2.Visible = True : rdoFra2.Checked = False
        lblFraR3.Visible = True : rdoFra3.Visible = True : rdoFra3.Checked = False
        lblFraR4.Visible = True : rdoFra4.Visible = True : rdoFra4.Checked = False
        lblFraR5.Visible = True : rdoFra5.Visible = True : rdoFra5.Checked = False
        lblFraR6.Visible = True : rdoFra6.Visible = True : rdoFra6.Checked = False
        lblFraR7.Visible = True : rdoFra7.Visible = True : rdoFra7.Checked = False
    End Sub
    Private Sub AllShowCheckOption()
        lblFraC1.Visible = True : ChkFra1.Visible = True : ChkFra1.Checked = False
        lblFraC2.Visible = True : ChkFra2.Visible = True : ChkFra2.Checked = False
        lblFraC3.Visible = True : ChkFra3.Visible = True : ChkFra3.Checked = False
        lblFraC4.Visible = True : ChkFra4.Visible = True : ChkFra4.Checked = False
        lblFraC5.Visible = True : ChkFra5.Visible = True : ChkFra5.Checked = False
        lblFraC6.Visible = True : ChkFra6.Visible = True : ChkFra6.Checked = False
        lblFraC7.Visible = True : ChkFra7.Visible = True : ChkFra7.Checked = False
    End Sub

    Private Function IsCorrectAnswer() As Boolean
        Dim co = dbData(randomArray(currQueNo)).chkoropt
        If co = "o" Or co = "ab" Or co = "tf" Then
            If rdoFra1.Checked = dbData(randomArray(currQueNo)).Ans1 Then
                If rdoFra2.Checked = dbData(randomArray(currQueNo)).Ans2 Then
                    If rdoFra3.Checked = dbData(randomArray(currQueNo)).Ans3 Then
                        If rdoFra4.Checked = dbData(randomArray(currQueNo)).Ans4 Then
                            If rdoFra5.Checked = dbData(randomArray(currQueNo)).Ans5 Then
                                If rdoFra6.Checked = dbData(randomArray(currQueNo)).Ans6 Then
                                    If rdoFra7.Checked = dbData(randomArray(currQueNo)).Ans7 Then
                                        Return True
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If co = "c" Then
            If ChkFra1.Checked = dbData(randomArray(currQueNo)).Ans1 Then
                If ChkFra2.Checked = dbData(randomArray(currQueNo)).Ans2 Then
                    If ChkFra3.Checked = dbData(randomArray(currQueNo)).Ans3 Then
                        If ChkFra4.Checked = dbData(randomArray(currQueNo)).Ans4 Then
                            If ChkFra5.Checked = dbData(randomArray(currQueNo)).Ans5 Then
                                If ChkFra6.Checked = dbData(randomArray(currQueNo)).Ans6 Then
                                    If ChkFra7.Checked = dbData(randomArray(currQueNo)).Ans7 Then
                                        Return True
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If co = "i" Then
            If dbData(randomArray(currQueNo)).InputAnswer = txtInput.Text Then
                Return True
            End If
        End If
        Return False
    End Function

    Private Function IsAnswered() As Boolean
        Dim co = dbData(randomArray(currQueNo)).chkoropt
        If co = "o" Or co = "ab" Or co = "tf" Then
            If rdoFra1.Checked Then Return True
            If rdoFra2.Checked Then Return True
            If rdoFra3.Checked Then Return True
            If rdoFra4.Checked Then Return True
            If rdoFra5.Checked Then Return True
            If rdoFra6.Checked Then Return True
            If rdoFra7.Checked Then Return True
        End If
        If co = "c" Then
            If ChkFra1.Checked Then Return True
            If ChkFra2.Checked Then Return True
            If ChkFra3.Checked Then Return True
            If ChkFra4.Checked Then Return True
            If ChkFra5.Checked Then Return True
            If ChkFra6.Checked Then Return True
            If ChkFra7.Checked Then Return True
        End If
        If co = "i" Then
            If txtInput.Text <> "" Then Return True
        End If
        Return False
    End Function

    Private Sub SaveSelectedAnswers()
        Dim ri = dbData(randomArray(currQueNo))
        Dim co = dbData(randomArray(currQueNo)).chkoropt
        If co = "o" Or co = "ab" Or co = "tf" Then
            If rdoFra1.Checked Then ri.mySelectedAnswers(0) = "1" Else ri.mySelectedAnswers(0) = "0"
            If rdoFra2.Checked Then ri.mySelectedAnswers(1) = "1" Else ri.mySelectedAnswers(1) = "0"
            If rdoFra3.Checked Then ri.mySelectedAnswers(2) = "1" Else ri.mySelectedAnswers(2) = "0"
            If rdoFra4.Checked Then ri.mySelectedAnswers(3) = "1" Else ri.mySelectedAnswers(3) = "0"
            If rdoFra5.Checked Then ri.mySelectedAnswers(4) = "1" Else ri.mySelectedAnswers(4) = "0"
            If rdoFra6.Checked Then ri.mySelectedAnswers(5) = "1" Else ri.mySelectedAnswers(5) = "0"
            If rdoFra7.Checked Then ri.mySelectedAnswers(6) = "1" Else ri.mySelectedAnswers(6) = "0"
        End If
        If co = "c" Then
            If ChkFra1.Checked Then ri.mySelectedAnswers(0) = "1" Else ri.mySelectedAnswers(0) = "0"
            If ChkFra2.Checked Then ri.mySelectedAnswers(1) = "1" Else ri.mySelectedAnswers(1) = "0"
            If ChkFra3.Checked Then ri.mySelectedAnswers(2) = "1" Else ri.mySelectedAnswers(2) = "0"
            If ChkFra4.Checked Then ri.mySelectedAnswers(3) = "1" Else ri.mySelectedAnswers(3) = "0"
            If ChkFra5.Checked Then ri.mySelectedAnswers(4) = "1" Else ri.mySelectedAnswers(4) = "0"
            If ChkFra6.Checked Then ri.mySelectedAnswers(5) = "1" Else ri.mySelectedAnswers(5) = "0"
            If ChkFra7.Checked Then ri.mySelectedAnswers(6) = "1" Else ri.mySelectedAnswers(6) = "0"
        End If
        If co = "i" Then
            ri.myAnswer = txtInput.Text
        End If
        dbData(randomArray(currQueNo)) = ri

    End Sub

    Private Sub btnShowAnswer_Click(sender As Object, e As EventArgs) Handles btnShowAnswer.Click

        If btnShowAnswer.Text = "Show Answer" Then
            btnShowAnswer.Text = "Hide Answer"
            Dim co = dbData(randomArray(currQueNo)).chkoropt
            If co = "o" Or co = "ab" Or co = "tf" Or co = "c" Then
                If dbData(randomArray(currQueNo)).Ans1 = "1" Then PictureBox1.Visible = True
                If dbData(randomArray(currQueNo)).Ans2 = "1" Then PictureBox2.Visible = True
                If dbData(randomArray(currQueNo)).Ans3 = "1" Then PictureBox3.Visible = True
                If dbData(randomArray(currQueNo)).Ans4 = "1" Then PictureBox4.Visible = True
                If dbData(randomArray(currQueNo)).Ans5 = "1" Then PictureBox5.Visible = True
                If dbData(randomArray(currQueNo)).Ans6 = "1" Then PictureBox6.Visible = True
                If dbData(randomArray(currQueNo)).Ans7 = "1" Then PictureBox7.Visible = True
            End If
            If co = "i" Then
                GroupBox1.Visible = True
                txtInputAnswer.Text = dbData(randomArray(currQueNo)).InputAnswer
            End If
        Else
            btnShowAnswer.Text = "Show Answer"
            PictureBox1.Visible = False : PictureBox2.Visible = False : PictureBox3.Visible = False
            PictureBox4.Visible = False : PictureBox5.Visible = False : PictureBox6.Visible = False : PictureBox7.Visible = False
            GroupBox1.Visible = False
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeLeft -= 1
        lblTimeDiff.Text = timeLeft & " minutes"
        If timeLeft = 0 Then
            Timer1.Enabled = False
            MessageBox.Show("Nerdom Cert Exams - Your Time Has Expired. You will now be taken to review.", "Nerdom Cert Exams", MessageBoxButtons.OK)
            btnReview.Enabled = True
        End If
    End Sub

    Private Sub chkMarkForReview_CheckedChanged(sender As Object, e As EventArgs) Handles chkMarkForReview.CheckedChanged
        Dim ri = dbData(randomArray(currQueNo))
        ri.marked = chkMarkForReview.Checked
        dbData(randomArray(currQueNo)) = ri
    End Sub

    Private Sub lblHideTimer_Click(sender As Object, e As EventArgs) Handles lblHideTimer.Click
        If lblHideTimer.Text = "Hide Timer" Then
            lblTimeDiff.Visible = False
            Label1.Visible = False
            lblHideTimer.Text = "Show Timer"
        Else
            lblTimeDiff.Visible = True
            Label1.Visible = True
            lblHideTimer.Text = "Hide Timer"
        End If
    End Sub

    Private Sub lblPauseTimer_Click(sender As Object, e As EventArgs) Handles lblPauseTimer.Click
        If lblPauseTimer.Text = "Pause Timer" Then
            Timer1.Enabled = False
            lblPauseTimer.Text = "UnPause Timer"
        Else
            Timer1.Enabled = True
            lblPauseTimer.Text = "Pause Timer"
        End If
    End Sub

    Private Sub btnShowExplanation_Click(sender As Object, e As EventArgs) Handles btnShowExplanation.Click

        'Save All Satatus
        SaveAllStatus()

        Dim fe As New frmExplanation("frmNet1")  'All data
        fe.ShowDialog()
    End Sub

    Private Sub btnScoreTest_Click(sender As Object, e As EventArgs) Handles btnScoreTest.Click
        SaveAllStatus()
        DisplayData(currQueNo)

        Dim fpp As New frmPrintPreview("frmNet1")
        fpp.ShowDialog()
    End Sub

    Private Sub btnNotes_Click(sender As Object, e As EventArgs) Handles btnNotes.Click
        Dim fn As New frmNotes("frmNet1")
        fn.ShowDialog()
    End Sub

    Private Sub btnReview_Click(sender As Object, e As EventArgs) Handles btnReview.Click
        SaveAllStatus()
        DisplayData(currQueNo)

        Dim fr1 As New frmReview1(Me, fme)
        fr1.ShowDialog()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim fn As New frmExhibit("frmNet1")
        fn.ShowDialog()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        SaveAllStatus()
        DisplayData(currQueNo)
    End Sub


End Class