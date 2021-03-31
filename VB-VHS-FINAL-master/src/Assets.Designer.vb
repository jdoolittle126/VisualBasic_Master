<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Assets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Assets))
        Me.pbAssets = New System.Windows.Forms.PictureBox()
        CType(Me.pbAssets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbAssets
        '
        Me.pbAssets.BackColor = System.Drawing.Color.White
        Me.pbAssets.Image = CType(resources.GetObject("pbAssets.Image"), System.Drawing.Image)
        Me.pbAssets.Location = New System.Drawing.Point(-2, -1)
        Me.pbAssets.Name = "pbAssets"
        Me.pbAssets.Size = New System.Drawing.Size(1074, 643)
        Me.pbAssets.TabIndex = 0
        Me.pbAssets.TabStop = False
        '
        'Assets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 654)
        Me.Controls.Add(Me.pbAssets)
        Me.Name = "Assets"
        Me.Text = "Form1"
        CType(Me.pbAssets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents pbAssets As PictureBox
End Class
