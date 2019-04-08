Imports System.Text.RegularExpressions
Imports Econsave_POS.CodeShare.Cryptography

Public Class AddStaff

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Generate ID
        Using db As New EconsaveDataClassesDataContext()
            GenerateID(db)
        End Using
    End Sub


    ' Sub routine to generate ID
    Private Sub GenerateID(db As EconsaveDataClassesDataContext)
        txtStaffID.Text = $"MN{(db.Staffs.Count + 1).ToString("D4")}"
    End Sub

    ' Generate Staff ID 
    Private Sub radCashier_CheckedChanged(sender As Object, e As EventArgs) Handles radCashier.CheckedChanged
        Using db As New EconsaveDataClassesDataContext()
            txtStaffID.Text = $"CS{(db.Staffs.Count + 1).ToString("D4")}"
        End Using
    End Sub

    Private Sub radManager_CheckedChanged(sender As Object, e As EventArgs) Handles radManager.CheckedChanged
        Using db As New EconsaveDataClassesDataContext()
            txtStaffID.Text = $"MN{(db.Staffs.Count + 1).ToString("D4")}"
        End Using
    End Sub

    ' Register btn click event handler
    Private Sub btnRegisterStaff_Click(sender As Object, e As EventArgs) Handles btnRegisterStaff.Click
        If isValidFields() Then
            'Database
            Using db As New EconsaveDataClassesDataContext()
                Dim regEmp As New Staff
                'Add Employee 
                regEmp.staffID = txtStaffID.Text
                regEmp.name = txtName.Text
                regEmp.password = SHA.GenerateSHA256String(txtConfirmPassword.Text)
                If radManager.Checked Then
                    regEmp.position = "Manager"
                Else
                    regEmp.position = "Cashier"
                End If
                regEmp.registeredOn = DateTime.Now
                ' Add new emp and save changes
                db.Staffs.InsertOnSubmit(regEmp)
                db.SubmitChanges()
                ' Display successful message
                MessageBox.Show($"({regEmp.staffID}) has been successfully added!", "Succesfully Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Generate new Item ID
                GenerateID(db)
            End Using
        End If
        Me.DialogResult = DialogResult.None
    End Sub

    ' Clear btn click event handler
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtPassword.Text = ""
        txtConfirmPassword.Text = ""
        lblDialogbox.Text = ""
        lblDialogBoxPassword.Text = ""
        radManager.Checked = True
        Me.DialogResult = DialogResult.None
    End Sub

    ' Function to validate field inputs
    Private Function isValidFields() As Boolean
        Dim textRegex As New Regex("^[A-z0-9\s\-\@\#\$\%\&\*\(\)\[\]\'\:\,\.\|]+$")
        Dim validData As Boolean = True

        ErrorProvider1.Clear()

        If Not textRegex.IsMatch(txtName.Text) Then
            ErrorProvider1.SetError(txtName, "Required To Fill In")
            validData = False
        End If

        If Not textRegex.IsMatch(txtPassword.Text) Then
            ErrorProvider1.SetError(txtPassword, "Required To Set Password.")
            validData = False
        End If

        If Not textRegex.IsMatch(txtConfirmPassword.Text) Then
            ErrorProvider1.SetError(txtConfirmPassword, "Confirm password must not be empty.")
            validData = False
        End If
        Return validData
    End Function

    ' Check Password length
    Private Sub txtPassword_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyUp
        If txtPassword.Text.Length < 8 Then
            lblDialogBoxPassword.Text = "Password must be at least 9 digits/characters."
        ElseIf txtPassword.Text.Length > 8 Then
            lblDialogBoxPassword.ResetText()
        End If
    End Sub

    Private Sub txtConfirmPassword_KeyUp(sender As Object, e As KeyEventArgs) Handles txtConfirmPassword.KeyUp
        If txtConfirmPassword.Text = txtPassword.Text Then
            lblDialogbox.Text = ("Password Match")
            lblDialogbox.ForeColor = Color.Green
        Else
            lblDialogbox.Text = ("Password Does Not Match")
            lblDialogbox.ForeColor = Color.Red
        End If
    End Sub
End Class