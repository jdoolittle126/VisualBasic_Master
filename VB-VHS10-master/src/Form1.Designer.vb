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
        Me.toolbar = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElipseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RectangleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrushColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrushToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.colorSample = New System.Windows.Forms.PictureBox()
        Me.lblColorSample = New System.Windows.Forms.Label()
        Me.colorPicker = New System.Windows.Forms.ColorDialog()
        Me.toolsPanel = New System.Windows.Forms.Panel()
        Me.btnToImage = New System.Windows.Forms.Button()
        Me.btnToForm = New System.Windows.Forms.Button()
        Me.brushPrev = New System.Windows.Forms.PictureBox()
        Me.lblWH = New System.Windows.Forms.Label()
        Me.heightBar = New System.Windows.Forms.TrackBar()
        Me.widthBar = New System.Windows.Forms.TrackBar()
        Me.lblRot = New System.Windows.Forms.Label()
        Me.rotBar = New System.Windows.Forms.TrackBar()
        Me.lblBrushSample = New System.Windows.Forms.Label()
        Me.bgColorPicker = New System.Windows.Forms.ColorDialog()
        Me.openImage = New System.Windows.Forms.OpenFileDialog()
        Me.toolbar.SuspendLayout()
        CType(Me.colorSample, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolsPanel.SuspendLayout()
        CType(Me.brushPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.heightBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.widthBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rotBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolbar
        '
        Me.toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.BrushToolStripMenuItem})
        Me.toolbar.Location = New System.Drawing.Point(0, 0)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.Size = New System.Drawing.Size(1209, 24)
        Me.toolbar.TabIndex = 2
        Me.toolbar.Text = "Tool Bar"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.OpenToolStripMenuItem, Me.UndoToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.SaveToolStripMenuItem.Text = "Save (WIP)"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ClearToolStripMenuItem.Text = "Clear Canvas"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LineToolStripMenuItem, Me.ElipseToolStripMenuItem, Me.RectangleToolStripMenuItem, Me.BrushColorToolStripMenuItem, Me.BackgroundColorToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ToolsToolStripMenuItem.Text = "Drawing"
        Me.ToolsToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'LineToolStripMenuItem
        '
        Me.LineToolStripMenuItem.Checked = True
        Me.LineToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LineToolStripMenuItem.Name = "LineToolStripMenuItem"
        Me.LineToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.LineToolStripMenuItem.Text = "Line"
        '
        'ElipseToolStripMenuItem
        '
        Me.ElipseToolStripMenuItem.Name = "ElipseToolStripMenuItem"
        Me.ElipseToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ElipseToolStripMenuItem.Text = "Elipse"
        '
        'RectangleToolStripMenuItem
        '
        Me.RectangleToolStripMenuItem.Name = "RectangleToolStripMenuItem"
        Me.RectangleToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.RectangleToolStripMenuItem.Text = "Rectangle"
        '
        'BrushColorToolStripMenuItem
        '
        Me.BrushColorToolStripMenuItem.Name = "BrushColorToolStripMenuItem"
        Me.BrushColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BrushColorToolStripMenuItem.Text = "Brush Color"
        '
        'BackgroundColorToolStripMenuItem
        '
        Me.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
        Me.BackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BackgroundColorToolStripMenuItem.Text = "Background Color"
        '
        'BrushToolStripMenuItem
        '
        Me.BrushToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SizeToolStripMenuItem})
        Me.BrushToolStripMenuItem.Name = "BrushToolStripMenuItem"
        Me.BrushToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.BrushToolStripMenuItem.Text = "View"
        '
        'SizeToolStripMenuItem
        '
        Me.SizeToolStripMenuItem.Checked = True
        Me.SizeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SizeToolStripMenuItem.Name = "SizeToolStripMenuItem"
        Me.SizeToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SizeToolStripMenuItem.Text = "Tools"
        '
        'colorSample
        '
        Me.colorSample.BackColor = System.Drawing.Color.Black
        Me.colorSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.colorSample.Location = New System.Drawing.Point(155, 38)
        Me.colorSample.Name = "colorSample"
        Me.colorSample.Size = New System.Drawing.Size(25, 25)
        Me.colorSample.TabIndex = 3
        Me.colorSample.TabStop = False
        '
        'lblColorSample
        '
        Me.lblColorSample.AutoSize = True
        Me.lblColorSample.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColorSample.Location = New System.Drawing.Point(12, 39)
        Me.lblColorSample.Name = "lblColorSample"
        Me.lblColorSample.Size = New System.Drawing.Size(124, 24)
        Me.lblColorSample.TabIndex = 4
        Me.lblColorSample.Text = "Color Sample"
        '
        'colorPicker
        '
        Me.colorPicker.AnyColor = True
        Me.colorPicker.SolidColorOnly = True
        '
        'toolsPanel
        '
        Me.toolsPanel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.toolsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.toolsPanel.Controls.Add(Me.btnToImage)
        Me.toolsPanel.Controls.Add(Me.btnToForm)
        Me.toolsPanel.Controls.Add(Me.brushPrev)
        Me.toolsPanel.Controls.Add(Me.lblWH)
        Me.toolsPanel.Controls.Add(Me.heightBar)
        Me.toolsPanel.Controls.Add(Me.widthBar)
        Me.toolsPanel.Controls.Add(Me.lblRot)
        Me.toolsPanel.Controls.Add(Me.rotBar)
        Me.toolsPanel.Controls.Add(Me.lblBrushSample)
        Me.toolsPanel.Controls.Add(Me.lblColorSample)
        Me.toolsPanel.Controls.Add(Me.colorSample)
        Me.toolsPanel.Location = New System.Drawing.Point(-7, 12)
        Me.toolsPanel.Name = "toolsPanel"
        Me.toolsPanel.Size = New System.Drawing.Size(208, 657)
        Me.toolsPanel.TabIndex = 5
        '
        'btnToImage
        '
        Me.btnToImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToImage.Location = New System.Drawing.Point(105, 276)
        Me.btnToImage.Name = "btnToImage"
        Me.btnToImage.Size = New System.Drawing.Size(75, 54)
        Me.btnToImage.TabIndex = 37
        Me.btnToImage.Text = "Resize Form to Image "
        Me.btnToImage.UseVisualStyleBackColor = True
        '
        'btnToForm
        '
        Me.btnToForm.Location = New System.Drawing.Point(17, 276)
        Me.btnToForm.Name = "btnToForm"
        Me.btnToForm.Size = New System.Drawing.Size(75, 54)
        Me.btnToForm.TabIndex = 36
        Me.btnToForm.Text = "Resize Image to Form"
        Me.btnToForm.UseVisualStyleBackColor = True
        '
        'brushPrev
        '
        Me.brushPrev.Location = New System.Drawing.Point(17, 112)
        Me.brushPrev.Name = "brushPrev"
        Me.brushPrev.Size = New System.Drawing.Size(163, 145)
        Me.brushPrev.TabIndex = 35
        Me.brushPrev.TabStop = False
        '
        'lblWH
        '
        Me.lblWH.AutoSize = True
        Me.lblWH.Location = New System.Drawing.Point(44, 343)
        Me.lblWH.Name = "lblWH"
        Me.lblWH.Size = New System.Drawing.Size(132, 13)
        Me.lblWH.TabIndex = 34
        Me.lblWH.Text = "Width: 100 ---- Height: 100"
        '
        'heightBar
        '
        Me.heightBar.Location = New System.Drawing.Point(117, 359)
        Me.heightBar.Maximum = 500
        Me.heightBar.Minimum = 1
        Me.heightBar.Name = "heightBar"
        Me.heightBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.heightBar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.heightBar.Size = New System.Drawing.Size(45, 201)
        Me.heightBar.TabIndex = 33
        Me.heightBar.TickFrequency = 30
        Me.heightBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.heightBar.Value = 100
        '
        'widthBar
        '
        Me.widthBar.Location = New System.Drawing.Point(47, 359)
        Me.widthBar.Maximum = 500
        Me.widthBar.Minimum = 1
        Me.widthBar.Name = "widthBar"
        Me.widthBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.widthBar.Size = New System.Drawing.Size(45, 201)
        Me.widthBar.TabIndex = 32
        Me.widthBar.TickFrequency = 30
        Me.widthBar.Value = 100
        '
        'lblRot
        '
        Me.lblRot.AutoSize = True
        Me.lblRot.Location = New System.Drawing.Point(73, 563)
        Me.lblRot.Name = "lblRot"
        Me.lblRot.Size = New System.Drawing.Size(63, 13)
        Me.lblRot.TabIndex = 31
        Me.lblRot.Text = "Rotation: 0°"
        '
        'rotBar
        '
        Me.rotBar.Location = New System.Drawing.Point(-1, 579)
        Me.rotBar.Maximum = 360
        Me.rotBar.Minimum = -360
        Me.rotBar.Name = "rotBar"
        Me.rotBar.Size = New System.Drawing.Size(201, 45)
        Me.rotBar.TabIndex = 30
        Me.rotBar.TickFrequency = 30
        '
        'lblBrushSample
        '
        Me.lblBrushSample.AutoSize = True
        Me.lblBrushSample.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrushSample.Location = New System.Drawing.Point(13, 85)
        Me.lblBrushSample.Name = "lblBrushSample"
        Me.lblBrushSample.Size = New System.Drawing.Size(179, 24)
        Me.lblBrushSample.TabIndex = 5
        Me.lblBrushSample.Text = "Brush Sample (WIP)"
        '
        'bgColorPicker
        '
        Me.bgColorPicker.AnyColor = True
        Me.bgColorPicker.Color = System.Drawing.Color.White
        Me.bgColorPicker.SolidColorOnly = True
        '
        'openImage
        '
        Me.openImage.DefaultExt = "jpg"
        Me.openImage.Title = "Open an image"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1209, 665)
        Me.Controls.Add(Me.toolbar)
        Me.Controls.Add(Me.toolsPanel)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.toolbar
        Me.Name = "Form1"
        Me.Text = "Drawing Pad"
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
        CType(Me.colorSample, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolsPanel.ResumeLayout(False)
        Me.toolsPanel.PerformLayout()
        CType(Me.brushPrev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.heightBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.widthBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rotBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolbar As MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ElipseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RectangleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BrushToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents colorSample As PictureBox
    Friend WithEvents lblColorSample As Label
    Friend WithEvents colorPicker As ColorDialog
    Friend WithEvents BrushColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolsPanel As Panel
    Friend WithEvents lblBrushSample As Label
    Friend WithEvents lblRot As Label
    Friend WithEvents rotBar As TrackBar
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bgColorPicker As ColorDialog
    Friend WithEvents lblWH As Label
    Friend WithEvents heightBar As TrackBar
    Friend WithEvents widthBar As TrackBar
    Friend WithEvents brushPrev As PictureBox
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents openImage As OpenFileDialog
    Friend WithEvents btnToImage As Button
    Friend WithEvents btnToForm As Button
End Class
