<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guest_Pay
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
        Me.txt_other = New System.Windows.Forms.TextBox()
        Me.txt_guestpay = New System.Windows.Forms.TextBox()
        Me.txt_realmoney = New System.Windows.Forms.TextBox()
        Me.btn_quit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_danhao = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lb_guest_name = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_pay = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lb_change = New System.Windows.Forms.Label()
        Me.lb_discountmoney = New System.Windows.Forms.Label()
        Me.lb_yajin = New System.Windows.Forms.Label()
        Me.lb_shouldpay = New System.Windows.Forms.Label()
        Me.lb_consume = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_other
        '
        Me.txt_other.Location = New System.Drawing.Point(83, 78)
        Me.txt_other.Name = "txt_other"
        Me.txt_other.Size = New System.Drawing.Size(247, 21)
        Me.txt_other.TabIndex = 14
        '
        'txt_guestpay
        '
        Me.txt_guestpay.Location = New System.Drawing.Point(313, 43)
        Me.txt_guestpay.Name = "txt_guestpay"
        Me.txt_guestpay.Size = New System.Drawing.Size(100, 21)
        Me.txt_guestpay.TabIndex = 13
        '
        'txt_realmoney
        '
        Me.txt_realmoney.Location = New System.Drawing.Point(83, 43)
        Me.txt_realmoney.Name = "txt_realmoney"
        Me.txt_realmoney.Size = New System.Drawing.Size(100, 21)
        Me.txt_realmoney.TabIndex = 12
        '
        'btn_quit
        '
        Me.btn_quit.Location = New System.Drawing.Point(487, 76)
        Me.btn_quit.Name = "btn_quit"
        Me.btn_quit.Size = New System.Drawing.Size(75, 23)
        Me.btn_quit.TabIndex = 11
        Me.btn_quit.Text = "取消"
        Me.btn_quit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txt_danhao)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lb_guest_name)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 75)
        Me.Panel1.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("微软雅黑", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(6, 52)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(143, 16)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "格式样例：YG201512260001"
        '
        'txt_danhao
        '
        Me.txt_danhao.Location = New System.Drawing.Point(57, 27)
        Me.txt_danhao.Name = "txt_danhao"
        Me.txt_danhao.Size = New System.Drawing.Size(100, 21)
        Me.txt_danhao.TabIndex = 11
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(227, 37)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(100, 20)
        Me.ComboBox2.TabIndex = 10
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"团体", "散客"})
        Me.ComboBox1.Location = New System.Drawing.Point(227, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 20)
        Me.ComboBox1.TabIndex = 9
        Me.ComboBox1.Text = "团体"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(165, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 12)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "结账宾客："
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(487, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lb_guest_name
        '
        Me.lb_guest_name.AutoSize = True
        Me.lb_guest_name.Location = New System.Drawing.Point(409, 30)
        Me.lb_guest_name.Name = "lb_guest_name"
        Me.lb_guest_name.Size = New System.Drawing.Size(47, 12)
        Me.lb_guest_name.TabIndex = 5
        Me.lb_guest_name.Text = "Label17"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(348, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "宾客姓名："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "结账房间："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "结账单号："
        '
        'btn_pay
        '
        Me.btn_pay.Location = New System.Drawing.Point(401, 76)
        Me.btn_pay.Name = "btn_pay"
        Me.btn_pay.Size = New System.Drawing.Size(75, 23)
        Me.btn_pay.TabIndex = 10
        Me.btn_pay.Text = "结账"
        Me.btn_pay.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lb_change)
        Me.Panel2.Controls.Add(Me.lb_discountmoney)
        Me.Panel2.Controls.Add(Me.lb_yajin)
        Me.Panel2.Controls.Add(Me.lb_shouldpay)
        Me.Panel2.Controls.Add(Me.lb_consume)
        Me.Panel2.Controls.Add(Me.txt_other)
        Me.Panel2.Controls.Add(Me.txt_guestpay)
        Me.Panel2.Controls.Add(Me.txt_realmoney)
        Me.Panel2.Controls.Add(Me.btn_quit)
        Me.Panel2.Controls.Add(Me.btn_pay)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(1, 79)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(580, 125)
        Me.Panel2.TabIndex = 15
        '
        'lb_change
        '
        Me.lb_change.AutoSize = True
        Me.lb_change.Location = New System.Drawing.Point(515, 46)
        Me.lb_change.Name = "lb_change"
        Me.lb_change.Size = New System.Drawing.Size(47, 12)
        Me.lb_change.TabIndex = 19
        Me.lb_change.Text = "Label13"
        '
        'lb_discountmoney
        '
        Me.lb_discountmoney.AutoSize = True
        Me.lb_discountmoney.Location = New System.Drawing.Point(515, 12)
        Me.lb_discountmoney.Name = "lb_discountmoney"
        Me.lb_discountmoney.Size = New System.Drawing.Size(47, 12)
        Me.lb_discountmoney.TabIndex = 18
        Me.lb_discountmoney.Text = "Label16"
        '
        'lb_yajin
        '
        Me.lb_yajin.AutoSize = True
        Me.lb_yajin.Location = New System.Drawing.Point(366, 12)
        Me.lb_yajin.Name = "lb_yajin"
        Me.lb_yajin.Size = New System.Drawing.Size(47, 12)
        Me.lb_yajin.TabIndex = 17
        Me.lb_yajin.Text = "Label15"
        '
        'lb_shouldpay
        '
        Me.lb_shouldpay.AutoSize = True
        Me.lb_shouldpay.Location = New System.Drawing.Point(225, 12)
        Me.lb_shouldpay.Name = "lb_shouldpay"
        Me.lb_shouldpay.Size = New System.Drawing.Size(47, 12)
        Me.lb_shouldpay.TabIndex = 16
        Me.lb_shouldpay.Text = "Label14"
        '
        'lb_consume
        '
        Me.lb_consume.AutoSize = True
        Me.lb_consume.Location = New System.Drawing.Point(81, 12)
        Me.lb_consume.Name = "lb_consume"
        Me.lb_consume.Size = New System.Drawing.Size(47, 12)
        Me.lb_consume.TabIndex = 15
        Me.lb_consume.Text = "Label13"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 12)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "结账备注："
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(474, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 12)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "找零："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(242, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 12)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "宾客支付："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 12)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "实收金额："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(450, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "优惠金额："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(302, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "已收押金："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(163, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "应收金额："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "消费金额："
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Location = New System.Drawing.Point(122, 210)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(459, 33)
        Me.Panel3.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(157, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(125, 12)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "结账区内房间消费清单"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(254, -13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 12)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "结账区内房间消费清单"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(122, 244)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(459, 141)
        Me.DataGridView1.TabIndex = 68
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Location = New System.Drawing.Point(1, 210)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(118, 33)
        Me.Panel4.TabIndex = 69
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(1, 244)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowTemplate.Height = 23
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(118, 141)
        Me.DataGridView2.TabIndex = 70
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(26, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 12)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "已结账单号"
        '
        'Guest_Pay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 386)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Guest_Pay"
        Me.Text = "收银结账"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_other As System.Windows.Forms.TextBox
    Friend WithEvents txt_guestpay As System.Windows.Forms.TextBox
    Friend WithEvents txt_realmoney As System.Windows.Forms.TextBox
    Friend WithEvents btn_quit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_pay As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lb_consume As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lb_discountmoney As System.Windows.Forms.Label
    Friend WithEvents lb_yajin As System.Windows.Forms.Label
    Friend WithEvents lb_shouldpay As System.Windows.Forms.Label
    Friend WithEvents lb_change As System.Windows.Forms.Label
    Friend WithEvents lb_guest_name As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_danhao As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
End Class
