Public Class Form1
    Dim points As Integer
    Dim time As Integer = 10
    Dim buttons As New List(Of buttonObj)
    Dim BASE_SPEED As Integer = 5
    Dim sizeCount As Integer = 50
    Dim timerCounter As Integer = 0
    Dim moveTimer As Integer = 0

    'Builds list on startup
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buttons.Add(New buttonObj(getRand(Me.Size.Width), getRand(Me.Size.Height), 1))
        buttons.Add(New buttonObj(getRand(Me.Size.Width), getRand(Me.Size.Height), 2))
        buttons.Add(New buttonObj(getRand(Me.Size.Width), getRand(Me.Size.Height), 3))
        buttons.Add(New buttonObj(getRand(Me.Size.Width), getRand(Me.Size.Height), 4))
        buttons.Add(New buttonObj(getRand(Me.Size.Width), getRand(Me.Size.Height), 5))
        buttons.Add(New buttonObj(getRand(Me.Size.Width), getRand(Me.Size.Height), 6))
        sizeCount = buttons(2).getWidth
        fixOverLaps(buttons)
    End Sub

    'Removes points and handles the button that moves away from mouse, as well as the button that changes size
    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        If startButton.Visible Then
            points -= Math.Abs((points / 25)) + 5
            'Button 4 Will run away from mouse on misclick
            buttons(3).setVelLeft(getVelocityLeft(buttons(3), MousePosition.X, MousePosition.Y, -(BASE_SPEED + buttons(0).getPointValue / 10)))
            buttons(3).setVelTop(getVelocityTop(buttons(3), MousePosition.X, MousePosition.Y, -(BASE_SPEED + buttons(0).getPointValue / 10)))
            sizeCount += 5
            sizeCount = clamp(sizeCount, 35, 125)
            buttons(2).setHeight(sizeCount)
            buttons(2).setWidth(sizeCount)
        End If
    End Sub

    '------------------------------------------------------- Button and Timer Subs -------------------------------------------------------'

    'Start button starts the timer that controls everything
    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        button1Function()
        button2Function()
        button3Function()
        button4Function()
        button5Function()
        button6Function()
        movementTimer.Enabled = True
        btn1.Visible = True
        btn2.Visible = True
        btn3.Visible = True
        btn4.Visible = True
        btn5.Visible = True
        btn6.Visible = True
        startButton.Visible = False
    End Sub

    'Add points, moves constantly
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        button1Function()
        points += buttons(0).getPointValue
    End Sub

    'Add points, jumps to location
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        button2Function()
        points += buttons(1).getPointValue
    End Sub

    'Changes size and moves 
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        button3Function()
        points += buttons(2).getPointValue
    End Sub

    'Moves away from mouse at speed
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        button4Function()
        points += buttons(3).getPointValue
    End Sub

    'Moves in random patterns
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        button5Function()
        points += buttons(4).getPointValue
    End Sub

    'Bounces off walls, random speeds
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        button6Function()
        points += buttons(5).getPointValue
    End Sub

    'Timer/Game loop
    Private Sub movementTimer_Tick(sender As Object, e As EventArgs) Handles movementTimer.Tick

        lblPoints.Text = "Score: " + points.ToString + " / 1,000" & vbCrLf & "-150 points will result in a loss!"

        'Button 1 Functions
        passOver(buttons(0))

        'Button 2 Functions
        moveTimer += 1
        If moveTimer > getRand(2500) Then
            findOpenSpot(buttons(1), buttons)
            moveTimer = 0
        End If

        'Button 3 Functions
        checkBounceWall(buttons(2))

        'Button 4 Functions
        passOver(buttons(3))

        'Button 5 Functions
        passOver(buttons(4))

        'Button 6 Functions
        checkBounceWall(buttons(5))

        'Sync
        buttons(0).sync(btn1)
        buttons(1).sync(btn2)
        buttons(2).sync(btn3)
        buttons(3).sync(btn4)
        buttons(4).sync(btn5)
        buttons(5).sync(btn6)

        'Check Win/Loss
        If points <= -150 Then
            lblPoints.Text = "You lost! Better luck next time!"
            btn1.Visible = False
            btn2.Visible = False
            btn3.Visible = False
            btn4.Visible = False
            btn5.Visible = False
            btn6.Visible = False
            timerCounter += 1
            If timerCounter > 300 Then

                Application.Restart()
                Me.Refresh()
            End If
        ElseIf points >= 1000 Then
            lblPoints.Text = "You win!"
            btn1.Visible = False
            btn2.Visible = False
            btn3.Visible = False
            btn4.Visible = False
            btn5.Visible = False
            btn6.Visible = False
            timerCounter += 1
            If timerCounter > 300 Then
                Application.Restart()
                Me.Refresh()
            End If
        End If
    End Sub

    '------------------------------------------------------- Functions/Subs used elsewhere in code -------------------------------------------------------'

    Public Sub button1Function()
        'Moves at a speed based on the points you earn from this button
        Dim leftLoc1 As Integer = getRand(Me.Size.Width)
        Dim topLoc1 As Integer = getRand(Me.Size.Height)

        buttons(0).setVelLeft(getVelocityLeft(buttons(0), leftLoc1, topLoc1, BASE_SPEED + buttons(0).getPointValue / 10))
        buttons(0).setVelTop(getVelocityTop(buttons(0), leftLoc1, topLoc1, BASE_SPEED + buttons(0).getPointValue / 10))
        setRandomColor(buttons(0))
        buttons(0).newPointValue(getRand(9))
    End Sub

    Public Sub button2Function()
        'Moves location
        findOpenSpot(buttons(1), buttons)
        setRandomColor(buttons(1))
        buttons(1).newPointValue(getRand(9))
    End Sub

    Public Sub button3Function()
        'Changes size, some code is in form1's clicked method
        buttons(2).setWidth(sizeCount)
        buttons(2).setHeight(sizeCount)
        buttons(2).setVelLeft(getVelocityLeft(buttons(2), getRand(Me.Size.Width), getRand(Me.Size.Height), BASE_SPEED - 2))
        buttons(2).setVelTop(getVelocityTop(buttons(2), getRand(Me.Size.Width), getRand(Me.Size.Height), BASE_SPEED - 2))
        sizeCount -= 2
        sizeCount = clamp(sizeCount, 35, 125)
        setRandomColor(buttons(2))
        buttons(2).newPointValue(getRand(9))
    End Sub

    Public Sub button4Function()
        'Moves away from mouse, code is mostly in form1's clicked method
        setRandomColor(buttons(3))
        buttons(3).newPointValue(getRand(9))
    End Sub

    Public Sub button5Function()
        'Random direction
        If getRand(2) = 1 Then
            buttons(4).setVelLeft(getRand(4))
            buttons(4).setVelTop(getRand(4))
        Else
            buttons(4).setVelLeft(-getRand(4))
            buttons(4).setVelTop(-getRand(4))
        End If
        setRandomColor(buttons(4))
        buttons(4).newPointValue(getRand(9))
    End Sub

    Public Sub button6Function()
        'X and Y movement are not related for this button
        buttons(5).setVelLeft(getVelocityLeft(buttons(5), getRand(Me.Size.Width), getRand(Me.Size.Height), BASE_SPEED))
        buttons(5).setVelTop(getVelocityTop(buttons(5), getRand(Me.Size.Width), getRand(Me.Size.Height), BASE_SPEED))
        setRandomColor(buttons(5))
        buttons(5).newPointValue(getRand(9))
    End Sub

    'Velocity X
    Public Function getVelocityLeft(obj As buttonObj, targetLeft As Integer, targetTop As Integer, leftSpeed As Integer)
        Dim velLeft As Integer = 0
        Dim angle As Double = Math.Atan((Math.Abs(targetLeft - obj.getLeft)) / (Math.Abs(targetTop - obj.getTop)))
        Dim distance As Double = Math.Sqrt(Math.Pow(targetLeft - obj.getLeft, 2) + Math.Pow(targetTop - obj.getTop, 2))
        If distance = 0 Then
            distance = 1
        End If

        velLeft = Math.Round((((targetLeft - obj.getLeft) / distance) * leftSpeed))
        Return velLeft
    End Function

    'Velocity Y
    Public Function getVelocityTop(obj As buttonObj, targetLeft As Integer, targetTop As Integer, topSpeed As Integer)
        Dim velTop As Integer = 0
        Dim angle As Double = Math.Atan((Math.Abs(targetLeft - obj.getLeft)) / (Math.Abs(targetTop - obj.getTop)))
        Dim distance As Double = Math.Sqrt(Math.Pow(targetLeft - obj.getLeft, 2) + Math.Pow(targetTop - obj.getTop, 2))
        If distance = 0 Then
            distance = 1
        End If

        velTop = Math.Round((((targetTop - obj.getTop) / distance) * topSpeed))
        Return velTop
    End Function

    'Bounces off the walls by reversing the velocity in X or Y 
    Public Sub checkBounceWall(obj As buttonObj)
        If (obj.getLeft <= 0 Or obj.getLeft + obj.getWidth >= Me.Size.Width) Then
            obj.setVelLeft(-obj.getVelLeft)
        ElseIf (obj.getTop <= 0 Or obj.getTop + obj.getHeight >= Me.Size.Height) Then
            obj.setVelTop(-obj.getVelTop)
        End If

    End Sub

    'Not quite perfect, so I decided not to use this method and do not handle button collisions
    Public Sub checkBounceButton(obj As buttonObj, list As List(Of buttonObj))
        For Each btn In list
            If Not btn.getID = obj.getID Then
                If checkOverlap(obj, btn) Then
                    If Math.Abs(obj.getLeft - btn.getLeft) * 2 > Math.Abs(obj.getTop - btn.getTop) * 2 Then
                        obj.setVelTop(-obj.getVelTop)
                        btn.setVelTop(-btn.getVelTop)
                    Else
                        obj.setVelLeft(-obj.getVelLeft)
                        btn.setVelLeft(-btn.getVelLeft)
                    End If
                End If
            End If
        Next
    End Sub

    'Gets a random color
    Public Sub setRandomColor(obj As buttonObj)
        obj.setR(getRand(255))
        obj.setG(getRand(255))
        obj.setB(getRand(255))
    End Sub

    'Passes over from top to bottom or left to right (and vice versa) of the form
    Public Sub passOver(obj As buttonObj)
        If (obj.getLeft > Me.Size.Width) Then
            obj.setLeft(0)
        ElseIf obj.getLeft < 0 Then
            obj.setLeft(Me.Size.Width)
        End If

        If (obj.getTop > Me.Size.Height) Then
            obj.setTop(0)
        ElseIf obj.getTop < 0 Then
            obj.setTop(Me.Size.Height)
        End If

    End Sub

    'Random number
    Public Function getRand(num As Integer)
        Dim random As Integer = CInt(Int((num * Rnd())))
        Return random
    End Function

    'Fixes overlaps by retrying positions until each button is in its own space; prob not the best way to do this
    Public Sub fixOverLaps(list As List(Of buttonObj))
