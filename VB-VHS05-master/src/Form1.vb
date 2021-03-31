Public Class Form1
    Private Sub btnUP_Click(sender As Object, e As EventArgs) Handles btnUP.Click
        picFish.Top -= 100
        lblPos.Text = "Fish pos: (" + Convert.ToString(picFish.Left) + "," + Convert.ToString(picFish.Top) + ")"
    End Sub

    Private Sub btnDOWN_Click(sender As Object, e As EventArgs) Handles btnDOWN.Click
        picFish.Top += 100
        lblPos.Text = "Fish pos: (" + Convert.ToString(picFish.Left) + "," + Convert.ToString(picFish.Top) + ")"
    End Sub

    Private Sub btnLEFT_Click(sender As Object, e As EventArgs) Handles btnLEFT.Click
        picFish.Left -= 100
        lblPos.Text = "Fish pos: (" + Convert.ToString(picFish.Left) + "," + Convert.ToString(picFish.Top) + ")"
    End Sub

    Private Sub btnRIGHT_Click(sender As Object, e As EventArgs) Handles btnRIGHT.Click
        picFish.Left += 100
        lblPos.Text = "Fish pos: (" + Convert.ToString(picFish.Left) + "," + Convert.ToString(picFish.Top) + ")"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPos.Text = "Fish pos: (" + Convert.ToString(picFish.Left) + "," + Convert.ToString(picFish.Top) + ")"
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        picFish.Left = 337
        picFish.Top = 328
        lblPos.Text = "Fish pos: (" + Convert.ToString(picFish.Left) + "," + Convert.ToString(picFish.Top) + ")"
    End Sub

End Class
