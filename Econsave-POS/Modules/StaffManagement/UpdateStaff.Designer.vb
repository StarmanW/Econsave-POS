<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateStaff))
        Me.btnExit = New MetroFramework.Controls.MetroButton()
        Me.btnUpdateItem = New MetroFramework.Controls.MetroButton()
        Me.radManager = New MetroFramework.Controls.MetroRadioButton()
        Me.txtPassword = New MetroFramework.Controls.MetroTextBox()
        Me.txtStaffName = New MetroFramework.Controls.MetroTextBox()
        Me.txtStaffID = New MetroFramework.Controls.MetroTextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.radCashier = New MetroFramework.Controls.MetroRadioButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(292, 282)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(184, 43)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.btnExit.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnExit.UseCustomBackColor = True
        Me.btnExit.UseCustomForeColor = True
        Me.btnExit.UseSelectable = True
        '
        'btnUpdateItem
        '
        Me.btnUpdateItem.BackColor = System.Drawing.Color.Green
        Me.btnUpdateItem.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnUpdateItem.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnUpdateItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdateItem.Location = New System.Drawing.Point(62, 282)
        Me.btnUpdateItem.Name = "btnUpdateItem"
        Me.btnUpdateItem.Size = New System.Drawing.Size(185, 43)
        Me.btnUpdateItem.TabIndex = 14
        Me.btnUpdateItem.Text = "&Update Details"
        Me.btnUpdateItem.UseCustomBackColor = True
        Me.btnUpdateItem.UseCustomForeColor = True
        Me.btnUpdateItem.UseSelectable = True
        '
        'radManager
        '
        Me.radManager.AutoSize = True
        Me.radManager.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.radManager.Location = New System.Drawing.Point(143, 240)
        Me.radManager.Name = "radManager"
        Me.radManager.Size = New System.Drawing.Size(98, 25)
        Me.radManager.TabIndex = 10
        Me.radManager.Text = "Manager"
        Me.radManager.UseSelectable = True
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.CustomButton.Image = Nothing
        Me.txtPassword.CustomButton.Location = New System.Drawing.Point(315, 2)
        Me.txtPassword.CustomButton.Name = ""
        Me.txtPassword.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPassword.CustomButton.TabIndex = 1
        Me.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPassword.CustomButton.UseSelectable = True
        Me.txtPassword.CustomButton.Visible = False
        Me.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPassword.Lines = New String(-1) {}
        Me.txtPassword.Location = New System.Drawing.Point(133, 179)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.ShortcutsEnabled = True
        Me.txtPassword.Size = New System.Drawing.Size(343, 30)
        Me.txtPassword.TabIndex = 9
        Me.txtPassword.UseSelectable = True
        Me.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtStaffName
        '
        '
        '
        '
        Me.txtStaffName.CustomButton.Image = Nothing
        Me.txtStaffName.CustomButton.Location = New System.Drawing.Point(315, 2)
        Me.txtStaffName.CustomButton.Name = ""
        Me.txtStaffName.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtStaffName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStaffName.CustomButton.TabIndex = 1
        Me.txtStaffName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStaffName.CustomButton.UseSelectable = True
        Me.txtStaffName.CustomButton.Visible = False
        Me.txtStaffName.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtStaffName.Lines = New String(-1) {}
        Me.txtStaffName.Location = New System.Drawing.Point(133, 124)
        Me.txtStaffName.MaxLength = 32767
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStaffName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStaffName.SelectedText = ""
        Me.txtStaffName.SelectionLength = 0
        Me.txtStaffName.SelectionStart = 0
        Me.txtStaffName.ShortcutsEnabled = True
        Me.txtStaffName.Size = New System.Drawing.Size(343, 30)
        Me.txtStaffName.TabIndex = 8
        Me.txtStaffName.UseSelectable = True
        Me.txtStaffName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStaffName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtStaffID
        '
        '
        '
        '
        Me.txtStaffID.CustomButton.Image = Nothing
        Me.txtStaffID.CustomButton.Location = New System.Drawing.Point(315, 2)
        Me.txtStaffID.CustomButton.Name = ""
        Me.txtStaffID.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtStaffID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStaffID.CustomButton.TabIndex = 1
        Me.txtStaffID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStaffID.CustomButton.UseSelectable = True
        Me.txtStaffID.CustomButton.Visible = False
        Me.txtStaffID.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtStaffID.Lines = New String(-1) {}
        Me.txtStaffID.Location = New System.Drawing.Point(133, 76)
        Me.txtStaffID.MaxLength = 32767
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStaffID.ReadOnly = True
        Me.txtStaffID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStaffID.SelectedText = ""
        Me.txtStaffID.SelectionLength = 0
        Me.txtStaffID.SelectionStart = 0
        Me.txtStaffID.ShortcutsEnabled = True
        Me.txtStaffID.Size = New System.Drawing.Size(343, 30)
        Me.txtStaffID.TabIndex = 1
        Me.txtStaffID.UseSelectable = True
        Me.txtStaffID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStaffID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(58, 240)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(69, 20)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "Position:"
        '
        'lblDescription
        '
        Me.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(45, 179)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(82, 20)
        Me.lblDescription.TabIndex = 6
        Me.lblDescription.Text = "Password:"
        '
        'lblItemName
        '
        Me.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(33, 124)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(94, 20)
        Me.lblItemName.TabIndex = 5
        Me.lblItemName.Text = "Staff Name:"
        '
        'lblStaffID
        '
        Me.lblStaffID.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffID.Location = New System.Drawing.Point(58, 76)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(69, 20)
        Me.lblStaffID.TabIndex = 4
        Me.lblStaffID.Text = "Staff ID:"
        '
        'radCashier
        '
        Me.radCashier.AutoSize = True
        Me.radCashier.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.radCashier.Location = New System.Drawing.Point(247, 240)
        Me.radCashier.Name = "radCashier"
        Me.radCashier.Size = New System.Drawing.Size(85, 25)
        Me.radCashier.TabIndex = 11
        Me.radCashier.Text = "Cashier"
        Me.radCashier.UseSelectable = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'UpdateStaff
        '
        Me.AcceptButton = Me.btnUpdateItem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(518, 349)
        Me.Controls.Add(Me.radManager)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblItemName)
        Me.Controls.Add(Me.lblStaffID)
        Me.Controls.Add(Me.radCashier)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.txtStaffID)
        Me.Controls.Add(Me.btnUpdateItem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "UpdateStaff"
        Me.Resizable = False
        Me.Text = "Update Staff Details"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As MetroFramework.Controls.MetroButton
    Friend WithEvents btnUpdateItem As MetroFramework.Controls.MetroButton
    Friend WithEvents radManager As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents txtPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtStaffName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtStaffID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblItemName As Label
    Friend WithEvents lblStaffID As Label
    Friend WithEvents radCashier As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
