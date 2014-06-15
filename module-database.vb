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

Imports System.Data.OleDb

Module module_database

    Public Function dbConnect(ByVal table As String) As Boolean
        Dim success As Boolean
        Try
            Dim connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=server.property\server.mdb;")
            If DoesTableExist(table) = True Then
                Dim command As New OleDbCommand("SELECT * FROM " + table, connection)
                infobox("Found!", "Success!")
                connection.Open()
                command.Connection.Close()
                connection.Dispose()
            End If
        Catch ex As Exception
            dberror()
            appendLog(ex.Message.ToString)
            success = False
        End Try
        Return success
    End Function

    Public Function dbLogin(ByVal username As String, ByVal password As String) As Integer
        Dim level As Integer = 0
        Try
            Dim connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=server.mdb;")
            Dim command As New OleDbCommand("SELECT * FROM [tblAuth] WHERE [UsernameField] = username AND [PasswordField] = password", connection)
            Dim usernameParam As New OleDbParameter("username", username)
            Dim passwordParam As New OleDbParameter("password", password)
            command.Parameters.Add(usernameParam)
            command.Parameters.Add(passwordParam)
            command.Connection.Open()
            Dim reader As OleDbDataReader = command.ExecuteReader()
            If reader.Read() Then
                Try
                    level = Int(reader("Access_Level").ToString())
                Catch ex As Exception
                    dberror()
                    appendLog(ex.Message.ToString)
                End Try
                command.Connection.Close()
                command.Connection.Dispose()
                Return level
                Exit Function
            Else
                command.Connection.Close()
                command.Connection.Dispose()
                Return level
                Exit Function
            End If
        Catch ex As Exception
            dberror()
            appendLog(ex.Message.ToString)
        End Try

        Return level
    End Function

    Public Function DoesTableExist(ByVal table As String) As Boolean
        Dim connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=server.mdb;")
        connection.Open()
        Dim restrictions(3) As String
        restrictions(2) = table
        Dim dbTbl As DataTable = connection.GetSchema("Tables", restrictions)

        If dbTbl.Rows.Count = 0 Then
            DoesTableExist = False
        Else
            DoesTableExist = True
        End If

        dbTbl.Dispose()
        connection.Close()
        connection.Dispose()
    End Function

End Module
