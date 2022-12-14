<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LobbySelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LobbySelect))
        Me.GroupBoxAsia = New System.Windows.Forms.GroupBox()
        Me.ButtonLobby2 = New System.Windows.Forms.Button()
        Me.ButtonLobby1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBoxAsia.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxAsia
        '
        Me.GroupBoxAsia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBoxAsia.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxAsia.Controls.Add(Me.ButtonLobby2)
        Me.GroupBoxAsia.Controls.Add(Me.ButtonLobby1)
        Me.GroupBoxAsia.Font = New System.Drawing.Font("Poppins SemiBold", 24.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxAsia.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBoxAsia.Location = New System.Drawing.Point(376, 210)
        Me.GroupBoxAsia.Name = "GroupBoxAsia"
        Me.GroupBoxAsia.Size = New System.Drawing.Size(307, 230)
        Me.GroupBoxAsia.TabIndex = 10
        Me.GroupBoxAsia.TabStop = False
        Me.GroupBoxAsia.Text = "Asia"
        '
        'ButtonLobby2
        '
        Me.ButtonLobby2.Font = New System.Drawing.Font("Poppins SemiBold", 24.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonLobby2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonLobby2.Location = New System.Drawing.Point(43, 124)
        Me.ButtonLobby2.Name = "ButtonLobby2"
        Me.ButtonLobby2.Size = New System.Drawing.Size(220, 76)
        Me.ButtonLobby2.TabIndex = 1
        Me.ButtonLobby2.Text = "Lobby2"
        Me.ButtonLobby2.UseVisualStyleBackColor = True
        '
        'ButtonLobby1
        '
        Me.ButtonLobby1.Font = New System.Drawing.Font("Poppins SemiBold", 24.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonLobby1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonLobby1.Location = New System.Drawing.Point(43, 42)
        Me.ButtonLobby1.Name = "ButtonLobby1"
        Me.ButtonLobby1.Size = New System.Drawing.Size(220, 76)
        Me.ButtonLobby1.TabIndex = 0
        Me.ButtonLobby1.Text = "Lobby1"
        Me.ButtonLobby1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Font = New System.Drawing.Font("Poppins SemiBold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(466, 576)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 43)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.Image = Global.VSS2.My.Resources.Resources.logo_no_bg
        Me.PictureBox1.Location = New System.Drawing.Point(404, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(247, 192)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'LobbySelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1039, 631)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBoxAsia)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LobbySelect"
        Me.Text = "LobbySelect"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBoxAsia.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxAsia As GroupBox
    Friend WithEvents ButtonLobby2 As Button
    Friend WithEvents ButtonLobby1 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
