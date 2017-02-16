Imports System.Data.SqlClient

Public Class Guest_Pay
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
        DataGridView2.DataSource = dt
    End Sub

    '判断输入的单号是否正确 14位，前两位只能是YG，其余位只能为数字
    Function isValidID(ByVal str As String)
        Dim i As Integer
        If str.Length <> 14 Then
            Return False
        End If
        For i = 0 To i < str.Length Step +1
            '除前两位之外
            If i <> 0 And i <> 1 Then
                If str.Substring(i) > "9" Or str.Substring(i) < "0" Then
                    Return False
                End If
                '判断前两位
            ElseIf str.Substring(i) <> "Y" And str.Substring(i) > "G" Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        '显示数据表的信息
        If ComboBox1.SelectedItem = "团体" Then
            Dim SQL3 As String
            SQL3 = "select r_no as 房间号,main_room as 主客房间,price as 房间单价,days as 消费天数 from team where main_room='" + ComboBox2.SelectedItem.ToString() + "'"
            bindGridView1(SQL3)
        ElseIf ComboBox1.SelectedItem = "散客" Then
            Dim SQL3 As String
            SQL3 = "select r_no as 房间号,main_room as 主客房间,price as 单价,discount as 折扣,realprice as 折扣价,days as 消费天数 from personal where main_room='" + ComboBox2.SelectedItem.ToString() + "'"
            bindGridView1(SQL3)
        End If
        '显示宾客姓名
        If ComboBox1.SelectedItem = "团体" Then
            Dim SQL2 As String
            SQL2 = "select main_name from team where r_no='" + ComboBox2.SelectedItem.ToString() + "'"
            Dim main_name As String
            Dim cmd2 As New SqlCommand(SQL2, conn)
            conn.Open()
            main_name = cmd2.ExecuteScalar.ToString()
            conn.Close()
            lb_guest_name.Text = main_name
        ElseIf ComboBox1.SelectedItem = "散客" Then
            Dim SQL2 As String
            SQL2 = "select main_name from personal where r_no='" + ComboBox2.SelectedItem.ToString() + "'"
            Dim main_name As String
            Dim cmd2 As New SqlCommand(SQL2, conn)
            conn.Open()
            main_name = cmd2.ExecuteScalar.ToString()
            conn.Close()
            lb_guest_name.Text = main_name
        End If
        '金额处的所有显示
        Dim i As Integer
        Dim roomid As String
        Dim price As Double
        Dim consume_team As Double
        Dim consume_personal As Double
        Dim realprice As Double
        If ComboBox1.SelectedItem = "团体" Then
            Dim SQL4 As String
            For i = DataGridView1.RowCount To 1 Step -1
                roomid = DataGridView1.Rows(i - 1).Cells(0).Value
                SQL4 = "select price from team where r_no='" + roomid + "'"
                Dim cmd4 As New SqlCommand(SQL4, conn)
                conn.Open()
                price = cmd4.ExecuteScalar.ToString()
                conn.Close()
                consume_team = consume_team + price
            Next
            '消费金额
            lb_consume.Text = consume_team
            '应收金额
            lb_shouldpay.Text = consume_team
            '预付押金
            Dim premoney As Integer
            Dim pre_money As Integer
            For i = DataGridView1.RowCount To 1 Step -1
                roomid = DataGridView1.Rows(i - 1).Cells(0).Value
                SQL4 = "select premoney from team where r_no='" + roomid + "'"
                Dim cmd4 As New SqlCommand(SQL4, conn)
                conn.Open()
                premoney = cmd4.ExecuteScalar.ToString()
                conn.Close()
            Next
            pre_money = premoney
            lb_yajin.Text = pre_money
            '优惠金额
            lb_discountmoney.Text = "0"
        ElseIf ComboBox1.SelectedItem = "散客" Then
            Dim SQL4 As String
            For i = DataGridView1.RowCount To 1 Step -1
                roomid = DataGridView1.Rows(i - 1).Cells(0).Value
                SQL4 = "select price from personal where r_no='" + roomid + "'"
                Dim cmd As New SqlCommand(SQL4, conn)
                conn.Open()
                price = cmd.ExecuteScalar.ToString()
                conn.Close()
                consume_personal = consume_personal + price
            Next
            '消费金额
            lb_consume.Text = consume_personal
            '应收金额
            For i = DataGridView1.RowCount To 1 Step -1
                roomid = DataGridView1.Rows(i - 1).Cells(0).Value
                SQL4 = "select realprice from personal where r_no='" + roomid + "'"
                Dim cmd As New SqlCommand(SQL4, conn)
                conn.Open()
                price = cmd.ExecuteScalar.ToString()
                conn.Close()
                realprice = realprice + price
            Next
            lb_shouldpay.Text = realprice
            '预付押金
            Dim premoney As Integer
            Dim pre_money As Integer
            SQL4 = "select premoney from personal where r_no='" + ComboBox2.SelectedItem.ToString() + "'"
                Dim cmd4 As New SqlCommand(SQL4, conn)
                conn.Open()
                premoney = cmd4.ExecuteScalar.ToString()
                conn.Close()
            pre_money = premoney
            lb_yajin.Text = pre_money
            '优惠金额
            lb_discountmoney.Text = consume_personal - realprice
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim guest As String
        guest = ComboBox1.SelectedItem
        ComboBox2.Text = ""
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim i As Integer
        Dim SQL1 As String
        Dim SQL2 As String
        If guest = "团体" Then
            '在添加进去之前需要清空之前添加进去的数据
            ComboBox2.Items.Clear()
            '下拉框中显示的是主客所在的房间，这样才能实现一次性结账
            SQL1 = "select main_room from team "
            Dim cmd1 As New SqlCommand(SQL1, conn)
            conn.Open()
            '数据适配器
            Dim adp As New SqlDataAdapter(SQL1, conn)
            Dim ds As New DataSet
            adp.Fill(ds, "team")
            '用于从数据库提取数据放入comboBox里
            For i = ds.Tables(0).Rows.Count To 1 Step -1
                '去掉下拉框中的重复项
                If ComboBox2.Items.Contains(ds.Tables(0).Rows(i - 1).Item(0).ToString()) = False Then
                    ComboBox2.Items.Add(ds.Tables(0).Rows(i - 1).Item(0).ToString())
                End If
            Next
        ElseIf guest = "散客" Then
            '在添加进去之前需要清空之前添加进去的数据
            ComboBox2.Items.Clear()
            '下拉框中显示的是主客所在的房间，这样才能实现一次性结账
            SQL2 = "select main_room from personal "
            Dim cmd2 As New SqlCommand(SQL2, conn)
            conn.Open()
            '数据适配器
            Dim adp As New SqlDataAdapter(SQL2, conn)
            Dim ds As New DataSet
            adp.Fill(ds, "personal")
            '用于从数据库提取数据放入comboBox里
            For i = ds.Tables(0).Rows.Count To 1 Step -1
                '去掉下拉框中的重复项
                If ComboBox2.Items.Contains(ds.Tables(0).Rows(i - 1).Item(0).ToString()) = False Then
                    ComboBox2.Items.Add(ds.Tables(0).Rows(i - 1).Item(0).ToString())
                End If
            Next
        End If

    End Sub

    Private Sub btn_pay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pay.Click
        Dim roomid As String
        Dim flag As Boolean
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        '判断信息是否有未填
        If txt_danhao.Text <> "" Or txt_guestpay.Text <> "" Or txt_realmoney.Text <> "" Then
            '判断单号形式是否合法
            Dim str As String
            str = txt_danhao.Text
            If isValidID(str) = True Then
                '判断单号输入的是否重复
                Dim SQL10 As String
                SQL10 = "select checkout_danhao from checkout where checkout_danhao='" + str + "'"
                Dim cmd10 As New SqlCommand(SQL10, conn)
                conn.Open()
                '数据适配器
                Dim adp As New SqlDataAdapter(SQL10, conn)
                Dim ds As New DataSet
                adp.Fill(ds, "checkout")
                If ds.Tables(0).Rows.Count = 0 Then
                    conn.Close()
                    '判断实收金额是否有误
                    If txt_realmoney.Text >= lb_shouldpay.Text Then
                        '判断宾客所付金额的正确性
                        If txt_guestpay.Text >= lb_shouldpay.Text Then
                            '计算找零
                            lb_change.Text = txt_guestpay.Text - txt_realmoney.Text
                            '向数据库的checkout表中插入数据
                            Dim SQL As String
                            SQL = "insert into checkout(checkout_danhao,c_name,c_room_no,realpay,c_pay,consume,discount_price,other,checkout_time) values('" + txt_danhao.Text + "','" + lb_guest_name.Text + "','" + ComboBox2.SelectedItem + "','" + txt_realmoney.Text + "','" + txt_guestpay.Text + "','" + lb_consume.Text + "','" + lb_discountmoney.Text + "','" + txt_other.Text + "','" + Now() + "')"
                            Dim cmd As New SqlCommand(SQL, conn)
                            conn.Open()
                            cmd.ExecuteNonQuery()
                            conn.Close()
                            '修改房间状态为——可供
                            Dim SQL1 As String
                            For i = DataGridView1.RowCount To 1 Step -1
                                roomid = DataGridView1.Rows(i - 1).Cells(0).Value
                                SQL1 = "update roominfo set state='可供' where id='" + roomid + "'"
                                Dim cmd1 As New SqlCommand(SQL1, conn)
                                conn.Open()
                                cmd1.ExecuteNonQuery()
                                conn.Close()
                            Next
                            '删除宾客表中的数据并且更新DataGridView1里的数据
                            Dim guest As String
                            guest = ComboBox1.SelectedItem
                            If guest = "团体" Then
                                Dim SQL2 As String
                                For i = DataGridView1.RowCount To 1 Step -1
                                    roomid = DataGridView1.Rows(i - 1).Cells(0).Value
                                    SQL2 = "delete from team where r_no='" + roomid + "'"
                                    Dim cmd2 As New SqlCommand(SQL2, conn)
                                    conn.Open()
                                    cmd2.ExecuteNonQuery()
                                    conn.Close()
                                Next
                                'DataGridView1里的数据更新
                                Dim SQL3 As String
                                SQL3 = "select r_no as 房间号,main_room as 主客房间,price as 房间单价,days as 消费天数 from team where main_room='" + ComboBox2.SelectedItem.ToString() + "'"
                                bindGridView1(SQL3)
                            ElseIf guest = "散客" Then
                                Dim SQL2 As String
                                For i = DataGridView1.RowCount To 1 Step -1
                                    roomid = DataGridView1.Rows(i - 1).Cells(0).Value
                                    SQL2 = "delete from personal where r_no='" + roomid + "'"
                                    Dim cmd2 As New SqlCommand(SQL2, conn)
                                    conn.Open()
                                    cmd2.ExecuteNonQuery()
                                    conn.Close()
                                Next
                                'DataGridView1里的数据更新
                                Dim SQL3 As String
                                SQL3 = "select r_no as 房间号,main_room as 主客房间,price as 单价,discount as 折扣,realprice as 折扣价,days as 消费天数 from personal where main_room='" + ComboBox2.SelectedItem.ToString() + "'"
                                bindGridView1(SQL3)
                            End If
                        Else
                            MessageBox.Show("宾客所付金额低于应付金额！")
                        End If
                    Else
                        MessageBox.Show("实收金额不能低于应收金额！")
                    End If
                Else
                    MessageBox.Show("输入的单号已存在！请重新输入！")
                End If
            Else
                MessageBox.Show("单号输入错误！")
            End If
            Else
                MessageBox.Show("所填信息不得为空！")
            End If
    End Sub

    Private Sub btn_quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_quit.Click
        Me.Close()
    End Sub

    Private Sub Guest_Pay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SQL As String
        SQL = "select checkout_danhao from checkout"
        bindGridView2(SQL)
    End Sub
End Class