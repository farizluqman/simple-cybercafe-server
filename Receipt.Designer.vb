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
        Me.FormSkin1 = New cybercafe_server.FormSkin()
        Me.statusReceipt = New cybercafe_server.FlatStatusBar()
        Me.tableReceipt = New System.Windows.Forms.DataGridView()
        Me.columnTimeIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnTimeOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCharge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdClose = New cybercafe_server.FlatButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPayment = New cybercafe_server.FlatTextBox()
        Me.FormSkin1.SuspendLayout()
        CType(Me.tableReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.statusReceipt)
        Me.FormSkin1.Controls.Add(Me.tableReceipt)
        Me.FormSkin1.Controls.Add(Me.cmdClose)
        Me.FormSkin1.Controls.Add(Me.Label7)
        Me.FormSkin1.Controls.Add(Me.txtPayment)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(611, 346)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Receipt"
        '
        'statusReceipt
        '
        Me.statusReceipt.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.statusReceipt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.statusReceipt.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.statusReceipt.ForeColor = System.Drawing.Color.White
        Me.statusReceipt.Location = New System.Drawing.Point(0, 323)
        Me.statusReceipt.Name = "statusReceipt"
        Me.statusReceipt.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.statusReceipt.ShowTimeDate = False
        Me.statusReceipt.Size = New System.Drawing.Size(611, 23)
        Me.statusReceipt.TabIndex = 31
        Me.statusReceipt.TextColor = System.Drawing.Color.White
        '
        'tableReceipt
        '
        Me.tableReceipt.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tableReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tableReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableReceipt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnTimeIn, Me.columnTimeOut, Me.columnCharge})
        Me.tableReceipt.Location = New System.Drawing.Point(18, 61)
        Me.tableReceipt.Name = "tableReceipt"
        Me.tableReceipt.ReadOnly = True
        Me.tableReceipt.Size = New System.Drawing.Size(569, 103)
        Me.tableReceipt.TabIndex = 30
        '
        'columnTimeIn
        '
        Me.columnTimeIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnTimeIn.FillWeight = 40.0!
        Me.columnTimeIn.HeaderText = "Time In"
        Me.columnTimeIn.Name = "columnTimeIn"
        Me.columnTimeIn.ReadOnly = True
        '
        'columnTimeOut
        '
        Me.columnTimeOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnTimeOut.FillWeight = 40.0!
        Me.columnTimeOut.HeaderText = "Time Out"
        Me.columnTimeOut.Name = "columnTimeOut"
        Me.columnTimeOut.ReadOnly = True
        '
        'columnCharge
        '
        Me.columnCharge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnCharge.FillWeight = 20.0!
        Me.columnCharge.HeaderText = "Charge"
        Me.columnCharge.Name = "columnCharge"
        Me.columnCharge.ReadOnly = True
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Transparent
        Me.cmdClose.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdClose.Location = New System.Drawing.Point(405, 258)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Rounded = False
        Me.cmdClose.Size = New System.Drawing.Size(181, 54)
        Me.cmdClose.TabIndex = 29
        Me.cmdClose.Text = "Close"
        Me.cmdClose.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(402, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 21)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Payment"
        '
        'txtPayment
        '
        Me.txtPayment.BackColor = System.Drawing.Color.Transparent
        Me.txtPayment.Enabled = False
        Me.txtPayment.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayment.Location = New System.Drawing.Point(405, 198)
        Me.txtPayment.MaxLength = 32767
        Me.txtPayment.Multiline = False
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.ReadOnly = True
        Me.txtPayment.Size = New System.Drawing.Size(182, 54)
        Me.txtPayment.TabIndex = 0
        Me.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPayment.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPayment.UseSystemPasswordChar = False
        '
        'frmReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 346)
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
    Friend WithEvents txtPayment As cybercafe_server.FlatTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As cybercafe_server.FlatButton
    Friend WithEvents tableReceipt As System.Windows.Forms.DataGridView
    Friend WithEvents columnTimeIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnTimeOut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnCharge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents statusReceipt As cybercafe_server.FlatStatusBar
End Class
