Public Class Buttonsetting

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CType(mysales.panlformoshtriat1.Controls.Find(txt_name.Text.Trim, True)(0), Button).Text = Txt_button.Text
      
        'sender.Image = Image.FromFile(paath1 & sender.tag)


        mysales.panlformoshtriat1.Refresh()
        deleterrecords(" delete  menu_Dalel  where Button_name='" & txt_name.Text.Trim & "'")

        add_to_menu_Dalel_table()


        fill_Comboboxes()
    End Sub
    'إضافة الى جدول menu_Dalel
    Sub add_to_menu_Dalel_table()
        'إضافة البيانات الى الجدول Monyaction
        Dim cell_currentdate As Date = Today
        Dim mesa As String = MsgBox("سيتم حفظ الصنف فى هذا الدليل", MsgBoxStyle.YesNo, "دليل الاصناف")
        Dim query2 As String = "Select @@Identity"

        If mesa = MsgBoxResult.Yes Then
            
            Using conn As New SqlClient.SqlConnection(mycon)
                Dim query As String = "Insert Into  menu_Dalel  (Button_name,Button_text,Button_Icon,Item_ID,Button_iindex) Values (@Button_name, @Button_text ,@Button_Icon ,@Item_ID,@Button_iindex)"
                Using cmd As New SqlClient.SqlCommand(query, conn)


                    cmd.Parameters.Add("@Button_name", SqlDbType.NChar).Value = txt_name.Text.Trim
                    cmd.Parameters.Add("@Button_text", SqlDbType.NVarChar).Value = Txt_button.Text.Trim
                    cmd.Parameters.Add("@Button_Icon", SqlDbType.NChar).Value = picture_path.Text.Trim
                    cmd.Parameters.Add("@Item_ID", SqlDbType.Int).Value = CInt(txt_item_ID.Text)
                    cmd.Parameters.Add("@Button_iindex", SqlDbType.Int).Value = CInt(Txt_index.Text.Trim)



                    conn.Open()

                    cmd.ExecuteNonQuery()

                    cmd.CommandText = query2

                    cmd.ExecuteScalar()



                End Using
            End Using
            MsgBox("Done")
            txt_item_ID.Text = -1
        End If
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Txt_button.Text = ComboBox2.Text

        txt_name.Text = ComboBox1.Items.Item(ComboBox2.SelectedIndex)

        '  Txt_index.Text = ComboBox1.Items.Add(CType(mysales.panlformoshtriat1.Controls.Find(ctl.Name.Trim, True)(0), Button).tag)
    End Sub

    Private Sub Buttonsetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fill_Comboboxes()
        Me.Location = New System.Drawing.Point(50, 100)
        txt_item_ID.Text = -1
    End Sub

    Sub fill_Comboboxes()

        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        For Each ctl As Control In mysales.panlformoshtriat1.Controls
            If (ctl.GetType() Is GetType(Button)) And ctl.Text <> "" Then
                ComboBox2.Items.Add(CType(mysales.panlformoshtriat1.Controls.Find(ctl.Name.Trim, True)(0), Button).Text)

                ComboBox1.Items.Add(CType(mysales.panlformoshtriat1.Controls.Find(ctl.Name.Trim, True)(0), Button).Name)
            End If

        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button2_CursorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.CursorChanged

    End Sub

    Private Sub Button2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseDown

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim open As New OpenFileDialog()
        open.Filter = "Image Files(*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp"
        If open.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = System.IO.Path.GetFullPath(open.FileName)
            picture_path.Text = fileName
            PictureBox1.Image = New Bitmap(open.FileName)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
            CType(mysales.panlformoshtriat1.Controls.Find(txt_name.Text.Trim, True)(0), Button).Image = PictureBox1.Image
            CType(mysales.panlformoshtriat1.Controls.Find(txt_name.Text.Trim, True)(0), Button).ImageAlign = ContentAlignment.TopCenter
            CType(mysales.panlformoshtriat1.Controls.Find(txt_name.Text.Trim, True)(0), Button).TextAlign = ContentAlignment.BottomCenter


        End If
    End Sub

    Private Sub txt_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_name.TextChanged
        'Txt_index.Text = ComboBox1.Items.Add(CType(mysales.panlformoshtriat1.Controls.Find(txt_name.Text.Trim, True)(0), Button).Tag)

        Dim InputString As String = txt_name.Text ' "Mr. albert jhon 3423211 bot besan uk"
        Dim Result As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(InputString, "\d+")
        '  MsgBox(Result.Value)
        Txt_index.Text = Result.Value
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


   
    Dim rs As New Resizer

    Private Sub Button4_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Buttonsetting_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
      
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
       
    End Sub

    Private Sub DataGridView1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Enter
       
    End Sub

    Private Sub txt_get_itemz_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_get_itemz.TextChanged
        'إضافة إيقونات من نوع صورة 
        Dim MYSQL As String = " SELECT     dbo.Itemz.Item_name, dbo.Baracode_Items.Item_Baracode, dbo.Itemz.IDs  FROM  dbo.Itemz INNER JOIN  dbo.Baracode_Items ON dbo.Itemz.IDs = dbo.Baracode_Items.IDs  WHERE  (dbo.Baracode_Items.Item_Baracode = N'" & txt_get_itemz.Text.Trim & "') OR      (dbo.Itemz.Item_name  LIKE N'" & txt_get_itemz.Text.Trim & "' + N'%')"
        ' (dbo.Baracode_Items.Item_Baracode = N'" & txt_get_itemz.Text.Trim & "') OR
        'Dim barcode_forButtons As DataTable
        'barcode_forButtons = TheDatatables(MYSQL)

        Me.DataGridView1.DataSource = TheDatatables(MYSQL)
    End Sub

    Private Sub DataGridView1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseDoubleClick
        Txt_button.Text = Me.DataGridView1.CurrentRow.Cells("Item_name").Value
        txt_item_ID.Text = CInt(Me.DataGridView1.CurrentRow.Cells("IDs").Value)
    End Sub

    Private Sub Button4_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "إنشاء تفرع" Then

            Button4.Text = "ربط بأصناف"
            Me.DataGridView1.Visible = False
            Label3.Visible = False
            txt_get_itemz.Visible = False
            Me.Height = 206
            txt_item_ID.Text = -1
        Else
            Button4.Text = "إنشاء تفرع"
            Me.DataGridView1.Visible = True
            Label3.Visible = True
            txt_get_itemz.Visible = True
            Me.Height = 433
        End If
    End Sub
End Class