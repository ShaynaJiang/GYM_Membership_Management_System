Imports MySql.Data.MySqlClient
Public Class 退購
    Dim dr As MySqlDataReader
    Dim sql As String
    Dim result As Boolean
    Dim 退課 = Me

    Private Sub 退購_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkboxcolumn()
        class_load()
        id.Text = 登入.TextBox1.Text
    End Sub
    Private Sub class_load()
        Dim con As New connection
        Try
            con.Openconnection()
            id.Text = 登入.TextBox1.Text
            Dim cmd As New MySqlCommand("SELECT 課程.課程編號 ,課程.課程名稱,`教練名稱`,`課程時間` FROM `課程`
                                         where 課程.課程編號  in( select 課程編號 from 有購課者 where 會員編號 = @id)", con.getConnection)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", id.Text)

            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table) 'table name
            DataGridView1.DataSource = table

            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DataGridView1.AutoResizeRows()
            'DataGridView1.DefaultCellStyle.Font = New Font("Arial", 12)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub checkboxcolumn()
        Dim checkbox As New DataGridViewCheckBoxColumn
        With checkbox
            .Width = 20
            .HeaderText = "退課"
            .DefaultCellStyle.Padding = New Padding(0, 5, 0, 5)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' 對齊內容
        End With
        With DataGridView1
            .Columns.Add(checkbox)
            .RowHeadersVisible = False
        End With
    End Sub

    Private Function delete(sql As String, id As String)
        Dim con As New connection
        Try
            con.Openconnection()
            Dim cmd As New MySqlCommand(sql, con.getConnection)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", id)
            'MessageBox.Show("*", id)
            'MessageBox.Show(courseId)
            ' MessageBox.Show(row.Cells(0).FormattedValue)
            result = cmd.ExecuteNonQuery()
            If result = 0 Then
                result = 0
            Else
                result = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Closeconnection()
        Return result
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        id.Text = ""
        選購.Show()
        Me.Hide()
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles close.Click
        退課.close
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(0).FormattedValue = True Then
                    Dim courseId As String = row.Cells(1).FormattedValue
                    Dim id As String = Me.id.Text
                    sql = "delete from 有購課者 where 會員編號 = @id and 課程編號 LIKE '%" & row.Cells(1).FormattedValue & "%'"
                    'MessageBox.Show(id)
                    'MessageBox.Show(courseId)
                    'MessageBox.Show(row.Cells(0).FormattedValue)
                    delete(sql, id)
                End If
            Next
            If result = 0 Then
                MessageBox.Show("沒有退購的課程")
            Else
                MessageBox.Show("課程退購成功")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        class_load()
    End Sub

    Private Sub id_TextChanged(sender As Object, e As EventArgs) Handles id.TextChanged
        class_load()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        studentclass.Show()
        'Me.Hide()
    End Sub
End Class