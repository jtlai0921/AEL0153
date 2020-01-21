Public Class Form1
    Dim speech As New SpeechLib.SpVoice

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "We must accept finite disappointment, but we must never lose infinite hope.  -- Mattin Luther King"

        TextBox1.Font = New Font("", 10, FontStyle.Regular)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim s = TextBox1.Text
        speech.Speak(s, SpeechLib.SpeechVoiceSpeakFlags.SVSFDefault)
    End Sub
End Class
