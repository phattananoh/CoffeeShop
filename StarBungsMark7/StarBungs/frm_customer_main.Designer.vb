<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customer_main
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
        Me.txt_show_point = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.date_show_born = New System.Windows.Forms.DateTimePicker()
        Me.txt_show_password = New System.Windows.Forms.TextBox()
        Me.txt_show_username = New System.Windows.Forms.TextBox()
        Me.txt_show_tel = New System.Windows.Forms.TextBox()
        Me.txt_show_address = New System.Windows.Forms.TextBox()
        Me.txt_show_nickname = New System.Windows.Forms.TextBox()
        Me.txt_show_name = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_use_point = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.txt_coupon_code = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_use_coupon = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_history = New System.Windows.Forms.Button()
        Me.Datagrid_bill = New System.Windows.Forms.DataGridView()
        Me.Datagrid_list = New System.Windows.Forms.DataGridView()
        Me.Bill = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Datagrid_bill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datagrid_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_show_point
        '
        Me.txt_show_point.Enabled = False
        Me.txt_show_point.Location = New System.Drawing.Point(91, 272)
        Me.txt_show_point.Name = "txt_show_point"
        Me.txt_show_point.Size = New System.Drawing.Size(96, 22)
        Me.txt_show_point.TabIndex = 68
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(25, 275)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(60, 17)
        Me.Label25.TabIndex = 67
        Me.Label25.Text = "แต้มสะสม"
        '
        'date_show_born
        '
        Me.date_show_born.Location = New System.Drawing.Point(91, 140)
        Me.date_show_born.Name = "date_show_born"
        Me.date_show_born.Size = New System.Drawing.Size(167, 22)
        Me.date_show_born.TabIndex = 66
        '
        'txt_show_password
        '
        Me.txt_show_password.Location = New System.Drawing.Point(388, 94)
        Me.txt_show_password.Name = "txt_show_password"
        Me.txt_show_password.Size = New System.Drawing.Size(140, 22)
        Me.txt_show_password.TabIndex = 65
        '
        'txt_show_username
        '
        Me.txt_show_username.Enabled = False
        Me.txt_show_username.Location = New System.Drawing.Point(388, 50)
        Me.txt_show_username.Name = "txt_show_username"
        Me.txt_show_username.Size = New System.Drawing.Size(140, 22)
        Me.txt_show_username.TabIndex = 64
        '
        'txt_show_tel
        '
        Me.txt_show_tel.Location = New System.Drawing.Point(91, 230)
        Me.txt_show_tel.Name = "txt_show_tel"
        Me.txt_show_tel.Size = New System.Drawing.Size(167, 22)
        Me.txt_show_tel.TabIndex = 63
        '
        'txt_show_address
        '
        Me.txt_show_address.Location = New System.Drawing.Point(91, 186)
        Me.txt_show_address.Name = "txt_show_address"
        Me.txt_show_address.Size = New System.Drawing.Size(436, 22)
        Me.txt_show_address.TabIndex = 62
        '
        'txt_show_nickname
        '
        Me.txt_show_nickname.Location = New System.Drawing.Point(91, 94)
        Me.txt_show_nickname.Name = "txt_show_nickname"
        Me.txt_show_nickname.Size = New System.Drawing.Size(167, 22)
        Me.txt_show_nickname.TabIndex = 61
        '
        'txt_show_name
        '
        Me.txt_show_name.Location = New System.Drawing.Point(91, 50)
        Me.txt_show_name.Name = "txt_show_name"
        Me.txt_show_name.Size = New System.Drawing.Size(167, 22)
        Me.txt_show_name.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(309, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 17)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(309, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 17)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Username"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 17)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "เบอร์โทร"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 17)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "ที่อยู่"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "วันเกิด"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "ชื่อเล่น"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "ชื่อสกุล"
        '
        'btn_use_point
        '
        Me.btn_use_point.Location = New System.Drawing.Point(416, 271)
        Me.btn_use_point.Name = "btn_use_point"
        Me.btn_use_point.Size = New System.Drawing.Size(75, 23)
        Me.btn_use_point.TabIndex = 69
        Me.btn_use_point.Text = "ใช้แต้ม"
        Me.btn_use_point.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(140, 405)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(114, 23)
        Me.btn_edit.TabIndex = 70
        Me.btn_edit.Text = "บันทึกการแก้ไข"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.Location = New System.Drawing.Point(278, 405)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(114, 23)
        Me.btn_logout.TabIndex = 71
        Me.btn_logout.Text = "ออกจากระบบ"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'txt_coupon_code
        '
        Me.txt_coupon_code.Location = New System.Drawing.Point(21, 29)
        Me.txt_coupon_code.Name = "txt_coupon_code"
        Me.txt_coupon_code.Size = New System.Drawing.Size(167, 22)
        Me.txt_coupon_code.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Coupon Code"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_coupon_code)
        Me.Panel1.Location = New System.Drawing.Point(176, 322)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(202, 65)
        Me.Panel1.TabIndex = 74
        '
        'txt_use_coupon
        '
        Me.txt_use_coupon.Location = New System.Drawing.Point(296, 273)
        Me.txt_use_coupon.Name = "txt_use_coupon"
        Me.txt_use_coupon.Size = New System.Drawing.Size(96, 22)
        Me.txt_use_coupon.TabIndex = 75
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "ระบุแต้ม"
        '
        'btn_history
        '
        Me.btn_history.Location = New System.Drawing.Point(416, 350)
        Me.btn_history.Name = "btn_history"
        Me.btn_history.Size = New System.Drawing.Size(75, 23)
        Me.btn_history.TabIndex = 77
        Me.btn_history.Text = "ประวัติ"
        Me.btn_history.UseVisualStyleBackColor = True
        '
        'Datagrid_bill
        '
        Me.Datagrid_bill.AllowUserToAddRows = False
        Me.Datagrid_bill.AllowUserToDeleteRows = False
        Me.Datagrid_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datagrid_bill.Location = New System.Drawing.Point(606, 50)
        Me.Datagrid_bill.Name = "Datagrid_bill"
        Me.Datagrid_bill.ReadOnly = True
        Me.Datagrid_bill.RowHeadersVisible = False
        Me.Datagrid_bill.RowHeadersWidth = 51
        Me.Datagrid_bill.RowTemplate.Height = 24
        Me.Datagrid_bill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datagrid_bill.Size = New System.Drawing.Size(394, 158)
        Me.Datagrid_bill.TabIndex = 78
        '
        'Datagrid_list
        '
        Me.Datagrid_list.AllowUserToAddRows = False
        Me.Datagrid_list.AllowUserToDeleteRows = False
        Me.Datagrid_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datagrid_list.Location = New System.Drawing.Point(606, 229)
        Me.Datagrid_list.Name = "Datagrid_list"
        Me.Datagrid_list.ReadOnly = True
        Me.Datagrid_list.RowHeadersVisible = False
        Me.Datagrid_list.RowHeadersWidth = 51
        Me.Datagrid_list.RowTemplate.Height = 24
        Me.Datagrid_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datagrid_list.Size = New System.Drawing.Size(394, 158)
        Me.Datagrid_list.TabIndex = 79
        '
        'Bill
        '
        Me.Bill.AutoSize = True
        Me.Bill.Location = New System.Drawing.Point(606, 27)
        Me.Bill.Name = "Bill"
        Me.Bill.Size = New System.Drawing.Size(26, 17)
        Me.Bill.TabIndex = 80
        Me.Bill.Text = "Bill"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(606, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 17)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "list"
        '
        'frm_customer_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 450)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Bill)
        Me.Controls.Add(Me.Datagrid_list)
        Me.Controls.Add(Me.Datagrid_bill)
        Me.Controls.Add(Me.btn_history)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_use_coupon)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_use_point)
        Me.Controls.Add(Me.txt_show_point)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.date_show_born)
        Me.Controls.Add(Me.txt_show_password)
        Me.Controls.Add(Me.txt_show_username)
        Me.Controls.Add(Me.txt_show_tel)
        Me.Controls.Add(Me.txt_show_address)
        Me.Controls.Add(Me.txt_show_nickname)
        Me.Controls.Add(Me.txt_show_name)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frm_customer_main"
        Me.Text = "frm_customer_login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Datagrid_bill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datagrid_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_show_point As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents date_show_born As DateTimePicker
    Friend WithEvents txt_show_password As TextBox
    Friend WithEvents txt_show_username As TextBox
    Friend WithEvents txt_show_tel As TextBox
    Friend WithEvents txt_show_address As TextBox
    Friend WithEvents txt_show_nickname As TextBox
    Friend WithEvents txt_show_name As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_use_point As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_logout As Button
    Friend WithEvents txt_coupon_code As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_use_coupon As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_history As Button
    Friend WithEvents Datagrid_bill As DataGridView
    Friend WithEvents Datagrid_list As DataGridView
    Friend WithEvents Bill As Label
    Friend WithEvents Label10 As Label
End Class
