<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.SettingsMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiffsiniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsGroup = New System.Windows.Forms.GroupBox()
        Me.UpdateIntervalTextBox = New System.Windows.Forms.NumericUpDown()
        Me.DiffsListView = New System.Windows.Forms.ListView()
        Me.FileName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FileLocation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ExportToCSVOption = New System.Windows.Forms.CheckBox()
        Me.ExportToJSONOption = New System.Windows.Forms.CheckBox()
        Me.DiffsLabel = New System.Windows.Forms.Label()
        Me.UpdateIntervalLabel = New System.Windows.Forms.Label()
        Me.DisplayFullOption = New System.Windows.Forms.CheckBox()
        Me.ChecksumOption = New System.Windows.Forms.CheckBox()
        Me.StartUpOption = New System.Windows.Forms.CheckBox()
        Me.DiffsGroup = New System.Windows.Forms.GroupBox()
        Me.DiffsRemoveButton = New System.Windows.Forms.Button()
        Me.DiffsRefreshButton = New System.Windows.Forms.Button()
        Me.DiffsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SettingsMenuStrip.SuspendLayout()
        Me.OptionsGroup.SuspendLayout()
        CType(Me.UpdateIntervalTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DiffsGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'SettingsMenuStrip
        '
        Me.SettingsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.SettingsMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.SettingsMenuStrip.Name = "SettingsMenuStrip"
        Me.SettingsMenuStrip.Size = New System.Drawing.Size(725, 24)
        Me.SettingsMenuStrip.TabIndex = 0
        Me.SettingsMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DiffsiniToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "&Add"
        '
        'DiffsiniToolStripMenuItem
        '
        Me.DiffsiniToolStripMenuItem.Name = "DiffsiniToolStripMenuItem"
        Me.DiffsiniToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DiffsiniToolStripMenuItem.Text = "&Diffs.ini"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'OptionsGroup
        '
        Me.OptionsGroup.Controls.Add(Me.UpdateIntervalTextBox)
        Me.OptionsGroup.Controls.Add(Me.DiffsListView)
        Me.OptionsGroup.Controls.Add(Me.ExportToCSVOption)
        Me.OptionsGroup.Controls.Add(Me.ExportToJSONOption)
        Me.OptionsGroup.Controls.Add(Me.DiffsLabel)
        Me.OptionsGroup.Controls.Add(Me.UpdateIntervalLabel)
        Me.OptionsGroup.Controls.Add(Me.DisplayFullOption)
        Me.OptionsGroup.Controls.Add(Me.ChecksumOption)
        Me.OptionsGroup.Controls.Add(Me.StartUpOption)
        Me.OptionsGroup.Location = New System.Drawing.Point(12, 27)
        Me.OptionsGroup.Name = "OptionsGroup"
        Me.OptionsGroup.Size = New System.Drawing.Size(394, 307)
        Me.OptionsGroup.TabIndex = 1
        Me.OptionsGroup.TabStop = False
        Me.OptionsGroup.Text = "Options"
        '
        'UpdateIntervalTextBox
        '
        Me.UpdateIntervalTextBox.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UpdateIntervalTextBox.Location = New System.Drawing.Point(258, 16)
        Me.UpdateIntervalTextBox.Maximum = New Decimal(New Integer() {50000, 0, 0, 0})
        Me.UpdateIntervalTextBox.Minimum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.UpdateIntervalTextBox.Name = "UpdateIntervalTextBox"
        Me.UpdateIntervalTextBox.Size = New System.Drawing.Size(120, 20)
        Me.UpdateIntervalTextBox.TabIndex = 17
        Me.UpdateIntervalTextBox.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'DiffsListView
        '
        Me.DiffsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FileName, Me.FileLocation})
        Me.DiffsListView.FullRowSelect = True
        Me.DiffsListView.GridLines = True
        Me.DiffsListView.Location = New System.Drawing.Point(6, 113)
        Me.DiffsListView.MultiSelect = False
        Me.DiffsListView.Name = "DiffsListView"
        Me.DiffsListView.Size = New System.Drawing.Size(381, 188)
        Me.DiffsListView.TabIndex = 16
        Me.DiffsListView.UseCompatibleStateImageBehavior = False
        Me.DiffsListView.View = System.Windows.Forms.View.Details
        '
        'FileName
        '
        Me.FileName.Text = "File Name"
        Me.FileName.Width = 131
        '
        'FileLocation
        '
        Me.FileLocation.Text = "File Location"
        Me.FileLocation.Width = 245
        '
        'ExportToCSVOption
        '
        Me.ExportToCSVOption.AutoSize = True
        Me.ExportToCSVOption.Location = New System.Drawing.Point(175, 67)
        Me.ExportToCSVOption.Name = "ExportToCSVOption"
        Me.ExportToCSVOption.Size = New System.Drawing.Size(92, 17)
        Me.ExportToCSVOption.TabIndex = 15
        Me.ExportToCSVOption.Text = "Export to CSV"
        Me.ExportToCSVOption.UseVisualStyleBackColor = True
        '
        'ExportToJSONOption
        '
        Me.ExportToJSONOption.AutoSize = True
        Me.ExportToJSONOption.Location = New System.Drawing.Point(175, 42)
        Me.ExportToJSONOption.Name = "ExportToJSONOption"
        Me.ExportToJSONOption.Size = New System.Drawing.Size(99, 17)
        Me.ExportToJSONOption.TabIndex = 14
        Me.ExportToJSONOption.Text = "Export to JSON"
        Me.ExportToJSONOption.UseVisualStyleBackColor = True
        '
        'DiffsLabel
        '
        Me.DiffsLabel.AutoSize = True
        Me.DiffsLabel.Location = New System.Drawing.Point(15, 96)
        Me.DiffsLabel.Name = "DiffsLabel"
        Me.DiffsLabel.Size = New System.Drawing.Size(83, 13)
        Me.DiffsLabel.TabIndex = 13
        Me.DiffsLabel.Text = "Diffs.ini Sources"
        '
        'UpdateIntervalLabel
        '
        Me.UpdateIntervalLabel.AutoSize = True
        Me.UpdateIntervalLabel.Location = New System.Drawing.Point(172, 19)
        Me.UpdateIntervalLabel.Name = "UpdateIntervalLabel"
        Me.UpdateIntervalLabel.Size = New System.Drawing.Size(80, 13)
        Me.UpdateIntervalLabel.TabIndex = 11
        Me.UpdateIntervalLabel.Text = "Update Interval"
        '
        'DisplayFullOption
        '
        Me.DisplayFullOption.AutoSize = True
        Me.DisplayFullOption.Location = New System.Drawing.Point(15, 67)
        Me.DisplayFullOption.Name = "DisplayFullOption"
        Me.DisplayFullOption.Size = New System.Drawing.Size(63, 17)
        Me.DisplayFullOption.TabIndex = 9
        Me.DisplayFullOption.Text = "Full at 0"
        Me.DisplayFullOption.UseVisualStyleBackColor = True
        '
        'ChecksumOption
        '
        Me.ChecksumOption.AutoSize = True
        Me.ChecksumOption.Location = New System.Drawing.Point(15, 43)
        Me.ChecksumOption.Name = "ChecksumOption"
        Me.ChecksumOption.Size = New System.Drawing.Size(112, 17)
        Me.ChecksumOption.TabIndex = 8
        Me.ChecksumOption.Text = "Enable Checksum"
        Me.ChecksumOption.UseVisualStyleBackColor = True
        '
        'StartUpOption
        '
        Me.StartUpOption.AutoSize = True
        Me.StartUpOption.Location = New System.Drawing.Point(15, 19)
        Me.StartUpOption.Name = "StartUpOption"
        Me.StartUpOption.Size = New System.Drawing.Size(98, 17)
        Me.StartUpOption.TabIndex = 7
        Me.StartUpOption.Text = "Run on Startup"
        Me.StartUpOption.UseVisualStyleBackColor = True
        '
        'DiffsGroup
        '
        Me.DiffsGroup.Controls.Add(Me.DiffsRemoveButton)
        Me.DiffsGroup.Controls.Add(Me.DiffsRefreshButton)
        Me.DiffsGroup.Controls.Add(Me.DiffsRichTextBox)
        Me.DiffsGroup.Location = New System.Drawing.Point(413, 28)
        Me.DiffsGroup.Name = "DiffsGroup"
        Me.DiffsGroup.Size = New System.Drawing.Size(310, 306)
        Me.DiffsGroup.TabIndex = 2
        Me.DiffsGroup.TabStop = False
        Me.DiffsGroup.Text = "Diffs.ini Data"
        '
        'DiffsRemoveButton
        '
        Me.DiffsRemoveButton.Location = New System.Drawing.Point(228, 276)
        Me.DiffsRemoveButton.Name = "DiffsRemoveButton"
        Me.DiffsRemoveButton.Size = New System.Drawing.Size(75, 23)
        Me.DiffsRemoveButton.TabIndex = 2
        Me.DiffsRemoveButton.Text = "Remove"
        Me.DiffsRemoveButton.UseVisualStyleBackColor = True
        '
        'DiffsRefreshButton
        '
        Me.DiffsRefreshButton.Location = New System.Drawing.Point(6, 277)
        Me.DiffsRefreshButton.Name = "DiffsRefreshButton"
        Me.DiffsRefreshButton.Size = New System.Drawing.Size(75, 23)
        Me.DiffsRefreshButton.TabIndex = 1
        Me.DiffsRefreshButton.Text = "Refresh"
        Me.DiffsRefreshButton.UseVisualStyleBackColor = True
        '
        'DiffsRichTextBox
        '
        Me.DiffsRichTextBox.Location = New System.Drawing.Point(7, 20)
        Me.DiffsRichTextBox.Name = "DiffsRichTextBox"
        Me.DiffsRichTextBox.ReadOnly = True
        Me.DiffsRichTextBox.Size = New System.Drawing.Size(297, 251)
        Me.DiffsRichTextBox.TabIndex = 0
        Me.DiffsRichTextBox.Text = ""
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(735, 346)
        Me.Controls.Add(Me.DiffsGroup)
        Me.Controls.Add(Me.OptionsGroup)
        Me.Controls.Add(Me.SettingsMenuStrip)
        Me.Name = "Settings"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Settings"
        Me.SettingsMenuStrip.ResumeLayout(False)
        Me.SettingsMenuStrip.PerformLayout()
        Me.OptionsGroup.ResumeLayout(False)
        Me.OptionsGroup.PerformLayout()
        CType(Me.UpdateIntervalTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DiffsGroup.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SettingsMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsGroup As System.Windows.Forms.GroupBox
    Friend WithEvents StartUpOption As System.Windows.Forms.CheckBox
    Friend WithEvents UpdateIntervalLabel As System.Windows.Forms.Label
    Friend WithEvents DisplayFullOption As System.Windows.Forms.CheckBox
    Friend WithEvents ChecksumOption As System.Windows.Forms.CheckBox
    Friend WithEvents DiffsLabel As System.Windows.Forms.Label
    Friend WithEvents ExportToCSVOption As System.Windows.Forms.CheckBox
    Friend WithEvents ExportToJSONOption As System.Windows.Forms.CheckBox
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiffsiniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DiffsListView As System.Windows.Forms.ListView
    Friend WithEvents FileName As System.Windows.Forms.ColumnHeader
    Friend WithEvents FileLocation As System.Windows.Forms.ColumnHeader
    Friend WithEvents DiffsGroup As System.Windows.Forms.GroupBox
    Friend WithEvents DiffsRemoveButton As System.Windows.Forms.Button
    Friend WithEvents DiffsRefreshButton As System.Windows.Forms.Button
    Friend WithEvents DiffsRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents UpdateIntervalTextBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
