Public Class DailySalesReport
    Private Sub DailySalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using db As New EconsaveDataClassesDataContext()
            Dim dates = (From t In db.Transactions
                         Where t.createdOn = DateTime.Now
                         Order By t.createdOn Descending
                         Select t.createdOn).Distinct().ToList()

            cboDate.Items.Clear()
            For Each d In dates
                cboDate.Items.Add(d)
            Next
        End Using
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cmbTransaction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTransaction.SelectedIndexChanged
        Using db As New EconsaveDataClassesDataContext()
            Dim transaction = (From t In db.Transactions
                               Where t.transactionID Is cboTransaction.SelectedItem
                               Select t).FirstOrDefault()

            ' Set label text
            lblTransaction.Text = transaction.transactionID
            lblDate.Text = transaction.createdOn.ToLongDateString()
            lblByStaff.Text = transaction.Staff.name
            lblTotalSales.Text = $"RM{transaction.totalPrice.ToString("N2")}"

            dgvDailySales.DataSource = From itmSls In db.ItemSales
                                       Where itmSls.transactionID = cboTransaction.SelectedItem.ToString()
                                       Select
                                           Item_ID = itmSls.itemID,
                                           Item_Name = itmSls.Item.name,
                                           Price_per_Unit = itmSls.Item.price,
                                           Quantity_Sold = itmSls.quantity,
                                           Subtotal = itmSls.subtotal
        End Using
    End Sub

    Private Sub cboDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDate.SelectedIndexChanged
        Using db As New EconsaveDataClassesDataContext()
            Dim selectedDate = Date.Parse(cboDate.SelectedItem.ToString())
            Dim transactions = (From t In db.Transactions
                                Where t.createdOn.Date.Equals(selectedDate.Date)
                                Select t.transactionID).ToList()

            cboTransaction.Items.Clear()
            For Each transaction In transactions
                cboTransaction.Items.Add(transaction)
            Next
        End Using
    End Sub
End Class