<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cmdElvis = New System.Windows.Forms.Button()
        Me.cmdBigger = New System.Windows.Forms.Button()
        Me.cmdSmaller = New System.Windows.Forms.Button()
        Me.picMoney = New System.Windows.Forms.PictureBox()
        Me.cmdMoreMoney = New System.Windows.Forms.Button()
        CType(Me.picMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdElvis
        '
        Me.cmdElvis.Location = New System.Drawing.Point(12, 12)
        Me.cmdElvis.Name = "cmdElvis"
        Me.cmdElvis.Size = New System.Drawing.Size(89, 50)
        Me.cmdElvis.TabIndex = 0
        Me.cmdElvis.Text = "Elvis Rules!"
        Me.cmdElvis.UseVisualStyleBackColor = True
        '
        'cmdBigger
        '
        Me.cmdBigger.Location = New System.Drawing.Point(296, 197)
        Me.cmdBigger.Name = "cmdBigger"
        Me.cmdBigger.Size = New System.Drawing.Size(75, 23)
        Me.cmdBigger.TabIndex = 1
        Me.cmdBigger.Text = "Get Bigger!"
        Me.cmdBigger.UseVisualStyleBackColor = True
        '
        'cmdSmaller
        '
        Me.cmdSmaller.Location = New System.Drawing.Point(296, 13)
        Me.cmdSmaller.Name = "cmdSmaller"
        Me.cmdSmaller.Size = New System.Drawing.Size(296, 178)
        Me.cmdSmaller.TabIndex = 2
        Me.cmdSmaller.Text = "Get Smaller!"
        Me.cmdSmaller.UseVisualStyleBackColor = True
        '
        'picMoney
        '
        Me.picMoney.Image = CType(resources.GetObject("picMoney.Image"), System.Drawing.Image)
        Me.picMoney.Location = New System.Drawing.Point(12, 82)
        Me.picMoney.Name = "picMoney"
        Me.picMoney.Size = New System.Drawing.Size(76, 87)
        Me.picMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMoney.TabIndex = 3
        Me.picMoney.TabStop = False
        '
        'cmdMoreMoney
        '
        Me.cmdMoreMoney.Location = New System.Drawing.Point(132, 26)
        Me.cmdMoreMoney.Name = "cmdMoreMoney"
        Me.cmdMoreMoney.Size = New System.Drawing.Size(128, 23)
        Me.cmdMoreMoney.TabIndex = 4
        Me.cmdMoreMoney.Text = "More Money!"
        Me.cmdMoreMoney.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 365)
        Me.Controls.Add(Me.cmdMoreMoney)
        Me.Controls.Add(Me.cmdSmaller)
        Me.Controls.Add(Me.cmdBigger)
        Me.Controls.Add(Me.cmdElvis)
        Me.Controls.Add(Me.picMoney)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picMoney, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdElvis As Button
    Friend WithEvents cmdBigger As Button
    Friend WithEvents cmdSmaller As Button
    Friend WithEvents picMoney As PictureBox
    Friend WithEvents cmdMoreMoney As Button
End Class
