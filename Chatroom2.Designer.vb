<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chatroom2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chatroom2))
        Me.GroupBoxCht2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonSend2 = New System.Windows.Forms.Button()
        Me.TextBoxMessage2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBoxOnline2 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxChat2 = New System.Windows.Forms.RichTextBox()
        Me.PictureBoxHomeCR2 = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBoxCht2.SuspendLayout()
        CType(Me.PictureBoxHomeCR2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxCht2
        '
        Me.GroupBoxCht2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBoxCht2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxCht2.Controls.Add(Me.Label10)
        Me.GroupBoxCht2.Controls.Add(Me.Label9)
        Me.GroupBoxCht2.Controls.Add(Me.Label8)
        Me.GroupBoxCht2.Controls.Add(Me.Label7)
        Me.GroupBoxCht2.Controls.Add(Me.Label6)
        Me.GroupBoxCht2.Controls.Add(Me.Label5)
        Me.GroupBoxCht2.Controls.Add(Me.Label4)
        Me.GroupBoxCht2.Controls.Add(Me.Label3)
        Me.GroupBoxCht2.Controls.Add(Me.ButtonSend2)
        Me.GroupBoxCht2.Controls.Add(Me.TextBoxMessage2)
        Me.GroupBoxCht2.Controls.Add(Me.Label2)
        Me.GroupBoxCht2.Controls.Add(Me.Label1)
        Me.GroupBoxCht2.Controls.Add(Me.RichTextBoxOnline2)
        Me.GroupBoxCht2.Controls.Add(Me.RichTextBoxChat2)
        Me.GroupBoxCht2.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxCht2.Location = New System.Drawing.Point(169, 32)
        Me.GroupBoxCht2.Name = "GroupBoxCht2"
        Me.GroupBoxCht2.Size = New System.Drawing.Size(463, 387)
        Me.GroupBoxCht2.TabIndex = 1
        Me.GroupBoxCht2.TabStop = False
        Me.GroupBoxCht2.Text = "ChatRoom2"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label10.Location = New System.Drawing.Point(351, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 16)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Player 1 ✔"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label9.Location = New System.Drawing.Point(351, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Player 2 ✔"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label8.Location = New System.Drawing.Point(351, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Player 3 ❌"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label7.Location = New System.Drawing.Point(351, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Player 4 ❌"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(6, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Player 1 : wkwkwkwk "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(6, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Player 3 : Lol 😂"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(6, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Player 4 : come to me❤"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(6, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Player 2 : I need SugerrDidyy "
        '
        'ButtonSend2
        '
        Me.ButtonSend2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonSend2.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSend2.Location = New System.Drawing.Point(158, 348)
        Me.ButtonSend2.Name = "ButtonSend2"
        Me.ButtonSend2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSend2.TabIndex = 5
        Me.ButtonSend2.Text = "Send ✔"
        Me.ButtonSend2.UseVisualStyleBackColor = True
        '
        'TextBoxMessage2
        '
        Me.TextBoxMessage2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxMessage2.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMessage2.Location = New System.Drawing.Point(6, 348)
        Me.TextBoxMessage2.Name = "TextBoxMessage2"
        Me.TextBoxMessage2.Size = New System.Drawing.Size(146, 22)
        Me.TextBoxMessage2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Chat"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(351, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Player Online"
        '
        'RichTextBoxOnline2
        '
        Me.RichTextBoxOnline2.BackColor = System.Drawing.SystemColors.MenuText
        Me.RichTextBoxOnline2.Location = New System.Drawing.Point(307, 73)
        Me.RichTextBoxOnline2.Name = "RichTextBoxOnline2"
        Me.RichTextBoxOnline2.Size = New System.Drawing.Size(150, 308)
        Me.RichTextBoxOnline2.TabIndex = 1
        Me.RichTextBoxOnline2.Text = ""
        '
        'RichTextBoxChat2
        '
        Me.RichTextBoxChat2.BackColor = System.Drawing.SystemColors.MenuText
        Me.RichTextBoxChat2.Location = New System.Drawing.Point(0, 73)
        Me.RichTextBoxChat2.Name = "RichTextBoxChat2"
        Me.RichTextBoxChat2.Size = New System.Drawing.Size(241, 308)
        Me.RichTextBoxChat2.TabIndex = 0
        Me.RichTextBoxChat2.Text = ""
        '
        'PictureBoxHomeCR2
        '
        Me.PictureBoxHomeCR2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBoxHomeCR2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxHomeCR2.Image = Global.VSS2.My.Resources.Resources.noun_home_icon_3574480
        Me.PictureBoxHomeCR2.Location = New System.Drawing.Point(384, 419)
        Me.PictureBoxHomeCR2.Name = "PictureBoxHomeCR2"
        Me.PictureBoxHomeCR2.Size = New System.Drawing.Size(65, 40)
        Me.PictureBoxHomeCR2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxHomeCR2.TabIndex = 9
        Me.PictureBoxHomeCR2.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(588, 6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'Chatroom2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.VSS2.My.Resources.Resources._1203245
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PictureBoxHomeCR2)
        Me.Controls.Add(Me.GroupBoxCht2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Chatroom2"
        Me.Text = "Chatroom2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBoxCht2.ResumeLayout(False)
        Me.GroupBoxCht2.PerformLayout()
        CType(Me.PictureBoxHomeCR2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxCht2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonSend2 As Button
    Friend WithEvents TextBoxMessage2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBoxOnline2 As RichTextBox
    Friend WithEvents RichTextBoxChat2 As RichTextBox
    Friend WithEvents PictureBoxHomeCR2 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
