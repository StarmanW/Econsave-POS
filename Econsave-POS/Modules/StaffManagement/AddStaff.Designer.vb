<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddStaff
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblstaff = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.grpEmployee = New System.Windows.Forms.GroupBox()
        Me.txtConfirmPassword = New MetroFramework.Controls.MetroTextBox()
        Me.txtPassword = New MetroFramework.Controls.MetroTextBox()
        Me.txtName = New MetroFramework.Controls.MetroTextBox()
        Me.txtStaffID = New MetroFramework.Controls.MetroTextBox()
        Me.lblDialogBoxPassword = New System.Windows.Forms.Label()
        Me.radCashier = New System.Windows.Forms.RadioButton()
        Me.radManager = New System.Windows.Forms.RadioButton()
        Me.lblDialogbox = New System.Windows.Forms.Label()
        Me.lblconfirmpassword = New System.Windows.Forms.Label()
        Me.EconsaveDBDataSet = New Econsave_POS.EconsaveDBDataSet()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New Econsave_POS.EconsaveDBDataSetTableAdapters.StaffTableAdapter()
        Me.StaffBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.StaffBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnRegisterStaff = New MetroFramework.Controls.MetroButton()
        Me.btnClear = New MetroFramework.Controls.MetroButton()
        Me.grpEmployee.SuspendLayout()
        CType(Me.EconsaveDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(136, 123)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(88, 28)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lblPosition
        '
        Me.lblPosition.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(120, 336)
        Me.lblPosition.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(104, 28)
        Me.lblPosition.TabIndex = 0
        Me.lblPosition.Text = "Position :"
        '
        'lblstaff
        '
        Me.lblstaff.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstaff.Location = New System.Drawing.Point(121, 55)
        Me.lblstaff.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblstaff.Name = "lblstaff"
        Me.lblstaff.Size = New System.Drawing.Size(103, 28)
        Me.lblstaff.TabIndex = 0
        Me.lblstaff.Text = "Staff ID:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(109, 183)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(89, 23)
        Me.lblPassword.TabIndex = 0
        Me.lblPassword.Text = "Password :"
        '
        'grpEmployee
        '
        Me.grpEmployee.Controls.Add(Me.txtConfirmPassword)
        Me.grpEmployee.Controls.Add(Me.txtPassword)
        Me.grpEmployee.Controls.Add(Me.txtName)
        Me.grpEmployee.Controls.Add(Me.txtStaffID)
        Me.grpEmployee.Controls.Add(Me.lblDialogBoxPassword)
        Me.grpEmployee.Controls.Add(Me.radCashier)
        Me.grpEmployee.Controls.Add(Me.radManager)
        Me.grpEmployee.Controls.Add(Me.lblDialogbox)
        Me.grpEmployee.Controls.Add(Me.lblconfirmpassword)
        Me.grpEmployee.Controls.Add(Me.lblstaff)
        Me.grpEmployee.Controls.Add(Me.lblPosition)
        Me.grpEmployee.Controls.Add(Me.lblPassword)
        Me.grpEmployee.Controls.Add(Me.lblName)
        Me.grpEmployee.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEmployee.Location = New System.Drawing.Point(31, 91)
        Me.grpEmployee.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpEmployee.Name = "grpEmployee"
        Me.grpEmployee.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpEmployee.Size = New System.Drawing.Size(553, 374)
        Me.grpEmployee.TabIndex = 0
        Me.grpEmployee.TabStop = False
        Me.grpEmployee.Text = "Employee Details"
        '
        'txtConfirmPassword
        '
        '
        '
        '
        Me.txtConfirmPassword.CustomButton.Image = Nothing
        Me.txtConfirmPassword.CustomButton.Location = New System.Drawing.Point(348, 1)
        Me.txtConfirmPassword.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtConfirmPassword.CustomButton.Name = ""
        Me.txtConfirmPassword.CustomButton.Size = New System.Drawing.Size(47, 43)
        Me.txtConfirmPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtConfirmPassword.CustomButton.TabIndex = 1
        Me.txtConfirmPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtConfirmPassword.CustomButton.UseSelectable = True
        Me.txtConfirmPassword.CustomButton.Visible = False
        Me.txtConfirmPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtConfirmPassword.Lines = New String(-1) {}
        Me.txtConfirmPassword.Location = New System.Drawing.Point(221, 257)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtConfirmPassword.MaxLength = 32767
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtConfirmPassword.SelectedText = ""
        Me.txtConfirmPassword.SelectionLength = 0
        Me.txtConfirmPassword.SelectionStart = 0
        Me.txtConfirmPassword.ShortcutsEnabled = True
        Me.txtConfirmPassword.Size = New System.Drawing.Size(297, 37)
        Me.txtConfirmPassword.TabIndex = 4
        Me.txtConfirmPassword.UseSelectable = True
        Me.txtConfirmPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtConfirmPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.CustomButton.Image = Nothing
        Me.txtPassword.CustomButton.Location = New System.Drawing.Point(348, 1)
        Me.txtPassword.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassword.CustomButton.Name = ""
        Me.txtPassword.CustomButton.Size = New System.Drawing.Size(47, 43)
        Me.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPassword.CustomButton.TabIndex = 1
        Me.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPassword.CustomButton.UseSelectable = True
        Me.txtPassword.CustomButton.Visible = False
        Me.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPassword.Lines = New String(-1) {}
        Me.txtPassword.Location = New System.Drawing.Point(221, 183)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.ShortcutsEnabled = True
        Me.txtPassword.Size = New System.Drawing.Size(297, 37)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.UseSelectable = True
        Me.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtName
        '
        '
        '
        '
        Me.txtName.CustomButton.Image = Nothing
        Me.txtName.CustomButton.Location = New System.Drawing.Point(348, 1)
        Me.txtName.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtName.CustomButton.Name = ""
        Me.txtName.CustomButton.Size = New System.Drawing.Size(47, 43)
        Me.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtName.CustomButton.TabIndex = 1
        Me.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtName.CustomButton.UseSelectable = True
        Me.txtName.CustomButton.Visible = False
        Me.txtName.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtName.Lines = New String(-1) {}
        Me.txtName.Location = New System.Drawing.Point(221, 114)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtName.MaxLength = 32767
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtName.SelectedText = ""
        Me.txtName.SelectionLength = 0
        Me.txtName.SelectionStart = 0
        Me.txtName.ShortcutsEnabled = True
        Me.txtName.Size = New System.Drawing.Size(297, 37)
        Me.txtName.TabIndex = 2
        Me.txtName.UseSelectable = True
        Me.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtStaffID
        '
        '
        '
        '
        Me.txtStaffID.CustomButton.Image = Nothing
        Me.txtStaffID.CustomButton.Location = New System.Drawing.Point(348, 1)
        Me.txtStaffID.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStaffID.CustomButton.Name = ""
        Me.txtStaffID.CustomButton.Size = New System.Drawing.Size(47, 43)
        Me.txtStaffID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStaffID.CustomButton.TabIndex = 1
        Me.txtStaffID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStaffID.CustomButton.UseSelectable = True
        Me.txtStaffID.CustomButton.Visible = False
        Me.txtStaffID.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtStaffID.Lines = New String(-1) {}
        Me.txtStaffID.Location = New System.Drawing.Point(221, 46)
        Me.txtStaffID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStaffID.MaxLength = 32767
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStaffID.ReadOnly = True
        Me.txtStaffID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStaffID.SelectedText = ""
        Me.txtStaffID.SelectionLength = 0
        Me.txtStaffID.SelectionStart = 0
        Me.txtStaffID.ShortcutsEnabled = True
        Me.txtStaffID.Size = New System.Drawing.Size(297, 37)
        Me.txtStaffID.TabIndex = 1
        Me.txtStaffID.UseSelectable = True
        Me.txtStaffID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStaffID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblDialogBoxPassword
        '
        Me.lblDialogBoxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDialogBoxPassword.Location = New System.Drawing.Point(217, 224)
        Me.lblDialogBoxPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDialogBoxPassword.Name = "lblDialogBoxPassword"
        Me.lblDialogBoxPassword.Size = New System.Drawing.Size(317, 30)
        Me.lblDialogBoxPassword.TabIndex = 21
        '
        'radCashier
        '
        Me.radCashier.AutoSize = True
        Me.radCashier.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCashier.Location = New System.Drawing.Point(344, 337)
        Me.radCashier.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radCashier.Name = "radCashier"
        Me.radCashier.Size = New System.Drawing.Size(87, 27)
        Me.radCashier.TabIndex = 6
        Me.radCashier.TabStop = True
        Me.radCashier.Text = "Cashier"
        Me.radCashier.UseVisualStyleBackColor = True
        '
        'radManager
        '
        Me.radManager.AutoSize = True
        Me.radManager.Checked = True
        Me.radManager.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radManager.Location = New System.Drawing.Point(216, 337)
        Me.radManager.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radManager.Name = "radManager"
        Me.radManager.Size = New System.Drawing.Size(99, 27)
        Me.radManager.TabIndex = 5
        Me.radManager.TabStop = True
        Me.radManager.Text = "Manager"
        Me.radManager.UseVisualStyleBackColor = True
        '
        'lblDialogbox
        '
        Me.lblDialogbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDialogbox.Location = New System.Drawing.Point(221, 298)
        Me.lblDialogbox.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDialogbox.Name = "lblDialogbox"
        Me.lblDialogbox.Size = New System.Drawing.Size(297, 25)
        Me.lblDialogbox.TabIndex = 17
        '
        'lblconfirmpassword
        '
        Me.lblconfirmpassword.AutoSize = True
        Me.lblconfirmpassword.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfirmpassword.Location = New System.Drawing.Point(43, 257)
        Me.lblconfirmpassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblconfirmpassword.Name = "lblconfirmpassword"
        Me.lblconfirmpassword.Size = New System.Drawing.Size(155, 23)
        Me.lblconfirmpassword.TabIndex = 0
        Me.lblconfirmpassword.Text = "Confirm Password :"
        '
        'EconsaveDBDataSet
        '
        Me.EconsaveDBDataSet.DataSetName = "EconsaveDBDataSet"
        Me.EconsaveDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.EconsaveDBDataSet
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'StaffBindingSource1
        '
        Me.StaffBindingSource1.DataMember = "Staff"
        Me.StaffBindingSource1.DataSource = Me.EconsaveDBDataSet
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'StaffBindingSource2
        '
        Me.StaffBindingSource2.DataMember = "Staff"
        Me.StaffBindingSource2.DataSource = Me.EconsaveDBDataSet
        '
        'StaffBindingSource3
        '
        Me.StaffBindingSource3.DataMember = "Staff"
        Me.StaffBindingSource3.DataSource = Me.EconsaveDBDataSet
        '
        'StaffBindingSource4
        '
        Me.StaffBindingSource4.DataMember = "Staff"
        Me.StaffBindingSource4.DataSource = Me.EconsaveDBDataSet
        '
        'btnRegisterStaff
        '
        Me.btnRegisterStaff.BackColor = System.Drawing.Color.Green
        Me.btnRegisterStaff.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRegisterStaff.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnRegisterStaff.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRegisterStaff.Location = New System.Drawing.Point(154, 492)
        Me.btnRegisterStaff.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRegisterStaff.Name = "btnRegisterStaff"
        Me.btnRegisterStaff.Size = New System.Drawing.Size(139, 59)
        Me.btnRegisterStaff.TabIndex = 10
        Me.btnRegisterStaff.Text = "&Register Staff"
        Me.btnRegisterStaff.UseCustomBackColor = True
        Me.btnRegisterStaff.UseCustomForeColor = True
        Me.btnRegisterStaff.UseSelectable = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClear.Location = New System.Drawing.Point(323, 492)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(139, 59)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseCustomBackColor = True
        Me.btnClear.UseCustomForeColor = True
        Me.btnClear.UseSelectable = True
        '
        'AddStaff
        '
        Me.AcceptButton = Me.btnRegisterStaff
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 596)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRegisterStaff)
        Me.Controls.Add(Me.grpEmployee)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "AddStaff"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Resizable = False
        Me.Text = "Register New Employee "
        Me.grpEmployee.ResumeLayout(False)
        Me.grpEmployee.PerformLayout()
        CType(Me.EconsaveDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblName As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblstaff As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents grpEmployee As GroupBox
    Friend WithEvents lblconfirmpassword As Label
    Friend WithEvents lblDialogbox As Label
    Friend WithEvents EconsaveDBDataSet As EconsaveDBDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As EconsaveDBDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents StaffBindingSource1 As BindingSource
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents StaffBindingSource3 As BindingSource
    Friend WithEvents StaffBindingSource2 As BindingSource
    Friend WithEvents StaffBindingSource4 As BindingSource
    Friend WithEvents radCashier As RadioButton
    Friend WithEvents radManager As RadioButton
    Friend WithEvents lblDialogBoxPassword As Label
    Friend WithEvents txtConfirmPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtStaffID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnClear As MetroFramework.Controls.MetroButton
    Friend WithEvents btnRegisterStaff As MetroFramework.Controls.MetroButton
End Class
