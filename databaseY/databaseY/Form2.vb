Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class Form2
    '當滑鼠過去 選單文字加底線 反之滑鼠消失
    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.Font = New Font(Label1.Font, FontStyle.Underline Or FontStyle.Bold)
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.Font = New Font(Label1.Font, FontStyle.Bold)
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        Label2.Font = New Font(Label2.Font, FontStyle.Underline Or FontStyle.Bold)
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label2.Font = New Font(Label2.Font, FontStyle.Bold)
    End Sub
    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.Font = New Font(Label3.Font, FontStyle.Underline)
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.Font = New Font(Label3.Font, FontStyle.Regular Or FontStyle.Bold)
    End Sub
    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.Font = New Font(Label4.Font, FontStyle.Underline)
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.Font = New Font(Label4.Font, FontStyle.Regular Or FontStyle.Bold)
    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        Label5.Font = New Font(Label5.Font, FontStyle.Underline)
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        Label5.Font = New Font(Label5.Font, FontStyle.Regular Or FontStyle.Bold)
    End Sub

    Private Sub Label6_MouseEnter(sender As Object, e As EventArgs) Handles Label6.MouseEnter
        Label6.Font = New Font(Label6.Font, FontStyle.Underline)
    End Sub

    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles Label6.MouseLeave
        Label6.Font = New Font(Label6.Font, FontStyle.Regular Or FontStyle.Bold)
    End Sub

    Private Sub Label7_MouseEnter(sender As Object, e As EventArgs) Handles Label7.MouseEnter
        Label7.Font = New Font(Label7.Font, FontStyle.Underline)
    End Sub

    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles Label7.MouseLeave
        Label7.Font = New Font(Label7.Font, FontStyle.Regular Or FontStyle.Bold)
    End Sub

    Private Sub Label8_MouseEnter(sender As Object, e As EventArgs) Handles Label8.MouseEnter
        Label8.Font = New Font(Label8.Font, FontStyle.Underline)
    End Sub

    Private Sub Label8_MouseLeave(sender As Object, e As EventArgs) Handles Label8.MouseLeave
        Label8.Font = New Font(Label8.Font, FontStyle.Regular Or FontStyle.Bold)
    End Sub

    Private Sub Label9_MouseEnter(sender As Object, e As EventArgs) Handles Label9.MouseEnter
        Label9.Font = New Font(Label9.Font, FontStyle.Underline)
    End Sub

    Private Sub Label9_MouseLeave(sender As Object, e As EventArgs) Handles Label9.MouseLeave
        Label9.Font = New Font(Label9.Font, FontStyle.Regular Or FontStyle.Bold)
    End Sub
    Private Sub Label10_MouseEnter(sender As Object, e As EventArgs) Handles Label10.MouseEnter
        Label10.Font = New Font(Label10.Font, FontStyle.Underline)
    End Sub

    Private Sub Label10_MouseLeave(sender As Object, e As EventArgs) Handles Label10.MouseLeave
        Label10.Font = New Font(Label10.Font, FontStyle.Regular Or FontStyle.Bold)
    End Sub
    Private Sub Label11_MouseEnter(sender As Object, e As EventArgs) Handles Label11.MouseEnter
        Label11.Font = New Font(Label11.Font, FontStyle.Underline)
    End Sub

    Private Sub Label11_MouseLeave(sender As Object, e As EventArgs) Handles Label11.MouseLeave
        Label11.Font = New Font(Label11.Font, FontStyle.Regular Or FontStyle.Bold)
    End Sub

    '點選各功能介面出現設定
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Panel1.Visible = True
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        studentclass.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        coach.Show()
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        個人資查詢.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        請假.Show()

    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        資料修改.Show()
    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        重新設定密碼.Show()
    End Sub
    Private Sub Label11_Click(sender As Object, e As EventArgs)
        登入.Show()
        Me.Hide()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Close()
        登入.Show()
    End Sub
    Private Sub end_s_Click(sender As Object, e As EventArgs) Handles end_s.Click
        Application.Exit()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        card.Show()

    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        curriculum.Show()
    End Sub
    Private Sub Label11_Click_1(sender As Object, e As EventArgs) Handles Label11.Click
        context.Show()

    End Sub
    '選單出現設定
    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave

        Dim clientRect As Rectangle = Panel1.ClientRectangle
        Dim mousePos As Point = Panel1.PointToClient(Control.MousePosition)
        If Not clientRect.Contains(mousePos) Then
            Panel1.Visible = False
        End If
    End Sub
    Private Sub button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave

        Dim clientRect As Rectangle = Panel1.ClientRectangle
        Dim mousePos As Point = Panel1.PointToClient(Control.MousePosition)

        If Not clientRect.Contains(mousePos) Then
            Panel1.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mail.Show()
        Me.Hide()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        選購.Show()
    End Sub
End Class