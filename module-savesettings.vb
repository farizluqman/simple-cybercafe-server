Imports System.Runtime.InteropServices

Module module_savesettings
    <DllImport("kernel32.dll", SetLastError:=True)> _
    Public Function WritePrivateProfileString(ByVal lpAppName As String, _
                        ByVal lpKeyName As String, _
                        ByVal lpString As String, _
                        ByVal lpFileName As String) As Boolean
    End Function

    Public Function saveClientConfig(ByVal section As String, ByVal key As String, ByVal keyword As String, ByVal pc As String)
        Try
            WritePrivateProfileString(section, key, keyword, "clients\" + pc + ".cfg")
        Catch ex As Exception
            errorbox("Cannot save client's settings. Please restart the application", "Saving Error")
        End Try
        Return 0
    End Function
End Module
