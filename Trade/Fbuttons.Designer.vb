<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fbuttons
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
        Me.Pane_btn = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Pane_btn
        '
        Me.Pane_btn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pane_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pane_btn.Location = New System.Drawing.Point(0, 0)
        Me.Pane_btn.Name = "Pane_btn"
        Me.Pane_btn.Size = New System.Drawing.Size(705, 613)
        Me.Pane_btn.TabIndex = 0
        '
        'Fbuttons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(705, 613)
        Me.ControlBox = False
        Me.Controls.Add(Me.Pane_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(655, 63)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fbuttons"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Fbuttons"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pane_btn As System.Windows.Forms.Panel
End Class
