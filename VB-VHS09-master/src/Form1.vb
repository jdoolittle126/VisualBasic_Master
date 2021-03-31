Public Class Form1
    Dim globalName As String
    Dim drawingForm As New Form()

    Private Sub btnGlobalName_Click(sender As Object, e As EventArgs) Handles btnGlobalName.Click
        globalName = InputBox("Please enter your name")
    End Sub


    Private Sub btnName_Click(sender As Object, e As EventArgs) Handles btnName.Click
        Randomize()

        Dim counter As Integer
        Dim xVal As Integer
        Dim yVal As Integer
        Dim myName As String = InputBox("Please enter your name")
        showForm(drawingForm)
        Dim myFormObj As Graphics = drawingForm.CreateGraphics
        Dim objFont As Font = New System.Drawing.Font("arial", 20)

        For counter = 1 To 5
            xVal = Math.Abs(CInt(Int((500 * Rnd()) + 1)))
            yVal = Math.Abs(CInt(Int((500 * Rnd()) + 1)))
            myFormObj.DrawString(myName, objFont, Drawing.Brushes.DeepPink, xVal, yVal)
        Next
    End Sub

    Private Sub btnName2_Click(sender As Object, e As EventArgs) Handles btnName2.Click
        Dim counter As Integer
        Dim myName As String = InputBox("Please enter your name")
        showForm(drawingForm)
        Dim myFormObj As Graphics = drawingForm.CreateGraphics
        Dim objFont As Font = New System.Drawing.Font("arial", 20)

        For counter = 1 To 5
            myFormObj.DrawString(myName, objFont, Drawing.Brushes.Coral, counter * 50, counter * 50)
        Next
    End Sub

    Private Sub btnGlobalName1_Click(sender As Object, e As EventArgs) Handles btnGlobalName1.Click
        Randomize()
        drawingForm.Show()
        Dim counter As Integer
        Dim xVal As Integer
        Dim yVal As Integer
        Dim myFormObj As Graphics = drawingForm.CreateGraphics
        Dim objFont As Font = New System.Drawing.Font("arial", 20)
        showForm(drawingForm)
        For counter = 1 To 5
            xVal = Math.Abs(CInt(Int((drawingForm.Width * Rnd()) + 1)))
            yVal = Math.Abs(CInt(Int((drawingForm.Height * Rnd()) + 1)))
            myFormObj.DrawString(globalName, objFont, Drawing.Brushes.Gold, xVal, yVal)
        Next
    End Sub

    Private Sub btnGlobalName2_Click(sender As Object, e As EventArgs) Handles btnGlobalName2.Click
        Dim counter As Integer
        Dim myFormObj As Graphics = drawingForm.CreateGraphics
        Dim objFont As Font = New System.Drawing.Font("arial", 20)
        showForm(drawingForm)
        For counter = 1 To 5
            myFormObj.DrawString(globalName, objFont, Drawing.Brushes.Lime, counter * 50, counter * 50)
        Next
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        showForm(drawingForm)
        drawingForm.BackColor = getColor()
    End Sub

    Public Function getColor()
        Randomize()
        Return Color.FromArgb(CInt(Rnd() * 255), CInt(Rnd() * 255), CInt(Rnd() * 255))
    End Function

    Public Sub showForm(myForm As Form)
        myForm.Text = "Drawing Area"
        myForm.Size = New Size(500, 500)
        myForm.MinimumSize = New Size(500, 500)
        myForm.MaximumSize = New Size(500, 500)
        myForm.Show()
    End Sub
End Class
