Imports MySql.Data.MySqlClient
Public Class 會員註冊
    Private Sub butExit_Click(sender As Object, e As EventArgs)
        Me.Close()
        登入.Show()
    End Sub
    Private Sub UsrID_enter(sender As Object, e As EventArgs) Handles usrID.Enter
        labID.ForeColor = Color.RoyalBlue
    End Sub
    Private Sub UsrID_leave(sender As Object, e As EventArgs) Handles usrID.Leave
        labID.ForeColor = Color.Black
    End Sub
    Private Sub Name_enter(sender As Object, e As EventArgs) Handles usrname.Enter
        labname.ForeColor = Color.RoyalBlue
    End Sub
    Private Sub Name_leave(sender As Object, e As EventArgs) Handles usrname.Leave
        labname.ForeColor = Color.Black
    End Sub
    Private Sub Pid_enter(sender As Object, e As EventArgs) Handles pid.Enter
        labpid.ForeColor = Color.RoyalBlue
    End Sub
    Private Sub Pid_leave(sender As Object, e As EventArgs) Handles pid.Leave
        labpid.ForeColor = Color.Black
    End Sub
    Private Sub Pass_enter(sender As Object, e As EventArgs) Handles passwd.Enter

        ' passwd.UseSystemPasswordChar = False
        labpass.ForeColor = Color.RoyalBlue

    End Sub
    Private Sub Pass_leave(sender As Object, e As EventArgs) Handles passwd.Leave

        passwd.UseSystemPasswordChar = True

        If (passwd.Text.Length < 6) Then
            labpass.ForeColor = Color.Red
            passWarn1.Visible = True
        Else
            labpass.ForeColor = Color.Black
            passWarn1.Visible = False
        End If

    End Sub
    Private Sub Check_enter(sender As Object, e As EventArgs) Handles cheak.Enter

        ' cheak.UseSystemPasswordChar = False
        labcheck.ForeColor = Color.RoyalBlue

    End Sub
    Private Sub Check_leave(sender As Object, e As EventArgs) Handles cheak.Leave

        cheak.UseSystemPasswordChar = True

        If (cheak.Text <> passwd.Text) Then
            labcheck.ForeColor = Color.Red
            passWarn2.Visible = True
        Else
            labcheck.ForeColor = Color.Black
            passWarn2.Visible = False
        End If

    End Sub
    Private Sub Bir_enter(sender As Object, e As EventArgs) Handles bir.Enter
        labbir.ForeColor = Color.RoyalBlue
    End Sub
    Private Sub Bir_leave(sender As Object, e As EventArgs) Handles bir.Leave
        labbir.ForeColor = Color.Black
    End Sub
    Private Sub Gender_enter(sender As Object, e As EventArgs) Handles gender.Enter
        labgender.ForeColor = Color.RoyalBlue
    End Sub
    Private Sub Gender_leave(sender As Object, e As EventArgs) Handles gender.Leave
        labgender.ForeColor = Color.Black
    End Sub
    Private Sub Phone_enter(sender As Object, e As EventArgs) Handles phone.Enter
        labphone.ForeColor = Color.RoyalBlue
    End Sub
    Private Sub Phone_leave(sender As Object, e As EventArgs) Handles phone.Leave
        labphone.ForeColor = Color.Black
    End Sub
    Private Sub Mail_enter(sender As Object, e As EventArgs) Handles mail.Enter
        labmail.ForeColor = Color.RoyalBlue
    End Sub
    Private Sub Mail_leave(sender As Object, e As EventArgs) Handles mail.Leave
        labmail.ForeColor = Color.Black
    End Sub
    Private Sub Adr_enter(sender As Object, e As EventArgs) Handles adress.Enter
        Labadr.ForeColor = Color.RoyalBlue
    End Sub
    Private Sub Adr_leave(sender As Object, e As EventArgs) Handles adress.Leave
        Labadr.ForeColor = Color.Black
    End Sub
    Private Sub Sure_Click(sender As Object, e As EventArgs) Handles sure.Click

        Dim memberID As String = usrID.Text
        Dim membername As String = usrname.Text
        Dim pidd As String = pid.Text
        Dim pass As String = passwd.Text
        Dim genderr As String = gender.Text
        Dim phonee As String = phone.Text
        Dim maill As String = mail.Text
        Dim adre As String = adress.Text
        Dim selectedDate As DateTime = bir.Value
        Dim mysqlDate As String = selectedDate.ToString("yyyy-MM-dd")
        Dim SelectedValue As String = gender.SelectedItem.ToString()


        If membername.Trim().ToLower() = "membername" Or membername.Trim() = "" Then

                MessageBox.Show("Enter your name")

            ElseIf pidd.Trim() = "" Then

                MessageBox.Show("Enter your personal ID")

            ElseIf phonee.Trim() = "" Or IsNumeric(phone.Text) = False Or phonee.Trim.Length > 11 Then

                MessageBox.Show("Check your Phone Number")

            ElseIf pass.Trim().Length < 6 Or cheak.Text <> passwd.Text Then

                MessageBox.Show("Check your PassWord")

            ElseIf maill.Trim() = "" Then

                MsgBox("Enter your email")

            ElseIf genderr.Trim() = "" Then

                MsgBox("性別不得為空")

            ElseIf adre.Trim() = "" Then

                MsgBox("Enter your adress")

            ElseIf IDExist(pidd) Or IDExist(memberID) Then

                MsgBox("User has already EXIST")

            ElseIf memberID.First() = "A" Then

                Dim conn As New connection()
                Dim command As New MySqlCommand("INSERT INTO `會員`(會員帳號, 會員編號, 會員姓名, 身分證字號, 會員密碼, 出生日期, 性別, 手機號碼, 電子信箱, 通訊地址) VALUES (@log, @uid, @usr, @pid, @passwd, @bir, @gender, @phone,@mail, @adr)", conn.getConnection)
                ' Dim mysqlDate As String = selectedDate.ToString("yyyy-MM-dd")

                command.Parameters.Add("@log", MySqlDbType.VarChar).Value = memberID
                command.Parameters.Add("@uid", MySqlDbType.VarChar).Value = memberID
                command.Parameters.Add("@usr", MySqlDbType.VarChar).Value = membername
                command.Parameters.Add("@pid", MySqlDbType.VarChar).Value = pidd
                command.Parameters.Add("@passwd", MySqlDbType.VarChar).Value = pass
                command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phonee
                command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = maill
                command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = adre
                command.Parameters.AddWithValue("@bir", mysqlDate)
                command.Parameters.AddWithValue("@gender", SelectedValue)

                conn.Openconnection()

                If command.ExecuteNonQuery() = 1 Then

                    MsgBox("REGIST！")
                    conn.Closeconnection()
                    Me.Close()
                    登入.Show()
                    Return

                Else

                    MsgBox("NOT REGIST")
                    conn.Closeconnection()
                    Return

                End If
            ElseIf memberID.First() = "B" Then
                Dim conn As New connection()
                Dim command As New MySqlCommand("INSERT INTO `教練`(教練帳號, 教練編號, 教練名稱, 身分證字號, 教練密碼, 出生日期, 性別, 手機號碼, 電子信箱, 通訊地址) VALUES (@log, @uid, @usr, @pid, @passwd, @bir, @gender, @phone,@mail, @adr)", conn.getConnection)
                ' Dim mysqlDate As String = selectedDate.ToString("yyyy-MM-dd")

                command.Parameters.Add("@log", MySqlDbType.VarChar).Value = memberID
                command.Parameters.Add("@uid", MySqlDbType.VarChar).Value = memberID
                command.Parameters.Add("@usr", MySqlDbType.VarChar).Value = membername
                command.Parameters.Add("@pid", MySqlDbType.VarChar).Value = pidd
                command.Parameters.Add("@passwd", MySqlDbType.VarChar).Value = pass
                command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phonee
                command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = maill
                command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = adre
                command.Parameters.AddWithValue("@bir", mysqlDate)
                command.Parameters.AddWithValue("@gender", SelectedValue)

                conn.Openconnection()

                If command.ExecuteNonQuery() = 1 Then

                    MsgBox("REGIST！")
                    conn.Closeconnection()
                    Me.Close()
                    登入.Show()
                    Return

                Else

                    MsgBox("NOT REGIST")
                    conn.Closeconnection()
                    Return

                End If
            Else
                MessageBox.Show("Check your ID")
            End If


    End Sub
    Public Function IDExist(ByVal id As String) As Boolean

        Dim conn As New Connection()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT 會員編號, 身分證字號 FROM `會員` WHERE 會員編號 = @uid AND 身分證字號 = @pid", conn.getConnection())

        command.Parameters.Add("@uid", MySqlDbType.VarChar).Value = id
        command.Parameters.Add("@pid", MySqlDbType.VarChar).Value = id

        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

End Class