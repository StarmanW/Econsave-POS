Public Class Login
    Dim id As String
    Dim password As String
    Friend staffId As String
    Dim staffPassword As String
    Dim staffPosition As String
    Dim position As String
    Dim dataNum As Integer
    Dim Authorize As Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        id = txtId.Text
        password = txtPassword.Text

        'Retrieve Data
        Dim db As New EconsaveDataClassesDataContext()  'connect database
        'db.Staffs.Where(Function(s) s.staffID = "CS0001").FirstOrDefault() 'retrieve only one value

        Dim staffList As List(Of Staff)  ' = db.Staffs.ToList()  'create a list based on staff
        staffList = db.Staffs.ToList

        'For i = 0 To db.Staffs.Count        'staffList(i).staffID = i is refer to which row and staffID is what i looking for
        '    staffList(i).staffID
        'Next

        'Validation

        Do Until dataNum = db.Staffs.Count

            staffId = staffList(dataNum).staffID
            staffPassword = staffList(dataNum).password
            staffPosition = staffList(dataNum).position


            If txtId.Text = "" Or txtPassword.Text = "" Then
                epId.SetError(txtId, "User ID Is Required For Login!")
                epPassword.SetError(txtPassword, "Password Is Required For Login!")

            ElseIf staffId.Equals(id) = False Or staffPassword.Equals(password) = False Then
                epWrongId.SetError(txtId, "Invalid Id!")
                epWrongPassword.SetError(txtPassword, "Invalid Password!")

            ElseIf staffId.Equals(id) = True And staffPassword.Equals(password) = True And staffPosition = "Manager" Then
                'MessageBox.Show("I Am Manager")

            ElseIf staffId.Equals(id) = True And staffPassword.Equals(password) = True And staffPosition = "Cashier" Then
                'MessageBox.Show("I Am Cashier")

            End If

            dataNum += 1

        Loop

        dataNum = 0

    End Sub

    Private Sub ForgetPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForgetPasswordToolStripMenuItem.Click
        Authorize = New Authorize()
        Authorize.Show()
    End Sub

    Private Sub ChangeBackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeBackgroundToolStripMenuItem.Click

        Dim color1 = New ColorDialog
        With color1
            .Color = txtId.ForeColor
            .Color = BackColor
            .ShowDialog() 'confirm 
            txtId.ForeColor = .Color
            BackColor = .Color
        End With

    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click

        txtId.Text = ""
        txtPassword.Text = ""
        txtId.ForeColor = Color.Empty
        BackColor = Color.White

    End Sub

    Private Sub SearchHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchHistoryToolStripMenuItem.Click
        Dim showHistory = New History()
        History.Show()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        Dim AboutUs = New AboutUs()
        AboutUs.Show()

    End Sub


End Class