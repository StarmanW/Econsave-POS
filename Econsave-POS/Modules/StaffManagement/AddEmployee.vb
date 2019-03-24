Imports System.Text.RegularExpressions

Public Class AddEmployee

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Populate Item Category combo box and generate Item ID
        Using db As New EconsaveDataClassesDataContext()
            GenerateItemID(db)
        End Using
    End Sub

    ' Sub routine to generate item ID
    Private Sub GenerateItemID(db As EconsaveDataClassesDataContext)
        lblStaffID.Text = (db.Staffs.Count + 1).ToString("D4")
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If Not isValidFields() Then
            'Database
            Using db As New EconsaveDataClassesDataContext()
                Dim regEmp As New Staff
                'Add Employee 
                regEmp.staffID = lblStaffID.Text
                regEmp.name = txtName.Text
                regEmp.password = txtconfirmpassword.Text
                regEmp.position = Convert.ToByte(radManager.Checked)
                regEmp.position = Convert.ToByte(radCashier.Checked)
                regEmp.position = Convert.ToByte(radStaff.Checked)
                regEmp.registeredOn = DateAndTime.Now
                ' Add new item and save changes
                db.Staffs.InsertOnSubmit(regEmp)
                db.SubmitChanges()
                ' Display successful message
                MessageBox.Show($"({regEmp.staffID}) has been successfully added!", "Succesfully Added", MessageBoxButtons.OKCancel)
                ' Generate new Item ID
                GenerateItemID(db)
            End Using
        End If
    End Sub

    Private Sub txtconfirmpassword_TextChanged(sender As Object, e As EventArgs) Handles txtconfirmpassword.TextChanged
        If txtconfirmpassword.Text = txtPassword.Text Then
            lblDialogbox.Text = ("Password Match")
            lblDialogbox.ForeColor = Color.Green
        Else
            lblDialogbox.Text = ("Password Does Not Match")
            lblDialogbox.ForeColor = Color.Red
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text.Length < 8 Then
            lblDialogBoxPassword.Text = ("Too short at least 9 digits or character above")
        ElseIf txtPassword.Text.Length > 8 Then
            lblDialogBoxPassword.ResetText()
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click

        If lstvData.Items.Count = 0 Then
            Dim ListOfEmp As ListViewItem
            ListOfEmp = lstvData.Items.Add(lblStaffID.Text)
            ListOfEmp.SubItems.Add(txtName.Text)

            If radManager.Text = radManager.Text Then
                ListOfEmp.SubItems.Add(radManager.Text)
            ElseIf radCashier.Text = radCashier.Text Then
                ListOfEmp.SubItems.Add(radCashier.Text)
            Else
                ListOfEmp.SubItems.Add(radStaff.Text)
            End If
            ListOfEmp.SubItems.Add(txtconfirmpassword.Text)
            ListOfEmp = Nothing
        Else
                With lstvData
                Dim addedlistOfEmp As ListViewItem
                addedlistOfEmp = .FindItemWithText(txtName.Text, True, 0, True)
                If Not addedlistOfEmp Is Nothing Then
                    MessageBox.Show($"{(txtName.Text)} already in the database")
                Else
                    Dim ListOfEmp As ListViewItem
                    ListOfEmp = lstvData.Items.Add(lblStaffID.Text)
                    ListOfEmp.SubItems.Add(txtName.Text)
                    If radManager.Text = radManager.Text Then
                        ListOfEmp.SubItems.Add(radManager.Text)
                    ElseIf radCashier.Text = radCashier.Text Then
                        ListOfEmp.SubItems.Add(radCashier.Text)
                    Else
                        ListOfEmp.SubItems.Add(radStaff.Text)
                    End If
                    ListOfEmp.SubItems.Add(txtconfirmpassword.Text)
                    ListOfEmp = Nothing
                End If
            End With
        End If


    End Sub

    ' Function to validate field inputs
    Private Function isValidFields() As Boolean
        Dim textRegex As New Regex("^[A-z0-9\s\-\@\#\$\%\&\*\(\)\[\]\'\:\,\.\|]+$")
        Dim hasError As Boolean = False

        ErrorProvider1.Clear()

        If Not textRegex.IsMatch(txtName.Text) Then
            ErrorProvider1.SetError(txtName, "Required To Fill In")
            hasError = True
        End If

        If Not textRegex.IsMatch(txtPassword.Text) Then
            ErrorProvider1.SetError(txtPassword, "Required To Set Password.")
            hasError = True
        End If

        Return hasError
    End Function

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        txtName.Text = ""
        txtPassword.Text = ""
        txtconfirmpassword.Text = ""
        lblDialogbox.Text = ""
        lblDialogBoxPassword.Text = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class