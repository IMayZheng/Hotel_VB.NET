Imports System.Data.SqlClient

Public Class Mainboard
    Public style As Integer
    Private Function Room_state(ByVal lb As String)
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL As String
        SQL = "select state from roominfo where id='" + lb + "'"
        Dim state As String
        Dim cmd As New SqlCommand(SQL, conn)
        conn.Open()
        '获取查询结果--第一行第一列
        state = cmd.ExecuteScalar.ToString()
        conn.Close()
        Return state
    End Function

    Private Sub Image_show(ByVal state As String, ByVal button As Button, ByVal label As String)
        state = Room_state(label)
        If state = "可供" Then
            button.Image = System.Drawing.Image.FromFile("E:\java\05\05 SQLServer\JavaPrj_5\pic\room\prov.gif")
        ElseIf state = "占用" Then
            button.Image = System.Drawing.Image.FromFile("E:\java\05\05 SQLServer\JavaPrj_5\pic\room\rese.gif")
        ElseIf state = "停用" Then
            button.Image = System.Drawing.Image.FromFile("E:\java\05\05 SQLServer\JavaPrj_5\pic\room\stop.gif")
        ElseIf state = "预订" Then
            button.Image = System.Drawing.Image.FromFile("E:\java\05\05 SQLServer\JavaPrj_5\pic\room\pree.gif")
        End If
    End Sub

    Private Sub Mainboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        '显示房间总数
        Dim SQL As String
        SQL = "select count(id) from roominfo"
        Dim room_count As String
        Dim cmd As New SqlCommand(SQL, conn)
        conn.Open()
        '获取查询结果--第一行第一列
        room_count = cmd.ExecuteScalar.ToString()
        conn.Close()
        lb_main_left_bottom_count.Text = room_count
        '显示当前占用的数目
        Dim SQL1 As String
        SQL1 = "select count(id) from roominfo where state='占用'"
        Dim room_ocupy As String
        Dim cmd1 As New SqlCommand(SQL1, conn)
        conn.Open()
        '获取查询结果--第一行第一列
        room_ocupy = cmd1.ExecuteScalar.ToString()
        conn.Close()
        lb_main_left_bottom_occupy.Text = room_ocupy
        '显示当前可供的数目
        Dim SQL2 As String
        SQL2 = "select count(id) from roominfo where state='可供'"
        Dim room_canuse As String
        Dim cmd2 As New SqlCommand(SQL2, conn)
        conn.Open()
        '获取查询结果--第一行第一列
        room_canuse = cmd2.ExecuteScalar.ToString()
        conn.Close()
        lb_main_left_bottom_canuse.Text = room_canuse
        '显示预订的数目
        Dim SQL3 As String
        SQL3 = "select count(id) from roominfo where state='预订'"
        Dim room_preorder As String
        Dim cmd3 As New SqlCommand(SQL3, conn)
        conn.Open()
        '获取查询结果--第一行第一列
        room_preorder = cmd3.ExecuteScalar.ToString()
        conn.Close()
        lb_main_left_bottom_preorder.Text = room_preorder
        '显示已停用的数目
        Dim SQL4 As String
        SQL4 = "select count(id) from roominfo where state='预订'"
        Dim room_stop As String
        Dim cmd4 As New SqlCommand(SQL4, conn)
        conn.Open()
        '获取查询结果--第一行第一列
        room_stop = cmd4.ExecuteScalar.ToString()
        conn.Close()
        lb_main_left_bottom_stop.Text = room_stop
        '显示时间
        'Label_main_left_top_time.Text = Now().ToString()
        Timer1.Interval = 1000
        Timer1.Enabled = True
        Label_main_left_time.Text = Now().ToString()
        '显示图片
        Dim state1 As String
        state1 = Room_state(Label6.Text)
        Image_show(state1, Button1, Label6.Text)

        Dim state2 As String
        state2 = Room_state(Label7.Text)
        Image_show(state2, Button2, Label7.Text)

        Dim state3 As String
        state3 = Room_state(Label8.Text)
        Image_show(state3, Button3, Label8.Text)

        Dim state4 As String
        state4 = Room_state(Label9.Text)
        Image_show(state4, Button4, Label9.Text)


        Dim state5 As String
        state5 = Room_state(Label10.Text)
        Image_show(state5, Button5, Label10.Text)

        Dim state6 As String
        state6 = Room_state(Label11.Text)
        Image_show(state6, Button6, Label11.Text)


        Dim state7 As String
        state7 = Room_state(Label12.Text)
        Image_show(state7, Button7, Label12.Text)

        Dim state8 As String
        state8 = Room_state(Label13.Text)
        Image_show(state8, Button8, Label13.Text)

        Dim state9 As String
        state9 = Room_state(Label14.Text)
        Image_show(state9, Button9, Label14.Text)

        Dim state10 As String
        state10 = Room_state(Label15.Text)
        Image_show(state10, Button10, Label15.Text)


        Dim state11 As String
        state11 = Room_state(Label16.Text)
        Image_show(state11, Button11, Label16.Text)

        Dim state12 As String
        state12 = Room_state(Label17.Text)
        Image_show(state12, Button12, Label17.Text)

        Dim state13 As String
        state13 = Room_state(Label18.Text)
        Image_show(state13, Button13, Label18.Text)

        Dim state14 As String
        state14 = Room_state(Label19.Text)
        Image_show(state14, Button14, Label19.Text)

        Dim state15 As String
        state15 = Room_state(Label20.Text)
        Image_show(state15, Button15, Label20.Text)


        Dim state16 As String
        state16 = Room_state(Label35.Text)
        Image_show(state16, Button30, Label35.Text)

        Dim state17 As String
        state17 = Room_state(Label34.Text)
        Image_show(state17, Button29, Label34.Text)

        Dim state18 As String
        state18 = Room_state(Label33.Text)
        Image_show(state18, Button28, Label33.Text)

        Dim state19 As String
        state19 = Room_state(Label32.Text)
        Image_show(state19, Button27, Label32.Text)

        Dim state20 As String
        state20 = Room_state(Label31.Text)
        Image_show(state20, Button26, Label31.Text)

        Dim state21 As String
        state21 = Room_state(Label30.Text)
        Image_show(state21, Button25, Label30.Text)

        Dim state22 As String
        state22 = Room_state(Label29.Text)
        Image_show(state22, Button24, Label29.Text)

        Dim state23 As String
        state23 = Room_state(Label28.Text)
        Image_show(state23, Button23, Label28.Text)

        Dim state24 As String
        state24 = Room_state(Label27.Text)
        Image_show(state24, Button22, Label27.Text)

        Dim state25 As String
        state25 = Room_state(Label26.Text)
        Image_show(state25, Button21, Label26.Text)

        Dim state26 As String
        state26 = Room_state(Label25.Text)
        Image_show(state26, Button20, Label25.Text)

        Dim state27 As String
        state27 = Room_state(Label24.Text)
        Image_show(state27, Button19, Label24.Text)

        Dim state28 As String
        state28 = Room_state(Label23.Text)
        Image_show(state28, Button18, Label23.Text)

        Dim state29 As String
        state29 = Room_state(Label22.Text)
        Image_show(state29, Button17, Label22.Text)

        Dim state30 As String
        state30 = Room_state(Label21.Text)
        Image_show(state30, Button16, Label21.Text)




        Dim state31 As String
        state31 = Room_state(Label50.Text)
        Image_show(state31, Button45, Label50.Text)


        Dim state32 As String
        state32 = Room_state(Label49.Text)
        Image_show(state32, Button44, Label49.Text)

        Dim state33 As String
        state33 = Room_state(Label48.Text)
        Image_show(state33, Button43, Label48.Text)


        Dim state34 As String
        state34 = Room_state(Label47.Text)
        Image_show(state34, Button42, Label47.Text)


        Dim state35 As String
        state35 = Room_state(Label46.Text)
        Image_show(state35, Button41, Label46.Text)


        Dim state36 As String
        state36 = Room_state(Label45.Text)
        Image_show(state36, Button40, Label45.Text)

        Dim state37 As String
        state37 = Room_state(Label44.Text)
        Image_show(state37, Button39, Label44.Text)


        Dim state38 As String
        state38 = Room_state(Label43.Text)
        Image_show(state38, Button38, Label43.Text)



        Dim state39 As String
        state39 = Room_state(Label42.Text)
        Image_show(state39, Button37, Label42.Text)


        Dim state40 As String
        state40 = Room_state(Label41.Text)
        Image_show(state40, Button36, Label41.Text)





        Dim state41 As String
        state41 = Room_state(Label65.Text)
        Image_show(state41, Button60, Label65.Text)


        Dim state42 As String
        state42 = Room_state(Label64.Text)
        Image_show(state42, Button59, Label64.Text)

        Dim state43 As String
        state43 = Room_state(Label63.Text)
        Image_show(state43, Button58, Label63.Text)


        Dim state44 As String
        state44 = Room_state(Label62.Text)
        Image_show(state44, Button57, Label62.Text)

        Dim state45 As String
        state45 = Room_state(Label61.Text)
        Image_show(state45, Button56, Label61.Text)

        Dim state46 As String
        state46 = Room_state(Label60.Text)
        Image_show(state46, Button55, Label60.Text)


        Dim state47 As String
        state47 = Room_state(Label59.Text)
        Image_show(state47, Button54, Label59.Text)


        Dim state48 As String
        state48 = Room_state(Label58.Text)
        Image_show(state48, Button53, Label58.Text)



        Dim state49 As String
        state49 = Room_state(Label57.Text)
        Image_show(state49, Button52, Label57.Text)


        Dim state50 As String
        state50 = Room_state(Label56.Text)
        Image_show(state50, Button51, Label56.Text)





        Dim state51 As String
        state51 = Room_state(Label80.Text)
        Image_show(state51, Button75, Label80.Text)


        Dim state52 As String
        state52 = Room_state(Label79.Text)
        Image_show(state52, Button74, Label79.Text)

        Dim state53 As String
        state53 = Room_state(Label78.Text)
        Image_show(state53, Button73, Label78.Text)

        Dim state54 As String
        state54 = Room_state(Label77.Text)
        Image_show(state54, Button72, Label77.Text)



        Dim state55 As String
        state55 = Room_state(Label76.Text)
        Image_show(state55, Button71, Label76.Text)





        Dim state56 As String
        state56 = Room_state(Label95.Text)
        Image_show(state56, Button90, Label95.Text)


        Dim state57 As String
        state57 = Room_state(Label94.Text)
        Image_show(state57, Button89, Label94.Text)


        Dim state58 As String
        state58 = Room_state(Label93.Text)
        Image_show(state58, Button88, Label93.Text)


        Dim state59 As String
        state59 = Room_state(Label92.Text)
        Image_show(state59, Button87, Label92.Text)


        Dim state60 As String
        state60 = Room_state(Label91.Text)
        Image_show(state60, Button86, Label91.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Text = Label6.Text
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL0 As String
        SQL0 = "select state from roominfo where id='" + Label6.Text + "'"
        Dim state As String
        Dim cmd0 As New SqlCommand(SQL0, conn)
        conn.Open()
        state = cmd0.ExecuteScalar.ToString()
        conn.Close()
        Dim SQL As String
        SQL = "select other1 from roominfo where id='" + Label6.Text + "'"
        Dim other1 As String
        Dim cmd As New SqlCommand(SQL, conn)
        conn.Open()
        other1 = cmd.ExecuteScalar.ToString()
        conn.Close()
        If state = "占用" Then
            If other1 = "团体" Then
                Dim SQL1 As String
                SQL1 = "select main_name from team where r_no='" + Label6.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from team where r_no='" + Label6.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label6.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label6.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from team where r_no='" + Label6.Text + "'"
                Dim SQL6 As String
                SQL6 = "select price from team where r_no='" + Label6.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            ElseIf other1 = "散客" Then
                Dim SQL1 As String
                SQL1 = "select main_name from personal where r_no='" + Label6.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from personal where r_no='" + Label6.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label6.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label6.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from personal where r_no='" + Label6.Text + "'"
                Dim SQL6 As String
                SQL6 = "select realprice from personal where r_no='" + Label6.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            End If
        ElseIf state = "预订" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被预订中……")
        ElseIf state = "停用" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被停用中……")
        End If
    End Sub

    Private Sub Btn_main_02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_main_02.Click
        Dim team_checkin As New Team_Checkin
        team_checkin.Show()
    End Sub

    Private Sub Btn_main_07_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_main_07.Click
        Me.Close()
    End Sub

    Private Sub Btn_main_01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_main_01.Click
        Dim personal_checkin As New Personal_Checkin
        personal_checkin.Show()
    End Sub

    Private Sub Btn_main_03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_main_03.Click
        Dim guest_pay As New Guest_Pay
        guest_pay.Show()
    End Sub

    Private Sub 收银结算ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 收银结算ToolStripMenuItem.Click
        Dim guest_pay As New Guest_Pay
        guest_pay.Show()
    End Sub

    Private Sub Btn_main_06_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_main_06.Click
        Dim guest_management As New Guest_Management
        guest_management.Show()
    End Sub

    Private Sub Btn_main_05_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_main_05.Click
        Dim bill As New Bill
        bill.Show()
    End Sub

    Private Sub Button_main_04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_main_04.Click
        Dim room_reservation As New Room_Reservation
        room_reservation.Show()
    End Sub

    Private Sub 客户预订ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 客户预订ToolStripMenuItem.Click
        Dim guest_preorder As New Guest_PreOrder
        guest_preorder.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label1.Text = Label7.Text
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL0 As String
        SQL0 = "select state from roominfo where id='" + Label7.Text + "'"
        Dim state As String
        Dim cmd0 As New SqlCommand(SQL0, conn)
        conn.Open()
        state = cmd0.ExecuteScalar.ToString()
        conn.Close()
        If state = "占用" Then
            Dim SQL As String
            SQL = "select other1 from roominfo where id='" + Label7.Text + "'"
            Dim other1 As String
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            other1 = cmd.ExecuteScalar.ToString()
            conn.Close()
            If other1 = "团体" Then
                Dim SQL1 As String
                SQL1 = "select main_name from team where r_no='" + Label7.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from team where r_no='" + Label7.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label7.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label7.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from team where r_no='" + Label7.Text + "'"
                Dim SQL6 As String
                SQL6 = "select price from team where r_no='" + Label7.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            ElseIf other1 = "散客" Then
                Dim SQL1 As String
                SQL1 = "select main_name from personal where r_no='" + Label7.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from personal where r_no='" + Label7.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label7.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label7.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from personal where r_no='" + Label7.Text + "'"
                Dim SQL6 As String
                SQL6 = "select realprice from personal where r_no='" + Label7.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            End If
        ElseIf state = "预订" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被预订中……")
        ElseIf state = "停用" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被停用中……")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label1.Text = Label8.Text
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL0 As String
        SQL0 = "select state from roominfo where id='" + Label8.Text + "'"
        Dim state As String
        Dim cmd0 As New SqlCommand(SQL0, conn)
        conn.Open()
        state = cmd0.ExecuteScalar.ToString()
        conn.Close()
        If state = "占用" Then
            Dim SQL As String
            SQL = "select other1 from roominfo where id='" + Label8.Text + "'"
            Dim other1 As String
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            other1 = cmd.ExecuteScalar.ToString()
            conn.Close()
            If other1 = "团体" Then
                Dim SQL1 As String
                SQL1 = "select main_name from team where r_no='" + Label8.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from team where r_no='" + Label8.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label8.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label8.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from team where r_no='" + Label8.Text + "'"
                Dim SQL6 As String
                SQL6 = "select price from team where r_no='" + Label8.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            ElseIf other1 = "散客" Then
                Dim SQL1 As String
                SQL1 = "select main_name from personal where r_no='" + Label8.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from personal where r_no='" + Label8.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label8.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label8.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from personal where r_no='" + Label8.Text + "'"
                Dim SQL6 As String
                SQL6 = "select realprice from personal where r_no='" + Label8.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            End If
        ElseIf state = "预订" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被预订中……")
        ElseIf state = "停用" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被停用中……")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Label1.Text = Label9.Text
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL0 As String
        SQL0 = "select state from roominfo where id='" + Label9.Text + "'"
        Dim state As String
        Dim cmd0 As New SqlCommand(SQL0, conn)
        conn.Open()
        state = cmd0.ExecuteScalar.ToString()
        conn.Close()
        If state = "占用" Then
            Dim SQL As String
            SQL = "select other1 from roominfo where id='" + Label9.Text + "'"
            Dim other1 As String
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            other1 = cmd.ExecuteScalar.ToString()
            conn.Close()
            If other1 = "团体" Then
                Dim SQL1 As String
                SQL1 = "select main_name from team where r_no='" + Label9.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from team where r_no='" + Label9.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label9.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label9.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from team where r_no='" + Label9.Text + "'"
                Dim SQL6 As String
                SQL6 = "select price from team where r_no='" + Label9.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            ElseIf other1 = "散客" Then
                Dim SQL1 As String
                SQL1 = "select main_name from personal where r_no='" + Label9.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from personal where r_no='" + Label9.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label9.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label9.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from personal where r_no='" + Label9.Text + "'"
                Dim SQL6 As String
                SQL6 = "select realprice from personal where r_no='" + Label9.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            End If
        ElseIf state = "预订" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被预订中……")
        ElseIf state = "停用" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被停用中……")
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Label1.Text = Label10.Text
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL0 As String
        SQL0 = "select state from roominfo where id='" + Label10.Text + "'"
        Dim state As String
        Dim cmd0 As New SqlCommand(SQL0, conn)
        conn.Open()
        state = cmd0.ExecuteScalar.ToString()
        conn.Close()
        If state = "占用" Then
            Dim SQL As String
            SQL = "select other1 from roominfo where id='" + Label10.Text + "'"
            Dim other1 As String
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            other1 = cmd.ExecuteScalar.ToString()
            conn.Close()
            If other1 = "团体" Then
                Dim SQL1 As String
                SQL1 = "select main_name from team where r_no='" + Label10.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from team where r_no='" + Label10.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label10.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label10.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from team where r_no='" + Label10.Text + "'"
                Dim SQL6 As String
                SQL6 = "select price from team where r_no='" + Label10.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            ElseIf other1 = "散客" Then
                Dim SQL1 As String
                SQL1 = "select main_name from personal where r_no='" + Label10.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from personal where r_no='" + Label10.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label10.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label10.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from personal where r_no='" + Label10.Text + "'"
                Dim SQL6 As String
                SQL6 = "select realprice from personal where r_no='" + Label10.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            End If
        ElseIf state = "预订" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被预订中……")
        ElseIf state = "停用" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被停用中……")
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Label1.Text = Label11.Text
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL0 As String
        SQL0 = "select state from roominfo where id='" + Label11.Text + "'"
        Dim state As String
        Dim cmd0 As New SqlCommand(SQL0, conn)
        conn.Open()
        state = cmd0.ExecuteScalar.ToString()
        conn.Close()
        If state = "占用" Then
            Dim SQL As String
            SQL = "select other1 from roominfo where id='" + Label11.Text + "'"
            Dim other1 As String
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            other1 = cmd.ExecuteScalar.ToString()
            conn.Close()
            If other1 = "团体" Then
                Dim SQL1 As String
                SQL1 = "select main_name from team where r_no='" + Label11.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from team where r_no='" + Label11.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label11.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label11.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from team where r_no='" + Label11.Text + "'"
                Dim SQL6 As String
                SQL6 = "select price from team where r_no='" + Label11.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            ElseIf other1 = "散客" Then
                Dim SQL1 As String
                SQL1 = "select main_name from personal where r_no='" + Label11.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from personal where r_no='" + Label11.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label11.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label11.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from personal where r_no='" + Label11.Text + "'"
                Dim SQL6 As String
                SQL6 = "select realprice from personal where r_no='" + Label11.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            End If
        ElseIf state = "预订" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被预订中……")
        ElseIf state = "停用" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被停用中……")
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Label1.Text = Label12.Text
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL0 As String
        SQL0 = "select state from roominfo where id='" + Label12.Text + "'"
        Dim state As String
        Dim cmd0 As New SqlCommand(SQL0, conn)
        conn.Open()
        state = cmd0.ExecuteScalar.ToString()
        conn.Close()
        If state = "占用" Then
            Dim SQL As String
            SQL = "select other1 from roominfo where id='" + Label12.Text + "'"
            Dim other1 As String
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            other1 = cmd.ExecuteScalar.ToString()
            conn.Close()
            If other1 = "团体" Then
                Dim SQL1 As String
                SQL1 = "select main_name from team where r_no='" + Label12.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from team where r_no='" + Label12.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label12.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label12.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from team where r_no='" + Label12.Text + "'"
                Dim SQL6 As String
                SQL6 = "select price from team where r_no='" + Label12.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            ElseIf other1 = "散客" Then
                Dim SQL1 As String
                SQL1 = "select main_name from personal where r_no='" + Label12.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from personal where r_no='" + Label12.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label12.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label12.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from personal where r_no='" + Label12.Text + "'"
                Dim SQL6 As String
                SQL6 = "select realprice from personal where r_no='" + Label12.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            End If
        ElseIf state = "预订" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被预订中……")
        ElseIf state = "停用" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被停用中……")
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Label1.Text = Label13.Text
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL0 As String
        SQL0 = "select state from roominfo where id='" + Label13.Text + "'"
        Dim state As String
        Dim cmd0 As New SqlCommand(SQL0, conn)
        conn.Open()
        state = cmd0.ExecuteScalar.ToString()
        conn.Close()
        If state = "占用" Then
            Dim SQL As String
            SQL = "select other1 from roominfo where id='" + Label13.Text + "'"
            Dim other1 As String
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            other1 = cmd.ExecuteScalar.ToString()
            conn.Close()
            If other1 = "团体" Then
                Dim SQL1 As String
                SQL1 = "select main_name from team where r_no='" + Label13.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from team where r_no='" + Label13.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label13.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label13.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from team where r_no='" + Label13.Text + "'"
                Dim SQL6 As String
                SQL6 = "select price from team where r_no='" + Label13.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            ElseIf other1 = "散客" Then
                Dim SQL1 As String
                SQL1 = "select main_name from personal where r_no='" + Label13.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from personal where r_no='" + Label13.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label13.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label13.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from personal where r_no='" + Label13.Text + "'"
                Dim SQL6 As String
                SQL6 = "select realprice from personal where r_no='" + Label13.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            End If
        ElseIf state = "预订" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被预订中……")
        ElseIf state = "停用" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被停用中……")
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Label1.Text = Label14.Text
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL0 As String
        SQL0 = "select state from roominfo where id='" + Label14.Text + "'"
        Dim state As String
        Dim cmd0 As New SqlCommand(SQL0, conn)
        conn.Open()
        state = cmd0.ExecuteScalar.ToString()
        conn.Close()
        If state = "占用" Then
            Dim SQL As String
            SQL = "select other1 from roominfo where id='" + Label14.Text + "'"
            Dim other1 As String
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            other1 = cmd.ExecuteScalar.ToString()
            conn.Close()
            If other1 = "团体" Then
                Dim SQL1 As String
                SQL1 = "select main_name from team where r_no='" + Label14.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from team where r_no='" + Label14.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label14.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label14.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from team where r_no='" + Label14.Text + "'"
                Dim SQL6 As String
                SQL6 = "select price from team where r_no='" + Label14.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            ElseIf other1 = "散客" Then
                Dim SQL1 As String
                SQL1 = "select main_name from personal where r_no='" + Label14.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from personal where r_no='" + Label14.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label14.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label14.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from personal where r_no='" + Label14.Text + "'"
                Dim SQL6 As String
                SQL6 = "select realprice from personal where r_no='" + Label14.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            End If
        ElseIf state = "预订" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被预订中……")
        ElseIf state = "停用" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被停用中……")
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Label1.Text = Label15.Text
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL0 As String
        SQL0 = "select state from roominfo where id='" + Label15.Text + "'"
        Dim state As String
        Dim cmd0 As New SqlCommand(SQL0, conn)
        conn.Open()
        state = cmd0.ExecuteScalar.ToString()
        conn.Close()
        If state = "占用" Then
            Dim SQL As String
            SQL = "select other1 from roominfo where id='" + Label15.Text + "'"
            Dim other1 As String
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            other1 = cmd.ExecuteScalar.ToString()
            conn.Close()
            If other1 = "团体" Then
                Dim SQL1 As String
                SQL1 = "select main_name from team where r_no='" + Label15.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from team where r_no='" + Label15.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label15.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label15.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from team where r_no='" + Label15.Text + "'"
                Dim SQL6 As String
                SQL6 = "select price from team where r_no='" + Label15.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            ElseIf other1 = "散客" Then
                Dim SQL1 As String
                SQL1 = "select main_name from personal where r_no='" + Label15.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from personal where r_no='" + Label15.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label15.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label15.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from personal where r_no='" + Label15.Text + "'"
                Dim SQL6 As String
                SQL6 = "select realprice from personal where r_no='" + Label15.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            End If
        ElseIf state = "预订" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被预订中……")
        ElseIf state = "停用" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被停用中……")
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Label1.Text = Label16.Text
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL0 As String
        SQL0 = "select state from roominfo where id='" + Label16.Text + "'"
        Dim state As String
        Dim cmd0 As New SqlCommand(SQL0, conn)
        conn.Open()
        state = cmd0.ExecuteScalar.ToString()
        conn.Close()
        If state = "占用" Then
            Dim SQL As String
            SQL = "select other1 from roominfo where id='" + Label16.Text + "'"
            Dim other1 As String
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            other1 = cmd.ExecuteScalar.ToString()
            conn.Close()
            If other1 = "团体" Then
                Dim SQL1 As String
                SQL1 = "select main_name from team where r_no='" + Label16.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from team where r_no='" + Label16.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label16.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label16.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from team where r_no='" + Label16.Text + "'"
                Dim SQL6 As String
                SQL6 = "select price from team where r_no='" + Label16.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            ElseIf other1 = "散客" Then
                Dim SQL1 As String
                SQL1 = "select main_name from personal where r_no='" + Label16.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from personal where r_no='" + Label16.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label16.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label16.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from personal where r_no='" + Label16.Text + "'"
                Dim SQL6 As String
                SQL6 = "select realprice from personal where r_no='" + Label16.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            End If
        ElseIf state = "预订" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被预订中……")
        ElseIf state = "停用" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被停用中……")
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Label1.Text = Label17.Text
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL0 As String
        SQL0 = "select state from roominfo where id='" + Label17.Text + "'"
        Dim state As String
        Dim cmd0 As New SqlCommand(SQL0, conn)
        conn.Open()
        state = cmd0.ExecuteScalar.ToString()
        conn.Close()
        If state = "占用" Then
            Dim SQL As String
            SQL = "select other1 from roominfo where id='" + Label17.Text + "'"
            Dim other1 As String
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            other1 = cmd.ExecuteScalar.ToString()
            conn.Close()
            If other1 = "团体" Then
                Dim SQL1 As String
                SQL1 = "select main_name from team where r_no='" + Label17.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from team where r_no='" + Label17.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label17.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label17.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from team where r_no='" + Label17.Text + "'"
                Dim SQL6 As String
                SQL6 = "select price from team where r_no='" + Label17.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            ElseIf other1 = "散客" Then
                Dim SQL1 As String
                SQL1 = "select main_name from personal where r_no='" + Label17.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from personal where r_no='" + Label17.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label17.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label17.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from personal where r_no='" + Label17.Text + "'"
                Dim SQL6 As String
                SQL6 = "select realprice from personal where r_no='" + Label17.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            End If
        ElseIf state = "预订" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被预订中……")
        ElseIf state = "停用" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被停用中……")
        End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Label1.Text = Label18.Text
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL0 As String
        SQL0 = "select state from roominfo where id='" + Label18.Text + "'"
        Dim state As String
        Dim cmd0 As New SqlCommand(SQL0, conn)
        conn.Open()
        state = cmd0.ExecuteScalar.ToString()
        conn.Close()
        If state = "占用" Then
            Dim SQL As String
            SQL = "select other1 from roominfo where id='" + Label18.Text + "'"
            Dim other1 As String
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            other1 = cmd.ExecuteScalar.ToString()
            conn.Close()
            If other1 = "团体" Then
                Dim SQL1 As String
                SQL1 = "select main_name from team where r_no='" + Label18.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from team where r_no='" + Label18.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label18.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label18.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from team where r_no='" + Label18.Text + "'"
                Dim SQL6 As String
                SQL6 = "select price from team where r_no='" + Label18.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            ElseIf other1 = "散客" Then
                Dim SQL1 As String
                SQL1 = "select main_name from personal where r_no='" + Label18.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from personal where r_no='" + Label18.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label18.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label18.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from personal where r_no='" + Label18.Text + "'"
                Dim SQL6 As String
                SQL6 = "select realprice from personal where r_no='" + Label18.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            End If
        ElseIf state = "预订" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被预订中……")
        ElseIf state = "停用" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被停用中……")
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Label1.Text = Label19.Text
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL0 As String
        SQL0 = "select state from roominfo where id='" + Label19.Text + "'"
        Dim state As String
        Dim cmd0 As New SqlCommand(SQL0, conn)
        conn.Open()
        state = cmd0.ExecuteScalar.ToString()
        conn.Close()
        If state = "占用" Then
            Dim SQL As String
            SQL = "select other1 from roominfo where id='" + Label19.Text + "'"
            Dim other1 As String
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            other1 = cmd.ExecuteScalar.ToString()
            conn.Close()
            If other1 = "团体" Then
                Dim SQL1 As String
                SQL1 = "select main_name from team where r_no='" + Label19.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from team where r_no='" + Label10.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label19.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label19.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from team where r_no='" + Label19.Text + "'"
                Dim SQL6 As String
                SQL6 = "select price from team where r_no='" + Label19.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            ElseIf other1 = "散客" Then
                Dim SQL1 As String
                SQL1 = "select main_name from personal where r_no='" + Label19.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from personal where r_no='" + Label19.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label19.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label19.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from personal where r_no='" + Label19.Text + "'"
                Dim SQL6 As String
                SQL6 = "select realprice from personal where r_no='" + Label19.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            End If
        ElseIf state = "预订" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被预订中……")
        ElseIf state = "停用" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被停用中……")
        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Label1.Text = Label20.Text
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL0 As String
        SQL0 = "select state from roominfo where id='" + Label20.Text + "'"
        Dim state As String
        Dim cmd0 As New SqlCommand(SQL0, conn)
        conn.Open()
        state = cmd0.ExecuteScalar.ToString()
        conn.Close()
        If state = "占用" Then
            Dim SQL As String
            SQL = "select other1 from roominfo where id='" + Label20.Text + "'"
            Dim other1 As String
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            other1 = cmd.ExecuteScalar.ToString()
            conn.Close()
            If other1 = "团体" Then
                Dim SQL1 As String
                SQL1 = "select main_name from team where r_no='" + Label20.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from team where r_no='" + Label20.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label20.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label20.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from team where r_no='" + Label20.Text + "'"
                Dim SQL6 As String
                SQL6 = "select price from team where r_no='" + Label20.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            ElseIf other1 = "散客" Then
                Dim SQL1 As String
                SQL1 = "select main_name from personal where r_no='" + Label20.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from personal where r_no='" + Label20.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label20.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label20.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from personal where r_no='" + Label20.Text + "'"
                Dim SQL6 As String
                SQL6 = "select realprice from personal where r_no='" + Label20.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            End If
        ElseIf state = "预订" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被预订中……")
        ElseIf state = "停用" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被停用中……")
        End If
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        Label1.Text = Label35.Text
        Dim strconn As String
        strconn = "server=.;database=sunhotel;uid=sa;pwd=12345"
        Dim conn As New SqlConnection(strconn)
        Dim SQL0 As String
        SQL0 = "select state from roominfo where id='" + Label35.Text + "'"
        Dim state As String
        Dim cmd0 As New SqlCommand(SQL0, conn)
        conn.Open()
        state = cmd0.ExecuteScalar.ToString()
        conn.Close()
        If state = "占用" Then
            Dim SQL As String
            SQL = "select other1 from roominfo where id='" + Label35.Text + "'"
            Dim other1 As String
            Dim cmd As New SqlCommand(SQL, conn)
            conn.Open()
            other1 = cmd.ExecuteScalar.ToString()
            conn.Close()
            If other1 = "团体" Then
                Dim SQL1 As String
                SQL1 = "select main_name from team where r_no='" + Label35.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from team where r_no='" + Label35.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label35.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label35.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from team where r_no='" + Label35.Text + "'"
                Dim SQL6 As String
                SQL6 = "select price from team where r_no='" + Label35.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            ElseIf other1 = "散客" Then
                Dim SQL1 As String
                SQL1 = "select main_name from personal where r_no='" + Label35.Text + "'"
                Dim SQL2 As String
                SQL2 = "select price from personal where r_no='" + Label35.Text + "'"
                Dim SQL3 As String
                SQL3 = "select r_tel from roominfo where id='" + Label35.Text + "'"
                Dim SQL4 As String
                SQL4 = "select location from roominfo where id='" + Label35.Text + "'"
                Dim SQL5 As String
                SQL5 = "select premoney from personal where r_no='" + Label35.Text + "'"
                Dim SQL6 As String
                SQL6 = "select realprice from personal where r_no='" + Label35.Text + "'"
                Dim name As String
                Dim danjia As String
                Dim tel As String
                Dim location As String
                Dim premoney As String
                Dim price As String
                Dim cmd1 As New SqlCommand(SQL1, conn)
                Dim cmd2 As New SqlCommand(SQL2, conn)
                Dim cmd3 As New SqlCommand(SQL3, conn)
                Dim cmd4 As New SqlCommand(SQL4, conn)
                Dim cmd5 As New SqlCommand(SQL5, conn)
                Dim cmd6 As New SqlCommand(SQL6, conn)
                conn.Open()
                name = cmd1.ExecuteScalar.ToString()
                danjia = cmd2.ExecuteScalar.ToString()
                tel = cmd3.ExecuteScalar.ToString()
                location = cmd4.ExecuteScalar.ToString()
                premoney = cmd5.ExecuteScalar.ToString()
                price = cmd6.ExecuteScalar.ToString()
                conn.Close()
                lb_main_left_center_name.Text = name
                lb_main_left_center_preprice.Text = danjia
                lb_main_left_center_tel.Text = tel
                lb_main_left_center_area.Text = location
                lb_main_left_center_premoney.Text = premoney
                lb_main_left_center_money.Text = price
            End If
        ElseIf state = "预订" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被预订中……")
        ElseIf state = "停用" Then
            lb_main_left_center_name.Text = ""
            lb_main_left_center_preprice.Text = ""
            lb_main_left_center_tel.Text = ""
            lb_main_left_center_area.Text = ""
            lb_main_left_center_premoney.Text = ""
            lb_main_left_center_money.Text = ""
            MessageBox.Show("房间被停用中……")
        End If
    End Sub
End Class