Imports System.Net.Mail

Public Class ForgetPassword
    Dim staffID As String
    Dim staffPassword As String

    Public Sub New()

        InitializeComponent()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim db As New EconsaveDataClassesDataContext()

        staffID = txtId.Text

        Dim staff = db.Staffs.Where(Function(s) s.staffID = txtId.Text).FirstOrDefault()
        staffPassword = staff.password
        staffID = staff.staffID

        Dim message As New MailMessage(txtEmail.Text, "liewjw-wa16@student.tarc.edu.my", "Password Recovery", staffPassword)

        Dim emailClient As New SmtpClient(Me.txtEmail.Text)

        Dim myC As New System.Net.NetworkCredential("liewjw-wa16@student.tarc.edu.my", "970804565275a")

        emailClient.Credentials = myC
        emailClient.Send(message)

        MsgBox("Email Sent!")

    End Sub
End Class