Public Class frmExamManage
    Public Sub getText()
        Dim no As Integer = 1
        txtitems.Text = getValue("SELECT numberofitems from tblmanageexam where no='" & no.ToString & "'")
        txttimeduration.Text = getValue("select timeduration from tblmanageexam where no='" & no.ToString & "'")
    End Sub

    Private Sub frmExamManage_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        btnCancelitem.PerformClick()
        btncanceltime.PerformClick()
        Me.Hide()
    End Sub

    Private Sub frmExamManage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
            e.Handled = False
        End If
    End Sub
    Private Sub frmExamManage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getText()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdititem.Click
        GroupBox3.Enabled = False
        btnSaveitem.Enabled = True
        btnCancelitem.Enabled = True
        txtitems.Enabled = True
    End Sub

    Private Sub btnSaveitem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveitem.Click
        If txtitems.Text = "0" Or txtitems.Text = "" Then
            MsgBox("Invalid Input, There Must be a Question", vbCritical, "Entrance Exam")
            Exit Sub
        End If
        Dim totalitem As String = getValue("SELECT COUNT(*) FROM tblQuestions;")
        If Val(txtitems.Text) > Val(totalitem) Then
            MsgBox("the item must less than or equal to the total questions")
        Else
            Execute("update tblmanageexam set numberofitems='" & Me.txtitems.Text & "' WHERE timeduration='" & Me.txttimeduration.Text & "'")
            MsgBox("Save")
            GroupBox3.Enabled = True
            btnEdititem.Enabled = True
            btnSaveitem.Enabled = False
            btnCancelitem.Enabled = False
            txtitems.Enabled = False
          End If
    End Sub

    Private Sub btnedittime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedittime.Click
        GroupBox2.Enabled = False
        btnedittime.Enabled = False
        btnsavetime.Enabled = True
        btncanceltime.Enabled = True
        txttimeduration.Enabled = True
    End Sub

    Private Sub btnCancelitem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelitem.Click
        getText()
        GroupBox3.Enabled = True
        btnEdititem.Enabled = True
        btnSaveitem.Enabled = False
        btnCancelitem.Enabled = False
        txtitems.Enabled = False
        txtitems.Refresh()
    End Sub

    Private Sub btnsavetime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavetime.Click
        If txttimeduration.Text = "0" Or txttimeduration.Text = "" Then
            MsgBox("Invalid Time", vbCritical, "Time")
        Else
            Execute("update tblmanageexam set timeduration='" & Me.txttimeduration.Text & "' WHERE numberofitems='" & Me.txtitems.Text & "'")
            MsgBox("Saved", vbInformation, "Entrance Exam")
            GroupBox2.Enabled = True
            btnedittime.Enabled = True
            btnsavetime.Enabled = False
            btncanceltime.Enabled = False
            txttimeduration.Enabled = False
        End If
    End Sub

    Private Sub btncanceltime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncanceltime.Click
        getText()
        GroupBox2.Enabled = True
        btnedittime.Enabled = True
        btnsavetime.Enabled = False
        btncanceltime.Enabled = False
        txttimeduration.Enabled = False
    End Sub
End Class