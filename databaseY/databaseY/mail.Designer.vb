<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mail
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
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim butExit As System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        butExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'butExit
        '
        butExit.BackColor = System.Drawing.Color.Transparent
        butExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        butExit.FlatAppearance.BorderSize = 0
        butExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        butExit.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        butExit.ForeColor = System.Drawing.Color.Black
        butExit.Location = New System.Drawing.Point(486, 0)
        butExit.Name = "butExit"
        butExit.Size = New System.Drawing.Size(75, 56)
        butExit.TabIndex = 104
        butExit.Text = "X"
        butExit.UseVisualStyleBackColor = False
        AddHandler butExit.Click, AddressOf Me.butExit_Click
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox1.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(118, 241)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(319, 258)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(223, 531)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 51)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "發送"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "回饋和建議:"
        '
        'mail
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.databaseY.My.Resources.Resources.yelloback
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(560, 701)
        Me.Controls.Add(butExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
