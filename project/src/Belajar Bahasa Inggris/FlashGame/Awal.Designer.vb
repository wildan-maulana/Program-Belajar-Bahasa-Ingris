<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Awal
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Awal))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Mulai = New System.Windows.Forms.LinkLabel
        Me.VisualStyler1 = New SkinSoft.VisualStyler.VisualStyler(Me.components)
        CType(Me.VisualStyler1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Yellow
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Fuchsia
        Me.ProgressBar1.Location = New System.Drawing.Point(249, 181)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(467, 37)
        Me.ProgressBar1.TabIndex = 0
        '
        'Timer1
        '
        '
        'Mulai
        '
        Me.Mulai.AutoSize = True
        Me.Mulai.BackColor = System.Drawing.Color.LightCyan
        Me.Mulai.Font = New System.Drawing.Font("Gill Sans MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mulai.LinkColor = System.Drawing.Color.Black
        Me.Mulai.Location = New System.Drawing.Point(430, 239)
        Me.Mulai.Name = "Mulai"
        Me.Mulai.Size = New System.Drawing.Size(110, 38)
        Me.Mulai.TabIndex = 1
        Me.Mulai.TabStop = True
        Me.Mulai.Text = "MULAI"
        '
        'VisualStyler1
        '
        Me.VisualStyler1.License = CType(resources.GetObject("VisualStyler1.License"), SkinSoft.VisualStyler.Licensing.VisualStylerLicense)
        Me.VisualStyler1.LoadVisualStyle(Nothing, "OSX (Brushed).vssf")
        '
        'Awal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.FlashGame.My.Resources.Resources.awal
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(936, 511)
        Me.Controls.Add(Me.Mulai)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Awal"
        Me.Text = "Form1"
        CType(Me.VisualStyler1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Mulai As System.Windows.Forms.LinkLabel
    Friend WithEvents VisualStyler1 As SkinSoft.VisualStyler.VisualStyler

End Class
