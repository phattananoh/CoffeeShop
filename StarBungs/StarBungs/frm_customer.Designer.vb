<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customer
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.datagrid_search = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.date_show_born = New System.Windows.Forms.DateTimePicker()
        Me.txt_show_password = New System.Windows.Forms.TextBox()
        Me.txt_show_username = New System.Windows.Forms.TextBox()
        Me.txt_show_tel = New System.Windows.Forms.TextBox()
        Me.txt_show_address = New System.Windows.Forms.TextBox()
        Me.txt_show_nickname = New System.Windows.Forms.TextBox()
        Me.txt_show_name = New System.Windows.Forms.TextBox()
        Me.datagrid_show_customer = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.date_add_born = New System.Windows.Forms.DateTimePicker()
        Me.txt_add_password = New System.Windows.Forms.TextBox()
        Me.txt_add_username = New System.Windows.Forms.TextBox()
        Me.txt_add_tel = New System.Windows.Forms.TextBox()
        Me.txt_add_address = New System.Windows.Forms.TextBox()
        Me.txt_add_nickname = New System.Windows.Forms.TextBox()
        Me.txt_add_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_add_save = New System.Windows.Forms.Button()
        Me.btn_add_clear = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn_edit_cancel = New System.Windows.Forms.Button()
        Me.btn_edit_button = New System.Windows.Forms.Button()
        Me.date_edit_born = New System.Windows.Forms.DateTimePicker()
        Me.txt_edit_password = New System.Windows.Forms.TextBox()
        Me.txt_edit_username = New System.Windows.Forms.TextBox()
        Me.txt_edit_tel = New System.Windows.Forms.TextBox()
        Me.txt_edit_address = New System.Windows.Forms.TextBox()
        Me.txt_edit_nickname = New System.Windows.Forms.TextBox()
        Me.txt_edit_name = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_edit_point = New System.Windows.Forms.TextBox()
        Me.txt_show_point = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.datagrid_search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.datagrid_show_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.datagrid_search)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 450)
        Me.Panel1.TabIndex = 0
        '
        'datagrid_search
        '
        Me.datagrid_search.AllowUserToAddRows = False
        Me.datagrid_search.AllowUserToDeleteRows = False
        Me.datagrid_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_search.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagrid_search.Location = New System.Drawing.Point(0, 61)
        Me.datagrid_search.Name = "datagrid_search"
        Me.datagrid_search.ReadOnly = True
        Me.datagrid_search.RowHeadersWidth = 51
        Me.datagrid_search.RowTemplate.Height = 24
        Me.datagrid_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_search.Size = New System.Drawing.Size(266, 389)
        Me.datagrid_search.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txt_search)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(266, 61)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ค้นหา"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(84, 18)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(154, 22)
        Me.txt_search.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(266, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(534, 450)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_show_point)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.date_show_born)
        Me.TabPage1.Controls.Add(Me.txt_show_password)
        Me.TabPage1.Controls.Add(Me.txt_show_username)
        Me.TabPage1.Controls.Add(Me.txt_show_tel)
        Me.TabPage1.Controls.Add(Me.txt_show_address)
        Me.TabPage1.Controls.Add(Me.txt_show_nickname)
        Me.TabPage1.Controls.Add(Me.txt_show_name)
        Me.TabPage1.Controls.Add(Me.datagrid_show_customer)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(526, 421)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "แสดงข้อมูล"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'date_show_born
        '
        Me.date_show_born.Enabled = False
        Me.date_show_born.Location = New System.Drawing.Point(81, 117)
        Me.date_show_born.Name = "date_show_born"
        Me.date_show_born.Size = New System.Drawing.Size(167, 22)
        Me.date_show_born.TabIndex = 16
        '
        'txt_show_password
        '
        Me.txt_show_password.Enabled = False
        Me.txt_show_password.Location = New System.Drawing.Point(378, 71)
        Me.txt_show_password.Name = "txt_show_password"
        Me.txt_show_password.Size = New System.Drawing.Size(140, 22)
        Me.txt_show_password.TabIndex = 15
        '
        'txt_show_username
        '
        Me.txt_show_username.Enabled = False
        Me.txt_show_username.Location = New System.Drawing.Point(378, 27)
        Me.txt_show_username.Name = "txt_show_username"
        Me.txt_show_username.Size = New System.Drawing.Size(140, 22)
        Me.txt_show_username.TabIndex = 14
        '
        'txt_show_tel
        '
        Me.txt_show_tel.Enabled = False
        Me.txt_show_tel.Location = New System.Drawing.Point(81, 207)
        Me.txt_show_tel.Name = "txt_show_tel"
        Me.txt_show_tel.Size = New System.Drawing.Size(167, 22)
        Me.txt_show_tel.TabIndex = 12
        '
        'txt_show_address
        '
        Me.txt_show_address.Enabled = False
        Me.txt_show_address.Location = New System.Drawing.Point(81, 163)
        Me.txt_show_address.Name = "txt_show_address"
        Me.txt_show_address.Size = New System.Drawing.Size(436, 22)
        Me.txt_show_address.TabIndex = 11
        '
        'txt_show_nickname
        '
        Me.txt_show_nickname.Enabled = False
        Me.txt_show_nickname.Location = New System.Drawing.Point(81, 71)
        Me.txt_show_nickname.Name = "txt_show_nickname"
        Me.txt_show_nickname.Size = New System.Drawing.Size(167, 22)
        Me.txt_show_nickname.TabIndex = 9
        '
        'txt_show_name
        '
        Me.txt_show_name.Enabled = False
        Me.txt_show_name.Location = New System.Drawing.Point(81, 27)
        Me.txt_show_name.Name = "txt_show_name"
        Me.txt_show_name.Size = New System.Drawing.Size(167, 22)
        Me.txt_show_name.TabIndex = 2
        '
        'datagrid_show_customer
        '
        Me.datagrid_show_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_show_customer.Location = New System.Drawing.Point(6, 290)
        Me.datagrid_show_customer.Name = "datagrid_show_customer"
        Me.datagrid_show_customer.RowHeadersWidth = 51
        Me.datagrid_show_customer.RowTemplate.Height = 24
        Me.datagrid_show_customer.Size = New System.Drawing.Size(512, 125)
        Me.datagrid_show_customer.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(299, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(299, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Username"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "เบอร์โทร"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "ที่อยู่"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "วันเกิด"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ชื่อเล่น"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ชื่อสกุล"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_add_clear)
        Me.TabPage2.Controls.Add(Me.btn_add_save)
        Me.TabPage2.Controls.Add(Me.date_add_born)
        Me.TabPage2.Controls.Add(Me.txt_add_password)
        Me.TabPage2.Controls.Add(Me.txt_add_username)
        Me.TabPage2.Controls.Add(Me.txt_add_tel)
        Me.TabPage2.Controls.Add(Me.txt_add_address)
        Me.TabPage2.Controls.Add(Me.txt_add_nickname)
        Me.TabPage2.Controls.Add(Me.txt_add_name)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(526, 421)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "เพิ่ม"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.btn_delete)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(526, 421)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "ลบ"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.txt_edit_point)
        Me.TabPage4.Controls.Add(Me.Label24)
        Me.TabPage4.Controls.Add(Me.btn_edit_cancel)
        Me.TabPage4.Controls.Add(Me.btn_edit_button)
        Me.TabPage4.Controls.Add(Me.date_edit_born)
        Me.TabPage4.Controls.Add(Me.txt_edit_password)
        Me.TabPage4.Controls.Add(Me.txt_edit_username)
        Me.TabPage4.Controls.Add(Me.txt_edit_tel)
        Me.TabPage4.Controls.Add(Me.txt_edit_address)
        Me.TabPage4.Controls.Add(Me.txt_edit_nickname)
        Me.TabPage4.Controls.Add(Me.txt_edit_name)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Controls.Add(Me.Label18)
        Me.TabPage4.Controls.Add(Me.Label19)
        Me.TabPage4.Controls.Add(Me.Label20)
        Me.TabPage4.Controls.Add(Me.Label21)
        Me.TabPage4.Controls.Add(Me.Label22)
        Me.TabPage4.Controls.Add(Me.Label23)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(526, 421)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "แก้ไข"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'date_add_born
        '
        Me.date_add_born.Location = New System.Drawing.Point(81, 123)
        Me.date_add_born.Name = "date_add_born"
        Me.date_add_born.Size = New System.Drawing.Size(167, 22)
        Me.date_add_born.TabIndex = 30
        '
        'txt_add_password
        '
        Me.txt_add_password.Location = New System.Drawing.Point(378, 77)
        Me.txt_add_password.Name = "txt_add_password"
        Me.txt_add_password.Size = New System.Drawing.Size(140, 22)
        Me.txt_add_password.TabIndex = 29
        '
        'txt_add_username
        '
        Me.txt_add_username.Location = New System.Drawing.Point(378, 33)
        Me.txt_add_username.Name = "txt_add_username"
        Me.txt_add_username.Size = New System.Drawing.Size(140, 22)
        Me.txt_add_username.TabIndex = 28
        '
        'txt_add_tel
        '
        Me.txt_add_tel.Location = New System.Drawing.Point(81, 213)
        Me.txt_add_tel.Name = "txt_add_tel"
        Me.txt_add_tel.Size = New System.Drawing.Size(167, 22)
        Me.txt_add_tel.TabIndex = 27
        '
        'txt_add_address
        '
        Me.txt_add_address.Location = New System.Drawing.Point(82, 169)
        Me.txt_add_address.Name = "txt_add_address"
        Me.txt_add_address.Size = New System.Drawing.Size(436, 22)
        Me.txt_add_address.TabIndex = 26
        '
        'txt_add_nickname
        '
        Me.txt_add_nickname.Location = New System.Drawing.Point(81, 77)
        Me.txt_add_nickname.Name = "txt_add_nickname"
        Me.txt_add_nickname.Size = New System.Drawing.Size(167, 22)
        Me.txt_add_nickname.TabIndex = 25
        '
        'txt_add_name
        '
        Me.txt_add_name.Location = New System.Drawing.Point(81, 33)
        Me.txt_add_name.Name = "txt_add_name"
        Me.txt_add_name.Size = New System.Drawing.Size(167, 22)
        Me.txt_add_name.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(299, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Password"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(299, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 17)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Username"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "เบอร์โทร"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 17)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "ที่อยู่"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 123)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 17)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "วันเกิด"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 17)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "ชื่อเล่น"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 17)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "ชื่อสกุล"
        '
        'btn_add_save
        '
        Me.btn_add_save.Location = New System.Drawing.Point(154, 294)
        Me.btn_add_save.Name = "btn_add_save"
        Me.btn_add_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_add_save.TabIndex = 31
        Me.btn_add_save.Text = "Save"
        Me.btn_add_save.UseVisualStyleBackColor = True
        '
        'btn_add_clear
        '
        Me.btn_add_clear.Location = New System.Drawing.Point(293, 294)
        Me.btn_add_clear.Name = "btn_add_clear"
        Me.btn_add_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_add_clear.TabIndex = 32
        Me.btn_add_clear.Text = "Clear"
        Me.btn_add_clear.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(223, 194)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 0
        Me.btn_delete.Text = "ลบ"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(144, 151)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(247, 17)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "การลบลูกค้าจะไม่สามารถนำกลับมาใช้ใหม่ได้"
        '
        'btn_edit_cancel
        '
        Me.btn_edit_cancel.Location = New System.Drawing.Point(292, 328)
        Me.btn_edit_cancel.Name = "btn_edit_cancel"
        Me.btn_edit_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_edit_cancel.TabIndex = 48
        Me.btn_edit_cancel.Text = "Cancel"
        Me.btn_edit_cancel.UseVisualStyleBackColor = True
        '
        'btn_edit_button
        '
        Me.btn_edit_button.Location = New System.Drawing.Point(152, 328)
        Me.btn_edit_button.Name = "btn_edit_button"
        Me.btn_edit_button.Size = New System.Drawing.Size(75, 23)
        Me.btn_edit_button.TabIndex = 47
        Me.btn_edit_button.Text = "Edit"
        Me.btn_edit_button.UseVisualStyleBackColor = True
        '
        'date_edit_born
        '
        Me.date_edit_born.Location = New System.Drawing.Point(80, 123)
        Me.date_edit_born.Name = "date_edit_born"
        Me.date_edit_born.Size = New System.Drawing.Size(167, 22)
        Me.date_edit_born.TabIndex = 46
        '
        'txt_edit_password
        '
        Me.txt_edit_password.Location = New System.Drawing.Point(377, 77)
        Me.txt_edit_password.Name = "txt_edit_password"
        Me.txt_edit_password.Size = New System.Drawing.Size(140, 22)
        Me.txt_edit_password.TabIndex = 45
        '
        'txt_edit_username
        '
        Me.txt_edit_username.Enabled = False
        Me.txt_edit_username.Location = New System.Drawing.Point(377, 33)
        Me.txt_edit_username.Name = "txt_edit_username"
        Me.txt_edit_username.Size = New System.Drawing.Size(140, 22)
        Me.txt_edit_username.TabIndex = 44
        '
        'txt_edit_tel
        '
        Me.txt_edit_tel.Location = New System.Drawing.Point(80, 213)
        Me.txt_edit_tel.Name = "txt_edit_tel"
        Me.txt_edit_tel.Size = New System.Drawing.Size(167, 22)
        Me.txt_edit_tel.TabIndex = 43
        '
        'txt_edit_address
        '
        Me.txt_edit_address.Location = New System.Drawing.Point(81, 169)
        Me.txt_edit_address.Name = "txt_edit_address"
        Me.txt_edit_address.Size = New System.Drawing.Size(436, 22)
        Me.txt_edit_address.TabIndex = 42
        '
        'txt_edit_nickname
        '
        Me.txt_edit_nickname.Location = New System.Drawing.Point(80, 77)
        Me.txt_edit_nickname.Name = "txt_edit_nickname"
        Me.txt_edit_nickname.Size = New System.Drawing.Size(167, 22)
        Me.txt_edit_nickname.TabIndex = 41
        '
        'txt_edit_name
        '
        Me.txt_edit_name.Location = New System.Drawing.Point(80, 33)
        Me.txt_edit_name.Name = "txt_edit_name"
        Me.txt_edit_name.Size = New System.Drawing.Size(167, 22)
        Me.txt_edit_name.TabIndex = 34
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(298, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 17)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Password"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(298, 36)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 17)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "Username"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(15, 216)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 17)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "เบอร์โทร"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(15, 172)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(30, 17)
        Me.Label20.TabIndex = 37
        Me.Label20.Text = "ที่อยู่"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(13, 123)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 17)
        Me.Label21.TabIndex = 36
        Me.Label21.Text = "วันเกิด"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(13, 80)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 17)
        Me.Label22.TabIndex = 35
        Me.Label22.Text = "ชื่อเล่น"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(13, 36)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 17)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = "ชื่อสกุล"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(15, 263)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(60, 17)
        Me.Label24.TabIndex = 49
        Me.Label24.Text = "แต้มสะสม"
        '
        'txt_edit_point
        '
        Me.txt_edit_point.Location = New System.Drawing.Point(81, 260)
        Me.txt_edit_point.Name = "txt_edit_point"
        Me.txt_edit_point.Size = New System.Drawing.Size(167, 22)
        Me.txt_edit_point.TabIndex = 50
        '
        'txt_show_point
        '
        Me.txt_show_point.Location = New System.Drawing.Point(81, 249)
        Me.txt_show_point.Name = "txt_show_point"
        Me.txt_show_point.Size = New System.Drawing.Size(167, 22)
        Me.txt_show_point.TabIndex = 52
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(15, 252)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(60, 17)
        Me.Label25.TabIndex = 51
        Me.Label25.Text = "แต้มสะสม"
        '
        'frm_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_customer"
        Me.Text = "frm_customer"
        Me.Panel1.ResumeLayout(False)
        CType(Me.datagrid_search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.datagrid_show_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents datagrid_search As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents date_show_born As DateTimePicker
    Friend WithEvents txt_show_password As TextBox
    Friend WithEvents txt_show_username As TextBox
    Friend WithEvents txt_show_tel As TextBox
    Friend WithEvents txt_show_address As TextBox
    Friend WithEvents txt_show_nickname As TextBox
    Friend WithEvents txt_show_name As TextBox
    Friend WithEvents datagrid_show_customer As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents btn_add_clear As Button
    Friend WithEvents btn_add_save As Button
    Friend WithEvents date_add_born As DateTimePicker
    Friend WithEvents txt_add_password As TextBox
    Friend WithEvents txt_add_username As TextBox
    Friend WithEvents txt_add_tel As TextBox
    Friend WithEvents txt_add_address As TextBox
    Friend WithEvents txt_add_nickname As TextBox
    Friend WithEvents txt_add_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit_cancel As Button
    Friend WithEvents btn_edit_button As Button
    Friend WithEvents date_edit_born As DateTimePicker
    Friend WithEvents txt_edit_password As TextBox
    Friend WithEvents txt_edit_username As TextBox
    Friend WithEvents txt_edit_tel As TextBox
    Friend WithEvents txt_edit_address As TextBox
    Friend WithEvents txt_edit_nickname As TextBox
    Friend WithEvents txt_edit_name As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_show_point As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txt_edit_point As TextBox
    Friend WithEvents Label24 As Label
End Class
