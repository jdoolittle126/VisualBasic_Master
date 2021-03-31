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
        Me.btnName = New System.Windows.Forms.Button()
        Me.btnName2 = New System.Windows.Forms.Button()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.btnGlobalName = New System.Windows.Forms.Button()
        Me.btnGlobalName1 = New System.Windows.Forms.Button()
        Me.btnGlobalName2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnName
        '
        Me.btnName.Location = New System.Drawing.Point(12, 12)
        Me.btnName.Name = "btnName"
        Me.btnName.Size = New System.Drawing.Size(236, 70)
        Me.btnName.TabIndex = 0
        Me.btnName.Text = "Name Function 1"
        Me.btnName.UseVisualStyleBackColor = True
        '
        'btnName2
        '
        Me.btnName2.Location = New System.Drawing.Point(12, 88)
        Me.btnName2.Name = "btnName2"
        Me.btnName2.Size = New System.Drawing.Size(236, 70)
        Me.btnName2.TabIndex = 1
        Me.btnName2.Text = "Name Function 2"
        Me.btnName2.UseVisualStyleBackColor = True
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(12, 165)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(236, 70)
        Me.btnColor.TabIndex = 2
        Me.btnColor.Text = "New Background Color"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'btnGlobalName
        '
        Me.btnGlobalName.Location = New System.Drawing.Point(254, 165)
        Me.btnGlobalName.Name = "btnGlobalName"
        Me.btnGlobalName.Size = New System.Drawing.Size(236, 70)
        Me.btnGlobalName.TabIndex = 3
        Me.btnGlobalName.Text = "Set Global Name"
        Me.btnGlobalName.UseVisualStyleBackColor = True
        '
        'btnGlobalName1
        '
        Me.btnGlobalName1.Location = New System.Drawing.Point(254, 12)
        Me.btnGlobalName1.Name = "btnGlobalName1"
        Me.btnGlobalName1.Size = New System.Drawing.Size(236, 70)
        Me.btnGlobalName1.TabIndex = 4
        Me.btnGlobalName1.Text = "Global Name Function 1"
        Me.btnGlobalName1.UseVisualStyleBackColor = True
        '
        'btnGlobalName2
        '
        Me.btnGlobalName2.Location = New System.Drawing.Point(254, 88)
        Me.btnGlobalName2.Name = "btnGlobalName2"
        Me.btnGlobalName2.Size = New System.Drawing.Size(236, 70)
        Me.btnGlobalName2.TabIndex = 5
        Me.btnGlobalName2.Text = "Global Name Function 2"
        Me.btnGlobalName2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 247)
        Me.Controls.Add(Me.btnGlobalName2)
        Me.Controls.Add(Me.btnGlobalName1)
        Me.Controls.Add(Me.btnGlobalName)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.btnName2)
        Me.Controls.Add(Me.btnName)
        Me.Name = "Form1"
        Me.Text = "Control Panel"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnName As Button
    Friend WithEvents btnName2 As Button
    Friend WithEvents btnColor As Button
    Friend WithEvents btnGlobalName As Button
    Friend WithEvents btnGlobalName1 As Button
    Friend WithEvents btnGlobalName2 As Button
End Class
