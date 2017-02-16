Imports System.Data.SqlClient

Public Class PreReservation_update
    Public c_name2 As String

    Private Sub BindComBoxData1()
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        '数据适配器
        Dim Sql As String
        Sql = "select * from roomtype"
        Dim adp As New SqlDataAdapter(Sql, conn)
        Dim ds As New DataSet
        '此处的room不是数据库表的名字，是变量名，是可以改变的.但与下面的要统一
        adp.Fill(ds, "room")
        '建立数据表
        Dim dt As New DataTable
        dt = ds.Tables("room")
        Me.ComboBox1_guige.DisplayMember = "r_type"
        Me.ComboBox1_guige.ValueMember = "id"
        Me.ComboBox1_guige.DataSource = dt

    End Sub
    Private Sub BindComBoxData2(ByVal SQL As String)
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
        Me.ComboBox2_r_no.DisplayMember = "id"
        Me.ComboBox2_r_no.ValueMember = "id"
        Me.ComboBox2_r_no.DataSource = dt

    End Sub
    Private Sub PreReservation_update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '接收从表中传过来的数据
        'Dim guest_preorder As New Guest_PreOrder
        'c_name2 = guest_preorder.c_name1
        txt_name.Text = c_name2
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL As String
        SQL = "select * from engage where c_name='" + txt_name.Text + "'"
        Dim cmd As New SqlCommand(SQL, conn)
        conn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read() Then
            '显示宾客的联系方式
            txt_tel.Text = dr.Item("c_tel").ToString()
            '显示预抵时间
            txt_pa_time.Text = dr.Item("pa_time").ToString()
            '显示保留时间
            txt_keep_time.Text = dr.Item("keep_time").ToString()
            '显示备注信息
            txt_other.Text = dr.Item("other1").ToString()
            '显示房间编号
            BindComBoxData1()
            ComboBox1_guige.SelectedValue = dr.Item("r_type_id").ToString()
            ComboBox2_r_no.Text = dr.Item("r_no").ToString()
            '显示预订房间的规格
            '  ComboBox1_guige.SelectedValue = dr.Item("r_type_id").ToString()
            conn.Close()
        End If
    End Sub

    Private Sub Button1_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1_save.Click
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        '更新roominfo里的房间状态 一定在更新engage之前
        Dim SQL2 As String
        SQL2 = "select r_no from engage where c_name='" + txt_name.Text + "'"
        Dim room_no As String
        Dim cmd2 As New SqlCommand(SQL2, conn)
        conn.Open()
        '获取查询结果--第一行第一列
        room_no = cmd2.ExecuteScalar.ToString()
        conn.Close()
        Dim SQL3 As String
        SQL3 = "update roominfo set state='可供' where id='" + room_no + "'"
        Dim cmd3 As New SqlCommand(SQL3, conn)
        conn.Open()
        cmd3.ExecuteNonQuery()
        conn.Close()
        '获取房间规格的ID号
        Dim SQL0 As String
        SQL0 = "select id from roomtype where r_type='" + ComboBox1_guige.SelectedItem.ToString() + "'"
        Dim r_id As String
        Dim cmd0 As New SqlCommand(SQL0, conn)
        conn.Open()
        r_id = cmd0.ExecuteScalar.ToString()
        conn.Close()
        '更新engage数据库
        Dim SQL As String
        SQL = "update engage set c_tel='" + txt_tel.Text + "',r_type_id='" + r_id + "',r_no='" + ComboBox2_r_no.SelectedItem.ToString() + "',pa_time='" + txt_pa_time.Text + "',keep_time='" + txt_keep_time.Text + "',other1='" + txt_other.Text + "'"
        Dim cmd As New SqlCommand(SQL, conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub

    Private Sub ComboBox1_guige_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1_guige.SelectedValueChanged
        Dim Sql As String
        Sql = "select * from roominfo where r_type_id = '" + ComboBox1_guige.SelectedValue + "' and state = '可供'"
        BindComBoxData2(Sql)
    End Sub
End Class