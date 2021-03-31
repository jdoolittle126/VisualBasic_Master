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
        Me.Panel = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelOven = New System.Windows.Forms.Label()
        Me.Window = New System.Windows.Forms.Panel()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel.Controls.Add(Me.ProgressBar1)
        Me.Panel.Controls.Add(Me.Button2)
        Me.Panel.Controls.Add(Me.Button1)
        Me.Panel.Controls.Add(Me.LabelOven)
        Me.Panel.Location = New System.Drawing.Point(517, 12)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(255, 338)
        Me.Panel.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(30, 60)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(210, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Button2.Location = New System.Drawing.Point(143, 289)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 42)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Button1.Location = New System.Drawing.Point(30, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelOven
        '
        Me.LabelOven.AutoSize = True
        Me.LabelOven.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelOven.Location = New System.Drawing.Point(24, 13)
        Me.LabelOven.Name = "LabelOven"
        Me.LabelOven.Size = New System.Drawing.Size(216, 31)
        Me.LabelOven.TabIndex = 0
        Me.LabelOven.Text = "Microwave Oven"
        '
        'Window
        '
        Me.Window.BackColor = System.Drawing.Color.DimGray
        Me.Window.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Window.Location = New System.Drawing.Point(12, 12)
        Me.Window.Name = "Window"
        Me.Window.Size = New System.Drawing.Size(484, 338)
        Me.Window.TabIndex = 0
        '
        'Form1
        '
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 362)
        Me.Controls.Add(Me.Window)
        Me.Controls.Add(Me.Panel)
        Me.Name = "Form1"
        Me.Text = "Microwave Oven"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelOven As Label
    Friend WithEvents Window As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
