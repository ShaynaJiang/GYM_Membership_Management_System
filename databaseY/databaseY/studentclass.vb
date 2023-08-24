Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class studentclass


    Private Sub studentclass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        Dim con As New connection()
        Dim adapter As New MySqlDataAdapter("Select * FROM `課程`", con.getConnection())
        Dim table As New DataTable()
        DataGridView1.Rows.Clear()
        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        context_box.Height = 100
        adapter.Fill(table) 'table name
        DataGridView1.DataSource = table
        Dim command As New MySqlCommand("SELECT DISTINCT `課程編號`, `課程名稱`, `教練名稱` FROM `課程`", con.getConnection())
        Dim reader As MySqlDataReader

        Try
            con.Openconnection()
            reader = command.ExecuteReader()
            ComboBox1.Items.Clear()
            ComboBox2.Items.Clear()
            While reader.Read()
                Dim courseName As String = reader("課程名稱").ToString()
                If Not ComboBox1.Items.Contains(courseName) Then
                    ComboBox1.Items.Add(courseName)
                End If
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        Finally
            con.Closeconnection()
        End Try
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        Dim selectedCourseName As String = ComboBox1.SelectedItem.ToString()
        Dim con As New connection()
        Dim command As New MySqlCommand("SELECT DISTINCT `教練名稱` FROM `課程` WHERE `課程名稱` = @name", con.getConnection())

        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = selectedCourseName

        Try
            con.Openconnection()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            ComboBox2.Items.Clear()

            While reader.Read()
                Dim teacher As String = reader("教練名稱").ToString()
                ComboBox2.Items.Add(teacher)
            End While

            reader.Close()

            ComboBox2.Text = ""
            ComboBox3.DataSource = Nothing
            ComboBox3.Text = ""
            context_box.Text = ""
            DataGridView1.DataSource = Nothing
            ComboBox2.Enabled = True
        Catch ex As Exception
            MessageBox.Show("發生錯誤：" & ex.Message)
        Finally
            con.Closeconnection()
        End Try
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox3.Enabled = False
        Dim selectedCourseName As String = ComboBox1.SelectedItem.ToString()
        Dim selectedTeacher As String = ComboBox2.SelectedItem.ToString()

        Dim con As New connection
        Try
            con.Openconnection()
            Dim command As New MySqlCommand("SELECT `課程時間` FROM `課程` WHERE `課程名稱` = @name AND `教練名稱` = @teacher", con.getConnection())
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = selectedCourseName
            command.Parameters.Add("@teacher", MySqlDbType.VarChar).Value = selectedTeacher

            Dim reader As MySqlDataReader = command.ExecuteReader()

            ComboBox3.Items.Clear()

            While reader.Read()
                Dim time As String = reader("課程時間").ToString()
                ComboBox3.Items.Add(time)
            End While

            reader.Close()

            ComboBox3.Text = ""
            context_box.Text = ""
            DataGridView1.DataSource = Nothing
            ComboBox3.Enabled = True
        Catch ex As Exception
            MessageBox.Show("發生錯誤：" & ex.Message)
        Finally
            con.Closeconnection()
        End Try
    End Sub





    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim selectedCourseName As String = ComboBox1.SelectedItem.ToString()
        Dim selectedTeacher As String = ComboBox2.SelectedItem.ToString()
        Dim selectedTime As String = ComboBox3.SelectedItem.ToString()

        Dim con As New connection()
        Dim command As New MySqlCommand("Select * FROM `課程` WHERE `課程名稱` = @name AND `教練名稱` = @teacher AND `課程時間` = @time", con.getConnection())
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = selectedCourseName
        command.Parameters.Add("@teacher", MySqlDbType.VarChar).Value = selectedTeacher
        command.Parameters.Add("@time", MySqlDbType.VarChar).Value = selectedTime

        Try
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                context_box.Text = table.Rows(0)("課程內容").ToString()
                DataGridView1.DataSource = table
            Else
                context_box.Text = ""
                DataGridView1.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub end_s_Click(sender As Object, e As EventArgs) Handles end_s.Click
        Me.Close()
    End Sub


End Class