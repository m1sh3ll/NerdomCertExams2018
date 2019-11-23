Imports Nerdom.frmMainE

Public Class frmExplanation
    Dim frmName = ""
    Dim currQueNo = 0
    Public Sub New(_frmName As String)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        frmName = _frmName
    End Sub
    Private Sub frmExplanation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitleIncorrectAnswer.Visible = False
        lblIncorrectAnswer.Visible = False

        If frmName = "frmNet2" Then currQueNo = frmNet2.currQueNo
        If frmName = "frmNet1" Then currQueNo = frmNet1.currQueNo

        Me.Text = "Question " & currQueNo + 1 & " - Explanation"
        lblCorrectInc.Text = dbData(randomArray(currQueNo)).correct

        'QUESTION...
        lblQuestion.Text = ManipulationText(dbData(randomArray(currQueNo)).Ques, 80)
        'lblQuestion.Top = lblTitleQuestion.Top + lblTitleQuestion.Height + 75
        'lblQuestion.Width = 8685

        'CORRECT ANSWER....
        lblTitleCorrectAnswer.Top = lblQuestion.Top + lblQuestion.Height + 9
        lblCorrectAnswer.Top = lblTitleCorrectAnswer.Top + lblTitleCorrectAnswer.Height + 9
        If frmName = "frmNet2" Then lblCorrectAnswer.Text = ManipulationText(dbData(randomArray(currQueNo)).InputAnswer, 80)
        If frmName = "frmNet1" Then
            lblCorrectAnswer.Text = ""
            If dbData(randomArray(currQueNo)).Ans1 = "1" Then lblCorrectAnswer.Text += "A. " & dbData(randomArray(currQueNo)).AnsA & vbCrLf
            If dbData(randomArray(currQueNo)).Ans2 = "1" Then lblCorrectAnswer.Text += "B. " & dbData(randomArray(currQueNo)).AnsB & vbCrLf
            If dbData(randomArray(currQueNo)).Ans3 = "1" Then lblCorrectAnswer.Text += "C. " & dbData(randomArray(currQueNo)).AnsC & vbCrLf
            If dbData(randomArray(currQueNo)).Ans4 = "1" Then lblCorrectAnswer.Text += "D. " & dbData(randomArray(currQueNo)).AnsD & vbCrLf
            If dbData(randomArray(currQueNo)).Ans5 = "1" Then lblCorrectAnswer.Text += "E. " & dbData(randomArray(currQueNo)).AnsE & vbCrLf
            If dbData(randomArray(currQueNo)).Ans6 = "1" Then lblCorrectAnswer.Text += "F. " & dbData(randomArray(currQueNo)).AnsF & vbCrLf
            If dbData(randomArray(currQueNo)).Ans7 = "1" Then lblCorrectAnswer.Text += "G. " & dbData(randomArray(currQueNo)).AnsG & vbCrLf
            If lblCorrectAnswer.Text = "" Then lblCorrectAnswer.Text = dbData(randomArray(currQueNo)).Answer
        End If

        'EXPLANATION....
        lblExplanationTitle.Top = lblCorrectAnswer.Top + lblCorrectAnswer.Height + 9
        lblExplanation.Top = lblExplanationTitle.Top + lblExplanationTitle.Height + 9
        lblExplanation.Text = ManipulationText(dbData(randomArray(currQueNo)).Explanation, 80)

        'INCORRECT ANSWER(S).... not in labs
        If frmName = "frmNet1" Then
            If dbData(randomArray(currQueNo)).chkoropt <> "i" Then
                lblTitleIncorrectAnswer.Top = lblExplanation.Top + lblExplanation.Height + 9
                lblIncorrectAnswer.Top = lblTitleIncorrectAnswer.Top + lblTitleIncorrectAnswer.Height + 9
                lblIncorrectAnswer.Text = ""
                If dbData(randomArray(currQueNo)).Ans1 = "0" And dbData(randomArray(currQueNo)).AnsA <> "" Then lblIncorrectAnswer.Text += "A. " & dbData(randomArray(currQueNo)).AnsA & vbCrLf
                If dbData(randomArray(currQueNo)).Ans2 = "0" And dbData(randomArray(currQueNo)).AnsB <> "" Then lblIncorrectAnswer.Text += "B. " & dbData(randomArray(currQueNo)).AnsB & vbCrLf
                If dbData(randomArray(currQueNo)).Ans3 = "0" And dbData(randomArray(currQueNo)).AnsC <> "" Then lblIncorrectAnswer.Text += "C. " & dbData(randomArray(currQueNo)).AnsC & vbCrLf
                If dbData(randomArray(currQueNo)).Ans4 = "0" And dbData(randomArray(currQueNo)).AnsD <> "" Then lblIncorrectAnswer.Text += "D. " & dbData(randomArray(currQueNo)).AnsD & vbCrLf
                If dbData(randomArray(currQueNo)).Ans5 = "0" And dbData(randomArray(currQueNo)).AnsE <> "" Then lblIncorrectAnswer.Text += "E. " & dbData(randomArray(currQueNo)).AnsE & vbCrLf
                If dbData(randomArray(currQueNo)).Ans6 = "0" And dbData(randomArray(currQueNo)).AnsF <> "" Then lblIncorrectAnswer.Text += "F. " & dbData(randomArray(currQueNo)).AnsF & vbCrLf
                If dbData(randomArray(currQueNo)).Ans7 = "0" And dbData(randomArray(currQueNo)).AnsG <> "" Then lblIncorrectAnswer.Text += "G. " & dbData(randomArray(currQueNo)).AnsG & vbCrLf
                lblTitleIncorrectAnswer.Visible = True
                lblIncorrectAnswer.Visible = True
            End If
        End If

        lblQuestionIDNumber.Text = dbData(randomArray(currQueNo)).QID
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class