<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_total
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_total))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_change = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_receive = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.btn_cancle = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_discount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_total2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Price = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_add_point = New System.Windows.Forms.Label()
        Me.lbl_point = New System.Windows.Forms.Label()
        Me.Price.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(5, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subtotal"
        '
        'txt_total
        '
        Me.txt_total.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_total.Location = New System.Drawing.Point(139, 51)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(201, 40)
        Me.txt_total.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(357, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 35)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "฿"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(377, 405)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 35)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "฿"
        '
        'txt_change
        '
        Me.txt_change.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_change.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_change.Location = New System.Drawing.Point(159, 403)
        Me.txt_change.Name = "txt_change"
        Me.txt_change.ReadOnly = True
        Me.txt_change.Size = New System.Drawing.Size(201, 40)
        Me.txt_change.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(31, 405)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 35)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Change"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(377, 359)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 35)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "฿"
        '
        'txt_receive
        '
        Me.txt_receive.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_receive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_receive.Location = New System.Drawing.Point(159, 357)
        Me.txt_receive.Name = "txt_receive"
        Me.txt_receive.Size = New System.Drawing.Size(201, 40)
        Me.txt_receive.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(31, 359)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 35)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Receive"
        '
        'btn_confirm
        '
        Me.btn_confirm.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_confirm.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_confirm.Location = New System.Drawing.Point(114, 531)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(120, 56)
        Me.btn_confirm.TabIndex = 9
        Me.btn_confirm.Text = "Confirm"
        Me.btn_confirm.UseVisualStyleBackColor = False
        '
        'btn_cancle
        '
        Me.btn_cancle.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_cancle.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_cancle.Location = New System.Drawing.Point(257, 531)
        Me.btn_cancle.Name = "btn_cancle"
        Me.btn_cancle.Size = New System.Drawing.Size(120, 56)
        Me.btn_cancle.TabIndex = 10
        Me.btn_cancle.Text = "Cancle"
        Me.btn_cancle.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(259, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 35)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "฿"
        '
        'txt_discount
        '
        Me.txt_discount.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_discount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_discount.Location = New System.Drawing.Point(139, 95)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.ReadOnly = True
        Me.txt_discount.Size = New System.Drawing.Size(114, 40)
        Me.txt_discount.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(9, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 35)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Discount -"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(357, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 35)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "฿"
        '
        'txt_total2
        '
        Me.txt_total2.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_total2.Location = New System.Drawing.Point(139, 169)
        Me.txt_total2.Name = "txt_total2"
        Me.txt_total2.ReadOnly = True
        Me.txt_total2.Size = New System.Drawing.Size(201, 40)
        Me.txt_total2.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(45, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 35)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Total"
        '
        'Price
        '
        Me.Price.Controls.Add(Me.Label9)
        Me.Price.Controls.Add(Me.txt_discount)
        Me.Price.Controls.Add(Me.txt_total2)
        Me.Price.Controls.Add(Me.Label1)
        Me.Price.Controls.Add(Me.Label10)
        Me.Price.Controls.Add(Me.txt_total)
        Me.Price.Controls.Add(Me.Label7)
        Me.Price.Controls.Add(Me.Label2)
        Me.Price.Controls.Add(Me.Label8)
        Me.Price.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Price.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Price.Location = New System.Drawing.Point(37, 125)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(399, 226)
        Me.Price.TabIndex = 17
        Me.Price.TabStop = False
        Me.Price.Text = "Checkout"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(156, -27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(274, 146)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'lbl_add_point
        '
        Me.lbl_add_point.AutoSize = True
        Me.lbl_add_point.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_add_point.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_add_point.Location = New System.Drawing.Point(31, 452)
        Me.lbl_add_point.Name = "lbl_add_point"
        Me.lbl_add_point.Size = New System.Drawing.Size(74, 35)
        Me.lbl_add_point.TabIndex = 19
        Me.lbl_add_point.Text = "Point"
        '
        'lbl_point
        '
        Me.lbl_point.AutoSize = True
        Me.lbl_point.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_point.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_point.Location = New System.Drawing.Point(160, 452)
        Me.lbl_point.Name = "lbl_point"
        Me.lbl_point.Size = New System.Drawing.Size(30, 35)
        Me.lbl_point.TabIndex = 20
        Me.lbl_point.Text = "0"
        '
        'frm_total
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(510, 599)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_point)
        Me.Controls.Add(Me.lbl_add_point)
        Me.Controls.Add(Me.btn_cancle)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_receive)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_change)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_total"
        Me.Text = "Purchase"
        Me.Price.ResumeLayout(False)
        Me.Price.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_change As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_receive As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_confirm As Button
    Friend WithEvents btn_cancle As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_discount As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_total2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Price As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_add_point As Label
    Friend WithEvents lbl_point As Label
End Class
