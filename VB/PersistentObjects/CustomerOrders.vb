Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.Xpo

Namespace PersistentObjects
	<NonPersistent>
	Public Class MyBaseObject
		Inherits XPObject

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
	End Class

	Public Class Customer
		Inherits MyBaseObject

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Private _CompanyName As String
		Public Property CompanyName() As String
			Get
				Return _CompanyName
			End Get
			Set(ByVal value As String)
				SetPropertyValue("CompanyName", _CompanyName, value)
			End Set
		End Property

		Private _ContactName As String
		Public Property ContactName() As String
			Get
				Return _ContactName
			End Get
			Set(ByVal value As String)
				SetPropertyValue("ContactName", _ContactName, value)
			End Set
		End Property

		Private _Country As String
		Public Property Country() As String
			Get
				Return _Country
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Country", _Country, value)
			End Set
		End Property

		Private _Phone As String
		Public Property Phone() As String
			Get
				Return _Phone
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Phone", _Phone, value)
			End Set
		End Property

		<Association("Customer-Orders")>
		Public ReadOnly Property Orders() As XPCollection(Of Order)
			Get
				Return GetCollection(Of Order)("Orders")
			End Get
		End Property
	End Class

	Public Class Order
		Inherits MyBaseObject

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Private _OrderDate As Date
		Public Property OrderDate() As Date
			Get
				Return _OrderDate
			End Get
			Set(ByVal value As Date)
				SetPropertyValue("OrderDate", _OrderDate, value)
			End Set
		End Property

		Private _PaidTotal As Decimal
		Public Property PaidTotal() As Decimal
			Get
				Return _PaidTotal
			End Get
			Set(ByVal value As Decimal)
				SetPropertyValue("PaidTotal", _PaidTotal, value)
			End Set
		End Property

		Private _Customer As Customer

		<Association("Customer-Orders")>
		Public Property Customer() As Customer
			Get
				Return _Customer
			End Get
			Set(ByVal value As Customer)
				SetPropertyValue("Customer", _Customer, value)
			End Set
		End Property
	End Class
End Namespace
