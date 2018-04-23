Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Xpo
Imports DevExpress.Web
Imports PersistentObjects
Imports DevExpress.Data.Filtering

Namespace XpoWebApplication
	Partial Public Class _Default
		Inherits System.Web.UI.Page

		Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
            Dim xpoSession As Session = XpoHelper.GetNewSession()
            XpoDataSource1.Session = xpoSession
            XpoDataSource2.Session = xpoSession
		End Sub

		Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim cust As Customer = XpoDataSource1.Session.GetObjectByKey(Of Customer)(navigateComboBox.Value)
			If cust Is Nothing Then
				cust = New Customer(XpoDataSource1.Session)
			End If
			cust.CompanyName = CType(ASPxFormLayout1.FindNestedControlByFieldName("CompanyName"), ASPxTextBox).Text
			cust.ContactName = CType(ASPxFormLayout1.FindNestedControlByFieldName("ContactName"), ASPxTextBox).Text
			cust.Country = CType(ASPxFormLayout1.FindNestedControlByFieldName("Country"), ASPxTextBox).Text
			cust.Phone = CType(ASPxFormLayout1.FindNestedControlByFieldName("Phone"), ASPxTextBox).Text
			cust.Save()
			navigateComboBox.Value = cust.Oid
		End Sub
	End Class
End Namespace
