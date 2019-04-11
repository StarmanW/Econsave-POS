Imports System.Net.Mail
Imports System.Text
Imports Econsave_POS.CodeShare.Cryptography

Public Class ForgetPassword
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Using db As New EconsaveDataClassesDataContext()
            Dim staff = db.Staffs.Where(Function(s) s.staffID = txtId.Text).FirstOrDefault()
            If staff IsNot Nothing Then
                Try
                    Dim r As New Random
                    Dim newPass = RandomString(r)
                    staff.password = SHA.GenerateSHA256String(newPass)
                    db.SubmitChanges()
                    MessageBox.Show($"New password for {staff.name} ({staff.staffID}) is {newPass}.{vbNewLine}The password has been copied to clipboard.", "New Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Clipboard.SetText(CStr(newPass))
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MessageBox.Show("Invalid ID!", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Using
    End Sub

    Function RandomString(r As Random) As String
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim sb As New StringBuilder
        Dim cnt As Integer = 12
        For i As Integer = 1 To cnt
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
End Class