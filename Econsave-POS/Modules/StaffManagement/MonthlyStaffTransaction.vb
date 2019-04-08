Public Class MonthlyStaffTransaction

    ' Search employee for the month
    Private Sub MonthlyStaffTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using db As New EconsaveDataClassesDataContext()
            dgvStaffMonthlyTrans.DataSource = From t In db.Transactions
                                              Where t.createdOn.Month = 0
                                              Select
                                                  ID = t.staffID,
                                                  Name = t.Staff.name,
                                                  Total_Transaction = t.transactionID.ToArray.Length
        End Using
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged
        Using db As New EconsaveDataClassesDataContext()
            dgvStaffMonthlyTrans.DataSource = From t In db.Transactions
                                              Where t.createdOn.Month = cboMonth.SelectedIndex
                                              Select
                                                  ID = t.staffID,
                                                  Name = t.Staff.name,
                                                  Total_Transaction = t.transactionID.ToArray.Length
        End Using

        dgvStaffMonthlyTrans.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ' Print Document
    Private bitmap As Bitmap
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim height As Integer = dgvStaffMonthlyTrans.Height
        dgvStaffMonthlyTrans.Height = dgvStaffMonthlyTrans.RowCount * dgvStaffMonthlyTrans.RowTemplate.Height
        Bitmap = New Bitmap(Me.dgvStaffMonthlyTrans.Width, Me.dgvStaffMonthlyTrans.Height)
        dgvStaffMonthlyTrans.DrawToBitmap(Bitmap, New Rectangle(0, 0, Me.dgvStaffMonthlyTrans.Width, Me.dgvStaffMonthlyTrans.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 2
        PrintPreviewDialog1.ShowDialog()
        dgvStaffMonthlyTrans.Height = height
    End Sub
End Class