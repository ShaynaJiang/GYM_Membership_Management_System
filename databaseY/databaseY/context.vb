
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Public Class context

    Private Sub context_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New connection()
        Dim command As New MySqlCommand("SELECT * FROM `會員身體數據` WHERE `會員編號` = @isuser", con.getConnection())
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter(command)
        DateTimePicker1.CustomFormat = "yyyy"
        command.Parameters.Add("@isuser", MySqlDbType.VarChar).Value = 登入.TextBox1.Text
        DataGridView1.Rows.Clear()
        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        adapter.Fill(table)
        DataGridView1.DataSource = table
        Dim chartcommand As New MySqlCommand("SELECT `紀錄日期`, `會員體重` , `腰圍`, `臀圍`, `胸圍` FROM `會員身體數據` WHERE `會員編號` = @isuser", con.getConnection())
        chartcommand.Parameters.Add("@isuser", MySqlDbType.VarChar).Value = 登入.TextBox1.Text
        Dim chartAdapter As New MySqlDataAdapter(chartcommand)
        Dim chartTable As New DataTable()
        chartAdapter.Fill(chartTable)
        Dim series1 As New Series()
        series1.Name = "體重"
        series1.XValueType = ChartValueType.DateTime
        For Each row As DataRow In table.Rows
            Dim dateRecord As DateTime = Convert.ToDateTime(row("紀錄日期"))
            Dim weight As Double = Convert.ToDouble(row("會員體重"))
            series1.Points.AddXY(dateRecord.Date, weight)
        Next
        series1.ChartType = SeriesChartType.Line
        series1.BorderWidth = 10

        ' 將資料序列添加到圖表中
        Chart1.Series.Add(series1)
        Chart1.ChartAreas(0).AxisX.LabelStyle.Format = "yyyy/MM"
        Chart1.ChartAreas(0).AxisX.IntervalType = DateTimeIntervalType.Months
        Chart1.ChartAreas(0).AxisX.Interval = 2
    End Sub

    Private Sub dateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ' 獲取選擇的日期
        Dim selectedDate As DateTime = DateTimePicker1.Value
        Dim con As New connection()
        Dim command As New MySqlCommand("SELECT `紀錄日期`, `會員體重` , `腰圍`, `臀圍`, `胸圍`, `會員身高` FROM `會員身體數據` WHERE `會員編號` = @isuser AND YEAR(`紀錄日期`) = @SelectedYear ", con.getConnection())
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter(command)
        command.Parameters.Add("@isuser", MySqlDbType.VarChar).Value = 登入.TextBox1.Text
        command.Parameters.Add("@SelectedYear", MySqlDbType.Int32).Value = selectedDate.Year
        command.Parameters.Add("@SelectedMonth", MySqlDbType.Int32).Value = selectedDate.Month

        Try
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                TextBox1.Text = table.Rows(0)("臀圍").ToString()
                TextBox2.Text = table.Rows(0)("胸圍").ToString()
                Textbox3.Text = table.Rows(0)("腰圍").ToString()
                TextBox4.Text = table.Rows(0)("會員身高").ToString()
                TextBox5.Text = table.Rows(0)("會員體重").ToString()
                DataGridView1.DataSource = table
                Chart1.Series.Clear()
                Chart1.ChartAreas.Clear()
                Chart1.ChartAreas.Add(New ChartArea())

                Dim series1 As New Series()
                series1.Name = "體重"
                series1.XValueType = ChartValueType.DateTime

                For Each row As DataRow In table.Rows
                    Dim dateRecord As DateTime = Convert.ToDateTime(row("紀錄日期"))
                    Dim weight As Double = Convert.ToDouble(row("會員體重"))
                    series1.Points.AddXY(dateRecord.Date, weight)
                Next
                series1.ChartType = SeriesChartType.Line
                series1.BorderWidth = 10
                Chart1.Series.Add(series1)
                Chart1.ChartAreas(0).AxisX.LabelStyle.Format = "yyyy/MM"
                Chart1.ChartAreas(0).AxisX.IntervalType = DateTimeIntervalType.Months
                Chart1.ChartAreas(0).AxisX.Interval = 2
                Chart1.BackColor = Color.Transparent
                Chart1.ChartAreas(0).BackColor = Color.White
            Else
                ' 清空文本框和 DataGridView（沒有檢索到資料）
                TextBox1.Text = ""
                TextBox2.Text = ""
                Textbox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                DataGridView1.DataSource = Nothing
                Chart1.Series.Clear()
                MessageBox.Show("無資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("資料庫錯誤：" & ex.Message)
        Finally
            con.Closeconnection()
            command.Dispose()
            adapter.Dispose()
            table.Dispose()
        End Try
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged

        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            If Not selectedRow Is Nothing AndAlso Not selectedRow.IsNewRow Then
                TextBox1.Text = selectedRow.Cells("臀圍").Value.ToString()
                TextBox2.Text = selectedRow.Cells("胸圍").Value.ToString()
                Textbox3.Text = selectedRow.Cells("腰圍").Value.ToString()
                TextBox4.Text = selectedRow.Cells("會員身高").Value.ToString()
                TextBox5.Text = selectedRow.Cells("會員體重").Value.ToString()
            End If
        End If
    End Sub

    Private Sub end_s_Click(sender As Object, e As EventArgs) Handles end_s.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        Textbox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
    End Sub
End Class


