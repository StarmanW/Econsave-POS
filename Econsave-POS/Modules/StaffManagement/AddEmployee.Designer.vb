<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddEmployee
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
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListAllEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpEmployee = New System.Windows.Forms.GroupBox()
        Me.lblDialogbox = New System.Windows.Forms.Label()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.lblconfirmpassword = New System.Windows.Forms.Label()
        Me.txtconfirmpassword = New System.Windows.Forms.TextBox()
        Me.lstvData = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EconsaveDBDataSet = New Econsave_POS.EconsaveDBDataSet()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New Econsave_POS.EconsaveDBDataSetTableAdapters.StaffTableAdapter()
        Me.StaffBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnView = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.StaffBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.radManager = New System.Windows.Forms.RadioButton()
        Me.radCashier = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1.SuspendLayout()
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
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(27, 90)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(66, 23)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name : "
        '
        'lblPosition
        '
        Me.lblPosition.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(15, 137)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(78, 23)
        Me.lblPosition.TabIndex = 3
        Me.lblPosition.Text = "Position :"
        '
        'lblstaff
        '
        Me.lblstaff.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstaff.Location = New System.Drawing.Point(16, 37)
        Me.lblstaff.Name = "lblstaff"
        Me.lblstaff.Size = New System.Drawing.Size(77, 23)
        Me.lblstaff.TabIndex = 4
        Me.lblstaff.Text = "Staff ID :"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(358, 45)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(87, 19)
        Me.lblPassword.TabIndex = 7
        Me.lblPassword.Text = "Password :"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(451, 47)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(181, 20)
        Me.txtPassword.TabIndex = 10
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(99, 93)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(177, 20)
        Me.txtName.TabIndex = 11
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(233, 192)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(81, 28)
        Me.btnRegister.TabIndex = 0
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(668, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.ListAllEmployeeToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'ListAllEmployeeToolStripMenuItem
        '
        Me.ListAllEmployeeToolStripMenuItem.Name = "ListAllEmployeeToolStripMenuItem"
        Me.ListAllEmployeeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ListAllEmployeeToolStripMenuItem.Text = "List all employee"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'grpEmployee
        '
        Me.grpEmployee.Controls.Add(Me.radCashier)
        Me.grpEmployee.Controls.Add(Me.radManager)
        Me.grpEmployee.Controls.Add(Me.btnView)
        Me.grpEmployee.Controls.Add(Me.lblDialogbox)
        Me.grpEmployee.Controls.Add(Me.lblStaffID)
        Me.grpEmployee.Controls.Add(Me.lblconfirmpassword)
        Me.grpEmployee.Controls.Add(Me.txtconfirmpassword)
        Me.grpEmployee.Controls.Add(Me.btnRegister)
        Me.grpEmployee.Controls.Add(Me.lblstaff)
        Me.grpEmployee.Controls.Add(Me.lblPosition)
        Me.grpEmployee.Controls.Add(Me.txtPassword)
        Me.grpEmployee.Controls.Add(Me.txtName)
        Me.grpEmployee.Controls.Add(Me.lblPassword)
        Me.grpEmployee.Controls.Add(Me.lblName)
        Me.grpEmployee.Location = New System.Drawing.Point(23, 104)
        Me.grpEmployee.Name = "grpEmployee"
        Me.grpEmployee.Size = New System.Drawing.Size(665, 241)
        Me.grpEmployee.TabIndex = 14
        Me.grpEmployee.TabStop = False
        Me.grpEmployee.Text = "Employee Details"
        '
        'lblDialogbox
        '
        Me.lblDialogbox.Location = New System.Drawing.Point(451, 113)
        Me.lblDialogbox.Name = "lblDialogbox"
        Me.lblDialogbox.Size = New System.Drawing.Size(181, 23)
        Me.lblDialogbox.TabIndex = 17
        '
        'lblStaffID
        '
        Me.lblStaffID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStaffID.Location = New System.Drawing.Point(99, 37)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(177, 23)
        Me.lblStaffID.TabIndex = 15
        '
        'lblconfirmpassword
        '
        Me.lblconfirmpassword.AutoSize = True
        Me.lblconfirmpassword.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfirmpassword.Location = New System.Drawing.Point(296, 91)
        Me.lblconfirmpassword.Name = "lblconfirmpassword"
        Me.lblconfirmpassword.Size = New System.Drawing.Size(149, 19)
        Me.lblconfirmpassword.TabIndex = 14
        Me.lblconfirmpassword.Text = "Confirm Password :"
        '
        'txtconfirmpassword
        '
        Me.txtconfirmpassword.Location = New System.Drawing.Point(451, 90)
        Me.txtconfirmpassword.Name = "txtconfirmpassword"
        Me.txtconfirmpassword.Size = New System.Drawing.Size(181, 20)
        Me.txtconfirmpassword.TabIndex = 13
        Me.txtconfirmpassword.UseSystemPasswordChar = True
        '
        'lstvData
        '
        Me.lstvData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstvData.FullRowSelect = True
        Me.lstvData.GridLines = True
        Me.lstvData.Location = New System.Drawing.Point(43, 367)
        Me.lstvData.Name = "lstvData"
        Me.lstvData.Size = New System.Drawing.Size(599, 132)
        Me.lstvData.TabIndex = 15
        Me.lstvData.UseCompatibleStateImageBehavior = False
        Me.lstvData.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Staff ID"
        Me.ColumnHeader1.Width = 116
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Employee Name"
        Me.ColumnHeader2.Width = 169
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Position"
        Me.ColumnHeader3.Width = 159
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Password"
        Me.ColumnHeader4.Width = 153
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
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(347, 192)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(81, 28)
        Me.btnView.TabIndex = 18
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
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
        'radManager
        '
        Me.radManager.AutoSize = True
        Me.radManager.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radManager.Location = New System.Drawing.Point(99, 138)
        Me.radManager.Name = "radManager"
        Me.radManager.Size = New System.Drawing.Size(83, 22)
        Me.radManager.TabIndex = 19
        Me.radManager.TabStop = True
        Me.radManager.Text = "Manager"
        Me.radManager.UseVisualStyleBackColor = True
        '
        'radCashier
        '
        Me.radCashier.AutoSize = True
        Me.radCashier.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCashier.Location = New System.Drawing.Point(188, 138)
        Me.radCashier.Name = "radCashier"
        Me.radCashier.Size = New System.Drawing.Size(73, 22)
        Me.radCashier.TabIndex = 20
        Me.radCashier.TabStop = True
        Me.radCashier.Text = "Cashier"
        Me.radCashier.UseVisualStyleBackColor = True
        '
        'AddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 522)
        Me.Controls.Add(Me.lstvData)
        Me.Controls.Add(Me.grpEmployee)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AddEmployee"
        Me.Text = "Register New Employee "
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblstaff As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpEmployee As GroupBox
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListAllEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblconfirmpassword As Label
    Friend WithEvents txtconfirmpassword As TextBox
    Friend WithEvents lblStaffID As Label
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstvData As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents lblDialogbox As Label
    Friend WithEvents EconsaveDBDataSet As EconsaveDBDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As EconsaveDBDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents StaffBindingSource1 As BindingSource
    Friend WithEvents btnView As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents StaffBindingSource3 As BindingSource
    Friend WithEvents StaffBindingSource2 As BindingSource
    Friend WithEvents StaffBindingSource4 As BindingSource
    Friend WithEvents radCashier As RadioButton
    Friend WithEvents radManager As RadioButton
End Class
