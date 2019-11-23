Imports Nerdom.frmMainE
Public Class frmPrintPreview

    Dim frmName = ""
    Public Sub New(_frmName As String)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        frmName = _frmName
    End Sub
    Private Sub frmPrintPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayScoreReport()
    End Sub
    Private Sub DisplayScoreReport()
        RichTextBox1.Text = "Nerdom Cert Exams Score Report" & vbCrLf
        If frmName = "frmNet2" Then RichTextBox1.Text += dbIcnse(selectedCCNA).TopicBut1 & vbCrLf
        If frmName = "frmNet1" Then
            If selectedExamNo = 1 Then RichTextBox1.Text += dbIcnse(selectedCCNA).TopicBut1 & vbCrLf
            If selectedExamNo = 2 Then RichTextBox1.Text += dbIcnse(selectedCCNA).TopicBut2 & vbCrLf
            If selectedExamNo = 3 Then RichTextBox1.Text += dbIcnse(selectedCCNA).TopicBut3 & vbCrLf
            If selectedExamNo = 4 Then RichTextBox1.Text += dbIcnse(selectedCCNA).TopicBut4 & vbCrLf
            If selectedExamNo = 5 Then RichTextBox1.Text += dbIcnse(selectedCCNA).TopicBut5 & vbCrLf
            If selectedExamNo = 6 Then RichTextBox1.Text += dbIcnse(selectedCCNA).TopicButAll & vbCrLf
        End If
        RichTextBox1.Text += "----------------------------------------------------------" & vbCrLf

        RichTextBox1.Text += frmMainE.userName & vbCrLf
        Dim TodayDateTime = Format(Now, "long date") & " " & Format(Now, "long time")
        RichTextBox1.Text += TodayDateTime & vbCrLf
        RichTextBox1.Text += "----------------------------------------------------------" & vbCrLf

        RichTextBox1.Text += "Your Score Report: " & vbCrLf
        RichTextBox1.Text += GetCorrectNum() & " correct out of " & frmMainE.selectedQuestionNum & vbCrLf

        RichTextBox1.Text += "Your score for this exam was " & Math.Round(GetCorrectNum() / frmMainE.selectedQuestionNum * 100) & "%." & vbCrLf

        If Math.Round(GetCorrectNum() / frmMainE.selectedQuestionNum * 100) > 74 Then
            RichTextBox1.Text += "Result : Pass :) Good work!" & vbCrLf & vbCrLf
        Else
            RichTextBox1.Text += "Result : Fail :( Needs some work. Study study." & vbCrLf & vbCrLf
        End If

        For i = 0 To frmMainE.selectedQuestionNum - 1
            Dim str1 = dbData(randomArray(i)).correct
            If str1 = "correct" Or str1 = "incorrect" Then
                RichTextBox1.Text += "Question #" & i + 1 & ". " & str1 & "."
                RichTextBox1.Text += vbCrLf
                RichTextBox1.Text += ManipulationText(dbData(randomArray(i)).Ques, 90)
                RichTextBox1.Text += vbCrLf
                RichTextBox1.Text += "Correct Answer : " & dbData(randomArray(i)).InputAnswer & vbCrLf & vbCrLf
            End If
            If str1 = "incomplete" Then
                RichTextBox1.Text += "Question #" & i + 1 & ". " & str1 & "."
                RichTextBox1.Text += vbCrLf + vbCrLf
            End If
        Next
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnViewNotes_Click(sender As Object, e As EventArgs) Handles btnViewNotes.Click
        RichTextBox1.Text = "Exam Notes : " & vbCrLf
        RichTextBox1.Text += "------------------------------------------------------------" & vbCrLf

        For i = 0 To frmMainE.selectedQuestionNum - 1
            Dim str1 = dbData(randomArray(i)).note
            If str1 <> "" Then
                RichTextBox1.Text += "Question # " & i + 1 & "." & vbCrLf
                RichTextBox1.Text += str1 & vbCrLf & vbCrLf
            End If
        Next
    End Sub

    Private Sub btnViewScoreReport_Click(sender As Object, e As EventArgs) Handles btnViewScoreReport.Click
        DisplayScoreReport()
    End Sub
End Class