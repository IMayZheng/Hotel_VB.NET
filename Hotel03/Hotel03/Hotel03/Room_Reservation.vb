Imports System.Data.SqlClient

Public Class Room_Reservation
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
        DataGridView1.DataSource = dt
    End Sub
    Private Sub ComboBox1_r_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1_r_type.SelectedIndexChanged
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        If ComboBox1_r_type.SelectedItem = "标准单人间" Then
            '在添加进去之前需要清空之前添加进去的数据
            ComboBox2_r_no.Items.Clear()
            Dim SQL As String
            SQL = "select id from roominfo where r_type_id='LX0001' and state='可供'"
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            '数据适配器
            Dim adp As New SqlDataAdapter(SQL, conn)
            Dim ds As New DataSet
            adp.Fill(ds, "roominfo")
            '用于从数据库提取数据放入comboBox里
            For i = ds.Tables(0).Rows.Count To 1 Step -1
                '去掉下拉框中的重复项
                If ComboBox2_r_no.Items.Contains(ds.Tables(0).Rows(i - 1).Item(0).ToString()) = False Then
                    ComboBox2_r_no.Items.Add(ds.Tables(0).Rows(i - 1).Item(0).ToString())
                End If
            Next
        ElseIf ComboBox1_r_type.SelectedItem = "标准双人间" Then
            '在添加进去之前需要清空之前添加进去的数据
            ComboBox2_r_no.Items.Clear()
            Dim SQL As String
            SQL = "select id from roominfo where r_type_id='LX0002' and state='可供'"
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            '数据适配器
            Dim adp As New SqlDataAdapter(SQL, conn)
            Dim ds As New DataSet
            adp.Fill(ds, "roominfo")
            '用于从数据库提取数据放入comboBox里
            For i = ds.Tables(0).Rows.Count To 1 Step -1
                '去掉下拉框中的重复项
                If ComboBox2_r_no.Items.Contains(ds.Tables(0).Rows(i - 1).Item(0).ToString()) = False Then
                    ComboBox2_r_no.Items.Add(ds.Tables(0).Rows(i - 1).Item(0).ToString())
                End If
            Next
        ElseIf ComboBox1_r_type.SelectedItem = "豪华单人间" Then
            '在添加进去之前需要清空之前添加进去的数据
            ComboBox2_r_no.Items.Clear()
            Dim SQL As String
            SQL = "select id from roominfo where r_type_id='LX0003' and state='可供'"
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            '数据适配器
            Dim adp As New SqlDataAdapter(SQL, conn)
            Dim ds As New DataSet
            adp.Fill(ds, "roominfo")
            '用于从数据库提取数据放入comboBox里
            For i = ds.Tables(0).Rows.Count To 1 Step -1
                '去掉下拉框中的重复项
                If ComboBox2_r_no.Items.Contains(ds.Tables(0).Rows(i - 1).Item(0).ToString()) = False Then
                    ComboBox2_r_no.Items.Add(ds.Tables(0).Rows(i - 1).Item(0).ToString())
                End If
            Next
        ElseIf ComboBox1_r_type.SelectedItem = "豪华双人间" Then
            '在添加进去之前需要清空之前添加进去的数据
            ComboBox2_r_no.Items.Clear()
            Dim SQL As String
            SQL = "select id from roominfo where r_type_id='LX0004' and state='可供'"
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            '数据适配器
            Dim adp As New SqlDataAdapter(SQL, conn)
            Dim ds As New DataSet
            adp.Fill(ds, "roominfo")
            '用于从数据库提取数据放入comboBox里
            For i = ds.Tables(0).Rows.Count To 1 Step -1
                '去掉下拉框中的重复项
                If ComboBox2_r_no.Items.Contains(ds.Tables(0).Rows(i - 1).Item(0).ToString()) = False Then
                    ComboBox2_r_no.Items.Add(ds.Tables(0).Rows(i - 1).Item(0).ToString())
                End If
            Next
        ElseIf ComboBox1_r_type.SelectedItem = "商务套房" Then
            '在添加进去之前需要清空之前添加进去的数据
            ComboBox2_r_no.Items.Clear()
            Dim SQL As String
            SQL = "select id from roominfo where r_type_id='LX0005' and state='可供'"
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            '数据适配器
            Dim adp As New SqlDataAdapter(SQL, conn)
            Dim ds As New DataSet
            adp.Fill(ds, "roominfo")
            '用于从数据库提取数据放入comboBox里
            For i = ds.Tables(0).Rows.Count To 1 Step -1
                '去掉下拉框中的重复项
                If ComboBox2_r_no.Items.Contains(ds.Tables(0).Rows(i - 1).Item(0).ToString()) = False Then
                    ComboBox2_r_no.Items.Add(ds.Tables(0).Rows(i - 1).Item(0).ToString())
                End If
            Next
        ElseIf ComboBox1_r_type.SelectedItem = "总统套房" Then
            '在添加进去之前需要清空之前添加进去的数据
            ComboBox2_r_no.Items.Clear()
            Dim SQL As String
            SQL = "select id from roominfo where r_type_id='LX0006' and state='可供'"
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            '数据适配器
            Dim adp As New SqlDataAdapter(SQL, conn)
            Dim ds As New DataSet
            adp.Fill(ds, "roominfo")
            '用于从数据库提取数据放入comboBox里
            For i = ds.Tables(0).Rows.Count To 1 Step -1
                '去掉下拉框中的重复项
                If ComboBox2_r_no.Items.Contains(ds.Tables(0).Rows(i - 1).Item(0).ToString()) = False Then
                    ComboBox2_r_no.Items.Add(ds.Tables(0).Rows(i - 1).Item(0).ToString())
                End If
            Next
        End If
    End Sub

    Private Sub Button1_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1_save.Click
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        '得到房间类型的ID号
        Dim SQL0 As String
        SQL0 = "select id from roomtype where r_type='" + ComboBox1_r_type.SelectedItem.ToString() + "'"
        Dim r_id As String
        Dim cmd0 As New SqlCommand(SQL0, conn)
        conn.Open()
        '获取查询结果--第一行第一列
        r_id = cmd0.ExecuteScalar.ToString()
        conn.Close()
        '插入数据进入数据库
        Dim SQL As String
        SQL = "insert into engage(c_name,c_tel,r_type_id,r_no,pa_time,keep_time,eng_time,engagemark,cluemark,delmark,other1) values('" + txt_c_name.Text + "','" + txt_c_tel.Text + "','" + r_id + "','" + ComboBox2_r_no.SelectedItem.ToString() + "','" + txt_engage_time.Text + "','" + txt_keep_time.Text + "','" + Now() + "','0','0','0','" + txt_other.Text + "')"
        Dim cmd As New SqlCommand(SQL, conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        '更改roominfo中房间的状态信息为——预订
        Dim SQL1 As String
        SQL1 = "update roominfo set state='预订' where id='" + ComboBox2_r_no.SelectedItem.ToString() + "'"
        Dim cmd1 As New SqlCommand(SQL1, conn)
        conn.Open()
        cmd1.ExecuteNonQuery()
        conn.Close()
        ComboBox2_r_no.Text = ""
    End Sub

    Private Sub btn_toright_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_toright.Click
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL As String
        SQL = "select r_type_id as 房间类型,id as 房间编号 from roominfo where id='" + ComboBox2_r_no.SelectedItem.ToString() + "'"
        bindGridView1(SQL)
    End Sub

    Private Sub Button2_quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2_quit.Click
        Me.Close()
    End Sub

    Private Sub Room_Reservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class