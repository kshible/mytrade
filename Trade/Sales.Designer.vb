<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panlformoshtriat1 = New System.Windows.Forms.Panel()
        Me.txtGetRecords = New System.Windows.Forms.TextBox()
        Me.thesum = New System.Windows.Forms.Label()
        Me.PicBarCode = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.objDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.txt_receve = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_Reset = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.panlformoshtriat1.SuspendLayout()
        CType(Me.PicBarCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.Snow
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.GridColor = System.Drawing.Color.White
        Me.DataGridView2.Location = New System.Drawing.Point(549, 334)
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.Size = New System.Drawing.Size(128, 135)
        Me.DataGridView2.TabIndex = 0
        Me.DataGridView2.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(722, 578)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(111, 63)
        Me.DataGridView1.TabIndex = 5
        Me.DataGridView1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Location = New System.Drawing.Point(22, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(823, 429)
        Me.Panel1.TabIndex = 46
        '
        'panlformoshtriat1
        '
        Me.panlformoshtriat1.BackColor = System.Drawing.Color.Snow
        Me.panlformoshtriat1.Controls.Add(Me.txtGetRecords)
        Me.panlformoshtriat1.Location = New System.Drawing.Point(623, 644)
        Me.panlformoshtriat1.Name = "panlformoshtriat1"
        Me.panlformoshtriat1.Size = New System.Drawing.Size(326, 95)
        Me.panlformoshtriat1.TabIndex = 47
        Me.panlformoshtriat1.Visible = False
        '
        'txtGetRecords
        '
        Me.txtGetRecords.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtGetRecords.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGetRecords.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGetRecords.ForeColor = System.Drawing.Color.Gold
        Me.txtGetRecords.Location = New System.Drawing.Point(99, 3)
        Me.txtGetRecords.Name = "txtGetRecords"
        Me.txtGetRecords.Size = New System.Drawing.Size(388, 32)
        Me.txtGetRecords.TabIndex = 52
        '
        'thesum
        '
        Me.thesum.AutoSize = True
        Me.thesum.BackColor = System.Drawing.Color.Black
        Me.thesum.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold)
        Me.thesum.ForeColor = System.Drawing.Color.Yellow
        Me.thesum.Location = New System.Drawing.Point(15, 610)
        Me.thesum.Name = "thesum"
        Me.thesum.Size = New System.Drawing.Size(105, 32)
        Me.thesum.TabIndex = 49
        Me.thesum.Text = "thesum"
        '
        'PicBarCode
        '
        Me.PicBarCode.BackColor = System.Drawing.Color.Transparent
        Me.PicBarCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicBarCode.Location = New System.Drawing.Point(609, 512)
        Me.PicBarCode.Name = "PicBarCode"
        Me.PicBarCode.Size = New System.Drawing.Size(216, 47)
        Me.PicBarCode.TabIndex = 52
        Me.PicBarCode.TabStop = False
        Me.PicBarCode.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'objDateTimePicker
        '
        Me.objDateTimePicker.CalendarFont = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.objDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.objDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.objDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.Maroon
        Me.objDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.objDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.Black
        Me.objDateTimePicker.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.objDateTimePicker.Location = New System.Drawing.Point(5, 653)
        Me.objDateTimePicker.Name = "objDateTimePicker"
        Me.objDateTimePicker.Size = New System.Drawing.Size(283, 32)
        Me.objDateTimePicker.TabIndex = 53
        '
        'txt_receve
        '
        Me.txt_receve.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_receve.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_receve.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_receve.ForeColor = System.Drawing.Color.Yellow
        Me.txt_receve.Location = New System.Drawing.Point(566, 610)
        Me.txt_receve.Name = "txt_receve"
        Me.txt_receve.Size = New System.Drawing.Size(89, 34)
        Me.txt_receve.TabIndex = 54
        Me.txt_receve.Text = "0"
        Me.txt_receve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(354, 496)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 27)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "FiFo_sys"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(443, 534)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 37)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(443, 496)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(67, 20)
        Me.TextBox1.TabIndex = 57
        '
        'txt_Reset
        '
        Me.txt_Reset.BackColor = System.Drawing.SystemColors.WindowText
        Me.txt_Reset.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Reset.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Reset.ForeColor = System.Drawing.Color.Yellow
        Me.txt_Reset.Location = New System.Drawing.Point(354, 610)
        Me.txt_Reset.Name = "txt_Reset"
        Me.txt_Reset.Size = New System.Drawing.Size(206, 34)
        Me.txt_Reset.TabIndex = 58
        Me.txt_Reset.Text = "0"
        Me.txt_Reset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(514, 214)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(172, 20)
        Me.TextBox2.TabIndex = 0
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txt_Reset)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_receve)
        Me.Controls.Add(Me.objDateTimePicker)
        Me.Controls.Add(Me.PicBarCode)
        Me.Controls.Add(Me.thesum)
        Me.Controls.Add(Me.panlformoshtriat1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Sales"
        Me.Size = New System.Drawing.Size(1121, 835)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panlformoshtriat1.ResumeLayout(False)
        Me.panlformoshtriat1.PerformLayout()
        CType(Me.PicBarCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents panlformoshtriat1 As System.Windows.Forms.Panel
    Friend WithEvents thesum As System.Windows.Forms.Label
    Friend WithEvents txtGetRecords As System.Windows.Forms.TextBox
    Friend WithEvents PicBarCode As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents objDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_receve As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Reset As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox

End Class
