Public Class frmConfiguration

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmConfiguration_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.TblMembersTableAdapter.Fill(Me.ServerDataSet.tblMembers)

    End Sub
End Class