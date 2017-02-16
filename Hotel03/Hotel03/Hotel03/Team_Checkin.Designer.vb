<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Team_Checkin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bt_add = New System.Windows.Forms.Button()
        Me.DataGridView_roominfo = New System.Windows.Forms.DataGridView()
        Me.SunhotelDataSet = New Hotel03.sunhotelDataSet()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bt_delete = New System.Windows.Forms.Button()
        Me.DataGridView_roomchecked = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ComboBox_roomtype = New System.Windows.Forms.ComboBox()
        Me.RoominfoTableAdapter = New Hotel03.sunhotelDataSetTableAdapters.roominfoTableAdapter()
        Me.RoomtypeTableAdapter = New Hotel03.sunhotelDataSetTableAdapters.roomtypeTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.bt_ok = New System.Windows.Forms.Button()
        Me.bt_quit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView_roominfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SunhotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView_roomchecked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.bt_add)
        Me.Panel1.Controls.Add(Me.DataGridView_roominfo)
        Me.Panel1.Location = New System.Drawing.Point(9, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(298, 249)
        Me.Panel1.TabIndex = 0
        '
        'bt_add
        '
        Me.bt_add.Location = New System.Drawing.Point(-1, 215)
        Me.bt_add.Name = "bt_add"
        Me.bt_add.Size = New System.Drawing.Size(298, 33)
        Me.bt_add.TabIndex = 1
        Me.bt_add.Text = "添加到开单区"
        Me.bt_add.UseVisualStyleBackColor = True
        '
        'DataGridView_roominfo
        '
        Me.DataGridView_roominfo.AllowUserToAddRows = False
        Me.DataGridView_roominfo.AllowUserToDeleteRows = False
        Me.DataGridView_roominfo.AllowUserToResizeColumns = False
        Me.DataGridView_roominfo.AllowUserToResizeRows = False
        Me.DataGridView_roominfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_roominfo.Location = New System.Drawing.Point(0, 66)
        Me.DataGridView_roominfo.Name = "DataGridView_roominfo"
        Me.DataGridView_roominfo.ReadOnly = True
        Me.DataGridView_roominfo.RowHeadersVisible = False
        Me.DataGridView_roominfo.RowTemplate.Height = 23
        Me.DataGridView_roominfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_roominfo.Size = New System.Drawing.Size(298, 150)
        Me.DataGridView_roominfo.TabIndex = 0
        '
        'SunhotelDataSet
        '
        Me.SunhotelDataSet.DataSetName = "sunhotelDataSet"
        Me.SunhotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.bt_delete)
        Me.Panel2.Controls.Add(Me.DataGridView_roomchecked)
        Me.Panel2.Location = New System.Drawing.Point(348, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 249)
        Me.Panel2.TabIndex = 1
        '
        'bt_delete
        '
        Me.bt_delete.Location = New System.Drawing.Point(1, 216)
        Me.bt_delete.Name = "bt_delete"
        Me.bt_delete.Size = New System.Drawing.Size(298, 33)
        Me.bt_delete.TabIndex = 2
        Me.bt_delete.Text = "从开单区删除"
        Me.bt_delete.UseVisualStyleBackColor = True
        '
        'DataGridView_roomchecked
        '
        Me.DataGridView_roomchecked.AllowUserToAddRows = False
        Me.DataGridView_roomchecked.AllowUserToDeleteRows = False
        Me.DataGridView_roomchecked.AllowUserToResizeColumns = False
        Me.DataGridView_roomchecked.AllowUserToResizeRows = False
        Me.DataGridView_roomchecked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_roomchecked.Location = New System.Drawing.Point(1, 26)
        Me.DataGridView_roomchecked.Name = "DataGridView_roomchecked"
        Me.DataGridView_roomchecked.ReadOnly = True
        Me.DataGridView_roomchecked.RowHeadersVisible = False
        Me.DataGridView_roomchecked.RowTemplate.Height = 23
        Me.DataGridView_roomchecked.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_roomchecked.Size = New System.Drawing.Size(298, 191)
        Me.DataGridView_roomchecked.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(9, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(298, 25)
        Me.Panel3.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "房间信息"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(348, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(300, 25)
        Me.Panel4.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "开单房间"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "房间类型："
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ComboBox_roomtype)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Location = New System.Drawing.Point(9, 36)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(298, 40)
        Me.Panel5.TabIndex = 1
        '
        'ComboBox_roomtype
        '
        Me.ComboBox_roomtype.FormattingEnabled = True
        Me.ComboBox_roomtype.Items.AddRange(New Object() {"标准单人间", "标准双人间", "豪华单人间", "豪华双人间", "商务套房", "总统套房"})
        Me.ComboBox_roomtype.Location = New System.Drawing.Point(127, 14)
        Me.ComboBox_roomtype.Name = "ComboBox_roomtype"
        Me.ComboBox_roomtype.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox_roomtype.TabIndex = 1
        Me.ComboBox_roomtype.Text = "标准单人间"
        '
        'RoominfoTableAdapter
        '
        Me.RoominfoTableAdapter.ClearBeforeFill = True
        '
        'RoomtypeTableAdapter
        '
        Me.RoomtypeTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "证件类型："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "证件编码："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "实收押金："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 384)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "地址信息："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 409)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 12)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "备注信息："
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(103, 322)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(134, 21)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(103, 352)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 21)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(103, 381)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(544, 21)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(103, 406)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(545, 21)
        Me.TextBox4.TabIndex = 10
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"身份证"})
        Me.ComboBox1.Location = New System.Drawing.Point(103, 291)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 20)
        Me.ComboBox1.TabIndex = 11
        Me.ComboBox1.Text = "身份证"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(243, 294)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 12)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "宾客类型："
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(243, 325)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 12)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "主客姓名："
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(243, 355)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 12)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "主客房间："
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(442, 294)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 12)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "主客性别："
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(442, 325)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 12)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "宾客人数："
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(442, 355)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 12)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "预住天数："
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"普通宾客"})
        Me.ComboBox2.Location = New System.Drawing.Point(314, 291)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(100, 20)
        Me.ComboBox2.TabIndex = 18
        Me.ComboBox2.Text = "普通宾客"
        '
        'ComboBox3
        '
        Me.ComboBox3.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"男", "女"})
        Me.ComboBox3.Location = New System.Drawing.Point(513, 291)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(100, 20)
        Me.ComboBox3.TabIndex = 19
        Me.ComboBox3.Text = "男"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(314, 322)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 21)
        Me.TextBox5.TabIndex = 20
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(314, 352)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 21)
        Me.TextBox6.TabIndex = 21
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(513, 322)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 21)
        Me.TextBox7.TabIndex = 22
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(513, 352)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 21)
        Me.TextBox8.TabIndex = 23
        '
        'bt_ok
        '
        Me.bt_ok.Location = New System.Drawing.Point(195, 445)
        Me.bt_ok.Name = "bt_ok"
        Me.bt_ok.Size = New System.Drawing.Size(75, 23)
        Me.bt_ok.TabIndex = 24
        Me.bt_ok.Text = "确定"
        Me.bt_ok.UseVisualStyleBackColor = True
        '
        'bt_quit
        '
        Me.bt_quit.Location = New System.Drawing.Point(389, 445)
        Me.bt_quit.Name = "bt_quit"
        Me.bt_quit.Size = New System.Drawing.Size(75, 23)
        Me.bt_quit.TabIndex = 25
        Me.bt_quit.Text = "取消"
        Me.bt_quit.UseVisualStyleBackColor = True
        '
        'Team_Checkin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 480)
        Me.Controls.Add(Me.bt_quit)
        Me.Controls.Add(Me.bt_ok)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Team_Checkin"
        Me.Text = "团队开单"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView_roominfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SunhotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView_roomchecked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView_roominfo As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox_roomtype As System.Windows.Forms.ComboBox
    Friend WithEvents SunhotelDataSet As Hotel03.sunhotelDataSet
    Friend WithEvents RoominfoTableAdapter As Hotel03.sunhotelDataSetTableAdapters.roominfoTableAdapter
    Friend WithEvents RoomtypeTableAdapter As Hotel03.sunhotelDataSetTableAdapters.roomtypeTableAdapter
    Friend WithEvents bt_add As System.Windows.Forms.Button
    Friend WithEvents bt_delete As System.Windows.Forms.Button
    Friend WithEvents DataGridView_roomchecked As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents bt_ok As System.Windows.Forms.Button
    Friend WithEvents bt_quit As System.Windows.Forms.Button
End Class
