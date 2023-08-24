Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class card
    Private Sub card_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '卡面上
        Dim con As New connection()
        Dim command As New MySqlCommand("SELECT `會員姓名` FROM `會員` WHERE `會員編號` = @isuser", con.getConnection())
        Dim datecommand As New MySqlCommand("SELECT `會員到期紀錄` FROM `會員` WHERE `會員編號` = @isuser", con.getConnection())
        command.Parameters.Add("@isuser", MySqlDbType.VarChar).Value = 登入.TextBox1.Text
        datecommand.Parameters.Add("@isuser", MySqlDbType.VarChar).Value = 登入.TextBox1.Text
        Dim adapter As New MySqlDataAdapter(command)
        Dim dateadapter As New MySqlDataAdapter(datecommand)
        Dim table As New DataTable()
        Dim datetable As New DataTable()
        adapter.Fill(table)
        dateadapter.Fill(datetable)
        Label6.Text = 登入.TextBox1.Text.ToUpper
        If table.Rows.Count > 0 Then
            Label5.Text = table.Rows(0)("會員姓名").ToString()
            Dim expirationDate As DateTime = DateTime.Parse(datetable.Rows(0)("會員到期紀錄").ToString())
            Label7.Text = expirationDate.ToShortDateString()
        Else
            Label5.Text = "無資料"
        End If

        'combox
        Dim cardcommand As New MySqlCommand("SELECT t1.`會員編號`, t2.`課程編號` FROM `有購課者` AS t1 JOIN `課程` AS t2 ON t1.`課程編號` = t2.`課程編號` WHERE t1.`會員編號` = @isuser", con.getConnection())
        cardcommand.Parameters.Add("@isuser", MySqlDbType.VarChar).Value = 登入.TextBox1.Text
        Dim cardadapter As New MySqlDataAdapter(cardcommand)
        Dim table2 As New DataTable()
        cardadapter.Fill(table2)
        ComboBox1.DataSource = table2.DefaultView
        ComboBox1.DisplayMember = "課程編號"
        'TextBox2.Text = "課程編號"


    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex <> -1 Then
            Dim selectedRow As DataRowView = DirectCast(ComboBox1.SelectedItem, DataRowView)
            Dim selectedCourseID As String = selectedRow("課程編號").ToString()

            Dim con As New connection()

            Dim command As New MySqlCommand("SELECT `課程名稱`, `剩餘課堂數` FROM `有購課者` WHERE `課程編號` = @buy", con.getConnection())
            command.Parameters.Add("@buy", MySqlDbType.VarChar).Value = selectedCourseID
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                Dim courseName As String = table.Rows(0)("課程名稱").ToString()
                Dim courseBuy As String = table.Rows(0)("剩餘課堂數").ToString()

                TextBox2.Text = courseName
                TextBox1.Text = courseBuy
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()

    End Sub


End Class
