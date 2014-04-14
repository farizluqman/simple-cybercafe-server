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
        Me.components = New System.ComponentModel.Container()
        Me.FormSkin1 = New cybercafe_server.FormSkin()
        Me.cmdClose = New cybercafe_server.FlatButton()
        Me.statusSettings = New cybercafe_server.FlatStatusBar()
        Me.FlatTabControl1 = New cybercafe_server.FlatTabControl()
        Me.tabRates = New System.Windows.Forms.TabPage()
        Me.FlatTabControl2 = New cybercafe_server.FlatTabControl()
        Me.tabMembers = New System.Windows.Forms.TabPage()
        Me.dataMembers = New System.Windows.Forms.DataGridView()
        Me.IDNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberDOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsLoggedInDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TblMembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServerDataSet = New cybercafe_server.serverDataSet()
        Me.linkClear = New System.Windows.Forms.LinkLabel()
        Me.FlatTextBox1 = New cybercafe_server.FlatTextBox()
        Me.txtFilter = New cybercafe_server.FlatTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdDeleteMember = New cybercafe_server.FlatButton()
        Me.cmdEditMember = New cybercafe_server.FlatButton()
        Me.cmdAddMembers = New cybercafe_server.FlatButton()
        Me.tabDiscounts = New System.Windows.Forms.TabPage()
        Me.tabTax = New System.Windows.Forms.TabPage()
        Me.tabClients = New System.Windows.Forms.TabPage()
        Me.tabEmployees = New System.Windows.Forms.TabPage()
        Me.tabPOS = New System.Windows.Forms.TabPage()
        Me.tabDatabase = New System.Windows.Forms.TabPage()
        Me.tabServer = New System.Windows.Forms.TabPage()
        Me.txtPort = New cybercafe_server.FlatTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TblMembersTableAdapter = New cybercafe_server.serverDataSetTableAdapters.tblMembersTableAdapter()
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.tabRates.SuspendLayout()
        Me.FlatTabControl2.SuspendLayout()
        Me.tabMembers.SuspendLayout()
        CType(Me.dataMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FlatTabControl1.Controls.Add(Me.tabRates)
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
        'tabRates
        '
        Me.tabRates.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabRates.Controls.Add(Me.FlatTabControl2)
        Me.tabRates.Location = New System.Drawing.Point(4, 44)
        Me.tabRates.Name = "tabRates"
        Me.tabRates.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRates.Size = New System.Drawing.Size(917, 421)
        Me.tabRates.TabIndex = 0
        Me.tabRates.Text = "Rates"
        '
        'FlatTabControl2
        '
        Me.FlatTabControl2.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.FlatTabControl2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl2.Controls.Add(Me.tabMembers)
        Me.FlatTabControl2.Controls.Add(Me.tabDiscounts)
        Me.FlatTabControl2.Controls.Add(Me.tabTax)
        Me.FlatTabControl2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl2.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl2.Location = New System.Drawing.Point(8, 6)
        Me.FlatTabControl2.Name = "FlatTabControl2"
        Me.FlatTabControl2.SelectedIndex = 0
        Me.FlatTabControl2.Size = New System.Drawing.Size(901, 402)
        Me.FlatTabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl2.TabIndex = 4
        '
        'tabMembers
        '
        Me.tabMembers.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabMembers.Controls.Add(Me.dataMembers)
        Me.tabMembers.Controls.Add(Me.linkClear)
        Me.tabMembers.Controls.Add(Me.FlatTextBox1)
        Me.tabMembers.Controls.Add(Me.txtFilter)
        Me.tabMembers.Controls.Add(Me.PictureBox1)
        Me.tabMembers.Controls.Add(Me.cmdDeleteMember)
        Me.tabMembers.Controls.Add(Me.cmdEditMember)
        Me.tabMembers.Controls.Add(Me.cmdAddMembers)
        Me.tabMembers.Location = New System.Drawing.Point(4, 44)
        Me.tabMembers.Name = "tabMembers"
        Me.tabMembers.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMembers.Size = New System.Drawing.Size(893, 354)
        Me.tabMembers.TabIndex = 0
        Me.tabMembers.Text = "Members"
        '
        'dataMembers
        '
        Me.dataMembers.AutoGenerateColumns = False
        Me.dataMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataMembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDNumberDataGridViewTextBoxColumn, Me.MemberNameDataGridViewTextBoxColumn, Me.MemberDOBDataGridViewTextBoxColumn, Me.BalanceDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.IsLoggedInDataGridViewCheckBoxColumn})
        Me.dataMembers.DataSource = Me.TblMembersBindingSource
        Me.dataMembers.Location = New System.Drawing.Point(166, 44)
        Me.dataMembers.MultiSelect = False
        Me.dataMembers.Name = "dataMembers"
        Me.dataMembers.ReadOnly = True
        Me.dataMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataMembers.Size = New System.Drawing.Size(571, 291)
        Me.dataMembers.TabIndex = 14
        '
        'IDNumberDataGridViewTextBoxColumn
        '
        Me.IDNumberDataGridViewTextBoxColumn.DataPropertyName = "ID_Number"
        Me.IDNumberDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDNumberDataGridViewTextBoxColumn.Name = "IDNumberDataGridViewTextBoxColumn"
        Me.IDNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MemberNameDataGridViewTextBoxColumn
        '
        Me.MemberNameDataGridViewTextBoxColumn.DataPropertyName = "Member_Name"
        Me.MemberNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.MemberNameDataGridViewTextBoxColumn.Name = "MemberNameDataGridViewTextBoxColumn"
        Me.MemberNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemberNameDataGridViewTextBoxColumn.Width = 134
        '
        'MemberDOBDataGridViewTextBoxColumn
        '
        Me.MemberDOBDataGridViewTextBoxColumn.DataPropertyName = "Member_DOB"
        Me.MemberDOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.MemberDOBDataGridViewTextBoxColumn.Name = "MemberDOBDataGridViewTextBoxColumn"
        Me.MemberDOBDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BalanceDataGridViewTextBoxColumn
        '
        Me.BalanceDataGridViewTextBoxColumn.DataPropertyName = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.HeaderText = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.Name = "BalanceDataGridViewTextBoxColumn"
        Me.BalanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IsLoggedInDataGridViewCheckBoxColumn
        '
        Me.IsLoggedInDataGridViewCheckBoxColumn.DataPropertyName = "IsLoggedIn"
        Me.IsLoggedInDataGridViewCheckBoxColumn.HeaderText = "Logged In"
        Me.IsLoggedInDataGridViewCheckBoxColumn.Name = "IsLoggedInDataGridViewCheckBoxColumn"
        Me.IsLoggedInDataGridViewCheckBoxColumn.ReadOnly = True
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
        'linkClear
        '
        Me.linkClear.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.linkClear.AutoSize = True
        Me.linkClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.linkClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkClear.LinkColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.linkClear.LinkVisited = True
        Me.linkClear.Location = New System.Drawing.Point(691, 15)
        Me.linkClear.Name = "linkClear"
        Me.linkClear.Size = New System.Drawing.Size(36, 16)
        Me.linkClear.TabIndex = 13
        Me.linkClear.TabStop = True
        Me.linkClear.Text = "clear"
        Me.linkClear.VisitedLinkColor = System.Drawing.Color.White
        '
        'FlatTextBox1
        '
        Me.FlatTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox1.Enabled = False
        Me.FlatTextBox1.Location = New System.Drawing.Point(166, 9)
        Me.FlatTextBox1.MaxLength = 32767
        Me.FlatTextBox1.Multiline = False
        Me.FlatTextBox1.Name = "FlatTextBox1"
        Me.FlatTextBox1.ReadOnly = True
        Me.FlatTextBox1.Size = New System.Drawing.Size(56, 29)
        Me.FlatTextBox1.TabIndex = 12
        Me.FlatTextBox1.Text = "Filter"
        Me.FlatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox1.TextColor = System.Drawing.Color.White
        Me.FlatTextBox1.UseSystemPasswordChar = False
        '
        'txtFilter
        '
        Me.txtFilter.BackColor = System.Drawing.Color.Transparent
        Me.txtFilter.Location = New System.Drawing.Point(222, 9)
        Me.txtFilter.MaxLength = 32767
        Me.txtFilter.Multiline = False
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.ReadOnly = False
        Me.txtFilter.Size = New System.Drawing.Size(515, 29)
        Me.txtFilter.TabIndex = 11
        Me.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtFilter.TextColor = System.Drawing.Color.Silver
        Me.txtFilter.UseSystemPasswordChar = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cybercafe_server.My.Resources.Resources.generic_avatar
        Me.PictureBox1.Location = New System.Drawing.Point(13, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'cmdDeleteMember
        '
        Me.cmdDeleteMember.BackColor = System.Drawing.Color.Transparent
        Me.cmdDeleteMember.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.cmdDeleteMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDeleteMember.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdDeleteMember.Location = New System.Drawing.Point(743, 120)
        Me.cmdDeleteMember.Name = "cmdDeleteMember"
        Me.cmdDeleteMember.Rounded = False
        Me.cmdDeleteMember.Size = New System.Drawing.Size(144, 32)
        Me.cmdDeleteMember.TabIndex = 6
        Me.cmdDeleteMember.Text = "Delete Member"
        Me.cmdDeleteMember.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdEditMember
        '
        Me.cmdEditMember.BackColor = System.Drawing.Color.Transparent
        Me.cmdEditMember.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdEditMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEditMember.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdEditMember.Location = New System.Drawing.Point(743, 82)
        Me.cmdEditMember.Name = "cmdEditMember"
        Me.cmdEditMember.Rounded = False
        Me.cmdEditMember.Size = New System.Drawing.Size(144, 32)
        Me.cmdEditMember.TabIndex = 5
        Me.cmdEditMember.Text = "Edit Membership"
        Me.cmdEditMember.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdAddMembers
        '
        Me.cmdAddMembers.BackColor = System.Drawing.Color.Transparent
        Me.cmdAddMembers.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdAddMembers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAddMembers.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdAddMembers.Location = New System.Drawing.Point(743, 44)
        Me.cmdAddMembers.Name = "cmdAddMembers"
        Me.cmdAddMembers.Rounded = False
        Me.cmdAddMembers.Size = New System.Drawing.Size(144, 32)
        Me.cmdAddMembers.TabIndex = 4
        Me.cmdAddMembers.Text = "Add Members"
        Me.cmdAddMembers.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'tabDiscounts
        '
        Me.tabDiscounts.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabDiscounts.Location = New System.Drawing.Point(4, 44)
        Me.tabDiscounts.Name = "tabDiscounts"
        Me.tabDiscounts.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDiscounts.Size = New System.Drawing.Size(893, 354)
        Me.tabDiscounts.TabIndex = 1
        Me.tabDiscounts.Text = "Discounts"
        '
        'tabTax
        '
        Me.tabTax.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabTax.Location = New System.Drawing.Point(4, 44)
        Me.tabTax.Name = "tabTax"
        Me.tabTax.Size = New System.Drawing.Size(893, 354)
        Me.tabTax.TabIndex = 2
        Me.tabTax.Text = "Tax"
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
        'TblMembersTableAdapter
        '
        Me.TblMembersTableAdapter.ClearBeforeFill = True
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
        Me.tabRates.ResumeLayout(False)
        Me.FlatTabControl2.ResumeLayout(False)
        Me.tabMembers.ResumeLayout(False)
        Me.tabMembers.PerformLayout()
        CType(Me.dataMembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabServer.ResumeLayout(False)
        Me.tabServer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As cybercafe_server.FormSkin
    Friend WithEvents FlatTabControl1 As cybercafe_server.FlatTabControl
    Friend WithEvents tabRates As System.Windows.Forms.TabPage
    Friend WithEvents tabServer As System.Windows.Forms.TabPage
    Friend WithEvents statusSettings As cybercafe_server.FlatStatusBar
    Friend WithEvents cmdClose As cybercafe_server.FlatButton
    Friend WithEvents tabEmployees As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tabDatabase As System.Windows.Forms.TabPage
    Friend WithEvents txtPort As cybercafe_server.FlatTextBox
    Friend WithEvents tabClients As System.Windows.Forms.TabPage
    Friend WithEvents FlatTabControl2 As cybercafe_server.FlatTabControl
    Friend WithEvents tabMembers As System.Windows.Forms.TabPage
    Friend WithEvents tabDiscounts As System.Windows.Forms.TabPage
    Friend WithEvents tabTax As System.Windows.Forms.TabPage
    Friend WithEvents tabPOS As System.Windows.Forms.TabPage
    Friend WithEvents cmdDeleteMember As cybercafe_server.FlatButton
    Friend WithEvents cmdEditMember As cybercafe_server.FlatButton
    Friend WithEvents cmdAddMembers As cybercafe_server.FlatButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents linkClear As System.Windows.Forms.LinkLabel
    Friend WithEvents FlatTextBox1 As cybercafe_server.FlatTextBox
    Friend WithEvents txtFilter As cybercafe_server.FlatTextBox
    Friend WithEvents dataMembers As System.Windows.Forms.DataGridView
    Friend WithEvents ServerDataSet As cybercafe_server.serverDataSet
    Friend WithEvents TblMembersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblMembersTableAdapter As cybercafe_server.serverDataSetTableAdapters.tblMembersTableAdapter
    Friend WithEvents IDNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberDOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsLoggedInDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
