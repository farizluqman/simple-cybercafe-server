<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.timerClock = New System.Windows.Forms.Timer(Me.components)
        Me.timerTimeLeft = New System.Windows.Forms.Timer(Me.components)
        Me.timerTotalTime = New System.Windows.Forms.Timer(Me.components)
        Me.TblMembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServerDataSet = New cybercafe_server.serverDataSet()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.TblMembersTableAdapter = New cybercafe_server.serverDataSetTableAdapters.tblMembersTableAdapter()
        Me.FormSkin1s = New cybercafe_server.FormSkin()
        Me.FlatMax1 = New cybercafe_server.FlatMax()
        Me.cmdLogout = New cybercafe_server.FlatButton()
        Me.alertHome = New cybercafe_server.FlatAlertBox()
        Me.cmdSettings = New cybercafe_server.FlatButton()
        Me.statusMain = New cybercafe_server.FlatStatusBar()
        Me.FlatClose1 = New cybercafe_server.FlatClose()
        Me.FlatMini1 = New cybercafe_server.FlatMini()
        Me.FlatTabControl1 = New cybercafe_server.FlatTabControl()
        Me.tabTerminal = New System.Windows.Forms.TabPage()
        Me.FlatButton5 = New cybercafe_server.FlatButton()
        Me.FlatButton4 = New cybercafe_server.FlatButton()
        Me.FlatButton3 = New cybercafe_server.FlatButton()
        Me.linkClear = New System.Windows.Forms.LinkLabel()
        Me.FlatTextBox1 = New cybercafe_server.FlatTextBox()
        Me.txtFilter = New cybercafe_server.FlatTextBox()
        Me.cmdRefreshClients = New cybercafe_server.FlatButton()
        Me.FlatTabControl2 = New cybercafe_server.FlatTabControl()
        Me.tabBilling = New System.Windows.Forms.TabPage()
        Me.linkShowMemberName = New System.Windows.Forms.LinkLabel()
        Me.linkViewItems = New System.Windows.Forms.LinkLabel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMemberName = New cybercafe_server.FlatTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTimeLeft = New cybercafe_server.FlatTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTimeNow = New cybercafe_server.FlatTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCharges = New cybercafe_server.FlatTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTimeOut = New cybercafe_server.FlatTextBox()
        Me.txtTotalTime = New cybercafe_server.FlatTextBox()
        Me.cmdMembers = New cybercafe_server.FlatButton()
        Me.cmdPrepaid = New cybercafe_server.FlatButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTimeIn = New cybercafe_server.FlatTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAccessLevel = New cybercafe_server.FlatTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStatus = New cybercafe_server.FlatTextBox()
        Me.toggleOpen = New cybercafe_server.FlatToggle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSelectedPC = New cybercafe_server.FlatTextBox()
        Me.tabCommands = New System.Windows.Forms.TabPage()
        Me.FlatGroupBox2 = New cybercafe_server.FlatGroupBox()
        Me.cmdLoginAdmin = New cybercafe_server.FlatButton()
        Me.cmdLoginStaff = New cybercafe_server.FlatButton()
        Me.cmdUnlock = New cybercafe_server.FlatButton()
        Me.FlatGroupBox1 = New cybercafe_server.FlatGroupBox()
        Me.FlatButton12 = New cybercafe_server.FlatButton()
        Me.FlatButton11 = New cybercafe_server.FlatButton()
        Me.FlatButton10 = New cybercafe_server.FlatButton()
        Me.FlatButton9 = New cybercafe_server.FlatButton()
        Me.FlatButton2 = New cybercafe_server.FlatButton()
        Me.FlatButton1 = New cybercafe_server.FlatButton()
        Me.listClients = New System.Windows.Forms.ListView()
        Me.menuTermClients = New cybercafe_server.FlatContextMenuStrip()
        Me.OpenSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnOffClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendMessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabMembers = New System.Windows.Forms.TabPage()
        Me.cmdDeleteSelectedMember = New cybercafe_server.FlatButton()
        Me.cmdSendMessages = New cybercafe_server.FlatButton()
        Me.cmdEditMembershipTypes = New cybercafe_server.FlatButton()
        Me.cmdAddMember = New cybercafe_server.FlatButton()
        Me.cmdEditSelectedMember = New cybercafe_server.FlatButton()
        Me.dataMembers = New System.Windows.Forms.DataGridView()
        Me.IDNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberDOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsLoggedInDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.FlatTextBox2 = New cybercafe_server.FlatTextBox()
        Me.FlatTextBox3 = New cybercafe_server.FlatTextBox()
        Me.tabServices = New System.Windows.Forms.TabPage()
        Me.FlatTabControl3 = New cybercafe_server.FlatTabControl()
        Me.tabFnD = New System.Windows.Forms.TabPage()
        Me.tabPrinting = New System.Windows.Forms.TabPage()
        Me.tabPrepaidCodes = New System.Windows.Forms.TabPage()
        Me.tabMiscItems = New System.Windows.Forms.TabPage()
        Me.tabSales = New System.Windows.Forms.TabPage()
        Me.FlatTabControl4 = New cybercafe_server.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        CType(Me.TblMembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSkin1s.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.tabTerminal.SuspendLayout()
        Me.FlatTabControl2.SuspendLayout()
        Me.tabBilling.SuspendLayout()
        Me.tabCommands.SuspendLayout()
        Me.FlatGroupBox2.SuspendLayout()
        Me.FlatGroupBox1.SuspendLayout()
        Me.menuTermClients.SuspendLayout()
        Me.tabMembers.SuspendLayout()
        CType(Me.dataMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabServices.SuspendLayout()
        Me.FlatTabControl3.SuspendLayout()
        Me.tabSales.SuspendLayout()
        Me.FlatTabControl4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "PC.png")
        '
        'timerClock
        '
        Me.timerClock.Enabled = True
        Me.timerClock.Interval = 1000
        '
        'timerTimeLeft
        '
        Me.timerTimeLeft.Interval = 1000
        '
        'timerTotalTime
        '
        Me.timerTotalTime.Interval = 1000
        '
        'TblMembersBindingSource
        '
        Me.TblMembersBindingSource.DataMember = "tblMembers"
        Me.TblMembersBindingSource.DataSource = Me.ServerDataSet
        '
        'ServerDataSet
        '
        Me.ServerDataSet.DataSetName = "serverDataSet"
        Me.ServerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblMembersTableAdapter
        '
        Me.TblMembersTableAdapter.ClearBeforeFill = True
        '
        'FormSkin1s
        '
        Me.FormSkin1s.BackColor = System.Drawing.Color.White
        Me.FormSkin1s.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1s.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1s.Controls.Add(Me.FlatMax1)
        Me.FormSkin1s.Controls.Add(Me.cmdLogout)
        Me.FormSkin1s.Controls.Add(Me.alertHome)
        Me.FormSkin1s.Controls.Add(Me.cmdSettings)
        Me.FormSkin1s.Controls.Add(Me.statusMain)
        Me.FormSkin1s.Controls.Add(Me.FlatClose1)
        Me.FormSkin1s.Controls.Add(Me.FlatMini1)
        Me.FormSkin1s.Controls.Add(Me.FlatTabControl1)
        Me.FormSkin1s.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1s.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1s.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1s.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1s.HeaderMaximize = True
        Me.FormSkin1s.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1s.Name = "FormSkin1s"
        Me.FormSkin1s.Size = New System.Drawing.Size(1011, 678)
        Me.FormSkin1s.TabIndex = 1
        Me.FormSkin1s.TabStop = False
        Me.FormSkin1s.Text = "Simple CyberCafe Server 1.0"
        '
        'FlatMax1
        '
        Me.FlatMax1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMax1.BackColor = System.Drawing.Color.White
        Me.FlatMax1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMax1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMax1.Location = New System.Drawing.Point(947, 14)
        Me.FlatMax1.Name = "FlatMax1"
        Me.FlatMax1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMax1.TabIndex = 7
        Me.FlatMax1.Text = "FlatMax1"
        Me.FlatMax1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdLogout
        '
        Me.cmdLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLogout.BackColor = System.Drawing.Color.Transparent
        Me.cmdLogout.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.cmdLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLogout.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdLogout.Location = New System.Drawing.Point(894, 51)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.Rounded = False
        Me.cmdLogout.Size = New System.Drawing.Size(106, 32)
        Me.cmdLogout.TabIndex = 6
        Me.cmdLogout.Text = "Logout"
        Me.cmdLogout.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'alertHome
        '
        Me.alertHome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.alertHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.alertHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.alertHome.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.alertHome.kind = cybercafe_server.FlatAlertBox._Kind.Info
        Me.alertHome.Location = New System.Drawing.Point(4, 614)
        Me.alertHome.Name = "alertHome"
        Me.alertHome.Size = New System.Drawing.Size(1003, 42)
        Me.alertHome.TabIndex = 2
        Me.alertHome.Text = "Welcome to Simple CyberCafe Server 1.0"
        Me.alertHome.Visible = False
        '
        'cmdSettings
        '
        Me.cmdSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSettings.BackColor = System.Drawing.Color.Transparent
        Me.cmdSettings.BaseColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.cmdSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSettings.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdSettings.Location = New System.Drawing.Point(777, 51)
        Me.cmdSettings.Name = "cmdSettings"
        Me.cmdSettings.Rounded = False
        Me.cmdSettings.Size = New System.Drawing.Size(106, 32)
        Me.cmdSettings.TabIndex = 5
        Me.cmdSettings.Text = "Settings"
        Me.cmdSettings.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'statusMain
        '
        Me.statusMain.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.statusMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.statusMain.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.statusMain.ForeColor = System.Drawing.Color.White
        Me.statusMain.Location = New System.Drawing.Point(0, 655)
        Me.statusMain.Name = "statusMain"
        Me.statusMain.RectColor = System.Drawing.Color.Red
        Me.statusMain.ShowTimeDate = False
        Me.statusMain.Size = New System.Drawing.Size(1011, 23)
        Me.statusMain.TabIndex = 3
        Me.statusMain.Text = "Not Logged In"
        Me.statusMain.TextColor = System.Drawing.Color.White
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(981, 14)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 2
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(919, 14)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 1
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatTabControl1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.tabTerminal)
        Me.FlatTabControl1.Controls.Add(Me.tabMembers)
        Me.FlatTabControl1.Controls.Add(Me.tabServices)
        Me.FlatTabControl1.Controls.Add(Me.tabSales)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(0, 49)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(1011, 617)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 4
        '
        'tabTerminal
        '
        Me.tabTerminal.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabTerminal.Controls.Add(Me.FlatButton5)
        Me.tabTerminal.Controls.Add(Me.FlatButton4)
        Me.tabTerminal.Controls.Add(Me.FlatButton3)
        Me.tabTerminal.Controls.Add(Me.linkClear)
        Me.tabTerminal.Controls.Add(Me.FlatTextBox1)
        Me.tabTerminal.Controls.Add(Me.txtFilter)
        Me.tabTerminal.Controls.Add(Me.cmdRefreshClients)
        Me.tabTerminal.Controls.Add(Me.FlatTabControl2)
        Me.tabTerminal.Controls.Add(Me.listClients)
        Me.tabTerminal.Location = New System.Drawing.Point(4, 44)
        Me.tabTerminal.Name = "tabTerminal"
        Me.tabTerminal.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTerminal.Size = New System.Drawing.Size(1003, 569)
        Me.tabTerminal.TabIndex = 0
        Me.tabTerminal.Text = "Terminal"
        '
        'FlatButton5
        '
        Me.FlatButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FlatButton5.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton5.Location = New System.Drawing.Point(148, 474)
        Me.FlatButton5.Name = "FlatButton5"
        Me.FlatButton5.Rounded = False
        Me.FlatButton5.Size = New System.Drawing.Size(116, 32)
        Me.FlatButton5.TabIndex = 13
        Me.FlatButton5.Text = "Edit Client"
        Me.FlatButton5.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton4
        '
        Me.FlatButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton4.Location = New System.Drawing.Point(270, 474)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = False
        Me.FlatButton4.Size = New System.Drawing.Size(150, 32)
        Me.FlatButton4.TabIndex = 12
        Me.FlatButton4.Text = "Delete Client"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton3
        '
        Me.FlatButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(24, 474)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(116, 32)
        Me.FlatButton3.TabIndex = 11
        Me.FlatButton3.Text = "Add Client"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'linkClear
        '
        Me.linkClear.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.linkClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkClear.AutoSize = True
        Me.linkClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.linkClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkClear.LinkColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.linkClear.LinkVisited = True
        Me.linkClear.Location = New System.Drawing.Point(641, 23)
        Me.linkClear.Name = "linkClear"
        Me.linkClear.Size = New System.Drawing.Size(36, 16)
        Me.linkClear.TabIndex = 10
        Me.linkClear.TabStop = True
        Me.linkClear.Text = "clear"
        Me.linkClear.VisitedLinkColor = System.Drawing.Color.White
        '
        'FlatTextBox1
        '
        Me.FlatTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox1.Enabled = False
        Me.FlatTextBox1.Location = New System.Drawing.Point(24, 17)
        Me.FlatTextBox1.MaxLength = 32767
        Me.FlatTextBox1.Multiline = False
        Me.FlatTextBox1.Name = "FlatTextBox1"
        Me.FlatTextBox1.ReadOnly = True
        Me.FlatTextBox1.Size = New System.Drawing.Size(83, 29)
        Me.FlatTextBox1.TabIndex = 9
        Me.FlatTextBox1.Text = "Filter"
        Me.FlatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox1.TextColor = System.Drawing.Color.White
        Me.FlatTextBox1.UseSystemPasswordChar = False
        '
        'txtFilter
        '
        Me.txtFilter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilter.BackColor = System.Drawing.Color.Transparent
        Me.txtFilter.Location = New System.Drawing.Point(107, 17)
        Me.txtFilter.MaxLength = 32767
        Me.txtFilter.Multiline = False
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.ReadOnly = False
        Me.txtFilter.Size = New System.Drawing.Size(574, 29)
        Me.txtFilter.TabIndex = 8
        Me.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtFilter.TextColor = System.Drawing.Color.Silver
        Me.txtFilter.UseSystemPasswordChar = False
        '
        'cmdRefreshClients
        '
        Me.cmdRefreshClients.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRefreshClients.BackColor = System.Drawing.Color.Transparent
        Me.cmdRefreshClients.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdRefreshClients.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdRefreshClients.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdRefreshClients.Location = New System.Drawing.Point(574, 474)
        Me.cmdRefreshClients.Name = "cmdRefreshClients"
        Me.cmdRefreshClients.Rounded = False
        Me.cmdRefreshClients.Size = New System.Drawing.Size(106, 32)
        Me.cmdRefreshClients.TabIndex = 7
        Me.cmdRefreshClients.Text = "Refresh"
        Me.cmdRefreshClients.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatTabControl2
        '
        Me.FlatTabControl2.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatTabControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatTabControl2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl2.Controls.Add(Me.tabBilling)
        Me.FlatTabControl2.Controls.Add(Me.tabCommands)
        Me.FlatTabControl2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl2.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl2.Location = New System.Drawing.Point(686, 17)
        Me.FlatTabControl2.Name = "FlatTabControl2"
        Me.FlatTabControl2.SelectedIndex = 0
        Me.FlatTabControl2.Size = New System.Drawing.Size(312, 498)
        Me.FlatTabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl2.TabIndex = 1
        '
        'tabBilling
        '
        Me.tabBilling.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabBilling.Controls.Add(Me.linkShowMemberName)
        Me.tabBilling.Controls.Add(Me.linkViewItems)
        Me.tabBilling.Controls.Add(Me.Label11)
        Me.tabBilling.Controls.Add(Me.txtMemberName)
        Me.tabBilling.Controls.Add(Me.Label10)
        Me.tabBilling.Controls.Add(Me.txtTimeLeft)
        Me.tabBilling.Controls.Add(Me.Label9)
        Me.tabBilling.Controls.Add(Me.txtTimeNow)
        Me.tabBilling.Controls.Add(Me.Label8)
        Me.tabBilling.Controls.Add(Me.txtCharges)
        Me.tabBilling.Controls.Add(Me.Label7)
        Me.tabBilling.Controls.Add(Me.Label6)
        Me.tabBilling.Controls.Add(Me.txtTimeOut)
        Me.tabBilling.Controls.Add(Me.txtTotalTime)
        Me.tabBilling.Controls.Add(Me.cmdMembers)
        Me.tabBilling.Controls.Add(Me.cmdPrepaid)
        Me.tabBilling.Controls.Add(Me.Label5)
        Me.tabBilling.Controls.Add(Me.txtTimeIn)
        Me.tabBilling.Controls.Add(Me.Label4)
        Me.tabBilling.Controls.Add(Me.txtAccessLevel)
        Me.tabBilling.Controls.Add(Me.Label3)
        Me.tabBilling.Controls.Add(Me.txtStatus)
        Me.tabBilling.Controls.Add(Me.toggleOpen)
        Me.tabBilling.Controls.Add(Me.Label1)
        Me.tabBilling.Controls.Add(Me.Label2)
        Me.tabBilling.Controls.Add(Me.txtSelectedPC)
        Me.tabBilling.Location = New System.Drawing.Point(4, 44)
        Me.tabBilling.Name = "tabBilling"
        Me.tabBilling.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBilling.Size = New System.Drawing.Size(304, 450)
        Me.tabBilling.TabIndex = 0
        Me.tabBilling.Text = "Billing"
        '
        'linkShowMemberName
        '
        Me.linkShowMemberName.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.linkShowMemberName.AutoSize = True
        Me.linkShowMemberName.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.linkShowMemberName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkShowMemberName.LinkColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.linkShowMemberName.LinkVisited = True
        Me.linkShowMemberName.Location = New System.Drawing.Point(250, 333)
        Me.linkShowMemberName.Name = "linkShowMemberName"
        Me.linkShowMemberName.Size = New System.Drawing.Size(40, 16)
        Me.linkShowMemberName.TabIndex = 29
        Me.linkShowMemberName.TabStop = True
        Me.linkShowMemberName.Text = "Show"
        Me.linkShowMemberName.VisitedLinkColor = System.Drawing.Color.White
        '
        'linkViewItems
        '
        Me.linkViewItems.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.linkViewItems.AutoSize = True
        Me.linkViewItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.linkViewItems.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkViewItems.LinkColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.linkViewItems.LinkVisited = True
        Me.linkViewItems.Location = New System.Drawing.Point(218, 298)
        Me.linkViewItems.Name = "linkViewItems"
        Me.linkViewItems.Size = New System.Drawing.Size(72, 16)
        Me.linkViewItems.TabIndex = 14
        Me.linkViewItems.TabStop = True
        Me.linkViewItems.Text = "View Items"
        Me.linkViewItems.VisitedLinkColor = System.Drawing.Color.White
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(11, 332)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 19)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Member Name"
        '
        'txtMemberName
        '
        Me.txtMemberName.BackColor = System.Drawing.Color.Transparent
        Me.txtMemberName.Enabled = False
        Me.txtMemberName.Location = New System.Drawing.Point(118, 327)
        Me.txtMemberName.MaxLength = 32767
        Me.txtMemberName.Multiline = False
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.ReadOnly = True
        Me.txtMemberName.Size = New System.Drawing.Size(175, 29)
        Me.txtMemberName.TabIndex = 27
        Me.txtMemberName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtMemberName.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMemberName.UseSystemPasswordChar = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(11, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 19)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Time Left"
        '
        'txtTimeLeft
        '
        Me.txtTimeLeft.BackColor = System.Drawing.Color.Transparent
        Me.txtTimeLeft.Enabled = False
        Me.txtTimeLeft.Location = New System.Drawing.Point(118, 222)
        Me.txtTimeLeft.MaxLength = 32767
        Me.txtTimeLeft.Multiline = False
        Me.txtTimeLeft.Name = "txtTimeLeft"
        Me.txtTimeLeft.ReadOnly = True
        Me.txtTimeLeft.Size = New System.Drawing.Size(175, 29)
        Me.txtTimeLeft.TabIndex = 25
        Me.txtTimeLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTimeLeft.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTimeLeft.UseSystemPasswordChar = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(11, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 19)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Time Now"
        '
        'txtTimeNow
        '
        Me.txtTimeNow.BackColor = System.Drawing.Color.Transparent
        Me.txtTimeNow.Enabled = False
        Me.txtTimeNow.Location = New System.Drawing.Point(118, 117)
        Me.txtTimeNow.MaxLength = 32767
        Me.txtTimeNow.Multiline = False
        Me.txtTimeNow.Name = "txtTimeNow"
        Me.txtTimeNow.ReadOnly = True
        Me.txtTimeNow.Size = New System.Drawing.Size(175, 29)
        Me.txtTimeNow.TabIndex = 23
        Me.txtTimeNow.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTimeNow.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTimeNow.UseSystemPasswordChar = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(11, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 19)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Charges"
        '
        'txtCharges
        '
        Me.txtCharges.BackColor = System.Drawing.Color.Transparent
        Me.txtCharges.Enabled = False
        Me.txtCharges.Location = New System.Drawing.Point(118, 292)
        Me.txtCharges.MaxLength = 32767
        Me.txtCharges.Multiline = False
        Me.txtCharges.Name = "txtCharges"
        Me.txtCharges.ReadOnly = True
        Me.txtCharges.Size = New System.Drawing.Size(175, 29)
        Me.txtCharges.TabIndex = 21
        Me.txtCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtCharges.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCharges.UseSystemPasswordChar = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(11, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 19)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Total Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(11, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 19)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Time Out"
        '
        'txtTimeOut
        '
        Me.txtTimeOut.BackColor = System.Drawing.Color.Transparent
        Me.txtTimeOut.Enabled = False
        Me.txtTimeOut.Location = New System.Drawing.Point(118, 187)
        Me.txtTimeOut.MaxLength = 32767
        Me.txtTimeOut.Multiline = False
        Me.txtTimeOut.Name = "txtTimeOut"
        Me.txtTimeOut.ReadOnly = True
        Me.txtTimeOut.Size = New System.Drawing.Size(175, 29)
        Me.txtTimeOut.TabIndex = 17
        Me.txtTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTimeOut.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTimeOut.UseSystemPasswordChar = False
        '
        'txtTotalTime
        '
        Me.txtTotalTime.BackColor = System.Drawing.Color.Transparent
        Me.txtTotalTime.Enabled = False
        Me.txtTotalTime.Location = New System.Drawing.Point(118, 257)
        Me.txtTotalTime.MaxLength = 32767
        Me.txtTotalTime.Multiline = False
        Me.txtTotalTime.Name = "txtTotalTime"
        Me.txtTotalTime.ReadOnly = True
        Me.txtTotalTime.Size = New System.Drawing.Size(175, 29)
        Me.txtTotalTime.TabIndex = 19
        Me.txtTotalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTotalTime.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalTime.UseSystemPasswordChar = False
        '
        'cmdMembers
        '
        Me.cmdMembers.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdMembers.BackColor = System.Drawing.Color.Transparent
        Me.cmdMembers.BaseColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.cmdMembers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdMembers.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdMembers.Location = New System.Drawing.Point(160, 402)
        Me.cmdMembers.Name = "cmdMembers"
        Me.cmdMembers.Rounded = False
        Me.cmdMembers.Size = New System.Drawing.Size(133, 43)
        Me.cmdMembers.TabIndex = 16
        Me.cmdMembers.Text = "Members"
        Me.cmdMembers.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdPrepaid
        '
        Me.cmdPrepaid.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdPrepaid.BackColor = System.Drawing.Color.Transparent
        Me.cmdPrepaid.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdPrepaid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPrepaid.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdPrepaid.Location = New System.Drawing.Point(15, 402)
        Me.cmdPrepaid.Name = "cmdPrepaid"
        Me.cmdPrepaid.Rounded = False
        Me.cmdPrepaid.Size = New System.Drawing.Size(133, 43)
        Me.cmdPrepaid.TabIndex = 15
        Me.cmdPrepaid.Text = "Prepaid"
        Me.cmdPrepaid.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(11, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Time In"
        '
        'txtTimeIn
        '
        Me.txtTimeIn.BackColor = System.Drawing.Color.Transparent
        Me.txtTimeIn.Enabled = False
        Me.txtTimeIn.Location = New System.Drawing.Point(118, 152)
        Me.txtTimeIn.MaxLength = 32767
        Me.txtTimeIn.Multiline = False
        Me.txtTimeIn.Name = "txtTimeIn"
        Me.txtTimeIn.ReadOnly = True
        Me.txtTimeIn.Size = New System.Drawing.Size(175, 29)
        Me.txtTimeIn.TabIndex = 13
        Me.txtTimeIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTimeIn.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTimeIn.UseSystemPasswordChar = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(11, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 19)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Access Level"
        '
        'txtAccessLevel
        '
        Me.txtAccessLevel.BackColor = System.Drawing.Color.Transparent
        Me.txtAccessLevel.Enabled = False
        Me.txtAccessLevel.Location = New System.Drawing.Point(118, 82)
        Me.txtAccessLevel.MaxLength = 32767
        Me.txtAccessLevel.Multiline = False
        Me.txtAccessLevel.Name = "txtAccessLevel"
        Me.txtAccessLevel.ReadOnly = True
        Me.txtAccessLevel.Size = New System.Drawing.Size(175, 29)
        Me.txtAccessLevel.TabIndex = 11
        Me.txtAccessLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAccessLevel.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAccessLevel.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(11, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Status"
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.Transparent
        Me.txtStatus.Enabled = False
        Me.txtStatus.Location = New System.Drawing.Point(118, 47)
        Me.txtStatus.MaxLength = 32767
        Me.txtStatus.Multiline = False
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(175, 29)
        Me.txtStatus.TabIndex = 9
        Me.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtStatus.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtStatus.UseSystemPasswordChar = False
        '
        'toggleOpen
        '
        Me.toggleOpen.BackColor = System.Drawing.Color.Transparent
        Me.toggleOpen.Checked = False
        Me.toggleOpen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.toggleOpen.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.toggleOpen.Location = New System.Drawing.Point(118, 362)
        Me.toggleOpen.Name = "toggleOpen"
        Me.toggleOpen.Options = cybercafe_server.FlatToggle._Options.Style1
        Me.toggleOpen.Size = New System.Drawing.Size(76, 33)
        Me.toggleOpen.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 367)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Open"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Selected PC"
        '
        'txtSelectedPC
        '
        Me.txtSelectedPC.BackColor = System.Drawing.Color.Transparent
        Me.txtSelectedPC.Enabled = False
        Me.txtSelectedPC.Location = New System.Drawing.Point(118, 12)
        Me.txtSelectedPC.MaxLength = 32767
        Me.txtSelectedPC.Multiline = False
        Me.txtSelectedPC.Name = "txtSelectedPC"
        Me.txtSelectedPC.ReadOnly = True
        Me.txtSelectedPC.Size = New System.Drawing.Size(175, 29)
        Me.txtSelectedPC.TabIndex = 0
        Me.txtSelectedPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSelectedPC.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSelectedPC.UseSystemPasswordChar = False
        '
        'tabCommands
        '
        Me.tabCommands.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabCommands.Controls.Add(Me.FlatGroupBox2)
        Me.tabCommands.Controls.Add(Me.FlatGroupBox1)
        Me.tabCommands.Location = New System.Drawing.Point(4, 44)
        Me.tabCommands.Name = "tabCommands"
        Me.tabCommands.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCommands.Size = New System.Drawing.Size(304, 450)
        Me.tabCommands.TabIndex = 1
        Me.tabCommands.Text = "Commands"
        '
        'FlatGroupBox2
        '
        Me.FlatGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox2.Controls.Add(Me.cmdLoginAdmin)
        Me.FlatGroupBox2.Controls.Add(Me.cmdLoginStaff)
        Me.FlatGroupBox2.Controls.Add(Me.cmdUnlock)
        Me.FlatGroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.FlatGroupBox2.Name = "FlatGroupBox2"
        Me.FlatGroupBox2.ShowText = True
        Me.FlatGroupBox2.Size = New System.Drawing.Size(292, 152)
        Me.FlatGroupBox2.TabIndex = 2
        Me.FlatGroupBox2.Text = "Login"
        '
        'cmdLoginAdmin
        '
        Me.cmdLoginAdmin.BackColor = System.Drawing.Color.Transparent
        Me.cmdLoginAdmin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.cmdLoginAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLoginAdmin.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdLoginAdmin.Location = New System.Drawing.Point(150, 89)
        Me.cmdLoginAdmin.Name = "cmdLoginAdmin"
        Me.cmdLoginAdmin.Rounded = False
        Me.cmdLoginAdmin.Size = New System.Drawing.Size(122, 39)
        Me.cmdLoginAdmin.TabIndex = 7
        Me.cmdLoginAdmin.Text = "Admin"
        Me.cmdLoginAdmin.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdLoginStaff
        '
        Me.cmdLoginStaff.BackColor = System.Drawing.Color.Transparent
        Me.cmdLoginStaff.BaseColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.cmdLoginStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLoginStaff.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdLoginStaff.Location = New System.Drawing.Point(22, 89)
        Me.cmdLoginStaff.Name = "cmdLoginStaff"
        Me.cmdLoginStaff.Rounded = False
        Me.cmdLoginStaff.Size = New System.Drawing.Size(122, 39)
        Me.cmdLoginStaff.TabIndex = 6
        Me.cmdLoginStaff.Text = "Staff"
        Me.cmdLoginStaff.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdUnlock
        '
        Me.cmdUnlock.BackColor = System.Drawing.Color.Transparent
        Me.cmdUnlock.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdUnlock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdUnlock.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdUnlock.Location = New System.Drawing.Point(22, 44)
        Me.cmdUnlock.Name = "cmdUnlock"
        Me.cmdUnlock.Rounded = False
        Me.cmdUnlock.Size = New System.Drawing.Size(250, 39)
        Me.cmdUnlock.TabIndex = 5
        Me.cmdUnlock.Text = "Unlock"
        Me.cmdUnlock.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox1.Controls.Add(Me.FlatButton12)
        Me.FlatGroupBox1.Controls.Add(Me.FlatButton11)
        Me.FlatGroupBox1.Controls.Add(Me.FlatButton10)
        Me.FlatGroupBox1.Controls.Add(Me.FlatButton9)
        Me.FlatGroupBox1.Controls.Add(Me.FlatButton2)
        Me.FlatGroupBox1.Controls.Add(Me.FlatButton1)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(6, 140)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(295, 275)
        Me.FlatGroupBox1.TabIndex = 1
        Me.FlatGroupBox1.Text = "Control"
        '
        'FlatButton12
        '
        Me.FlatButton12.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton12.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.FlatButton12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton12.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton12.Location = New System.Drawing.Point(21, 207)
        Me.FlatButton12.Name = "FlatButton12"
        Me.FlatButton12.Rounded = False
        Me.FlatButton12.Size = New System.Drawing.Size(250, 39)
        Me.FlatButton12.TabIndex = 5
        Me.FlatButton12.Text = "Shutdown All PC"
        Me.FlatButton12.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton11
        '
        Me.FlatButton11.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton11.BaseColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.FlatButton11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton11.Location = New System.Drawing.Point(22, 104)
        Me.FlatButton11.Name = "FlatButton11"
        Me.FlatButton11.Rounded = False
        Me.FlatButton11.Size = New System.Drawing.Size(250, 39)
        Me.FlatButton11.TabIndex = 4
        Me.FlatButton11.Text = "Restart All PC"
        Me.FlatButton11.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton10
        '
        Me.FlatButton10.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton10.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.FlatButton10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton10.Location = New System.Drawing.Point(150, 149)
        Me.FlatButton10.Name = "FlatButton10"
        Me.FlatButton10.Rounded = False
        Me.FlatButton10.Size = New System.Drawing.Size(122, 52)
        Me.FlatButton10.TabIndex = 3
        Me.FlatButton10.Text = "Shutdown Selected PC"
        Me.FlatButton10.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton9
        '
        Me.FlatButton9.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton9.BaseColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.FlatButton9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton9.Location = New System.Drawing.Point(150, 46)
        Me.FlatButton9.Name = "FlatButton9"
        Me.FlatButton9.Rounded = False
        Me.FlatButton9.Size = New System.Drawing.Size(122, 52)
        Me.FlatButton9.TabIndex = 2
        Me.FlatButton9.Text = "Restart Locked PC"
        Me.FlatButton9.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(22, 149)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(122, 52)
        Me.FlatButton2.TabIndex = 1
        Me.FlatButton2.Text = "Shutdown Selected PC"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(22, 46)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(122, 52)
        Me.FlatButton1.TabIndex = 0
        Me.FlatButton1.Text = "Restart Selected PC"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'listClients
        '
        Me.listClients.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listClients.BackgroundImageTiled = True
        Me.listClients.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listClients.ContextMenuStrip = Me.menuTermClients
        Me.listClients.FullRowSelect = True
        Me.listClients.GridLines = True
        Me.listClients.LargeImageList = Me.ImageList1
        Me.listClients.Location = New System.Drawing.Point(24, 53)
        Me.listClients.MultiSelect = False
        Me.listClients.Name = "listClients"
        Me.listClients.Size = New System.Drawing.Size(656, 411)
        Me.listClients.TabIndex = 0
        Me.listClients.UseCompatibleStateImageBehavior = False
        '
        'menuTermClients
        '
        Me.menuTermClients.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.menuTermClients.ForeColor = System.Drawing.Color.White
        Me.menuTermClients.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenSessionToolStripMenuItem, Me.TurnOffClientToolStripMenuItem, Me.SendMessageToolStripMenuItem, Me.ToolStripSeparator1, Me.CloseSessionToolStripMenuItem})
        Me.menuTermClients.Name = "menuTermClients"
        Me.menuTermClients.ShowImageMargin = False
        Me.menuTermClients.Size = New System.Drawing.Size(133, 98)
        '
        'OpenSessionToolStripMenuItem
        '
        Me.OpenSessionToolStripMenuItem.Name = "OpenSessionToolStripMenuItem"
        Me.OpenSessionToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.OpenSessionToolStripMenuItem.Text = "Open Session"
        '
        'TurnOffClientToolStripMenuItem
        '
        Me.TurnOffClientToolStripMenuItem.Name = "TurnOffClientToolStripMenuItem"
        Me.TurnOffClientToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.TurnOffClientToolStripMenuItem.Text = "Transfer Session"
        '
        'SendMessageToolStripMenuItem
        '
        Me.SendMessageToolStripMenuItem.Name = "SendMessageToolStripMenuItem"
        Me.SendMessageToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.SendMessageToolStripMenuItem.Text = "Send Message"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(129, 6)
        '
        'CloseSessionToolStripMenuItem
        '
        Me.CloseSessionToolStripMenuItem.Name = "CloseSessionToolStripMenuItem"
        Me.CloseSessionToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.CloseSessionToolStripMenuItem.Text = "Close Session"
        '
        'tabMembers
        '
        Me.tabMembers.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabMembers.Controls.Add(Me.cmdDeleteSelectedMember)
        Me.tabMembers.Controls.Add(Me.cmdSendMessages)
        Me.tabMembers.Controls.Add(Me.cmdEditMembershipTypes)
        Me.tabMembers.Controls.Add(Me.cmdAddMember)
        Me.tabMembers.Controls.Add(Me.cmdEditSelectedMember)
        Me.tabMembers.Controls.Add(Me.dataMembers)
        Me.tabMembers.Controls.Add(Me.Label12)
        Me.tabMembers.Controls.Add(Me.PictureBox1)
        Me.tabMembers.Controls.Add(Me.LinkLabel1)
        Me.tabMembers.Controls.Add(Me.FlatTextBox2)
        Me.tabMembers.Controls.Add(Me.FlatTextBox3)
        Me.tabMembers.Location = New System.Drawing.Point(4, 44)
        Me.tabMembers.Name = "tabMembers"
        Me.tabMembers.Size = New System.Drawing.Size(1003, 569)
        Me.tabMembers.TabIndex = 2
        Me.tabMembers.Text = "Members"
        '
        'cmdDeleteSelectedMember
        '
        Me.cmdDeleteSelectedMember.BackColor = System.Drawing.Color.Transparent
        Me.cmdDeleteSelectedMember.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.cmdDeleteSelectedMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDeleteSelectedMember.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdDeleteSelectedMember.Location = New System.Drawing.Point(20, 466)
        Me.cmdDeleteSelectedMember.Name = "cmdDeleteSelectedMember"
        Me.cmdDeleteSelectedMember.Rounded = False
        Me.cmdDeleteSelectedMember.Size = New System.Drawing.Size(195, 32)
        Me.cmdDeleteSelectedMember.TabIndex = 21
        Me.cmdDeleteSelectedMember.Text = "Delete Selected Member"
        Me.cmdDeleteSelectedMember.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdSendMessages
        '
        Me.cmdSendMessages.BackColor = System.Drawing.Color.Transparent
        Me.cmdSendMessages.BaseColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.cmdSendMessages.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSendMessages.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdSendMessages.Location = New System.Drawing.Point(20, 428)
        Me.cmdSendMessages.Name = "cmdSendMessages"
        Me.cmdSendMessages.Rounded = False
        Me.cmdSendMessages.Size = New System.Drawing.Size(195, 32)
        Me.cmdSendMessages.TabIndex = 20
        Me.cmdSendMessages.Text = "Send Messages"
        Me.cmdSendMessages.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdEditMembershipTypes
        '
        Me.cmdEditMembershipTypes.BackColor = System.Drawing.Color.Transparent
        Me.cmdEditMembershipTypes.BaseColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.cmdEditMembershipTypes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEditMembershipTypes.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdEditMembershipTypes.Location = New System.Drawing.Point(20, 390)
        Me.cmdEditMembershipTypes.Name = "cmdEditMembershipTypes"
        Me.cmdEditMembershipTypes.Rounded = False
        Me.cmdEditMembershipTypes.Size = New System.Drawing.Size(195, 32)
        Me.cmdEditMembershipTypes.TabIndex = 19
        Me.cmdEditMembershipTypes.Text = "Membership Types"
        Me.cmdEditMembershipTypes.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdAddMember
        '
        Me.cmdAddMember.BackColor = System.Drawing.Color.Transparent
        Me.cmdAddMember.BaseColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.cmdAddMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAddMember.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdAddMember.Location = New System.Drawing.Point(20, 352)
        Me.cmdAddMember.Name = "cmdAddMember"
        Me.cmdAddMember.Rounded = False
        Me.cmdAddMember.Size = New System.Drawing.Size(195, 32)
        Me.cmdAddMember.TabIndex = 18
        Me.cmdAddMember.Text = "Add New Member"
        Me.cmdAddMember.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdEditSelectedMember
        '
        Me.cmdEditSelectedMember.BackColor = System.Drawing.Color.Transparent
        Me.cmdEditSelectedMember.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdEditSelectedMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEditSelectedMember.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdEditSelectedMember.Location = New System.Drawing.Point(20, 273)
        Me.cmdEditSelectedMember.Name = "cmdEditSelectedMember"
        Me.cmdEditSelectedMember.Rounded = False
        Me.cmdEditSelectedMember.Size = New System.Drawing.Size(195, 32)
        Me.cmdEditSelectedMember.TabIndex = 17
        Me.cmdEditSelectedMember.Text = "Edit Selected Member"
        Me.cmdEditSelectedMember.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'dataMembers
        '
        Me.dataMembers.AllowUserToAddRows = False
        Me.dataMembers.AllowUserToDeleteRows = False
        Me.dataMembers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataMembers.AutoGenerateColumns = False
        Me.dataMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataMembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDNumberDataGridViewTextBoxColumn, Me.MemberNameDataGridViewTextBoxColumn, Me.MemberDOBDataGridViewTextBoxColumn, Me.BalanceDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.IsLoggedInDataGridViewCheckBoxColumn})
        Me.dataMembers.DataSource = Me.TblMembersBindingSource
        Me.dataMembers.Location = New System.Drawing.Point(229, 64)
        Me.dataMembers.MultiSelect = False
        Me.dataMembers.Name = "dataMembers"
        Me.dataMembers.ReadOnly = True
        Me.dataMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataMembers.Size = New System.Drawing.Size(752, 434)
        Me.dataMembers.TabIndex = 16
        '
        'IDNumberDataGridViewTextBoxColumn
        '
        Me.IDNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IDNumberDataGridViewTextBoxColumn.DataPropertyName = "ID_Number"
        Me.IDNumberDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDNumberDataGridViewTextBoxColumn.Name = "IDNumberDataGridViewTextBoxColumn"
        Me.IDNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MemberNameDataGridViewTextBoxColumn
        '
        Me.MemberNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MemberNameDataGridViewTextBoxColumn.DataPropertyName = "Member_Name"
        Me.MemberNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.MemberNameDataGridViewTextBoxColumn.Name = "MemberNameDataGridViewTextBoxColumn"
        Me.MemberNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MemberDOBDataGridViewTextBoxColumn
        '
        Me.MemberDOBDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MemberDOBDataGridViewTextBoxColumn.DataPropertyName = "Member_DOB"
        Me.MemberDOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.MemberDOBDataGridViewTextBoxColumn.Name = "MemberDOBDataGridViewTextBoxColumn"
        Me.MemberDOBDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemberDOBDataGridViewTextBoxColumn.ToolTipText = "Date of Birth"
        '
        'BalanceDataGridViewTextBoxColumn
        '
        Me.BalanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BalanceDataGridViewTextBoxColumn.DataPropertyName = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.HeaderText = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.Name = "BalanceDataGridViewTextBoxColumn"
        Me.BalanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.FillWeight = 90.0!
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IsLoggedInDataGridViewCheckBoxColumn
        '
        Me.IsLoggedInDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IsLoggedInDataGridViewCheckBoxColumn.DataPropertyName = "IsLoggedIn"
        Me.IsLoggedInDataGridViewCheckBoxColumn.HeaderText = "Logged In"
        Me.IsLoggedInDataGridViewCheckBoxColumn.Name = "IsLoggedInDataGridViewCheckBoxColumn"
        Me.IsLoggedInDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(92, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 19)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Picture"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cybercafe_server.My.Resources.Resources.generic_avatar
        Me.PictureBox1.Location = New System.Drawing.Point(20, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 195)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.LinkLabel1.LinkVisited = True
        Me.LinkLabel1.Location = New System.Drawing.Point(939, 34)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(36, 16)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "clear"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.White
        '
        'FlatTextBox2
        '
        Me.FlatTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox2.Enabled = False
        Me.FlatTextBox2.Location = New System.Drawing.Point(229, 28)
        Me.FlatTextBox2.MaxLength = 32767
        Me.FlatTextBox2.Multiline = False
        Me.FlatTextBox2.Name = "FlatTextBox2"
        Me.FlatTextBox2.ReadOnly = True
        Me.FlatTextBox2.Size = New System.Drawing.Size(83, 29)
        Me.FlatTextBox2.TabIndex = 12
        Me.FlatTextBox2.Text = "Filter"
        Me.FlatTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox2.TextColor = System.Drawing.Color.White
        Me.FlatTextBox2.UseSystemPasswordChar = False
        '
        'FlatTextBox3
        '
        Me.FlatTextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatTextBox3.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox3.Location = New System.Drawing.Point(311, 28)
        Me.FlatTextBox3.MaxLength = 32767
        Me.FlatTextBox3.Multiline = False
        Me.FlatTextBox3.Name = "FlatTextBox3"
        Me.FlatTextBox3.ReadOnly = False
        Me.FlatTextBox3.Size = New System.Drawing.Size(670, 29)
        Me.FlatTextBox3.TabIndex = 11
        Me.FlatTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox3.TextColor = System.Drawing.Color.Silver
        Me.FlatTextBox3.UseSystemPasswordChar = False
        '
        'tabServices
        '
        Me.tabServices.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabServices.Controls.Add(Me.FlatTabControl3)
        Me.tabServices.Location = New System.Drawing.Point(4, 44)
        Me.tabServices.Name = "tabServices"
        Me.tabServices.Padding = New System.Windows.Forms.Padding(3)
        Me.tabServices.Size = New System.Drawing.Size(1003, 569)
        Me.tabServices.TabIndex = 1
        Me.tabServices.Text = "Services"
        '
        'FlatTabControl3
        '
        Me.FlatTabControl3.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.FlatTabControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatTabControl3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl3.Controls.Add(Me.tabFnD)
        Me.FlatTabControl3.Controls.Add(Me.tabPrinting)
        Me.FlatTabControl3.Controls.Add(Me.tabPrepaidCodes)
        Me.FlatTabControl3.Controls.Add(Me.tabMiscItems)
        Me.FlatTabControl3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl3.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl3.Location = New System.Drawing.Point(8, 6)
        Me.FlatTabControl3.Name = "FlatTabControl3"
        Me.FlatTabControl3.SelectedIndex = 0
        Me.FlatTabControl3.Size = New System.Drawing.Size(989, 509)
        Me.FlatTabControl3.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl3.TabIndex = 5
        '
        'tabFnD
        '
        Me.tabFnD.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabFnD.Location = New System.Drawing.Point(4, 44)
        Me.tabFnD.Name = "tabFnD"
        Me.tabFnD.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFnD.Size = New System.Drawing.Size(981, 461)
        Me.tabFnD.TabIndex = 0
        Me.tabFnD.Text = "Foods and Drinks"
        '
        'tabPrinting
        '
        Me.tabPrinting.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabPrinting.Location = New System.Drawing.Point(4, 44)
        Me.tabPrinting.Name = "tabPrinting"
        Me.tabPrinting.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrinting.Size = New System.Drawing.Size(981, 461)
        Me.tabPrinting.TabIndex = 1
        Me.tabPrinting.Text = "Printing Services"
        '
        'tabPrepaidCodes
        '
        Me.tabPrepaidCodes.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabPrepaidCodes.Location = New System.Drawing.Point(4, 44)
        Me.tabPrepaidCodes.Name = "tabPrepaidCodes"
        Me.tabPrepaidCodes.Size = New System.Drawing.Size(981, 461)
        Me.tabPrepaidCodes.TabIndex = 2
        Me.tabPrepaidCodes.Text = "Prepaid Codes"
        '
        'tabMiscItems
        '
        Me.tabMiscItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabMiscItems.Location = New System.Drawing.Point(4, 44)
        Me.tabMiscItems.Name = "tabMiscItems"
        Me.tabMiscItems.Size = New System.Drawing.Size(981, 461)
        Me.tabMiscItems.TabIndex = 3
        Me.tabMiscItems.Text = "Misc Items"
        '
        'tabSales
        '
        Me.tabSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabSales.Controls.Add(Me.FlatTabControl4)
        Me.tabSales.Location = New System.Drawing.Point(4, 44)
        Me.tabSales.Name = "tabSales"
        Me.tabSales.Size = New System.Drawing.Size(1003, 569)
        Me.tabSales.TabIndex = 3
        Me.tabSales.Text = "Sales"
        '
        'FlatTabControl4
        '
        Me.FlatTabControl4.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.FlatTabControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatTabControl4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl4.Controls.Add(Me.TabPage1)
        Me.FlatTabControl4.Controls.Add(Me.TabPage5)
        Me.FlatTabControl4.Controls.Add(Me.TabPage6)
        Me.FlatTabControl4.Controls.Add(Me.TabPage7)
        Me.FlatTabControl4.Controls.Add(Me.TabPage2)
        Me.FlatTabControl4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl4.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl4.Location = New System.Drawing.Point(8, 6)
        Me.FlatTabControl4.Name = "FlatTabControl4"
        Me.FlatTabControl4.SelectedIndex = 0
        Me.FlatTabControl4.Size = New System.Drawing.Size(989, 509)
        Me.FlatTabControl4.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl4.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(981, 461)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Daily Report"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage5.Location = New System.Drawing.Point(4, 44)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(981, 461)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Weekly Report"
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage6.Location = New System.Drawing.Point(4, 44)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(981, 461)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "Monthly Report"
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage7.Location = New System.Drawing.Point(4, 44)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(981, 461)
        Me.TabPage7.TabIndex = 3
        Me.TabPage7.Text = "Annual Report"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(981, 461)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Export"
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 678)
        Me.Controls.Add(Me.FormSkin1s)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CyberCafe Server 1.0"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.TblMembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSkin1s.ResumeLayout(False)
        Me.FlatTabControl1.ResumeLayout(False)
        Me.tabTerminal.ResumeLayout(False)
        Me.tabTerminal.PerformLayout()
        Me.FlatTabControl2.ResumeLayout(False)
        Me.tabBilling.ResumeLayout(False)
        Me.tabBilling.PerformLayout()
        Me.tabCommands.ResumeLayout(False)
        Me.FlatGroupBox2.ResumeLayout(False)
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.menuTermClients.ResumeLayout(False)
        Me.tabMembers.ResumeLayout(False)
        Me.tabMembers.PerformLayout()
        CType(Me.dataMembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabServices.ResumeLayout(False)
        Me.FlatTabControl3.ResumeLayout(False)
        Me.tabSales.ResumeLayout(False)
        Me.FlatTabControl4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1s As cybercafe_server.FormSkin
    Friend WithEvents FlatClose1 As cybercafe_server.FlatClose
    Friend WithEvents FlatMini1 As cybercafe_server.FlatMini
    Friend WithEvents statusMain As cybercafe_server.FlatStatusBar
    Friend WithEvents FlatTabControl1 As cybercafe_server.FlatTabControl
    Friend WithEvents tabTerminal As System.Windows.Forms.TabPage
    Friend WithEvents tabServices As System.Windows.Forms.TabPage
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents listClients As System.Windows.Forms.ListView
    Friend WithEvents tabMembers As System.Windows.Forms.TabPage
    Friend WithEvents cmdSettings As cybercafe_server.FlatButton
    Friend WithEvents FlatTabControl2 As cybercafe_server.FlatTabControl
    Friend WithEvents tabBilling As System.Windows.Forms.TabPage
    Friend WithEvents tabCommands As System.Windows.Forms.TabPage
    Friend WithEvents alertHome As cybercafe_server.FlatAlertBox
    Friend WithEvents txtSelectedPC As cybercafe_server.FlatTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents toggleOpen As cybercafe_server.FlatToggle
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdLogout As cybercafe_server.FlatButton
    Friend WithEvents menuTermClients As cybercafe_server.FlatContextMenuStrip
    Friend WithEvents OpenSessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnOffClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendMessageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseSessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRefreshClients As cybercafe_server.FlatButton
    Friend WithEvents txtFilter As cybercafe_server.FlatTextBox
    Friend WithEvents FlatTextBox1 As cybercafe_server.FlatTextBox
    Friend WithEvents linkClear As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtStatus As cybercafe_server.FlatTextBox
    Friend WithEvents cmdMembers As cybercafe_server.FlatButton
    Friend WithEvents cmdPrepaid As cybercafe_server.FlatButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTimeIn As cybercafe_server.FlatTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAccessLevel As cybercafe_server.FlatTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTimeOut As cybercafe_server.FlatTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotalTime As cybercafe_server.FlatTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCharges As cybercafe_server.FlatTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTimeNow As cybercafe_server.FlatTextBox
    Friend WithEvents timerClock As System.Windows.Forms.Timer
    Friend WithEvents FlatButton5 As cybercafe_server.FlatButton
    Friend WithEvents FlatButton4 As cybercafe_server.FlatButton
    Friend WithEvents FlatButton3 As cybercafe_server.FlatButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTimeLeft As cybercafe_server.FlatTextBox
    Friend WithEvents timerTimeLeft As System.Windows.Forms.Timer
    Friend WithEvents FlatGroupBox1 As cybercafe_server.FlatGroupBox
    Friend WithEvents FlatButton2 As cybercafe_server.FlatButton
    Friend WithEvents FlatButton1 As cybercafe_server.FlatButton
    Friend WithEvents FlatGroupBox2 As cybercafe_server.FlatGroupBox
    Friend WithEvents cmdLoginAdmin As cybercafe_server.FlatButton
    Friend WithEvents cmdLoginStaff As cybercafe_server.FlatButton
    Friend WithEvents cmdUnlock As cybercafe_server.FlatButton
    Friend WithEvents FlatButton12 As cybercafe_server.FlatButton
    Friend WithEvents FlatButton11 As cybercafe_server.FlatButton
    Friend WithEvents FlatButton10 As cybercafe_server.FlatButton
    Friend WithEvents FlatButton9 As cybercafe_server.FlatButton
    Friend WithEvents timerTotalTime As System.Windows.Forms.Timer
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMemberName As cybercafe_server.FlatTextBox
    Friend WithEvents FlatTabControl3 As cybercafe_server.FlatTabControl
    Friend WithEvents tabFnD As System.Windows.Forms.TabPage
    Friend WithEvents tabPrinting As System.Windows.Forms.TabPage
    Friend WithEvents tabPrepaidCodes As System.Windows.Forms.TabPage
    Friend WithEvents linkViewItems As System.Windows.Forms.LinkLabel
    Friend WithEvents tabMiscItems As System.Windows.Forms.TabPage
    Friend WithEvents linkShowMemberName As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents FlatTextBox2 As cybercafe_server.FlatTextBox
    Friend WithEvents FlatTextBox3 As cybercafe_server.FlatTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdAddMember As cybercafe_server.FlatButton
    Friend WithEvents cmdEditSelectedMember As cybercafe_server.FlatButton
    Friend WithEvents dataMembers As System.Windows.Forms.DataGridView
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents ServerDataSet As cybercafe_server.serverDataSet
    Friend WithEvents TblMembersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblMembersTableAdapter As cybercafe_server.serverDataSetTableAdapters.tblMembersTableAdapter
    Friend WithEvents cmdDeleteSelectedMember As cybercafe_server.FlatButton
    Friend WithEvents cmdSendMessages As cybercafe_server.FlatButton
    Friend WithEvents cmdEditMembershipTypes As cybercafe_server.FlatButton
    Friend WithEvents tabSales As System.Windows.Forms.TabPage
    Friend WithEvents FlatTabControl4 As cybercafe_server.FlatTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents FlatMax1 As cybercafe_server.FlatMax
    Friend WithEvents IDNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberDOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsLoggedInDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn

End Class
