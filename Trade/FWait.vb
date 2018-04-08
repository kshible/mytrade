Public Class FWait

    Private Sub FWait_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(658, 485)



        DGVwait.EnableHeadersVisualStyles = False
        DGVwait.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical

        DGVwait.BorderStyle = Windows.Forms.BorderStyle.None
        With DGVwait.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.MiddleCenter
            .BackColor = Color.LightGoldenrodYellow
            .ForeColor = Color.DarkBlue
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With


  
        Dim sqll As String = "SELECT     User_ID, Bill_type AS الرقم, Action_date AS التوقيت,  Item_reaceat_NO AS [رقم الانتظار] FROM  dbo.Bills  WHERE     (User_ID = 1) AND (Bill_type <= 8)"

        


        DGVwait.DataSource = TheDatatables(sqll)
        For Each GridCol As DataGridViewColumn In DGVwait.Columns
            If GridCol.Index < 2 Then
                GridCol.Visible = False
            End If
        Next


    End Sub


       
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' MsgBox(DGVwait.CurrentRow.Cells(3).Value)
    End Sub

    Private Sub DGVwait_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVwait.CellContentClick

    End Sub

    Private Sub DGVwait_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVwait.SelectionChanged
   
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        mysales.getbywasel(DGVwait.CurrentRow.Cells(3).Value)
        CType(mysales.panlformoshtriat1.Controls.Find("txtFatora", True)(0), TextBox).Text = DGVwait.CurrentRow.Cells(3).Value


        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


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
 





        Me.Close()
    End Sub
End Class