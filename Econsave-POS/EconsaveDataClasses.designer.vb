﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="EconsaveDB")>  _
Partial Public Class EconsaveDataClassesDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertCategory(instance As Category)
    End Sub
  Partial Private Sub UpdateCategory(instance As Category)
    End Sub
  Partial Private Sub DeleteCategory(instance As Category)
    End Sub
  Partial Private Sub InsertTransaction(instance As Transaction)
    End Sub
  Partial Private Sub UpdateTransaction(instance As Transaction)
    End Sub
  Partial Private Sub DeleteTransaction(instance As Transaction)
    End Sub
  Partial Private Sub InsertItem(instance As Item)
    End Sub
  Partial Private Sub UpdateItem(instance As Item)
    End Sub
  Partial Private Sub DeleteItem(instance As Item)
    End Sub
  Partial Private Sub InsertItemSale(instance As ItemSale)
    End Sub
  Partial Private Sub UpdateItemSale(instance As ItemSale)
    End Sub
  Partial Private Sub DeleteItemSale(instance As ItemSale)
    End Sub
  Partial Private Sub InsertStaff(instance As Staff)
    End Sub
  Partial Private Sub UpdateStaff(instance As Staff)
    End Sub
  Partial Private Sub DeleteStaff(instance As Staff)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.Econsave_POS.My.MySettings.Default.EconsaveDBConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Categories() As System.Data.Linq.Table(Of Category)
		Get
			Return Me.GetTable(Of Category)
		End Get
	End Property
	
	Public ReadOnly Property Transactions() As System.Data.Linq.Table(Of Transaction)
		Get
			Return Me.GetTable(Of Transaction)
		End Get
	End Property
	
	Public ReadOnly Property Items() As System.Data.Linq.Table(Of Item)
		Get
			Return Me.GetTable(Of Item)
		End Get
	End Property
	
	Public ReadOnly Property ItemSales() As System.Data.Linq.Table(Of ItemSale)
		Get
			Return Me.GetTable(Of ItemSale)
		End Get
	End Property
	
	Public ReadOnly Property Staffs() As System.Data.Linq.Table(Of Staff)
		Get
			Return Me.GetTable(Of Staff)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Category")>  _
Partial Public Class Category
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _categoryID As Integer
	
	Private _categoryName As String
	
	Private _Items As EntitySet(Of Item)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OncategoryIDChanging(value As Integer)
    End Sub
    Partial Private Sub OncategoryIDChanged()
    End Sub
    Partial Private Sub OncategoryNameChanging(value As String)
    End Sub
    Partial Private Sub OncategoryNameChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Items = New EntitySet(Of Item)(AddressOf Me.attach_Items, AddressOf Me.detach_Items)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_categoryID", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property categoryID() As Integer
		Get
			Return Me._categoryID
		End Get
		Set
			If ((Me._categoryID = value)  _
						= false) Then
				Me.OncategoryIDChanging(value)
				Me.SendPropertyChanging
				Me._categoryID = value
				Me.SendPropertyChanged("categoryID")
				Me.OncategoryIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_categoryName", DbType:="VarChar(100) NOT NULL", CanBeNull:=false)>  _
	Public Property categoryName() As String
		Get
			Return Me._categoryName
		End Get
		Set
			If (String.Equals(Me._categoryName, value) = false) Then
				Me.OncategoryNameChanging(value)
				Me.SendPropertyChanging
				Me._categoryName = value
				Me.SendPropertyChanged("categoryName")
				Me.OncategoryNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Category_Item", Storage:="_Items", ThisKey:="categoryID", OtherKey:="categoryID")>  _
	Public Property Items() As EntitySet(Of Item)
		Get
			Return Me._Items
		End Get
		Set
			Me._Items.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_Items(ByVal entity As Item)
		Me.SendPropertyChanging
		entity.Category = Me
	End Sub
	
	Private Sub detach_Items(ByVal entity As Item)
		Me.SendPropertyChanging
		entity.Category = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.[Transaction]")>  _
