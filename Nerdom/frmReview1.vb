Imports Nerdom.frmMainE
Public Class frmReview1
    Dim fn1 As frmNet1
    Dim fme As frmMainE

    Public Sub New(_form1 As Form, _form2 As Form)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        fn1 = _form1
        fme = _form2
    End Sub

    Private Sub frmReview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If fme.chkMarkForReview.Checked = False Then
            Label3.Visible = False
            btnMarked.Visible = False
            btnUnMarked.Visible = False
        Else
            If fme.chkReviewMarked.Checked = False Then btnMarked.Visible = False
            If fme.chkReviewUnMarked.Checked = False Then btnUnMarked.Visible = False
        End If

        If fme.chkReviewAnswered.Checked = False Then BtnAnswered.Visible = False
        If fme.chkReviewUnanswered.Checked = False Then BtnUnAnswered.Visible = False

        If fme.chkReviewCorrect.Checked = False Then btnCorrect.Visible = False
        If fme.chkReviewIncorrect.Checked = False Then btnIncorrect.Visible = False

        If fme.chkCorrectReview.Checked = False Then Label5.Visible = False

        '''''''''''''''''''''''''''''
        fn1.isClicked_ItemNotesBnt = False
        fn1.isClicked_NoItemNotesBnt = False
        fn1.isClicked_UnAnsweredBtn = False
        fn1.isClicked_AnsweredBtn = False
        fn1.isClicked_IncorrectBtn = False
        fn1.isClicked_CorrectBtn = False
        fn1.isClicked_MarkedBtn = False
        fn1.isClicked_UnMarkedBtn = False
        '''''''''''''''''''''''''''''

        Dim lblQID(frmMainE.selectedQuestionNum - 1) As Label
        Dim lblQues(frmMainE.selectedQuestionNum - 1) As Label
        Dim chkMarked(frmMainE.selectedQuestionNum - 1) As CheckBox
        Dim lblAnswered(frmMainE.selectedQuestionNum - 1) As Label
        Dim lblCorrect(frmMainE.selectedQuestionNum - 1) As Label
        Dim lblNotes(frmMainE.selectedQuestionNum - 1) As Label

        Dim ypos = 10
        For i = 0 To frmMainE.selectedQuestionNum - 1
            'Ques
            lblQues(i) = New Label()
            Me.Panel2.Controls.Add(lblQues(i))
            lblQues(i).Location = New Point(490, ypos)
            lblQues(i).AutoSize = True
            lblQues(i).Text = frmMainE.ManipulationText(dbData(randomArray(i)).Ques, 70)
            'lblQues(i).Font = New Font("Microsoft Sans Serif", 8.25!, CType((FontStyle.Bold Or FontStyle.Underline), FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lblQues(i).ForeColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))

            'QID
            lblQID(i) = New Label()
            Me.Panel2.Controls.Add(lblQID(i))
            lblQID(i).Location = New Point(3, ypos)
            lblQID(i).AutoSize = True
            lblQID(i).Text = i + 1 & ")"
            lblQID(i).Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))

            'Marked
            If fme.chkMarkForReview.Checked = True Then  'k
                chkMarked(i) = New CheckBox()
                Me.Panel2.Controls.Add(chkMarked(i))
                chkMarked(i).AutoSize = True
                chkMarked(i).Location = New Point(117, ypos + 7)
                chkMarked(i).Checked = dbData(randomArray(i)).marked
                chkMarked(i).Font = New Font("Microsoft Sans Serif", 14.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            End If

            'lblAnswered

            lblAnswered(i) = New Label()
            Me.Panel2.Controls.Add(lblAnswered(i))
            lblAnswered(i).Location = New Point(196, ypos)
            lblAnswered(i).AutoSize = True
            lblAnswered(i).Text = dbData(randomArray(i)).answered
            lblAnswered(i).Font = New Font("Microsoft Sans Serif", 14.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            lblAnswered(i).ForeColor = Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))

            'lblCorrect
            If fme.chkCorrectReview.Checked = True Then 'k
                lblCorrect(i) = New Label()
                Me.Panel2.Controls.Add(lblCorrect(i))
                lblCorrect(i).Location = New Point(305, ypos)
                lblCorrect(i).AutoSize = True
                If dbData(randomArray(i)).correct = "correct" Then
                    lblCorrect(i).Text = "Yes"
                End If
                If dbData(randomArray(i)).correct = "incorrect" Then
                    lblCorrect(i).Text = "No"
                End If
                lblCorrect(i).Font = New Font("Microsoft Sans Serif", 14.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
                lblCorrect(i).ForeColor = Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            End If


            'lblNotes
            lblNotes(i) = New Label()
            Me.Panel2.Controls.Add(lblNotes(i))
            lblNotes(i).Location = New Point(384, ypos)
            lblNotes(i).AutoSize = True
            If dbData(randomArray(i)).note <> "" Then
                lblNotes(i).Text = "Notes"
            End If
            lblNotes(i).Font = New Font("Microsoft Sans Serif", 14.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            lblNotes(i).ForeColor = Color.DarkBlue

            'calculate ypos of new line
            ypos = ypos + lblQues(i).Height + 25
        Next

        'check Notes
        Dim k = 0
        For i = 0 To frmMainE.selectedQuestionNum - 1
            If dbData(randomArray(i)).note <> "" Then
                k += 1
            End If
        Next
        If k = 0 Then btnItemNotes.Enabled = False
        'check UnNotes
        k = 0
        For i = 0 To frmMainE.selectedQuestionNum - 1
            If dbData(randomArray(i)).note = "" Then
                k += 1
            End If
        Next
        If k = 0 Then btnItemNoNotes.Enabled = False
        'check UnAnswered Review
        k = 0
        For i = 0 To frmMainE.selectedQuestionNum - 1
            If dbData(randomArray(i)).answered = "No" Then
                k += 1
            End If
        Next
        If k = 0 Then BtnUnAnswered.Enabled = False
        'check Answered Review
        k = 0
        For i = 0 To frmMainE.selectedQuestionNum - 1
            If dbData(randomArray(i)).answered = "Yes" Then
                k += 1
            End If
        Next
        If k = 0 Then BtnAnswered.Enabled = False
        'check Incorrect Review
        k = 0
        For i = 0 To frmMainE.selectedQuestionNum - 1
            If dbData(randomArray(i)).correct = "incorrect" Then
                k += 1
            End If
        Next
        If k = 0 Then btnIncorrect.Enabled = False
        'check Correct Review
        k = 0
        For i = 0 To frmMainE.selectedQuestionNum - 1
            If dbData(randomArray(i)).correct = "correct" Then
                k += 1
            End If
        Next
        If k = 0 Then btnCorrect.Enabled = False
        'check Marked Review
        k = 0
        For i = 0 To frmMainE.selectedQuestionNum - 1
            If dbData(randomArray(i)).marked = True Then
                k += 1
            End If
        Next
        If k = 0 Then btnMarked.Enabled = False
        'check UnMarked Review
        k = 0
        For i = 0 To frmMainE.selectedQuestionNum - 1
            If dbData(randomArray(i)).marked = False Then
                k += 1
            End If
        Next
        If k = 0 Then btnUnMarked.Enabled = False
    End Sub

    Private Sub BtnReviewAll_Click(sender As Object, e As EventArgs) Handles BtnReviewAll.Click
        frmNet1.currQueNo = 0
        fn1.DisplayData(0)
        fn1.Text = "REVIEW MODE"
        Me.Close()
    End Sub

    Private Sub btnScoreTest_Click(sender As Object, e As EventArgs) Handles btnScoreTest.Click
        If selectedCCNA = 0 Or selectedCCNA = 2 Then
            Dim fpp As New frmPrintPreview("frmNet2")
            fpp.ShowDialog()
        ElseIf selectedCCNA = 1 Then
            Dim fpp As New frmPrintPreview("frmNet1")
            fpp.ShowDialog()
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        frmNet1.currQueNo = 0
        fn1.DisplayData(0)
        fn1.Text = "REVIEW MODE"
        Me.Close()
    End Sub

    Private Sub btnItemNotes_Click(sender As Object, e As EventArgs) Handles btnItemNotes.Click
        For i = 0 To frmMainE.selectedQuestionNum - 1
            If dbData(randomArray(i)).note <> "" Then
                fn1.isClicked_ItemNotesBnt = True
                fn1.Text = "REVIEW MODE - REVIEWING ITEMS W/NOTES"
                frmNet1.currQueNo = i
                fn1.DisplayData(i)
                Me.Close()
                Exit For
            End If
        Next
    End Sub

    Private Sub btnItemNoNotes_Click(sender As Object, e As EventArgs) Handles btnItemNoNotes.Click
        For i = 0 To frmMainE.selectedQuestionNum - 1
            If dbData(randomArray(i)).note = "" Then
                fn1.isClicked_NoItemNotesBnt = True
                fn1.Text = "REVIEW MODE - REVIEWING ITEMS W/OUT NOTES"
                frmNet1.currQueNo = i
                fn1.DisplayData(i)
                Me.Close()
                Exit For
            End If
        Next
    End Sub

    Private Sub BtnUnAnswered_Click(sender As Object, e As EventArgs) Handles BtnUnAnswered.Click
        For i = 0 To frmMainE.selectedQuestionNum - 1
            If dbData(randomArray(i)).answered = "No" Then
                fn1.isClicked_UnAnsweredBtn = True
                fn1.Text = "REVIEW MODE - REVIEWING UNANSWERED ITEMS"
                frmNet1.currQueNo = i
                fn1.DisplayData(i)
                Me.Close()
                Exit For
            End If
        Next
    End Sub

    Private Sub BtnAnswered_Click(sender As Object, e As EventArgs) Handles BtnAnswered.Click
        For i = 0 To frmMainE.selectedQuestionNum - 1
            If dbData(randomArray(i)).answered = "Yes" Then
                fn1.isClicked_AnsweredBtn = True
                fn1.Text = "REVIEW MODE - REVIEWING ANSWERED ITEMS"
                frmNet1.currQueNo = i
                fn1.DisplayData(i)
                Me.Close()
                Exit For
            End If
        Next
    End Sub

    Private Sub btnIncorrect_Click(sender As Object, e As EventArgs) Handles btnIncorrect.Click
        For i = 0 To frmMainE.selectedQuestionNum - 1
            If dbData(randomArray(i)).correct = "incorrect" Then
                fn1.isClicked_IncorrectBtn = True
                fn1.Text = "REVIEW MODE - REVIEWING INCORRECT ITEMS"
                frmNet1.currQueNo = i
                fn1.DisplayData(i)
                Me.Close()
                Exit For
            End If
        Next
    End Sub

    Private Sub btnCorrect_Click(sender As Object, e As EventArgs) Handles btnCorrect.Click
        For i = 0 To frmMainE.selectedQuestionNum - 1
            If dbData(randomArray(i)).correct = "correct" Then
                fn1.isClicked_CorrectBtn = True
                fn1.Text = "REVIEW MODE - REVIEWING CORRECT ITEMS"
                frmNet1.currQueNo = i
                fn1.DisplayData(i)
                Me.Close()
                Exit For
            End If
        Next
    End Sub

    Private Sub btnMarked_Click(sender As Object, e As EventArgs) Handles btnMarked.Click
        For i = 0 To frmMainE.selectedQuestionNum - 1
            If dbData(randomArray(i)).marked = True Then
                fn1.isClicked_MarkedBtn = True
                fn1.Text = "REVIEW MODE - REVIEWING MARKED ITEMS"
                frmNet1.currQueNo = i
                fn1.DisplayData(i)
                Me.Close()
                Exit For
            End If
        Next
    End Sub

    Private Sub btnUnMarked_Click(sender As Object, e As EventArgs) Handles btnUnMarked.Click
        For i = 0 To frmMainE.selectedQuestionNum - 1
            If dbData(randomArray(i)).marked = False Then
                fn1.isClicked_UnMarkedBtn = True
                fn1.Text = "REVIEW MODE - REVIEWING UNMARKED ITEMS"
                frmNet1.currQueNo = i
                fn1.DisplayData(i)
                Me.Close()
                Exit For
            End If
        Next
    End Sub
End Class