Public Class Form1
    Dim speech As New SpeechLib.SpVoice
    Dim isSpeak = False
    Dim sp1 As Array

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Font = New Font("", 10, FontStyle.Regular)
        Dim i As Integer = 1
        Dim sp1 As Array
        Dim sr1 As System.IO.StreamReader
        sr1 = System.IO.File.OpenText(Application.StartupPath & "\網路名詞utf8.txt")
        Dim myReadLine As String = sr1.ReadLine
        sp1 = Split(myReadLine, "|")

        While Not myReadLine Is Nothing
            ListBox1.Items.Add(myReadLine)
            myReadLine = sr1.ReadLine
            sp1 = Split(myReadLine, "|")
            i = i + 1
        End While

        ListBox1.SelectedIndex = 5
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        sp1 = Split(ListBox1.SelectedItem, "|")
        TextBox1.Text = sp1(0) & vbNewLine & "    " & sp1(1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s = TextBox1.Text
        speech.Speak(s, SpeechLib.SpeechVoiceSpeakFlags.SVSFDefault)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim s = sp1(0)
        speech.Speak(s, SpeechLib.SpeechVoiceSpeakFlags.SVSFDefault)
    End Sub
End Class
