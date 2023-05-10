<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pricing
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
        Me.DataGridViewPrice = New System.Windows.Forms.DataGridView()
        Me.ButtonLoadRec = New System.Windows.Forms.Button()
        Me.Price_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price_unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewPrice
        '
        Me.DataGridViewPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPrice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Price_ID, Me.Price_unit, Me.price_no})
        Me.DataGridViewPrice.Location = New System.Drawing.Point(127, 60)
        Me.DataGridViewPrice.Name = "DataGridViewPrice"
        Me.DataGridViewPrice.RowHeadersWidth = 51
        Me.DataGridViewPrice.RowTemplate.Height = 24
        Me.DataGridViewPrice.Size = New System.Drawing.Size(430, 210)
        Me.DataGridViewPrice.TabIndex = 0
        '
        'ButtonLoadRec
        '
        Me.ButtonLoadRec.Location = New System.Drawing.Point(421, 288)
        Me.ButtonLoadRec.Name = "ButtonLoadRec"
        Me.ButtonLoadRec.Size = New System.Drawing.Size(136, 37)
        Me.ButtonLoadRec.TabIndex = 1
        Me.ButtonLoadRec.Text = "Load Records"
        Me.ButtonLoadRec.UseVisualStyleBackColor = True
        '
        'Price_ID
        '
        Me.Price_ID.HeaderText = "Price ID"
        Me.Price_ID.MinimumWidth = 6
        Me.Price_ID.Name = "Price_ID"
        Me.Price_ID.Width = 125
        '
        'Price_unit
        '
        Me.Price_unit.HeaderText = "Price Unit"
        Me.Price_unit.MinimumWidth = 6
        Me.Price_unit.Name = "Price_unit"
        Me.Price_unit.Width = 125
        '
        'price_no
        '
        Me.price_no.HeaderText = "Price No."
        Me.price_no.MinimumWidth = 6
        Me.price_no.Name = "price_no"
        Me.price_no.Width = 125
        '
        'Price
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonLoadRec)
        Me.Controls.Add(Me.DataGridViewPrice)
        Me.Name = "Price"
        Me.Text = "Price"
        CType(Me.DataGridViewPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewPrice As DataGridView
    Friend WithEvents ButtonLoadRec As Button
    Friend WithEvents Price_ID As DataGridViewTextBoxColumn
    Friend WithEvents Price_unit As DataGridViewTextBoxColumn
    Friend WithEvents price_no As DataGridViewTextBoxColumn
End Class
