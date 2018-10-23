Public Class frmQuestionaire
    Dim isSave As Boolean

    Public Sub origbutton()
        btnNew.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False

    End Sub
    Public Sub setbutton()
        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True

    End Sub
    Public Sub clear()
        txtanswer.Clear()
        txtoption1.Clear()
        txtoption2.Clear()
        txtoption3.Clear()
        txtoption4.Clear()
        txtquestion.Clear()
    End Sub
    Public Function isEmpty() As Boolean
        If txtanswer.Text = "" Or txtoption1.Text = "" Or txtoption2.Text = "" Or txtoption3.Text = "" Or txtoption4.Text = "" Or txtquestion.Text = "" Then
            isEmpty = True
        Else
            isEmpty = False
        End If
    End Function
    Public Sub refreshgrid()
        DataGridView1.DataSource = getRecords("select * from tblQuestions;")
        lbltotal.Text = getValue("select count(*) FROM tblQuestions;")
    End Sub

    Private Sub frmQuestionaire_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        btnCancel.PerformClick()
        Me.Hide()
    End Sub

    Private Sub frmQuestionaire_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
            e.Handled = False
        End If
    End Sub
    Private Sub frmQuestionaire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TabControl1.SelectedTab = TabPage2
        origbutton()
        refreshgrid()
        DataGridView1.Enabled = True
        GroupBox1.Enabled = False
    End Sub
  
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If isEmpty() = True Then
            MsgBox("Don't leave an Empty fields", MsgBoxStyle.Critical, "Empty Fields")
            txtquestion.Focus()
            Exit Sub
        End If

        If txtanswer.Text <> txtoption1.Text And txtanswer.Text <> txtoption2.Text And txtanswer.Text <> txtoption3.Text And txtanswer.Text <> txtoption4.Text Then
            MsgBox("Answer must be one of the choices", vbCritical, "Questionaire")
            txtanswer.Focus()
            Exit Sub
        End If
        If isSave = True Then

            If isAlready("SELECT question from tblquestions where question='" & Me.txtquestion.Text.Replace("'", "\'") & "'") Then
                  MsgBox("Question Already Exist", vbExclamation, "Already")
            Else
                Execute("INSERT INTO tblquestions (question,choice1,choice2,choice3,choice4,answer) VALUES ('" & _
                                   Me.txtquestion.Text.Replace("'", "\'") & "','" & Me.txtoption1.Text.Replace("'", "\'") & "','" & _
                                   Me.txtoption2.Text.Replace("'", "\'") & "','" & Me.txtoption3.Text.Replace("'", "\'") & "','" & Me.txtoption4.Text.Replace("'", "\'") & "','" & Me.txtanswer.Text.Replace("'", "\'") & "')")
                Call refreshgrid()

                MsgBox("New question has been added", MsgBoxStyle.Information, "Save")
                '     Exit Sub
            End If
        End If
        If isSave = False Then
            DBConnection.Execute("UPDATE tblquestions SET question='" & Me.txtquestion.Text.Replace("'", "\'") & "', choice1='" & Me.txtoption1.Text.Replace("'", "\'") & "', choice2='" & Me.txtoption2.Text.Replace("'", "\'") & "', choice3='" & Me.txtoption3.Text.Replace("'", "\'") & "', choice4='" & Me.txtoption4.Text.Replace("'", "\'") & "', answer='" & Me.txtanswer.Text.Replace("'", "\'") & "' WHERE qid='" & Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value.ToString & "'")
            Call refreshgrid()
            MsgBox("Question has been update", vbInformation, "update")
        End If
        Call clear()
        Call origbutton()
        GroupBox1.Enabled = False
        TabControl1.SelectedTab = TabPage2
        DataGridView1.Enabled = True
    End Sub

   
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure you want to delete this Record", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Delete Record") = MsgBoxResult.Ok Then
            Execute("DELETE FROM tblquestions WHERE QID=" & Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value.ToString & "")
            Call refreshgrid()
            MsgBox("Record Deleted", MsgBoxStyle.Information)
        End If
        TabControl1.SelectedTab = TabPage2

    End Sub
    Public Sub getText()
        txtquestion.Text = Me.DataGridView1(1, Me.DataGridView1.CurrentRow.Index).Value.ToString
        txtoption1.Text = Me.DataGridView1(2, Me.DataGridView1.CurrentCellAddress.Y).Value.ToString
        txtoption2.Text = Me.DataGridView1(3, Me.DataGridView1.CurrentCellAddress.Y).Value.ToString
        txtoption3.Text = Me.DataGridView1(4, Me.DataGridView1.CurrentCellAddress.Y).Value.ToString
        txtoption4.Text = Me.DataGridView1(5, Me.DataGridView1.CurrentCellAddress.Y).Value.ToString
        txtanswer.Text = Me.DataGridView1(6, Me.DataGridView1.CurrentCellAddress.Y).Value.ToString
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If Me.DataGridView1.Rows.Count > 0 Then
            getText()
        End If
    End Sub
    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            getText()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If isEmpty() = True Then
            MsgBox("Select The Record that You want to edit", vbExclamation, "Select")

        Else
            TabControl1.SelectedTab = TabPage1
            GroupBox1.Enabled = True
            DataGridView1.Enabled = False
            GroupBox1.Text = "Edit Question"
            isSave = False
            Call setbutton()
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        isSave = True
        DataGridView1.Enabled = False
        TabControl1.SelectedTab = TabPage1
        GroupBox1.Enabled = True
        GroupBox1.Text = "New Question"
        txtquestion.Focus()
        Call clear()
        Call setbutton()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call clear()
        Call origbutton()
        DataGridView1.Enabled = True
        GroupBox1.Enabled = False
        TabControl1.SelectedTab = TabPage2
    End Sub
End Class