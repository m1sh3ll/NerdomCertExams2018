Imports Nerdom.frmMainE
Public Class frmNotes
    Dim frmName = ""
    Dim CurrQueNo = 0
    Public Sub New(_frmName As String)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        frmName = _frmName
    End Sub
    Private Sub frmNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If frmName = "frmNet2" Then currQueNo = frmNet2.currQueNo
        If frmName = "frmNet1" Then currQueNo = frmNet1.currQueNo

        TxtNote.Text = dbData(randomArray(CurrQueNo)).note
        TxtNote.Select(TxtNote.TextLength, TxtNote.TextLength)

        Me.Text = "Note For Question" & CurrQueNo & " of " & frmMainE.selectedQuestionNum
    End Sub

    Private Sub btnErase_Click(sender As Object, e As EventArgs) Handles btnErase.Click
        TxtNote.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim ri = dbData(randomArray(CurrQueNo))
        ri.note = TxtNote.Text
        dbData(randomArray(CurrQueNo)) = ri
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class