Imports MySql.Data.MySqlClient

Public Class Form6
    Private Sub ButtonLoadDetails_Click(sender As Object, e As EventArgs) Handles ButtonLoadDetails.Click
        Me.DataGridView3.Rows.Clear()
        Dim strSQL As String
        Dim mycommand As New MySqlCommand
        strSQL = "Select * from deadline"
        Connect_to_DB()
        With mycommand
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = strSQL
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            Me.DataGridView3.Rows.Add(New Object() {myreader.Item("Code_ID"), myreader.Item("Days")})
        End While
        Disconnect_to_DB()
    End Sub

    Private Sub ButtonBack2_Click(sender As Object, e As EventArgs) Handles ButtonBack2.Click
        Hide()
        Form1.Show()
    End Sub
End Class