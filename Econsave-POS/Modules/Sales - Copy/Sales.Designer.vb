﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayItemListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.Tota = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.EconsaveDBDataSet1 = New Econsave_POS.EconsaveDBDataSet1()
        Me.lblCategory = New MetroFramework.Controls.MetroLabel()
        Me.cmbCategory = New MetroFramework.Controls.MetroComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.EconsaveDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MenuStrip2.Size = New System.Drawing.Size(1072, 35)
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(600, 163)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(407, 322)
        Me.Panel2.TabIndex = 4
        '
        'MetroButton1
        '
        Me.MetroButton1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MetroButton1.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.MetroButton1.ForeColor = System.Drawing.Color.Black
        Me.MetroButton1.Location = New System.Drawing.Point(835, 627)
        Me.MetroButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(161, 54)
        Me.MetroButton1.TabIndex = 6
        Me.MetroButton1.Text = "C&lear"
        Me.MetroButton1.UseCustomBackColor = True
        Me.MetroButton1.UseCustomForeColor = True
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MetroButton2.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton2.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.MetroButton2.ForeColor = System.Drawing.Color.Black
        Me.MetroButton2.Location = New System.Drawing.Point(643, 627)
        Me.MetroButton2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(161, 54)
        Me.MetroButton2.TabIndex = 7
        Me.MetroButton2.Text = "&Submit"
        Me.MetroButton2.UseCustomBackColor = True
        Me.MetroButton2.UseCustomForeColor = True
        Me.MetroButton2.UseSelectable = True
        '
        'Tota
        '
        Me.Tota.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Tota.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Tota.Location = New System.Drawing.Point(653, 562)
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
        Me.MetroLabel1.Location = New System.Drawing.Point(769, 562)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(149, 30)
        Me.MetroLabel1.TabIndex = 9
        Me.MetroLabel1.Text = "RM 29.50"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'EconsaveDBDataSet1
        '
        Me.EconsaveDBDataSet1.DataSetName = "EconsaveDBDataSet1"
        Me.EconsaveDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(43, 163)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
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
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 756)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.Tota)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Sales"
        Me.Padding = New System.Windows.Forms.Padding(20, 74, 20, 20)
        Me.Text = "Sales"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.EconsaveDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayItemListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents Tota As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents EconsaveDBDataSet1 As EconsaveDBDataSet1
    Friend WithEvents lblCategory As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbCategory As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DataGridView1 As DataGridView
End Class