Imports System.Data.OleDb
Imports System.IO

Public Class frmMainE
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader


    ''' <summary>
    ''' Data structure for keeping the data of database
    ''' </summary>
    Public Structure RecordInfo
        Public no As Integer
        Public QID As String
        Public Ques As String
        Public chkoropt As String
        Public Explanation As String
        Public InputAnswer As String
        Public InputAnswer2 As String
        Public RouterPrompt As String
        Public RouterOutput As String
        Public Exhibit As String
        Public ExhibitName As String

        Public answered As String
        Public correct As String
        Public myAnswer As String
        Public note As String
        Public marked As Boolean
        Public mySelectedAnswers() As String

        'for frmNet1
        Public AnsA As String
        Public AnsB As String
        Public AnsC As String
        Public AnsD As String
        Public AnsE As String
        Public AnsF As String
        Public AnsG As String
        Public Ans1 As String
        Public Ans2 As String
        Public Ans3 As String
        Public Ans4 As String
        Public Ans5 As String
        Public Ans6 As String
        Public Ans7 As String
        Public Answer As String
    End Structure
    Public Shared dbData As New List(Of RecordInfo)()  'All data
    Public Shared randomArray() As Integer

    Public Structure MainDbInfo
        Public ID As String
        Public ICTITLE As String
        Public IconMouse As String
        Public TopicBut1 As String
        Public TopicBut2 As String
        Public TopicBut3 As String
        Public TopicBut4 As String
        Public TopicBut5 As String
        Public TopicButAll As String
        Public MaxLbox As String
        Public MTYPE As String
        Public fldSubFolder As String
    End Structure
    Public Shared dbIcnse As New List(Of MainDbInfo)()

    '''''''  Shared variable '''''''''''''''''''
    Public Shared selectedSubFolder As String
    Public Shared selectedExamNo As Integer = 1
    Public Shared selectedQuestionNum As Integer
    Public Shared userName As String
    Public Shared selectedCCNA As Integer = 0
    Public Shared examMode As String = "study"
    Public Shared selected_ID As String


    Private Sub frmMainE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = Application.StartupPath & "\icnse.mdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        Try
            myConnection.Open()
            Dim str As String
            str = "SELECT * FROM t1 order by ID"

            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            dr = cmd.ExecuteReader
            If dr.HasRows = False Then
                Panel1.Enabled = False
                Panel2.Enabled = False
                Panel4.Enabled = False
                myConnection.Close()
                Return
            End If
            While dr.Read()
                Dim str1 = dr("ICTITLE").ToString.Trim()
                If str1 <> "" Then
                    ListBox1.Items.Add(str1)
                End If

                Dim rInfo As New MainDbInfo()
                With rInfo
                    .ID = dr("ID").ToString.Trim
                    .ICTITLE = dr("ICTITLE").ToString.Trim
                    .IconMouse = dr("IconMouse").ToString.Trim
                    .TopicBut1 = dr("TopicBut1").ToString.Trim
                    .TopicBut2 = dr("TopicBut2").ToString.Trim
                    .TopicBut3 = dr("TopicBut3").ToString.Trim
                    .TopicBut4 = dr("TopicBut4").ToString.Trim
                    .TopicBut5 = dr("TopicBut5").ToString.Trim
                    .TopicButAll = dr("TopicButAll").ToString.Trim
                    .MaxLbox = dr("MaxLbox").ToString.Trim
                    .MTYPE = dr("MTYPE").ToString.Trim
                    .fldSubFolder = dr("fldSubFolder").ToString.Trim
                End With
                dbIcnse.Add(rInfo)

            End While
            myConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Please, Install AccessDatabaseEngine." & vbCrLf & "You have no it, download it in web.")
        End Try

        ListBox1.SelectedIndex = 0

        For i = 5 To 10000 Step 5
            cbMinutes.Items.Add(i)
        Next
        cbMinutes.SelectedIndex = 4

        BtnLaunchExam.Text = "Launch  Exam 1"

        Me.Text = "Select an Exam and Exam Number to Begin."

        Timer1.Enabled = True
    End Sub


    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        selected_ID = dbIcnse(ListBox1.SelectedIndex).ID
        selectedCCNA = ListBox1.SelectedIndex
        selectedExamNo = 1
        BtnLaunchExam.Text = "Launch  Exam 1"

        Lbl_Topic.Text = dbIcnse(ListBox1.SelectedIndex).TopicBut1
        Lbl_Def.Text = dbIcnse(ListBox1.SelectedIndex).IconMouse
        If (dbIcnse(ListBox1.SelectedIndex).TopicBut2 Is "") Then BtnExam2.Enabled = False Else BtnExam2.Enabled = True
        If (dbIcnse(ListBox1.SelectedIndex).TopicBut3 Is "") Then BtnExam3.Enabled = False Else BtnExam3.Enabled = True
        If (dbIcnse(ListBox1.SelectedIndex).TopicBut4 Is "") Then BtnExam4.Enabled = False Else BtnExam4.Enabled = True
        If (dbIcnse(ListBox1.SelectedIndex).TopicBut5 Is "") Then BtnExam5.Enabled = False Else BtnExam5.Enabled = True
        If (dbIcnse(ListBox1.SelectedIndex).TopicButAll Is "") Then BtnExam6.Enabled = False Else BtnExam6.Enabled = True

        If (dbIcnse(ListBox1.SelectedIndex).MTYPE = "L") Then
            chkRandQuestions.Enabled = True
            chkRandAnswers.Enabled = False
            Panel3.Enabled = True
        End If
        If (dbIcnse(ListBox1.SelectedIndex).MTYPE = "E") Then
            chkRandQuestions.Enabled = True
            chkRandAnswers.Enabled = True
            Panel3.Enabled = True
        End If
        If (dbIcnse(ListBox1.SelectedIndex).MTYPE = "F") Then
            chkRandQuestions.Enabled = False
            chkRandAnswers.Enabled = False
            Panel3.Enabled = False
        End If

        selectedSubFolder = dbIcnse(ListBox1.SelectedIndex).fldSubFolder
        Dim file = Application.StartupPath & "\" & selectedSubFolder & "db00" & dbIcnse(ListBox1.SelectedIndex).ID & ".mdb"
        Dim rcnt = GetRecordCount(file)
        cbSelectAll.Items.Clear() : cbSelectAll.Text = ""
        cbSelectNum.Items.Clear() : cbSelectNum.Text = ""
        If rcnt > 0 Then
            cbSelectAll.Items.Add(rcnt)
            cbSelectAll.SelectedIndex = 0
            Dim k = 5
            If rcnt < 5 Then k = 1
            For i = k To rcnt
                cbSelectNum.Items.Add(i)
            Next
            cbSelectNum.SelectedIndex = 0
        End If
        BtnExam1.Select()

        If dbIcnse(ListBox1.SelectedIndex).MTYPE = "L" Then ResetOptions_Lab()
        If dbIcnse(ListBox1.SelectedIndex).MTYPE = "E" Then ResetOptions_Exam()
        If dbIcnse(ListBox1.SelectedIndex).MTYPE = "F" Then ResetOptions_Flash()

        'If ListBox1.SelectedIndex = 0 Then ResetOptions_Lab()
        'If ListBox1.SelectedIndex = 1 Then ResetOptions_Exam()
        'If ListBox1.SelectedIndex = 2 Then ResetOptions_Lab()
        'If ListBox1.SelectedIndex = 3 Then ResetOptions_Flash()

    End Sub

    Private Sub BtnExam_Click(sender As Object, e As EventArgs) Handles BtnExam6.Click, BtnExam5.Click, BtnExam4.Click, BtnExam3.Click, BtnExam2.Click, BtnExam1.Click
        Dim btn As Button = sender
        Dim s = btn.Name.Replace("BtnExam", "")
        Dim i = Int32.Parse(s)
        selectedExamNo = i

        If i = 1 Then Lbl_Topic.Text = dbIcnse(ListBox1.SelectedIndex).TopicBut1
        If i = 2 Then Lbl_Topic.Text = dbIcnse(ListBox1.SelectedIndex).TopicBut2
        If i = 3 Then Lbl_Topic.Text = dbIcnse(ListBox1.SelectedIndex).TopicBut3
        If i = 4 Then Lbl_Topic.Text = dbIcnse(ListBox1.SelectedIndex).TopicBut4
        If i = 5 Then Lbl_Topic.Text = dbIcnse(ListBox1.SelectedIndex).TopicBut5
        If i = 6 Then Lbl_Topic.Text = dbIcnse(ListBox1.SelectedIndex).TopicButAll

        Dim fname As String = ""
        If s = 1 Then fname = "db" & Int32.Parse(dbIcnse(ListBox1.SelectedIndex).ID).ToString("D3")
        If s > 1 Then fname = "db" & Int32.Parse(dbIcnse(ListBox1.SelectedIndex).ID).ToString("D3") & s
        fname = Application.StartupPath & "\" & selectedSubFolder & fname & ".mdb"

        Dim rcnt = GetRecordCount(fname)
        cbSelectAll.Items.Clear() : cbSelectAll.Text = ""
        cbSelectNum.Items.Clear() : cbSelectNum.Text = ""
        If rcnt > 0 Then
            cbSelectAll.Items.Add(rcnt)
            cbSelectAll.SelectedIndex = 0
            Dim k = 5
            If rcnt < 5 Then k = 1
            For i = k To rcnt
                cbSelectNum.Items.Add(i)
            Next
            cbSelectNum.SelectedIndex = 0
        End If


        BtnLaunchExam.Text = "Launch  Exam " & s

    End Sub

    Private Function GetRecordCount(file As String) As Integer
        Dim conn As OleDbConnection = New OleDbConnection
        Dim provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        Dim connStr = provider & file
        conn.ConnectionString = connStr

        Dim cnt = 0
        Try
            conn.Open()
            Dim str As String

            If ListBox1.SelectedIndex = 1 And chkMultChoice.Checked Then
                str = "SELECT * From Q1 WHERE chkoropt<>'i'"
            Else
                str = "SELECT * FROM Q1"
            End If

            Dim cmd As OleDbCommand = New OleDbCommand(str, conn)
            dr = cmd.ExecuteReader

            While dr.Read()
                cnt += 1
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error reading Database", "Error")
            cnt = 0
        End Try

        Return cnt
    End Function

    Private Sub BtnLaunchExam_Click(sender As Object, e As EventArgs) Handles BtnLaunchExam.Click

        If rdoSelectNum.Checked Then
            selectedQuestionNum = Int32.Parse(cbSelectNum.Text)
        Else
            selectedQuestionNum = Int32.Parse(cbSelectAll.Text)
        End If
        userName = txtUserName.Text



        If dbIcnse(ListBox1.SelectedIndex).MTYPE = "L" Then
            Dim fn2 As New frmNet2(Me)  'All data
            fn2.ShowDialog()
        End If

        If dbIcnse(ListBox1.SelectedIndex).MTYPE = "E" Then
            Dim fn1 As New frmNet1(Me)
            fn1.ShowDialog()
        End If

        If dbIcnse(ListBox1.SelectedIndex).MTYPE = "F" Then
            Dim f = ""
            If selectedExamNo = 1 Then f = "flash.exe"
            If selectedExamNo = 2 Then f = "flash2.exe"
            If selectedExamNo = 3 Then f = "flash3.exe"
            If selectedExamNo = 4 Then f = "flash4.exe"
            If selectedExamNo = 5 Then f = "flash5.exe"
            If selectedExamNo = 6 Then f = "flash6.exe"

            Dim objShell = CreateObject("shell.application")
            objShell.ShellExecute(Application.StartupPath & "\" & selectedSubFolder & f, "", "", "open", 1)
            objShell = Nothing

        End If

    End Sub

    Private Sub BtnMoreOptions_Click(sender As Object, e As EventArgs) Handles BtnMoreOptions.Click
        If BtnMoreOptions.Text = "<< More Options" Then
            Panel1.Visible = False
            Panel4.Visible = True
        End If
        If BtnMoreOptions.Text = "<< Hide Options" Then
            Panel1.Visible = True
            Panel4.Visible = False
        End If

        If BtnMoreOptions.Text = "<< More Options" Then
            BtnMoreOptions.Text = "<< Hide Options"
            'If examMode = "study" Then BtnStudyMode.Select() Else BtnExamMode.Select()
        Else
            BtnMoreOptions.Text = "<< More Options"

            If selectedExamNo = 1 Then BtnExam1.Select()
            If selectedExamNo = 2 Then BtnExam2.Select()
            If selectedExamNo = 3 Then BtnExam3.Select()
            If selectedExamNo = 4 Then BtnExam4.Select()
            If selectedExamNo = 5 Then BtnExam5.Select()
            If selectedExamNo = 6 Then BtnExam6.Select()
        End If


    End Sub

    Private Sub BtnExamMode_Click(sender As Object, e As EventArgs) Handles BtnExamMode.Click
        examMode = "exam"
        ResetOptions_Exammode()
    End Sub

    Private Sub BtnStudyMode_Click(sender As Object, e As EventArgs) Handles BtnStudyMode.Click
        examMode = "study"
        ResetOptions_StudyMode()
    End Sub

    Private Sub BtnResetOptions_Click(sender As Object, e As EventArgs) Handles BtnResetOptions.Click
        If ListBox1.SelectedIndex = 0 Then
            SettingOptions_Lab()
        End If
        If ListBox1.SelectedIndex = 1 Then
            SettingOptions_Exam()
        End If
        If ListBox1.SelectedIndex = 2 Then
            SettingOptions_Lab()
        End If
        If ListBox1.SelectedIndex = 3 Then
            ResetOptions_Flash()
        End If
    End Sub

    Private Sub ResetOptions_Lab()
        ResetOptions_Initialize()
        Dim nfile = ""
        'If ListBox1.SelectedIndex = 0 Then nfile = Application.StartupPath & "\" & "exams\nerdom1.log"
        'If ListBox1.SelectedIndex = 2 Then nfile = Application.StartupPath & "\" & "exams\nerdom3.log"
        nfile = Application.StartupPath & "\" & "exams\nerdom1.log"

        If File.Exists(nfile) Then
            ReadSetingOptions(nfile)
        Else
            SettingOptions_Lab()
        End If
    End Sub
    Private Sub SettingOptions_Lab()
        ResetOptions_Initialize()

        chkShowAnswer.Checked = True
        chkShowPercentCorrect.Checked = True
        chkProgressBar.Checked = True
        chkItemReview.Checked = True
        chkMarkForReview.Checked = True
        chkReviewMarked.Checked = True
        chkReviewUnMarked.Checked = True
        chkReviewAnswered.Checked = True
        chkReviewUnanswered.Checked = True

        chkShowExplanationButton.Checked = True
        chkPreviousButton.Checked = True
        chkAddNotes.Checked = True
        chkMultChoice.Enabled = False
        chkScoreTest.Checked = True
        chkHideTimer.Enabled = True
        chkPauseTimer.Enabled = True
        chkReviewCorrect.Checked = True
        chkReviewIncorrect.Checked = True

        chkCorrectReview.Checked = True

        chkTimedExam.Checked = False
    End Sub


    Private Sub ResetOptions_Exam()
        ResetOptions_Initialize()
        If File.Exists(Application.StartupPath & "\" & "exams\nerdom2.log") Then
            ReadSetingOptions(Application.StartupPath & "\" & "exams\nerdom2.log")
        Else
            SettingOptions_Exam()
        End If
    End Sub
    Private Sub SettingOptions_Exam()
        ResetOptions_Initialize()

        chkShowAnswer.Checked = True
        chkShowPercentCorrect.Checked = True
        chkProgressBar.Checked = True
        chkItemReview.Checked = True
        chkMarkForReview.Checked = True
        chkReviewMarked.Checked = True
        chkReviewUnMarked.Checked = True
        chkReviewAnswered.Checked = True
        chkReviewUnanswered.Checked = True

        chkShowExplanationButton.Checked = True
        chkPreviousButton.Checked = True
        chkAddNotes.Checked = True
        chkMultChoice.Checked = False
        chkScoreTest.Checked = True
        chkHideTimer.Enabled = True
        chkPauseTimer.Enabled = True
        chkReviewCorrect.Checked = True
        chkReviewIncorrect.Checked = True

        chkCorrectReview.Checked = True

        chkTimedExam.Checked = False
    End Sub

    Private Sub ResetOptions_Flash()
        ResetOptions_Initialize()

        chkShowAnswer.Enabled = False
            chkShowPercentCorrect.Enabled = False
            chkProgressBar.Enabled = False
            chkItemReview.Enabled = False
            chkMarkForReview.Enabled = False
            chkReviewMarked.Enabled = False
            chkReviewUnMarked.Enabled = False
            chkReviewAnswered.Enabled = False
            chkReviewUnanswered.Enabled = False

            chkShowExplanationButton.Enabled = False
            chkPreviousButton.Enabled = False
            chkAddNotes.Enabled = False
            chkMultChoice.Enabled = False
            chkScoreTest.Enabled = False
            chkHideTimer.Enabled = True
            chkPauseTimer.Enabled = True
            chkReviewCorrect.Enabled = False
            chkReviewIncorrect.Enabled = False

            chkCorrectReview.Enabled = False
            chkShowExplanationCorrect.Enabled = False
            chkShowExplanationIncorrect.Enabled = False

    End Sub

    Private Sub ResetOptions_Initialize()
        chkShowAnswer.Enabled = True
        chkShowPercentCorrect.Enabled = True
        chkProgressBar.Enabled = True
        chkItemReview.Enabled = True
        chkMarkForReview.Enabled = True
        chkReviewMarked.Enabled = True
        chkReviewUnMarked.Enabled = True
        chkReviewAnswered.Enabled = True
        chkReviewUnanswered.Enabled = True

        chkShowExplanationButton.Enabled = True
        chkPreviousButton.Enabled = True
        chkAddNotes.Enabled = True
        chkMultChoice.Enabled = True
        chkScoreTest.Enabled = True
        chkHideTimer.Enabled = True
        chkPauseTimer.Enabled = True
        chkReviewCorrect.Enabled = True
        chkReviewIncorrect.Enabled = True

        chkCorrectReview.Enabled = True
        chkShowExplanationCorrect.Enabled = True
        chkShowExplanationIncorrect.Enabled = True
        chkEndExam.Enabled = True

        chkShowAnswer.Checked = False
        chkShowPercentCorrect.Checked = False
        chkProgressBar.Checked = False
        chkItemReview.Checked = False
        chkMarkForReview.Checked = False
        chkReviewMarked.Checked = False
        chkReviewUnMarked.Checked = False
        chkReviewAnswered.Checked = False
        chkReviewUnanswered.Checked = False

        chkShowExplanationButton.Checked = False
        chkPreviousButton.Checked = False
        chkAddNotes.Checked = False
        chkMultChoice.Checked = False
        chkScoreTest.Checked = False
        chkHideTimer.Checked = True
        chkPauseTimer.Checked = True
        chkReviewCorrect.Checked = False
        chkReviewIncorrect.Checked = False

        chkCorrectReview.Checked = False
        chkShowExplanationCorrect.Checked = False
        chkShowExplanationIncorrect.Checked = False
        chkEndExam.Checked = False
    End Sub

    Private Sub ResetOptions_Exammode()
        ResetOptions_Initialize()

        If ListBox1.SelectedIndex = 0 Then
            chkMarkForReview.Enabled = False
            chkReviewMarked.Enabled = False
            chkReviewUnMarked.Enabled = False
            chkReviewAnswered.Enabled = False
            chkReviewUnanswered.Enabled = False

            chkMultChoice.Enabled = False
            chkHideTimer.Checked = True
            chkPauseTimer.Checked = True
            chkReviewCorrect.Enabled = False
            chkReviewIncorrect.Enabled = False

            chkCorrectReview.Enabled = False

            chkTimedExam.Checked = True
        End If
        If ListBox1.SelectedIndex = 1 Then
            chkMarkForReview.Enabled = False
            chkReviewMarked.Enabled = False
            chkReviewUnMarked.Enabled = False
            chkReviewAnswered.Enabled = False
            chkReviewUnanswered.Enabled = False


            chkMultChoice.Checked = True

            chkHideTimer.Checked = True
            chkPauseTimer.Checked = True
            chkReviewCorrect.Enabled = False
            chkReviewIncorrect.Enabled = False

            chkCorrectReview.Enabled = False

            chkTimedExam.Checked = True
        End If
        If ListBox1.SelectedIndex = 2 Then
            chkMarkForReview.Enabled = False
            chkReviewMarked.Enabled = False
            chkReviewUnMarked.Enabled = False
            chkReviewAnswered.Enabled = False
            chkReviewUnanswered.Enabled = False

            chkMultChoice.Enabled = False
            chkHideTimer.Checked = True
            chkPauseTimer.Checked = True
            chkReviewCorrect.Enabled = False
            chkReviewIncorrect.Enabled = False

            chkCorrectReview.Enabled = False

            chkTimedExam.Checked = True
        End If
        If ListBox1.SelectedIndex = 3 Then
            chkShowAnswer.Enabled = False
            chkShowPercentCorrect.Enabled = False
            chkProgressBar.Enabled = False
            chkItemReview.Enabled = False
            chkMarkForReview.Enabled = False
            chkReviewMarked.Enabled = False
            chkReviewUnMarked.Enabled = False
            chkReviewAnswered.Enabled = False
            chkReviewUnanswered.Enabled = False

            chkShowExplanationButton.Enabled = False
            chkPreviousButton.Enabled = False
            chkAddNotes.Enabled = False
            chkMultChoice.Enabled = False
            chkScoreTest.Enabled = False
            chkHideTimer.Checked = True
            chkPauseTimer.Checked = True
            chkReviewCorrect.Enabled = False
            chkReviewIncorrect.Enabled = False

            chkCorrectReview.Enabled = False
            chkShowExplanationCorrect.Enabled = False
            chkShowExplanationIncorrect.Enabled = False
        End If
    End Sub

    Private Sub ResetOptions_StudyMode()
        If dbIcnse(ListBox1.SelectedIndex).MTYPE = "L" Then
            SettingOptions_Lab()
        End If

        If dbIcnse(ListBox1.SelectedIndex).MTYPE = "E" Then
            SettingOptions_Exam()
        End If

        If dbIcnse(ListBox1.SelectedIndex).MTYPE = "F" Then
            ResetOptions_Flash()
        End If

    End Sub

    Public Shared Function ManipulationText(txt As String, w As Integer)
        Dim newTxtArr(txt.Length + 20) As Char
        Dim k = 1
        Dim j = 0
        For i = 0 To txt.Length - 1
            Dim ch = txt(i)
            If ch = vbCr Or ch = vbLf Then
                k = 1
            End If
            If k = w Then
                newTxtArr(j) = vbCrLf
                j += 1
                newTxtArr(j) = ch
                k = 1
            Else
                newTxtArr(j) = ch
            End If
            k += 1
            j += 1
        Next

        Dim newTxt As String = newTxtArr
        Return newTxt
    End Function

    Public Shared Function GetCorrectNum() As Integer
        Dim cnt = 0
        For i = 0 To selectedQuestionNum - 1
            If dbData(randomArray(i)).correct = "correct" Then
                cnt += 1
            End If
        Next
        Return cnt
    End Function

    Private Sub chkItemReview_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemReview.CheckedChanged
        If chkItemReview.Checked Then
            chkMarkForReview.Enabled = True
            chkReviewMarked.Enabled = True
            chkReviewUnMarked.Enabled = True
            chkReviewAnswered.Enabled = True
            chkReviewUnanswered.Enabled = True
            chkReviewCorrect.Enabled = True
            chkReviewIncorrect.Enabled = True
            chkCorrectReview.Enabled = True
        Else
            chkMarkForReview.Enabled = False
            chkReviewMarked.Enabled = False
            chkReviewUnMarked.Enabled = False
            chkReviewAnswered.Enabled = False
            chkReviewUnanswered.Enabled = False
            chkReviewCorrect.Enabled = False
            chkReviewIncorrect.Enabled = False
            chkCorrectReview.Enabled = False
        End If
    End Sub

    Private Sub chbTimedExam_CheckedChanged(sender As Object, e As EventArgs) Handles chkTimedExam.CheckedChanged
        If chkTimedExam.Checked Then
            chkHideTimer.Enabled = True : chkHideTimer.Checked = True
            chkPauseTimer.Enabled = True : chkPauseTimer.Checked = True
        Else
            chkHideTimer.Enabled = False
            chkPauseTimer.Enabled = False
        End If
    End Sub

    Private Sub chkMarkForReview_CheckedChanged(sender As Object, e As EventArgs) Handles chkMarkForReview.CheckedChanged
        If chkMarkForReview.Checked Then
            chkReviewMarked.Enabled = True : chkReviewUnMarked.Enabled = True
        Else
            chkReviewMarked.Enabled = False : chkReviewUnMarked.Enabled = False
        End If
    End Sub

    Private Sub chkMultChoice_CheckedChanged(sender As Object, e As EventArgs) Handles chkMultChoice.CheckedChanged
        selectedSubFolder = dbIcnse(ListBox1.SelectedIndex).fldSubFolder
        Dim file = ""
        If selectedExamNo = 1 Then
            file = Application.StartupPath & "\" & selectedSubFolder & "db00" & dbIcnse(ListBox1.SelectedIndex).ID & ".mdb"
        Else
            file = Application.StartupPath & "\" & selectedSubFolder & "db00" & dbIcnse(ListBox1.SelectedIndex).ID & selectedExamNo & ".mdb"
        End If

        Dim rcnt = GetRecordCount(file)
        cbSelectAll.Items.Clear()
        cbSelectAll.Items.Add(rcnt)
        cbSelectAll.SelectedIndex = 0

        cbSelectNum.Items.Clear()
        For i = 5 To rcnt
            cbSelectNum.Items.Add(i)
        Next
        cbSelectNum.SelectedIndex = 0
    End Sub

    Private Sub btnSaveOptions_Click(sender As Object, e As EventArgs) Handles btnSaveOptions.Click
        'Dim s = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        'Dim strSystemDir As String = Environment.GetEnvironmentVariable("SystemDrive")
        Dim file = ""
        If dbIcnse(ListBox1.SelectedIndex).MTYPE = "L" Then
            file = Application.StartupPath & "\" & "exams\nerdom1.log"
        End If
        If dbIcnse(ListBox1.SelectedIndex).MTYPE = "E" Then
            file = Application.StartupPath & "\" & "exams\nerdom2.log"
        End If

        'If ListBox1.SelectedIndex = 0 Then file = Application.StartupPath & "\" & "exams\nerdom1.log"
        'If ListBox1.SelectedIndex = 1 Then file = Application.StartupPath & "\" & "exams\nerdom2.log"
        'If ListBox1.SelectedIndex = 2 Then file = Application.StartupPath & "\" & "exams\nerdom3.log"

        '''''''''''''''''''''''''''''''''''''''
        Dim str1 = ""
        str1 += chkRandQuestions.Checked & " "
        str1 += chkRandAnswers.Checked & " " : str1 += chkRandAnswers.Enabled & " "
        str1 += rdoSelectNum.Checked & " "
        str1 += rdoSelectAll.Checked & " "
        str1 += chkTimedExam.Checked & " "

        str1 += chkShowAnswer.Checked & " "
        str1 += chkShowPercentCorrect.Checked & " "
        str1 += chkProgressBar.Checked & " "
        str1 += chkItemReview.Checked & " "
        str1 += chkMarkForReview.Checked & " " : str1 += chkMarkForReview.Enabled & " "
        str1 += chkReviewMarked.Checked & " " : str1 += chkReviewMarked.Enabled & " "
        str1 += chkReviewUnMarked.Checked & " " : str1 += chkReviewUnMarked.Enabled & " "
        str1 += chkReviewAnswered.Checked & " " : str1 += chkReviewAnswered.Enabled & " "
        str1 += chkReviewUnanswered.Checked & " " : str1 += chkReviewUnanswered.Enabled & " "

        str1 += chkShowExplanationButton.Checked & " "
        str1 += chkPreviousButton.Checked & " "
        str1 += chkAddNotes.Checked & " "
        str1 += chkMultChoice.Checked & " " : str1 += chkMultChoice.Enabled & " "
        str1 += chkScoreTest.Checked & " "
        str1 += chkHideTimer.Checked & " " : str1 += chkHideTimer.Enabled & " "
        str1 += chkPauseTimer.Checked & " " : str1 += chkPauseTimer.Enabled & " "
        str1 += chkReviewCorrect.Checked & " " : str1 += chkReviewCorrect.Enabled & " "
        str1 += chkReviewIncorrect.Checked & " " : str1 += chkReviewIncorrect.Enabled & " "

        str1 += chkCorrectReview.Checked & " " : str1 += chkCorrectReview.Enabled & " "
        str1 += chkShowExplanationCorrect.Checked & " "
        str1 += chkShowExplanationIncorrect.Checked & " "
        str1 += chkEndExam.Checked & " "

        str1 += txtUserName.Text & " "
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim writer As StreamWriter = New StreamWriter(file)
        writer.WriteLine(str1)
        writer.Close()

        If dbIcnse(ListBox1.SelectedIndex).MTYPE = "L" Then
            MessageBox.Show("Option settings for the exam type(Lab) were preserved.", "Note")
        End If
        If dbIcnse(ListBox1.SelectedIndex).MTYPE = "E" Then
            MessageBox.Show("Option settings for the exam type(Exam) were preserved.", "Note")
        End If

        'Dim dir As New DirectoryInfo(file)
        'Dir.Attributes = FileAttributes.Hidden

    End Sub

    Private Sub ReadSetingOptions(filename As String)
        Dim objReader = New StreamReader(filename)
        Dim strLine = objReader.ReadLine
        Dim x = Split(strLine, " ")

        chkRandQuestions.Checked = x(0)
        chkRandAnswers.Checked = x(1) : chkRandAnswers.Enabled = x(2)
        rdoSelectNum.Checked = x(3)
        rdoSelectAll.Checked = x(4)
        chkTimedExam.Checked = x(5)

        chkShowAnswer.Checked = x(6)
        chkShowPercentCorrect.Checked = x(7)
        chkProgressBar.Checked = x(8)
        chkItemReview.Checked = x(9)
        chkMarkForReview.Checked = x(10) : chkMarkForReview.Enabled = x(11)
        chkReviewMarked.Checked = x(12) : chkReviewMarked.Enabled = x(13)
        chkReviewUnMarked.Checked = x(14) : chkReviewUnMarked.Enabled = x(15)
        chkReviewAnswered.Checked = x(16) : chkReviewAnswered.Enabled = x(17)
        chkReviewUnanswered.Checked = x(18) : chkReviewUnanswered.Enabled = x(19)

        chkShowExplanationButton.Checked = x(20)
        chkPreviousButton.Checked = x(21)
        chkAddNotes.Checked = x(22)
        chkMultChoice.Checked = x(23) : chkMultChoice.Enabled = x(24)
        chkScoreTest.Checked = x(25)
        chkHideTimer.Checked = x(26) : chkHideTimer.Enabled = x(27)
        chkPauseTimer.Checked = x(28) : chkPauseTimer.Enabled = x(29)
        chkReviewCorrect.Checked = x(30) : chkReviewCorrect.Enabled = x(31)
        chkReviewIncorrect.Checked = x(32) : chkReviewIncorrect.Enabled = x(33)

        chkCorrectReview.Checked = x(34) : chkCorrectReview.Enabled = x(35)
        chkShowExplanationCorrect.Checked = x(36)
        chkShowExplanationIncorrect.Checked = x(37)
        chkEndExam.Checked = x(38)

        txtUserName.Text = x(39)

        objReader.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If cbSelectAll.Text = "" Then
            BtnLaunchExam.Enabled = False
        Else
            BtnLaunchExam.Enabled = True
        End If
    End Sub




End Class
