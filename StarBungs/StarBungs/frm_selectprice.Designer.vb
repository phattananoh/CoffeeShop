<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_selectprice
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
        Me.rad_hot = New System.Windows.Forms.RadioButton()
        Me.rad_iced = New System.Windows.Forms.RadioButton()
        Me.rad_frappe = New System.Windows.Forms.RadioButton()
        Me.lbl_hot = New System.Windows.Forms.Label()
        Me.lbl_iced = New System.Windows.Forms.Label()
        Me.lbl_frappe = New System.Windows.Forms.Label()
        Me.btn_select = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_coffeeID = New System.Windows.Forms.Label()
        Me.lbl_coffeeName = New System.Windows.Forms.Label()
        Me.txt_amount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rad_hot
        '
        Me.rad_hot.AutoSize = True
        Me.rad_hot.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_hot.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rad_hot.Location = New System.Drawing.Point(90, 138)
        Me.rad_hot.Name = "rad_hot"
        Me.rad_hot.Size = New System.Drawing.Size(60, 29)
        Me.rad_hot.TabIndex = 0
        Me.rad_hot.TabStop = True
        Me.rad_hot.Text = "Hot"
        Me.rad_hot.UseVisualStyleBackColor = True
        '
        'rad_iced
        '
        Me.rad_iced.AutoSize = True
        Me.rad_iced.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_iced.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rad_iced.Location = New System.Drawing.Point(90, 208)
        Me.rad_iced.Name = "rad_iced"
        Me.rad_iced.Size = New System.Drawing.Size(69, 29)
        Me.rad_iced.TabIndex = 1
        Me.rad_iced.TabStop = True
        Me.rad_iced.Text = "Iced"
        Me.rad_iced.UseVisualStyleBackColor = True
        '
        'rad_frappe
        '
        Me.rad_frappe.AutoSize = True
        Me.rad_frappe.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_frappe.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rad_frappe.Location = New System.Drawing.Point(90, 281)
        Me.rad_frappe.Name = "rad_frappe"
        Me.rad_frappe.Size = New System.Drawing.Size(88, 29)
        Me.rad_frappe.TabIndex = 2
        Me.rad_frappe.TabStop = True
        Me.rad_frappe.Text = "Frappe"
        Me.rad_frappe.UseVisualStyleBackColor = True
        '
        'lbl_hot
        '
        Me.lbl_hot.AutoSize = True
        Me.lbl_hot.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_hot.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_hot.Location = New System.Drawing.Point(220, 142)
        Me.lbl_hot.Name = "lbl_hot"
        Me.lbl_hot.Size = New System.Drawing.Size(26, 29)
        Me.lbl_hot.TabIndex = 3
        Me.lbl_hot.Text = "0"
        '
        'lbl_iced
        '
        Me.lbl_iced.AutoSize = True
        Me.lbl_iced.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_iced.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_iced.Location = New System.Drawing.Point(220, 212)
        Me.lbl_iced.Name = "lbl_iced"
        Me.lbl_iced.Size = New System.Drawing.Size(26, 29)
        Me.lbl_iced.TabIndex = 4
        Me.lbl_iced.Text = "0"
        '
        'lbl_frappe
        '
        Me.lbl_frappe.AutoSize = True
        Me.lbl_frappe.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_frappe.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_frappe.Location = New System.Drawing.Point(220, 285)
        Me.lbl_frappe.Name = "lbl_frappe"
        Me.lbl_frappe.Size = New System.Drawing.Size(26, 29)
        Me.lbl_frappe.TabIndex = 5
        Me.lbl_frappe.Text = "0"
        '
        'btn_select
        '
        Me.btn_select.BackColor = System.Drawing.Color.White
        Me.btn_select.Font = New System.Drawing.Font("Impact", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_select.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_select.Location = New System.Drawing.Point(91, 412)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(155, 64)
        Me.btn_select.TabIndex = 6
        Me.btn_select.Text = "Confirm"
        Me.btn_select.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(33, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(33, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Menu"
        '
        'lbl_coffeeID
        '
        Me.lbl_coffeeID.AutoSize = True
        Me.lbl_coffeeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_coffeeID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_coffeeID.Location = New System.Drawing.Point(133, 24)
        Me.lbl_coffeeID.Name = "lbl_coffeeID"
        Me.lbl_coffeeID.Size = New System.Drawing.Size(23, 25)
        Me.lbl_coffeeID.TabIndex = 9
        Me.lbl_coffeeID.Text = "0"
        '
        'lbl_coffeeName
        '
        Me.lbl_coffeeName.AutoSize = True
        Me.lbl_coffeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_coffeeName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_coffeeName.Location = New System.Drawing.Point(133, 76)
        Me.lbl_coffeeName.Name = "lbl_coffeeName"
        Me.lbl_coffeeName.Size = New System.Drawing.Size(23, 25)
        Me.lbl_coffeeName.TabIndex = 10
        Me.lbl_coffeeName.Text = "0"
        '
        'txt_amount
        '
        Me.txt_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_amount.Location = New System.Drawing.Point(117, 348)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(100, 30)
        Me.txt_amount.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(246, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Cup"
        '
        'frm_selectprice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(343, 505)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_amount)
        Me.Controls.Add(Me.lbl_coffeeName)
        Me.Controls.Add(Me.lbl_coffeeID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_select)
        Me.Controls.Add(Me.lbl_frappe)
        Me.Controls.Add(Me.lbl_iced)
        Me.Controls.Add(Me.lbl_hot)
        Me.Controls.Add(Me.rad_frappe)
        Me.Controls.Add(Me.rad_iced)
        Me.Controls.Add(Me.rad_hot)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name = "frm_selectprice"
        Me.Text = "เลือกราคา"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rad_hot As RadioButton
    Friend WithEvents rad_iced As RadioButton
    Friend WithEvents rad_frappe As RadioButton
    Friend WithEvents lbl_hot As Label
    Friend WithEvents lbl_iced As Label
    Friend WithEvents lbl_frappe As Label
    Friend WithEvents btn_select As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_coffeeID As Label
    Friend WithEvents lbl_coffeeName As Label
    Friend WithEvents txt_amount As TextBox
    Friend WithEvents Label4 As Label
End Class
