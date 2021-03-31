<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.movementTimer = New System.Windows.Forms.Timer(Me.components)
        Me.startButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(12, 12)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 0
        Me.btn1.UseVisualStyleBackColor = True
        Me.btn1.Visible = False
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(93, 12)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 23)
        Me.btn2.TabIndex = 1
        Me.btn2.UseVisualStyleBackColor = True
        Me.btn2.Visible = False
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(417, 12)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(75, 23)
        Me.btn6.TabIndex = 3
        Me.btn6.UseVisualStyleBackColor = True
        Me.btn6.Visible = False
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(174, 11)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 23)
        Me.btn3.TabIndex = 2
        Me.btn3.UseVisualStyleBackColor = True
        Me.btn3.Visible = False
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(336, 11)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(75, 23)
        Me.btn5.TabIndex = 5
        Me.btn5.UseVisualStyleBackColor = True
        Me.btn5.Visible = False
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(255, 11)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(75, 23)
        Me.btn4.TabIndex = 4
        Me.btn4.UseVisualStyleBackColor = True
        Me.btn4.Visible = False
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.Location = New System.Drawing.Point(12, 606)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(164, 25)
        Me.lblPoints.TabIndex = 6
        Me.lblPoints.Text = "Score: 0 / 1,000"
        '
        'movementTimer
        '
        Me.movementTimer.Interval = 1
        '
        'startButton
        '
        Me.startButton.Font = New System.Drawing.Font("Lucida Console", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startButton.Location = New System.Drawing.Point(476, 224)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(163, 75)
        Me.startButton.TabIndex = 7
        Me.startButton.Text = "Start !"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 674)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents lblPoints As Label
    Friend WithEvents movementTimer As Timer
    Friend WithEvents startButton As Button
End Class
