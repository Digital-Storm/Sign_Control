<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sign_Control
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("New Sign", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("IP Signs", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("COM Signs", System.Windows.Forms.HorizontalAlignment.Left)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartCommunicationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignsGroupBox = New System.Windows.Forms.GroupBox()
        Me.SignsListView = New System.Windows.Forms.ListView()
        Me.SignHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CountHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ConnectionHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EnabledHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SignConfigGroupBox = New System.Windows.Forms.GroupBox()
        Me.DeleteSignButton = New System.Windows.Forms.Button()
        Me.SaveSignButton = New System.Windows.Forms.Button()
        Me.COMSignRadio = New System.Windows.Forms.RadioButton()
        Me.IPSignRadio = New System.Windows.Forms.RadioButton()
        Me.COMGroup = New System.Windows.Forms.GroupBox()
        Me.ComPortLabel = New System.Windows.Forms.Label()
        Me.COMPortDropBox = New System.Windows.Forms.ComboBox()
        Me.IPAddressGroup = New System.Windows.Forms.GroupBox()
        Me.SignTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.SignTypeLabel = New System.Windows.Forms.Label()
        Me.IPAddressTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.IPAddressLabel = New System.Windows.Forms.Label()
        Me.PortTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BrightnessLabel = New System.Windows.Forms.Label()
        Me.BrightnessDropBox = New System.Windows.Forms.ComboBox()
        Me.PortLabel = New System.Windows.Forms.Label()
        Me.DiffsLabel = New System.Windows.Forms.Label()
        Me.DisplayModeLabel = New System.Windows.Forms.Label()
        Me.DiffsDropBox = New System.Windows.Forms.ComboBox()
        Me.DisplayModeDropBox = New System.Windows.Forms.ComboBox()
        Me.ExportNameLabel = New System.Windows.Forms.Label()
        Me.ExportNameTextBox = New System.Windows.Forms.TextBox()
        Me.CountHeaderLabel = New System.Windows.Forms.Label()
        Me.CountHeaderTextBox = New System.Windows.Forms.TextBox()
        Me.CountKeyLabel = New System.Windows.Forms.Label()
        Me.CountKeyTextBox = New System.Windows.Forms.TextBox()
        Me.SignNameLabel = New System.Windows.Forms.Label()
        Me.SignNameTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pbRandom = New System.Windows.Forms.ProgressBar()
        Me.testvalue = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SignsGroupBox.SuspendLayout()
        Me.SignConfigGroupBox.SuspendLayout()
        Me.COMGroup.SuspendLayout()
        Me.IPAddressGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ConfigurationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(852, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartCommunicationsToolStripMenuItem, Me.ToolStripSeparator2, Me.NewToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'StartCommunicationsToolStripMenuItem
        '
        Me.StartCommunicationsToolStripMenuItem.Name = "StartCommunicationsToolStripMenuItem"
        Me.StartCommunicationsToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.StartCommunicationsToolStripMenuItem.Text = "&Start Communications"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(190, 6)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SignToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'SignToolStripMenuItem
        '
        Me.SignToolStripMenuItem.Name = "SignToolStripMenuItem"
        Me.SignToolStripMenuItem.Size = New System.Drawing.Size(97, 22)
        Me.SignToolStripMenuItem.Text = "Si&gn"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(190, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ConfigurationToolStripMenuItem
        '
        Me.ConfigurationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ConfigurationToolStripMenuItem.Name = "ConfigurationToolStripMenuItem"
        Me.ConfigurationToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ConfigurationToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.ConfigurationToolStripMenuItem.Text = "&Configuration"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.OptionsToolStripMenuItem.Text = "Op&tions"
        '
        'SignsGroupBox
        '
        Me.SignsGroupBox.Controls.Add(Me.SignsListView)
        Me.SignsGroupBox.Location = New System.Drawing.Point(13, 28)
        Me.SignsGroupBox.Name = "SignsGroupBox"
        Me.SignsGroupBox.Size = New System.Drawing.Size(357, 286)
        Me.SignsGroupBox.TabIndex = 1
        Me.SignsGroupBox.TabStop = False
        Me.SignsGroupBox.Text = "Signs"
        '
        'SignsListView
        '
        Me.SignsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SignHeader, Me.CountHeader, Me.ConnectionHeader, Me.EnabledHeader})
        Me.SignsListView.FullRowSelect = True
        Me.SignsListView.GridLines = True
        ListViewGroup1.Header = "New Sign"
        ListViewGroup1.Name = "NewSignGroup"
        ListViewGroup1.Tag = "0"
        ListViewGroup2.Header = "IP Signs"
        ListViewGroup2.Name = "IPSignHeader"
        ListViewGroup2.Tag = "1"
        ListViewGroup3.Header = "COM Signs"
        ListViewGroup3.Name = "COMSignsHeader"
        ListViewGroup3.Tag = "2"
        Me.SignsListView.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        Me.SignsListView.Location = New System.Drawing.Point(6, 19)
        Me.SignsListView.MultiSelect = False
        Me.SignsListView.Name = "SignsListView"
        Me.SignsListView.Size = New System.Drawing.Size(344, 260)
        Me.SignsListView.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.SignsListView.TabIndex = 0
        Me.SignsListView.UseCompatibleStateImageBehavior = False
        Me.SignsListView.View = System.Windows.Forms.View.Details
        '
        'SignHeader
        '
        Me.SignHeader.Text = "Sign"
        Me.SignHeader.Width = 97
        '
        'CountHeader
        '
        Me.CountHeader.Text = "Count"
        Me.CountHeader.Width = 51
        '
        'ConnectionHeader
        '
        Me.ConnectionHeader.Text = "Connection"
        Me.ConnectionHeader.Width = 105
        '
        'EnabledHeader
        '
        Me.EnabledHeader.Text = "Status"
        Me.EnabledHeader.Width = 79
        '
        'SignConfigGroupBox
        '
        Me.SignConfigGroupBox.Controls.Add(Me.DeleteSignButton)
        Me.SignConfigGroupBox.Controls.Add(Me.SaveSignButton)
        Me.SignConfigGroupBox.Controls.Add(Me.COMSignRadio)
        Me.SignConfigGroupBox.Controls.Add(Me.IPSignRadio)
        Me.SignConfigGroupBox.Controls.Add(Me.COMGroup)
        Me.SignConfigGroupBox.Controls.Add(Me.IPAddressGroup)
        Me.SignConfigGroupBox.Controls.Add(Me.DiffsLabel)
        Me.SignConfigGroupBox.Controls.Add(Me.DisplayModeLabel)
        Me.SignConfigGroupBox.Controls.Add(Me.DiffsDropBox)
        Me.SignConfigGroupBox.Controls.Add(Me.DisplayModeDropBox)
        Me.SignConfigGroupBox.Controls.Add(Me.ExportNameLabel)
        Me.SignConfigGroupBox.Controls.Add(Me.ExportNameTextBox)
        Me.SignConfigGroupBox.Controls.Add(Me.CountHeaderLabel)
        Me.SignConfigGroupBox.Controls.Add(Me.CountHeaderTextBox)
        Me.SignConfigGroupBox.Controls.Add(Me.CountKeyLabel)
        Me.SignConfigGroupBox.Controls.Add(Me.CountKeyTextBox)
        Me.SignConfigGroupBox.Controls.Add(Me.SignNameLabel)
        Me.SignConfigGroupBox.Controls.Add(Me.SignNameTextBox)
        Me.SignConfigGroupBox.Location = New System.Drawing.Point(377, 28)
        Me.SignConfigGroupBox.Name = "SignConfigGroupBox"
        Me.SignConfigGroupBox.Size = New System.Drawing.Size(474, 286)
        Me.SignConfigGroupBox.TabIndex = 2
        Me.SignConfigGroupBox.TabStop = False
        Me.SignConfigGroupBox.Text = "Sign Configuration"
        '
        'DeleteSignButton
        '
        Me.DeleteSignButton.Location = New System.Drawing.Point(312, 256)
        Me.DeleteSignButton.Name = "DeleteSignButton"
        Me.DeleteSignButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteSignButton.TabIndex = 13
        Me.DeleteSignButton.TabStop = False
        Me.DeleteSignButton.Text = "Delete"
        Me.DeleteSignButton.UseVisualStyleBackColor = True
        '
        'SaveSignButton
        '
        Me.SaveSignButton.Location = New System.Drawing.Point(393, 256)
        Me.SaveSignButton.Name = "SaveSignButton"
        Me.SaveSignButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveSignButton.TabIndex = 12
        Me.SaveSignButton.Text = "Save"
        Me.SaveSignButton.UseVisualStyleBackColor = True
        '
        'COMSignRadio
        '
        Me.COMSignRadio.AutoSize = True
        Me.COMSignRadio.Location = New System.Drawing.Point(382, 19)
        Me.COMSignRadio.Name = "COMSignRadio"
        Me.COMSignRadio.Size = New System.Drawing.Size(73, 17)
        Me.COMSignRadio.TabIndex = 7
        Me.COMSignRadio.TabStop = True
        Me.COMSignRadio.Text = "COM Sign"
        Me.COMSignRadio.UseVisualStyleBackColor = True
        '
        'IPSignRadio
        '
        Me.IPSignRadio.AutoSize = True
        Me.IPSignRadio.Location = New System.Drawing.Point(276, 19)
        Me.IPSignRadio.Name = "IPSignRadio"
        Me.IPSignRadio.Size = New System.Drawing.Size(59, 17)
        Me.IPSignRadio.TabIndex = 6
        Me.IPSignRadio.TabStop = True
        Me.IPSignRadio.Text = "IP Sign"
        Me.IPSignRadio.UseVisualStyleBackColor = True
        '
        'COMGroup
        '
        Me.COMGroup.Controls.Add(Me.ComPortLabel)
        Me.COMGroup.Controls.Add(Me.COMPortDropBox)
        Me.COMGroup.Location = New System.Drawing.Point(30, 178)
        Me.COMGroup.Name = "COMGroup"
        Me.COMGroup.Size = New System.Drawing.Size(200, 46)
        Me.COMGroup.TabIndex = 21
        Me.COMGroup.TabStop = False
        Me.COMGroup.Text = "COM Sign"
        '
        'ComPortLabel
        '
        Me.ComPortLabel.AutoSize = True
        Me.ComPortLabel.Location = New System.Drawing.Point(6, 16)
        Me.ComPortLabel.Name = "ComPortLabel"
        Me.ComPortLabel.Size = New System.Drawing.Size(53, 13)
        Me.ComPortLabel.TabIndex = 11
        Me.ComPortLabel.Text = "COM Port"
        '
        'COMPortDropBox
        '
        Me.COMPortDropBox.FormattingEnabled = True
        Me.COMPortDropBox.Location = New System.Drawing.Point(102, 13)
        Me.COMPortDropBox.Name = "COMPortDropBox"
        Me.COMPortDropBox.Size = New System.Drawing.Size(92, 21)
        Me.COMPortDropBox.TabIndex = 11
        '
        'IPAddressGroup
        '
        Me.IPAddressGroup.Controls.Add(Me.SignTypeComboBox)
        Me.IPAddressGroup.Controls.Add(Me.SignTypeLabel)
        Me.IPAddressGroup.Controls.Add(Me.IPAddressTextBox)
        Me.IPAddressGroup.Controls.Add(Me.IPAddressLabel)
        Me.IPAddressGroup.Controls.Add(Me.PortTextBox)
        Me.IPAddressGroup.Controls.Add(Me.BrightnessLabel)
        Me.IPAddressGroup.Controls.Add(Me.BrightnessDropBox)
        Me.IPAddressGroup.Controls.Add(Me.PortLabel)
        Me.IPAddressGroup.Location = New System.Drawing.Point(268, 42)
        Me.IPAddressGroup.Name = "IPAddressGroup"
        Me.IPAddressGroup.Size = New System.Drawing.Size(200, 182)
        Me.IPAddressGroup.TabIndex = 20
        Me.IPAddressGroup.TabStop = False
        Me.IPAddressGroup.Text = "IP Sign"
        '
        'SignTypeComboBox
        '
        Me.SignTypeComboBox.FormattingEnabled = True
        Me.SignTypeComboBox.Items.AddRange(New Object() {"DF-2053", "Galaxy"})
        Me.SignTypeComboBox.Location = New System.Drawing.Point(87, 19)
        Me.SignTypeComboBox.Name = "SignTypeComboBox"
        Me.SignTypeComboBox.Size = New System.Drawing.Size(100, 21)
        Me.SignTypeComboBox.TabIndex = 24
        '
        'SignTypeLabel
        '
        Me.SignTypeLabel.AutoSize = True
        Me.SignTypeLabel.Location = New System.Drawing.Point(6, 22)
        Me.SignTypeLabel.Name = "SignTypeLabel"
        Me.SignTypeLabel.Size = New System.Drawing.Size(55, 13)
        Me.SignTypeLabel.TabIndex = 23
        Me.SignTypeLabel.Text = "Sign Type"
        '
        'IPAddressTextBox
        '
        Me.IPAddressTextBox.Location = New System.Drawing.Point(87, 46)
        Me.IPAddressTextBox.Name = "IPAddressTextBox"
        Me.IPAddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IPAddressTextBox.TabIndex = 7
        '
        'IPAddressLabel
        '
        Me.IPAddressLabel.AutoSize = True
        Me.IPAddressLabel.Location = New System.Drawing.Point(6, 50)
        Me.IPAddressLabel.Name = "IPAddressLabel"
        Me.IPAddressLabel.Size = New System.Drawing.Size(58, 13)
        Me.IPAddressLabel.TabIndex = 15
        Me.IPAddressLabel.Text = "IP Address"
        '
        'PortTextBox
        '
        Me.PortTextBox.Location = New System.Drawing.Point(87, 72)
        Me.PortTextBox.Name = "PortTextBox"
        Me.PortTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PortTextBox.TabIndex = 8
        '
        'BrightnessLabel
        '
        Me.BrightnessLabel.AutoSize = True
        Me.BrightnessLabel.Location = New System.Drawing.Point(6, 101)
        Me.BrightnessLabel.Name = "BrightnessLabel"
        Me.BrightnessLabel.Size = New System.Drawing.Size(56, 13)
        Me.BrightnessLabel.TabIndex = 19
        Me.BrightnessLabel.Text = "Brightness"
        '
        'BrightnessDropBox
        '
        Me.BrightnessDropBox.FormattingEnabled = True
        Me.BrightnessDropBox.Items.AddRange(New Object() {"Automatic", "Minimum", "Maximum"})
        Me.BrightnessDropBox.Location = New System.Drawing.Point(87, 98)
        Me.BrightnessDropBox.Name = "BrightnessDropBox"
        Me.BrightnessDropBox.Size = New System.Drawing.Size(100, 21)
        Me.BrightnessDropBox.TabIndex = 9
        '
        'PortLabel
        '
        Me.PortLabel.AutoSize = True
        Me.PortLabel.Location = New System.Drawing.Point(6, 76)
        Me.PortLabel.Name = "PortLabel"
        Me.PortLabel.Size = New System.Drawing.Size(26, 13)
        Me.PortLabel.TabIndex = 17
        Me.PortLabel.Text = "Port"
        '
        'DiffsLabel
        '
        Me.DiffsLabel.AutoSize = True
        Me.DiffsLabel.Location = New System.Drawing.Point(34, 154)
        Me.DiffsLabel.Name = "DiffsLabel"
        Me.DiffsLabel.Size = New System.Drawing.Size(47, 13)
        Me.DiffsLabel.TabIndex = 13
        Me.DiffsLabel.Text = "Diffs File"
        '
        'DisplayModeLabel
        '
        Me.DisplayModeLabel.AutoSize = True
        Me.DisplayModeLabel.Location = New System.Drawing.Point(34, 127)
        Me.DisplayModeLabel.Name = "DisplayModeLabel"
        Me.DisplayModeLabel.Size = New System.Drawing.Size(71, 13)
        Me.DisplayModeLabel.TabIndex = 12
        Me.DisplayModeLabel.Text = "Display Mode"
        '
        'DiffsDropBox
        '
        Me.DiffsDropBox.FormattingEnabled = True
        Me.DiffsDropBox.Location = New System.Drawing.Point(130, 151)
        Me.DiffsDropBox.Name = "DiffsDropBox"
        Me.DiffsDropBox.Size = New System.Drawing.Size(121, 21)
        Me.DiffsDropBox.TabIndex = 5
        '
        'DisplayModeDropBox
        '
        Me.DisplayModeDropBox.FormattingEnabled = True
        Me.DisplayModeDropBox.Items.AddRange(New Object() {"Normal", "Manual 'FULL'", "Manual 'OPEN'", "manual 'CLOSED'", "Disabled"})
        Me.DisplayModeDropBox.Location = New System.Drawing.Point(130, 124)
        Me.DisplayModeDropBox.Name = "DisplayModeDropBox"
        Me.DisplayModeDropBox.Size = New System.Drawing.Size(121, 21)
        Me.DisplayModeDropBox.TabIndex = 4
        '
        'ExportNameLabel
        '
        Me.ExportNameLabel.AutoSize = True
        Me.ExportNameLabel.Location = New System.Drawing.Point(34, 101)
        Me.ExportNameLabel.Name = "ExportNameLabel"
        Me.ExportNameLabel.Size = New System.Drawing.Size(68, 13)
        Me.ExportNameLabel.TabIndex = 7
        Me.ExportNameLabel.Text = "Export Name"
        '
        'ExportNameTextBox
        '
        Me.ExportNameTextBox.Location = New System.Drawing.Point(130, 98)
        Me.ExportNameTextBox.Name = "ExportNameTextBox"
        Me.ExportNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ExportNameTextBox.TabIndex = 3
        '
        'CountHeaderLabel
        '
        Me.CountHeaderLabel.AutoSize = True
        Me.CountHeaderLabel.Location = New System.Drawing.Point(34, 75)
        Me.CountHeaderLabel.Name = "CountHeaderLabel"
        Me.CountHeaderLabel.Size = New System.Drawing.Size(90, 13)
        Me.CountHeaderLabel.TabIndex = 5
        Me.CountHeaderLabel.Text = "Count INI Header"
        '
        'CountHeaderTextBox
        '
        Me.CountHeaderTextBox.Location = New System.Drawing.Point(130, 72)
        Me.CountHeaderTextBox.Name = "CountHeaderTextBox"
        Me.CountHeaderTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CountHeaderTextBox.TabIndex = 2
        '
        'CountKeyLabel
        '
        Me.CountKeyLabel.AutoSize = True
        Me.CountKeyLabel.Location = New System.Drawing.Point(34, 49)
        Me.CountKeyLabel.Name = "CountKeyLabel"
        Me.CountKeyLabel.Size = New System.Drawing.Size(73, 13)
        Me.CountKeyLabel.TabIndex = 3
        Me.CountKeyLabel.Text = "Count INI Key"
        '
        'CountKeyTextBox
        '
        Me.CountKeyTextBox.Location = New System.Drawing.Point(130, 46)
        Me.CountKeyTextBox.Name = "CountKeyTextBox"
        Me.CountKeyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CountKeyTextBox.TabIndex = 1
        '
        'SignNameLabel
        '
        Me.SignNameLabel.AutoSize = True
        Me.SignNameLabel.Location = New System.Drawing.Point(34, 23)
        Me.SignNameLabel.Name = "SignNameLabel"
        Me.SignNameLabel.Size = New System.Drawing.Size(59, 13)
        Me.SignNameLabel.TabIndex = 1
        Me.SignNameLabel.Text = "Sign Name"
        '
        'SignNameTextBox
        '
        Me.SignNameTextBox.Location = New System.Drawing.Point(130, 20)
        Me.SignNameTextBox.Name = "SignNameTextBox"
        Me.SignNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SignNameTextBox.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(128, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(209, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "123"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(315, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'pbRandom
        '
        Me.pbRandom.Location = New System.Drawing.Point(396, 1)
        Me.pbRandom.Name = "pbRandom"
        Me.pbRandom.Size = New System.Drawing.Size(100, 23)
        Me.pbRandom.TabIndex = 6
        '
        'testvalue
        '
        Me.testvalue.AutoSize = True
        Me.testvalue.Location = New System.Drawing.Point(503, 4)
        Me.testvalue.Name = "testvalue"
        Me.testvalue.Size = New System.Drawing.Size(24, 13)
        Me.testvalue.TabIndex = 7
        Me.testvalue.Text = "test"
        '
        'Sign_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(862, 326)
        Me.Controls.Add(Me.testvalue)
        Me.Controls.Add(Me.pbRandom)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SignConfigGroupBox)
        Me.Controls.Add(Me.SignsGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Sign_Control"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Sign Control"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SignsGroupBox.ResumeLayout(False)
        Me.SignConfigGroupBox.ResumeLayout(False)
        Me.SignConfigGroupBox.PerformLayout()
        Me.COMGroup.ResumeLayout(False)
        Me.COMGroup.PerformLayout()
        Me.IPAddressGroup.ResumeLayout(False)
        Me.IPAddressGroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartCommunicationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigurationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SignToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SignsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SignConfigGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SignsListView As System.Windows.Forms.ListView
    Friend WithEvents SignHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents CountHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents ConnectionHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents BrightnessLabel As System.Windows.Forms.Label
    Friend WithEvents BrightnessDropBox As System.Windows.Forms.ComboBox
    Friend WithEvents PortLabel As System.Windows.Forms.Label
    Friend WithEvents IPAddressLabel As System.Windows.Forms.Label
    Friend WithEvents DiffsLabel As System.Windows.Forms.Label
    Friend WithEvents DisplayModeLabel As System.Windows.Forms.Label
    Friend WithEvents ComPortLabel As System.Windows.Forms.Label
    Friend WithEvents DiffsDropBox As System.Windows.Forms.ComboBox
    Friend WithEvents DisplayModeDropBox As System.Windows.Forms.ComboBox
    Friend WithEvents COMPortDropBox As System.Windows.Forms.ComboBox
    Friend WithEvents ExportNameLabel As System.Windows.Forms.Label
    Friend WithEvents ExportNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountHeaderLabel As System.Windows.Forms.Label
    Friend WithEvents CountHeaderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountKeyLabel As System.Windows.Forms.Label
    Friend WithEvents CountKeyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SignNameLabel As System.Windows.Forms.Label
    Friend WithEvents SignNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnabledHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents COMSignRadio As System.Windows.Forms.RadioButton
    Friend WithEvents COMGroup As System.Windows.Forms.GroupBox
    Friend WithEvents IPAddressGroup As System.Windows.Forms.GroupBox
    Friend WithEvents IPSignRadio As System.Windows.Forms.RadioButton
    Friend WithEvents SaveSignButton As System.Windows.Forms.Button
    Friend WithEvents DeleteSignButton As System.Windows.Forms.Button
    Friend WithEvents IPAddressTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PortTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SignTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SignTypeLabel As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents pbRandom As System.Windows.Forms.ProgressBar
    Friend WithEvents testvalue As System.Windows.Forms.Label
End Class
