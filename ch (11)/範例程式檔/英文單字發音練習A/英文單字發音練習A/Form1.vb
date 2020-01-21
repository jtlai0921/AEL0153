Public Class Form1
    Dim speech As New SpeechLib.SpVoice
    Private Sub ListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged, ListBox2.SelectedIndexChanged, ListBox3.SelectedIndexChanged
        Label1.Text = ListBox1.SelectedItem & ListBox2.SelectedItem & ListBox3.SelectedItem
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ListBox1.Items.AddRange(New Object() {"ab", "abs", "ad", "bene", "bon", "cata", "circum", "co", "com", "con", "contra", "contro", "counter", "de", "de", "di", "dia", "dis", "e", "ec", "em", "en", "epi", "ex", "extra", "fore", "im", "in", "inter", "mal", "mon", "mono", "ob", "para", "per", "post", "pre", "pro", "pur", "re", "se", "sub", "super", "sur", "sus", "sym", "syn", "trans", "uni"})
        Me.ListBox2.Items.AddRange(New Object() {"act", "ag", "anim", "cad", "cap", "cas", "cede", "ceed", "ceiv", "cep", "cept", "cess", "cid", "cid", "cip", "cis", "cit", "claim", "clam", "clud", "clus", "cor", "cord", "corp", "corpor", "cour", "cours", "cred", "cup", "cur", "cur", "curs", "dic", "dict", "duc", "duct", "equ", "fac", "fact", "fair", "feat", "fect", "feit", "fer", "fin", "flex", "flext", "flu", "found", "fract", "frag", "frang", "fring", "fus", "gen", "grad", "gress", "ig", "it", "jac", "ject", "jet", "join", "joint", "junct", "lect", "leg", "lig", "locu", "log", "loqu", "luc", "lumin", "lustr", "magn", "main", "maj", "man", "max", "mini", "minu", "miss", "mit", "mob", "mom", "mot", "mov", "pass", "path", "ped", "pel", "pend", "pens", "plex", "plic", "plus", "ply", "pon", "pond", "port", "pos", "pound", "press", "quest", "quir", "quis", "reg", "rig", "scrib", "scrip", "secu", "sed", "sens", "sent", "sequ", "sess", "sid", "sist", "spec", "spect", "spic", "sta", "stitut", "strain", "stress", "strict", "string", "stru", "struct", "sue", "tact", "tain", "tang", "ten", "tend", "tens", "tent", "tin", "tor", "tort", "tract", "treat", "trud", "trus", "vac", "vail", "val", "van", "ven", "vent", "vers", "vert", "vey", "via", "vid", "view", "vig", "vis", "vit", "viv", "voc", "void", "vok", "volu", "volv", "voy"})
        Me.ListBox3.Items.AddRange(New Object() {"able", "ation", "bility", "ce", "en", "er", "ful", "graph", "ist", "ize", "less", "ment", "ment", "ness", "or", "rupt", "scrib", "ship", "tion", "tive"})

        Label1.Text = ""
        Label1.Font = New Font("Arial", 72)
        TextBox1.Text = "說明：" & vbCrLf & vbCrLf & "本程式應用收集之字首、字根及字尾，排列組合成練習單字，純供發音練習使用，並未考量組合之單字於習慣使用上有無其實際代表意義。"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' AxTextToSpeech1.Speak(Label1.Text)
        speech.Speak(Label1.Text, SpeechLib.SpeechVoiceSpeakFlags.SVSFDefault)
    End Sub
End Class

'Public Class Form1
'    Dim speech As New SpeechLib.SpVoice

'    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        TextBox1.Text = "We must accept finite disappointment, but we must never lose infinite hope.  -- Mattin Luther King"

'        TextBox1.Font = New Font("", 10, FontStyle.Regular)
'    End Sub

'    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
'        Dim s = TextBox1.Text
'        speech.Speak(s, SpeechLib.SpeechVoiceSpeakFlags.SVSFDefault)
'    End Sub
'End Class
