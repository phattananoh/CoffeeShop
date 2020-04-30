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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.datagrid_search = New System.Windows.Forms.DataGridView()
        CType(Me.datagrid_search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(71, 22)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(277, 22)
        Me.txt_search.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search"
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.White
        Me.btn_search.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_search.Location = New System.Drawing.Point(125, 358)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(94, 37)
        Me.btn_search.TabIndex = 3
        Me.btn_search.Text = "Confirm"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'datagrid_search
        '
        Me.datagrid_search.AllowUserToAddRows = False
        Me.datagrid_search.AllowUserToDeleteRows = False
        Me.datagrid_search.BackgroundColor = System.Drawing.Color.DarkOliveGreen
        Me.datagrid_search.ColumnHeadersHeight = 29
        Me.datagrid_search.Location = New System.Drawing.Point(26, 63)
        Me.datagrid_search.Name = "datagrid_search"
        Me.datagrid_search.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_search.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagrid_search.RowHeadersVisible = False
        Me.datagrid_search.RowHeadersWidth = 40
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FloralWhite
        Me.datagrid_search.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.datagrid_search.RowTemplate.Height = 24
        Me.datagrid_search.RowTemplate.ReadOnly = True
        Me.datagrid_search.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_search.Size = New System.Drawing.Size(311, 289)
        Me.datagrid_search.TabIndex = 4
        '
        'frm_select_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(360, 407)
        Me.Controls.Add(Me.datagrid_search)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_search)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Name = "frm_select_customer"
        Me.Text = "Select Customer"
        CType(Me.datagrid_search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_search As Button
    Friend WithEvents datagrid_search As DataGridView
End Class
