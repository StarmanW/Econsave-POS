Imports System.Text

Public Class StockReport

    Private Sub StockReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using db As New EconsaveDataClassesDataContext()
            InitializeCategoryBox(db)
            dgvStockReport.DataSource = From i In db.Items
                                        Select
                                            ID = i.itemID,
                                            Name = i.name,
                                            Price = Format(i.price, "0.00"),
                                            Quanity = i.stockQuantity,
                                            Status = i.status
        End Using

        dgvStockReport.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvStockReport.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    ' Sub routine to initialize category combo box
    Private Sub InitializeCategoryBox(db As EconsaveDataClassesDataContext)
        Dim category As List(Of Category)
        category = db.Categories.ToList()

        cmbCategory.Items.Add("All")
        ' For loop add category
        For i = 0 To category.Count - 1
            cmbCategory.Items.Add(category(i).categoryName)
        Next
        cmbCategory.SelectedIndex = 0
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        Dim db As New EconsaveDataClassesDataContext()
        Dim rs As Object

        If cmbCategory.SelectedIndex = 0 Then
            rs = From i In db.Items
                 Select
                    ID = i.itemID,
                    Name = i.name,
                    Price = Format(i.price, "0.00"),
                    Quanity = i.stockQuantity,
                    Status = i.status
        Else
            Dim itemCategory = CType(cmbCategory.SelectedItem, String)
            rs = From i In db.Items
                 Where i.Category.categoryName = itemCategory
                 Select
                    ID = i.itemID,
                    Name = i.name,
                    Price = Format(i.price, "0.00"),
                    Quanity = i.stockQuantity,
                    Status = i.status
        End If

        dgvStockReport.DataSource = rs

        dgvStockReport.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvStockReport.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Close()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        dlgPrintPreview.Document = doc
        DirectCast(dlgPrintPreview, Form).WindowState = FormWindowState.Maximized
        dlgPrintPreview.PrintPreviewControl.Zoom = 1.0
        dlgPrintPreview.ShowDialog(Me)
    End Sub

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        Using db As New EconsaveDataClassesDataContext()
            Dim stockList As List(Of Item)

            If cmbCategory.SelectedIndex = 0 Then
                stockList = db.Items.ToList()
            Else
                stockList = db.Items.Where(Function(i) i.Category.categoryName = cmbCategory.SelectedItem.ToString()).ToList()
            End If

            Dim staff As Staff = (From i In db.Staffs Where i.staffID = Login.staffId Select i).FirstOrDefault

            Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
            Dim fontSubHeader As New Font("Calibri", 12)
            Dim fontBody As New Font("Consolas", 10)
            Dim fontFooter As New Font("Calibri", 8)

            Dim header As String = "Stock Report"
            Dim subHeader As String = String.Format(
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
            "Prepared by {1,0} ( {2,0} )", DateTime.Now, staff.name, staff.staffID
        )

            Dim body As New StringBuilder()

            body.AppendLine(
            "No     Item ID      Item Name                      Price         Quantity        Status" & vbNewLine &
            "--     -------      ----------------------------   -------       --------        ------"
        )

            Dim cnt As Integer = 0
            For Each item In stockList
                Dim itemName = stockList(cnt).name
                If itemName.Count > 25 Then
                    itemName = itemName.Remove(25) & "..."
                End If

                body.AppendFormat(
                "{0,2} {1,12}     {2,-30} {3,7} {4,14} {5,15}" & vbNewLine, cnt + 1, stockList(cnt).itemID, itemName,
                Format(stockList(cnt).price, "0.00"), stockList(cnt).stockQuantity, stockList(cnt).status
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
        End Using
    End Sub
End Class