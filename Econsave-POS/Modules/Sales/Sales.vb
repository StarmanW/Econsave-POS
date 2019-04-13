Public Class Sales
    Private db As New EconsaveDataClassesDataContext()
    Private transaction As New Transaction

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

        InitDgvItems()
        SetDgvItems()

        InitDgvSelectedItems()
        SetDgvSelectedItems()

        lblTransactionID.Text = transaction.transactionID
    End Sub

    Private Sub dgvItems_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvItems.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = dgvItems.Rows(e.RowIndex)
            Dim selectedItemID = dgvItems.Item(0, selectedRow.Index).Value.ToString

            If CDbl(dgvItems.Item(3, selectedRow.Index).Value) <> 0 Then
                Dim itemSale =
                    db.ItemSales.Where(
                        Function(i) i.transactionID = transaction.transactionID And i.itemID = selectedItemID
                    ).FirstOrDefault
                Dim item = db.Items().Where(Function(i) i.itemID = selectedItemID).FirstOrDefault()

                If itemSale Is Nothing Then
                    Dim newItemSale As New ItemSale
                    With newItemSale
                        .itemSaleID = GenerateItemSaleID()
                        .itemID = selectedItemID
                        .transactionID = transaction.transactionID
                        .quantity = 1
                        .subtotal = CDbl(dgvItems.Item(4, selectedRow.Index).Value)
                    End With

                    item.stockQuantity -= 1

                    db.ItemSales.InsertOnSubmit(newItemSale)
                    db.SubmitChanges()
                Else
                    itemSale.quantity += 1
                    itemSale.subtotal += itemSale.Item.price
                    item.stockQuantity -= 1
                    db.SubmitChanges()
                End If
            Else
                MessageBox.Show(
                    "Item already out-of-stock",
                    "Out-of-Stock",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                )
            End If

        End If

        UpdateItemList()
        UpdateSelectItemList()
        UpdateTotalPrice()
        UpdateTransaction()
    End Sub

    Private Sub dgvSelectedItems_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSelectedItems.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = dgvSelectedItems.Rows(e.RowIndex)
            Dim selectedItemID = dgvSelectedItems.Item(0, selectedRow.Index).Value.ToString
            Dim item = db.Items.Where(Function(i) i.itemID = selectedItemID).FirstOrDefault()

            Dim itemSale = db.ItemSales.Where(Function(i) i.transactionID = transaction.transactionID And i.itemID = selectedItemID).FirstOrDefault

            If itemSale.quantity < 2 Then
                item.stockQuantity += 1
                db.ItemSales.DeleteOnSubmit(itemSale)
                db.SubmitChanges()
            Else
                item.stockQuantity += 1
                itemSale.quantity -= 1
                itemSale.subtotal -= itemSale.Item.price
                db.SubmitChanges()
            End If
        End If

        UpdateItemList()
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

    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        UpdateItemList()
    End Sub

    Private Sub UpdateItemList()
        Dim rs As Object

        If cmbCategory.SelectedIndex = 0 Then
            rs = From i In db.Items Select
                                ID = i.itemID,
                                Name = i.name,
                                Category = i.Category.categoryName,
                                Quantity = i.stockQuantity,
                                Price = i.price
        Else
            Dim itemCategory = CType(cmbCategory.SelectedItem, String)
            rs = From i In db.Items Where i.Category.categoryName = itemCategory Select
                                ID = i.itemID,
                                Name = i.name,
                                Category = i.Category.categoryName,
                                Quantity = i.stockQuantity,
                                Price = i.price
        End If

        dgvItems.DataSource = vbNull
        dgvItems.DataSource = rs

        SetDgvItems()
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

        dgvSelectedItems.DataSource = vbNull
        dgvSelectedItems.DataSource = rs

        SetDgvSelectedItems()
    End Sub

    Private Sub UpdateTotalPrice()
        Dim total As Double

        For i = 0 To dgvSelectedItems.Rows.Count - 1
            total += CDbl(dgvSelectedItems.Item(4, i).Value)
        Next

        lblTotalValue.Text = Format(total, "0.00")
    End Sub

    Private Sub UpdateTransaction()
        transaction.totalPrice = CDbl(lblTotalValue.Text)
        db.SubmitChanges()
    End Sub

    Private Sub clearSelectedItems()
        Dim itemSale =
            db.ItemSales.Where(
                Function(i) i.transactionID = transaction.transactionID
            ).ToList

        For Each item In itemSale
            Dim dbItem = (From i In db.Items Where i.itemID = item.itemID Select i).FirstOrDefault
            dbItem.stockQuantity += item.quantity
        Next

        db.ItemSales.DeleteAllOnSubmit(itemSale)
        db.SubmitChanges()

        UpdateItemList()
        UpdateSelectItemList()
    End Sub

    Private Sub InitDgvItems()
        Dim rs = From i In db.Items Select
                                        ID = i.itemID,
                                        Name = i.name,
                                        Category = i.Category.categoryName,
                                        Quantity = i.stockQuantity,
                                        Price = i.price

        dgvItems.DataSource = rs
    End Sub

    Private Sub SetDgvItems()
        With dgvItems
            .Columns(0).Width = 60
            .Columns(1).Width = 172
            .Columns(2).Width = 96
            With .Columns(3)
                .Width = 81
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End With
            With .Columns(4)
                .Width = 61
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
            End With
        End With
    End Sub

    Private Sub SetDgvSelectedItems()
        With dgvSelectedItems
            .Columns(0).Width = 60
            .Columns(1).Width = 130
            With .Columns(2)
                .Width = 65
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
            End With
            With .Columns(3)
                .Width = 85
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End With
            With .Columns(4)
                .Width = 85
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
            End With
        End With
    End Sub

    Private Sub InitDgvSelectedItems()
        Dim dt As New DataTable

        With dt.Columns
            .Add("ID")
            .Add("Name")
            .Add("Price")
            .Add("Quantity")
            .Add("Subtotal")
        End With

        dgvSelectedItems.DataSource = dt
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
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
            lblTotalValue.Text = "0.00"
            lblTransactionID.Text = transaction.transactionID
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearSelectedItems()
        lblTotalValue.Text = "0.00"
        UpdateTransaction()
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        Me.Close()
    End Sub

    Private Function GenerateTransactionID() As String
        Return (db.Transactions.Count + 1).ToString("D6")
    End Function

    Private Function GenerateItemSaleID() As String
        Return (db.ItemSales.Count + 1).ToString("D6")
    End Function
End Class