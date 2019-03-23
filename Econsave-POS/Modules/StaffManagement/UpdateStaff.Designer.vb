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
        Me.lblSearchKey = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblstaffid = New System.Windows.Forms.Label()
        Me.lblstaffname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EconsaveDBDataSet = New Econsave_POS.EconsaveDBDataSet()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New Econsave_POS.EconsaveDBDataSetTableAdapters.StaffTableAdapter()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegisteredOnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastLoginDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblshowname = New System.Windows.Forms.Label()
        Me.lblShwID = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EconsaveDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSearchKey
        '
        Me.lblSearchKey.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchKey.Location = New System.Drawing.Point(217, 119)
        Me.lblSearchKey.Name = "lblSearchKey"
        Me.lblSearchKey.Size = New System.Drawing.Size(69, 23)
        Me.lblSearchKey.TabIndex = 0
        Me.lblSearchKey.Text = "Search : "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(292, 112)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(202, 30)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Tag = ""
        '
        'lblstaffid
        '
        Me.lblstaffid.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstaffid.Location = New System.Drawing.Point(16, 175)
        Me.lblstaffid.Name = "lblstaffid"
        Me.lblstaffid.Size = New System.Drawing.Size(80, 23)
        Me.lblstaffid.TabIndex = 2
        Me.lblstaffid.Text = "Staff ID : "
        '
        'lblstaffname
        '
        Me.lblstaffname.AutoSize = True
        Me.lblstaffname.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstaffname.Location = New System.Drawing.Point(23, 232)
        Me.lblstaffname.Name = "lblstaffname"
        Me.lblstaffname.Size = New System.Drawing.Size(61, 19)
        Me.lblstaffname.TabIndex = 3
        Me.lblstaffname.Text = "Name :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Psotion : "
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.RegisteredOnDataGridViewTextBoxColumn, Me.LastLoginDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StaffBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(10, 357)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(646, 181)
        Me.DataGridView1.TabIndex = 5
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
        'lblshowname
        '
        Me.lblshowname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblshowname.Location = New System.Drawing.Point(114, 219)
        Me.lblshowname.Name = "lblshowname"
        Me.lblshowname.Size = New System.Drawing.Size(161, 32)
        Me.lblshowname.TabIndex = 6
        '
        'lblShwID
        '
        Me.lblShwID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShwID.Location = New System.Drawing.Point(115, 169)
        Me.lblShwID.Name = "lblShwID"
        Me.lblShwID.Size = New System.Drawing.Size(160, 29)
        Me.lblShwID.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(625, 29)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(114, 275)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(161, 32)
        Me.TextBox2.TabIndex = 9
        '
        'UpdateStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 546)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblShwID)
        Me.Controls.Add(Me.lblshowname)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblstaffname)
        Me.Controls.Add(Me.lblstaffid)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblSearchKey)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "UpdateStaff"
        Me.Text = "Update Employee Details"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EconsaveDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSearchKey As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblstaffid As Label
    Friend WithEvents lblstaffname As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EconsaveDBDataSet As EconsaveDBDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As EconsaveDBDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegisteredOnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastLoginDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblshowname As Label
    Friend WithEvents lblShwID As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TextBox2 As TextBox
End Class
