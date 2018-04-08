<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SR1
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
        Me.txtGetRecords = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtGetRecords
        '
        Me.txtGetRecords.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtGetRecords.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGetRecords.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGetRecords.ForeColor = System.Drawing.Color.Gold
        Me.txtGetRecords.Location = New System.Drawing.Point(32, 26)
        Me.txtGetRecords.Name = "txtGetRecords"
        Me.txtGetRecords.Size = New System.Drawing.Size(157, 32)
        Me.txtGetRecords.TabIndex = 53
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(84, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 38)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SR1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 157)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtGetRecords)
        Me.Name = "SR1"
        Me.Text = "SR1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGetRecords As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
