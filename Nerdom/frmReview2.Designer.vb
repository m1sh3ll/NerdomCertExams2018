<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReview2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnReviewAll = New System.Windows.Forms.Button()
        Me.btnScoreTest = New System.Windows.Forms.Button()
        Me.btnItemNotes = New System.Windows.Forms.Button()
        Me.btnItemNoNotes = New System.Windows.Forms.Button()
        Me.BtnUnAnswered = New System.Windows.Forms.Button()
        Me.BtnAnswered = New System.Windows.Forms.Button()
        Me.btnIncorrect = New System.Windows.Forms.Button()
        Me.btnCorrect = New System.Windows.Forms.Button()
        Me.btnMarked = New System.Windows.Forms.Button()
        Me.btnUnMarked = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1147, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Review Exam"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.BtnBack)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1147, 84)
        Me.Panel1.TabIndex = 2
        '
        'BtnBack
        '
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.Location = New System.Drawing.Point(1026, 0)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(121, 40)
        Me.BtnBack.TabIndex = 6
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(282, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Correct"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(484, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(287, 25)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Click the Question to Review"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(384, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Notes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(169, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Answered"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(77, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Marked"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(3, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "QID"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1147, 583)
        Me.Panel2.TabIndex = 3
        '
        'BtnReviewAll
        '
        Me.BtnReviewAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReviewAll.Location = New System.Drawing.Point(916, 671)
        Me.BtnReviewAll.Name = "BtnReviewAll"
        Me.BtnReviewAll.Size = New System.Drawing.Size(220, 38)
        Me.BtnReviewAll.TabIndex = 4
        Me.BtnReviewAll.Text = "Review All"
        Me.BtnReviewAll.UseVisualStyleBackColor = True
        '
        'btnScoreTest
        '
        Me.btnScoreTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScoreTest.Location = New System.Drawing.Point(916, 715)
        Me.btnScoreTest.Name = "btnScoreTest"
        Me.btnScoreTest.Size = New System.Drawing.Size(220, 38)
        Me.btnScoreTest.TabIndex = 5
        Me.btnScoreTest.Text = "Score Test"
        Me.btnScoreTest.UseVisualStyleBackColor = True
        '
        'btnItemNotes
        '
        Me.btnItemNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemNotes.Location = New System.Drawing.Point(690, 671)
        Me.btnItemNotes.Name = "btnItemNotes"
        Me.btnItemNotes.Size = New System.Drawing.Size(220, 38)
        Me.btnItemNotes.TabIndex = 6
        Me.btnItemNotes.Text = "Item w/Notes"
        Me.btnItemNotes.UseVisualStyleBackColor = True
        '
        'btnItemNoNotes
        '
        Me.btnItemNoNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemNoNotes.Location = New System.Drawing.Point(690, 715)
        Me.btnItemNoNotes.Name = "btnItemNoNotes"
        Me.btnItemNoNotes.Size = New System.Drawing.Size(220, 38)
        Me.btnItemNoNotes.TabIndex = 7
        Me.btnItemNoNotes.Text = "Item w/No Notes"
        Me.btnItemNoNotes.UseVisualStyleBackColor = True
        '
        'BtnUnAnswered
        '
        Me.BtnUnAnswered.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUnAnswered.Location = New System.Drawing.Point(463, 715)
        Me.BtnUnAnswered.Name = "BtnUnAnswered"
        Me.BtnUnAnswered.Size = New System.Drawing.Size(220, 38)
        Me.BtnUnAnswered.TabIndex = 8
        Me.BtnUnAnswered.Text = "Review UnAnswered" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnUnAnswered.UseVisualStyleBackColor = True
        '
        'BtnAnswered
        '
        Me.BtnAnswered.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnswered.Location = New System.Drawing.Point(463, 671)
        Me.BtnAnswered.Name = "BtnAnswered"
        Me.BtnAnswered.Size = New System.Drawing.Size(220, 38)
        Me.BtnAnswered.TabIndex = 9
        Me.BtnAnswered.Text = "Review Answered" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnAnswered.UseVisualStyleBackColor = True
        '
        'btnIncorrect
        '
        Me.btnIncorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncorrect.Location = New System.Drawing.Point(237, 715)
        Me.btnIncorrect.Name = "btnIncorrect"
        Me.btnIncorrect.Size = New System.Drawing.Size(220, 38)
        Me.btnIncorrect.TabIndex = 10
        Me.btnIncorrect.Text = "Review Incorrect" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnIncorrect.UseVisualStyleBackColor = True
        '
        'btnCorrect
        '
        Me.btnCorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCorrect.Location = New System.Drawing.Point(237, 671)
        Me.btnCorrect.Name = "btnCorrect"
        Me.btnCorrect.Size = New System.Drawing.Size(220, 38)
        Me.btnCorrect.TabIndex = 11
        Me.btnCorrect.Text = "Review Correct" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnCorrect.UseVisualStyleBackColor = True
        '
        'btnMarked
        '
        Me.btnMarked.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarked.Location = New System.Drawing.Point(11, 671)
        Me.btnMarked.Name = "btnMarked"
        Me.btnMarked.Size = New System.Drawing.Size(220, 38)
        Me.btnMarked.TabIndex = 12
        Me.btnMarked.Text = "Review Marked"
        Me.btnMarked.UseVisualStyleBackColor = True
        '
        'btnUnMarked
        '
        Me.btnUnMarked.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnMarked.Location = New System.Drawing.Point(11, 715)
        Me.btnUnMarked.Name = "btnUnMarked"
        Me.btnUnMarked.Size = New System.Drawing.Size(220, 38)
        Me.btnUnMarked.TabIndex = 13
        Me.btnUnMarked.Text = "Review UnMarked"
        Me.btnUnMarked.UseVisualStyleBackColor = True
        '
        'frmReview2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1146, 761)
        Me.Controls.Add(Me.btnUnMarked)
        Me.Controls.Add(Me.btnMarked)
        Me.Controls.Add(Me.btnCorrect)
        Me.Controls.Add(Me.btnIncorrect)
        Me.Controls.Add(Me.BtnAnswered)
        Me.Controls.Add(Me.BtnUnAnswered)
        Me.Controls.Add(Me.btnItemNoNotes)
        Me.Controls.Add(Me.btnItemNotes)
        Me.Controls.Add(Me.btnScoreTest)
        Me.Controls.Add(Me.BtnReviewAll)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "frmReview2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nerdom Cert Exams Review"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnReviewAll As Button
    Friend WithEvents btnScoreTest As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents btnItemNotes As Button
    Friend WithEvents btnItemNoNotes As Button
    Friend WithEvents BtnUnAnswered As Button
    Friend WithEvents BtnAnswered As Button
    Friend WithEvents btnIncorrect As Button
    Friend WithEvents btnCorrect As Button
    Friend WithEvents btnMarked As Button
    Friend WithEvents btnUnMarked As Button
End Class
