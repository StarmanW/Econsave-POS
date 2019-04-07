Public Class StockReport

    Private Sub StockReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using db As New EconsaveDataClassesDataContext()
            InitializeCategoryBox(db)
            dgvStockReport.DataSource = From i In db.Items
                                        Select
                                            Item_ID = i.itemID,
                                            Item_Name = i.name,
                                            Price_per_Unit = i.price,
                                            Quanity_Available = i.stockQuantity,
                                            Status = i.status
        End Using
    End Sub

    ' Sub routine to initialize category combo box
    Private Sub InitializeCategoryBox(db As EconsaveDataClassesDataContext)
        Dim category As List(Of Category)
        category = db.Categories.ToList()

        cmbCategory.Items.Add("All")
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
            rs = From i In db.Items
                 Select
                    Item_ID = i.itemID,
                    Item_Name = i.name,
                    Price_per_Unit = i.price,
                    Quanity_Available = i.stockQuantity,
                    Status = i.status
        Else
            Dim itemCategory = CType(cmbCategory.SelectedItem, String)
            rs = From i In db.Items
                 Where i.Category.categoryName = itemCategory
                 Select
                    Item_ID = i.itemID,
                    Item_Name = i.name,
                    Price_per_Unit = i.price,
                    Quanity_Available = i.stockQuantity,
                    Status = i.status
        End If

        dgvStockReport.DataSource = rs
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Close()
    End Sub
End Class