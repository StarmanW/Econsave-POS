Imports System.Text.RegularExpressions

Public Class UpdateItem

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Populate Item Category combo box and display Item data
        Using db As New EconsaveDataClassesDataContext()
            InitializeCategoryBox(db)
            DisplayItemData(db)
        End Using
    End Sub

    ' Sub routine to initialize category combo box
    Private Sub InitializeCategoryBox(db As EconsaveDataClassesDataContext)
        Dim category As List(Of Category)
        category = db.Categories.ToList()

        ' For loop add category
        For i = 0 To category.Count - 1
            cmbCategory.Items.Add(category(i).categoryName)
        Next
        cmbCategory.SelectedIndex = 0
    End Sub

    ' Sub routine to initialize item data into text fields
    Private Sub DisplayItemData(db As EconsaveDataClassesDataContext)
        Dim item = (From i In db.Items
                    Where i.itemID = DisplayItem.itemID
                    Select i).FirstOrDefault()

        txtItemID.Text = item.itemID
        txtItemName.Text = item.name
        txtDescription.Text = item.description
        numPrice.Value = Decimal.Parse(item.price.ToString())
        numStockQuantity.Value = item.stockQuantity
        cmbCategory.SelectedIndex = cmbCategory.Items.IndexOf(item.Category.categoryName)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnUpdateItem_Click(sender As Object, e As EventArgs) Handles btnUpdateItem.Click
        If Not isValidFields() Then
            Using db As New EconsaveDataClassesDataContext()
                Dim item = (From i In db.Items
                            Where i.itemID = DisplayItem.itemID
                            Select i).FirstOrDefault()

                ' Set new item property
                item.name = txtItemName.Text
                item.description = txtDescription.Text
                item.price = Double.Parse(CType(numPrice.Value, String))
                item.stockQuantity = Int16.Parse(CType(numStockQuantity.Value, String))
                item.lastUpdate = DateTime.Now
                item.categoryID = db.Categories.Where(Function(cat) cat.categoryName = cmbCategory.SelectedItem.ToString()).FirstOrDefault().categoryID
                If item.stockQuantity = 0 Then
                    item.status = "Out-of-stock"
                Else
                    item.status = "In-stock"
                End If

                ' Update item and save changes
                db.SubmitChanges()

                ' Display successful message
                MessageBox.Show($"Item ({item.name}) has been successfully updated!", "Item Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End If
        Me.DialogResult = DialogResult.None
    End Sub

    ' Function to validate field inputs
    Private Function isValidFields() As Boolean
        Dim textRegex As New Regex("^[A-z0-9\s\-\@\#\$\%\&\*\(\)\[\]\'\:\,\.\|]+$")
        Dim hasError As Boolean = False

        ErrorProvider1.Clear()

        If Not textRegex.IsMatch(txtItemName.Text) Then
            ErrorProvider1.SetError(txtItemName, "Please ensure the item name is not blank.")
            hasError = True
        End If

        If Not textRegex.IsMatch(txtDescription.Text) Then
            ErrorProvider1.SetError(txtDescription, "Please ensure the item description is not blank.")
            hasError = True
        End If

        Return hasError
    End Function
End Class