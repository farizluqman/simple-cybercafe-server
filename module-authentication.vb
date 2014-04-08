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
        Dim admin_array() As String = My.Settings.admin.Split(New String() {", "}, StringSplitOptions.RemoveEmptyEntries)
        Dim staff_array() As String = My.Settings.staff.Split(New String() {", "}, StringSplitOptions.RemoveEmptyEntries)
        Dim admin_pass_array() As String = My.Settings.admin_pass.Split(New String() {", "}, StringSplitOptions.RemoveEmptyEntries)
        Dim staff_pass_array() As String = My.Settings.staff_pass.Split(New String() {", "}, StringSplitOptions.RemoveEmptyEntries)
        Dim login_status As Integer
        ' login status 
        ' 0 - not logged in
        ' 1 - logged in as staff
        ' 2 - logged in as admin

        Dim i As Integer
        For Each admins As String In admin_array
            If username = admin_array(i) Then
                If MD5(password) = admin_pass_array(i) Then
                    login_status = 2
                    Return login_status
                    Exit Function
                End If
            End If
            i = i + 1
        Next

        i = 0

        For Each staffs As String In staff_array
            If username = staff_array(i) Then
                If MD5(password) = staff_pass_array(i) Then
                    login_status = 1
                    Return login_status
                    Exit Function
                End If

            End If
            i = i + 1
        Next

        Return 0
    End Function
End Module
