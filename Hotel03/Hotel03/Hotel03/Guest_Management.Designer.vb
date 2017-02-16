<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guest_Management
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
        Me.bt_search = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView_guestinfo = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView_guestinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.bt_search)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 100)
        Me.Panel1.TabIndex = 0
        '
        'bt_search
        '
        Me.bt_search.Location = New System.Drawing.Point(370, 66)
        Me.bt_search.Name = "bt_search"
        Me.bt_search.Size = New System.Drawing.Size(75, 23)
        Me.bt_search.TabIndex = 2
        Me.bt_search.Text = "查询"
        Me.bt_search.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(220, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 21)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "来宾姓名/证件编号："
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.DataGridView_guestinfo)
        Me.Panel2.Location = New System.Drawing.Point(0, 107)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(541, 283)
        Me.Panel2.TabIndex = 1
        '
        'DataGridView_guestinfo
        '
        Me.DataGridView_guestinfo.AllowUserToAddRows = False
        Me.DataGridView_guestinfo.AllowUserToDeleteRows = False
        Me.DataGridView_guestinfo.AllowUserToResizeColumns = False
        Me.DataGridView_guestinfo.AllowUserToResizeRows = False
        Me.DataGridView_guestinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_guestinfo.Location = New System.Drawing.Point(0, 32)
        Me.DataGridView_guestinfo.Name = "DataGridView_guestinfo"
        Me.DataGridView_guestinfo.RowHeadersVisible = False
        Me.DataGridView_guestinfo.RowTemplate.Height = 23
        Me.DataGridView_guestinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_guestinfo.Size = New System.Drawing.Size(541, 251)
        Me.DataGridView_guestinfo.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(0, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(541, 28)
        Me.Panel3.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(238, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "来宾信息"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "来宾类型："
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"团体", "散客"})
        Me.ComboBox1.Location = New System.Drawing.Point(220, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(101, 20)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.Text = "团体"
        '
        'Guest_Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 393)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Guest_Management"
        Me.Text = "客户管理"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView_guestinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bt_search As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView_guestinfo As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
