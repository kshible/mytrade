﻿
Imports System.Data.SqlClient

'Referencez

'placethelabels **************Sales_DGV**الوصول الى إخفاء وإظهار أعمدة الداتا جريد**************

'******************************أزرار شاشة المبيعات*********************
' Case "العدد"
'Case "باركود"
'Case "إدراج صنف"

'******************************أزرار القائمة الرئيسية*********************
'Case "ادراج فاتورة"
'   Case "الخزينة"
'  Case "الإعدادات"
' Case "خروج"
'  Case "المشتريات"


'/هنا يتم اضافة مجموعة من الاصناف اثناء البيع 
'/وقد يتم تصحيح هذه البيانات لاحقا فى شاشة المشتريات
'Sub add_short_items()

'هنا يتم تصميم وتشكيل شكل اداتا جريد حتي يتم تصويرها كما هو موجود بالمنظومات المعتبرة
'Sub Sale_DGV_Design()


'*****************************DataBase System*****************************
'إدراج البيانات الى الداتا جريد 2

'هنا أخذ البيانات من الفيو Salesdataview واضافته الى الداتا جريد
'وذلك  عندما نحتاج الى استدعاء بضاعة نريد بيعها من خلال الباركود 

'Sub pulldata_todatagrid2()


'إضافة الى جدول الاصناف الرئيسي
'Sub add_to_Itemz_table()


'إضافة الى جدول الحركة
'Sub add_to_Monyaction_table()