Partial Public Class Transaction
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _transactionID As String
	
	Private _staffID As String
	
	Private _totalPrice As Double
	
	Private _createdOn As Date
	
	Private _ItemSale As EntityRef(Of ItemSale)
	
	Private _Staff As EntityRef(Of Staff)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OntransactionIDChanging(value As String)
    End Sub
    Partial Private Sub OntransactionIDChanged()
    End Sub
    Partial Private Sub OnstaffIDChanging(value As String)
    End Sub
    Partial Private Sub OnstaffIDChanged()
    End Sub
    Partial Private Sub OntotalPriceChanging(value As Double)
    End Sub
    Partial Private Sub OntotalPriceChanged()
    End Sub
    Partial Private Sub OncreatedOnChanging(value As Date)
    End Sub
    Partial Private Sub OncreatedOnChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._ItemSale = CType(Nothing, EntityRef(Of ItemSale))
		Me._Staff = CType(Nothing, EntityRef(Of Staff))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_transactionID", DbType:="VarChar(10) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property transactionID() As String
		Get
			Return Me._transactionID
		End Get
		Set
			If (String.Equals(Me._transactionID, value) = false) Then
				Me.OntransactionIDChanging(value)
				Me.SendPropertyChanging
				Me._transactionID = value
				Me.SendPropertyChanged("transactionID")
				Me.OntransactionIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_staffID", DbType:="VarChar(10) NOT NULL", CanBeNull:=false)>  _
	Public Property staffID() As String
		Get
			Return Me._staffID
		End Get
		Set
			If (String.Equals(Me._staffID, value) = false) Then
				If Me._Staff.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnstaffIDChanging(value)
				Me.SendPropertyChanging
				Me._staffID = value
				Me.SendPropertyChanged("staffID")
				Me.OnstaffIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_totalPrice", DbType:="Float NOT NULL")>  _
	Public Property totalPrice() As Double
		Get
			Return Me._totalPrice
		End Get
		Set
			If ((Me._totalPrice = value)  _
						= false) Then
				Me.OntotalPriceChanging(value)
				Me.SendPropertyChanging
				Me._totalPrice = value
				Me.SendPropertyChanged("totalPrice")
				Me.OntotalPriceChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_createdOn", DbType:="Date NOT NULL")>  _
	Public Property createdOn() As Date
		Get
			Return Me._createdOn
		End Get
		Set
			If ((Me._createdOn = value)  _
						= false) Then
				Me.OncreatedOnChanging(value)
				Me.SendPropertyChanging
				Me._createdOn = value
				Me.SendPropertyChanged("createdOn")
				Me.OncreatedOnChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Transaction_ItemSale", Storage:="_ItemSale", ThisKey:="transactionID", OtherKey:="transactionID", IsUnique:=true, IsForeignKey:=false)>  _
	Public Property ItemSale() As ItemSale
		Get
			Return Me._ItemSale.Entity
		End Get
		Set
			Dim previousValue As ItemSale = Me._ItemSale.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._ItemSale.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._ItemSale.Entity = Nothing
					previousValue.Transaction = Nothing
				End If
				Me._ItemSale.Entity = value
				If (Object.Equals(value, Nothing) = false) Then
					value.Transaction = Me
				End If
				Me.SendPropertyChanged("ItemSale")
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Staff_Transaction", Storage:="_Staff", ThisKey:="staffID", OtherKey:="staffID", IsForeignKey:=true)>  _
	Public Property Staff() As Staff
		Get
			Return Me._Staff.Entity
		End Get
		Set
			Dim previousValue As Staff = Me._Staff.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Staff.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Staff.Entity = Nothing
					previousValue.Transactions.Remove(Me)
				End If
				Me._Staff.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Transactions.Add(Me)
					Me._staffID = value.staffID
				Else
					Me._staffID = CType(Nothing, String)
				End If
				Me.SendPropertyChanged("Staff")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Item")>  _
