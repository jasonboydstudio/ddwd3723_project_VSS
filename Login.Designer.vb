<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PanelSignIn = New System.Windows.Forms.Panel()
        Me.ButtonRegisterHere = New System.Windows.Forms.Button()
        Me.PictureBoxValorantScrimmingSystem = New System.Windows.Forms.PictureBox()
        Me.LabelSignin = New System.Windows.Forms.Label()
        Me.LabelDontHaveAnAccount = New System.Windows.Forms.Label()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelSignIn.SuspendLayout()
        CType(Me.PictureBoxValorantScrimmingSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSignIn
        '
        Me.PanelSignIn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelSignIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelSignIn.Controls.Add(Me.ButtonRegisterHere)
        Me.PanelSignIn.Controls.Add(Me.PictureBoxValorantScrimmingSystem)
        Me.PanelSignIn.Controls.Add(Me.LabelSignin)
        Me.PanelSignIn.Controls.Add(Me.LabelDontHaveAnAccount)
        Me.PanelSignIn.Controls.Add(Me.ButtonExit)
        Me.PanelSignIn.Controls.Add(Me.ButtonClear)
        Me.PanelSignIn.Controls.Add(Me.ButtonLogin)
        Me.PanelSignIn.Controls.Add(Me.TextBoxPassword)
        Me.PanelSignIn.Controls.Add(Me.TextBoxUsername)
        Me.PanelSignIn.Location = New System.Drawing.Point(64, -5)
        Me.PanelSignIn.Name = "PanelSignIn"
        Me.PanelSignIn.Size = New System.Drawing.Size(294, 678)
        Me.PanelSignIn.TabIndex = 0
        '
        'ButtonRegisterHere
        '
        Me.ButtonRegisterHere.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonRegisterHere.BackColor = System.Drawing.Color.Transparent
        Me.ButtonRegisterHere.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonRegisterHere.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonRegisterHere.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonRegisterHere.Location = New System.Drawing.Point(92, 413)
        Me.ButtonRegisterHere.Name = "ButtonRegisterHere"
        Me.ButtonRegisterHere.Size = New System.Drawing.Size(100, 41)
        Me.ButtonRegisterHere.TabIndex = 8
        Me.ButtonRegisterHere.Text = "Register"
        Me.ButtonRegisterHere.UseVisualStyleBackColor = False
        '
        'PictureBoxValorantScrimmingSystem
        '
        Me.PictureBoxValorantScrimmingSystem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBoxValorantScrimmingSystem.Image = Global.VSS2.My.Resources.Resources.logo_no_bg
        Me.PictureBoxValorantScrimmingSystem.Location = New System.Drawing.Point(7, 444)
        Me.PictureBoxValorantScrimmingSystem.Name = "PictureBoxValorantScrimmingSystem"
        Me.PictureBoxValorantScrimmingSystem.Size = New System.Drawing.Size(271, 222)
        Me.PictureBoxValorantScrimmingSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxValorantScrimmingSystem.TabIndex = 10
        Me.PictureBoxValorantScrimmingSystem.TabStop = False
        '
        'LabelSignin
        '
        Me.LabelSignin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelSignin.AutoSize = True
        Me.LabelSignin.Font = New System.Drawing.Font("Poppins SemiBold", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LabelSignin.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LabelSignin.Location = New System.Drawing.Point(78, 24)
        Me.LabelSignin.Name = "LabelSignin"
        Me.LabelSignin.Size = New System.Drawing.Size(133, 56)
        Me.LabelSignin.TabIndex = 9
        Me.LabelSignin.Text = "Sign in"
        '
        'LabelDontHaveAnAccount
        '
        Me.LabelDontHaveAnAccount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelDontHaveAnAccount.AutoSize = True
        Me.LabelDontHaveAnAccount.Location = New System.Drawing.Point(84, 396)
        Me.LabelDontHaveAnAccount.Name = "LabelDontHaveAnAccount"
        Me.LabelDontHaveAnAccount.Size = New System.Drawing.Size(125, 13)
        Me.LabelDontHaveAnAccount.TabIndex = 7
        Me.LabelDontHaveAnAccount.Text = "Don't have an account ?"
        '
        'ButtonExit
        '
        Me.ButtonExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonExit.BackColor = System.Drawing.Color.Transparent
        Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonExit.Font = New System.Drawing.Font("Poppins SemiBold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonExit.Location = New System.Drawing.Point(68, 287)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(151, 63)
        Me.ButtonExit.TabIndex = 6
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = False
        '
        'ButtonClear
        '
        Me.ButtonClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonClear.BackColor = System.Drawing.Color.Transparent
        Me.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonClear.Font = New System.Drawing.Font("Poppins SemiBold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonClear.Location = New System.Drawing.Point(68, 218)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(151, 63)
        Me.ButtonClear.TabIndex = 5
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonLogin.BackColor = System.Drawing.Color.Transparent
        Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonLogin.Font = New System.Drawing.Font("Poppins SemiBold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonLogin.Location = New System.Drawing.Point(68, 149)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(151, 63)
        Me.ButtonLogin.TabIndex = 4
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = False
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPassword.Font = New System.Drawing.Font("Adobe Caslon Pro", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBoxPassword.Location = New System.Drawing.Point(3, 116)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(285, 27)
        Me.TextBoxPassword.TabIndex = 3
        Me.TextBoxPassword.Text = "Password"
        Me.TextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxUsername.Font = New System.Drawing.Font("Adobe Caslon Pro", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBoxUsername.Location = New System.Drawing.Point(3, 83)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(285, 27)
        Me.TextBoxUsername.TabIndex = 2
        Me.TextBoxUsername.Text = "Username"
        Me.TextBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.VSS2.My.Resources.Resources._1282982__1_
        Me.PictureBox1.Location = New System.Drawing.Point(64, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1046, 675)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1044, 673)
        Me.Controls.Add(Me.PanelSignIn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelSignIn.ResumeLayout(False)
        Me.PanelSignIn.PerformLayout()
        CType(Me.PictureBoxValorantScrimmingSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelSignIn As Panel
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents ButtonExit As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ButtonRegisterHere As Button
    Friend WithEvents LabelDontHaveAnAccount As Label
    Friend WithEvents LabelSignin As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBoxValorantScrimmingSystem As PictureBox
End Class
