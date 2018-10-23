Public Class frmRanking

    Private Sub frmRanking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DataGridView1.DataSource = getRecords("SELECT tblRank.rankid,tblExaminee.firstname,tblExaminee.lastname,tblExaminee.middlename,tblresults.percentage,tblrank.logical,tblrank.oral,tblrank.rate From tblrank inner join tblexaminee on tblrank.examineeid=tblexaminee.examineeid inner join tblresults on tblrank.resultno=tblresults.resultno")
    End Sub
End Class