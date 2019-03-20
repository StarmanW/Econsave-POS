Imports System.Text.RegularExpressions

Public Class AddItem

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Populate Item Category combo box and generate Item ID
        Using db As New EconsaveDBEntities()
            GenerateItemID(db)
            InitializeCategoryBox(db)
        End Using
    End Sub

    ' Sub routine to generate item ID
    Private Sub GenerateItemID(db As EconsaveDBEntities)
        txtItemID.Text = (db.Items.Count + 1).ToString("D6")
    End Sub

    ' Sub routine to initialize category combo box
    Private Sub InitializeCategoryBox(db As EconsaveDBEntities)
        Dim category As List(Of Category)
        category = db.Categories.ToList()

        ' For loop add category
        For i = 0 To category.Count - 1
            cmbCategory.Items.Add(category(i).categoryName)
        Next
        cmbCategory.SelectedIndex = 0
    End Sub

    ' Sub routine to handle clear button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtItemName.Text = ""
        txtDescription.Text = ""
        numPrice.Value = 0
        numStockQuantity.Value = 0
        cmbCategory.SelectedIndex = 0
    End Sub

    ' Sub routine to handle add button
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If Not isValidFields() Then
            Using db As New EconsaveDBEntities()
                Dim itemCategory As String = cmbCategory.SelectedItem
                Dim newItem As New Item()

                ' Set new item property
                newItem.itemID = txtItemID.Text
                newItem.name = txtItemName.Text
                newItem.description = txtDescription.Text
                newItem.price = Double.Parse(numPrice.Value)
                newItem.stockQuantity = Int16.Parse(numStockQuantity.Value)
                newItem.createdOn = DateTime.Now
                newItem.categoryID = db.Categories.Where(Function(cat) cat.categoryName = itemCategory).FirstOrDefault().categoryID
                newItem.status = 1

                ' Add new item and save changes
                db.Items.Add(newItem)
                db.SaveChanges()

                ' Display successful message
                MessageBox.Show($"Item ({newItem.name}) has been successfully added!", "Item Added", MessageBoxButtons.OKCancel)

                ' Generate new Item ID
                GenerateItemID(db)
            End Using
        End If
    End Sub

    ' Function to validate field inputs
    Private Function isValidFields()
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