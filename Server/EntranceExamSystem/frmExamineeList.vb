Public Class frmExamineeList

    Private Sub frmExamineeList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = getRecords("select schoolid,firstname,lastname,gender,yr,section,cpno,languagetaken from tblExaminee;")
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If Me.txtSearch.Text.Length > 0 Then
            DataGridView1.DataSource = getRecords("select schoolid,firstname,lastname,gender,yr,section,cpno,languagetaken from tblExaminee where lastname='" & Me.txtSearch.Text & "';")

        Else
            DataGridView1.DataSource = getRecords("select schoolid,firstname,lastname,gender,yr,section,cpno,languagetaken from tblExaminee;")
        End If
    End Sub
End Class