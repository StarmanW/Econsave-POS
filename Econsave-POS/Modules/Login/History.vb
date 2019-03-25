Public Class History

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        Using db As New EconsaveDataClassesDataContext()
            InitializeStaffData(db)
        End Using

    End Sub

    Private Sub InitializeStaffData(db As EconsaveDataClassesDataContext)
        Dim staffList As List(Of Staff)
        staffList = db.Staffs.ToList
    End Sub


    'Display All Log In Record
    Private Sub Display_Record(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New EconsaveDataClassesDataContext()
        Dim rs = From i In db.Staffs Select
                                         i.staffID,
                                         i.name,
                                         i.position,
                                         i.registeredOn,
                                         i.lastLogin


        historyDataGV.DataSource = rs
    End Sub

    'Search
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchDate As String
        Dim dataDate As String
        searchDate = txtDate.Text
        Dim db As New EconsaveDataClassesDataContext()
        Dim staffList As List(Of Staff)
        staffList = db.Staffs.ToList()

        For k = 0 To db.Staffs.Count - 1

                dataDate = (staffList(k).lastLogin.ToString).Substring(0, 9)


            If String.Compare(searchDate.ToString, dataDate) = 0 Then

                Dim Data = From i In db.Staffs Where i.lastLogin = Date.Parse(searchDate)


                historyDataGV.DataSource = data


            End If

        Next

    End Sub

End Class