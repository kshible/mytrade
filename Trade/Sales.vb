Public Class Sales

    Dim price_sum As Double = 0
   

    Sub maketextboxez()
        Dim sqll As String = "SELECT     Itemz, Description, selected_Sales  FROM dbo.Itemzsitting  WHERE     (selected_Sales = 1)"

        clearcontrols(Panel1)
        DataGridView1.DataSource = TheDatatables(sqll)



        Panel1.Size = New Size(600, 330)
        Panel1.Location = New Point(5, 90)





        Dim xshift As Integer = Panel1.Width - 500
        Dim nnewline As Integer = 60

        'خصائص لداتا جريد الثانية


        '====================================================
        'تكوين الداتا جريد الخاصة بشاشة البيع
        Sales_DGV = New DataGridView

        Sales_DGV.Size = New Size(490, 320)
        Sales_DGV.Location = New Point(5, 5)
        'Sales_DGV.BackgroundColor = Color.AliceBlue 'Me.BackColor
        'Sales_DGV.BorderStyle = BorderStyle.None
        Sales_DGV.AllowUserToAddRows = False
        ' Sales_DGV.Dock = DockStyle.Bottom

        'Sales_DGV.EnableHeadersVisualStyles = False
        'Sales_DGV.BackColor = Color.Black

        '' Sales_DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.Black

        '' Make a style to turn the Quiz Average header yellow.
        'Dim header_style As New DataGridViewCellStyle
        'header_style.BackColor = Color.DarkBlue


        'For Each GridCol As DataGridViewColumn In Sales_DGV.Columns
        '    GridCol.DefaultCellStyle.ForeColor = Color.DarkBlue
        '    GridCol.HeaderCell.Style.BackColor = Color.DarkBlue
        '    GridCol.HeaderCell.Style = header_style
        '    'GridCol.h
        'Next


        Sales_DGV.EnableHeadersVisualStyles = False
        Sales_DGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical

        Sales_DGV.BorderStyle = Windows.Forms.BorderStyle.None
        With Sales_DGV.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.MiddleCenter
            .BackColor = Color.LightGoldenrodYellow
            .ForeColor = Color.DarkBlue
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With


        Sales_DGV.ColumnHeadersHeight = 30

        Sales_DGV.BackgroundColor = Me.BackColor
        '' Set the background color for all rows and for alternating rows. 
        '' The value for alternating rows overrides the value for all rows. 
        'Sales_DGV.RowsDefaultCellStyle.BackColor = Color.LightGray
        'Sales_DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray

        '' Set the row and column header styles.
        'Sales_DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        'Sales_DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
        'Sales_DGV.RowHeadersDefaultCellStyle.BackColor = Color.Black



        Me.Panel1.Controls.Add(Sales_DGV)

        AddHandler Sales_DGV.KeyDown, AddressOf Sales_DGVKeyDown
        AddHandler Sales_DGV.Click, AddressOf Sales__Click
        AddHandler Sales_DGV.RowStateChanged, AddressOf Sales_DGV_RowStateChanged
        'AddHandler tb.DoubleClick, AddressOf tb_DoubleClick  RowStateChanged

        ''================================كود الفواتير==================


        Me.Panel1.Refresh()
        'DataGridView1.Height = Panel1.Height - nnewline
        ' ShowDataInLvw(TheDatatables(sqll), ListView1)
    End Sub
   

    Private Sub Sales_DGV_RowStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs)

     
            Qtxt = ""
        Quint_Price_control = 0
        calculatesum()
    End Sub


    Private Sub Sales_DGVKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'myindix = sender.CurrentRow.Index
        Qtxt = ""


    End Sub
    Private Sub Sales__Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'myindix = sender.CurrentRow.Index
        'Qtxt = ""
     End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(ByVal sender As Object, ByVal e As EventArgs)


    End Sub

    'هنا يتم تصميم وتشكيل شكل اداتا جريد حتي يتم تصويرها كما هو موجود بالمنظومات المعتبرة
    Sub Sale_DGV_Design()
        Panel1.Size = New Size(985, 613)
        Panel1.Location = New Point(5, 40)

        'pannel.Size = New System.Drawing.Size(280, 570)
        'pannel.Location = New System.Drawing.Point(870, 45)


        Panel1.BackColor = Color.Black





        Sales_DGV.Size = New Size(560, 570)
        Sales_DGV.Location = New Point(2, 1)

        Sales_DGV.Font = New Font("Times New Roman", 13, FontStyle.Bold)
        Sales_DGV.ForeColor = Color.Blue
        Sales_DGV.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        Sales_DGV.BackgroundColor = Color.White
        Sales_DGV.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical
        Sales_DGV.RowHeadersVisible = False
        Sales_DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'Sales_DGV.RowsDefaultCellStyle.BackColor = Color.White
        'Sales_DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow


        For s As Integer = 1 To 1000

            Dim item As New DataGridViewRow
            item.CreateCells(Sales_DGV)

            For Each GridCol As DataGridViewColumn In Sales_DGV.Columns




                With item
                    '  ' هنا التطابق مع اسماء الأعمدة واسماء البوكسات

                    .Cells(GridCol.Index).Value = ""
                    .Height = 35
                End With



            Next



            Sales_DGV.Rows.Add(item)
        Next


    End Sub

    '/هنا يتم اضافة مجموعة من الاصناف اثناء البيع 
    '/وقد يتم تصحيح هذه البيانات لاحقا فى شاشة المشتريات
    Sub add_short_items()

        'panlformoshtriat1.Controls.Clear()

        Draw_pannel(panlformoshtriat1)
       
        'panlformoshtriat1.BackColor = Color.Black
        actions_DGV.Visible = False
        Dim xshift As Integer = panlformoshtriat1.Width - 280
        Dim nnewline As Integer = 50
        For j As Integer = 0 To DataGridView1.RowCount - 2

            'يتم إستبعاد الاجمالي او رقم التسلسل من الظهور فى اللوحةpanlformoshtriat1 

            If DataGridView1.Rows(j).Cells("Itemz").Value.ToString.Trim <> "Grid_No" And DataGridView1.Rows(j).Cells("Itemz").Value.ToString.Trim <> "Eljmali" Then




                Dim tb As New TextBox
                Dim lb As New Label



                'التكسات
                tb.Name = DataGridView1.Rows(j).Cells("Itemz").Value
                tb.Text = 0 ' DataGridView1.Rows(j).Cells("Description").Value
                ' tb.Tag = dtdsset.Tables(0).Rows(i).Item(0)
                tb.Size = New Size(200, 20)
                tb.ForeColor = Color.Blue
                tb.BackColor = Color.WhiteSmoke
                tb.Font = New Font("Times New Roman", 16, FontStyle.Regular)
                tb.Location = New Point(xshift, nnewline)
                AddHandler tb.KeyDown, AddressOf tb_KeyDown
                'AddHandler tb.DoubleClick, AddressOf tb_DoubleClick
                'AddHandler lb.DoubleClick, AddressOf lb_DoubleClick
                '---------------------------------------------------------

                lb.Name = "lbl" & DataGridView1.Rows(j).Cells("Itemz").Value
                lb.Text = DataGridView1.Rows(j).Cells("Description").Value
                lb.ForeColor = Color.DarkBlue
                lb.Location = New Point(xshift + 90, nnewline - 22)
                lb.Font = New Font("Times New Roman", 14, FontStyle.Bold)


                'If j Mod 2 = 0 Then
                '    lb.ForeColor = Color.Black
                '    tb.BackColor = Color.LightYellow
                'End If

                Me.panlformoshtriat1.Controls.Add(tb)
                Me.panlformoshtriat1.Controls.Add(lb)
                xshift -= 150


                If xshift < 0 Then
                    xshift = panlformoshtriat1.Width - 280
                    nnewline += 80
                End If
            End If
        Next
        ''==================================================
        For m As Integer = 1 To 4


            Dim Bton_short_items As New Button
            Select Case m
                Case 1
                    Bton_short_items.Name = "Bton_short_Save"
                    Bton_short_items.Text = "حفظ" ' DataGridView1.Rows(j).Cells("Description").Value
                    Bton_short_items.Location = New Point(10, 20)
                Case 2
                    Bton_short_items.Name = "Bton_short_Edit"
                    Bton_short_items.Text = "تعديل" ' DataGridView1.Rows(j).Cells("Description").Value
                    Bton_short_items.Location = New Point(10, 170)

                Case 3
                    Bton_short_items.Name = "Bton_short_Delete"
                    Bton_short_items.Text = "حذف" ' DataGridView1.Rows(j).Cells("Description").Value
                    Bton_short_items.Location = New Point(10, 320)

                Case 4
                    Bton_short_items.Name = "Bton_short_Back"
                    Bton_short_items.Text = "رجوع" ' DataGridView1.Rows(j).Cells("Description").Value
                    Bton_short_items.Location = New Point(10, 470)
            End Select

            Bton_short_items.Size = New Size(60, 60) '393, 613
            Bton_short_items.ForeColor = Color.White
            Bton_short_items.BackColor = Color.Black
            AddHandler Bton_short_items.MouseMove, AddressOf Bton_short_items_MouseMove
            AddHandler Bton_short_items.MouseLeave, AddressOf Bton_short_items_Leave
            AddHandler Bton_short_items.Click, AddressOf Bton_short_items_Click
            Me.panlformoshtriat1.Controls.Add(Bton_short_items)
            'If e.KeyCode = Keys.Up Then

        Next
    End Sub

    'حدث مرور مؤشر الفأرة على الزر
    Private Sub Bton_short_items_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        sender.BackColor = System.Drawing.Color.White
        sender.ForeColor = System.Drawing.Color.Black
    End Sub

    Private Sub Bton_short_items_Leave(ByVal sender As Object, ByVal e As System.EventArgs)

        sender.BackColor = System.Drawing.Color.Black
        sender.ForeColor = System.Drawing.Color.White
    End Sub
    Private Sub Bton_short_items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
         Dim mesa As String = ""
        Select Case sender.Text
            Case "حفظ"

                mesa = MsgBox("سيتم حفظ الصنف", MsgBoxStyle.YesNo, "ملاحظة")

                If mesa = MsgBoxResult.Yes Then
                    add_to_Itemz_table()
                    MsgBox("Done")
                End If


            Case "رجوع"
                mysales.panlformoshtriat1.Controls.Clear()

                'إستدعاء الداتا جريد والازرار الجانبية
                creatsButtonzin_panlformoshtriat1(mysales.panlformoshtriat1)
                typpe_Getrecords = 1
                addBarcoseToolz()
                'فى حالة البحث باستخدام الباركود
                typpe_Getrecords = 0
                actions_DGV.Visible = False
        End Select
    End Sub
    Private Sub tb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then
        '    MsgBox(sender.tabindex)

        'End If
    End Sub

    'إدراج البيانات الى الداتا جريد 2

    'هنا أخذ البيانات من التكست بوكسات وادراجها فى الداتا جريد
    'وذلك  عندما نحتاج الى اضافة صنف غير موجود من قبل 

    Sub inflateDatagridview()

        Qtxt = ""
        Dim item As New DataGridViewRow
        item.CreateCells(Sales_DGV)


        For Each GridCol As DataGridViewColumn In Sales_DGV.Columns
            For Each ctl As Control In Me.panlformoshtriat1.Controls
                If (ctl.GetType() Is GetType(TextBox)) Then






                    With item
                        '  ' هنا التطابق مع اسماء الأعمدة واسماء البوكسات
                        .Height = 40
                        .Cells(GridCol.Index).Value = 0

                    End With



                End If
            Next

        Next





        For Each GridCol As DataGridViewColumn In Sales_DGV.Columns
            For Each ctl As Control In Me.panlformoshtriat1.Controls
                If (ctl.GetType() Is GetType(TextBox)) Then

                    If LTrim(RTrim(ctl.Name.ToString)) = LTrim(RTrim(GridCol.Name.ToString)) Then




                        With item
                            '  ' هنا التطابق مع اسماء الأعمدة واسماء البوكسات

                            .Cells(GridCol.Index).Value = ctl.Text

                        End With


                    End If
                End If
            Next

        Next



        Sales_DGV.Rows.Add(item)




    End Sub

    Private Sub Sales_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter

    End Sub

    Private Sub Sales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'MessageBox.Show(e.KeyValue)
        'If e.KeyCode = Keys.PageUp Then
        '    MessageBox.Show(e.KeyValue)
        '    MsgBox("page up")
        'End If

        'If e.KeyCode = Keys.PageDown Then
        '    MessageBox.Show(e.KeyValue)
        '    MsgBox("page Down")
        'End If


        '' The Keycode value represents the key that 
        '' triggered the event. 
        'Select Case sender

        '    ' Check for the PAGE UP and PAGE DOWN keys. 
        '    Case 33
        '        MsgBox("page up")
        '    Case 34
        '        MsgBox("page Down")
        '        ' Cancel the keystroke. 

        'End Select


    End Sub
    Dim rs As New Resizer
    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objDateTimePicker.Format = DateTimePickerFormat.Custom
        objDateTimePicker.CustomFormat = "yyyy.MM.dd"
        rs.FindAllControls(Me)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)



    End Sub
    Sub placethelabels()
        Sales_DGV.Columns.Clear()
        Sales_DGV.Rows.Clear()
        'الحصول على كل البيانات من داخل الداتا جريد
        Dim sqll As String = "SELECT     Itemz, Description, selected_Sales  FROM dbo.Itemzsitting  " ' "SELECT * from Salesdataview "
        Dim copyDataTable As DataTable
        'حيث يمكن التعامل معها بسهولةcopyDataTable  يتم نسخ داتا تيبل الى 
        copyDataTable = TheDatatables(sqll).Copy()

        'DataGridView2.DataSource = copyDataTable
        Dim colIndex As Integer = 0
        For Each row As DataRow In copyDataTable.Rows
            'Itemzsittingهنا يتم تسمية كل الاعمدة واعطائها ليبل من داخل جدول 
            Sales_DGV.Columns.Add(LTrim(RTrim(row("Itemz"))), row("Description"))
            Sales_DGV.Columns(colIndex).Width = 120
            'هنا يتم إخفاء كل عمود قيمته 0 فى جدول Itemzsitting
            'If row("selected_Sales") = 0 Then
            Sales_DGV.Columns(LTrim(RTrim(row("Itemz")))).Visible = True
            'End If
            colIndex += 1
        Next row


        'ضبط عرض الاعمدة
        For Each GridCol As DataGridViewColumn In Sales_DGV.Columns

            'If GridCol.Name = GridCol1.Name Then
            '    If Not IsDBNull(actions_DGV.SelectedCells(GridCol1.Index).Value) Then
            '        Sales_DGV.Rows(Sales_DGV.Rows.Count - 1).Cells(GridCol.Name).Value = actions_DGV.CurrentRow.Cells(GridCol1.Name).Value
            '    End If
            'End If



            If GridCol.Name = "Item_name" Then
                GridCol.Visible = True
                GridCol.Width = 335
            End If

            If GridCol.Name = "Eljmali" Then
                GridCol.Visible = True
                GridCol.Width = 55
            End If

            If GridCol.Name = "Grid_No" Then
                GridCol.Visible = True
                GridCol.Width = 40
                GridCol.DisplayIndex = 0
            End If

            If GridCol.Name = "Item_QTY" Then
                GridCol.Visible = True
                GridCol.Width = 55
            End If

            If GridCol.Name = "Item_Price" Then
                GridCol.Visible = True
                GridCol.Width = 55
            End If

        Next

        'DataGridView1.Columns(1).DisplayIndex = 6
        'DataGridView1.Columns(2).DisplayIndex = 7
        'DataGridView1.Columns(6).DisplayIndex = 1
        'DataGridView1.Columns(7).DisplayIndex = 2
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs)




    End Sub

    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)

    End Sub

    Private Sub Button2_Click_2(ByVal sender As Object, ByVal e As EventArgs)



    End Sub
   


    

    'إدراج البيانات الى الداتا جريد 2

    'هنا أخذ البيانات من الفيو Salesdataview واضافته الى الداتا جريد
    'وذلك  عندما نحتاج الى استدعاء بضاعة نريد بيعها من خلال الباركود 

    Sub pulldata_todatagrid2()
        'الحصول على كل البيانات من داخل الداتا جريد
        Dim sqll As String = "SELECT     Itemz, Description, selected_Sales  FROM dbo.Itemzsitting  " ' "SELECT * from Salesdataview "
        Dim copyDataTable As DataTable
        'حيث يمكن التعامل معها بسهولةcopyDataTable  يتم نسخ داتا تيبل الى 
        copyDataTable = TheDatatables(sqll).Copy()

        'DataGridView2.DataSource = copyDataTable
        Dim colIndex As Integer = 0
        For Each row As DataRow In copyDataTable.Rows
            'Itemzsittingهنا يتم تسمية كل الاعمدة واعطائها ليبل من داخل جدول 
            Sales_DGV.Columns.Add(LTrim(RTrim(row("Itemz"))), row("Description"))
            Sales_DGV.Columns(colIndex).Width = 120
            'هنا يتم إخفاء كل عمود قيمته 0 فى جدول Itemzsitting
            If row("selected_Sales") = 0 Then
                Sales_DGV.Columns(LTrim(RTrim(row("Itemz")))).Visible = False
            End If
            colIndex += 1
        Next row
    End Sub

    'إضافة الى جدول الاصناف الرئيسي
    Sub add_to_Itemz_table()
        'إضافة البيانات الى الجدول Itemz

        'Dim mesa As String = MsgBox("سيتم حفظ البيانات", MsgBoxStyle.YesNo, "Save Equation")
        Dim query2 As String = "Select @@Identity"

        'If mesa = MsgBoxResult.Yes Then
        Dim row_count As Integer = Sales_DGV.Rows.Count - 1

        Dim XItem_name As String = "0"
        Dim XItem_code As String = "0"
        Dim XItem_Description As String = "/"
        Dim XItem_type As String = "0"
        Dim XItem_Baracode As String = "0"
        Dim XItem_unitnumber As Integer = 1
        Dim XItem_color As String = "0"
        Dim XItem_made As String = "0"
        Dim XItem_sale_price As Double = 0
        Dim Xitem_invoice_price As Double = 0
        Dim XItem_discount_price As Double = 0

        Using conn As New SqlClient.SqlConnection(mycon)
            Dim query As String = "Insert Into Itemz ( Item_name   , Item_code  , Item_Description  , Item_type  , Item_Baracode   , Item_unitnumber   , Item_color , Item_made ) Values ( @Item_name   , @Item_code  , @Item_Description  , @Item_type  , @Item_Baracode   , @Item_unitnumber   , @Item_color , @Item_made)"

            Using cmd As New SqlClient.SqlCommand(query, conn)
                ' MsgBox(DataGridView2.CurrentRow.Cells("Item_name").Value)


                For Each ctl As Control In Me.panlformoshtriat1.Controls
                    If (ctl.GetType() Is GetType(TextBox)) Then

                        Select Case ctl.Name.ToString.Trim
                            Case "Item_name"
                                XItem_name = ctl.Text

                            Case "Item_code"
                                XItem_code = ctl.Text

                            Case "Item_Description"
                                XItem_Description = ctl.Text

                            Case "Item_type"
                                XItem_type = ctl.Text

                            Case "Item_Baracode"
                                XItem_Baracode = ctl.Text

                            Case "Item_unitnumber"
                                XItem_unitnumber = ctl.Text

                            Case "Item_color"
                                XItem_color = ctl.Text

                            Case "Item_made"
                                XItem_made = ctl.Text

                            Case "Item_sale_price"
                                XItem_sale_price = ctl.Text

                            Case "item_invoice_price"
                                Xitem_invoice_price = ctl.Text

                            Case "Item_discount_price"
                                XItem_discount_price = ctl.Text

                        End Select






                    End If
                Next

              



                cmd.Parameters.Add("@Item_name", SqlDbType.NVarChar).Value = XItem_name
                cmd.Parameters.Add("@Item_code", SqlDbType.NChar).Value = XItem_code
                cmd.Parameters.Add("@Item_Description", SqlDbType.NVarChar).Value = XItem_Description
                cmd.Parameters.Add("@Item_type", SqlDbType.NChar).Value = XItem_type
                cmd.Parameters.Add("@Item_Baracode", SqlDbType.NChar).Value = XItem_Baracode
                cmd.Parameters.Add("@Item_unitnumber", SqlDbType.Int).Value = XItem_unitnumber
                cmd.Parameters.Add("@Item_color", SqlDbType.NVarChar).Value = XItem_color
                cmd.Parameters.Add("@Item_made", SqlDbType.NVarChar).Value = XItem_made
                cmd.Parameters.Add("@Item_sale_price", SqlDbType.Float).Value = XItem_sale_price
                cmd.Parameters.Add("@item_invoice_price", SqlDbType.Float).Value = Xitem_invoice_price
                cmd.Parameters.Add("@Item_discount_price", SqlDbType.Float).Value = XItem_discount_price


                'TxtDescriptionFun




                conn.Open()

                cmd.ExecuteNonQuery()

                cmd.CommandText = query2

                cmd.ExecuteScalar()



            End Using
        End Using
        ' MsgBox("Done")

        'End If
    End Sub



    'إضافة الى جدول الفواتير
    Sub add_to_Bills_table(ByVal reseat_no1 As Long, ByVal Payment_typ As Integer)


        Dim query2 As String = "Select @@Identity"
        Using conn As New SqlClient.SqlConnection(mycon)
            Dim query As String = "Insert Into Bills (User_ID , Item_reaceat_NO,person,discount_price,Bill_No_steaker,Action_date,memonote,Bill_type) Values (@User_ID , @Item_reaceat_NO,@person,@discount_price,@Bill_No_steaker,@Action_date,@memonote,@Bill_type)"



            Using cmd As New SqlClient.SqlCommand(query, conn)


                cmd.Parameters.Add("@User_ID", SqlDbType.Int).Value = "1"
                cmd.Parameters.Add("@Item_reaceat_NO", SqlDbType.BigInt).Value = reseat_no1
                cmd.Parameters.Add("@person", SqlDbType.NVarChar).Value = "person"
                cmd.Parameters.Add("@discount_price", SqlDbType.Real).Value = 0

                cmd.Parameters.Add("@Bill_No_steaker", SqlDbType.BigInt).Value = reseat_no1


                cmd.Parameters.Add("@Action_date", SqlDbType.Date).Value = objDateTimePicker.Value

                cmd.Parameters.Add("@memonote", SqlDbType.NVarChar).Value = "memo"

                cmd.Parameters.Add("@Bill_type", SqlDbType.SmallInt).Value = Payment_typ




                conn.Open()

                cmd.ExecuteNonQuery()

                cmd.CommandText = query2

                cmd.ExecuteScalar()



            End Using
        End Using
    End Sub





    'إضافة الى جدول الحركة
    Sub add_to_Monyaction_table(ByVal myitemx As Integer, ByVal bil_no As Long)
        'إضافة البيانات الى الجدول Monyaction
        ' Dim cell_currentdate As Date = objDateTimePicker.Text
        'Dim mesa As String = MsgBox("سيتم حفظ البيانات", MsgBoxStyle.YesNo, "Save Equation")
        Dim query2 As String = "Select @@Identity"

        'If mesa = MsgBoxResult.Yes Then
        Dim row_count As Integer = myitemx - 1 ' Sales_DGV.Rows.Count - 1

        If myitemx = 0 Then
            MsgBox("لايوجد مبيعات")
            Exit Sub

        End If



        For b As Integer = 0 To row_count
            Using conn As New SqlClient.SqlConnection(mycon)
                Dim query As String = "Insert Into Monyaction (IDs , Item_QTY  ,Item_Price,Payment_type  ,Bill_No  , expirdate  ,  discount_price) Values (@IDs , @Item_QTY  ,@Item_Price   ,@Payment_type     ,@Bill_No   ,@expirdate    ,  @discount_price)"

                '  Dim query As String = "Insert Into Monyaction (IDs , Item_QTY  ,Item_Price,Payment_type  ,Action_date   ,Bill_No  , Item_reaceat_NO ,expirdate  ,person , User_ID ,  discount_price) Values (@IDs , @Item_QTY  ,@Item_Price   ,@Payment_type  ,@Action_date   ,@Bill_No  , @Item_reaceat_NO ,@expirdate  ,@person  , @User_ID ,  @discount_price)"



                Using cmd As New SqlClient.SqlCommand(query, conn)


                    cmd.Parameters.Add("@IDs", SqlDbType.Int).Value = Sales_DGV.Rows(b).Cells("IDs").Value
                    cmd.Parameters.Add("@Item_QTY", SqlDbType.Float).Value = Sales_DGV.Rows(b).Cells("Item_QTY").Value
                    cmd.Parameters.Add("@Item_Price", SqlDbType.Float).Value = Sales_DGV.Rows(b).Cells("Item_Price").Value
                    cmd.Parameters.Add("@Payment_type", SqlDbType.Int).Value = Payment_typs 'نوع الحركة
                    cmd.Parameters.Add("@Bill_No", SqlDbType.NChar).Value = bil_no  ' Sales_DGV.Rows(b).Cells("Bill_No").Value

                    If IsDate(Sales_DGV.Rows(b).Cells("expirdate").Value) Then
                        cmd.Parameters.Add("@expirdate", SqlDbType.Date).Value = CDate(Sales_DGV.Rows(b).Cells("expirdate").Value)
                    Else
                        cmd.Parameters.Add("@expirdate", SqlDbType.Date).Value = Today
                    End If

                    cmd.Parameters.Add("@discount_price", SqlDbType.Float).Value = Sales_DGV.Rows(b).Cells("discount_price").Value




                    conn.Open()

                    cmd.ExecuteNonQuery()

                    cmd.CommandText = query2

                    cmd.ExecuteScalar()



                End Using
            End Using
        Next
        MsgBox("Done")

        'End If
    End Sub

    Private Sub Button1_Click_2(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(ByVal sender As Object, ByVal e As EventArgs)


        'إدراج البيانات الى الداتا جريد 2
        'هنا أخذ البيانات من التكست بوكسات وادراجها فى الداتا جريد
        'وذلك  عندما نحتاج الى اضافة صنف غير موجود من قبل 
        '  inflateDatagridview()



        'إضافة الى جدول الاصناف الرئيسي
        'add_to_Itemz_table()
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView2.KeyDown

    End Sub

    Private Sub DataGridView2_NewRowNeeded(ByVal sender As Object, ByVal e As DataGridViewRowEventArgs) Handles DataGridView2.NewRowNeeded

    End Sub

    Private Sub DataGridView2_RowEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView2.RowEnter

    End Sub

    Private Sub DataGridView2_RowPostPaint(ByVal sender As Object, ByVal e As DataGridViewRowPostPaintEventArgs) Handles DataGridView2.RowPostPaint

    End Sub

    Private Sub DataGridView2_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs) Handles DataGridView2.RowsAdded

    End Sub

    Private Sub DataGridView2_UserAddedRow(ByVal sender As Object, ByVal e As DataGridViewRowEventArgs) Handles DataGridView2.UserAddedRow

    End Sub

    Private Sub Button5_Click_1(ByVal sender As Object, ByVal e As EventArgs)

    End Sub


    Sub hidepanel1()
        Panel1.Visible = False
    End Sub
    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub panlformoshtriat1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panlformoshtriat1.Paint
        Dim borderRectangle As Rectangle = mysales.panlformoshtriat1.ClientRectangle
        Dim formGraphics As System.Drawing.Graphics
        ' formGraphics = Me.panlformoshtriat1.CreateGraphics()
        formGraphics = mysales.panlformoshtriat1.CreateGraphics()
        borderRectangle.Inflate(-30, -30)

        ControlPaint.DrawBorder3D(formGraphics, New Rectangle(-2, 0, 90, 570), _
            Border3DStyle.Raised)

        ' mypannel.Refresh()
        '  mysales.panlformoshtriat1.Refresh()



        ' Dim formGraphics As System.Drawing.Graphics
        formGraphics = mysales.panlformoshtriat1.CreateGraphics()
        Dim rect As New Rectangle(0, 570, 87, 40)
        '    sf.Alignment = StringAlignment.Far
        formGraphics.DrawRectangle(Pens.Red, rect)
        formGraphics.FillRectangle(Brushes.Black, rect)
    End Sub

    Private Sub panlformoshtriat1_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles panlformoshtriat1.VisibleChanged

    End Sub

    Private Sub Button1_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        inflateDatagridview_formaction_DGV()


    End Sub


    ' نقل البيانات من داتا جريد  الى اخري
    Sub inflateDatagridview_formaction_DGV()

        Sales_DGV.ReadOnly = True
        '   Sales_DGV.Rows.Add(item)
        'Next
        Dim Qnt_sum As Double = 0
        price_sum = 0
        Dim Mylogik As Boolean = True
        myindix = -1






        Do
            myindix += 1

            'إضافة صف جديد
            If myindix > Sales_DGV.Rows.Count - 1 Then
                Sales_DGV_Newrow()
            End If
            Sales_DGV.Rows(myindix).Selected = False
            If (IsDBNull(Sales_DGV.Rows(myindix).Cells("IDs").Value)) Or (String.IsNullOrWhiteSpace(Sales_DGV.Rows(myindix).Cells("IDs").Value.ToString)) Or (Sales_DGV.Rows(myindix).Cells("IDs").Value.ToString = "") Then
                Sales_DGV.Rows(myindix).Cells("Item_QTY").Value = 1
                ' Sales_DGV.Rows(myindix).Cells("IDs").Value = myindix
                If typpe_Getrecords = 0 Or typpe_Getrecords = 4 Then
                    Sales_DGV.Rows(myindix).Cells("Item_Price").Value = actions_DGV.Rows(0).Cells("Item_sale_price").Value
                    Sales_DGV.Rows(myindix).Cells("Eljmali").Value = Sales_DGV.Rows(myindix).Cells("Item_Price").Value * Sales_DGV.Rows(0).Cells("Item_QTY").Value
                Else
                    Sales_DGV.Rows(myindix).Cells("Item_Price").Value = actions_DGV.CurrentRow.Cells("Item_sale_price").Value
                    Sales_DGV.Rows(myindix).Cells("Eljmali").Value = Sales_DGV.Rows(myindix).Cells("Item_Price").Value * Sales_DGV.CurrentRow.Cells("Item_QTY").Value

                End If

                Mylogik = False

                'Else
                '    If CInt(Sales_DGV.Rows(myindix).Cells("IDs").Value) = CInt(actions_DGV.Rows(myindix).Cells("IDs").Value) Then
                '        Mylogik = False
                '        Sales_DGV.Rows(myindix).Cells("Item_QTY").Value += 1

                '    End If

            End If



        Loop While Mylogik = True



        'هنا يتم تعبئة الداتاجريد الخاصة بالبيع ببيانات الداتا جريد الخاصة بالاكشن التى يتم من خلالها لبيع

        For Each GridCol As DataGridViewColumn In Sales_DGV.Columns
            For Each GridCol1 As DataGridViewColumn In actions_DGV.Columns

                If GridCol.Name = GridCol1.Name Then
                    ' If Not IsDBNull(actions_DGV.SelectedCells(GridCol1.Index).Value) Then

                    If GridCol.Name.Trim <> "Item_QTY" And GridCol.Name.Trim <> "Item_Price" Then
                        If typpe_Getrecords = 0 Or typpe_Getrecords = 4 Then
                            Sales_DGV.Rows(myindix).Cells(GridCol.Name).Value = actions_DGV.Rows(0).Cells(GridCol1.Name).Value
                        Else
                            Sales_DGV.Rows(myindix).Cells(GridCol.Name).Value = actions_DGV.CurrentRow.Cells(GridCol1.Name).Value
                        End If

                        Sales_DGV.Rows(myindix).Cells("Grid_No").Value = myindix + 1
                        'If GridCol.Name.Trim = "Item_QTY" Then  Eljmali
                        '    Sales_DGV.Rows(myindix).Cells("Item_QTY").Value = 1
                    End If
                    'End If
                End If

            Next
        Next
        Sales_DGV.CurrentCell = Sales_DGV.Rows(myindix).Cells("Item_QTY")
        Sales_DGV.Rows(myindix).Selected = True
        ''هنا يتم وضع قيمة الكمية 1 يعنى اننى بعت صنف واحد فقط
        'If IsDBNull(Sales_DGV.Rows(myindix).Cells("Item_QTY").Value) Then
        '    Sales_DGV.Rows(myindix).Cells("Item_QTY").Value = 1Item_Price
        'Else

        'End If
        '   calculatesum()
    End Sub

    Sub Sales_DGV_Newrow()
        Dim item As New DataGridViewRow
        item.CreateCells(Sales_DGV)

        For Each GridCol As DataGridViewColumn In Sales_DGV.Columns




            With item
                '  ' هنا التطابق مع اسماء الأعمدة واسماء البوكسات

                .Cells(GridCol.Index).Value = ""

            End With



        Next



        Sales_DGV.Rows.Add(item)
    End Sub

    Public Sub calculatesum()
        Dim Qnt_sum As Double = 0
        price_sum = 0
        Dim kdb As Integer = 0

        For Each row As DataGridViewRow In Sales_DGV.Rows

            If (IsDBNull(Sales_DGV.Rows(row.Index).Cells("IDs").Value)) Or (String.IsNullOrWhiteSpace(Sales_DGV.Rows(row.Index).Cells("IDs").Value.ToString)) Then
                kdb = 0
            Else

                Qnt_sum += Sales_DGV.Rows(row.Index).Cells("Item_QTY").Value
                price_sum += Sales_DGV.Rows(row.Index).Cells("Item_Price").Value * Sales_DGV.Rows(row.Index).Cells("Item_QTY").Value
                'Grid_No
                Sales_DGV.Rows(row.Index).Cells("Grid_No").Value = row.Index + 1
                Sales_DGV.Rows(row.Index).Cells("Eljmali").Value = Sales_DGV.Rows(row.Index).Cells("Item_Price").Value * Sales_DGV.Rows(row.Index).Cells("Item_QTY").Value
                'Eljmali             
            End If


        Next row
        thesum.Text = " المجموع   " & price_sum


      
        If IsNumeric(txt_receve.Text) Then




            txt_Reset.Text = txt_receve.Text - price_sum
            txt_Reset.Text = "الباقي  " & txt_Reset.Text

            If txt_receve.Text - price_sum < 0 Then
                txt_Reset.ForeColor = Color.Red
            Else
                txt_Reset.ForeColor = Color.Yellow
            End If
        Else
            txt_Reset.Text = "Error"
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
    ''الازرار الفعالة الخاصة بالمعاملات المباشرة مثل الى اعلى والى اسفل والانتظار... الخ
    'Sub inside_buttonz()



    '    Dim borderRectangle As Rectangle = Me.panlformoshtriat1.ClientRectangle
    '    Dim formGraphics As System.Drawing.Graphics
    '    formGraphics = Me.panlformoshtriat1.CreateGraphics()
    '    borderRectangle.Inflate(-30, -30)

    '    ControlPaint.DrawBorder3D(formGraphics, New Rectangle(-2, 33, 90, 574), _
    '        Border3DStyle.Raised)


    '    'إضافة إيقونات من نوع صورة 
    '    '   Dim sqll As String = "SELECT   Icon_id, Icon_name, Icon_Caption, function_name, Icon_order, Activity_type, section_ID  FROM  My_aplication_Icons WHERE     (function_name = N'Create_icon_imajes') AND (Activity_type = N'غذائية') ORDER BY Icon_order" ' "SELECT * from Salesdataview "
    '    Dim sqll As String = "SELECT   Icon_id, Icon_name, Icon_Caption, function_name, Icon_order, Activity_type, section_ID  FROM  My_aplication_Icons WHERE     (function_name = N'inside_buttonz') AND (Activity_type = N'الكل') ORDER BY Icon_order" ' "SELECT * from Salesdataview "

    '    Dim Mymatrix As DataTable
    '    Mymatrix = TheDatatables(sqll)
    '    Dim shiftx As Integer = 10
    '    Dim shifty As Integer = 40





    '    For j As Integer = 0 To Mymatrix.Rows.Count - 1
    '        Dim Xybtnz As New Label
    '        Xybtnz.Name = LTrim(RTrim(Mymatrix.Rows(j).Item("Icon_name")))
    '        Xybtnz.Tag = LTrim(RTrim(Mymatrix.Rows(j).Item("Icon_Caption")))
    '        Dim picturenam As String = LTrim(RTrim(Mymatrix.Rows(j).Item("Icon_name")))
    '        Xybtnz.Image = Image.FromFile("D:\Trade\Trade\myicons\" & picturenam)


    '        Xybtnz.Location = New Point(shiftx, shifty)
    '        '  UnderCalcolater_Icons.Size = New Size(65, 90) '44, 36   Me.PointToClient(Windows.Forms.Cursor.Position)
    '        Xybtnz.Size = New Size(60, 60)
    '        ' oCurrentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
    '        Dim tooltip1 As System.Windows.Forms.ToolTip = New System.Windows.Forms.ToolTip()

    '        tooltip1.SetToolTip(Xybtnz, LTrim(RTrim(Mymatrix.Rows(j).Item("Icon_Caption"))))
    '        ' Add events to the new picturebox we just created so that it can be moved again later
    '        'AddHandler UnderCalcolater_Icons.Click, AddressOf UnderCalcolater_Icons_Click
    '        'AddHandler Xybtnz.MouseMove, AddressOf Xybtnz_MouseMove
    '        'AddHandler Xybtnz.MouseLeave, AddressOf Xybtnz_Leave

    '        ' Add picturebox to form
    '        panlformoshtriat1.Controls.Add(Xybtnz)

    '        ' Bring picturebox to front after it has been added to the form to ensure it is on top of all other controls in the controls collection
    '        Xybtnz.BringToFront()
    '        shifty += 71
    '    Next j
    'End Sub


    'Private Sub Xybtnz_MouseMove(ByVal sender As Object, ByVal e As System.EventArgs)



    '    sender.Image = Image.FromFile("D:\Trade\Trade\myicons\Big\" & sender.name)







    'End Sub

    'Private Sub Xybtnz_Leave(ByVal sender As Object, ByVal e As System.EventArgs)

    '    sender.Image = Image.FromFile("D:\Trade\Trade\myicons\" & sender.name)


    'End Sub
    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click

    End Sub

    Private Sub DataGridView1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Resize

    End Sub

    Private Sub DataGridView1_RowStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles DataGridView1.RowStateChanged

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged


    End Sub

    Private Sub DataGridView1_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.VisibleChanged

    End Sub

    Private Sub txtGetRecords_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGetRecords.TextChanged


        inflateDatagridview_module()
    End Sub
    Sub inflateDatagridview_module()
        Dim nnearo As String = "%" + mysales.txtGetRecords.Text + "%"
        Qtxt = ""
        'الحصول على كل البيانات من داخل الداتا جريد
        'Dim sqll As String = "SELECT   IDs  as 'رقم آلى', Item_name as 'الصنف', Item_sale_price as 'السعر' FROM Itemz WHERE Item_name  like N'" & nnearo & "'" ' "SELECT * from Salesdataview "
        Dim sqll As String = "SELECT * FROM  Salesdataview  WHERE Item_name  like N'" & nnearo & "'" ' "SELECT * from Salesdataview "

        actions_DGV.Visible = False
        'typpe_Getrecords = 4
        Select Case typpe_Getrecords

            Case 0
                ' فى حالة البحث باستخدام الباركود
                '  MsgBox("ssssssssssssssssssssss  " & typpe_Getrecords)
                sqll = "SELECT  * FROM  Salesdataview  WHERE  Item_Baracode = '" & txtGetRecords.Text.ToString.Trim & "'"
                ' actions_DGV.Visible = False
            Case 1
                actions_DGV.Visible = True
                '   فى حالة البحث باستخدام اسم الصنف
                sqll = "SELECT  TOP (5) * FROM  Salesdataview_Asnaf  WHERE Item_name  like N'" & nnearo & "'" ' "SELECT * from Salesdataview "

            Case 2
                '  البحث بسعر البيع
                If Not IsNumeric(txtGetRecords.Text) Then
                    'MsgBox("نرجو تحديد سعر البيع ")
                    Exit Sub
                End If

                sqll = "SELECT  * FROM  Salesdataview_Asnaf  WHERE  Item_sale_price =  " & CDbl(txtGetRecords.Text) & ""
                actions_DGV.Visible = True
            Case 3
                getbywasel(txtGetRecords.Text)
                Exit Sub
            Case 4
                'البحث عند الضغط على الزر الخاص بالقائمة السريعة وقائمة دليل الاصناف
                If Not IsNumeric(txtGetRecords.Text) Then
                    'MsgBox("نرجو كتابة رقم الواصل بشكل صحيح ")
                    Exit Sub
                End If

                'actions.makebutonsfor_alsareah_DLvw(mysales.Panel1)
                sqll = " SELECT     TOP (1) * FROM  Salesdataview Where ids = " & txtGetRecords.Text & ""
        End Select
        'هنا إعادة شكل البحث الى وضع الباركود اتوماتيكيا
        '  typpe_Getrecords = 0

        Dim Mymatrix As DataTable
        'حيث يمكن التعامل معها بسهولةcopyDataTable  يتم نسخ داتا تيبل الى 

        Mymatrix = TheDatatables(sqll)
        'MsgBox(Mymatrix.Rows.Count)
        With actions_DGV
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AllowUserToResizeColumns = True
            .AllowUserToAddRows = False

        End With
        actions_DGV.DataSource = Mymatrix
        'MsgBox(actions_DGV.RowCount)
        For Each GridCol As DataGridViewColumn In actions_DGV.Columns

            'If GridCol.Name = GridCol1.Name Then
            '    If Not IsDBNull(actions_DGV.SelectedCells(GridCol1.Index).Value) Then
            '        Sales_DGV.Rows(Sales_DGV.Rows.Count - 1).Cells(GridCol.Name).Value = actions_DGV.CurrentRow.Cells(GridCol1.Name).Value
            '    End If
            'End If
            GridCol.Visible = True


        Next
        For Each GridCol As DataGridViewColumn In actions_DGV.Columns



            If GridCol.Name = "Item_name" Then
                GridCol.Visible = True
                GridCol.Width = 165
                GridCol.HeaderText = "الصنف"
            End If


            If GridCol.Name = "Item_sale_price" Then
                GridCol.Visible = True
                GridCol.Width = 50

                GridCol.HeaderText = "سعر البيع"
            End If

        Next
        'MsgBox(sqll)
        'MsgBox(actions_DGV.Rows.Count)
        'عدم السماح بنقل البيانات الى مكان البيع الا عند وجود بيانات فى داتا جريد البحث
        If actions_DGV.Rows.Count > 0 And (typpe_Getrecords = 0 Or typpe_Getrecords = 4) Then
            'MsgBox("oookkk" & txtGetRecords.Text)
            inflateDatagridview_formaction_DGV()
            txtGetRecords.SelectAll()
        End If

    End Sub
    'دالة البحث بالواصل
    Sub getbywasel(ByVal myvalue As String)
        'البحث برقم الواصل
        If Not IsNumeric(myvalue) Then
            'MsgBox("نرجو كتابة رقم الواصل بشكل صحيح ")
            Exit Sub
        End If

        'sqll = "SELECT  * FROM  Salesdataview_Waselat  WHERE  Item_reaceat_NO =  " & CInt(txtGetRecords.Text) & ""
        '**********************************************************
        Dim sqll As String = "SELECT  * FROM  Salesdataview_Waselat  WHERE  Item_reaceat_NO =  " & CInt(myvalue) & ""

        'معناها الاجراء يبحث عن رقم الفاتورة
        'أي أن الاجراء هو رجوع من الانتظار

        If myvalue = 8 Then
            sqll = "SELECT  * FROM  Salesdataview_Waselat  WHERE  Bill_No =  " & CInt(myvalue) & ""
        End If

        For Each xrow As DataGridViewRow In Sales_DGV.Rows
            For Each GridCol As DataGridViewColumn In Sales_DGV.Columns
                xrow.Cells(GridCol.Name).Value = ""
            Next
        Next


        Dim waseldatagrid As New DataGridView
        waseldatagrid.DataSource = TheDatatables(sqll)
        waseldatagrid.AllowUserToAddRows = False
        waseldatagrid.Parent = Me
        waseldatagrid.Visible = False

        myindix = -1

        For x As Integer = 0 To waseldatagrid.Rows.Count - 1

            For Each GridCol As DataGridViewColumn In Sales_DGV.Columns
                For Each GridCol1 As DataGridViewColumn In waseldatagrid.Columns

                    If GridCol.Name = GridCol1.Name Then


                        Sales_DGV.Rows(x).Cells(GridCol.Name).Value = waseldatagrid.Rows(x).Cells(GridCol1.Name).Value

                        Sales_DGV.Rows(x).Cells("Grid_No").Value = x + 1

                    End If

                Next
            Next
        Next


        calculatesum()
        '**********************************************************

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If CType(Me.Controls.Find(GetbuttonName, True)(0), Button).BackColor = System.Drawing.Color.LightYellow Then

                CType(Me.Controls.Find(GetbuttonName, True)(0), Button).BackColor = System.Drawing.Color.SkyBlue
                CType(Me.Controls.Find(GetbuttonName, True)(0), Button).ForeColor = System.Drawing.Color.Black
            Else
                CType(Me.Controls.Find(GetbuttonName, True)(0), Button).BackColor = System.Drawing.Color.LightYellow
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Sales_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        '  MsgBox("imhere")
        '   rs.FindAllControls(Me)
    End Sub

    Private Sub Sales_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub Button1_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim btnclss As New Buttonclaccez
        Dim sqll As String = "SELECT  dbo.Monyaction.IDs, dbo.Monyaction.Action_no, dbo.Monyaction.Action_date, dbo.Monyaction.Item_QTY * dbo.Payments.Item_inout_QNT AS qnt, dbo.Monyaction.Item_Price,  dbo.Payments.Payment_type FROM     dbo.Monyaction INNER JOIN     dbo.Payments ON dbo.Monyaction.Payment_type = dbo.Payments.Payment_type ORDER BY dbo.Monyaction.IDs, dbo.Payments.Payment_type, dbo.Monyaction.Action_date"
        Dim FIFO_datatable As DataTable



        btnclss.update_reset()




        'حيث يمكن التعامل معها بسهولةcopyDataTable  يتم نسخ داتا تيبل الى 
        FIFO_datatable = TheDatatables(sqll)






        Dim QNT As Double = 0


        Dim step_IN As Integer = 0
        Dim step_IN_lojek As Boolean = True

        Dim Step_OUT As Integer = 0
        Dim Step_OUT_lojek As Boolean = True

        Dim breakitem As Integer = -1 'FIFO_datatable.Rows(0).Item("IDs")


        Dim Price As Double = 0
        Dim COST As Double = 0
        Dim acumilative_COST As Double = -1

        ' Dim acumilative_lojek As Boolean = True


        For Step_OUT = 0 To FIFO_datatable.Rows.Count - 1
            step_IN_lojek = True
            ''فى حالة وقوف المؤشر علي صنف اخر
            If FIFO_datatable.Rows(Step_OUT).Item("IDs") <> breakitem Then

                QNT = 0
                step_IN_lojek = True
                Step_OUT_lojek = True
                step_IN = Step_OUT
                breakitem = FIFO_datatable.Rows(step_IN).Item("IDs")
                Price = 0
                COST = 0
                QNT = FIFO_datatable.Rows(Step_OUT).Item("qnt")
                ' MsgBox(QNT)
            End If


            If FIFO_datatable.Rows(Step_OUT).Item("Payment_type") = 2 And (FIFO_datatable.Rows(Step_OUT).Item("qnt") + QNT) >= 0 Then
                QNT += FIFO_datatable.Rows(Step_OUT).Item("qnt")
                COST = Math.Abs(FIFO_datatable.Rows(Step_OUT).Item("qnt") * FIFO_datatable.Rows(step_IN).Item("Item_Price"))
                btnclss.update_qnt(FIFO_datatable.Rows(Step_OUT).Item("Action_no"), COST, QNT)

            Else


                If FIFO_datatable.Rows(Step_OUT).Item("Payment_type") = 2 And (FIFO_datatable.Rows(Step_OUT).Item("qnt") + QNT) < 0 Then

                    Dim loop_no As Integer = 0


                    COST = 0
                    COST = QNT * FIFO_datatable.Rows(step_IN).Item("Item_Price")

                    QNT += FIFO_datatable.Rows(Step_OUT).Item("qnt")
                    ' MsgBox("QNT=" & QNT)
                    Do

                        loop_no += 1
                        If QNT < 0 Then
                            step_IN += 1
                            QNT += FIFO_datatable.Rows(step_IN).Item("qnt")
                            ' MsgBox("QNT=" & QNT)

                            If QNT > 0 Then
                                COST += Math.Abs(FIFO_datatable.Rows(Step_OUT).Item("qnt") * FIFO_datatable.Rows(step_IN).Item("Item_Price"))
                            Else
                                COST += FIFO_datatable.Rows(step_IN).Item("qnt") * FIFO_datatable.Rows(step_IN).Item("Item_Price")
                            End If



                            If QNT + FIFO_datatable.Rows(step_IN).Item("qnt") < QNT Then
                                step_IN_lojek = False
                                QNT = 0
                                COST = 0
                            End If


                        Else
                            step_IN_lojek = False

                            'If QNT <> 0 Then
                            '    COST += Math.Abs(QNT + FIFO_datatable.Rows(Step_OUT).Item("qnt")) * FIFO_datatable.Rows(step_IN).Item("Item_Price")
                            '    QNT += FIFO_datatable.Rows(Step_OUT).Item("qnt")
                            'End If

                            ' QNT += FIFO_datatable.Rows(Step_OUT).Item("qnt")

                            ' MsgBox("COST=" & COST)
                        End If
                        btnclss.update_qnt(FIFO_datatable.Rows(Step_OUT).Item("Action_no"), COST, QNT)
                    Loop While (Step_OUT < FIFO_datatable.Rows.Count) And (step_IN < FIFO_datatable.Rows.Count) And step_IN_lojek = True



                    ' COST = 0
                End If

            End If





        Next



        MsgBox("done")

    End Sub

    Private Sub Panel1_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
      
        MsgBox(price_sum)
        MsgBox(txt_receve.Text)
        calculatesum()
    End Sub

    Private Sub txt_receve_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_receve.TextChanged
        Try

            If txt_receve.Text = "" Then
                txt_Reset.Text = ""
            End If

            If IsNumeric(txt_receve.Text) Then
                If txt_receve.Text = 0 Then
                    txt_Reset.Text = ""
                End If
                calculatesum()
            End If
        Catch ex As Exception

        End Try
      

    End Sub

    Private Sub txt_Reset_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Reset.TextChanged

    End Sub
End Class
