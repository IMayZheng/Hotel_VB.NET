<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Personal_Checkin
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_toleft = New System.Windows.Forms.Button()
        Me.btn_toright = New System.Windows.Forms.Button()
        Me.DataGridView_roomchecked = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DataGridView_room_canuse = New System.Windows.Forms.DataGridView()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txt_premoney = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_predays = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_realprice = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_discount = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_others = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_renshu = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_mainguest_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_zj_no = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.lb_preprice = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_quit = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox_roomtype = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView_roomchecked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView_room_canuse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(8, 292)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(646, 274)
        Me.TabControl1.TabIndex = 61
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_toleft)
        Me.TabPage1.Controls.Add(Me.btn_toright)
        Me.TabPage1.Controls.Add(Me.DataGridView_roomchecked)
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.DataGridView_room_canuse)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(638, 248)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "追加房间"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_toleft
        '
        Me.btn_toleft.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_toleft.Location = New System.Drawing.Point(288, 145)
        Me.btn_toleft.Name = "btn_toleft"
        Me.btn_toleft.Size = New System.Drawing.Size(51, 37)
        Me.btn_toleft.TabIndex = 5
        Me.btn_toleft.Text = "<<"
        Me.btn_toleft.UseVisualStyleBackColor = True
        '
        'btn_toright
        '
        Me.btn_toright.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_toright.Location = New System.Drawing.Point(288, 61)
        Me.btn_toright.Name = "btn_toright"
        Me.btn_toright.Size = New System.Drawing.Size(51, 37)
        Me.btn_toright.TabIndex = 4
        Me.btn_toright.Text = ">>"
        Me.btn_toright.UseVisualStyleBackColor = True
        '
        'DataGridView_roomchecked
        '
        Me.DataGridView_roomchecked.AllowUserToAddRows = False
        Me.DataGridView_roomchecked.AllowUserToDeleteRows = False
        Me.DataGridView_roomchecked.AllowUserToResizeColumns = False
        Me.DataGridView_roomchecked.AllowUserToResizeRows = False
        Me.DataGridView_roomchecked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_roomchecked.Location = New System.Drawing.Point(410, 40)
        Me.DataGridView_roomchecked.Name = "DataGridView_roomchecked"
        Me.DataGridView_roomchecked.RowHeadersVisible = False
        Me.DataGridView_roomchecked.RowTemplate.Height = 23
        Me.DataGridView_roomchecked.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_roomchecked.Size = New System.Drawing.Size(178, 202)
        Me.DataGridView_roomchecked.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Location = New System.Drawing.Point(410, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(178, 27)
        Me.Panel4.TabIndex = 2
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(64, 8)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 12)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "开单房间"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Location = New System.Drawing.Point(44, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(180, 27)
        Me.Panel3.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(66, 8)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 12)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "可供房间"
        '
        'DataGridView_room_canuse
        '
        Me.DataGridView_room_canuse.AllowUserToAddRows = False
        Me.DataGridView_room_canuse.AllowUserToDeleteRows = False
        Me.DataGridView_room_canuse.AllowUserToResizeColumns = False
        Me.DataGridView_room_canuse.AllowUserToResizeRows = False
        Me.DataGridView_room_canuse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_room_canuse.Location = New System.Drawing.Point(44, 40)
        Me.DataGridView_room_canuse.Name = "DataGridView_room_canuse"
        Me.DataGridView_room_canuse.RowHeadersVisible = False
        Me.DataGridView_room_canuse.RowTemplate.Height = 23
        Me.DataGridView_room_canuse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_room_canuse.Size = New System.Drawing.Size(180, 202)
        Me.DataGridView_room_canuse.TabIndex = 0
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(166, 246)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(144, 16)
        Me.CheckBox2.TabIndex = 60
        Me.CheckBox2.Text = "到预住天数时自动提醒"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(28, 246)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(60, 16)
        Me.CheckBox1.TabIndex = 59
        Me.CheckBox1.Text = "钟点房"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txt_premoney
        '
        Me.txt_premoney.Location = New System.Drawing.Point(554, 202)
        Me.txt_premoney.Name = "txt_premoney"
        Me.txt_premoney.Size = New System.Drawing.Size(100, 21)
        Me.txt_premoney.TabIndex = 58
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(492, 208)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 12)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "实收押金："
        '
        'txt_predays
        '
        Me.txt_predays.Location = New System.Drawing.Point(391, 202)
        Me.txt_predays.Name = "txt_predays"
        Me.txt_predays.Size = New System.Drawing.Size(75, 21)
        Me.txt_predays.TabIndex = 56
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(332, 208)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 12)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "预住天数："
        '
        'txt_realprice
        '
        Me.txt_realprice.Location = New System.Drawing.Point(242, 202)
        Me.txt_realprice.Name = "txt_realprice"
        Me.txt_realprice.ReadOnly = True
        Me.txt_realprice.Size = New System.Drawing.Size(68, 21)
        Me.txt_realprice.TabIndex = 54
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(181, 208)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 12)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "实际单价："
        '
        'txt_discount
        '
        Me.txt_discount.Location = New System.Drawing.Point(99, 205)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.ReadOnly = True
        Me.txt_discount.Size = New System.Drawing.Size(67, 21)
        Me.txt_discount.TabIndex = 52
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 208)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 12)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "折扣比例："
        '
        'txt_others
        '
        Me.txt_others.Location = New System.Drawing.Point(97, 175)
        Me.txt_others.Name = "txt_others"
        Me.txt_others.Size = New System.Drawing.Size(557, 21)
        Me.txt_others.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 179)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 12)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "备注信息："
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(97, 148)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(557, 21)
        Me.txt_address.TabIndex = 48
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 12)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "地址信息："
        '
        'txt_renshu
        '
        Me.txt_renshu.Location = New System.Drawing.Point(554, 112)
        Me.txt_renshu.Name = "txt_renshu"
        Me.txt_renshu.Size = New System.Drawing.Size(100, 21)
        Me.txt_renshu.TabIndex = 46
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(481, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 12)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "宾客人数："
        '
        'txt_mainguest_name
        '
        Me.txt_mainguest_name.Location = New System.Drawing.Point(297, 117)
        Me.txt_mainguest_name.Name = "txt_mainguest_name"
        Me.txt_mainguest_name.Size = New System.Drawing.Size(158, 21)
        Me.txt_mainguest_name.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(287, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "开单信息"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(226, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 12)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "主客姓名："
        '
        'ComboBox3
        '
        Me.ComboBox3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"普通宾客"})
        Me.ComboBox3.Location = New System.Drawing.Point(81, 118)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(85, 20)
        Me.ComboBox3.TabIndex = 42
        Me.ComboBox3.Text = "普通宾客"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 12)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "宾客类型："
        '
        'txt_zj_no
        '
        Me.txt_zj_no.Location = New System.Drawing.Point(297, 84)
        Me.txt_zj_no.Name = "txt_zj_no"
        Me.txt_zj_no.Size = New System.Drawing.Size(158, 21)
        Me.txt_zj_no.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(481, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "主客性别："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(226, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "证件编码："
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"身份证"})
        Me.ComboBox1.Location = New System.Drawing.Point(81, 84)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(85, 20)
        Me.ComboBox1.TabIndex = 36
        Me.ComboBox1.Text = "身份证"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "证件类型："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(481, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "预设单价："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(226, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "房间类型："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "主客房间："
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(8, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(646, 29)
        Me.Panel1.TabIndex = 31
        '
        'ComboBox5
        '
        Me.ComboBox5.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"男", "女"})
        Me.ComboBox5.Location = New System.Drawing.Point(554, 85)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(92, 20)
        Me.ComboBox5.TabIndex = 40
        Me.ComboBox5.Text = "男"
        '
        'lb_preprice
        '
        Me.lb_preprice.AutoSize = True
        Me.lb_preprice.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lb_preprice.ForeColor = System.Drawing.Color.Red
        Me.lb_preprice.Location = New System.Drawing.Point(552, 53)
        Me.lb_preprice.Name = "lb_preprice"
        Me.lb_preprice.Size = New System.Drawing.Size(63, 14)
        Me.lb_preprice.TabIndex = 64
        Me.lb_preprice.Text = "Label31"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 66)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(653, 12)
        Me.Label18.TabIndex = 65
        Me.Label18.Text = "_________________________________________________________________________________" & _
            "___________________________"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 265)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(653, 12)
        Me.Label19.TabIndex = 66
        Me.Label19.Text = "_________________________________________________________________________________" & _
            "___________________________"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 569)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(653, 12)
        Me.Label20.TabIndex = 67
        Me.Label20.Text = "_________________________________________________________________________________" & _
            "___________________________"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btn_quit)
        Me.Panel2.Controls.Add(Me.btn_ok)
        Me.Panel2.Location = New System.Drawing.Point(8, 617)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(651, 43)
        Me.Panel2.TabIndex = 68
        '
        'btn_quit
        '
        Me.btn_quit.Location = New System.Drawing.Point(346, 10)
        Me.btn_quit.Name = "btn_quit"
        Me.btn_quit.Size = New System.Drawing.Size(75, 23)
        Me.btn_quit.TabIndex = 1
        Me.btn_quit.Text = "取消"
        Me.btn_quit.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(174, 10)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 0
        Me.btn_ok.Text = "确定"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(14, 592)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(419, 12)
        Me.Label21.TabIndex = 69
        Me.Label21.Text = "注：只能追加同类房间，最多4间！若要追加不同类型的房间请选择""团体开单"""
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(81, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(85, 21)
        Me.TextBox1.TabIndex = 70
        '
        'ComboBox_roomtype
        '
        Me.ComboBox_roomtype.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboBox_roomtype.FormattingEnabled = True
        Me.ComboBox_roomtype.Items.AddRange(New Object() {"标准单人间", "标准双人间", "豪华单人间", "豪华双人间", "商务套房", "总统套房"})
        Me.ComboBox_roomtype.Location = New System.Drawing.Point(297, 50)
        Me.ComboBox_roomtype.Name = "ComboBox_roomtype"
        Me.ComboBox_roomtype.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox_roomtype.TabIndex = 71
        Me.ComboBox_roomtype.Text = "标准单人间"
        '
        'Personal_Checkin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 661)
        Me.Controls.Add(Me.ComboBox_roomtype)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lb_preprice)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txt_premoney)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_predays)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_realprice)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_discount)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_others)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_renshu)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_mainguest_name)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.txt_zj_no)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Personal_Checkin"
        Me.Text = "散客开单"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView_roomchecked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView_room_canuse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_premoney As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_predays As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_realprice As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_discount As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_others As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_renshu As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_mainguest_name As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_zj_no As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents lb_preprice As System.Windows.Forms.Label
    Friend WithEvents DataGridView_room_canuse As System.Windows.Forms.DataGridView
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_quit As System.Windows.Forms.Button
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btn_toleft As System.Windows.Forms.Button
    Friend WithEvents btn_toright As System.Windows.Forms.Button
    Friend WithEvents DataGridView_roomchecked As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_roomtype As System.Windows.Forms.ComboBox
End Class
