<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FWait
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
        Me.DGVwait = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DGVwait, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVwait
        '
        Me.DGVwait.AllowUserToAddRows = False
        Me.DGVwait.AllowUserToDeleteRows = False
        Me.DGVwait.BackgroundColor = System.Drawing.Color.White
        Me.DGVwait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVwait.Location = New System.Drawing.Point(12, 12)
        Me.DGVwait.Name = "DGVwait"
        Me.DGVwait.RowHeadersVisible = False
        Me.DGVwait.Size = New System.Drawing.Size(240, 166)
        Me.DGVwait.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(258, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 25)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "إزالة"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(258, 43)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 25)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "مستخدم"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(258, 153)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 25)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "موافق"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"مستخدم1", "مستخدم2", "مستخدم3"})
        Me.ComboBox1.Location = New System.Drawing.Point(258, 74)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(258, 122)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(64, 25)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "إلغاء"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FWait
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(325, 189)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGVwait)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FWait"
        Me.Text = "FWait"
        CType(Me.DGVwait, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVwait As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
