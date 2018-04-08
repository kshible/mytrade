Public Class Fbuttons

    Private Sub Fbuttons_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Pane_btn
        makebutonsfor_alsareah(Pane_btn)
    End Sub

    'إنشاء القائمة السريعة الخاصة بأزرار البحث عن الاصناف
    Sub makebutonsfor_alsareah(ByVal pannel As Panel)


        ' Draw_pannel(pannel)



        ' pannel.BackColor = Color.Black
        'الحصول على كل البيانات من داخل الداتا جريد
        Dim sqll As String = "SELECT   IDs, Item_name, Item_sale_price FROM Itemz" ' "SELECT * from Salesdataview "
        Dim Mymatrix As DataTable
        'حيث يمكن التعامل معها بسهولةcopyDataTable  يتم نسخ داتا تيبل الى 
        Mymatrix = TheDatatables(sqll)

        'DataGridView2.DataSource = copyDataTable
        Dim colIndex As Integer = 0

        'Itemzsittingهنا يتم تسمية كل الاعمدة واعطائها ليبل من داخل جدول 





        Dim shiftx As Integer = 2
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
            calculater_boutton_alsareah.Size = New System.Drawing.Size(139, 121)




            calculater_boutton_alsareah.Location = New System.Drawing.Point(shiftx, shifty)
            shiftx += 140
            If rearrange = 5 Then
                shiftx = 2
                shifty += 122
                rearrange = 0
            End If
            'يستخدم هذا المتغير لترتيب الازرار عموديا وافقيا على اللوحة
            rearrange += 1




            '  calculater_boutton_alsareah.BackColor = SystemColors.ActiveCaption
            calculater_boutton_alsareah.ForeColor = System.Drawing.Color.Black









            pannel.Controls.Add(calculater_boutton_alsareah)

            AddHandler CType(calculater_boutton_alsareah, Button).Click, AddressOf calculater_boutton_alsareah_cclick
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


    Private Sub calculater_boutton_alsareah_cclick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()
    End Sub

    Private Sub Pane_btn_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Pane_btn.Paint

    End Sub
End Class