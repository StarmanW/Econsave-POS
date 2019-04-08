<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddItem
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtItemID = New MetroFramework.Controls.MetroTextBox()
        Me.numPrice = New System.Windows.Forms.NumericUpDown()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblStockQuantity = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblItemID = New System.Windows.Forms.Label()
        Me.numStockQuantity = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtItemName = New MetroFramework.Controls.MetroTextBox()
        Me.cmbCategory = New MetroFramework.Controls.MetroComboBox()
        Me.txtDescription = New MetroFramework.Controls.MetroTextBox()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.btnAddItem = New MetroFramework.Controls.MetroButton()
        Me.btnClear = New MetroFramework.Controls.MetroButton()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numStockQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfileToolStripMenuItem, Me.SalesToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(21, 60)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(6, 3, 0, 3)
        Me.MenuStrip2.Size = New System.Drawing.Size(549, 29)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(51, 23)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(41, 23)
        Me.ProfileToolStripMenuItem.Text = "File"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txtItemID
        '
        '
        '
        '
        Me.txtItemID.CustomButton.Image = Nothing
        Me.txtItemID.CustomButton.Location = New System.Drawing.Point(363, 2)
        Me.txtItemID.CustomButton.Name = ""
        Me.txtItemID.CustomButton.Size = New System.Drawing.Size(19, 19)
        Me.txtItemID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtItemID.CustomButton.TabIndex = 1
        Me.txtItemID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtItemID.CustomButton.UseSelectable = True
        Me.txtItemID.CustomButton.Visible = False
        Me.txtItemID.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtItemID.Lines = New String(-1) {}
        Me.txtItemID.Location = New System.Drawing.Point(125, 3)
        Me.txtItemID.MaxLength = 32767
        Me.txtItemID.Name = "txtItemID"
        Me.txtItemID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemID.ReadOnly = True
        Me.txtItemID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtItemID.SelectedText = ""
        Me.txtItemID.SelectionLength = 0
        Me.txtItemID.SelectionStart = 0
        Me.txtItemID.ShortcutsEnabled = True
        Me.txtItemID.Size = New System.Drawing.Size(385, 24)
        Me.txtItemID.TabIndex = 1
        Me.txtItemID.UseSelectable = True
        Me.txtItemID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtItemID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'numPrice
        '
        Me.numPrice.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.numPrice.DecimalPlaces = 2
        Me.numPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPrice.Location = New System.Drawing.Point(125, 189)
        Me.numPrice.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numPrice.Name = "numPrice"
        Me.numPrice.Size = New System.Drawing.Size(384, 26)
        Me.numPrice.TabIndex = 4
        Me.numPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCategory
        '
        Me.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(42, 278)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(77, 20)
        Me.lblCategory.TabIndex = 9
        Me.lblCategory.Text = "Category:"
        '
        'lblStockQuantity
        '
        Me.lblStockQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblStockQuantity.AutoSize = True
        Me.lblStockQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockQuantity.Location = New System.Drawing.Point(47, 224)
        Me.lblStockQuantity.Name = "lblStockQuantity"
        Me.lblStockQuantity.Size = New System.Drawing.Size(72, 40)
        Me.lblStockQuantity.TabIndex = 8
        Me.lblStockQuantity.Text = "Stock Quantity:"
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(71, 192)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(48, 20)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "Price:"
        '
        'lblDescription
        '
        Me.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(26, 112)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(93, 20)
        Me.lblDescription.TabIndex = 6
        Me.lblDescription.Text = "Description:"
        '
        'lblItemName
        '
        Me.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(28, 37)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(91, 20)
        Me.lblItemName.TabIndex = 5
        Me.lblItemName.Text = "Item Name:"
        '
        'lblItemID
        '
        Me.lblItemID.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblItemID.AutoSize = True
        Me.lblItemID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemID.Location = New System.Drawing.Point(53, 5)
        Me.lblItemID.Name = "lblItemID"
        Me.lblItemID.Size = New System.Drawing.Size(66, 20)
        Me.lblItemID.TabIndex = 4
        Me.lblItemID.Text = "Item ID:"
        '
        'numStockQuantity
        '
        Me.numStockQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.numStockQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numStockQuantity.Location = New System.Drawing.Point(125, 231)
        Me.numStockQuantity.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numStockQuantity.Name = "numStockQuantity"
        Me.numStockQuantity.Size = New System.Drawing.Size(384, 26)
        Me.numStockQuantity.TabIndex = 5
        Me.numStockQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.62119!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.37881!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtItemName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.numStockQuantity, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblItemID, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblItemName, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDescription, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPrice, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblStockQuantity, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCategory, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.numPrice, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtItemID, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbCategory, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDescription, 1, 2)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(21, 104)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.27586!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.72414!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(543, 312)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'txtItemName
        '
        '
        '
        '
        Me.txtItemName.CustomButton.Image = Nothing
        Me.txtItemName.CustomButton.Location = New System.Drawing.Point(361, 1)
        Me.txtItemName.CustomButton.Name = ""
        Me.txtItemName.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtItemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtItemName.CustomButton.TabIndex = 1
        Me.txtItemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtItemName.CustomButton.UseSelectable = True
        Me.txtItemName.CustomButton.Visible = False
        Me.txtItemName.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtItemName.Lines = New String(-1) {}
        Me.txtItemName.Location = New System.Drawing.Point(125, 34)
        Me.txtItemName.MaxLength = 32767
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtItemName.SelectedText = ""
        Me.txtItemName.SelectionLength = 0
        Me.txtItemName.SelectionStart = 0
        Me.txtItemName.ShortcutsEnabled = True
        Me.txtItemName.Size = New System.Drawing.Size(385, 25)
        Me.txtItemName.TabIndex = 2
        Me.txtItemName.UseSelectable = True
        Me.txtItemName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtItemName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cmbCategory
        '
        Me.cmbCategory.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.ItemHeight = 23
        Me.cmbCategory.Location = New System.Drawing.Point(125, 274)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(384, 29)
        Me.cmbCategory.TabIndex = 6
        Me.cmbCategory.UseSelectable = True
        '
        'txtDescription
        '
        '
        '
        '
        Me.txtDescription.CustomButton.Image = Nothing
        Me.txtDescription.CustomButton.Location = New System.Drawing.Point(277, 2)
        Me.txtDescription.CustomButton.Name = ""
        Me.txtDescription.CustomButton.Size = New System.Drawing.Size(105, 105)
        Me.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDescription.CustomButton.TabIndex = 1
        Me.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDescription.CustomButton.UseSelectable = True
        Me.txtDescription.CustomButton.Visible = False
        Me.txtDescription.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtDescription.Lines = New String(-1) {}
        Me.txtDescription.Location = New System.Drawing.Point(125, 67)
        Me.txtDescription.MaxLength = 32767
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.SelectionLength = 0
        Me.txtDescription.SelectionStart = 0
        Me.txtDescription.ShortcutsEnabled = True
        Me.txtDescription.Size = New System.Drawing.Size(385, 110)
        Me.txtDescription.TabIndex = 3
        Me.txtDescription.UseSelectable = True
        Me.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDescription.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Location = New System.Drawing.Point(621, 267)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(8, 29)
        Me.MetroComboBox1.TabIndex = 6
        Me.MetroComboBox1.UseSelectable = True
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.Green
        Me.btnAddItem.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnAddItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAddItem.Location = New System.Drawing.Point(146, 422)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(185, 43)
        Me.btnAddItem.TabIndex = 7
        Me.btnAddItem.Text = "&Add New Item"
        Me.btnAddItem.UseCustomBackColor = True
        Me.btnAddItem.UseCustomForeColor = True
        Me.btnAddItem.UseSelectable = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnClear.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClear.Location = New System.Drawing.Point(346, 422)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(184, 43)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "&Clear"
        Me.btnClear.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnClear.UseCustomBackColor = True
        Me.btnClear.UseCustomForeColor = True
        Me.btnClear.UseSelectable = True
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'AddItem
        '
        Me.AcceptButton = Me.btnAddItem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(591, 486)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(591, 486)
        Me.MinimumSize = New System.Drawing.Size(591, 486)
        Me.Name = "AddItem"
        Me.Padding = New System.Windows.Forms.Padding(21, 60, 21, 20)
        Me.Text = "Add New Item"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numStockQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents numStockQuantity As NumericUpDown
    Friend WithEvents lblItemID As Label
    Friend WithEvents lblItemName As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblStockQuantity As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents numPrice As NumericUpDown
    Friend WithEvents txtItemID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmbCategory As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnAddItem As MetroFramework.Controls.MetroButton
    Friend WithEvents btnClear As MetroFramework.Controls.MetroButton
    Friend WithEvents txtDescription As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtItemName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
End Class
