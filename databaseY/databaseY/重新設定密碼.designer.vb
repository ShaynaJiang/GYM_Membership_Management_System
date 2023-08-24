<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 重新設定密碼
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim butExit As System.Windows.Forms.Button
        Me.oldpass = New System.Windows.Forms.RichTextBox()
        Me.Labold = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Labagain = New System.Windows.Forms.Label()
        Me.Labnew = New System.Windows.Forms.Label()
        Me.sure = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.passWarn2 = New System.Windows.Forms.Label()
        Me.passWarn1 = New System.Windows.Forms.Label()
        Me.cheak = New System.Windows.Forms.TextBox()
        Me.passwd = New System.Windows.Forms.TextBox()
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
        butExit.Location = New System.Drawing.Point(1099, -2)
        butExit.Name = "butExit"
        butExit.Size = New System.Drawing.Size(75, 56)
        butExit.TabIndex = 107
        butExit.Text = "X"
        butExit.UseVisualStyleBackColor = False
        AddHandler butExit.Click, AddressOf Me.butExit_Click
        '
        'oldpass
        '
        Me.oldpass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.oldpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.oldpass.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.oldpass.Location = New System.Drawing.Point(659, 163)
        Me.oldpass.Multiline = False
        Me.oldpass.Name = "oldpass"
        Me.oldpass.Size = New System.Drawing.Size(312, 55)
        Me.oldpass.TabIndex = 66
        Me.oldpass.Text = ""
        '
        'Labold
        '
        Me.Labold.BackColor = System.Drawing.Color.Transparent
        Me.Labold.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Labold.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Labold.Location = New System.Drawing.Point(488, 173)
        Me.Labold.Name = "Labold"
        Me.Labold.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Labold.Size = New System.Drawing.Size(165, 45)
        Me.Labold.TabIndex = 63
        Me.Labold.Text = "舊密碼"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(650, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(264, 50)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "重新設定密碼"
        '
        'Labagain
        '
        Me.Labagain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Labagain.BackColor = System.Drawing.Color.Transparent
        Me.Labagain.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Labagain.Location = New System.Drawing.Point(347, 410)
        Me.Labagain.Name = "Labagain"
        Me.Labagain.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Labagain.Size = New System.Drawing.Size(306, 45)
        Me.Labagain.TabIndex = 66
        Me.Labagain.Text = "再次輸入新密碼"
        '
        'Labnew
        '
        Me.Labnew.BackColor = System.Drawing.Color.Transparent
        Me.Labnew.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Labnew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Labnew.Location = New System.Drawing.Point(478, 293)
        Me.Labnew.Name = "Labnew"
        Me.Labnew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Labnew.Size = New System.Drawing.Size(175, 46)
        Me.Labnew.TabIndex = 68
        Me.Labnew.Text = "新密碼"
        '
        'sure
        '
        Me.sure.Font = New System.Drawing.Font("微軟正黑體", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.sure.Location = New System.Drawing.Point(896, 533)
        Me.sure.Name = "sure"
        Me.sure.Size = New System.Drawing.Size(101, 54)
        Me.sure.TabIndex = 70
        Me.sure.Text = "確認"
        Me.sure.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Font = New System.Drawing.Font("微軟正黑體", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cancel.Location = New System.Drawing.Point(585, 533)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(101, 54)
        Me.cancel.TabIndex = 71
        Me.cancel.Text = "取消"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'passWarn2
        '
        Me.passWarn2.AutoSize = True
        Me.passWarn2.BackColor = System.Drawing.Color.Transparent
        Me.passWarn2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.passWarn2.ForeColor = System.Drawing.Color.Red
        Me.passWarn2.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.passWarn2.Location = New System.Drawing.Point(795, 378)
        Me.passWarn2.Name = "passWarn2"
        Me.passWarn2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.passWarn2.Size = New System.Drawing.Size(181, 30)
        Me.passWarn2.TabIndex = 103
        Me.passWarn2.Text = "確認密碼不正確"
        Me.passWarn2.Visible = False
        '
        'passWarn1
        '
        Me.passWarn1.AutoSize = True
        Me.passWarn1.BackColor = System.Drawing.Color.Transparent
        Me.passWarn1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.passWarn1.ForeColor = System.Drawing.Color.Red
        Me.passWarn1.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.passWarn1.Location = New System.Drawing.Point(709, 261)
        Me.passWarn1.Name = "passWarn1"
        Me.passWarn1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.passWarn1.Size = New System.Drawing.Size(267, 30)
        Me.passWarn1.TabIndex = 104
        Me.passWarn1.Text = "6位數字且為英文或數字"
        Me.passWarn1.Visible = False
        '
        'cheak
        '
        Me.cheak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cheak.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cheak.Location = New System.Drawing.Point(659, 400)
        Me.cheak.Name = "cheak"
        Me.cheak.Size = New System.Drawing.Size(312, 55)
        Me.cheak.TabIndex = 68
        '
        'passwd
        '
        Me.passwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.passwd.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.passwd.Location = New System.Drawing.Point(659, 284)
        Me.passwd.Name = "passwd"
        Me.passwd.Size = New System.Drawing.Size(312, 55)
        Me.passwd.TabIndex = 67
        '
        '重新設定密碼
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.databaseY.My.Resources.Resources.背景圖
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1170, 678)
        Me.Controls.Add(butExit)
        Me.Controls.Add(Me.passwd)
        Me.Controls.Add(Me.cheak)
        Me.Controls.Add(Me.passWarn1)
        Me.Controls.Add(Me.passWarn2)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.sure)
        Me.Controls.Add(Me.Labnew)
        Me.Controls.Add(Me.Labagain)
        Me.Controls.Add(Me.oldpass)
        Me.Controls.Add(Me.Labold)
        Me.Controls.Add(Me.Label6)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "重新設定密碼"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents oldpass As RichTextBox
    Friend WithEvents Labold As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Labagain As Label
    Friend WithEvents Labnew As Label
    Friend WithEvents sure As Button
    Friend WithEvents cancel As Button
    Friend WithEvents passWarn2 As Label
    Friend WithEvents passWarn1 As Label
    Friend WithEvents cheak As TextBox
    Friend WithEvents passwd As TextBox
End Class
