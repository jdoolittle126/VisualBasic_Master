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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picFish = New System.Windows.Forms.PictureBox()
        Me.btnUP = New System.Windows.Forms.Button()
        Me.btnRIGHT = New System.Windows.Forms.Button()
        Me.btnLEFT = New System.Windows.Forms.Button()
        Me.btnDOWN = New System.Windows.Forms.Button()
        Me.lblPos = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.picFish, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFish
        '
        Me.picFish.BackColor = System.Drawing.SystemColors.Control
        Me.picFish.Image = CType(resources.GetObject("picFish.Image"), System.Drawing.Image)
        Me.picFish.Location = New System.Drawing.Point(337, 328)
        Me.picFish.Name = "picFish"
        Me.picFish.Size = New System.Drawing.Size(153, 89)
        Me.picFish.TabIndex = 0
        Me.picFish.TabStop = False
        '
        'btnUP
        '
        Me.btnUP.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnUP.Cursor = System.Windows.Forms.Cursors.PanNorth
        Me.btnUP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUP.Location = New System.Drawing.Point(689, 385)
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
        Me.btnRIGHT.Location = New System.Drawing.Point(746, 406)
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
        Me.btnLEFT.Location = New System.Drawing.Point(632, 406)
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
        Me.btnDOWN.Location = New System.Drawing.Point(689, 426)
        Me.btnDOWN.Name = "btnDOWN"
        Me.btnDOWN.Size = New System.Drawing.Size(75, 23)
        Me.btnDOWN.TabIndex = 4
        Me.btnDOWN.Text = "DOWN"
        Me.btnDOWN.UseVisualStyleBackColor = False
        '
        'lblPos
        '
        Me.lblPos.AutoSize = True
        Me.lblPos.Location = New System.Drawing.Point(689, 456)
        Me.lblPos.Name = "lblPos"
        Me.lblPos.Size = New System.Drawing.Size(100, 13)
        Me.lblPos.TabIndex = 5
        Me.lblPos.Text = "Fish pos: (337, 328)"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Crimson
        Me.btnReset.Location = New System.Drawing.Point(696, 406)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(52, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(817, 488)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblPos)
        Me.Controls.Add(Me.btnDOWN)
        Me.Controls.Add(Me.btnLEFT)
        Me.Controls.Add(Me.btnRIGHT)
        Me.Controls.Add(Me.btnUP)
        Me.Controls.Add(Me.picFish)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picFish, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picFish As PictureBox
    Friend WithEvents btnUP As Button
    Friend WithEvents btnRIGHT As Button
    Friend WithEvents btnLEFT As Button
    Friend WithEvents btnDOWN As Button
    Friend WithEvents lblPos As Label
    Friend WithEvents btnReset As Button
End Class
