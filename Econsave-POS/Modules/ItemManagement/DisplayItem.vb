Public Class DisplayItem
    Private Sub DisplayItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EconsaveDBDataSet.Item' table. You can move, or remove it, as needed.
        Dim db As New EconsaveDataClassesDataContext()
        Dim rs = From i In db.Items Select
                                        i.itemID,
                                        i.name,
                                        i.description,
                                        i.Category.categoryName,
                                        i.price,
                                        i.stockQuantity,
                                        i.createdOn,
                                        i.lastUpdate
        itemDGV.DataSource = rs
    End Sub
End Class