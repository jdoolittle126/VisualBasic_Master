Public Class Main
    '(new_Name, new_isWalkable, new_isBuildable, new_nutritionVal, new_animationFrames, new_tileType, new_tileSquare)

    Dim tileSize As Integer = Constants.tileSize

    Dim mat_Grass As Material = New Material("Grass", True, True, 1.0, 1, 1, New Rectangle(0, 0, tileSize * 3, tileSize * 3))
    Dim mat_Sand As Material = New Material("Sand", True, True, 0.0, 1, 1, New Rectangle(tileSize * 3, 0, tileSize * 3, tileSize * 3))
    Dim mat_Water As Material = New Material("Water", False, False, -1.0, 2, 2, New Rectangle(0, tileSize * 3, tileSize * 3, tileSize * 3))
    Dim tile_Grass As Tile = New Tile(1, mat_Grass)
    Dim tile_Sand As Tile = New Tile(2, mat_Sand)
    Dim tile_Water As Tile = New Tile(3, mat_Water)



    Dim mapWidth As Integer = Constants.mapWidth
    Dim mapHeight As Integer = Constants.mapHeight
    Dim G As Graphics
    Dim assets As New Assets
    Dim bmp_scr As Bitmap
    Dim viewPortWidth As Integer = 16 'Can not be larger than the map
    Dim viewPortHeight As Integer = 11
    Dim viewPortX, viewPortY As Integer

    Dim map_lower(mapWidth, mapHeight) As Tile 'Base Map
    Dim map_upper(mapWidth, mapHeight) As Tile 'Raised Map for dynamic tiles, but below entity layer

    Public Shared editor_map(Constants.mapWidth, Constants.mapHeight) As Tile
    Public Shared editHasContent As Boolean = False

    Private Sub btn_genMap(sender As Object, e As EventArgs) Handles btnGenMap.Click

        For x = 0 To mapWidth
            For y = 0 To mapHeight
                map_lower(x, y) = tile_Grass
            Next
        Next

        If editHasContent Then
            map_lower = editor_map
        End If

        forgeBaseHybrids()

    End Sub

    Private Sub btn_drawMap(sender As Object, e As EventArgs) Handles btnDrawMap.Click
        If renderLoop.Enabled Then
            renderLoop.Enabled = False
            btnDrawMap.Text = "Drawing Map: FALSE"
        Else
            renderLoop.Enabled = True
            btnDrawMap.Text = "Drawing Map: TRUE"
        End If
    End Sub

    Private Sub renderLoop_Tick(sender As Object, e As EventArgs) Handles renderLoop.Tick
        G = Me.CreateGraphics
        bmp_scr = New Bitmap(assets.pbAssets.Image)
        If map_lower(0, 0) IsNot Nothing Then
            drawTiles(G)
        End If
    End Sub

    Private Sub btn_editMap(sender As Object, e As EventArgs) Handles btnMapEditor.Click
        Dim mapEditor As Editor = New Editor()
        editHasContent = False
        mapEditor.Show()

    End Sub


    Public Sub drawTiles(G As Graphics)
        For x = viewPortX To viewPortWidth + viewPortX
            For y = viewPortY To viewPortHeight + viewPortY

                Dim dest As Rectangle = New Rectangle(x * tileSize, y * tileSize, tileSize, tileSize) 'The location to be drawn at

                If map_lower(x, y).id = 0 Then
                    'Hybrid Tile

                    bmp_scr.MakeTransparent(Color.Fuchsia)
                    G.DrawImage(bmp_scr, dest, map_lower(x, y).texture, GraphicsUnit.Pixel)  'Top or Left Texture
                    G.DrawImage(bmp_scr, dest, map_lower(x, y).texture2, GraphicsUnit.Pixel) 'Bottom or Right Texture

                Else
                    'Standard Tile

                    G.DrawImage(bmp_scr, dest, map_lower(x, y).texture, GraphicsUnit.Pixel)

                End If
            Next
        Next
    End Sub

    'Creates a hybrid tile that holds both textures when two meet, for the entire base map
    Public Sub forgeBaseHybrids()
        For x = 1 To mapWidth - 1       'Only blend in the middle section of the map, blending on the edges doesn't make sense
            For y = 1 To mapHeight - 1
                If map_lower(x - 1, y).id <> map_lower(x, y).id And map_lower(x - 1, y).id <> 0 And map_lower(x, y).id <> 0 Then

                    Dim id1 As Integer = map_lower(x - 1, y).id
                    Dim id2 As Integer = map_lower(x, y).id
                    Dim mat1Tile As Material = map_lower(x - 1, y).material 'Texture Left to Right
                    Dim mat2Tile As Material = map_lower(x, y).material

                    map_lower(x, y) = New Tile(id1, id2, mat1Tile, mat2Tile)
                    map_lower(x, y).texture = New Rectangle(mat1Tile.tileSquare.X + (2 * tileSize), mat1Tile.tileSquare.Y + tileSize, tileSize, tileSize)
                    map_lower(x, y).texture2 = New Rectangle(mat2Tile.tileSquare.X, mat2Tile.tileSquare.Y + (tileSize), tileSize, tileSize)

                ElseIf map_lower(x + 1, y).id <> map_lower(x, y).id And map_lower(x + 1, y).id <> 0 And map_lower(x, y).id <> 0 Then

                    Dim id1 As Integer = map_lower(x, y).id
                    Dim id2 As Integer = map_lower(x + 1, y).id
                    Dim mat1Tile As Material = map_lower(x, y).material 'Texture Left to Right
                    Dim mat2Tile As Material = map_lower(x + 1, y).material

                    map_lower(x, y) = New Tile(id1, id2, mat1Tile, mat2Tile)
                    map_lower(x, y).texture = New Rectangle(mat1Tile.tileSquare.X + (2 * tileSize), mat1Tile.tileSquare.Y + tileSize, tileSize, tileSize)
                    map_lower(x, y).texture2 = New Rectangle(mat2Tile.tileSquare.X, mat2Tile.tileSquare.Y + (tileSize), tileSize, tileSize)

                ElseIf map_lower(x, y - 1).id <> map_lower(x, y).id And map_lower(x, y - 1).id <> 0 And map_lower(x, y).id <> 0 Then

                    Dim id1 As Integer = map_lower(x, y - 1).id
                    Dim id2 As Integer = map_lower(x, y).id
                    Dim mat1Tile As Material = map_lower(x, y - 1).material 'Texture Top to Bottom
                    Dim mat2Tile As Material = map_lower(x, y).material

                    map_lower(x, y) = New Tile(id1, id2, mat1Tile, mat2Tile)
                    map_lower(x, y).texture = New Rectangle(mat1Tile.tileSquare.X + (tileSize), mat1Tile.tileSquare.Y + (2 * tileSize), tileSize, tileSize)
                    map_lower(x, y).texture2 = New Rectangle(mat2Tile.tileSquare.X + (tileSize), mat2Tile.tileSquare.Y, tileSize, tileSize)

                ElseIf map_lower(x, y + 1).id <> map_lower(x, y).id And map_lower(x, y + 1).id <> 0 And map_lower(x, y).id <> 0 Then

                    Dim id1 As Integer = map_lower(x, y).id
                    Dim id2 As Integer = map_lower(x, y + 1).id
                    Dim mat1Tile As Material = map_lower(x, y).material 'Texture Top to Bottom
                    Dim mat2Tile As Material = map_lower(x, y + 1).material

                    map_lower(x, y) = New Tile(id1, id2, mat1Tile, mat2Tile)
                    map_lower(x, y).texture = New Rectangle(mat1Tile.tileSquare.X + (tileSize), mat1Tile.tileSquare.Y + (2 * tileSize), tileSize, tileSize)
                    map_lower(x, y).texture2 = New Rectangle(mat2Tile.tileSquare.X + (tileSize), mat2Tile.tileSquare.Y, tileSize, tileSize)

                End If
            Next
        Next

        For x = 1 To mapWidth - 1       'Corner Tiles WIP
            For y = 1 To mapHeight - 1
                If map_lower(x, y).id = 0 Then
                    Dim neighbourCount As Integer = 0
                    If map_lower(x - 1, y).id = 0 Then
                        neighbourCount += 1
                    End If
                    If map_lower(x + 1, y).id = 0 Then
                        neighbourCount += 1
                    End If
                    If map_lower(x, y - 1).id = 0 Then
                        neighbourCount += 1
                    End If
                    If map_lower(x, y + 1).id = 0 Then
                        neighbourCount += 1
                    End If

                    If neighbourCount = 0 Then
                        'make a dot tile
                    ElseIf neighbourCount = 1 Then
                        'make a roundoff tile
                    ElseIf neighbourCount = 2 Then
                        'no change or make a corner tile
                    ElseIf neighbourCount = 3 Then
                        'no change or make tri-tile or corner and no change
                    Else
                        'all 4 sides touched, replace with normal tile
                    End If

                End If
            Next
        Next

    End Sub

End Class