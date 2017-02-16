Imports System.Data.SqlClient

Public Class Personal_Checkin
    '用于计数开房个数
    Public count As Integer = 0

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
        DataGridView_room_canuse.DataSource = dt
    End Sub
    '用于显示开单房间处的信息
    Sub bindGridView2(ByVal SQL As String)
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
        DataGridView_roomchecked.DataSource = dt
    End Sub

    '判断输入的证件号码是否正确 15位身份证只能为数字，18位身份证除最后一位可以为字母，其余位只能为数字
    Function isValidID(ByVal str As String)
        Dim i As Integer
        If str.Length <> 15 And str.Length <> 18 Then
            Return False
        End If
        For i = 0 To i < str.Length Step +1
            '如果是18位身份证
            If str.Length = 18 Then
                '除最后一位之外
                If i <> str.Length - 1 Then
                    If str.Substring(i) > "9" Or str.Substring(i) < "0" Then
                        Return False
                    End If
                    '判断18位身份证的的最后一位
                ElseIf str.Substring(i) < "0" Or str.Substring(i) > "9" And str.Substring(i) < "A" Or str.Substring(i) > "Z" And str.Substring(i) < "a" Or str.Substring(i) > "z" Then
                    Return False
                End If
                '是15位身份证
            ElseIf str.Substring(i) > "9" Or str.Substring(i) < "0" Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub Personal_Checkin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SQL As String
        SQL = "select roominfo.id as 客房编号,roomtype.price as 客房单价 from roominfo,roomtype where roominfo.r_type_id = roomtype.id and roominfo.state='可供' and  roomtype.r_type = '" + ComboBox_roomtype.SelectedItem.ToString() + "'"
        bindGridView1(SQL)
    End Sub

    Private Sub ComboBox_roomtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_roomtype.SelectedIndexChanged
        Dim price As Double
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL0 As String
        SQL0 = "select price from roomtype where r_type='" + ComboBox_roomtype.SelectedItem.ToString() + "'"
        Dim cmd0 As New SqlCommand(SQL0, conn)
        conn.Open()
        '获取查询结果--第一行第一列
        price = cmd0.ExecuteScalar.ToString()
        conn.Close()
        Dim SQL As String
        SQL = "select roominfo.id as 客房编号,roomtype.price as 客房单价 from roominfo,roomtype where roominfo.r_type_id = roomtype.id and roominfo.state='可供' and  roomtype.r_type = '" + ComboBox_roomtype.SelectedItem.ToString() + "'"
        bindGridView1(SQL)
        Dim SQL1 As String
        SQL1 = "select roominfo.id as 客房编号,roomtype.price as 客房单价 from roominfo,roomtype where roominfo.r_type_id = roomtype.id and roominfo.state='占用' and statetime='1' "
        bindGridView2(SQL1)
        lb_preprice.Text = ("￥") + price.ToString()
        txt_realprice.Text = (txt_discount.Text / 10 * price).ToString()
    End Sub

    Private Sub btn_toright_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_toright.Click

        Dim i As Integer
        Dim roomid2 As String
        Dim row_num As Integer
        row_num = DataGridView_roomchecked.RowCount

        Dim roomid1 As String
        'Cell(0).Value表示取第0列的值,因为房间ID号是唯一的
        roomid1 = DataGridView_room_canuse.Rows(DataGridView_room_canuse.CurrentCell.RowIndex).Cells(0).Value
        '主客房间处的信息也要更新
        TextBox1.Text = roomid1
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        '获取当前房间类型
        Dim SQL0 As String
        SQL0 = "select id from roomtype where r_type='" + ComboBox_roomtype.SelectedItem.ToString() + "'"
        'SQL0 = "select id from roominfo where id='" + roomid1 + "'"
        Dim room_type_id As String
        Dim cmd0 As New SqlCommand(SQL0, conn)
        conn.Open()
        '获取查询结果--第一行第一列
        room_type_id = cmd0.ExecuteScalar.ToString()
        conn.Close()
        Dim SQL1 As String
        If row_num = 0 Then
            Dim SQL As String
            SQL = "update roominfo set roominfo.state='占用',statetime='1' where id='" + roomid1 + "'"
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        ElseIf row_num < 4 Then
            For i = 1 To row_num Step +1
                roomid2 = DataGridView_roomchecked.Rows(i - 1).Cells(0).Value
                SQL1 = "select r_type_id from roominfo where id='" + roomid2 + "'"
                Dim room_type_id1 As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                conn.Open()
                room_type_id1 = cmd1.ExecuteScalar.ToString()
                conn.Close()
                Dim SQL As String
                If room_type_id = room_type_id1 Then
                    SQL = "update roominfo set roominfo.state='占用',statetime='1' where id='" + roomid1 + "'"
                    Dim cmd As New SqlCommand(SQL, conn)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                Else
                    MessageBox.Show("请选择相同类型的房间！")
                    '不添加刚才选中的不符合条件的房间
                    SQL = "update roominfo set roominfo.state='可供',statetime='0' where id='" + roomid1 + "'"
                    Dim SQL2 As String
                    SQL2 = "update roominfo set roominfo.state='可供',statetime='0' where id='" + roomid2 + "'"
                    Dim cmd As New SqlCommand(SQL, conn)
                    Dim cmd2 As New SqlCommand(SQL2, conn)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    cmd2.ExecuteNonQuery()
                    conn.Close()
                End If
            Next
        ElseIf row_num >= 4 Then
            MessageBox.Show("房间个数不能超过4间！")
        End If
        '开单房间处的数据表显示内容
        Dim SQL3 As String
        SQL3 = "select roominfo.id as 客房编号,roomtype.price as 客房单价 from roominfo,roomtype where roominfo.r_type_id = roomtype.id and roominfo.state='占用' and statetime='1'  "
        bindGridView2(SQL3)
        '删除操作执行完后显示整个数据库里的数据
        Dim SQL4 As String
        SQL4 = "select roominfo.id as 客房编号,roomtype.price as 客房单价 from roominfo,roomtype where roominfo.r_type_id = roomtype.id and roominfo.state='可供' and  roomtype.r_type = '" + ComboBox_roomtype.SelectedItem.ToString() + "'"
        bindGridView1(SQL4)
    End Sub

    Private Sub btn_toleft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_toleft.Click
        Dim roomid As String
        'Cell(0).Value表示取第0列的值,因为房间ID号是唯一的
        roomid = DataGridView_roomchecked.Rows(DataGridView_roomchecked.CurrentCell.RowIndex).Cells(0).Value
        TextBox1.Text = ""
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL As String
        SQL = "update roominfo set roominfo.state='可供',statetime='0' where id='" + roomid + "'"
        Dim cmd As New SqlCommand(SQL, conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        '房间信息处的数据表显示内容
        Dim SQL1 As String
        SQL1 = "select roominfo.id as 客房编号,roomtype.price as 客房单价 from roominfo,roomtype where roominfo.r_type_id = roomtype.id and roominfo.state='可供' and roomtype.r_type = '" + ComboBox_roomtype.SelectedItem.ToString() + "'  "
        bindGridView1(SQL1)
        '删除操作执行完后显示整个数据库里的数据
        Dim SQL2 As String
        SQL2 = "select roominfo.id as 客房编号,roomtype.price as 客房单价 from roominfo,roomtype where roominfo.r_type_id = roomtype.id and roominfo.state='占用' and   statetime='1' "
        bindGridView2(SQL2)
    End Sub

    Private Sub btn_quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_quit.Click
        Dim i As Integer
        Dim roomid2 As String
        Dim row_num As Integer
        row_num = DataGridView_roomchecked.RowCount
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL As String
        For i = row_num To 1 Step -1
            '要从i-1开始，因为行列都是从0开始计算
            roomid2 = DataGridView_roomchecked.Rows(i - 1).Cells(0).Value
            SQL = "update roominfo set state='可供',statetime='0' where id='" + roomid2 + "'"
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        Next
        '关闭窗体时计数器清零
        count = 0
        Me.Close()
    End Sub

    Private Sub btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        '获取表中的总行数 注意是从1开始计算的
        Dim row_num As Integer
        row_num = DataGridView_roomchecked.RowCount

        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        '得到宾客类型的ID号
        Dim SQL0 As String
        SQL0 = "select id from customertype where c_type='" + ComboBox3.SelectedItem.ToString() + "'"
        Dim id As String
        Dim cmd0 As New SqlCommand(SQL0, conn)
        conn.Open()
        '获取查询结果--第一行第一列
        id = cmd0.ExecuteScalar.ToString()
        conn.Close()
        '得到折扣比例处的折扣
        'Dim SQL1 As String
        'SQL1 = "select discount from customertype where c_type='" + ComboBox3.SelectedItem.ToString() + "'"
        'Dim discount As String
        'Dim cmd1 As New SqlCommand(SQL1, conn)
        'conn.Open()
        'discount = cmd1.ExecuteScalar.ToString()
        'conn.Close()
        'txt_discount.Text = discount.ToString()
        '得到房间单价
        Dim SQL2 As String
        SQL2 = "select price from roomtype where r_type='" + ComboBox_roomtype.SelectedItem.ToString() + "'"
        Dim price As String
        Dim cmd2 As New SqlCommand(SQL2, conn)
        conn.Open()
        price = cmd2.ExecuteScalar.ToString()
        conn.Close()
        '实收单价处的价格
        'txt_realprice.Text = (txt_discount.Text / 10 * price).ToString()
        Dim str As String
        str = txt_zj_no.Text
        If isValidID(str) = True Then
            Dim SQL As String
            Dim i As Integer
            Dim roomid2 As String
            For i = row_num To 1 Step -1
                'Cell(0).Value表示取第0列的值,因为房间ID号是唯一的
                roomid2 = DataGridView_roomchecked.Rows(i - 1).Cells(0).Value
                SQL = "insert into personal (r_no,main_room,main_name,zj_type,zj_no,c_type_id,sex,renshu,address,premoney,price,days,discount,realprice) values('" + roomid2 + "','" + TextBox1.Text + "','" + txt_mainguest_name.Text + "','" + ComboBox1.SelectedItem + "','" + txt_zj_no.Text + "','" + id + "','" + ComboBox5.SelectedItem + "','" + txt_renshu.Text + "','" + txt_address.Text + "','" + txt_premoney.Text + " ','" + price + "','" + txt_predays.Text + "','" + txt_discount.Text + "','" + txt_realprice.Text + "')"
                Dim cmd As New SqlCommand(SQL, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            Next
            Dim SQL3 As String
            For i = row_num To 1 Step -1
                '要从i-1开始，因为行列都是从0开始计算
                roomid2 = DataGridView_roomchecked.Rows(i - 1).Cells(0).Value
                SQL3 = "update roominfo set statetime='0',other1='散客' where id='" + roomid2 + "'"
                Dim cmd3 As New SqlCommand(SQL3, conn)
                conn.Open()
                cmd3.ExecuteNonQuery()
                conn.Close()
            Next
            Dim SQL4 As String
            SQL4 = "select roominfo.id as 客房编号,roomtype.price as 客房单价 from roominfo,roomtype where roominfo.r_type_id = roomtype.id and roominfo.state='占用' and roominfo.statetime='1'"
            bindGridView2(SQL4)
        ElseIf isValidID(str) = False Then
            MessageBox.Show("请输入正确的证件号码！")
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        '得到折扣比例处的折扣
        Dim SQL1 As String
        SQL1 = "select discount from customertype where c_type='" + ComboBox3.SelectedItem.ToString() + "'"
        Dim discount As String
        Dim cmd1 As New SqlCommand(SQL1, conn)
        conn.Open()
        discount = cmd1.ExecuteScalar.ToString()
        conn.Close()
        txt_discount.Text = discount.ToString()
    End Sub
End Class