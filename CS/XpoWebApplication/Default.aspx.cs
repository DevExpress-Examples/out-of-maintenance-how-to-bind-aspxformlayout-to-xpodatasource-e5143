using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Xpo;
using DevExpress.Web;
using PersistentObjects;
using DevExpress.Data.Filtering;

namespace XpoWebApplication
{
    public partial class _Default : System.Web.UI.Page
    {

        protected void Page_Init(object sender, EventArgs e)
        {
            Session session = XpoHelper.GetNewSession();
            XpoDataSource1.Session = session;
            XpoDataSource2.Session = session;
        }

        protected void ASPxButton1_Click(object sender, EventArgs e)
        {
            Customer cust = XpoDataSource1.Session.GetObjectByKey<Customer>(navigateComboBox.Value);
            if (cust == null)
                cust = new Customer(XpoDataSource1.Session);
            cust.CompanyName = ((ASPxTextBox)ASPxFormLayout1.FindNestedControlByFieldName("CompanyName")).Text;
            cust.ContactName = ((ASPxTextBox)ASPxFormLayout1.FindNestedControlByFieldName("ContactName")).Text;
            cust.Country = ((ASPxTextBox)ASPxFormLayout1.FindNestedControlByFieldName("Country")).Text;
            cust.Phone = ((ASPxTextBox)ASPxFormLayout1.FindNestedControlByFieldName("Phone")).Text;
            cust.Save();
            navigateComboBox.Value = cust.Oid;
        }
    }
}
