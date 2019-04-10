<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManagerForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailySalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlyStaffTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblWelcome = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.lblTotalStaff = New MetroFramework.Controls.MetroLabel()
        Me.lblStockQty = New MetroFramework.Controls.MetroLabel()
        Me.lblTransaction = New MetroFramework.Controls.MetroLabel()
        Me.lblRevenue = New MetroFramework.Controls.MetroLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.StaffManagementToolStripMenuItem, Me.ItemManagementToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(27, 74)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(587, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(65, 23)
        Me.FileToolStripMenuItem.Text = "Logout"
        '
        'StaffManagementToolStripMenuItem
        '
        Me.StaffManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStaffToolStripMenuItem, Me.DisplayStaffToolStripMenuItem, Me.ResetPasswordToolStripMenuItem})
        Me.StaffManagementToolStripMenuItem.Name = "StaffManagementToolStripMenuItem"
        Me.StaffManagementToolStripMenuItem.Size = New System.Drawing.Size(134, 23)
        Me.StaffManagementToolStripMenuItem.Text = "Staff Management"
        '
        'AddStaffToolStripMenuItem
        '
        Me.AddStaffToolStripMenuItem.Name = "AddStaffToolStripMenuItem"
        Me.AddStaffToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddStaffToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.AddStaffToolStripMenuItem.Text = "Add Staff"
        '
        'DisplayStaffToolStripMenuItem
        '
        Me.DisplayStaffToolStripMenuItem.Name = "DisplayStaffToolStripMenuItem"
        Me.DisplayStaffToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DisplayStaffToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.DisplayStaffToolStripMenuItem.Text = "Display Staff"
        '
        'ResetPasswordToolStripMenuItem
        '
        Me.ResetPasswordToolStripMenuItem.Name = "ResetPasswordToolStripMenuItem"
        Me.ResetPasswordToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ResetPasswordToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.ResetPasswordToolStripMenuItem.Text = "Reset Password"
        '
        'ItemManagementToolStripMenuItem
        '
        Me.ItemManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemToolStripMenuItem, Me.DisplayItemToolStripMenuItem})
        Me.ItemManagementToolStripMenuItem.Name = "ItemManagementToolStripMenuItem"
        Me.ItemManagementToolStripMenuItem.Size = New System.Drawing.Size(135, 23)
        Me.ItemManagementToolStripMenuItem.Text = "Item Management"
        '
        'AddItemToolStripMenuItem
        '
        Me.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem"
        Me.AddItemToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.D5), System.Windows.Forms.Keys)
        Me.AddItemToolStripMenuItem.Size = New System.Drawing.Size(232, 24)
        Me.AddItemToolStripMenuItem.Text = "Add Item"
        '
        'DisplayItemToolStripMenuItem
        '
        Me.DisplayItemToolStripMenuItem.Name = "DisplayItemToolStripMenuItem"
        Me.DisplayItemToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DisplayItemToolStripMenuItem.Size = New System.Drawing.Size(232, 24)
        Me.DisplayItemToolStripMenuItem.Text = "Display Item"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginHistoryToolStripMenuItem, Me.DailySalesToolStripMenuItem, Me.StockReportToolStripMenuItem, Me.MonthlyStaffTransactionToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(68, 23)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'LoginHistoryToolStripMenuItem
        '
        Me.LoginHistoryToolStripMenuItem.Name = "LoginHistoryToolStripMenuItem"
        Me.LoginHistoryToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LoginHistoryToolStripMenuItem.Size = New System.Drawing.Size(325, 24)
        Me.LoginHistoryToolStripMenuItem.Text = "Login History"
        '
        'DailySalesToolStripMenuItem
        '
        Me.DailySalesToolStripMenuItem.Name = "DailySalesToolStripMenuItem"
        Me.DailySalesToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DailySalesToolStripMenuItem.Size = New System.Drawing.Size(325, 24)
        Me.DailySalesToolStripMenuItem.Text = "Daily Sales"
        '
        'StockReportToolStripMenuItem
        '
        Me.StockReportToolStripMenuItem.Name = "StockReportToolStripMenuItem"
        Me.StockReportToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.StockReportToolStripMenuItem.Size = New System.Drawing.Size(325, 24)
        Me.StockReportToolStripMenuItem.Text = "Stock"
        '
        'MonthlyStaffTransactionToolStripMenuItem
        '
        Me.MonthlyStaffTransactionToolStripMenuItem.Name = "MonthlyStaffTransactionToolStripMenuItem"
        Me.MonthlyStaffTransactionToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MonthlyStaffTransactionToolStripMenuItem.Size = New System.Drawing.Size(325, 24)
        Me.MonthlyStaffTransactionToolStripMenuItem.Text = "Monthly Staff Transaction"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblWelcome.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblWelcome.Location = New System.Drawing.Point(27, 118)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(136, 25)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome back, "
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(27, 174)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(88, 25)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Statistics"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(27, 212)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(76, 19)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "Total Staff: "
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(27, 244)
        Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(131, 19)
        Me.MetroLabel4.TabIndex = 4
        Me.MetroLabel4.Text = "Total Items in Stock:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(27, 278)
        Me.MetroLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(120, 19)
        Me.MetroLabel5.TabIndex = 5
        Me.MetroLabel5.Text = "Total Transactions:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(27, 311)
        Me.MetroLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(111, 19)
        Me.MetroLabel6.TabIndex = 6
        Me.MetroLabel6.Text = "Overall Revenue:"
        '
        'lblTotalStaff
        '
        Me.lblTotalStaff.AutoSize = True
        Me.lblTotalStaff.Location = New System.Drawing.Point(110, 212)
        Me.lblTotalStaff.Name = "lblTotalStaff"
        Me.lblTotalStaff.Size = New System.Drawing.Size(83, 19)
        Me.lblTotalStaff.TabIndex = 7
        Me.lblTotalStaff.Text = "MetroLabel7"
        '
        'lblStockQty
        '
        Me.lblStockQty.AutoSize = True
        Me.lblStockQty.Location = New System.Drawing.Point(165, 244)
        Me.lblStockQty.Name = "lblStockQty"
        Me.lblStockQty.Size = New System.Drawing.Size(83, 19)
        Me.lblStockQty.TabIndex = 8
        Me.lblStockQty.Text = "MetroLabel8"
        '
        'lblTransaction
        '
        Me.lblTransaction.AutoSize = True
        Me.lblTransaction.Location = New System.Drawing.Point(154, 278)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(83, 19)
        Me.lblTransaction.TabIndex = 9
        Me.lblTransaction.Text = "MetroLabel9"
        '
        'lblRevenue
        '
        Me.lblRevenue.AutoSize = True
        Me.lblRevenue.Location = New System.Drawing.Point(145, 311)
        Me.lblRevenue.Name = "lblRevenue"
        Me.lblRevenue.Size = New System.Drawing.Size(88, 19)
        Me.lblRevenue.TabIndex = 10
        Me.lblRevenue.Text = "MetroLabel10"
        '
        'ManagerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 373)
        Me.Controls.Add(Me.lblRevenue)
        Me.Controls.Add(Me.lblTransaction)
        Me.Controls.Add(Me.lblStockQty)
        Me.Controls.Add(Me.lblTotalStaff)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "ManagerForm"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Resizable = False
        Me.Text = "Manager Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonthlyStaffTransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DailySalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblWelcome As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTotalStaff As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblStockQty As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTransaction As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblRevenue As MetroFramework.Controls.MetroLabel
End Class
