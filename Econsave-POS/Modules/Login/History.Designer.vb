<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
    Inherits System.Windows.Forms.Form

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.historyDataGV = New System.Windows.Forms.DataGridView()
        Me.EconsaveDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EconsaveDBDataSet = New Econsave_POS.EconsaveDBDataSet()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.historyDataGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EconsaveDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EconsaveDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(191, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date :"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(297, 68)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(389, 30)
        Me.txtDate.TabIndex = 1
        '
        'historyDataGV
        '
        Me.historyDataGV.AllowUserToAddRows = False
        Me.historyDataGV.AllowUserToDeleteRows = False
        Me.historyDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.historyDataGV.Location = New System.Drawing.Point(63, 130)
        Me.historyDataGV.Name = "historyDataGV"
        Me.historyDataGV.ReadOnly = True
        Me.historyDataGV.RowTemplate.Height = 24
        Me.historyDataGV.Size = New System.Drawing.Size(876, 402)
        Me.historyDataGV.TabIndex = 2
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
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(705, 68)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(136, 30)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 560)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.historyDataGV)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "History"
        Me.Text = "History"
        CType(Me.historyDataGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EconsaveDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EconsaveDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents historyDataGV As DataGridView
    Friend WithEvents EconsaveDBDataSetBindingSource As BindingSource
    Friend WithEvents EconsaveDBDataSet As EconsaveDBDataSet
    Friend WithEvents btnSearch As Button
End Class
