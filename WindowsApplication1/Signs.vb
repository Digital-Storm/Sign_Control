Imports System.IO
Imports System.Text
Imports System.IO.Ports
Imports V15NetLib
Imports System.ComponentModel
<Serializable()> Class Signs
    Private m_Signs As Hashtable
    Private sName As String = ""
    Private sINIKey As String = ""
    Private sINIHeader As String = ""
    Private sExportName As String = ""
    Private sDisplayMode As eDisplayMode = Nothing
    Private sDiffs As String = ""
    Public Sub SetName(ByVal name As String)
        Me.sName = name
    End Sub

    Function Name() As String
        Return Me.sName
    End Function

    Public Sub SetINIKey(ByVal INIKey As String)
        Me.sINIKey = INIKey
    End Sub

    Function INIKey() As String
        Return Me.sINIKey
    End Function

    Public Sub SetINIHeader(ByVal INIHeader As String)
        Me.sINIHeader = INIHeader
    End Sub

    Function INIHeader() As String
        Return Me.sINIHeader
    End Function

    Public Sub SetExportName(ByVal ExportName As String)
        Me.sExportName = ExportName
    End Sub

    Function ExportName() As String
        Return Me.sExportName
    End Function
    Public Sub SetDisplayMode(ByVal DisplayMode As eDisplayMode)
        Me.sDisplayMode = DisplayMode
    End Sub

    Function DisplayMode() As eDisplayMode
        Return Me.sDisplayMode
    End Function

    Public Sub SetDiffs(ByVal Diffs As String)
        Me.sDiffs = Diffs
    End Sub

    Function Diffs() As String
        Return Me.sDiffs
    End Function

    Public Sub New()
        m_Signs = New Hashtable(StringComparer.InvariantCultureIgnoreCase)
    End Sub

    Public ReadOnly Property Signs() As System.Collections.ICollection
        Get
            Return m_Signs.Values
        End Get
    End Property


    <Serializable()> Class IPSign
        Private SignError As V15NetError
        Private SignNet As V15NetworkClass
        Private sSignType As eSignType = Nothing
        Private sIP As String = Nothing
        Private iPort As Integer = Nothing
        Private sBrightness As eBrightness = Nothing
        Private sSignVersion As eSignVersion = Nothing
        Public Sub SetSignType(ByVal signtype As eSignType)
            Me.sSignType = signtype
        End Sub

        Function SignType() As eSignType
            Return Me.sSignType
        End Function

        Public Sub SetIP(ByVal ip As String)
            Me.sIP = ip
        End Sub

        Function IP() As String
            Return Me.sIP
        End Function

        Public Sub SetPort(ByVal port As Integer)
            Me.iPort = port
        End Sub

        Function Port() As Integer
            Return Me.iPort
        End Function

        Public Sub SetBrightness(ByVal brightness As eBrightness)
            Me.sBrightness = brightness
        End Sub

        Function Brightness() As eBrightness
            Return Me.sBrightness
        End Function

        Public Sub SetSignVersion(ByVal signversion As eSignVersion)
            Me.sSignVersion = signversion
        End Sub
        Function SignVersion() As eSignVersion
            Return Me.sSignVersion
        End Function

        me.SignNet = New V15NetworkClass

        Public Function Connect()

            Return True
        End Function

        Public Enum eSignType
            NewSign
            IP
            COM
        End Enum

        Public Enum eSignVersion
            DF2053
            Galaxy
        End Enum

        Public Enum eBrightness
            Auto
        End Enum

    End Class


    <Serializable()> Class COMSign
        Public Sub SetCOM(ByVal com As String)
            Me.sCom = com
        End Sub

        Function COM() As String
            Return Me.sCom
        End Function
        Private sCom As String = Nothing

        'Public Sub New()
        '    Me.sName = "New Sign"
        '    Me.sINIKey = Nothing
        '    Me.sINIHeader = Nothing
        '    Me.sExportName = Me.sName
        '    Me.sDisplayMode = "Normal"
        '    Me.sDiffs = Nothing
        '    Me.sSignType = "NewSign"
        '    Me.sIP = Nothing
        '    Me.sCom = Nothing
        '    Me.iPort = Nothing
        '    Me.sBrightness = Nothing
        '    Me.sSignVersion = Nothing

        'End Sub


    End Class

    Public Enum eDisplayMode
        Normal
        FULL
        OPEN
    End Enum


End Class



