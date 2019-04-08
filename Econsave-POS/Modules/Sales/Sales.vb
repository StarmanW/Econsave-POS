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

    Private Sub Sales_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        If transaction.totalPrice = 0 Then
            clearSelectedItems()

            db.Transactions.DeleteOnSubmit(transaction)
            db.SubmitChanges()
        End If
    End Sub

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With transaction
            .transactionID = GenerateTransactionID()
            .staffID = db.Staffs.ToList(0).staffID
            .totalPrice = 0
            .createdOn = Today
        End With

        db.Transactions.InsertOnSubmit(transaction)
        db.SubmitChanges()

        Dim rs = From i In db.Items Select
                                ID = i.itemID,
                                Name = i.name,
                                Category = i.Category.categoryName,
                                Price = i.price

        DataGridView1.DataSource = rs

        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 170
        DataGridView1.Columns(2).Width = 95
        DataGridView1.Columns(3).Width = 65

        DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(3).DefaultCellStyle.Format = "N2"
        'DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        'DataGridView1.AutoSizeColumnsMode = CType(DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnsMode)

        Dim dt As New DataTable
        dt.Columns.Add("ID")
        dt.Columns.Add("Name")
        dt.Columns.Add("Price")
        dt.Columns.Add("Quantity")
        dt.Columns.Add("Subtotal")

        DataGridView2.DataSource = dt

        DataGridView2.Columns(0).Width = 60
        DataGridView2.Columns(1).Width = 130
        DataGridView2.Columns(2).Width = 65
        DataGridView2.Columns(3).Width = 85
        DataGridView2.Columns(4).Width = 85

        DataGridView2.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        'DataGridView2.AutoSizeColumnsMode = CType(DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnsMode)

        MetroLabel4.Text = transaction.transactionID
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = DataGridView1.Rows(e.RowIndex)
            Dim selectedItemID = DataGridView1.Item(0, selectedRow.Index).Value.ToString

            'If itemSaleList.Count = 0 Then
            '    Dim itemSale As New ItemSale
            '    With itemSale
            '        .itemID = selectedItemID
            '        .transactionID = transaction.transactionID
            '        .quantity = 1
            '        .subtotal = CDbl(DataGridView1.Item(3, selectedRow.Index).Value)
            '    End With

            '    itemSaleList.Add(itemSale)

            '    '==============================================
            '    db.ItemSales.InsertOnSubmit(itemSale)
            '    db.SubmitChanges()
            'Else
            '    Dim found As Boolean = False

            'For Each tmpItemSale In itemSaleList
            '    If tmpItemSale.itemID = selectedItemID Then
            '        Dim item As New Item

            '        For Each tmpItem In itemList
            '            If tmpItem.itemID = selectedItemID Then
            '                item = tmpItem
            '                Exit For
            '            End If
            '        Next

            '        With tmpItemSale
            '            .quantity += 1
            '            .subtotal += item.price
            '        End With

            '        found = True
            '        Exit For
            '    End If
            'Next

            Dim itemSale = db.ItemSales.Where(Function(i) i.transactionID = transaction.transactionID And i.itemID = selectedItemID).FirstOrDefault

            If itemSale Is Nothing Then
                Dim newItemSale As New ItemSale
                With newItemSale
                    .itemSaleID = GenerateItemSaleID()
                    .itemID = selectedItemID
                    .transactionID = transaction.transactionID
                    .quantity = 1
                    .subtotal = CDbl(DataGridView1.Item(3, selectedRow.Index).Value)
                End With

                'itemSaleList.Add(newItemSale)

                db.ItemSales.InsertOnSubmit(newItemSale)
                db.SubmitChanges()
            Else
                itemSale.quantity += 1
                itemSale.subtotal += itemSale.Item.price
                db.SubmitChanges()
            End If
        End If

        UpdateSelectItemList()
        UpdateTotalPrice()
        UpdateTransaction()
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

    Private Sub UpdateSelectItemList()
        Dim db As New EconsaveDataClassesDataContext()
        Dim rs As New Object

        rs = From i In db.ItemSales Where i.transactionID = transaction.transactionID Select
                            ID = i.itemID,
                            Name = i.Item.name,
                            Price = i.Item.price,
                            Quantity = i.quantity,
                            Subtotal = i.subtotal

        DataGridView2.DataSource = vbNull
        DataGridView2.DataSource = rs

        DataGridView2.Columns(0).Width = 60
        DataGridView2.Columns(1).Width = 130
        DataGridView2.Columns(2).Width = 65
        DataGridView2.Columns(3).Width = 85
        DataGridView2.Columns(4).Width = 85

        DataGridView2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView2.Columns(2).DefaultCellStyle.Format = "N2"

        DataGridView2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView2.Columns(4).DefaultCellStyle.Format = "N2"

        'DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        'DataGridView2.AutoSizeColumnsMode = CType(DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnsMode)
    End Sub

    Private Sub DataGridView2_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = DataGridView2.Rows(e.RowIndex)
            Dim selectedItemID = DataGridView2.Item(0, selectedRow.Index).Value.ToString

            Dim itemSale = db.ItemSales.Where(Function(i) i.transactionID = transaction.transactionID And i.itemID = selectedItemID).FirstOrDefault

            If itemSale.quantity < 2 Then
                db.ItemSales.DeleteOnSubmit(itemSale)
                db.SubmitChanges()
            Else
                itemSale.quantity -= 1
                itemSale.subtotal -= itemSale.Item.price
                db.SubmitChanges()
            End If
        End If

        UpdateSelectItemList()
        UpdateTotalPrice()
        UpdateTransaction()
    End Sub

    Private Sub UpdateTotalPrice()
        Dim total As Double

        For i = 0 To DataGridView2.Rows.Count - 1
            total += CDbl(DataGridView2.Item(4, i).Value)
        Next

        MetroLabel1.Text = Format(total, "0.00")
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        clearSelectedItems()
        MetroLabel1.Text = "0.00"
        UpdateTransaction()
    End Sub

    Private Sub clearSelectedItems()
        Dim itemSale = db.ItemSales.Where(Function(i) i.transactionID = transaction.transactionID).ToList

        db.ItemSales.DeleteAllOnSubmit(itemSale)
        db.SubmitChanges()

        UpdateSelectItemList()

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim result As Integer = MessageBox.Show("Confirm Submission?", "", MessageBoxButtons.OKCancel)

        If result = DialogResult.OK Then
            UpdateTransaction()

            Dim newTransaction As New Transaction

            With newTransaction
                .transactionID = GenerateTransactionID()
                .staffID = db.Staffs.ToList(0).staffID
                .totalPrice = 0
                .createdOn = Today
            End With

            db.Transactions.InsertOnSubmit(newTransaction)
            transaction = newTransaction
            db.SubmitChanges()

            UpdateSelectItemList()
            MetroLabel1.Text = "0.00"
            MetroLabel4.Text = transaction.transactionID
        End If
    End Sub

    Private Sub UpdateTransaction()
        transaction.totalPrice = CDbl(MetroLabel1.Text)
        db.SubmitChanges()
    End Sub

    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileToolStripMenuItem.Click
        Me.Hide()
    End Sub
End Class