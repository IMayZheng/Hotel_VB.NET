Imports System.Data.SqlClient

Public Class Guest_Management
    Sub bindGridView1(ByVal SQL As String)
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        '数据适配器
        Dim adp As New SqlDataAdapter(SQL, conn)
        Dim ds As New DataSet
        '此处的room不是数据库表的名字，是变量名，是可以改变的.但与下面的要统一
        adp.Fill(ds, "room")
        '建立数据表
        Dim dt As New DataTable
        dt = ds.Tables("room")
        DataGridView_guestinfo.DataSource = dt
    End Sub
    Private Sub Guest_Management_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SQL As String
        SQL = "select main_room as 主客房间,main_name as 主客姓名,c_type_id as 宾客类型,zj_type as 证件类型,zj_no as 证件号码,sex as 性别,address as 地址,days as 欲住天数 from team,roominfo where roominfo.id = team.r_no "
        bindGridView1(SQL)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim guest As String
        guest = ComboBox1.SelectedItem
        If guest = "团体" Then
            Dim SQL As String
            SQL = "select main_room as 主客房间,main_name as 主客姓名,c_type_id as 宾客类型,zj_type as 证件类型,zj_no as 证件号码,sex as 性别,address as 地址,days as 欲住天数 from team,roominfo where roominfo.id = team.r_no "
            bindGridView1(SQL)
        ElseIf guest = "散客" Then
            Dim SQL As String
            SQL = "select main_room as 主客房间,main_name as 主客姓名,c_type_id as 宾客类型,zj_type as 证件类型,zj_no as 证件号码,sex as 性别,address as 地址,days as 欲住天数 from personal,roominfo where roominfo.id = personal.r_no "
            bindGridView1(SQL)
        End If
    End Sub

    Private Sub bt_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_search.Click
        Dim guest As String
        guest = ComboBox1.SelectedItem
        If guest = "团体" Then
            Dim SQL As String
            SQL = "select main_room as 主客房间,main_name as 主客姓名,c_type_id as 宾客类型,zj_type as 证件类型,zj_no as 证件号码,sex as 性别,address as 地址,days as 欲住天数 from team where main_name='" + TextBox1.Text + "' or zj_no='" + TextBox1.Text + "'"
            bindGridView1(SQL)
        ElseIf guest = "散客" Then
            Dim SQL As String
            SQL = "select main_room as 主客房间,main_name as 主客姓名,c_type_id as 宾客类型,zj_type as 证件类型,zj_no as 证件号码,sex as 性别,address as 地址,days as 欲住天数 from personal where main_name='" + TextBox1.Text + "' or zj_no='" + TextBox1.Text + "'"
            bindGridView1(SQL)
        End If
    End Sub
End Class