<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.ComboBox_Login = New System.Windows.Forms.ComboBox()
        Me.TxtBox_Loginpwd = New System.Windows.Forms.TextBox()
        Me.Btn_Login_ok = New System.Windows.Forms.Button()
        Me.Btn_Login_quit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox_Login
        '
        Me.ComboBox_Login.FormattingEnabled = True
        Me.ComboBox_Login.Items.AddRange(New Object() {"admin"})
        Me.ComboBox_Login.Location = New System.Drawing.Point(247, 156)
        Me.ComboBox_Login.Name = "ComboBox_Login"
        Me.ComboBox_Login.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox_Login.TabIndex = 0
        Me.ComboBox_Login.Text = "admin"
        '
        'TxtBox_Loginpwd
        '
        Me.TxtBox_Loginpwd.Location = New System.Drawing.Point(247, 182)
        Me.TxtBox_Loginpwd.Name = "TxtBox_Loginpwd"
        Me.TxtBox_Loginpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtBox_Loginpwd.Size = New System.Drawing.Size(121, 21)
        Me.TxtBox_Loginpwd.TabIndex = 1
        '
        'Btn_Login_ok
        '
        Me.Btn_Login_ok.Location = New System.Drawing.Point(198, 216)
        Me.Btn_Login_ok.Name = "Btn_Login_ok"
        Me.Btn_Login_ok.Size = New System.Drawing.Size(69, 22)
        Me.Btn_Login_ok.TabIndex = 2
        Me.Btn_Login_ok.Text = "登录"
        Me.Btn_Login_ok.UseVisualStyleBackColor = True
        '
        'Btn_Login_quit
        '
        Me.Btn_Login_quit.Location = New System.Drawing.Point(299, 216)
        Me.Btn_Login_quit.Name = "Btn_Login_quit"
        Me.Btn_Login_quit.Size = New System.Drawing.Size(69, 22)
        Me.Btn_Login_quit.TabIndex = 3
        Me.Btn_Login_quit.Text = "取消"
        Me.Btn_Login_quit.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(410, 242)
        Me.Controls.Add(Me.Btn_Login_quit)
        Me.Controls.Add(Me.Btn_Login_ok)
        Me.Controls.Add(Me.TxtBox_Loginpwd)
        Me.Controls.Add(Me.ComboBox_Login)
        Me.Name = "Login"
        Me.Text = "管理员登录窗口"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox_Login As System.Windows.Forms.ComboBox
    Friend WithEvents TxtBox_Loginpwd As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Login_ok As System.Windows.Forms.Button
    Friend WithEvents Btn_Login_quit As System.Windows.Forms.Button

End Class
