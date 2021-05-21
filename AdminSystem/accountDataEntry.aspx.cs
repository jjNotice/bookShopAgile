using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccountCollection;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustID_;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustID_ = Convert.ToInt32(Session["CustID"]);
        if (IsPostBack == false)
        {
            if (CustID_ != -1)
            {
                DisplayAccount();
            }
        }
    }

    private void DisplayAccount()
    {
        clsAccountCollection TheAccount = new clsAccountCollection();
        TheAccount.ThisAccount.Find(CustID_);
        txtCustID.Text = TheAccount.ThisAccount.CustID.ToString();
        txtCustFName.Text = TheAccount.ThisAccount.CustFName.ToString();
        txtCustSName.Text = TheAccount.ThisAccount.CustSName;
        txtCustPhone.Text = TheAccount.ThisAccount.CustPhone.ToString();
        txtCustAddress.Text = TheAccount.ThisAccount.CustAddress.ToString();
        txtJoinDate.Text = TheAccount.ThisAccount.JoinDate.ToString();
        chkNewsletterSub.Checked = TheAccount.ThisAccount.NewsLetterSub;
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsAccount Account = new clsAccount();
        Int32 AccountID;
        Boolean Found = false;
        AccountID = Convert.ToInt32(txtCustID.Text);
        Found = Account.Find(AccountID);
        if (Found == true)
        {
            txtCustID.Text = Account.CustID.ToString();
            txtCustFName.Text = Account.CustFName;
            txtCustSName.Text = Account.CustSName;
            txtCustAddress.Text = Account.CustAddress.ToString();
            txtJoinDate.Text = Account.JoinDate.ToString();
            txtCustPhone.Text = Account.CustPhone.ToString();
            lblError.Text = "";
        }
        else
        {
            lblError.Text = "Error. No such record exists!";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("accountList.aspx");
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsAccounts
        clsAccount Account = new clsAccount();
        string CustID = txtCustID.Text;
        string CustFName = txtCustFName.Text;
        string CustSName = txtCustSName.Text;
        string CustAddress = txtCustAddress.Text;
        string JoinDate = txtJoinDate.Text;
        string CustPhone = txtCustPhone.Text;
        string Error = "";

        ///////////////
        Error = Account.Valid(CustFName, CustSName, CustAddress, JoinDate, CustPhone);
        if (Error == "")
        {
            Account.CustID = Int32.Parse(CustID);
            Account.CustFName = CustFName;
            Account.CustSName = CustSName;
            Account.CustAddress = CustAddress;
            Account.JoinDate = Convert.ToDateTime(JoinDate);
            Account.NewsLetterSub = chkNewsletterSub.Checked;
            Account.CustPhone = long.Parse(CustPhone);
            clsAccountCollection AccountList = new clsAccountCollection();
            if (CustID_ == -1)
            {
                AccountList.ThisAccount = Account;
                AccountList.Add();
            }
            else
            {
                AccountList.ThisAccount.Find(CustID_);
                AccountList.ThisAccount = Account;
                AccountList.Update();
            }
            Response.Redirect("accountList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }
}