<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm1
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
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents btnCreateAcc As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.OK = New System.Windows.Forms.Button()
        Me.btnCreateAcc = New System.Windows.Forms.Button()
        Me.TextPassword = New System.Windows.Forms.TextBox()
        Me.TextEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextUsername = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(801, 179)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(133, 40)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Username:"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.Transparent
        Me.OK.BackgroundImage = Global.StartHereDemo2.My.Resources.Resources._1
        Me.OK.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(997, 562)
        Me.OK.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(84, 34)
        Me.OK.TabIndex = 4
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = False
        '
        'btnCreateAcc
        '
        Me.btnCreateAcc.BackColor = System.Drawing.Color.Transparent
        Me.btnCreateAcc.BackgroundImage = Global.StartHereDemo2.My.Resources.Resources._2
        Me.btnCreateAcc.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnCreateAcc.Font = New System.Drawing.Font("Monotype Corsiva", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAcc.Location = New System.Drawing.Point(1152, 11)
        Me.btnCreateAcc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCreateAcc.Name = "btnCreateAcc"
        Me.btnCreateAcc.Size = New System.Drawing.Size(188, 44)
        Me.btnCreateAcc.TabIndex = 5
        Me.btnCreateAcc.Text = "Create Account"
        Me.btnCreateAcc.UseVisualStyleBackColor = False
        '
        'TextPassword
        '
        Me.TextPassword.BackColor = System.Drawing.Color.AntiqueWhite
        Me.TextPassword.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPassword.Location = New System.Drawing.Point(877, 362)
        Me.TextPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextPassword.Size = New System.Drawing.Size(337, 36)
        Me.TextPassword.TabIndex = 9
        '
        'TextEmail
        '
        Me.TextEmail.BackColor = System.Drawing.Color.AntiqueWhite
        Me.TextEmail.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEmail.Location = New System.Drawing.Point(877, 493)
        Me.TextEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextEmail.Name = "TextEmail"
        Me.TextEmail.Size = New System.Drawing.Size(337, 36)
        Me.TextEmail.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(820, 431)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 44)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Email:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(801, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 41)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextUsername
        '
        Me.TextUsername.BackColor = System.Drawing.Color.AntiqueWhite
        Me.TextUsername.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextUsername.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextUsername.Location = New System.Drawing.Point(877, 236)
        Me.TextUsername.Name = "TextUsername"
        Me.TextUsername.Size = New System.Drawing.Size(337, 36)
        Me.TextUsername.TabIndex = 10
        '
        'LoginForm1
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.StartHereDemo2.My.Resources.Resources._1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnCreateAcc
        Me.ClientSize = New System.Drawing.Size(1352, 715)
        Me.Controls.Add(Me.TextUsername)
        Me.Controls.Add(Me.TextPassword)
        Me.Controls.Add(Me.TextEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCreateAcc)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordLabel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextPassword As TextBox
    Friend WithEvents TextEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextUsername As TextBox
End Class
