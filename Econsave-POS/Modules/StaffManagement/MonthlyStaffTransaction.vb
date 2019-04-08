Public Class MonthlyStaffTransaction

    Private Sub MonthlyStaffTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using db As New EconsaveDataClassesDataContext()
            dgvStaffMonthlyTrans.DataSource = From t In db.Transactions
                                              Where t.createdOn.Month = 0
                                              Select
                                                  Staff_ID = t.staffID,
                                                  Staff_Name = t.Staff.name,
                                                  Total_Transaction = t.transactionID.ToArray.Length
        End Using
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged
        Using db As New EconsaveDataClassesDataContext()
            dgvStaffMonthlyTrans.DataSource = From t In db.Transactions
                                              Where t.createdOn.Month = cboMonth.SelectedIndex
                                              Select
                                                  Staff_ID = t.staffID,
                                                  Staff_Name = t.Staff.name,
                                                  Total_Transaction = t.transactionID.ToArray.Length
        End Using

        dgvStaffMonthlyTrans.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class