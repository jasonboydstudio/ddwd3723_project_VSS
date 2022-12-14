<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.PanelRegister = New System.Windows.Forms.Panel()
        Me.PictureBoxValorantScrimmingSystem = New System.Windows.Forms.PictureBox()
        Me.ButtonContinue = New System.Windows.Forms.Button()
        Me.ButtonClear2 = New System.Windows.Forms.Button()
        Me.ButtonRegister2 = New System.Windows.Forms.Button()
        Me.TextBoxRegisterPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxRegisterUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.LabelRegister = New System.Windows.Forms.Label()
        Me.PanelRegister.SuspendLayout()
        CType(Me.PictureBoxValorantScrimmingSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelRegister
        '
        Me.PanelRegister.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.PanelRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelRegister.Controls.Add(Me.PictureBoxValorantScrimmingSystem)
        Me.PanelRegister.Controls.Add(Me.ButtonContinue)
        Me.PanelRegister.Controls.Add(Me.ButtonClear2)
        Me.PanelRegister.Controls.Add(Me.ButtonRegister2)
        Me.PanelRegister.Controls.Add(Me.TextBoxRegisterPassword)
        Me.PanelRegister.Controls.Add(Me.TextBoxRegisterUsername)
        Me.PanelRegister.Controls.Add(Me.TextBoxEmail)
        Me.PanelRegister.Controls.Add(Me.LabelRegister)
        Me.PanelRegister.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.PanelRegister.Location = New System.Drawing.Point(377, 55)
        Me.PanelRegister.Name = "PanelRegister"
        Me.PanelRegister.Size = New System.Drawing.Size(348, 574)
        Me.PanelRegister.TabIndex = 0
        '
        'PictureBoxValorantScrimmingSystem
        '
        Me.PictureBoxValorantScrimmingSystem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBoxValorantScrimmingSystem.Image = Global.VSS2.My.Resources.Resources.logo_no_bg
        Me.PictureBoxValorantScrimmingSystem.Location = New System.Drawing.Point(63, 373)
        Me.PictureBoxValorantScrimmingSystem.Name = "PictureBoxValorantScrimmingSystem"
        Me.PictureBoxValorantScrimmingSystem.Size = New System.Drawing.Size(224, 198)
        Me.PictureBoxValorantScrimmingSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxValorantScrimmingSystem.TabIndex = 11
        Me.PictureBoxValorantScrimmingSystem.TabStop = False
        '
        'ButtonContinue
        '
        Me.ButtonContinue.Font = New System.Drawing.Font("Poppins SemiBold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonContinue.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonContinue.Location = New System.Drawing.Point(102, 316)
        Me.ButtonContinue.Name = "ButtonContinue"
        Me.ButtonContinue.Size = New System.Drawing.Size(143, 51)
        Me.ButtonContinue.TabIndex = 6
        Me.ButtonContinue.Text = "Continue"
        Me.ButtonContinue.UseVisualStyleBackColor = False
        '
        'ButtonClear2
        '
        Me.ButtonClear2.Font = New System.Drawing.Font("Poppins SemiBold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonClear2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonClear2.Location = New System.Drawing.Point(102, 259)
        Me.ButtonClear2.Name = "ButtonClear2"
        Me.ButtonClear2.Size = New System.Drawing.Size(143, 51)
        Me.ButtonClear2.TabIndex = 5
        Me.ButtonClear2.Text = "Clear"
        Me.ButtonClear2.UseVisualStyleBackColor = False
        '
        'ButtonRegister2
        '
        Me.ButtonRegister2.Font = New System.Drawing.Font("Poppins SemiBold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonRegister2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonRegister2.Location = New System.Drawing.Point(102, 202)
        Me.ButtonRegister2.Name = "ButtonRegister2"
        Me.ButtonRegister2.Size = New System.Drawing.Size(143, 51)
        Me.ButtonRegister2.TabIndex = 4
        Me.ButtonRegister2.Text = "Register"
        Me.ButtonRegister2.UseVisualStyleBackColor = False
        '
        'TextBoxRegisterPassword
        '
        Me.TextBoxRegisterPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRegisterPassword.Font = New System.Drawing.Font("Adobe Caslon Pro", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxRegisterPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBoxRegisterPassword.Location = New System.Drawing.Point(55, 147)
        Me.TextBoxRegisterPassword.Name = "TextBoxRegisterPassword"
        Me.TextBoxRegisterPassword.Size = New System.Drawing.Size(243, 27)
        Me.TextBoxRegisterPassword.TabIndex = 3
        Me.TextBoxRegisterPassword.Text = "Enter Your Password here"
        Me.TextBoxRegisterPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxRegisterUsername
        '
        Me.TextBoxRegisterUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRegisterUsername.Font = New System.Drawing.Font("Adobe Caslon Pro", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxRegisterUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBoxRegisterUsername.Location = New System.Drawing.Point(55, 114)
        Me.TextBoxRegisterUsername.Name = "TextBoxRegisterUsername"
        Me.TextBoxRegisterUsername.Size = New System.Drawing.Size(243, 27)
        Me.TextBoxRegisterUsername.TabIndex = 2
        Me.TextBoxRegisterUsername.Text = "Enter your Username here"
        Me.TextBoxRegisterUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TextBoxEmail.Font = New System.Drawing.Font("Adobe Caslon Pro", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBoxEmail.Location = New System.Drawing.Point(55, 81)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(243, 27)
        Me.TextBoxEmail.TabIndex = 1
        Me.TextBoxEmail.Text = "Enter Your Email Here"
        Me.TextBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelRegister
        '
        Me.LabelRegister.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelRegister.AutoSize = True
        Me.LabelRegister.Font = New System.Drawing.Font("Poppins SemiBold", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LabelRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelRegister.Location = New System.Drawing.Point(65, 22)
        Me.LabelRegister.Name = "LabelRegister"
        Me.LabelRegister.Size = New System.Drawing.Size(222, 56)
        Me.LabelRegister.TabIndex = 0
        Me.LabelRegister.Text = "Registration"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.VSS2.My.Resources.Resources._1074846
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1080, 693)
        Me.Controls.Add(Me.PanelRegister)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelRegister.ResumeLayout(False)
        Me.PanelRegister.PerformLayout()
        CType(Me.PictureBoxValorantScrimmingSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelRegister As Panel
    Friend WithEvents ButtonClear2 As Button
    Friend WithEvents ButtonRegister2 As Button
    Friend WithEvents TextBoxRegisterPassword As TextBox
    Friend WithEvents TextBoxRegisterUsername As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents LabelRegister As Label
    Friend WithEvents ButtonContinue As Button
    Friend WithEvents PictureBoxValorantScrimmingSystem As PictureBox
End Class
