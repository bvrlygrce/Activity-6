<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextClient_no = New System.Windows.Forms.TextBox()
        Me.TextFirstname = New System.Windows.Forms.TextBox()
        Me.TextProject = New System.Windows.Forms.TextBox()
        Me.TextLastname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextDeadline = New System.Windows.Forms.TextBox()
        Me.TextDifficulties = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Client_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Firstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Project = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Difficulties = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deadline = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loadrecords = New System.Windows.Forms.Button()
        Me.ButtonPricing = New System.Windows.Forms.Button()
        Me.ButtonDiff = New System.Windows.Forms.Button()
        Me.ButtonDeadline = New System.Windows.Forms.Button()
        Me.backupRec = New System.Windows.Forms.Button()
        Me.ImportRec = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.PrintRec = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(24, 401)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(192, 44)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Record"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(58, 69)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(98, 22)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Client no."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First Name"
        '
        'TextClient_no
        '
        Me.TextClient_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextClient_no.Location = New System.Drawing.Point(218, 61)
        Me.TextClient_no.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextClient_no.Name = "TextClient_no"
        Me.TextClient_no.Size = New System.Drawing.Size(189, 30)
        Me.TextClient_no.TabIndex = 3
        '
        'TextFirstname
        '
        Me.TextFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFirstname.Location = New System.Drawing.Point(218, 102)
        Me.TextFirstname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextFirstname.Name = "TextFirstname"
        Me.TextFirstname.Size = New System.Drawing.Size(189, 30)
        Me.TextFirstname.TabIndex = 4
        '
        'TextProject
        '
        Me.TextProject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextProject.Location = New System.Drawing.Point(218, 196)
        Me.TextProject.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextProject.Name = "TextProject"
        Me.TextProject.Size = New System.Drawing.Size(189, 30)
        Me.TextProject.TabIndex = 8
        '
        'TextLastname
        '
        Me.TextLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextLastname.Location = New System.Drawing.Point(218, 149)
        Me.TextLastname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextLastname.Name = "TextLastname"
        Me.TextLastname.Size = New System.Drawing.Size(189, 30)
        Me.TextLastname.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Project"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Name"
        '
        'TextDeadline
        '
        Me.TextDeadline.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDeadline.Location = New System.Drawing.Point(218, 286)
        Me.TextDeadline.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextDeadline.Name = "TextDeadline"
        Me.TextDeadline.Size = New System.Drawing.Size(189, 30)
        Me.TextDeadline.TabIndex = 12
        '
        'TextDifficulties
        '
        Me.TextDifficulties.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDifficulties.Location = New System.Drawing.Point(218, 242)
        Me.TextDifficulties.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextDifficulties.Name = "TextDifficulties"
        Me.TextDifficulties.Size = New System.Drawing.Size(189, 30)
        Me.TextDifficulties.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 22)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Deadline"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Difficulties"
        '
        'TextPrice
        '
        Me.TextPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPrice.Location = New System.Drawing.Point(218, 331)
        Me.TextPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextPrice.Name = "TextPrice"
        Me.TextPrice.Size = New System.Drawing.Size(189, 30)
        Me.TextPrice.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(69, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 22)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Price"
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdate.Location = New System.Drawing.Point(239, 401)
        Me.ButtonUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(192, 44)
        Me.ButtonUpdate.TabIndex = 15
        Me.ButtonUpdate.Text = "Update Record"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.Location = New System.Drawing.Point(130, 449)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(192, 38)
        Me.ButtonDelete.TabIndex = 16
        Me.ButtonDelete.Text = "Delete Record"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Client_no, Me.Firstname, Me.Lastname, Me.Project, Me.Difficulties, Me.Deadline, Me.Price})
        Me.DataGridView1.Location = New System.Drawing.Point(465, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(930, 399)
        Me.DataGridView1.TabIndex = 17
        '
        'Client_no
        '
        Me.Client_no.HeaderText = "Client No."
        Me.Client_no.MinimumWidth = 6
        Me.Client_no.Name = "Client_no"
        Me.Client_no.Width = 125
        '
        'Firstname
        '
        Me.Firstname.HeaderText = "Firstname"
        Me.Firstname.MinimumWidth = 6
        Me.Firstname.Name = "Firstname"
        Me.Firstname.Width = 125
        '
        'Lastname
        '
        Me.Lastname.HeaderText = "Lastname"
        Me.Lastname.MinimumWidth = 6
        Me.Lastname.Name = "Lastname"
        Me.Lastname.Width = 125
        '
        'Project
        '
        Me.Project.HeaderText = "Project"
        Me.Project.MinimumWidth = 6
        Me.Project.Name = "Project"
        Me.Project.Width = 125
        '
        'Difficulties
        '
        Me.Difficulties.HeaderText = "Difficulties"
        Me.Difficulties.MinimumWidth = 6
        Me.Difficulties.Name = "Difficulties"
        Me.Difficulties.Width = 125
        '
        'Deadline
        '
        Me.Deadline.HeaderText = "Deadline"
        Me.Deadline.MinimumWidth = 6
        Me.Deadline.Name = "Deadline"
        Me.Deadline.Width = 125
        '
        'Price
        '
        Me.Price.HeaderText = "Price Code"
        Me.Price.MinimumWidth = 6
        Me.Price.Name = "Price"
        Me.Price.Width = 125
        '
        'loadrecords
        '
        Me.loadrecords.BackColor = System.Drawing.Color.Transparent
        Me.loadrecords.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadrecords.Location = New System.Drawing.Point(465, 484)
        Me.loadrecords.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.loadrecords.Name = "loadrecords"
        Me.loadrecords.Size = New System.Drawing.Size(192, 44)
        Me.loadrecords.TabIndex = 18
        Me.loadrecords.Text = "Load Records"
        Me.loadrecords.UseVisualStyleBackColor = False
        '
        'ButtonPricing
        '
        Me.ButtonPricing.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPricing.Location = New System.Drawing.Point(31, 570)
        Me.ButtonPricing.Name = "ButtonPricing"
        Me.ButtonPricing.Size = New System.Drawing.Size(137, 46)
        Me.ButtonPricing.TabIndex = 19
        Me.ButtonPricing.Text = "Pricing"
        Me.ButtonPricing.UseVisualStyleBackColor = True
        '
        'ButtonDiff
        '
        Me.ButtonDiff.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDiff.Location = New System.Drawing.Point(31, 622)
        Me.ButtonDiff.Name = "ButtonDiff"
        Me.ButtonDiff.Size = New System.Drawing.Size(137, 46)
        Me.ButtonDiff.TabIndex = 20
        Me.ButtonDiff.Text = "Difficulties Scale"
        Me.ButtonDiff.UseVisualStyleBackColor = True
        '
        'ButtonDeadline
        '
        Me.ButtonDeadline.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDeadline.Location = New System.Drawing.Point(31, 674)
        Me.ButtonDeadline.Name = "ButtonDeadline"
        Me.ButtonDeadline.Size = New System.Drawing.Size(137, 46)
        Me.ButtonDeadline.TabIndex = 21
        Me.ButtonDeadline.Text = "Deadline"
        Me.ButtonDeadline.UseVisualStyleBackColor = True
        '
        'backupRec
        '
        Me.backupRec.BackColor = System.Drawing.Color.Transparent
        Me.backupRec.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backupRec.Location = New System.Drawing.Point(1203, 484)
        Me.backupRec.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.backupRec.Name = "backupRec"
        Me.backupRec.Size = New System.Drawing.Size(192, 44)
        Me.backupRec.TabIndex = 22
        Me.backupRec.Text = "BackUp Records"
        Me.backupRec.UseVisualStyleBackColor = False
        '
        'ImportRec
        '
        Me.ImportRec.BackColor = System.Drawing.Color.Transparent
        Me.ImportRec.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImportRec.Location = New System.Drawing.Point(663, 484)
        Me.ImportRec.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ImportRec.Name = "ImportRec"
        Me.ImportRec.Size = New System.Drawing.Size(192, 44)
        Me.ImportRec.TabIndex = 23
        Me.ImportRec.Text = "Import"
        Me.ImportRec.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(1288, 674)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(137, 46)
        Me.BackButton.TabIndex = 24
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'PrintRec
        '
        Me.PrintRec.BackColor = System.Drawing.Color.Transparent
        Me.PrintRec.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintRec.Location = New System.Drawing.Point(1005, 484)
        Me.PrintRec.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PrintRec.Name = "PrintRec"
        Me.PrintRec.Size = New System.Drawing.Size(192, 44)
        Me.PrintRec.TabIndex = 25
        Me.PrintRec.Text = "Print Records"
        Me.PrintRec.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StartHereDemo2.My.Resources.Resources._2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1450, 743)
        Me.Controls.Add(Me.PrintRec)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ImportRec)
        Me.Controls.Add(Me.backupRec)
        Me.Controls.Add(Me.ButtonDeadline)
        Me.Controls.Add(Me.ButtonDiff)
        Me.Controls.Add(Me.ButtonPricing)
        Me.Controls.Add(Me.loadrecords)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.TextPrice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextDeadline)
        Me.Controls.Add(Me.TextDifficulties)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextProject)
        Me.Controls.Add(Me.TextLastname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextFirstname)
        Me.Controls.Add(Me.TextClient_no)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnAdd)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextClient_no As TextBox
    Friend WithEvents TextFirstname As TextBox
    Friend WithEvents TextProject As TextBox
    Friend WithEvents TextLastname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextDeadline As TextBox
    Friend WithEvents TextDifficulties As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextPrice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Client_no As DataGridViewTextBoxColumn
    Friend WithEvents Firstname As DataGridViewTextBoxColumn
    Friend WithEvents Lastname As DataGridViewTextBoxColumn
    Friend WithEvents Project As DataGridViewTextBoxColumn
    Friend WithEvents Difficulties As DataGridViewTextBoxColumn
    Friend WithEvents Deadline As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents loadrecords As Button
    Friend WithEvents ButtonPricing As Button
    Friend WithEvents ButtonDiff As Button
    Friend WithEvents ButtonDeadline As Button
    Friend WithEvents backupRec As Button
    Public WithEvents ImportRec As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents PrintRec As Button
End Class
