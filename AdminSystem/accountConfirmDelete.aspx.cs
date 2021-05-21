using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccountCollection;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 CustID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustID = Convert.ToInt32(Session["CustID"]);
    }

    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        clsAccountCollection TheAccounts = new clsAccountCollection();
        TheAccounts.ThisAccount.Find(CustID);
        TheAccounts.Delete();
        Response.Redirect("AccountList.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AccountList.aspx");
    }
}