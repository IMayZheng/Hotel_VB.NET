<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bill
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
        Me.txt_searchconditions = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lb_paytime = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_searchconditions
        '
        Me.txt_searchconditions.Location = New System.Drawing.Point(158, 70)
        Me.txt_searchconditions.Name = "txt_searchconditions"
        Me.txt_searchconditions.Size = New System.Drawing.Size(126, 21)
        Me.txt_searchconditions.TabIndex = 7
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(354, 68)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 23)
        Me.btn_search.TabIndex = 6
        Me.btn_search.Text = "查询"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(593, 398)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.lb_paytime)
        Me.TabPage1.Controls.Add(Me.txt_searchconditions)
        Me.TabPage1.Controls.Add(Me.btn_search)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(585, 372)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "结账单查询"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(585, 268)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "结账状态信息"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 17)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(571, 245)
        Me.DataGridView1.TabIndex = 0
        '
        'lb_paytime
        '
        Me.lb_paytime.AutoSize = True
        Me.lb_paytime.Location = New System.Drawing.Point(156, 35)
        Me.lb_paytime.Name = "lb_paytime"
        Me.lb_paytime.Size = New System.Drawing.Size(41, 12)
        Me.lb_paytime.TabIndex = 8
        Me.lb_paytime.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "姓名/房间号/账单号："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(85, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "结账时间："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(243, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "总营业额："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(303, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Label3"
        '
        'Bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 398)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Bill"
        Me.Text = "营业查询"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_searchconditions As System.Windows.Forms.TextBox
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lb_paytime As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
