Public Class frmMain

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            btnExaminee.PerformClick()
            e.Handled = False
        ElseIf e.KeyCode = Keys.F2 Then
            btnQuestion.PerformClick()
            e.Handled = False
        ElseIf e.KeyCode = Keys.F3 Then
            btnUserAccount.PerformClick()
            e.Handled = False
        ElseIf e.KeyCode = Keys.F4 Then
            btnmanageexam.PerformClick()
            e.Handled = False
        ElseIf e.Alt AndAlso e.KeyCode = Keys.X Then
            Button3.PerformClick()
        ElseIf e.Alt AndAlso e.KeyCode = Keys.Q Then
            btnLogout.PerformClick()
        End If
    End Sub

   
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = My.Computer.Screen.Bounds.Size
        Me.Focus()
    End Sub

    Private Sub btnExaminee_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminee.Click
        frmExaminee.ShowDialog()
    End Sub

    Private Sub btnQuestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuestion.Click
        frmQuestionaire.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Close Application", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Exit") = MsgBoxResult.Ok Then
            Application.Exit()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnUserAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserAccount.Click
        frmAccount.ShowDialog()
    End Sub

    Private Sub btnResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResults.Click
        frmResults.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        Me.Hide()
        frmUser.cleartext()
        frmUser.Show()
    End Sub

    Private Sub btnExaminees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminees.Click
       
        frmPrintExaminee.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmanageexam.Click
        frmExamManage.ShowDialog()
    End Sub

    Private Sub btnExaminee_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnExaminee.KeyDown
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        frmAbout.ShowDialog()
    End Sub
End Class
