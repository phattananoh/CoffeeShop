<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_history
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
        Me.datagrid_history = New System.Windows.Forms.DataGridView()
        CType(Me.datagrid_history, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datagrid_history
        '
        Me.datagrid_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_history.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagrid_history.Location = New System.Drawing.Point(0, 0)
        Me.datagrid_history.Name = "datagrid_history"
        Me.datagrid_history.RowHeadersWidth = 51
        Me.datagrid_history.RowTemplate.Height = 24
        Me.datagrid_history.Size = New System.Drawing.Size(468, 450)
        Me.datagrid_history.TabIndex = 0
        '
        'frm_history
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 450)
        Me.Controls.Add(Me.datagrid_history)
        Me.Name = "frm_history"
        Me.Text = "frm_history"
        CType(Me.datagrid_history, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents datagrid_history As DataGridView
End Class
