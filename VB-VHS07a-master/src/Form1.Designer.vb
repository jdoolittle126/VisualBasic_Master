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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnTestPath = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVisionDown = New System.Windows.Forms.Button()
        Me.btnVisionUp = New System.Windows.Forms.Button()
        Me.lblDiverControls = New System.Windows.Forms.Label()
        Me.hasMouseControl = New System.Windows.Forms.CheckBox()
        Me.picShark = New System.Windows.Forms.PictureBox()
        Me.picDiver = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.picShark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDiver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUP
        '
        Me.btnUP.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnUP.Cursor = System.Windows.Forms.Cursors.PanNorth
        Me.btnUP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUP.Location = New System.Drawing.Point(38, 612)
        Me.btnUP.Name = "btnUP"
        Me.btnUP.Size = New System.Drawing.Size(50, 23)
        Me.btnUP.TabIndex = 1
        Me.btnUP.Text = "UP"
        Me.btnUP.UseVisualStyleBackColor = False
        '
        'btnRIGHT
        '
        Me.btnRIGHT.BackColor = System.Drawing.Color.Coral
        Me.btnRIGHT.Cursor = System.Windows.Forms.Cursors.PanEast
        Me.btnRIGHT.Location = New System.Drawing.Point(63, 634)
        Me.btnRIGHT.Name = "btnRIGHT"
        Me.btnRIGHT.Size = New System.Drawing.Size(51, 23)
        Me.btnRIGHT.TabIndex = 2
        Me.btnRIGHT.Text = "RIGHT"
        Me.btnRIGHT.UseVisualStyleBackColor = False
        '
        'btnLEFT
        '
        Me.btnLEFT.BackColor = System.Drawing.Color.Coral
        Me.btnLEFT.Cursor = System.Windows.Forms.Cursors.PanWest
        Me.btnLEFT.Location = New System.Drawing.Point(6, 634)
        Me.btnLEFT.Name = "btnLEFT"
        Me.btnLEFT.Size = New System.Drawing.Size(51, 23)
        Me.btnLEFT.TabIndex = 3
        Me.btnLEFT.Text = "LEFT"
        Me.btnLEFT.UseVisualStyleBackColor = False
        '
        'btnDOWN
        '
        Me.btnDOWN.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnDOWN.Cursor = System.Windows.Forms.Cursors.PanSouth
        Me.btnDOWN.Location = New System.Drawing.Point(38, 656)
        Me.btnDOWN.Name = "btnDOWN"
        Me.btnDOWN.Size = New System.Drawing.Size(50, 23)
        Me.btnDOWN.TabIndex = 4
        Me.btnDOWN.Text = "DOWN"
        Me.btnDOWN.UseVisualStyleBackColor = False
        '
        'btnSpdUp
        '
        Me.btnSpdUp.Location = New System.Drawing.Point(128, 482)
        Me.btnSpdUp.Name = "btnSpdUp"
        Me.btnSpdUp.Size = New System.Drawing.Size(79, 23)
        Me.btnSpdUp.TabIndex = 6
        Me.btnSpdUp.Text = "Speed Up"
        Me.btnSpdUp.UseVisualStyleBackColor = True
        '
        'btnSpdDwn
        '
        Me.btnSpdDwn.Location = New System.Drawing.Point(128, 511)
        Me.btnSpdDwn.Name = "btnSpdDwn"
        Me.btnSpdDwn.Size = New System.Drawing.Size(79, 23)
        Me.btnSpdDwn.TabIndex = 7
        Me.btnSpdDwn.Text = "Speed Down"
        Me.btnSpdDwn.UseVisualStyleBackColor = True
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Location = New System.Drawing.Point(125, 443)
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.btnTestPath)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblSpeed)
        Me.Panel1.Controls.Add(Me.btnVisionDown)
        Me.Panel1.Controls.Add(Me.btnVisionUp)
        Me.Panel1.Controls.Add(Me.lblDiverControls)
        Me.Panel1.Controls.Add(Me.hasMouseControl)
        Me.Panel1.Controls.Add(Me.btnUP)
        Me.Panel1.Controls.Add(Me.btnSpdDwn)
        Me.Panel1.Controls.Add(Me.btnRIGHT)
        Me.Panel1.Controls.Add(Me.btnSpdUp)
        Me.Panel1.Controls.Add(Me.btnDOWN)
        Me.Panel1.Controls.Add(Me.btnLEFT)
        Me.Panel1.Location = New System.Drawing.Point(1128, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(295, 720)
        Me.Panel1.TabIndex = 10
        '
        'btnTestPath
        '
        Me.btnTestPath.Location = New System.Drawing.Point(74, 251)
        Me.btnTestPath.Name = "btnTestPath"
        Me.btnTestPath.Size = New System.Drawing.Size(75, 23)
        Me.btnTestPath.TabIndex = 12
        Me.btnTestPath.Text = "Test Path"
        Me.btnTestPath.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Shark Speed"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 443)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Shark Maximum Sight"
        '
        'btnVisionDown
        '
        Me.btnVisionDown.Location = New System.Drawing.Point(13, 511)
        Me.btnVisionDown.Name = "btnVisionDown"
        Me.btnVisionDown.Size = New System.Drawing.Size(75, 23)
        Me.btnVisionDown.TabIndex = 9
        Me.btnVisionDown.Text = "Vision Down"
        Me.btnVisionDown.UseVisualStyleBackColor = True
        '
        'btnVisionUp
        '
        Me.btnVisionUp.Location = New System.Drawing.Point(13, 482)
        Me.btnVisionUp.Name = "btnVisionUp"
        Me.btnVisionUp.Size = New System.Drawing.Size(75, 23)
        Me.btnVisionUp.TabIndex = 8
        Me.btnVisionUp.Text = "Vision Up"
        Me.btnVisionUp.UseVisualStyleBackColor = True
        '
        'lblDiverControls
        '
        Me.lblDiverControls.AutoSize = True
        Me.lblDiverControls.Location = New System.Drawing.Point(17, 582)
        Me.lblDiverControls.Name = "lblDiverControls"
        Me.lblDiverControls.Size = New System.Drawing.Size(76, 13)
        Me.lblDiverControls.TabIndex = 6
        Me.lblDiverControls.Text = "Diver Controls:"
        '
        'hasMouseControl
        '
        Me.hasMouseControl.AutoSize = True
        Me.hasMouseControl.Location = New System.Drawing.Point(20, 685)
        Me.hasMouseControl.Name = "hasMouseControl"
        Me.hasMouseControl.Size = New System.Drawing.Size(94, 17)
        Me.hasMouseControl.TabIndex = 5
        Me.hasMouseControl.Text = "Mouse Control"
        Me.hasMouseControl.UseVisualStyleBackColor = True
        '
        'picShark
        '
        Me.picShark.BackColor = System.Drawing.Color.White
        Me.picShark.Location = New System.Drawing.Point(0, 0)
        Me.picShark.Name = "picShark"
        Me.picShark.Size = New System.Drawing.Size(50, 50)
        Me.picShark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShark.TabIndex = 5
        Me.picShark.TabStop = False
        '
        'picDiver
        '
        Me.picDiver.BackColor = System.Drawing.SystemColors.Control
        Me.picDiver.Image = CType(resources.GetObject("picDiver.Image"), System.Drawing.Image)
        Me.picDiver.Location = New System.Drawing.Point(580, 212)
        Me.picDiver.Name = "picDiver"
        Me.picDiver.Size = New System.Drawing.Size(94, 54)
        Me.picDiver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDiver.TabIndex = 0
        Me.picDiver.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1435, 744)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblCoords)
        Me.Controls.Add(Me.picShark)
        Me.Controls.Add(Me.picDiver)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnVisionDown As Button
    Friend WithEvents btnVisionUp As Button
    Friend WithEvents lblDiverControls As Label
    Friend WithEvents hasMouseControl As CheckBox
    Friend WithEvents btnTestPath As Button
End Class
