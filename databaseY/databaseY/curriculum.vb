Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports Microsoft.Win32

Imports MySql.Data.MySqlClient
Public Class curriculum
    Private Sub end_s_Click(sender As Object, e As EventArgs) Handles end_s.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub curriculum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
        Dim con As New connection
        Dim cmd2 As New MySqlCommand("SELECT DISTINCT 課程名稱 FROM 有購課者 where 會員編號=@temp", con.getConnection())
        cmd2.Parameters.AddWithValue("@temp", 登入.temp)
        Dim adapter2 As New MySqlDataAdapter(cmd2)
        Dim table2 As New DataTable()
        adapter2.Fill(table2)
        ComboBox2.DataSource = table2
        ComboBox2.DisplayMember = "課程名稱"
        ComboBox2.Text = " "

        Dim cmd3 As New MySqlCommand("SELECT 課程編號 FROM 有購課者 where 會員編號=@temp", con.getConnection())
        cmd3.Parameters.AddWithValue("@temp", 登入.temp)
        Dim adapter3 As New MySqlDataAdapter(cmd3)
        Dim table3 As New DataTable()
        adapter3.Fill(table3)
        ComboBox3.DataSource = table3
        ComboBox3.DisplayMember = "課程編號"
        ComboBox3.Text = " "
    End Sub

    Sub load()
        Dim con As New connection
        'Dim adapter As New MySqlDataAdapter("SELECT  * FROM 有購課者 where 會員編號=@ctemp  ", con.getConnection())
        Dim table As New DataTable()
        Dim cmd As New MySqlCommand("SELECT  課程.課程編號,課程.課程名稱,剩餘課堂數,課程時間 FROM 有購課者 INNER JOIN 課程 ON 有購課者.課程編號=課程.課程編號 where 會員編號=@temp ", con.getConnection())
        cmd.Parameters.AddWithValue("@temp", 登入.temp)
        Dim adapter As New MySqlDataAdapter
        adapter.SelectCommand = cmd

        adapter.Fill(table) 'table name
        DataGridView1.DataSource = table
        ' DataGridView1.AutoResizeColumns()
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        DataGridView1.RowHeadersWidth = 30


        'DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders

        'Me.DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        If (ComboBox2.Text = "" Or ComboBox2.Text = " ") And (ComboBox3.Text = "" Or ComboBox3.Text = " ") Then
            'MsgBox("請選擇你要查詢的項目!!")
            load()
        End If
        If ComboBox2.Text <> " " Then
            Dim con As New connection
            Dim cmd As New MySqlCommand("SELECT  課程.課程編號,課程.課程名稱,課程時間,剩餘課堂數 FROM 有購課者 INNER JOIN 課程 ON 有購課者.課程編號=課程.課程編號 where  有購課者.會員編號=@temp AND 課程.課程名稱=@CNAME ", con.getConnection())
            cmd.Parameters.AddWithValue("@temp", 登入.temp)
            cmd.Parameters.AddWithValue("@CNAME", ComboBox2.Text)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            DataGridView1.RowHeadersWidth = 30
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        End If
        If ComboBox3.Text <> " " Then
            Dim con As New connection
            Dim cmd As New MySqlCommand("SELECT  課程.課程編號,課程.課程名稱,課程時間,剩餘課堂數 FROM 有購課者 INNER JOIN 課程 ON 有購課者.課程編號=課程.課程編號 where  有購課者.會員編號=@temp AND 課程.課程編號=@CNO   ", con.getConnection())
            cmd.Parameters.AddWithValue("@temp", 登入.temp)
            cmd.Parameters.AddWithValue("@CNO", ComboBox3.Text)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            DataGridView1.RowHeadersWidth = 30
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        load()

    End Sub
End Class