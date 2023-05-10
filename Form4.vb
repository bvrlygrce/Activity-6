Imports MySql.Data.MySqlClient

Public Class Form4
    Private Sub ButtonLoadRec_Click(sender As Object, e As EventArgs) Handles ButtonLoadRec.Click
        Me.DataGridView1.Rows.Clear()
        Dim strSQL As String
        Dim mycommand As New MySqlCommand
        strSQL = "Select * from price "
        Connect_to_DB()
        With mycommand
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = strSQL
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            Me.DataGridView1.Rows.Add(New Object() {myreader.Item("Price_ID"), myreader.Item("Price_unit"), myreader.Item("price_no")})
        End While
        Disconnect_to_DB()
    End Sub


    Private Sub ButtonBack4_Click(sender As Object, e As EventArgs) Handles ButtonBack4.Click
        Hide()
        Form1.Show()
    End Sub
End Class