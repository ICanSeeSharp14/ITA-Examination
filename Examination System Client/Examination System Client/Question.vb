Public Class Question
    Public Sub colortext()
        If RadioButton1.Checked Then
            txtQuestion.BackColor = Color.DarkCyan
        ElseIf RadioButton2.Checked Then
            txtQuestion.BackColor = Color.DarkCyan
        ElseIf RadioButton3.Checked Then
            txtQuestion.BackColor = Color.DarkCyan
        ElseIf RadioButton4.Checked Then
            txtQuestion.BackColor = Color.DarkCyan
        Else

        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.lblAnswer.Text = RadioButton2.Text
        colortext()
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Me.lblAnswer.Text = RadioButton4.Text
        colortext()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Me.lblAnswer.Text = RadioButton3.Text
        colortext()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.lblAnswer.Text = RadioButton1.Text
        colortext()
    End Sub

    Private Sub Question_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        colortext()
    End Sub

    Private Sub lblNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNo.Click

    End Sub
End Class
