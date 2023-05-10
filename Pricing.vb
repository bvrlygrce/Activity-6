Imports MySql.Data.MySqlClient

Public Class Pricing


    Private Sub ButtonLoadRec_Click(sender As Object, e As EventArgs) Handles ButtonLoadRec.Click
        Me.DataGridViewPrice.Rows.Clear()
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
            Me.DataGridViewPrice.Rows.Add(New Object() {myreader.Item("Price_ID"), myreader.Item("Price_unit"), myreader.Item("price_no")})
        End While
        Disconnect_to_DB()
    End Sub

End Class