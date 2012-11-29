<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profil))
        Me.Label1 = New System.Windows.Forms.Label
        Me.playerBaru = New System.Windows.Forms.LinkLabel
        Me.Delete = New System.Windows.Forms.LinkLabel
        Me.RenamePlayer = New System.Windows.Forms.LinkLabel
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Moccasin
        Me.Label1.Font = New System.Drawing.Font("Gill Sans MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(234, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 67)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PILIH PROFIL"
        '
        'playerBaru
        '
        Me.playerBaru.AutoSize = True
        Me.playerBaru.BackColor = System.Drawing.Color.Orchid
        Me.playerBaru.DisabledLinkColor = System.Drawing.Color.Transparent
        Me.playerBaru.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playerBaru.LinkColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.playerBaru.Location = New System.Drawing.Point(361, 329)
        Me.playerBaru.Name = "playerBaru"
        Me.playerBaru.Size = New System.Drawing.Size(121, 25)
        Me.playerBaru.TabIndex = 2
        Me.playerBaru.TabStop = True
        Me.playerBaru.Text = "New Player"
        '
        'Delete
        '
        Me.Delete.AutoSize = True
        Me.Delete.BackColor = System.Drawing.Color.Orchid
        Me.Delete.DisabledLinkColor = System.Drawing.Color.Transparent
        Me.Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.LinkColor = System.Drawing.Color.Black
        Me.Delete.Location = New System.Drawing.Point(514, 329)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(74, 25)
        Me.Delete.TabIndex = 3
        Me.Delete.TabStop = True
        Me.Delete.Text = "Delete"
        '
        'RenamePlayer
        '
        Me.RenamePlayer.AutoSize = True
        Me.RenamePlayer.BackColor = System.Drawing.Color.Orchid
        Me.RenamePlayer.DisabledLinkColor = System.Drawing.Color.Transparent
        Me.RenamePlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RenamePlayer.LinkColor = System.Drawing.Color.Black
        Me.RenamePlayer.Location = New System.Drawing.Point(241, 329)
        Me.RenamePlayer.Name = "RenamePlayer"
        Me.RenamePlayer.Size = New System.Drawing.Size(91, 25)
        Me.RenamePlayer.TabIndex = 4
        Me.RenamePlayer.TabStop = True
        Me.RenamePlayer.Text = "Rename"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(285, 155)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(265, 158)
        Me.DataGridView1.TabIndex = 5
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Orchid
        Me.LinkLabel1.DisabledLinkColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(322, 387)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(56, 25)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Help"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Orchid
        Me.LinkLabel2.DisabledLinkColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.Location = New System.Drawing.Point(467, 387)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(69, 25)
        Me.LinkLabel2.TabIndex = 7
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "About"
        '
        'Profil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlashGame.My.Resources.Resources.lets_play
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(796, 501)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.RenamePlayer)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.playerBaru)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Red
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Profil"
        Me.Text = "Profil"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents playerBaru As System.Windows.Forms.LinkLabel
    Friend WithEvents Delete As System.Windows.Forms.LinkLabel
    Friend WithEvents RenamePlayer As System.Windows.Forms.LinkLabel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
End Class
