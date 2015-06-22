<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.主编辑区 = New System.Windows.Forms.TextBox()
        Me.设置 = New System.Windows.Forms.Button()
        Me.复制到剪切板 = New System.Windows.Forms.Button()
        Me.从剪切板复制 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        '主编辑区
        '
        Me.主编辑区.AcceptsReturn = True
        Me.主编辑区.AllowDrop = True
        Me.主编辑区.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.主编辑区.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.主编辑区.Location = New System.Drawing.Point(2, 2)
        Me.主编辑区.Multiline = True
        Me.主编辑区.Name = "主编辑区"
        Me.主编辑区.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.主编辑区.Size = New System.Drawing.Size(1266, 796)
        Me.主编辑区.TabIndex = 0
        '
        '设置
        '
        Me.设置.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.设置.Location = New System.Drawing.Point(1199, 769)
        Me.设置.Margin = New System.Windows.Forms.Padding(0)
        Me.设置.Name = "设置"
        Me.设置.Size = New System.Drawing.Size(50, 29)
        Me.设置.TabIndex = 1
        Me.设置.Text = "设置"
        Me.设置.UseVisualStyleBackColor = True
        '
        '复制到剪切板
        '
        Me.复制到剪切板.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.复制到剪切板.Location = New System.Drawing.Point(1109, 769)
        Me.复制到剪切板.Margin = New System.Windows.Forms.Padding(0)
        Me.复制到剪切板.Name = "复制到剪切板"
        Me.复制到剪切板.Size = New System.Drawing.Size(90, 29)
        Me.复制到剪切板.TabIndex = 2
        Me.复制到剪切板.Text = "复制到剪切板"
        Me.复制到剪切板.UseVisualStyleBackColor = True
        '
        '从剪切板复制
        '
        Me.从剪切板复制.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.从剪切板复制.Location = New System.Drawing.Point(1019, 769)
        Me.从剪切板复制.Margin = New System.Windows.Forms.Padding(0)
        Me.从剪切板复制.Name = "从剪切板复制"
        Me.从剪切板复制.Size = New System.Drawing.Size(90, 29)
        Me.从剪切板复制.TabIndex = 3
        Me.从剪切板复制.Text = "从剪切板复制"
        Me.从剪切板复制.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 802)
        Me.ControlBox = False
        Me.Controls.Add(Me.从剪切板复制)
        Me.Controls.Add(Me.复制到剪切板)
        Me.Controls.Add(Me.设置)
        Me.Controls.Add(Me.主编辑区)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QuickText"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 主编辑区 As System.Windows.Forms.TextBox
    Friend WithEvents 设置 As System.Windows.Forms.Button
    Friend WithEvents 复制到剪切板 As System.Windows.Forms.Button
    Friend WithEvents 从剪切板复制 As System.Windows.Forms.Button

End Class
