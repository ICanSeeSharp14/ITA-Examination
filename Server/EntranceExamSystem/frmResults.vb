Public Class frmResults

    Private Sub frmResults_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Created Then
            Me.txtSearch.Text = "Search..."
            Me.txtSearch.ForeColor = Color.LightGray

        End If
        DataGridView1.DataSource = getRecords("Select tblexaminee.examineeid,tblExaminee.Schoolid,tblexaminee.firstname,tblexaminee.lastname,tblexaminee.middlename,tblresults.DateExam,tblresults.Score from tblResults inner join tblExaminee on tblresults.examineeid=tblexaminee.examineeid;")
    End Sub

    Private Sub txtSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.GotFocus

        Me.txtSearch.ForeColor = Color.Black
        Me.txtSearch.Clear()
    End Sub

    Private Sub txtSearch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.LostFocus
        If Me.txtSearch.Text = "" Then
            Me.txtSearch.Text = "Search..."
            Me.txtSearch.ForeColor = Color.LightGray

        End If
        DataGridView1.DataSource = getRecords("Select tblexaminee.examineeid,tblExaminee.Schoolid,tblexaminee.firstname,tblexaminee.lastname,tblexaminee.middlename,tblresults.DateExam,tblresults.Score from tblResults inner join tblExaminee on tblresults.examineeid=tblexaminee.examineeid;")

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged

        If Me.txtSearch.Text.Length > 0 Then
            DataGridView1.DataSource = getRecords("Select tblexaminee.examineeid,tblExaminee.Schoolid,tblexaminee.firstname,tblexaminee.lastname,tblexaminee.middlename,tblresults.DateExam,tblresults.Score from tblResults inner join tblExaminee on tblresults.examineeid=tblexaminee.examineeid WHERE tblexaminee.examineeid like '" & _
                                                  Me.txtSearch.Text & "' or tblexaminee.lastname like '" & Me.txtSearch.Text.Replace("'", "\'") & "%' or tblexaminee.middlename like '" & _
                                                  Me.txtSearch.Text.Replace("'", "\'") & "%' or tblexaminee.schoolid like '" & Me.txtSearch.Text.Replace("'", "\'") & "%' or tblexaminee.firstname like '" & Me.txtSearch.Text.Replace("'", "\'") & "%';")
        Else
            DataGridView1.DataSource = getRecords("Select tblexaminee.examineeid,tblExaminee.Schoolid,tblexaminee.firstname,tblexaminee.lastname,tblexaminee.middlename,tblresults.DateExam,tblresults.Score from tblResults inner join tblExaminee on tblresults.examineeid=tblexaminee.examineeid;")

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If DataGridView1.RowCount = 0 Then
            MsgBox("There's no Record")
            Exit Sub
        End If
        If MsgBox("Are you sure to reset the results? it will not undo the results", vbOKCancel + vbCritical, "Reset") = vbOK Then
            frmDeleting.ProgressBar1.Minimum = 0
            frmDeleting.ShowDialog()
        End If
        'DataGridView1.DataSource = getRecords("Select tblexaminee.examineeid,tblExaminee.Schoolid,tblexaminee.firstname,tblexaminee.lastname,tblexaminee.middlename,tblresults.DateExam,tblresults.Score from tblResults inner join tblExaminee on tblresults.examineeid=tblexaminee.examineeid;")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.DataSource = getRecords("Select tblexaminee.examineeid,tblExaminee.Schoolid,tblexaminee.firstname,tblexaminee.lastname,tblexaminee.middlename,tblresults.DateExam,tblresults.Score from tblResults inner join tblExaminee on tblresults.examineeid=tblexaminee.examineeid;")
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If DataGridView1.RowCount = 0 Then
            MsgBox("There's no Record")
            Exit Sub
        Else
            frmViewAnswers.txtname.Text = getValue("select concat(firstname,' ',lastname) FROM tblexaminee WHERE examineeid='" & Me.DataGridView1("examineeid", Me.DataGridView1.CurrentCellAddress.Y).Value.ToString & "'")
            frmViewAnswers.txtyearsec.Text = getValue("SELECT CONCAT(yr,'-',section) FROM tblexaminee WHERE examineeid='" & Me.DataGridView1("examineeid", Me.DataGridView1.CurrentCellAddress.Y).Value.ToString & "'")
            frmViewAnswers.txtscore.Text = Me.DataGridView1("score", Me.DataGridView1.CurrentCellAddress.Y).Value.ToString
            frmViewAnswers.txtdateexam.Text = Me.DataGridView1("dateexam", Me.DataGridView1.CurrentCellAddress.Y).Value.ToString
            frmViewAnswers.ShowDialog()

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSelect.PerformClick()
        End If
    End Sub
End Class