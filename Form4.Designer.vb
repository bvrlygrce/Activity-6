<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.ButtonLoadRec = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Price_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price_unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonBack4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonLoadRec
        '
        Me.ButtonLoadRec.BackColor = System.Drawing.Color.Transparent
        Me.ButtonLoadRec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonLoadRec.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLoadRec.Image = Global.StartHereDemo2.My.Resources.Resources._3
        Me.ButtonLoadRec.Location = New System.Drawing.Point(1187, 590)
        Me.ButtonLoadRec.Name = "ButtonLoadRec"
        Me.ButtonLoadRec.Size = New System.Drawing.Size(157, 56)
        Me.ButtonLoadRec.TabIndex = 3
        Me.ButtonLoadRec.Text = "Load Records"
        Me.ButtonLoadRec.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Price_Id, Me.Price_unit, Me.price_no})
        Me.DataGridView1.Location = New System.Drawing.Point(599, 180)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(466, 419)
        Me.DataGridView1.TabIndex = 4
        '
        'Price_Id
        '
        Me.Price_Id.HeaderText = "Price Id"
        Me.Price_Id.MinimumWidth = 6
        Me.Price_Id.Name = "Price_Id"
        Me.Price_Id.Width = 125
        '
        'Price_unit
        '
        Me.Price_unit.HeaderText = "Unit"
        Me.Price_unit.MinimumWidth = 6
        Me.Price_unit.Name = "Price_unit"
        Me.Price_unit.Width = 125
        '
        'price_no
        '
        Me.price_no.HeaderText = "No."
        Me.price_no.MinimumWidth = 6
        Me.price_no.Name = "price_no"
        Me.price_no.Width = 125
        '
        'ButtonBack4
        '
        Me.ButtonBack4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonBack4.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBack4.Image = Global.StartHereDemo2.My.Resources.Resources._3
        Me.ButtonBack4.Location = New System.Drawing.Point(1454, 733)
        Me.ButtonBack4.Name = "ButtonBack4"
        Me.ButtonBack4.Size = New System.Drawing.Size(116, 39)
        Me.ButtonBack4.TabIndex = 5
        Me.ButtonBack4.Text = "Back"
        Me.ButtonBack4.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StartHereDemo2.My.Resources.Resources._3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1596, 784)
        Me.Controls.Add(Me.ButtonBack4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonLoadRec)
        Me.DoubleBuffered = True
        Me.Name = "Form4"
        Me.Text = "Price Details"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonLoadRec As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Price_Id As DataGridViewTextBoxColumn
    Friend WithEvents Price_unit As DataGridViewTextBoxColumn
    Friend WithEvents price_no As DataGridViewTextBoxColumn
    Friend WithEvents ButtonBack4 As Button
End Class
