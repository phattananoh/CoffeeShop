'อย่าลืม กด LIKE FanPage ของ Admin ที่ : http://www.facebook.com/vbpossible
'กด SubScribe Chanel Youtube ที่ : https://www.youtube.com/channel/UCZ8934MylOAyG2ddaR7lOGA
'เพื่อรับเเทคนิคและความรู้ดี ๆ จาก VBPossible

Module ListView_Control
#Region "อธิบายวิธีการใช้งาน Sub Load_Sale_item"
    '??? เอาไว้ใช้ทำอะไร
    '     ดึงข้อมูลสินค้าจากฐานข้อมูล มาแสดงในรูปแบบ ตารางภาพ โดยใช้ Listview คู่กับ ImageList 

    ' หลักการทำงานของ Load_Sale_item คือ
    '1. โหลดข้อมูลภาพจากฐานข้อมูล ทั้งหมด จากนั้นเอาไปเก็บไว้ใน Image List
    '2. ให้ ListView ดึงรูปภาพจาก ImageList อีกทีนึง
    '3. ถ้าไม่มีรูปภาพในฐานข้อมูล ก็ให้แสดงภาพใน imageError_Path แทน

    ' อธิบาย parameter และ object ที่ต้องใช้
    '1. ต้องการ ImageList 1 ตัว สำหรับเก็บภาพ สินค้า ที่ดึงมากจากฐานข้อมูล
    ''       เปลี่ยน Properties : ColorDepth = Depth32Bit
    ''       เปลี่ยน Properties : Size = 70-120 (ขนาดภาพที่จะแสดง เลือกตามความเหมาะสม
    '2. ต้องการ ListView 1 ตัว สำหรับดึงภาพใน ImageList มาแสดงอีกที
    ''       เปลี่ยน Properties : Large ImageList = ชื่อของ ImageList ที่เราสร้างไว้ในข้อ 1
    '3. datatable_query คือ ตารางที่เก็บข้อมูลของ Product ซึ่งเรา query มาจากฐานข้อมูลอีกที
    ''       ในโค้ด sql ให้ query ข้อมูล 3 อย่างได้แก่ รหัสสินค้า / ชื่อสินค้า / ภาพสินค้า
    '4. Image_ErrorPath คือ ที่อยู่รูปภาพที่จะให้แสดง ในกรณีที่ Product บางตัวไม่มีรูปภาพในฐานข้อมูล
    '5. ColumnName_Picture คือ ชื่อ Column ที่เก็บรูปภาพสินค้าเอาไว้ (ตามข้อ 3)
    '6. ColumnName_ID_Product คือ ชื่อ Column ที่เก็บรหัสสินค้า เอาไว้ (ตามข้อ 3)
    '7. ColumnName_Name_Product คือ ชื่อ Column ที่เก็บชื่อสินค้า เอาไว้ (ตามข้อ 3)
#End Region
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
#Region "อธิบายวิธีการใช้งาน Function Sum_Column_Normal"
    '??? เอาไว้ใช้ทำอะไร
    '   หาผลรวมใน column listview ที่กำหนด และ returen ค่่ากลับไปเป็น integer (จำนวนเต็ม)

    ' หลักการทำงานของ Sum_Column_Normal คือ
    '1. ใช้ For วนรอบจนครบทุกแถวของ ListView
    '2. ระหว่างวนไปแต่ละแถว เราจะบวกจำนวนในคอลัมภ์ไปด้วย
    '3. จะ Return ค่า กลับเป็น integer

    ' อธิบาย parameter และ object ที่ต้องใช้
    '1. listview_name คือ ชื่่อของ ListView ที่ต้องการจะหาผลรวม
    '2. Index_column คือ ลำดับ SubItem หรือ Column ของ ListView(ข้อ1) ที่ต้องการจะหาผลรวม

#End Region
    Friend Function Sum_Column_Normal(ByVal listview_name As ListView, ByVal Index_column As Integer)
        Dim result As Double = 0
        Dim i As Integer = listview_name.Items.Count - 1
        For j As Integer = 0 To i
            result += CType(listview_name.Items(j).SubItems(Index_column).Text, Double)
        Next
        Return result
    End Function
#Region "อธิบายวิธีการใช้งาน Function Sum_Column_Currentcy"
    '??? เอาไว้ใช้ทำอะไร
    '   หาผลรวมใน column listview ที่กำหนด และ returen ค่่ากลับไปเป็น Double (ทศนิยม)

    ' หลักการทำงานของ Sum_Column_Currentcy คือ
    '1. ใช้ For วนรอบจนครบทุกแถวของ ListView
    '2. ระหว่างวนไปแต่ละแถว เราจะบวกจำนวนในคอลัมภ์ไปด้วย
    '3. จะ Return ค่า กลับเป็น Double ทศนิยม

    ' อธิบาย parameter และ object ที่ต้องใช้
    '1. listview_name คือ ชื่่อของ ListView ที่ต้องการจะหาผลรวม
    '2. Index_column คือ ลำดับ SubItem หรือ Column ของ ListView(ข้อ1) ที่ต้องการจะหาผลรวม

#End Region

    Friend Function Sum_Column_Currency(ByVal listview_name As ListView, ByVal Index_column As Integer)
        Dim result As Double = 0
        Dim i As Integer = listview_name.Items.Count - 1
        For j As Integer = 0 To i
            result += CType(listview_name.Items(j).SubItems(Index_column).Text, Double)
        Next
        Return FormatNumber(result)
    End Function

#Region "อธิบายวิธีการใช้งาน Function Average_Column"

    '??? เอาไว้ใช้ทำอะไร
    '   หาค่าเฉลี่ยใน column listview ที่กำหนด และ return ค่่ากลับไปเป็น Double (ทศนิยม)

    ' หลักการทำงานของ Average_Column คือ
    '1. ใช้ For วนรอบจนครบทุกแถวของ ListView
    '2. ระหว่างวนไปแต่ละแถว เราจะบวกจำนวนในคอลัมภ์ไปด้วย
    '3. นำจำนวนที่บวก มาหารกับจำนวน ข่้อมูลทั้งหมด
    '4. Return ค่าเฉลี่ยกลับไป

    ' อธิบาย parameter และ object ที่ต้องใช้
    '1. listview_name คือ ชื่่อของ ListView ที่ต้องการจะหาผลรวม
    '2. Index_column คือ ลำดับ SubItem หรือ Column ของ ListView(ข้อ1) ที่ต้องการจะหาผลรวม

#End Region

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
