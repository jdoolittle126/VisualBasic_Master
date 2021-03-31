Public Class Form1
    Dim speed As Integer = 3
    Dim gravity As Integer = 1
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
        Dim velLeft As Integer = 0
        Dim velTop As Integer = 0
        Dim velConst As Integer = 1

        'Handles blackhole                                                  V Middle of hole we add 1/2 the x size and 1/2 the y size from each
        Dim distance_hole As Double = Math.Sqrt(Math.Pow(blackholeBox.Left + (418 / 2) - picShark.Left, 2) + Math.Pow(blackholeBox.Top + (281 / 2) - picShark.Top, 2))

        If Math.Abs(distance_hole) > 20 Then                                                                                'Not actually how grav. acc. works, but the numbers make sense
            velLeft = Math.Round((((blackholeBox.Left + (418 / 2) - picShark.Left) / distance_hole) * Math.Round(gravity * (100 / distance_hole))))
            velTop = Math.Round((((blackholeBox.Top + (281 / 2) - picShark.Top) / distance_hole) * Math.Round(gravity * (100 / distance_hole))))
            picShark.Visible = True
            velConst = 1
        Else
            velConst = 0
            If gravity < 0 Then
                velConst = 1
            End If

            picShark.Visible = False
        End If


        Dim distance As Double = Math.Sqrt(Math.Pow(picDiver.Left - picShark.Left, 2) + Math.Pow(picDiver.Top - picShark.Top, 2))
        If Math.Abs(distance) > 0 Then
            'Velocity must be an integer, you can't move 0.5 of a pixel!
            velLeft = velLeft + Math.Round((((picDiver.Left - picShark.Left) / distance) * speed))
            velTop = velTop + Math.Round((((picDiver.Top - picShark.Top) / distance) * speed))
            'Use the velocity to create the actual movement



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

        'velConst allows or denies movement, there is no escape from a black hole
        picShark.Top += velTop * velConst
        picShark.Left += velLeft * velConst




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

    Private Sub btnGravUp_Click(sender As Object, e As EventArgs) Handles btnGravUp.Click
        gravity += 1
    End Sub

    Private Sub btnGravDwn_Click(sender As Object, e As EventArgs) Handles btnGravDwn.Click
        gravity -= 1
    End Sub
End Class
