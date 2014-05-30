'Imports V15NetLib
'Friend NotInheritable Class DataTypes
'    ' Methods
'    Public Shared Function GetV15Error(ByVal nError As V15NetError) As String
'        Select Case nError
'            Case V15NetError.V15NET_OK
'                Return "V15NET_OK"
'            Case V15NetError.ERR_COMMAND_BUSY
'                Return "ERR_COMMAND_BUSY"
'            Case V15NetError.ERR_COMMAND_ALREADY_CONNECTED
'                Return "ERR_COMMAND_ALREADY_CONNECTED"
'            Case V15NetError.ERR_COMMAND_NOT_CONFIGURED
'                Return "ERR_COMMAND_NOT_CONFIGURED"
'            Case V15NetError.ERR_COMMAND_NO_CONNECTION
'                Return "ERR_COMMAND_NO_CONNECTION"
'            Case V15NetError.ERR_COMMAND_NO_BROADCAST
'                Return "ERR_COMMAND_NO_BROADCAST"
'            Case V15NetError.ERR_SIGN_NO_RESPONSE
'                Return "ERR_SIGN_NO_RESPONSE"
'            Case V15NetError.ERR_SIGN_INVALID_RESPONSE
'                Return "ERR_SIGN_INVALID_RESPONSE"
'            Case V15NetError.ERR_SIGN_UNSUPPORTED_COMMAND
'                Return "ERR_SIGN_UNSUPPORTED_COMMAND"
'            Case V15NetError.ERR_SIGN_BAD_COMMAND
'                Return "ERR_SIGN_BAD_COMMAND"
'            Case V15NetError.ERR_SIGN_RESPONSE_ERROR
'                Return "ERR_SIGN_RESPONSE_ERROR"
'            Case V15NetError.ERR_SIGN_ABORT
'                Return "ERR_SIGN_ABORT"
'            Case V15NetError.ERR_SIGN_FILE_SYSTEM
'                Return "ERR_SIGN_FILE_SYSTEM"
'            Case V15NetError.ERR_SIGN_FILE_NOT_FOUND
'                Return "ERR_SIGN_FILE_NOT_FOUND"
'            Case V15NetError.ERR_SIGN_MEMORY
'                Return "ERR_SIGN_MEMORY"
'            Case V15NetError.ERR_SIGN_FILE_MEMORY
'                Return "ERR_SIGN_FILE_MEMORY"
'            Case V15NetError.ERR_SIGN_FLASH_WRITE
'                Return "ERR_SIGN_FLASH_WRITE"
'            Case V15NetError.ERR_SIGN_FILE_TOO_LARGE
'                Return "ERR_SIGN_FILE_TOO_LARGE"
'            Case V15NetError.ERR_SIGN_NOT_READY
'                Return "ERR_SIGN_NOT_READY"
'            Case V15NetError.ERR_SIGN_OUT_OF_RANGE
'                Return "ERR_SIGN_OUT_OF_RANGE"
'            Case V15NetError.ERR_SIGN_INVALID_MESSAGE
'                Return "ERR_SIGN_INVALID_MESSAGE"
'            Case V15NetError.ERR_SIGN_INVALID_MESSAGE_NAME
'                Return "ERR_SIGN_INVALID_MESSAGE_NAME"
'            Case V15NetError.ERR_SIGN_MAX_RUNNING_MESSAGES
'                Return "ERR_SIGN_MAX_RUNNING_MESSAGES"
'            Case V15NetError.ERR_SIGN_MESSAGE_NOT_RUNNING
'                Return "ERR_SIGN_MESSAGE_NOT_RUNNING"
'            Case V15NetError.ERR_SIGN_SCHEDULER_FULL
'                Return "ERR_SIGN_SCHEDULER_FULL"
'            Case V15NetError.ERR_SIGN_INVALID_PASSWORD
'                Return "ERR_SIGN_INVALID_PASSWORD"
'            Case V15NetError.ERR_SIGN_UNKNOWN
'                Return "ERR_SIGN_UNKNOWN"
'            Case V15NetError.M2_ERR_SIGN_UNKNOWN
'                Return "M2_ERR_SIGN_NOT_FOUND"
'            Case V15NetError.M2_ERR_SIGN_MEMORY
'                Return "M2_ERR_SIGN_MEMORY"
'            Case V15NetError.M2_ERR_SIGN_OUT_OF_RANGE
'                Return "M2_ERR_SIGN_OUT_OF_RANGE"
'            Case V15NetError.M2_ERR_SIGN_NOT_READY
'                Return "M2_ERR_SIGN_NOT_READY"
'            Case V15NetError.M2_ERR_SIGN_DEFRAG_MODE
'                Return "M2_ERR_SIGN_DEFRAG_MODE"
'            Case V15NetError.M2_ERR_SIGN_OPTION_UNSUPPORTED
'                Return "M2_ERR_SIGN_OPTION_UNSUPPORTED"
'            Case V15NetError.ERR_NETWORK_CONNECT_FAILED
'                Return "ERR_NETWORK_CONNECT_FAILED"
'            Case V15NetError.ERR_NETWORK_DISCONNECT_INVALID
'                Return "ERR_NETWORK_DISCONNECT_INVALID"
'            Case V15NetError.ERR_NETWORK_NO_WRITE
'                Return "ERR_NETWORK_NO_WRITE"
'            Case V15NetError.ERR_NETWORK_NO_READ
'                Return "ERR_NETWORK_NO_READ"
'            Case V15NetError.ERR_SOCKET_NO_CREATE
'                Return "ERR_SOCKET_NO_CREATE"
'            Case V15NetError.ERR_SOCKET_NO_INIT
'                Return "ERR_SOCKET_NO_INIT"
'            Case V15NetError.ERR_GRAPHIC_UNSUPPORTED_FORMAT
'                Return "ERR_GRAPHIC_UNSUPPORTED_FORMAT"
'            Case V15NetError.ERR_SIGN_NOT_AUTHENTICATED
'                Return "ERR_SIGN_NOT_AUTHENTICATED"
'        End Select
'        Return "UNKNOWN ERROR"
'    End Function


'    ' Fields
'    Public Shared SIGN_GREEN As String = "C1C"
'    Public Shared SIGN_RED As String = "CE0"
'End Class
