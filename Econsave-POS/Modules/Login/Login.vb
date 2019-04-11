Imports System.Text.RegularExpressions
Imports Econsave_POS.CodeShare.Cryptography

Public Class Login
    Dim id As String
    Dim password As String
    Friend staffId As String
    Dim staffPassword As String

    Private Function isValidDataField() As Boolean
        Dim textRegex As New Regex("^[A-z0-9\s\-\@\#\$\%\&\*\(\)\[\]\'\:\,\.\|]+$")
        Dim validData As Boolean = True

        ErrorProvider1.Clear()

        If Not textRegex.IsMatch(txtStaffID.Text) Then
            ErrorProvider1.SetError(txtStaffID, "Please Enter Staff ID.")
            validData = False
        End If

        If Not textRegex.IsMatch(txtPassword.Text) Then
            ErrorProvider1.SetError(txtPassword, "Please Enter Passwrod.")
            validData = False
        End If

        Return validData
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If isValidDataField() Then
            staffId = txtStaffID.Text.ToLower
            password = SHA.GenerateSHA256String(txtPassword.Text).ToLower()

            'Retrieve Data
            Using db As New EconsaveDataClassesDataContext()
                Dim staff = db.Staffs.Where(Function(s) s.staffID.ToLower() = staffId AndAlso s.password.ToLower() = password).FirstOrDefault()
                If staff Is Nothing Then
                    MessageBox.Show("Invalid staff ID or password, please try again.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    txtPassword.ResetText()
                    txtStaffID.ResetText()
                    txtStaffID.Select()

                    staff.lastLogin = DateTime.Now
                    db.SubmitChanges()
                    Me.Hide()
                    If staff.position = "Manager" Then
                        ManagerForm.ShowDialog()
                        ManagerForm.Close()
                    ElseIf staff.position = "Cashier" Then
                        Sales.ShowDialog()
                        Sales.Close()
                    End If
                    staffId = String.Empty
                    Me.Show()
                    Me.Select()
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