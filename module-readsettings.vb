Imports System.Text

Module module_readsettings
    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String, _
        ByVal lpKeyName As String, _
        ByVal lpDefault As String, _
        ByVal lpReturnedString As StringBuilder, _
        ByVal nSize As Integer, _
        ByVal lpFileName As String) As Integer ' function for the configuration file reader

    Public Function readClientConfig(ByVal section As String, ByVal key As String, ByVal pc As String) As String
        ' this function is to read clients configuration file (located at the clients\ folder)
        ' parameter for reading the config file: readClientConfig("section", "key", "pc_number")

        ' sections available
        ' ------------------
        ' [network] 
        ' connected=(0 - disconnected, 1 - connected) 
        ' [clients]
        ' accesslevel=(0 - locked, 1 - prepaid, 2 - open, 3 - members, 4 - staffs, 5 - admin)
        ' timein=(client's checkin time)
        ' timeout=(client's checkout time)
        Dim res As Integer
        Dim sb As StringBuilder

        sb = New StringBuilder(500)
        res = GetPrivateProfileString(section, key, "", sb, sb.Capacity, "clients\" + pc + ".cfg")
        Return sb.ToString()
    End Function

    Public Function getClients()
        ' this is a function that will get all clients from the directory clients\
        ' this function will list all clients to the client list 
        For Each files In System.IO.Directory.GetFiles("clients\")
            Dim icon As Icon = My.Resources.icons.Icon1
            frmHome.ImageList1.Images.Add(icon.ToBitmap)
            Dim i As String = Replace(files.ToString, "clients\", "")
            If i.EndsWith(".cfg") Then
                Dim j As String = Replace(i, ".cfg", "")
                frmHome.listClients.Items.Add(New ListViewItem(j, frmHome.ImageList1.Images.Count - 1))
            End If
        Next
        Return 0
    End Function

    Public Function filterClients(ByVal search As String)
        ' this is a function that will filter clients by given keyword
        ' this function will list the results to the client list 
        ' parameter: filterClients(search_keywords)
        For Each files In System.IO.Directory.GetFiles("clients\")
            Dim icon As Icon = My.Resources.icons.Icon1
            frmHome.ImageList1.Images.Add(icon.ToBitmap)
            Dim i As String = Replace(files.ToString, "clients\", "")
            If i.EndsWith(".cfg") Then
                Dim j As String = Replace(i, ".cfg", "")
                If j.ToLower.Contains(search.ToLower) Then ' change both search keyword and the list to lowercase for case insensitve search
                    frmHome.listClients.Items.Add(New ListViewItem(j, frmHome.ImageList1.Images.Count - 1))
                End If
            End If
        Next
        Return 0
    End Function

    Public Function statusConnection(ByVal code As String) As String
        ' this function will return the connection status of the client based on the status code
        ' parameter: statusConnection(code)
        Dim status As String
        If code = "0" Then
            status = "Disconnected"
        ElseIf code = "1" Then
            status = "Connected"
        Else
            status = "Unknown"
        End If
        Return status
    End Function
    Public Function statusAccesslevel(ByVal pc As String) As String
        ' this function will return the connection status of the client based on the status code
        ' parameter: statusConnection(code)
        Dim status As String

        Dim accesslevel As Integer = Int(readClientConfig("clients", "accesslevel", pc))
        If accesslevel = "0" Then
            status = "Locked"
        ElseIf accesslevel = "1" Then
            status = "Prepaid"
        ElseIf accesslevel = "2" Then
            status = "Open"
        ElseIf accesslevel = "3" Then
            status = "Members"
        ElseIf accesslevel = "4" Then
            status = "Staffs"
        ElseIf accesslevel = "5" Then
            status = "Admin"
        Else
            status = "Unknown"
        End If
        Return status
    End Function
 

    Public Function getAdmins() As String()
        Dim admins As String()

        Return {"1", "1"}
    End Function

End Module