Retry:
        For Each listBtn1 As buttonObj In list
            If (listBtn1.getLeft + listBtn1.getWidth + 10 >= Me.Size.Width Or listBtn1.getTop + listBtn1.getHeight + 10 >= Me.Size.Height) Then
                listBtn1.setLeft(Math.Abs(getRand(Me.Size.Width - listBtn1.getWidth)))
                listBtn1.setTop(Math.Abs(getRand(Me.Size.Height - listBtn1.getHeight)))
                GoTo Retry
            End If
            For Each listBtn2 As buttonObj In list

                If (checkOverlap(listBtn1, listBtn2) And Not listBtn1.getID = listBtn2.getID) Then
                    listBtn1.setLeft(listBtn1.getLeft + listBtn1.getWidth + 10)
                    listBtn1.setTop(listBtn1.getTop + listBtn1.getHeight + 10)
                    GoTo Retry
                End If
            Next
        Next
    End Sub

    'Finds an open spot, much like the fixOverLaps, but for 1 button
    Public Sub findOpenSpot(btn As buttonObj, list As List(Of buttonObj))
        btn.setLeft(getRand(Me.Size.Width - btn.getWidth))
        btn.setTop(getRand(Me.Size.Height - btn.getHeight))
Retry2:
        For Each listBtn In list
            If (checkOverlap(btn, listBtn) And Not btn.getID = listBtn.getID) Then
                btn.setLeft(getRand(Me.Size.Width - btn.getWidth))
                btn.setTop(getRand(Me.Size.Height - btn.getHeight))
                GoTo Retry2
            End If
        Next
    End Sub

    'Checks for collisions
    Public Function checkOverlap(obj1 As buttonObj, obj2 As buttonObj)
        Return Math.Abs(obj1.getLeft - obj2.getLeft) * 2 <= (obj1.getWidth + obj2.getWidth) And Math.Abs(obj1.getTop - obj2.getTop) * 2 <= (obj1.getHeight + obj2.getHeight)
    End Function

    'Simple clamp to limit numbers from going over max and under min
    Public Function clamp(val As Integer, min As Integer, max As Integer)
        If val >= max Then
            Return max
        ElseIf val <= min Then
            Return min
        Else
            Return val
        End If

    End Function

