Public Class Sales


    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'testing purpose - delete later
        Dim DynamicButtonCount As Integer = 1

        For i = 0 To 50
            Dim name As String = ("Dynamic Button_" & DynamicButtonCount)
            Dim btnDynamicButton As Button = New Button
            btnDynamicButton.Name = name
            btnDynamicButton.Text = name
            btnDynamicButton.Size = New System.Drawing.Size(200, 30)
            btnDynamicButton.Location = New System.Drawing.Point(40, (DynamicButtonCount * 40))
            Panel1.Controls.Add(btnDynamicButton)
            DynamicButtonCount = (DynamicButtonCount + 1)
        Next
    End Sub

End Class