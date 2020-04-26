<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_select_customer
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
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datagrid_search = New System.Windows.Forms.DataGridView()
        Me.btn_search = New System.Windows.Forms.Button()
        CType(Me.datagrid_search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(58, 22)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(290, 22)
        Me.txt_search.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ค้นหา"
        '
        'datagrid_search
        '
        Me.datagrid_search.AllowUserToAddRows = False
        Me.datagrid_search.AllowUserToDeleteRows = False
        Me.datagrid_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_search.Location = New System.Drawing.Point(12, 50)
        Me.datagrid_search.Name = "datagrid_search"
        Me.datagrid_search.ReadOnly = True
        Me.datagrid_search.RowHeadersVisible = False
        Me.datagrid_search.RowHeadersWidth = 51
        Me.datagrid_search.RowTemplate.Height = 24
        Me.datagrid_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_search.Size = New System.Drawing.Size(336, 288)
        Me.datagrid_search.TabIndex = 2
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(138, 358)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 31)
        Me.btn_search.TabIndex = 3
        Me.btn_search.Text = "ตกลง"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'frm_select_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 407)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.datagrid_search)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_search)
        Me.Name = "frm_select_customer"
        Me.Text = "เลือกลูกค้า"
        CType(Me.datagrid_search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents datagrid_search As DataGridView
    Friend WithEvents btn_search As Button
End Class
