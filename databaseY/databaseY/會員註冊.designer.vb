<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 會員註冊
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labID = New System.Windows.Forms.Label()
        Me.labname = New System.Windows.Forms.Label()
        Me.labpid = New System.Windows.Forms.Label()
        Me.labphone = New System.Windows.Forms.Label()
        Me.labpass = New System.Windows.Forms.Label()
        Me.labcheck = New System.Windows.Forms.Label()
        Me.labbir = New System.Windows.Forms.Label()
        Me.labgender = New System.Windows.Forms.Label()
        Me.labmail = New System.Windows.Forms.Label()
        Me.Labadr = New System.Windows.Forms.Label()
        Me.usrID = New System.Windows.Forms.RichTextBox()
        Me.usrname = New System.Windows.Forms.RichTextBox()
        Me.pid = New System.Windows.Forms.RichTextBox()
        Me.phone = New System.Windows.Forms.RichTextBox()
        Me.mail = New System.Windows.Forms.RichTextBox()
        Me.adress = New System.Windows.Forms.RichTextBox()
        Me.gender = New System.Windows.Forms.ComboBox()
        Me.bir = New System.Windows.Forms.DateTimePicker()
        Me.cancel = New System.Windows.Forms.Button()
        Me.sure = New System.Windows.Forms.Button()
        Me.passWarn1 = New System.Windows.Forms.Label()
        Me.passWarn2 = New System.Windows.Forms.Label()
        Me.passwd = New System.Windows.Forms.TextBox()
        Me.cheak = New System.Windows.Forms.TextBox()
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
        butExit.Location = New System.Drawing.Point(1095, -3)
        butExit.Name = "butExit"
        butExit.Size = New System.Drawing.Size(75, 56)
        butExit.TabIndex = 104
        butExit.Text = "X"
        butExit.UseVisualStyleBackColor = False
        AddHandler butExit.Click, AddressOf Me.butExit_Click
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label1.Location = New System.Drawing.Point(502, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "會員註冊"
        '
        'labID
        '
        Me.labID.AutoSize = True
        Me.labID.BackColor = System.Drawing.Color.Transparent
        Me.labID.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labID.ForeColor = System.Drawing.Color.Black
        Me.labID.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.labID.Location = New System.Drawing.Point(61, 230)
        Me.labID.Name = "labID"
        Me.labID.Size = New System.Drawing.Size(127, 36)
        Me.labID.TabIndex = 1
        Me.labID.Text = "會員編號"
        '
        'labname
        '
        Me.labname.AutoSize = True
        Me.labname.BackColor = System.Drawing.Color.Transparent
        Me.labname.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labname.ForeColor = System.Drawing.Color.Black
        Me.labname.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.labname.Location = New System.Drawing.Point(620, 230)
        Me.labname.Name = "labname"
        Me.labname.Size = New System.Drawing.Size(127, 36)
        Me.labname.TabIndex = 2
        Me.labname.Text = "會員姓名"
        '
        'labpid
        '
        Me.labpid.AutoSize = True
        Me.labpid.BackColor = System.Drawing.Color.Transparent
        Me.labpid.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labpid.ForeColor = System.Drawing.Color.Black
        Me.labpid.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.labpid.Location = New System.Drawing.Point(61, 313)
        Me.labpid.Name = "labpid"
        Me.labpid.Size = New System.Drawing.Size(155, 36)
        Me.labpid.TabIndex = 3
        Me.labpid.Text = "身分證字號"
        '
        'labphone
        '
        Me.labphone.AutoSize = True
        Me.labphone.BackColor = System.Drawing.Color.Transparent
        Me.labphone.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labphone.ForeColor = System.Drawing.Color.Black
        Me.labphone.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.labphone.Location = New System.Drawing.Point(620, 313)
        Me.labphone.Name = "labphone"
        Me.labphone.Size = New System.Drawing.Size(127, 36)
        Me.labphone.TabIndex = 4
        Me.labphone.Text = "手機號碼"
        '
        'labpass
        '
        Me.labpass.AutoSize = True
        Me.labpass.BackColor = System.Drawing.Color.Transparent
        Me.labpass.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labpass.ForeColor = System.Drawing.Color.Black
        Me.labpass.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.labpass.Location = New System.Drawing.Point(61, 388)
        Me.labpass.Name = "labpass"
        Me.labpass.Size = New System.Drawing.Size(71, 36)
        Me.labpass.TabIndex = 5
        Me.labpass.Text = "密碼"
        '
        'labcheck
        '
        Me.labcheck.AutoSize = True
        Me.labcheck.BackColor = System.Drawing.Color.Transparent
        Me.labcheck.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labcheck.ForeColor = System.Drawing.Color.Black
        Me.labcheck.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.labcheck.Location = New System.Drawing.Point(620, 388)
        Me.labcheck.Name = "labcheck"
        Me.labcheck.Size = New System.Drawing.Size(127, 36)
        Me.labcheck.TabIndex = 6
        Me.labcheck.Text = "確認密碼"
        '
        'labbir
        '
        Me.labbir.AutoSize = True
        Me.labbir.BackColor = System.Drawing.Color.Transparent
        Me.labbir.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labbir.ForeColor = System.Drawing.Color.Black
        Me.labbir.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.labbir.Location = New System.Drawing.Point(61, 474)
        Me.labbir.Name = "labbir"
        Me.labbir.Size = New System.Drawing.Size(71, 36)
        Me.labbir.TabIndex = 7
        Me.labbir.Text = "生日"
        '
        'labgender
        '
        Me.labgender.AutoSize = True
        Me.labgender.BackColor = System.Drawing.Color.Transparent
        Me.labgender.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labgender.ForeColor = System.Drawing.Color.Black
        Me.labgender.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.labgender.Location = New System.Drawing.Point(328, 474)
        Me.labgender.Name = "labgender"
        Me.labgender.Size = New System.Drawing.Size(71, 36)
        Me.labgender.TabIndex = 8
        Me.labgender.Text = "性別"
        '
        'labmail
        '
        Me.labmail.AutoSize = True
        Me.labmail.BackColor = System.Drawing.Color.Transparent
        Me.labmail.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labmail.ForeColor = System.Drawing.Color.Black
        Me.labmail.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.labmail.Location = New System.Drawing.Point(620, 474)
        Me.labmail.Name = "labmail"
        Me.labmail.Size = New System.Drawing.Size(127, 36)
        Me.labmail.TabIndex = 9
        Me.labmail.Text = "電子信箱"
        '
        'Labadr
        '
        Me.Labadr.AutoSize = True
        Me.Labadr.BackColor = System.Drawing.Color.Transparent
        Me.Labadr.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Labadr.ForeColor = System.Drawing.Color.Black
        Me.Labadr.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Labadr.Location = New System.Drawing.Point(61, 557)
        Me.Labadr.Name = "Labadr"
        Me.Labadr.Size = New System.Drawing.Size(127, 36)
        Me.Labadr.TabIndex = 10
        Me.Labadr.Text = "通訊地址"
        '
        'usrID
        '
        Me.usrID.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.usrID.Location = New System.Drawing.Point(67, 263)
        Me.usrID.Multiline = False
        Me.usrID.Name = "usrID"
        Me.usrID.Size = New System.Drawing.Size(480, 47)
        Me.usrID.TabIndex = 11
        Me.usrID.Text = ""
        '
        'usrname
        '
        Me.usrname.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.usrname.Location = New System.Drawing.Point(626, 263)
        Me.usrname.Multiline = False
        Me.usrname.Name = "usrname"
        Me.usrname.Size = New System.Drawing.Size(480, 47)
        Me.usrname.TabIndex = 12
        Me.usrname.Text = ""
        '
        'pid
        '
        Me.pid.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.pid.Location = New System.Drawing.Point(67, 340)
        Me.pid.Multiline = False
        Me.pid.Name = "pid"
        Me.pid.Size = New System.Drawing.Size(480, 47)
        Me.pid.TabIndex = 13
        Me.pid.Text = ""
        '
        'phone
        '
        Me.phone.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.phone.Location = New System.Drawing.Point(626, 340)
        Me.phone.Multiline = False
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(480, 47)
        Me.phone.TabIndex = 14
        Me.phone.Text = ""
        '
        'mail
        '
        Me.mail.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.mail.Location = New System.Drawing.Point(626, 500)
        Me.mail.Multiline = False
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(480, 47)
        Me.mail.TabIndex = 19
        Me.mail.Text = ""
        '
        'adress
        '
        Me.adress.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.adress.Location = New System.Drawing.Point(67, 583)
        Me.adress.Multiline = False
        Me.adress.Name = "adress"
        Me.adress.Size = New System.Drawing.Size(480, 47)
        Me.adress.TabIndex = 20
        Me.adress.Text = ""
        '
        'gender
        '
        Me.gender.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gender.FormattingEnabled = True
        Me.gender.Items.AddRange(New Object() {"女性", "男性", "其他"})
        Me.gender.Location = New System.Drawing.Point(334, 504)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(213, 43)
        Me.gender.TabIndex = 18
        '
        'bir
        '
        Me.bir.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.bir.Location = New System.Drawing.Point(67, 504)
        Me.bir.Name = "bir"
        Me.bir.Size = New System.Drawing.Size(261, 45)
        Me.bir.TabIndex = 17
        '
        'cancel
        '
        Me.cancel.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cancel.Location = New System.Drawing.Point(626, 583)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(101, 44)
        Me.cancel.TabIndex = 73
        Me.cancel.Text = "取消"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'sure
        '
        Me.sure.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.sure.Location = New System.Drawing.Point(1005, 583)
        Me.sure.Name = "sure"
        Me.sure.Size = New System.Drawing.Size(101, 44)
        Me.sure.TabIndex = 72
        Me.sure.Text = "確認"
        Me.sure.UseVisualStyleBackColor = True
        '
        'passWarn1
        '
        Me.passWarn1.AutoSize = True
        Me.passWarn1.BackColor = System.Drawing.Color.Transparent
        Me.passWarn1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.passWarn1.ForeColor = System.Drawing.Color.Red
        Me.passWarn1.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.passWarn1.Location = New System.Drawing.Point(285, 392)
        Me.passWarn1.Name = "passWarn1"
        Me.passWarn1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.passWarn1.Size = New System.Drawing.Size(267, 30)
        Me.passWarn1.TabIndex = 75
        Me.passWarn1.Text = "6位數字且為英文或數字"
        Me.passWarn1.Visible = False
        '
        'passWarn2
        '
        Me.passWarn2.AutoSize = True
        Me.passWarn2.BackColor = System.Drawing.Color.Transparent
        Me.passWarn2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.passWarn2.ForeColor = System.Drawing.Color.Red
        Me.passWarn2.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.passWarn2.Location = New System.Drawing.Point(930, 392)
        Me.passWarn2.Name = "passWarn2"
        Me.passWarn2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.passWarn2.Size = New System.Drawing.Size(181, 30)
        Me.passWarn2.TabIndex = 76
        Me.passWarn2.Text = "確認密碼不正確"
        Me.passWarn2.Visible = False
        '
        'passwd
        '
        Me.passwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.passwd.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.passwd.Location = New System.Drawing.Point(67, 416)
        Me.passwd.Name = "passwd"
        Me.passwd.Size = New System.Drawing.Size(480, 55)
        Me.passwd.TabIndex = 15
        '
        'cheak
        '
        Me.cheak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cheak.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cheak.Location = New System.Drawing.Point(626, 416)
        Me.cheak.Name = "cheak"
        Me.cheak.Size = New System.Drawing.Size(480, 55)
        Me.cheak.TabIndex = 16
        '
        '會員註冊
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackgroundImage = Global.databaseY.My.Resources.Resources.背景圖11
        Me.ClientSize = New System.Drawing.Size(1170, 678)
        Me.Controls.Add(butExit)
        Me.Controls.Add(Me.cheak)
        Me.Controls.Add(Me.passwd)
        Me.Controls.Add(Me.passWarn2)
        Me.Controls.Add(Me.passWarn1)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.sure)
        Me.Controls.Add(Me.bir)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.adress)
        Me.Controls.Add(Me.mail)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.usrname)
        Me.Controls.Add(Me.usrID)
        Me.Controls.Add(Me.Labadr)
        Me.Controls.Add(Me.labmail)
        Me.Controls.Add(Me.labgender)
        Me.Controls.Add(Me.labbir)
        Me.Controls.Add(Me.labcheck)
        Me.Controls.Add(Me.labpass)
        Me.Controls.Add(Me.labphone)
        Me.Controls.Add(Me.labpid)
        Me.Controls.Add(Me.labname)
        Me.Controls.Add(Me.labID)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "會員註冊"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents labID As Label
    Friend WithEvents labname As Label
    Friend WithEvents labpid As Label
    Friend WithEvents labphone As Label
    Friend WithEvents labpass As Label
    Friend WithEvents labcheck As Label
    Friend WithEvents labbir As Label
    Friend WithEvents labgender As Label
    Friend WithEvents labmail As Label
    Friend WithEvents Labadr As Label
    Friend WithEvents usrID As RichTextBox
    Friend WithEvents usrname As RichTextBox
    Friend WithEvents pid As RichTextBox
    Friend WithEvents phone As RichTextBox
    Friend WithEvents mail As RichTextBox
    Friend WithEvents adress As RichTextBox
    Friend WithEvents gender As ComboBox
    Friend WithEvents bir As DateTimePicker
    Friend WithEvents cancel As Button
    Friend WithEvents sure As Button
    Friend WithEvents passWarn1 As Label
    Friend WithEvents passWarn2 As Label
    Friend WithEvents passwd As TextBox
    Friend WithEvents cheak As TextBox
End Class
