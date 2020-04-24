

Module ListView_Control

    Friend Sub Load_Sale_item(ByVal imagelist_name As ImageList, ByVal listview_name As ListView, ByVal datatable_query As DataTable, ByVal imageError_Path As Image, ByVal columnName_picture As String, ByVal columnName_ID_Product As String, ByVal columnName_Name_product As String)
        Dim amount_row As Integer = datatable_query.Rows.Count - 1
        Dim img As Image
        Dim img_array As Byte()
        imagelist_name.Images.Clear()
        listview_name.Items.Clear()
        For idx As Integer = 0 To amount_row
            Try
                img_array = datatable_query.Rows(idx)(columnName_picture)
                Dim mem As New System.IO.MemoryStream
                mem.Write(img_array, 0, img_array.Length)
                img = Image.FromStream(mem, True)
                imagelist_name.Images.Add(Image.FromStream(mem, True))

            Catch ex As Exception
                imagelist_name.Images.Add(imageError_Path)
            End Try
            Dim name_picture As String = datatable_query.Rows(idx)(columnName_ID_Product) & " | " & datatable_query.Rows(idx)(columnName_Name_product)
            listview_name.Items.Add(name_picture, idx)
            listview_name.Refresh()
        Next
    End Sub

    Friend Function Sum_Column_Normal(ByVal listview_name As ListView, ByVal Index_column As Integer)
        Dim result As Double = 0
        Dim i As Integer = listview_name.Items.Count - 1
        For j As Integer = 0 To i
            result += CType(listview_name.Items(j).SubItems(Index_column).Text, Double)
        Next
        Return result
    End Function


    Friend Function Sum_Column_Currency(ByVal listview_name As ListView, ByVal Index_column As Integer)
        Dim result As Double = 0
        Dim i As Integer = listview_name.Items.Count - 1
        For j As Integer = 0 To i
            result += CType(listview_name.Items(j).SubItems(Index_column).Text, Double)
        Next
        Return FormatNumber(result)
    End Function



    Friend Function Average_Column(ByVal listview_name As ListView, ByVal Index_column As Integer)
        Dim result As Double = 0
        Dim i As Integer = listview_name.Items.Count - 1
        For j As Integer = 0 To i
            result += CType(listview_name.Items(j).SubItems(Index_column).Text, Double)
        Next
        result = result / i
        Return FormatNumber(result)
    End Function




End Module
