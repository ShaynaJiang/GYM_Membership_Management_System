Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports Microsoft.Win32

Imports MySql.Data.MySqlClient
Public Class 建立學員名單
    Private Sub 建立學員名單_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New connection
        Dim cmd As New MySqlCommand("SELECT 課程編號,課程名稱 FROM 課程 where 教練編號=@temp  ", con.getConnection())

        cmd.Parameters.AddWithValue("@temp", 登入.temp)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()
        ComboBox1.DataSource = table
        adapter.Fill(table)
        ComboBox1.DisplayMember = "課程編號"
        ComboBox1.ValueMember = "課程名稱"
        ComboBox1.Text = "選擇課程編號"
        Label1.Text = " "
        reload()


    End Sub

    Private Sub end_s_Click(sender As Object, e As EventArgs) Handles end_s.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label1.Text = ComboBox1.GetItemText(ComboBox1.SelectedValue)
    End Sub



    Sub reload()
        Dim con As New connection
        Dim cmd2 As New MySqlCommand("SELECT 有購課者.會員編號,會員姓名 FROM 有購課者 INNER JOIN 會員 ON 有購課者.會員編號=會員.會員編號 where 課程編號=@CNO  ", con.getConnection())
        cmd2.Parameters.AddWithValue("@CNO", ComboBox1.Text)
        Dim adapter2 As New MySqlDataAdapter(cmd2)
        Dim table2 As New DataTable()
        'table.Clear()
        adapter2.Fill(table2)
        DataGridView1.DataSource = table2
        DataGridView1.RowHeadersWidth = 30
        DataGridView1.AutoResizeColumns()
        DataGridView1.AutoResizeRows()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        reload()
    End Sub
End Class