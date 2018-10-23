Public Class frmPrintExaminee

    Private Sub frmPrintExaminee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Size = My.Computer.Screen.Bounds.Size

    End Sub

    Public Sub refreshgrid()
        DataGridView1.DataSource = getRecords("SELECT SchoolID, FirstName, MiddleName, LastName, ExamCode FROM tblExaminee;")
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub frmPrintExaminee_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshgrid()
        DataGridView1.DataSource = getRecords("SELECT SchoolID, FirstName, MiddleName, LastName, ExamCode FROM tblExaminee;")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Close Application", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Exit") = MsgBoxResult.Ok Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub
End Class