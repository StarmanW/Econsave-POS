Public Class Sales
    Private selectedItem As New List(Of Item)
    Private db As New EconsaveDataClassesDataContext()
    Private itemList As List(Of Item) = (From i In db.Items Select i).ToList

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rs = From i In itemList Select
                                ItemID = i.itemID,
                                Name = i.name,
                                Category = i.Category.categoryName,
                                Price = i.price

        DataGridView1.DataSource = rs.ToList

        DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(3).DefaultCellStyle.Format = "N2"
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridView1.AutoSizeColumnsMode = CType(DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnsMode)
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = DataGridView1.Rows(e.RowIndex)

            For i = 0 To itemList.Count - 1
                If itemList(i).itemID = (DataGridView1.Item(0, selectedRow.Index).Value).ToString Then
                    selectedItem.Add(itemList(i))
                End If
            Next
            'selectedItem.Add((DataGridView1.Item(0, selectedRow.Index).Value).ToString)
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
                                ItemID = i.itemID,
                                Name = i.name,
                                Category = i.Category.categoryName,
                                Price = i.price
        Else
            Dim itemCategory = CType(cmbCategory.SelectedItem, String)
            rs = From i In db.Items Where i.Category.categoryName = itemCategory Select
                                ItemID = i.itemID,
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



        rs = (From i In selectedItem Select
                            ItemID = i.itemID,
                            Name = i.name,
                            Price = i.price).ToList

        DataGridView2.DataSource = rs
    End Sub

    Private Sub SortSelectedItems()

    End Sub
End Class