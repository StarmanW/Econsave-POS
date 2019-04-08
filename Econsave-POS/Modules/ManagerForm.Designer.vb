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
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailySalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlyStaffTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.StaffManagementToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(881, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(41, 23)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.LogoutToolStripMenuItem.Text = "Logout"
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
        'ManagerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 561)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "ManagerForm"
        Me.Resizable = False
        Me.Text = "Manager Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonthlyStaffTransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DailySalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetPasswordToolStripMenuItem As ToolStripMenuItem
End Class
