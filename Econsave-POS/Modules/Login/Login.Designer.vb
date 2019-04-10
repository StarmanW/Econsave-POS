<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.txtStaffID = New MetroFramework.Controls.MetroTextBox()
        Me.lblStaffID = New MetroFramework.Controls.MetroLabel()
        Me.lblStaffPassword = New MetroFramework.Controls.MetroLabel()
        Me.txtPassword = New MetroFramework.Controls.MetroTextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtStaffID
        '
        '
        '
        '
        Me.txtStaffID.CustomButton.Image = Nothing
        Me.txtStaffID.CustomButton.Location = New System.Drawing.Point(357, 2)
        Me.txtStaffID.CustomButton.Name = ""
        Me.txtStaffID.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtStaffID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStaffID.CustomButton.TabIndex = 1
        Me.txtStaffID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStaffID.CustomButton.UseSelectable = True
        Me.txtStaffID.CustomButton.Visible = False
        Me.txtStaffID.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtStaffID.Lines = New String(-1) {}
        Me.txtStaffID.Location = New System.Drawing.Point(147, 193)
        Me.txtStaffID.MaxLength = 32767
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStaffID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStaffID.SelectedText = ""
        Me.txtStaffID.SelectionLength = 0
        Me.txtStaffID.SelectionStart = 0
        Me.txtStaffID.ShortcutsEnabled = True
        Me.txtStaffID.Size = New System.Drawing.Size(385, 30)
        Me.txtStaffID.TabIndex = 7
        Me.txtStaffID.UseSelectable = True
        Me.txtStaffID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStaffID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblStaffID.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblStaffID.Location = New System.Drawing.Point(49, 193)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(75, 25)
        Me.lblStaffID.TabIndex = 8
        Me.lblStaffID.Text = "Staff ID:"
        '
        'lblStaffPassword
        '
        Me.lblStaffPassword.AutoSize = True
        Me.lblStaffPassword.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblStaffPassword.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblStaffPassword.Location = New System.Drawing.Point(34, 243)
        Me.lblStaffPassword.Name = "lblStaffPassword"
        Me.lblStaffPassword.Size = New System.Drawing.Size(91, 25)
        Me.lblStaffPassword.TabIndex = 9
        Me.lblStaffPassword.Text = "Password:"
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.CustomButton.Image = Nothing
        Me.txtPassword.CustomButton.Location = New System.Drawing.Point(357, 2)
        Me.txtPassword.CustomButton.Name = ""
        Me.txtPassword.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPassword.CustomButton.TabIndex = 1
        Me.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPassword.CustomButton.UseSelectable = True
        Me.txtPassword.CustomButton.Visible = False
        Me.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPassword.Lines = New String(-1) {}
        Me.txtPassword.Location = New System.Drawing.Point(147, 238)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.ShortcutsEnabled = True
        Me.txtPassword.Size = New System.Drawing.Size(385, 30)
        Me.txtPassword.TabIndex = 10
        Me.txtPassword.UseSelectable = True
        Me.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.ForestGreen
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Image = Global.Econsave_POS.My.Resources.Resources.cbvoi_qjprf_6
        Me.btnLogin.Location = New System.Drawing.Point(147, 287)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(385, 45)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Econsave_POS.My.Resources.Resources.Econsave_logo
        Me.PictureBox1.Location = New System.Drawing.Point(49, 65)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(483, 102)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 376)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblStaffPassword)
        Me.Controls.Add(Me.lblStaffID)
        Me.Controls.Add(Me.txtStaffID)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Resizable = False
        Me.Text = "Login"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblStaffPassword As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblStaffID As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtStaffID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