End Class

'My own button object that overlays the actual button, holding extra infromation and making the code above more readable and cleaner
Public Class buttonObj
    Private velTop, velLeft, top, left, width, height, r, g, b, pointVal, id As Integer

    Public Sub New(ByVal nTop As Integer, ByVal nLeft As Integer, ByVal id As Integer)
        Me.id = id
        Me.top = nTop
        Me.left = nLeft
        Me.velLeft = 0
        Me.velTop = 0
        Me.r = CInt(Int((255 * Rnd())))
        Me.g = CInt(Int((255 * Rnd())))
        Me.b = CInt(Int((255 * Rnd())))
        Me.width = 50
        Me.height = 50
        Me.pointVal = CInt(Int((9 * Rnd()) + 1)) 'Random number 1-9
    End Sub
    'Getters and Setters
    Public Sub setVelTop(vel As Integer)
        Me.velTop = vel
    End Sub
    Public Sub setVelLeft(vel As Integer)
        Me.velLeft = vel
    End Sub
    Public Function getVelTop()
        Return Me.velTop
    End Function
    Public Function getVelLeft()
        Return Me.velLeft
    End Function

    Public Function getID()
        Return Me.id
    End Function

    Public Sub setWidth(w As Integer)
        Me.width = w
    End Sub
    Public Sub setHeight(h As Integer)
        Me.height = h
    End Sub
    Public Function getWidth()
        Return Me.width
    End Function
    Public Function getHeight()
        Return Me.height
    End Function

    Public Sub setTop(t As Integer)
        Me.top = t
    End Sub
    Public Sub setLeft(l As Integer)
        Me.left = l
    End Sub
    Public Function getTop()
        Return Me.top
    End Function
    Public Function getLeft()
        Return Me.left
    End Function

    Public Function getPointValue()
        Return Me.pointVal
    End Function
    Public Sub newPointValue(val As Integer)
        Me.pointVal += val
    End Sub

    Public Sub setR(r As Integer)
        Me.r = r
    End Sub
    Public Sub setG(g As Integer)
        Me.g = g
    End Sub
    Public Sub setB(b As Integer)
        Me.b = b
    End Sub

    'Syncs the info from the button to this object
    Public Sub sync(btn As Button)
        btn.Top = Me.top
        btn.Left = Me.left

        btn.Text = Me.pointVal
        btn.ForeColor = Color.FromArgb(255, Math.Abs(255 - Me.r), Math.Abs(255 - Me.g), Math.Abs(255 - Me.b))
        btn.Left += Me.velLeft
        btn.Top += Me.velTop
        Me.left += Me.velLeft
        Me.top += Me.velTop
        btn.Width = Me.width
        btn.Height = Me.height
        btn.BackColor = Color.FromArgb(255, Me.r, Me.g, Me.b)
    End Sub

End Class