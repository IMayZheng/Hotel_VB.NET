<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guest_PreOrder
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
        Me.bt_delete = New System.Windows.Forms.Button()
        Me.bt_update = New System.Windows.Forms.Button()
        Me.bt_add = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView_guest_preorder_info = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView_guest_preorder_info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.bt_search)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.bt_delete)
        Me.Panel1.Controls.Add(Me.bt_update)
        Me.Panel1.Controls.Add(Me.bt_add)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 52)
        Me.Panel1.TabIndex = 0
        '
        'bt_search
        '
        Me.bt_search.Location = New System.Drawing.Point(561, 14)
        Me.bt_search.Name = "bt_search"
        Me.bt_search.Size = New System.Drawing.Size(75, 23)
        Me.bt_search.TabIndex = 5
        Me.bt_search.Text = "查询"
        Me.bt_search.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(410, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 21)
        Me.TextBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(289, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "房间号/姓名/电话："
        '
        'bt_delete
        '
        Me.bt_delete.Location = New System.Drawing.Point(200, 12)
        Me.bt_delete.Name = "bt_delete"
        Me.bt_delete.Size = New System.Drawing.Size(70, 26)
        Me.bt_delete.TabIndex = 2
        Me.bt_delete.Text = "删除"
        Me.bt_delete.UseVisualStyleBackColor = True
        '
        'bt_update
        '
        Me.bt_update.Location = New System.Drawing.Point(111, 12)
        Me.bt_update.Name = "bt_update"
        Me.bt_update.Size = New System.Drawing.Size(71, 26)
        Me.bt_update.TabIndex = 1
        Me.bt_update.Text = "修改"
        Me.bt_update.UseVisualStyleBackColor = True
        '
        'bt_add
        '
        Me.bt_add.Location = New System.Drawing.Point(24, 12)
        Me.bt_add.Name = "bt_add"
        Me.bt_add.Size = New System.Drawing.Size(71, 26)
        Me.bt_add.TabIndex = 0
        Me.bt_add.Text = "增加"
        Me.bt_add.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView_guest_preorder_info)
        Me.Panel2.Location = New System.Drawing.Point(0, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(792, 290)
        Me.Panel2.TabIndex = 1
        '
        'DataGridView_guest_preorder_info
        '
        Me.DataGridView_guest_preorder_info.AllowUserToAddRows = False
        Me.DataGridView_guest_preorder_info.AllowUserToDeleteRows = False
        Me.DataGridView_guest_preorder_info.AllowUserToResizeColumns = False
        Me.DataGridView_guest_preorder_info.AllowUserToResizeRows = False
        Me.DataGridView_guest_preorder_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_guest_preorder_info.Location = New System.Drawing.Point(0, 35)
        Me.DataGridView_guest_preorder_info.Name = "DataGridView_guest_preorder_info"
        Me.DataGridView_guest_preorder_info.RowHeadersVisible = False
        Me.DataGridView_guest_preorder_info.RowTemplate.Height = 23
        Me.DataGridView_guest_preorder_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_guest_preorder_info.Size = New System.Drawing.Size(792, 255)
        Me.DataGridView_guest_preorder_info.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(0, 53)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(792, 34)
        Me.Panel3.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(347, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "客户预订信息"
        '
        'Guest_PreOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 340)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Guest_PreOrder"
        Me.Text = "客户预订"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView_guest_preorder_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bt_search As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_delete As System.Windows.Forms.Button
    Friend WithEvents bt_update As System.Windows.Forms.Button
    Friend WithEvents bt_add As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView_guest_preorder_info As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
