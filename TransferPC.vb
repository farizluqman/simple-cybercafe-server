Public Class frmTransferPC

    Dim target As String = frmHome.selectedPC

    Private Sub TransferPC_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtTargetPCNumber.Text = target.Replace("PC", "")
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdTransfer_Click(sender As Object, e As EventArgs) Handles cmdTransfer.Click
        Dim destination As String = "PC" + txtDestinationPCNumber.Text
        If Not target = destination Then
            transfer(target, destination)
            frmHome.clientInfo()
            Me.Close()
        Else
            errorbox("Cannot transfer to the same PC. Please select another PC.", "Error")
        End If

        
    End Sub

End Class