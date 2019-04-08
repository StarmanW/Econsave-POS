<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeBackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForgetPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.epId = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epPassword = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epWrongPassword = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epWrongId = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.epId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epWrongPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epWrongId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Image = Global.Econsave_POS.My.Resources.Resources.Econsave_logo
        Me.Label1.Location = New System.Drawing.Point(64, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(452, 111)
        Me.Label1.TabIndex = 0
        '
        'lblId
        '
        Me.lblId.Location = New System.Drawing.Point(99, 221)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(100, 23)
        Me.lblId.TabIndex = 1
        Me.lblId.Text = "Login :"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(99, 264)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(59, 13)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password :"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(181, 221)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(305, 20)
        Me.txtId.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(181, 257)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(305, 20)
        Me.txtPassword.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistoryToolStripMenuItem, Me.OptionToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(550, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchHistoryToolStripMenuItem})
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'SearchHistoryToolStripMenuItem
        '
        Me.SearchHistoryToolStripMenuItem.Name = "SearchHistoryToolStripMenuItem"
        Me.SearchHistoryToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.SearchHistoryToolStripMenuItem.Text = "Report"
        '
        'OptionToolStripMenuItem
        '
        Me.OptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeBackgroundToolStripMenuItem, Me.ResetToolStripMenuItem})
        Me.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem"
        Me.OptionToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.OptionToolStripMenuItem.Text = "Option"
        '
        'ChangeBackgroundToolStripMenuItem
        '
        Me.ChangeBackgroundToolStripMenuItem.Name = "ChangeBackgroundToolStripMenuItem"
        Me.ChangeBackgroundToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ChangeBackgroundToolStripMenuItem.Text = "Change Background"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForgetPasswordToolStripMenuItem, Me.AboutUsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ForgetPasswordToolStripMenuItem
        '
        Me.ForgetPasswordToolStripMenuItem.Name = "ForgetPasswordToolStripMenuItem"
        Me.ForgetPasswordToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ForgetPasswordToolStripMenuItem.Text = "Forget Password"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AboutUsToolStripMenuItem.Text = "About Us"
        '
        'btnLogin
        '
        Me.btnLogin.Image = Global.Econsave_POS.My.Resources.Resources.cbvoi_qjprf_6
        Me.btnLogin.Location = New System.Drawing.Point(413, 292)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(73, 45)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'epId
        '
        Me.epId.ContainerControl = Me
        '
        'epPassword
        '
        Me.epPassword.ContainerControl = Me
        '
        'epWrongPassword
        '
        Me.epWrongPassword.ContainerControl = Me
        '
        'epWrongId
        '
        Me.epWrongId.ContainerControl = Me
        '
        'Login
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 359)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.Label1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Login"
        Me.Text = "Login"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.epId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epWrongPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epWrongId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeBackgroundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForgetPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnLogin As Button
    Friend WithEvents epId As ErrorProvider
    Friend WithEvents epPassword As ErrorProvider
    Friend WithEvents epWrongPassword As ErrorProvider
    Friend WithEvents epWrongId As ErrorProvider
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
