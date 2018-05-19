Imports Microsoft.VisualBasic
	Imports System
	Imports DevExpress.Xpo
Namespace Northwind

	<Persistent("Customers")> _
	Public Class Customer
		Inherits XPLiteObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Private _customerID As String

		<Key> _
		Public Property CustomerID() As String
			Get
				Return _customerID
			End Get
			Set(ByVal value As String)
				SetPropertyValue("CustomerID", _customerID, value)
			End Set
		End Property

		Private _contactTitle As String
		Public Property ContactTitle() As String
			Get
				Return _contactTitle
			End Get
			Set(ByVal value As String)
				SetPropertyValue("ContactTitle", _contactTitle, value)
			End Set
		End Property

		Private _companyName As String
		Public Property CompanyName() As String
			Get
				Return _companyName
			End Get
			Set(ByVal value As String)
				SetPropertyValue("CompanyName", _companyName, value)
			End Set
		End Property

	Private _address As String
		Public Property Address() As String
			Get
				Return _address
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Address", _address, value)
			End Set
		End Property

		<Association("CustomerOrders", GetType(Order))> _
		Public ReadOnly Property Orders() As XPCollection(Of Order)
			Get
				Return GetCollection(Of Order)("Orders")
			End Get
		End Property
	End Class

	<Persistent("Orders")> _
	Public Class Order
		Inherits XPLiteObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		<Key(True), Persistent> _
		Private OrderID As Integer = -1

		<PersistentAlias("OrderID")> _
		Public ReadOnly Property ID() As Integer
			Get
				Return OrderID
			End Get
		End Property

		Private _OrderDate As DateTime
		Public Property OrderDate() As DateTime
			Get
				Return _OrderDate
			End Get
			Set(ByVal value As DateTime)
				SetPropertyValue("OrderDate", _OrderDate, value)
			End Set
		End Property

		<PersistentAlias("Custom('GetMonth', [OrderDate])")> _
		Public ReadOnly Property OrderMonth() As Integer
			Get
				' .NET implementation of the custom function (GetMonth)
				Return OrderDate.Month
			End Get
		End Property

		Private _customer As Customer
		<Persistent("CustomerID"), Association("CustomerOrders")> _
		Public Property Customer() As Customer
			Get
				Return _customer
			End Get
			Set(ByVal value As Customer)
				SetPropertyValue("Customer", _customer, value)
			End Set
		End Property

		Private _Employer As Employee
		<Persistent("EmployeeID")> _
		Public Property Employee() As Employee
			Get
				Return _Employer
			End Get
			Set(ByVal value As Employee)
				SetPropertyValue("Employer", _Employer, value)
			End Set
		End Property
	End Class

	<Persistent("Employees")> _
	Public Class Employee
		Inherits XPLiteObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		<Key(True), Persistent> _
		Public EmployeeID As Integer

		Private _FirstName As String
		Public Property FirstName() As String
			Get
				Return _FirstName
			End Get
			Set(ByVal value As String)
				SetPropertyValue("FirstName", _FirstName, value)
			End Set
		End Property
		Private _LastName As String
		Public Property LastName() As String
			Get
				Return _LastName
			End Get
			Set(ByVal value As String)
				SetPropertyValue("LastName", _LastName, value)
			End Set
		End Property

		<PersistentAlias("Concat([FirstName], ' ', [LastName])")> _
		Public ReadOnly Property FullName() As String
			Get
				Return CStr(EvaluateAlias("FullName"))
			End Get
		End Property
	End Class
End Namespace
