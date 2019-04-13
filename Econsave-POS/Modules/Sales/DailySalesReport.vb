Imports System.Text

Public Class DailySalesReport
    Private Sub DailySalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using db As New EconsaveDataClassesDataContext()
            Dim dates = (From t In db.Transactions
                         Order By t.createdOn Descending
                         Select t.createdOn).Distinct().ToList()

            cboDate.Items.Clear()
            For Each d In dates
                cboDate.Items.Add(d)
            Next
        End Using

        Dim dt As New DataTable
        dt.Columns.Add("ID")
        dt.Columns.Add("Name")
        dt.Columns.Add("Price")
        dt.Columns.Add("Quantity")
        dt.Columns.Add("Subtotal")

        dgvDailySales.DataSource = dt

        dgvDailySales.Columns(0).Width = 60
        dgvDailySales.Columns(1).Width = 130
        dgvDailySales.Columns(2).Width = 65
        dgvDailySales.Columns(3).Width = 85
        dgvDailySales.Columns(4).Width = 85

        dgvDailySales.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDailySales.Columns(2).DefaultCellStyle.Format = "N2"

        dgvDailySales.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDailySales.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDailySales.Columns(4).DefaultCellStyle.Format = "N2"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cmbTransaction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTransaction.SelectedIndexChanged
        dgvDailySales.Columns(0).Width = 60
        dgvDailySales.Columns(1).Width = 130
        dgvDailySales.Columns(2).Width = 65
        dgvDailySales.Columns(3).Width = 85
        dgvDailySales.Columns(4).Width = 85

        dgvDailySales.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDailySales.Columns(2).DefaultCellStyle.Format = "N2"

        dgvDailySales.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDailySales.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDailySales.Columns(4).DefaultCellStyle.Format = "N2"

        Using db As New EconsaveDataClassesDataContext()
            Dim transaction = (From t In db.Transactions
                               Where t.transactionID Is cboTransaction.SelectedItem
                               Select t).FirstOrDefault()

            ' Set label text
            lblTransactionID.Text = transaction.transactionID
            lblDate.Text = transaction.createdOn.ToLongDateString()
            lblCashierName.Text = transaction.Staff.name
            lblTotal.Text = $"RM{transaction.totalPrice.ToString("N2")}"

            dgvDailySales.DataSource = From itmSls In db.ItemSales
                                       Where itmSls.transactionID = cboTransaction.SelectedItem.ToString()
                                       Select
                                           ID = itmSls.itemID,
                                           Name = itmSls.Item.name,
                                           Price = itmSls.Item.price,
                                           Quantity = itmSls.quantity,
                                           Subtotal = itmSls.subtotal
        End Using

        btnPrint.Enabled = True
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

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        dlgPrintPreview.Document = doc
        DirectCast(dlgPrintPreview, Form).WindowState = FormWindowState.Maximized
        dlgPrintPreview.PrintPreviewControl.Zoom = 1.0
        dlgPrintPreview.ShowDialog(Me)
    End Sub

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        Dim db As New EconsaveDataClassesDataContext()
        Dim itemSaleList As List(Of ItemSale) = (From i In db.ItemSales Where i.transactionID = cboTransaction.SelectedItem.ToString).ToList
        Dim staff As Staff = (From i In db.Staffs Where i.staffID = Login.staffId Select i).FirstOrDefault

        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)
        Dim fontFooter As New Font("Calibri", 8)

        Dim header As String = "Daily Sales Report"
        Dim subHeader As String = String.Format(
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
            "Prepared by {1,0} ( {2,0} )", DateTime.Now, staff.name, staff.staffID
        )

        Dim body As New StringBuilder()

        body.AppendLine(
            "No     Item ID      Item Name                      Price         Quantity        Subtotal" & vbNewLine &
            "--     -------      ----------------------------   -------       --------        --------"
        )

        Dim cnt As Integer = 0
        For Each item In itemSaleList
            '27
            Dim itemName = itemSaleList(cnt).Item.name
            If itemName.Count > 25 Then
                itemName = itemName.Remove(25) & "..."
            End If

            body.AppendFormat(
                "{0,2} {1,12}     {2,-30} {3,7} {4,14} {5,15}" & vbNewLine, cnt, itemSaleList(cnt).itemID, itemName,
                Format(itemSaleList(cnt).Item.price, "0.00"), itemSaleList(cnt).quantity, Format(itemSaleList(cnt).subtotal, "0.00")
            )
            cnt += 1
        Next

        With body
            .AppendLine()
            '.AppendFormat("{0,81}Total" & Format(itemSaleList(0).Transaction.totalPrice, "0.00") & vbNewLine & vbNewLine, " ")
            .AppendFormat(
                "{0,81}Total" & vbNewLine &
                "{1,81}--------" & vbNewLine &
                "{2,89}" & vbNewLine, " ", " ", "RM " & Format(itemSaleList(0).Transaction.totalPrice, "0.00")
)
            .AppendFormat("{0,2} record(s) total", cnt)
        End With

        Dim footer As String = "Econsave Supermarket 2001-" & Today.Year

        With e.Graphics
            .DrawImage(My.Resources.Econsave_logo, 0, 25, 100, 30)
            .DrawString(header, fontHeader, Brushes.ForestGreen, 120, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 120, 40)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
            .DrawString(footer, fontFooter, Brushes.Gray, 550, 930)
        End With
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        Me.Close()
    End Sub
End Class