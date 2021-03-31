Public Class Form1

    Private Sub cmdBigger_Click(sender As Object, e As EventArgs) Handles cmdBigger.Click
        cmdBigger.Height += 10
        cmdBigger.Width += 10
    End Sub

    Private Sub cmdSmaller_Click(sender As Object, e As EventArgs) Handles cmdSmaller.Click
        'I used an if because I have no clue if there is a built in clamp function
        If cmdSmaller.Height > 10 Then
            cmdSmaller.Height -= 10
        End If
        If cmdSmaller.Width > 10 Then
            cmdSmaller.Width -= 10
        End If
    End Sub
    Private Sub cmdMoreMoney_Click(sender As Object, e As EventArgs) Handles cmdMoreMoney.Click
        picMoney.Height += 10
        picMoney.Width += 10
    End Sub

    Private Sub cmdElvis_Click(sender As Object, e As EventArgs) Handles cmdElvis.Click
        cmdElvis.Text = cmdElvis.Text + "!"
    End Sub
End Class
