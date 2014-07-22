Imports System
Imports System.IO
Imports System.Text
Imports System.Drawing
Imports System.IO.Ports
Imports System.Windows.Forms
Imports System.Threading
Imports V15NetLib
Imports System.ComponentModel


Public Class Sign_Control
    'Run communications in its own thread for performance.
    Dim thrTimerThread As New System.Threading.Thread(AddressOf TimerThread)
    Dim ProgramRunning As Boolean = True
    Dim CommunicationsRunning As Boolean = False
    Dim randomProgress As Integer = 0
    Dim ThreadsRunning As Integer = 0
    Dim shutdownattempt As Integer = 0
    Dim skipthisitem As Boolean = False
    Dim SelectedSignName As String = ""
    Dim LoadedSignName As String = ""
    Dim SaveSignNames As Boolean = True
    Dim SignConfig As New IniFile
    'Dim iSigns As New Signs.NewSign


    Private Sub Sign_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SignNet = New V15NetworkClass
        Try
            thrTimerThread.Start()
            ThreadsRunning += 1
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "critical")
        End Try
        If Not SignConfigGroupBox.Visible = False Then
            SignConfigGroupBox.Hide()
        End If
        'Dim varBuffer As String = ChrW(12)
        'varBuffer = ((((((varBuffer & "010" & ChrW(2)) & "0101" & ChrW(27)) & "C1C" & ChrW(27)) & "M" & "FULL") & ChrW(27) & "M") & ChrW(3) & ChrW(3))
        'Dim CurrentItem As ListViewItem
        SignConfig.Load("C:\test.ini")
        Dim i As Integer = 0
        Dim skipvalue As Integer = 0
        For Each inisection As IniFile.IniSection In SignConfig.Sections
            skipthisitem = False
            If inisection.GetKey("ConnectionType").Value = 1 Or inisection.GetKey("ConnectionType").Value = 2 Then
                If inisection.Keys.Count > 0 Then
                    For Each key As IniFile.IniSection.IniKey In inisection.Keys
                        If key.Name = "ConnectionType" Then
                            skipvalue += 1
                        End If
                    Next
                    If skipvalue >= 1 Then
                        skipthisitem = False
                    Else
                        skipthisitem = True
                    End If
                Else
                    skipthisitem = True
                End If
                'SignsListView.Items.Add(inisection.Name)
                'For Each k As IniFile.IniSection.IniKey In inisection.Keys
                'If k.Name = "ConnectionType" Then
                If skipthisitem = False Then
                    Select Case inisection.GetKey("ConnectionType").Value
                        Case 1
                            SignsListView.Items.Add(inisection.Name).Group = SignsListView.Groups(1)
                            SignsListView.FindItemWithText(inisection.Name).SubItems.Add("")
                            SignsListView.FindItemWithText(inisection.Name).SubItems.Add("")
                            SignsListView.FindItemWithText(inisection.Name).SubItems.Add("")
                        Case 2
                            SignsListView.Items.Add(inisection.Name).Group = SignsListView.Groups(2)
                            SignsListView.FindItemWithText(inisection.Name).SubItems.Add("")
                            SignsListView.FindItemWithText(inisection.Name).SubItems.Add("")
                            SignsListView.FindItemWithText(inisection.Name).SubItems.Add("")
                    End Select
                End If
            End If
            'Next
            i = i + 1
            skipvalue = 0
        Next
        SignsListView.Update()
        For Each item As String In SerialPort.GetPortNames
            Me.COMPortDropBox.Items.Add(item)
        Next
        'Call UpdateListView()
        Dim SignComms As Boolean = My.Settings.RunOnStartup
        If My.Settings.RunOnStartup = True Then
            Try
                SignComms = True
            Catch ex As Exception
                MsgBox("Error " & ex.ToString, MsgBoxStyle.Critical, "Critical")
                SignComms = False
            End Try
        End If
    End Sub

    'On program shutdown.
    Private Sub Sign_Control_FormClosing(sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            CommunicationsRunning = False
            'Dim intervalsetting As Integer = My.Settings.UpdateInterval
            'My.Settings.UpdateInterval = 1
            ProgramRunning = False
            'temporary till i can force interupt of sleep on thread.
            Threading.Thread.Sleep(My.Settings.UpdateInterval)
            If ThreadsRunning >= 1 And shutdownattempt < 1 Then
                shutdownattempt += 1
                ' My.Settings.UpdateInterval = intervalsetting
                If Not shutdownattempt > 1 Then
                    e.Cancel = True
                End If
            End If
            SignConfig.Save("C:\test.ini")
    End Sub

    'Opening Settings Panel
    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        Settings.Show()
    End Sub

    'Closing the Program with Exit Button
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Settings.Close()
        Me.Close()
    End Sub

    'Clicking new sign in menu
    Private Sub SignToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignToolStripMenuItem.Click
        SignConfigGroupBox.Show()
        COMGroup.Hide()
        IPAddressGroup.Hide()
        If SignsListView.Groups(0).Items.Count < 1 Then
            Dim NewItem As ListViewItem = SignsListView.Items.Add("New Sign")
            NewItem.Group = SignsListView.Groups(0)
            NewItem.SubItems.Add("")
            NewItem.SubItems.Add("")
            NewItem.SubItems.Add("")
            NewItem.Focused = True
            Call LoadSignSettings(SignsListView.FocusedItem, True)
        Else
            For Each Item As ListViewItem In SignsListView.Groups(0).Items
                Item.Focused = True
                Call LoadSignSettings(SignsListView.FocusedItem, True)
            Next
        End If
    End Sub

    'Update UI when new object selected in Sign list
    Private Sub SignsListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SignsListView.SelectedIndexChanged
        If SignsListView.SelectedIndices.Count >= 1 Then
            SignConfigGroupBox.Show()
            LoadedSignName = SignsListView.FocusedItem.Name
            Call LoadSignSettings(SignsListView.FocusedItem)
        Else
            SignConfigGroupBox.Hide()
        End If
    End Sub

    'Loads the sign settings into the UI when an item in the Sign Box is selected.
    Private Sub LoadSignSettings(FocusedSign As ListViewItem, Optional ByRef NewSign As Boolean = False)
        SignNameTextBox.Text = FocusedSign.Text
        SelectedSignName = FocusedSign.Text
        If Not NewSign = True And FocusedSign.Group.Tag <> 0 Then
            CountKeyTextBox.Text = SignConfig.GetSection(FocusedSign.Text).GetKey("CountKey").Value
            CountHeaderTextBox.Text = SignConfig.GetSection(FocusedSign.Text).GetKey("CountHeader").Value
            ExportNameTextBox.Text = SignConfig.GetSection(FocusedSign.Text).GetKey("ExportName").Value
            DisplayModeDropBox.Text = SignConfig.GetSection(FocusedSign.Text).GetKey("DisplayMode").Value
            DiffsDropBox.Text = SignConfig.GetSection(FocusedSign.Text).GetKey("Diffs").Value
            Select Case SignConfig.GetSection(FocusedSign.Text).GetKey("ConnectionType").Value
                Case 1
                    IPSignRadio.Checked = True
                    COMSignRadio.Checked = False
                    IPAddressGroup.Show()
                    COMGroup.Hide()
                    SignTypeComboBox.Text = SignConfig.GetSection(FocusedSign.Text).GetKey("SignType").Value
                    IPAddressTextBox.Text = SignConfig.GetSection(FocusedSign.Text).GetKey("IPAddress").Value
                    PortTextBox.Text = SignConfig.GetSection(FocusedSign.Text).GetKey("Port").Value
                    BrightnessDropBox.Text = SignConfig.GetSection(FocusedSign.Text).GetKey("Brightness").Value
                    SignTypeComboBox.Text = SignConfig.GetSection(FocusedSign.Text).GetKey("SignType").Value
                Case 2
                    IPSignRadio.Checked = False
                    COMSignRadio.Checked = True
                    IPAddressGroup.Hide()
                    COMGroup.Show()
                    COMPortDropBox.Text = SignConfig.GetSection(FocusedSign.Text).GetKey("COMPort").Value
            End Select
        ElseIf NewSign = True Or FocusedSign.Group.Tag = 0 Then
            IPSignRadio.Checked = False
            COMSignRadio.Checked = False
            IPAddressGroup.Hide()
            COMGroup.Hide()
            CountKeyTextBox.Clear()
            CountHeaderTextBox.Clear()
            ExportNameTextBox.Clear()
            DisplayModeDropBox.Text = ""
            DiffsDropBox.Text = ""
            SignTypeComboBox.Text = ""
            IPAddressTextBox.Clear()
            PortTextBox.Clear()
            BrightnessDropBox.Text = ""
            SignTypeComboBox.Text = ""
            COMPortDropBox.Text = ""
        End If
        LoadedSignName = FocusedSign.Text
    End Sub

    'Clears the SignList setting and refills it with the current Sign list items and settings.
    Private Sub SignSaveSettings(FocusedSign As ListViewItem, Optional ByVal NewSign As Boolean = False)
        Dim SignSection As IniFile.IniSection
        SignSection = SignConfig.GetSection(FocusedSign.Text)
        If SignSection IsNot Nothing And ValidateSign(FocusedSign) = True Then
            Select Case FocusedSign.Group.Tag
                Case 0
                    FocusedSign.Text = SignNameTextBox.Text
                    SignConfig.AddSection(FocusedSign.Text)
                    SignSection.RemoveAllKeys()
                    SignSection.AddKey("CountKey").SetValue(CountKeyTextBox.Text)
                    SignSection.AddKey("CountHeader").SetValue(CountHeaderTextBox.Text)
                    SignSection.AddKey("ExportName").SetValue(ExportNameTextBox.Text)
                    SignSection.AddKey("DisplayMode").SetValue(DisplayModeDropBox.Text)
                    SignSection.AddKey("Diffs").SetValue(DiffsDropBox.Text)
                    If IPSignRadio.Checked = True And COMSignRadio.Checked = False Then
                        SignSection.AddKey("ConnectionType").SetValue("1")
                        SignSection.AddKey("SignType").SetValue(SignTypeComboBox.Text)
                        SignSection.AddKey("IPAddress").SetValue(IPAddressTextBox.Text)
                        SignSection.AddKey("Port").SetValue(PortTextBox.Text)
                        SignSection.AddKey("Brightness").SetValue(BrightnessDropBox.Text)
                        SignSection.AddKey("SignType").SetValue(SignTypeComboBox.Text)
                    ElseIf IPSignRadio.Checked = False And COMSignRadio.Checked = True Then
                        SignSection.AddKey("ConnectionType").SetValue("2")
                        SignSection.AddKey("ComPort").SetValue(COMPortDropBox.Text)
                    End If
                Case Is <> 0
                    SignConfig.RenameSection(LoadedSignName, SignNameTextBox.Text)
                    FocusedSign.Text = SignNameTextBox.Text
                    If SignSection.Keys.Count > 0 Then
                        SignSection.RemoveAllKeys()
                    End If
                    SignSection.AddKey("CountKey").SetValue(CountKeyTextBox.Text)
                    SignSection.AddKey("CountHeader").SetValue(CountHeaderTextBox.Text)
                    SignSection.AddKey("ExportName").SetValue(ExportNameTextBox.Text)
                    SignSection.AddKey("DisplayMode").SetValue(DisplayModeDropBox.Text)
                    SignSection.AddKey("Diffs").SetValue(DiffsDropBox.Text)
                    If IPSignRadio.Checked = True And COMSignRadio.Checked = False Then
                        SignSection.AddKey("ConnectionType").SetValue("1")
                        SignSection.AddKey("SignType").SetValue(SignTypeComboBox.Text)
                        SignSection.AddKey("IPAddress").SetValue(IPAddressTextBox.Text)
                        SignSection.AddKey("Port").SetValue(PortTextBox.Text)
                        SignSection.AddKey("Brightness").SetValue(BrightnessDropBox.Text)
                        SignSection.AddKey("SignType").SetValue(SignTypeComboBox.Text)
                    ElseIf IPSignRadio.Checked = False And COMSignRadio.Checked = True Then
                        SignSection.AddKey("ConnectionType").SetValue("2")
                        SignSection.AddKey("ComPort").SetValue(COMPortDropBox.Text)
                    End If
            End Select
        ElseIf SignSection Is Nothing And ValidateSign(FocusedSign) = True Then
            If SignNameTextBox.Text <> "New Sign" Then
                FocusedSign.Text = SignNameTextBox.Text
                SignConfig.AddSection(FocusedSign.Text)
                SignSection = SignConfig.GetSection(FocusedSign.Text)
                SignSection.AddKey("CountKey").SetValue(CountKeyTextBox.Text)
                SignSection.AddKey("CountHeader").SetValue(CountHeaderTextBox.Text)
                SignSection.AddKey("ExportName").SetValue(ExportNameTextBox.Text)
                SignSection.AddKey("DisplayMode").SetValue(DisplayModeDropBox.Text)
                SignSection.AddKey("Diffs").SetValue(DiffsDropBox.Text)
                If IPSignRadio.Checked = True And COMSignRadio.Checked = False Then
                    SignSection.AddKey("ConnectionType").SetValue("1")
                    SignSection.AddKey("SignType").SetValue(SignTypeComboBox.Text)
                    SignSection.AddKey("IPAddress").SetValue(IPAddressTextBox.Text)
                    SignSection.AddKey("Port").SetValue(PortTextBox.Text)
                    SignSection.AddKey("Brightness").SetValue(BrightnessDropBox.Text)
                    SignSection.AddKey("SignType").SetValue(SignTypeComboBox.Text)
                ElseIf IPSignRadio.Checked = False And COMSignRadio.Checked = True Then
                    SignSection.AddKey("ConnectionType").SetValue("2")
                    SignSection.AddKey("ComPort").SetValue(COMPortDropBox.Text)
                End If
            Else
                MsgBox("You cannot use 'New Sign' as the name of your sign", MsgBoxStyle.Information, "Change the Sign Name")
            End If
        Else
            MsgBox("Select a communications type before saving", MsgBoxStyle.Information, "Sign Not Saved!")
        End If
    End Sub

    Function ValidateSign(FocusedSign As ListViewItem, Optional skipnamecheck As Boolean = False)
        If FocusedSign.Text <> SignNameTextBox.Text Then
            For Each section As IniFile.IniSection In SignConfig.Sections
                If section.Name = SignNameTextBox.Text Then
                    MsgBox("'" & SignNameTextBox.Text & "' is already in use. Please select a different name.")
                    Return False
                End If
            Next
        End If
        If IPSignRadio.Checked = False And COMSignRadio.Checked = False Then
            Return False
        ElseIf IPSignRadio.Checked = True Then
            If SignNameTextBox.Text <> "" And CountHeaderTextBox.Text <> "" And CountKeyTextBox.Text <> "" And ExportNameTextBox.Text <> "" And DisplayModeDropBox.Text <> "" And DiffsDropBox.Text <> "" And SignTypeComboBox.Text <> "" And IPAddressTextBox.Text <> "" And PortTextBox.Text <> "" And BrightnessDropBox.Text <> "" And SignTypeComboBox.Text <> "" Then
                Return True
            Else
                Return False
            End If
        ElseIf COMSignRadio.Checked = True Then
            If SignNameTextBox.Text <> "" And CountHeaderTextBox.Text <> "" And CountKeyTextBox.Text <> "" And ExportNameTextBox.Text <> "" And DisplayModeDropBox.Text <> "" And DiffsDropBox.Text <> "" And COMPortDropBox.Text <> "" Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
        Return False
    End Function

    'Saves the sign settings when the button is pressed.
    Private Sub SaveSignButton_Click(sender As Object, e As EventArgs) Handles SaveSignButton.Click
        Call Me.SignSaveSettings(SignsListView.FocusedItem)
    End Sub

    'Removes the sign from the list, and deletes its settings.
    Private Sub DeleteSignButton_Click(sender As Object, e As EventArgs) Handles DeleteSignButton.Click
        If MsgBox("Remove [" & SignsListView.FocusedItem.Text & "]?", MsgBoxStyle.YesNo, "Remove Item From List") = MsgBoxResult.Yes Then


            SignConfig.RemoveSection(SignsListView.FocusedItem.Text)
            SignsListView.FocusedItem.Remove()
            SignConfigGroupBox.Hide()
            'Call Me.SignSaveSettings()
            'SignConfig.Save("C:\test.ini")
        End If
    End Sub

    Private Sub IPSign_Send(IPAdd As String, port As Short, count As String, signtype As String, Optional dimming As String = Nothing)
        Dim varbuffer As String = Nothing
        Dim DimSet As DimmingType = DimmingType.DIMMING_AUTO
        Dim DimLevel As Short = 0
        If count.Length < 4 Then
            Select Case count.Length
                Case 0
                    count = "    "
                Case 1
                    count = "   " & count
                Case 2
                    count = "  " & count
                Case 3
                    count = " " & count
            End Select
        End If
        Select Case dimming
            Case "Auto"
                DimSet = DimmingType.DIMMING_AUTO
                DimLevel = 0
            Case "Maximum"
                DimSet = DimmingType.DIMMING_MANUAL
                DimLevel = &H3F
            Case "Minimum"
                DimSet = DimmingType.DIMMING_MANUAL
                DimLevel = 1
            Case Nothing
        End Select
        Me.SignError = Me.SignNet.ConfigureRemote(IPAdd, port, &H3E8)
        Me.SignError = Me.SignNet.Connect
        Select Case signtype
            Case "DF-2053"
                Me.SignError = Me.SignNet.MdcSetDimming(1, DimSet, 0)
                varbuffer = ((((((ChrW(12) & "010" & ChrW(2)) & "0101" & ChrW(27)) & DataTypes.SIGN_GREEN & ChrW(27)) & "M" & count) & ChrW(27) & "M") & ChrW(3) & ChrW(3))
                Me.SignError = Me.SignNet.MdcSendMessage(1, "SIGNMSG", DateTime.Now, varbuffer)
                Me.SignError = Me.SignNet.MdcRunMessage(1, "SIGNMSG", 0, True)
            Case "Galaxy"
                Me.SignError = Me.SignNet.M2SendRTD(1, 1, 4, True, count)
        End Select
        Me.SignError = Me.SignNet.Disconnect
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    Private Sub COMSign_Send(port As String, count As String)
        If count.Length < 4 Then
            Select Case count.Length
                Case 0
                    count = "0000"
                Case 1
                    count = "000" & count
                Case 2
                    count = "00" & count
                Case 3
                    count = "0" & count
            End Select
        End If

        Dim bytearray1() As Byte = {22, 22, 2, 3, 0, 0}
        Dim bytearray2() As Byte = UnicodeStringToBytes(count)
        Dim bytearray3() As Byte = {2, 3}

        Dim ByteArray(bytearray1.Length + bytearray2.Length + bytearray3.Length - 1) As Byte
        Buffer.BlockCopy(bytearray1, 0, ByteArray, 0, bytearray1.Length)
        Buffer.BlockCopy(bytearray2, 0, ByteArray, bytearray1.Length, bytearray2.Length)

        Dim ByteArrayNew(ByteArray.Length + bytearray3.Length - 1) As Byte
        Buffer.BlockCopy(ByteArray, 0, ByteArrayNew, 0, ByteArray.Length)
        Buffer.BlockCopy(bytearray3, 0, ByteArrayNew, ByteArray.Length, bytearray3.Length)

        'Data Organization  
        '(16 16 02 03 00) Default with signs
        '(00) = No Checksum. (01) = Checksum Enabled
        '(XX XX XX XX) Sign Display Value, Leading 30's are auto removed
        '(00) Normal Operation (02) Sign OPEN (03) Sign FULL
        Dim SignCom As IO.Ports.SerialPort
        SignCom = New IO.Ports.SerialPort
        SignCom = My.Computer.Ports.OpenSerialPort(port)
        SignCom.BaudRate = 9600
        SignCom.DataBits = 8
        SignCom.Parity = IO.Ports.Parity.None
        SignCom.Write(ByteArrayNew, 0, ByteArrayNew.Length)
        SignCom.Close()

        'Using SignCOM As IO.Ports.SerialPort =
        '    My.Computer.Ports.OpenSerialPort(port)
        '    SignCOM.BaudRate = 9600
        '    SignCOM.DataBits = 8
        '    SignCOM.Parity = IO.Ports.Parity.None
        '    SignCOM.Write(ByteArrayNew, 0, ByteArrayNew.Length)
        '    SignCOM.Close()
        'End Using
    End Sub
    Private Function UnicodeBytesToString(
    ByVal bytes() As Byte) As String

        Return System.Text.Encoding.Unicode.GetString(bytes)
    End Function


    'Convert string of numbers to bytes.
    Private Function UnicodeStringToBytes(ByVal str As String) As Byte()
        Return System.Text.Encoding.ASCII.GetBytes(str)
    End Function

    Public Function UpdateCounts(ByVal Sign As String) As String
        Dim strCount As String = ""
        Dim Count As String = "    "
        Dim DIFFSFile As New IniFile
        SignConfig.Load("C:\test.ini")
        DIFFSFile.Load(SignConfig.GetKeyValue(Sign, "Diffs"))
        strCount = DIFFSFile.GetKeyValue(SignConfig.GetKeyValue(Sign, "CountHeader"), SignConfig.GetKeyValue(Sign, "CountKey"))

        If (strCount = "<NULL>") Then
            Return "OPEN"
        End If
        If (Convert.ToInt16(strCount) < 1) Then
            Return "FULL"
        End If
        Count = Strings.Trim(strCount)
        'Select Case Strings.Len(strCount)
        '    Case 0
        '        Return "    "
        '    Case 1
        '        Return ("   " & Strings.Trim(Convert.ToString(strCount)))
        '    Case 2
        '        Return ("  " & Strings.Trim(Convert.ToString(strCount)))
        '    Case 3
        '        Return (" " & Strings.Trim(Convert.ToString(strCount)))
        '    Case 4
        '        Return Strings.Trim(Convert.ToString(strCount))
        'End Select

        Return Strings.Right(Strings.Trim(Convert.ToString(strCount)), 4)

    End Function

    Private Sub TimerThread()
        Dim Diffs As New IniFile
        Dim SignCount As String
        Do
            'Me.pbRandom. 'CInt(Math.Ceiling(Rnd() * 100))

            'Testing a progress bar update while thread is running.




            Do While CommunicationsRunning = True
                SaveSignNames = False
                'SignConfig.Load("C:\test.ini")
                Dim signarray(SignConfig.Sections.Count) As String
                'For Each section As IniFile.IniSection In SignConfig.Sections
                Dim i As Integer = 1
                For Each section As IniFile.IniSection In SignConfig.Sections
                    signarray(i) = section.Name
                    i += 1
                Next
                Dim signvalue As Integer = 1
                For sign = 1 To i - 1
                    signvalue = sign
                    Try
                        SignCount = UpdateCounts(signarray(signvalue))
                        Me.Invoke(New MethodInvoker(Sub() Communications(signarray(signvalue), SignCount)))
                        Diffs.Load("C:\test.ini")
                        For Each key As IniFile.IniSection.IniKey In Diffs.GetSection(signarray(signvalue)).Keys
                            If key.Name = "ComPort" Then
                                COMSign_Send(Diffs.GetSection(signarray(signvalue)).GetKey("ComPort").GetValue, SignCount)
                            ElseIf key.Name = "IPAddress" Then
                                If Diffs.GetSection(signarray(signvalue)).GetKey("SignType").GetValue = "DF-2053" Then
                                    IPSign_Send(Diffs.GetSection(signarray(signvalue)).GetKey("IPAddress").GetValue, Diffs.GetSection(signarray(signvalue)).GetKey("Port").GetValue, SignCount, Diffs.GetSection(signarray(signvalue)).GetKey("SignType").GetValue, Diffs.GetSection(signarray(signvalue)).GetKey("Brightness").GetValue)
                                ElseIf Diffs.GetSection(signarray(signvalue)).GetKey("SignType").GetValue = "Galaxy" Then
                                    IPSign_Send(Diffs.GetSection(signarray(signvalue)).GetKey("IPAddress").GetValue, Diffs.GetSection(signarray(signvalue)).GetKey("Port").GetValue, SignCount, Diffs.GetSection(signarray(signvalue)).GetKey("SignType").GetValue)
                                End If
                            End If
                        Next
                    Catch ex As Exception
                    End Try
                Next sign

                If Me.pbRandom.InvokeRequired Then
                    pbRandom.Invoke(New MethodInvoker(Sub() UpdateProgressBar()))
                Else
                    pbRandom.Value = CInt(Math.Ceiling(Rnd() * 100))
                End If
                SaveSignNames = True
                System.Threading.Thread.Sleep(My.Settings.UpdateInterval)
            Loop
            SaveSignNames = True
            'Threading.Thread.Sleep(My.Settings.UpdateInterval)
        Loop While ProgramRunning = True
        Me.Invoke(New EventHandler(AddressOf Me.CloseMe))
    End Sub

    'Updates ListViewItem with Sign Count (Invoked by thread)
    Public Sub Communications(sign As String, SignCount As String)
        SignsListView.FindItemWithText(sign).SubItems(1).Text = SignCount
    End Sub

    'Gives me visual indication that communications thread is active
    Private Sub UpdateProgressBar()
        pbRandom.Value = CInt(Math.Ceiling(Rnd() * 100))
    End Sub

    'Update UI when COM radio button selected
    Private Sub COMSignRadio_CheckedChanged(sender As Object, e As EventArgs) Handles COMSignRadio.CheckedChanged
        If COMSignRadio.Checked.Equals(True) Then
            IPSignRadio.Checked.Equals(False)
            IPAddressGroup.Hide()
            COMGroup.Show()
            SignsListView.FocusedItem.Group = SignsListView.Groups(2)
        End If
    End Sub

    'Update UI when IP radio button selected
    Private Sub IPSignRadio_CheckedChanged(sender As Object, e As EventArgs) Handles IPSignRadio.CheckedChanged
        If IPSignRadio.Checked.Equals(True) Then
            COMSignRadio.Checked.Equals(False)
            COMGroup.Hide()
            IPAddressGroup.Show()
            SignsListView.FocusedItem.Group = SignsListView.Groups(1)
        End If
    End Sub

    Private Sub CloseMe(ByVal o As Object, ByVal e As EventArgs)
        Me.ThreadsRunning -= 1
        Me.Close()
    End Sub

    Private Sub StartCommunicationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartCommunicationsToolStripMenuItem.Click
        If CommunicationsRunning = False Then
            CommunicationsRunning = True
            StartCommunicationsToolStripMenuItem.Text = "Stop Communications"
        ElseIf CommunicationsRunning = True Then
            CommunicationsRunning = False
            StartCommunicationsToolStripMenuItem.Text = "Start Communications"
        End If
    End Sub

    Private Sub SignNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles SignNameTextBox.TextChanged
        Dim setred = False
        If SignsListView.FocusedItem.Text <> SignNameTextBox.Text Then
            For Each section As IniFile.IniSection In SignConfig.Sections
                If section.Name = SignNameTextBox.Text Then
                    setred = True
                    'MsgBox("'" & SignNameTextBox.Text & "' is already in use. Please select a different name.")
                End If
            Next
            If setred = True Then
                SignNameTextBox.ForeColor = Color.Red
            Else
                SignNameTextBox.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private INIFile As IniFile
    Private SignError As V15NetError
    Private SignNet As V15NetworkClass

End Class