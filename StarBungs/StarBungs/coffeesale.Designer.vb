<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class coffeesale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_del_all = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_coffee_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_coffee_amount = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.rad_hot = New System.Windows.Forms.RadioButton()
        Me.rad_frappe = New System.Windows.Forms.RadioButton()
        Me.rad_iced = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ListView2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(617, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 466)
        Me.Panel1.TabIndex = 0
        '
        'ListView2
        '
        Me.ListView2.HideSelection = False
        Me.ListView2.LargeImageList = Me.ImageList1
        Me.ListView2.Location = New System.Drawing.Point(6, 55)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(191, 363)
        Me.ListView2.TabIndex = 1
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txt_search)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 49)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ค้นหา"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(88, 12)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(100, 22)
        Me.txt_search.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txt_total)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(617, 100)
        Me.Panel3.TabIndex = 1
        '
        'txt_total
        '
        Me.txt_total.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_total.Location = New System.Drawing.Point(0, 0)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(617, 98)
        Me.txt_total.TabIndex = 0
        Me.txt_total.Text = "0.00"
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ListView1)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 100)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(617, 366)
        Me.Panel4.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(0, 48)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(617, 270)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "*"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "รหัส"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "รายการ"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "หน่วย"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "จำนวน"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ราคา"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ราคารวม"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btn_del)
        Me.Panel6.Controls.Add(Me.btn_del_all)
        Me.Panel6.Controls.Add(Me.Button4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 318)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(617, 48)
        Me.Panel6.TabIndex = 15
        '
        'btn_del
        '
        Me.btn_del.Location = New System.Drawing.Point(12, 6)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(75, 32)
        Me.btn_del.TabIndex = 11
        Me.btn_del.Text = "ลบที่เลือก"
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'btn_del_all
        '
        Me.btn_del_all.Location = New System.Drawing.Point(117, 6)
        Me.btn_del_all.Name = "btn_del_all"
        Me.btn_del_all.Size = New System.Drawing.Size(73, 32)
        Me.btn_del_all.TabIndex = 12
        Me.btn_del_all.Text = "ลบทั้งหมด"
        Me.btn_del_all.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(539, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 32)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "คิดเงิน"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.txt_coffee_id)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.txt_coffee_amount)
        Me.Panel5.Controls.Add(Me.btn_add)
        Me.Panel5.Controls.Add(Me.rad_hot)
        Me.Panel5.Controls.Add(Me.rad_frappe)
        Me.Panel5.Controls.Add(Me.rad_iced)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(617, 48)
        Me.Panel5.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "รหัสสินค้า"
        '
        'txt_coffee_id
        '
        Me.txt_coffee_id.Location = New System.Drawing.Point(97, 11)
        Me.txt_coffee_id.Name = "txt_coffee_id"
        Me.txt_coffee_id.Size = New System.Drawing.Size(64, 22)
        Me.txt_coffee_id.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "จำนวน"
        '
        'txt_coffee_amount
        '
        Me.txt_coffee_amount.Location = New System.Drawing.Point(246, 11)
        Me.txt_coffee_amount.Name = "txt_coffee_amount"
        Me.txt_coffee_amount.Size = New System.Drawing.Size(64, 22)
        Me.txt_coffee_amount.TabIndex = 2
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(536, 11)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 10
        Me.btn_add.Text = "เพิ่ม"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'rad_hot
        '
        Me.rad_hot.AutoSize = True
        Me.rad_hot.Checked = True
        Me.rad_hot.Location = New System.Drawing.Point(333, 12)
        Me.rad_hot.Name = "rad_hot"
        Me.rad_hot.Size = New System.Drawing.Size(52, 21)
        Me.rad_hot.TabIndex = 7
        Me.rad_hot.TabStop = True
        Me.rad_hot.Text = "ร้อน"
        Me.rad_hot.UseVisualStyleBackColor = True
        '
        'rad_frappe
        '
        Me.rad_frappe.AutoSize = True
        Me.rad_frappe.Location = New System.Drawing.Point(468, 12)
        Me.rad_frappe.Name = "rad_frappe"
        Me.rad_frappe.Size = New System.Drawing.Size(46, 21)
        Me.rad_frappe.TabIndex = 9
        Me.rad_frappe.Text = "ปั่น"
        Me.rad_frappe.UseVisualStyleBackColor = True
        '
        'rad_iced
        '
        Me.rad_iced.AutoSize = True
        Me.rad_iced.Location = New System.Drawing.Point(400, 12)
        Me.rad_iced.Name = "rad_iced"
        Me.rad_iced.Size = New System.Drawing.Size(49, 21)
        Me.rad_iced.TabIndex = 8
        Me.rad_iced.Text = "เย็น"
        Me.rad_iced.UseVisualStyleBackColor = True
        '
        'coffeesale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 466)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "coffeesale"
        Me.Text = "coffeesale"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ListView2 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents btn_del_all As Button
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents rad_frappe As RadioButton
    Friend WithEvents rad_iced As RadioButton
    Friend WithEvents rad_hot As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_coffee_id As TextBox
    Friend WithEvents txt_coffee_amount As TextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
End Class
