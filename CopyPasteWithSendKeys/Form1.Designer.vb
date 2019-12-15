<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.goButton = New System.Windows.Forms.Button()
        Me.inputTextBox = New System.Windows.Forms.TextBox()
        Me.charsRemainingLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'goButton
        '
        Me.goButton.Location = New System.Drawing.Point(13, 415)
        Me.goButton.Name = "goButton"
        Me.goButton.Size = New System.Drawing.Size(775, 23)
        Me.goButton.TabIndex = 1
        Me.goButton.Text = "Jetzt Tastenanschläge vorgaukeln"
        Me.goButton.UseVisualStyleBackColor = True
        '
        'inputTextBox
        '
        Me.inputTextBox.AcceptsReturn = True
        Me.inputTextBox.AcceptsTab = True
        Me.inputTextBox.AllowDrop = True
        Me.inputTextBox.Location = New System.Drawing.Point(13, 13)
        Me.inputTextBox.MaxLength = 65535
        Me.inputTextBox.Multiline = True
        Me.inputTextBox.Name = "inputTextBox"
        Me.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.inputTextBox.Size = New System.Drawing.Size(775, 363)
        Me.inputTextBox.TabIndex = 2
        Me.inputTextBox.WordWrap = False
        '
        'charsRemainingLabel
        '
        Me.charsRemainingLabel.AutoSize = True
        Me.charsRemainingLabel.Location = New System.Drawing.Point(13, 383)
        Me.charsRemainingLabel.Name = "charsRemainingLabel"
        Me.charsRemainingLabel.Size = New System.Drawing.Size(223, 13)
        Me.charsRemainingLabel.TabIndex = 3
        Me.charsRemainingLabel.Text = "Verbleibende Textlänge bis Maximum erreicht:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.charsRemainingLabel)
        Me.Controls.Add(Me.inputTextBox)
        Me.Controls.Add(Me.goButton)
        Me.Name = "Form1"
        Me.Text = "Tastenanschläge vorgaukeln"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents goButton As Button
    Friend WithEvents inputTextBox As TextBox
    Friend WithEvents charsRemainingLabel As Label
End Class
