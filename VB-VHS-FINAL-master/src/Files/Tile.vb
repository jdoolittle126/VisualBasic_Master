Public Class Tile
    Property id As Integer
    Property id_mat1 As Integer
    Property id_mat2 As Integer
    Property material As Material
    Property material2 As Material
    Property texture As Rectangle
    Property texture2 As Rectangle


    Public Sub New(new_id As Integer, new_material As Material)
        Me.id = new_id
        Me.material = new_material
        Me.texture = New Rectangle(new_material.tileSquare.X + Constants.tileSize, new_material.tileSquare.Y + Constants.tileSize, Constants.tileSize, Constants.tileSize)
    End Sub

    Public Sub New(new_id1 As Integer, new_id2 As Integer, new_material1 As Material, new_material2 As Material)
        Me.id = 0
        Me.id_mat1 = new_id1
        Me.id_mat2 = new_id2
        Me.material = new_material1
        Me.material2 = new_material2
    End Sub

End Class
