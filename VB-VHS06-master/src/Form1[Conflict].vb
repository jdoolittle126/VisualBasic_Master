Public Class Form1
    Dim speed As Integer = 4
    Dim diverSpeed As Integer = 7

    Private Sub btnSpdUp_Click(sender As Object, e As EventArgs) Handles btnSpdUp.Click
        speed += 1
    End Sub

    Private Sub btnSpdDwn_Click(sender As Object, e As EventArgs) Handles btnSpdDwn.Click
        speed -= 1
    End Sub

    Private Sub tickTimer_Tick(sender As Object, e As EventArgs) Handles tickTimer.Tick
        Dim distance As Double = Math.Sqrt(Math.Pow(picDiver.Left - picShark.Left, 2) + Math.Pow(picDiver.Top - picShark.Top, 2))
        If distance <> 0 Then
            Dim velLeft As Integer = Math.Round((((picDiver.Left - picShark.Left) / distance) * speed))
            Dim velTop As Integer = Math.Round((((picDiver.Top - picShark.Top) / distance) * speed))

            picShark.Top += velTop
            picShark.Left += velLeft
        End If

        lblCoords.Text = "Shark Coords: (" + Convert.ToString(picShark.Left) + " ," + Convert.ToString(picShark.Top) + ")"

    End Sub

    Private Sub btnUP_Click(sender As Object, e As EventArgs) Handles btnUP.Click
        picDiver.Top -= diverSpeed
    End Sub

    Private Sub btnDOWN_Click(sender As Object, e As EventArgs) Handles btnDOWN.Click
        picDiver.Top += diverSpeed
    End Sub

    Private Sub btnLEFT_Click(sender As Object, e As EventArgs) Handles btnLEFT.Click
        picDiver.Left -= diverSpeed
    End Sub

    Private Sub btnRIGHT_Click(sender As Object, e As EventArgs) Handles btnRIGHT.Click
        picDiver.Left += diverSpeed
    End Sub


End Class
