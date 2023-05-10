Imports MySql.Data.MySqlClient

Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            strSQL = "Select * from login_form where username='" _
            & .TextUsername.Text & "' and password= '" _
            & .TextPassword.Text & "' and email= '" _
            & .TextEmail.Text & "'"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                .Hide()
                Form1.Show()
            Else
                MessageBox.Show("Invalid username or password")
            End If
            Call Disconnect_to_DB()
        End With
    End Sub

    Private Sub Clear_Boxes()
        With Me
            .TextUsername.Text = ""
            .TextPassword.Text = ""
            .TextEmail.Text = ""
        End With
    End Sub

    Private Sub btnCreateAcc_Click(sender As Object, e As EventArgs) Handles btnCreateAcc.Click
        Hide()
        Create_Account.Show()


    End Sub

End Class

