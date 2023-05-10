Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class Create_Account
    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Insert into login_form values('" _
                & .TextBoxID.Text & "', '" _
                & .TextBoxEmail.Text & "','" _
                & .TextBoxUsername.Text & "','" _
                & .TextBoxPassword.Text & "')"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("You Are Successfully Created An Account")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With
    End Sub
    Private Sub Clear_Boxes()
        With Me
            .TextBoxID.Text = ""
            .TextBoxEmail.Text = ""
            .TextBoxUsername.Text = ""
            .TextBoxPassword.Text = ""

        End With
    End Sub

    Private Sub LinkLOGIN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLOGIN.LinkClicked
        Hide()
        LoginForm1.Show()
    End Sub

    Private Sub Create_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class