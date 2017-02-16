<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreReservation_update
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
        Me.txt_other = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_keep_time = New System.Windows.Forms.TextBox()
        Me.txt_pa_time = New System.Windows.Forms.TextBox()
        Me.ComboBox2_r_no = New System.Windows.Forms.ComboBox()
        Me.ComboBox1_guige = New System.Windows.Forms.ComboBox()
        Me.txt_tel = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2_quit
        '
        Me.Button2_quit.Location = New System.Drawing.Point(244, 341)
        Me.Button2_quit.Name = "Button2_quit"
        Me.Button2_quit.Size = New System.Drawing.Size(75, 23)
        Me.Button2_quit.TabIndex = 33
        Me.Button2_quit.Text = "取消"
        Me.Button2_quit.UseVisualStyleBackColor = True
        '
        'Button1_save
        '
        Me.Button1_save.Location = New System.Drawing.Point(59, 341)
        Me.Button1_save.Name = "Button1_save"
        Me.Button1_save.Size = New System.Drawing.Size(75, 23)
        Me.Button1_save.TabIndex = 32
        Me.Button1_save.Text = "保存"
        Me.Button1_save.UseVisualStyleBackColor = True
        '
        'txt_other
        '
        Me.txt_other.Location = New System.Drawing.Point(67, 288)
        Me.txt_other.Name = "txt_other"
        Me.txt_other.Size = New System.Drawing.Size(286, 21)
        Me.txt_other.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 12)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "备注："
        '
        'txt_keep_time
        '
        Me.txt_keep_time.Location = New System.Drawing.Point(154, 251)
        Me.txt_keep_time.Name = "txt_keep_time"
        Me.txt_keep_time.Size = New System.Drawing.Size(116, 21)
        Me.txt_keep_time.TabIndex = 29
        '
        'txt_pa_time
        '
        Me.txt_pa_time.Location = New System.Drawing.Point(154, 206)
        Me.txt_pa_time.Name = "txt_pa_time"
        Me.txt_pa_time.Size = New System.Drawing.Size(116, 21)
        Me.txt_pa_time.TabIndex = 28
        '
        'ComboBox2_r_no
        '
        Me.ComboBox2_r_no.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboBox2_r_no.FormattingEnabled = True
        Me.ComboBox2_r_no.Location = New System.Drawing.Point(154, 170)
        Me.ComboBox2_r_no.Name = "ComboBox2_r_no"
        Me.ComboBox2_r_no.Size = New System.Drawing.Size(116, 20)
        Me.ComboBox2_r_no.TabIndex = 27
        '
        'ComboBox1_guige
        '
        Me.ComboBox1_guige.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboBox1_guige.FormattingEnabled = True
        Me.ComboBox1_guige.Items.AddRange(New Object() {"标准单人间", "标准双人间", "豪华单人间", "豪华双人间", "商务套房", "总统套房"})
        Me.ComboBox1_guige.Location = New System.Drawing.Point(154, 135)
        Me.ComboBox1_guige.Name = "ComboBox1_guige"
        Me.ComboBox1_guige.Size = New System.Drawing.Size(116, 20)
        Me.ComboBox1_guige.TabIndex = 26
        '
        'txt_tel
        '
        Me.txt_tel.Location = New System.Drawing.Point(154, 98)
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(116, 21)
        Me.txt_tel.TabIndex = 25
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(154, 58)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(116, 21)
        Me.txt_name.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(69, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "保留时间："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "预抵时间："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "房间编号："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "预订规格："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "基本预订信息"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "联系电话："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "宾客姓名："
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(364, 40)
        Me.Panel1.TabIndex = 17
        '
        'PreReservation_update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 378)
        Me.Controls.Add(Me.Button2_quit)
        Me.Controls.Add(Me.Button1_save)
        Me.Controls.Add(Me.txt_other)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_keep_time)
        Me.Controls.Add(Me.txt_pa_time)
        Me.Controls.Add(Me.ComboBox2_r_no)
        Me.Controls.Add(Me.ComboBox1_guige)
        Me.Controls.Add(Me.txt_tel)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PreReservation_update"
        Me.Text = "客户预订信息修改"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2_quit As System.Windows.Forms.Button
    Friend WithEvents Button1_save As System.Windows.Forms.Button
    Friend WithEvents txt_other As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_keep_time As System.Windows.Forms.TextBox
    Friend WithEvents txt_pa_time As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2_r_no As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1_guige As System.Windows.Forms.ComboBox
    Friend WithEvents txt_tel As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
