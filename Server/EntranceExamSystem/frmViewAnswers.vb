Imports System.Data.Odbc
Public Class frmViewAnswers
    Dim conn As OdbcConnection = New OdbcConnection("DSN=Server")
    Dim cmd As OdbcCommand
    Dim dt As DataTable
    Dim dr As OdbcDataReader
    Private Sub frmViewAnswers_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        frmResults.Show()
    End Sub
    '***Open and close connection
    Public Sub con()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    '*****Display record into the datagridview
    Private Sub refreshList()
        con()
        cmd = New OdbcCommand("SELECT * FROM tblexamineeanswer WHERE examineeid='" & frmResults.DataGridView1("examineeid", frmResults.DataGridView1.CurrentCellAddress.Y).Value.ToString & "'", conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        DataGridView1.Rows.Clear()
        Do While dr.Read = True
            DataGridView1.Rows.Add(dr(1), dr(2), dr(3))
        Loop
        DataGridView1.Refresh()
    End Sub
    Private Sub txtname_StyleChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.txtname.Text = StrConv(Me.txtname.Text, vbUpperCase)
    End Sub

    Private Sub frmViewAnswers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call refreshList()
    End Sub
End Class