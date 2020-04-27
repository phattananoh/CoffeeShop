<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_staffs
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGrid_Search = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_show_level = New System.Windows.Forms.TextBox()
        Me.ck_show_Staffs = New System.Windows.Forms.CheckBox()
        Me.ck_show_Customer = New System.Windows.Forms.CheckBox()
        Me.ck_show_Menu = New System.Windows.Forms.CheckBox()
        Me.ck_show_Coupon = New System.Windows.Forms.CheckBox()
        Me.ck_show_Sale = New System.Windows.Forms.CheckBox()
        Me.txt_show_gender = New System.Windows.Forms.TextBox()
        Me.txt_show_email = New System.Windows.Forms.TextBox()
        Me.txt_show_Name = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_show_Password = New System.Windows.Forms.TextBox()
        Me.txt_show_ID = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_add_level = New System.Windows.Forms.TextBox()
        Me.CheckBox_staffs = New System.Windows.Forms.CheckBox()
        Me.CheckBox_customer = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Menu = New System.Windows.Forms.CheckBox()
        Me.CheckBox_promotion = New System.Windows.Forms.CheckBox()
        Me.CheckBox_sale = New System.Windows.Forms.CheckBox()
        Me.txt_add_Gender = New System.Windows.Forms.ComboBox()
        Me.txt_add_email = New System.Windows.Forms.TextBox()
        Me.txt_add_name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_add_password = New System.Windows.Forms.TextBox()
        Me.txt_add_user = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_edit_level = New System.Windows.Forms.TextBox()
        Me.cbEdit_Staffs = New System.Windows.Forms.CheckBox()
        Me.cbEdit_Customer = New System.Windows.Forms.CheckBox()
        Me.cbEdit_Menu = New System.Windows.Forms.CheckBox()
        Me.cbEdit_Coupon = New System.Windows.Forms.CheckBox()
        Me.cbEdit_sale = New System.Windows.Forms.CheckBox()
        Me.combo_edit_name = New System.Windows.Forms.ComboBox()
        Me.txt_edit_email = New System.Windows.Forms.TextBox()
        Me.txt_edit_name = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txt_edit_password = New System.Windows.Forms.TextBox()
        Me.txt_edit_ID = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_confirm = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGrid_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGrid_Search)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(436, 502)
        Me.Panel1.TabIndex = 0
        '
        'DataGrid_Search
        '
        Me.DataGrid_Search.AllowUserToAddRows = False
        Me.DataGrid_Search.AllowUserToDeleteRows = False
        Me.DataGrid_Search.BackgroundColor = System.Drawing.Color.DarkOliveGreen
        Me.DataGrid_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid_Search.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid_Search.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid_Search.Location = New System.Drawing.Point(0, 79)
        Me.DataGrid_Search.Name = "DataGrid_Search"
        Me.DataGrid_Search.ReadOnly = True
        Me.DataGrid_Search.RowHeadersVisible = False
        Me.DataGrid_Search.RowHeadersWidth = 51
        Me.DataGrid_Search.RowTemplate.Height = 24
        Me.DataGrid_Search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid_Search.Size = New System.Drawing.Size(436, 423)
        Me.DataGrid_Search.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(436, 79)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(81, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(157, 22)
        Me.TextBox1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(436, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(614, 502)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.txt_show_gender)
        Me.TabPage1.Controls.Add(Me.txt_show_email)
        Me.TabPage1.Controls.Add(Me.txt_show_Name)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(606, 473)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Staff"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txt_show_level)
        Me.GroupBox4.Controls.Add(Me.ck_show_Staffs)
        Me.GroupBox4.Controls.Add(Me.ck_show_Customer)
        Me.GroupBox4.Controls.Add(Me.ck_show_Menu)
        Me.GroupBox4.Controls.Add(Me.ck_show_Coupon)
        Me.GroupBox4.Controls.Add(Me.ck_show_Sale)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(37, 152)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(445, 173)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Role"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(38, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 17)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Level :"
        '
        'txt_show_level
        '
        Me.txt_show_level.Enabled = False
        Me.txt_show_level.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_show_level.Location = New System.Drawing.Point(103, 31)
        Me.txt_show_level.Name = "txt_show_level"
        Me.txt_show_level.Size = New System.Drawing.Size(206, 22)
        Me.txt_show_level.TabIndex = 19
        '
        'ck_show_Staffs
        '
        Me.ck_show_Staffs.AutoSize = True
        Me.ck_show_Staffs.Enabled = False
        Me.ck_show_Staffs.Location = New System.Drawing.Point(186, 97)
        Me.ck_show_Staffs.Name = "ck_show_Staffs"
        Me.ck_show_Staffs.Size = New System.Drawing.Size(121, 21)
        Me.ck_show_Staffs.TabIndex = 4
        Me.ck_show_Staffs.Text = "Manage Staffs"
        Me.ck_show_Staffs.UseVisualStyleBackColor = True
        '
        'ck_show_Customer
        '
        Me.ck_show_Customer.AutoSize = True
        Me.ck_show_Customer.Enabled = False
        Me.ck_show_Customer.Location = New System.Drawing.Point(38, 124)
        Me.ck_show_Customer.Name = "ck_show_Customer"
        Me.ck_show_Customer.Size = New System.Drawing.Size(145, 21)
        Me.ck_show_Customer.TabIndex = 3
        Me.ck_show_Customer.Text = "Mangae Customer"
        Me.ck_show_Customer.UseVisualStyleBackColor = True
        '
        'ck_show_Menu
        '
        Me.ck_show_Menu.AutoSize = True
        Me.ck_show_Menu.Enabled = False
        Me.ck_show_Menu.Location = New System.Drawing.Point(38, 97)
        Me.ck_show_Menu.Name = "ck_show_Menu"
        Me.ck_show_Menu.Size = New System.Drawing.Size(120, 21)
        Me.ck_show_Menu.TabIndex = 2
        Me.ck_show_Menu.Text = "Manage Menu"
        Me.ck_show_Menu.UseVisualStyleBackColor = True
        '
        'ck_show_Coupon
        '
        Me.ck_show_Coupon.AutoSize = True
        Me.ck_show_Coupon.Enabled = False
        Me.ck_show_Coupon.Location = New System.Drawing.Point(186, 70)
        Me.ck_show_Coupon.Name = "ck_show_Coupon"
        Me.ck_show_Coupon.Size = New System.Drawing.Size(134, 21)
        Me.ck_show_Coupon.TabIndex = 1
        Me.ck_show_Coupon.Text = "Manage Coupon"
        Me.ck_show_Coupon.UseVisualStyleBackColor = True
        '
        'ck_show_Sale
        '
        Me.ck_show_Sale.AutoSize = True
        Me.ck_show_Sale.Enabled = False
        Me.ck_show_Sale.Location = New System.Drawing.Point(38, 70)
        Me.ck_show_Sale.Name = "ck_show_Sale"
        Me.ck_show_Sale.Size = New System.Drawing.Size(58, 21)
        Me.ck_show_Sale.TabIndex = 0
        Me.ck_show_Sale.Text = "Sale"
        Me.ck_show_Sale.UseVisualStyleBackColor = True
        '
        'txt_show_gender
        '
        Me.txt_show_gender.Enabled = False
        Me.txt_show_gender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_show_gender.Location = New System.Drawing.Point(158, 363)
        Me.txt_show_gender.Name = "txt_show_gender"
        Me.txt_show_gender.Size = New System.Drawing.Size(206, 22)
        Me.txt_show_gender.TabIndex = 11
        '
        'txt_show_email
        '
        Me.txt_show_email.Enabled = False
        Me.txt_show_email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_show_email.Location = New System.Drawing.Point(158, 391)
        Me.txt_show_email.Name = "txt_show_email"
        Me.txt_show_email.Size = New System.Drawing.Size(206, 22)
        Me.txt_show_email.TabIndex = 10
        '
        'txt_show_Name
        '
        Me.txt_show_Name.Enabled = False
        Me.txt_show_Name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_show_Name.Location = New System.Drawing.Point(158, 335)
        Me.txt_show_Name.Name = "txt_show_Name"
        Me.txt_show_Name.Size = New System.Drawing.Size(206, 22)
        Me.txt_show_Name.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(89, 394)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Email :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(78, 366)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Gender"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_show_Password)
        Me.GroupBox1.Controls.Add(Me.txt_show_ID)
        Me.GroupBox1.Controls.Add(Me.Username)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(37, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 131)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account"
        '
        'txt_show_Password
        '
        Me.txt_show_Password.Enabled = False
        Me.txt_show_Password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_show_Password.Location = New System.Drawing.Point(114, 80)
        Me.txt_show_Password.Name = "txt_show_Password"
        Me.txt_show_Password.Size = New System.Drawing.Size(206, 22)
        Me.txt_show_Password.TabIndex = 4
        '
        'txt_show_ID
        '
        Me.txt_show_ID.Enabled = False
        Me.txt_show_ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_show_ID.Location = New System.Drawing.Point(114, 39)
        Me.txt_show_ID.Name = "txt_show_ID"
        Me.txt_show_ID.Size = New System.Drawing.Size(206, 22)
        Me.txt_show_ID.TabIndex = 2
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Location = New System.Drawing.Point(24, 42)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(73, 17)
        Me.Username.TabIndex = 3
        Me.Username.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(89, 338)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Name"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.txt_add_Gender)
        Me.TabPage2.Controls.Add(Me.txt_add_email)
        Me.TabPage2.Controls.Add(Me.txt_add_name)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(606, 473)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("Impact", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(381, 322)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 30
        Me.Button5.Text = "Clear"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(381, 430)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 35)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txt_add_level)
        Me.GroupBox3.Controls.Add(Me.CheckBox_staffs)
        Me.GroupBox3.Controls.Add(Me.CheckBox_customer)
        Me.GroupBox3.Controls.Add(Me.CheckBox_Menu)
        Me.GroupBox3.Controls.Add(Me.CheckBox_promotion)
        Me.GroupBox3.Controls.Add(Me.CheckBox_sale)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(37, 144)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(460, 167)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Role"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(38, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 17)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Level :"
        '
        'txt_add_level
        '
        Me.txt_add_level.Location = New System.Drawing.Point(103, 31)
        Me.txt_add_level.Name = "txt_add_level"
        Me.txt_add_level.Size = New System.Drawing.Size(206, 22)
        Me.txt_add_level.TabIndex = 19
        '
        'CheckBox_staffs
        '
        Me.CheckBox_staffs.AutoSize = True
        Me.CheckBox_staffs.Location = New System.Drawing.Point(186, 97)
        Me.CheckBox_staffs.Name = "CheckBox_staffs"
        Me.CheckBox_staffs.Size = New System.Drawing.Size(121, 21)
        Me.CheckBox_staffs.TabIndex = 4
        Me.CheckBox_staffs.Text = "Manage Staffs"
        Me.CheckBox_staffs.UseVisualStyleBackColor = True
        '
        'CheckBox_customer
        '
        Me.CheckBox_customer.AutoSize = True
        Me.CheckBox_customer.Location = New System.Drawing.Point(38, 124)
        Me.CheckBox_customer.Name = "CheckBox_customer"
        Me.CheckBox_customer.Size = New System.Drawing.Size(145, 21)
        Me.CheckBox_customer.TabIndex = 3
        Me.CheckBox_customer.Text = "Mangae Customer"
        Me.CheckBox_customer.UseVisualStyleBackColor = True
        '
        'CheckBox_Menu
        '
        Me.CheckBox_Menu.AutoSize = True
        Me.CheckBox_Menu.Location = New System.Drawing.Point(38, 97)
        Me.CheckBox_Menu.Name = "CheckBox_Menu"
        Me.CheckBox_Menu.Size = New System.Drawing.Size(120, 21)
        Me.CheckBox_Menu.TabIndex = 2
        Me.CheckBox_Menu.Text = "Manage Menu"
        Me.CheckBox_Menu.UseVisualStyleBackColor = True
        '
        'CheckBox_promotion
        '
        Me.CheckBox_promotion.AutoSize = True
        Me.CheckBox_promotion.Location = New System.Drawing.Point(186, 70)
        Me.CheckBox_promotion.Name = "CheckBox_promotion"
        Me.CheckBox_promotion.Size = New System.Drawing.Size(134, 21)
        Me.CheckBox_promotion.TabIndex = 1
        Me.CheckBox_promotion.Text = "Manage Coupon"
        Me.CheckBox_promotion.UseVisualStyleBackColor = True
        '
        'CheckBox_sale
        '
        Me.CheckBox_sale.AutoSize = True
        Me.CheckBox_sale.Location = New System.Drawing.Point(38, 70)
        Me.CheckBox_sale.Name = "CheckBox_sale"
        Me.CheckBox_sale.Size = New System.Drawing.Size(58, 21)
        Me.CheckBox_sale.TabIndex = 0
        Me.CheckBox_sale.Text = "Sale"
        Me.CheckBox_sale.UseVisualStyleBackColor = True
        '
        'txt_add_Gender
        '
        Me.txt_add_Gender.FormattingEnabled = True
        Me.txt_add_Gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.txt_add_Gender.Location = New System.Drawing.Point(151, 362)
        Me.txt_add_Gender.Name = "txt_add_Gender"
        Me.txt_add_Gender.Size = New System.Drawing.Size(206, 24)
        Me.txt_add_Gender.TabIndex = 18
        '
        'txt_add_email
        '
        Me.txt_add_email.Location = New System.Drawing.Point(151, 402)
        Me.txt_add_email.Name = "txt_add_email"
        Me.txt_add_email.Size = New System.Drawing.Size(206, 22)
        Me.txt_add_email.TabIndex = 17
        '
        'txt_add_name
        '
        Me.txt_add_name.Location = New System.Drawing.Point(151, 325)
        Me.txt_add_name.Name = "txt_add_name"
        Me.txt_add_name.Size = New System.Drawing.Size(206, 22)
        Me.txt_add_name.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(75, 405)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Email :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(66, 365)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Gender"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_add_password)
        Me.GroupBox2.Controls.Add(Me.txt_add_user)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(37, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(445, 116)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Account"
        '
        'txt_add_password
        '
        Me.txt_add_password.Location = New System.Drawing.Point(114, 70)
        Me.txt_add_password.Name = "txt_add_password"
        Me.txt_add_password.Size = New System.Drawing.Size(206, 22)
        Me.txt_add_password.TabIndex = 4
        '
        'txt_add_user
        '
        Me.txt_add_user.Location = New System.Drawing.Point(114, 29)
        Me.txt_add_user.Name = "txt_add_user"
        Me.txt_add_user.Size = New System.Drawing.Size(206, 22)
        Me.txt_add_user.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Username"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Password"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(80, 328)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 17)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Name"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.combo_edit_name)
        Me.TabPage3.Controls.Add(Me.txt_edit_email)
        Me.TabPage3.Controls.Add(Me.txt_edit_name)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.ForeColor = System.Drawing.Color.White
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(606, 473)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Edit"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Impact", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(376, 317)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 29
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Impact", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(376, 421)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 35)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.txt_edit_level)
        Me.GroupBox5.Controls.Add(Me.cbEdit_Staffs)
        Me.GroupBox5.Controls.Add(Me.cbEdit_Customer)
        Me.GroupBox5.Controls.Add(Me.cbEdit_Menu)
        Me.GroupBox5.Controls.Add(Me.cbEdit_Coupon)
        Me.GroupBox5.Controls.Add(Me.cbEdit_sale)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(32, 137)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(460, 167)
        Me.GroupBox5.TabIndex = 23
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Role"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(38, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 17)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Level :"
        '
        'txt_edit_level
        '
        Me.txt_edit_level.Location = New System.Drawing.Point(103, 31)
        Me.txt_edit_level.Name = "txt_edit_level"
        Me.txt_edit_level.Size = New System.Drawing.Size(206, 22)
        Me.txt_edit_level.TabIndex = 19
        '
        'cbEdit_Staffs
        '
        Me.cbEdit_Staffs.AutoSize = True
        Me.cbEdit_Staffs.Location = New System.Drawing.Point(186, 97)
        Me.cbEdit_Staffs.Name = "cbEdit_Staffs"
        Me.cbEdit_Staffs.Size = New System.Drawing.Size(121, 21)
        Me.cbEdit_Staffs.TabIndex = 4
        Me.cbEdit_Staffs.Text = "Manage Staffs"
        Me.cbEdit_Staffs.UseVisualStyleBackColor = True
        '
        'cbEdit_Customer
        '
        Me.cbEdit_Customer.AutoSize = True
        Me.cbEdit_Customer.Location = New System.Drawing.Point(38, 124)
        Me.cbEdit_Customer.Name = "cbEdit_Customer"
        Me.cbEdit_Customer.Size = New System.Drawing.Size(145, 21)
        Me.cbEdit_Customer.TabIndex = 3
        Me.cbEdit_Customer.Text = "Mangae Customer"
        Me.cbEdit_Customer.UseVisualStyleBackColor = True
        '
        'cbEdit_Menu
        '
        Me.cbEdit_Menu.AutoSize = True
        Me.cbEdit_Menu.Location = New System.Drawing.Point(38, 97)
        Me.cbEdit_Menu.Name = "cbEdit_Menu"
        Me.cbEdit_Menu.Size = New System.Drawing.Size(120, 21)
        Me.cbEdit_Menu.TabIndex = 2
        Me.cbEdit_Menu.Text = "Manage Menu"
        Me.cbEdit_Menu.UseVisualStyleBackColor = True
        '
        'cbEdit_Coupon
        '
        Me.cbEdit_Coupon.AutoSize = True
        Me.cbEdit_Coupon.Location = New System.Drawing.Point(186, 70)
        Me.cbEdit_Coupon.Name = "cbEdit_Coupon"
        Me.cbEdit_Coupon.Size = New System.Drawing.Size(134, 21)
        Me.cbEdit_Coupon.TabIndex = 1
        Me.cbEdit_Coupon.Text = "Manage Coupon"
        Me.cbEdit_Coupon.UseVisualStyleBackColor = True
        '
        'cbEdit_sale
        '
        Me.cbEdit_sale.AutoSize = True
        Me.cbEdit_sale.Location = New System.Drawing.Point(38, 70)
        Me.cbEdit_sale.Name = "cbEdit_sale"
        Me.cbEdit_sale.Size = New System.Drawing.Size(58, 21)
        Me.cbEdit_sale.TabIndex = 0
        Me.cbEdit_sale.Text = "Sale"
        Me.cbEdit_sale.UseVisualStyleBackColor = True
        '
        'combo_edit_name
        '
        Me.combo_edit_name.FormattingEnabled = True
        Me.combo_edit_name.Items.AddRange(New Object() {"Male", "Female"})
        Me.combo_edit_name.Location = New System.Drawing.Point(146, 355)
        Me.combo_edit_name.Name = "combo_edit_name"
        Me.combo_edit_name.Size = New System.Drawing.Size(206, 24)
        Me.combo_edit_name.TabIndex = 27
        '
        'txt_edit_email
        '
        Me.txt_edit_email.Location = New System.Drawing.Point(146, 395)
        Me.txt_edit_email.Name = "txt_edit_email"
        Me.txt_edit_email.Size = New System.Drawing.Size(206, 22)
        Me.txt_edit_email.TabIndex = 26
        '
        'txt_edit_name
        '
        Me.txt_edit_name.Location = New System.Drawing.Point(146, 318)
        Me.txt_edit_name.Name = "txt_edit_name"
        Me.txt_edit_name.Size = New System.Drawing.Size(206, 22)
        Me.txt_edit_name.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(70, 398)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 17)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Email :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(61, 358)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 17)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Gender"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txt_edit_password)
        Me.GroupBox6.Controls.Add(Me.txt_edit_ID)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(32, 15)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(445, 116)
        Me.GroupBox6.TabIndex = 22
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Account"
        '
        'txt_edit_password
        '
        Me.txt_edit_password.Location = New System.Drawing.Point(114, 70)
        Me.txt_edit_password.Name = "txt_edit_password"
        Me.txt_edit_password.Size = New System.Drawing.Size(206, 22)
        Me.txt_edit_password.TabIndex = 4
        '
        'txt_edit_ID
        '
        Me.txt_edit_ID.Location = New System.Drawing.Point(114, 29)
        Me.txt_edit_ID.Name = "txt_edit_ID"
        Me.txt_edit_ID.Size = New System.Drawing.Size(206, 22)
        Me.txt_edit_ID.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(24, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 17)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Username"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(24, 73)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 17)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Password"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(75, 321)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 17)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Name"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.Button2)
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Controls.Add(Me.txt_confirm)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(606, 473)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Remove"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(268, 276)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 40)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(202, 232)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(241, 21)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "please enter ""CONFIRM"" to Delete"
        '
        'txt_confirm
        '
        Me.txt_confirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_confirm.Location = New System.Drawing.Point(239, 199)
        Me.txt_confirm.Name = "txt_confirm"
        Me.txt_confirm.Size = New System.Drawing.Size(152, 30)
        Me.txt_confirm.TabIndex = 13
        '
        'frm_staffs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 502)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_staffs"
        Me.Text = "Staff"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGrid_Search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGrid_Search As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents txt_show_ID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Username As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_show_Password As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_show_email As TextBox
    Friend WithEvents txt_show_Name As TextBox
    Friend WithEvents txt_show_gender As TextBox
    Friend WithEvents txt_add_Gender As ComboBox
    Friend WithEvents txt_add_email As TextBox
    Friend WithEvents txt_add_name As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_add_password As TextBox
    Friend WithEvents txt_add_user As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_add_level As TextBox
    Friend WithEvents CheckBox_staffs As CheckBox
    Friend WithEvents CheckBox_customer As CheckBox
    Friend WithEvents CheckBox_Menu As CheckBox
    Friend WithEvents CheckBox_promotion As CheckBox
    Friend WithEvents CheckBox_sale As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_show_level As TextBox
    Friend WithEvents ck_show_Staffs As CheckBox
    Friend WithEvents ck_show_Customer As CheckBox
    Friend WithEvents ck_show_Menu As CheckBox
    Friend WithEvents ck_show_Coupon As CheckBox
    Friend WithEvents ck_show_Sale As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_confirm As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_edit_level As TextBox
    Friend WithEvents cbEdit_Staffs As CheckBox
    Friend WithEvents cbEdit_Customer As CheckBox
    Friend WithEvents cbEdit_Menu As CheckBox
    Friend WithEvents cbEdit_Coupon As CheckBox
    Friend WithEvents cbEdit_sale As CheckBox
    Friend WithEvents combo_edit_name As ComboBox
    Friend WithEvents txt_edit_email As TextBox
    Friend WithEvents txt_edit_name As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txt_edit_password As TextBox
    Friend WithEvents txt_edit_ID As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
