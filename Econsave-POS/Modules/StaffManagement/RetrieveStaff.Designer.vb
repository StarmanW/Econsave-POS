<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RetrieveStaff
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EconsaveDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EconsaveDBDataSet = New Econsave_POS.EconsaveDBDataSet()
        Me.lblSearchKey = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New Econsave_POS.EconsaveDBDataSetTableAdapters.StaffTableAdapter()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegisteredOnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastLoginDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EconsaveDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EconsaveDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.RegisteredOnDataGridViewTextBoxColumn, Me.LastLoginDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StaffBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(11, 159)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(650, 191)
        Me.DataGridView1.TabIndex = 0
        '
        'EconsaveDBDataSetBindingSource
        '
        Me.EconsaveDBDataSetBindingSource.DataSource = Me.EconsaveDBDataSet
        Me.EconsaveDBDataSetBindingSource.Position = 0
        '
        'EconsaveDBDataSet
        '
        Me.EconsaveDBDataSet.DataSetName = "EconsaveDBDataSet"
        Me.EconsaveDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblSearchKey
        '
        Me.lblSearchKey.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchKey.Location = New System.Drawing.Point(23, 101)
        Me.lblSearchKey.Name = "lblSearchKey"
        Me.lblSearchKey.Size = New System.Drawing.Size(74, 31)
        Me.lblSearchKey.TabIndex = 1
        Me.lblSearchKey.Text = "Search :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(103, 101)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 29)
        Me.TextBox1.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(634, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterEmployeeToolStripMenuItem, Me.UpdateEmployeeToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ViewToolStripMenuItem.Text = "File"
        '
        'RegisterEmployeeToolStripMenuItem
        '
        Me.RegisterEmployeeToolStripMenuItem.Name = "RegisterEmployeeToolStripMenuItem"
        Me.RegisterEmployeeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RegisterEmployeeToolStripMenuItem.Text = "Register Employee"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FontToolStripMenuItem.Text = "Clear"
        '
        'UpdateEmployeeToolStripMenuItem
        '
        Me.UpdateEmployeeToolStripMenuItem.Name = "UpdateEmployeeToolStripMenuItem"
        Me.UpdateEmployeeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UpdateEmployeeToolStripMenuItem.Text = "Update Employee "
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.EconsaveDBDataSetBindingSource
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "staffID"
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "staffID"
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'RegisteredOnDataGridViewTextBoxColumn
        '
        Me.RegisteredOnDataGridViewTextBoxColumn.DataPropertyName = "registeredOn"
        Me.RegisteredOnDataGridViewTextBoxColumn.HeaderText = "registeredOn"
        Me.RegisteredOnDataGridViewTextBoxColumn.Name = "RegisteredOnDataGridViewTextBoxColumn"
        '
        'LastLoginDataGridViewTextBoxColumn
        '
        Me.LastLoginDataGridViewTextBoxColumn.DataPropertyName = "lastLogin"
        Me.LastLoginDataGridViewTextBoxColumn.HeaderText = "lastLogin"
        Me.LastLoginDataGridViewTextBoxColumn.Name = "LastLoginDataGridViewTextBoxColumn"
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "position"
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        '
        'RetrieveStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 371)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblSearchKey)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "RetrieveStaff"
        Me.Text = "Employee Details"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EconsaveDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EconsaveDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EconsaveDBDataSetBindingSource As BindingSource
    Friend WithEvents EconsaveDBDataSet As EconsaveDBDataSet
    Friend WithEvents lblSearchKey As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As EconsaveDBDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegisteredOnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastLoginDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
