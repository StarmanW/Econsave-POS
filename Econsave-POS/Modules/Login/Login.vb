Public Class Login
    Dim id As String
    Dim password As String
    Dim staffId As String
    Dim staffPassword As String


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
        If txtId.Text = "" Then
            epId.SetError(txtId, "User ID Is Required For Login!")
        End If

        If txtPassword.Text = "" Then
            epPassword.SetError(txtPassword, "Password Is Required For Login!")
        End If

        For i = 0 To db.Staffs.Count - 1

            staffId = staffList(i).staffID
            staffPassword = staffList(i).password


            If String.Compare(staffId, id) = 1 Or String.Compare(staffPassword, password) = 1 Then

                epWrongId.SetError(txtId, "Invalid Id!")
                epWrongPassword.SetError(txtPassword, "Invalid Password!")

            End If

            If String.Compare(staffId, id) = 0 AndAlso String.Compare(staffPassword, password) = 0 Then
                Dim identity As String
                identity = id.Substring(0, 2)
                If String.Compare(identity, "CS") = 0 Then
                    MessageBox.Show("I Am Cashier")
                    Stop
                End If

                If String.Compare(identity, "MN") = 0 Then
                    MessageBox.Show("I Am Manager")
                    Stop
                End If

            End If

        Next

    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim showHistory = New History()
        History.Show()

    End Sub

End Class