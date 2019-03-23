Public Class RetrieveStaff
    Private Sub RetrieveStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EconsaveDBDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.EconsaveDBDataSet.Staff)

    End Sub
End Class