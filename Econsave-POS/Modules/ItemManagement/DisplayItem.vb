Public Class DisplayItem

    Friend itemID As String

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

        cmbCategory.Items.Add("All")
        ' For loop add category
        For i = 0 To category.Count - 1
            cmbCategory.Items.Add(category(i).categoryName)
        Next
        cmbCategory.SelectedIndex = 0
    End Sub

    Private Sub DisplayItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New EconsaveDataClassesDataContext()
        Dim rs = From i In db.Items Select
                                        ID = i.itemID,
                                        Name = i.name,
                                        Description = i.description,
                                        Category = i.Category.categoryName,
                                        Price = Format(i.price, "0.00"),
                                        Quantity = i.stockQuantity,
                                        Created_On = i.createdOn,
                                        Last_Update = i.lastUpdate
        itemDGV.DataSource = rs
        itemDGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        itemDGV.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        Dim db As New EconsaveDataClassesDataContext()
        Dim rs As Object

        If cmbCategory.SelectedIndex = 0 Then
            rs = From i In db.Items Select
                                        ID = i.itemID,
                                        Name = i.name,
                                        Description = i.description,
                                        Category = i.Category.categoryName,
                                        Price = Format(i.price, "0.00"),
                                        Quantity = i.stockQuantity,
                                        Created_On = i.createdOn,
                                        Last_Update = i.lastUpdate
        Else
            Dim itemCategory = CType(cmbCategory.SelectedItem, String)
            rs = From i In db.Items Where i.Category.categoryName = itemCategory Select
                                        ID = i.itemID,
                                        Name = i.name,
                                        Description = i.description,
                                        Category = i.Category.categoryName,
                                        Price = Format(i.price, "0.00"),
                                        Quantity = i.stockQuantity,
                                        Created_On = i.createdOn,
                                        Last_Update = i.lastUpdate
        End If

        itemDGV.DataSource = rs
        itemDGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        itemDGV.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub itemDGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles itemDGV.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = itemDGV.Rows(e.RowIndex)
            itemID = CType(itemDGV.Item(0, selectedRow.Index).Value, String)
            UpdateItem.ShowDialog()
            UpdateItem.Close()
            DisplayItem_Load(sender, e)
        End If
    End Sub

    Private Sub txtSearchBox_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearchBox.KeyUp
        Dim searchStr = txtSearchBox.Text
        Dim db As New EconsaveDataClassesDataContext()
        Dim rs As Object

        ' Only do this query if search box is not empty
        If Not searchStr.Equals("") Then
            If cmbCategory.SelectedIndex = 0 Then
                rs = From i In db.Items Where i.description.Contains(searchStr) Or i.name.Contains(searchStr) Select
                                        ID = i.itemID,
                                        Name = i.name,
                                        Description = i.description,
                                        Category = i.Category.categoryName,
                                        Price = Format(i.price, "0.00"),
                                        Quantity = i.stockQuantity,
                                        Created_On = i.createdOn,
                                        Last_Update = i.lastUpdate
            Else
                Dim itemCategory = CType(cmbCategory.SelectedItem, String)
                rs = From i In db.Items Where i.Category.categoryName = itemCategory And (i.description.Contains(searchStr) Or i.name.Contains(searchStr)) Select
                                        ID = i.itemID,
                                        Name = i.name,
                                        Description = i.description,
                                        Category = i.Category.categoryName,
                                        Price = Format(i.price, "0.00"),
                                        Quantity = i.stockQuantity,
                                        Created_On = i.createdOn,
                                        Last_Update = i.lastUpdate
            End If
        Else
            If cmbCategory.SelectedIndex = 0 Then
                rs = From i In db.Items Select
                                        ID = i.itemID,
                                        Name = i.name,
                                        Description = i.description,
                                        Category = i.Category.categoryName,
                                        Price = Format(i.price, "0.00"),
                                        Quantity = i.stockQuantity,
                                        Created_On = i.createdOn,
                                        Last_Update = i.lastUpdate
            Else
                Dim itemCategory = CType(cmbCategory.SelectedItem, String)
                rs = From i In db.Items Where i.Category.categoryName = itemCategory Select
                                        ID = i.itemID,
                                        Name = i.name,
                                        Description = i.description,
                                        Category = i.Category.categoryName,
                                        Price = Format(i.price, "0.00"),
                                        Quantity = i.stockQuantity,
                                        Created_On = i.createdOn,
                                        Last_Update = i.lastUpdate
            End If
        End If
        itemDGV.DataSource = rs

        itemDGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        itemDGV.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Close()
    End Sub
End Class