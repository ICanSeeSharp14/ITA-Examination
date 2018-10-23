Public Class frmDeleting
    Dim rowcount As String = getValue("SELECT COUNT(*) FROM tblResults;")

    Private Sub frmDeleting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblrow.Text = rowcount
        Timer1.Start()
        ProgressBar1.Maximum = rowcount
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.ProgressBar1.Minimum = 0
        If Me.lbltick.Text = lblrow.Text And Me.ProgressBar1.Value = rowcount Then
            Timer1.Stop()
            Execute("Delete From tblresults;")
            Execute("Delete from tblexamineeanswer;")
            frmResults.DataGridView1.DataSource = getRecords("Select tblexaminee.examineeid,tblExaminee.Schoolid,tblexaminee.firstname,tblexaminee.lastname,tblexaminee.middlename,tblresults.DateExam,tblresults.Score from tblResults inner join tblExaminee on tblresults.examineeid=tblexaminee.examineeid;")
            MsgBox("All Records has been deleted", vbInformation, "deleted")
            Me.Hide()
        Else
            ProgressBar1.Value += 1
            lbltick.Text = lbltick.Text + 1
        End If
    End Sub
End Class