<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonProfile = New System.Windows.Forms.Button()
        Me.ButtonLeaderBoard = New System.Windows.Forms.Button()
        Me.ButtonInfo = New System.Windows.Forms.Button()
        Me.ButtonSetting = New System.Windows.Forms.Button()
        Me.ButtonChatLobby = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.Image = Global.VSS2.My.Resources.Resources.logo_no_bg
        Me.PictureBox1.Location = New System.Drawing.Point(613, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(397, 272)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'ButtonProfile
        '
        Me.ButtonProfile.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ButtonProfile.BackColor = System.Drawing.Color.RosyBrown
        Me.ButtonProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonProfile.Location = New System.Drawing.Point(287, 38)
        Me.ButtonProfile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonProfile.Name = "ButtonProfile"
        Me.ButtonProfile.Size = New System.Drawing.Size(205, 66)
        Me.ButtonProfile.TabIndex = 21
        Me.ButtonProfile.Text = "Profile"
        Me.ButtonProfile.UseVisualStyleBackColor = False
        '
        'ButtonLeaderBoard
        '
        Me.ButtonLeaderBoard.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonLeaderBoard.BackColor = System.Drawing.Color.RosyBrown
        Me.ButtonLeaderBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonLeaderBoard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonLeaderBoard.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonLeaderBoard.Location = New System.Drawing.Point(65, 278)
        Me.ButtonLeaderBoard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonLeaderBoard.Name = "ButtonLeaderBoard"
        Me.ButtonLeaderBoard.Size = New System.Drawing.Size(205, 66)
        Me.ButtonLeaderBoard.TabIndex = 24
        Me.ButtonLeaderBoard.Text = "LeaderBoard"
        Me.ButtonLeaderBoard.UseVisualStyleBackColor = False
        '
        'ButtonInfo
        '
        Me.ButtonInfo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonInfo.BackColor = System.Drawing.Color.RosyBrown
        Me.ButtonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonInfo.Location = New System.Drawing.Point(491, 277)
        Me.ButtonInfo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonInfo.Name = "ButtonInfo"
        Me.ButtonInfo.Size = New System.Drawing.Size(204, 66)
        Me.ButtonInfo.TabIndex = 22
        Me.ButtonInfo.Text = "Info"
        Me.ButtonInfo.UseVisualStyleBackColor = False
        '
        'ButtonSetting
        '
        Me.ButtonSetting.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ButtonSetting.BackColor = System.Drawing.Color.RosyBrown
        Me.ButtonSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonSetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonSetting.Location = New System.Drawing.Point(489, 180)
        Me.ButtonSetting.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonSetting.Name = "ButtonSetting"
        Me.ButtonSetting.Size = New System.Drawing.Size(205, 66)
        Me.ButtonSetting.TabIndex = 23
        Me.ButtonSetting.Text = "Setting"
        Me.ButtonSetting.UseVisualStyleBackColor = False
        '
        'ButtonChatLobby
        '
        Me.ButtonChatLobby.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonChatLobby.BackColor = System.Drawing.Color.RosyBrown
        Me.ButtonChatLobby.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonChatLobby.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonChatLobby.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonChatLobby.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonChatLobby.Location = New System.Drawing.Point(65, 180)
        Me.ButtonChatLobby.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonChatLobby.Name = "ButtonChatLobby"
        Me.ButtonChatLobby.Size = New System.Drawing.Size(205, 66)
        Me.ButtonChatLobby.TabIndex = 26
        Me.ButtonChatLobby.Text = "Chat Lobby"
        Me.ButtonChatLobby.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.ButtonChatLobby)
        Me.Panel1.Controls.Add(Me.ButtonSetting)
        Me.Panel1.Controls.Add(Me.ButtonInfo)
        Me.Panel1.Controls.Add(Me.ButtonLeaderBoard)
        Me.Panel1.Controls.Add(Me.ButtonProfile)
        Me.Panel1.Location = New System.Drawing.Point(423, 279)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(741, 447)
        Me.Panel1.TabIndex = 22
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.VSS2.My.Resources.Resources._1203245
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1583, 812)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Home"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ButtonProfile As Button
    Friend WithEvents ButtonLeaderBoard As Button
    Friend WithEvents ButtonInfo As Button
    Friend WithEvents ButtonSetting As Button
    Friend WithEvents ButtonChatLobby As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
End Class
