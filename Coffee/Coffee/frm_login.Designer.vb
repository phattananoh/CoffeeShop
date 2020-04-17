<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.chk_remember = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(804, 67)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Yi Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Yi Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(132, 70)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(148, 31)
        Me.txt_username.TabIndex = 1
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(132, 144)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_password.Size = New System.Drawing.Size(148, 31)
        Me.txt_password.TabIndex = 2
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(132, 224)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(71, 28)
        Me.btn_login.TabIndex = 3
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_exit.Location = New System.Drawing.Point(209, 224)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(71, 28)
        Me.btn_exit.TabIndex = 4
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(132, 181)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(124, 21)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "แสดง Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'chk_remember
        '
        Me.chk_remember.AutoSize = True
        Me.chk_remember.BackColor = System.Drawing.Color.Transparent
        Me.chk_remember.ForeColor = System.Drawing.Color.White
        Me.chk_remember.Location = New System.Drawing.Point(132, 107)
        Me.chk_remember.Name = "chk_remember"
        Me.chk_remember.Size = New System.Drawing.Size(168, 21)
        Me.chk_remember.TabIndex = 8
        Me.chk_remember.Text = "Remember Username"
        Me.chk_remember.UseVisualStyleBackColor = False
        '
        'frm_login
        '
        Me.AcceptButton = Me.btn_login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.Coffee.My.Resources.Resources.caffeine1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btn_exit
        Me.ClientSize = New System.Drawing.Size(804, 457)
        Me.ControlBox = False
        Me.Controls.Add(Me.chk_remember)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents chk_remember As CheckBox
End Class
