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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DailySalesReport))
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.dgvDailySales = New System.Windows.Forms.DataGridView()
        Me.Metrolbl = New MetroFramework.Controls.MetroLabel()
        Me.cboTransaction = New MetroFramework.Controls.MetroComboBox()
        Me.MetroDatelbl = New MetroFramework.Controls.MetroLabel()
        Me.cboDate = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lblTransaction = New MetroFramework.Controls.MetroLabel()
        Me.lblDate = New MetroFramework.Controls.MetroLabel()
        Me.lblByStaff = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.lblTotalSales = New MetroFramework.Controls.MetroLabel()
        Me.doc = New System.Drawing.Printing.PrintDocument()
        Me.dlgPrintPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvDailySales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroButton2
        '
        Me.MetroButton2.BackColor = System.Drawing.SystemColors.Highlight
        Me.MetroButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.MetroButton2.Enabled = False
        Me.MetroButton2.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton2.ForeColor = System.Drawing.Color.White
        Me.MetroButton2.Location = New System.Drawing.Point(898, 755)
        Me.MetroButton2.Margin = New System.Windows.Forms.Padding(5)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(131, 53)
        Me.MetroButton2.TabIndex = 3
        Me.MetroButton2.Text = "&Print"
        Me.MetroButton2.UseCustomBackColor = True
        Me.MetroButton2.UseCustomForeColor = True
        Me.MetroButton2.UseSelectable = True
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
        Me.btnClose.TabIndex = 2
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
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvDailySales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDailySales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDailySales.BackgroundColor = System.Drawing.Color.White
        Me.dgvDailySales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDailySales.CausesValidation = False
        Me.dgvDailySales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvDailySales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDailySales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDailySales.DefaultCellStyle = DataGridViewCellStyle4
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
        Me.dgvDailySales.TabIndex = 8
        '
        'Metrolbl
        '
        Me.Metrolbl.AutoSize = True
        Me.Metrolbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Metrolbl.Location = New System.Drawing.Point(467, 125)
        Me.Metrolbl.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Metrolbl.Name = "Metrolbl"
        Me.Metrolbl.Size = New System.Drawing.Size(103, 25)
        Me.Metrolbl.TabIndex = 11
        Me.Metrolbl.Text = "Transaction:"
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
        'MetroDatelbl
        '
        Me.MetroDatelbl.AutoSize = True
        Me.MetroDatelbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroDatelbl.Location = New System.Drawing.Point(44, 125)
        Me.MetroDatelbl.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.MetroDatelbl.Name = "MetroDatelbl"
        Me.MetroDatelbl.Size = New System.Drawing.Size(54, 25)
        Me.MetroDatelbl.TabIndex = 13
        Me.MetroDatelbl.Text = "Date:"
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
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(44, 173)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(125, 25)
        Me.MetroLabel1.TabIndex = 15
        Me.MetroLabel1.Text = "Transaction ID:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(44, 208)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(54, 25)
        Me.MetroLabel2.TabIndex = 16
        Me.MetroLabel2.Text = "Date:"
        '
        'lblTransaction
        '
        Me.lblTransaction.AutoSize = True
        Me.lblTransaction.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTransaction.Location = New System.Drawing.Point(237, 173)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(20, 25)
        Me.lblTransaction.TabIndex = 18
        Me.lblTransaction.Text = "-"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblDate.Location = New System.Drawing.Point(237, 208)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(20, 25)
        Me.lblDate.TabIndex = 19
        Me.lblDate.Text = "-"
        '
        'lblByStaff
        '
        Me.lblByStaff.AutoSize = True
        Me.lblByStaff.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblByStaff.Location = New System.Drawing.Point(237, 245)
        Me.lblByStaff.Name = "lblByStaff"
        Me.lblByStaff.Size = New System.Drawing.Size(20, 25)
        Me.lblByStaff.TabIndex = 20
        Me.lblByStaff.Text = "-"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(44, 245)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(179, 25)
        Me.MetroLabel3.TabIndex = 17
        Me.MetroLabel3.Text = "Transaction Made by:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(44, 279)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(97, 25)
        Me.MetroLabel4.TabIndex = 21
        Me.MetroLabel4.Text = "Total Sales:"
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTotalSales.Location = New System.Drawing.Point(237, 279)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(20, 25)
        Me.lblTotalSales.TabIndex = 22
        Me.lblTotalSales.Text = "-"
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
        'MenuStrip2
        '
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfileToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(27, 74)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(8, 4, 0, 4)
        Me.MenuStrip2.Size = New System.Drawing.Size(1007, 35)
        Me.MenuStrip2.TabIndex = 23
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(76, 27)
        Me.ProfileToolStripMenuItem.Text = "Logout"
        '
        'DailySalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 825)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.lblTotalSales)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.lblByStaff)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTransaction)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroDatelbl)
        Me.Controls.Add(Me.cboDate)
        Me.Controls.Add(Me.Metrolbl)
        Me.Controls.Add(Me.cboTransaction)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvDailySales)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "DailySalesReport"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Resizable = False
        Me.Text = "Daily Sales Report"
        CType(Me.dgvDailySales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents dgvDailySales As DataGridView
    Friend WithEvents Metrolbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboTransaction As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroDatelbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboDate As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTransaction As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDate As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblByStaff As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTotalSales As MetroFramework.Controls.MetroLabel
    Friend WithEvents doc As Printing.PrintDocument
    Friend WithEvents dlgPrintPreview As PrintPreviewDialog
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
End Class
