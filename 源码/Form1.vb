
Public Class Form1
    Dim timenow As Date
    Dim timeset As Date
    Dim timeend As Integer
    Dim lt As Integer
    Dim pas As Boolean
    Dim go As Boolean
    Dim sDirect As String
    Dim gpsw As String




    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        RadioButton1.Checked = True : sethour()

        go = False

        sDirect = System.Environment.SystemDirectory

        TextBox1.Text = Format(DateTime.Now, "HH")
        TextBox2.Text = Format(DateTime.Now, "mm")
        TextBox3.Text = Format(DateTime.Now, "ss")


        Timer1.Enabled = True

    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        If go = True Then
            e.Cancel = True
            Me.Hide()
            NotifyIcon1.Visible = True
            NotifyIcon1.BalloonTipText = "已经隐藏在这里了"
            NotifyIcon1.ShowBalloonTip(2000)
        End If
       
    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        GroupBox1.Text = timenow

        If go = True And RadioButton2.Checked = True Then
            lt = lt + 1
            If lt >= timeend * 10 Then Shell(sDirect & "\shutdown -t 0 -s -f") : Application.Exit()
            GroupBox1.Text = lt / 10
        End If

        timenow = DateTime.Now



        If go = True And Val(Replace((Replace(Replace(timeset, "-", ""), " ", "")), ":", "")) = Val(Replace((Replace(Replace(timenow, "-", ""), " ", "")), ":", "")) Then Shell(sDirect & "\shutdown -t 0 -s -f") : Application.Exit()


    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            pas = True

            psw.Visible = True

            psw.Focus()
        End If
       
        If CheckBox1.Checked = False Then

            pas = False

            psw.Visible = False


        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If go = True Then
            If pas = True Then
                gpsw = InputBox("请输入密码", "", "")
                If gpsw = psw.Text Then NotifyIcon1.Dispose() : Application.Restart() Else MsgBox("密码错误", MsgBoxStyle.OkOnly)
            End If
            If pas = False Then NotifyIcon1.Dispose() : Application.Restart()
        End If


        If go = False Then
            If RadioButton1.Checked = True Then timeset = DateTimePicker1.Value.Date & " " & TextBox1.Text & ":" & TextBox2.Text & ":" & TextBox3.Text
            If RadioButton2.Checked = True Then timeend = Val(TextBox5.Text) * 60 + Val(TextBox4.Text)
            psw.Visible = False

            go = True
            Button1.Text = "取消"
            Me.Visible = False
            NotifyIcon1.Visible = True
            RadioButton1.Checked = False
            DateTimePicker1.Enabled = False
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
            shi.Enabled = False
            fen.Enabled = False
            miao.Enabled = False
            fen2.Enabled = False
            miao2.Enabled = False
            CheckBox1.Enabled = False
            psw.Visible = False
            NotifyIcon1.ShowBalloonTip(2000)
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked = True Then delayhour() '延时

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton1.Checked = True Then sethour() '定时

    End Sub
    '下面是输入数据的判断
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged


        With TextBox1

            If Val(Str$(.Text)) >= 24 Then .Text = 23

            If Val(Str$(.Text)) < 0 Then .Text = 0

            If Len(.Text) = 2 Then TextBox2.Focus()

        End With

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text <> "" Then
            With TextBox2

                If Val(Str$(.Text)) > 60 Then .Text = 59

                If Val(Str$(.Text)) < 0 Then .Text = 0

                If Len(.Text) = 2 Then TextBox3.Focus()

            End With
        End If
    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        With TextBox3

            If Val(Str$(.Text)) > 60 Then .Text = 59

            If Val(Str$(.Text)) < 0 Then .Text = 0

            If Len(.Text) = 2 Then Button1.Focus()

        End With
    End Sub
    Sub delayhour()
        RadioButton1.Checked = False
        DateTimePicker1.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        shi.Enabled = False
        fen.Enabled = False
        miao.Enabled = False
        fen2.Enabled = True
        miao2.Enabled = True
    End Sub

    Sub sethour()
        RadioButton2.Checked = False
        DateTimePicker1.Enabled = True
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        shi.Enabled = True
        fen.Enabled = True
        miao.Enabled = True
        fen2.Enabled = False
        miao2.Enabled = False
    End Sub




    Private Sub 显示主程序ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 显示主程序ToolStripMenuItem.Click
        Me.Visible = True : NotifyIcon1.Visible = False
    End Sub
End Class