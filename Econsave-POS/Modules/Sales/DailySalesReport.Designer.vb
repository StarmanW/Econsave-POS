<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DailySalesReport
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DailySalesReport))
        Me.btnPrint = New MetroFramework.Controls.MetroButton()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.dgvDailySales = New System.Windows.Forms.DataGridView()
        Me.lblTransactionSelect = New MetroFramework.Controls.MetroLabel()
        Me.cboTransaction = New MetroFramework.Controls.MetroComboBox()
        Me.lblDateSelect = New MetroFramework.Controls.MetroLabel()
        Me.cboDate = New MetroFramework.Controls.MetroComboBox()
        Me.lblTransactionIDTitle = New MetroFramework.Controls.MetroLabel()
        Me.lblDateTitle = New MetroFramework.Controls.MetroLabel()
        Me.lblTransactionID = New MetroFramework.Controls.MetroLabel()
        Me.lblDate = New MetroFramework.Controls.MetroLabel()
        Me.lblCashierName = New MetroFramework.Controls.MetroLabel()
        Me.lblCashierNameTitle = New MetroFramework.Controls.MetroLabel()
        Me.lblTotalTitle = New MetroFramework.Controls.MetroLabel()
        Me.lblTotal = New MetroFramework.Controls.MetroLabel()
        Me.doc = New System.Drawing.Printing.PrintDocument()
        Me.dlgPrintPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvDailySales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrint.Enabled = False
        Me.btnPrint.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(898, 755)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(5)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(131, 53)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseCustomBackColor = True
        Me.btnPrint.UseCustomForeColor = True
        Me.btnPrint.UseSelectable = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.ForestGreen
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(739, 755)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(131, 53)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseCustomBackColor = True
        Me.btnClose.UseCustomForeColor = True
        Me.btnClose.UseSelectable = True
        '
        'dgvDailySales
        '
        Me.dgvDailySales.AllowUserToAddRows = False
        Me.dgvDailySales.AllowUserToDeleteRows = False
        Me.dgvDailySales.AllowUserToResizeColumns = False
        Me.dgvDailySales.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvDailySales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDailySales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDailySales.BackgroundColor = System.Drawing.Color.White
        Me.dgvDailySales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDailySales.CausesValidation = False
        Me.dgvDailySales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvDailySales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDailySales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDailySales.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDailySales.Location = New System.Drawing.Point(35, 325)
        Me.dgvDailySales.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dgvDailySales.MultiSelect = False
        Me.dgvDailySales.Name = "dgvDailySales"
        Me.dgvDailySales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDailySales.RowHeadersVisible = False
        Me.dgvDailySales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvDailySales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDailySales.ShowCellErrors = False
        Me.dgvDailySales.ShowCellToolTips = False
        Me.dgvDailySales.ShowEditingIcon = False
        Me.dgvDailySales.Size = New System.Drawing.Size(994, 404)
        Me.dgvDailySales.StandardTab = True
        Me.dgvDailySales.TabIndex = 2
        '
        'lblTransactionSelect
        '
        Me.lblTransactionSelect.AutoSize = True
        Me.lblTransactionSelect.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTransactionSelect.Location = New System.Drawing.Point(467, 125)
        Me.lblTransactionSelect.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblTransactionSelect.Name = "lblTransactionSelect"
        Me.lblTransactionSelect.Size = New System.Drawing.Size(103, 25)
        Me.lblTransactionSelect.TabIndex = 11
        Me.lblTransactionSelect.Text = "Transaction:"
        '
        'cboTransaction
        '
        Me.cboTransaction.FormattingEnabled = True
        Me.cboTransaction.ItemHeight = 24
        Me.cboTransaction.Location = New System.Drawing.Point(582, 125)
        Me.cboTransaction.Margin = New System.Windows.Forms.Padding(7)
        Me.cboTransaction.Name = "cboTransaction"
        Me.cboTransaction.Size = New System.Drawing.Size(169, 30)
        Me.cboTransaction.TabIndex = 1
        Me.cboTransaction.UseSelectable = True
        '
        'lblDateSelect
        '
        Me.lblDateSelect.AutoSize = True
        Me.lblDateSelect.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblDateSelect.Location = New System.Drawing.Point(44, 125)
        Me.lblDateSelect.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblDateSelect.Name = "lblDateSelect"
        Me.lblDateSelect.Size = New System.Drawing.Size(54, 25)
        Me.lblDateSelect.TabIndex = 13
        Me.lblDateSelect.Text = "Date:"
        '
        'cboDate
        '
        Me.cboDate.FormattingEnabled = True
        Me.cboDate.ItemHeight = 24
        Me.cboDate.Location = New System.Drawing.Point(102, 125)
        Me.cboDate.Margin = New System.Windows.Forms.Padding(7)
        Me.cboDate.Name = "cboDate"
        Me.cboDate.Size = New System.Drawing.Size(337, 30)
        Me.cboDate.TabIndex = 0
        Me.cboDate.UseSelectable = True
        '
        'lblTransactionIDTitle
        '
        Me.lblTransactionIDTitle.AutoSize = True
        Me.lblTransactionIDTitle.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTransactionIDTitle.Location = New System.Drawing.Point(44, 173)
        Me.lblTransactionIDTitle.Name = "lblTransactionIDTitle"
        Me.lblTransactionIDTitle.Size = New System.Drawing.Size(125, 25)
        Me.lblTransactionIDTitle.TabIndex = 15
        Me.lblTransactionIDTitle.Text = "Transaction ID:"
        '
        'lblDateTitle
        '
        Me.lblDateTitle.AutoSize = True
        Me.lblDateTitle.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblDateTitle.Location = New System.Drawing.Point(44, 208)
        Me.lblDateTitle.Name = "lblDateTitle"
        Me.lblDateTitle.Size = New System.Drawing.Size(54, 25)
        Me.lblDateTitle.TabIndex = 16
        Me.lblDateTitle.Text = "Date:"
        '
        'lblTransactionID
        '
        Me.lblTransactionID.AutoSize = True
        Me.lblTransactionID.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTransactionID.Location = New System.Drawing.Point(237, 173)
        Me.lblTransactionID.Name = "lblTransactionID"
        Me.lblTransactionID.Size = New System.Drawing.Size(0, 0)
        Me.lblTransactionID.TabIndex = 18
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblDate.Location = New System.Drawing.Point(237, 208)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(20, 25)
        Me.lblDate.TabIndex = 19
        Me.lblDate.Tag = "-"
        Me.lblDate.Text = "-"
        '
        'lblCashierName
        '
        Me.lblCashierName.AutoSize = True
        Me.lblCashierName.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblCashierName.Location = New System.Drawing.Point(237, 245)
        Me.lblCashierName.Name = "lblCashierName"
        Me.lblCashierName.Size = New System.Drawing.Size(20, 25)
        Me.lblCashierName.TabIndex = 20
        Me.lblCashierName.Text = "-"
        '
        'lblCashierNameTitle
        '
        Me.lblCashierNameTitle.AutoSize = True
        Me.lblCashierNameTitle.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblCashierNameTitle.Location = New System.Drawing.Point(44, 245)
        Me.lblCashierNameTitle.Name = "lblCashierNameTitle"
        Me.lblCashierNameTitle.Size = New System.Drawing.Size(179, 25)
        Me.lblCashierNameTitle.TabIndex = 17
        Me.lblCashierNameTitle.Text = "Transaction Made by:"
        '
        'lblTotalTitle
        '
        Me.lblTotalTitle.AutoSize = True
        Me.lblTotalTitle.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTotalTitle.Location = New System.Drawing.Point(44, 279)
        Me.lblTotalTitle.Name = "lblTotalTitle"
        Me.lblTotalTitle.Size = New System.Drawing.Size(97, 25)
        Me.lblTotalTitle.TabIndex = 21
        Me.lblTotalTitle.Text = "Total Sales:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTotal.Location = New System.Drawing.Point(237, 279)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(20, 25)
        Me.lblTotal.TabIndex = 22
        Me.lblTotal.Text = "-"
        '
        'doc
        '
        Me.doc.DocumentName = "Daily Sales Report"
        Me.doc.OriginAtMargins = True
        '
        'dlgPrintPreview
        '
        Me.dlgPrintPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPrintPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPrintPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPrintPreview.Enabled = True
        Me.dlgPrintPreview.Icon = CType(resources.GetObject("dlgPrintPreview.Icon"), System.Drawing.Icon)
        Me.dlgPrintPreview.Name = "dlgPrintPreview"
        Me.dlgPrintPreview.UseAntiAlias = True
        Me.dlgPrintPreview.Visible = False
        '
        'mnuStrip
        '
        Me.mnuStrip.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mnuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogout})
        Me.mnuStrip.Location = New System.Drawing.Point(27, 74)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Padding = New System.Windows.Forms.Padding(8, 4, 0, 4)
        Me.mnuStrip.Size = New System.Drawing.Size(1007, 35)
        Me.mnuStrip.TabIndex = 23
        Me.mnuStrip.Text = "MenuStrip2"
        '
        'mnuLogout
        '
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(76, 27)
        Me.mnuLogout.Text = "Logout"
        '
        'DailySalesReport
        '
        Me.AcceptButton = Me.btnPrint
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1061, 825)
        Me.Controls.Add(Me.mnuStrip)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTotalTitle)
        Me.Controls.Add(Me.lblCashierName)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTransactionID)
        Me.Controls.Add(Me.lblCashierNameTitle)
        Me.Controls.Add(Me.lblDateTitle)
        Me.Controls.Add(Me.lblTransactionIDTitle)
        Me.Controls.Add(Me.lblDateSelect)
        Me.Controls.Add(Me.cboDate)
        Me.Controls.Add(Me.lblTransactionSelect)
        Me.Controls.Add(Me.cboTransaction)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvDailySales)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "DailySalesReport"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Resizable = False
        Me.Text = "Daily Sales Report"
        CType(Me.dgvDailySales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPrint As MetroFramework.Controls.MetroButton
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents dgvDailySales As DataGridView
    Friend WithEvents lblTransactionSelect As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboTransaction As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lblDateSelect As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboDate As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lblTransactionIDTitle As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDateTitle As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTransactionID As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDate As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCashierName As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCashierNameTitle As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTotalTitle As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents doc As Printing.PrintDocument
    Friend WithEvents dlgPrintPreview As PrintPreviewDialog
    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents mnuLogout As ToolStripMenuItem
End Class
