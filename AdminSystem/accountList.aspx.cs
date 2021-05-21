using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccountCollection;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayAccount();
        }
    }
    void DisplayAccount()
    {
       
        clsAccountCollection Account = new clsAccountCollection();
        lstResult.DataSource = Account.AccountList;
        lstResult.DataValueField = "CustID";
        lstResult.DataTextField = "CustAddress";
        lstResult.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustID"] = -1;
        //redirect to the data entry page
        Response.Redirect("accountDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CustID;
        if (lstResult.SelectedIndex != -1)
        {
            CustID = Convert.ToInt32(lstResult.SelectedValue);
            Session["CustID"] = CustID;
            Response.Redirect("accountConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete.";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CustID;
        if (lstResult.SelectedIndex != -1)
        {
            CustID = Convert.ToInt32(lstResult.SelectedValue);
            Session["CustID"] = CustID;
            Response.Redirect("accountDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsAccountCollection Account = new clsAccountCollection();
        Account.ReportByCustAddress(txtSearch.Text);
        lstResult.DataSource = Account.AccountList;
        lstResult.DataValueField = "CustID";
        lstResult.DataValueField = "CustAddress";
        lstResult.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsAccountCollection Account = new clsAccountCollection();
        Account.ReportByCustAddress("");
        txtSearch.Text = "";
        lstResult.DataSource = Account.AccountList;
        lstResult.DataValueField = "CustID";
        lstResult.DataValueField = "CustAddress";
        lstResult.DataBind();
    }
}