Module trademoudle

    Public mysales As New Sales
    Public myuser As New users
    Public myssting As New UserControlsettings
    Public Qtxt As String
    'Dim LSHuser As String = "sh"
    'Dim LSHpassword As String = "P@ssw0rd1"
    'Dim LSHDatabase As String = "MonyDB"
    'Dim LSHServer As String = "10.10.7.7"
    ' عدد الازرار فى اللائحة الرئيسية داخل الفورم actions
    Public Mainbutton_coun As Integer = 0
    'لتبديل اللوحات
    Public Manue_Counter As Integer = 1

    'التحرك عبر صفوف جريد البيع
    Public myindix As Integer = -1

    'التحكم فى تعديل الاسعار أو الكميات
    '0 تعديل كميات.
    '1 تعديل أسعار
    Public Quint_Price_control As Integer = 0


    'تحديد نوع البحث باركود او واصل .... الخ
    Public typpe_Getrecords As Integer = 0

    'تحديد طريقة الدفع وهي معرفة فى الجدول[Payment_type]
    Public Payment_typs As Integer = 2


    Dim LSHuser As String = "sh"
    Dim LSHpassword As String = "asd11"
    Dim LSHDatabase As String = "MonyDB"
    Dim LSHServer As String = "DELL-PC"
    Public actions_DGV As DataGridView
    Public Sales_DGV As DataGridView

    Public mycon As String = "Persist Security Info=False;User ID='" & LSHuser & "' ;password='" & LSHpassword & "'; Initial Catalog='" & LSHDatabase & "' ;Data Source='" & LSHServer & "'"
    'خاص بتقليب الازرار فى قائمة دليل الاصناف
    Public x_Dalel_Asnaf As Integer = 1
    Public Sub Draw_pannel(ByVal Xpnl1)
        ' actions_DGV.Visible = True
        ' Xpnl1.Controls.Clear()
        Xpnl1.Size = New Size(420, 609)
        Xpnl1.Location = New Point(568, 42)
        Xpnl1.BackColor = Color.White
        Xpnl1.Visible = True

    End Sub

    Public Sub ShowDataInLvw(ByVal data As DataTable, ByVal lvw As ListView)

        ' Set the view to show details.
        lvw.View = View.Details
        ' Allow the user to edit item text.
        lvw.LabelEdit = True
        ' Allow the user to rearrange columns.
        lvw.AllowColumnReorder = True
        ' Display check boxes.
        ' ListView1.CheckBoxes = True
        ' Select the item and subitems when selection is made.
        lvw.FullRowSelect = True
        ' Display grid lines.
        lvw.GridLines = True
        ' Sort the items in the list in ascending order.
        ' lvw.Sorting = SortOrder.Ascending




        lvw.GridLines = True
        lvw.Columns.Clear()
        lvw.Items.Clear()
        For Each col As DataColumn In data.Columns
            lvw.Columns.Add(col.ToString)
        Next
        For Each row As DataRow In data.Rows
            Dim lst As ListViewItem
            lst = lvw.Items.Add(If(row(0) IsNot Nothing, row(0).ToString, ""))
            For i As Integer = 1 To data.Columns.Count - 1
                lst.SubItems.Add(If(row(i) IsNot Nothing, row(i).ToString, ""))
            Next
        Next
    End Sub


    'تنظيف محتوي البانل الرئيسية
    Public Sub clearcontrols(ByVal pnl As Panel)
        'If (ctrl.GetType() Is GetType(TextBox)) Then

        'End If
        pnl.Controls.Clear()

    End Sub

    'الحصول على داتا تيبل

    Public Function TheDatatables(ByVal strSql As String) As DataTable
        ' Dim strSql As String = "SELECT EmpCode,EmpID,EmpName FROM dbo.Employee"
        Dim dtb As New DataTable
        Using cnn As New SqlConnection(mycon)
            cnn.Open()
            Using dad As New SqlDataAdapter(strSql, cnn)
                dad.Fill(dtb)
            End Using
            cnn.Close()
        End Using
        Return dtb
    End Function





    'طريقة الاستدعاء

    ' Dim myIDD As Integer = GETMXXVALUES("SELECT     MAX(IDs) AS Expr1  FROM  dbo.Itemz")

    'الحصول على أكبر قيمة وهى قيمة المفتاح
    Function GETMXXVALUES(ByVal sstr As String) As String

        Try

            Dim conn As New SqlClient.SqlConnection(mycon)

            Dim rs As SqlClient.SqlDataReader


            conn.Open()
            Dim cmd As New SqlClient.SqlCommand(sstr, conn)
            rs = cmd.ExecuteReader
            rs.Read()


            ' GETMXXVALUES = CStr(Val(rs(0)))
            'GETMXXVALUES = GETMXXVALUES.Replace("E", 2)
            GETMXXVALUES = CStr(Val(rs(0)) + 1)
            'GETMXXVALUES = GETMXXVALUES.Replace(2, "E")

            rs.Close()
            conn.Close()
        Catch ex As Exception
            GETMXXVALUES = 1
        End Try

    End Function



















    'دوال رسم الباركود

    Function Code128(ByVal TheText As String, ByVal CodeLetter As String) As Image
        ' TheText متغير خاص بالنص المراد تشفيره
        ' CodeLetter متغير خاص بالفئة المراد استخدامها

        Dim Binaryz As String = "" 'متغير سيحمل النص بعد تحويله إلى باينرى
        Dim I As Integer
        Dim NumCode As Integer 'متغير سيحمل  قيمة حساب النص التكميلى
        If CodeLetter = "A" Or CodeLetter = "a" Then
            NumCode = 103
            Binaryz = "00101111011"
        End If
        If CodeLetter = "B" Or CodeLetter = "b" Then
            NumCode = 104
            Binaryz = "00101101111"
        End If
        If CodeLetter = "C" Or CodeLetter = "c" Then
            NumCode = 105
            Binaryz = "00101100011"
        End If
        ' الكود التالى سيقوم باسناد قيمة الحرف بالباينرى حسب الجدول الخاص بالكود 128
        For I = 1 To Len(TheText)
            NumCode = NumCode + ((Asc(Mid(TheText, I, 1)) - 32) * I)
            Select Case Asc(Mid(TheText, I, 1))
                Case 32
                    Binaryz = Binaryz & "00100110011"
                Case 33
                    Binaryz = Binaryz & "00110010011"
                Case 34
                    Binaryz = Binaryz & "00110011001"
                Case 35
                    Binaryz = Binaryz & "01101100111"
                Case 36
                    Binaryz = Binaryz & "01101110011"
                Case 37
                    Binaryz = Binaryz & "01110110011"
                Case 38
                    Binaryz = Binaryz & "01100110111"
                Case 39
                    Binaryz = Binaryz & "01100111011"
                Case 40
                    Binaryz = Binaryz & "01110011011"
                Case 41
                    Binaryz = Binaryz & "00110110111"
                Case 42
                    Binaryz = Binaryz & "00110111011"
                Case 43
                    Binaryz = Binaryz & "00111011011"
                Case 44
                    Binaryz = Binaryz & "01001100011"
                Case 45
                    Binaryz = Binaryz & "01100100011"
                Case 46
                    Binaryz = Binaryz & "01100110001"
                Case 47
                    Binaryz = Binaryz & "01000110011"
                Case 48
                    Binaryz = Binaryz & "01100010011"
                Case 49
                    Binaryz = Binaryz & "01100011001"
                Case 50
                    Binaryz = Binaryz & "00110001101"
                Case 51
                    Binaryz = Binaryz & "00110100011"
                Case 52
                    Binaryz = Binaryz & "00110110001"
                Case 53
                    Binaryz = Binaryz & "00100011011"
                Case 54
                    Binaryz = Binaryz & "00110001011"
                Case 55
                    Binaryz = Binaryz & "00010010001"
                Case 56
                    Binaryz = Binaryz & "00010110011"
                Case 57
                    Binaryz = Binaryz & "00011010011"
                Case 58
                    Binaryz = Binaryz & "00011011001"
                Case 59
                    Binaryz = Binaryz & "00010011011"
                Case 60
                    Binaryz = Binaryz & "00011001011"
                Case 61
                    Binaryz = Binaryz & "00011001101"
                Case 62
                    Binaryz = Binaryz & "00100100111"
                Case 63
                    Binaryz = Binaryz & "00100111001"
                Case 64
                    Binaryz = Binaryz & "00111001001"
                Case 65
                    Binaryz = Binaryz & "01011100111"
                Case 66
                    Binaryz = Binaryz & "01110100111"
                Case 67
                    Binaryz = Binaryz & "01110111001"
                Case 68
                    Binaryz = Binaryz & "01001110111"
                Case 69
                    Binaryz = Binaryz & "01110010111"
                Case 70
                    Binaryz = Binaryz & "01110011101"
                Case 71
                    Binaryz = Binaryz & "00101110111"
                Case 72
                    Binaryz = Binaryz & "00111010111"
                Case 73
                    Binaryz = Binaryz & "00111011101"
                Case 74
                    Binaryz = Binaryz & "01001000111"
                Case 75
                    Binaryz = Binaryz & "01001110001"
                Case 76
                    Binaryz = Binaryz & "01110010001"
                Case 77
                    Binaryz = Binaryz & "01000100111"
                Case 78
                    Binaryz = Binaryz & "01000111001"
                Case 79
                    Binaryz = Binaryz & "01110001001"
                Case 80
                    Binaryz = Binaryz & "00010001001"
                Case 81
                    Binaryz = Binaryz & "00101110001"
                Case 82
                    Binaryz = Binaryz & "00111010001"
                Case 83
                    Binaryz = Binaryz & "00100010111"
                Case 84
                    Binaryz = Binaryz & "00100011101"
                Case 85
                    Binaryz = Binaryz & "00100010001"
                Case 86
                    Binaryz = Binaryz & "00010100111"
                Case 87
                    Binaryz = Binaryz & "00010111001"
                Case 88
                    Binaryz = Binaryz & "00011101001"
                Case 89
                    Binaryz = Binaryz & "00010010111"
                Case 90
                    Binaryz = Binaryz & "00010011101"
                Case 91
                    Binaryz = Binaryz & "00011100101"
                Case 92
                    Binaryz = Binaryz & "00010000101"
                Case 93
                    Binaryz = Binaryz & "00110111101"
                Case 94
                    Binaryz = Binaryz & "00001110101"
                Case 95
                    Binaryz = Binaryz & "01011001111"
                Case 96
                    Binaryz = Binaryz & "01011110011"
                Case 97
                    Binaryz = Binaryz & "01101001111"
                Case 98
                    Binaryz = Binaryz & "01101111001"
                Case 99
                    Binaryz = Binaryz & "01111010011"
                Case 100
                    Binaryz = Binaryz & "01111011001"
                Case 101
                    Binaryz = Binaryz & "01001101111"
                Case 102
                    Binaryz = Binaryz & "01001111011"
                Case 103
                    Binaryz = Binaryz & "01100101111"
                Case 104
                    Binaryz = Binaryz & "01100111101"
                Case 105
                    Binaryz = Binaryz & "01111001011"
                Case 106
                    Binaryz = Binaryz & "01111001101"
                Case 107
                    Binaryz = Binaryz & "00111101101"
                Case 108
                    Binaryz = Binaryz & "00110101111"
                Case 109
                    Binaryz = Binaryz & "00001000101"
                Case 110
                    Binaryz = Binaryz & "00111101011"
                Case 111
                    Binaryz = Binaryz & "01110000101"
                Case 112
                    Binaryz = Binaryz & "01011000011"
                Case 113
                    Binaryz = Binaryz & "01101000011"
                Case 114
                    Binaryz = Binaryz & "01101100001"
                Case 115
                    Binaryz = Binaryz & "01000011011"
                Case 116
                    Binaryz = Binaryz & "01100001011"
                Case 117
                    Binaryz = Binaryz & "01100001101"
                Case 118
                    Binaryz = Binaryz & "00001011011"
                Case 119
                    Binaryz = Binaryz & "00001101011"
                Case 120
                    Binaryz = Binaryz & "00001101101"
                Case 121
                    Binaryz = Binaryz & "00100100001"
                Case 122
                    Binaryz = Binaryz & "00100001001"
                Case 123
                    Binaryz = Binaryz & "00001001001"
                Case 124
                    Binaryz = Binaryz & "01010000111"
                Case 125
                    Binaryz = Binaryz & "01011100001"
                Case 126
                    Binaryz = Binaryz & "01110100001"
                Case 127
                    Binaryz = Binaryz & "01000010111"
                Case 128
                    Binaryz = Binaryz & "01000011101"
                Case 129
                    Binaryz = Binaryz & "00001010111"
                Case 130
                    Binaryz = Binaryz & "00001011101"
                Case 131
                    Binaryz = Binaryz & "01000100001"
                Case 132
                    Binaryz = Binaryz & "01000010001"
                Case 133
                    Binaryz = Binaryz & "00010100001"
                Case 134
                    Binaryz = Binaryz & "00001010001"
                Case 135
                    Binaryz = Binaryz & "00101111011"
                Case 136
                    Binaryz = Binaryz & "00101101111"
                Case 137
                    Binaryz = Binaryz & "00101100011"
                Case 138
                    Binaryz = Binaryz & "0011100010100"
            End Select
        Next
        NumCode = NumCode Mod 103
        ' الكود التالى لمعرفة الحرف المراد اضافتة لاستكمال النص
        Select Case NumCode
            Case 0
                Binaryz = Binaryz & "00100110011"
            Case 1
                Binaryz = Binaryz & "00110010011"
            Case 2
                Binaryz = Binaryz & "00110011001"
            Case 3
                Binaryz = Binaryz & "01101100111"
            Case 4
                Binaryz = Binaryz & "01101110011"
            Case 5
                Binaryz = Binaryz & "01110110011"
            Case 6
                Binaryz = Binaryz & "01100110111"
            Case 7
                Binaryz = Binaryz & "01100111011"
            Case 8
                Binaryz = Binaryz & "01110011011"
            Case 9
                Binaryz = Binaryz & "00110110111"
            Case 10
                Binaryz = Binaryz & "00110111011"
            Case 11
                Binaryz = Binaryz & "00111011011"
            Case 12
                Binaryz = Binaryz & "01001100011"
            Case 13
                Binaryz = Binaryz & "01100100011"
            Case 14
                Binaryz = Binaryz & "01100110001"
            Case 15
                Binaryz = Binaryz & "01000110011"
            Case 16
                Binaryz = Binaryz & "01100010011"
            Case 17
                Binaryz = Binaryz & "01100011001"
            Case 18
                Binaryz = Binaryz & "00110001101"
            Case 19
                Binaryz = Binaryz & "00110100011"
            Case 20
                Binaryz = Binaryz & "00110110001"
            Case 21
                Binaryz = Binaryz & "00100011011"
            Case 22
                Binaryz = Binaryz & "00110001011"
            Case 23
                Binaryz = Binaryz & "00010010001"
            Case 24
                Binaryz = Binaryz & "00010110011"
            Case 25
                Binaryz = Binaryz & "00011010011"
            Case 26
                Binaryz = Binaryz & "00011011001"
            Case 27
                Binaryz = Binaryz & "00010011011"
            Case 28
                Binaryz = Binaryz & "00011001011"
            Case 29
                Binaryz = Binaryz & "00011001101"
            Case 30
                Binaryz = Binaryz & "00100100111"
            Case 31
                Binaryz = Binaryz & "00100111001"
            Case 32
                Binaryz = Binaryz & "00111001001"
            Case 33
                Binaryz = Binaryz & "01011100111"
            Case 34
                Binaryz = Binaryz & "01110100111"
            Case 35
                Binaryz = Binaryz & "01110111001"
            Case 36
                Binaryz = Binaryz & "01001110111"
            Case 37
                Binaryz = Binaryz & "01110010111"
            Case 38
                Binaryz = Binaryz & "01110011101"
            Case 39
                Binaryz = Binaryz & "00101110111"
            Case 40
                Binaryz = Binaryz & "00111010111"
            Case 41
                Binaryz = Binaryz & "00111011101"
            Case 42
                Binaryz = Binaryz & "01001000111"
            Case 43
                Binaryz = Binaryz & "01001110001"
            Case 44
                Binaryz = Binaryz & "01110010001"
            Case 45
                Binaryz = Binaryz & "01000100111"
            Case 46
                Binaryz = Binaryz & "01000111001"
            Case 47
                Binaryz = Binaryz & "01110001001"
            Case 48
                Binaryz = Binaryz & "00010001001"
            Case 49
                Binaryz = Binaryz & "00101110001"
            Case 50
                Binaryz = Binaryz & "00111010001"
            Case 51
                Binaryz = Binaryz & "00100010111"
            Case 52
                Binaryz = Binaryz & "00100011101"
            Case 53
                Binaryz = Binaryz & "00100010001"
            Case 54
                Binaryz = Binaryz & "00010100111"
            Case 55
                Binaryz = Binaryz & "00010111001"
            Case 56
                Binaryz = Binaryz & "00011101001"
            Case 57
                Binaryz = Binaryz & "00010010111"
            Case 58
                Binaryz = Binaryz & "00010011101"
            Case 59
                Binaryz = Binaryz & "00011100101"
            Case 60
                Binaryz = Binaryz & "00010000101"
            Case 61
                Binaryz = Binaryz & "00110111101"
            Case 62
                Binaryz = Binaryz & "00001110101"
            Case 63
                Binaryz = Binaryz & "01011001111"
            Case 64
                Binaryz = Binaryz & "01011110011"
            Case 65
                Binaryz = Binaryz & "01101001111"
            Case 66
                Binaryz = Binaryz & "01101111001"
            Case 67
                Binaryz = Binaryz & "01111010011"
            Case 68
                Binaryz = Binaryz & "01111011001"
            Case 69
                Binaryz = Binaryz & "01001101111"
            Case 70
                Binaryz = Binaryz & "01001111011"
            Case 71
                Binaryz = Binaryz & "01100101111"
            Case 72
                Binaryz = Binaryz & "01100111101"
            Case 73
                Binaryz = Binaryz & "01111001011"
            Case 74
                Binaryz = Binaryz & "01111001101"
            Case 75
                Binaryz = Binaryz & "00111101101"
            Case 76
                Binaryz = Binaryz & "00110101111"
            Case 77
                Binaryz = Binaryz & "00001000101"
            Case 78
                Binaryz = Binaryz & "00111101011"
            Case 79
                Binaryz = Binaryz & "01110000101"
            Case 80
                Binaryz = Binaryz & "01011000011"
            Case 81
                Binaryz = Binaryz & "01101000011"
            Case 82
                Binaryz = Binaryz & "01101100001"
            Case 83
                Binaryz = Binaryz & "01000011011"
            Case 84
                Binaryz = Binaryz & "01100001011"
            Case 85
                Binaryz = Binaryz & "01100001101"
            Case 86
                Binaryz = Binaryz & "00001011011"
            Case 87
                Binaryz = Binaryz & "00001101011"
            Case 88
                Binaryz = Binaryz & "00001101101"
            Case 89
                Binaryz = Binaryz & "00100100001"
            Case 90
                Binaryz = Binaryz & "00100001001"
            Case 91
                Binaryz = Binaryz & "00001001001"
            Case 92
                Binaryz = Binaryz & "01010000111"
            Case 93
                Binaryz = Binaryz & "01011100001"
            Case 94
                Binaryz = Binaryz & "01110100001"
            Case 95
                Binaryz = Binaryz & "01000010111"
            Case 96
                Binaryz = Binaryz & "01000011101"
            Case 97
                Binaryz = Binaryz & "00001010111"
            Case 98
                Binaryz = Binaryz & "00001011101"
            Case 99
                Binaryz = Binaryz & "01000100001"
            Case 100
                Binaryz = Binaryz & "01000010001"
            Case 101
                Binaryz = Binaryz & "00010100001"
            Case 102
                Binaryz = Binaryz & "00001010001"
        End Select
        Binaryz = Binaryz & "0011100010100" ' انهاء الكود باضافة الباينرى الخاص بايقاف جميع الاكواد

        ' انشاء صورة عرضها عدد حروف الباينرى المستخدم
        Dim bmp As Bitmap = New Bitmap(Len(Binaryz), 60, System.Drawing.Imaging.PixelFormat.Format24bppRgb)
        Dim z As String ' متغير لمعرفة لون الخط 
        Dim GraphZ As Graphics = Graphics.FromImage(bmp)
        Dim RectZ As Rectangle = New Rectangle(0, 0, bmp.Width, bmp.Height) ' مستطيل بحجم الصورة لاعطاء الخلفية باللون الابيض
        ' فرشاه لدهان المستطيل السابق باللون الابيض
        Dim myBrush As Brush = New Drawing.Drawing2D.LinearGradientBrush(RectZ, Color.LightYellow, Color.SkyBlue, Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal)
        ' دهان المستطيل السابق باللون الابيض
        GraphZ.FillRectangle(myBrush, RectZ)
        '  رسم خطوط الباركود
        Dim PenZ As Pen
        Dim point1 As Point ' نقطة بداية الخط
        Dim point2 As Point ' نقطة نهاية الخط
        For I = 1 To Len(Binaryz)
            z = Mid(Binaryz, I, 1)
            If z = "0" Then
                PenZ = New Pen(Color.Black, 1)
                point1 = New Point(I, 0)
                point2 = New Point(I, 40)
                GraphZ.DrawLine(PenZ, point1, point2)
            Else
                PenZ = New Pen(Color.White, 1)
                point1 = New Point(I, 0)
                point2 = New Point(I, 40)
                GraphZ.DrawLine(PenZ, point1, point2)
            End If
        Next
        ' رسم النص المراد ترميزه اسفل الكود
        GraphZ.DrawString(TheText, New Font("times new roman", 12, FontStyle.Bold), New SolidBrush(Color.DarkBlue), 20, 40)
        ' ارجاع الصورة النهائية للدالة
        Code128 = bmp
    End Function
    Function Toc(ByVal Text2CStr As String) As String
        ' دالة لتعويض النص المطلوب تشفيره بالارقام للفئة 
        ' (C)
        Dim X As Integer = 1
        Dim NewText As String = ""
        Dim Z As String = ""
        Do
            Z = Mid(Text2CStr, X, 2)
            ' اضافة رقم32 لقيمة الاسكى واستعادة الحرف الناتج بعد الاضافة
            NewText = NewText & Chr(Val(Z) + 32)
            X += 2
            Z = Mid(Text2CStr, X, 1)
            If X >= Len(Text2CStr) Then Exit Do
            If Z = "" Then Exit Do
        Loop
        Toc = NewText
    End Function


    Sub deleterrecords(ByVal sqll As String)

        Dim query2 As String = "Select @@Identity"
        Using conn As New SqlClient.SqlConnection(mycon)

            Dim query As String = sqll ' " delete from  TblAllData  where txtyyears=" & txtyyearss & "  And  txtKserial=" & xtxtKseria & " "

            Using cmd As New SqlClient.SqlCommand(query, conn)



                conn.Open()

                cmd.ExecuteNonQuery()

                cmd.CommandText = query2

                cmd.ExecuteScalar()



            End Using

        End Using

    End Sub
End Module