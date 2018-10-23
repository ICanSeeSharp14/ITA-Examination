Public Class frmUser
    
    Private Sub txtschoolid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim var As String = "abcdefghijklmnopqrstuvwxyz!@#$%^&*()_+={}[]':;\|/?<>,.`~ "
        If InStr(var, LCase(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtexamid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim var As String = "abcdefghijklmnopqrstuvwxyz!@#$%^&*()_+={}[]':;\|/?<>,.`~ "
        If InStr(var, LCase(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtuser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtuser.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            Button2.PerformClick()
        End If
    End Sub
    Private Sub txtpass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            Button2.PerformClick()
        End If

    End Sub
    Public Sub cleartext()
        txtuser.Clear()
        txtpass.Clear()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtuser.Text = "" Or txtpass.Text = "" Then
            MsgBox("Enter Your Username/Password", vbExclamation, "Empty")
            txtuser.Focus()
            Exit Sub
        End If
        Dim user As String = getValue("SELECT username FROM tblUser WHERE username='" & Me.txtuser.Text.Replace("'", "\'") & "' and password='" & Me.txtpass.Text & "'")
        Dim pass As String = getValue("SELECT password FROM tbluser WHERE password='" & Me.txtpass.Text.Replace("'", "\'") & "' and username='" & Me.txtuser.Text.Replace("'", "\'") & "'")
        If txtpass.Text = pass And txtuser.Text = user Then
            Me.Hide()
            frmMain.Show()
            Exit Sub
        Else
            MsgBox("Incorrect Username or Password", vbExclamation, "Inncorrect Account")
            txtuser.Clear()
            txtpass.Clear()
            txtuser.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class