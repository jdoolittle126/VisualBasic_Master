<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnGrass = New System.Windows.Forms.Button()
        Me.btnSand = New System.Windows.Forms.Button()
        Me.updateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnSaveMap = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGrass
        '
        Me.btnGrass.BackColor = System.Drawing.Color.LightGreen
        Me.btnGrass.Location = New System.Drawing.Point(12, 607)
        Me.btnGrass.Name = "btnGrass"
        Me.btnGrass.Size = New System.Drawing.Size(64, 64)
        Me.btnGrass.TabIndex = 0
        Me.btnGrass.Text = "Grass"
        Me.btnGrass.UseVisualStyleBackColor = False
        '
        'btnSand
        '
        Me.btnSand.BackColor = System.Drawing.Color.Bisque
        Me.btnSand.Location = New System.Drawing.Point(82, 607)
        Me.btnSand.Name = "btnSand"
        Me.btnSand.Size = New System.Drawing.Size(64, 64)
        Me.btnSand.TabIndex = 1
        Me.btnSand.Text = "Sand"
        Me.btnSand.UseVisualStyleBackColor = False
        '
        'updateTimer
        '
        '
        'btnSaveMap
        '
        Me.btnSaveMap.Location = New System.Drawing.Point(904, 617)
        Me.btnSaveMap.Name = "btnSaveMap"
        Me.btnSaveMap.Size = New System.Drawing.Size(108, 54)
        Me.btnSaveMap.TabIndex = 2
        Me.btnSaveMap.Text = "Save Map"
        Me.btnSaveMap.UseVisualStyleBackColor = True
        '
        'Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 683)
        Me.Controls.Add(Me.btnSaveMap)
        Me.Controls.Add(Me.btnSand)
        Me.Controls.Add(Me.btnGrass)
        Me.Name = "Editor"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGrass As Button
    Friend WithEvents btnSand As Button
    Friend WithEvents updateTimer As Timer
    Friend WithEvents btnSaveMap As Button
End Class
