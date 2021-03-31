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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnUP = New System.Windows.Forms.Button()
        Me.btnRIGHT = New System.Windows.Forms.Button()
        Me.btnLEFT = New System.Windows.Forms.Button()
        Me.btnDOWN = New System.Windows.Forms.Button()
        Me.btnSpdUp = New System.Windows.Forms.Button()
        Me.btnSpdDwn = New System.Windows.Forms.Button()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.tickTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblCoords = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.blackholeBox = New System.Windows.Forms.PictureBox()
        Me.picShark = New System.Windows.Forms.PictureBox()
        Me.picDiver = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGravDwn = New System.Windows.Forms.Button()
        Me.btnGravUp = New System.Windows.Forms.Button()
        CType(Me.blackholeBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDiver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUP
        '
        Me.btnUP.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnUP.Cursor = System.Windows.Forms.Cursors.PanNorth
        Me.btnUP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUP.Location = New System.Drawing.Point(69, 668)
        Me.btnUP.Name = "btnUP"
        Me.btnUP.Size = New System.Drawing.Size(75, 23)
        Me.btnUP.TabIndex = 1
        Me.btnUP.Text = "UP"
        Me.btnUP.UseVisualStyleBackColor = False
        '
        'btnRIGHT
        '
        Me.btnRIGHT.BackColor = System.Drawing.Color.Coral
        Me.btnRIGHT.Cursor = System.Windows.Forms.Cursors.PanEast
        Me.btnRIGHT.Location = New System.Drawing.Point(126, 689)
        Me.btnRIGHT.Name = "btnRIGHT"
        Me.btnRIGHT.Size = New System.Drawing.Size(75, 23)
        Me.btnRIGHT.TabIndex = 2
        Me.btnRIGHT.Text = "RIGHT"
        Me.btnRIGHT.UseVisualStyleBackColor = False
        '
        'btnLEFT
        '
        Me.btnLEFT.BackColor = System.Drawing.Color.Coral
        Me.btnLEFT.Cursor = System.Windows.Forms.Cursors.PanWest
        Me.btnLEFT.Location = New System.Drawing.Point(12, 689)
        Me.btnLEFT.Name = "btnLEFT"
        Me.btnLEFT.Size = New System.Drawing.Size(75, 23)
        Me.btnLEFT.TabIndex = 3
        Me.btnLEFT.Text = "LEFT"
        Me.btnLEFT.UseVisualStyleBackColor = False
        '
        'btnDOWN
        '
        Me.btnDOWN.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnDOWN.Cursor = System.Windows.Forms.Cursors.PanSouth
        Me.btnDOWN.Location = New System.Drawing.Point(69, 709)
        Me.btnDOWN.Name = "btnDOWN"
        Me.btnDOWN.Size = New System.Drawing.Size(75, 23)
        Me.btnDOWN.TabIndex = 4
        Me.btnDOWN.Text = "DOWN"
        Me.btnDOWN.UseVisualStyleBackColor = False
        '
        'btnSpdUp
        '
        Me.btnSpdUp.Location = New System.Drawing.Point(1373, 689)
        Me.btnSpdUp.Name = "btnSpdUp"
        Me.btnSpdUp.Size = New System.Drawing.Size(88, 23)
        Me.btnSpdUp.TabIndex = 6
        Me.btnSpdUp.Text = "Speed Up"
        Me.btnSpdUp.UseVisualStyleBackColor = True
        '
        'btnSpdDwn
        '
        Me.btnSpdDwn.Location = New System.Drawing.Point(1373, 718)
        Me.btnSpdDwn.Name = "btnSpdDwn"
        Me.btnSpdDwn.Size = New System.Drawing.Size(88, 23)
        Me.btnSpdDwn.TabIndex = 7
        Me.btnSpdDwn.Text = "Speed Down"
        Me.btnSpdDwn.UseVisualStyleBackColor = True
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Location = New System.Drawing.Point(1356, 637)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(105, 13)
        Me.lblSpeed.TabIndex = 8
        Me.lblSpeed.Text = "Shark Speed Control"
        '
        'tickTimer
        '
        Me.tickTimer.Enabled = True
        '
        'lblCoords
        '
        Me.lblCoords.AutoSize = True
        Me.lblCoords.Location = New System.Drawing.Point(1397, 668)
        Me.lblCoords.Name = "lblCoords"
        Me.lblCoords.Size = New System.Drawing.Size(0, 13)
        Me.lblCoords.TabIndex = 9
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'blackholeBox
        '
        Me.blackholeBox.Image = Global.WindowsApplication1.My.Resources.Resources.blackHole
        Me.blackholeBox.Location = New System.Drawing.Point(753, 141)
        Me.blackholeBox.Name = "blackholeBox"
        Me.blackholeBox.Size = New System.Drawing.Size(415, 281)
        Me.blackholeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blackholeBox.TabIndex = 10
        Me.blackholeBox.TabStop = False
        '
        'picShark
        '
        Me.picShark.BackColor = System.Drawing.Color.White
        Me.picShark.Location = New System.Drawing.Point(32, 27)
        Me.picShark.Name = "picShark"
        Me.picShark.Size = New System.Drawing.Size(99, 42)
        Me.picShark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShark.TabIndex = 5
        Me.picShark.TabStop = False
        '
        'picDiver
        '
        Me.picDiver.BackColor = System.Drawing.SystemColors.Control
        Me.picDiver.Image = CType(resources.GetObject("picDiver.Image"), System.Drawing.Image)
        Me.picDiver.Location = New System.Drawing.Point(493, 183)
        Me.picDiver.Name = "picDiver"
        Me.picDiver.Size = New System.Drawing.Size(94, 54)
        Me.picDiver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDiver.TabIndex = 0
        Me.picDiver.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1241, 637)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Gravity of hole"
        '
        'btnGravDwn
        '
        Me.btnGravDwn.Location = New System.Drawing.Point(1228, 718)
        Me.btnGravDwn.Name = "btnGravDwn"
        Me.btnGravDwn.Size = New System.Drawing.Size(88, 23)
        Me.btnGravDwn.TabIndex = 12
        Me.btnGravDwn.Text = "Gravity Down"
        Me.btnGravDwn.UseVisualStyleBackColor = True
        '
        'btnGravUp
        '
        Me.btnGravUp.Location = New System.Drawing.Point(1228, 689)
        Me.btnGravUp.Name = "btnGravUp"
        Me.btnGravUp.Size = New System.Drawing.Size(88, 23)
        Me.btnGravUp.TabIndex = 11
        Me.btnGravUp.Text = "Gravity Up"
        Me.btnGravUp.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1473, 743)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGravDwn)
        Me.Controls.Add(Me.btnGravUp)
        Me.Controls.Add(Me.lblCoords)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.btnSpdDwn)
        Me.Controls.Add(Me.btnSpdUp)
        Me.Controls.Add(Me.picShark)
        Me.Controls.Add(Me.btnDOWN)
        Me.Controls.Add(Me.btnLEFT)
        Me.Controls.Add(Me.btnRIGHT)
        Me.Controls.Add(Me.btnUP)
        Me.Controls.Add(Me.picDiver)
        Me.Controls.Add(Me.blackholeBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.blackholeBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDiver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUP As Button
    Friend WithEvents btnRIGHT As Button
    Friend WithEvents btnLEFT As Button
    Friend WithEvents btnDOWN As Button
    Friend WithEvents picDiver As PictureBox
    Friend WithEvents picShark As PictureBox
    Friend WithEvents btnSpdUp As Button
    Friend WithEvents btnSpdDwn As Button
    Friend WithEvents lblSpeed As Label
    Friend WithEvents tickTimer As Timer
    Friend WithEvents lblCoords As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents blackholeBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGravDwn As Button
    Friend WithEvents btnGravUp As Button
End Class
