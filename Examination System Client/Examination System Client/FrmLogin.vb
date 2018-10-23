Public Class FrmLogin

    Private Sub FrmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F8 Then
            DBConfig.ShowDialog()
        End If
    End Sub

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        getData()
        ConnDB()

        If Me.txtCode.Text.Trim.Length = 0 Or Me.txtID.Text.Trim.Length = 0 Then
            MsgBox("Enter your school id and exam code", vbExclamation, "Exam")
            Exit Sub
        End If

        sqlQuery = <sql>
                       selEcT schoolid from tblresults where SchoolID = '<%= Me.txtID.Text %>'
                       </sql>

        dt = SQLRetrieve(sqlQuery)
        If dt.Rows.Count > 0 Then
            MsgBox("You already taken the exam.", vbExclamation, "Exam")
            Exit Sub
        Else
            sqlQuery = <sq>
                           select schoolid,examineeid,examcode,
CONCAT(lastname,' ',Firstname,' ',Substring(middlename,1,1),'.') as `Name` from tblexaminee 
where schoolid = '<%= Me.txtID.Text %>' and examcode = '<%= Me.txtCode.Text %>' 
                       </sq>

            dt = SQLRetrieve(sqlQuery)
            If dt.Rows.Count > 0 Then
                Dim ACCOUNT_PASSWORD As String = dt.Rows(0).Item(0).ToString
                Dim USER_NAME As String = dt.Rows(0).Item(2).ToString
                If ACCOUNT_PASSWORD = Me.txtID.Text And USER_NAME = txtCode.Text Then
                    Form1.lblName.Text = dt.Rows(0).Item(1).ToString

                    Form1.ShowDialog()
                Else
                    MsgBox("Invalid Exam Code/School ID", vbInformation, "Invalid")
                    Me.txtCode.Focus()
                End If

            End If

        End If
        'Form.lb1lID.Text = Me.txtID.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class