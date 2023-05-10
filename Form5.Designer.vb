<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Diff_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Scale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonLoadRec2 = New System.Windows.Forms.Button()
        Me.ButtonBack = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Diff_code, Me.Scale})
        Me.DataGridView2.Location = New System.Drawing.Point(552, 208)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(300, 313)
        Me.DataGridView2.TabIndex = 0
        '
        'Diff_code
        '
        Me.Diff_code.HeaderText = "Diff. Code"
        Me.Diff_code.MinimumWidth = 6
        Me.Diff_code.Name = "Diff_code"
        Me.Diff_code.Width = 125
        '
        'Scale
        '
        Me.Scale.HeaderText = "Diff. Scale"
        Me.Scale.MinimumWidth = 6
        Me.Scale.Name = "Scale"
        Me.Scale.Width = 125
        '
        'ButtonLoadRec2
        '
        Me.ButtonLoadRec2.BackColor = System.Drawing.Color.Sienna
        Me.ButtonLoadRec2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLoadRec2.Image = Global.StartHereDemo2.My.Resources.Resources._3
        Me.ButtonLoadRec2.Location = New System.Drawing.Point(1010, 582)
        Me.ButtonLoadRec2.Name = "ButtonLoadRec2"
        Me.ButtonLoadRec2.Size = New System.Drawing.Size(150, 44)
        Me.ButtonLoadRec2.TabIndex = 1
        Me.ButtonLoadRec2.Text = "Load Records"
        Me.ButtonLoadRec2.UseVisualStyleBackColor = False
        '
        'ButtonBack
        '
        Me.ButtonBack.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBack.Image = Global.StartHereDemo2.My.Resources.Resources._3
        Me.ButtonBack.Location = New System.Drawing.Point(1239, 701)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(129, 49)
        Me.ButtonBack.TabIndex = 2
        Me.ButtonBack.Text = "Back"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StartHereDemo2.My.Resources.Resources._3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1380, 762)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.ButtonLoadRec2)
        Me.Controls.Add(Me.DataGridView2)
        Me.DoubleBuffered = True
        Me.Name = "Form5"
        Me.Text = "Level of Difficulty"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Diff_code As DataGridViewTextBoxColumn
    Friend Shadows WithEvents Scale As DataGridViewTextBoxColumn
    Friend WithEvents ButtonLoadRec2 As Button
    Friend WithEvents ButtonBack As Button
End Class
