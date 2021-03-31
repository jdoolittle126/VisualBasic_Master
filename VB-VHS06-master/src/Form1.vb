Public Class Form1
    Dim speed As Integer = 3
    Dim diverSpeed As Integer = 6
    Dim isLeft As Boolean = True
    'Had to create the image slightly differently, in order to flip it
    Dim sharkImage As Image = My.Resources.SharkRight

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picShark.Image = sharkImage
    End Sub
    'Shark Speed controls
    Private Sub btnSpdUp_Click(sender As Object, e As EventArgs) Handles btnSpdUp.Click
        speed += 1
    End Sub

    Private Sub btnSpdDwn_Click(sender As Object, e As EventArgs) Handles btnSpdDwn.Click
        speed -= 1
    End Sub

    'I find this method more effective, due to the fact that the shark will always take the shortest past at an (almost) constant speed! (The rounding makes it change a bit, but this is unnoticeable
    Private Sub tickTimer_Tick(sender As Object, e As EventArgs) Handles tickTimer.Tick
        'Some trig here, tan^-1(ops side / adj side) gives you the angle; angle = tan^-1(diff in x/diff in y)
        Dim angle As Double = Math.Atan((Math.Abs(picDiver.Left - picShark.Left)) / (Math.Abs(picDiver.Top - picShark.Top)))
        'Pythagorean theorem gives us the hyp. distance by taking the x side and y side, solving for a^2 + b^2 = c^2
        Dim distance As Double = Math.Sqrt(Math.Pow(picDiver.Left - picShark.Left, 2) + Math.Pow(picDiver.Top - picShark.Top, 2))
        'Gotta make sure the shark hasn't caught the diver, because you can't divid by 0!
        If Math.Abs(distance) > 0 Then
            'Velocity must be an integer, you can't move 0.5 of a pixel!
            Dim velLeft As Integer = Math.Round((((picDiver.Left - picShark.Left) / distance) * speed))
            Dim velTop As Integer = Math.Round((((picDiver.Top - picShark.Top) / distance) * speed))

            'Use the velocity to create the actual movement
            picShark.Top += velTop
            picShark.Left += velLeft

            'Flips image so the shark faces the diver
            If picShark.Left > picDiver.Left Then
                If isLeft = True Then
                    sharkImage.RotateFlip(RotateFlipType.RotateNoneFlipX)
                    picShark.Image = sharkImage
                    isLeft = False
                End If

            Else
                If isLeft = False Then
                    sharkImage.RotateFlip(RotateFlipType.RotateNoneFlipX)
                    picShark.Image = sharkImage
                    isLeft = True
                End If
            End If

        End If
        'Some coords
        lblCoords.Text = "(" + Convert.ToString(picShark.Left) + " ," + Convert.ToString(picShark.Top) + ")"
    End Sub

    'Buttons move diver
    Private Sub btnUP_Click_1(sender As Object, e As EventArgs) Handles btnUP.Click
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
