Public Class frmLogin
    Dim username As String
    Dim password As String
    Dim login_status
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmHome.statusMain.Text = "Logging In..."
        frmHome.statusMain.RectColor = Color.GreenYellow
    End Sub

    Private Sub frmLogin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If login_status = 1 OrElse login_status = 2 Then
            frmHome.LoggedInAs = username
            frmHome.statusMain.Text = "Logged in as " + username
            frmHome.statusMain.RectColor = Color.FromArgb(35, 168, 109)
            MsgBox("Welcome to Simple CyberCafe Server 1.0. Please visit https://github.com/farizluqman/simple-cybercafe-server", vbInformation, "Simple CyberCafe Server 1.0")
            frmHome.alertHome.kind = FlatAlertBox._Kind.Info
            frmHome.alertHome.Text = "Welcome to Simple CyberCafe Server 1.0"
            frmHome.alertHome.Visible = True
            frmHome.Enabled = True
            frmHome.loginLevel = login_status
            If toggleRemember.Checked = True Then
                My.Settings.remember_login = username
                My.Settings.Save()
            ElseIf toggleRemember.Checked = False Then
                My.Settings.remember_login = ""
                My.Settings.Save()
            End If
        Else
            End
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, _
                                           ByVal keyData As System.Windows.Forms.Keys) _
                                           As Boolean

        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then ' when all textbox has been filled, the enter key will run the command button
            If txtUsername.Text.Length > 0 And txtPassword.Text.Length > 0 Then
                cmdLogin_Click(Me, EventArgs.Empty)
            Else ' simulate the return key as tab key when textbox hasn't been filled. 
                ' due to some bugs, we need to send the press key twice to go to the next control
                SendKeys.Send("{Tab}")
                SendKeys.Send("{Tab}")
            End If
            Return False
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        username = txtUsername.Text
        password = txtPassword.Text

        login_status = login(username, password)

        If login_status = 2 Then
            alertLogin.Visible = False
            alertLogin.Text = "Logged in successfully"
            alertLogin.kind = FlatAlertBox._Kind.Success
            alertLogin.Visible = True
            frmHome.isLoggedIn = True
            Me.Close()
            Exit Sub
        ElseIf login_status = 1 Then
            alertLogin.Visible = False
            alertLogin.Text = "Logged in successfully"
            alertLogin.kind = FlatAlertBox._Kind.Success
            alertLogin.Visible = True
            frmHome.isLoggedIn = True
            Me.Close()
            Exit Sub
        ElseIf login_status = 0 Then
            alertLogin.Visible = False
            alertLogin.Text = "Invalid username or password"
            alertLogin.kind = FlatAlertBox._Kind.Error
            alertLogin.Visible = True
        End If
    End Sub


    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        frmHome.Enabled = False
        txtUsername.Text = My.Settings.remember_login
        If My.Settings.remember_login.Length > 0 Then
            toggleRemember.Checked = True
        End If
    End Sub
End Class