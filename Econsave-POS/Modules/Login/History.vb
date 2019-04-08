Imports System.Drawing.Printing
Imports System.Text

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
        dlgPrintPreview.Document = doc
        DirectCast(dlgPrintPreview, Form).WindowState = FormWindowState.Maximized
        dlgPrintPreview.PrintPreviewControl.Zoom = 1.0
        dlgPrintPreview.ShowDialog(Me)
    End Sub

    Private Sub doc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles doc.PrintPage
        Dim db As New EconsaveDataClassesDataContext()
        Dim staff As Staff = (From i In db.Staffs Where i.staffID = Login.staffId Select i).FirstOrDefault
        Dim staffLoginList = (From i In db.Staffs Order By i.lastLogin Descending Select i).ToList

        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)
        Dim fontFooter As New Font("Calibri", 8)

        Dim header As String = "Daily Sales Report"
        Dim subHeader As String = String.Format(
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
            "Prepared by {1,0} ( {2,0} )", DateTime.Now, staff.name, staff.staffID
        )

        Dim body As New StringBuilder()

        body.AppendLine(
            "No  Staff ID  Staff Name                    Position  Registered On  Last Login" & vbNewLine &
            "--  --------  ----------------------------  --------  -------------  ----------"
        )

        Dim cnt As Integer = 0
        For Each staff In staffLoginList
            Dim staffName = staffLoginList(cnt).name
            If staffName.Count > 25 Then
                staffName = staffName.Remove(25) & "..."
            End If

            Dim lastLogin As String
            Try
                lastLogin = staffLoginList(cnt).lastLogin.Value.ToShortDateString()
            Catch ex As Exception
                lastLogin = ""
            End Try

            body.AppendFormat(
                "{0,2} {1,7}    {2,-29} {3,7} {4,11} {5,14}" & vbNewLine, cnt, staffLoginList(cnt).staffID, staffLoginList(cnt).name,
                staffLoginList(cnt).position, staffLoginList(cnt).registeredOn.ToShortDateString, lastLogin
            )

            cnt += 1
        Next

        With body
            .AppendLine()
            .AppendFormat("{0,2} record(s) total", cnt)
        End With

        Dim footer As String = "Econsave Supermarket 2001-" & Today.Year

        With e.Graphics
            .DrawImage(My.Resources.Econsave_logo, 0, 25, 100, 30)
            .DrawString(header, fontHeader, Brushes.ForestGreen, 120, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 120, 40)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
            .DrawString(footer, fontFooter, Brushes.Gray, 550, 930)
        End With
    End Sub
End Class