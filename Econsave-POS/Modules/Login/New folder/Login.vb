Imports System.Text.RegularExpressions
Imports Econsave_POS.CodeShare.Cryptography

Public Class Login
    Dim id As String
    Dim password As String
    Dim staffId As String
    Dim staffPassword As String

    Private Function isValidDataField() As Boolean
        Dim textRegex As New Regex("^[A-z0-9\s\-\@\#\$\%\&\*\(\)\[\]\'\:\,\.\|]+$")
        Dim validData As Boolean = True

        ErrorProvider1.Clear()

        If Not textRegex.IsMatch(txtStaffID.Text) Then
            ErrorProvider1.SetError(txtStaffID, "Please enter staff ID.")
            validData = False
        End If

        If Not textRegex.IsMatch(txtPassword.Text) Then
            ErrorProvider1.SetError(txtPassword, "Please enter passwrod.")
            validData = False
        End If

        Return validData
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If isValidDataField() Then
            staffId = txtStaffID.Text
            password = SHA.GenerateSHA256String(txtPassword.Text)

            'Retrieve Data
            Using db As New EconsaveDataClassesDataContext()
                Dim staff = db.Staffs.Where(Function(s) s.staffID = staffId AndAlso s.password = password).FirstOrDefault()
                If staff Is Nothing Then
                    MessageBox.Show("Invalid staff ID or password, please try again.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    If staff.position = "Manager" Then
                        Me.Hide()
                        ManagerForm.ShowDialog()
                        ManagerForm.Close()
                        Me.Show()
                    Else
                        MessageBox.Show($"Welcome back, Cashier {staff.name}", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    staff.lastLogin = DateTime.Now
                    db.SubmitChanges()
                End If
            End Using
        End If
    End Sub

    ' Show history
    Private Sub btnHistory_Click(sender As Object, e As EventArgs)
        Dim showHistory = New History()
        History.Show()
    End Sub
End Class