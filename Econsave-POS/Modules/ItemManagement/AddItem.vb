Imports System.Text.RegularExpressions

Public Class AddItem

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Populate Item Category combo box and generate Item ID
        Using db As New EconsaveDataClassesDataContext()
            GenerateItemID(db)
            InitializeCategoryBox(db)
        End Using
    End Sub

    ' Sub routine to generate item ID
    Private Sub GenerateItemID(db As EconsaveDataClassesDataContext)
        txtItemID.Text = $"IT{(db.Items.Count + 1).ToString("D6")}"
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
        If isValidFields() Then
            Using db As New EconsaveDataClassesDataContext()
                Dim itemCategory As String = CType(cmbCategory.SelectedItem, String)
                Dim newItem As New Item()

                ' Set new item property
                newItem.itemID = txtItemID.Text
                newItem.name = txtItemName.Text
                newItem.description = txtDescription.Text
                newItem.price = Double.Parse(CType(numPrice.Value, String))
                newItem.stockQuantity = Int16.Parse(CType(numStockQuantity.Value, String))
                newItem.createdOn = DateTime.Now
                newItem.categoryID = db.Categories.Where(Function(cat) cat.categoryName = itemCategory).FirstOrDefault().categoryID
                If newItem.stockQuantity = 0 Then
                    newItem.status = "Out-of-stock"
                Else
                    newItem.status = "In-stock"
                End If

                ' Add new item and save changes
                db.Items.InsertOnSubmit(newItem)
                db.SubmitChanges()

                ' Display successful message
                MessageBox.Show($"Item ({newItem.name}) has been successfully added!", "Item Added", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Generate new Item ID
                GenerateItemID(db)
            End Using
        End If
    End Sub

    ' Function to validate field inputs
    Private Function isValidFields() As Boolean
        Dim textRegex As New Regex("^[A-z0-9\s\-\@\#\$\%\&\*\(\)\[\]\'\:\,\.\|]+$")
        Dim validData As Boolean = True

        ErrorProvider1.Clear()

        If Not textRegex.IsMatch(txtItemName.Text) Then
            ErrorProvider1.SetError(txtItemName, "Please ensure the item name is not blank.")
            validData = False
        End If

        If Not textRegex.IsMatch(txtDescription.Text) Then
            ErrorProvider1.SetError(txtDescription, "Please ensure the item description is not blank.")
            validData = False
        End If

        Return validData
    End Function

    Private Sub DisplayItemListToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        DisplayItem.ShowDialog()
        DisplayItem.Close()
        Me.Show()
    End Sub
End Class