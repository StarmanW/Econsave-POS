﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MonthlyStaffTransaction
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
        Me.dgvStaffMonthlyTrans = New System.Windows.Forms.DataGridView()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.cboMonth = New MetroFramework.Controls.MetroComboBox()
        CType(Me.dgvStaffMonthlyTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvStaffMonthlyTrans
        '
        Me.dgvStaffMonthlyTrans.AllowUserToResizeColumns = False
        Me.dgvStaffMonthlyTrans.AllowUserToResizeRows = False
        Me.dgvStaffMonthlyTrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStaffMonthlyTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaffMonthlyTrans.Location = New System.Drawing.Point(34, 102)
        Me.dgvStaffMonthlyTrans.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvStaffMonthlyTrans.Name = "dgvStaffMonthlyTrans"
        Me.dgvStaffMonthlyTrans.Size = New System.Drawing.Size(839, 509)
        Me.dgvStaffMonthlyTrans.TabIndex = 1
        '
        'MetroButton2
        '
        Me.MetroButton2.BackColor = System.Drawing.SystemColors.Highlight
        Me.MetroButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.MetroButton2.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton2.ForeColor = System.Drawing.Color.White
        Me.MetroButton2.Location = New System.Drawing.Point(462, 620)
        Me.MetroButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(411, 45)
        Me.MetroButton2.TabIndex = 7
        Me.MetroButton2.Text = "&Print"
        Me.MetroButton2.UseCustomBackColor = True
        Me.MetroButton2.UseCustomForeColor = True
        Me.MetroButton2.UseSelectable = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.ForestGreen
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(34, 620)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(411, 45)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseCustomBackColor = True
        Me.btnClose.UseCustomForeColor = True
        Me.btnClose.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(33, 63)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(66, 25)
        Me.MetroLabel1.TabIndex = 8
        Me.MetroLabel1.Text = "Month:"
        '
        'cboMonth
        '
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.ItemHeight = 23
        Me.cboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonth.Location = New System.Drawing.Point(105, 63)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(249, 29)
        Me.cboMonth.TabIndex = 9
        Me.cboMonth.UseSelectable = True
        '
        'MonthlyStaffTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(910, 687)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvStaffMonthlyTrans)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MonthlyStaffTransaction"
        Me.Padding = New System.Windows.Forms.Padding(30, 83, 30, 28)
        Me.Text = "Monthly Staffs Transaction"
        CType(Me.dgvStaffMonthlyTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvStaffMonthlyTrans As DataGridView
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboMonth As MetroFramework.Controls.MetroComboBox
End Class