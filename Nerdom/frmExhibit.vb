Imports Nerdom.frmMainE

Public Class frmExhibit
    Dim frmName = ""
    Dim currQueNo = 0
    Public Sub New(_frmName As String)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        frmName = _frmName
    End Sub

    Private Sub frmExhibit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmName = "frmNet2" Then currQueNo = frmNet2.currQueNo
        If frmName = "frmNet1" Then currQueNo = frmNet1.currQueNo

        Me.Text = "Question " & currQueNo + 1 & " - Exhibit"

        PictureBox1.Image = Bitmap.FromFile(Application.StartupPath & "\" & selectedSubFolder + dbData(randomArray(currQueNo)).ExhibitName)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class