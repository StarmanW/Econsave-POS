<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MonthlyStaffTransaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MonthlyStaffTransaction))
        Me.dgvStaffMonthlyTrans = New System.Windows.Forms.DataGridView()
        Me.btnPrint = New MetroFramework.Controls.MetroButton()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.cboMonth = New MetroFramework.Controls.MetroComboBox()
        Me.EntityCommand1 = New System.Data.Entity.Core.EntityClient.EntityCommand()
        Me.dlgPrintPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.doc = New System.Drawing.Printing.PrintDocument()
        CType(Me.dgvStaffMonthlyTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvStaffMonthlyTrans
        '
        Me.dgvStaffMonthlyTrans.AllowUserToAddRows = False
        Me.dgvStaffMonthlyTrans.AllowUserToDeleteRows = False
        Me.dgvStaffMonthlyTrans.AllowUserToResizeColumns = False
        Me.dgvStaffMonthlyTrans.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvStaffMonthlyTrans.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStaffMonthlyTrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStaffMonthlyTrans.BackgroundColor = System.Drawing.Color.White
        Me.dgvStaffMonthlyTrans.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStaffMonthlyTrans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvStaffMonthlyTrans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvStaffMonthlyTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStaffMonthlyTrans.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvStaffMonthlyTrans.Location = New System.Drawing.Point(34, 102)
        Me.dgvStaffMonthlyTrans.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvStaffMonthlyTrans.MultiSelect = False
        Me.dgvStaffMonthlyTrans.Name = "dgvStaffMonthlyTrans"
        Me.dgvStaffMonthlyTrans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvStaffMonthlyTrans.RowHeadersVisible = False
        Me.dgvStaffMonthlyTrans.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvStaffMonthlyTrans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStaffMonthlyTrans.Size = New System.Drawing.Size(839, 509)
        Me.dgvStaffMonthlyTrans.TabIndex = 1
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrint.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(754, 620)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(122, 56)
        Me.btnPrint.TabIndex = 7
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
        Me.btnClose.Location = New System.Drawing.Point(608, 620)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(122, 56)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseCustomBackColor = True
        Me.btnClose.UseCustomForeColor = True
        Me.btnClose.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(33, 63)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(66, 25)
        Me.MetroLabel1.TabIndex = 8
        Me.MetroLabel1.Text = "Month:"
        '
        'cboMonth
        '
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.ItemHeight = 23
        Me.cboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonth.Location = New System.Drawing.Point(105, 63)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(249, 29)
        Me.cboMonth.TabIndex = 9
        Me.cboMonth.UseSelectable = True
        '
        'EntityCommand1
        '
        Me.EntityCommand1.CommandTimeout = 0
        Me.EntityCommand1.CommandTree = Nothing
        Me.EntityCommand1.Connection = Nothing
        Me.EntityCommand1.EnablePlanCaching = True
        Me.EntityCommand1.Transaction = Nothing
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
        'doc
        '
        Me.doc.DocumentName = "Daily Sales Report"
        Me.doc.OriginAtMargins = True
        '
        'MonthlyStaffTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(910, 687)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvStaffMonthlyTrans)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "MonthlyStaffTransaction"
        Me.Padding = New System.Windows.Forms.Padding(30, 83, 30, 28)
        Me.Resizable = False
        Me.Text = "Monthly Staffs Transaction"
        CType(Me.dgvStaffMonthlyTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvStaffMonthlyTrans As DataGridView
    Friend WithEvents btnPrint As MetroFramework.Controls.MetroButton
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboMonth As MetroFramework.Controls.MetroComboBox
    Friend WithEvents EntityCommand1 As Entity.Core.EntityClient.EntityCommand
    Friend WithEvents dlgPrintPreview As PrintPreviewDialog
    Friend WithEvents doc As Printing.PrintDocument
End Class
