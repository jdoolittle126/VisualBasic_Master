Public Class Main
    '(new_Name, new_isWalkable, new_isBuildable, new_nutritionVal, new_animationFrames, new_tileType, new_tileSquare)
    Dim mat_Grass As Material = New Material("Grass", True, True, 1.0, 1, 1, New Rectangle(0, 0, 96, 96))
    Dim mat_Water As Material = New Material("Water", False, False, -1.0, 1, 2, New Rectangle(96, 96, 96, 96))

    Dim G As Graphics
    Dim assets As New Assets
    Dim tile As Bitmap
    Dim viewPortX As Integer = 10
    Dim viewPortY As Integer = 10
    Dim test_map As List(Of Tile)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        G = Me.CreateGraphics
        tile = New Bitmap(assets.pbAssets.Image)
        For x = 0 To viewPortX
            For y = 0 To viewPortY
                G.DrawImage(tile, dest32, source32, GraphicsUnit.Pixel)
                G.DrawImage(tile, dest64, source64, GraphicsUnit.Pixel)
            Next
        Next

    End Sub
End Class