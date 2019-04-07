Imports System.Text.RegularExpressions
Imports Econsave_POS.CodeShare.Cryptography

Public Class UpdateStaff

    Private Sub UpdateStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using db As New EconsaveDataClassesDataContext()
            DisplayStaffData(db)
        End Using
    End Sub

    ' Sub routine to initialize item data into text fields
    Private Sub DisplayStaffData(db As EconsaveDataClassesDataContext)
        Dim staff = (From s In db.Staffs
                     Where s.staffID = DisplayStaff.staffID
                     Select s).FirstOrDefault()

        txtStaffID.Text = staff.staffID
        txtStaffName.Text = staff.name
        If staff.position = 1 Then
            radManager.Checked = True
        Else
            radCashier.Checked = True
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnUpdateItem_Click(sender As Object, e As EventArgs) Handles btnUpdateItem.Click
        If isValidFields() Then
            Using db As New EconsaveDataClassesDataContext()
                Dim staff = (From s In db.Staffs
                             Where s.staffID = DisplayStaff.staffID
                             Select s).FirstOrDefault()

                staff.name = txtStaffName.Text

                ' Only update password if password field is entered
                If Not txtPassword.Text.Equals("") Then
                    staff.password = SHA.GenerateSHA256String(txtPassword.Text)
                End If

                ' Update position according to checked radio button 
                If radManager.Checked Then
                    staff.position = 1
                Else
                    staff.position = 2
                End If

                ' Update item and save changes
                db.SubmitChanges()

                ' Display successful message
                MessageBox.Show($"Staff ({staff.name}) has been successfully updated!", "Staff Details Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End If
        Me.DialogResult = DialogResult.None
    End Sub

    ' Function to validate field inputs
    Private Function isValidFields() As Boolean
        Dim textRegex As New Regex("^[A-z0-9\s\-\@\#\$\%\&\*\(\)\[\]\'\:\,\.\|]+$")
        Dim validData As Boolean = True

        ErrorProvider1.Clear()

        If Not textRegex.IsMatch(txtStaffName.Text) Then
            ErrorProvider1.SetError(txtStaffName, "Staff name required.")
            validData = False
        End If

        Return validData
    End Function
End Class