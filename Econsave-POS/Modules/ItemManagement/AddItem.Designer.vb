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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddItem))
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtItemID = New MetroFramework.Controls.MetroTextBox()
        Me.numPrice = New System.Windows.Forms.NumericUpDown()
        Me.numStockQuantity = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txtItemName = New MetroFramework.Controls.MetroTextBox()
        Me.cmbCategory = New MetroFramework.Controls.MetroComboBox()
        Me.txtDescription = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.btnAddItem = New MetroFramework.Controls.MetroButton()
        Me.btnClear = New MetroFramework.Controls.MetroButton()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numStockQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.txtItemID.Location = New System.Drawing.Point(142, 3)
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
        Me.numPrice.Location = New System.Drawing.Point(142, 189)
        Me.numPrice.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numPrice.Name = "numPrice"
        Me.numPrice.Size = New System.Drawing.Size(384, 26)
        Me.numPrice.TabIndex = 4
        Me.numPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numStockQuantity
        '
        Me.numStockQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.numStockQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numStockQuantity.Location = New System.Drawing.Point(142, 231)
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
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.59853!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.40147!))
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtItemName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.numStockQuantity, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.numPrice, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtItemID, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbCategory, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDescription, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel4, 0, 3)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(24, 63)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.27586!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.72414!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(543, 312)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.Location = New System.Drawing.Point(51, 276)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(85, 25)
        Me.MetroLabel6.TabIndex = 19
        Me.MetroLabel6.Text = "Category:"
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
        Me.txtItemName.Location = New System.Drawing.Point(142, 34)
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
        Me.cmbCategory.Location = New System.Drawing.Point(142, 274)
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
        Me.txtDescription.Location = New System.Drawing.Point(142, 67)
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
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(66, 3)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(70, 25)
        Me.MetroLabel1.TabIndex = 14
        Me.MetroLabel1.Text = "Item ID:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(36, 35)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(100, 25)
        Me.MetroLabel2.TabIndex = 15
        Me.MetroLabel2.Text = "Item Name:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(35, 110)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(101, 25)
        Me.MetroLabel3.TabIndex = 16
        Me.MetroLabel3.Text = "Description:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(10, 231)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(126, 25)
        Me.MetroLabel5.TabIndex = 18
        Me.MetroLabel5.Text = "Stock Quantity:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(83, 189)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(53, 25)
        Me.MetroLabel4.TabIndex = 17
        Me.MetroLabel4.Text = "Price:"
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
        Me.btnAddItem.Location = New System.Drawing.Point(149, 381)
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
        Me.btnClear.Location = New System.Drawing.Point(349, 381)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(184, 43)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "&Clear"
        Me.btnClear.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnClear.UseCustomBackColor = True
        Me.btnClear.UseCustomForeColor = True
        Me.btnClear.UseSelectable = True
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(591, 486)
        Me.MinimumSize = New System.Drawing.Size(591, 486)
        Me.Name = "AddItem"
        Me.Padding = New System.Windows.Forms.Padding(21, 60, 21, 20)
        Me.Resizable = False
        Me.Text = "Add New Item"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numStockQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents numStockQuantity As NumericUpDown
    Friend WithEvents numPrice As NumericUpDown
    Friend WithEvents txtItemID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmbCategory As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnAddItem As MetroFramework.Controls.MetroButton
    Friend WithEvents btnClear As MetroFramework.Controls.MetroButton
    Friend WithEvents txtDescription As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtItemName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
End Class
