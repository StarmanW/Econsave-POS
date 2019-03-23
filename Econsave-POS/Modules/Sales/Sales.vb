Public Class Sales


    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New EconsaveDataClassesDataContext()
        Dim rs = From i In db.Items Select
                                        ItemID = i.itemID,
                                        Name = i.name,
                                        Category = i.Category.categoryName,
                                        Price = i.price
        DataGridView1.DataSource = rs

        DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(3).DefaultCellStyle.Format = "N2"
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
End Class