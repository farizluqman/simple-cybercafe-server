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

Imports System.ComponentModel

Public Class frmHome
    Public isLoggedIn As Boolean = False
    Public loggedInAs As String
    Public access_level As Integer
    Public admin_array() As String = My.Settings.admin.Split(New String() {", "}, StringSplitOptions.RemoveEmptyEntries)
    Public staff_array() As String = My.Settings.staff.Split(New String() {", "}, StringSplitOptions.RemoveEmptyEntries)
    Public admin_pass_array() As String = My.Settings.admin_pass.Split(New String() {", "}, StringSplitOptions.RemoveEmptyEntries)
    Public staff_pass_array() As String = My.Settings.staff_pass.Split(New String() {", "}, StringSplitOptions.RemoveEmptyEntries)
    Public selectedPC As String
    Public prepaidMode As Integer ' 0 - unlock pc, 1 - add prepaid/expand time

    Public Function clearClients()
        listClients.Clear()
        Return 0
    End Function

    Private Sub frmHome_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'ServerDataSet.tblMembers' table. You can move, or remove it, as needed.
        Me.TblMembersTableAdapter.Fill(Me.ServerDataSet.tblMembers)
        If isLoggedIn = False Then
            frmLogin.Show()
        End If
        getClients()
    End Sub

    Private Function changeAlertBox(ByVal message As String, ByVal kind As String)
        alertHome.Hide()
        alertHome.Text = message
        If LCase(kind) = "info" Then
            alertHome.kind = FlatAlertBox._Kind.Info
        ElseIf LCase(kind) = "success" Then
            alertHome.kind = FlatAlertBox._Kind.Success
        ElseIf LCase(kind) = "error" Then
            alertHome.kind = FlatAlertBox._Kind.Error
        End If
        alertHome.Show()
        Return 0
    End Function

    Private Sub menuTermClients_Opening(ByVal sender As System.Object, ByVal e As CancelEventArgs) _
        Handles menuTermClients.Opening
        If Me.listClients.SelectedItems.Count = 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub txtFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFilter.TextChanged
        clearClients()
        filterClients(txtFilter.Text)
    End Sub

    Private Sub linkClear_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkClear.LinkClicked
        txtFilter.Text = ""
    End Sub

    Private Sub timerRuntime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerClock.Tick
        txtTimeNow.Text = Now.ToLongTimeString.ToString()
    End Sub

    Private Sub cmdPrepaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrepaid.Click

        If readClientConfig("clients", "accesslevel", selectedPC) = "0" Then
            prepaidMode = 0
            frmPrepaid.FormSkin1.Text = "Add Prepaid (Unlock PC)"
            saveClientConfig("clients", "timein", Now, selectedPC)
            saveClientConfig("clients", "timeout", Now, selectedPC)
            frmPrepaid.Show()
        ElseIf readClientConfig("clients", "accesslevel", selectedPC) = "1" Then
            prepaidMode = 1
            frmPrepaid.FormSkin1.Text = "Add Prepaid (Expand Time)"
            frmPrepaid.Show()
        ElseIf readClientConfig("clients", "accesslevel", selectedPC) = "2" Then
            changeAlertBox(("The client is currently in " + statusAccesslevel(selectedPC) + " mode."), "error")
        ElseIf readClientConfig("clients", "accesslevel", selectedPC) = "3" Then
            changeAlertBox(("The client is currently in " + statusAccesslevel(selectedPC) + " mode."), "error")
        ElseIf readClientConfig("clients", "accesslevel", selectedPC) = "4" Then
            changeAlertBox(("The client is currently in " + statusAccesslevel(selectedPC) + " mode."), "error")
        ElseIf readClientConfig("clients", "accesslevel", selectedPC) = "5" Then
            changeAlertBox(("The client is currently in " + statusAccesslevel(selectedPC) + " mode."), "error")
        Else

        End If

    End Sub

    Private Sub timerTimeLeft_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timerTimeLeft.Tick
        Dim istimeout As Integer = readClientConfig("clients", "istimeout", selectedPC)
        If istimeout = 0 Then
            txtTimeLeft.Text = calculateTimeLeft(selectedPC)
        End If
    End Sub

    Private Sub CloseSessionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseSessionToolStripMenuItem.Click
        Dim accesslevel = readClientConfig("clients", "accesslevel", selectedPC)
        If MsgBox("Do you want to close the current session?", vbQuestion + vbYesNo, "Close session") = MsgBoxResult.Yes Then
            If accesslevel = 0 Then
                MsgBox("The client is currently locked", vbInformation, "Close session")
            ElseIf accesslevel = 1 Then
                logout(selectedPC)
                ' frmReceipt.Show()
                changeAlertBox("The client is successfully logged out", "success")
            ElseIf accesslevel = 2 Then
                saveClientConfig("clients", "timeout", Now, selectedPC)
                frmReceipt.Show()
                changeAlertBox("The client is successfully logged out", "success")
            ElseIf accesslevel = 3 Then
                logout(selectedPC)
                changeAlertBox("The client is successfully logged out", "success")
            ElseIf accesslevel = 4 Then
                logout(selectedPC)
                changeAlertBox("The client is successfully logged out", "success")
            ElseIf accesslevel = 5 Then
                logout(selectedPC)
                changeAlertBox("The client is successfully logged out", "success")
            ElseIf accesslevel = 6 Then
                logout(selectedPC)
                changeAlertBox("The client is successfully logged out", "success")
            End If
        End If
        clientInfo()
    End Sub

    Private Sub listClients_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listClients.SelectedIndexChanged
        clientInfo()
    End Sub

    Public Function clientInfo()
        Dim i As Integer
        Dim pc As String
        Dim connection_code As String
        Dim accesslevel_code As String
        ' the function is quiet bloated. need to be fixed for shorter and cleaner codes
        For i = 0 To listClients.SelectedItems.Count - 1
            pc = listClients.SelectedItems(i).Text
            selectedPC = pc
            txtSelectedPC.Text = listClients.SelectedItems(i).Text
            connection_code = readClientConfig("network", "connected", pc)
            accesslevel_code = readClientConfig("clients", "accesslevel", pc)
            txtStatus.Text = statusConnection(connection_code)
            txtAccessLevel.Text = statusAccesslevel(pc)
            txtTimeIn.Text = Date.Parse(readClientConfig("clients", "timein", pc))
            txtMemberName.Text = "N/A" ' temporary while working on database and membership functionality
            If accesslevel_code = "2" Then ' for open sessions
                timerTimeLeft.Enabled = False
                timerTotalTime.Enabled = True
                toggleOpen.Hide()
                toggleOpen.Checked = True
                toggleOpen.Show()
                txtTimeIn.Text = getTimeIn(pc)
                txtTotalTime.Text = getTotalTime(pc)
                txtTimeOut.Text = "N/A"
                txtTimeLeft.Text = "N/A"
                txtCharges.Text = My.Settings.currency + Format(calculateOpen(pc), " 0.00")
            ElseIf accesslevel_code = "1" Then ' for prepaid sessions
                timerTimeLeft.Enabled = True
                timerTotalTime.Enabled = False
                toggleOpen.Hide()
                toggleOpen.Checked = False
                toggleOpen.Show()
                txtTimeOut.Text = getTimeOut(pc)
                txtTimeLeft.Text = calculateTimeLeft(pc)
                txtCharges.Text = My.Settings.currency + Format(totalPrepaid(pc), " 0.00")
                txtTotalTime.Text = getTotalTime(pc)
            ElseIf accesslevel_code = "0" Then ' locked session
                timerTimeLeft.Enabled = False
                timerTotalTime.Enabled = False
                toggleOpen.Hide()
                toggleOpen.Checked = False
                toggleOpen.Show()
                txtCharges.Text = "N/A"
                txtTimeIn.Text = "N/A"
                txtTimeOut.Text = "N/A"
                txtTotalTime.Text = "N/A"
                txtTimeLeft.Text = "N/A"
            Else
                txtCharges.Text = "N/A"
                txtTimeOut.Text = "N/A"
                txtTotalTime.Text = "N/A"
                txtTimeLeft.Text = "N/A"
                timerTimeLeft.Enabled = False
                toggleOpen.Hide()
                toggleOpen.Checked = False
                toggleOpen.Show()
            End If
        Next
        Return 0
    End Function


    Private Sub cmdLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogout.Click
        frmLogin.Show()
        Me.Enabled = False
    End Sub

    Private Sub cmdRefreshClients_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefreshClients.Click
        clientInfo()
    End Sub

    Private Sub cmdLoginStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoginStaff.Click
        If access_level = 1 OrElse access_level = 2 Then
            errorbox("You don't have permission to do that!", "Login PC as Staff")
        End If
    End Sub

    Private Sub cmdLoginAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoginAdmin.Click
        If access_level = 1 OrElse access_level = 2 Then
            errorbox("You don't have permission to do that!", "Login PC as Admin")
        End If
    End Sub

    Private Sub cmdUnlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnlock.Click
        If access_level = 1 OrElse access_level = 2 Then
            errorbox("You don't have permission to do that!", "Unlock")
        End If
    End Sub

    Private Sub timerTotalTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerTotalTime.Tick
        txtTotalTime.Text = getTotalTime(selectedPC)
    End Sub

    Private Sub OpenSessionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenSessionToolStripMenuItem.Click
        If MsgBox("Do you want to login the client into open hour mode?", vbQuestion + vbYesNo, "Open session") = MsgBoxResult.Yes Then
            Dim accesslevel As Integer = Int(readClientConfig("clients", "accesslevel", selectedPC))
            If accesslevel = 0 Then
                open(selectedPC)
                changeAlertBox(("The client is successfully logged in as " + statusAccesslevel(selectedPC) + " mode"), "success")
            Else
                changeAlertBox(("The client is currently in " + statusAccesslevel(selectedPC) + " mode"), "error")
            End If
        End If
        clientInfo()
    End Sub

    Private Sub toggleOpen_CheckedChanged(ByVal sender As System.Object) Handles toggleOpen.CheckedChanged
        If selectedPC = Nothing Then
            errorbox("Please select a PC", "Invalid Option")
            toggleOpen.Hide()
            toggleOpen.Checked = False
            toggleOpen.Show()
            Exit Sub
        End If
        Dim accesslevel As Integer = Int(readClientConfig("clients", "accesslevel", selectedPC))
        If accesslevel = 2 Then
            If MsgBox("Do you want to close the current session?", vbQuestion + vbYesNo, "Close session") = MsgBoxResult.Yes Then
                If toggleOpen.Checked = False Then
                    saveClientConfig("clients", "timeout", Now, selectedPC)
                    frmReceipt.Show()
                    changeAlertBox("The client is successfully logged out", "success")
                End If
            Else
                toggleOpen.Hide()
                toggleOpen.Checked = True
                toggleOpen.Show()
            End If
        ElseIf accesslevel = 0 Then
            If MsgBox("Do you want to login the client into open hour mode?", vbQuestion + vbYesNo, "Open session") = MsgBoxResult.Yes Then
                open(selectedPC)
                changeAlertBox(("The client is successfully logged in as " + statusAccesslevel(selectedPC) + " mode"), "success")
                clientInfo()
            Else
                toggleOpen.Hide()
                toggleOpen.Checked = False
                toggleOpen.Show()
            End If

        Else
            changeAlertBox(("The client is currently in " + statusAccesslevel(selectedPC) + " mode."), "error")
            toggleOpen.Hide()
            toggleOpen.Checked = False
            toggleOpen.Show()
        End If
    End Sub

    Private Sub cmdSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSettings.Click
        frmConfiguration.Show()
    End Sub
End Class
