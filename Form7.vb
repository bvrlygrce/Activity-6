Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.FileIO

Public Class Form7
    Public sqlColumns As String = "Client_no as client_no,  Firstname as firstname, Lastname as lastname, Project as project, Difficulties as difficulties, Deadline as deadline, Price as price"
    Private Sub Load_Data_to_Grid(ByVal strsql As String)
        Dim myreader As MySqlDataReader
        Dim mycommand As New MySqlCommand
        Dim mydataAdapter As New MySqlDataAdapter
        Dim mydatatable As New DataTable

        Connect_to_DB()
        With Me
            Try
                mycommand.Connection = myconn
                mycommand.CommandText = strsql
                myreader = mycommand.ExecuteReader
                mydatatable = New DataTable

                myreader.Close()
                mydataAdapter.SelectCommand = mycommand

                mydataAdapter.Fill(mydatatable)
                .DataGridView1.AutoSize = True
                .DataGridView1.Refresh()
                .DataGridView1.EndEdit()
                .DataGridView1.DataSource = mydatatable
                .DataGridView1.ReadOnly = True
                .DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                '.dgreport.Columns("order_total").DefaultCellStyle.Format = "#,##0.00"
                '.dgreport.Columns("category_name").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                '.dgreport.Columns("username").DefaultCellStyle.Format = "#,##0.00"
                '.dgreport.Columns("category_no").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            Catch ex As MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error on SQL query")
            End Try
            myreader = Nothing
            mycommand = Nothing
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'strSQL = "select " & Me.sqlColumns & " from Client_no"
        'Me.Label1.Text = strSQL
        Call Load_Data_to_Grid("select " & Me.sqlColumns & " from client_info")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'MsgBox(currentDate.ToString)
        Call importToExcel(Me.DataGridView1, "samplereport.xlsx")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class