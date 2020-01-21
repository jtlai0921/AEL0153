<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.flyPB = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.flyPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flyPB
        '
        Me.flyPB.BackColor = System.Drawing.Color.Transparent
        Me.flyPB.Image = Global.WindowsApplication1.My.Resources.Resources.planeU
        Me.flyPB.Location = New System.Drawing.Point(354, 226)
        Me.flyPB.Name = "flyPB"
        Me.flyPB.Size = New System.Drawing.Size(70, 87)
        Me.flyPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.flyPB.TabIndex = 0
        Me.flyPB.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "planeU.gif")
        Me.ImageList1.Images.SetKeyName(1, "planeRU.gif")
        Me.ImageList1.Images.SetKeyName(2, "planeR.gif")
        Me.ImageList1.Images.SetKeyName(3, "planeRD.gif")
        Me.ImageList1.Images.SetKeyName(4, "planeD.gif")
        Me.ImageList1.Images.SetKeyName(5, "planeLD.gif")
        Me.ImageList1.Images.SetKeyName(6, "planeL.gif")
        Me.ImageList1.Images.SetKeyName(7, "planeLU.gif")
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.back
        Me.ClientSize = New System.Drawing.Size(528, 315)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.flyPB)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.flyPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents flyPB As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
