Public Class DisplayStaff

    Friend staffID As String

    Private Sub DisplayItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New EconsaveDataClassesDataContext()

        Dim rs = From s In db.Staffs
                 Select Staff_ID = s.staffID,
                     Name = s.name,
                     Position = s.position,
                     Registered_On = s.registeredOn,
                     Last_Login = s.lastLogin

        itemDGV.DataSource = rs
    End Sub

    ' Display staff details 
    Private Sub itemDGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles itemDGV.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = itemDGV.Rows(e.RowIndex)
            staffID = CType(itemDGV.Item(0, selectedRow.Index).Value, String)
            UpdateStaff.ShowDialog()
            UpdateStaff.Close()
            DisplayItem_Load(sender, e)
        End If
    End Sub

    ' Search function
    Private Sub txtSearchBox_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearchBox.KeyUp
        Dim searchStr = txtSearchBox.Text
        Dim db As New EconsaveDataClassesDataContext()
        Dim rs As Object

        ' Only do this query if search box is not empty
        If Not searchStr.Equals("") Then
            rs = From s In db.Staffs
                 Where s.name.Contains(searchStr)
                 Select Staff_ID = s.staffID,
                     Name = s.name,
                     Position = s.position,
                     Registered_On = s.registeredOn,
                     Last_Login = s.lastLogin
        Else
            rs = From s In db.Staffs
                 Select Staff_ID = s.staffID,
                     Name = s.name,
                     Position = s.position,
                     Registered_On = s.registeredOn,
                     Last_Login = s.lastLogin
        End If
        itemDGV.DataSource = rs
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Close()
    End Sub
End Class