Public Class Sales
    Private db As New EconsaveDataClassesDataContext()
    Private itemList As List(Of Item) = (From i In db.Items Select i).ToList
    Private selectedItemList As New List(Of Item)
    Private itemSaleList As New List(Of ItemSale)
    Private transaction As New Transaction

    Private Function GenerateTransactionID() As String
        Return (db.Transactions.Count + 1).ToString("D6")
    End Function

    Private Function GenerateItemSaleID() As String
        Return (db.ItemSales.Count + 1).ToString("D6")
    End Function

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With transaction
            .transactionID = GenerateTransactionID()
            .staffID = db.Staffs.ToList(0).staffID
            .totalPrice = 0
            .createdOn = Today
        End With

        Dim rs = From i In itemList Select
                                ID = i.itemID,
                                Name = i.name,
                                Category = i.Category.categoryName,
                                Price = i.price

        DataGridView1.DataSource = rs.ToList

        DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(3).DefaultCellStyle.Format = "N2"
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridView1.AutoSizeColumnsMode = CType(DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnsMode)

        Dim dt As New DataTable
        dt.Columns.Add("ID")
        dt.Columns.Add("Name")
        dt.Columns.Add("Price")
        dt.Columns.Add("Quantity")
        dt.Columns.Add("Subtotal")

        DataGridView2.DataSource = dt

        DataGridView2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView2.Columns(2).DefaultCellStyle.Format = "N2"
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridView2.AutoSizeColumnsMode = CType(DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnsMode)
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = DataGridView1.Rows(e.RowIndex)
            Dim selectedItemID = DataGridView1.Item(0, selectedRow.Index).Value.ToString

            If itemSaleList.Count = 0 Then
                Dim itemSale As New ItemSale
                With itemSale
                    .itemID = selectedItemID
                    .transactionID = transaction.transactionID
                    .quantity = 1
                    .subtotal = CDbl(DataGridView1.Item(3, selectedRow.Index).Value)
                End With

                itemSaleList.Add(itemSale)
            Else
                Dim found As Boolean = False

                For i = 0 To itemSaleList.Count - 1
                    MessageBox.Show((itemSaleList(i).itemID = selectedItemID).ToString)

                    If found = False Then
                        If itemSaleList(i).itemID = selectedItemID Then
                            Dim item = db.Items.Where(Function(j) j.itemID Is selectedItemID).FirstOrDefault

                            With itemSaleList(i)
                                .quantity += 1
                                .subtotal += item.price
                            End With

                            found = True
                        Else
                            Dim itemSale As New ItemSale
                            With itemSale
                                .itemID = selectedItemID
                                .transactionID = transaction.transactionID
                                .quantity = 1
                                .subtotal = CDbl(DataGridView1.Item(3, selectedRow.Index).Value)
                            End With

                            itemSaleList.Add(itemSale)
                        End If
                    End If
                Next
            End If
        End If

        UpdateSelectItemList()
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Using db As New EconsaveDataClassesDataContext()
            InitializeCategoryBox(db)
        End Using
    End Sub

    ' Sub routine to initialize category combo box
    Private Sub InitializeCategoryBox(db As EconsaveDataClassesDataContext)
        Dim category As List(Of Category)
        category = db.Categories.ToList()

        cmbCategory.Items.Add("")
        ' For loop add category
        For i = 0 To category.Count - 1
            cmbCategory.Items.Add(category(i).categoryName)
        Next
        cmbCategory.SelectedIndex = 0
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        Dim db As New EconsaveDataClassesDataContext()
        Dim rs As Object

        If cmbCategory.SelectedIndex = 0 Then
            rs = From i In db.Items Select
                                ID = i.itemID,
                                Name = i.name,
                                Category = i.Category.categoryName,
                                Price = i.price
        Else
            Dim itemCategory = CType(cmbCategory.SelectedItem, String)
            rs = From i In db.Items Where i.Category.categoryName = itemCategory Select
                                ID = i.itemID,
                                Name = i.name,
                                Category = i.Category.categoryName,
                                Price = i.price
        End If

        DataGridView1.DataSource = rs
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub UpdateSelectItemList()
        Dim db As New EconsaveDataClassesDataContext()
        Dim rs As New Object

        'rs = (From i In itemSaleList Select
        '                    ID = i.itemID,
        '                    Name = i.Item.name,
        '                    Price = i.Item.price,
        '                    Quantity = i.quantity,
        '                    Subtotal = i.subtotal).ToList

        DataGridView2.DataSource = vbNull
        DataGridView2.DataSource = itemSaleList
    End Sub
End Class