<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Code_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Days = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonLoadDetails = New System.Windows.Forms.Button()
        Me.ButtonBack2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code_ID, Me.Days})
        Me.DataGridView3.Location = New System.Drawing.Point(550, 240)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(305, 303)
        Me.DataGridView3.TabIndex = 0
        '
        'Code_ID
        '
        Me.Code_ID.HeaderText = "Code Id"
        Me.Code_ID.MinimumWidth = 6
        Me.Code_ID.Name = "Code_ID"
        Me.Code_ID.Width = 125
        '
        'Days
        '
        Me.Days.HeaderText = "Days"
        Me.Days.MinimumWidth = 6
        Me.Days.Name = "Days"
        Me.Days.Width = 125
        '
        'ButtonLoadDetails
        '
        Me.ButtonLoadDetails.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLoadDetails.Image = Global.StartHereDemo2.My.Resources.Resources._3
        Me.ButtonLoadDetails.Location = New System.Drawing.Point(1024, 580)
        Me.ButtonLoadDetails.Name = "ButtonLoadDetails"
        Me.ButtonLoadDetails.Size = New System.Drawing.Size(153, 51)
        Me.ButtonLoadDetails.TabIndex = 1
        Me.ButtonLoadDetails.Text = "Load Details"
        Me.ButtonLoadDetails.UseVisualStyleBackColor = True
        '
        'ButtonBack2
        '
        Me.ButtonBack2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBack2.Image = Global.StartHereDemo2.My.Resources.Resources._3
        Me.ButtonBack2.Location = New System.Drawing.Point(1252, 697)
        Me.ButtonBack2.Name = "ButtonBack2"
        Me.ButtonBack2.Size = New System.Drawing.Size(116, 45)
        Me.ButtonBack2.TabIndex = 2
        Me.ButtonBack2.Text = "Back"
        Me.ButtonBack2.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StartHereDemo2.My.Resources.Resources._3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1398, 768)
        Me.Controls.Add(Me.ButtonBack2)
        Me.Controls.Add(Me.ButtonLoadDetails)
        Me.Controls.Add(Me.DataGridView3)
        Me.DoubleBuffered = True
        Me.Name = "Form6"
        Me.Text = "Deadline Details"
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Code_ID As DataGridViewTextBoxColumn
    Friend WithEvents Days As DataGridViewTextBoxColumn
    Friend WithEvents ButtonLoadDetails As Button
    Friend WithEvents ButtonBack2 As Button
End Class
