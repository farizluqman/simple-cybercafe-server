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

Module module_authentication

    Public Function MD5(ByRef input As String) As String
        ' this function is to convert any input and return an MD5 hash
        ' parameter for MD5 conversion: MD5("text to hash")
        Dim md5svc As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim bytes() As Byte = md5svc.ComputeHash(System.Text.Encoding.ASCII.GetBytes(input))
        Dim i As String
        For Each j As Byte In bytes
            i += j.ToString("x2")
        Next
        Return i
    End Function

    Public Function login(ByVal username As String, ByVal password As String) As Integer
        Return dbLogin(username, MD5(password))
    End Function
End Module
