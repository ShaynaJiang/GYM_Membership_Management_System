Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class 資料修改
    Private Sub butExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
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

        Dim membername As String = usrname.Text
        Dim pidd As String = pid.Text
        ' Dim pass As String = passwd.Text
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

        ElseIf maill.Trim() = "" Then

            MsgBox("Enter your email")

        ElseIf adre.Trim() = "" Then

            MsgBox("Enter your adress")

        ElseIf 登入.TextBox1.Text.First() = "A" Then
            Dim conn As New Connection()
            Dim updateQuery = "UPDATE 會員 SET 會員姓名 = @usr, 身分證字號 = @pid, 出生日期 = @bir, 性別 = @gender, 手機號碼 = @phone, 電子信箱 = @mail, 通訊地址 = @adr WHERE 會員編號 = @uid"
            Dim table As New DataTable()
            Dim command As New MySqlCommand(updateQuery, conn.getConnection)
            command.Parameters.Add("@uid", MySqlDbType.VarChar).Value = 登入.TextBox1.Text
            command.Parameters.Add("@usr", MySqlDbType.VarChar).Value = membername
            command.Parameters.Add("@pid", MySqlDbType.VarChar).Value = pidd
            ' command.Parameters.Add("@passwd", MySqlDbType.VarChar).Value = pass
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phonee
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = maill
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = adre
            command.Parameters.AddWithValue("@bir", mysqlDate)
            command.Parameters.AddWithValue("@gender", SelectedValue)

            conn.OpenConnection()

            If command.ExecuteNonQuery() = 1 Then

                MsgBox("修改成功！")
                conn.CloseConnection()
                Return

            Else

                MsgBox("修改失敗")
                conn.CloseConnection()
                Return

            End If

        ElseIf 登入.TextBox1.Text.First() = "B" Then

            Dim conn As New Connection()
            Dim updateQuery = "UPDATE 教練 SET 教練名稱 = @usr, 身分證字號 = @pid, 出生日期 = @bir, 性別 = @gender, 手機號碼 = @phone, 電子信箱 = @mail, 通訊地址 = @adr WHERE 會員編號 = @uid"
            Dim table As New DataTable()
            Dim command As New MySqlCommand(updateQuery, conn.getConnection)
            command.Parameters.Add("@uid", MySqlDbType.VarChar).Value = 登入.TextBox1.Text
            command.Parameters.Add("@usr", MySqlDbType.VarChar).Value = membername
            command.Parameters.Add("@pid", MySqlDbType.VarChar).Value = pidd
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phonee
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = maill
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = adre
            command.Parameters.AddWithValue("@bir", mysqlDate)
            command.Parameters.AddWithValue("@gender", SelectedValue)

            conn.OpenConnection()

            If command.ExecuteNonQuery() = 1 Then

                MsgBox("修改成功！")
                conn.CloseConnection()
                Return

            Else

                MsgBox("修改失敗")
                conn.CloseConnection()
                Return

            End If

        End If
    End Sub


End Class