Imports MySql.Data.MySqlClient

Public Class Form5

    Private Sub ButtonLoadRec2_Click(sender As Object, e As EventArgs) Handles ButtonLoadRec2.Click
        Me.DataGridView2.Rows.Clear()
        Dim strSQL As String
        Dim mycommand As New MySqlCommand
        strSQL = "Select * from difficulties"
        Connect_to_DB()
        With mycommand
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = strSQL
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            Me.DataGridView2.Rows.Add(New Object() {myreader.Item("Diff_code"), myreader.Item("Scale")})
        End While
        Disconnect_to_DB()
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Hide()
        Form1.Show()
    End Sub

End Class
