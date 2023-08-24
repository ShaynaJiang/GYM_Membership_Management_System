Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports Microsoft.Win32

Imports MySql.Data.MySqlClient
Public Class 請假
    Private Sub end_s_Click(sender As Object, e As EventArgs) Handles end_s.Click
        Me.Close()
    End Sub

    Private Sub 請假_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Sub load()
        Dim con As New connection
        Dim cmd As New MySqlCommand("SELECT  課程.課程編號,課程.課程名稱,剩餘課堂數,課程時間 FROM 有購課者 INNER JOIN 課程 ON 有購課者.課程編號=課程.課程編號 where 會員編號=@temp ", con.getConnection())
        cmd.Parameters.AddWithValue("@temp", 登入.temp)
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter(cmd)
        adapter.Fill(table)
        DataGridView1.DataSource = table
        'DataGridView1.AutoResizeColumns()
        'DataGridView1.AutoResizeRows()
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.RowHeadersWidth = 30
        '
        Dim cmd2 As New MySqlCommand("SELECT 課程編號,課程名稱,請假日期  FROM 出席  where 會員編號=@temp ", con.getConnection())
        cmd2.Parameters.AddWithValue("@temp", 登入.temp)
        Dim table2 As New DataTable()
        Dim adapter2 As New MySqlDataAdapter(cmd2)
        adapter2.Fill(table2)
        DataGridView2.DataSource = table2
        'DataGridView2.AutoResizeColumns()
        'DataGridView2.AutoResizeRows()
        DataGridView2.RowHeadersWidth = 30
        DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        '確保只選取一行
        If DataGridView1.SelectedRows.Count = 1 Then
            Dim selectedRow As Integer = DataGridView1.SelectedRows(0).Index
            Dim CNO As String = DataGridView1.Rows(selectedRow).Cells("課程編號").Value.ToString()
            Dim CNAME As String = DataGridView1.Rows(selectedRow).Cells("課程名稱").Value.ToString()
            '取出是星期幾請假
            Dim selectedDate As DateTime = DateTimePicker1.Value
            Dim selectedDayOfWeek As DayOfWeek = selectedDate.DayOfWeek
            'Dim dayOfWeekString As String = selectedDayOfWeek.ToString()
            Dim dayOfWeekString As String = ""
            Select Case selectedDayOfWeek
                Case DayOfWeek.Sunday
                    dayOfWeekString = "禮拜日"
                Case DayOfWeek.Monday
                    dayOfWeekString = "禮拜一"
                Case DayOfWeek.Tuesday
                    dayOfWeekString = "禮拜二"
                Case DayOfWeek.Wednesday
                    dayOfWeekString = "禮拜三"
                Case DayOfWeek.Thursday
                    dayOfWeekString = "禮拜四"
                Case DayOfWeek.Friday
                    dayOfWeekString = "禮拜五"
                Case DayOfWeek.Saturday
                    dayOfWeekString = "禮拜六"
            End Select

            Dim result As DialogResult = MessageBox.Show("是否確定要請假?？", "請假申請確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Dim 課程時間 As String = DataGridView1.Rows(selectedRow).Cells("課程時間").Value.ToString()
            Dim 星期 As String = 課程時間.Substring(課程時間.LastIndexOf(" "c) + 1)
            'Dim lastSpaceIndex As Integer = 課程時間.LastIndexOf(" ")


            'Dim 星期 As String = 課程時間.Substring(lastSpaceIndex + 1)
            'Label3.Text = 星期
            'Label4.Text = dayOfWeekString

            Dim a As String = dayOfWeekString.Trim()
            Dim b As String = 星期.Trim()

            'If (String.Equals(dayOfWeekString, 星期)) Then
            'If (a.Equals(b)) Then
            If a.Equals(b) Then
                If result = DialogResult.Yes Then
                    Dim con As New connection
                    con.Openconnection()

                    Dim updateSql As String = "UPDATE 有購課者 SET 剩餘課堂數=剩餘課堂數+1 WHERE 課程編號=@CNO"
                    Dim insertSql As String = "INSERT  INTO 出席 (會員編號,課程編號,課程名稱,請假日期) VALUES (@NO,@CNO,@CNAME,@DATE)"

                    Using cmd As New MySqlCommand(updateSql, con.getConnection())
                        cmd.Parameters.AddWithValue("@CNO", CNO)
                        cmd.ExecuteNonQuery()
                    End Using

                    Try
                        Using cmd2 As New MySqlCommand(insertSql, con.getConnection())
                            MsgBox("請假成功!")
                            cmd2.Parameters.AddWithValue("@NO", 登入.temp)
                            cmd2.Parameters.AddWithValue("@CNO", CNO)
                            cmd2.Parameters.AddWithValue("@CNAME", CNAME)
                            cmd2.Parameters.AddWithValue("@DATE", DateTimePicker1.Value)
                            cmd2.ExecuteNonQuery()
                        End Using
                        load()
                        con.Closeconnection()
                    Catch ex As Exception
                        MsgBox("已請過假!")
                    End Try

                End If
            Else
                MsgBox("日期選擇錯誤! 此課程是" & 星期)
            End If
        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If DataGridView2.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView2.SelectedRows(0)
            Dim selected As Integer = DataGridView2.SelectedRows(0).Index
            Dim CNO As String = DataGridView2.Rows(selected).Cells("課程編號").Value.ToString()
            Dim Dayoff As String = DataGridView2.Rows(selected).Cells("請假日期").Value.ToString()


            Dim deleteSql As String = "DELETE FROM 出席 WHERE 課程編號 = @CNO AND 請假日期 = @Dayoff"
            Dim result As DialogResult = MessageBox.Show("是否刪除該筆請假申請？", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim con As New connection
                con.Openconnection()

                ' 把星期去掉
                Dim parsedDate As DateTime = DateTime.Parse(Dayoff)
                Dim formattedDate As String = parsedDate.ToString("yyyy-MM-dd")

                Using cmd As New MySqlCommand(deleteSql, con.getConnection())
                    cmd.Parameters.AddWithValue("@CNO", CNO)
                    cmd.Parameters.AddWithValue("@Dayoff", formattedDate)


                    cmd.ExecuteNonQuery()
                End Using

                con.Closeconnection()
                DataGridView2.Rows.Remove(selectedRow)
                'load()
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class