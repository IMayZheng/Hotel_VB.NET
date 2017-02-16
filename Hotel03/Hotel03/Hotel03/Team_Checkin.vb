Imports System.Data.SqlClient

Public Class Team_Checkin
    ''' <summary>
    ''' 无返回值且带参数的函数体.只能执行增删改的语句，查询不可以
    ''' </summary>
    ''' <param name="SQL">SQL语句</param>
    ''' <remarks></remarks>
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
        DataGridView_roominfo.DataSource = dt
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

    Private Sub Team_Checkin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SQL As String
        SQL = "select roominfo.id as 客房编号,roominfo.state as 客房状态,roomtype.price as 客房单价 from roominfo,roomtype where roominfo.r_type_id = roomtype.id and roominfo.state='可供' and  roomtype.r_type = '" + ComboBox_roomtype.SelectedItem.ToString() + "'"
        bindGridView1(SQL)
    End Sub

    Private Sub ComboBox_roomtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_roomtype.SelectedIndexChanged
        Dim SQL As String
        SQL = "select roominfo.id as 客房编号,roominfo.state as 客房状态,roomtype.price as 客房单价 from roominfo,roomtype where roominfo.r_type_id = roomtype.id and roominfo.state='可供' and  roomtype.r_type = '" + ComboBox_roomtype.SelectedItem.ToString() + "'"
        bindGridView1(SQL)
        Dim SQL1 As String
        SQL1 = "select roominfo.id as 客房编号,roominfo.state as 客房状态,roomtype.price as 客房单价 from roominfo,roomtype where roominfo.r_type_id = roomtype.id and roominfo.state='占用' and statetime='1'  "
        bindGridView2(SQL1)
    End Sub

    Private Sub bt_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_add.Click
        Dim roomid As String
        'Cell(0).Value表示取第0列的值,因为房间ID号是唯一的
        roomid = DataGridView_roominfo.Rows(DataGridView_roominfo.CurrentCell.RowIndex).Cells(0).Value
        '主客房间处的信息也要更新
        TextBox6.Text = roomid
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL As String
        SQL = "update roominfo set roominfo.state='占用',statetime='1' where id='" + roomid + "'"
        Dim cmd As New SqlCommand(SQL, conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        '开单房间处的数据表显示内容
        Dim SQL1 As String
        SQL1 = "select roominfo.id as 客房编号,roominfo.state as 客房状态,roomtype.price as 客房单价 from roominfo,roomtype where roominfo.r_type_id = roomtype.id and roominfo.state='占用' and statetime='1'  "
        bindGridView2(SQL1)
        '删除操作执行完后显示整个数据库里的数据
        Dim SQL2 As String
        SQL2 = "select roominfo.id as 客房编号,roominfo.state as 客房状态,roomtype.price as 客房单价 from roominfo,roomtype where roominfo.r_type_id = roomtype.id and roominfo.state='可供' and  roomtype.r_type = '" + ComboBox_roomtype.SelectedItem.ToString() + "'"
        bindGridView1(SQL2)
    End Sub

    Private Sub bt_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_delete.Click
        Dim roomid As String
        'Cell(0).Value表示取第0列的值,因为房间ID号是唯一的
        roomid = DataGridView_roomchecked.Rows(DataGridView_roomchecked.CurrentCell.RowIndex).Cells(0).Value
        TextBox6.Text = ""
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
        SQL1 = "select roominfo.id as 客房编号,roominfo.state as 客房状态,roomtype.price as 客房单价 from roominfo,roomtype where roominfo.r_type_id = roomtype.id and roominfo.state='可供' and roomtype.r_type = '" + ComboBox_roomtype.SelectedItem.ToString() + "'  "
        bindGridView1(SQL1)
        '删除操作执行完后显示整个数据库里的数据
        Dim SQL2 As String
        SQL2 = "select roominfo.id as 客房编号,roominfo.state as 客房状态,roomtype.price as 客房单价 from roominfo,roomtype where roominfo.r_type_id = roomtype.id and roominfo.state='占用' and   statetime='1'"
        bindGridView2(SQL2)
    End Sub

    Private Sub bt_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ok.Click
        '获取表中的总行数 注意是从1开始计算的
        Dim row_num As Integer
        row_num = DataGridView_roomchecked.RowCount
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        '得到宾客类型的ID号
        Dim SQL0 As String
        SQL0 = "select id from customertype where c_type='" + ComboBox2.SelectedItem.ToString() + "'"
        Dim id As String
        Dim cmd0 As New SqlCommand(SQL0, conn)
        conn.Open()
        '获取查询结果--第一行第一列
        id = cmd0.ExecuteScalar.ToString()
        conn.Close()
        '得到房间单价
        Dim SQL1 As String
        SQL1 = "select price from roomtype where r_type='" + ComboBox_roomtype.SelectedItem + "'"
        Dim price As String
        Dim cmd1 As New SqlCommand(SQL1, conn)
        conn.Open()
        price = cmd1.ExecuteScalar.ToString()
        conn.Close()
        Dim str As String
        str = TextBox1.Text
        If isValidID(str) = True Then
            Dim SQL As String
            Dim i As Integer
            Dim roomid2 As String
            For i = row_num To 1 Step -1
                'Cell(0).Value表示取第0列的值,因为房间ID号是唯一的
                roomid2 = DataGridView_roomchecked.Rows(i - 1).Cells(0).Value
                SQL = "insert into team (r_no,main_room,main_name,c_type_id,zj_type,zj_no,sex,renshu,address,premoney,days,price) values('" + roomid2 + "','" + TextBox6.Text + "','" + TextBox5.Text + "','" + id + "','" + ComboBox1.SelectedItem + "','" + TextBox1.Text + "','" + ComboBox3.SelectedItem + "','" + TextBox7.Text + "','" + TextBox3.Text + "','" + TextBox2.Text + " ','" + TextBox8.Text + "','" + price + "')"
                Dim cmd As New SqlCommand(SQL, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            Next
            Dim SQL2 As String
            For i = row_num To 1 Step -1
                '要从i-1开始，因为行列都是从0开始计算
                roomid2 = DataGridView_roomchecked.Rows(i - 1).Cells(0).Value
                SQL2 = "update roominfo set statetime='0',other1='团体' where id='" + roomid2 + "'"
                Dim cmd2 As New SqlCommand(SQL2, conn)
                conn.Open()
                cmd2.ExecuteNonQuery()
                conn.Close()
            Next
            Dim SQL3 As String
            SQL3 = "select roominfo.id as 客房编号,roominfo.state as 客房状态,roomtype.price as 客房单价 from roominfo,roomtype where roominfo.r_type_id = roomtype.id and roominfo.state='占用' and roominfo.statetime='1'"
            bindGridView2(SQL3)
        ElseIf isValidID(str) = False Then
            MessageBox.Show("请输入正确的证件号码！")
        End If
    End Sub

    Private Sub bt_quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_quit.Click
        Dim i As Integer
        Dim roomid As String
        Dim row_num As Integer
        row_num = DataGridView_roomchecked.RowCount

        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL As String
        For i = row_num To 1 Step -1
            '要从i-1开始，因为行列都是从0开始计算
            roomid = DataGridView_roomchecked.Rows(i - 1).Cells(0).Value
            SQL = "update roominfo set state='可供',statetime='0' where id='" + roomid + "'"
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        Next
        Me.Close()
    End Sub
End Class