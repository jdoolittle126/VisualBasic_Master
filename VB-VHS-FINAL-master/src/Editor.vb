Imports System.ComponentModel

Public Class Editor

    Dim g As Graphics

    Dim mat_Grass As Material = New Material("Grass", True, True, 1.0, 1, 1, New Rectangle(0, 0, Constants.tileSize * 3, Constants.tileSize * 3))
    Dim mat_Sand As Material = New Material("Sand", True, True, 0.0, 1, 1, New Rectangle(Constants.tileSize * 3, 0, Constants.tileSize * 3, Constants.tileSize * 3))
    Dim tile_Grass As Tile = New Tile(1, mat_Grass)
    Dim tile_Sand As Tile = New Tile(2, mat_Sand)

    Dim bmp_scr As Bitmap
    Dim width As Integer = Constants.mapWidth
    Dim height As Integer = Constants.mapHeight
    Dim edit_map(width, height) As Tile
    Dim selectedMaterial As Integer = 1


    Private Sub Editor_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        g = Me.CreateGraphics
        bmp_scr = New Bitmap(Assets.pbAssets.Image)
        bmp_scr.MakeTransparent(Color.Fuchsia)
        firstRender(g)
        updateTimer.Enabled = True

    End Sub


    Private Sub updateTimer_Tick(sender As Object, e As EventArgs) Handles updateTimer.Tick
        g = Me.CreateGraphics
        bmp_scr = New Bitmap(Assets.pbAssets.Image)
        bmp_scr.MakeTransparent(Color.Fuchsia)

        For x = 0 To width
            For y = 0 To height
                Dim destination As Rectangle = New Rectangle(x * Constants.tileSize, y * Constants.tileSize, Constants.tileSize, Constants.tileSize)
                g.DrawImage(bmp_scr, destination, edit_map(x, y).texture, GraphicsUnit.Pixel)
                g.DrawImage(bmp_scr, destination, New Rectangle(0, Constants.tileSize * 6, Constants.tileSize, Constants.tileSize), GraphicsUnit.Pixel)
            Next
        Next
    End Sub

    Public Sub firstRender(g As Graphics)
        For x = 0 To width
            For y = 0 To height
                Dim destination As Rectangle = New Rectangle(x * Constants.tileSize, y * Constants.tileSize, Constants.tileSize, Constants.tileSize)
                g.DrawImage(bmp_scr, destination, tile_Grass.texture, GraphicsUnit.Pixel)
                g.DrawImage(bmp_scr, destination, New Rectangle(0, Constants.tileSize * 6, Constants.tileSize, Constants.tileSize), GraphicsUnit.Pixel)
                edit_map(x, y) = tile_Grass
            Next
        Next

    End Sub

    Private Sub btnGrass_Click(sender As Object, e As EventArgs) Handles btnGrass.Click
        selectedMaterial = 1
    End Sub

    Private Sub btnSand_Click(sender As Object, e As EventArgs) Handles btnSand.Click
        selectedMaterial = 2
    End Sub



    Private Sub Form1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseClick
        Dim p As Point = Me.PointToClient(Me.MousePosition)
        If selectedMaterial = 1 Then
            edit_map(Math.Floor((p.X) / Constants.tileSize), Math.Floor(p.Y / Constants.tileSize)) = tile_Grass
        Else
            edit_map(Math.Floor(p.X / Constants.tileSize), Math.Floor(p.Y / Constants.tileSize)) = tile_Sand
        End If
    End Sub

    Private Sub btnSaveMap_Click(sender As Object, e As EventArgs) Handles btnSaveMap.Click
        Main.editor_map = edit_map
        Main.editHasContent = True
        Me.Close()
    End Sub
End Class