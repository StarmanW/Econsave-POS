<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateItem
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnUpdateItem = New MetroFramework.Controls.MetroButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtItemName = New MetroFramework.Controls.MetroTextBox()
        Me.numStockQuantity = New System.Windows.Forms.NumericUpDown()
        Me.lblItemID = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblStockQuantity = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.numPrice = New System.Windows.Forms.NumericUpDown()
        Me.txtItemID = New MetroFramework.Controls.MetroTextBox()
        Me.cmbCategory = New MetroFramework.Controls.MetroComboBox()
        Me.txtDescription = New MetroFramework.Controls.MetroTextBox()
        Me.btnExit = New MetroFramework.Controls.MetroButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.numStockQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdateItem
        '
        Me.btnUpdateItem.BackColor = System.Drawing.Color.Green
        Me.btnUpdateItem.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnUpdateItem.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnUpdateItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdateItem.Location = New System.Drawing.Point(140, 384)
        Me.btnUpdateItem.Name = "btnUpdateItem"
        Me.btnUpdateItem.Size = New System.Drawing.Size(185, 43)
        Me.btnUpdateItem.TabIndex = 10
        Me.btnUpdateItem.Text = "&Update Item"
        Me.btnUpdateItem.UseCustomBackColor = True
        Me.btnUpdateItem.UseCustomForeColor = True
        Me.btnUpdateItem.UseSelectable = True
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(23, 63)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.27586!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.72414!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(526, 312)
        Me.TableLayoutPanel1.TabIndex = 9
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
        Me.txtItemName.Location = New System.Drawing.Point(121, 34)
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
        'numStockQuantity
        '
        Me.numStockQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.numStockQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numStockQuantity.Location = New System.Drawing.Point(121, 231)
        Me.numStockQuantity.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numStockQuantity.Name = "numStockQuantity"
        Me.numStockQuantity.Size = New System.Drawing.Size(384, 26)
        Me.numStockQuantity.TabIndex = 5
        Me.numStockQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblItemID
        '
        Me.lblItemID.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblItemID.AutoSize = True
        Me.lblItemID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemID.Location = New System.Drawing.Point(49, 5)
        Me.lblItemID.Name = "lblItemID"
        Me.lblItemID.Size = New System.Drawing.Size(66, 20)
        Me.lblItemID.TabIndex = 4
        Me.lblItemID.Text = "Item ID:"
        '
        'lblItemName
        '
        Me.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(24, 37)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(91, 20)
        Me.lblItemName.TabIndex = 5
        Me.lblItemName.Text = "Item Name:"
        '
        'lblDescription
        '
        Me.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(22, 112)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(93, 20)
        Me.lblDescription.TabIndex = 6
        Me.lblDescription.Text = "Description:"
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(67, 192)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(48, 20)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "Price:"
        '
        'lblStockQuantity
        '
        Me.lblStockQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblStockQuantity.AutoSize = True
        Me.lblStockQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockQuantity.Location = New System.Drawing.Point(43, 224)
        Me.lblStockQuantity.Name = "lblStockQuantity"
        Me.lblStockQuantity.Size = New System.Drawing.Size(72, 40)
        Me.lblStockQuantity.TabIndex = 8
        Me.lblStockQuantity.Text = "Stock Quantity:"
        '
        'lblCategory
        '
        Me.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(38, 278)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(77, 20)
        Me.lblCategory.TabIndex = 9
        Me.lblCategory.Text = "Category:"
        '
        'numPrice
        '
        Me.numPrice.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.numPrice.DecimalPlaces = 2
        Me.numPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPrice.Location = New System.Drawing.Point(121, 189)
        Me.numPrice.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numPrice.Name = "numPrice"
        Me.numPrice.Size = New System.Drawing.Size(384, 26)
        Me.numPrice.TabIndex = 4
        Me.numPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.txtItemID.Location = New System.Drawing.Point(121, 3)
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
        'cmbCategory
        '
        Me.cmbCategory.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.ItemHeight = 23
        Me.cmbCategory.Location = New System.Drawing.Point(121, 274)
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
        Me.txtDescription.Location = New System.Drawing.Point(121, 67)
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
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(345, 384)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(184, 43)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "E&xit"
        Me.btnExit.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnExit.UseCustomBackColor = True
        Me.btnExit.UseCustomForeColor = True
        Me.btnExit.UseSelectable = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'UpdateItem
        '
        Me.AcceptButton = Me.btnUpdateItem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(584, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUpdateItem)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.Name = "UpdateItem"
        Me.Resizable = False
        Me.Text = "Update Item"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.numStockQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUpdateItem As MetroFramework.Controls.MetroButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtItemName As MetroFramework.Controls.MetroTextBox
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
    Friend WithEvents txtDescription As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnExit As MetroFramework.Controls.MetroButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
End Class
