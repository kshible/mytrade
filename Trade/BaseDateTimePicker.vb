Public Class DateTimePicker
    Inherits System.Windows.Forms.DateTimePicker

#Region " Component Designer generated code "

    Public Sub New()
        MyBase.New()

        ' This call is required by the Component Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Control overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Control Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Component Designer
    ' It can be modified using the Component Designer.  Do not modify it
    ' using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

#End Region

    'The module level variable that will store the background color
    Private mBackColor As Color = SystemColors.Window

    'The BackColor property we will be calling
    Public Overrides Property BackColor() As Color
        Get
            Return mBackColor
        End Get
        Set(ByVal Value As Color)
            mBackColor = Value
            'After the BackColor has been set, Invalidate the control
            'This will force it to be redrawn
            Invalidate()
        End Set
    End Property

    'WndProc fires durring the painting of the control
    Protected Overrides Sub WndProc(ByRef m As Message)
        'Check to see if message being send is WM_ERASEBKGND. 
        'The hex value of this message is &H14.
        'This message is sent when the background of the 
        'object needs to be erased. In our case though, instead of
        'erasing it, we will paint a rectangle over it
        If m.Msg = CInt(&H14) Then ' WM_ERASEBKGND 
            Dim g As Graphics = Graphics.FromHdc(m.WParam)
            g.FillRectangle(New SolidBrush(mBackColor), ClientRectangle)
            g.Dispose()
            Return
        End If
        MyBase.WndProc(m)
    End Sub
End Class