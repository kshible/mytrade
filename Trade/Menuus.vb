Module Menuus
    '******************************************************************************************************************************
    'هنا تكوين ايقونات من نوع صورة والحاقها بالبانل Panelforbuttonz====>تم استبدالها ببانل اخري

    'الحصول على اسم الزر
    Public GetbuttonName As String = ""

    Sub Create_icon_imajes(ByVal pannel As Panel)

        'Draw_pannel(pannel)

        '' Panelforbuttonz.Controls.Clear()
        ''الحصول على كل البيانات من داخل الداتا جريد
        'Dim sqll As String = "SELECT   Icon_id, Icon_name, Icon_Caption, function_name, Icon_order, Activity_type, section_ID  FROM  My_aplication_Icons WHERE     (function_name = N'Create_icon_imajes') AND (Activity_type = N'غذائية') ORDER BY Icon_order" ' "SELECT * from Salesdataview "
        'Dim Mymatrix As DataTable
        ''حيث يمكن التعامل معها بسهولةcopyDataTable  يتم نسخ داتا تيبل الى 
        'Mymatrix = TheDatatables(sqll)
        'Dim ccount = Mymatrix.Rows.Count - 1
        'Dim shift_Y = -8
        'For d As Integer = 0 To ccount








        '    Dim oCurrentPictureBox As New Label
        '    oCurrentPictureBox.Name = LTrim(RTrim(Mymatrix.Rows(d).Item("Icon_id")))
        '    oCurrentPictureBox.Tag = LTrim(RTrim(Mymatrix.Rows(d).Item("Icon_name")))

        '    oCurrentPictureBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        '    oCurrentPictureBox.Text = LTrim(RTrim(Mymatrix.Rows(d).Item("Icon_Caption")))
        '    oCurrentPictureBox.TextAlign = ContentAlignment.BottomCenter
        '    oCurrentPictureBox.ForeColor = pannel.BackColor ' Color.Transparent
        '    ' oCurrentPictureBox = New Label
        '    Dim picturenam As String = LTrim(RTrim(Mymatrix.Rows(d).Item("Icon_name")))
        '    oCurrentPictureBox.Image = Image.FromFile("D:\Trade\Trade\myicons\" & picturenam)
        '    oCurrentPictureBox.Location = New Point(22, shift_Y)
        '    oCurrentPictureBox.Size = New Size(65, 90) '44, 36   Me.PointToClient(Windows.Forms.Cursor.Position)
        '    '  oCurrentPictureBox.Size = AutoSize
        '    ' oCurrentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        '    Dim tooltip1 As System.Windows.Forms.ToolTip = New System.Windows.Forms.ToolTip()

        '    tooltip1.SetToolTip(oCurrentPictureBox, LTrim(RTrim(Mymatrix.Rows(d).Item("Icon_Caption"))))
        '    ' Add events to the new picturebox we just created so that it can be moved again later
        '    AddHandler oCurrentPictureBox.Click, AddressOf oCurrentPictureBox_Click
        '    AddHandler oCurrentPictureBox.MouseMove, AddressOf oCurrentPictureBox_MouseMove
        '    AddHandler oCurrentPictureBox.MouseLeave, AddressOf oCurrentPictureBox_Leave

        '    ' Add picturebox to form
        '    pannel.Controls.Add(oCurrentPictureBox)

        '    ' Bring picturebox to front after it has been added to the form to ensure it is on top of all other controls in the controls collection
        '    oCurrentPictureBox.BringToFront()
        '    shift_Y += 83
        'Next





        Draw_pannel(pannel)



        ' pannel.BackColor = Color.Black
        'الحصول على كل البيانات من داخل الداتا جريد
        Dim sqll As String = "SELECT   IDs,Item_name, Item_sale_price FROM Itemz" ' "SELECT * from Salesdataview "
        Dim Mymatrix As DataTable
        'حيث يمكن التعامل معها بسهولةcopyDataTable  يتم نسخ داتا تيبل الى 
        Mymatrix = TheDatatables(sqll)

        'DataGridView2.DataSource = copyDataTable
        Dim colIndex As Integer = 0

        'Itemzsittingهنا يتم تسمية كل الاعمدة واعطائها ليبل من داخل جدول 





        Dim shiftx As Integer = 89
        Dim shifty As Integer = 2
        Dim quintity_name As Integer = 1
        Dim rearrange As Integer = 1
        Dim thecountofrowz = Mymatrix.Rows.Count - 1


      
        For j As Integer = 1 To 18 ' thecountofrowz - 1

            Dim oCurrentPictureBox As New Button
            oCurrentPictureBox.Name = "Dalel_Asnaf" & j ' LTrim(RTrim(Mymatrix.Rows(j).Item(0)))
            oCurrentPictureBox.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold)

            oCurrentPictureBox.TextAlign = ContentAlignment.BottomCenter
            oCurrentPictureBox.ImageAlign = ContentAlignment.TopCenter

            'If (j Mod 2 = 0) Then


            'Else
            '    oCurrentPictureBox.BackColor = System.Drawing.Color.CadetBlue

            'End If

            'If quintity_name > thecountofrowz Then
            oCurrentPictureBox.Text = "صنف " & j
            oCurrentPictureBox.Tag = j ' LTrim(RTrim(Mymatrix.Rows(quintity_name).Item(0)))

            'Else
            '    oCurrentPictureBox.Text = LTrim(RTrim(Mymatrix.Rows(quintity_name).Item(1))) ' & "    " & LTrim(RTrim(Mymatrix.Rows(quintity_name).Item(2)))
            '    oCurrentPictureBox.Tag = LTrim(RTrim(Mymatrix.Rows(quintity_name).Item(0)))
            'End If


            oCurrentPictureBox.FlatStyle = FlatStyle.Standard
            oCurrentPictureBox.TextAlign = ContentAlignment.MiddleCenter
            oCurrentPictureBox.Size = New System.Drawing.Size(109, 100)




            oCurrentPictureBox.Location = New System.Drawing.Point(shiftx, shifty)
            shiftx += 110
            If rearrange = 3 Then
                shiftx = 89
                shifty += 101
                rearrange = 0
            End If
            'يستخدم هذا المتغير لترتيب الازرار عموديا وافقيا على اللوحة
            rearrange += 1




            '  calculater_boutton_alsareah.BackColor = SystemColors.ActiveCaption
            ' oCurrentPictureBox.ForeColor = System.Drawing.Color.Black

            oCurrentPictureBox.BackColor = System.Drawing.Color.White
            oCurrentPictureBox.ForeColor = System.Drawing.Color.Blue







            pannel.Controls.Add(oCurrentPictureBox)
            AddHandler oCurrentPictureBox.Click, AddressOf oCurrentPictureBox_Click

            AddHandler oCurrentPictureBox.MouseMove, AddressOf oCurrentPictureBox_MouseMove
            AddHandler oCurrentPictureBox.MouseLeave, AddressOf oCurrentPictureBox_Leave
            AddHandler oCurrentPictureBox.MouseDown, AddressOf oCurrentPictureBox_MouseDown

            quintity_name += 1



        Next

        'تحميل الصور والمعلومات من الجدول   Buttonclaccezعبر الكلاس  menue_ID
        Dim reading As New Buttonclaccez
        reading.rad_forward(mysales.panlformoshtriat1)

        x_Dalel_Asnaf = 19
    End Sub


    'حدث النقر على  الازرار الجانبية الخاصة بالبانلPanelforbuttonz
    Private Sub oCurrentPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MsgBox(sender.text)


        'Select Case sender.text
        '    Case "العدد"
        '        Try
        '            ' Sales_DGV.Rows.Remove(Sales_DGV.CurrentRow)
        '            Create_Calcolater(actions.verticalpanal)
        '        Catch ex As Exception
        '            MsgBox("لاتوجد بضاعة")
        '        End Try

        '    Case "باركود"
        '        mysales.txtGetRecords.Focus()
        '        Create_Calcolater(actions.verticalpanal)

        '    Case "إدراج صنف"
        '        ' Me.middlepanel.Controls.Add(mysales)
        '        mysales.panlformoshtriat1.Visible = True
        '        '/هنا يتم اضافة مجموعة من الاصناف اثناء البيع 
        '        '/وقد يتم تصحيح هذه البيانات لاحقا فى شاشة المشتريات
        '        mysales.add_short_items()
        '        mysales.txtGetRecords.Visible = False

        'End Select

       
        Dim Result As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(sender.name, "\d+")
        Select Case Result.Value

            Case 3, 21, 39, 57, 75

                If x_Dalel_Asnaf >= 90 Then
                    x_Dalel_Asnaf = 73
                End If


                Dim reading As New Buttonclaccez
                reading.rad_forward(mysales.panlformoshtriat1)
                mysales.panlformoshtriat1.Refresh()

               

            Case 18, 36, 54, 72, 90

                If x_Dalel_Asnaf < 20 Then
                    x_Dalel_Asnaf = 1
                Else
                    x_Dalel_Asnaf -= 18 * 2
                End If
                Dim reading As New Buttonclaccez
                reading.rad_forward(mysales.panlformoshtriat1)
                mysales.panlformoshtriat1.Refresh()

            Case Else
                If CInt(sender.tag) = -1 Then

                    Fbuttons.ShowDialog()
                Else

                    'actions_DGV.Visible = True
                    'actions_DGV.Refresh()
                    mysales.txtGetRecords.ResetText()
                    'mysales.txtGetRecords.Visible = True
                    typpe_Getrecords = 4
                    mysales.txtGetRecords.Text = CInt(sender.tag)


                    ' Dim sqll As String = "SELECT top 1 * FROM  Salesdataview  WHERE  ids =  " & CInt(txtGetRecords.Text) & ""
                    '   Dim sqll As String = " SELECT * FROM  Salesdataview  WHERE   ids = " & txtGetRecords.Text & ""


                    'txtGetRecords.ResetText()
                    '                   actions_DGV.Visible = True
                    '                   typpe_Getrecords = 4
                    '                   txtGetRecords.Text = 111


                    '' Dim sqll As String = "SELECT top 1 * FROM  Salesdataview  WHERE  ids =  " & CInt(txtGetRecords.Text) & ""
                    'Dim sqll As String = " SELECT * FROM  Salesdataview  WHERE   ids = " & CInt(sender.tag) & ""

                    'Dim Mymatrix As DataTable
                    ''حيث يمكن التعامل معها بسهولةcopyDataTable  يتم نسخ داتا تيبل الى 
                    'Mymatrix = TheDatatables(sqll)


                    'With actions_DGV
                    '    .RowsDefaultCellStyle.BackColor = Color.White
                    '    .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                    '    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    '    .AllowUserToResizeColumns = True
                    '    .AllowUserToAddRows = False
                    '    .Visible = True
                    '    .Refresh()
                    'End With
                    'actions_DGV.DataSource = Mymatrix
                    ''actions_DGV.Visible = True
                    'MsgBox(actions_DGV.RowCount)
                    'MsgBox(sender.tag)



                    actions_DGV.Refresh()

                End If


        End Select


        '  MsgBox("wwwwwwwwwwwww" & mysales.txtGetRecords.Text)

    End Sub


    'النقر بزر الماوس الايمن على دليل الاصناف
    Private Sub oCurrentPictureBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim Result As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(sender.name, "\d+")

        If Result.Value <> 3 And Result.Value <> 21 And Result.Value <> 39 And Result.Value <> 57 And Result.Value <> 75 And Result.Value <> 18 And Result.Value <> 36 And Result.Value <> 54 And Result.Value <> 72 And Result.Value <> 90 Then
            If e.Button = MouseButtons.Right Then
                Buttonsetting.Txt_button.Text = sender.text
                Buttonsetting.txt_name.Text = sender.name
                Buttonsetting.ComboBox2.Text = sender.text
                Buttonsetting.ShowDialog()
            End If
        End If

    End Sub



    'حدث مرور مؤشر الفأرة على الزر
    Private Sub oCurrentPictureBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        'Dim paath1 As String = "D:\Trade\Trade\myicons\Big\"
        'sender.Image = Image.FromFile(paath1 & sender.tag)
        sender.BackColor = System.Drawing.Color.Black
        sender.ForeColor = Color.White
        sender.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold)

    End Sub

    Private Sub oCurrentPictureBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        'Dim paath2 As String = "D:\Trade\Trade\myicons\"
        'sender.Image = Image.FromFile(paath2 & sender.tag)
        ' sender.ForeColor = Color.Transparent
      
        sender.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold)

        sender.BackColor = System.Drawing.Color.White
        sender.ForeColor = System.Drawing.Color.Black
    End Sub

    '*******************************************End***************************************************************************




    'ازرار كتابة ارقام الكميات
    Sub Create_Calcolater(ByVal pannel As Panel)
        pannel.Controls.Clear()
        pannel.Size = New System.Drawing.Size(450, 644)
        pannel.Location = New System.Drawing.Point(920, 40)
        pannel.BackColor = Color.WhiteSmoke





        Dim shiftx As Integer = 20
        Dim shifty As Integer = 3
        Dim quintity_name As Integer = 1

        For i As Integer = 0 To 3
            shiftx = 75
            For j As Integer = 0 To 2


                Dim calculater_boutton As New Button
                calculater_boutton.Name = "q" & quintity_name
                calculater_boutton.Font = New System.Drawing.Font("Times New Roman", 38.0!, System.Drawing.FontStyle.Bold)
                ' calculater_boutton.Image = Image.FromFile("D:\Trade\Trade\myicons\calculater\dimensions_add_48.png")
                calculater_boutton.TextAlign = ContentAlignment.MiddleLeft
                calculater_boutton.ImageAlign = ContentAlignment.MiddleRight
                Select Case quintity_name
                    Case 12
                        calculater_boutton.Text = "C"
                        calculater_boutton.Tag = "C"
                    Case 11
                        calculater_boutton.Text = "."
                        calculater_boutton.Tag = "."
                    Case 10

                        calculater_boutton.Text = "0"
                        calculater_boutton.Tag = "0"

                    Case 13
                        calculater_boutton.Text = "Cash"
                        calculater_boutton.Tag = "Cash"
                        calculater_boutton.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
                    Case 14
                        calculater_boutton.Text = "Shelf"
                        calculater_boutton.Tag = "Shelf"
                        calculater_boutton.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)

                    Case 16
                        calculater_boutton.Text = "الرئيسية"
                        calculater_boutton.Tag = "الرئيسية"
                        calculater_boutton.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)

                    Case 17
                        calculater_boutton.Text = "السريعة"
                        calculater_boutton.Tag = "السريعة"
                        calculater_boutton.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)


                    Case 15
                        calculater_boutton.Text = "المعاملات"
                        calculater_boutton.Tag = "المعاملات"
                        calculater_boutton.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)


                    Case Else

                        calculater_boutton.Text = quintity_name
                        calculater_boutton.Tag = quintity_name
                End Select






                calculater_boutton.FlatStyle = FlatStyle.Flat
                calculater_boutton.TextAlign = ContentAlignment.MiddleLeft

                calculater_boutton.Size = New System.Drawing.Size(120, 100)

                If (quintity_name = 13) Then
                    shifty += 30
                End If



                calculater_boutton.Location = New System.Drawing.Point(shiftx, shifty)
                shiftx += 122
                'Times New Roman, 48pt, style=Bold


                ' calculater_boutton.BackColor = SystemColors.ActiveCaption

                If quintity_name < 13 Then

                    If (quintity_name Mod 2 = 0) Then
                        calculater_boutton.BackColor = System.Drawing.Color.Snow

                    Else
                        calculater_boutton.BackColor = System.Drawing.Color.White

                    End If

                Else
                    calculater_boutton.BackColor = System.Drawing.Color.LightYellow
                End If
                calculater_boutton.ForeColor = System.Drawing.Color.Blue









                pannel.Controls.Add(calculater_boutton)

                AddHandler CType(calculater_boutton, Button).Click, AddressOf calculater_boutton_cclick
                AddHandler CType(calculater_boutton, Button).MouseMove, AddressOf calculater_boutton_foucxed
                AddHandler CType(calculater_boutton, Button).MouseLeave, AddressOf calculater_boutton_MouseLeave
                ' listOfbuttons.Add(CType(btn, Button))
                quintity_name += 1
            Next
            shifty += 102
        Next






        'إضافة إيقونات من نوع صورة 
        '   Dim sqll As String = "SELECT   Icon_id, Icon_name, Icon_Caption, function_name, Icon_order, Activity_type, section_ID  FROM  My_aplication_Icons WHERE     (function_name = N'Create_icon_imajes') AND (Activity_type = N'غذائية') ORDER BY Icon_order" ' "SELECT * from Salesdataview "
        Dim sqll As String = "SELECT   Icon_id, Icon_name, Icon_Caption, function_name, Icon_order, Activity_type, section_ID  FROM  My_aplication_Icons WHERE     (function_name = N'Create_icon_imajes') AND (Activity_type = N'غذائية') ORDER BY Icon_order" ' "SELECT * from Salesdataview "
        shifty += 10
        'حيث يمكن التعامل معها بسهولةcopyDataTable  يتم نسخ داتا تيبل الى 

        Dim Mymatrix As DataTable
        Mymatrix = TheDatatables(sqll)
        ' MsgBox(Mymatrix.Rows.Count - 1)
        Dim d As Integer = 0
        For i As Integer = 0 To 1
            shiftx = 77
            For j As Integer = 0 To 2
                Dim UnderCalcolater_Icons As New Button
                UnderCalcolater_Icons.Name = LTrim(RTrim(Mymatrix.Rows(d).Item("Icon_id")))
                UnderCalcolater_Icons.Tag = LTrim(RTrim(Mymatrix.Rows(d).Item("Icon_Caption")))

                UnderCalcolater_Icons.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
                UnderCalcolater_Icons.Text = LTrim(RTrim(Mymatrix.Rows(d).Item("Icon_Caption")))
                UnderCalcolater_Icons.TextAlign = ContentAlignment.BottomCenter
                UnderCalcolater_Icons.ForeColor = Color.Black ' Color.Transparent
                UnderCalcolater_Icons.BackColor = Color.WhiteSmoke

                ' oCurrentPictureBox = New Label
                Dim picturenam As String = LTrim(RTrim(Mymatrix.Rows(d).Item("Icon_name")))
                UnderCalcolater_Icons.Image = Image.FromFile("D:\Trade\Trade\myicons\" & picturenam)
                UnderCalcolater_Icons.Location = New Point(shiftx, shifty)
                UnderCalcolater_Icons.Size = New Size(118, 90) '44, 36   Me.PointToClient(Windows.Forms.Cursor.Position)
                '  oCurrentPictureBox.Size = AutoSize
                ' oCurrentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                Dim tooltip1 As System.Windows.Forms.ToolTip = New System.Windows.Forms.ToolTip()

                ' tooltip1.SetToolTip(UnderCalcolater_Icons, LTrim(RTrim(Mymatrix.Rows(d).Item("Icon_Caption"))))
                ' Add events to the new picturebox we just created so that it can be moved again later
                AddHandler UnderCalcolater_Icons.Click, AddressOf UnderCalcolater_Icons_Click
                AddHandler UnderCalcolater_Icons.MouseMove, AddressOf UnderCalcolater_Icons_MouseMove
                AddHandler UnderCalcolater_Icons.MouseLeave, AddressOf UnderCalcolater_Icons_Leave

                ' Add picturebox to form
                pannel.Controls.Add(UnderCalcolater_Icons)

                ' Bring picturebox to front after it has been added to the form to ensure it is on top of all other controls in the controls collection
                UnderCalcolater_Icons.BringToFront()
                d += 1
                shiftx += 122
            Next
            shifty += 102
        Next

        pannel.Refresh()
    End Sub
    Private Sub calculater_boutton_foucxed(ByVal sender As Object, ByVal e As System.EventArgs)
        sender.ForeColor = System.Drawing.Color.White



    End Sub

    Private Sub calculater_boutton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        sender.ForeColor = System.Drawing.Color.Blue
        ' sender.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)

    End Sub

    Private Sub calculater_boutton_cclick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Qtxt = "." Then
            Qtxt = "0."
        End If

        ' Sales_DGV.ClearSelection()
        Dim currentr As Integer = Sales_DGV.CurrentCell.RowIndex
        '  If myindix > -1 Then
        Dim mycolmn_name As String = ""

        If Quint_Price_control = 0 Then
            mycolmn_name = "Item_QTY"
        Else
            mycolmn_name = "Item_Price"
        End If


        If IsNumeric(sender.tag) Or CStr(sender.tag) = "." Then
            Qtxt = Qtxt & sender.tag
            Sales_DGV.Rows(currentr).Cells(mycolmn_name).Value = Qtxt

        End If

        If CStr(sender.tag) = "C" Then
            Qtxt = ""
            Sales_DGV.Rows(currentr).Cells(mycolmn_name).Value = Qtxt
        End If
        '  End If



        mysales.txtGetRecords.Focus()
        ' mysales.txtGetRecords.ResetText()


    End Sub
    '******************************************************************************************************



    'حدث مرور مؤشر الفأرة على الزر
    Private Sub UnderCalcolater_Icons_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        'If sender.tag <> "معاملات" Then
        '    Dim paath1 As String = "D:\Trade\Trade\myicons\Big\"
        '    sender.Image = Image.FromFile(paath1 & sender.tag)
        'End If
        'تشكيل تبديل الالوان الخاصة بالازرار
        'If sender.tag < 2 Then

        '    sender.BackColor = System.Drawing.Color.Black
        '    sender.ForeColor = System.Drawing.Color.WhiteSmoke

        'Else
        sender.BackColor = System.Drawing.Color.LightSteelBlue
        sender.ForeColor = System.Drawing.Color.DarkBlue

        'End If


        'sender.ForeColor = Color.Blue
    End Sub

    Private Sub UnderCalcolater_Icons_Leave(ByVal sender As Object, ByVal e As System.EventArgs)

        'If sender.tag <> "معاملات" Then
        '    Dim paath2 As String = "D:\Trade\Trade\myicons\"
        '    sender.Image = Image.FromFile(paath2 & sender.tag)
        '    ' sender.ForeColor = Color.Transparent
        'End If
        sender.BackColor = System.Drawing.Color.WhiteSmoke
        sender.ForeColor = System.Drawing.Color.Black
    End Sub
    Private Sub UnderCalcolater_Icons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim Mymatrix As DataTable
 
        'إضافة إيقونات من نوع صورة 
        '   Dim sqll As String = "SELECT   Icon_id, Icon_name, Icon_Caption, function_name, Icon_order, Activity_type, section_ID  FROM  My_aplication_Icons WHERE     (function_name = N'Create_icon_imajes') AND (Activity_type = N'غذائية') ORDER BY Icon_order" ' "SELECT * from Salesdataview "
        Dim sqll As String = "SELECT   Icon_id, Icon_name, Icon_Caption, function_name, Icon_order, Activity_type, section_ID  FROM  My_aplication_Icons WHERE     (function_name = N'Create_icon_imajes') AND (Activity_type = N'غذائية') ORDER BY Icon_order" ' "SELECT * from Salesdataview "

        'حيث يمكن التعامل معها بسهولةcopyDataTable  يتم نسخ داتا تيبل الى 


        Mymatrix = TheDatatables(sqll)

     



        Select Case sender.tag
            
            Case "الرئيسية"
                actions.middlepanel.Controls.Clear()
                actions.creatMainbutoons(actions.CheckedListBox1, actions.verticalpanal)
                actions.Refresh()
            Case "دليل الاصناف"
                '********************************جملة Case متداخلة لتبديل القوائم*******************************************

                Manue_Counter += 1
                If Manue_Counter > 2 Then
                    Manue_Counter = 1
                End If
                Select Case Manue_Counter
                    Case 1
                        '  Create_icon_imajes(mysales.panlformoshtriat1)
                        creatsButtonzin_panlformoshtriat1(mysales.panlformoshtriat1)
                        addBarcoseToolz()
                        Dim picturenam As String = LTrim(RTrim(Mymatrix.Rows(4).Item("Icon_name")))
                        sender.Image = Image.FromFile("D:\Trade\Trade\myicons\catalog_fav_64.png")
                        sender.text = "دليل الاصناف"
                        'Case 2
                        '    'reference
                        '    'creatsButtonzin_panlformoshtriat1(mysales.panlformoshtriat1)
                        '    'Dim picturenam As String = LTrim(RTrim(Mymatrix.Rows(3).Item("Icon_name")))
                        '    'sender.Image = Image.FromFile("D:\Trade\Trade\myicons\market_segmentation_search_64.png")
                        '    ''  actions.makebutonsfor_alsareah(mysales.panlformoshtriat1)
                        typpe_Getrecords = 0
                    Case 2

                        creatsButtonzin_panlformoshtriat1(mysales.panlformoshtriat1)
                        Create_icon_imajes(mysales.panlformoshtriat1)
                        Dim picturenam As String = LTrim(RTrim(Mymatrix.Rows(5).Item("Icon_name")))
                        sender.Image = Image.FromFile("D:\Trade\Trade\myicons\dss_search_64.png")
                        actions.makebutonsfor_alsareah_DLvw(mysales.panlformoshtriat1)

                        sender.text = "معاملات"
                End Select

                sender.BringToFront()
                '*************************************************************************************************************

            Case "القائمة السريعة"
                '  Create_icon_imajes(mysales.panlformoshtriat1)
                FBasketButoons.ShowDialog()
                '  sender.text = "ورقة الاصناف"

            Case "تغيير سعر"

                If sender.text = "تغيير سعر" Then
                    sender.text = "تغيير كمية"
                    Quint_Price_control = 1
                Else
                    sender.text = "تغيير سعر"
                    Quint_Price_control = 0
                End If
            Case "إدراج صنف"
                mysales.panlformoshtriat1.Controls.Clear()
                mysales.add_short_items()
            Case "معاملة جديدة"
                'actions.makebutonsfor_alsareah_DLvw(mysales.panlformoshtriat1)
                'mysales.panlformoshtriat1.Controls.Add(mysales.txtGetRecords)
                'mysales.txtGetRecords.Dock = DockStyle.Top
                'mysales.txtGetRecords.BackColor = Color.Blue
                'mysales.txtGetRecords.ForeColor = Color.White
                'mysales.txtGetRecords.Visible = True
                'mysales.txtGetRecords.Focus()
                Sales_DGV.Rows.Clear()
                For s As Integer = 1 To 1000
                    Dim item As New DataGridViewRow
                    item.CreateCells(Sales_DGV)

                    For Each GridCol As DataGridViewColumn In Sales_DGV.Columns

                        With item
                            '  ' هنا التطابق مع اسماء الأعمدة واسماء البوكسات

                            .Cells(GridCol.Index).Value = ""

                        End With

                    Next

                    Sales_DGV.Rows.Add(item)
                Next
        End Select

        mysales.txtGetRecords.Focus()
        mysales.txtGetRecords.ResetText()
        Qtxt = ""
    End Sub

    ' هذه الازرار تضاف تحت الداتا جريدactions_DGV الخاصة بتغيير طريقة البحث عن الاصناف
    'البحث حسب رقم الكود او الباركود او الاسم ..... الخ
    Sub creatsButtonzin_panlformoshtriat1(ByVal mypannel As Panel)



        mypannel.Controls.Clear()
        mypannel.BackColor = Color.White
       
       

        ' mypannel.BackColor = Color.PaleVioletRed

        'إضافة إيقونات من نوع صورة 
        '   Dim sqll As String = "SELECT   Icon_id, Icon_name, Icon_Caption, function_name, Icon_order, Activity_type, section_ID  FROM  My_aplication_Icons WHERE     (function_name = N'Create_icon_imajes') AND (Activity_type = N'غذائية') ORDER BY Icon_order" ' "SELECT * from Salesdataview "
        Dim sqll As String = "SELECT   Icon_id, Icon_name, Icon_Caption, function_name, Icon_order, Activity_type, section_ID  FROM  My_aplication_Icons WHERE     (function_name = N'inside_buttonz') AND (Activity_type = N'الكل') ORDER BY Icon_order" ' "SELECT * from Salesdataview "

        Dim Mymatrix As DataTable
        Mymatrix = TheDatatables(sqll)
        Dim shiftx As Integer = 10
        Dim shifty As Integer = 10





        For j As Integer = 0 To Mymatrix.Rows.Count - 1
            Dim panlformoshtriat_Icons As New Label
            panlformoshtriat_Icons.Name = LTrim(RTrim(Mymatrix.Rows(j).Item("Icon_name")))
            panlformoshtriat_Icons.Tag = LTrim(RTrim(Mymatrix.Rows(j).Item("Icon_Caption")))
            Dim picturenam As String = LTrim(RTrim(Mymatrix.Rows(j).Item("Icon_name")))
            panlformoshtriat_Icons.Image = Image.FromFile("D:\Trade\Trade\myicons\" & picturenam)


            panlformoshtriat_Icons.Location = New Point(shiftx, shifty)
            '  UnderCalcolater_Icons.Size = New Size(65, 90) '44, 36   Me.PointToClient(Windows.Forms.Cursor.Position)
            panlformoshtriat_Icons.Size = New Size(60, 60)
            ' oCurrentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
         

            Dim tooltip1 As System.Windows.Forms.ToolTip = New System.Windows.Forms.ToolTip()

            tooltip1.SetToolTip(panlformoshtriat_Icons, LTrim(RTrim(Mymatrix.Rows(j).Item("Icon_Caption"))))
            ' Add events to the new picturebox we just created so that it can be moved again later
            'AddHandler UnderCalcolater_Icons.Click, AddressOf UnderCalcolater_Icons_Click
            'AddHandler Xybtnz.MouseMove, AddressOf Xybtnz_MouseMove
            'AddHandler Xybtnz.MouseLeave, AddressOf Xybtnz_Leave
            AddHandler panlformoshtriat_Icons.Click, AddressOf panlformoshtriat_Icons_Click
            AddHandler panlformoshtriat_Icons.MouseMove, AddressOf panlformoshtriat_Icons_MouseMove
            AddHandler panlformoshtriat_Icons.MouseLeave, AddressOf panlformoshtriat_Icons_Leave
            ' Add picturebox to form
            mypannel.Controls.Add(panlformoshtriat_Icons)

            ' Bring picturebox to front after it has been added to the form to ensure it is on top of all other controls in the controls collection
            panlformoshtriat_Icons.BringToFront()
            shifty += 71
        Next j

        'Dim borderRectangle As Rectangle = mypannel.ClientRectangle
        'Dim formGraphics As System.Drawing.Graphics
        '' formGraphics = Me.panlformoshtriat1.CreateGraphics()
        'formGraphics = mypannel.CreateGraphics()
        'borderRectangle.Inflate(-30, -30)

        'ControlPaint.DrawBorder3D(formGraphics, New Rectangle(-2, 0, 90, 570), _
        '    Border3DStyle.Raised)




    End Sub
    Private Sub panlformoshtriat_Icons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'الازرار المتحكمة فى تحديد طريقة البحث

        'actions_DGV.Visible = True
        'Select Case sender.text

        '    Case "باركود"
        '        'فى حالة البحث باستخدام الباركود
        '        typpe_Getrecords = 0
        '        actions_DGV.Visible = False

        '    Case "صنف"
        '        'فى حالة البحث باستخدام اسم الصنف
        '        typpe_Getrecords = 1

        '    Case "سعر"
        '        'البحث بسعر البيع
        '        typpe_Getrecords = 2
        '        mysales.txtGetRecords.Focus()
        '        mysales.txtGetRecords.ResetText()
        '    Case "واصلات"
        '        'البحث برقم الواصل
        '        typpe_Getrecords = 3
        '        mysales.txtGetRecords.Focus()
        '        mysales.txtGetRecords.ResetText()
        '    Case "إلغاء"
        '        'If myindix > -1 Then

        '        'إلغاء الصف الحالى من البضاعة

        '        Sales_DGV.Rows.RemoveAt(myindix)
        '        For h As Integer = 0 To Sales_DGV.Rows.Count - 1
        '            Sales_DGV.Rows(h).Selected = False
        '        Next
        '        myindix -= 1

        '        If myindix = -1 Then
        '            myindix = 0
        '        End If
        '        Sales_DGV.Rows(myindix).Selected = True

        '    Case "Down"

        '        If myindix < Sales_DGV.Rows.Count - 1 And myindix > -1 Then
        '            Sales_DGV.Rows(myindix).Selected = False
        '            myindix += 1
        '            Sales_DGV.Rows(myindix).Selected = True
        '        End If

        '    Case "UP"


        '        If myindix > 0 Then
        '            Sales_DGV.Rows(myindix).Selected = False
        '            myindix -= 1
        '            Sales_DGV.Rows(myindix).Selected = True
        '        End If
        '    Case "Btun4"

        '        Sales_DGV.Rows.Clear()
        '        For s As Integer = 1 To 24

        '            Dim item As New DataGridViewRow
        '            item.CreateCells(Sales_DGV)

        '            For Each GridCol As DataGridViewColumn In Sales_DGV.Columns




        '                With item
        '                    '  ' هنا التطابق مع اسماء الأعمدة واسماء البوكسات

        '                    .Cells(GridCol.Index).Value = ""

        '                End With



        '            Next



        '            Sales_DGV.Rows.Add(item)
        '        Next
        'End Select

        'mysales.txtGetRecords.Focus()
        'mysales.txtGetRecords.ResetText()
        'Qtxt = ""

        ' actions_DGV.Visible = True
        'Dim borderRectangle As Rectangle = mypannel.ClientRectangle
        'Dim formGraphics As System.Drawing.Graphics
        'formGraphics = mypannel.CreateGraphics()
        'borderRectangle.Inflate(-30, -30)

        'ControlPaint.DrawBorder3D(formGraphics, New Rectangle(-2, 33, 90, 574), _
        '    Border3DStyle.Raised)

        Select Case sender.tag

            Case "اعلى"


                Try
                    Sales_DGV.ClearSelection()
                    Dim currentr As Integer = Sales_DGV.CurrentCell.RowIndex
                    Sales_DGV.CurrentCell = Sales_DGV.Rows(currentr - 1).Cells(0)
                    Sales_DGV.Rows(currentr - 1).Selected = True
                Catch ex As Exception
                    Sales_DGV.CurrentCell = Sales_DGV.Rows(0).Cells(0)
                    Sales_DGV.Rows(0).Selected = True
                End Try





                ' '' MsgBox(myindix)
                'If myindix > 0 Then
                '    Sales_DGV.Rows(myindix).Selected = False
                '    '  myindix -= 1
                '    myindix = Sales_DGV.SelectedRows(0).Index - 1
                '    Sales_DGV.Rows(myindix).Selected = True
                'End If
                Qtxt = ""
            Case "اسفل"
                '   MsgBox(myindix)
                'If myindix < Sales_DGV.Rows.Count - 1 And myindix > -1 Then
                '    Sales_DGV.Rows(myindix).Selected = False
                '    '   myindix += 1
                '    myindix = Sales_DGV.SelectedRows(0).Index + 1
                '    Sales_DGV.Rows(myindix).Selected = True


                'End If

                Try
                    Sales_DGV.ClearSelection()
                    Dim currentr As Integer = Sales_DGV.CurrentCell.RowIndex
                    Sales_DGV.CurrentCell = Sales_DGV.Rows(currentr + 1).Cells(0)
                    Sales_DGV.Rows(currentr + 1).Selected = True
                Catch ex As Exception
                    Sales_DGV.CurrentCell = Sales_DGV.Rows(Sales_DGV.RowCount - 1).Cells(0)
                    Sales_DGV.Rows(Sales_DGV.RowCount - 1).Selected = True
                End Try
                Qtxt = ""

            Case "إلغاء صنف"

                Sales_DGV.ClearSelection()
                Dim currentr As Integer = Sales_DGV.CurrentCell.RowIndex


                'For h As Integer = myindix To Sales_DGV.Rows.Count - 1
                '    Sales_DGV.Rows(h).Selected = False
                'Next
                'If myindix <> -1 Then
                '    Sales_DGV.Rows(myindix).Selected = False
                If Sales_DGV.CurrentRow.Cells("ids").Value.ToString <> "" Then
                    Sales_DGV.Rows.RemoveAt(currentr)
              
                End If

                '    myindix += 1
                '    Sales_DGV.Rows(myindix).Selected = True
                'End If

                'إلغاء الصف الحالى من البضاعة

                '  Sales_DGV.Rows.RemoveAt(myindix)


                ''myindix -= 1

                'If myindix <= -1 Then
                '    myindix = 0
                'End If
                'Sales_DGV.Rows(myindix).Selected = True
                Qtxt = ""


            Case "زيادة"


                Dim currentr As Integer = Sales_DGV.CurrentCell.RowIndex
                If Quint_Price_control = 0 Then
                    Sales_DGV.Rows(currentr).Cells("Item_QTY").Value += 1
                Else
                    Sales_DGV.Rows(currentr).Cells("Item_Price").Value += 1
                End If





                Qtxt = ""

            Case "نقصان"



                Dim currentr As Integer = Sales_DGV.CurrentCell.RowIndex
                If Quint_Price_control = 0 Then
                    Sales_DGV.Rows(currentr).Cells("Item_QTY").Value -= 1
                Else
                    Sales_DGV.Rows(currentr).Cells("Item_Price").Value -= 1
                End If



                'Quint_Price_control = 1
                Qtxt = ""
                '    Case "Btun4"

                '        Sales_DGV.Rows.Clear()
                '        For s As Integer = 1 To 24

                '            Dim item As New DataGridViewRow
                '            item.CreateCells(Sales_DGV)

                '            For Each GridCol As DataGridViewColumn In Sales_DGV.Columns




                '                With item
                '                    '  ' هنا التطابق مع اسماء الأعمدة واسماء البوكسات

                '                    .Cells(GridCol.Index).Value = ""

                '                End With



                '            Next



                '            Sales_DGV.Rows.Add(item)
                '        Next



            Case "بحث باركود"
                    'فى حالة البحث باستخدام الباركود
                    typpe_Getrecords += 1
                    actions_DGV.Visible = True
                    If typpe_Getrecords > 3 Then
                        typpe_Getrecords = 0
                        actions_DGV.Visible = False
                    End If



            Case "ترجيع صنف"
                'ترجيع مبيعات
                Payment_typs = 3

            Case "رجوع"
                FWait.Location = New Point(664, 371)
                FWait.ShowDialog()

            Case "إنتظار"
                cash_mony(8)

        End Select

    End Sub
    
    Private Sub panlformoshtriat_Icons_MouseMove(ByVal sender As Object, ByVal e As System.EventArgs)

        'MsgBox(sender.tag)

        '    'تشكيل تبديل الالوان الخاصة بالازرار
        '    If sender.tag < 2 Then

        '        sender.BackColor = System.Drawing.Color.Black
        '        sender.ForeColor = System.Drawing.Color.WhiteSmoke

        '    Else
        '        sender.BackColor = System.Drawing.Color.WhiteSmoke
        '        sender.ForeColor = System.Drawing.Color.Black

        '    End If




        Dim tooltip2 As System.Windows.Forms.ToolTip = New System.Windows.Forms.ToolTip()


        If sender.tag = "بحث باركود" Then
            Select Case typpe_Getrecords
                Case 0
                    'فى حالة البحث باستخدام الباركود
                    'sender.Image = Image.FromFile("D:\Trade\Trade\myicons\Big\serial_number_zoom_64.png")
                    '  tooltip2.SetToolTip(sender, "بحث باركود")
                    actions.mycomments.Text = "بحث باركود"
                Case (1)
                    'فى حالة البحث باستخدام اسم الصنف
                    'sender.Image = Image.FromFile("D:\Trade\Trade\myicons\Big\productfinished_zoom_64.png")
                    '  tooltip2.SetToolTip(sender, "البحث باسم الصنف")
                    actions.mycomments.Text = "البحث باسم الصنف"
                Case 2
                    'البحث بسعر البيع
                    'sender.Image = Image.FromFile("D:\Trade\Trade\myicons\Big\bill_zoom_64.png")
                    ' tooltip2.SetToolTip(sender, "البحث بسعر البيع")
                    actions.mycomments.Text = "البحث بسعر البيع"
                Case 3
                    'البحث برقم الواصل
                    'sender.Image = Image.FromFile("D:\Trade\Trade\myicons\Big\taxes_zoom_64.png")
                    '  tooltip2.SetToolTip(sender, "البحث برقم الواصل")
                    actions.mycomments.Text = "البحث برقم الواصل"
            End Select
        Else
            'الازرار الاخري
            sender.Image = Image.FromFile("D:\Trade\Trade\myicons\Big\" & sender.name)
        End If




    End Sub

    Private Sub panlformoshtriat_Icons_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        'MsgBox(sender.tag)
        'If sender.tag < 2 Then
        '    sender.BackColor = System.Drawing.Color.WhiteSmoke
        '    sender.ForeColor = System.Drawing.Color.Black

        'Else
        '    sender.BackColor = System.Drawing.Color.Black
        '    sender.ForeColor = System.Drawing.Color.WhiteSmoke
        'End If

        Dim tooltip2 As System.Windows.Forms.ToolTip = New System.Windows.Forms.ToolTip()

        If sender.tag = "بحث باركود" Then
            Select Case typpe_Getrecords
                Case 0
                    'فى حالة البحث باستخدام الباركود
                    sender.Image = Image.FromFile("D:\Trade\Trade\myicons\serial_number_zoom_64.png")
                    ' tooltip2.SetToolTip(sender, "بحث باركود")
                Case 1
                    'فى حالة البحث باستخدام اسم الصنف
                    sender.Image = Image.FromFile("D:\Trade\Trade\myicons\productfinished_zoom_64.png")
                    ' tooltip2.SetToolTip(sender, "البحث باسم الصنف")
                Case 2
                    'البحث بسعر البيع
                    sender.Image = Image.FromFile("D:\Trade\Trade\myicons\bill_zoom_64.png")
                    ' tooltip2.SetToolTip(sender, "البحث بسعر البيع")
                Case 3
                    'البحث برقم الواصل
                    sender.Image = Image.FromFile("D:\Trade\Trade\myicons\taxes_zoom_64.png")
                    ' tooltip2.SetToolTip(sender, "البحث برقم الواصل")
            End Select
        Else
            'الازرار الاخري
            sender.Image = Image.FromFile("D:\Trade\Trade\myicons\" & sender.name)
        End If

        '  sender.Image = Image.FromFile("D:\Trade\Trade\myicons\" & sender.name)


    End Sub


    Sub addBarcoseToolz()
        actions.makebutonsfor_alsareah_DLvw(mysales.panlformoshtriat1)
        mysales.panlformoshtriat1.Controls.Add(mysales.txtGetRecords)
        mysales.txtGetRecords.Size = New Size(329, 35)
        mysales.txtGetRecords.Location = New Point(90, 1)
        mysales.txtGetRecords.BackColor = Color.Black
        mysales.txtGetRecords.ForeColor = Color.Gold
        mysales.txtGetRecords.Visible = True
        mysales.txtGetRecords.Focus()



        Dim namecount As Integer = 0

        'إضافة الازرار السوداء والبيضاء






        ' ''إضافة إيقونات من نوع صورة 
        ' ''   Dim sqll As String = "SELECT   Icon_id, Icon_name, Icon_Caption, function_name, Icon_order, Activity_type, section_ID  FROM  My_aplication_Icons WHERE     (function_name = N'Create_icon_imajes') AND (Activity_type = N'غذائية') ORDER BY Icon_order" ' "SELECT * from Salesdataview "
        Dim sqll As String = "SELECT   Icon_id, Icon_name, Icon_Caption, function_name, Icon_order, Activity_type, section_ID  FROM  My_aplication_Icons WHERE     (function_name = N'Create_icon_imajes') AND (Activity_type = N'غذائية') ORDER BY Icon_order" ' "SELECT * from Salesdataview "

        'حيث يمكن التعامل معها بسهولةcopyDataTable  يتم نسخ داتا تيبل الى 
        Dim mySearchbuttonz(10) As String
        For s As Integer = 0 To 10
            mySearchbuttonz(s) = "Btun" & s
        Next
        mySearchbuttonz(0) = "طباعة واصل"
        mySearchbuttonz(1) = "طباعة فاتورة"
        mySearchbuttonz(2) = "باركود"
        mySearchbuttonz(3) = "واصلات"
        mySearchbuttonz(6) = "سعر"
        mySearchbuttonz(7) = "صنف"
        mySearchbuttonz(5) = "كاش"
        mySearchbuttonz(4) = "إستلام"
        Dim Mymatrix As DataTable
        Mymatrix = TheDatatables(sqll)
        Dim shiftx As Integer = 100
        Dim shifty As Integer = 420
        Dim d As Integer = 0
        For i As Integer = 0 To 1
            shiftx = 100


            For j As Integer = 0 To 3
                Dim BarcoseToolz As New Button
                BarcoseToolz.Name = "BTNX" & namecount   ' LTrim(RTrim(Mymatrix.Rows(d).Item("Icon_id")))
                namecount += 1

                BarcoseToolz.Tag = j ' LTrim(RTrim(Mymatrix.Rows(d).Item("Icon_name")))
                BarcoseToolz.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
                BarcoseToolz.Text = mySearchbuttonz(d) ' LTrim(RTrim(Mymatrix.Rows(d).Item("Icon_Caption")))
                BarcoseToolz.TextAlign = ContentAlignment.BottomCenter
                BarcoseToolz.ForeColor = Color.White
                BarcoseToolz.BackColor = Color.Black ' Color.Transparent
                BarcoseToolz.FlatStyle = FlatStyle.Standard
                ' oCurrentPictureBox = New Label
                ' Dim picturenam As String = LTrim(RTrim(Mymatrix.Rows(d).Item("Icon_name")))
                ' panlformoshtriat_Icons.Image = Image.FromFile("D:\Trade\Trade\myicons\" & picturenam)
                BarcoseToolz.Location = New Point(shiftx, shifty)
                BarcoseToolz.Size = New Size(70, 90) '44, 36   Me.PointToClient(Windows.Forms.Cursor.Position)
                '  oCurrentPictureBox.Size = AutoSize
                ' oCurrentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                Dim tooltip1 As System.Windows.Forms.ToolTip = New System.Windows.Forms.ToolTip()
                If j < 2 Then
                    BarcoseToolz.ForeColor = Color.Black
                    BarcoseToolz.BackColor = Color.White
                End If
                If j = 1 Then
                    shiftx += 10
                End If
                ' tooltip1.SetToolTip(panlformoshtriat_Icons, LTrim(RTrim(Mymatrix.Rows(d).Item("Icon_Caption"))))
                ' Add events to the new picturebox we just created so that it can be moved again later
                AddHandler BarcoseToolz.Click, AddressOf BarcoseToolz_Click
                AddHandler BarcoseToolz.MouseMove, AddressOf BarcoseToolz_MouseMove
                AddHandler BarcoseToolz.MouseLeave, AddressOf BarcoseToolz_Leave

                ' Add picturebox to form
                mysales.panlformoshtriat1.Controls.Add(BarcoseToolz)

                ' Bring picturebox to front after it has been added to the form to ensure it is on top of all other controls in the controls collection
                BarcoseToolz.BringToFront()
                d += 1
                shiftx += 75
            Next
            shifty += 95
        Next







        Dim Fatora As New TextBox
 


        'إضافة تكست الفاتورة
        Fatora.Name = "txtFatora"
        Fatora.Text = 102020 ' DataGridView1.Rows(j).Cells("Description").Value
        Fatora.Size = New Size(200, 30)
        Fatora.ForeColor = Color.Blue
        Fatora.BackColor = Color.White
        Fatora.Font = New Font("Times New Roman", 40, FontStyle.Regular)
        Fatora.Location = New Point(90, 370)
        Fatora.BorderStyle = BorderStyle.None

        mysales.panlformoshtriat1.Controls.Add(Fatora)

        '    e.Graphics.DrawString(txt, the_font, Brushes.Blue, rect, sf)

        'Dim borderRectangle As Rectangle = mysales.panlformoshtriat1.ClientRectangle
        'Dim formGraphics As System.Drawing.Graphics
        '' formGraphics = Me.panlformoshtriat1.CreateGraphics()
        'formGraphics = mysales.panlformoshtriat1.CreateGraphics()
        'borderRectangle.Inflate(-30, -30)

        'ControlPaint.DrawBorder3D(formGraphics, New Rectangle(-2, 0, 90, 570), _
        '    Border3DStyle.Raised)

        '' mypannel.Refresh()
        'mysales.panlformoshtriat1.Refresh()















        '' panlformoshtriat_Icons.BorderStyle = BorderStyle.FixedSingle
        'If LTrim(RTrim(Mymatrix.Rows(j).Item("Icon_Caption"))) = "كاش" Then
        '    panlformoshtriat_Icons.Location = New Point(shiftx + 270, 370)
        '    '  UnderCalcolater_Icons.Size = New Size(65, 90) '44, 36   Me.PointToClient(Windows.Forms.Cursor.Position) بحث باركود
        '    panlformoshtriat_Icons.Size = New Size(60, 60)
        'End If


        'If LTrim(RTrim(Mymatrix.Rows(j).Item("Icon_Caption"))) = "بحث باركود" Then
        '    panlformoshtriat_Icons.Location = New Point(shiftx + 270, 490)
        '    '  UnderCalcolater_Icons.Size = New Size(65, 90) '44, 36   Me.PointToClient(Windows.Forms.Cursor.Position) إلغاء معاملة
        '    panlformoshtriat_Icons.Size = New Size(60, 60)
        'End If


        'If LTrim(RTrim(Mymatrix.Rows(j).Item("Icon_Caption"))) = "إستلام" Then
        '    panlformoshtriat_Icons.Location = New Point(shiftx + 100, 370)
        '    '  UnderCalcolater_Icons.Size = New Size(65, 90) '44, 36   Me.PointToClient(Windows.Forms.Cursor.Position) إستلام
        '    panlformoshtriat_Icons.Size = New Size(60, 60)
        'End If

        'If LTrim(RTrim(Mymatrix.Rows(j).Item("Icon_Caption"))) = "إدراج صنف" Then
        '    panlformoshtriat_Icons.Location = New Point(shiftx + 100, 488)
        '    '  UnderCalcolater_Icons.Size = New Size(65, 90) '44, 36   Me.PointToClient(Windows.Forms.Cursor.Position) إستلام
        '    panlformoshtriat_Icons.Size = New Size(60, 60)
        'End If
    End Sub

    Private Sub BarcoseToolz_Leave(ByVal sender As Object, ByVal e As System.EventArgs)


        If sender.BackColor = System.Drawing.Color.LightYellow Then
            Exit Sub
        End If


        If sender.tag < 2 Then
            sender.BackColor = System.Drawing.Color.White
            sender.ForeColor = System.Drawing.Color.Black

        Else
            sender.BackColor = System.Drawing.Color.Black
            sender.ForeColor = System.Drawing.Color.White
        End If
    End Sub

    Private Sub BarcoseToolz_MouseMove(ByVal sender As Object, ByVal e As System.EventArgs)

        'If sender.BackColor = System.Drawing.Color.LightYellow Then
        '    Exit Sub
        'End If

        ''    'تشكيل تبديل الالوان الخاصة بالازرار
        'If sender.tag < 2 Then

        '    sender.BackColor = System.Drawing.Color.Black
        '    sender.ForeColor = System.Drawing.Color.White

        'Else
        '    sender.BackColor = System.Drawing.Color.White
        '    sender.ForeColor = System.Drawing.Color.Black

        'End If
    End Sub



    Private Sub BarcoseToolz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'الازرار المتحكمة فى تحديد طريقة البحث
      
        actions_DGV.Visible = True
        Select sender.text

            Case "باركود"
                'فى حالة البحث باستخدام الباركود
                typpe_Getrecords = 0
                actions_DGV.Visible = False

            Case "صنف"
                'فى حالة البحث باستخدام اسم الصنف
                typpe_Getrecords = 1

            Case "سعر"
                'البحث بسعر البيع
                typpe_Getrecords = 2
                'mysales.txtGetRecords.Focus()
                'mysales.txtGetRecords.ResetText()
            Case "واصلات"
                'البحث برقم الواصل
                typpe_Getrecords = 3
                'mysales.txtGetRecords.Focus()
                'mysales.txtGetRecords.ResetText()

            Case "إستلام"
                actions_DGV.Visible = False
                SR1.ShowDialog()
                'mysales.txt_receve.Focus()
                Exit Sub
            Case "كاش"

                cash_mony(2)


        End Select

        mysales.txtGetRecords.Focus()
        mysales.txtGetRecords.ResetText()
        Qtxt = ""

    
        If GetbuttonName <> "" Then
            CType(actions.Controls.Find(GetbuttonName, True)(0), Button).BackColor = System.Drawing.Color.White
            CType(actions.Controls.Find(GetbuttonName, True)(0), Button).ForeColor = System.Drawing.Color.Black

        End If

        If sender.BackColor = System.Drawing.Color.LightYellow Then
            sender.BackColor = System.Drawing.Color.White
            sender.ForeColor = System.Drawing.Color.Black

        Else
            sender.BackColor = System.Drawing.Color.LightYellow
            sender.ForeColor = System.Drawing.Color.Blue
            GetbuttonName = sender.name
        End If
       
        

    End Sub

    Sub cash_mony(ByVal Payment_typ As Integer)

        Qtxt = ""
        Quint_Price_control = 0
        mysales.calculatesum()


        Dim myloop As Integer = 0
        Dim myitems As Integer = 0
        Dim lojekmyloop As Boolean = True
        Do




            If (Sales_DGV.Rows(myloop).Cells("IDs").Value.ToString = "") Or (myloop = Sales_DGV.RowCount) Then
                ' Or (Sales_DGV.Rows(myloop).Cells("IDs").Value.ToString = "") Then

                lojekmyloop = False
            Else
                myitems += 1
            End If

            myloop += 1

        Loop While (lojekmyloop = True)







        Dim reseat_no As Long = GETMXXVALUES("SELECT max(Bill_No) FROM Bills")
        CType(mysales.panlformoshtriat1.Controls.Find("txtFatora", True)(0), TextBox).Text = reseat_no

        ' MsgBox(reseat_no)

        mysales.add_to_Bills_table(reseat_no, Payment_typ)

        mysales.add_to_Monyaction_table(myitems, reseat_no)
        'وضع البحث من خلال الباركود
        typpe_Getrecords = 0

        'مبيعات
        Payment_typs = 2

        Sales_DGV.Rows.Clear()
        For s As Integer = 1 To 1000
            Dim item As New DataGridViewRow
            item.CreateCells(Sales_DGV)

            For Each GridCol As DataGridViewColumn In Sales_DGV.Columns

                With item
                    '  ' هنا التطابق مع اسماء الأعمدة واسماء البوكسات
                    .Cells(GridCol.Index).Value = ""
                End With

            Next

            Sales_DGV.Rows.Add(item)
        Next

    End Sub
End Module
