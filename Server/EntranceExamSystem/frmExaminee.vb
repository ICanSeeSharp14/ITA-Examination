Public Class frmExaminee
    Dim isSave As Boolean

    Public Sub setbutton()
        btnCancel.Enabled = True
        btnSave.Enabled = True

        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False

    End Sub
    Public Sub refreshgrid()
        DataGridView1.DataSource = getRecords("SELECT * FROM tblExaminee;")
    End Sub
    Public Function isEmpty() As Boolean
        If txtFirstName.Text = "" Or txtlanguage.Text = "" Or txtLastname.Text = "" Or txtschoolID.Text = "" Or _
        txtSection.Text = "" Or txtMiddleName.Text = "" Or cmbGender.Text = "" Or cmbYearlevel.Text = "" Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub origbutton()
        btnCancel.Enabled = False
        btnSave.Enabled = False

        btnNew.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
    End Sub
    Public Sub clear()
        'clear textbox
        txtFirstName.Clear()
        txtschoolID.Clear()
        txtlanguage.Clear()
        txtLastname.Clear()
        txtSection.Clear()
        txtMiddleName.Clear()
        txtnumber.Clear()
        txtSection.Clear()
        txtSearch.Clear()
        'clear combobox
        cmbGender.SelectedIndex = -1
        cmbYearlevel.SelectedIndex = -1
    End Sub

    Private Sub frmExaminee_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        btncancel.PerformClick()
        Me.Hide()
    End Sub

    Private Sub frmExaminee_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
            e.Handled = False
        End If
    End Sub

    Private Sub frmExaminee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      origbutton()
        GroupBox3.Enabled = False
        refreshgrid()

    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If Me.DataGridView1.Rows.Count > 0 Then
            content()
        End If
    End Sub

  
    Private Sub txtnumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumber.KeyPress
        Dim var As String = "abcdefghijklmnopqrstuvwxyz!@`#$%^&*()+-=_;':/?,<>.{}[]\|~,"
        If InStr(var, LCase(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtLastname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLastname.KeyPress
        Dim var As String = "1234567890!@#$%^&*()_+-=~`<>,./?:;'\|}{[]"
        If InStr(var, LCase(e.KeyChar)) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtschoolID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtschoolID.KeyPress
        Dim var As String = "abcdefghijklmnopqrstuvwxyz!@`#$%^&*()+=_;':/?,<>.{}[]\|~,"
        If InStr(var, LCase(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtLastname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLastname.LostFocus
        Me.txtLastname.Text = StrConv(txtLastname.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub txtSection_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSection.KeyPress
        Dim var As String = "!@#$%^&*()_+-=~`<>,./?:;'\|}{[]"
        If InStr(var, LCase(e.KeyChar)) Then
            e.Handled = True
        End If

    End Sub
    Private Sub txtSection_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSection.LostFocus
        txtSection.Text = StrConv(txtSection.Text, VbStrConv.ProperCase)

    End Sub

    Private Sub txtSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.GotFocus
        Me.txtSearch.Clear()
        Me.txtSearch.ForeColor = Color.Black
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        Dim var As String = "1234567890'"
        If InStr(var, LCase(e.KeyChar)) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If Me.txtSearch.Text.Length > 0 Then
            DataGridView1.DataSource = getRecords("SELECT * from tblExaminee WHERE lastname like '" & Me.txtSearch.Text & "%'")
        Else
            Call refreshgrid()
        End If
    End Sub

    Private Sub txtFirstName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFirstName.KeyPress
        Dim var As String = "1234567890!@#$%^&*()_+-=~`<>,./?:;'\|}{[]"
        If InStr(var, LCase(e.KeyChar)) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtFirstName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFirstName.LostFocus
        Me.txtFirstName.Text = StrConv(txtFirstName.Text, VbStrConv.ProperCase)

    End Sub
    Private Sub btnsaving_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtnumber.Text.Length > 0 Then
            If txtnumber.TextLength < 11 Then
                MsgBox("Number should be 11 digits", MsgBoxStyle.Critical, "Entrance Exam")
                txtnumber.Focus()
                Exit Sub
            End If
        End If
        If isEmpty() = True Then
            MsgBox("All Fields are Required Except CP Number(Optional)", MsgBoxStyle.Exclamation, "Empty")
            Exit Sub
        End If

        If isSave = True Then
            Execute("INSERT INTO tblExaminee (schoolid,firstname,middlename,lastname,gender,yr,section,cpno,languagetaken,examcode) VALUES ('" & Me.txtschoolID.Text & _
                    "','" & txtFirstName.Text & "','" & txtMiddleName.Text & "','" & txtLastname.Text & "','" & _
                    cmbGender.Text & "','" & cmbYearlevel.Text & "','" & txtSection.Text & "','" & txtnumber.Text & "','" & txtlanguage.Text & "','" & ExamCode(8) & "')")
            refreshgrid()
            MsgBox("Record Saved", MsgBoxStyle.Information, "New Record")

        Else
            Execute("UPDATE tblExaminee set schoolid='" & txtschoolID.Text & "',firstname='" & txtFirstName.Text & "',middlename='" & _
                    txtMiddleName.Text & "',lastname='" & txtLastname.Text & "',gender='" & cmbGender.Text & "',yr='" & _
                    cmbYearlevel.Text & "',section='" & txtSection.Text & "',cpno='" & txtnumber.Text & "',languagetaken='" & txtlanguage.Text & "' WHERE examineeid='" & Me.DataGridView1(0, Me.DataGridView1.CurrentCellAddress.Y).Value.ToString & "'")
            refreshgrid()
            MsgBox("Record updated", MsgBoxStyle.Information, "Update")
            'Dim voice As String = "Record Updated"
            'Dim SAPI = CreateObject("SAPI.spvoice")
            'SAPI.speak(voice)
        End If
        clear()
        origbutton()
        GroupBox3.Enabled = False
        GroupBoxsearch.Enabled = True
        DataGridView1.Enabled = True
    End Sub

    Private Sub btndeleting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If isAlready("SELECT examineeid from tblresults where examineeid='" & Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value.ToString & "'") Then
            MsgBox("Cannot be deleted, the Record you selected is already take the exam", MsgBoxStyle.Exclamation, "Already")
            Exit Sub
        End If
        If MsgBox("Delete Record", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Delete Confirmation") = MsgBoxResult.Ok Then
            If DataGridView1.Rows.Count = 0 Then
                MsgBox("No Record Deleted", MsgBoxStyle.Information, "No Record")
            Else
                Execute("DELETE FROM tblExaminee WHERE examineeid=" & Me.DataGridView1(0, Me.DataGridView1.CurrentCellAddress.Y).Value.ToString & "")
                refreshgrid()
                MsgBox("Record Deleted", MsgBoxStyle.Critical, "Deleted")
              
            End If
           End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        isSave = True
        DataGridView1.Enabled = False
        GroupBox3.Enabled = True
        txtLastname.Focus()
        Call setbutton()
        Call clear()
        GroupBoxsearch.Enabled = False

    End Sub
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Call clear()
        Call origbutton()
        GroupBoxsearch.Enabled = True
        GroupBox3.Enabled = False
        DataGridView1.Enabled = True
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If isEmpty() = True Then
            MsgBox("Select the Record that you want to Edit", MsgBoxStyle.Exclamation, "Select")
            Exit Sub
        Else
            isSave = False
            GroupBox3.Enabled = True
            txtLastname.Focus()
            DataGridView1.Enabled = False
            GroupBoxsearch.Enabled = False
            setbutton()
        End If
    End Sub
    Public Sub content()
        Me.txtschoolID.Text = Me.DataGridView1(1, Me.DataGridView1.CurrentCellAddress.Y).Value.ToString
        Me.txtFirstName.Text = Me.DataGridView1(2, Me.DataGridView1.CurrentCellAddress.Y).Value.ToString
        Me.txtMiddleName.Text = Me.DataGridView1(3, Me.DataGridView1.CurrentCellAddress.Y).Value.ToString
        Me.txtLastname.Text = Me.DataGridView1(4, Me.DataGridView1.CurrentCellAddress.Y).Value.ToString
        Me.cmbGender.Text = Me.DataGridView1(5, Me.DataGridView1.CurrentCellAddress.Y).Value.ToString
        Me.cmbYearlevel.Text = Me.DataGridView1(6, Me.DataGridView1.CurrentCellAddress.Y).Value.ToString
        Me.txtSection.Text = Me.DataGridView1(7, Me.DataGridView1.CurrentCellAddress.Y).Value.ToString
        Me.txtnumber.Text = Me.DataGridView1(8, Me.DataGridView1.CurrentCellAddress.Y).Value.ToString
        Me.txtlanguage.Text = Me.DataGridView1(9, Me.DataGridView1.CurrentCellAddress.Y).Value.ToString

    End Sub
    Private Sub txtlanguage_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlanguage.LostFocus
        txtlanguage.Text = StrConv(txtlanguage.Text, VbStrConv.Uppercase)
    End Sub
    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Down Or Keys.Up Then
            If DataGridView1.Rows.Count > 0 Then
                content()
            End If
        End If
    End Sub

    Private Sub txtMiddleName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMiddleName.KeyPress
        Dim var As String = "1234567890!@#$%^&*()_+-=~`<>,./?:;'\|}{[]"
        If InStr(var, LCase(e.KeyChar)) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtMiddleName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMiddleName.LostFocus
        Me.txtMiddleName.Text = StrConv(txtMiddleName.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        content()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Close Application", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Exit") = MsgBoxResult.Ok Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtLastname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLastname.TextChanged

    End Sub

    Private Sub txtMiddleName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMiddleName.TextChanged

    End Sub
End Class