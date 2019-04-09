Public Class ManagerForm
    Private Sub AddStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStaffToolStripMenuItem.Click
        AddStaff.ShowDialog()
        AddStaff.Close()
        Me.Select()
    End Sub

    Private Sub DisplayStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayStaffToolStripMenuItem.Click
        DisplayStaff.ShowDialog()
        DisplayStaff.Close()
        Me.Select()
    End Sub

    Private Sub LoginHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginHistoryToolStripMenuItem.Click
        History.ShowDialog()
        History.Close()
        Me.Select()
    End Sub

    Private Sub DailySalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailySalesToolStripMenuItem.Click
        DailySalesReport.ShowDialog()
        DailySalesReport.Close()
        Me.Select()
    End Sub

    Private Sub StockReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockReportToolStripMenuItem.Click
        StockReport.ShowDialog()
        StockReport.Close()
        Me.Select()
    End Sub

    Private Sub MonthlyStaffTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthlyStaffTransactionToolStripMenuItem.Click
        MonthlyStaffTransaction.ShowDialog()
        MonthlyStaffTransaction.Close()
        Me.Select()
    End Sub

    Private Sub ResetPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetPasswordToolStripMenuItem.Click
        ForgetPassword.ShowDialog()
        ForgetPassword.Close()
        Me.Select()
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemToolStripMenuItem.Click
        AddItem.ShowDialog()
        AddItem.Close()
        Me.Select()
    End Sub

    Private Sub DisplayItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayItemToolStripMenuItem.Click
        DisplayItem.ShowDialog()
        DisplayItem.Close()
        Me.Select()
    End Sub

    Private Sub ManagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using db As New EconsaveDataClassesDataContext
            Dim staff = db.Staffs.Where(Function(s) s.staffID = Login.staffId).FirstOrDefault()
            lblWelcome.Text = $"Welcome back, {staff.name}!"
            lblTotalStaff.Text = (db.Staffs.Count).ToString
            lblStockQty.Text = ((From i In db.Items Select i.stockQuantity).Sum()).ToString()
            lblTransaction.Text = (db.Transactions.Count).ToString
            Try
                lblRevenue.Text = $"RM {((From t In db.Transactions Select t.totalPrice).Sum).ToString("F2")}"
            Catch ex As Exception
                lblRevenue.Text = $"RM 0.00"
            End Try
        End Using
    End Sub
End Class