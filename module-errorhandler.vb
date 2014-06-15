Imports System.IO

Module module_errorhandler

    Function appendLog(ByVal e As String) As Boolean
        Dim status As Boolean = False
        If My.Computer.FileSystem.FileExists("server\errors.log") Then
            Try
                Dim logWriter As New System.IO.StreamWriter("server\errors.log", True)
                logWriter.WriteLine(CStr(Now) + " - " + e)
                logWriter.Close()
            Catch ex As Exception

            End Try
        Else
            File.Create("server\errors.log").Dispose()
            Try
                Dim logWriter As New System.IO.StreamWriter("server\errors.log", True)
                logWriter.WriteLine(CStr(Now) + " - " + e)
                logWriter.Close()
            Catch ex As Exception

            End Try
        End If

        Return status
    End Function

End Module
