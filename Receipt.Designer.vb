<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceipt
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
        Me.timerFixPayment = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New cybercafe_server.FormSkin()
        Me.FlatTextBox1 = New cybercafe_server.FlatTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.toggleFree = New cybercafe_server.FlatToggle()
        Me.txtChangeDueCurrency = New cybercafe_server.FlatTextBox()
        Me.txtPayment = New cybercafe_server.FlatTextBox()
        Me.txtCharge = New cybercafe_server.FlatTextBox()
        Me.txtChargeCurrency = New cybercafe_server.FlatTextBox()
        Me.txtPaymentCurrency = New cybercafe_server.FlatTextBox()
        Me.cmdAllClear = New cybercafe_server.FlatButton()
        Me.cmdOk = New cybercafe_server.FlatButton()
        Me.cmdStartCents = New cybercafe_server.FlatButton()
        Me.cmdPay0 = New cybercafe_server.FlatButton()
        Me.cmdPay9 = New cybercafe_server.FlatButton()
        Me.cmdPay8 = New cybercafe_server.FlatButton()
        Me.cmdPay7 = New cybercafe_server.FlatButton()
        Me.cmdPay6 = New cybercafe_server.FlatButton()
        Me.cmdPay5 = New cybercafe_server.FlatButton()
        Me.cmdPay4 = New cybercafe_server.FlatButton()
        Me.cmdPay3 = New cybercafe_server.FlatButton()
        Me.cmdPay2 = New cybercafe_server.FlatButton()
        Me.cmdPay1 = New cybercafe_server.FlatButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtChangeDue = New cybercafe_server.FlatTextBox()
        Me.statusReceipt = New cybercafe_server.FlatStatusBar()
        Me.tableReceipt = New System.Windows.Forms.DataGridView()
        Me.columnItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnTax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnMember = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCharge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FormSkin1.SuspendLayout()
        CType(Me.tableReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timerFixPayment
        '
        Me.timerFixPayment.Enabled = True
        Me.timerFixPayment.Interval = 1000
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatTextBox1)
        Me.FormSkin1.Controls.Add(Me.Label3)
        Me.FormSkin1.Controls.Add(Me.toggleFree)
        Me.FormSkin1.Controls.Add(Me.txtChangeDueCurrency)
        Me.FormSkin1.Controls.Add(Me.txtPayment)
        Me.FormSkin1.Controls.Add(Me.txtCharge)
        Me.FormSkin1.Controls.Add(Me.txtChargeCurrency)
        Me.FormSkin1.Controls.Add(Me.txtPaymentCurrency)
        Me.FormSkin1.Controls.Add(Me.cmdAllClear)
        Me.FormSkin1.Controls.Add(Me.cmdOk)
        Me.FormSkin1.Controls.Add(Me.cmdStartCents)
        Me.FormSkin1.Controls.Add(Me.cmdPay0)
        Me.FormSkin1.Controls.Add(Me.cmdPay9)
        Me.FormSkin1.Controls.Add(Me.cmdPay8)
        Me.FormSkin1.Controls.Add(Me.cmdPay7)
        Me.FormSkin1.Controls.Add(Me.cmdPay6)
        Me.FormSkin1.Controls.Add(Me.cmdPay5)
        Me.FormSkin1.Controls.Add(Me.cmdPay4)
        Me.FormSkin1.Controls.Add(Me.cmdPay3)
        Me.FormSkin1.Controls.Add(Me.cmdPay2)
        Me.FormSkin1.Controls.Add(Me.cmdPay1)
        Me.FormSkin1.Controls.Add(Me.Label2)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.txtChangeDue)
        Me.FormSkin1.Controls.Add(Me.statusReceipt)
        Me.FormSkin1.Controls.Add(Me.tableReceipt)
        Me.FormSkin1.Controls.Add(Me.Label7)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(748, 606)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Receipt"
        '
        'FlatTextBox1
        '
        Me.FlatTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox1.Enabled = False
        Me.FlatTextBox1.Location = New System.Drawing.Point(59, 466)
        Me.FlatTextBox1.MaxLength = 32767
        Me.FlatTextBox1.Multiline = True
        Me.FlatTextBox1.Name = "FlatTextBox1"
        Me.FlatTextBox1.ReadOnly = True
        Me.FlatTextBox1.Size = New System.Drawing.Size(350, 46)
        Me.FlatTextBox1.TabIndex = 56
        Me.FlatTextBox1.Text = "Warning: Marking un-paid invoices as paid will result in running short of money"
        Me.FlatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox1.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(142, 530)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 21)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Mark as Paid"
        '
        'toggleFree
        '
        Me.toggleFree.BackColor = System.Drawing.Color.Transparent
        Me.toggleFree.Checked = False
        Me.toggleFree.Cursor = System.Windows.Forms.Cursors.Hand
        Me.toggleFree.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.toggleFree.Location = New System.Drawing.Point(247, 524)
        Me.toggleFree.Name = "toggleFree"
        Me.toggleFree.Options = cybercafe_server.FlatToggle._Options.Style2
        Me.toggleFree.Size = New System.Drawing.Size(76, 33)
        Me.toggleFree.TabIndex = 54
        Me.toggleFree.Text = "toggleFree"
        '
        'txtChangeDueCurrency
        '
        Me.txtChangeDueCurrency.BackColor = System.Drawing.Color.Transparent
        Me.txtChangeDueCurrency.Enabled = False
        Me.txtChangeDueCurrency.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChangeDueCurrency.Location = New System.Drawing.Point(474, 429)
        Me.txtChangeDueCurrency.MaxLength = 32767
        Me.txtChangeDueCurrency.Multiline = False
        Me.txtChangeDueCurrency.Name = "txtChangeDueCurrency"
        Me.txtChangeDueCurrency.ReadOnly = True
        Me.txtChangeDueCurrency.Size = New System.Drawing.Size(90, 54)
        Me.txtChangeDueCurrency.TabIndex = 53
        Me.txtChangeDueCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtChangeDueCurrency.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtChangeDueCurrency.UseSystemPasswordChar = False
        '
        'txtPayment
        '
        Me.txtPayment.BackColor = System.Drawing.Color.Transparent
        Me.txtPayment.Enabled = False
        Me.txtPayment.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayment.Location = New System.Drawing.Point(564, 333)
        Me.txtPayment.MaxLength = 32767
        Me.txtPayment.Multiline = False
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.ReadOnly = True
        Me.txtPayment.Size = New System.Drawing.Size(133, 54)
        Me.txtPayment.TabIndex = 34
        Me.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPayment.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPayment.UseSystemPasswordChar = False
        '
        'txtCharge
        '
        Me.txtCharge.BackColor = System.Drawing.Color.Transparent
        Me.txtCharge.Enabled = False
        Me.txtCharge.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCharge.Location = New System.Drawing.Point(564, 240)
        Me.txtCharge.MaxLength = 32767
        Me.txtCharge.Multiline = False
        Me.txtCharge.Name = "txtCharge"
        Me.txtCharge.ReadOnly = True
        Me.txtCharge.Size = New System.Drawing.Size(133, 54)
        Me.txtCharge.TabIndex = 0
        Me.txtCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCharge.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCharge.UseSystemPasswordChar = False
        '
        'txtChargeCurrency
        '
        Me.txtChargeCurrency.BackColor = System.Drawing.Color.Transparent
        Me.txtChargeCurrency.Enabled = False
        Me.txtChargeCurrency.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChargeCurrency.Location = New System.Drawing.Point(474, 240)
        Me.txtChargeCurrency.MaxLength = 32767
        Me.txtChargeCurrency.Multiline = False
        Me.txtChargeCurrency.Name = "txtChargeCurrency"
        Me.txtChargeCurrency.ReadOnly = True
        Me.txtChargeCurrency.Size = New System.Drawing.Size(90, 54)
        Me.txtChargeCurrency.TabIndex = 52
        Me.txtChargeCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtChargeCurrency.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtChargeCurrency.UseSystemPasswordChar = False
        '
        'txtPaymentCurrency
        '
        Me.txtPaymentCurrency.BackColor = System.Drawing.Color.Transparent
        Me.txtPaymentCurrency.Enabled = False
        Me.txtPaymentCurrency.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentCurrency.Location = New System.Drawing.Point(474, 333)
        Me.txtPaymentCurrency.MaxLength = 32767
        Me.txtPaymentCurrency.Multiline = False
        Me.txtPaymentCurrency.Name = "txtPaymentCurrency"
        Me.txtPaymentCurrency.ReadOnly = True
        Me.txtPaymentCurrency.Size = New System.Drawing.Size(90, 54)
        Me.txtPaymentCurrency.TabIndex = 51
        Me.txtPaymentCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPaymentCurrency.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPaymentCurrency.UseSystemPasswordChar = False
        '
        'cmdAllClear
        '
        Me.cmdAllClear.BackColor = System.Drawing.Color.Transparent
        Me.cmdAllClear.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdAllClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAllClear.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdAllClear.Location = New System.Drawing.Point(351, 286)
        Me.cmdAllClear.Name = "cmdAllClear"
        Me.cmdAllClear.Rounded = False
        Me.cmdAllClear.Size = New System.Drawing.Size(68, 168)
        Me.cmdAllClear.TabIndex = 50
        Me.cmdAllClear.Text = "AC"
        Me.cmdAllClear.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.Color.Transparent
        Me.cmdOk.BaseColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdOk.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdOk.Location = New System.Drawing.Point(474, 506)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Rounded = False
        Me.cmdOk.Size = New System.Drawing.Size(223, 54)
        Me.cmdOk.TabIndex = 47
        Me.cmdOk.Text = "OK"
        Me.cmdOk.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdStartCents
        '
        Me.cmdStartCents.BackColor = System.Drawing.Color.Transparent
        Me.cmdStartCents.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdStartCents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdStartCents.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdStartCents.Location = New System.Drawing.Point(277, 286)
        Me.cmdStartCents.Name = "cmdStartCents"
        Me.cmdStartCents.Rounded = False
        Me.cmdStartCents.Size = New System.Drawing.Size(68, 52)
        Me.cmdStartCents.TabIndex = 46
        Me.cmdStartCents.Text = "."
        Me.cmdStartCents.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdPay0
        '
        Me.cmdPay0.BackColor = System.Drawing.Color.Transparent
        Me.cmdPay0.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdPay0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPay0.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdPay0.Location = New System.Drawing.Point(277, 344)
        Me.cmdPay0.Name = "cmdPay0"
        Me.cmdPay0.Rounded = False
        Me.cmdPay0.Size = New System.Drawing.Size(68, 110)
        Me.cmdPay0.TabIndex = 45
        Me.cmdPay0.Text = "0"
        Me.cmdPay0.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdPay9
        '
        Me.cmdPay9.BackColor = System.Drawing.Color.Transparent
        Me.cmdPay9.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdPay9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPay9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdPay9.Location = New System.Drawing.Point(203, 402)
        Me.cmdPay9.Name = "cmdPay9"
        Me.cmdPay9.Rounded = False
        Me.cmdPay9.Size = New System.Drawing.Size(68, 52)
        Me.cmdPay9.TabIndex = 44
        Me.cmdPay9.Text = "9"
        Me.cmdPay9.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdPay8
        '
        Me.cmdPay8.BackColor = System.Drawing.Color.Transparent
        Me.cmdPay8.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdPay8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPay8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdPay8.Location = New System.Drawing.Point(129, 402)
        Me.cmdPay8.Name = "cmdPay8"
        Me.cmdPay8.Rounded = False
        Me.cmdPay8.Size = New System.Drawing.Size(68, 52)
        Me.cmdPay8.TabIndex = 43
        Me.cmdPay8.Text = "8"
        Me.cmdPay8.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdPay7
        '
        Me.cmdPay7.BackColor = System.Drawing.Color.Transparent
        Me.cmdPay7.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdPay7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPay7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdPay7.Location = New System.Drawing.Point(55, 402)
        Me.cmdPay7.Name = "cmdPay7"
        Me.cmdPay7.Rounded = False
        Me.cmdPay7.Size = New System.Drawing.Size(68, 52)
        Me.cmdPay7.TabIndex = 42
        Me.cmdPay7.Text = "7"
        Me.cmdPay7.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdPay6
        '
        Me.cmdPay6.BackColor = System.Drawing.Color.Transparent
        Me.cmdPay6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdPay6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPay6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdPay6.Location = New System.Drawing.Point(203, 344)
        Me.cmdPay6.Name = "cmdPay6"
        Me.cmdPay6.Rounded = False
        Me.cmdPay6.Size = New System.Drawing.Size(68, 52)
        Me.cmdPay6.TabIndex = 41
        Me.cmdPay6.Text = "6"
        Me.cmdPay6.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdPay5
        '
        Me.cmdPay5.BackColor = System.Drawing.Color.Transparent
        Me.cmdPay5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdPay5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPay5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdPay5.Location = New System.Drawing.Point(129, 344)
        Me.cmdPay5.Name = "cmdPay5"
        Me.cmdPay5.Rounded = False
        Me.cmdPay5.Size = New System.Drawing.Size(68, 52)
        Me.cmdPay5.TabIndex = 40
        Me.cmdPay5.Text = "5"
        Me.cmdPay5.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdPay4
        '
        Me.cmdPay4.BackColor = System.Drawing.Color.Transparent
        Me.cmdPay4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdPay4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPay4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdPay4.Location = New System.Drawing.Point(55, 344)
        Me.cmdPay4.Name = "cmdPay4"
        Me.cmdPay4.Rounded = False
        Me.cmdPay4.Size = New System.Drawing.Size(68, 52)
        Me.cmdPay4.TabIndex = 39
        Me.cmdPay4.Text = "4"
        Me.cmdPay4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdPay3
        '
        Me.cmdPay3.BackColor = System.Drawing.Color.Transparent
        Me.cmdPay3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdPay3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPay3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdPay3.Location = New System.Drawing.Point(203, 286)
        Me.cmdPay3.Name = "cmdPay3"
        Me.cmdPay3.Rounded = False
        Me.cmdPay3.Size = New System.Drawing.Size(68, 52)
        Me.cmdPay3.TabIndex = 38
        Me.cmdPay3.Text = "3"
        Me.cmdPay3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdPay2
        '
        Me.cmdPay2.BackColor = System.Drawing.Color.Transparent
        Me.cmdPay2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdPay2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPay2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdPay2.Location = New System.Drawing.Point(129, 286)
        Me.cmdPay2.Name = "cmdPay2"
        Me.cmdPay2.Rounded = False
        Me.cmdPay2.Size = New System.Drawing.Size(68, 52)
        Me.cmdPay2.TabIndex = 37
        Me.cmdPay2.Text = "2"
        Me.cmdPay2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdPay1
        '
        Me.cmdPay1.BackColor = System.Drawing.Color.Transparent
        Me.cmdPay1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdPay1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPay1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdPay1.Location = New System.Drawing.Point(55, 286)
        Me.cmdPay1.Name = "cmdPay1"
        Me.cmdPay1.Rounded = False
        Me.cmdPay1.Size = New System.Drawing.Size(68, 52)
        Me.cmdPay1.TabIndex = 36
        Me.cmdPay1.Text = "1"
        Me.cmdPay1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(553, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 21)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Payment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(541, 399)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 21)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Change Due"
        '
        'txtChangeDue
        '
        Me.txtChangeDue.BackColor = System.Drawing.Color.Transparent
        Me.txtChangeDue.Enabled = False
        Me.txtChangeDue.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChangeDue.Location = New System.Drawing.Point(564, 429)
        Me.txtChangeDue.MaxLength = 32767
        Me.txtChangeDue.Multiline = False
        Me.txtChangeDue.Name = "txtChangeDue"
        Me.txtChangeDue.ReadOnly = True
        Me.txtChangeDue.Size = New System.Drawing.Size(133, 54)
        Me.txtChangeDue.TabIndex = 32
        Me.txtChangeDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtChangeDue.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtChangeDue.UseSystemPasswordChar = False
        '
        'statusReceipt
        '
        Me.statusReceipt.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.statusReceipt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.statusReceipt.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.statusReceipt.ForeColor = System.Drawing.Color.White
        Me.statusReceipt.Location = New System.Drawing.Point(0, 583)
        Me.statusReceipt.Name = "statusReceipt"
        Me.statusReceipt.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.statusReceipt.ShowTimeDate = False
        Me.statusReceipt.Size = New System.Drawing.Size(748, 23)
        Me.statusReceipt.TabIndex = 31
        Me.statusReceipt.TextColor = System.Drawing.Color.White
        '
        'tableReceipt
        '
        Me.tableReceipt.AllowUserToAddRows = False
        Me.tableReceipt.AllowUserToDeleteRows = False
        Me.tableReceipt.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.tableReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tableReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableReceipt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnItem, Me.columnQuantity, Me.columnTax, Me.columnMember, Me.columnCharge})
        Me.tableReceipt.Location = New System.Drawing.Point(18, 61)
        Me.tableReceipt.Name = "tableReceipt"
        Me.tableReceipt.ReadOnly = True
        Me.tableReceipt.Size = New System.Drawing.Size(722, 132)
        Me.tableReceipt.TabIndex = 30
        '
        'columnItem
        '
        Me.columnItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnItem.FillWeight = 70.0!
        Me.columnItem.HeaderText = "Item"
        Me.columnItem.Name = "columnItem"
        Me.columnItem.ReadOnly = True
        '
        'columnQuantity
        '
        Me.columnQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnQuantity.FillWeight = 13.0!
        Me.columnQuantity.HeaderText = "Qty"
        Me.columnQuantity.Name = "columnQuantity"
        Me.columnQuantity.ReadOnly = True
        '
        'columnTax
        '
        Me.columnTax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnTax.FillWeight = 20.0!
        Me.columnTax.HeaderText = "Tax"
        Me.columnTax.Name = "columnTax"
        Me.columnTax.ReadOnly = True
        '
        'columnMember
        '
        Me.columnMember.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnMember.FillWeight = 30.0!
        Me.columnMember.HeaderText = "Member"
        Me.columnMember.Name = "columnMember"
        Me.columnMember.ReadOnly = True
        '
        'columnCharge
        '
        Me.columnCharge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnCharge.FillWeight = 30.0!
        Me.columnCharge.HeaderText = "Charge"
        Me.columnCharge.Name = "columnCharge"
        Me.columnCharge.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(557, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 21)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Charge"
        '
        'frmReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 606)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recipt"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.tableReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As cybercafe_server.FormSkin
    Friend WithEvents txtCharge As cybercafe_server.FlatTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tableReceipt As System.Windows.Forms.DataGridView
    Friend WithEvents statusReceipt As cybercafe_server.FlatStatusBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPayment As cybercafe_server.FlatTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtChangeDue As cybercafe_server.FlatTextBox
    Friend WithEvents cmdStartCents As cybercafe_server.FlatButton
    Friend WithEvents cmdPay0 As cybercafe_server.FlatButton
    Friend WithEvents cmdPay9 As cybercafe_server.FlatButton
    Friend WithEvents cmdPay8 As cybercafe_server.FlatButton
    Friend WithEvents cmdPay7 As cybercafe_server.FlatButton
    Friend WithEvents cmdPay6 As cybercafe_server.FlatButton
    Friend WithEvents cmdPay5 As cybercafe_server.FlatButton
    Friend WithEvents cmdPay4 As cybercafe_server.FlatButton
    Friend WithEvents cmdPay3 As cybercafe_server.FlatButton
    Friend WithEvents cmdPay2 As cybercafe_server.FlatButton
    Friend WithEvents cmdPay1 As cybercafe_server.FlatButton
    Friend WithEvents cmdOk As cybercafe_server.FlatButton
    Friend WithEvents cmdAllClear As cybercafe_server.FlatButton
    Friend WithEvents txtPaymentCurrency As cybercafe_server.FlatTextBox
    Friend WithEvents txtChargeCurrency As cybercafe_server.FlatTextBox
    Friend WithEvents timerFixPayment As System.Windows.Forms.Timer
    Friend WithEvents txtChangeDueCurrency As cybercafe_server.FlatTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents toggleFree As cybercafe_server.FlatToggle
    Friend WithEvents columnItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnTax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnMember As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnCharge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FlatTextBox1 As cybercafe_server.FlatTextBox
End Class
