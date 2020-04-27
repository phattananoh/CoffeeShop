<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class starbungs_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(starbungs_main))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.mn_sale = New System.Windows.Forms.ToolStripButton()
        Me.mn_menu = New System.Windows.Forms.ToolStripButton()
        Me.mn_customers = New System.Windows.Forms.ToolStripButton()
        Me.mn_staffs = New System.Windows.Forms.ToolStripButton()
        Me.mn_promition = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_Username = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_Name = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_Email = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Level = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_Level = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statistics = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mn_sale, Me.mn_menu, Me.mn_customers, Me.mn_staffs, Me.mn_promition, Me.statistics, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(873, 123)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'mn_sale
        '
        Me.mn_sale.AutoSize = False
        Me.mn_sale.Font = New System.Drawing.Font("Impact", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mn_sale.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mn_sale.Image = CType(resources.GetObject("mn_sale.Image"), System.Drawing.Image)
        Me.mn_sale.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mn_sale.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mn_sale.Name = "mn_sale"
        Me.mn_sale.Size = New System.Drawing.Size(120, 120)
        Me.mn_sale.Text = "Sale"
        Me.mn_sale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mn_menu
        '
        Me.mn_menu.AutoSize = False
        Me.mn_menu.Font = New System.Drawing.Font("Impact", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mn_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mn_menu.Image = CType(resources.GetObject("mn_menu.Image"), System.Drawing.Image)
        Me.mn_menu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mn_menu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mn_menu.Name = "mn_menu"
        Me.mn_menu.Size = New System.Drawing.Size(120, 120)
        Me.mn_menu.Text = "Menu"
        Me.mn_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mn_customers
        '
        Me.mn_customers.AutoSize = False
        Me.mn_customers.Font = New System.Drawing.Font("Impact", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mn_customers.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mn_customers.Image = CType(resources.GetObject("mn_customers.Image"), System.Drawing.Image)
        Me.mn_customers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mn_customers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mn_customers.Name = "mn_customers"
        Me.mn_customers.Size = New System.Drawing.Size(120, 120)
        Me.mn_customers.Text = "Customers"
        Me.mn_customers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mn_staffs
        '
        Me.mn_staffs.AutoSize = False
        Me.mn_staffs.Font = New System.Drawing.Font("Impact", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mn_staffs.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mn_staffs.Image = CType(resources.GetObject("mn_staffs.Image"), System.Drawing.Image)
        Me.mn_staffs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mn_staffs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mn_staffs.Name = "mn_staffs"
        Me.mn_staffs.Size = New System.Drawing.Size(120, 120)
        Me.mn_staffs.Text = "Staffs"
        Me.mn_staffs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mn_promition
        '
        Me.mn_promition.AutoSize = False
        Me.mn_promition.Font = New System.Drawing.Font("Impact", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mn_promition.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mn_promition.Image = CType(resources.GetObject("mn_promition.Image"), System.Drawing.Image)
        Me.mn_promition.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mn_promition.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mn_promition.Name = "mn_promition"
        Me.mn_promition.Size = New System.Drawing.Size(120, 120)
        Me.mn_promition.Text = "Promotion"
        Me.mn_promition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton6.AutoSize = False
        Me.ToolStripButton6.Font = New System.Drawing.Font("Impact", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(120, 120)
        Me.ToolStripButton6.Text = "Exit"
        Me.ToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(41, 21)
        Me.ToolStripStatusLabel1.Text = "User:"
        '
        'lbl_Username
        '
        Me.lbl_Username.BackColor = System.Drawing.Color.White
        Me.lbl_Username.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(31, 21)
        Me.lbl_Username.Text = "xxx"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(49, 21)
        Me.ToolStripStatusLabel3.Text = "Name"
        '
        'lbl_Name
        '
        Me.lbl_Name.BackColor = System.Drawing.Color.White
        Me.lbl_Name.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(31, 21)
        Me.lbl_Name.Text = "xxx"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(49, 21)
        Me.ToolStripStatusLabel2.Text = "Email:"
        '
        'lbl_Email
        '
        Me.lbl_Email.BackColor = System.Drawing.Color.White
        Me.lbl_Email.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(31, 21)
        Me.lbl_Email.Text = "xxx"
        '
        'Level
        '
        Me.Level.BackColor = System.Drawing.Color.White
        Me.Level.Name = "Level"
        Me.Level.Size = New System.Drawing.Size(46, 21)
        Me.Level.Text = "Level:"
        '
        'lbl_Level
        '
        Me.lbl_Level.BackColor = System.Drawing.Color.White
        Me.lbl_Level.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Level.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Level.Name = "lbl_Level"
        Me.lbl_Level.Size = New System.Drawing.Size(31, 21)
        Me.lbl_Level.Text = "xxx"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbl_Username, Me.ToolStripStatusLabel3, Me.lbl_Name, Me.ToolStripStatusLabel2, Me.lbl_Email, Me.Level, Me.lbl_Level})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 423)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(873, 27)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statistics
        '
        Me.statistics.AutoSize = False
        Me.statistics.Font = New System.Drawing.Font("Impact", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statistics.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.statistics.Image = CType(resources.GetObject("statistics.Image"), System.Drawing.Image)
        Me.statistics.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.statistics.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.statistics.Name = "statistics"
        Me.statistics.Size = New System.Drawing.Size(120, 120)
        Me.statistics.Text = "Statistics"
        Me.statistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'starbungs_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(873, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.IsMdiContainer = True
        Me.Name = "starbungs_main"
        Me.Text = "Main Menu"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents mn_sale As ToolStripButton
    Friend WithEvents mn_menu As ToolStripButton
    Friend WithEvents mn_customers As ToolStripButton
    Friend WithEvents mn_promition As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lbl_Username As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents lbl_Name As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents lbl_Email As ToolStripStatusLabel
    Friend WithEvents Level As ToolStripStatusLabel
    Friend WithEvents lbl_Level As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents mn_staffs As ToolStripButton
    Friend WithEvents statistics As ToolStripButton
End Class
