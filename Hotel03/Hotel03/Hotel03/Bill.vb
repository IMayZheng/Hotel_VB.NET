Imports System.Data.SqlClient

Public Class Bill
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
    Private Sub Bill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SQL As String
        SQL = "select checkout_danhao as 结账单号,c_name as 宾客姓名,c_room_no as 结账房间,realpay as 实际付款,c_pay as 宾客付款,consume as 消费金额,discount_price as 优惠金额,other as 备注信息,checkout_time as 结账时间 from checkout"
        bindGridView1(SQL)
        Dim date_time As String
        'Cell(8).Value表示取第8列的值
        date_time = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(8).Value
        lb_paytime.Text = date_time
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL1 As String
        SQL1 = "select sum(consume) from checkout"
        Dim money As String
        Dim cmd1 As New SqlCommand(SQL1, conn)
        conn.Open()
        '获取查询结果--第一行第一列
        money = cmd1.ExecuteScalar.ToString()
        conn.Close()
        Label3.Text = money
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim date_time As String
        'Cell(8).Value表示取第8列的值
        date_time = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(8).Value
        lb_paytime.Text = date_time
    End Sub

    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        If txt_searchconditions.Text = "" Then
            Dim SQL As String
            SQL = "select checkout_danhao as 结账单号,c_name as 宾客姓名,c_room_no as 结账房间,realpay as 实际付款,c_pay as 宾客付款,consume as 消费金额,discount_price as 优惠金额,other as 备注信息,checkout_time as 结账时间 from checkout"
            bindGridView1(SQL)
        Else
            Dim SQL As String
            SQL = "select checkout_danhao as 结账单号,c_name as 宾客姓名,c_room_no as 结账房间,realpay as 实际付款,c_pay as 宾客付款,consume as 消费金额,discount_price as 优惠金额,other as 备注信息,checkout_time as 结账时间 from checkout where c_name='" + txt_searchconditions.Text + "' or c_room_no='" + txt_searchconditions.Text + "' or checkout_danhao='" + txt_searchconditions.Text + "'"
            bindGridView1(SQL)
            Dim date_time As String
            'Cell(8).Value表示取第8列的值
            date_time = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(8).Value
            lb_paytime.Text = date_time
        End If
    End Sub
End Class