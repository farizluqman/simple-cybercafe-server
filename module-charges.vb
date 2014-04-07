Module module_charges
    Public Function totalPrepaid(ByVal pc As String) As Double
        Dim currentHours As integer
        Dim currentMinutes As Integer
        Dim charges As Double

        currentHours = Int(readClientConfig("clients", "hours", pc))
        currentMinutes = Int(readClientConfig("clients", "minutes", pc))

        charges = (currentHours * My.Settings.rate) + (currentMinutes * My.Settings.rate / 60)

        Return charges
    End Function

    Public Function calculateToCharge(ByVal hours As Integer, ByVal minutes As Integer) As Double
        Dim charges As Double
        charges = (hours * My.Settings.rate) + (minutes * My.Settings.rate / 60)
        Return charges
    End Function

    Public Function calculateOpen(ByVal pc As String) As String
        Dim TimeIn As DateTime = readClientConfig("clients", "timein", pc)
        Dim TotalTime = DateTime.Now - TimeIn
        Dim charge As Double = calculateToCharge(TotalTime.TotalHours, TotalTime.Minutes)
        Dim formattedCharge As String = My.Settings.currency + Format(charge, " 0.00")
        Return formattedCharge
    End Function

    Public Function calculateTimeFromCash(ByVal cash As Double) As String
        Dim formattedHours
        Dim hourlyRate As Double = Convert.ToDouble(My.Settings.rate)
        Dim duration As TimeSpan = TimeSpan.FromHours(cash / hourlyRate)
        Dim hours = Math.Floor(duration.TotalHours)
        Dim minutes = duration.Minutes
        formattedHours = Format(hours, "00") + " h " + Format(minutes, "00") + " m "
        Return formattedHours
    End Function

    Public Function calculateHoursFromCash(ByVal cash As Double) As Integer
        Dim hourlyRate As Double = Convert.ToDouble(My.Settings.rate)
        Dim duration As TimeSpan = TimeSpan.FromHours(cash / hourlyRate)
        Dim hours = Math.Floor(duration.TotalHours)
        Return Int(hours)
    End Function

    Public Function calculateMinutesFromCash(ByVal cash As Double) As Integer
        Dim hourlyRate As Double = Convert.ToDouble(My.Settings.rate)
        Dim duration As TimeSpan = TimeSpan.FromHours(cash / hourlyRate)
        Dim minutes = duration.Minutes
        Return Int(minutes)
    End Function
End Module
