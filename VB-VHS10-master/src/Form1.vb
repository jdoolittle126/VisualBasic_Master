Imports System.IO

'I plan on making improvements to this, I hope its not to bad to read

Public Class Form1
    Dim red, green, blue, rot, brushType, brushWidth, brushHeight As Integer
    Dim firstClick As Boolean = False
    Public gObjects As New List(Of graphicsObject)
    Dim toolBarVis As Boolean = True
    Dim coordKeeper As Boolean = True
    Dim x1, x2, y1, y2 As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rot = 0
        red = 0
        blue = 0
        green = 0
        brushType = 1
        brushWidth = 100
        brushHeight = 200
        LineToolStripMenuItem.Checked = True
        Me.Cursor = Cursors.Cross
        previewRefresh()
        AddHandler Me.Paint, AddressOf Me.Form1_Paint
        AddHandler MyBase.Paint, AddressOf Me.Form1_Paint
    End Sub


    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim g As Graphics = e.Graphics

        For Each obj In gObjects
            Dim objColor As Color
            objColor = obj.getColor
            g.TranslateTransform(0, 0)
            g.ResetTransform()
            Dim drawingPen As New Pen(objColor)
            Dim drawingBrush As New SolidBrush(objColor)

            If obj.getShape = 1 Then
                drawingPen.Width = obj.getWidth
                g.DrawLine(drawingPen, obj.getX, obj.getY, obj.getX2, obj.getY2)
            ElseIf obj.getShape = 2 Then
                g.TranslateTransform(obj.getX + (obj.getWidth * 0.5), obj.getY + (obj.getHeight * 0.5))
                g.RotateTransform(obj.getRot)
                g.FillEllipse(drawingBrush, Integer.Parse(0 - Math.Round(obj.getWidth / 2)), Integer.Parse(0 - Math.Round(obj.getHeight / 2)), obj.getWidth, obj.getHeight)
            Else
                g.TranslateTransform(obj.getX + (obj.getWidth * 0.5), obj.getY + (obj.getHeight * 0.5))
                g.RotateTransform(obj.getRot)
                g.FillRectangle(drawingBrush, Integer.Parse(0 - Math.Round(obj.getWidth / 2)), Integer.Parse(0 - Math.Round(obj.getHeight / 2)), obj.getWidth, obj.getHeight)
            End If
        Next


    End Sub

    Private Sub rotBar_Scroll(sender As Object, e As EventArgs) Handles rotBar.Scroll
        rot = rotBar.Value
        lblRot.Text = "Rotation: " + rot.ToString + "°"
    End Sub

    Private Sub SizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SizeToolStripMenuItem.Click
        If toolBarVis Then
            toolBarVis = False
            toolsPanel.Visible = False
            SizeToolStripMenuItem.Checked = False
        Else
            toolBarVis = True
            toolsPanel.Visible = True
            SizeToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Brush Type 1
    Private Sub LineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LineToolStripMenuItem.Click
        LineToolStripMenuItem.Checked = True
        ElipseToolStripMenuItem.Checked = False
        RectangleToolStripMenuItem.Checked = False
        brushType = 1
        Me.Cursor = Cursors.Cross
    End Sub

    'Brush Type 2
    Private Sub ElipseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElipseToolStripMenuItem.Click
        ElipseToolStripMenuItem.Checked = True
        LineToolStripMenuItem.Checked = False
        RectangleToolStripMenuItem.Checked = False
        brushType = 2
        Me.Cursor = Cursors.Arrow
    End Sub

    'Brush Type 3
    Private Sub RectangleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RectangleToolStripMenuItem.Click
        RectangleToolStripMenuItem.Checked = True
        LineToolStripMenuItem.Checked = False
        ElipseToolStripMenuItem.Checked = False
        brushType = 3
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub widthBar_Scroll(sender As Object, e As EventArgs) Handles widthBar.Scroll
        lblWH.Text = "Width: " + widthBar.Value.ToString + " ---- Height: " + heightBar.Value.ToString
        brushWidth = widthBar.Value
        previewRefresh()
    End Sub

    Private Sub heightBar_Scroll(sender As Object, e As EventArgs) Handles heightBar.Scroll
        lblWH.Text = "Width: " + widthBar.Value.ToString + " ---- Height: " + heightBar.Value.ToString
        brushHeight = heightBar.Value
        previewRefresh()
    End Sub

    Private Sub BackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        bgColorPicker.ShowDialog()
        Me.BackColor = bgColorPicker.Color
    End Sub

    Private Sub colorSample_Click(sender As Object, e As EventArgs) Handles colorSample.Click
        editColor()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        If gObjects IsNot Nothing Then
            If gObjects.Count > 0 Then
                gObjects.RemoveAt(gObjects.Count - 1)
                Me.Refresh()
            End If
        End If

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        openImage.Filter = "Image Files(*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp"
        If openImage.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim fileName As String = System.IO.Path.GetFullPath(openImage.FileName)
            Me.BackgroundImage = New Bitmap(openImage.FileName)
        End If
    End Sub

    Private Sub btnToForm_Click(sender As Object, e As EventArgs) Handles btnToForm.Click
        Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
    End Sub

    Private Sub btnToImage_Click(sender As Object, e As EventArgs) Handles btnToImage.Click
        If Me.BackgroundImage IsNot Nothing Then
            Me.Width = Me.BackgroundImage.Width
            Me.Height = Me.BackgroundImage.Height
        End If
    End Sub

    Private Sub BrushColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrushColorToolStripMenuItem.Click
        editColor()
    End Sub

    Public Sub editColor()
        colorPicker.ShowDialog()
        red = colorPicker.Color.R
        blue = colorPicker.Color.B
        green = colorPicker.Color.G
        colorSample.BackColor = colorPicker.Color
        previewRefresh()

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        If gObjects IsNot Nothing Then
            If gObjects.Count > 0 Then
                For i = gObjects.Count - 1 To 0 Step -1
                    gObjects.RemoveAt(i)
                Next i
                Me.Refresh()
            End If
        End If
    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick


        If coordKeeper Then
            x1 = -1
            y1 = -1
            coordKeeper = False
        End If

        If brushType > 1 Then
            Dim currentObject As New graphicsObject(red, green, blue, brushType, brushWidth, brushHeight, e.X - (0.5 * brushWidth), e.Y - (0.5 * brushHeight), rot)
            gObjects.Add(currentObject)

        Else
            If x1 = -1 And y1 = -1 Then
                x1 = e.X
                y1 = e.Y
            Else
                x2 = e.X
                y2 = e.Y
                Dim currentObject As New graphicsObject(red, green, blue, brushType, brushWidth, x1, y1, x2, y2, rot)
                gObjects.Add(currentObject)
                coordKeeper = True

            End If
        End If

        Me.Refresh()
    End Sub

    Private Sub Form1_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.Refresh()
    End Sub

    'WIP
    Private Sub previewRefresh()
        Dim previewGraphics As Graphics = brushPrev.CreateGraphics()
        Dim drawingBrush As New SolidBrush(colorPicker.Color)
        previewGraphics.TranslateTransform(brushPrev.Left, brushPrev.Top)
        previewGraphics.FillRectangle(drawingBrush, 0, 0, 50, 50)

        If brushType = 1 Then

        ElseIf brushType = 2 Then
            previewGraphics.FillEllipse(drawingBrush, 0, 0, widthBar.Value, heightBar.Value)
        Else

        End If
        brushPrev.Refresh()
    End Sub
