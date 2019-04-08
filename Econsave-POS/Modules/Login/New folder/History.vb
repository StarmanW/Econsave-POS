Public Class History

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Using db As New EconsaveDataClassesDataContext()
            loginHistoryDGV.DataSource = From s In db.Staffs Select
                                                                 Staff_ID = s.staffID,
                                                                 Staff_Name = s.name,
                                                                 Position = s.position,
                                                                 Registed_On = s.registeredOn,
                                                                 Last_Login = s.lastLogin
        End Using
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Close()
    End Sub
End Class