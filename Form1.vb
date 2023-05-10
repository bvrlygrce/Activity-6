Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.FileIO
Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Insert into client_info values('" _
                & .TextClient_no.Text & "', '" _
                & .TextFirstname.Text & "' , '" & .TextLastname.Text & "', '" & .TextProject.Text & "' , '" & .TextDifficulties.Text & "', '" & .TextDeadline.Text & "' , '" & .TextPrice.Text & "')"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Record Successfully Added")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub Clear_Boxes()
        With Me
            .TextClient_no.Text = ""
            .TextFirstname.Text = ""
            .TextLastname.Text = ""
            .TextProject.Text = ""
            .TextDifficulties.Text = ""
            .TextDeadline.Text = ""
            .TextPrice.Text = ""
        End With
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Update client_info set Firstname= '" _
                & .TextFirstname.Text & "' ,
                Lastname= '" & .TextLastname.Text & "',
                Project= '" & .TextProject.Text & "' ,
                Difficulties= '" & .TextDifficulties.Text & "',
                Deadline= '" & .TextDeadline.Text & "',
                Price= '" & .TextPrice.Text & "'
                where client_no='" & .TextClient_no.Text & "'"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Record Successfully Updated")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Delete from client_info where client_no='" & .TextClient_no.Text & "'"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Record Successfully Delete")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub loadrecords_Click(sender As Object, e As EventArgs) Handles loadrecords.Click
        Me.DataGridView1.Rows.Clear()
        Dim strSQL As String
        Dim mycommand As New MySqlCommand
        strSQL = "Select * from client_info "
        Connect_to_DB()
        With mycommand
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = strSQL
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            Me.DataGridView1.Rows.Add(New Object() {myreader.Item("Client_no"), myreader.Item("Firstname"), myreader.Item("Lastname") _
                    , myreader.Item("Project"), myreader.Item("Difficulties"), myreader.Item("Deadline"), myreader.Item("Price")})
        End While

        Disconnect_to_DB()
    End Sub

    Private Sub ImportRec_Click(sender As Object, e As EventArgs) Handles ImportRec.Click
        Dim filepath As String = ""

        ' Create a new instance of the OpenFileDialog
        Dim ImportRec As New OpenFileDialog()

        ' Set the default file extension and filter for the OpenFileDialog
        ImportRec.DefaultExt = ".csv"
        ImportRec.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"

        ' Show the OpenFileDialog box
        If ImportRec.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path
            filepath = ImportRec.FileName

            ' Handle any exceptions that may occur when reading the file
            Try
                Dim fileContent As String = File.ReadAllText(filepath)
                ' Do something with the file content
            Catch ex As Exception
                MessageBox.Show("Error reading file: " & ex.Message)
            End Try
        End If


        ' Load the CSV file into a DataTable
        Dim dt As New DataTable()
        Using sr As New StreamReader(filepath)
            Dim headers() As String = sr.ReadLine().Split(","c)
            For i As Integer = 0 To headers.Length - 1
                Select Case i
                    Case 0
                        dt.Columns.Add("Client No.")
                    Case 1
                        dt.Columns.Add("Firstname")
                    Case 2
                        dt.Columns.Add("Lastname")
                    Case 3
                        dt.Columns.Add("Project")
                    Case 4
                        dt.Columns.Add("Difficulties")
                    Case 5
                        dt.Columns.Add("Deadline")
                    Case 6
                        dt.Columns.Add("Price code")
                End Select
            Next
            While Not sr.EndOfStream
                Dim rows() As String = sr.ReadLine().Split(","c)
                If rows.Length <= 10 Then
                    Dim newRow As DataRow = dt.NewRow()
                    For i As Integer = 0 To rows.Length - 1
                        newRow(i) = rows(i)
                    Next
                    dt.Rows.Add(newRow)
                End If
            End While
        End Using

        ' Bind the DataTable to the DataGridView
        DataGridView1.DataSource = dt
    End Sub


    Private Sub backupRec_Click(sender As Object, e As EventArgs) Handles backupRec.Click
        ' Select the folder to save the backup file
        Dim folderBrowserDialog As New FolderBrowserDialog()
        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            ' Construct the full path for the backup file
            Dim filePath As String = Path.Combine(folderBrowserDialog.SelectedPath, "Backup.sql")

            ' Write the MySQL dump file
            Using sw As New StreamWriter(filePath)
                Dim connectionString As String = "Server=localhost;Port=3306;Database=mydatabase;Uid=root;Pwd=bgrce02162002;"
                Using myconn As New MySqlConnection(connectionString)
                    myconn.Open()
                    Using cmd As New MySqlCommand()
                        cmd.Connection = myconn
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = "SELECT @@VERSION;"
                        Dim version As String = cmd.ExecuteScalar()
                        sw.WriteLine("-- MySQL dump " & version)
                        sw.WriteLine("-- Created on " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                        sw.WriteLine("")
                        sw.WriteLine("-- USE mydatabase;")
                        sw.WriteLine("")
                        sw.WriteLine("DROP TABLE IF EXIST `client_info`;")
                        sw.WriteLine("")
                        sw.WriteLine("CREATE TABLE `client_info`;")
                        sw.WriteLine("`Client no.` int(15) NOT NULL AUTO_INCREMENT,")
                        sw.WriteLine("`First Name` varchar(225) NOT NULL,")
                        sw.WriteLine("`Last Name` varchar(225) NOT NULL,")
                        sw.WriteLine("`Project` int(15) NOT NULL,")
                        sw.WriteLine("`Difficulties` int(15) NOT NULL,")
                        sw.WriteLine("`Deadline` int(15) NOT NULL,")
                        sw.WriteLine("`Price` int(15) NOT NULL,")
                        sw.WriteLine("PRIMARY KEY (`Client no.`)")
                        sw.WriteLine(") ENGINE=InnoDB DEFAULT CHARSET=utf8;")
                        sw.WriteLine("")
                        Dim dt As DataTable = GetDataTable("SELECT * FROM `client_info`;", myconn)
                        If dt IsNot Nothing Then
                            For Each row As DataRow In dt.Rows
                                Dim values As New List(Of String)()
                                For Each col As DataColumn In dt.Columns
                                    values.Add("'" & row(col.ColumnName).ToString().Replace("'", "''") & "'")
                                Next
                                sw.WriteLine("INSERT INTO `client_info` (" & String.Join(", ", dt.Columns.Cast(Of DataColumn).Select(Function(c) "`" & c.ColumnName & "`")) & ") VALUES (" & String.Join(", ", values) & ");")
                            Next
                        End If
                    End Using
                End Using
            End Using
            MessageBox.Show("Backup completed successfully.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Function GetDataTable(ByVal strQSL As String, myconn As MySqlConnection) As DataTable
        Dim dt As New DataTable()
        Using da As New MySqlDataAdapter(strSQL, myconn)
            da.Fill(dt)
        End Using
        Return dt
    End Function

    Private Sub ButtonPricing_Click(sender As Object, e As EventArgs) Handles ButtonPricing.Click
        Hide()
        Form4.Show()
    End Sub

    Private Sub ButtonDiff_Click(sender As Object, e As EventArgs) Handles ButtonDiff.Click
        Hide()
        Form5.Show()
    End Sub

    Private Sub ButtonDeadline_Click(sender As Object, e As EventArgs) Handles ButtonDeadline.Click
        Hide()
        Form6.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Hide()
        LoginForm1.Show()
    End Sub

    Private Sub PrintRec_Click(sender As Object, e As EventArgs) Handles PrintRec.Click
        Me.Hide()
        Form7.Show()
    End Sub
End Class

