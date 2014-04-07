Module displaymessage

    ' this module is for error logging
    ' the error logging feature will be available soon
    Public Sub infobox(ByVal message As String, ByVal title As String)
        MsgBox(message, vbInformation, title)
    End Sub

    Public Sub errorbox(ByVal message As String, ByVal title As String)
        MsgBox(message, vbCritical, title)
    End Sub

    Public Sub warningbox(ByVal message As String, ByVal title As String)
        MsgBox(message, vbExclamation, title)
    End Sub

End Module
