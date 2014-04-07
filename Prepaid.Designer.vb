<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrepaid
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
        Me.timerTimeLeft = New System.Windows.Forms.Timer(Me.components)
        Me.timerTimeIn = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New cybercafe_server.FormSkin()
        Me.txtSelectedPC = New cybercafe_server.FlatTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTimeLeft = New cybercafe_server.FlatTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTimeIn = New cybercafe_server.FlatTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTimeOut = New cybercafe_server.FlatTextBox()
        Me.alertPrepaid = New cybercafe_server.FlatAlertBox()
        Me.statusPrepaid = New cybercafe_server.FlatStatusBar()
        Me.FlatTabControl1 = New cybercafe_server.FlatTabControl()
        Me.tabTime = New System.Windows.Forms.TabPage()
        Me.cmdReset = New cybercafe_server.FlatButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNewTimeOut = New cybercafe_server.FlatTextBox()
        Me.cmdTopUp = New cybercafe_server.FlatButton()
        Me.comboDiscounts = New cybercafe_server.FlatComboBox()
        Me.checkDiscount = New cybercafe_server.FlatCheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCharge = New cybercafe_server.FlatTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAddTime = New cybercafe_server.FlatTextBox()
        Me.cmdAdd5Mins = New cybercafe_server.FlatButton()
        Me.cmdAdd10Mins = New cybercafe_server.FlatButton()
        Me.cmdAdd30Mins = New cybercafe_server.FlatButton()
        Me.cmdAdd1Hour = New cybercafe_server.FlatButton()
        Me.tabCash = New System.Windows.Forms.TabPage()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.FlatTextBox1 = New cybercafe_server.FlatTextBox()
        Me.txtCurrency = New cybercafe_server.FlatTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCashNewTimeOut = New cybercafe_server.FlatTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCashAddTime = New cybercafe_server.FlatTextBox()
        Me.cmdCash = New cybercafe_server.FlatButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tabPrepaidCard = New System.Windows.Forms.TabPage()
        Me.cmdClose = New cybercafe_server.FlatButton()
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.tabTime.SuspendLayout()
        Me.tabCash.SuspendLayout()
        Me.SuspendLayout()
        '
        'timerTimeLeft
        '
        Me.timerTimeLeft.Interval = 1000
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.txtSelectedPC)
        Me.FormSkin1.Controls.Add(Me.Label3)
        Me.FormSkin1.Controls.Add(Me.txtTimeLeft)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.txtTimeIn)
        Me.FormSkin1.Controls.Add(Me.Label5)
        Me.FormSkin1.Controls.Add(Me.Label4)
        Me.FormSkin1.Controls.Add(Me.txtTimeOut)
        Me.FormSkin1.Controls.Add(Me.alertPrepaid)
        Me.FormSkin1.Controls.Add(Me.statusPrepaid)
        Me.FormSkin1.Controls.Add(Me.FlatTabControl1)
        Me.FormSkin1.Controls.Add(Me.cmdClose)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(583, 497)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Add Prepaid"
        '
        'txtSelectedPC
        '
        Me.txtSelectedPC.BackColor = System.Drawing.Color.Transparent
        Me.txtSelectedPC.Enabled = False
        Me.txtSelectedPC.Location = New System.Drawing.Point(143, 116)
        Me.txtSelectedPC.MaxLength = 32767
        Me.txtSelectedPC.Multiline = False
        Me.txtSelectedPC.Name = "txtSelectedPC"
        Me.txtSelectedPC.ReadOnly = True
        Me.txtSelectedPC.Size = New System.Drawing.Size(226, 29)
        Me.txtSelectedPC.TabIndex = 2
        Me.txtSelectedPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSelectedPC.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSelectedPC.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(25, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 21)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Selected PC"
        '
        'txtTimeLeft
        '
        Me.txtTimeLeft.BackColor = System.Drawing.Color.Transparent
        Me.txtTimeLeft.Enabled = False
        Me.txtTimeLeft.Location = New System.Drawing.Point(143, 233)
        Me.txtTimeLeft.MaxLength = 32767
        Me.txtTimeLeft.Multiline = False
        Me.txtTimeLeft.Name = "txtTimeLeft"
        Me.txtTimeLeft.ReadOnly = True
        Me.txtTimeLeft.Size = New System.Drawing.Size(226, 29)
        Me.txtTimeLeft.TabIndex = 16
        Me.txtTimeLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTimeLeft.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTimeLeft.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 21)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Time Left"
        '
        'txtTimeIn
        '
        Me.txtTimeIn.BackColor = System.Drawing.Color.Transparent
        Me.txtTimeIn.Enabled = False
        Me.txtTimeIn.Location = New System.Drawing.Point(143, 154)
        Me.txtTimeIn.MaxLength = 32767
        Me.txtTimeIn.Multiline = False
        Me.txtTimeIn.Name = "txtTimeIn"
        Me.txtTimeIn.ReadOnly = True
        Me.txtTimeIn.Size = New System.Drawing.Size(226, 29)
        Me.txtTimeIn.TabIndex = 20
        Me.txtTimeIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTimeIn.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTimeIn.UseSystemPasswordChar = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(25, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 21)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Time Out"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(25, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 21)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Time In"
        '
        'txtTimeOut
        '
        Me.txtTimeOut.BackColor = System.Drawing.Color.Transparent
        Me.txtTimeOut.Enabled = False
        Me.txtTimeOut.Location = New System.Drawing.Point(143, 193)
        Me.txtTimeOut.MaxLength = 32767
        Me.txtTimeOut.Multiline = False
        Me.txtTimeOut.Name = "txtTimeOut"
        Me.txtTimeOut.ReadOnly = True
        Me.txtTimeOut.Size = New System.Drawing.Size(226, 29)
        Me.txtTimeOut.TabIndex = 22
        Me.txtTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTimeOut.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTimeOut.UseSystemPasswordChar = False
        '
        'alertPrepaid
        '
        Me.alertPrepaid.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.alertPrepaid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.alertPrepaid.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.alertPrepaid.kind = cybercafe_server.FlatAlertBox._Kind.Success
        Me.alertPrepaid.Location = New System.Drawing.Point(4, 432)
        Me.alertPrepaid.Name = "alertPrepaid"
        Me.alertPrepaid.Size = New System.Drawing.Size(575, 42)
        Me.alertPrepaid.TabIndex = 3
        Me.alertPrepaid.Visible = False
        '
        'statusPrepaid
        '
        Me.statusPrepaid.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.statusPrepaid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.statusPrepaid.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.statusPrepaid.ForeColor = System.Drawing.Color.White
        Me.statusPrepaid.Location = New System.Drawing.Point(0, 474)
        Me.statusPrepaid.Name = "statusPrepaid"
        Me.statusPrepaid.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.statusPrepaid.ShowTimeDate = False
        Me.statusPrepaid.Size = New System.Drawing.Size(583, 23)
        Me.statusPrepaid.TabIndex = 2
        Me.statusPrepaid.TextColor = System.Drawing.Color.White
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatTabControl1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.tabTime)
        Me.FlatTabControl1.Controls.Add(Me.tabCash)
        Me.FlatTabControl1.Controls.Add(Me.tabPrepaidCard)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(0, 49)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(583, 436)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 1
        '
        'tabTime
        '
        Me.tabTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabTime.Controls.Add(Me.cmdReset)
        Me.tabTime.Controls.Add(Me.Label8)
        Me.tabTime.Controls.Add(Me.txtNewTimeOut)
        Me.tabTime.Controls.Add(Me.cmdTopUp)
        Me.tabTime.Controls.Add(Me.comboDiscounts)
        Me.tabTime.Controls.Add(Me.checkDiscount)
        Me.tabTime.Controls.Add(Me.Label7)
        Me.tabTime.Controls.Add(Me.Label6)
        Me.tabTime.Controls.Add(Me.txtCharge)
        Me.tabTime.Controls.Add(Me.Label2)
        Me.tabTime.Controls.Add(Me.txtAddTime)
        Me.tabTime.Controls.Add(Me.cmdAdd5Mins)
        Me.tabTime.Controls.Add(Me.cmdAdd10Mins)
        Me.tabTime.Controls.Add(Me.cmdAdd30Mins)
        Me.tabTime.Controls.Add(Me.cmdAdd1Hour)
        Me.tabTime.Location = New System.Drawing.Point(4, 44)
        Me.tabTime.Name = "tabTime"
        Me.tabTime.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTime.Size = New System.Drawing.Size(575, 388)
        Me.tabTime.TabIndex = 0
        Me.tabTime.Text = "Time"
        '
        'cmdReset
        '
        Me.cmdReset.BackColor = System.Drawing.Color.Transparent
        Me.cmdReset.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.cmdReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdReset.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdReset.Location = New System.Drawing.Point(386, 219)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Rounded = False
        Me.cmdReset.Size = New System.Drawing.Size(169, 28)
        Me.cmdReset.TabIndex = 32
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(21, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 21)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "New Time Out"
        '
        'txtNewTimeOut
        '
        Me.txtNewTimeOut.BackColor = System.Drawing.Color.Transparent
        Me.txtNewTimeOut.Enabled = False
        Me.txtNewTimeOut.Location = New System.Drawing.Point(139, 262)
        Me.txtNewTimeOut.MaxLength = 32767
        Me.txtNewTimeOut.Multiline = False
        Me.txtNewTimeOut.Name = "txtNewTimeOut"
        Me.txtNewTimeOut.ReadOnly = True
        Me.txtNewTimeOut.Size = New System.Drawing.Size(226, 29)
        Me.txtNewTimeOut.TabIndex = 30
        Me.txtNewTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtNewTimeOut.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNewTimeOut.UseSystemPasswordChar = False
        '
        'cmdTopUp
        '
        Me.cmdTopUp.BackColor = System.Drawing.Color.Transparent
        Me.cmdTopUp.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdTopUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdTopUp.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdTopUp.Location = New System.Drawing.Point(386, 266)
        Me.cmdTopUp.Name = "cmdTopUp"
        Me.cmdTopUp.Rounded = False
        Me.cmdTopUp.Size = New System.Drawing.Size(169, 54)
        Me.cmdTopUp.TabIndex = 29
        Me.cmdTopUp.Text = "Add Prepaid"
        Me.cmdTopUp.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'comboDiscounts
        '
        Me.comboDiscounts.AutoCompleteCustomSource.AddRange(New String() {"2 Hour - RM 3.50", "3 Hour - RM 5.00", "4 Hour - RM 6.50"})
        Me.comboDiscounts.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.comboDiscounts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.comboDiscounts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboDiscounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboDiscounts.Enabled = False
        Me.comboDiscounts.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.comboDiscounts.ForeColor = System.Drawing.Color.White
        Me.comboDiscounts.FormattingEnabled = True
        Me.comboDiscounts.HoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.comboDiscounts.ItemHeight = 18
        Me.comboDiscounts.Items.AddRange(New Object() {"N/A", "2 Hour - RM 3.50", "3 Hour - RM 5.00", "4 Hour - RM 6.50"})
        Me.comboDiscounts.Location = New System.Drawing.Point(386, 44)
        Me.comboDiscounts.Name = "comboDiscounts"
        Me.comboDiscounts.Size = New System.Drawing.Size(169, 24)
        Me.comboDiscounts.TabIndex = 28
        '
        'checkDiscount
        '
        Me.checkDiscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.checkDiscount.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.checkDiscount.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.checkDiscount.Checked = False
        Me.checkDiscount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checkDiscount.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.checkDiscount.Location = New System.Drawing.Point(386, 16)
        Me.checkDiscount.Name = "checkDiscount"
        Me.checkDiscount.Options = cybercafe_server.FlatCheckBox._Options.Style1
        Me.checkDiscount.Size = New System.Drawing.Size(112, 22)
        Me.checkDiscount.TabIndex = 2
        Me.checkDiscount.Text = "Apply Discount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(436, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 19)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Quick Add"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(21, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 21)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Charge"
        '
        'txtCharge
        '
        Me.txtCharge.BackColor = System.Drawing.Color.Transparent
        Me.txtCharge.Enabled = False
        Me.txtCharge.Location = New System.Drawing.Point(139, 221)
        Me.txtCharge.MaxLength = 32767
        Me.txtCharge.Multiline = False
        Me.txtCharge.Name = "txtCharge"
        Me.txtCharge.ReadOnly = True
        Me.txtCharge.Size = New System.Drawing.Size(226, 29)
        Me.txtCharge.TabIndex = 24
        Me.txtCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtCharge.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCharge.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 21)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Add"
        '
        'txtAddTime
        '
        Me.txtAddTime.BackColor = System.Drawing.Color.Transparent
        Me.txtAddTime.Enabled = False
        Me.txtAddTime.Location = New System.Drawing.Point(139, 180)
        Me.txtAddTime.MaxLength = 32767
        Me.txtAddTime.Multiline = False
        Me.txtAddTime.Name = "txtAddTime"
        Me.txtAddTime.ReadOnly = True
        Me.txtAddTime.Size = New System.Drawing.Size(226, 29)
        Me.txtAddTime.TabIndex = 18
        Me.txtAddTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAddTime.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAddTime.UseSystemPasswordChar = False
        '
        'cmdAdd5Mins
        '
        Me.cmdAdd5Mins.BackColor = System.Drawing.Color.Transparent
        Me.cmdAdd5Mins.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdAdd5Mins.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAdd5Mins.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdAdd5Mins.Location = New System.Drawing.Point(386, 190)
        Me.cmdAdd5Mins.Name = "cmdAdd5Mins"
        Me.cmdAdd5Mins.Rounded = False
        Me.cmdAdd5Mins.Size = New System.Drawing.Size(169, 28)
        Me.cmdAdd5Mins.TabIndex = 15
        Me.cmdAdd5Mins.Text = "+ 5 Minutes"
        Me.cmdAdd5Mins.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdAdd10Mins
        '
        Me.cmdAdd10Mins.BackColor = System.Drawing.Color.Transparent
        Me.cmdAdd10Mins.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdAdd10Mins.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAdd10Mins.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdAdd10Mins.Location = New System.Drawing.Point(386, 161)
        Me.cmdAdd10Mins.Name = "cmdAdd10Mins"
        Me.cmdAdd10Mins.Rounded = False
        Me.cmdAdd10Mins.Size = New System.Drawing.Size(169, 28)
        Me.cmdAdd10Mins.TabIndex = 14
        Me.cmdAdd10Mins.Text = "+ 10 Minutes"
        Me.cmdAdd10Mins.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdAdd30Mins
        '
        Me.cmdAdd30Mins.BackColor = System.Drawing.Color.Transparent
        Me.cmdAdd30Mins.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdAdd30Mins.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAdd30Mins.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdAdd30Mins.Location = New System.Drawing.Point(386, 132)
        Me.cmdAdd30Mins.Name = "cmdAdd30Mins"
        Me.cmdAdd30Mins.Rounded = False
        Me.cmdAdd30Mins.Size = New System.Drawing.Size(169, 28)
        Me.cmdAdd30Mins.TabIndex = 13
        Me.cmdAdd30Mins.Text = "+ 30 Minutes"
        Me.cmdAdd30Mins.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdAdd1Hour
        '
        Me.cmdAdd1Hour.BackColor = System.Drawing.Color.Transparent
        Me.cmdAdd1Hour.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdAdd1Hour.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAdd1Hour.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdAdd1Hour.Location = New System.Drawing.Point(386, 103)
        Me.cmdAdd1Hour.Name = "cmdAdd1Hour"
        Me.cmdAdd1Hour.Rounded = False
        Me.cmdAdd1Hour.Size = New System.Drawing.Size(169, 28)
        Me.cmdAdd1Hour.TabIndex = 12
        Me.cmdAdd1Hour.Text = "+ 1 Hour"
        Me.cmdAdd1Hour.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'tabCash
        '
        Me.tabCash.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabCash.Controls.Add(Me.txtCash)
        Me.tabCash.Controls.Add(Me.FlatTextBox1)
        Me.tabCash.Controls.Add(Me.txtCurrency)
        Me.tabCash.Controls.Add(Me.Label11)
        Me.tabCash.Controls.Add(Me.txtCashNewTimeOut)
        Me.tabCash.Controls.Add(Me.Label10)
        Me.tabCash.Controls.Add(Me.txtCashAddTime)
        Me.tabCash.Controls.Add(Me.cmdCash)
        Me.tabCash.Controls.Add(Me.Label9)
        Me.tabCash.Location = New System.Drawing.Point(4, 44)
        Me.tabCash.Name = "tabCash"
        Me.tabCash.Size = New System.Drawing.Size(575, 388)
        Me.tabCash.TabIndex = 2
        Me.tabCash.Text = "Cash"
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtCash.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCash.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.ForeColor = System.Drawing.Color.Silver
        Me.txtCash.Location = New System.Drawing.Point(456, 91)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(89, 32)
        Me.txtCash.TabIndex = 42
        '
        'FlatTextBox1
        '
        Me.FlatTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox1.Enabled = False
        Me.FlatTextBox1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatTextBox1.Location = New System.Drawing.Point(451, 86)
        Me.FlatTextBox1.MaxLength = 32767
        Me.FlatTextBox1.Multiline = False
        Me.FlatTextBox1.Name = "FlatTextBox1"
        Me.FlatTextBox1.ReadOnly = True
        Me.FlatTextBox1.Size = New System.Drawing.Size(101, 43)
        Me.FlatTextBox1.TabIndex = 43
        Me.FlatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox1.UseSystemPasswordChar = False
        '
        'txtCurrency
        '
        Me.txtCurrency.BackColor = System.Drawing.Color.Transparent
        Me.txtCurrency.Enabled = False
        Me.txtCurrency.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrency.Location = New System.Drawing.Point(385, 86)
        Me.txtCurrency.MaxLength = 32767
        Me.txtCurrency.Multiline = False
        Me.txtCurrency.Name = "txtCurrency"
        Me.txtCurrency.ReadOnly = True
        Me.txtCurrency.Size = New System.Drawing.Size(60, 43)
        Me.txtCurrency.TabIndex = 35
        Me.txtCurrency.Text = "RM"
        Me.txtCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCurrency.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCurrency.UseSystemPasswordChar = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(21, 225)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 21)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "New Time Out"
        '
        'txtCashNewTimeOut
        '
        Me.txtCashNewTimeOut.BackColor = System.Drawing.Color.Transparent
        Me.txtCashNewTimeOut.Enabled = False
        Me.txtCashNewTimeOut.Location = New System.Drawing.Point(139, 221)
        Me.txtCashNewTimeOut.MaxLength = 32767
        Me.txtCashNewTimeOut.Multiline = False
        Me.txtCashNewTimeOut.Name = "txtCashNewTimeOut"
        Me.txtCashNewTimeOut.ReadOnly = True
        Me.txtCashNewTimeOut.Size = New System.Drawing.Size(226, 29)
        Me.txtCashNewTimeOut.TabIndex = 33
        Me.txtCashNewTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtCashNewTimeOut.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCashNewTimeOut.UseSystemPasswordChar = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(21, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 21)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Add"
        '
        'txtCashAddTime
        '
        Me.txtCashAddTime.BackColor = System.Drawing.Color.Transparent
        Me.txtCashAddTime.Enabled = False
        Me.txtCashAddTime.Location = New System.Drawing.Point(139, 180)
        Me.txtCashAddTime.MaxLength = 32767
        Me.txtCashAddTime.Multiline = False
        Me.txtCashAddTime.Name = "txtCashAddTime"
        Me.txtCashAddTime.ReadOnly = True
        Me.txtCashAddTime.Size = New System.Drawing.Size(226, 29)
        Me.txtCashAddTime.TabIndex = 31
        Me.txtCashAddTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtCashAddTime.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCashAddTime.UseSystemPasswordChar = False
        '
        'cmdCash
        '
        Me.cmdCash.BackColor = System.Drawing.Color.Transparent
        Me.cmdCash.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdCash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCash.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdCash.Location = New System.Drawing.Point(385, 136)
        Me.cmdCash.Name = "cmdCash"
        Me.cmdCash.Rounded = False
        Me.cmdCash.Size = New System.Drawing.Size(169, 54)
        Me.cmdCash.TabIndex = 30
        Me.cmdCash.Text = "Add Prepaid"
        Me.cmdCash.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(450, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 21)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Cash"
        '
        'tabPrepaidCard
        '
        Me.tabPrepaidCard.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabPrepaidCard.Location = New System.Drawing.Point(4, 44)
        Me.tabPrepaidCard.Name = "tabPrepaidCard"
        Me.tabPrepaidCard.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrepaidCard.Size = New System.Drawing.Size(575, 388)
        Me.tabPrepaidCard.TabIndex = 1
        Me.tabPrepaidCard.Text = "Prepaid Card"
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Transparent
        Me.cmdClose.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdClose.Location = New System.Drawing.Point(488, 11)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Rounded = False
        Me.cmdClose.Size = New System.Drawing.Size(83, 32)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "Close"
        Me.cmdClose.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'frmPrepaid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 497)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPrepaid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prepaid"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.FlatTabControl1.ResumeLayout(False)
        Me.tabTime.ResumeLayout(False)
        Me.tabTime.PerformLayout()
        Me.tabCash.ResumeLayout(False)
        Me.tabCash.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As cybercafe_server.FormSkin
    Friend WithEvents cmdClose As cybercafe_server.FlatButton
    Friend WithEvents FlatTabControl1 As cybercafe_server.FlatTabControl
    Friend WithEvents tabTime As System.Windows.Forms.TabPage
    Friend WithEvents tabPrepaidCard As System.Windows.Forms.TabPage
    Friend WithEvents txtSelectedPC As cybercafe_server.FlatTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdAdd1Hour As cybercafe_server.FlatButton
    Friend WithEvents cmdAdd5Mins As cybercafe_server.FlatButton
    Friend WithEvents cmdAdd10Mins As cybercafe_server.FlatButton
    Friend WithEvents cmdAdd30Mins As cybercafe_server.FlatButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTimeLeft As cybercafe_server.FlatTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAddTime As cybercafe_server.FlatTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCharge As cybercafe_server.FlatTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTimeOut As cybercafe_server.FlatTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTimeIn As cybercafe_server.FlatTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents comboDiscounts As cybercafe_server.FlatComboBox
    Friend WithEvents checkDiscount As cybercafe_server.FlatCheckBox
    Friend WithEvents statusPrepaid As cybercafe_server.FlatStatusBar
    Friend WithEvents cmdTopUp As cybercafe_server.FlatButton
    Friend WithEvents alertPrepaid As cybercafe_server.FlatAlertBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNewTimeOut As cybercafe_server.FlatTextBox
    Friend WithEvents cmdReset As cybercafe_server.FlatButton
    Friend WithEvents tabCash As System.Windows.Forms.TabPage
    Friend WithEvents timerTimeLeft As System.Windows.Forms.Timer
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCashNewTimeOut As cybercafe_server.FlatTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCashAddTime As cybercafe_server.FlatTextBox
    Friend WithEvents cmdCash As cybercafe_server.FlatButton
    Friend WithEvents txtCurrency As cybercafe_server.FlatTextBox
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents FlatTextBox1 As cybercafe_server.FlatTextBox
    Friend WithEvents timerTimeIn As System.Windows.Forms.Timer
End Class
