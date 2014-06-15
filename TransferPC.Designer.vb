<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferPC
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
        Me.txtTargetFmt = New cybercafe_server.FlatTextBox()
        Me.txtTargetPCNumber = New cybercafe_server.FlatTextBox()
        Me.txtDestinationFmt = New cybercafe_server.FlatTextBox()
        Me.cmdCancel = New cybercafe_server.FlatButton()
        Me.cmdTransfer = New cybercafe_server.FlatButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDestinationPCNumber = New cybercafe_server.FlatTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdClose = New cybercafe_server.FlatButton()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.txtTargetFmt)
        Me.FormSkin1.Controls.Add(Me.txtTargetPCNumber)
        Me.FormSkin1.Controls.Add(Me.txtDestinationFmt)
        Me.FormSkin1.Controls.Add(Me.cmdCancel)
        Me.FormSkin1.Controls.Add(Me.cmdTransfer)
        Me.FormSkin1.Controls.Add(Me.Label2)
        Me.FormSkin1.Controls.Add(Me.txtDestinationPCNumber)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.cmdClose)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(333, 254)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Transfer PC"
        '
        'txtTargetFmt
        '
        Me.txtTargetFmt.BackColor = System.Drawing.Color.Transparent
        Me.txtTargetFmt.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTargetFmt.Location = New System.Drawing.Point(135, 72)
        Me.txtTargetFmt.MaxLength = 32767
        Me.txtTargetFmt.Multiline = False
        Me.txtTargetFmt.Name = "txtTargetFmt"
        Me.txtTargetFmt.ReadOnly = True
        Me.txtTargetFmt.Size = New System.Drawing.Size(57, 39)
        Me.txtTargetFmt.TabIndex = 13
        Me.txtTargetFmt.Text = "PC"
        Me.txtTargetFmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTargetFmt.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTargetFmt.UseSystemPasswordChar = False
        '
        'txtTargetPCNumber
        '
        Me.txtTargetPCNumber.BackColor = System.Drawing.Color.Transparent
        Me.txtTargetPCNumber.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTargetPCNumber.Location = New System.Drawing.Point(198, 72)
        Me.txtTargetPCNumber.MaxLength = 32767
        Me.txtTargetPCNumber.Multiline = False
        Me.txtTargetPCNumber.Name = "txtTargetPCNumber"
        Me.txtTargetPCNumber.ReadOnly = True
        Me.txtTargetPCNumber.Size = New System.Drawing.Size(101, 39)
        Me.txtTargetPCNumber.TabIndex = 12
        Me.txtTargetPCNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTargetPCNumber.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTargetPCNumber.UseSystemPasswordChar = False
        '
        'txtDestinationFmt
        '
        Me.txtDestinationFmt.BackColor = System.Drawing.Color.Transparent
        Me.txtDestinationFmt.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestinationFmt.Location = New System.Drawing.Point(135, 119)
        Me.txtDestinationFmt.MaxLength = 32767
        Me.txtDestinationFmt.Multiline = False
        Me.txtDestinationFmt.Name = "txtDestinationFmt"
        Me.txtDestinationFmt.ReadOnly = True
        Me.txtDestinationFmt.Size = New System.Drawing.Size(57, 39)
        Me.txtDestinationFmt.TabIndex = 11
        Me.txtDestinationFmt.Text = "PC"
        Me.txtDestinationFmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDestinationFmt.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDestinationFmt.UseSystemPasswordChar = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.Transparent
        Me.cmdCancel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdCancel.Location = New System.Drawing.Point(173, 179)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Rounded = False
        Me.cmdCancel.Size = New System.Drawing.Size(126, 32)
        Me.cmdCancel.TabIndex = 10
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdTransfer
        '
        Me.cmdTransfer.BackColor = System.Drawing.Color.Transparent
        Me.cmdTransfer.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdTransfer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdTransfer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdTransfer.Location = New System.Drawing.Point(38, 179)
        Me.cmdTransfer.Name = "cmdTransfer"
        Me.cmdTransfer.Rounded = False
        Me.cmdTransfer.Size = New System.Drawing.Size(129, 32)
        Me.cmdTransfer.TabIndex = 9
        Me.cmdTransfer.Text = "Transfer Now"
        Me.cmdTransfer.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(34, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Target"
        '
        'txtDestinationPCNumber
        '
        Me.txtDestinationPCNumber.BackColor = System.Drawing.Color.Transparent
        Me.txtDestinationPCNumber.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestinationPCNumber.Location = New System.Drawing.Point(198, 119)
        Me.txtDestinationPCNumber.MaxLength = 32767
        Me.txtDestinationPCNumber.Multiline = False
        Me.txtDestinationPCNumber.Name = "txtDestinationPCNumber"
        Me.txtDestinationPCNumber.ReadOnly = False
        Me.txtDestinationPCNumber.Size = New System.Drawing.Size(101, 39)
        Me.txtDestinationPCNumber.TabIndex = 5
        Me.txtDestinationPCNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDestinationPCNumber.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDestinationPCNumber.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(34, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Destination"
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Transparent
        Me.cmdClose.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdClose.Location = New System.Drawing.Point(238, 10)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Rounded = False
        Me.cmdClose.Size = New System.Drawing.Size(83, 32)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "Close"
        Me.cmdClose.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'frmTransferPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 254)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTransferPC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer PC"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As cybercafe_server.FormSkin
    Friend WithEvents cmdClose As cybercafe_server.FlatButton
    Friend WithEvents cmdCancel As cybercafe_server.FlatButton
    Friend WithEvents cmdTransfer As cybercafe_server.FlatButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDestinationPCNumber As cybercafe_server.FlatTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDestinationFmt As cybercafe_server.FlatTextBox
    Friend WithEvents txtTargetFmt As cybercafe_server.FlatTextBox
    Friend WithEvents txtTargetPCNumber As cybercafe_server.FlatTextBox
End Class
