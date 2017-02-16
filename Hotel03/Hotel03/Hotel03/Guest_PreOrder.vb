Imports System.Data.SqlClient

Public Class Guest_PreOrder
    Public c_name1 As String

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
        DataGridView_guest_preorder_info.DataSource = dt
    End Sub
    Private Sub bt_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_add.Click
        Dim room_reservation As New Room_Reservation
        room_reservation.Show()
    End Sub

    Private Sub Guest_PreOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SQL As String
        SQL = "select c_name as 宾客姓名,c_tel as 联系方式,r_type_id as 房间类型,r_no as 房间编号,pa_time as 预抵时间,keep_time as 保留时间,eng_time as 预定时间,other1 as 备注 from engage"
        bindGridView1(SQL)
    End Sub

    Private Sub bt_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_update.Click
        Dim prereservation As New PreReservation_update
        c_name1 = Me.DataGridView_guest_preorder_info.Rows(DataGridView_guest_preorder_info.CurrentCell.RowIndex).Cells(0).Value
        prereservation.c_name2 = c_name1
        prereservation.Show()
    End Sub
End Class