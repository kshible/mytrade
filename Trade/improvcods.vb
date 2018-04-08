Public Class improvcods

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListView1.Bounds = New Rectangle(New Point(10, 10), New Size(300, 200))

        ' Set the view to show details.
        ListView1.View = View.Details
        ' Allow the user to edit item text.
        ListView1.LabelEdit = True
        ' Allow the user to rearrange columns.
        ListView1.AllowColumnReorder = True
        ' Display check boxes.
        ' ListView1.CheckBoxes = True
        ' Select the item and subitems when selection is made.
        ListView1.FullRowSelect = True
        ' Display grid lines.
        ListView1.GridLines = True
        ' Sort the items in the list in ascending order.
        ListView1.Sorting = SortOrder.Ascending

        ' Create three items and three sets of subitems for each item.
        Dim item1 As New ListViewItem("الصنف", 0)
        ' Place a check mark next to the item.
        ' item1.Checked = True
        item1.SubItems.Add("1")
        item1.SubItems.Add("2")
        item1.SubItems.Add("3")
        Dim item2 As New ListViewItem("item2", 1)
        item2.SubItems.Add("4")
        item2.SubItems.Add("5")
        item2.SubItems.Add("6")
        Dim item3 As New ListViewItem("item3", 2)
        ' Place a check mark next to the item.
        '  item3.Checked = True
        item3.SubItems.Add("7")
        item3.SubItems.Add("8")
        item3.SubItems.Add("9")

        ' Create columns for the items and subitems.
        ' Width of -2 indicates auto-size.
        ListView1.Columns.Add("Item Column", -2, HorizontalAlignment.Right)
        ListView1.Columns.Add("Column 2", -2, HorizontalAlignment.Right)
        ListView1.Columns.Add("Column 3", -2, HorizontalAlignment.Right)
        ListView1.Columns.Add("Column 4", -2, HorizontalAlignment.Right)

        'Add the items to the ListView.
        ListView1.Items.AddRange(New ListViewItem() {item1, item2, item3})

        ' Create two ImageList objects.
        'Dim imageListSmall As New ImageList()
        'Dim imageListLarge As New ImageList()

        ' Initialize the ImageList objects with bitmaps.
        'imageListSmall.Images.Add(Bitmap.FromFile("C:\MySmallImage1.bmp"))
        'imageListSmall.Images.Add(Bitmap.FromFile("C:\MySmallImage2.bmp"))
        'imageListLarge.Images.Add(Bitmap.FromFile("C:\MyLargeImage1.bmp"))
        'imageListLarge.Images.Add(Bitmap.FromFile("C:\MyLargeImage2.bmp"))

        'Assign the ImageList objects to the ListView.
        'ListView1.LargeImageList = imageListLarge
        'ListView1.SmallImageList = imageListSmall

        ' Add the ListView to the control collection.
        Me.Controls.Add(ListView1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListView1.Items.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim i As ListViewItem

        'i = ListView1.SelectedItems(0)
        ''  i.Text = TextBox1.Text
        'i.SubItems.Item(2).Text = "fggff"
        '' ListView1.Items(4).SubItems(2).Text = "foo"



        'If ListView1.SelectedIndices.Count > 0 Then
        '    TextBox1.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(1).Text
        'End If


        'For Each MyListViewItem As ListViewItem In ListView1.Items
        '    MsgBox(MyListViewItem.SubItems(0).Text)
        'Next



        '  MsgBox(ListView1.Columns(1).Name)




        'Dim i() As String = {"Email ID", "Phone", "Address"}
        'Dim k As Integer = 0
        'For Each LWC As ColumnHeader In ListView1.Columns

        '    LWC.Text = i(k)
        '    k += 1
        'Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListView1.Items.RemoveAt(0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListView1.Items.Add("List item text", 3)
    End Sub

    Private Sub improvcods_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