Partial Public Class Item
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _itemID As String
	
	Private _name As String
	
	Private _description As String
	
	Private _price As Double
	
	Private _stockQuantity As Integer
	
	Private _createdOn As Date
	
	Private _lastUpdate As System.Nullable(Of Date)
	
	Private _categoryID As Integer
	
	Private _status As String
	
	Private _ItemSales As EntitySet(Of ItemSale)
	
	Private _Category As EntityRef(Of Category)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnitemIDChanging(value As String)
    End Sub
    Partial Private Sub OnitemIDChanged()
    End Sub
    Partial Private Sub OnnameChanging(value As String)
    End Sub
    Partial Private Sub OnnameChanged()
    End Sub
    Partial Private Sub OndescriptionChanging(value As String)
    End Sub
    Partial Private Sub OndescriptionChanged()
    End Sub
    Partial Private Sub OnpriceChanging(value As Double)
    End Sub
    Partial Private Sub OnpriceChanged()
    End Sub
    Partial Private Sub OnstockQuantityChanging(value As Integer)
    End Sub
    Partial Private Sub OnstockQuantityChanged()
    End Sub
    Partial Private Sub OncreatedOnChanging(value As Date)
    End Sub
    Partial Private Sub OncreatedOnChanged()
    End Sub
    Partial Private Sub OnlastUpdateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnlastUpdateChanged()
    End Sub
    Partial Private Sub OncategoryIDChanging(value As Integer)
    End Sub
    Partial Private Sub OncategoryIDChanged()
    End Sub
    Partial Private Sub OnstatusChanging(value As String)
    End Sub
    Partial Private Sub OnstatusChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._ItemSales = New EntitySet(Of ItemSale)(AddressOf Me.attach_ItemSales, AddressOf Me.detach_ItemSales)
		Me._Category = CType(Nothing, EntityRef(Of Category))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_itemID", DbType:="VarChar(10) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property itemID() As String
		Get
			Return Me._itemID
		End Get
		Set
			If (String.Equals(Me._itemID, value) = false) Then
				Me.OnitemIDChanging(value)
				Me.SendPropertyChanging
				Me._itemID = value
				Me.SendPropertyChanged("itemID")
				Me.OnitemIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_name", DbType:="VarChar(255) NOT NULL", CanBeNull:=false)>  _
	Public Property name() As String
		Get
			Return Me._name
		End Get
		Set
			If (String.Equals(Me._name, value) = false) Then
				Me.OnnameChanging(value)
				Me.SendPropertyChanging
				Me._name = value
				Me.SendPropertyChanged("name")
				Me.OnnameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_description", DbType:="VarChar(255) NOT NULL", CanBeNull:=false)>  _
	Public Property description() As String
		Get
			Return Me._description
		End Get
		Set
			If (String.Equals(Me._description, value) = false) Then
				Me.OndescriptionChanging(value)
				Me.SendPropertyChanging
				Me._description = value
				Me.SendPropertyChanged("description")
				Me.OndescriptionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_price", DbType:="Float NOT NULL")>  _
	Public Property price() As Double
		Get
			Return Me._price
		End Get
		Set
			If ((Me._price = value)  _
						= false) Then
				Me.OnpriceChanging(value)
				Me.SendPropertyChanging
				Me._price = value
				Me.SendPropertyChanged("price")
				Me.OnpriceChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_stockQuantity", DbType:="Int NOT NULL")>  _
	Public Property stockQuantity() As Integer
		Get
			Return Me._stockQuantity
		End Get
		Set
			If ((Me._stockQuantity = value)  _
						= false) Then
				Me.OnstockQuantityChanging(value)
				Me.SendPropertyChanging
				Me._stockQuantity = value
				Me.SendPropertyChanged("stockQuantity")
				Me.OnstockQuantityChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_createdOn", DbType:="Date NOT NULL")>  _
	Public Property createdOn() As Date
		Get
			Return Me._createdOn
		End Get
		Set
			If ((Me._createdOn = value)  _
						= false) Then
				Me.OncreatedOnChanging(value)
				Me.SendPropertyChanging
				Me._createdOn = value
				Me.SendPropertyChanged("createdOn")
				Me.OncreatedOnChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_lastUpdate", DbType:="Date")>  _
	Public Property lastUpdate() As System.Nullable(Of Date)
		Get
			Return Me._lastUpdate
		End Get
		Set
			If (Me._lastUpdate.Equals(value) = false) Then
				Me.OnlastUpdateChanging(value)
				Me.SendPropertyChanging
				Me._lastUpdate = value
				Me.SendPropertyChanged("lastUpdate")
				Me.OnlastUpdateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_categoryID", DbType:="Int NOT NULL")>  _
	Public Property categoryID() As Integer
		Get
			Return Me._categoryID
		End Get
		Set
			If ((Me._categoryID = value)  _
						= false) Then
				If Me._Category.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OncategoryIDChanging(value)
				Me.SendPropertyChanging
				Me._categoryID = value
				Me.SendPropertyChanged("categoryID")
				Me.OncategoryIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_status", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property status() As String
		Get
			Return Me._status
		End Get
		Set
			If (String.Equals(Me._status, value) = false) Then
				Me.OnstatusChanging(value)
				Me.SendPropertyChanging
				Me._status = value
				Me.SendPropertyChanged("status")
				Me.OnstatusChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Item_ItemSale", Storage:="_ItemSales", ThisKey:="itemID", OtherKey:="itemID")>  _
	Public Property ItemSales() As EntitySet(Of ItemSale)
		Get
			Return Me._ItemSales
		End Get
		Set
			Me._ItemSales.Assign(value)
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Category_Item", Storage:="_Category", ThisKey:="categoryID", OtherKey:="categoryID", IsForeignKey:=true)>  _
	Public Property Category() As Category
		Get
			Return Me._Category.Entity
		End Get
		Set
			Dim previousValue As Category = Me._Category.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Category.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Category.Entity = Nothing
					previousValue.Items.Remove(Me)
				End If
				Me._Category.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Items.Add(Me)
					Me._categoryID = value.categoryID
				Else
					Me._categoryID = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("Category")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_ItemSales(ByVal entity As ItemSale)
		Me.SendPropertyChanging
		entity.Item = Me
	End Sub
	
	Private Sub detach_ItemSales(ByVal entity As ItemSale)
		Me.SendPropertyChanging
		entity.Item = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.ItemSales")>  _
