Private Sub 日文_CheckedChanged(sender As Object, e As EventArgs)

End Sub

Private Sub 英文_CheckedChanged(sender As Object, e As EventArgs)

End Sub
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.字号减小 = New System.Windows.Forms.Button()
        Me.字号增加 = New System.Windows.Forms.Button()
        Me.字号显示 = New System.Windows.Forms.Label()
        Me.雅黑 = New System.Windows.Forms.Button()
        Me.信息1 = New System.Windows.Forms.Label()
        Me.信息2 = New System.Windows.Forms.Label()
        Me.字体2 = New System.Windows.Forms.Button()
        Me.字体3 = New System.Windows.Forms.Button()
        Me.设为默认 = New System.Windows.Forms.Button()
        Me.字色黑 = New System.Windows.Forms.Button()
        Me.字色白 = New System.Windows.Forms.Button()
        Me.字色红 = New System.Windows.Forms.Button()
        Me.背景白 = New System.Windows.Forms.Button()
        Me.背景黑 = New System.Windows.Forms.Button()
        Me.背景绿 = New System.Windows.Forms.Button()
        Me.信息4 = New System.Windows.Forms.Label()
        Me.信息5 = New System.Windows.Forms.Label()
        Me.中文 = New System.Windows.Forms.RadioButton()
        Me.英文 = New System.Windows.Forms.RadioButton()
        Me.信息10 = New System.Windows.Forms.Label()
        Me.日文 = New System.Windows.Forms.RadioButton()
        Me.信息3 = New System.Windows.Forms.Label()
        Me.下划线 = New System.Windows.Forms.Button()
        Me.粗体 = New System.Windows.Forms.Button()
        Me.倾斜 = New System.Windows.Forms.Button()
        Me.信息11 = New System.Windows.Forms.Label()
        Me.字号 = New System.Windows.Forms.Label()
        Me.快捷功能开关 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        '字号减小
        '
        Me.字号减小.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.字号减小.Location = New System.Drawing.Point(92, 13)
        Me.字号减小.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.字号减小.Name = "字号减小"
        Me.字号减小.Size = New System.Drawing.Size(135, 49)
        Me.字号减小.TabIndex = 0
        Me.字号减小.Text = "字号-"
        Me.字号减小.UseVisualStyleBackColor = True
        '
        '字号增加
        '
        Me.字号增加.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.字号增加.Location = New System.Drawing.Point(233, 13)
        Me.字号增加.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.字号增加.Name = "字号增加"
        Me.字号增加.Size = New System.Drawing.Size(135, 50)
        Me.字号增加.TabIndex = 1
        Me.字号增加.Text = "字号+"
        Me.字号增加.UseVisualStyleBackColor = True
        '
        '字号显示
        '
        Me.字号显示.AutoSize = True
        Me.字号显示.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.字号显示.Location = New System.Drawing.Point(374, 22)
        Me.字号显示.Name = "字号显示"
        Me.字号显示.Size = New System.Drawing.Size(145, 31)
        Me.字号显示.TabIndex = 2
        Me.字号显示.Text = "当前字号 24"
        '
        '雅黑
        '
        Me.雅黑.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.雅黑.Location = New System.Drawing.Point(92, 70)
        Me.雅黑.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.雅黑.Name = "雅黑"
        Me.雅黑.Size = New System.Drawing.Size(135, 49)
        Me.雅黑.TabIndex = 3
        Me.雅黑.Text = "微软雅黑"
        Me.雅黑.UseVisualStyleBackColor = True
        '
        '信息1
        '
        Me.信息1.AutoSize = True
        Me.信息1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.信息1.Location = New System.Drawing.Point(12, 30)
        Me.信息1.Name = "信息1"
        Me.信息1.Size = New System.Drawing.Size(74, 21)
        Me.信息1.TabIndex = 4
        Me.信息1.Text = "字号设置"
        Me.信息1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '信息2
        '
        Me.信息2.AutoSize = True
        Me.信息2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.信息2.Location = New System.Drawing.Point(12, 87)
        Me.信息2.Name = "信息2"
        Me.信息2.Size = New System.Drawing.Size(74, 21)
        Me.信息2.TabIndex = 5
        Me.信息2.Text = "字体设置"
        Me.信息2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '字体2
        '
        Me.字体2.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.字体2.Location = New System.Drawing.Point(233, 70)
        Me.字体2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.字体2.Name = "字体2"
        Me.字体2.Size = New System.Drawing.Size(135, 49)
        Me.字体2.TabIndex = 6
        Me.字体2.Text = "字体2"
        Me.字体2.UseVisualStyleBackColor = True
        '
        '字体3
        '
        Me.字体3.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.字体3.Location = New System.Drawing.Point(374, 70)
        Me.字体3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.字体3.Name = "字体3"
        Me.字体3.Size = New System.Drawing.Size(135, 49)
        Me.字体3.TabIndex = 7
        Me.字体3.Text = "字体3"
        Me.字体3.UseVisualStyleBackColor = True
        '
        '设为默认
        '
        Me.设为默认.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.设为默认.Location = New System.Drawing.Point(525, 13)
        Me.设为默认.Name = "设为默认"
        Me.设为默认.Size = New System.Drawing.Size(36, 277)
        Me.设为默认.TabIndex = 8
        Me.设为默认.Text = "设为默认"
        Me.设为默认.UseVisualStyleBackColor = True
        '
        '字色黑
        '
        Me.字色黑.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.字色黑.Location = New System.Drawing.Point(92, 184)
        Me.字色黑.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.字色黑.Name = "字色黑"
        Me.字色黑.Size = New System.Drawing.Size(135, 49)
        Me.字色黑.TabIndex = 9
        Me.字色黑.Text = "黑"
        Me.字色黑.UseVisualStyleBackColor = True
        '
        '字色白
        '
        Me.字色白.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.字色白.Location = New System.Drawing.Point(233, 184)
        Me.字色白.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.字色白.Name = "字色白"
        Me.字色白.Size = New System.Drawing.Size(135, 49)
        Me.字色白.TabIndex = 10
        Me.字色白.Text = "白"
        Me.字色白.UseVisualStyleBackColor = True
        '
        '字色红
        '
        Me.字色红.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.字色红.Location = New System.Drawing.Point(374, 184)
        Me.字色红.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.字色红.Name = "字色红"
        Me.字色红.Size = New System.Drawing.Size(135, 49)
        Me.字色红.TabIndex = 11
        Me.字色红.Text = "红"
        Me.字色红.UseVisualStyleBackColor = True
        '
        '背景白
        '
        Me.背景白.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.背景白.Location = New System.Drawing.Point(92, 241)
        Me.背景白.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.背景白.Name = "背景白"
        Me.背景白.Size = New System.Drawing.Size(135, 49)
        Me.背景白.TabIndex = 12
        Me.背景白.Text = "白"
        Me.背景白.UseVisualStyleBackColor = True
        '
        '背景黑
        '
        Me.背景黑.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.背景黑.Location = New System.Drawing.Point(233, 241)
        Me.背景黑.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.背景黑.Name = "背景黑"
        Me.背景黑.Size = New System.Drawing.Size(135, 49)
        Me.背景黑.TabIndex = 13
        Me.背景黑.Text = "黑"
        Me.背景黑.UseVisualStyleBackColor = True
        '
        '背景绿
        '
        Me.背景绿.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.背景绿.Location = New System.Drawing.Point(374, 241)
        Me.背景绿.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.背景绿.Name = "背景绿"
        Me.背景绿.Size = New System.Drawing.Size(135, 49)
        Me.背景绿.TabIndex = 14
        Me.背景绿.Text = "淡绿"
        Me.背景绿.UseVisualStyleBackColor = True
        '
        '信息4
        '
        Me.信息4.AutoSize = True
        Me.信息4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.信息4.Location = New System.Drawing.Point(12, 201)
        Me.信息4.Name = "信息4"
        Me.信息4.Size = New System.Drawing.Size(74, 21)
        Me.信息4.TabIndex = 15
        Me.信息4.Text = "字体颜色"
        Me.信息4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '信息5
        '
        Me.信息5.AutoSize = True
        Me.信息5.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.信息5.Location = New System.Drawing.Point(12, 258)
        Me.信息5.Name = "信息5"
        Me.信息5.Size = New System.Drawing.Size(74, 21)
        Me.信息5.TabIndex = 16
        Me.信息5.Text = "背景颜色"
        Me.信息5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '中文
        '
        Me.中文.AutoSize = True
        Me.中文.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.中文.Location = New System.Drawing.Point(74, 306)
        Me.中文.Name = "中文"
        Me.中文.Size = New System.Drawing.Size(83, 24)
        Me.中文.TabIndex = 17
        Me.中文.TabStop = True
        Me.中文.Text = "简体中文"
        Me.中文.UseVisualStyleBackColor = True
        '
        '英文
        '
        Me.英文.AutoSize = True
        Me.英文.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.英文.Location = New System.Drawing.Point(163, 307)
        Me.英文.Name = "英文"
        Me.英文.Size = New System.Drawing.Size(76, 24)
        Me.英文.TabIndex = 18
        Me.英文.TabStop = True
        Me.英文.Text = "English"
        Me.英文.UseVisualStyleBackColor = True
        '
        '信息10
        '
        Me.信息10.AutoSize = True
        Me.信息10.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.信息10.Location = New System.Drawing.Point(26, 307)
        Me.信息10.Name = "信息10"
        Me.信息10.Size = New System.Drawing.Size(42, 21)
        Me.信息10.TabIndex = 19
        Me.信息10.Text = "语言"
        '
        '日文
        '
        Me.日文.AutoSize = True
        Me.日文.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.日文.Location = New System.Drawing.Point(245, 307)
        Me.日文.Name = "日文"
        Me.日文.Size = New System.Drawing.Size(55, 24)
        Me.日文.TabIndex = 20
        Me.日文.TabStop = True
        Me.日文.Text = "日语"
        Me.日文.UseVisualStyleBackColor = True
        '
        '信息3
        '
        Me.信息3.AutoSize = True
        Me.信息3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.信息3.Location = New System.Drawing.Point(12, 144)
        Me.信息3.Name = "信息3"
        Me.信息3.Size = New System.Drawing.Size(74, 21)
        Me.信息3.TabIndex = 25
        Me.信息3.Text = "文字样式"
        Me.信息3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '下划线
        '
        Me.下划线.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.下划线.Location = New System.Drawing.Point(374, 127)
        Me.下划线.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.下划线.Name = "下划线"
        Me.下划线.Size = New System.Drawing.Size(135, 49)
        Me.下划线.TabIndex = 24
        Me.下划线.Text = "下划线"
        Me.下划线.UseVisualStyleBackColor = True
        '
        '粗体
        '
        Me.粗体.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.粗体.Location = New System.Drawing.Point(233, 127)
        Me.粗体.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.粗体.Name = "粗体"
        Me.粗体.Size = New System.Drawing.Size(135, 49)
        Me.粗体.TabIndex = 23
        Me.粗体.Text = "粗体"
        Me.粗体.UseVisualStyleBackColor = True
        '
        '倾斜
        '
        Me.倾斜.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.倾斜.Location = New System.Drawing.Point(92, 127)
        Me.倾斜.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.倾斜.Name = "倾斜"
        Me.倾斜.Size = New System.Drawing.Size(135, 49)
        Me.倾斜.TabIndex = 22
        Me.倾斜.Text = "倾斜"
        Me.倾斜.UseVisualStyleBackColor = True
        '
        '信息11
        '
        Me.信息11.AutoSize = True
        Me.信息11.Location = New System.Drawing.Point(462, 311)
        Me.信息11.Name = "信息11"
        Me.信息11.Size = New System.Drawing.Size(99, 17)
        Me.信息11.TabIndex = 26
        Me.信息11.Text = "QuickText v1.02"
        '
        '字号
        '
        Me.字号.AutoSize = True
        Me.字号.Font = New System.Drawing.Font("微软雅黑", 24.0!)
        Me.字号.Location = New System.Drawing.Point(395, 373)
        Me.字号.Name = "字号"
        Me.字号.Size = New System.Drawing.Size(82, 41)
        Me.字号.TabIndex = 28
        Me.字号.Text = "字号"
        Me.字号.Visible = False
        '
        '快捷功能开关
        '
        Me.快捷功能开关.Location = New System.Drawing.Point(342, 306)
        Me.快捷功能开关.Name = "快捷功能开关"
        Me.快捷功能开关.Size = New System.Drawing.Size(102, 25)
        Me.快捷功能开关.TabIndex = 29
        Me.快捷功能开关.Text = "快捷功能 开"
        Me.快捷功能开关.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 569)
        Me.Controls.Add(Me.快捷功能开关)
        Me.Controls.Add(Me.字号)
        Me.Controls.Add(Me.信息11)
        Me.Controls.Add(Me.信息3)
        Me.Controls.Add(Me.下划线)
        Me.Controls.Add(Me.粗体)
        Me.Controls.Add(Me.倾斜)
        Me.Controls.Add(Me.日文)
        Me.Controls.Add(Me.信息10)
        Me.Controls.Add(Me.英文)
        Me.Controls.Add(Me.中文)
        Me.Controls.Add(Me.信息5)
        Me.Controls.Add(Me.信息4)
        Me.Controls.Add(Me.背景绿)
        Me.Controls.Add(Me.背景黑)
        Me.Controls.Add(Me.背景白)
        Me.Controls.Add(Me.字色红)
        Me.Controls.Add(Me.字色白)
        Me.Controls.Add(Me.字色黑)
        Me.Controls.Add(Me.设为默认)
        Me.Controls.Add(Me.字体3)
        Me.Controls.Add(Me.字体2)
        Me.Controls.Add(Me.信息2)
        Me.Controls.Add(Me.信息1)
        Me.Controls.Add(Me.雅黑)
        Me.Controls.Add(Me.字号显示)
        Me.Controls.Add(Me.字号增加)
        Me.Controls.Add(Me.字号减小)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "设置"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 字号减小 As System.Windows.Forms.Button
    Friend WithEvents 字号增加 As System.Windows.Forms.Button
    Friend WithEvents 字号显示 As System.Windows.Forms.Label
    Friend WithEvents 雅黑 As System.Windows.Forms.Button
    Friend WithEvents 信息1 As System.Windows.Forms.Label
    Friend WithEvents 信息2 As System.Windows.Forms.Label
    Friend WithEvents 字体2 As System.Windows.Forms.Button
    Friend WithEvents 字体3 As System.Windows.Forms.Button
    Friend WithEvents 设为默认 As System.Windows.Forms.Button
    Friend WithEvents 字色黑 As System.Windows.Forms.Button
    Friend WithEvents 字色白 As System.Windows.Forms.Button
    Friend WithEvents 字色红 As System.Windows.Forms.Button
    Friend WithEvents 背景白 As System.Windows.Forms.Button
    Friend WithEvents 背景黑 As System.Windows.Forms.Button
    Friend WithEvents 背景绿 As System.Windows.Forms.Button
    Friend WithEvents 信息4 As System.Windows.Forms.Label
    Friend WithEvents 信息5 As System.Windows.Forms.Label
    Friend WithEvents 中文 As System.Windows.Forms.RadioButton
    Friend WithEvents 英文 As System.Windows.Forms.RadioButton
    Friend WithEvents 信息10 As System.Windows.Forms.Label
    Friend WithEvents 日文 As System.Windows.Forms.RadioButton
    Friend WithEvents 信息3 As System.Windows.Forms.Label
    Friend WithEvents 下划线 As System.Windows.Forms.Button
    Friend WithEvents 粗体 As System.Windows.Forms.Button
    Friend WithEvents 倾斜 As System.Windows.Forms.Button
    Friend WithEvents 信息11 As System.Windows.Forms.Label
    Friend WithEvents 字号 As System.Windows.Forms.Label
    Friend WithEvents 快捷功能开关 As System.Windows.Forms.Button
