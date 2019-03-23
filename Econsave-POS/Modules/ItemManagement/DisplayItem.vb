﻿Public Class DisplayItem
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Using db As New EconsaveDataClassesDataContext()
            InitializeCategoryBox(db)
        End Using
    End Sub

    ' Sub routine to initialize category combo box
    Private Sub InitializeCategoryBox(db As EconsaveDataClassesDataContext)
        Dim category As List(Of Category)
        category = db.Categories.ToList()

        cmbCategory.Items.Add("")
        ' For loop add category
        For i = 0 To category.Count - 1
            cmbCategory.Items.Add(category(i).categoryName)
        Next
        cmbCategory.SelectedIndex = 0
    End Sub

    Private Sub DisplayItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New EconsaveDataClassesDataContext()
        Dim rs = From i In db.Items Select
                                        Item_ID = i.itemID,
                                        Item_Name = i.name,
                                        Description = i.description,
                                        Category = i.Category.categoryName,
                                        Price_per_Unit = i.price,
                                        Stock_Quantity = i.stockQuantity,
                                        Created_On = i.createdOn,
                                        Last_Update = i.lastUpdate
        itemDGV.DataSource = rs
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        Dim db As New EconsaveDataClassesDataContext()
        Dim rs As Object

        If cmbCategory.SelectedIndex = 0 Then
            rs = From i In db.Items Select
                                        Item_ID = i.itemID,
                                        Item_Name = i.name,
                                        Description = i.description,
                                        Category = i.Category.categoryName,
                                        Price_per_Unit = i.price,
                                        Stock_Quantity = i.stockQuantity,
                                        Created_On = i.createdOn,
                                        Last_Update = i.lastUpdate
        Else
            Dim itemCategory = CType(cmbCategory.SelectedItem, String)
            rs = From i In db.Items Where i.Category.categoryName = itemCategory Select
                                        Item_ID = i.itemID,
                                        Item_Name = i.name,
                                        Description = i.description,
                                        Category = i.Category.categoryName,
                                        Price_per_Unit = i.price,
                                        Stock_Quantity = i.stockQuantity,
                                        Created_On = i.createdOn,
                                        Last_Update = i.lastUpdate
        End If

        itemDGV.DataSource = rs
    End Sub
End Class