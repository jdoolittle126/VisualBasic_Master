<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.btnDrawMap = New System.Windows.Forms.Button()
        Me.btnGenMap = New System.Windows.Forms.Button()
        Me.btnMapEditor = New System.Windows.Forms.Button()
        Me.renderLoop = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnDrawMap
        '
        Me.btnDrawMap.Location = New System.Drawing.Point(892, 627)
        Me.btnDrawMap.Name = "btnDrawMap"
        Me.btnDrawMap.Size = New System.Drawing.Size(120, 44)
        Me.btnDrawMap.TabIndex = 0
        Me.btnDrawMap.Text = "Drawing Map: FALSE"
        Me.btnDrawMap.UseVisualStyleBackColor = True
        '
        'btnGenMap
        '
        Me.btnGenMap.Location = New System.Drawing.Point(892, 569)
        Me.btnGenMap.Name = "btnGenMap"
        Me.btnGenMap.Size = New System.Drawing.Size(120, 52)
        Me.btnGenMap.TabIndex = 1
        Me.btnGenMap.Text = "Generate Map"
        Me.btnGenMap.UseVisualStyleBackColor = True
        '
        'btnMapEditor
        '
        Me.btnMapEditor.Location = New System.Drawing.Point(892, 511)
        Me.btnMapEditor.Name = "btnMapEditor"
        Me.btnMapEditor.Size = New System.Drawing.Size(120, 52)
        Me.btnMapEditor.TabIndex = 2
        Me.btnMapEditor.Text = "Create Map"
        Me.btnMapEditor.UseVisualStyleBackColor = True
        '
        'renderLoop
        '
        Me.renderLoop.Interval = 115
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 683)
        Me.Controls.Add(Me.btnMapEditor)
        Me.Controls.Add(Me.btnGenMap)
        Me.Controls.Add(Me.btnDrawMap)
        Me.Name = "Main"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDrawMap As Button
    Friend WithEvents btnGenMap As Button
    Friend WithEvents btnMapEditor As Button
    Friend WithEvents renderLoop As Timer
End Class
