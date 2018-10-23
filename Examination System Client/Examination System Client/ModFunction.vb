Imports MySql.Data.MySqlClient

Module ModFunction

    Dim a As ComboBox
    Dim btn As Button
    Public strText As String
    Function TempPassword() As String
        Dim allowedchar() As Char = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890".ToCharArray()
        Dim rnd As Random = New Random
        Dim strPass As String
        Dim strlen As Integer = rnd.Next(8, 12)
        For x = 0 To strlen
            strPass += allowedchar(rnd.Next(0, allowedchar.Length))

        Next
        Return strPass
    End Function
    Sub LettersOnly(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        Dim notallowedkey As String = "0123456789!@#$%^&*()_+~`-=[]{}"":;|\<>?,./'"
        If InStr(notallowedkey, LCase(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Sub NumberOnly(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim notallowedkey As String = "qwertyuiopasdfghjklzxcvbnm!@#$%^&*()_+~`=[]{}"":;|\<>?,./-"
        If InStr(notallowedkey, LCase(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub


    Sub toProperCase(ByVal txt As TextBox)

        On Error Resume Next
        If txt.Text.Trim.Length > 0 Then
            strText = txt.Text
            txt.Text = (StrConv(strText, VbStrConv.ProperCase))
            txt.Select(txt.Text.Length, 0)

        End If
    End Sub

    Sub DefaultBGColor(ByVal obj As Control)
        Dim ctrl As Control
        For Each ctrl In obj.Controls
            If TypeOf ctrl Is Button Then
                btn = ctrl
                btn.BackColor = System.Drawing.Color.FromArgb(34, 45, 50)
            End If
        Next
    End Sub

    Sub ConnOpen()
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub
    Sub ConnClose()
        conn.Close()
    End Sub
    Function SQLExecute(ByVal sql As String) As Integer
        Try
            ConnOpen()
            cmd = New MySqlCommand(sql, conn)
            result = cmd.ExecuteNonQuery


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Execution Failed")
        Finally
            '    cmd.Dispose()
            conn.Dispose()
        End Try
        Return result
    End Function

    Function isEmpty(ByVal obj As Control) As Boolean
        Dim ctrl As Control
        For Each ctrl In obj.Controls
            If TypeOf ctrl Is TextBox Then
                If ctrl.Text = "" Then
                    Return True
                End If
            ElseIf TypeOf ctrl Is ComboBox Then
                a = ctrl
                If a.Text = "" Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    Sub ClearText(ByVal obj As Control)
        Dim ctrl As Control
        For Each ctrl In obj.Controls
            If TypeOf ctrl Is TextBox Then

                ctrl.Text = ""
            ElseIf TypeOf ctrl Is ComboBox Then
                a = ctrl
                If a.DropDownStyle = ComboBoxStyle.DropDownList Or a.DropDownStyle = ComboBoxStyle.DropDown Then
                    a.ResetText()
                    a.SelectedIndex = -1
                End If
            End If
        Next
    End Sub

    Function Key(ByVal dgView As DataGridView)
        Return dgView(0, dgView.CurrentRow.Index).Value.ToString
    End Function

    Function SQLRetrieve(ByVal sql As String) As DataTable

        Try
            ConnOpen()
            dt = New DataTable
            cmd = New MySqlCommand(sql, conn)
            dt.Load(cmd.ExecuteReader, LoadOption.OverwriteChanges)

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Execution Failed")

        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()

        End Try

        Return dt
    End Function

End Module
