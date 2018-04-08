<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class actions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.mainpanal = New System.Windows.Forms.Panel()
        Me.mycomments = New System.Windows.Forms.TextBox()
        Me.middlepanel = New System.Windows.Forms.Panel()
        Me.verticalpanal = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.mainpanal.SuspendLayout()
        Me.verticalpanal.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainpanal
        '
        Me.mainpanal.Controls.Add(Me.mycomments)
        Me.mainpanal.Controls.Add(Me.middlepanel)
        Me.mainpanal.Controls.Add(Me.verticalpanal)
        Me.mainpanal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainpanal.Location = New System.Drawing.Point(0, 0)
        Me.mainpanal.Name = "mainpanal"
        Me.mainpanal.Size = New System.Drawing.Size(1274, 741)
        Me.mainpanal.TabIndex = 0
        '
        'mycomments
        '
        Me.mycomments.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mycomments.Location = New System.Drawing.Point(1015, 12)
        Me.mycomments.Name = "mycomments"
        Me.mycomments.Size = New System.Drawing.Size(244, 26)
        Me.mycomments.TabIndex = 4
        Me.mycomments.Visible = False
        '
        'middlepanel
        '
        Me.middlepanel.Location = New System.Drawing.Point(0, 0)
        Me.middlepanel.Name = "middlepanel"
        Me.middlepanel.Size = New System.Drawing.Size(995, 683)
        Me.middlepanel.TabIndex = 3
        '
        'verticalpanal
        '
        Me.verticalpanal.BackColor = System.Drawing.Color.Beige
        Me.verticalpanal.Controls.Add(Me.Button2)
        Me.verticalpanal.Controls.Add(Me.Button1)
        Me.verticalpanal.Controls.Add(Me.CheckedListBox1)
        Me.verticalpanal.Location = New System.Drawing.Point(1006, 24)
        Me.verticalpanal.Name = "verticalpanal"
        Me.verticalpanal.Size = New System.Drawing.Size(256, 726)
        Me.verticalpanal.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(245, 434)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 37)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "UP"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(318, 431)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Down"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"ادراج فاتورة", "المبيعات", "الخزينة", "التالف", "المستخدمين", "الإعدادات", "الرئيسية", "خروج", "النسخ الإحتياطى", "الإصناف المسترجعة", "المشتريات", "المبيعات اليومية", "التقارير", "إنتظار"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(23, 366)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(149, 154)
        Me.CheckedListBox1.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'actions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1274, 741)
        Me.ControlBox = False
        Me.Controls.Add(Me.mainpanal)
        Me.Name = "actions"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "منظومة  مبيعات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mainpanal.ResumeLayout(False)
        Me.mainpanal.PerformLayout()
        Me.verticalpanal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mainpanal As System.Windows.Forms.Panel
    Friend WithEvents verticalpanal As System.Windows.Forms.Panel
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents middlepanel As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents mycomments As System.Windows.Forms.TextBox

End Class
