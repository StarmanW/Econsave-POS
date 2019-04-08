<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgetPassword
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtId = New MetroFramework.Controls.MetroTextBox()
        Me.btnSubmit = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(67, 79)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(24, 19)
        Me.MetroLabel1.TabIndex = 9
        Me.MetroLabel1.Text = "ID:"
        '
        'txtId
        '
        '
        '
        '
        Me.txtId.CustomButton.Image = Nothing
        Me.txtId.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.txtId.CustomButton.Name = ""
        Me.txtId.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtId.CustomButton.TabIndex = 1
        Me.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtId.CustomButton.UseSelectable = True
        Me.txtId.CustomButton.Visible = False
        Me.txtId.Lines = New String(-1) {}
        Me.txtId.Location = New System.Drawing.Point(107, 79)
        Me.txtId.MaxLength = 32767
        Me.txtId.Name = "txtId"
        Me.txtId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtId.SelectedText = ""
        Me.txtId.SelectionLength = 0
        Me.txtId.SelectionStart = 0
        Me.txtId.ShortcutsEnabled = True
        Me.txtId.Size = New System.Drawing.Size(174, 23)
        Me.txtId.TabIndex = 11
        Me.txtId.UseSelectable = True
        Me.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtId.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.ForestGreen
        Me.btnSubmit.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(107, 117)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(174, 41)
        Me.btnSubmit.TabIndex = 13
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseCustomBackColor = True
        Me.btnSubmit.UseCustomForeColor = True
        Me.btnSubmit.UseSelectable = True
        '
        'ForgetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 181)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "ForgetPassword"
        Me.Text = "Reset Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtId As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSubmit As MetroFramework.Controls.MetroButton
End Class
