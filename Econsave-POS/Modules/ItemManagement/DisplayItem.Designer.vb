<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DisplayItem
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
        Me.itemDGV = New System.Windows.Forms.DataGridView()
        Me.cmbCategory = New MetroFramework.Controls.MetroComboBox()
        Me.lblCategory = New MetroFramework.Controls.MetroLabel()
        Me.EconsaveDBDataSet1 = New Econsave_POS.EconsaveDBDataSet()
        CType(Me.itemDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EconsaveDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'itemDGV
        '
        Me.itemDGV.AllowUserToResizeColumns = False
        Me.itemDGV.AllowUserToResizeRows = False
        Me.itemDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.itemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.itemDGV.Location = New System.Drawing.Point(23, 94)
        Me.itemDGV.Name = "itemDGV"
        Me.itemDGV.Size = New System.Drawing.Size(851, 331)
        Me.itemDGV.TabIndex = 0
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.ItemHeight = 23
        Me.cmbCategory.Location = New System.Drawing.Point(115, 59)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(203, 29)
        Me.cmbCategory.TabIndex = 1
        Me.cmbCategory.UseSelectable = True
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblCategory.Location = New System.Drawing.Point(24, 59)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(85, 25)
        Me.lblCategory.TabIndex = 2
        Me.lblCategory.Text = "Category:"
        '
        'EconsaveDBDataSet1
        '
        Me.EconsaveDBDataSet1.DataSetName = "EconsaveDBDataSet"
        Me.EconsaveDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DisplayItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 450)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.itemDGV)
        Me.Name = "DisplayItem"
        Me.Text = "Display Item"
        CType(Me.itemDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EconsaveDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents itemDGV As DataGridView
    Friend WithEvents cmbCategory As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lblCategory As MetroFramework.Controls.MetroLabel
    Friend WithEvents EconsaveDBDataSet1 As EconsaveDBDataSet
End Class
