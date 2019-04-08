Imports System.Drawing.Printing

Public Class History

    Dim dataNum As Integer

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
                                         ID = i.staffID,
                                         Name = i.name,
                                         Position = i.position,
                                         Registered_On = i.registeredOn,
                                         Last_Login = i.lastLogin

        historyDataGV.DataSource = rs
    End Sub

    'Search
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim search As String
        Dim dataDateLastLogin As String
        Dim dataDateRegister As String
        Dim dataName As String
        Dim dataPosition As String
        Dim dataStaffID As String
        search = txtSearch.Text
        Dim db As New EconsaveDataClassesDataContext()
        Dim staffList As List(Of Staff)
        staffList = db.Staffs.ToList()

        Do Until dataNum = db.Staffs.Count

            If search.ToString.Count = 9 Then
                dataDateLastLogin = (staffList(dataNum).lastLogin.ToString).Substring(0, 9)
                dataDateRegister = (staffList(dataNum).registeredOn.ToString).Substring(0, 9)
            Else

                dataDateLastLogin = (staffList(dataNum).lastLogin.ToString).Substring(0, 10)
                dataDateRegister = (staffList(dataNum).registeredOn.ToString).Substring(0, 10)
            End If

            dataName = (staffList(dataNum).name.ToString)
            dataPosition = (staffList(dataNum).position.ToString)
            dataStaffID = (staffList(dataNum).staffID)

            If String.Compare(search.ToString, dataDateLastLogin) = 0 Then

                Dim Data = From i In db.Staffs Where i.lastLogin = Date.Parse(search)
                           Select
                                         ID = i.staffID,
                                         Name = i.name,
                                         Position = i.position,
                                         Registered_On = i.registeredOn,
                                         Last_Login = i.lastLogin


                historyDataGV.DataSource = Data

            End If

            If String.Compare(search.ToString, dataDateRegister) = 0 Then

                Dim Data = From i In db.Staffs Where i.registeredOn = Date.Parse(search)
                           Select
                                         ID = i.staffID,
                                         Name = i.name,
                                         Position = i.position,
                                         Registered_On = i.registeredOn,
                                         Last_Login = i.lastLogin

                historyDataGV.DataSource = Data

            End If

            If String.Compare(search.ToString, dataName) = 0 Then

                Dim Data = From i In db.Staffs Where i.name = search
                           Select
                                         ID = i.staffID,
                                         Name = i.name,
                                         Position = i.position,
                                         Registered_On = i.registeredOn,
                                         Last_Login = i.lastLogin

                historyDataGV.DataSource = Data

            End If

            If String.Compare(search.ToString, dataStaffID) = 0 Then

                Dim Data = From i In db.Staffs Where i.staffID = search
                           Select
                                         ID = i.staffID,
                                         Name = i.name,
                                         Position = i.position,
                                         Registered_On = i.registeredOn,
                                         Last_Login = i.lastLogin

                historyDataGV.DataSource = Data

            End If

            If String.Compare(search.ToString, dataPosition) = 0 Then
                Dim Data = From i In db.Staffs Where i.position = search
                           Select
                                         ID = i.staffID,
                                         Name = i.name,
                                         Position = i.position,
                                         Registered_On = i.registeredOn,
                                         Last_Login = i.lastLogin

                historyDataGV.DataSource = Data

            End If

            dataNum += 1
        Loop

        dataNum = 0
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Display_Record(sender, e)
        txtSearch.ResetText()


    End Sub

    Private bitmap As Bitmap

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim height As Integer = historyDataGV.Height
        historyDataGV.Height = historyDataGV.RowCount * historyDataGV.RowTemplate.Height
        bitmap = New Bitmap(Me.historyDataGV.Width, Me.historyDataGV.Height)
        historyDataGV.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.historyDataGV.Width, Me.historyDataGV.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 2
        PrintPreviewDialog1.ShowDialog()
        historyDataGV.Height = height


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub
End Class