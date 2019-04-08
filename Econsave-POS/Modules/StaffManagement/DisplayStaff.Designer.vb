<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DisplayStaff
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StaffTableAdapter = New Econsave_POS.EconsaveDBDataSetTableAdapters.StaffTableAdapter()
        Me.txtSearchBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.itemDGV = New System.Windows.Forms.DataGridView()
        CType(Me.itemDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'txtSearchBox
        '
        '
        '
        '
        Me.txtSearchBox.CustomButton.Image = Nothing
        Me.txtSearchBox.CustomButton.Location = New System.Drawing.Point(324, 2)
        Me.txtSearchBox.CustomButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearchBox.CustomButton.Name = ""
        Me.txtSearchBox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtSearchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearchBox.CustomButton.TabIndex = 1
        Me.txtSearchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearchBox.CustomButton.UseSelectable = True
        Me.txtSearchBox.CustomButton.Visible = False
        Me.txtSearchBox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtSearchBox.Lines = New String(-1) {}
        Me.txtSearchBox.Location = New System.Drawing.Point(109, 97)
        Me.txtSearchBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearchBox.MaxLength = 32767
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearchBox.SelectedText = ""
        Me.txtSearchBox.SelectionLength = 0
        Me.txtSearchBox.SelectionStart = 0
        Me.txtSearchBox.ShortcutsEnabled = True
        Me.txtSearchBox.Size = New System.Drawing.Size(352, 30)
        Me.txtSearchBox.TabIndex = 7
        Me.txtSearchBox.UseSelectable = True
        Me.txtSearchBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearchBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(34, 97)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(68, 25)
        Me.MetroLabel1.TabIndex = 6
        Me.MetroLabel1.Text = "Search:"
        '
        'itemDGV
        '
        Me.itemDGV.AllowUserToAddRows = False
        Me.itemDGV.AllowUserToDeleteRows = False
        Me.itemDGV.AllowUserToResizeColumns = False
        Me.itemDGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.itemDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.itemDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.itemDGV.BackgroundColor = System.Drawing.Color.White
        Me.itemDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.itemDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.itemDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.itemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.itemDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.itemDGV.Location = New System.Drawing.Point(34, 143)
        Me.itemDGV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.itemDGV.Name = "itemDGV"
        Me.itemDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.itemDGV.RowHeadersVisible = False
        Me.itemDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.itemDGV.Size = New System.Drawing.Size(1276, 509)
        Me.itemDGV.TabIndex = 5
        '
        'DisplayStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1353, 704)
        Me.Controls.Add(Me.txtSearchBox)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.itemDGV)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "DisplayStaff"
        Me.Padding = New System.Windows.Forms.Padding(30, 92, 30, 31)
        Me.Resizable = False
        Me.Text = "Employee Details"
        CType(Me.itemDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StaffTableAdapter As EconsaveDBDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents txtSearchBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents itemDGV As DataGridView
End Class
