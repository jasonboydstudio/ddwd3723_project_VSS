<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chatroom1
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
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim ChatfieldLabel As System.Windows.Forms.Label
        Dim DataGridView1 As System.Windows.Forms.DataGridView
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chatroom1))
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChatfieldDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChatsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChatsDataSet = New VSS2.ChatsDataSet()
        Me.GroupBoxChatRoom1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ChatfieldTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ChatsDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChatsTableAdapter = New VSS2.ChatsDataSetTableAdapters.ChatsTableAdapter()
        Me.TableAdapterManager = New VSS2.ChatsDataSetTableAdapters.TableAdapterManager()
        Me.clock = New System.Windows.Forms.Timer(Me.components)
        UsernameLabel = New System.Windows.Forms.Label()
        ChatfieldLabel = New System.Windows.Forms.Label()
        DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChatsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChatsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxChatRoom1.SuspendLayout()
        CType(Me.ChatsDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.ForeColor = System.Drawing.Color.White
        UsernameLabel.Location = New System.Drawing.Point(53, 53)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(132, 32)
        UsernameLabel.TabIndex = 1
        UsernameLabel.Text = "Username:"
        '
        'ChatfieldLabel
        '
        ChatfieldLabel.AutoSize = True
        ChatfieldLabel.Location = New System.Drawing.Point(35, 425)
        ChatfieldLabel.Name = "ChatfieldLabel"
        ChatfieldLabel.Size = New System.Drawing.Size(121, 32)
        ChatfieldLabel.TabIndex = 3
        ChatfieldLabel.Text = "Chatfield:"
        '
        'DataGridView1
        '
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn, Me.ChatfieldDataGridViewTextBoxColumn, Me.TimeDataGridViewTextBoxColumn})
        DataGridView1.DataSource = Me.ChatsBindingSource
        DataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace
        DataGridView1.Location = New System.Drawing.Point(41, 130)
        DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 24
        DataGridView1.Size = New System.Drawing.Size(701, 288)
        DataGridView1.TabIndex = 0
        AddHandler DataGridView1.CellContentClick, AddressOf Me.DataGridView1_CellContentClick
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UsernameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.Width = 125
        '
        'ChatfieldDataGridViewTextBoxColumn
        '
        Me.ChatfieldDataGridViewTextBoxColumn.DataPropertyName = "Chatfield"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ChatfieldDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ChatfieldDataGridViewTextBoxColumn.HeaderText = "Chatfield"
        Me.ChatfieldDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ChatfieldDataGridViewTextBoxColumn.Name = "ChatfieldDataGridViewTextBoxColumn"
        Me.ChatfieldDataGridViewTextBoxColumn.Width = 1000
        '
        'TimeDataGridViewTextBoxColumn
        '
        Me.TimeDataGridViewTextBoxColumn.DataPropertyName = "Time"
        Me.TimeDataGridViewTextBoxColumn.HeaderText = "Time"
        Me.TimeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TimeDataGridViewTextBoxColumn.Name = "TimeDataGridViewTextBoxColumn"
        Me.TimeDataGridViewTextBoxColumn.Width = 125
        '
        'ChatsBindingSource
        '
        Me.ChatsBindingSource.DataMember = "Chats"
        Me.ChatsBindingSource.DataSource = Me.ChatsDataSet
        '
        'ChatsDataSet
        '
        Me.ChatsDataSet.DataSetName = "ChatsDataSet"
        Me.ChatsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxChatRoom1
        '
        Me.GroupBoxChatRoom1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBoxChatRoom1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxChatRoom1.Controls.Add(Me.Button2)
        Me.GroupBoxChatRoom1.Controls.Add(Me.Button1)
        Me.GroupBoxChatRoom1.Controls.Add(ChatfieldLabel)
        Me.GroupBoxChatRoom1.Controls.Add(Me.ChatfieldTextBox)
        Me.GroupBoxChatRoom1.Controls.Add(UsernameLabel)
        Me.GroupBoxChatRoom1.Controls.Add(Me.UsernameTextBox)
        Me.GroupBoxChatRoom1.Controls.Add(DataGridView1)
        Me.GroupBoxChatRoom1.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxChatRoom1.ForeColor = System.Drawing.Color.White
        Me.GroupBoxChatRoom1.Location = New System.Drawing.Point(355, 48)
        Me.GroupBoxChatRoom1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxChatRoom1.Name = "GroupBoxChatRoom1"
        Me.GroupBoxChatRoom1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxChatRoom1.Size = New System.Drawing.Size(767, 538)
        Me.GroupBoxChatRoom1.TabIndex = 0
        Me.GroupBoxChatRoom1.TabStop = False
        Me.GroupBoxChatRoom1.Text = "ChatRoom1"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(409, 466)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 39)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Send"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(215, 465)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 41)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "New Text"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ChatfieldTextBox
        '
        Me.ChatfieldTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChatsBindingSource, "Chatfield", True))
        Me.ChatfieldTextBox.Location = New System.Drawing.Point(173, 422)
        Me.ChatfieldTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChatfieldTextBox.Multiline = True
        Me.ChatfieldTextBox.Name = "ChatfieldTextBox"
        Me.ChatfieldTextBox.Size = New System.Drawing.Size(568, 38)
        Me.ChatfieldTextBox.TabIndex = 4
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChatsBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(233, 53)
        Me.UsernameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(200, 39)
        Me.UsernameTextBox.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.Location = New System.Drawing.Point(8, 786)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePicker1.TabIndex = 1
        Me.DateTimePicker1.Visible = False
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(697, 746)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 48)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Home"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ChatsDataSetBindingSource
        '
        Me.ChatsDataSetBindingSource.DataSource = Me.ChatsDataSet
        Me.ChatsDataSetBindingSource.Position = 0
        '
        'ChatsTableAdapter
        '
        Me.ChatsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChatsTableAdapter = Me.ChatsTableAdapter
        Me.TableAdapterManager.UpdateOrder = VSS2.ChatsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'clock
        '
        '
        'Chatroom1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1523, 826)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBoxChatRoom1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Chatroom1"
        Me.Text = "Chatroom1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChatsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChatsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxChatRoom1.ResumeLayout(False)
        Me.GroupBoxChatRoom1.PerformLayout()
        CType(Me.ChatsDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxChatRoom1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ChatsDataSetBindingSource As BindingSource
    Friend WithEvents ChatsDataSet As ChatsDataSet
    Friend WithEvents ChatsBindingSource As BindingSource
    Friend WithEvents ChatsTableAdapter As ChatsDataSetTableAdapters.ChatsTableAdapter
    Friend WithEvents TableAdapterManager As ChatsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
    Friend WithEvents ChatfieldTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChatfieldDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents clock As Timer
End Class
