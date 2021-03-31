Public Class Material
    Property name As String
    Property isWalkable As Boolean
    Property isBuildable As Boolean
    Property nutritionVal As Double
    Property animationFrames As Integer
    Property tileType As Integer 'Layer to be used on
    Property tileSquare As Rectangle 'Where all animation tiles are 1 square over

    Public Sub New(new_Name As String, new_isWalkable As Boolean, new_isBuildable As Boolean, new_nutritionVal As Double, new_animationFrames As Integer, new_tileType As Integer, new_tileSquare As Rectangle)
        Me.name = new_Name
        Me.isWalkable = new_isWalkable
        Me.isBuildable = new_isBuildable
        Me.nutritionVal = new_nutritionVal
        Me.animationFrames = new_animationFrames
        Me.tileType = new_tileType
        Me.tileSquare = new_tileSquare
    End Sub

End Class
