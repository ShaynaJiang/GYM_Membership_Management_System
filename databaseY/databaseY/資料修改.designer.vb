<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 資料修改
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
        Me.cancel = New System.Windows.Forms.Button()
        Me.sure = New System.Windows.Forms.Button()
        Me.bir = New System.Windows.Forms.DateTimePicker()
        Me.gender = New System.Windows.Forms.ComboBox()
        Me.adress = New System.Windows.Forms.RichTextBox()
        Me.mail = New System.Windows.Forms.RichTextBox()
        Me.phone = New System.Windows.Forms.RichTextBox()
        Me.pid = New System.Windows.Forms.RichTextBox()
        Me.usrname = New System.Windows.Forms.RichTextBox()
        Me.Labadr = New System.Windows.Forms.Label()
        Me.labmail = New System.Windows.Forms.Label()
        Me.labgender = New System.Windows.Forms.Label()
        Me.labbir = New System.Windows.Forms.Label()
        Me.labphone = New System.Windows.Forms.Label()
        Me.labpid = New System.Windows.Forms.Label()
        Me.labname = New System.Windows.Forms.Label()
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
        butExit.Location = New System.Drawing.Point(1097, -2)
        butExit.Name = "butExit"
        butExit.Size = New System.Drawing.Size(75, 56)
        butExit.TabIndex = 103
        butExit.Text = "X"
        butExit.UseVisualStyleBackColor = False
        AddHandler butExit.Click, AddressOf Me.butExit_Click
        '
        'cancel
        '
        Me.cancel.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cancel.Location = New System.Drawing.Point(370, 564)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(101, 44)
        Me.cancel.TabIndex = 99
        Me.cancel.Text = "取消"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'sure
        '
        Me.sure.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.sure.Location = New System.Drawing.Point(675, 564)
        Me.sure.Name = "sure"
        Me.sure.Size = New System.Drawing.Size(101, 44)
        Me.sure.TabIndex = 98
        Me.sure.Text = "確認"
        Me.sure.UseVisualStyleBackColor = True
        '
        'bir
        '
        Me.bir.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.bir.Location = New System.Drawing.Point(64, 365)
        Me.bir.Name = "bir"
        Me.bir.Size = New System.Drawing.Size(261, 45)
        Me.bir.TabIndex = 94
        '
        'gender
        '
        Me.gender.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gender.FormattingEnabled = True
        Me.gender.Items.AddRange(New Object() {"女性", "男性", "其他"})
        Me.gender.Location = New System.Drawing.Point(331, 365)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(213, 43)
        Me.gender.TabIndex = 95
        '
        'adress
        '
        Me.adress.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.adress.Location = New System.Drawing.Point(64, 466)
        Me.adress.Multiline = False
        Me.adress.Name = "adress"
        Me.adress.Size = New System.Drawing.Size(480, 47)
        Me.adress.TabIndex = 97
        Me.adress.Text = ""
        '
        'mail
        '
        Me.mail.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.mail.Location = New System.Drawing.Point(626, 462)
        Me.mail.Multiline = False
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(480, 47)
        Me.mail.TabIndex = 96
        Me.mail.Text = ""
        '
        'phone
        '
        Me.phone.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.phone.Location = New System.Drawing.Point(626, 365)
        Me.phone.Multiline = False
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(480, 47)
        Me.phone.TabIndex = 91
        Me.phone.Text = ""
        '
        'pid
        '
        Me.pid.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.pid.Location = New System.Drawing.Point(64, 267)
        Me.pid.Multiline = False
        Me.pid.Name = "pid"
        Me.pid.Size = New System.Drawing.Size(480, 47)
        Me.pid.TabIndex = 90
        Me.pid.Text = ""
        '
        'usrname
        '
        Me.usrname.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.usrname.Location = New System.Drawing.Point(626, 269)
        Me.usrname.Multiline = False
        Me.usrname.Name = "usrname"
        Me.usrname.Size = New System.Drawing.Size(480, 47)
        Me.usrname.TabIndex = 89
        Me.usrname.Text = ""
        '
        'Labadr
        '
        Me.Labadr.AutoSize = True
        Me.Labadr.BackColor = System.Drawing.Color.Transparent
        Me.Labadr.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Labadr.ForeColor = System.Drawing.Color.Black
        Me.Labadr.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Labadr.Location = New System.Drawing.Point(58, 440)
        Me.Labadr.Name = "Labadr"
        Me.Labadr.Size = New System.Drawing.Size(127, 36)
        Me.Labadr.TabIndex = 87
        Me.Labadr.Text = "通訊地址"
        '
        'labmail
        '
        Me.labmail.AutoSize = True
        Me.labmail.BackColor = System.Drawing.Color.Transparent
        Me.labmail.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labmail.ForeColor = System.Drawing.Color.Black
        Me.labmail.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.labmail.Location = New System.Drawing.Point(620, 436)
        Me.labmail.Name = "labmail"
        Me.labmail.Size = New System.Drawing.Size(127, 36)
        Me.labmail.TabIndex = 86
        Me.labmail.Text = "電子信箱"
        '
        'labgender
        '
        Me.labgender.AutoSize = True
        Me.labgender.BackColor = System.Drawing.Color.Transparent
        Me.labgender.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labgender.ForeColor = System.Drawing.Color.Black
        Me.labgender.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.labgender.Location = New System.Drawing.Point(325, 335)
        Me.labgender.Name = "labgender"
        Me.labgender.Size = New System.Drawing.Size(71, 36)
        Me.labgender.TabIndex = 85
        Me.labgender.Text = "性別"
        '
        'labbir
        '
        Me.labbir.AutoSize = True
        Me.labbir.BackColor = System.Drawing.Color.Transparent
        Me.labbir.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labbir.ForeColor = System.Drawing.Color.Black
        Me.labbir.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.labbir.Location = New System.Drawing.Point(58, 335)
        Me.labbir.Name = "labbir"
        Me.labbir.Size = New System.Drawing.Size(71, 36)
        Me.labbir.TabIndex = 84
        Me.labbir.Text = "生日"
        '
        'labphone
        '
        Me.labphone.AutoSize = True
        Me.labphone.BackColor = System.Drawing.Color.Transparent
        Me.labphone.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labphone.ForeColor = System.Drawing.Color.Black
        Me.labphone.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.labphone.Location = New System.Drawing.Point(620, 338)
        Me.labphone.Name = "labphone"
        Me.labphone.Size = New System.Drawing.Size(127, 36)
        Me.labphone.TabIndex = 81
        Me.labphone.Text = "手機號碼"
        '
        'labpid
        '
        Me.labpid.AutoSize = True
        Me.labpid.BackColor = System.Drawing.Color.Transparent
        Me.labpid.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labpid.ForeColor = System.Drawing.Color.Black
        Me.labpid.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.labpid.Location = New System.Drawing.Point(58, 240)
        Me.labpid.Name = "labpid"
        Me.labpid.Size = New System.Drawing.Size(155, 36)
        Me.labpid.TabIndex = 80
        Me.labpid.Text = "身分證字號"
        '
        'labname
        '
        Me.labname.AutoSize = True
        Me.labname.BackColor = System.Drawing.Color.Transparent
        Me.labname.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labname.ForeColor = System.Drawing.Color.Black
        Me.labname.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.labname.Location = New System.Drawing.Point(620, 236)
        Me.labname.Name = "labname"
        Me.labname.Size = New System.Drawing.Size(71, 36)
        Me.labname.TabIndex = 79
        Me.labname.Text = "姓名"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label1.Location = New System.Drawing.Point(494, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 50)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "資料修改"
        '
        '資料修改
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.databaseY.My.Resources.Resources.背景3
        Me.ClientSize = New System.Drawing.Size(1170, 678)
        Me.Controls.Add(butExit)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.sure)
        Me.Controls.Add(Me.bir)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.adress)
        Me.Controls.Add(Me.mail)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.usrname)
        Me.Controls.Add(Me.Labadr)
        Me.Controls.Add(Me.labmail)
        Me.Controls.Add(Me.labgender)
        Me.Controls.Add(Me.labbir)
        Me.Controls.Add(Me.labphone)
        Me.Controls.Add(Me.labpid)
        Me.Controls.Add(Me.labname)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "資料修改"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "資料修改"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cancel As Button
    Friend WithEvents sure As Button
    Friend WithEvents bir As DateTimePicker
    Friend WithEvents gender As ComboBox
    Friend WithEvents adress As RichTextBox
    Friend WithEvents mail As RichTextBox
    Friend WithEvents phone As RichTextBox
    Friend WithEvents pid As RichTextBox
    Friend WithEvents usrname As RichTextBox
    Friend WithEvents Labadr As Label
    Friend WithEvents labmail As Label
    Friend WithEvents labgender As Label
    Friend WithEvents labbir As Label
    Friend WithEvents labphone As Label
    Friend WithEvents labpid As Label
    Friend WithEvents labname As Label
    Friend WithEvents Label1 As Label
End Class
