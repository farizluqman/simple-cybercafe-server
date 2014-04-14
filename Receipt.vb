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

Public Class frmReceipt
    Private charges As String = frmPrepaid.charges
    Private pc As String = frmHome.selectedPC
    Private hours As Integer = frmPrepaid.hours
    Private minutes As Integer = frmPrepaid.minutes
    Private accesslevel As Integer = Int(readClientConfig("clients", "accesslevel", pc))
    Private countCharges As Double = 0.0
    Private payment As Double = 0.0
    Private startCents As Boolean = False

    Private Sub frmReceipt_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        frmPrepaid.Enabled = False
        txtChangeDue.Text = "0.00"
        txtChargeCurrency.Text = My.Settings.currency
        txtPaymentCurrency.Text = My.Settings.currency
        txtChangeDueCurrency.Text = My.Settings.currency
        If accesslevel = 2 And frmHome.prepaidMode = 0 Then
            logout(pc)
            countCharges = calculateOpen(pc)
            charges = calculateOpen(pc)
            tableReceipt.Rows.Add("Open Hour", "1", "", My.Settings.currency + Format(calculateOpen(pc), " 0.00"), readClientConfig("clients", "timein", pc), readClientConfig("clients", "timeout", pc))
            txtCharge.Text = My.Settings.currency + Format(charges, " 0.00")
        ElseIf frmHome.prepaidMode = 1 Then
            countCharges = calculateToCharge(hours, minutes)
            tableReceipt.Rows.Add("Top Up (Prepaid)", "1", "", My.Settings.currency + Format(calculateToCharge(frmPrepaid.hours, frmPrepaid.minutes), " 0.00"), readClientConfig("clients", "timein", pc), readClientConfig("clients", "timeout", pc))
            txtCharge.Text = Format(calculateToCharge(hours, minutes), "0.00")
        ElseIf frmHome.prepaidMode = 0 Then
            countCharges = calculateToCharge(hours, minutes)
            tableReceipt.Rows.Add("Unlock PC (Prepaid)", "1", "", My.Settings.currency + Format(calculateToCharge(frmPrepaid.hours, frmPrepaid.minutes), " 0.00"), readClientConfig("clients", "timein", pc), readClientConfig("clients", "timeout", pc))
            txtCharge.Text = Format(calculateToCharge(hours, minutes), "0.00")
        End If

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        frmPrepaid.Close()
        frmHome.clientInfo()
    End Sub

    Private Sub cmdPay1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPay1.Click
        txtPayment.Text += "1"
        reformat()
    End Sub

    Private Sub cmdPay2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPay2.Click
        txtPayment.Text += "2"
        reformat()
    End Sub

    Private Sub cmdPay3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPay3.Click
        txtPayment.Text += "3"
        reformat()
    End Sub

    Private Sub cmdPay4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPay4.Click
        txtPayment.Text += "4"
        reformat()
    End Sub

    Private Sub cmdPay5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPay5.Click
        txtPayment.Text += "5"
        reformat()
    End Sub

    Private Sub cmdPay6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPay6.Click
        txtPayment.Text += "6"
        reformat()
    End Sub

    Private Sub cmdPay7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPay7.Click
        txtPayment.Text += "7"
        reformat()
    End Sub

    Private Sub cmdPay8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPay8.Click
        txtPayment.Text += "8"
        reformat()
    End Sub

    Private Sub cmdPay9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPay9.Click
        txtPayment.Text += "9"
        reformat()
    End Sub

    Private Sub cmdStartCents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStartCents.Click
        If startCents = False Then
            txtPayment.Text += "."
            startCents = True
        End If
    End Sub

    Private Sub cmdPay0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPay0.Click
        txtPayment.Text += "0"
        reformat()
    End Sub

    Private Sub cmdAllClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAllClear.Click
        txtPayment.Text = ""
        txtChangeDue.Text = "0.00"
        startCents = False
        payment = 0
    End Sub

    Private Sub reformat()
        payment = txtPayment.Text
        If Format(payment - countCharges) > 0 Then
            txtChangeDue.Text = Format(payment - countCharges, "0.00")
        Else
            txtChangeDue.Text = "0.00"
        End If

    End Sub

    Private Sub toggleFree_CheckedChanged(ByVal sender As System.Object) Handles toggleFree.CheckedChanged
        If toggleFree.Checked = True Then
            tableReceipt.Rows.Add("Adjustment", " ", " ", "-" + Format(calculateToCharge(frmPrepaid.hours, frmPrepaid.minutes), "RM 0.00"))
            txtCharge.Text = "0.00"
            countCharges = 0.0
            charges = 0.0
        Else
            tableReceipt.Rows.RemoveAt(1)
            If frmHome.prepaidMode = 0 Then
                countCharges = calculateToCharge(hours, minutes)
                txtCharge.Text = Format(calculateToCharge(hours, minutes), "0.00")
            ElseIf frmHome.prepaidMode = 1 Then
                countCharges = calculateToCharge(hours, minutes)
                txtCharge.Text = Format(calculateToCharge(hours, minutes), "0.00")
            ElseIf accesslevel = 2 Then
                logout(pc)
                countCharges = calculateOpen(pc)
                charges = calculateOpen(pc)
                txtCharge.Text = My.Settings.currency + Format(charges, " 0.00")
            End If
        End If

    End Sub


    Private Sub FlatButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton12.Click

    End Sub
End Class