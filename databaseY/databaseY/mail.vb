Imports System.Net.Mail

Public Class mail
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim smtp As New SmtpClient("smtp.gmail.com", 587)
            Dim mail As New MailMessage()

            smtp.UseDefaultCredentials = False
            smtp.EnableSsl = True
            smtp.Credentials = New System.Net.NetworkCredential("710535@mail.pcsh.ntpc.edu.tw", "pcsh412633")

            mail.Subject = "回饋和意見"
            mail.SubjectEncoding = System.Text.Encoding.UTF8
            mail.BodyEncoding = System.Text.Encoding.UTF8
            mail.From = New MailAddress("710535@mail.pcsh.ntpc.edu.tw")
            mail.Priority = MailPriority.Normal
            mail.IsBodyHtml = True
            mail.Body = RichTextBox1.Text
            mail.To.Add("a12210521@gmail.com")

            smtp.Send(mail)
            MsgBox("郵件已發送！")

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub butExit_Click(sender As Object, e As EventArgs)
        Me.Close()
        Form2.Show()
    End Sub

End Class




