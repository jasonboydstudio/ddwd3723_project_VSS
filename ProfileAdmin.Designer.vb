<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileAdmin
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
        Dim SUsernameLabel As System.Windows.Forms.Label
        Dim SPasswordLabel As System.Windows.Forms.Label
        Dim SEmailLabel As System.Windows.Forms.Label
        Dim FullnameLabel As System.Windows.Forms.Label
        Dim Date_of_BirthLabel As System.Windows.Forms.Label
        Dim Phone_NoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProfileAdmin))
        Me.SearchProfileMe = New System.Windows.Forms.Button()
        Me.ButtonHomeProfileMe = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.search_txtbx = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Phone_NoTextBox = New System.Windows.Forms.TextBox()
        Me.UserProfileBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VSSdatabaseDataSet3 = New VSS2.VSSdatabaseDataSet3()
        Me.Date_of_BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FullnameTextBox = New System.Windows.Forms.TextBox()
        Me.SEmailTextBox = New System.Windows.Forms.TextBox()
        Me.SPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.SUsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Add_Btton = New System.Windows.Forms.Button()
        Me.clearBtnMe = New System.Windows.Forms.Button()
        Me.AddInfoMe = New System.Windows.Forms.Button()
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        SUsernameLabel = New System.Windows.Forms.Label()
        SPasswordLabel = New System.Windows.Forms.Label()
        SEmailLabel = New System.Windows.Forms.Label()
        FullnameLabel = New System.Windows.Forms.Label()
        Date_of_BirthLabel = New System.Windows.Forms.Label()
        Phone_NoLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.UserProfileBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VSSdatabaseDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserProfileBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VSSdatabaseDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VSSdatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SUsernameLabel
        '
        SUsernameLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        SUsernameLabel.AutoSize = True
        SUsernameLabel.Font = New System.Drawing.Font("Poppins SemiBold", 10.0!, System.Drawing.FontStyle.Bold)
        SUsernameLabel.ForeColor = System.Drawing.Color.White
        SUsernameLabel.Location = New System.Drawing.Point(43, 14)
        SUsernameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SUsernameLabel.Name = "SUsernameLabel"
        SUsernameLabel.Size = New System.Drawing.Size(91, 25)
        SUsernameLabel.TabIndex = 0
        SUsernameLabel.Text = "Username:"
        '
        'SPasswordLabel
        '
        SPasswordLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        SPasswordLabel.AutoSize = True
        SPasswordLabel.Font = New System.Drawing.Font("Poppins SemiBold", 10.0!, System.Drawing.FontStyle.Bold)
        SPasswordLabel.ForeColor = System.Drawing.Color.White
        SPasswordLabel.Location = New System.Drawing.Point(43, 55)
        SPasswordLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SPasswordLabel.Name = "SPasswordLabel"
        SPasswordLabel.Size = New System.Drawing.Size(86, 25)
        SPasswordLabel.TabIndex = 2
        SPasswordLabel.Text = "Password:"
        '
        'SEmailLabel
        '
        SEmailLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        SEmailLabel.AutoSize = True
        SEmailLabel.Font = New System.Drawing.Font("Poppins SemiBold", 10.0!, System.Drawing.FontStyle.Bold)
        SEmailLabel.ForeColor = System.Drawing.Color.White
        SEmailLabel.Location = New System.Drawing.Point(43, 98)
        SEmailLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SEmailLabel.Name = "SEmailLabel"
        SEmailLabel.Size = New System.Drawing.Size(55, 25)
        SEmailLabel.TabIndex = 4
        SEmailLabel.Text = "Email:"
        AddHandler SEmailLabel.Click, AddressOf Me.SEmailLabel_Click_1
        '
        'FullnameLabel
        '
        FullnameLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        FullnameLabel.AutoSize = True
        FullnameLabel.Font = New System.Drawing.Font("Poppins SemiBold", 10.0!, System.Drawing.FontStyle.Bold)
        FullnameLabel.ForeColor = System.Drawing.Color.White
        FullnameLabel.Location = New System.Drawing.Point(43, 138)
        FullnameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FullnameLabel.Name = "FullnameLabel"
        FullnameLabel.Size = New System.Drawing.Size(82, 25)
        FullnameLabel.TabIndex = 6
        FullnameLabel.Text = "Fullname:"
        '
        'Date_of_BirthLabel
        '
        Date_of_BirthLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Date_of_BirthLabel.AutoSize = True
        Date_of_BirthLabel.Font = New System.Drawing.Font("Poppins SemiBold", 10.0!, System.Drawing.FontStyle.Bold)
        Date_of_BirthLabel.ForeColor = System.Drawing.Color.White
        Date_of_BirthLabel.Location = New System.Drawing.Point(43, 172)
        Date_of_BirthLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Date_of_BirthLabel.Name = "Date_of_BirthLabel"
        Date_of_BirthLabel.Size = New System.Drawing.Size(102, 25)
        Date_of_BirthLabel.TabIndex = 8
        Date_of_BirthLabel.Text = "Date of Birth:"
        '
        'Phone_NoLabel
        '
        Phone_NoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Phone_NoLabel.AutoSize = True
        Phone_NoLabel.Font = New System.Drawing.Font("Poppins SemiBold", 10.0!, System.Drawing.FontStyle.Bold)
        Phone_NoLabel.ForeColor = System.Drawing.Color.White
        Phone_NoLabel.Location = New System.Drawing.Point(43, 206)
        Phone_NoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Phone_NoLabel.Name = "Phone_NoLabel"
        Phone_NoLabel.Size = New System.Drawing.Size(83, 25)
        Phone_NoLabel.TabIndex = 10
        Phone_NoLabel.Text = "Phone No:"
        '
        'SearchProfileMe
        '
        Me.SearchProfileMe.Font = New System.Drawing.Font("Poppins SemiBold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.SearchProfileMe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SearchProfileMe.Location = New System.Drawing.Point(65, 41)
        Me.SearchProfileMe.Name = "SearchProfileMe"
        Me.SearchProfileMe.Size = New System.Drawing.Size(134, 47)
        Me.SearchProfileMe.TabIndex = 35
        Me.SearchProfileMe.Text = "Search"
        Me.SearchProfileMe.UseVisualStyleBackColor = True
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
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.search_txtbx)
        Me.Panel1.Controls.Add(Me.SearchProfileMe)
        Me.Panel1.Location = New System.Drawing.Point(91, 197)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(261, 101)
        Me.Panel1.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 25)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Enter username"
        '
        'search_txtbx
        '
        Me.search_txtbx.Font = New System.Drawing.Font("Adobe Caslon Pro", 10.0!, System.Drawing.FontStyle.Bold)
        Me.search_txtbx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.search_txtbx.Location = New System.Drawing.Point(141, 13)
        Me.search_txtbx.Margin = New System.Windows.Forms.Padding(2)
        Me.search_txtbx.Name = "search_txtbx"
        Me.search_txtbx.Size = New System.Drawing.Size(99, 23)
        Me.search_txtbx.TabIndex = 36
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoSize = True
        Me.Panel2.Controls.Add(Phone_NoLabel)
        Me.Panel2.Controls.Add(Me.Phone_NoTextBox)
        Me.Panel2.Controls.Add(Date_of_BirthLabel)
        Me.Panel2.Controls.Add(Me.Date_of_BirthDateTimePicker)
        Me.Panel2.Controls.Add(FullnameLabel)
        Me.Panel2.Controls.Add(Me.FullnameTextBox)
        Me.Panel2.Controls.Add(SEmailLabel)
        Me.Panel2.Controls.Add(Me.SEmailTextBox)
        Me.Panel2.Controls.Add(SPasswordLabel)
        Me.Panel2.Controls.Add(Me.SPasswordTextBox)
        Me.Panel2.Controls.Add(SUsernameLabel)
        Me.Panel2.Controls.Add(Me.SUsernameTextBox)
        Me.Panel2.Location = New System.Drawing.Point(358, 197)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(417, 277)
        Me.Panel2.TabIndex = 38
        '
        'Phone_NoTextBox
        '
        Me.Phone_NoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Phone_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfileBindingSource2, "Phone No", True))
        Me.Phone_NoTextBox.Font = New System.Drawing.Font("Adobe Caslon Pro", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Phone_NoTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Phone_NoTextBox.Location = New System.Drawing.Point(173, 206)
        Me.Phone_NoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Phone_NoTextBox.Name = "Phone_NoTextBox"
        Me.Phone_NoTextBox.Size = New System.Drawing.Size(164, 23)
        Me.Phone_NoTextBox.TabIndex = 11
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
        'Date_of_BirthDateTimePicker
        '
        Me.Date_of_BirthDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Date_of_BirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UserProfileBindingSource2, "Date of Birth", True))
        Me.Date_of_BirthDateTimePicker.Font = New System.Drawing.Font("Adobe Caslon Pro", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Date_of_BirthDateTimePicker.Location = New System.Drawing.Point(173, 172)
        Me.Date_of_BirthDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.Date_of_BirthDateTimePicker.Name = "Date_of_BirthDateTimePicker"
        Me.Date_of_BirthDateTimePicker.Size = New System.Drawing.Size(164, 23)
        Me.Date_of_BirthDateTimePicker.TabIndex = 9
        '
        'FullnameTextBox
        '
        Me.FullnameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.FullnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfileBindingSource2, "Fullname", True))
        Me.FullnameTextBox.Font = New System.Drawing.Font("Adobe Caslon Pro", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FullnameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FullnameTextBox.Location = New System.Drawing.Point(173, 139)
        Me.FullnameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FullnameTextBox.Name = "FullnameTextBox"
        Me.FullnameTextBox.Size = New System.Drawing.Size(164, 23)
        Me.FullnameTextBox.TabIndex = 7
        '
        'SEmailTextBox
        '
        Me.SEmailTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.SEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfileBindingSource2, "sEmail", True))
        Me.SEmailTextBox.Font = New System.Drawing.Font("Adobe Caslon Pro", 10.0!, System.Drawing.FontStyle.Bold)
        Me.SEmailTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SEmailTextBox.Location = New System.Drawing.Point(173, 99)
        Me.SEmailTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SEmailTextBox.Name = "SEmailTextBox"
        Me.SEmailTextBox.Size = New System.Drawing.Size(164, 23)
        Me.SEmailTextBox.TabIndex = 5
        '
        'SPasswordTextBox
        '
        Me.SPasswordTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.SPasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfileBindingSource2, "sPassword", True))
        Me.SPasswordTextBox.Font = New System.Drawing.Font("Adobe Caslon Pro", 10.0!, System.Drawing.FontStyle.Bold)
        Me.SPasswordTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SPasswordTextBox.Location = New System.Drawing.Point(173, 55)
        Me.SPasswordTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SPasswordTextBox.Name = "SPasswordTextBox"
        Me.SPasswordTextBox.Size = New System.Drawing.Size(164, 23)
        Me.SPasswordTextBox.TabIndex = 3
        '
        'SUsernameTextBox
        '
        Me.SUsernameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.SUsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfileBindingSource2, "sUsername", True))
        Me.SUsernameTextBox.Font = New System.Drawing.Font("Adobe Caslon Pro", 10.0!, System.Drawing.FontStyle.Bold)
        Me.SUsernameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SUsernameTextBox.Location = New System.Drawing.Point(173, 15)
        Me.SUsernameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SUsernameTextBox.Name = "SUsernameTextBox"
        Me.SUsernameTextBox.Size = New System.Drawing.Size(164, 23)
        Me.SUsernameTextBox.TabIndex = 1
        '
        'Add_Btton
        '
        Me.Add_Btton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Add_Btton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Add_Btton.Font = New System.Drawing.Font("Poppins SemiBold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Add_Btton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Add_Btton.Location = New System.Drawing.Point(81, 16)
        Me.Add_Btton.Name = "Add_Btton"
        Me.Add_Btton.Size = New System.Drawing.Size(180, 64)
        Me.Add_Btton.TabIndex = 39
        Me.Add_Btton.Text = "Add New"
        Me.Add_Btton.UseVisualStyleBackColor = True
        '
        'clearBtnMe
        '
        Me.clearBtnMe.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.clearBtnMe.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.clearBtnMe.Font = New System.Drawing.Font("Poppins SemiBold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.clearBtnMe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.clearBtnMe.Location = New System.Drawing.Point(502, 16)
        Me.clearBtnMe.Name = "clearBtnMe"
        Me.clearBtnMe.Size = New System.Drawing.Size(184, 64)
        Me.clearBtnMe.TabIndex = 39
        Me.clearBtnMe.Text = "Clear"
        Me.clearBtnMe.UseVisualStyleBackColor = True
        '
        'AddInfoMe
        '
        Me.AddInfoMe.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AddInfoMe.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AddInfoMe.Font = New System.Drawing.Font("Poppins SemiBold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.AddInfoMe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AddInfoMe.Location = New System.Drawing.Point(285, 16)
        Me.AddInfoMe.Name = "AddInfoMe"
        Me.AddInfoMe.Size = New System.Drawing.Size(184, 64)
        Me.AddInfoMe.TabIndex = 39
        Me.AddInfoMe.Text = "Save"
        Me.AddInfoMe.UseVisualStyleBackColor = True
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
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.AddInfoMe)
        Me.Panel3.Controls.Add(Me.clearBtnMe)
        Me.Panel3.Controls.Add(Me.Add_Btton)
        Me.Panel3.Location = New System.Drawing.Point(183, 480)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(754, 100)
        Me.Panel3.TabIndex = 42
        '
        'ProfileAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1036, 664)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonHomeProfileMe)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProfileAdmin"
        Me.Text = "ProfileAdmin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.UserProfileBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VSSdatabaseDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserProfileBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VSSdatabaseDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VSSdatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchProfileMe As Button
    Friend WithEvents ButtonHomeProfileMe As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents clearBtnMe As Button
    Friend WithEvents AddInfoMe As Button
    Friend WithEvents VSSdatabaseDataSet1 As VSSdatabaseDataSet1
    Friend WithEvents UserProfileBindingSource As BindingSource
    Friend WithEvents UserProfileTableAdapter As VSSdatabaseDataSet1TableAdapters.UserProfileTableAdapter
    Friend WithEvents TableAdapterManager As VSSdatabaseDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Add_Btton As Button
    Friend WithEvents VSSdatabaseDataSet2 As VSSdatabaseDataSet2
    Friend WithEvents UserProfileBindingSource1 As BindingSource
    Friend WithEvents UserProfileTableAdapter1 As VSSdatabaseDataSet2TableAdapters.UserProfileTableAdapter
    Friend WithEvents TableAdapterManager1 As VSSdatabaseDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents VSSdatabaseDataSet3 As VSSdatabaseDataSet3
    Friend WithEvents UserProfileBindingSource2 As BindingSource
    Friend WithEvents UserProfileTableAdapter2 As VSSdatabaseDataSet3TableAdapters.UserProfileTableAdapter
    Friend WithEvents TableAdapterManager2 As VSSdatabaseDataSet3TableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents search_txtbx As TextBox
    Friend WithEvents Phone_NoTextBox As TextBox
    Friend WithEvents Date_of_BirthDateTimePicker As DateTimePicker
    Friend WithEvents FullnameTextBox As TextBox
    Friend WithEvents SEmailTextBox As TextBox
    Friend WithEvents SPasswordTextBox As TextBox
    Friend WithEvents SUsernameTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
End Class
