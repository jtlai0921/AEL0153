<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.檔案FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.結束XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.輸入方式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.文章測驗ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.字根歸類ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.檔案FToolStripMenuItem, Me.輸入方式ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(575, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '檔案FToolStripMenuItem
        '
        Me.檔案FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.結束XToolStripMenuItem})
        Me.檔案FToolStripMenuItem.Name = "檔案FToolStripMenuItem"
        Me.檔案FToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.檔案FToolStripMenuItem.Text = "檔案(&F)"
        '
        '結束XToolStripMenuItem
        '
        Me.結束XToolStripMenuItem.Name = "結束XToolStripMenuItem"
        Me.結束XToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.結束XToolStripMenuItem.Text = "結束(&X)"
        '
        '輸入方式ToolStripMenuItem
        '
        Me.輸入方式ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文章測驗ToolStripMenuItem, Me.字根歸類ToolStripMenuItem})
        Me.輸入方式ToolStripMenuItem.Name = "輸入方式ToolStripMenuItem"
        Me.輸入方式ToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.輸入方式ToolStripMenuItem.Text = "輸入方式(&I)"
        '
        '文章測驗ToolStripMenuItem
        '
        Me.文章測驗ToolStripMenuItem.Name = "文章測驗ToolStripMenuItem"
        Me.文章測驗ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.文章測驗ToolStripMenuItem.Text = "文章測驗"
        '
        '字根歸類ToolStripMenuItem
        '
        Me.字根歸類ToolStripMenuItem.Name = "字根歸類ToolStripMenuItem"
        Me.字根歸類ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.字根歸類ToolStripMenuItem.Text = "字根歸類"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 496)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.Text = "資料輸入表單"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 檔案FToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 輸入方式ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 文章測驗ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 字根歸類ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 結束XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
