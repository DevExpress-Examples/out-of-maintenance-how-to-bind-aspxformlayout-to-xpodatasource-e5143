<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="XpoWebApplication._Default" %>

<%@ Register Assembly="DevExpress.Web.v17.1, Version=17.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v17.1, Version=17.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web" TagPrefix="dxwgv" %>
<%@ Register Assembly="DevExpress.Web.v17.1, Version=17.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web" TagPrefix="dxe" %>

<%@ Register Assembly="DevExpress.Xpo.v17.1, Version=17.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Xpo" TagPrefix="dxxpo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">

		<dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" DataSourceID="XpoDataSource1">
			<Items>
				<dx:LayoutItem FieldName="Oid">
					<LayoutItemNestedControlCollection>
						<dx:LayoutItemNestedControlContainer runat="server">
							<dxe:ASPxComboBox ID="navigateComboBox" runat="server" AutoPostBack="True" ValueType="System.Int32" ValueField="Oid" TextField="Oid" DataSourceID="XpoDataSource2" SelectedIndex="0">
							</dxe:ASPxComboBox>
						</dx:LayoutItemNestedControlContainer>
					</LayoutItemNestedControlCollection>
				</dx:LayoutItem>
				<dx:LayoutItem FieldName="CompanyName">
					<LayoutItemNestedControlCollection>
						<dx:LayoutItemNestedControlContainer runat="server">
							<dxe:ASPxTextBox ID="ASPxFormLayout1_E2" runat="server">
							</dxe:ASPxTextBox>
						</dx:LayoutItemNestedControlContainer>
					</LayoutItemNestedControlCollection>
				</dx:LayoutItem>
				<dx:LayoutItem FieldName="ContactName">
					<LayoutItemNestedControlCollection>
						<dx:LayoutItemNestedControlContainer runat="server">
							<dxe:ASPxTextBox ID="ASPxFormLayout1_E3" runat="server">
							</dxe:ASPxTextBox>
						</dx:LayoutItemNestedControlContainer>
					</LayoutItemNestedControlCollection>
				</dx:LayoutItem>
				<dx:LayoutItem FieldName="Country">
					<LayoutItemNestedControlCollection>
						<dx:LayoutItemNestedControlContainer runat="server">
							<dxe:ASPxTextBox ID="ASPxFormLayout1_E4" runat="server">
							</dxe:ASPxTextBox>
						</dx:LayoutItemNestedControlContainer>
					</LayoutItemNestedControlCollection>
				</dx:LayoutItem>
				<dx:LayoutItem FieldName="Phone">
					<LayoutItemNestedControlCollection>
						<dx:LayoutItemNestedControlContainer runat="server">
							<dxe:ASPxTextBox ID="ASPxFormLayout1_E5" runat="server">
							</dxe:ASPxTextBox>
						</dx:LayoutItemNestedControlContainer>
					</LayoutItemNestedControlCollection>
				</dx:LayoutItem>
			</Items>
		</dx:ASPxFormLayout>
		<dxe:ASPxButton ID="ASPxButton1" runat="server" Text="Update" AutoPostBack="false" OnClick="ASPxButton1_Click">
		</dxe:ASPxButton>
		<dxxpo:XpoDataSource ID="XpoDataSource1" runat="server" TypeName="PersistentObjects.Customer" Criteria="[Oid] = ?">
			<CriteriaParameters>
				<asp:ControlParameter ControlID="ASPxFormLayout1$navigateComboBox" Name="Oid" DefaultValue="1" PropertyName="Value" Type="Int32" />
			</CriteriaParameters>
		</dxxpo:XpoDataSource>
		<dxxpo:XpoDataSource ID="XpoDataSource2" runat="server" TypeName="PersistentObjects.Customer">
		</dxxpo:XpoDataSource>

	</form>
</body>
</html>