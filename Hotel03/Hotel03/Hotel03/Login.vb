Imports System.Data.SqlClient

Public Class Login

    'Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Dim strconn As String
    '    strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
    '    Dim conn As New SqlConnection(strconn)
    '    Dim SQL As String
    '    SQL = "select * from pwd"
    '    Dim cmd As New SqlCommand(SQL, conn)
    '    conn.Open()
    '    Dim dr As SqlDataReader = cmd.ExecuteReader
    '    'ComboBox_Login.SelectedItem = dr.Item("name").ToString()
    '    conn.Close()
    'End Sub

    Private Sub Btn_Login_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Login_ok.Click
        If ComboBox_Login.SelectedItem = "" Or TxtBox_Loginpwd.Text = "" Then
            MessageBox.Show("用户名或密码输入不能为空！")
        Else
            Dim strconn As String
            strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
            Dim conn As New SqlConnection(strconn)
            Dim SQL As String
            SQL = "select userid as 姓名,pwd as 密码 from pwd where userid='" + ComboBox_Login.SelectedItem.ToString() + "' and pwd='" + TxtBox_Loginpwd.Text + "'"
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read() = True Then
                conn.Close()
                '隐藏之前的窗体
                Me.Hide()
                'stucontrol为局部变量
                Dim mainboard As New Mainboard
                mainboard.Show()
            Else
                conn.Close()
                MessageBox.Show("密码输入错误！")
            End If
        End If
    End Sub

    Private Sub Btn_Login_quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Login_quit.Click
        Me.Close()
    End Sub
End Class
