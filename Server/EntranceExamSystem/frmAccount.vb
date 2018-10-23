Public Class frmAccount

    Private Sub frmAccount_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Button1.PerformClick()
        Button2.PerformClick()
        Me.Hide()
    End Sub

    Private Sub frmAccount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
            e.Handled = False
        End If

    End Sub

    Private Sub frmAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim newpass As String = getValue("select password from tbluser where username='" & frmuser.txtuser.Text & "'")
        Me.txtOldpass.Text = newpass
        Dim newuser As String = getValue("select username from tbluser where password='" & Me.txtOldpass.Text & "'")
        Me.txtcurrentusername.Text = newuser

        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
    End Sub

    Private Sub btnchangeuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchangeuser.Click
        GroupBox2.Enabled = True
        GroupBox1.Enabled = False
        btnchangeuser.Enabled = False
        btnchangepass.Enabled = False
    End Sub

    Private Sub btnchangepass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchangepass.Click
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
        btnchangepass.Enabled = False
        btnchangeuser.Enabled = False
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If txtNewpass.Text = "" Or txtOldpass.Text = "" Or txtOldpass.Text = "" Then
            MsgBox("Don't Leave an empty fields", MsgBoxStyle.Critical, "Empty Field")
            txtOldpass.Focus()
            Exit Sub
        End If
        ' Dim old As String = DBConnection.getValue("SELECT password FROM tbluser WHERE password='" & Me.txtOldpass.Text.Replace("'", "\'") & "' WHERE username='" & txtNewpass.Text & "'")
        ' If txtOldpass.Text = old Then
        If txtNewpass.Text <> txtConfirmpass.Text Then
            MsgBox("Password Do not match", MsgBoxStyle.Exclamation, "Do not Match")
            txtConfirmpass.Clear()
            txtNewpass.Clear()
            txtConfirmpass.Clear()
            txtNewpass.Focus()
        Else
            Execute("UPDATE tbluser SET password='" & Me.txtNewpass.Text & "'")
            MsgBox("Password successfully change", MsgBoxStyle.Information, "Change Password")
            Dim newpass As String = getValue("select password from tbluser where username='" & frmuser.txtuser.Text & "'")
            Me.txtOldpass.Text = newpass
            Me.txtNewpass.Clear()
            Me.txtConfirmpass.Clear()
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            btnchangepass.Enabled = True
            btnchangeuser.Enabled = True
            'End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Me.txtnewusername.Text = "" Then
            MsgBox("Enter your new username")
            Exit Sub
        End If
        Execute("update tbluser set username='" & Me.txtnewusername.Text & "' where password='" & Me.txtOldpass.Text & "'")

        MsgBox("Username updated")
        Dim newuser As String = getValue("select username from tbluser where password='" & Me.txtOldpass.Text & "'")
        Me.txtcurrentusername.Text = newuser
        txtnewusername.Clear()
        btnchangepass.Enabled = True
        btnchangeuser.Enabled = True
        GroupBox2.Enabled = False
        GroupBox1.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtnewusername.Clear()
        GroupBox2.Enabled = False
        GroupBox1.Enabled = False
        btnchangeuser.Enabled = True
        btnchangepass.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        btnchangeuser.Enabled = True
        btnchangepass.Enabled = True
        txtConfirmpass.Clear()
        txtNewpass.Clear()
        GroupBox2.Enabled = False
        GroupBox1.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Close Application", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Exit") = MsgBoxResult.Ok Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtnewusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnewusername.TextChanged

    End Sub

    Private Sub txtcurrentusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcurrentusername.TextChanged

    End Sub
End Class