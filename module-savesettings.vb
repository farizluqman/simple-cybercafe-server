'Copyright 2014 Fariz Luqman
'
'   Licensed under the Apache License, Version 2.0 (the "License");
'   you may not use this file except in compliance with the License.
'   You may obtain a copy of the License at
'
'       http://www.apache.org/licenses/LICENSE-2.0
'
'   Unless required by applicable law or agreed to in writing, software
'   distributed under the License is distributed on an "AS IS" BASIS,
'   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
'   See the License for the specific language governing permissions and
'   limitations under the License.

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
