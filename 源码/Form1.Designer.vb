<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.miao = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.fen2 = New System.Windows.Forms.TextBox
        Me.shi = New System.Windows.Forms.TextBox
        Me.miao2 = New System.Windows.Forms.TextBox
        Me.fen = New System.Windows.Forms.TextBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.psw = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.conmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.显示主程序ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        Me.conmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(113, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "确认"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.miao)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.fen2)
        Me.GroupBox1.Controls.Add(Me.shi)
        Me.GroupBox1.Controls.Add(Me.miao2)
        Me.GroupBox1.Controls.Add(Me.fen)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(151, 137)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'miao
        '
        Me.miao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.miao.Location = New System.Drawing.Point(134, 61)
        Me.miao.Name = "miao"
        Me.miao.ReadOnly = True
        Me.miao.Size = New System.Drawing.Size(14, 14)
        Me.miao.TabIndex = 12
        Me.miao.Text = "秒"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(104, 56)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(25, 21)
        Me.TextBox3.TabIndex = 11
        Me.TextBox3.Text = "59"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(79, 106)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(46, 21)
        Me.TextBox4.TabIndex = 6
        Me.TextBox4.TabStop = False
        Me.TextBox4.WordWrap = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(27, 106)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(29, 21)
        Me.TextBox5.TabIndex = 5
        Me.TextBox5.TabStop = False
        Me.TextBox5.WordWrap = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(15, 83)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.Text = "延时"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(56, 56)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(25, 21)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = "59"
        Me.TextBox2.WordWrap = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(25, 21)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "23"
        Me.TextBox1.WordWrap = False
        '
        'RadioButton1
        '
        Me.RadioButton1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RadioButton1.Location = New System.Drawing.Point(11, 13)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.Text = "定时"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(18, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(107, 21)
        Me.DateTimePicker1.TabIndex = 0
        Me.DateTimePicker1.TabStop = False
        '
        'fen2
        '
        Me.fen2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.fen2.Location = New System.Drawing.Point(62, 109)
        Me.fen2.Name = "fen2"
        Me.fen2.ReadOnly = True
        Me.fen2.Size = New System.Drawing.Size(21, 14)
        Me.fen2.TabIndex = 8
        Me.fen2.Text = "分"
        '
        'shi
        '
        Me.shi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.shi.Location = New System.Drawing.Point(39, 60)
        Me.shi.Name = "shi"
        Me.shi.ReadOnly = True
        Me.shi.Size = New System.Drawing.Size(21, 14)
        Me.shi.TabIndex = 7
        Me.shi.Text = "时"
        '
        'miao2
        '
        Me.miao2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.miao2.Location = New System.Drawing.Point(131, 109)
        Me.miao2.Name = "miao2"
        Me.miao2.ReadOnly = True
        Me.miao2.Size = New System.Drawing.Size(14, 14)
        Me.miao2.TabIndex = 10
        Me.miao2.Text = "秒"
        '
        'fen
        '
        Me.fen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.fen.Location = New System.Drawing.Point(87, 60)
        Me.fen.Name = "fen"
        Me.fen.ReadOnly = True
        Me.fen.Size = New System.Drawing.Size(14, 14)
        Me.fen.TabIndex = 9
        Me.fen.Text = "分"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(13, 157)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.TabStop = False
        Me.CheckBox1.Text = "使用密码"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'psw
        '
        Me.psw.Location = New System.Drawing.Point(30, 155)
        Me.psw.Name = "psw"
        Me.psw.ShortcutsEnabled = False
        Me.psw.Size = New System.Drawing.Size(77, 21)
        Me.psw.TabIndex = 4
        Me.psw.TabStop = False
        Me.psw.UseSystemPasswordChar = True
        Me.psw.Visible = False
        Me.psw.WordWrap = False
        '
        'Timer1
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "开始倒计时，右键这里显示主窗口"
        Me.NotifyIcon1.BalloonTipTitle = "关机宝"
        Me.NotifyIcon1.ContextMenuStrip = Me.conmenu
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        '
        'conmenu
        '
        Me.conmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.显示主程序ToolStripMenuItem})
        Me.conmenu.Name = "ContextMenuStrip1"
        Me.conmenu.Size = New System.Drawing.Size(135, 26)
        '
        '显示主程序ToolStripMenuItem
        '
        Me.显示主程序ToolStripMenuItem.Name = "显示主程序ToolStripMenuItem"
        Me.显示主程序ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.显示主程序ToolStripMenuItem.Text = "显示主程序"
        '
        'Form1
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(176, 195)
        Me.Controls.Add(Me.psw)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "关机宝"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.conmenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents psw As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents fen2 As System.Windows.Forms.TextBox
    Friend WithEvents shi As System.Windows.Forms.TextBox
    Friend WithEvents miao2 As System.Windows.Forms.TextBox
    Friend WithEvents fen As System.Windows.Forms.TextBox
    Friend WithEvents miao As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents conmenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 显示主程序ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
