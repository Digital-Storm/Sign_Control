Imports System.IO

Public Class Settings
    'Variable to hold Save Yes No value
    Dim ConfigSave As Boolean = False
    Dim SettingsConfig As New IniFile

    'On Settings load
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DiffsGroup.Hide()

        UpdateIntervalTextBox.Value = My.Settings.UpdateInterval
        DisplayFullOption.Checked = My.Settings.FullAt0
        ChecksumOption.Checked = My.Settings.EnableChecksum
        StartUpOption.Checked = My.Settings.RunOnStartup
        ExportToJSONOption.Checked = My.Settings.LogToJSON
        ExportToCSVOption.Checked = My.Settings.LogToCSV
        Dim CurrentItem As ListViewItem = New ListViewItem()
        For Each Item As String In My.Settings.DiffsFilePath
            If Not Item.StartsWith("SubItem:") Then
                CurrentItem = New ListViewItem(Item)
                DiffsListView.Items.Add(CurrentItem)
            Else
                CurrentItem.SubItems.Add(Item.Replace("SubItem:", ""))
            End If
        Next
        'sets save setting to false.
        ConfigSave = False
    End Sub

    Private Sub Settings_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        If ConfigSave = True Then
            If MsgBox("There are unsaved changes." & vbNewLine & "Would you like to save?", MsgBoxStyle.YesNo, "Unsaved Changes!") = MsgBoxResult.Yes Then
                ConfigSave = False
                Call SaveSettings()
            Else
                ConfigSave = False
            End If
        End If
    End Sub

    'Save and Exit Button
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Call SaveSettings()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If ConfigSave = True Then
            If MsgBox("There are unsaved changes." & vbNewLine & "Would you like to save?", MsgBoxStyle.YesNo, "Unsaved Changes!") = MsgBoxResult.Yes Then
                ConfigSave = False
                Call SaveSettings()
            Else
                ConfigSave = False
            End If
        End If
        Me.Close()
    End Sub

    'Select Item from Diffs List
    Private Sub DiffsListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DiffsListView.SelectedIndexChanged
        If DiffsListView.SelectedItems.Count >= 1 Then
            DiffsRichTextBox.Clear()
            DiffsGroup.Show()
            Call LoadFile(DiffsListView.FocusedItem.SubItems(1).Text & DiffsListView.FocusedItem.Text)
        Else
            DiffsGroup.Hide()
        End If


    End Sub

    'Refresh Diffs List
    Private Sub DiffsRefreshButton_Click(sender As Object, e As EventArgs) Handles DiffsRefreshButton.Click
        Call LoadFile(DiffsListView.FocusedItem.SubItems(1).Text & DiffsListView.FocusedItem.Text)
    End Sub

    'Delete item from Diffs List
    Private Sub DiffsRemoveButton_Click(sender As Object, e As EventArgs) Handles DiffsRemoveButton.Click
        If MsgBox("Remove [" & DiffsListView.FocusedItem.Text & "]?", MsgBoxStyle.YesNo, "Remove Item From List") = MsgBoxResult.Yes Then
            DiffsListView.FocusedItem.Remove()
            DiffsGroup.Hide()
            ConfigSave = True
        End If
    End Sub

    'Loading a file
    Private Sub LoadFile(SelectedDiff)
        Try
            Using sr As New StreamReader(SelectedDiff.ToString)
                Dim TextData As String
                TextData = sr.ReadToEnd()
                DiffsRichTextBox.Text = TextData
            End Using
        Catch ex As Exception
            DiffsRichTextBox.Text = "Could not read the file." & vbNewLine
            DiffsRichTextBox.AppendText(ex.Message)
        End Try
    End Sub

    'Adding a new Diffs File through Menu
    Private Sub DiffsiniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiffsiniToolStripMenuItem.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFile As String
        Dim strFilePath As String
        Dim strFileName As String

        fd.Title = "Select Diffs.ini"
        fd.InitialDirectory = "C:\"
        fd.Filter = "txt files (*.txt)|*.txt|ini files (*.ini)|*.ini"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            strFile = fd.FileName
            strFileName = fd.SafeFileName
            strFilePath = fd.FileName.Replace(strFileName, "")
            DiffsListView.Items.Add(strFileName).SubItems.Add(strFilePath)
        End If
        ConfigSave = True
    End Sub


    Private Sub SaveSettings()
        'For i = 


        My.Settings.DiffsFilePath.Clear()
        For Each Item As ListViewItem In DiffsListView.Items
            My.Settings.DiffsFilePath.Add(Item.Text)
            If Item.SubItems.Count > 0 Then
                For count As Integer = 1 To Item.SubItems.Count - 1
                    My.Settings.DiffsFilePath.Add("SubItem:" & Item.SubItems(count).Text)
                Next
            End If
        Next
        My.Settings.UpdateInterval = UpdateIntervalTextBox.Value
        ConfigSave = False
        My.Settings.Save()
    End Sub

    Private Sub StartUpOption_CheckStateChanged(sender As Object, e As EventArgs) Handles StartUpOption.CheckStateChanged
        My.Settings.RunOnStartup = StartUpOption.CheckState
        ConfigSave = True
    End Sub
    Private Sub ChecksumOption_CheckStateChanged(sender As Object, e As EventArgs) Handles ChecksumOption.CheckStateChanged
        My.Settings.EnableChecksum = ChecksumOption.CheckState
        ConfigSave = True
    End Sub
    Private Sub DisplayFullOption_CheckStateChanged(sender As Object, e As EventArgs) Handles DisplayFullOption.CheckStateChanged
        My.Settings.FullAt0 = DisplayFullOption.CheckState
        ConfigSave = True
    End Sub
    Private Sub ExportToCSVOption_CheckStateChanged(sender As Object, e As EventArgs) Handles ExportToCSVOption.CheckStateChanged
        My.Settings.LogToCSV = ExportToCSVOption.CheckState
        ConfigSave = True
    End Sub
    Private Sub ExportToJSONOption_CheckStateChanged(sender As Object, e As EventArgs) Handles ExportToJSONOption.CheckStateChanged
        My.Settings.LogToJSON = ExportToJSONOption.CheckState
        ConfigSave = True
    End Sub
End Class