End Class

'----------------------------------------------------------------------------------------------------------'

Public Class graphicsObject
    Private shapeType, colorRed, colorBlue, colorGreen, shapeWidth, shapeHeight, valX, valY, valX2, valY2, rot As Integer
    Protected Sub New(color As Color, type As Integer, width As Integer, height As Integer, leftLoc As Integer, topLoc As Integer, rot As Integer)
        Me.colorRed = color.R
        Me.colorGreen = color.G
        Me.colorBlue = color.B
        Me.shapeType = type
        Me.shapeWidth = width
        Me.shapeHeight = height
        Me.valX = leftLoc
        Me.valY = topLoc
        Me.rot = rot
    End Sub
    Public Sub New(red As Integer, green As Integer, blue As Integer, type As Integer, width As Integer, height As Integer, leftLoc As Integer, topLoc As Integer, rot As Integer)
        Me.colorRed = red
        Me.colorGreen = green
        Me.colorBlue = blue
        Me.shapeType = type
        Me.shapeWidth = width
        Me.shapeHeight = height
        Me.valX = leftLoc
        Me.valY = topLoc
        Me.rot = rot
    End Sub
    Public Sub New(color As Color, type As Integer, width As Integer, leftLoc As Integer, topLoc As Integer, leftLoc2 As Integer, topLoc2 As Integer, rot As Integer)
        Me.colorRed = color.R
        Me.colorGreen = color.G
        Me.colorBlue = color.B
        Me.shapeType = type
        Me.shapeWidth = width
        Me.valX = leftLoc
        Me.valY = topLoc
        Me.rot = rot
        Me.valX2 = leftLoc2
        Me.valY2 = topLoc2
    End Sub
    Public Sub New(red As Integer, green As Integer, blue As Integer, type As Integer, width As Integer, leftLoc As Integer, topLoc As Integer, leftLoc2 As Integer, topLoc2 As Integer, rot As Integer)
        Me.colorRed = red
        Me.colorGreen = green
        Me.colorBlue = blue
        Me.shapeType = type
        Me.shapeWidth = width
        Me.valX = leftLoc
        Me.valY = topLoc
        Me.rot = rot
        Me.valX2 = leftLoc2
        Me.valY2 = topLoc2
    End Sub
    'Could have used properties
    Public Function getShape()
        Return Me.shapeType
    End Function
    Public Function getRed()
        Return Me.colorRed
    End Function
    Public Function getGreen()
        Return Me.colorGreen
    End Function
    Public Function getBlue()
        Return Me.colorBlue
    End Function
    Public Function getColor()
        Return Color.FromArgb(colorRed, colorGreen, colorBlue)
    End Function
    Public Function getWidth()
        Return Me.shapeWidth
    End Function
    Public Function getHeight()
        Return Me.shapeHeight
    End Function
    Public Function getX()
        Return Me.valX
    End Function
    Public Function getY()
        Return Me.valY
    End Function
    Public Function getX2()
        Return Me.valX2
    End Function
    Public Function getY2()
        Return Me.valY2
    End Function
    Public Function getRot()
        Return Me.rot
    End Function
End Class

'----------------------------------------------------------------------------------------------------------'