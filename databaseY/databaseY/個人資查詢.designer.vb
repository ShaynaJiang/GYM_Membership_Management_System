<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 個人資查詢
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cancel = New System.Windows.Forms.Button()
        Me.Labexit = New System.Windows.Forms.Label()
        Me.adress = New System.Windows.Forms.RichTextBox()
        Me.mail = New System.Windows.Forms.RichTextBox()
        Me.phone = New System.Windows.Forms.RichTextBox()
        Me.pid = New System.Windows.Forms.RichTextBox()
        Me.usrname = New System.Windows.Forms.RichTextBox()
        Me.ID = New System.Windows.Forms.RichTextBox()
        Me.Labadr = New System.Windows.Forms.Label()
        Me.labmail = New System.Windows.Forms.Label()
        Me.labgender = New System.Windows.Forms.Label()
        Me.labbir = New System.Windows.Forms.Label()
        Me.labphone = New System.Windows.Forms.Label()
        Me.labpid = New System.Windows.Forms.Label()
        Me.labname = New System.Windows.Forms.Label()
        Me.labID = New System.Windows.Forms.Label()
        Me.bir = New System.Windows.Forms.RichTextBox()
        Me.gender = New System.Windows.Forms.RichTextBox()
        butExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(681, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 48)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "個人資料"
        '
        'cancel
        '
        Me.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cancel.Font = New System.Drawing.Font("微軟正黑體", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cancel.Location = New System.Drawing.Point(716, 594)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(93, 47)
        Me.cancel.TabIndex = 48
        Me.cancel.Text = "返回"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'Labexit
        '
        Me.Labexit.AutoSize = True
        Me.Labexit.BackColor = System.Drawing.Color.Transparent
        Me.Labexit.Font = New System.Drawing.Font("微軟正黑體", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Labexit.Location = New System.Drawing.Point(1179, -75)
        Me.Labexit.Name = "Labexit"
        Me.Labexit.Size = New System.Drawing.Size(38, 40)
        Me.Labexit.TabIndex = 95
        Me.Labexit.Text = "X"
        '
        'adress
        '
        Me.adress.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.adress.Location = New System.Drawing.Point(420, 521)
        Me.adress.Multiline = False
        Me.adress.Name = "adress"
        Me.adress.ReadOnly = True
        Me.adress.Size = New System.Drawing.Size(698, 47)
        Me.adress.TabIndex = 94
        Me.adress.Text = ""
        '
        'mail
        '
        Me.mail.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.mail.Location = New System.Drawing.Point(420, 437)
        Me.mail.Multiline = False
        Me.mail.Name = "mail"
        Me.mail.ReadOnly = True
        Me.mail.Size = New System.Drawing.Size(698, 47)
        Me.mail.TabIndex = 93
        Me.mail.Text = ""
        '
        'phone
        '
        Me.phone.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.phone.Location = New System.Drawing.Point(420, 350)
        Me.phone.Multiline = False
        Me.phone.Name = "phone"
        Me.phone.ReadOnly = True
        Me.phone.Size = New System.Drawing.Size(324, 47)
        Me.phone.TabIndex = 88
        Me.phone.Text = ""
        '
        'pid
        '
        Me.pid.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.pid.Location = New System.Drawing.Point(420, 248)
        Me.pid.Multiline = False
        Me.pid.Name = "pid"
        Me.pid.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(324, 47)
        Me.pid.TabIndex = 87
        Me.pid.Text = ""
        '
        'usrname
        '
        Me.usrname.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.usrname.Location = New System.Drawing.Point(794, 154)
        Me.usrname.Multiline = False
        Me.usrname.Name = "usrname"
        Me.usrname.ReadOnly = True
        Me.usrname.Size = New System.Drawing.Size(324, 47)
        Me.usrname.TabIndex = 86
        Me.usrname.Text = ""
        '
        'ID
        '
        Me.ID.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ID.Location = New System.Drawing.Point(420, 154)
        Me.ID.Multiline = False
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Size = New System.Drawing.Size(324, 47)
        Me.ID.TabIndex = 85
        Me.ID.Text = ""
        '
        'Labadr
        '
        Me.Labadr.AutoSize = True
        Me.Labadr.BackColor = System.Drawing.Color.Transparent
        Me.Labadr.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Labadr.ForeColor = System.Drawing.Color.Black
        Me.Labadr.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Labadr.Location = New System.Drawing.Point(414, 494)
        Me.Labadr.Name = "Labadr"
        Me.Labadr.Size = New System.Drawing.Size(127, 36)
        Me.Labadr.TabIndex = 84
        Me.Labadr.Text = "通訊地址"
        '
        'labmail
        '
        Me.labmail.AutoSize = True
        Me.labmail.BackColor = System.Drawing.Color.Transparent
        Me.labmail.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labmail.ForeColor = System.Drawing.Color.Black
        Me.labmail.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.labmail.Location = New System.Drawing.Point(414, 410)
        Me.labmail.Name = "labmail"
        Me.labmail.Size = New System.Drawing.Size(127, 36)
        Me.labmail.TabIndex = 83
        Me.labmail.Text = "電子信箱"
        '
        'labgender
        '
        Me.labgender.AutoSize = True
        Me.labgender.BackColor = System.Drawing.Color.Transparent
        Me.labgender.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labgender.ForeColor = System.Drawing.Color.Black
        Me.labgender.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.labgender.Location = New System.Drawing.Point(788, 323)
        Me.labgender.Name = "labgender"
        Me.labgender.Size = New System.Drawing.Size(71, 36)
        Me.labgender.TabIndex = 82
        Me.labgender.Text = "性別"
        '
        'labbir
        '
        Me.labbir.AutoSize = True
        Me.labbir.BackColor = System.Drawing.Color.Transparent
        Me.labbir.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labbir.ForeColor = System.Drawing.Color.Black
        Me.labbir.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.labbir.Location = New System.Drawing.Point(788, 220)
        Me.labbir.Name = "labbir"
        Me.labbir.Size = New System.Drawing.Size(71, 36)
        Me.labbir.TabIndex = 81
        Me.labbir.Text = "生日"
        '
        'labphone
        '
        Me.labphone.AutoSize = True
        Me.labphone.BackColor = System.Drawing.Color.Transparent
        Me.labphone.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labphone.ForeColor = System.Drawing.Color.Black
        Me.labphone.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.labphone.Location = New System.Drawing.Point(414, 323)
        Me.labphone.Name = "labphone"
        Me.labphone.Size = New System.Drawing.Size(127, 36)
        Me.labphone.TabIndex = 78
        Me.labphone.Text = "手機號碼"
        '
        'labpid
        '
        Me.labpid.AutoSize = True
        Me.labpid.BackColor = System.Drawing.Color.Transparent
        Me.labpid.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labpid.ForeColor = System.Drawing.Color.Black
        Me.labpid.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.labpid.Location = New System.Drawing.Point(414, 221)
        Me.labpid.Name = "labpid"
        Me.labpid.Size = New System.Drawing.Size(155, 36)
        Me.labpid.TabIndex = 77
        Me.labpid.Text = "身分證字號"
        '
        'labname
        '
        Me.labname.AutoSize = True
        Me.labname.BackColor = System.Drawing.Color.Transparent
        Me.labname.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labname.ForeColor = System.Drawing.Color.Black
        Me.labname.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.labname.Location = New System.Drawing.Point(788, 127)
        Me.labname.Name = "labname"
        Me.labname.Size = New System.Drawing.Size(71, 36)
        Me.labname.TabIndex = 76
        Me.labname.Text = "姓名"
        '
        'labID
        '
        Me.labID.AutoSize = True
        Me.labID.BackColor = System.Drawing.Color.Transparent
        Me.labID.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labID.ForeColor = System.Drawing.Color.Black
        Me.labID.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.labID.Location = New System.Drawing.Point(414, 121)
        Me.labID.Name = "labID"
        Me.labID.Size = New System.Drawing.Size(71, 36)
        Me.labID.TabIndex = 75
        Me.labID.Text = "編號"
        '
        'bir
        '
        Me.bir.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.bir.Location = New System.Drawing.Point(794, 248)
        Me.bir.Multiline = False
        Me.bir.Name = "bir"
        Me.bir.ReadOnly = True
        Me.bir.Size = New System.Drawing.Size(324, 47)
        Me.bir.TabIndex = 96
        Me.bir.Text = ""
        '
        'gender
        '
        Me.gender.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gender.Location = New System.Drawing.Point(794, 350)
        Me.gender.Multiline = False
        Me.gender.Name = "gender"
        Me.gender.ReadOnly = True
        Me.gender.Size = New System.Drawing.Size(324, 47)
        Me.gender.TabIndex = 97
        Me.gender.Text = ""
        '
        'butExit
        '
        butExit.BackColor = System.Drawing.Color.Transparent
        butExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        butExit.FlatAppearance.BorderSize = 0
        butExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        butExit.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        butExit.ForeColor = System.Drawing.Color.Black
        butExit.Location = New System.Drawing.Point(1098, -2)
        butExit.Name = "butExit"
        butExit.Size = New System.Drawing.Size(75, 56)
        butExit.TabIndex = 104
        butExit.Text = "X"
        butExit.UseVisualStyleBackColor = False
        AddHandler butExit.Click, AddressOf Me.butExit_Click
        '
        '個人資查詢
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.databaseY.My.Resources.Resources.背景圖2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1170, 678)
        Me.Controls.Add(butExit)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.bir)
        Me.Controls.Add(Me.Labexit)
        Me.Controls.Add(Me.adress)
        Me.Controls.Add(Me.mail)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.usrname)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Labadr)
        Me.Controls.Add(Me.labmail)
        Me.Controls.Add(Me.labgender)
        Me.Controls.Add(Me.labbir)
        Me.Controls.Add(Me.labphone)
        Me.Controls.Add(Me.labpid)
        Me.Controls.Add(Me.labname)
        Me.Controls.Add(Me.labID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cancel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "個人資查詢"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents cancel As Button
    Friend WithEvents Labexit As Label
    Friend WithEvents adress As RichTextBox
    Friend WithEvents mail As RichTextBox
    Friend WithEvents phone As RichTextBox
    Friend WithEvents pid As RichTextBox
    Friend WithEvents usrname As RichTextBox
    Friend WithEvents ID As RichTextBox
    Friend WithEvents Labadr As Label
    Friend WithEvents labmail As Label
    Friend WithEvents labgender As Label
    Friend WithEvents labbir As Label
    Friend WithEvents labphone As Label
    Friend WithEvents labpid As Label
    Friend WithEvents labname As Label
    Friend WithEvents labID As Label
    Friend WithEvents bir As RichTextBox
    Friend WithEvents gender As RichTextBox
End Class
