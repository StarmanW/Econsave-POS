Public Class ManagerForm
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStaffToolStripMenuItem.Click
        AddStaff.ShowDialog()
        AddStaff.Close()
    End Sub

    Private Sub DisplayStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayStaffToolStripMenuItem.Click
        DisplayStaff.ShowDialog()
        DisplayStaff.Close()
    End Sub

    Private Sub LoginHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginHistoryToolStripMenuItem.Click
        History.ShowDialog()
        History.Close()
    End Sub

    Private Sub DailySalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailySalesToolStripMenuItem.Click

    End Sub

    Private Sub StockReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockReportToolStripMenuItem.Click
        StockReport.ShowDialog()
        StockReport.Close()
    End Sub

    Private Sub MonthlyStaffTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthlyStaffTransactionToolStripMenuItem.Click
        MonthlyStaffTransaction.ShowDialog()
        MonthlyStaffTransaction.Close()
    End Sub
End Class