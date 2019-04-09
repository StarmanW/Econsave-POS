Imports System.Text

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

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        Dim db As New EconsaveDataClassesDataContext()
        Dim staffList As List(Of Transaction) = (From i In db.Transactions Where i.transactionID = cboMonth.SelectedItem.ToString).ToList
        Dim staff As Staff = (From i In db.Staffs Where i.staffID = Login.staffId Select i).FirstOrDefault


        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
            Dim fontBody As New Font("Consolas", 10)
            Dim fontFooter As New Font("Calibri", 8)

        Dim header As String = "Monthly Staff Transcation Report"
        Dim subHeader As String = String.Format(
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
            "Prepared by {1,0} ( {2,0} )", DateTime.Now, staff.name, staff.staffID
        )

            Dim body As New StringBuilder()

        body.AppendLine(
            "No     Transcation ID      Staff ID                 Price       Created On" & vbNewLine &
            "--     -------      ----------------------------   -------       --------"
        )

        Dim cnt As Integer = 0
        For Each item In staffList
            Dim itemName = staffList(cnt).transactionID
            If itemName.Count > 25 Then
                itemName = itemName.Remove(25) & "..."
            End If

            body.AppendFormat(
                "{0,2} {1,12}     {2,-30} {3,7} {4,14} {5,15}" & vbNewLine, cnt + 1, staffList(cnt).transactionID, itemName,
                Format(staffList(cnt).totalPrice, "0.00"), staffList(cnt).staffID, staffList(cnt).createdOn
            )
            cnt += 1
        Next

        With body
                .AppendLine()
                '.AppendFormat("{0,81}Total" & Format(itemSaleList(0).Transaction.totalPrice, "0.00") & vbNewLine & vbNewLine, " ")

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

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        dlgPrintPreview.Document = doc
        DirectCast(dlgPrintPreview, Form).WindowState = FormWindowState.Maximized
        dlgPrintPreview.PrintPreviewControl.Zoom = 1.0
        dlgPrintPreview.ShowDialog(Me)
    End Sub
End Class