Public Class Form1
    Dim sharkSpeed As Integer = 3
    Dim diverSpeed As Integer = 6
    Dim isLeft As Boolean = True

    Dim formWidth As Integer = 1451 'getWidth()
    Dim formHeight As Integer = 782 'getHeight()

    Dim dirDict As New Dictionary(Of Object, Boolean)
    Dim sharkImage As Image = My.Resources.sharkTest
    Dim portalOImage As Image = My.Resources.portalOrange
    Dim portalBImage As Image = My.Resources.portalBlue
    Dim blockImage As Image = My.Resources.block
    Dim finalPath As Image = My.Resources.path
    Dim pathC As Image = My.Resources.pathC
    Dim posFillMatrix(Fix(formWidth / 50), Fix(formHeight / 50)) As Boolean
    Dim nodeMatrix(Fix(formWidth / 50), Fix(formHeight / 50)) As node
    Dim nodesLeft As Integer
    Dim myGraphics As Graphics = Me.CreateGraphics



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picShark.Image = sharkImage
        dirDict.Add(sharkImage, False)
        dirDict.Add(portalOImage, False)
        dirDict.Add(portalBImage, False)
        dirDict.Add(blockImage, False)

    End Sub
    'Shark Speed controls
    Private Sub btnSpdUp_Click(sender As Object, e As EventArgs) Handles btnSpdUp.Click
        sharkSpeed += 1
    End Sub

    Private Sub btnSpdDwn_Click(sender As Object, e As EventArgs) Handles btnSpdDwn.Click
        sharkSpeed -= 1
    End Sub

    Public Function getHeight()
        Return Height
    End Function

    Public Function getWidth()
        Return Width
    End Function


    Private Sub tickTimer_Tick(sender As Object, e As EventArgs) Handles tickTimer.Tick

        'picShark.Top += getVelocityTop(picShark, picDiver, sharkSpeed)
        'picShark.Left += getVelocityLeft(picShark, picDiver, sharkSpeed)

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
        'Some coords
        lblCoords.Text = "(" + Convert.ToString(picShark.Left) + " ," + Convert.ToString(picShark.Top) + ")"
    End Sub

    Public Sub invertDirectionBool(image As Image)
        If dirDict(image) Then
            dirDict(image) = False
        Else
            dirDict(image) = True
        End If

    End Sub

    Public Sub faceImageLeft(image As Image)
        If Not dirDict(image) Then
            invertDirectionBool(image)
            image.RotateFlip(RotateFlipType.RotateNoneFlipX)
        End If
    End Sub

    Public Sub faceImageRight(image As Image)
        If dirDict(image) Then
            invertDirectionBool(image)
            image.RotateFlip(RotateFlipType.RotateNoneFlipX)
        End If
    End Sub

    Public Function clampLeft(coordLeft As Integer)
        If coordLeft >= formWidth Then
            coordLeft = formWidth
        ElseIf coordLeft <= 0 Then
            coordLeft = 0
        End If
        Return coordLeft
    End Function

    Public Function clampTop(coordTop As Integer)
        If coordTop >= formHeight Then
            coordTop = formHeight
        ElseIf coordTop <= 0 Then
            coordTop = 0
        End If
        Return coordTop
    End Function

    Public Function getVelocityLeft(obj As Object, target As Object, leftSpeed As Integer)
        Dim velLeft As Integer = 0
        Dim angle As Double = Math.Atan((Math.Abs(target.Left - obj.Left)) / (Math.Abs(target.Top - obj.Top)))
        Dim distance As Double = Math.Sqrt(Math.Pow(target.Left - obj.Left, 2) + Math.Pow(target.Top - obj.Top, 2))
        If Math.Abs(distance) > 0 Then
            velLeft = Math.Round((((target.Left - obj.Left) / distance) * leftSpeed))
        End If
        Return velLeft
    End Function

    Public Function getVelocityTop(obj As Object, target As Object, topSpeed As Integer)
        Dim velTop As Integer = 0
        Dim angle As Double = Math.Atan((Math.Abs(target.Left - obj.Left)) / (Math.Abs(target.Top - obj.Top)))
        Dim distance As Double = Math.Sqrt(Math.Pow(target.Left - obj.Left, 2) + Math.Pow(target.Top - obj.Top, 2))
        If Math.Abs(distance) > 0 Then
            velTop = Math.Round((((target.Top - obj.Top) / distance) * topSpeed))
        End If
        Return velTop
    End Function

    'Method to find a path using Dijkstra's Algorithm
    Public Function findPath(obj As Object, leftTarget As Integer, topTarget As Integer, myGraphics As Graphics)

        Dim gridLeftFin As Integer = Fix(leftTarget / 50) 'X grid of finish
        Dim gridTopFin As Integer = Fix(topTarget / 50) 'Y grid of finish
        Dim gridLeftStart As Integer = Fix(obj.Left / 50) 'Starting point x grid
        Dim gridTopStart As Integer = Fix(obj.Top / 50) 'Starting point y grid
        Dim prev((Fix(formWidth / 50)) * (Fix(formHeight / 50))) As node 'Array of the node the current node was directed from
        Dim dist((Fix(formWidth / 50)) * (Fix(formHeight / 50))) As Integer 'Node value will give steps to start

        While nodesLeft > 0
            nodeMatrix(gridLeftStart, gridTopStart)
            prev()
            nodesLeft -=1
       End While

        Dim currentLeft As Integer = gridLeftStart
        Dim currentTop As Integer = gridTopStart


    End Function

    Public Sub editPosMap(posX As Integer, posY As Integer, setTo As Boolean)
        For i As Integer = 0 To Fix(formWidth / 50)
            For j As Integer = 0 To Fix(formHeight / 50)
                If i = posX Then
                    If j = posY Then
                        posFillMatrix(i, j) = setTo
                    End If
                End If
            Next
        Next
    End Sub

    Public Function getPosMap(posX As Integer, posY As Integer)
        Dim result As Boolean = False
        For i As Integer = 0 To Fix(formWidth / 50)
            For j As Integer = 0 To Fix(formHeight / 50)
                If i = posX Then
                    If j = posY Then
                        result = posFillMatrix(i, j)
                        GoTo end_of_for
                    End If
                End If
            Next
        Next

end_of_for:
        Return result
    End Function

    Sub fillPosMap(setTo As Boolean)
        For i As Integer = 0 To Fix(formWidth / 50)
            For j As Integer = 0 To Fix(formHeight / 50)
                Dim currentNode As node
                currentNode.setX(i)
                currentNode.setY(j)
                currentNode.setState(False)
                nodesLeft += 1

                posFillMatrix(i, j) = setTo
                nodeMatrix(i, j) = currentNode
            Next
        Next
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

    Private Sub btnTestPath_Click(sender As Object, e As EventArgs) Handles btnTestPath.Click
        fillPosMap(False)
        Dim rly = findPath(picShark, 300, 300, myGraphics)
    End Sub
End Class


Public Class node
    Private gridX As Integer
    Private gridY As Integer
    Private state As Boolean
    Private nodeValue As Integer

    Public Sub setX(x As Integer)
        gridX = x
    End Sub

    Public Sub setY(y As Integer)
        gridY = y
    End Sub

    Public Sub setState(currentState As Boolean)
        state = currentState
    End Sub

    Public Sub setNodeValue(val As Integer)
        nodeValue = val
    End Sub
End Class