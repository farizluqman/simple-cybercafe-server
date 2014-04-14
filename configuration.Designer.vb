<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FormSkin1 = New cybercafe_server.FormSkin()
        Me.cmdClose = New cybercafe_server.FlatButton()
        Me.statusSettings = New cybercafe_server.FlatStatusBar()
        Me.FlatTabControl1 = New cybercafe_server.FlatTabControl()
        Me.tabClients = New System.Windows.Forms.TabPage()
        Me.tabEmployees = New System.Windows.Forms.TabPage()
        Me.tabPOS = New System.Windows.Forms.TabPage()
        Me.tabDatabase = New System.Windows.Forms.TabPage()
        Me.tabServer = New System.Windows.Forms.TabPage()
        Me.txtPort = New cybercafe_server.FlatTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.tabServer.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.cmdClose)
        Me.FormSkin1.Controls.Add(Me.statusSettings)
        Me.FormSkin1.Controls.Add(Me.FlatTabControl1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(925, 530)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Settings"
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Transparent
        Me.cmdClose.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdClose.Location = New System.Drawing.Point(826, 12)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Rounded = False
        Me.cmdClose.Size = New System.Drawing.Size(83, 32)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "Close"
        Me.cmdClose.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'statusSettings
        '
        Me.statusSettings.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.statusSettings.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.statusSettings.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.statusSettings.ForeColor = System.Drawing.Color.White
        Me.statusSettings.Location = New System.Drawing.Point(0, 507)
        Me.statusSettings.Name = "statusSettings"
        Me.statusSettings.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.statusSettings.ShowTimeDate = False
        Me.statusSettings.Size = New System.Drawing.Size(925, 23)
        Me.statusSettings.TabIndex = 2
        Me.statusSettings.TextColor = System.Drawing.Color.White
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatTabControl1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.tabClients)
        Me.FlatTabControl1.Controls.Add(Me.tabEmployees)
        Me.FlatTabControl1.Controls.Add(Me.tabPOS)
        Me.FlatTabControl1.Controls.Add(Me.tabDatabase)
        Me.FlatTabControl1.Controls.Add(Me.tabServer)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(0, 49)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(925, 469)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 1
        '
        'tabClients
        '
        Me.tabClients.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabClients.Location = New System.Drawing.Point(4, 44)
        Me.tabClients.Name = "tabClients"
        Me.tabClients.Size = New System.Drawing.Size(917, 421)
        Me.tabClients.TabIndex = 4
        Me.tabClients.Text = "Clients"
        '
        'tabEmployees
        '
        Me.tabEmployees.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabEmployees.Location = New System.Drawing.Point(4, 44)
        Me.tabEmployees.Name = "tabEmployees"
        Me.tabEmployees.Size = New System.Drawing.Size(917, 421)
        Me.tabEmployees.TabIndex = 2
        Me.tabEmployees.Text = "Employees"
        '
        'tabPOS
        '
        Me.tabPOS.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabPOS.Location = New System.Drawing.Point(4, 44)
        Me.tabPOS.Name = "tabPOS"
        Me.tabPOS.Size = New System.Drawing.Size(917, 421)
        Me.tabPOS.TabIndex = 5
        Me.tabPOS.Text = "POS"
        '
        'tabDatabase
        '
        Me.tabDatabase.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabDatabase.Location = New System.Drawing.Point(4, 44)
        Me.tabDatabase.Name = "tabDatabase"
        Me.tabDatabase.Size = New System.Drawing.Size(917, 421)
        Me.tabDatabase.TabIndex = 3
        Me.tabDatabase.Text = "Database"
        '
        'tabServer
        '
        Me.tabServer.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabServer.Controls.Add(Me.txtPort)
        Me.tabServer.Controls.Add(Me.Label2)
        Me.tabServer.Location = New System.Drawing.Point(4, 44)
        Me.tabServer.Name = "tabServer"
        Me.tabServer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabServer.Size = New System.Drawing.Size(917, 421)
        Me.tabServer.TabIndex = 1
        Me.tabServer.Text = "Server"
        '
        'txtPort
        '
        Me.txtPort.BackColor = System.Drawing.Color.Transparent
        Me.txtPort.Location = New System.Drawing.Point(162, 40)
        Me.txtPort.MaxLength = 32767
        Me.txtPort.Multiline = False
        Me.txtPort.Name = "txtPort"
        Me.txtPort.ReadOnly = False
        Me.txtPort.Size = New System.Drawing.Size(104, 29)
        Me.txtPort.TabIndex = 8
        Me.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPort.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPort.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(40, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Server Port (TCP)"
        '
        'frmConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 530)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConfiguration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "configuration"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FlatTabControl1.ResumeLayout(False)
        Me.tabServer.ResumeLayout(False)
        Me.tabServer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As cybercafe_server.FormSkin
    Friend WithEvents FlatTabControl1 As cybercafe_server.FlatTabControl
    Friend WithEvents tabServer As System.Windows.Forms.TabPage
    Friend WithEvents statusSettings As cybercafe_server.FlatStatusBar
    Friend WithEvents cmdClose As cybercafe_server.FlatButton
    Friend WithEvents tabEmployees As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tabDatabase As System.Windows.Forms.TabPage
    Friend WithEvents txtPort As cybercafe_server.FlatTextBox
    Friend WithEvents tabClients As System.Windows.Forms.TabPage
    Friend WithEvents tabPOS As System.Windows.Forms.TabPage
End Class
