
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Public Class actions
    Const timer_interval As Integer = 15 ' INTERVAL IN MILLISECONDS
    Protected current_gradient_shift As Integer = 10
    Protected gradiant_step As Integer = 5
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles mainpanal.Paint

    End Sub


    ' verticalpanalصناعة الأزرار بعد تحديد البانل
    Sub creatMainbutoons(ByVal listchekbox As CheckedListBox, ByVal pnnl As Panel)


        pnnl.Controls.Clear()

        ' pnnl.Width = 350
        pnnl.Location = New System.Drawing.Point(1006, 24)
        pnnl.Size = New System.Drawing.Size(356, 726)
        '256, 726
        pnnl.Refresh()
        Dim h1 As Integer = 330 ' verticalpanal.Width - 50
        h1 = h1
        Dim Botonhight As Integer = -70
        Dim i As Integer = 0
        Dim checked As CheckedListBox.CheckedItemCollection = listchekbox.CheckedItems



        Dim item As String

        For Each item In listchekbox.Items




            '  For i As Integer = 0 To Me.CheckedListBox1.Items.Count - 1

            'For Each Chek As CheckedListBox.CheckedItems In Me.CheckedListBox1.Items
            'If CheckState.Checked = True Then


            'إظهار ثمانية أزرار فقط
            If i < 9 Then


                Dim btn As New Button
                btn.Name = "Mainbutton" & i
                'CheckedListBox1.SelectedIndex = i
                btn.Text = item.ToString
                btn.FlatStyle = FlatStyle.Flat
                btn.TextAlign = ContentAlignment.MiddleLeft
                '   btn.ImageAlign = ContentAlignment.MiddleRight
                btn.Size = New System.Drawing.Size(h1, 69)
                Botonhight += 72 'btn.Height
                btn.Location = New System.Drawing.Point(5, Botonhight)
                'btn.Text = mosmiat(k)
                ''  btn.Visible = False

                If (i Mod 2 = 0) Then
                    btn.BackColor = System.Drawing.Color.Snow

                Else
                    btn.BackColor = System.Drawing.Color.LightYellow

                End If

                btn.ForeColor = System.Drawing.Color.Blue

                'AddHandler CType(btn, Button).MouseHover, AddressOf btn_foucxed
                'listOfbuttons.Add(CType(btn, Button))
                'AddHandler CType(btn, Button).MouseLeave, AddressOf btn_foucxleave
                'listOfbuttons.Add(CType(btn, Button))
                ''  assignpictureimage(btn)


                pnnl.Controls.Add(btn)
                ' btn.Refresh()
                ' changebotonpictures(btn)

                btn.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)

                '  Me.verticalpanal.Refresh()
                ' Threading.Thread.Sleep(100)
                Mainbutton_coun = i
                i += 1
                AddHandler CType(btn, Button).Click, AddressOf btn_cclick
                AddHandler CType(btn, Button).MouseMove, AddressOf MouseHover_foucxed
                AddHandler CType(btn, Button).MouseLeave, AddressOf btn_MouseLeave
                ' listOfbuttons.Add(CType(btn, Button))
            End If
        Next

        Me.Refresh()

    End Sub
    Private Sub MouseHover_foucxed(ByVal sender As Object, ByVal e As System.EventArgs)
        sender.ForeColor = System.Drawing.Color.DarkBlue
    End Sub

    Private Sub btn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        sender.ForeColor = System.Drawing.Color.Blue
    End Sub

    Dim rs As New Resizer
    Private Sub actions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        creatMainbutoons(CheckedListBox1, verticalpanal)

        'Timer1.Start()
        'Timer1.Interval = timer_interval
        '  rs.FindAllControls(Me)

    End Sub







    Private Sub btn_cclick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        clearcontrols(middlepanel)
        '        ادراج(فاتورة)
        '        المبيعات()
        '        الخزينة()
        '        التالف()
        'حركة البيع والشراء
        '        المستخدمين()
        '        الإعدادات()

        ' mysales.txtGetRecords.Visible = False
        '  Me.middlepanel.Controls.Clear()
        Select Case sender.text

            Case "ادراج فاتورة"
                '  mysales.txtGetRecords.Visible = True
                Me.middlepanel.Controls.Add(mysales)
                mysales.Panel1.Visible = True
                'توزيع الليبلات داخل panel1
                mysales.maketextboxez()
                'توزيع  المسميا على الداتا جريد
                mysales.placethelabels()

                'إستدعاء ازرار الارقام الخاصة بكتابة الارقام
                Create_Calcolater(verticalpanal)
                'إستدعاء ايقونات المعاملات
                '   Create_icon_imajes(mysales.panlformoshtriat1)
                ''إنشاء القائمة السريعة الخاصة بأزرار البحث عن الاصناف



                Me.makebutonsfor_alsareah_DLvw(mysales.panlformoshtriat1)
                'إستدعاء الداتا جريد والازرار الت تحتها
                '   creatsButtonzin_panlformoshtriat1(mysales.panlformoshtriat1)
                ' mysales.panlformoshtriat1.Controls.Add(mysales.txtGetRecords)
                mysales.txtGetRecords.Width = 30
                mysales.txtGetRecords.BackColor = Color.Yellow
                mysales.txtGetRecords.ForeColor = Color.White
                mysales.txtGetRecords.Visible = True
                mysales.txtGetRecords.Focus()

             


                ' creatsButtonzin_panlformoshtriat1(mysales.panlformoshtriat1)

                ' استدعاء دالة رسم Sale_DGV_Design
                mysales.Sale_DGV_Design()
                ' mysales.txtGetRecords.Visible = False
                actions_DGV.Visible = False

                'إستدعاء الداتا جريد والازرار الجانبية
                creatsButtonzin_panlformoshtriat1(mysales.panlformoshtriat1)
                ' typpe_Getrecords = 0
                addBarcoseToolz()

            Case "الخزينة"
                Me.middlepanel.Controls.Add(myuser)
            Case "الإعدادات"
                Me.middlepanel.Controls.Add(myssting)

            Case "خروج"
                End

            Case "المشتريات"
                Me.middlepanel.Controls.Add(mysales)

                mysales.Panel1.Visible = False




        End Select




    End Sub



    Private Sub verticalpanal_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles verticalpanal.Paint

    End Sub

    Private Sub middlepanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles middlepanel.Paint
        'Dim borderRectangle As Rectangle = middlepanel.ClientRectangle
        'Dim formGraphics As System.Drawing.Graphics
        '' formGraphics = Me.panlformoshtriat1.CreateGraphics()
        'formGraphics = middlepanel.CreateGraphics()
        'borderRectangle.Inflate(-30, -30)

        'ControlPaint.DrawBorder3D(formGraphics, New Rectangle(-2, 33, 90, 574), _
        '    Border3DStyle.Raised)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        'MsgBox(Mainbutton_coun)
        Dim arry_of_caption(Mainbutton_coun) As String

        For i As Integer = 0 To Mainbutton_coun

            arry_of_caption(i) = CType(Me.Controls.Find("Mainbutton" & i, True)(0), Button).Text
        Next

        CType(Me.Controls.Find("Mainbutton0", True)(0), Button).Text = arry_of_caption(Mainbutton_coun)
        For i As Integer = 0 To Mainbutton_coun - 1
            CType(Me.Controls.Find("Mainbutton" & i + 1, True)(0), Button).Text = arry_of_caption(i)
            'MsgBox(arry_of_caption(i - 1))
        Next

    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        'MsgBox(Mainbutton_coun)
        Dim arry_of_caption(Mainbutton_coun) As String

        For i As Integer = 0 To Mainbutton_coun

            arry_of_caption(i) = CType(Me.Controls.Find("Mainbutton" & i, True)(0), Button).Text
        Next

        CType(Me.Controls.Find("Mainbutton" & Mainbutton_coun, True)(0), Button).Text = arry_of_caption(0)
        For i As Integer = Mainbutton_coun To 1 Step -1
            CType(Me.Controls.Find("Mainbutton" & i - 1, True)(0), Button).Text = arry_of_caption(i)
            'MsgBox(arry_of_caption(i - 1))
        Next
    End Sub




    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub




    'إنشاء القائمة السريعة الخاصة بأزرار البحث عن الاصناف
    Sub makebutonsfor_alsareah(ByVal pannel As Panel)


        Draw_pannel(pannel)



        ' pannel.BackColor = Color.Black
        'الحصول على كل البيانات من داخل الداتا جريد
        Dim sqll As String = "SELECT   IDs, Item_name, Item_sale_price FROM Itemz" ' "SELECT * from Salesdataview "
        Dim Mymatrix As DataTable
        'حيث يمكن التعامل معها بسهولةcopyDataTable  يتم نسخ داتا تيبل الى 
        Mymatrix = TheDatatables(sqll)

        'DataGridView2.DataSource = copyDataTable
        Dim colIndex As Integer = 0

        'Itemzsittingهنا يتم تسمية كل الاعمدة واعطائها ليبل من داخل جدول 





        Dim shiftx As Integer = 20
        Dim shifty As Integer = 2
        Dim quintity_name As Integer = 1
        Dim rearrange As Integer = 1
        Dim thecountofrowz = Mymatrix.Rows.Count - 1


        ' For i As Integer = 0 To 50

        For j As Integer = 0 To thecountofrowz


            Dim calculater_boutton_alsareah As New Button
            calculater_boutton_alsareah.Name = LTrim(RTrim(Mymatrix.Rows(j).Item(0)))
            calculater_boutton_alsareah.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)


            'If (j Mod 2 = 0) Then
            calculater_boutton_alsareah.BackColor = System.Drawing.Color.Azure

            'Else
            '    calculater_boutton_alsareah.BackColor = System.Drawing.Color.CadetBlue

            'End If

            If quintity_name > thecountofrowz Then
                calculater_boutton_alsareah.Text = "**********"
                calculater_boutton_alsareah.Tag = "q" ' & quintity_name

            Else
                calculater_boutton_alsareah.Text = LTrim(RTrim(Mymatrix.Rows(quintity_name).Item(1))) ' & "    " & LTrim(RTrim(Mymatrix.Rows(quintity_name).Item(2)))
                calculater_boutton_alsareah.Tag = LTrim(RTrim(Mymatrix.Rows(quintity_name).Item(0)))
            End If


            calculater_boutton_alsareah.FlatStyle = FlatStyle.Standard
            calculater_boutton_alsareah.TextAlign = ContentAlignment.MiddleCenter
            calculater_boutton_alsareah.Size = New System.Drawing.Size(120, 118)




            calculater_boutton_alsareah.Location = New System.Drawing.Point(shiftx, shifty)
            shiftx += 120
            If rearrange = 3 Then
                shiftx = 50
                shifty += 121
                rearrange = 0
            End If
            'يستخدم هذا المتغير لترتيب الازرار عموديا وافقيا على اللوحة
            rearrange += 1




            '  calculater_boutton_alsareah.BackColor = SystemColors.ActiveCaption
            calculater_boutton_alsareah.ForeColor = System.Drawing.Color.Black









            pannel.Controls.Add(calculater_boutton_alsareah)

            '   AddHandler CType(calculater_boutton_alsareah, Button).Click, AddressOf calculater_boutton_alsareah_cclick
            AddHandler CType(calculater_boutton_alsareah, Button).MouseMove, AddressOf calculater_boutton_alsareah_foucxed
            AddHandler CType(calculater_boutton_alsareah, Button).MouseLeave, AddressOf calculater_boutton_alsareah_MouseLeave
            ' listOfbuttons.Add(CType(btn, Button))
            quintity_name += 1



        Next
        ' Me.Refresh()


    End Sub
    Private Sub calculater_boutton_alsareah_foucxed(ByVal sender As Object, ByVal e As System.EventArgs)
        ' sender.ForeColor = System.Drawing.Color.White

        sender.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold)
        sender.BackColor = System.Drawing.Color.LightSteelBlue

    End Sub

    Private Sub calculater_boutton_alsareah_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        ' sender.ForeColor = System.Drawing.Color.Blue
        sender.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        sender.BackColor = System.Drawing.Color.Azure
    End Sub




    'إنشاء القائمة السريعة الخاصة بأزرار البحث عن الاصناف

    Sub makebutonsfor_alsareah_DLvw(ByVal pannel As Panel)


        'خصائص لداتا جريد الاولي
        Draw_pannel(pannel)



        actions_DGV = New DataGridView

        actions_DGV.Size = New System.Drawing.Size(320, 270)
        actions_DGV.Location = New System.Drawing.Point(90, 33)

        actions_DGV.BorderStyle = Windows.Forms.BorderStyle.None
        actions_DGV.BackgroundColor = Color.White
        actions_DGV.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal
        actions_DGV.RowHeadersVisible = False
        actions_DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        actions_DGV.BackgroundColor = Color.White  'Color.Aqua '
        '  actions_DGV.BorderStyle = BorderStyle.None
        AddHandler actions_DGV.KeyDown, AddressOf actions_DGVKeyDown

        AddHandler actions_DGV.VisibleChanged, AddressOf actions_VisibleChanged
      
        '   AddHandler actions_DGV.CellEndEdit, AddressOf actions_test




        pannel.Controls.Add(actions_DGV)








    End Sub

    Private Sub actions_DGVKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)


        If e.KeyCode = Keys.Enter Then
            mysales.inflateDatagridview_formaction_DGV()
            ' mysales.txtGetRecords.Focus()
        End If


    End Sub

    

    Private Sub actions_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If mysales.txtGetRecords.Visible = False Then
        '    mysales.txtGetRecords.Visible = True
        'Else
        '    mysales.txtGetRecords.Visible = False
        'End If
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Control.IsKeyLocked(Keys.NumLock) = True Then
        '    MsgBox("okk")
        'Else
        '    MsgBox("off")

        'End If
        ' Panelforbuttonz.Size = New Size(157, 627)
        '  Create_icon_imajes(Panelforbuttonz)
    End Sub

    Private Sub Button3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtGetRecords_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        mysales.txtGetRecords.BackColor = Color.Blue
    End Sub

    Private Sub txtGetRecords_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then

        '    actions_DGV.Focus()


        'End If

        'If e.KeyCode = Keys.F2 Then

        '    Create_Calcolater(verticalpanal)




        'End If
        'inflateDatagridview_formaction_DGV()


        '    ' MsgBox("enter")
        '    CType(Me.Controls.Find("myDatagridview", True)(0), DataGridView).CurrentCell(1, 0)
        '    'CType(Me.Controls.Find("Mainbutton0", True)(0), Button).Text = arry_of_caption(Mainbutton_coun)
        ''For i As Integer = 0 To Mainbutton_coun - 1
        ''    CType(Me.Controls.Find("Mainbutton" & i + 1, True)(0), Button).Text = arry_of_caption(i)
        ''    'MsgBox(arry_of_caption(i - 1))
        '    'Next

        '    Me.dataGridView1.CurrentCell = Me.dataGridView1(1, 0)
        ''myDatagridview
    End Sub


    Private Sub txtGetRecords_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        mysales.txtGetRecords.BackColor = Color.Black
    End Sub
    Private Sub txtGetRecords_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)



        'Try
        '    'If Control.IsKeyLocked(Keys.NumLock) = True Then
        '    '    Sales_DGV.Rows(Sales_DGV.Rows.Count - 1).Cells("Item_QTY").Value() = txtGetRecords.Text
        '    'Else

        '    PicBarCode.BackgroundImage = Code128(txtGetRecords.Text, "A")

        '    makebutonsfor_alsareah_DLvw(verticalpanal)
        '    'End If
        'Catch ex As Exception

        'End Try





        'If e.KeyCode = Keys.F2 Then
        '    searchkod = "F2"
        '    Searchitems.Show()
        'End If


        'If e.Modifiers = Keys.Control And e.KeyCode = Keys.I Then
        '    Dim mesa As String = MsgBox("Are you sure you want to add Trenier information ", MsgBoxStyle.YesNo, "add Trenier information")
        '    If mesa = MsgBoxResult.Yes Then
        '        If mesa = MsgBoxResult.Yes Then
        '            addtoactiontable()
        '        End If

        '    End If

        'For Each coll As DataGridViewColumn In DataGridView1.Columns
        '    If coll.Index > 1 Then
        '        DataGridView1.Columns(coll.Index).Visible = False
        '    End If

        'Next


        '        DataGridView myGridView = //...
        'int rowToSelect = //...
        'int columnToSelect = //...

        'DataGridViewRow selectedRow = myGridView.Rows[rowToSelect];
        'selectedRow.Selected = true;
        '        selectedRow.Cells([columnToSelect].Selected = True)



    End Sub



    ''هنا تكوين ايقونات من نوع صورة والحاقها بالبانل Panelforbuttonz
    'Sub Create_icon_imajes(ByVal pannel As Panel)

    '    Draw_pannel(pannel)

    '    ' Panelforbuttonz.Controls.Clear()
    '    'الحصول على كل البيانات من داخل الداتا جريد
    '    Dim sqll As String = "SELECT   Icon_id, Icon_name, Icon_Caption, function_name, Icon_order, Activity_type, section_ID  FROM  My_aplication_Icons WHERE     (function_name = N'Create_icon_imajes') AND (Activity_type = N'غذائية') ORDER BY Icon_order" ' "SELECT * from Salesdataview "
    '    Dim Mymatrix As DataTable
    '    'حيث يمكن التعامل معها بسهولةcopyDataTable  يتم نسخ داتا تيبل الى 
    '    Mymatrix = TheDatatables(sqll)
    '    Dim ccount = Mymatrix.Rows.Count - 1
    '    Dim shift_Y = -8
    '    For d As Integer = 0 To ccount








    '        Dim oCurrentPictureBox As New Label
    '        oCurrentPictureBox.Name = LTrim(RTrim(Mymatrix.Rows(d).Item("Icon_id")))
    '        oCurrentPictureBox.Tag = LTrim(RTrim(Mymatrix.Rows(d).Item("Icon_name")))

    '        oCurrentPictureBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
    '        oCurrentPictureBox.Text = LTrim(RTrim(Mymatrix.Rows(d).Item("Icon_Caption")))
    '        oCurrentPictureBox.TextAlign = ContentAlignment.BottomCenter
    '        oCurrentPictureBox.ForeColor = Me.BackColor ' Color.Transparent
    '        ' oCurrentPictureBox = New Label
    '        Dim picturenam As String = LTrim(RTrim(Mymatrix.Rows(d).Item("Icon_name")))
    '        oCurrentPictureBox.Image = Image.FromFile("D:\Trade\Trade\myicons\" & picturenam)
    '        oCurrentPictureBox.Location = New Point(22, shift_Y)
    '        oCurrentPictureBox.Size = New Size(65, 90) '44, 36   Me.PointToClient(Windows.Forms.Cursor.Position)
    '        '  oCurrentPictureBox.Size = AutoSize
    '        ' oCurrentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
    '        Dim tooltip1 As System.Windows.Forms.ToolTip = New System.Windows.Forms.ToolTip()

    '        tooltip1.SetToolTip(oCurrentPictureBox, LTrim(RTrim(Mymatrix.Rows(d).Item("Icon_Caption"))))
    '        ' Add events to the new picturebox we just created so that it can be moved again later
    '        AddHandler oCurrentPictureBox.Click, AddressOf oCurrentPictureBox_Click
    '        AddHandler oCurrentPictureBox.MouseMove, AddressOf oCurrentPictureBox_MouseMove
    '        AddHandler oCurrentPictureBox.MouseLeave, AddressOf oCurrentPictureBox_Leave

    '        ' Add picturebox to form
    '        pannel.Controls.Add(oCurrentPictureBox)

    '        ' Bring picturebox to front after it has been added to the form to ensure it is on top of all other controls in the controls collection
    '        oCurrentPictureBox.BringToFront()
    '        shift_Y += 83
    '    Next
    'End Sub


    ''حدث النقر على  الازرار الجانبية الخاصة بالبانلPanelforbuttonz
    'Private Sub oCurrentPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Select Case sender.text
    '        Case "العدد"
    '            Try
    '                ' Sales_DGV.Rows.Remove(Sales_DGV.CurrentRow)
    '                Create_Calcolater(verticalpanal)
    '            Catch ex As Exception
    '                MsgBox("لاتوجد بضاعة")
    '            End Try

    '        Case "باركود"
    '            mysales.txtGetRecords.Focus()
    '            Create_Calcolater(verticalpanal)

    '        Case "إدراج صنف"
    '            ' Me.middlepanel.Controls.Add(mysales)
    '            mysales.panlformoshtriat1.Visible = True
    '            '/هنا يتم اضافة مجموعة من الاصناف اثناء البيع 
    '            '/وقد يتم تصحيح هذه البيانات لاحقا فى شاشة المشتريات
    '            mysales.add_short_items()
    '            mysales.txtGetRecords.Visible = False

    '    End Select
    'End Sub

    ''حدث مرور مؤشر الفأرة على الزر
    'Private Sub oCurrentPictureBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    Dim paath1 As String = "D:\Trade\Trade\myicons\Big\"
    '    sender.Image = Image.FromFile(paath1 & sender.tag)

    '    'sender.ForeColor = Color.Blue
    'End Sub

    'Private Sub oCurrentPictureBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim paath2 As String = "D:\Trade\Trade\myicons\"
    '    sender.Image = Image.FromFile(paath2 & sender.tag)
    '    ' sender.ForeColor = Color.Transparent
    'End Sub

    Private Sub Panelforbuttonz_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'SET THE GRAPHICS OBJECT IN THE FORM
        Dim grafx As Graphics = CreateGraphics()

        'SET AND DETERMINE THE SIZE,FONT AND TEXT.
        Dim fnt As New Font("Segoe UI", 40, _
            FontStyle.Regular, GraphicsUnit.Point)
        Dim start_text As String = "Text Animation + test2" 'APPEAR THE TEXT IN THE FIRST LOAD
        Dim fnt_size As New SizeF(grafx.MeasureString(start_text, fnt))

        'SET THE TEXT THAT TO BE CENTERED IN THE CLIENT AREA.
        Dim ptf_text_start As New PointF( _
            CSng(ClientSize.Width - fnt_size.Width) / 2, _
           CSng(ClientSize.Height - fnt_size.Height) / 2)


        'FOR THE ANIMATION EFFECT, SET THE GRADIENT START AND ITS END POINT.
        Dim ptf_gradient_start As New PointF(0, 0)
        Dim ptf_gradient_end As New PointF(current_gradient_shift, 130)


        'USE THE BRUSH FOR DRAWING THE TEXT.
        Dim gradient_brush As New LinearGradientBrush(ptf_gradient_start, _
            ptf_gradient_end, Color.Crimson, BackColor)

        'THE TEXT DRAW AT THE CENTERED OF THE CLIENT AREA.
        grafx.DrawString(start_text, fnt, gradient_brush, ptf_text_start)
        grafx.Dispose()

        'REVERSING THE GRADIENT WHEN IT GETS TO A CERTAIN VALUE
        current_gradient_shift += gradiant_step
        If current_gradient_shift = 500 Then
            gradiant_step = -5
        ElseIf current_gradient_shift = -50 Then
            gradiant_step = 5
        End If
    End Sub

    Private Sub mycomments_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mycomments.KeyDown

    End Sub

    Private Sub mycomments_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mycomments.TextChanged

    End Sub

    Private Sub actions_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        ' rs.ResizeAllControls(Me)
    End Sub
End Class
