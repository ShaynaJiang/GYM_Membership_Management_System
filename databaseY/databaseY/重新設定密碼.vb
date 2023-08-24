Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports MySql.Data.MySqlClient
Public Class 重新設定密碼
    Private Sub butExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub
    Private Sub Old_enter(sender As Object, e As EventArgs) Handles oldpass.Enter
        Labold.ForeColor = Color.RoyalBlue
    End Sub
    Private Sub Old_leave(sender As Object, e As EventArgs) Handles oldpass.Leave
        Labold.ForeColor = Color.Black
    End Sub
    Private Sub Pass_enter(sender As Object, e As EventArgs) Handles passwd.Enter

        ' passwd.UseSystemPasswordChar = False
        Labnew.ForeColor = Color.RoyalBlue

    End Sub
    Private Sub Pass_leave(sender As Object, e As EventArgs) Handles passwd.Leave

        passwd.UseSystemPasswordChar = True

        If (passwd.Text.Length < 6) Then
            Labnew.ForeColor = Color.Red
            passWarn1.Visible = True
        Else
            Labnew.ForeColor = Color.Black
            passWarn1.Visible = False
        End If

    End Sub
    Private Sub Check_enter(sender As Object, e As EventArgs) Handles cheak.Enter

        ' cheak.UseSystemPasswordChar = False
        Labagain.ForeColor = Color.RoyalBlue

    End Sub
    Private Sub Check_leave(sender As Object, e As EventArgs) Handles cheak.Leave

        cheak.UseSystemPasswordChar = True

        If (cheak.Text <> passwd.Text) Then
            Labagain.ForeColor = Color.Red
            passWarn2.Visible = True
        Else
            Labagain.ForeColor = Color.Black
            passWarn2.Visible = False
        End If

    End Sub
    Private Sub Sure_Click(sender As Object, e As EventArgs) Handles sure.Click

        If (passwd.Text.Trim().Length < 6 Or cheak.Text <> passwd.Text) Then

            MessageBox.Show("Check your PassWord")

        ElseIf PassExist(oldpass.Text) Then

            MsgBox("Password has NOT EXIST")

        ElseIf (登入.TextBox1.Text.First() = "A") Then

            Dim conn As New Connection()
            Dim updateQuery = "UPDATE 會員 SET 會員密碼 = @pass WHERE 會員編號 = @uid"
            Dim table As New DataTable()
            Dim command As New MySqlCommand(updateQuery, conn.getConnection)
            command.Parameters.Add("@uid", MySqlDbType.VarChar).Value = 登入.TextBox1.Text
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passwd.Text
            conn.OpenConnection()

            If command.ExecuteNonQuery() = 1 Then

                MsgBox("修改成功！")
                conn.CloseConnection()
                Me.Close()
                登入.Show()
                Return

            Else

                MsgBox("修改失敗")
                conn.CloseConnection()
                Return

            End If

        ElseIf 登入.TextBox1.Text.First() = "B" Then

            Dim conn As New Connection()
            Dim updateQuery = "UPDATE 教練 SET 教練密碼 = @cpass WHERE 教練編號 = @cid"
            Dim table As New DataTable()
            Dim command As New MySqlCommand(updateQuery, conn.getConnection)
            command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = 登入.TextBox1.Text
            command.Parameters.Add("@cpass", MySqlDbType.VarChar).Value = passwd.Text
            conn.OpenConnection()

            If command.ExecuteNonQuery() = 1 Then

                MsgBox("修改成功！")
                conn.CloseConnection()
                Me.Close()
                Form2.Close()
                登入.Show()
                Return

            Else

                MsgBox("修改失敗")
                conn.CloseConnection()
                Return

            End If
        End If

    End Sub
    Public Function PassExist(ByVal pass As String) As Boolean

        Dim conn As New Connection()
        Dim adapter As New MySqlDataAdapter()
        Dim adapter2 As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim table2 As New DataTable()

        Dim command As New MySqlCommand("SELECT 會員密碼 FROM 會員 WHERE 會員密碼 = @pass AND 會員編號 = @uid ", conn.getConnection())
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass
        command.Parameters.Add("@uid", MySqlDbType.VarChar).Value = 登入.TextBox1.Text

        Dim command2 As New MySqlCommand("SELECT 教練密碼 FROM 教練 WHERE 教練密碼 = @cpass AND 教練編號 = @cid", conn.getConnection())
        command2.Parameters.Add("@cpass", MySqlDbType.VarChar).Value = pass
        command2.Parameters.Add("@cid", MySqlDbType.VarChar).Value = 登入.TextBox1.Text

        adapter.SelectCommand = command
        adapter.Fill(table)
        adapter2.SelectCommand = command2
        adapter2.Fill(table2)

        If (table.Rows.Count = 0 AndAlso table2.Rows.Count = 0) Then
            Return True
        Else
            Return False
        End If

    End Function
End Class