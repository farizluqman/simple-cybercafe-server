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

Module module_sessionkeeper

    Public Function getTimeIn(ByVal pc As String) As String
        Return System.Convert.ToDateTime(readClientConfig("clients", "timein", pc))
    End Function

    Public Function getTimeOut(ByVal pc As String) As String
        Return System.Convert.ToDateTime(readClientConfig("clients", "timeout", pc))
    End Function

    Public Function getTotalTime(ByVal pc As String) As String
        Dim TotalTime As TimeSpan
        Dim TimeIn As DateTime
        Dim TimeOut As DateTime
        Dim hours As Integer
        Dim minutes As Integer
        Dim seconds As Integer
        Dim formattedTotalTime As String
        Dim accesslevel As Integer = Int(readClientConfig("clients", "accesslevel", pc))
        If accesslevel = 1 Then
            ' counting backwards
            TimeOut = System.Convert.ToDateTime(readClientConfig("clients", "timeout", pc))
            TimeIn = System.Convert.ToDateTime(readClientConfig("clients", "timein", pc))
            TotalTime = TimeOut - TimeIn
        ElseIf accesslevel = 2 Then
            ' counting forward
            TimeIn = System.Convert.ToDateTime(readClientConfig("clients", "timein", pc))
            TotalTime = DateTime.Now - TimeIn
        End If
        hours = TotalTime.TotalHours
        minutes = TotalTime.Minutes
        seconds = TotalTime.Seconds
        formattedTotalTime = Format(hours, "00") + " h " + Format(minutes, "00") + " m " + Format(seconds, "00") + " s "
        Return formattedTotalTime
    End Function

    Public Function calculateTimeLeft(ByVal pc As String) As String
        Dim d1 As DateTime = DateTime.Now
        Dim d2 As DateTime = System.Convert.ToDateTime(readClientConfig("clients", "timeout", pc))
        Dim difference As TimeSpan = d2 - d1
        'round down total hours to integer'
        Dim hours = Math.Floor(difference.TotalHours)
        Dim minutes = Math.Abs(difference.Minutes)
        Dim seconds = difference.Seconds
        Dim timeleft As String = Format(hours, "00") + " h " + Format(minutes, "00") + " m " + Format(seconds, "00") + " s "
        If Int(seconds) < 0 Then
            timeleft = "00 h 00 m 00 s (Time Out)"
            saveClientConfig("clients", "istimeout", 1, pc)
        End If
        Return timeleft
    End Function

    Public Function addtime(ByVal hours As Integer, ByVal minutes As Integer, ByVal prepaidmode As Integer, ByVal pc As String) As String
        ' this function will receive add-on hours & minutes, and then generate a new time out.
        ' usage: addtime(hours,minutes,prepaidmode,pc)
        ' prepaid mode 0 for unlock and 1 for expand time
        Dim timeout As DateTime
        Dim newtimeout As DateTime
        If prepaidmode = 0 Then
            ' for unlock pc mode we calculate the time out by: adding Now + add-on time
            timeout = Now.ToLocalTime
            newtimeout = timeout.AddHours(hours)
            newtimeout = newtimeout.AddMinutes(minutes)
        ElseIf prepaidmode = 1 Then
            ' for expand time mode we calculate the time out by: adding old timeout + add-on time
            timeout = DateTime.Parse(getTimeOut(pc))
            newtimeout = timeout.AddHours(hours)
            newtimeout = newtimeout.AddMinutes(minutes)
        End If
        Return newtimeout ' return the time
    End Function

    Public Function recordTime(ByVal hours As Integer, ByVal minutes As Integer, ByVal pc As String)
        Dim newHours As Integer
        Dim newMinutes As Integer
        Dim accesslevel As Integer = Int(readClientConfig("clients", "accesslevel", pc))

        If accesslevel = 0 Then
            saveClientConfig("clients", "hours", 0, pc)
            saveClientConfig("clients", "minutes", 0, pc)
        End If

        Dim oldHours As Integer = readClientConfig("clients", "hours", pc)
        Dim oldMinutes As Integer = readClientConfig("clients", "minutes", pc)
        newHours = oldHours + hours
        newMinutes = oldMinutes + minutes

        saveClientConfig("clients", "hours", newHours, pc)
        saveClientConfig("clients", "minutes", newMinutes, pc)
        Return 0
    End Function

    Public Function logout(ByVal pc As String)
        saveClientConfig("clients", "accesslevel", 0, pc)
        Return 0
    End Function

    Public Function open(ByVal pc As String)
        saveClientConfig("clients", "accesslevel", 2, pc)
        saveClientConfig("clients", "timein", Now, pc)
        Return 0
    End Function


    Public Function transfer(ByVal target As String, ByVal destination As String) As Boolean

        Dim status As Boolean = False

        If My.Computer.FileSystem.FileExists("clients\" + target + ".cfg") And My.Computer.FileSystem.FileExists("clients\" + destination + ".cfg") Then
            Try
                My.Computer.FileSystem.RenameFile("clients\" + target + ".cfg", target + ".cfg.temp")
                My.Computer.FileSystem.RenameFile("clients\" + destination + ".cfg", destination + ".cfg.temp")
                My.Computer.FileSystem.RenameFile("clients\" + target + ".cfg.temp", destination + ".cfg")
                My.Computer.FileSystem.RenameFile("clients\" + destination + ".cfg.temp", target + ".cfg")
                infobox("Successfully transferred the session from " + target + " to " + destination, "Successful transfer session")
                status = True
            Catch ex As Exception
                appendLog(ex.Message.ToString)
                status = False
            End Try
        Else
            errorbox("Invalid target or destination PC", "Error")
        End If
        

        Return status
    End Function

End Module