
Module DBConnection

    Dim cmd As Odbc.OdbcCommand
    Dim conn As Odbc.OdbcConnection = New Odbc.OdbcConnection("DSN=Server")
    Dim dt As DataTable
    Dim dr As Odbc.OdbcDataReader
    Dim sql As String
    Dim result As Integer

    Function ExamCode(ByVal lenght As Integer) As String
        Dim strChar() As Char = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRST".ToCharArray()
        Dim str As String = ""
        Dim temp As String
        For x = 0 To lenght
            Dim xx As Integer
            Dim rnd As New Random
            xx = rnd.Next(0, strChar.Length)

            temp = strChar(xx.ToString)
            MsgBox(temp)
            str = str & temp
        Next
        Return str
    End Function

    Public Function getRecords(ByVal sql) As DataTable
        conn.Open()
        dt = New DataTable
        cmd = New Odbc.OdbcCommand(sql, conn)
        dt.Load(cmd.ExecuteReader, LoadOption.OverwriteChanges)
        conn.Close()
        Return dt
    End Function
    Public Sub Execute(ByVal sql)
        conn.Open()
        cmd = New Odbc.OdbcCommand(sql, conn)
        result = cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Function getValue(ByVal sql) As String
        conn.Open()
        dt = New DataTable
        cmd = New Odbc.OdbcCommand(sql, conn)
        dt.Load(cmd.ExecuteReader, LoadOption.OverwriteChanges)
        conn.Close()
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0).ToString
        Else
            Return ""
        End If
    End Function
    Public Function isAlready(ByVal sql) As Boolean
        conn.Open()
        dt = New DataTable
        cmd = New Odbc.OdbcCommand(sql, conn)
        dt.Load(cmd.ExecuteReader, LoadOption.OverwriteChanges)
        conn.Close()
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
End Module
