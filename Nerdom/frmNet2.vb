Imports System.Data.OleDb
Imports Nerdom.frmMainE
Public Class frmNet2
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Preferences()

        Me.Text = "Select an Exam and Exam Number to Begin."

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
        str = "SELECT * FROM Q1"
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
                .RouterPrompt = dr("RouterPrompt").ToString.Trim()
                .RouterOutput = dr("RouterOutput").ToString.Trim()
                .Exhibit = dr("Exhibit").ToString.Trim()
                .ExhibitName = dr("ExhibitName").ToString.Trim()
                .correct = "incomplete"
                .answered = ""
                .myAnswer = ""
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

        'Progress Bar
        ProgressBar1.Maximum = frmMainE.selectedQuestionNum
        ProgressBar1.Value = 1

        'form caption


    End Sub
    Private Sub Preferences()
        'show answer' button
        If fme.chkShowAnswer.Checked Then btnShowAnswer.Visible = True Else btnShowAnswer.Visible = False
        If fme.chkShowPercentCorrect.Checked Then lblPercentCorrect.Visible = True Else lblPercentCorrect.Visible = False
        If fme.chkProgressBar.Checked Then
            ProgressBar1.Visible = True
        Else
            ProgressBar1.Visible = False
            lblPercent.Location = New Point(418, 20)
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
        'if quesNo = 0, or quwsNo = 
        If quesNo = 0 Then
            btnPrevious.Enabled = False
            btnForward.Enabled = True
        End If

        ' first question display
        txtQuesN1.Text = dbData(randomArray(quesNo)).Ques
        txtInput.Text = dbData(randomArray(quesNo)).RouterPrompt & " "
        txtInput.Text += dbData(randomArray(quesNo)).myAnswer
        txtInput.Select(txtInput.TextLength, txtInput.TextLength)

        'Exhibit enable or disable
        If dbData(randomArray(quesNo)).Exhibit = "0" Then
            btnShow.Enabled = False
        ElseIf dbData(randomArray(quesNo)).Exhibit = "1" Then
            btnShow.Enabled = True
        ElseIf dbData(randomArray(quesNo)).Exhibit = "" Then
            btnShow.Enabled = False
        End If


        'display "x of y"
        lblPercent.Text = quesNo + 1 & " of " & frmMainE.selectedQuestionNum

        'display "mark for review"
        chkMarkForReview.Checked = dbData(randomArray(quesNo)).marked

        lblPercentCorrect.Text = "Correct : " & Math.Round(GetCorrectNum() / frmMainE.selectedQuestionNum * 100) & "%"

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
    Private Sub txtInput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRouterOutput.Text = dbData(randomArray(currQueNo)).RouterOutput
            '''''''''''''''''''''''''''''
            SaveAllStatus()
            ''''''''''''''''''''''''''''

            lblPercentCorrect.Text = "Correct : " & Math.Round(GetCorrectNum() / frmMainE.selectedQuestionNum * 100) & "%"
        End If
    End Sub

    Private Sub btnShowExplanation_Click(sender As Object, e As EventArgs) Handles btnShowExplanation.Click

        Dim fe As New frmExplanation("frmNet2")  'All data
        fe.ShowDialog()
    End Sub

    Private Sub btnShowAnswer_Click(sender As Object, e As EventArgs) Handles btnShowAnswer.Click
        If btnShowAnswer.Text = "Show Answer" Then
            btnShowAnswer.Text = "Hide Answer"
            GroupBox1.Visible = True
            txtInputAnswer.Text = dbData(randomArray(currQueNo)).InputAnswer
        Else
            btnShowAnswer.Text = "Show Answer"
            GroupBox1.Visible = False
        End If


    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        txtRouterOutput.Text = ""
        GroupBox1.Visible = False : btnShowAnswer.Text = "Show Answer"


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
                Dim fr As New frmReview2(Me, fme)
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
                Dim fr As New frmReview2(Me, fme)
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
                Dim fr As New frmReview2(Me, fme)
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
                Dim fr As New frmReview2(Me, fme)
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
                Dim fr As New frmReview2(Me, fme)
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
                Dim fr As New frmReview2(Me, fme)
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
                Dim fr As New frmReview2(Me, fme)
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
                Dim fr As New frmReview2(Me, fme)
                fr.ShowDialog()
            End If
        Else
            ''''''''''''''''''''''''''''''
            Dim isCorrect = SaveAllStatus()
            ''''''''''
            If fme.chkShowExplanationCorrect.Checked Then
                If isCorrect Then
                    Dim fe As New frmExplanation("frmNet1")
                    fe.ShowDialog()
                End If
            End If
            If fme.chkShowExplanationIncorrect.Checked Then
                If isCorrect = False Then
                    Dim fe As New frmExplanation("frmNet1")
                    fe.ShowDialog()
                End If
            End If
            '''''''''''
            currQueNo += 1
            '''''''''''''''''''''''''''''''
        End If

        DisplayData(currQueNo)
    End Sub
    Private Function SaveAllStatus() As Boolean
        Dim s = txtInput.Text.Replace(dbData(randomArray(currQueNo)).RouterPrompt, "").Trim()
        If s = "" Then
            Dim ri = dbData(randomArray(currQueNo))
            ri.answered = "No"
            dbData(randomArray(currQueNo)) = ri
        Else
            Dim ri = dbData(randomArray(currQueNo))
            ri.answered = "Yes"
            ri.myAnswer = s
            dbData(randomArray(currQueNo)) = ri
        End If
        Dim isCorrect As Boolean
        If s = dbData(randomArray(currQueNo)).InputAnswer Or s = dbData(randomArray(currQueNo)).InputAnswer2 Then
            Dim ri = dbData(randomArray(currQueNo))
            ri.correct = "correct" : isCorrect = True
            dbData(randomArray(currQueNo)) = ri
        Else
            Dim ri = dbData(randomArray(currQueNo))
            ri.correct = "incorrect" : isCorrect = False
            dbData(randomArray(currQueNo)) = ri
        End If
        Return isCorrect
    End Function

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        txtRouterOutput.Text = ""
        GroupBox1.Visible = False : btnShowAnswer.Text = "Show Answer"

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
                Dim fr As New frmReview2(Me, fme)
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
                Dim fr As New frmReview2(Me, fme)
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
                Dim fr As New frmReview2(Me, fme)
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
                Dim fr As New frmReview2(Me, fme)
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
                Dim fr As New frmReview2(Me, fme)
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
                Dim fr As New frmReview2(Me, fme)
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
                Dim fr As New frmReview2(Me, fme)
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
                Dim fr As New frmReview2(Me, fme)
                fr.ShowDialog()
            End If
        Else
            '''''''''''''''''''''''''''''''''''''''''''''''''
            SaveAllStatus()
            currQueNo -= 1
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        End If

        DisplayData(currQueNo)
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

    Private Sub btnScoreTest_Click(sender As Object, e As EventArgs) Handles btnScoreTest.Click
        SaveAllStatus()
        DisplayData(currQueNo)

        Dim fpp As New frmPrintPreview("frmNet2")   'All data
        fpp.ShowDialog()
    End Sub

    Private Sub frmNet2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Close()
    End Sub

    Private Sub btnNotes_Click(sender As Object, e As EventArgs) Handles btnNotes.Click
        Dim fn As New frmNotes("frmNet2")  'All data
        fn.ShowDialog()
    End Sub

    Private Sub btnReview_Click(sender As Object, e As EventArgs) Handles btnReview.Click
        '''''''''''''''''''''''''''''
        SaveAllStatus()
        DisplayData(currQueNo)
        ''''''''''''''''''''''''''''

        Dim fr As New frmReview2(Me, fme)
        fr.ShowDialog()


    End Sub

    Private Sub chkMarkForReview_CheckedChanged(sender As Object, e As EventArgs) Handles chkMarkForReview.CheckedChanged
        Dim ri = dbData(randomArray(currQueNo))
        ri.marked = chkMarkForReview.Checked
        dbData(randomArray(currQueNo)) = ri
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim fn As New frmExhibit("frmNet2")
        fn.ShowDialog()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        SaveAllStatus()
        DisplayData(currQueNo)
    End Sub
End Class