Imports System.Reflection.Emit

Public Class Form3

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.Font = New Font(Label3.Font, FontStyle.Underline)
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.Font = New Font(Label3.Font, FontStyle.Regular Or FontStyle.Bold)
    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        Label5.Font = New Font(Label5.Font, FontStyle.Underline)
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        Label5.Font = New Font(Label5.Font, FontStyle.Regular Or FontStyle.Bold)
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
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Panel1.Visible = True
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        個人資查詢.Show()
    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        資料修改.Show()
    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        重新設定密碼.Show()
    End Sub
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        建立學員名單.Show()
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        coachcur.Show()
    End Sub
    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave

        Dim clientRect As Rectangle = Panel1.ClientRectangle
        '獲取滑鼠位置在控制項中的座標
        Dim mousePos As Point = Panel1.PointToClient(Control.MousePosition)

        '判斷滑鼠位置是否在控制項內
        If Not clientRect.Contains(mousePos) Then
            '滑鼠已經離開控制項，隱藏控制項
            Panel1.Visible = False
        End If
    End Sub
    Private Sub button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave

        Dim clientRect As Rectangle = Panel1.ClientRectangle
        '獲取滑鼠位置在控制項中的座標
        Dim mousePos As Point = Panel1.PointToClient(Control.MousePosition)

        '判斷滑鼠位置是否在控制項內
        If Not clientRect.Contains(mousePos) Then
            '滑鼠已經離開控制項，隱藏控制項
            Panel1.Visible = False
        End If
    End Sub

    Private Sub end_s_Click(sender As Object, e As EventArgs) Handles end_s.Click
        Application.Exit()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Close()
        登入.Show()
    End Sub
End Class