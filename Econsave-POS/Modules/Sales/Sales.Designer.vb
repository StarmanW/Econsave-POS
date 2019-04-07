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
        Dim DataGridViewCellStyle57 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle58 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle59 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle60 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle61 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle62 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle63 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle64 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayItemListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tota = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.EconsaveDBDataSet = New Econsave_POS.EconsaveDBDataSet()
        Me.lblCategory = New MetroFramework.Controls.MetroLabel()
        Me.cmbCategory = New MetroFramework.Controls.MetroComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.EconsaveDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesToolStripMenuItem, Me.ItemManagementToolStripMenuItem, Me.ProfileToolStripMenuItem})
        Me.MenuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip2.Location = New System.Drawing.Point(20, 74)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(8, 4, 0, 4)
        Me.MenuStrip2.Size = New System.Drawing.Size(1230, 35)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(60, 27)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'ItemManagementToolStripMenuItem
        '
        Me.ItemManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewItemToolStripMenuItem, Me.DisplayItemListToolStripMenuItem})
        Me.ItemManagementToolStripMenuItem.Name = "ItemManagementToolStripMenuItem"
        Me.ItemManagementToolStripMenuItem.Size = New System.Drawing.Size(164, 27)
        Me.ItemManagementToolStripMenuItem.Text = "Item Management"
        '
        'AddNewItemToolStripMenuItem
        '
        Me.AddNewItemToolStripMenuItem.Name = "AddNewItemToolStripMenuItem"
        Me.AddNewItemToolStripMenuItem.Size = New System.Drawing.Size(210, 28)
        Me.AddNewItemToolStripMenuItem.Text = "Add New Item"
        '
        'DisplayItemListToolStripMenuItem
        '
        Me.DisplayItemListToolStripMenuItem.Name = "DisplayItemListToolStripMenuItem"
        Me.DisplayItemListToolStripMenuItem.Size = New System.Drawing.Size(210, 28)
        Me.DisplayItemListToolStripMenuItem.Text = "Display Item List"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(70, 27)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'Tota
        '
        Me.Tota.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Tota.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Tota.Location = New System.Drawing.Point(792, 562)
        Me.Tota.Name = "Tota"
        Me.Tota.Size = New System.Drawing.Size(115, 30)
        Me.Tota.TabIndex = 8
        Me.Tota.Text = "Total : "
        Me.Tota.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MetroLabel1
        '
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(974, 562)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(103, 30)
        Me.MetroLabel1.TabIndex = 9
        Me.MetroLabel1.Text = "0.00"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'EconsaveDBDataSet
        '
        Me.EconsaveDBDataSet.DataSetName = "EconsaveDBDataSet1"
        Me.EconsaveDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblCategory.Location = New System.Drawing.Point(20, 123)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(87, 25)
        Me.lblCategory.TabIndex = 11
        Me.lblCategory.Text = "Category"
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.ItemHeight = 24
        Me.cmbCategory.Location = New System.Drawing.Point(140, 118)
        Me.cmbCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(269, 30)
        Me.cmbCategory.TabIndex = 10
        Me.cmbCategory.UseSelectable = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle57.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle57
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle58.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle58.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle58.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle58.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle58.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle58
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle59.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle59.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle59.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle59.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle59.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle59
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(43, 163)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle60.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle60.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle60.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle60.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle60.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle60
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 45
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(517, 518)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        DataGridViewCellStyle61.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle61
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle62.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle62.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle62.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle62.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle62.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle62
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle63.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle63.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle63.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle63.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle63.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle63
        Me.DataGridView2.GridColor = System.Drawing.Color.White
        Me.DataGridView2.Location = New System.Drawing.Point(679, 163)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle64.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle64.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle64.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle64.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle64.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle64
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 45
        Me.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.ShowCellErrors = False
        Me.DataGridView2.ShowCellToolTips = False
        Me.DataGridView2.ShowEditingIcon = False
        Me.DataGridView2.ShowRowErrors = False
        Me.DataGridView2.Size = New System.Drawing.Size(567, 370)
        Me.DataGridView2.TabIndex = 12
        '
        'MetroLabel2
        '
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(913, 562)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(67, 30)
        Me.MetroLabel2.TabIndex = 13
        Me.MetroLabel2.Text = "RM"
        '
        'MetroButton2
        '
        Me.MetroButton2.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton2.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.MetroButton2.Location = New System.Drawing.Point(792, 620)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(161, 61)
        Me.MetroButton2.TabIndex = 16
        Me.MetroButton2.Text = "&Submit"
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.MetroButton1.Location = New System.Drawing.Point(974, 620)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(161, 61)
        Me.MetroButton1.TabIndex = 17
        Me.MetroButton1.Text = "C&lear"
        Me.MetroButton1.UseSelectable = True
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1270, 756)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.Tota)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Sales"
        Me.Padding = New System.Windows.Forms.Padding(20, 74, 20, 20)
        Me.Text = "Sales"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.EconsaveDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayItemListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tota As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents EconsaveDBDataSet As EconsaveDBDataSet
    Friend WithEvents lblCategory As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbCategory As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
End Class
