Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class coach

    Private Sub end_s_Click(sender As Object, e As EventArgs) Handles end_s.Click
        Me.Close()
    End Sub

    Private Sub coach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New connection()
        Dim command As New MySqlCommand("SELECT DISTINCT `教練編號` , `教練名稱` FROM `教練`", con.getConnection())
        Dim reader As MySqlDataReader

        Try

            con.Openconnection()

            reader = command.ExecuteReader()

            ComboBox1.Items.Clear()
            ComboBox2.Items.Clear()
            While reader.Read()
                ComboBox1.Items.Add(reader("教練編號").ToString())
                ComboBox2.Items.Add(reader("教練名稱").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        Finally
            con.Closeconnection()
        End Try
    End Sub
    Private Sub idComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim con As New connection()
        Dim command As New MySqlCommand("SELECT `教練編號`, `教練名稱`, `教授課程`, `教練頭貼` FROM `教練` WHERE `教練編號` = @id", con.getConnection())
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        Dim imgByte() As Byte

        command.Parameters.Add("@id", MySqlDbType.VarChar).Value = ComboBox1.SelectedItem.ToString()

        Try
            adapter.Fill(table) ' Fill the data from database to DataTable

            If table.Rows.Count > 0 Then
                name_box.Text = table(0)("教授課程").ToString()
                ComboBox2.Text = table(0)("教練名稱").ToString()
                If ComboBox2.SelectedIndex >= 0 Then
                    ComboBox1.SelectedIndex = ComboBox2.SelectedIndex
                End If
                If Not IsDBNull(table(0)("教練頭貼")) Then
                    imgByte = DirectCast(table(0)("教練頭貼"), Byte())
                    Dim ms As New MemoryStream(imgByte)
                    PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
                    PictureBox1.Image = Image.FromStream(ms)
                Else
                    PictureBox1.Image = Nothing
                End If
            Else
                name_box.Text = ""
                ComboBox2.Text = ""
                PictureBox1.Image = Nothing
                MessageBox.Show("查無此人", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub nameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim con As New connection()
        Dim command As New MySqlCommand("SELECT `教練編號`, `教練名稱`, `教授課程`, `教練頭貼` FROM `教練` WHERE `教練名稱` = @name", con.getConnection())
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        Dim imgByte() As Byte

        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = ComboBox2.SelectedItem.ToString()

        Try
            adapter.Fill(table) ' Fill the data from database to DataTable

            If table.Rows.Count > 0 Then
                name_box.Text = table(0)("教授課程").ToString()
                ComboBox1.Text = table(0)("教練編號").ToString()
                If Not IsDBNull(table(0)("教練頭貼")) Then
                    imgByte = DirectCast(table(0)("教練頭貼"), Byte())
                    Dim ms As New MemoryStream(imgByte)
                    PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
                    PictureBox1.Image = Image.FromStream(ms)
                Else
                    PictureBox1.Image = Nothing
                End If
            Else
                name_box.Text = ""
                ComboBox1.Text = ""
                PictureBox1.Image = Nothing
                MessageBox.Show("查無此人", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub


End Class