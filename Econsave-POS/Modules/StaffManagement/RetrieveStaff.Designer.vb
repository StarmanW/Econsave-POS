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
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EconsaveDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EconsaveDBDataSet = New Econsave_POS.EconsaveDBDataSet()
        Me.txtSearchitem = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffTableAdapter = New Econsave_POS.EconsaveDBDataSetTableAdapters.StaffTableAdapter()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegisteredOnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastLoginDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EconsaveDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EconsaveDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.EconsaveDBDataSetBindingSource
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
        'txtSearchitem
        '
        Me.txtSearchitem.Location = New System.Drawing.Point(231, 101)
        Me.txtSearchitem.Multiline = True
        Me.txtSearchitem.Name = "txtSearchitem"
        Me.txtSearchitem.Size = New System.Drawing.Size(169, 29)
        Me.txtSearchitem.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(632, 24)
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
        Me.RegisterEmployeeToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.RegisterEmployeeToolStripMenuItem.Text = "Register Employee"
        '
        'UpdateEmployeeToolStripMenuItem
        '
        Me.UpdateEmployeeToolStripMenuItem.Name = "UpdateEmployeeToolStripMenuItem"
        Me.UpdateEmployeeToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.UpdateEmployeeToolStripMenuItem.Text = "Update Employee "
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
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
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.FontToolStripMenuItem.Text = "Clear"
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'btnSearch
        '
        Me.btnSearch.CausesValidation = False
        Me.btnSearch.Location = New System.Drawing.Point(415, 101)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.RegisteredOnDataGridViewTextBoxColumn, Me.LastLoginDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StaffBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 152)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(646, 199)
        Me.DataGridView1.TabIndex = 5
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
        'StaffBindingSource1
        '
        Me.StaffBindingSource1.DataMember = "Staff"
        Me.StaffBindingSource1.DataSource = Me.EconsaveDBDataSetBindingSource
        '
        'RetrieveStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 374)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearchitem)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "RetrieveStaff"
        Me.Text = "Employee Details"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EconsaveDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EconsaveDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EconsaveDBDataSetBindingSource As BindingSource
    Friend WithEvents EconsaveDBDataSet As EconsaveDBDataSet
    Friend WithEvents txtSearchitem As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As EconsaveDBDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents btnSearch As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegisteredOnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastLoginDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffBindingSource1 As BindingSource
End Class
