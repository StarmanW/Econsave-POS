<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
    'Inherits System.Windows.Forms.Form
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(History))
        Me.EconsaveDBDataSet = New Econsave_POS.EconsaveDBDataSet()
        Me.EconsaveDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.historyDataGV = New System.Windows.Forms.DataGridView()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.btnSearch = New MetroFramework.Controls.MetroButton()
        Me.btnReset = New MetroFramework.Controls.MetroButton()
        Me.btnPrint = New MetroFramework.Controls.MetroButton()
        Me.doc = New System.Drawing.Printing.PrintDocument()
        Me.dlgPrintPreview = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.EconsaveDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EconsaveDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.historyDataGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EconsaveDBDataSet
        '
        Me.EconsaveDBDataSet.DataSetName = "EconsaveDBDataSet"
        Me.EconsaveDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EconsaveDBDataSetBindingSource
        '
        Me.EconsaveDBDataSetBindingSource.DataSource = Me.EconsaveDBDataSet
        Me.EconsaveDBDataSetBindingSource.Position = 0
        '
        'historyDataGV
        '
        Me.historyDataGV.AllowUserToAddRows = False
        Me.historyDataGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.historyDataGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.historyDataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.historyDataGV.BackgroundColor = System.Drawing.Color.White
        Me.historyDataGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.historyDataGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.historyDataGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.historyDataGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.historyDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.historyDataGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.historyDataGV.Location = New System.Drawing.Point(62, 161)
        Me.historyDataGV.MultiSelect = False
        Me.historyDataGV.Name = "historyDataGV"
        Me.historyDataGV.ReadOnly = True
        Me.historyDataGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.historyDataGV.RowHeadersVisible = False
        Me.historyDataGV.RowTemplate.Height = 24
        Me.historyDataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.historyDataGV.Size = New System.Drawing.Size(650, 301)
        Me.historyDataGV.TabIndex = 9
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(62, 60)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(72, 25)
        Me.MetroLabel1.TabIndex = 10
        Me.MetroLabel1.Text = "Search :"
        '
        'txtSearch
        '
        '
        '
        '
        Me.txtSearch.CustomButton.Image = Nothing
        Me.txtSearch.CustomButton.Location = New System.Drawing.Point(250, 1)
        Me.txtSearch.CustomButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSearch.CustomButton.Name = ""
        Me.txtSearch.CustomButton.Size = New System.Drawing.Size(13, 14)
        Me.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearch.CustomButton.TabIndex = 1
        Me.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearch.CustomButton.UseSelectable = True
        Me.txtSearch.CustomButton.Visible = False
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(166, 60)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.Size = New System.Drawing.Size(351, 19)
        Me.txtSearch.TabIndex = 11
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.ForestGreen
        Me.btnSearch.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(540, 51)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 41)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseCustomBackColor = True
        Me.btnSearch.UseCustomForeColor = True
        Me.btnSearch.UseSelectable = True
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Red
        Me.btnReset.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(632, 51)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(80, 41)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseCustomBackColor = True
        Me.btnReset.UseCustomForeColor = True
        Me.btnReset.UseSelectable = True
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnPrint.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(632, 476)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 41)
        Me.btnPrint.TabIndex = 14
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseCustomBackColor = True
        Me.btnPrint.UseCustomForeColor = True
        Me.btnPrint.UseSelectable = True
        '
        'doc
        '
        Me.doc.DocumentName = "Daily Sales Report"
        Me.doc.OriginAtMargins = True
        '
        'dlgPrintPreview
        '
        Me.dlgPrintPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPrintPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPrintPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPrintPreview.Enabled = True
        Me.dlgPrintPreview.Icon = CType(resources.GetObject("dlgPrintPreview.Icon"), System.Drawing.Icon)
        Me.dlgPrintPreview.Name = "dlgPrintPreview"
        Me.dlgPrintPreview.UseAntiAlias = True
        Me.dlgPrintPreview.Visible = False
        '
        'History
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 525)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.historyDataGV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "History"
        Me.Padding = New System.Windows.Forms.Padding(15, 60, 15, 16)
        Me.Resizable = False
        Me.Text = "History"
        CType(Me.EconsaveDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EconsaveDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.historyDataGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EconsaveDBDataSet As EconsaveDBDataSet
    Friend WithEvents EconsaveDBDataSetBindingSource As BindingSource
    Friend WithEvents historyDataGV As DataGridView
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSearch As MetroFramework.Controls.MetroButton
    Friend WithEvents btnReset As MetroFramework.Controls.MetroButton
    Friend WithEvents btnPrint As MetroFramework.Controls.MetroButton
    Friend WithEvents doc As Printing.PrintDocument
    Friend WithEvents dlgPrintPreview As PrintPreviewDialog
End Class
