Imports MySql.Data.MySqlClient
Public Class 選購
    Dim dr As MySqlDataReader
    Dim result As Boolean
    Dim 選課 = Me

    '顯示課程
    Private Sub class_load()
        Dim con As New connection
        Try
            id.Text = 登入.TextBox1.Text
            Dim cmd As New MySqlCommand("SELECT 課程.課程編號 ,課程.課程名稱,`教練名稱`,`課程時間`,`課程內容` FROM `課程`
                                         where 課程.課程編號 not in( select 課程編號 from 有購課者 where 會員編號 = @id)", con.getConnection)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", id.Text)
            'dr = cmd.ExecuteReader
            'While dr.Read
            'DataGridView1.Rows.Add(dr.Item("課程編號"), dr.Item("課程名稱"), dr.Item("教練名稱"), dr.Item("課程時間"), dr.Item("課程內容"))
            'End While
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table) 'table name
            DataGridView1.DataSource = table

            DataGridView1.AutoResizeColumns()
            DataGridView1.AutoResizeRows()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '增加checkbox選項
    Private Sub checkboxcolumn()
        Dim checkbox As New DataGridViewCheckBoxColumn
        With checkbox
            .Width = 20
            .HeaderText = "選課"
            .DefaultCellStyle.Padding = New Padding(0, 5, 0, 5)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' 對齊內容
        End With
        With DataGridView1
            .Columns.Add(checkbox)
            .RowHeadersVisible = False
        End With
    End Sub

    '選購form
    Private Sub 選購_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkboxcolumn()
        class_load()
        id.Text = ""
        time.Text = ""
        classname.Text = ""
    End Sub

    '加入已購課程
    Private Function insert(sql As String, id As String, courseId As String, courseName As String)
        'Dim count As Integer = 0
        Dim con As New connection
        Try
            con.Openconnection()
            Dim cmd As New MySqlCommand(sql, con.getConnection)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@courseId", courseId)
            cmd.Parameters.AddWithValue("@courseName", courseName)
            'MessageBox.Show("*", id)
            'MessageBox.Show(courseId)
            'MessageBox.Show(row.Cells(0).FormattedValue)
            result = cmd.ExecuteNonQuery()
            ' count = cmd.ExecuteNonQuery()
            If result = 0 Then
                result = 0
            Else
                result = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            'MessageBox.Show("請填入您的會員編號")
        End Try
        con.Closeconnection()
        Return result
        ' Return count
    End Function
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim count As Integer = 0
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(0).FormattedValue = True Then
                    Dim Sql As String = "INSERT INTO `有購課者`(`會員編號`, `課程編號`, `課程名稱`,剩餘課堂數) VALUES (@id,@courseId,@courseName,24)"
                    Dim id As String = Me.id.Text
                    Dim courseId As String = row.Cells(1).FormattedValue
                    Dim courseName As String = row.Cells(2).FormattedValue
                    'MessageBox.Show(id)
                    'MessageBox.Show(courseId)
                    'MessageBox.Show(row.Cells(0).FormattedValue)
                    insert(Sql, id, courseId, courseName)
                End If
            Next
            If result = 0 Then
                MessageBox.Show("沒有加入購課的課程")
            Else
                MessageBox.Show("購買成功 !") ' & Environment.NewLine & "共加入" & count.ToString() & " 筆課程")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        class_load()
    End Sub

    '結束程式
    Private Sub close_Click(sender As Object, e As EventArgs) Handles close.Click
        選課.close
    End Sub

    '到退購頁面
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        id.Text = ""
        time.Text = ""
        classname.Text = ""
        退購.Show()
        Me.Hide()
    End Sub

    '輸入會員編號
    Private Sub id_TextChanged(sender As Object, e As EventArgs) Handles id.TextChanged
        class_load()
    End Sub


    '查詢可購課程
    Private Sub search(selectDate As String, selectName As String)
        Dim con As New connection
        Try
            Dim sql As String = "SELECT 課程.課程編號 ,課程.課程名稱,`教練名稱`,`課程時間`,`課程內容` 
                             FROM `課程`
                             where 課程.課程編號 not in( select 課程編號 from 有購課者 where 會員編號 = @id)
                             and 課程時間 like '%" & selectDate & "%' 
                             and 課程名稱 like '%" & selectName & "%' "

            Dim cmd As New MySqlCommand(sql, con.getConnection)
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter(cmd)

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", id.Text)

            table.Clear()
            adapter.Fill(table) 'table name
            DataGridView1.DataSource = table

            DataGridView1.AutoResizeColumns()
            DataGridView1.AutoResizeRows()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        search(time.Text, classname.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        studentclass.Show()
        '選課.close
    End Sub
End Class