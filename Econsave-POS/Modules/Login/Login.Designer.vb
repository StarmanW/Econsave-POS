<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

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
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.epId = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epPassword = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epWrongId = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epWrongPassword = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epWrongId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epWrongPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblId.Location = New System.Drawing.Point(177, 249)
        Me.lblId.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(37, 25)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "ID:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(177, 302)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(104, 25)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password:"
        '
        'txtId
        '
        Me.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtId.Location = New System.Drawing.Point(295, 249)
        Me.txtId.Margin = New System.Windows.Forms.Padding(5)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(385, 30)
        Me.txtId.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(295, 299)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(385, 30)
        Me.txtPassword.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Econsave_POS.My.Resources.Resources.Econsave_logo
        Me.PictureBox1.Location = New System.Drawing.Point(197, 112)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(483, 102)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.Image = Global.Econsave_POS.My.Resources.Resources.cbvoi_qjprf_6
        Me.btnLogin.Location = New System.Drawing.Point(295, 351)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(175, 41)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnHistory
        '
        Me.btnHistory.Image = Global.Econsave_POS.My.Resources.Resources.cb4e4_ot9m3_6
        Me.btnHistory.Location = New System.Drawing.Point(505, 351)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(175, 41)
        Me.btnHistory.TabIndex = 6
        Me.btnHistory.Text = "&History"
        Me.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'epId
        '
        Me.epId.ContainerControl = Me
        '
        'epPassword
        '
        Me.epPassword.ContainerControl = Me
        '
        'epWrongId
        '
        Me.epWrongId.ContainerControl = Me
        '
        'epWrongPassword
        '
        Me.epWrongPassword.ContainerControl = Me
        '
        'Login
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 492)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblId)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epWrongId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epWrongPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblId As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents epId As ErrorProvider
    Friend WithEvents epPassword As ErrorProvider
    Friend WithEvents epWrongId As ErrorProvider
    Friend WithEvents epWrongPassword As ErrorProvider
End Class
