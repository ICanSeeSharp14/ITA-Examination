
Public Class Form1

    Sub InsertAnswer()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.lblID.Text = FrmLogin.txtID.Text

        sqlQuery = <sql>
                       SELECT * FROM tblquestions ORDER BY RAND() LIMIT 60;
                   </sql>

        dt = SQLRetrieve(sqlQuery)
        For x = 0 To dt.Rows.Count - 1
            With Me.Panel1.Controls
                Dim question As New Question
                question.lblNo.Text = dt.Rows.Count - x
                question.txtQuestion.Text = dt.Rows(x).Item("Question").ToString
                question.RadioButton1.Text = dt.Rows(x).Item(2).ToString
                question.RadioButton2.Text = dt.Rows(x).Item(3).ToString
                question.RadioButton3.Text = dt.Rows(x).Item(4).ToString
                question.RadioButton4.Text = dt.Rows(x).Item(5).ToString
                question.Label1.Text = dt.Rows(x).Item(6).ToString

                .Add(question)
                question.Dock = DockStyle.Top

            End With

        Next
        Panel1.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Timer1.Start()
        Me.Button2.Enabled = False
        Panel1.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim dialog As DialogResult = Confirm.ShowDialog
        If dialog = vbYes Then
            Dim question As New Question
            Dim ctr As Control
            For Each ctr In Me.Panel1.Controls
                If TypeOf ctr Is UserControl Then
                    question = ctr
                    sqlQuery = <sql>
                       INSERT INTO tblexamineeanswer (ExamineeID,Question,Answer,CorrectAnswer)
                        VALUES ('<%= Me.lblID.Text %>','<%= question.txtQuestion.Text.Replace("'", "\'") %>','<%= question.lblAnswer.Text.Replace("'", "\'") %>','<%= question.Label1.Text.Replace("'", "\'") %>')
                   </sql>

                    SQLExecute(sqlQuery)
                End If
            Next

            sqlQuery = <sql>
                       insert into tblresults (examineeid,schoolid,dateexam,score) values ('<%= Me.lblID.Text %>',
'<%= Me.lblSchoolid.Text %>',CURDATE(),(
                       SELECT Count(*) FROM `tblexamineeanswer` WHERE answer = correctanswer and examineeid = '<%= Me.lblID.Text %>'))
                   </sql>

            SQLExecute(sqlQuery)

            Me.Hide()
            FrmLogin.Show()
            'dt = SQLRetrieve(sqlQuery)

        End If
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If Val(Me.lblHour.Text) > 0 And Val(Me.lblMinute.Text) > 0 And Val(Me.lblSecond.Text) > 0 Then
            Me.lblSecond.Text = Val(Me.lblSecond.Text) - 1

        ElseIf Val(Me.lblHour.Text) > 0 And Val(Me.lblMinute.Text) > 0 And Val(Me.lblSecond.Text) = 0 Then
            Me.lblSecond.Text = 59
            Me.lblMinute.Text -= 1


        ElseIf Val(Me.lblHour.Text) > 0 And Val(Me.lblMinute.Text) = 0 And Val(Me.lblSecond.Text) = 0 Then
            Me.lblHour.Text -= 1
            Me.lblMinute.Text = 59
        ElseIf Val(Me.lblHour.Text) > 0 And Val(Me.lblMinute.Text) = 0 And Val(Me.lblSecond.Text) > 0 Then
            Me.lblSecond.Text = Val(lblSecond.Text) - 1

        ElseIf Val(Me.lblHour.Text) > 0 And Val(Me.lblMinute.Text) = 0 And Val(Me.lblSecond.Text) = 0 Then
            Me.lblHour.Text = Val(lblHour.Text) - 1
            Me.lblMinute.Text = 59
            Me.lblSecond.Text = 59



        ElseIf Val(Me.lblHour.Text) = 0 And Val(Me.lblMinute.Text) > 0 And Val(Me.lblSecond.Text) > 0 Then
            Me.lblSecond.Text = Val(Me.lblSecond.Text) - 1



        ElseIf Val(Me.lblHour.Text) = 0 And Val(Me.lblMinute.Text) > 0 And Val(Me.lblSecond.Text) = 0 Then
            Me.lblSecond.Text = 59
            Me.lblMinute.Text -= 1

        ElseIf Val(Me.lblHour.Text) = 0 And Val(Me.lblMinute.Text) = 0 And Val(Me.lblSecond.Text) > 0 Then
            Me.lblSecond.Text -= 1

        Else
            MsgBox("Times Up.", vbInformation, "Time")

            Dim question As Question
            For Each question In Me.Panel1.Controls
                sqlQuery = <sql>
                       INSERT INTO tblexamineeanswer (ExamineeID,Question,Answer,CorrectAnswer)
                        VALUES ('100001','<%= question.txtQuestion.Text.Replace("'", "\'") %>','<%= question.lblAnswer.Text.Replace("'", "\'") %>','<%= question.Label1.Text.Replace("'", "\'") %>')
                   </sql>

                SQLExecute(sqlQuery)


                ' question.lblAnswer.Text
            Next

            sqlQuery = <sql>
                       insert into tblresult (examineeid,,dateexam,score) values ('<%= Me.lblID.Text %>',CURDATE(),(
                       SELECT Count(*) FROM tblexamineeeanswer WHERE answer = correctanswer and examineeid = '<%= Me.lblID.Text %>'))
                   </sql>

            SQLExecute(sqlQuery)

            Me.Hide()
            FrmLogin.Show()

        End If
    End Sub

    Private Sub BunifuCards1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles BunifuCards1.Paint

    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHour.Click

    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMinute.Click

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSecond.Click

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lblID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblID.Click

    End Sub

    Private Sub lblName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblName.Click

    End Sub

    Private Sub BunifuCards2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles BunifuCards2.Paint

    End Sub
End Class
