Public Class Form1
    Public Declare Sub Sleep Lib "kernel32" Alias "Sleep" (ByVal dwMilliseconds As Long)
    ReadOnly charsRemainingLabelDefaultText As String = "Verbleibende Textlänge bis Maximum erreicht: "
    ReadOnly standinOpeningParenthesis As String = "$$$$$Klammerauf$$$$$"
    ReadOnly standinClosingParenthesis As String = "$$$$$Klammerzu$$$$$"
    ReadOnly standinOpeningCurly As String = "$$$$$GeschwungeneKlammerauf$$$$$"
    ReadOnly standinClosingCurly As String = "$$$$$GeschwungeneKlammerzu$$$$$"
    ReadOnly standinTilde As String = "$$$$$Tilde$$$$$"
    Private Sub goButton_Click(sender As Object, e As EventArgs) Handles goButton.Click
        Dim textToBeSent As String = inputTextBox.Text
        textToBeSent = textToBeSent.Replace("{", standinOpeningCurly)
        textToBeSent = textToBeSent.Replace("}", standinClosingCurly)
        textToBeSent = textToBeSent.Replace(standinOpeningCurly, "{{}")
        textToBeSent = textToBeSent.Replace(standinClosingCurly, "{}}")
        textToBeSent = textToBeSent.Replace("(", standinOpeningParenthesis)
        textToBeSent = textToBeSent.Replace(")", standinClosingParenthesis)
        textToBeSent = textToBeSent.Replace("+", "{+}")
        textToBeSent = textToBeSent.Replace("%", "+(5)")
        textToBeSent = textToBeSent.Replace(standinOpeningParenthesis, "+(8)")
        textToBeSent = textToBeSent.Replace(standinClosingParenthesis, "+(9)")

        textToBeSent = textToBeSent.Replace(Chr(13) + Chr(10), "~")
        If inputTextBox.Text.Contains("~") Then
            MsgBox("Texte die das ~ Symbol beinhalten werden nicht unterstützt" + Chr(10) + "Der Text wird wohl an das andere Fenster übergeben aber die" + Chr(10) + "Tilde wird wohl zu was auch immer die Enter-Taste bewirkt!!!!", MessageBoxButtons.OK, "Tastenanschläge vorgaukeln")
        End If
        SendKeys.Send("%{TAB}")
        Sleep(100)
        SendKeys.Send(textToBeSent)
    End Sub

    Private Sub inputTextBox_TextChanged(sender As Object, e As EventArgs) Handles inputTextBox.TextChanged
        Dim charsRemainingCount As Int64 = inputTextBox.MaxLength - inputTextBox.TextLength
        charsRemainingLabel.Text = charsRemainingLabelDefaultText + charsRemainingCount.ToString
    End Sub
End Class
