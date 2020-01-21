<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.NUpDownHour = New System.Windows.Forms.NumericUpDown
        Me.NUpDownMinute = New System.Windows.Forms.NumericUpDown
        Me.NUpDownSecond = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.NUpDownYear = New System.Windows.Forms.NumericUpDown
        Me.NUpDownMonth = New System.Windows.Forms.NumericUpDown
        Me.NUpDownDay = New System.Windows.Forms.NumericUpDown
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.NUpDownHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUpDownMinute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUpDownSecond, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUpDownYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUpDownMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUpDownDay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "鬧鈴時間設定"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "時"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "分"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(123, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 12)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "秒"
        '
        'NUpDownHour
        '
        Me.NUpDownHour.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NUpDownHour.Location = New System.Drawing.Point(17, 101)
        Me.NUpDownHour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NUpDownHour.Name = "NUpDownHour"
        Me.NUpDownHour.Size = New System.Drawing.Size(36, 22)
        Me.NUpDownHour.TabIndex = 2
        '
        'NUpDownMinute
        '
        Me.NUpDownMinute.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NUpDownMinute.Location = New System.Drawing.Point(73, 101)
        Me.NUpDownMinute.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NUpDownMinute.Name = "NUpDownMinute"
        Me.NUpDownMinute.Size = New System.Drawing.Size(36, 22)
        Me.NUpDownMinute.TabIndex = 2
        '
        'NUpDownSecond
        '
        Me.NUpDownSecond.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NUpDownSecond.Location = New System.Drawing.Point(125, 101)
        Me.NUpDownSecond.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NUpDownSecond.Name = "NUpDownSecond"
        Me.NUpDownSecond.Size = New System.Drawing.Size(36, 22)
        Me.NUpDownSecond.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 12)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "年"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 12)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "月"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(123, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 12)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "日"
        '
        'NUpDownYear
        '
        Me.NUpDownYear.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NUpDownYear.Location = New System.Drawing.Point(17, 61)
        Me.NUpDownYear.Maximum = New Decimal(New Integer() {2017, 0, 0, 0})
        Me.NUpDownYear.Minimum = New Decimal(New Integer() {2007, 0, 0, 0})
        Me.NUpDownYear.Name = "NUpDownYear"
        Me.NUpDownYear.Size = New System.Drawing.Size(50, 22)
        Me.NUpDownYear.TabIndex = 2
        Me.NUpDownYear.Value = New Decimal(New Integer() {2007, 0, 0, 0})
        '
        'NUpDownMonth
        '
        Me.NUpDownMonth.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NUpDownMonth.Location = New System.Drawing.Point(73, 61)
        Me.NUpDownMonth.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.NUpDownMonth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUpDownMonth.Name = "NUpDownMonth"
        Me.NUpDownMonth.Size = New System.Drawing.Size(36, 22)
        Me.NUpDownMonth.TabIndex = 2
        Me.NUpDownMonth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NUpDownDay
        '
        Me.NUpDownDay.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NUpDownDay.Location = New System.Drawing.Point(125, 61)
        Me.NUpDownDay.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.NUpDownDay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUpDownDay.Name = "NUpDownDay"
        Me.NUpDownDay.Size = New System.Drawing.Size(36, 22)
        Me.NUpDownDay.TabIndex = 2
        Me.NUpDownDay.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "新增"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(173, 176)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NUpDownDay)
        Me.Controls.Add(Me.NUpDownSecond)
        Me.Controls.Add(Me.NUpDownMonth)
        Me.Controls.Add(Me.NUpDownYear)
        Me.Controls.Add(Me.NUpDownMinute)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NUpDownHour)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Location = New System.Drawing.Point(700, 100)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "時間設定"
        CType(Me.NUpDownHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUpDownMinute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUpDownSecond, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUpDownYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUpDownMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUpDownDay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NUpDownHour As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUpDownMinute As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUpDownSecond As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NUpDownYear As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUpDownMonth As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUpDownDay As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
