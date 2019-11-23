<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintPreview
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnFont = New System.Windows.Forms.Button()
        Me.btnViewScoreReport = New System.Windows.Forms.Button()
        Me.btnViewNotes = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1106, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Score Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 40)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1106, 623)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(811, 672)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 35)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnFont
        '
        Me.btnFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFont.Location = New System.Drawing.Point(123, 672)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(100, 35)
        Me.btnFont.TabIndex = 3
        Me.btnFont.Text = "Font"
        Me.btnFont.UseVisualStyleBackColor = True
        '
        'btnViewScoreReport
        '
        Me.btnViewScoreReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewScoreReport.Location = New System.Drawing.Point(229, 672)
        Me.btnViewScoreReport.Name = "btnViewScoreReport"
        Me.btnViewScoreReport.Size = New System.Drawing.Size(100, 35)
        Me.btnViewScoreReport.TabIndex = 4
        Me.btnViewScoreReport.Text = "Score Report"
        Me.btnViewScoreReport.UseVisualStyleBackColor = True
        '
        'btnViewNotes
        '
        Me.btnViewNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewNotes.Location = New System.Drawing.Point(335, 672)
        Me.btnViewNotes.Name = "btnViewNotes"
        Me.btnViewNotes.Size = New System.Drawing.Size(100, 35)
        Me.btnViewNotes.TabIndex = 5
        Me.btnViewNotes.Text = "Notes"
        Me.btnViewNotes.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(468, 672)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 35)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmPrintPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 712)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnViewNotes)
        Me.Controls.Add(Me.btnViewScoreReport)
        Me.Controls.Add(Me.btnFont)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmPrintPreview"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Preview - Your Score Report"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnFont As Button
    Friend WithEvents btnViewScoreReport As Button
    Friend WithEvents btnViewNotes As Button
    Friend WithEvents btnPrint As Button
End Class
