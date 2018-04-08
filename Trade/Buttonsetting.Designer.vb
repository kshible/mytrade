<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buttonsetting
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_button = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picture_path = New System.Windows.Forms.TextBox()
        Me.Txt_index = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_get_itemz = New System.Windows.Forms.TextBox()
        Me.txt_item_ID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(78, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "....صورة"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(397, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "إسم الزر"
        '
        'Txt_button
        '
        Me.Txt_button.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_button.Location = New System.Drawing.Point(140, 42)
        Me.Txt_button.Name = "Txt_button"
        Me.Txt_button.Size = New System.Drawing.Size(235, 26)
        Me.Txt_button.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Location = New System.Drawing.Point(274, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 40)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "حفظ"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Location = New System.Drawing.Point(1, 103)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 40)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "رجوع"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(331, 353)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(116, 20)
        Me.txt_name.TabIndex = 5
        Me.txt_name.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(178, 352)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(118, 21)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(140, 10)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(235, 27)
        Me.ComboBox2.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(381, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "الاسم الجديد"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 96)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'picture_path
        '
        Me.picture_path.Location = New System.Drawing.Point(237, 74)
        Me.picture_path.Name = "picture_path"
        Me.picture_path.Size = New System.Drawing.Size(138, 20)
        Me.picture_path.TabIndex = 10
        Me.picture_path.Text = "0"
        Me.picture_path.Visible = False
        '
        'Txt_index
        '
        Me.Txt_index.Location = New System.Drawing.Point(12, 353)
        Me.Txt_index.Name = "Txt_index"
        Me.Txt_index.Size = New System.Drawing.Size(127, 20)
        Me.Txt_index.TabIndex = 11
        Me.Txt_index.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(451, 147)
        Me.DataGridView1.TabIndex = 13
        Me.DataGridView1.Visible = False
        '
        'txt_get_itemz
        '
        Me.txt_get_itemz.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_get_itemz.Location = New System.Drawing.Point(151, 222)
        Me.txt_get_itemz.Name = "txt_get_itemz"
        Me.txt_get_itemz.Size = New System.Drawing.Size(201, 26)
        Me.txt_get_itemz.TabIndex = 14
        Me.txt_get_itemz.Visible = False
        '
        'txt_item_ID
        '
        Me.txt_item_ID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_item_ID.Location = New System.Drawing.Point(33, 215)
        Me.txt_item_ID.Name = "txt_item_ID"
        Me.txt_item_ID.Size = New System.Drawing.Size(52, 26)
        Me.txt_item_ID.TabIndex = 15
        Me.txt_item_ID.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(358, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "بحث عن اصناف"
        Me.Label3.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button4.Location = New System.Drawing.Point(118, 103)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 40)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "ربط بأصناف"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Buttonsetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(451, 167)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_item_ID)
        Me.Controls.Add(Me.txt_get_itemz)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Txt_index)
        Me.Controls.Add(Me.picture_path)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Txt_button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Buttonsetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Buttonsetting"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_button As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picture_path As System.Windows.Forms.TextBox
    Friend WithEvents Txt_index As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_get_itemz As System.Windows.Forms.TextBox
    Friend WithEvents txt_item_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
