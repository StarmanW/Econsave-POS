Public Class authorize
    Dim id As String
    Dim password As String
    Dim staffID As String
    Dim staffPassword As String
    Dim staffPosition As String
    Dim position As Decimal
    Dim dataNum As Integer
    Dim Valid As Boolean

    Private Sub InitializeCom()

        InitializeComponent()

    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        id = txtId.Text
        password = txtPassword.Text

        Dim db As New EconsaveDataClassesDataContext()

        Dim staffList As List(Of Staff)
        staffList = db.Staffs.ToList


        Do Until dataNum = db.Staffs.Count

            staffID = staffList(dataNum).staffID
            staffPassword = staffList(dataNum).password
            staffPosition = staffList(dataNum).position


            If txtId.Text = "" Or txtPassword.Text = "" Then
                epEnterId.SetError(txtId, "User ID Is Required!")



            ElseIf txtPassword.Text = "" Then
                epEnterPass.SetError(txtPassword, "Password Is Required!")



            ElseIf String.Compare(id, staffID.ToString) = 1 Or String.Compare(password, staffPassword.ToString) = 1 Then
                epErrorId.SetError(txtId, "User ID Or User Password Invalid!")
                epErrorId.SetError(txtPassword, "User ID Or User Password Invalid!")

            ElseIf String.Compare(id, staffID) = 0 AndAlso String.Compare(password, staffPassword) = 0 AndAlso staffPosition = "Manager" Then

                Valid = True



            ElseIf String.Compare(id, staffID) = 0 AndAlso String.Compare(password, staffPassword) = 0 AndAlso staffPosition = "Cashier" Then


                MessageBox.Show("Only Manager Can Perform This Action!")
                Exit Do

            End If

            dataNum += 1

        Loop

        dataNum = 0

        If Valid = True Then
            ForgetPassword.Show()
            Me.Close()

        End If

    End Sub


End Class