Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Window.BackColor = Color.LightYellow
        Dim intCount As Integer
        For intCount = 0 To 100
            ProgressBar1.Value = intCount
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Window.BackColor = Color.DimGray
        ProgressBar1.Value = 0
    End Sub

End Class
