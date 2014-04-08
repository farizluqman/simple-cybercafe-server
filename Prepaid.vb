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

Public Class frmPrepaid

    Public pc As String = frmHome.selectedPC
    Public prepaidMode As String = frmHome.prepaidMode

    Public hours As Integer
    Public minutes As Integer
    ' this is counted manually / incremented as user add hours and minutes. 
    ' no need to use timespan for this

    Public charges As String

    Private Function changeAlertBox(ByVal message As String, ByVal kind As String)
        alertPrepaid.Hide()
        alertPrepaid.Text = message
        If LCase(kind) = "info" Then
            alertPrepaid.kind = FlatAlertBox._Kind.Info
        ElseIf LCase(kind) = "success" Then
            alertPrepaid.kind = FlatAlertBox._Kind.Success
        ElseIf LCase(kind) = "error" Then
            alertPrepaid.kind = FlatAlertBox._Kind.Error
        End If
        alertPrepaid.Show()
        Return 0
    End Function

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Public Sub frmPrepaid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtCurrency.Text = My.Settings.currency
        txtSelectedPC.Text = frmHome.selectedPC
        If prepaidMode = 0 Then
            timerTimeLeft.Enabled = False
            txtTimeIn.Text = getTimeIn(pc)
            txtTimeOut.Text = "N/A"
            txtTimeLeft.Text = "N/A"
            txtAddTime.Text = hours.ToString("00") + " h " + minutes.ToString("00") + " m "
        ElseIf prepaidMode = 1 Then
            timerTimeLeft.Enabled = True
            txtTimeIn.Text = getTimeIn(pc)
            txtTimeOut.Text = getTimeOut(pc)
            txtTimeLeft.Text = calculateTimeLeft(pc)
            txtAddTime.Text = hours.ToString("00") + " h " + minutes.ToString("00") + " m "
        End If
    End Sub

    Private Sub checkDiscount_CheckedChanged(ByVal sender As Object) Handles checkDiscount.CheckedChanged
        If checkDiscount.Checked = True Then
            comboDiscounts.Enabled = True
        Else
            comboDiscounts.Enabled = False
        End If
    End Sub

    Private Sub cmdAdd1Hour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd1Hour.Click
        hours = hours + 1
        txtAddTime.Text = hours.ToString("00") + " h " + minutes.ToString("00") + " m "
    End Sub

    Private Sub cmdAdd30Mins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd30Mins.Click
        minutes = minutes + 30
        txtAddTime.Text = hours.ToString("00") + " h " + minutes.ToString("00") + " m "
        If minutes >= 60 Then
            minutes = 0
            hours = hours + 1
            txtAddTime.Text = hours.ToString("00") + " h " + minutes.ToString("00") + " m "
        End If
    End Sub

    Private Sub cmdAdd10Mins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd10Mins.Click
        minutes = minutes + 10
        txtAddTime.Text = hours.ToString("00") + " h " + minutes.ToString("00") + " m "
        If minutes >= 60 Then
            minutes = 0
            hours = hours + 1
            txtAddTime.Text = hours.ToString("00") + " h " + minutes.ToString("00") + " m "
        End If
    End Sub

    Private Sub cmdAdd5Mins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd5Mins.Click
        minutes = minutes + 5
        txtAddTime.Text = hours.ToString("00") + " h " + minutes.ToString("00") + " m "
        If minutes >= 60 Then
            minutes = 0
            hours = hours + 1
            txtAddTime.Text = hours.ToString("00") + " h " + minutes.ToString("00") + " m "
        End If
    End Sub

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        hours = 0
        minutes = 0
        txtAddTime.Text = hours.ToString("00") + " h " + minutes.ToString("00") + " m "
    End Sub

    Private Sub cmdTopup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTopUp.Click
        If prepaidMode = 0 Then
            saveClientConfig("clients", "timein", Now.ToLocalTime, pc)
            saveClientConfig("clients", "timeout", addtime(hours, minutes, 0, pc), pc)
            recordTime(hours, minutes, pc)
            saveClientConfig("clients", "accesslevel", 1, pc)
        ElseIf prepaidMode = 1 Then
            saveClientConfig("clients", "timeout", addtime(hours, minutes, 1, pc), pc)
            recordTime(hours, minutes, pc)
        End If
        saveClientConfig("clients", "istimeout", 0, pc)
        frmReceipt.Show()
    End Sub

    Private Sub txtAddTime_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddTime.TextChanged
        txtNewTimeOut.Text = addtime(hours, minutes, prepaidMode, pc)
        charges = My.Settings.currency + " " + Format(calculateToCharge(hours, minutes), "0.00")
        txtCharge.Text = charges
    End Sub

    Private Sub frmPrepaid_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        timerTimeLeft.Enabled = False
    End Sub

    Private Sub timerTimeLeft_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timerTimeLeft.Tick
        txtTimeLeft.Text = calculateTimeLeft(pc)
    End Sub

    Private Sub txtCash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCash.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar = Convert.ToChar(Keys.Back) OrElse e.KeyChar = Convert.ToChar(Keys.Delete) OrElse e.KeyChar = "." Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCash.TextChanged
        Try
            Dim cash As Double
            cash = Convert.ToDouble(txtCash.Text)
            hours = calculateHoursFromCash(cash)
            minutes = calculateMinutesFromCash(cash)
            txtCashAddTime.Text = calculateTimeFromCash(cash)
            txtCashNewTimeOut.Text = addtime(hours, minutes, prepaidMode, pc)
        Catch ex As Exception
            changeAlertBox("Invalid input. Please check your input. Input could not be blank. ", "error")
        End Try

        If txtCash.Text = "" OrElse txtCash.Text Is Nothing Then
            txtCashNewTimeOut.Text = Convert.ToString(TimeSpan.Zero)
            txtCashAddTime.Text = "00 h 00 m"
        End If
    End Sub

    Private Sub cmdCash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCash.Click
        If prepaidMode = 0 Then
            saveClientConfig("clients", "timein", Now.ToLocalTime, pc)
            saveClientConfig("clients", "timeout", addtime(hours, minutes, 0, pc), pc)
            recordTime(hours, minutes, pc)
            saveClientConfig("clients", "accesslevel", 1, pc)
        ElseIf prepaidMode = 1 Then
            saveClientConfig("clients", "timeout", addtime(hours, minutes, 1, pc), pc)
            recordTime(hours, minutes, pc)
        End If
        saveClientConfig("clients", "istimeout", 0, pc)
        frmReceipt.Show()
    End Sub
End Class