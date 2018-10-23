Public Class Background

    Private Sub Background_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.IsHandleCreated = True Then
            FrmLogin.ShowDialog()
        End If
    End Sub
End Class