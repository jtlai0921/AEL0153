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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RBtnYellowBlouse = New System.Windows.Forms.RadioButton
        Me.RBtnGreenBlouse = New System.Windows.Forms.RadioButton
        Me.RBtnBlueBlouse = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RBtnBlueHat = New System.Windows.Forms.RadioButton
        Me.RBtnYellowHat = New System.Windows.Forms.RadioButton
        Me.RBtnRedHat = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RBtnWhiteShoes = New System.Windows.Forms.RadioButton
        Me.RBtnRedShoes = New System.Windows.Forms.RadioButton
        Me.RBtnBlueShoes = New System.Windows.Forms.RadioButton
        Me.PBoxHat = New System.Windows.Forms.PictureBox
        Me.PBoxBlouse = New System.Windows.Forms.PictureBox
        Me.PBoxShoes = New System.Windows.Forms.PictureBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PBoxHat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxBlouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxShoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBtnYellowBlouse)
        Me.GroupBox2.Controls.Add(Me.RBtnGreenBlouse)
        Me.GroupBox2.Controls.Add(Me.RBtnBlueBlouse)
        Me.GroupBox2.Location = New System.Drawing.Point(388, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(72, 88)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "上衣"
        '
        'RBtnYellowBlouse
        '
        Me.RBtnYellowBlouse.AutoSize = True
        Me.RBtnYellowBlouse.Location = New System.Drawing.Point(17, 64)
        Me.RBtnYellowBlouse.Name = "RBtnYellowBlouse"
        Me.RBtnYellowBlouse.Size = New System.Drawing.Size(35, 16)
        Me.RBtnYellowBlouse.TabIndex = 2
        Me.RBtnYellowBlouse.TabStop = True
        Me.RBtnYellowBlouse.Text = "黃"
        Me.RBtnYellowBlouse.UseVisualStyleBackColor = True
        '
        'RBtnGreenBlouse
        '
        Me.RBtnGreenBlouse.AutoSize = True
        Me.RBtnGreenBlouse.Location = New System.Drawing.Point(17, 44)
        Me.RBtnGreenBlouse.Name = "RBtnGreenBlouse"
        Me.RBtnGreenBlouse.Size = New System.Drawing.Size(35, 16)
        Me.RBtnGreenBlouse.TabIndex = 1
        Me.RBtnGreenBlouse.TabStop = True
        Me.RBtnGreenBlouse.Text = "綠"
        Me.RBtnGreenBlouse.UseVisualStyleBackColor = True
        '
        'RBtnBlueBlouse
        '
        Me.RBtnBlueBlouse.AutoSize = True
        Me.RBtnBlueBlouse.Location = New System.Drawing.Point(17, 22)
        Me.RBtnBlueBlouse.Name = "RBtnBlueBlouse"
        Me.RBtnBlueBlouse.Size = New System.Drawing.Size(35, 16)
        Me.RBtnBlueBlouse.TabIndex = 0
        Me.RBtnBlueBlouse.TabStop = True
        Me.RBtnBlueBlouse.Text = "藍"
        Me.RBtnBlueBlouse.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBtnBlueHat)
        Me.GroupBox1.Controls.Add(Me.RBtnYellowHat)
        Me.GroupBox1.Controls.Add(Me.RBtnRedHat)
        Me.GroupBox1.Location = New System.Drawing.Point(388, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(72, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "帽子"
        '
        'RBtnBlueHat
        '
        Me.RBtnBlueHat.AutoSize = True
        Me.RBtnBlueHat.Location = New System.Drawing.Point(17, 66)
        Me.RBtnBlueHat.Name = "RBtnBlueHat"
        Me.RBtnBlueHat.Size = New System.Drawing.Size(35, 16)
        Me.RBtnBlueHat.TabIndex = 0
        Me.RBtnBlueHat.TabStop = True
        Me.RBtnBlueHat.Text = "藍"
        Me.RBtnBlueHat.UseVisualStyleBackColor = True
        '
        'RBtnYellowHat
        '
        Me.RBtnYellowHat.AutoSize = True
        Me.RBtnYellowHat.Location = New System.Drawing.Point(17, 44)
        Me.RBtnYellowHat.Name = "RBtnYellowHat"
        Me.RBtnYellowHat.Size = New System.Drawing.Size(35, 16)
        Me.RBtnYellowHat.TabIndex = 0
        Me.RBtnYellowHat.TabStop = True
        Me.RBtnYellowHat.Text = "黃"
        Me.RBtnYellowHat.UseVisualStyleBackColor = True
        '
        'RBtnRedHat
        '
        Me.RBtnRedHat.AutoSize = True
        Me.RBtnRedHat.Location = New System.Drawing.Point(17, 22)
        Me.RBtnRedHat.Name = "RBtnRedHat"
        Me.RBtnRedHat.Size = New System.Drawing.Size(35, 16)
        Me.RBtnRedHat.TabIndex = 0
        Me.RBtnRedHat.TabStop = True
        Me.RBtnRedHat.Text = "紅"
        Me.RBtnRedHat.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RBtnWhiteShoes)
        Me.GroupBox3.Controls.Add(Me.RBtnRedShoes)
        Me.GroupBox3.Controls.Add(Me.RBtnBlueShoes)
        Me.GroupBox3.Location = New System.Drawing.Point(388, 226)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(72, 100)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "鞋子"
        '
        'RBtnWhiteShoes
        '
        Me.RBtnWhiteShoes.AutoSize = True
        Me.RBtnWhiteShoes.Location = New System.Drawing.Point(17, 64)
        Me.RBtnWhiteShoes.Name = "RBtnWhiteShoes"
        Me.RBtnWhiteShoes.Size = New System.Drawing.Size(35, 16)
        Me.RBtnWhiteShoes.TabIndex = 2
        Me.RBtnWhiteShoes.TabStop = True
        Me.RBtnWhiteShoes.Text = "白"
        Me.RBtnWhiteShoes.UseVisualStyleBackColor = True
        '
        'RBtnRedShoes
        '
        Me.RBtnRedShoes.AutoSize = True
        Me.RBtnRedShoes.Location = New System.Drawing.Point(17, 42)
        Me.RBtnRedShoes.Name = "RBtnRedShoes"
        Me.RBtnRedShoes.Size = New System.Drawing.Size(35, 16)
        Me.RBtnRedShoes.TabIndex = 1
        Me.RBtnRedShoes.TabStop = True
        Me.RBtnRedShoes.Text = "紅"
        Me.RBtnRedShoes.UseVisualStyleBackColor = True
        '
        'RBtnBlueShoes
        '
        Me.RBtnBlueShoes.AutoSize = True
        Me.RBtnBlueShoes.Location = New System.Drawing.Point(17, 22)
        Me.RBtnBlueShoes.Name = "RBtnBlueShoes"
        Me.RBtnBlueShoes.Size = New System.Drawing.Size(35, 16)
        Me.RBtnBlueShoes.TabIndex = 0
        Me.RBtnBlueShoes.TabStop = True
        Me.RBtnBlueShoes.Text = "藍"
        Me.RBtnBlueShoes.UseVisualStyleBackColor = True
        '
        'PBoxHat
        '
        Me.PBoxHat.BackColor = System.Drawing.Color.Transparent
        Me.PBoxHat.Image = Global.WindowsApplication1.My.Resources.Resources.initial
        Me.PBoxHat.Location = New System.Drawing.Point(114, 2)
        Me.PBoxHat.Name = "PBoxHat"
        Me.PBoxHat.Size = New System.Drawing.Size(52, 50)
        Me.PBoxHat.TabIndex = 7
        Me.PBoxHat.TabStop = False
        '
        'PBoxBlouse
        '
        Me.PBoxBlouse.BackColor = System.Drawing.Color.Transparent
        Me.PBoxBlouse.Image = Global.WindowsApplication1.My.Resources.Resources.yellowBlouse
        Me.PBoxBlouse.Location = New System.Drawing.Point(163, 25)
        Me.PBoxBlouse.Name = "PBoxBlouse"
        Me.PBoxBlouse.Size = New System.Drawing.Size(102, 103)
        Me.PBoxBlouse.TabIndex = 8
        Me.PBoxBlouse.TabStop = False
        '
        'PBoxShoes
        '
        Me.PBoxShoes.BackColor = System.Drawing.Color.Transparent
        Me.PBoxShoes.Location = New System.Drawing.Point(173, 326)
        Me.PBoxShoes.Name = "PBoxShoes"
        Me.PBoxShoes.Size = New System.Drawing.Size(80, 42)
        Me.PBoxShoes.TabIndex = 9
        Me.PBoxShoes.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.initial
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(478, 432)
        Me.Controls.Add(Me.PBoxShoes)
        Me.Controls.Add(Me.PBoxBlouse)
        Me.Controls.Add(Me.PBoxHat)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "服裝搭配"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PBoxHat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxBlouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxShoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RBtnYellowBlouse As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnGreenBlouse As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnBlueBlouse As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RBtnBlueHat As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnYellowHat As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnRedHat As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RBtnBlueShoes As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnWhiteShoes As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnRedShoes As System.Windows.Forms.RadioButton
    Friend WithEvents PBoxHat As System.Windows.Forms.PictureBox
    Friend WithEvents PBoxBlouse As System.Windows.Forms.PictureBox
    Friend WithEvents PBoxShoes As System.Windows.Forms.PictureBox

End Class
