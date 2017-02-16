<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Room_Reservation
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button2_quit = New System.Windows.Forms.Button()
        Me.Button1_save = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txt_other = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_keep_time = New System.Windows.Forms.TextBox()
        Me.txt_engage_time = New System.Windows.Forms.TextBox()
        Me.ComboBox2_r_no = New System.Windows.Forms.ComboBox()
        Me.ComboBox1_r_type = New System.Windows.Forms.ComboBox()
        Me.txt_c_tel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_c_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_toright = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2_quit
        '
        Me.Button2_quit.Location = New System.Drawing.Point(270, 395)
        Me.Button2_quit.Name = "Button2_quit"
        Me.Button2_quit.Size = New System.Drawing.Size(75, 23)
        Me.Button2_quit.TabIndex = 38
        Me.Button2_quit.Text = "取消"
        Me.Button2_quit.UseVisualStyleBackColor = True
        '
        'Button1_save
        '
        Me.Button1_save.Location = New System.Drawing.Point(83, 395)
        Me.Button1_save.Name = "Button1_save"
        Me.Button1_save.Size = New System.Drawing.Size(75, 23)
        Me.Button1_save.TabIndex = 37
        Me.Button1_save.Text = "保存"
        Me.Button1_save.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(38, 343)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(192, 16)
        Me.CheckBox1.TabIndex = 36
        Me.CheckBox1.Text = "到达保留时间是否自己取消预订"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txt_other
        '
        Me.txt_other.Location = New System.Drawing.Point(83, 295)
        Me.txt_other.Name = "txt_other"
        Me.txt_other.Size = New System.Drawing.Size(326, 21)
        Me.txt_other.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 12)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "备注："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(12, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 12)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "点击右边按钮添加预定"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(219, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 234)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "本次预定的房间"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(203, 208)
        Me.DataGridView1.TabIndex = 0
        '
        'txt_keep_time
        '
        Me.txt_keep_time.Location = New System.Drawing.Point(83, 203)
        Me.txt_keep_time.Name = "txt_keep_time"
        Me.txt_keep_time.Size = New System.Drawing.Size(100, 21)
        Me.txt_keep_time.TabIndex = 32
        '
        'txt_engage_time
        '
        Me.txt_engage_time.Location = New System.Drawing.Point(83, 175)
        Me.txt_engage_time.Name = "txt_engage_time"
        Me.txt_engage_time.Size = New System.Drawing.Size(100, 21)
        Me.txt_engage_time.TabIndex = 31
        '
        'ComboBox2_r_no
        '
        Me.ComboBox2_r_no.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboBox2_r_no.FormattingEnabled = True
        Me.ComboBox2_r_no.Location = New System.Drawing.Point(83, 141)
        Me.ComboBox2_r_no.Name = "ComboBox2_r_no"
        Me.ComboBox2_r_no.Size = New System.Drawing.Size(100, 20)
        Me.ComboBox2_r_no.TabIndex = 30
        '
        'ComboBox1_r_type
        '
        Me.ComboBox1_r_type.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboBox1_r_type.FormattingEnabled = True
        Me.ComboBox1_r_type.Items.AddRange(New Object() {"标准单人间", "标准双人间", "豪华单人间", "豪华双人间", "商务套房", "总统套房"})
        Me.ComboBox1_r_type.Location = New System.Drawing.Point(83, 108)
        Me.ComboBox1_r_type.Name = "ComboBox1_r_type"
        Me.ComboBox1_r_type.Size = New System.Drawing.Size(100, 20)
        Me.ComboBox1_r_type.TabIndex = 29
        Me.ComboBox1_r_type.Text = "标准单人间"
        '
        'txt_c_tel
        '
        Me.txt_c_tel.Location = New System.Drawing.Point(83, 74)
        Me.txt_c_tel.Name = "txt_c_tel"
        Me.txt_c_tel.Size = New System.Drawing.Size(100, 21)
        Me.txt_c_tel.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "保留时间："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "预抵时间："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "基本预订信息"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "房间编号："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "预定规格："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "联系电话："
        '
        'txt_c_name
        '
        Me.txt_c_name.Location = New System.Drawing.Point(83, 45)
        Me.txt_c_name.Name = "txt_c_name"
        Me.txt_c_name.Size = New System.Drawing.Size(100, 21)
        Me.txt_c_name.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "宾客姓名："
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(432, 28)
        Me.Panel1.TabIndex = 20
        '
        'btn_toright
        '
        Me.btn_toright.Location = New System.Drawing.Point(155, 242)
        Me.btn_toright.Name = "btn_toright"
        Me.btn_toright.Size = New System.Drawing.Size(28, 23)
        Me.btn_toright.TabIndex = 39
        Me.btn_toright.Text = ">>"
        Me.btn_toright.UseVisualStyleBackColor = True
        '
        'Room_Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 433)
        Me.Controls.Add(Me.btn_toright)
        Me.Controls.Add(Me.Button2_quit)
        Me.Controls.Add(Me.Button1_save)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txt_other)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_keep_time)
        Me.Controls.Add(Me.txt_engage_time)
        Me.Controls.Add(Me.ComboBox2_r_no)
        Me.Controls.Add(Me.ComboBox1_r_type)
        Me.Controls.Add(Me.txt_c_tel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_c_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Room_Reservation"
        Me.Text = "客房预订"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2_quit As System.Windows.Forms.Button
    Friend WithEvents Button1_save As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_other As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_keep_time As System.Windows.Forms.TextBox
    Friend WithEvents txt_engage_time As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2_r_no As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1_r_type As System.Windows.Forms.ComboBox
    Friend WithEvents txt_c_tel As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_c_name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_toright As System.Windows.Forms.Button
End Class
