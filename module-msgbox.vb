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

    Public Sub dberror()
        errorbox("Could not access the database. Please check the error log to see the status.", "Error")
    End Sub

End Module
