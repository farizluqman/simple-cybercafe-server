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
    Public charges As String = frmPrepaid.charges
    Public pc As String = frmHome.selectedPC
    Public accesslevel As Integer = Int(readClientConfig("clients", "accesslevel", pc))

    Private Sub frmReceipt_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        frmPrepaid.Enabled = False
        If accesslevel = 0 OrElse accesslevel = 1 Then
            tableReceipt.Rows.Add(readClientConfig("clients", "timein", pc), readClientConfig("clients", "timeout", pc), Format(calculateToCharge(frmPrepaid.hours, frmPrepaid.minutes), "RM 0.00"))
            txtPayment.Text = Format(calculateToCharge(frmPrepaid.hours, frmPrepaid.minutes), "RM 0.00")
        ElseIf accesslevel = 2 Then
            logout(pc)
            charges = calculateOpen(pc)
            tableReceipt.Rows.Add(readClientConfig("clients", "timein", pc), readClientConfig("clients", "timeout", pc), charges)
            txtPayment.Text = charges
        End If

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        frmPrepaid.Close()
        frmHome.clientInfo()
    End Sub

End Class