Partial Public Class ItemSale
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _transactionID As String
	
	Private _itemID As String
	
	Private _quantity As Integer
	
	Private _subtotal As Double
	
	Private _Item As EntityRef(Of Item)
	
	Private _Transaction As EntityRef(Of Transaction)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OntransactionIDChanging(value As String)
    End Sub
    Partial Private Sub OntransactionIDChanged()
    End Sub
    Partial Private Sub OnitemIDChanging(value As String)
    End Sub
    Partial Private Sub OnitemIDChanged()
    End Sub
    Partial Private Sub OnquantityChanging(value As Integer)
    End Sub
    Partial Private Sub OnquantityChanged()
    End Sub
    Partial Private Sub OnsubtotalChanging(value As Double)
    End Sub
    Partial Private Sub OnsubtotalChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Item = CType(Nothing, EntityRef(Of Item))
		Me._Transaction = CType(Nothing, EntityRef(Of Transaction))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_transactionID", DbType:="VarChar(10) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property transactionID() As String
		Get
			Return Me._transactionID
		End Get
		Set
			If (String.Equals(Me._transactionID, value) = false) Then
				If Me._Transaction.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OntransactionIDChanging(value)
				Me.SendPropertyChanging
				Me._transactionID = value
				Me.SendPropertyChanged("transactionID")
				Me.OntransactionIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_itemID", DbType:="VarChar(10) NOT NULL", CanBeNull:=false)>  _
	Public Property itemID() As String
		Get
			Return Me._itemID
		End Get
		Set
			If (String.Equals(Me._itemID, value) = false) Then
				If Me._Item.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnitemIDChanging(value)
				Me.SendPropertyChanging
				Me._itemID = value
				Me.SendPropertyChanged("itemID")
				Me.OnitemIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_quantity", DbType:="Int NOT NULL")>  _
	Public Property quantity() As Integer
		Get
			Return Me._quantity
		End Get
		Set
			If ((Me._quantity = value)  _
						= false) Then
				Me.OnquantityChanging(value)
				Me.SendPropertyChanging
				Me._quantity = value
				Me.SendPropertyChanged("quantity")
				Me.OnquantityChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_subtotal", DbType:="Float NOT NULL")>  _
	Public Property subtotal() As Double
		Get
			Return Me._subtotal
		End Get
		Set
			If ((Me._subtotal = value)  _
						= false) Then
				Me.OnsubtotalChanging(value)
				Me.SendPropertyChanging
				Me._subtotal = value
				Me.SendPropertyChanged("subtotal")
				Me.OnsubtotalChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Item_ItemSale", Storage:="_Item", ThisKey:="itemID", OtherKey:="itemID", IsForeignKey:=true)>  _
	Public Property Item() As Item
		Get
			Return Me._Item.Entity
		End Get
		Set
			Dim previousValue As Item = Me._Item.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Item.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Item.Entity = Nothing
					previousValue.ItemSales.Remove(Me)
				End If
				Me._Item.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.ItemSales.Add(Me)
					Me._itemID = value.itemID
				Else
					Me._itemID = CType(Nothing, String)
				End If
				Me.SendPropertyChanged("Item")
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Transaction_ItemSale", Storage:="_Transaction", ThisKey:="transactionID", OtherKey:="transactionID", IsForeignKey:=true)>  _
	Public Property Transaction() As Transaction
		Get
			Return Me._Transaction.Entity
		End Get
		Set
			Dim previousValue As Transaction = Me._Transaction.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Transaction.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Transaction.Entity = Nothing
					previousValue.ItemSale = Nothing
				End If
				Me._Transaction.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.ItemSale = Me
					Me._transactionID = value.transactionID
				Else
					Me._transactionID = CType(Nothing, String)
				End If
				Me.SendPropertyChanged("Transaction")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Staff")>  _
