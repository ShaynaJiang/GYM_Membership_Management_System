Imports System.Data.SqlClient
Imports System.Globalization
Imports MySql.Data.MySqlClient
Public Class 個人資查詢
    Private Sub butExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub 個人資查詢_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New Connection()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM 會員 WHERE 會員編號 = @uid", conn.getConnection)
        Dim command2 As New MySqlCommand("SELECT * FROM 教練 WHERE 教練編號 = @tid", conn.getConnection)
        ID.Text = 登入.TextBox1.Text

        command.Parameters.Add("@uid", MySqlDbType.VarChar).Value = ID.Text
        command2.Parameters.Add("@tid", MySqlDbType.VarChar).Value = ID.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim adapter2 As New MySqlDataAdapter(command2)
        adapter.Fill(table)
        adapter2.Fill(table)

        Dim rawDateTime As DateTime = table.Rows(0)("出生日期")
        Dim dateOnly As DateTime = rawDateTime.Date
        Dim formattedDate As String = dateOnly.ToString("yyyy-MM-dd")

        'clear the textbox
        usrname.Text = ""
        pid.Text = ""
        phone.Text = ""
        bir.Text = ""
        gender.Text = ""
        mail.Text = ""
        adress.Text = ""

        If table.Rows.Count <= 0 Then

            MessageBox.Show("NO DATA FOUND")

        ElseIf ID.Text.First() = "A" Then
            'search member's imformation
            usrname.Text = table.Rows(0)("會員姓名").ToString
            pid.Text = table.Rows(0)("身分證字號").ToString
            phone.Text = table.Rows(0)("手機號碼").ToString
            bir.Text = formattedDate
            gender.Text = table.Rows(0)("性別").ToString
            mail.Text = table.Rows(0)("電子信箱").ToString
            adress.Text = table.Rows(0)("通訊地址").ToString

        ElseIf ID.Text.First() = "B" Then
            'search coach's imformation
            usrname.Text = table.Rows(0)("教練名稱").ToString
            pid.Text = table.Rows(0)("身分證字號").ToString
            phone.Text = table.Rows(0)("手機號碼").ToString
            bir.Text = formattedDate
            gender.Text = table.Rows(0)("性別").ToString
            mail.Text = table.Rows(0)("電子信箱").ToString
            adress.Text = table.Rows(0)("通訊地址").ToString

        End If
    End Sub

End Class