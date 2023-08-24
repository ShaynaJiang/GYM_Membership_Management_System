Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports Microsoft.Win32

Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class 登入
    Public Shared temp As String
    Public Shared islogin As Boolean = False

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.DarkGray
        Button1.ForeColor = Color.Gray
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Transparent
        Button1.ForeColor = Color.White
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter

        Dim username As String = TextBox1.Text
        If username.Trim().ToLower = "username" Or username.Trim() = "" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.White
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        Dim username As String = TextBox1.Text
        If username.Trim().ToLower = "username" Or username.Trim() = "" Then
            TextBox1.Text = "username"
            TextBox1.ForeColor = Color.White

        End If
    End Sub

    Private Sub Pass_Enter(sender As Object, e As EventArgs) Handles Pass.Enter
        Dim password As String = Pass.Text
        If password.Trim().ToLower = "password" Or password.Trim() = "" Then
            Pass.UseSystemPasswordChar = False
            Pass.Text = ""
            Pass.ForeColor = Color.White

        End If
    End Sub

    Private Sub Pass_Leave(sender As Object, e As EventArgs) Handles Pass.Leave
        Dim password As String = Pass.Text
        If password.Trim().ToLower = "password" Or password.Trim() = "" Then
            Pass.Text = "password"
            Pass.ForeColor = Color.White
            Pass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        Dim brightness As Single = 2
        Dim originalImage As Image = PictureBox1.Image
        Dim lightImage As New Bitmap(originalImage.Width, originalImage.Height)
        Using g As Graphics = Graphics.FromImage(lightImage)
            Dim cm As New Imaging.ColorMatrix(New Single()() _
                            {
                                New Single() {brightness, 0, 0, 0, 0},
                                New Single() {0, brightness, 0, 0, 0},
                                New Single() {0, 0, brightness, 0, 0},
                                New Single() {0, 0, 0, 1, 0},
                                New Single() {0, 0, 0, 0, 1}
                            })

            Dim attributes As New Imaging.ImageAttributes()
            attributes.SetColorMatrix(cm)
            g.DrawImage(originalImage,
                        New Rectangle(0, 0, originalImage.Width, originalImage.Height),
                        0, 0, originalImage.Width, originalImage.Height,
                        GraphicsUnit.Pixel, attributes)
        End Using
        PictureBox1.Image = lightImage
    End Sub
    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.LOGin_button
    End Sub

    Private Sub Label1__MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.Font = New Font(Label1.Font, FontStyle.Underline)
    End Sub

    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.Font = New Font(Label1.Font, FontStyle.Regular)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim con As New connection
        Dim userAdapter As New MySqlDataAdapter()
        Dim coachAdapter As New MySqlDataAdapter()
        Dim userTable As New DataTable()
        Dim coachTable As New DataTable()
        Dim userCommand As New MySqlCommand("SELECT `會員帳號`, `會員密碼` FROM `會員` WHERE `會員帳號` = @usn AND `會員密碼` = @pass", con.getConnection())
        Dim coachCommand As New MySqlCommand("SELECT `教練帳號`, `教練密碼` FROM `教練` WHERE `教練帳號` = @csn AND `教練密碼` = @cpass", con.getConnection())

        userAdapter.SelectCommand = userCommand
        userCommand.Parameters.Clear()
        userCommand.Parameters.Add("@usn", MySqlDbType.String).Value = TextBox1.Text
        userCommand.Parameters.Add("@pass", MySqlDbType.String).Value = Pass.Text
        userTable.Clear()
        userAdapter.Fill(userTable)

        coachAdapter.SelectCommand = coachCommand
        coachCommand.Parameters.Clear()
        coachCommand.Parameters.Add("@csn", MySqlDbType.VarChar).Value = TextBox1.Text
        coachCommand.Parameters.Add("@cpass", MySqlDbType.VarChar).Value = Pass.Text
        coachTable.Clear()
        coachAdapter.Fill(coachTable)

        If TextBox1.Text.Trim().ToLower() = "username" Or TextBox1.Text.Trim() = "" Then
            MessageBox.Show("請輸入帳號", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Pass.Text.Trim() = "" Or Pass.Text.Trim().ToLower() = "password" Then
            MessageBox.Show("請輸入密碼", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf userTable.Rows.Count = 1 Then
            If userTable.Rows(0)("會員密碼").ToString() = Pass.Text.Trim() Then
                MessageBox.Show("登入", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
                temp = TextBox1.Text
                Form2.Show()
                Me.Hide()
            ElseIf userTable.Rows.Count = 0 Then
                MessageBox.Show("密碼不正確", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf coachTable.Rows.Count = 1 Then
            MessageBox.Show("登入", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
            temp = TextBox1.Text
            Form3.Show()
            Me.Hide()
        Else
            Dim result As DialogResult = MessageBox.Show("使用者不存在，是否要註冊新帳號？", "註冊", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Me.Hide()
                會員註冊.Show()

            End If
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        會員註冊.Show()
    End Sub


End Class
