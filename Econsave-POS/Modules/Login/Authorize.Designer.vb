<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class authorize
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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.epEnterId = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epEnterPass = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epErrorId = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ItemSalesTableAdapter1 = New Econsave_POS.EconsaveDBDataSetTableAdapters.ItemSalesTableAdapter()
        CType(Me.epEnterId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epEnterPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epErrorId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(236, 162)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 9
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(128, 128)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(183, 20)
        Me.txtPassword.TabIndex = 8
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(128, 77)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(183, 20)
        Me.txtId.TabIndex = 7
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(60, 131)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(59, 13)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Password :"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(95, 77)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(24, 13)
        Me.lblId.TabIndex = 5
        Me.lblId.Text = "ID :"
        '
        'epEnterId
        '
        Me.epEnterId.ContainerControl = Me
        '
        'epEnterPass
        '
        Me.epEnterPass.ContainerControl = Me
        '
        'epErrorId
        '
        Me.epErrorId.ContainerControl = Me
        '
        'ItemSalesTableAdapter1
        '
        Me.ItemSalesTableAdapter1.ClearBeforeFill = True
        '
        'authorize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 267)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblId)
        Me.Name = "authorize"
        Me.Text = "Authorize"
        CType(Me.epEnterId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epEnterPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epErrorId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblId As Label
    Friend WithEvents epEnterId As ErrorProvider
    Friend WithEvents epEnterPass As ErrorProvider
    Friend WithEvents epErrorId As ErrorProvider
    Friend WithEvents ItemSalesTableAdapter1 As EconsaveDBDataSetTableAdapters.ItemSalesTableAdapter
End Class
