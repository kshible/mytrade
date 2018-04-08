

Public Class Buttonclaccez

  
    Sub rad_forward(ByVal Pnl As Panel)

        'If x_Dalel_Asnaf >= 57 Then
        '    x_Dalel_Asnaf = 75
        'End If
        'Dim Dalel_Asnaf As Integer = x_Dalel_Asnaf
      

        For Each ctl As Control In Pnl.Controls
            If (ctl.GetType() Is GetType(Button)) Then
                ctl.Name = "Dalel_Asnaf" & x_Dalel_Asnaf
                ctl.Text = "صنف" & x_Dalel_Asnaf
                ctl.Tag = x_Dalel_Asnaf
                ctl.ForeColor = Color.Blue
                CType(ctl, Button).Image = Nothing
                x_Dalel_Asnaf += 1
            End If
        Next

      

        'إضافة إيقونات من نوع صورة 
        Dim MYSQL As String = "SELECT  menue_ID, Button_name, Button_text, Button_Icon, Button_iindex, Item_ID FROM menu_Dalel  WHERE     (Button_name LIKE N'Dalel_Asnaf' + N'%') AND (Button_iindex BETWEEN " & x_Dalel_Asnaf - 18 & " AND  " & x_Dalel_Asnaf & ")"

        Dim Dalel_Asnaf_Datatable As DataTable
        Dalel_Asnaf_Datatable = TheDatatables(MYSQL)

        Dim TheButton_name As String = ""
        For w As Integer = 0 To Dalel_Asnaf_Datatable.Rows.Count - 1
            TheButton_name = LTrim(RTrim(Dalel_Asnaf_Datatable.Rows(w).Item("Button_name")))

            CType(Pnl.Controls.Find(TheButton_name, True)(0), Button).Text = LTrim(RTrim(Dalel_Asnaf_Datatable.Rows(w).Item("Button_text")))

            CType(Pnl.Controls.Find(TheButton_name, True)(0), Button).Tag = LTrim(RTrim(Dalel_Asnaf_Datatable.Rows(w).Item("Item_ID")))




            If LTrim(RTrim(Dalel_Asnaf_Datatable.Rows(w).Item("Button_Icon"))) <> "path" And LTrim(RTrim(Dalel_Asnaf_Datatable.Rows(w).Item("Button_Icon"))) <> "0" Then
                CType(Pnl.Controls.Find(TheButton_name, True)(0), Button).Image = Image.FromFile(LTrim(RTrim(Dalel_Asnaf_Datatable.Rows(w).Item("Button_Icon"))))
            End If
            CType(Pnl.Controls.Find(TheButton_name, True)(0), Button).ImageAlign = ContentAlignment.MiddleCenter
            CType(Pnl.Controls.Find(TheButton_name, True)(0), Button).TextAlign = ContentAlignment.BottomCenter




        Next



        'x_Dalel_Asnaf += 18
        'If Dalel_Asnaf >= 90 Then
        '    x_Dalel_Asnaf = 91
        'End If

    End Sub


    Sub update_qnt(ByVal Item_no As Integer, ByVal cost As Double, ByVal qnt As Double)





        Dim query2 As String = "Select @@Identity"

        Using conn As New SqlClient.SqlConnection(mycon)
            Dim query As String = "Update  Monyaction set Item_cost=@Item_cost ,current_stock=@current_stock where Action_no=@Action_no"

            Using cmd As New SqlClient.SqlCommand(query, conn)

                cmd.Parameters.Add("@Item_cost", SqlDbType.Money).Value = cost
                cmd.Parameters.Add("@Action_no", SqlDbType.Int).Value = Item_no
                cmd.Parameters.Add("@current_stock", SqlDbType.Real).Value = qnt
                'dbo.Monyaction.current_stock


                conn.Open()

                cmd.ExecuteNonQuery()

                cmd.CommandText = query2

                cmd.ExecuteScalar()



            End Using

        End Using


    End Sub


    Sub update_reset()





        Dim query2 As String = "Select @@Identity"

        Using conn As New SqlClient.SqlConnection(mycon)
            Dim query As String = "Update  Monyaction set Item_cost=@Item_cost ,current_stock=@current_stock "

            Using cmd As New SqlClient.SqlCommand(query, conn)

                cmd.Parameters.Add("@Item_cost", SqlDbType.Money).Value = 0

                cmd.Parameters.Add("@current_stock", SqlDbType.Real).Value = 0
                'dbo.Monyaction.current_stock


                conn.Open()

                cmd.ExecuteNonQuery()

                cmd.CommandText = query2

                cmd.ExecuteScalar()



            End Using

        End Using


    End Sub
   
End Class
