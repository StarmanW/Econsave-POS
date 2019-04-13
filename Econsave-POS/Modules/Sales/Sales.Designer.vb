<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sales
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales))
        Me.lblTotal = New MetroFramework.Controls.MetroLabel()
        Me.lblTotalValue = New MetroFramework.Controls.MetroLabel()
        Me.EconsaveDBDataSet = New Econsave_POS.EconsaveDBDataSet()
        Me.lblCategory = New MetroFramework.Controls.MetroLabel()
        Me.cmbCategory = New MetroFramework.Controls.MetroComboBox()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.dgvSelectedItems = New System.Windows.Forms.DataGridView()
        Me.btnSubmit = New MetroFramework.Controls.MetroButton()
        Me.btnClear = New MetroFramework.Controls.MetroButton()
        Me.lblTransactionIDTitle = New MetroFramework.Controls.MetroLabel()
        Me.lblTransactionID = New MetroFramework.Controls.MetroLabel()
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.EconsaveDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSelectedItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTotal.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotal.Location = New System.Drawing.Point(789, 636)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(161, 30)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "Total :    RM"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalValue
        '
        Me.lblTotalValue.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTotalValue.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalValue.Location = New System.Drawing.Point(972, 636)
        Me.lblTotalValue.Name = "lblTotalValue"
        Me.lblTotalValue.Size = New System.Drawing.Size(103, 30)
        Me.lblTotalValue.TabIndex = 9
        Me.lblTotalValue.Text = "0.00"
        Me.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'EconsaveDBDataSet
        '
        Me.EconsaveDBDataSet.DataSetName = "EconsaveDBDataSet1"
        Me.EconsaveDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblCategory
        '
        Me.lblCategory.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblCategory.Location = New System.Drawing.Point(19, 192)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(165, 41)
        Me.lblCategory.TabIndex = 11
        Me.lblCategory.Text = "Category"
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.ItemHeight = 24
        Me.cmbCategory.Location = New System.Drawing.Point(196, 197)
        Me.cmbCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(269, 30)
        Me.cmbCategory.TabIndex = 1
        Me.cmbCategory.UseSelectable = True
        '
        'dgvItems
        '
        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.AllowUserToDeleteRows = False
        Me.dgvItems.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvItems.BackgroundColor = System.Drawing.Color.White
        Me.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItems.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvItems.GridColor = System.Drawing.Color.White
        Me.dgvItems.Location = New System.Drawing.Point(41, 238)
        Me.dgvItems.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvItems.MultiSelect = False
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.ReadOnly = True
        Me.dgvItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItems.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvItems.RowHeadersVisible = False
        Me.dgvItems.RowHeadersWidth = 45
        Me.dgvItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItems.ShowCellErrors = False
        Me.dgvItems.ShowCellToolTips = False
        Me.dgvItems.ShowEditingIcon = False
        Me.dgvItems.ShowRowErrors = False
        Me.dgvItems.Size = New System.Drawing.Size(620, 518)
        Me.dgvItems.StandardTab = True
        Me.dgvItems.TabIndex = 0
        '
        'dgvSelectedItems
        '
        Me.dgvSelectedItems.AllowUserToAddRows = False
        Me.dgvSelectedItems.AllowUserToDeleteRows = False
        Me.dgvSelectedItems.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvSelectedItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvSelectedItems.BackgroundColor = System.Drawing.Color.White
        Me.dgvSelectedItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSelectedItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvSelectedItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSelectedItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvSelectedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSelectedItems.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvSelectedItems.GridColor = System.Drawing.Color.White
        Me.dgvSelectedItems.Location = New System.Drawing.Point(683, 238)
        Me.dgvSelectedItems.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvSelectedItems.MultiSelect = False
        Me.dgvSelectedItems.Name = "dgvSelectedItems"
        Me.dgvSelectedItems.ReadOnly = True
        Me.dgvSelectedItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSelectedItems.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvSelectedItems.RowHeadersVisible = False
        Me.dgvSelectedItems.RowHeadersWidth = 45
        Me.dgvSelectedItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSelectedItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSelectedItems.ShowCellErrors = False
        Me.dgvSelectedItems.ShowCellToolTips = False
        Me.dgvSelectedItems.ShowEditingIcon = False
        Me.dgvSelectedItems.ShowRowErrors = False
        Me.dgvSelectedItems.Size = New System.Drawing.Size(567, 370)
        Me.dgvSelectedItems.StandardTab = True
        Me.dgvSelectedItems.TabIndex = 2
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.ForestGreen
        Me.btnSubmit.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(789, 694)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(161, 62)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseCustomBackColor = True
        Me.btnSubmit.UseCustomForeColor = True
        Me.btnSubmit.UseSelectable = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnClear.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(972, 694)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(161, 62)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseCustomBackColor = True
        Me.btnClear.UseCustomForeColor = True
        Me.btnClear.UseSelectable = True
        '
        'lblTransactionIDTitle
        '
        Me.lblTransactionIDTitle.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTransactionIDTitle.Location = New System.Drawing.Point(19, 138)
        Me.lblTransactionIDTitle.Name = "lblTransactionIDTitle"
        Me.lblTransactionIDTitle.Size = New System.Drawing.Size(172, 36)
        Me.lblTransactionIDTitle.TabIndex = 18
        Me.lblTransactionIDTitle.Text = "Transaction ID"
        '
        'lblTransactionID
        '
        Me.lblTransactionID.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTransactionID.Location = New System.Drawing.Point(196, 138)
        Me.lblTransactionID.Name = "lblTransactionID"
        Me.lblTransactionID.Size = New System.Drawing.Size(269, 33)
        Me.lblTransactionID.TabIndex = 19
        '
        'mnuStrip
        '
        Me.mnuStrip.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mnuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogout})
        Me.mnuStrip.Location = New System.Drawing.Point(20, 74)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Padding = New System.Windows.Forms.Padding(8, 4, 0, 4)
        Me.mnuStrip.Size = New System.Drawing.Size(1229, 35)
        Me.mnuStrip.TabIndex = 24
        Me.mnuStrip.Text = "MenuStrip2"
        '
        'mnuLogout
        '
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(76, 27)
        Me.mnuLogout.Text = "&Logout"
        '
        'Sales
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 798)
        Me.Controls.Add(Me.mnuStrip)
        Me.Controls.Add(Me.lblTransactionID)
        Me.Controls.Add(Me.lblTransactionIDTitle)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.dgvSelectedItems)
        Me.Controls.Add(Me.dgvItems)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.lblTotalValue)
        Me.Controls.Add(Me.lblTotal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Sales"
        Me.Padding = New System.Windows.Forms.Padding(20, 74, 20, 20)
        Me.Resizable = False
        Me.Text = "Sales"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        CType(Me.EconsaveDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSelectedItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTotalValue As MetroFramework.Controls.MetroLabel
    Friend WithEvents EconsaveDBDataSet As EconsaveDBDataSet
    Friend WithEvents lblCategory As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbCategory As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents dgvSelectedItems As DataGridView
    Friend WithEvents btnSubmit As MetroFramework.Controls.MetroButton
    Friend WithEvents btnClear As MetroFramework.Controls.MetroButton
    Friend WithEvents lblTransactionIDTitle As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTransactionID As MetroFramework.Controls.MetroLabel
    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents mnuLogout As ToolStripMenuItem
End Class