Partial Public Class Staff
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _staffID As String
	
	Private _name As String
	
	Private _password As String
	
	Private _registeredOn As Date
	
	Private _lastLogin As System.Nullable(Of Date)
	
	Private _position As Integer
	
	Private _Transactions As EntitySet(Of Transaction)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnstaffIDChanging(value As String)
    End Sub
    Partial Private Sub OnstaffIDChanged()
    End Sub
    Partial Private Sub OnnameChanging(value As String)
    End Sub
    Partial Private Sub OnnameChanged()
    End Sub
    Partial Private Sub OnpasswordChanging(value As String)
    End Sub
    Partial Private Sub OnpasswordChanged()
    End Sub
    Partial Private Sub OnregisteredOnChanging(value As Date)
    End Sub
    Partial Private Sub OnregisteredOnChanged()
    End Sub
    Partial Private Sub OnlastLoginChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnlastLoginChanged()
    End Sub
    Partial Private Sub OnpositionChanging(value As Integer)
    End Sub
    Partial Private Sub OnpositionChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Transactions = New EntitySet(Of Transaction)(AddressOf Me.attach_Transactions, AddressOf Me.detach_Transactions)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_staffID", DbType:="VarChar(10) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property staffID() As String
		Get
			Return Me._staffID
		End Get
		Set
			If (String.Equals(Me._staffID, value) = false) Then
				Me.OnstaffIDChanging(value)
				Me.SendPropertyChanging
				Me._staffID = value
				Me.SendPropertyChanged("staffID")
				Me.OnstaffIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_name", DbType:="VarChar(255) NOT NULL", CanBeNull:=false)>  _
	Public Property name() As String
		Get
			Return Me._name
		End Get
		Set
			If (String.Equals(Me._name, value) = false) Then
				Me.OnnameChanging(value)
				Me.SendPropertyChanging
				Me._name = value
				Me.SendPropertyChanged("name")
				Me.OnnameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_password", DbType:="VarChar(255) NOT NULL", CanBeNull:=false)>  _
	Public Property password() As String
		Get
			Return Me._password
		End Get
		Set
			If (String.Equals(Me._password, value) = false) Then
				Me.OnpasswordChanging(value)
				Me.SendPropertyChanging
				Me._password = value
				Me.SendPropertyChanged("password")
				Me.OnpasswordChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_registeredOn", DbType:="Date NOT NULL")>  _
	Public Property registeredOn() As Date
		Get
			Return Me._registeredOn
		End Get
		Set
			If ((Me._registeredOn = value)  _
						= false) Then
				Me.OnregisteredOnChanging(value)
				Me.SendPropertyChanging
				Me._registeredOn = value
				Me.SendPropertyChanged("registeredOn")
				Me.OnregisteredOnChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_lastLogin", DbType:="Date")>  _
	Public Property lastLogin() As System.Nullable(Of Date)
		Get
			Return Me._lastLogin
		End Get
		Set
			If (Me._lastLogin.Equals(value) = false) Then
				Me.OnlastLoginChanging(value)
				Me.SendPropertyChanging
				Me._lastLogin = value
				Me.SendPropertyChanged("lastLogin")
				Me.OnlastLoginChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_position", DbType:="Int NOT NULL")>  _
	Public Property position() As Integer
		Get
			Return Me._position
		End Get
		Set
			If ((Me._position = value)  _
						= false) Then
				Me.OnpositionChanging(value)
				Me.SendPropertyChanging
				Me._position = value
				Me.SendPropertyChanged("position")
				Me.OnpositionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Staff_Transaction", Storage:="_Transactions", ThisKey:="staffID", OtherKey:="staffID")>  _
	Public Property Transactions() As EntitySet(Of Transaction)
		Get
			Return Me._Transactions
		End Get
		Set
			Me._Transactions.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_Transactions(ByVal entity As Transaction)
		Me.SendPropertyChanging
		entity.Staff = Me
	End Sub
	
	Private Sub detach_Transactions(ByVal entity As Transaction)
		Me.SendPropertyChanging
		entity.Staff = Nothing
	End Sub
End Class
