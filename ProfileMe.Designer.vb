<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileMe
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProfileMe))
        Me.ButtonHomeProfileMe = New System.Windows.Forms.Button()
        Me.UserProfileBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VSSdatabaseDataSet3 = New VSS2.VSSdatabaseDataSet3()
        Me.UserProfileBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VSSdatabaseDataSet2 = New VSS2.VSSdatabaseDataSet2()
        Me.UserProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VSSdatabaseDataSet1 = New VSS2.VSSdatabaseDataSet1()
        Me.UserProfileTableAdapter = New VSS2.VSSdatabaseDataSet1TableAdapters.UserProfileTableAdapter()
        Me.TableAdapterManager = New VSS2.VSSdatabaseDataSet1TableAdapters.TableAdapterManager()
        Me.UserProfileTableAdapter1 = New VSS2.VSSdatabaseDataSet2TableAdapters.UserProfileTableAdapter()
        Me.TableAdapterManager1 = New VSS2.VSSdatabaseDataSet2TableAdapters.TableAdapterManager()
        Me.UserProfileTableAdapter2 = New VSS2.VSSdatabaseDataSet3TableAdapters.UserProfileTableAdapter()
        Me.TableAdapterManager2 = New VSS2.VSSdatabaseDataSet3TableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.usernameBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.emailBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pwBox = New System.Windows.Forms.TextBox()
        Me.fnameBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dobBox = New System.Windows.Forms.TextBox()
        Me.phoneBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        CType(Me.UserProfileBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VSSdatabaseDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserProfileBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VSSdatabaseDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VSSdatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonHomeProfileMe
        '
        Me.ButtonHomeProfileMe.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonHomeProfileMe.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonHomeProfileMe.Font = New System.Drawing.Font("Poppins SemiBold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonHomeProfileMe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonHomeProfileMe.Location = New System.Drawing.Point(457, 605)
        Me.ButtonHomeProfileMe.Name = "ButtonHomeProfileMe"
        Me.ButtonHomeProfileMe.Size = New System.Drawing.Size(134, 47)
        Me.ButtonHomeProfileMe.TabIndex = 34
        Me.ButtonHomeProfileMe.Text = "Home"
        Me.ButtonHomeProfileMe.UseVisualStyleBackColor = True
        '
        'UserProfileBindingSource2
        '
        Me.UserProfileBindingSource2.DataMember = "UserProfile"
        Me.UserProfileBindingSource2.DataSource = Me.VSSdatabaseDataSet3
        '
        'VSSdatabaseDataSet3
        '
        Me.VSSdatabaseDataSet3.DataSetName = "VSSdatabaseDataSet3"
        Me.VSSdatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserProfileBindingSource1
        '
        Me.UserProfileBindingSource1.DataMember = "UserProfile"
        Me.UserProfileBindingSource1.DataSource = Me.VSSdatabaseDataSet2
        '
        'VSSdatabaseDataSet2
        '
        Me.VSSdatabaseDataSet2.DataSetName = "VSSdatabaseDataSet2"
        Me.VSSdatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserProfileBindingSource
        '
        Me.UserProfileBindingSource.DataMember = "UserProfile"
        Me.UserProfileBindingSource.DataSource = Me.VSSdatabaseDataSet1
        '
        'VSSdatabaseDataSet1
        '
        Me.VSSdatabaseDataSet1.DataSetName = "VSSdatabaseDataSet1"
        Me.VSSdatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserProfileTableAdapter
        '
        Me.UserProfileTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RankingDatabaseTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = VSS2.VSSdatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserDatabaseTableAdapter = Nothing
        Me.TableAdapterManager.UserProfileTableAdapter = Me.UserProfileTableAdapter
        '
        'UserProfileTableAdapter1
        '
        Me.UserProfileTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.RankingDatabaseTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = VSS2.VSSdatabaseDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UserDatabaseTableAdapter = Nothing
        Me.TableAdapterManager1.UserProfileTableAdapter = Me.UserProfileTableAdapter1
        '
        'UserProfileTableAdapter2
        '
        Me.UserProfileTableAdapter2.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.RankingDatabaseTableAdapter = Nothing
        Me.TableAdapterManager2.UpdateOrder = VSS2.VSSdatabaseDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager2.UserDatabaseTableAdapter = Nothing
        Me.TableAdapterManager2.UserProfileTableAdapter = Me.UserProfileTableAdapter2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.Image = Global.VSS2.My.Resources.Resources.logo_no_bg
        Me.PictureBox1.Location = New System.Drawing.Point(389, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(247, 192)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'usernameBox
        '
        Me.usernameBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.usernameBox.Font = New System.Drawing.Font("Adobe Caslon Pro", 10.0!, System.Drawing.FontStyle.Bold)
        Me.usernameBox.Location = New System.Drawing.Point(209, 64)
        Me.usernameBox.Name = "usernameBox"
        Me.usernameBox.Size = New System.Drawing.Size(157, 23)
        Me.usernameBox.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(96, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 25)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Username :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(430, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 48)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "My Profile"
        '
        'emailBox
        '
        Me.emailBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.emailBox.Font = New System.Drawing.Font("Adobe Caslon Pro", 10.0!, System.Drawing.FontStyle.Bold)
        Me.emailBox.Location = New System.Drawing.Point(209, 93)
        Me.emailBox.Name = "emailBox"
        Me.emailBox.Size = New System.Drawing.Size(157, 23)
        Me.emailBox.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins SemiBold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(96, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 25)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Email :"
        '
        'pwBox
        '
        Me.pwBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pwBox.Font = New System.Drawing.Font("Adobe Caslon Pro", 10.0!, System.Drawing.FontStyle.Bold)
        Me.pwBox.Location = New System.Drawing.Point(209, 122)
        Me.pwBox.Name = "pwBox"
        Me.pwBox.Size = New System.Drawing.Size(157, 23)
        Me.pwBox.TabIndex = 42
        '
        'fnameBox
        '
        Me.fnameBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fnameBox.Font = New System.Drawing.Font("Adobe Caslon Pro", 10.0!, System.Drawing.FontStyle.Bold)
        Me.fnameBox.Location = New System.Drawing.Point(209, 151)
        Me.fnameBox.Name = "fnameBox"
        Me.fnameBox.Size = New System.Drawing.Size(157, 23)
        Me.fnameBox.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins SemiBold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(96, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 25)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Password :"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins SemiBold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(96, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 25)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Fullname :"
        '
        'dobBox
        '
        Me.dobBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dobBox.Font = New System.Drawing.Font("Adobe Caslon Pro", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dobBox.Location = New System.Drawing.Point(209, 185)
        Me.dobBox.Name = "dobBox"
        Me.dobBox.Size = New System.Drawing.Size(157, 23)
        Me.dobBox.TabIndex = 42
        '
        'phoneBox
        '
        Me.phoneBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.phoneBox.Font = New System.Drawing.Font("Adobe Caslon Pro", 10.0!, System.Drawing.FontStyle.Bold)
        Me.phoneBox.Location = New System.Drawing.Point(209, 214)
        Me.phoneBox.Name = "phoneBox"
        Me.phoneBox.Size = New System.Drawing.Size(157, 23)
        Me.phoneBox.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins SemiBold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(96, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 25)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Date Of Birth :"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins SemiBold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(96, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 25)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Phone No :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.usernameBox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.emailBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.pwBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.fnameBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dobBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.phoneBox)
        Me.GroupBox1.Location = New System.Drawing.Point(288, 245)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 307)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        '
        'ProfileMe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1036, 664)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonHomeProfileMe)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProfileMe"
        Me.Text = "ProfileAdmin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UserProfileBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VSSdatabaseDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserProfileBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VSSdatabaseDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VSSdatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonHomeProfileMe As Button
    Friend WithEvents VSSdatabaseDataSet1 As VSSdatabaseDataSet1
    Friend WithEvents UserProfileBindingSource As BindingSource
    Friend WithEvents UserProfileTableAdapter As VSSdatabaseDataSet1TableAdapters.UserProfileTableAdapter
    Friend WithEvents TableAdapterManager As VSSdatabaseDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents VSSdatabaseDataSet2 As VSSdatabaseDataSet2
    Friend WithEvents UserProfileBindingSource1 As BindingSource
    Friend WithEvents UserProfileTableAdapter1 As VSSdatabaseDataSet2TableAdapters.UserProfileTableAdapter
    Friend WithEvents TableAdapterManager1 As VSSdatabaseDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents VSSdatabaseDataSet3 As VSSdatabaseDataSet3
    Friend WithEvents UserProfileBindingSource2 As BindingSource
    Friend WithEvents UserProfileTableAdapter2 As VSSdatabaseDataSet3TableAdapters.UserProfileTableAdapter
    Friend WithEvents TableAdapterManager2 As VSSdatabaseDataSet3TableAdapters.TableAdapterManager
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents usernameBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents emailBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pwBox As TextBox
    Friend WithEvents fnameBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dobBox As TextBox
    Friend WithEvents phoneBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class
