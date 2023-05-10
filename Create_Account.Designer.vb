<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create_Account
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
        Me.ButtonCreate = New System.Windows.Forms.Button()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.LinkLOGIN = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'ButtonCreate
        '
        Me.ButtonCreate.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCreate.BackgroundImage = Global.StartHereDemo2.My.Resources.Resources._2
        Me.ButtonCreate.Cursor = System.Windows.Forms.Cursors.PanSW
        Me.ButtonCreate.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCreate.Location = New System.Drawing.Point(898, 610)
        Me.ButtonCreate.Name = "ButtonCreate"
        Me.ButtonCreate.Size = New System.Drawing.Size(118, 52)
        Me.ButtonCreate.TabIndex = 0
        Me.ButtonCreate.Text = "CREATE"
        Me.ButtonCreate.UseVisualStyleBackColor = False
        '
        'TextBoxID
        '
        Me.TextBoxID.BackColor = System.Drawing.Color.BurlyWood
        Me.TextBoxID.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxID.Location = New System.Drawing.Point(422, 242)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(491, 32)
        Me.TextBoxID.TabIndex = 1
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.BackColor = System.Drawing.Color.BurlyWood
        Me.TextBoxEmail.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmail.Location = New System.Drawing.Point(422, 340)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(491, 32)
        Me.TextBoxEmail.TabIndex = 2
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.BackColor = System.Drawing.Color.BurlyWood
        Me.TextBoxUsername.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsername.Location = New System.Drawing.Point(422, 444)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(491, 32)
        Me.TextBoxUsername.TabIndex = 3
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.BackColor = System.Drawing.Color.BurlyWood
        Me.TextBoxPassword.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.Location = New System.Drawing.Point(422, 536)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(491, 32)
        Me.TextBoxPassword.TabIndex = 4
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.BackColor = System.Drawing.Color.Transparent
        Me.LabelName.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(633, 277)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(87, 25)
        Me.LabelName.TabIndex = 5
        Me.LabelName.Text = "User ID"
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.BackColor = System.Drawing.Color.Transparent
        Me.LabelEmail.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.Location = New System.Drawing.Point(633, 375)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(70, 25)
        Me.LabelEmail.TabIndex = 6
        Me.LabelEmail.Text = "Email"
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.BackColor = System.Drawing.Color.Transparent
        Me.LabelUsername.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsername.Location = New System.Drawing.Point(617, 479)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(103, 25)
        Me.LabelUsername.TabIndex = 7
        Me.LabelUsername.Text = "Username"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.BackColor = System.Drawing.Color.Transparent
        Me.LabelPassword.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.Location = New System.Drawing.Point(621, 571)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(99, 25)
        Me.LabelPassword.TabIndex = 8
        Me.LabelPassword.Text = "Password"
        '
        'LinkLOGIN
        '
        Me.LinkLOGIN.ActiveLinkColor = System.Drawing.Color.Black
        Me.LinkLOGIN.AutoSize = True
        Me.LinkLOGIN.BackColor = System.Drawing.Color.Transparent
        Me.LinkLOGIN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LinkLOGIN.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLOGIN.LinkColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LinkLOGIN.Location = New System.Drawing.Point(1262, 697)
        Me.LinkLOGIN.Name = "LinkLOGIN"
        Me.LinkLOGIN.Size = New System.Drawing.Size(87, 26)
        Me.LinkLOGIN.TabIndex = 9
        Me.LinkLOGIN.TabStop = True
        Me.LinkLOGIN.Text = "LOGIN"
        '
        'Create_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StartHereDemo2.My.Resources.Resources._5
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1374, 746)
        Me.Controls.Add(Me.LinkLOGIN)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.ButtonCreate)
        Me.DoubleBuffered = True
        Me.Name = "Create_Account"
        Me.Text = "Create_Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonCreate As Button
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents LinkLOGIN As LinkLabel
End Class
